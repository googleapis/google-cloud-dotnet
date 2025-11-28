// Copyright 2025 Google LLC
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

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Ads.AdManager.V1
{
    /// <summary>Settings for <see cref="NetworkServiceClient"/> instances.</summary>
    public sealed partial class NetworkServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="NetworkServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="NetworkServiceSettings"/>.</returns>
        public static NetworkServiceSettings GetDefault() => new NetworkServiceSettings();

        /// <summary>Constructs a new <see cref="NetworkServiceSettings"/> object with default settings.</summary>
        public NetworkServiceSettings()
        {
        }

        private NetworkServiceSettings(NetworkServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetNetworkSettings = existing.GetNetworkSettings;
            ListNetworksSettings = existing.ListNetworksSettings;
            OnCopy(existing);
        }

        partial void OnCopy(NetworkServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServiceClient.GetNetwork</c> and <c>NetworkServiceClient.GetNetworkAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetNetworkSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServiceClient.ListNetworks</c> and <c>NetworkServiceClient.ListNetworksAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListNetworksSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="NetworkServiceSettings"/> object.</returns>
        public NetworkServiceSettings Clone() => new NetworkServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="NetworkServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class NetworkServiceClientBuilder : gaxgrpc::ClientBuilderBase<NetworkServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public NetworkServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public NetworkServiceClientBuilder() : base(NetworkServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref NetworkServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<NetworkServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override NetworkServiceClient Build()
        {
            NetworkServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<NetworkServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<NetworkServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private NetworkServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return NetworkServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<NetworkServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return NetworkServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => NetworkServiceClient.ChannelPool;
    }

    /// <summary>NetworkService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `Network` objects.
    /// </remarks>
    public abstract partial class NetworkServiceClient
    {
        /// <summary>
        /// The default endpoint for the NetworkService service, which is a host of "admanager.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "admanager.googleapis.com:443";

        /// <summary>The default NetworkService scopes.</summary>
        /// <remarks>
        /// The default NetworkService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/admanager</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(NetworkService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="NetworkServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="NetworkServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="NetworkServiceClient"/>.</returns>
        public static stt::Task<NetworkServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new NetworkServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="NetworkServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="NetworkServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="NetworkServiceClient"/>.</returns>
        public static NetworkServiceClient Create() => new NetworkServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="NetworkServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="NetworkServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="NetworkServiceClient"/>.</returns>
        internal static NetworkServiceClient Create(grpccore::CallInvoker callInvoker, NetworkServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            NetworkService.NetworkServiceClient grpcClient = new NetworkService.NetworkServiceClient(callInvoker);
            return new NetworkServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC NetworkService client</summary>
        public virtual NetworkService.NetworkServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a Network object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Network GetNetwork(GetNetworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a Network object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Network> GetNetworkAsync(GetNetworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve a Network object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Network> GetNetworkAsync(GetNetworkRequest request, st::CancellationToken cancellationToken) =>
            GetNetworkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a Network object.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of Network.
        /// Format: networks/{network_code}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Network GetNetwork(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNetwork(new GetNetworkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a Network object.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of Network.
        /// Format: networks/{network_code}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Network> GetNetworkAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetNetworkAsync(new GetNetworkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a Network object.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of Network.
        /// Format: networks/{network_code}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Network> GetNetworkAsync(string name, st::CancellationToken cancellationToken) =>
            GetNetworkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve a Network object.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of Network.
        /// Format: networks/{network_code}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Network GetNetwork(NetworkName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNetwork(new GetNetworkRequest
            {
                NetworkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a Network object.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of Network.
        /// Format: networks/{network_code}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Network> GetNetworkAsync(NetworkName name, gaxgrpc::CallSettings callSettings = null) =>
            GetNetworkAsync(new GetNetworkRequest
            {
                NetworkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// API to retrieve a Network object.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of Network.
        /// Format: networks/{network_code}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Network> GetNetworkAsync(NetworkName name, st::CancellationToken cancellationToken) =>
            GetNetworkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// API to retrieve all the networks the current user has access to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListNetworksResponse ListNetworks(ListNetworksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve all the networks the current user has access to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListNetworksResponse> ListNetworksAsync(ListNetworksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// API to retrieve all the networks the current user has access to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListNetworksResponse> ListNetworksAsync(ListNetworksRequest request, st::CancellationToken cancellationToken) =>
            ListNetworksAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>NetworkService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `Network` objects.
    /// </remarks>
    public sealed partial class NetworkServiceClientImpl : NetworkServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetNetworkRequest, Network> _callGetNetwork;

        private readonly gaxgrpc::ApiCall<ListNetworksRequest, ListNetworksResponse> _callListNetworks;

        /// <summary>
        /// Constructs a client wrapper for the NetworkService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="NetworkServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public NetworkServiceClientImpl(NetworkService.NetworkServiceClient grpcClient, NetworkServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            NetworkServiceSettings effectiveSettings = settings ?? NetworkServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetNetwork = clientHelper.BuildApiCall<GetNetworkRequest, Network>("GetNetwork", grpcClient.GetNetworkAsync, grpcClient.GetNetwork, effectiveSettings.GetNetworkSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetNetwork);
            Modify_GetNetworkApiCall(ref _callGetNetwork);
            _callListNetworks = clientHelper.BuildApiCall<ListNetworksRequest, ListNetworksResponse>("ListNetworks", grpcClient.ListNetworksAsync, grpcClient.ListNetworks, effectiveSettings.ListNetworksSettings);
            Modify_ApiCall(ref _callListNetworks);
            Modify_ListNetworksApiCall(ref _callListNetworks);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetNetworkApiCall(ref gaxgrpc::ApiCall<GetNetworkRequest, Network> call);

        partial void Modify_ListNetworksApiCall(ref gaxgrpc::ApiCall<ListNetworksRequest, ListNetworksResponse> call);

        partial void OnConstruction(NetworkService.NetworkServiceClient grpcClient, NetworkServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC NetworkService client</summary>
        public override NetworkService.NetworkServiceClient GrpcClient { get; }

        partial void Modify_GetNetworkRequest(ref GetNetworkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListNetworksRequest(ref ListNetworksRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// API to retrieve a Network object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Network GetNetwork(GetNetworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNetworkRequest(ref request, ref callSettings);
            return _callGetNetwork.Sync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve a Network object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Network> GetNetworkAsync(GetNetworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetNetworkRequest(ref request, ref callSettings);
            return _callGetNetwork.Async(request, callSettings);
        }

        /// <summary>
        /// API to retrieve all the networks the current user has access to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListNetworksResponse ListNetworks(ListNetworksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNetworksRequest(ref request, ref callSettings);
            return _callListNetworks.Sync(request, callSettings);
        }

        /// <summary>
        /// API to retrieve all the networks the current user has access to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListNetworksResponse> ListNetworksAsync(ListNetworksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNetworksRequest(ref request, ref callSettings);
            return _callListNetworks.Async(request, callSettings);
        }
    }
}
