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

using ga = Google.Api;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.GkeConnect.Gateway.V1Beta1
{
    /// <summary>Settings for <see cref="GatewayServiceClient"/> instances.</summary>
    public sealed partial class GatewayServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="GatewayServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="GatewayServiceSettings"/>.</returns>
        public static GatewayServiceSettings GetDefault() => new GatewayServiceSettings();

        /// <summary>Constructs a new <see cref="GatewayServiceSettings"/> object with default settings.</summary>
        public GatewayServiceSettings()
        {
        }

        private GatewayServiceSettings(GatewayServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetResourceSettings = existing.GetResourceSettings;
            PostResourceSettings = existing.PostResourceSettings;
            DeleteResourceSettings = existing.DeleteResourceSettings;
            PutResourceSettings = existing.PutResourceSettings;
            PatchResourceSettings = existing.PatchResourceSettings;
            OnCopy(existing);
        }

        partial void OnCopy(GatewayServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GatewayServiceClient.GetResource</c> and <c>GatewayServiceClient.GetResourceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetResourceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GatewayServiceClient.PostResource</c> and <c>GatewayServiceClient.PostResourceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PostResourceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GatewayServiceClient.DeleteResource</c> and <c>GatewayServiceClient.DeleteResourceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteResourceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GatewayServiceClient.PutResource</c> and <c>GatewayServiceClient.PutResourceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PutResourceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GatewayServiceClient.PatchResource</c> and <c>GatewayServiceClient.PatchResourceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PatchResourceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="GatewayServiceSettings"/> object.</returns>
        public GatewayServiceSettings Clone() => new GatewayServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="GatewayServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class GatewayServiceClientBuilder : gaxgrpc::ClientBuilderBase<GatewayServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public GatewayServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref GatewayServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<GatewayServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override GatewayServiceClient Build()
        {
            GatewayServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<GatewayServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<GatewayServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private GatewayServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return GatewayServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<GatewayServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return GatewayServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => GatewayServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => GatewayServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => GatewayServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>GatewayService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Gateway service is a public API which works as a Kubernetes resource model
    /// proxy between end users and registered Kubernetes clusters. Each RPC in this
    /// service matches with an HTTP verb. End user will initiate kubectl commands
    /// against the Gateway service, and Gateway service will forward user requests
    /// to clusters.
    /// </remarks>
    public abstract partial class GatewayServiceClient
    {
        /// <summary>
        /// The default endpoint for the GatewayService service, which is a host of "connectgateway.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "connectgateway.googleapis.com:443";

        /// <summary>The default GatewayService scopes.</summary>
        /// <remarks>
        /// The default GatewayService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="GatewayServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="GatewayServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="GatewayServiceClient"/>.</returns>
        public static stt::Task<GatewayServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new GatewayServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="GatewayServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="GatewayServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="GatewayServiceClient"/>.</returns>
        public static GatewayServiceClient Create() => new GatewayServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="GatewayServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="GatewayServiceSettings"/>.</param>
        /// <returns>The created <see cref="GatewayServiceClient"/>.</returns>
        internal static GatewayServiceClient Create(grpccore::CallInvoker callInvoker, GatewayServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            GatewayService.GatewayServiceClient grpcClient = new GatewayService.GatewayServiceClient(callInvoker);
            return new GatewayServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC GatewayService client</summary>
        public virtual GatewayService.GatewayServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// GetResource performs an HTTP GET request on the Kubernetes API Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ga::HttpBody GetResource(ga::HttpBody request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// GetResource performs an HTTP GET request on the Kubernetes API Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> GetResourceAsync(ga::HttpBody request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// GetResource performs an HTTP GET request on the Kubernetes API Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> GetResourceAsync(ga::HttpBody request, st::CancellationToken cancellationToken) =>
            GetResourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// PostResource performs an HTTP POST on the Kubernetes API Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ga::HttpBody PostResource(ga::HttpBody request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// PostResource performs an HTTP POST on the Kubernetes API Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> PostResourceAsync(ga::HttpBody request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// PostResource performs an HTTP POST on the Kubernetes API Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> PostResourceAsync(ga::HttpBody request, st::CancellationToken cancellationToken) =>
            PostResourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// DeleteResource performs an HTTP DELETE on the Kubernetes API Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ga::HttpBody DeleteResource(ga::HttpBody request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// DeleteResource performs an HTTP DELETE on the Kubernetes API Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> DeleteResourceAsync(ga::HttpBody request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// DeleteResource performs an HTTP DELETE on the Kubernetes API Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> DeleteResourceAsync(ga::HttpBody request, st::CancellationToken cancellationToken) =>
            DeleteResourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// PutResource performs an HTTP PUT on the Kubernetes API Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ga::HttpBody PutResource(ga::HttpBody request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// PutResource performs an HTTP PUT on the Kubernetes API Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> PutResourceAsync(ga::HttpBody request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// PutResource performs an HTTP PUT on the Kubernetes API Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> PutResourceAsync(ga::HttpBody request, st::CancellationToken cancellationToken) =>
            PutResourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// PatchResource performs an HTTP PATCH on the Kubernetes API Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ga::HttpBody PatchResource(ga::HttpBody request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// PatchResource performs an HTTP PATCH on the Kubernetes API Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> PatchResourceAsync(ga::HttpBody request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// PatchResource performs an HTTP PATCH on the Kubernetes API Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ga::HttpBody> PatchResourceAsync(ga::HttpBody request, st::CancellationToken cancellationToken) =>
            PatchResourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>GatewayService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Gateway service is a public API which works as a Kubernetes resource model
    /// proxy between end users and registered Kubernetes clusters. Each RPC in this
    /// service matches with an HTTP verb. End user will initiate kubectl commands
    /// against the Gateway service, and Gateway service will forward user requests
    /// to clusters.
    /// </remarks>
    public sealed partial class GatewayServiceClientImpl : GatewayServiceClient
    {
        private readonly gaxgrpc::ApiCall<ga::HttpBody, ga::HttpBody> _callGetResource;

        private readonly gaxgrpc::ApiCall<ga::HttpBody, ga::HttpBody> _callPostResource;

        private readonly gaxgrpc::ApiCall<ga::HttpBody, ga::HttpBody> _callDeleteResource;

        private readonly gaxgrpc::ApiCall<ga::HttpBody, ga::HttpBody> _callPutResource;

        private readonly gaxgrpc::ApiCall<ga::HttpBody, ga::HttpBody> _callPatchResource;

        /// <summary>
        /// Constructs a client wrapper for the GatewayService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="GatewayServiceSettings"/> used within this client.</param>
        public GatewayServiceClientImpl(GatewayService.GatewayServiceClient grpcClient, GatewayServiceSettings settings)
        {
            GrpcClient = grpcClient;
            GatewayServiceSettings effectiveSettings = settings ?? GatewayServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetResource = clientHelper.BuildApiCall<ga::HttpBody, ga::HttpBody>(grpcClient.GetResourceAsync, grpcClient.GetResource, effectiveSettings.GetResourceSettings);
            Modify_ApiCall(ref _callGetResource);
            Modify_GetResourceApiCall(ref _callGetResource);
            _callPostResource = clientHelper.BuildApiCall<ga::HttpBody, ga::HttpBody>(grpcClient.PostResourceAsync, grpcClient.PostResource, effectiveSettings.PostResourceSettings);
            Modify_ApiCall(ref _callPostResource);
            Modify_PostResourceApiCall(ref _callPostResource);
            _callDeleteResource = clientHelper.BuildApiCall<ga::HttpBody, ga::HttpBody>(grpcClient.DeleteResourceAsync, grpcClient.DeleteResource, effectiveSettings.DeleteResourceSettings);
            Modify_ApiCall(ref _callDeleteResource);
            Modify_DeleteResourceApiCall(ref _callDeleteResource);
            _callPutResource = clientHelper.BuildApiCall<ga::HttpBody, ga::HttpBody>(grpcClient.PutResourceAsync, grpcClient.PutResource, effectiveSettings.PutResourceSettings);
            Modify_ApiCall(ref _callPutResource);
            Modify_PutResourceApiCall(ref _callPutResource);
            _callPatchResource = clientHelper.BuildApiCall<ga::HttpBody, ga::HttpBody>(grpcClient.PatchResourceAsync, grpcClient.PatchResource, effectiveSettings.PatchResourceSettings);
            Modify_ApiCall(ref _callPatchResource);
            Modify_PatchResourceApiCall(ref _callPatchResource);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetResourceApiCall(ref gaxgrpc::ApiCall<ga::HttpBody, ga::HttpBody> call);

        partial void Modify_PostResourceApiCall(ref gaxgrpc::ApiCall<ga::HttpBody, ga::HttpBody> call);

        partial void Modify_DeleteResourceApiCall(ref gaxgrpc::ApiCall<ga::HttpBody, ga::HttpBody> call);

        partial void Modify_PutResourceApiCall(ref gaxgrpc::ApiCall<ga::HttpBody, ga::HttpBody> call);

        partial void Modify_PatchResourceApiCall(ref gaxgrpc::ApiCall<ga::HttpBody, ga::HttpBody> call);

        partial void OnConstruction(GatewayService.GatewayServiceClient grpcClient, GatewayServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC GatewayService client</summary>
        public override GatewayService.GatewayServiceClient GrpcClient { get; }

        partial void Modify_HttpBody(ref ga::HttpBody request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// GetResource performs an HTTP GET request on the Kubernetes API Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ga::HttpBody GetResource(ga::HttpBody request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_HttpBody(ref request, ref callSettings);
            return _callGetResource.Sync(request, callSettings);
        }

        /// <summary>
        /// GetResource performs an HTTP GET request on the Kubernetes API Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ga::HttpBody> GetResourceAsync(ga::HttpBody request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_HttpBody(ref request, ref callSettings);
            return _callGetResource.Async(request, callSettings);
        }

        /// <summary>
        /// PostResource performs an HTTP POST on the Kubernetes API Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ga::HttpBody PostResource(ga::HttpBody request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_HttpBody(ref request, ref callSettings);
            return _callPostResource.Sync(request, callSettings);
        }

        /// <summary>
        /// PostResource performs an HTTP POST on the Kubernetes API Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ga::HttpBody> PostResourceAsync(ga::HttpBody request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_HttpBody(ref request, ref callSettings);
            return _callPostResource.Async(request, callSettings);
        }

        /// <summary>
        /// DeleteResource performs an HTTP DELETE on the Kubernetes API Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ga::HttpBody DeleteResource(ga::HttpBody request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_HttpBody(ref request, ref callSettings);
            return _callDeleteResource.Sync(request, callSettings);
        }

        /// <summary>
        /// DeleteResource performs an HTTP DELETE on the Kubernetes API Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ga::HttpBody> DeleteResourceAsync(ga::HttpBody request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_HttpBody(ref request, ref callSettings);
            return _callDeleteResource.Async(request, callSettings);
        }

        /// <summary>
        /// PutResource performs an HTTP PUT on the Kubernetes API Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ga::HttpBody PutResource(ga::HttpBody request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_HttpBody(ref request, ref callSettings);
            return _callPutResource.Sync(request, callSettings);
        }

        /// <summary>
        /// PutResource performs an HTTP PUT on the Kubernetes API Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ga::HttpBody> PutResourceAsync(ga::HttpBody request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_HttpBody(ref request, ref callSettings);
            return _callPutResource.Async(request, callSettings);
        }

        /// <summary>
        /// PatchResource performs an HTTP PATCH on the Kubernetes API Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ga::HttpBody PatchResource(ga::HttpBody request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_HttpBody(ref request, ref callSettings);
            return _callPatchResource.Sync(request, callSettings);
        }

        /// <summary>
        /// PatchResource performs an HTTP PATCH on the Kubernetes API Server.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ga::HttpBody> PatchResourceAsync(ga::HttpBody request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_HttpBody(ref request, ref callSettings);
            return _callPatchResource.Async(request, callSettings);
        }
    }
}
