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
    /// <summary>Settings for <see cref="TargetSslProxiesClient"/> instances.</summary>
    public sealed partial class TargetSslProxiesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="TargetSslProxiesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="TargetSslProxiesSettings"/>.</returns>
        public static TargetSslProxiesSettings GetDefault() => new TargetSslProxiesSettings();

        /// <summary>Constructs a new <see cref="TargetSslProxiesSettings"/> object with default settings.</summary>
        public TargetSslProxiesSettings()
        {
        }

        private TargetSslProxiesSettings(TargetSslProxiesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            DeleteSettings = existing.DeleteSettings;
            GetSettings = existing.GetSettings;
            InsertSettings = existing.InsertSettings;
            ListSettings = existing.ListSettings;
            SetBackendServiceSettings = existing.SetBackendServiceSettings;
            SetProxyHeaderSettings = existing.SetProxyHeaderSettings;
            SetSslCertificatesSettings = existing.SetSslCertificatesSettings;
            SetSslPolicySettings = existing.SetSslPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(TargetSslProxiesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TargetSslProxiesClient.Delete</c> and <c>TargetSslProxiesClient.DeleteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>TargetSslProxiesClient.Get</c>
        ///  and <c>TargetSslProxiesClient.GetAsync</c>.
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
        /// <c>TargetSslProxiesClient.Insert</c> and <c>TargetSslProxiesClient.InsertAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InsertSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>TargetSslProxiesClient.List</c>
        ///  and <c>TargetSslProxiesClient.ListAsync</c>.
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
        /// <c>TargetSslProxiesClient.SetBackendService</c> and <c>TargetSslProxiesClient.SetBackendServiceAsync</c>.
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
        /// <c>TargetSslProxiesClient.SetProxyHeader</c> and <c>TargetSslProxiesClient.SetProxyHeaderAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetProxyHeaderSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TargetSslProxiesClient.SetSslCertificates</c> and <c>TargetSslProxiesClient.SetSslCertificatesAsync</c>.
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
        /// <c>TargetSslProxiesClient.SetSslPolicy</c> and <c>TargetSslProxiesClient.SetSslPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetSslPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="TargetSslProxiesSettings"/> object.</returns>
        public TargetSslProxiesSettings Clone() => new TargetSslProxiesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="TargetSslProxiesClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class TargetSslProxiesClientBuilder : gaxgrpc::ClientBuilderBase<TargetSslProxiesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public TargetSslProxiesSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public TargetSslProxiesClientBuilder()
        {
            UseJwtAccessWithScopes = TargetSslProxiesClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref TargetSslProxiesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<TargetSslProxiesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override TargetSslProxiesClient Build()
        {
            TargetSslProxiesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<TargetSslProxiesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<TargetSslProxiesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private TargetSslProxiesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return TargetSslProxiesClient.Create(callInvoker, Settings);
        }

        private async stt::Task<TargetSslProxiesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return TargetSslProxiesClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => TargetSslProxiesClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => TargetSslProxiesClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => TargetSslProxiesClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => ComputeRestAdapter.ComputeAdapter;
    }

    /// <summary>TargetSslProxies client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The TargetSslProxies API.
    /// </remarks>
    public abstract partial class TargetSslProxiesClient
    {
        /// <summary>
        /// The default endpoint for the TargetSslProxies service, which is a host of "compute.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default TargetSslProxies scopes.</summary>
        /// <remarks>
        /// The default TargetSslProxies scopes are:
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
        /// Asynchronously creates a <see cref="TargetSslProxiesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TargetSslProxiesClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="TargetSslProxiesClient"/>.</returns>
        public static stt::Task<TargetSslProxiesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new TargetSslProxiesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="TargetSslProxiesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TargetSslProxiesClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="TargetSslProxiesClient"/>.</returns>
        public static TargetSslProxiesClient Create() => new TargetSslProxiesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="TargetSslProxiesClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="TargetSslProxiesSettings"/>.</param>
        /// <returns>The created <see cref="TargetSslProxiesClient"/>.</returns>
        internal static TargetSslProxiesClient Create(grpccore::CallInvoker callInvoker, TargetSslProxiesSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            TargetSslProxies.TargetSslProxiesClient grpcClient = new TargetSslProxies.TargetSslProxiesClient(callInvoker);
            return new TargetSslProxiesClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC TargetSslProxies client</summary>
        public virtual TargetSslProxies.TargetSslProxiesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified TargetSslProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Delete(DeleteTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified TargetSslProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(DeleteTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified TargetSslProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(DeleteTargetSslProxyRequest request, st::CancellationToken cancellationToken) =>
            DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified TargetSslProxy resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxy">
        /// Name of the TargetSslProxy resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Delete(string project, string targetSslProxy, gaxgrpc::CallSettings callSettings = null) =>
            Delete(new DeleteTargetSslProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetSslProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetSslProxy, nameof(targetSslProxy)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified TargetSslProxy resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxy">
        /// Name of the TargetSslProxy resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(string project, string targetSslProxy, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAsync(new DeleteTargetSslProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetSslProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetSslProxy, nameof(targetSslProxy)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified TargetSslProxy resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxy">
        /// Name of the TargetSslProxy resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> DeleteAsync(string project, string targetSslProxy, st::CancellationToken cancellationToken) =>
            DeleteAsync(project, targetSslProxy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified TargetSslProxy resource. Gets a list of available target SSL proxies by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TargetSslProxy Get(GetTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified TargetSslProxy resource. Gets a list of available target SSL proxies by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetSslProxy> GetAsync(GetTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified TargetSslProxy resource. Gets a list of available target SSL proxies by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetSslProxy> GetAsync(GetTargetSslProxyRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified TargetSslProxy resource. Gets a list of available target SSL proxies by making a list() request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxy">
        /// Name of the TargetSslProxy resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TargetSslProxy Get(string project, string targetSslProxy, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetTargetSslProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetSslProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetSslProxy, nameof(targetSslProxy)),
            }, callSettings);

        /// <summary>
        /// Returns the specified TargetSslProxy resource. Gets a list of available target SSL proxies by making a list() request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxy">
        /// Name of the TargetSslProxy resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetSslProxy> GetAsync(string project, string targetSslProxy, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetTargetSslProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetSslProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetSslProxy, nameof(targetSslProxy)),
            }, callSettings);

        /// <summary>
        /// Returns the specified TargetSslProxy resource. Gets a list of available target SSL proxies by making a list() request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxy">
        /// Name of the TargetSslProxy resource to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetSslProxy> GetAsync(string project, string targetSslProxy, st::CancellationToken cancellationToken) =>
            GetAsync(project, targetSslProxy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a TargetSslProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Insert(InsertTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a TargetSslProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(InsertTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a TargetSslProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(InsertTargetSslProxyRequest request, st::CancellationToken cancellationToken) =>
            InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a TargetSslProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation Insert(string project, TargetSslProxy targetSslProxyResource, gaxgrpc::CallSettings callSettings = null) =>
            Insert(new InsertTargetSslProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetSslProxyResource = gax::GaxPreconditions.CheckNotNull(targetSslProxyResource, nameof(targetSslProxyResource)),
            }, callSettings);

        /// <summary>
        /// Creates a TargetSslProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(string project, TargetSslProxy targetSslProxyResource, gaxgrpc::CallSettings callSettings = null) =>
            InsertAsync(new InsertTargetSslProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetSslProxyResource = gax::GaxPreconditions.CheckNotNull(targetSslProxyResource, nameof(targetSslProxyResource)),
            }, callSettings);

        /// <summary>
        /// Creates a TargetSslProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> InsertAsync(string project, TargetSslProxy targetSslProxyResource, st::CancellationToken cancellationToken) =>
            InsertAsync(project, targetSslProxyResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the list of TargetSslProxy resources available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TargetSslProxy"/> resources.</returns>
        public virtual gax::PagedEnumerable<TargetSslProxyList, TargetSslProxy> List(ListTargetSslProxiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of TargetSslProxy resources available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TargetSslProxy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<TargetSslProxyList, TargetSslProxy> ListAsync(ListTargetSslProxiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of TargetSslProxy resources available to the specified project.
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
        /// <returns>A pageable sequence of <see cref="TargetSslProxy"/> resources.</returns>
        public virtual gax::PagedEnumerable<TargetSslProxyList, TargetSslProxy> List(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            List(new ListTargetSslProxiesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Retrieves the list of TargetSslProxy resources available to the specified project.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TargetSslProxy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<TargetSslProxyList, TargetSslProxy> ListAsync(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAsync(new ListTargetSslProxiesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Changes the BackendService for TargetSslProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetBackendService(SetBackendServiceTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes the BackendService for TargetSslProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetBackendServiceAsync(SetBackendServiceTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes the BackendService for TargetSslProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetBackendServiceAsync(SetBackendServiceTargetSslProxyRequest request, st::CancellationToken cancellationToken) =>
            SetBackendServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Changes the BackendService for TargetSslProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxy">
        /// Name of the TargetSslProxy resource whose BackendService resource is to be set.
        /// </param>
        /// <param name="targetSslProxiesSetBackendServiceRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetBackendService(string project, string targetSslProxy, TargetSslProxiesSetBackendServiceRequest targetSslProxiesSetBackendServiceRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetBackendService(new SetBackendServiceTargetSslProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetSslProxiesSetBackendServiceRequestResource = gax::GaxPreconditions.CheckNotNull(targetSslProxiesSetBackendServiceRequestResource, nameof(targetSslProxiesSetBackendServiceRequestResource)),
                TargetSslProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetSslProxy, nameof(targetSslProxy)),
            }, callSettings);

        /// <summary>
        /// Changes the BackendService for TargetSslProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxy">
        /// Name of the TargetSslProxy resource whose BackendService resource is to be set.
        /// </param>
        /// <param name="targetSslProxiesSetBackendServiceRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetBackendServiceAsync(string project, string targetSslProxy, TargetSslProxiesSetBackendServiceRequest targetSslProxiesSetBackendServiceRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetBackendServiceAsync(new SetBackendServiceTargetSslProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetSslProxiesSetBackendServiceRequestResource = gax::GaxPreconditions.CheckNotNull(targetSslProxiesSetBackendServiceRequestResource, nameof(targetSslProxiesSetBackendServiceRequestResource)),
                TargetSslProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetSslProxy, nameof(targetSslProxy)),
            }, callSettings);

        /// <summary>
        /// Changes the BackendService for TargetSslProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxy">
        /// Name of the TargetSslProxy resource whose BackendService resource is to be set.
        /// </param>
        /// <param name="targetSslProxiesSetBackendServiceRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetBackendServiceAsync(string project, string targetSslProxy, TargetSslProxiesSetBackendServiceRequest targetSslProxiesSetBackendServiceRequestResource, st::CancellationToken cancellationToken) =>
            SetBackendServiceAsync(project, targetSslProxy, targetSslProxiesSetBackendServiceRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Changes the ProxyHeaderType for TargetSslProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetProxyHeader(SetProxyHeaderTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes the ProxyHeaderType for TargetSslProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetProxyHeaderAsync(SetProxyHeaderTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes the ProxyHeaderType for TargetSslProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetProxyHeaderAsync(SetProxyHeaderTargetSslProxyRequest request, st::CancellationToken cancellationToken) =>
            SetProxyHeaderAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Changes the ProxyHeaderType for TargetSslProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxy">
        /// Name of the TargetSslProxy resource whose ProxyHeader is to be set.
        /// </param>
        /// <param name="targetSslProxiesSetProxyHeaderRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetProxyHeader(string project, string targetSslProxy, TargetSslProxiesSetProxyHeaderRequest targetSslProxiesSetProxyHeaderRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetProxyHeader(new SetProxyHeaderTargetSslProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetSslProxiesSetProxyHeaderRequestResource = gax::GaxPreconditions.CheckNotNull(targetSslProxiesSetProxyHeaderRequestResource, nameof(targetSslProxiesSetProxyHeaderRequestResource)),
                TargetSslProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetSslProxy, nameof(targetSslProxy)),
            }, callSettings);

        /// <summary>
        /// Changes the ProxyHeaderType for TargetSslProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxy">
        /// Name of the TargetSslProxy resource whose ProxyHeader is to be set.
        /// </param>
        /// <param name="targetSslProxiesSetProxyHeaderRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetProxyHeaderAsync(string project, string targetSslProxy, TargetSslProxiesSetProxyHeaderRequest targetSslProxiesSetProxyHeaderRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetProxyHeaderAsync(new SetProxyHeaderTargetSslProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetSslProxiesSetProxyHeaderRequestResource = gax::GaxPreconditions.CheckNotNull(targetSslProxiesSetProxyHeaderRequestResource, nameof(targetSslProxiesSetProxyHeaderRequestResource)),
                TargetSslProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetSslProxy, nameof(targetSslProxy)),
            }, callSettings);

        /// <summary>
        /// Changes the ProxyHeaderType for TargetSslProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxy">
        /// Name of the TargetSslProxy resource whose ProxyHeader is to be set.
        /// </param>
        /// <param name="targetSslProxiesSetProxyHeaderRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetProxyHeaderAsync(string project, string targetSslProxy, TargetSslProxiesSetProxyHeaderRequest targetSslProxiesSetProxyHeaderRequestResource, st::CancellationToken cancellationToken) =>
            SetProxyHeaderAsync(project, targetSslProxy, targetSslProxiesSetProxyHeaderRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Changes SslCertificates for TargetSslProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetSslCertificates(SetSslCertificatesTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes SslCertificates for TargetSslProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetSslCertificatesAsync(SetSslCertificatesTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes SslCertificates for TargetSslProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetSslCertificatesAsync(SetSslCertificatesTargetSslProxyRequest request, st::CancellationToken cancellationToken) =>
            SetSslCertificatesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Changes SslCertificates for TargetSslProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxy">
        /// Name of the TargetSslProxy resource whose SslCertificate resource is to be set.
        /// </param>
        /// <param name="targetSslProxiesSetSslCertificatesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetSslCertificates(string project, string targetSslProxy, TargetSslProxiesSetSslCertificatesRequest targetSslProxiesSetSslCertificatesRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetSslCertificates(new SetSslCertificatesTargetSslProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetSslProxiesSetSslCertificatesRequestResource = gax::GaxPreconditions.CheckNotNull(targetSslProxiesSetSslCertificatesRequestResource, nameof(targetSslProxiesSetSslCertificatesRequestResource)),
                TargetSslProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetSslProxy, nameof(targetSslProxy)),
            }, callSettings);

        /// <summary>
        /// Changes SslCertificates for TargetSslProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxy">
        /// Name of the TargetSslProxy resource whose SslCertificate resource is to be set.
        /// </param>
        /// <param name="targetSslProxiesSetSslCertificatesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetSslCertificatesAsync(string project, string targetSslProxy, TargetSslProxiesSetSslCertificatesRequest targetSslProxiesSetSslCertificatesRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetSslCertificatesAsync(new SetSslCertificatesTargetSslProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetSslProxiesSetSslCertificatesRequestResource = gax::GaxPreconditions.CheckNotNull(targetSslProxiesSetSslCertificatesRequestResource, nameof(targetSslProxiesSetSslCertificatesRequestResource)),
                TargetSslProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetSslProxy, nameof(targetSslProxy)),
            }, callSettings);

        /// <summary>
        /// Changes SslCertificates for TargetSslProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxy">
        /// Name of the TargetSslProxy resource whose SslCertificate resource is to be set.
        /// </param>
        /// <param name="targetSslProxiesSetSslCertificatesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetSslCertificatesAsync(string project, string targetSslProxy, TargetSslProxiesSetSslCertificatesRequest targetSslProxiesSetSslCertificatesRequestResource, st::CancellationToken cancellationToken) =>
            SetSslCertificatesAsync(project, targetSslProxy, targetSslProxiesSetSslCertificatesRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the SSL policy for TargetSslProxy. The SSL policy specifies the server-side support for SSL features. This affects connections between clients and the SSL proxy load balancer. They do not affect the connection between the load balancer and the backends.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetSslPolicy(SetSslPolicyTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the SSL policy for TargetSslProxy. The SSL policy specifies the server-side support for SSL features. This affects connections between clients and the SSL proxy load balancer. They do not affect the connection between the load balancer and the backends.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetSslPolicyAsync(SetSslPolicyTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the SSL policy for TargetSslProxy. The SSL policy specifies the server-side support for SSL features. This affects connections between clients and the SSL proxy load balancer. They do not affect the connection between the load balancer and the backends.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetSslPolicyAsync(SetSslPolicyTargetSslProxyRequest request, st::CancellationToken cancellationToken) =>
            SetSslPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the SSL policy for TargetSslProxy. The SSL policy specifies the server-side support for SSL features. This affects connections between clients and the SSL proxy load balancer. They do not affect the connection between the load balancer and the backends.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxy">
        /// Name of the TargetSslProxy resource whose SSL policy is to be set. The name must be 1-63 characters long, and comply with RFC1035.
        /// </param>
        /// <param name="sslPolicyReferenceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operation SetSslPolicy(string project, string targetSslProxy, SslPolicyReference sslPolicyReferenceResource, gaxgrpc::CallSettings callSettings = null) =>
            SetSslPolicy(new SetSslPolicyTargetSslProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                SslPolicyReferenceResource = gax::GaxPreconditions.CheckNotNull(sslPolicyReferenceResource, nameof(sslPolicyReferenceResource)),
                TargetSslProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetSslProxy, nameof(targetSslProxy)),
            }, callSettings);

        /// <summary>
        /// Sets the SSL policy for TargetSslProxy. The SSL policy specifies the server-side support for SSL features. This affects connections between clients and the SSL proxy load balancer. They do not affect the connection between the load balancer and the backends.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxy">
        /// Name of the TargetSslProxy resource whose SSL policy is to be set. The name must be 1-63 characters long, and comply with RFC1035.
        /// </param>
        /// <param name="sslPolicyReferenceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetSslPolicyAsync(string project, string targetSslProxy, SslPolicyReference sslPolicyReferenceResource, gaxgrpc::CallSettings callSettings = null) =>
            SetSslPolicyAsync(new SetSslPolicyTargetSslProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                SslPolicyReferenceResource = gax::GaxPreconditions.CheckNotNull(sslPolicyReferenceResource, nameof(sslPolicyReferenceResource)),
                TargetSslProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetSslProxy, nameof(targetSslProxy)),
            }, callSettings);

        /// <summary>
        /// Sets the SSL policy for TargetSslProxy. The SSL policy specifies the server-side support for SSL features. This affects connections between clients and the SSL proxy load balancer. They do not affect the connection between the load balancer and the backends.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetSslProxy">
        /// Name of the TargetSslProxy resource whose SSL policy is to be set. The name must be 1-63 characters long, and comply with RFC1035.
        /// </param>
        /// <param name="sslPolicyReferenceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operation> SetSslPolicyAsync(string project, string targetSslProxy, SslPolicyReference sslPolicyReferenceResource, st::CancellationToken cancellationToken) =>
            SetSslPolicyAsync(project, targetSslProxy, sslPolicyReferenceResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>TargetSslProxies client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The TargetSslProxies API.
    /// </remarks>
    public sealed partial class TargetSslProxiesClientImpl : TargetSslProxiesClient
    {
        private readonly gaxgrpc::ApiCall<DeleteTargetSslProxyRequest, Operation> _callDelete;

        private readonly gaxgrpc::ApiCall<GetTargetSslProxyRequest, TargetSslProxy> _callGet;

        private readonly gaxgrpc::ApiCall<InsertTargetSslProxyRequest, Operation> _callInsert;

        private readonly gaxgrpc::ApiCall<ListTargetSslProxiesRequest, TargetSslProxyList> _callList;

        private readonly gaxgrpc::ApiCall<SetBackendServiceTargetSslProxyRequest, Operation> _callSetBackendService;

        private readonly gaxgrpc::ApiCall<SetProxyHeaderTargetSslProxyRequest, Operation> _callSetProxyHeader;

        private readonly gaxgrpc::ApiCall<SetSslCertificatesTargetSslProxyRequest, Operation> _callSetSslCertificates;

        private readonly gaxgrpc::ApiCall<SetSslPolicyTargetSslProxyRequest, Operation> _callSetSslPolicy;

        /// <summary>
        /// Constructs a client wrapper for the TargetSslProxies service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="TargetSslProxiesSettings"/> used within this client.</param>
        public TargetSslProxiesClientImpl(TargetSslProxies.TargetSslProxiesClient grpcClient, TargetSslProxiesSettings settings)
        {
            GrpcClient = grpcClient;
            TargetSslProxiesSettings effectiveSettings = settings ?? TargetSslProxiesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callDelete = clientHelper.BuildApiCall<DeleteTargetSslProxyRequest, Operation>(grpcClient.DeleteAsync, grpcClient.Delete, effectiveSettings.DeleteSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("target_ssl_proxy", request => request.TargetSslProxy);
            Modify_ApiCall(ref _callDelete);
            Modify_DeleteApiCall(ref _callDelete);
            _callGet = clientHelper.BuildApiCall<GetTargetSslProxyRequest, TargetSslProxy>(grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("target_ssl_proxy", request => request.TargetSslProxy);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callInsert = clientHelper.BuildApiCall<InsertTargetSslProxyRequest, Operation>(grpcClient.InsertAsync, grpcClient.Insert, effectiveSettings.InsertSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callInsert);
            Modify_InsertApiCall(ref _callInsert);
            _callList = clientHelper.BuildApiCall<ListTargetSslProxiesRequest, TargetSslProxyList>(grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            _callSetBackendService = clientHelper.BuildApiCall<SetBackendServiceTargetSslProxyRequest, Operation>(grpcClient.SetBackendServiceAsync, grpcClient.SetBackendService, effectiveSettings.SetBackendServiceSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("target_ssl_proxy", request => request.TargetSslProxy);
            Modify_ApiCall(ref _callSetBackendService);
            Modify_SetBackendServiceApiCall(ref _callSetBackendService);
            _callSetProxyHeader = clientHelper.BuildApiCall<SetProxyHeaderTargetSslProxyRequest, Operation>(grpcClient.SetProxyHeaderAsync, grpcClient.SetProxyHeader, effectiveSettings.SetProxyHeaderSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("target_ssl_proxy", request => request.TargetSslProxy);
            Modify_ApiCall(ref _callSetProxyHeader);
            Modify_SetProxyHeaderApiCall(ref _callSetProxyHeader);
            _callSetSslCertificates = clientHelper.BuildApiCall<SetSslCertificatesTargetSslProxyRequest, Operation>(grpcClient.SetSslCertificatesAsync, grpcClient.SetSslCertificates, effectiveSettings.SetSslCertificatesSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("target_ssl_proxy", request => request.TargetSslProxy);
            Modify_ApiCall(ref _callSetSslCertificates);
            Modify_SetSslCertificatesApiCall(ref _callSetSslCertificates);
            _callSetSslPolicy = clientHelper.BuildApiCall<SetSslPolicyTargetSslProxyRequest, Operation>(grpcClient.SetSslPolicyAsync, grpcClient.SetSslPolicy, effectiveSettings.SetSslPolicySettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("target_ssl_proxy", request => request.TargetSslProxy);
            Modify_ApiCall(ref _callSetSslPolicy);
            Modify_SetSslPolicyApiCall(ref _callSetSslPolicy);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_DeleteApiCall(ref gaxgrpc::ApiCall<DeleteTargetSslProxyRequest, Operation> call);

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetTargetSslProxyRequest, TargetSslProxy> call);

        partial void Modify_InsertApiCall(ref gaxgrpc::ApiCall<InsertTargetSslProxyRequest, Operation> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListTargetSslProxiesRequest, TargetSslProxyList> call);

        partial void Modify_SetBackendServiceApiCall(ref gaxgrpc::ApiCall<SetBackendServiceTargetSslProxyRequest, Operation> call);

        partial void Modify_SetProxyHeaderApiCall(ref gaxgrpc::ApiCall<SetProxyHeaderTargetSslProxyRequest, Operation> call);

        partial void Modify_SetSslCertificatesApiCall(ref gaxgrpc::ApiCall<SetSslCertificatesTargetSslProxyRequest, Operation> call);

        partial void Modify_SetSslPolicyApiCall(ref gaxgrpc::ApiCall<SetSslPolicyTargetSslProxyRequest, Operation> call);

        partial void OnConstruction(TargetSslProxies.TargetSslProxiesClient grpcClient, TargetSslProxiesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC TargetSslProxies client</summary>
        public override TargetSslProxies.TargetSslProxiesClient GrpcClient { get; }

        partial void Modify_DeleteTargetSslProxyRequest(ref DeleteTargetSslProxyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTargetSslProxyRequest(ref GetTargetSslProxyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InsertTargetSslProxyRequest(ref InsertTargetSslProxyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTargetSslProxiesRequest(ref ListTargetSslProxiesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetBackendServiceTargetSslProxyRequest(ref SetBackendServiceTargetSslProxyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetProxyHeaderTargetSslProxyRequest(ref SetProxyHeaderTargetSslProxyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetSslCertificatesTargetSslProxyRequest(ref SetSslCertificatesTargetSslProxyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetSslPolicyTargetSslProxyRequest(ref SetSslPolicyTargetSslProxyRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Deletes the specified TargetSslProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Delete(DeleteTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTargetSslProxyRequest(ref request, ref callSettings);
            return _callDelete.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified TargetSslProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> DeleteAsync(DeleteTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTargetSslProxyRequest(ref request, ref callSettings);
            return _callDelete.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the specified TargetSslProxy resource. Gets a list of available target SSL proxies by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TargetSslProxy Get(GetTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTargetSslProxyRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified TargetSslProxy resource. Gets a list of available target SSL proxies by making a list() request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TargetSslProxy> GetAsync(GetTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTargetSslProxyRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a TargetSslProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation Insert(InsertTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertTargetSslProxyRequest(ref request, ref callSettings);
            return _callInsert.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a TargetSslProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> InsertAsync(InsertTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertTargetSslProxyRequest(ref request, ref callSettings);
            return _callInsert.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of TargetSslProxy resources available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TargetSslProxy"/> resources.</returns>
        public override gax::PagedEnumerable<TargetSslProxyList, TargetSslProxy> List(ListTargetSslProxiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTargetSslProxiesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTargetSslProxiesRequest, TargetSslProxyList, TargetSslProxy>(_callList, request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of TargetSslProxy resources available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TargetSslProxy"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<TargetSslProxyList, TargetSslProxy> ListAsync(ListTargetSslProxiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTargetSslProxiesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTargetSslProxiesRequest, TargetSslProxyList, TargetSslProxy>(_callList, request, callSettings);
        }

        /// <summary>
        /// Changes the BackendService for TargetSslProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation SetBackendService(SetBackendServiceTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetBackendServiceTargetSslProxyRequest(ref request, ref callSettings);
            return _callSetBackendService.Sync(request, callSettings);
        }

        /// <summary>
        /// Changes the BackendService for TargetSslProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> SetBackendServiceAsync(SetBackendServiceTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetBackendServiceTargetSslProxyRequest(ref request, ref callSettings);
            return _callSetBackendService.Async(request, callSettings);
        }

        /// <summary>
        /// Changes the ProxyHeaderType for TargetSslProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation SetProxyHeader(SetProxyHeaderTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetProxyHeaderTargetSslProxyRequest(ref request, ref callSettings);
            return _callSetProxyHeader.Sync(request, callSettings);
        }

        /// <summary>
        /// Changes the ProxyHeaderType for TargetSslProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> SetProxyHeaderAsync(SetProxyHeaderTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetProxyHeaderTargetSslProxyRequest(ref request, ref callSettings);
            return _callSetProxyHeader.Async(request, callSettings);
        }

        /// <summary>
        /// Changes SslCertificates for TargetSslProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation SetSslCertificates(SetSslCertificatesTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetSslCertificatesTargetSslProxyRequest(ref request, ref callSettings);
            return _callSetSslCertificates.Sync(request, callSettings);
        }

        /// <summary>
        /// Changes SslCertificates for TargetSslProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> SetSslCertificatesAsync(SetSslCertificatesTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetSslCertificatesTargetSslProxyRequest(ref request, ref callSettings);
            return _callSetSslCertificates.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the SSL policy for TargetSslProxy. The SSL policy specifies the server-side support for SSL features. This affects connections between clients and the SSL proxy load balancer. They do not affect the connection between the load balancer and the backends.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operation SetSslPolicy(SetSslPolicyTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetSslPolicyTargetSslProxyRequest(ref request, ref callSettings);
            return _callSetSslPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the SSL policy for TargetSslProxy. The SSL policy specifies the server-side support for SSL features. This affects connections between clients and the SSL proxy load balancer. They do not affect the connection between the load balancer and the backends.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operation> SetSslPolicyAsync(SetSslPolicyTargetSslProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetSslPolicyTargetSslProxyRequest(ref request, ref callSettings);
            return _callSetSslPolicy.Async(request, callSettings);
        }
    }

    public partial class ListTargetSslProxiesRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class TargetSslProxyList : gaxgrpc::IPageResponse<TargetSslProxy>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TargetSslProxy> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
