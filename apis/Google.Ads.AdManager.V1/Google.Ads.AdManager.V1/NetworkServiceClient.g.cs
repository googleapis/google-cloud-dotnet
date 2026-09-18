// Copyright 2026 Google LLC
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
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

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
            UpdateNetworkSettings = existing.UpdateNetworkSettings;
            ProvisionTestNetworkSettings = existing.ProvisionTestNetworkSettings;
            GetDefaultThirdPartyDataDeclarationSettings = existing.GetDefaultThirdPartyDataDeclarationSettings;
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

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServiceClient.UpdateNetwork</c> and <c>NetworkServiceClient.UpdateNetworkAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateNetworkSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServiceClient.ProvisionTestNetwork</c> and <c>NetworkServiceClient.ProvisionTestNetworkAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ProvisionTestNetworkSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NetworkServiceClient.GetDefaultThirdPartyDataDeclaration</c> and
        /// <c>NetworkServiceClient.GetDefaultThirdPartyDataDeclarationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDefaultThirdPartyDataDeclarationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

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
        /// <item><description>https://www.googleapis.com/auth/admanager.readonly</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/admanager",
            "https://www.googleapis.com/auth/admanager.readonly",
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
        /// Retrieves a `Network` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Network GetNetwork(GetNetworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `Network` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Network> GetNetworkAsync(GetNetworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a `Network` object.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Network> GetNetworkAsync(GetNetworkRequest request, st::CancellationToken cancellationToken) =>
            GetNetworkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a `Network` object.
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
        /// Retrieves a `Network` object.
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
        /// Retrieves a `Network` object.
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
        /// Retrieves a `Network` object.
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
        /// Retrieves a `Network` object.
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
        /// Retrieves a `Network` object.
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
        /// Retrieves all the networks the current user has access to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Network"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListNetworksResponse, Network> ListNetworks(ListNetworksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves all the networks the current user has access to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Network"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListNetworksResponse, Network> ListNetworksAsync(ListNetworksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `Network` object. Currently, only the network display name can be
        /// updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Network UpdateNetwork(UpdateNetworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `Network` object. Currently, only the network display name can be
        /// updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Network> UpdateNetworkAsync(UpdateNetworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `Network` object. Currently, only the network display name can be
        /// updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Network> UpdateNetworkAsync(UpdateNetworkRequest request, st::CancellationToken cancellationToken) =>
            UpdateNetworkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `Network` object. Currently, only the network display name can be
        /// updated.
        /// </summary>
        /// <param name="network">
        /// Required. The `Network` to update.
        /// 
        /// The `Network`'s `name` is used to identify the `Network` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Network UpdateNetwork(Network network, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateNetwork(new UpdateNetworkRequest
            {
                Network = gax::GaxPreconditions.CheckNotNull(network, nameof(network)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a `Network` object. Currently, only the network display name can be
        /// updated.
        /// </summary>
        /// <param name="network">
        /// Required. The `Network` to update.
        /// 
        /// The `Network`'s `name` is used to identify the `Network` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Network> UpdateNetworkAsync(Network network, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateNetworkAsync(new UpdateNetworkRequest
            {
                Network = gax::GaxPreconditions.CheckNotNull(network, nameof(network)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a `Network` object. Currently, only the network display name can be
        /// updated.
        /// </summary>
        /// <param name="network">
        /// Required. The `Network` to update.
        /// 
        /// The `Network`'s `name` is used to identify the `Network` to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Network> UpdateNetworkAsync(Network network, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateNetworkAsync(network, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Provisions a test network associated with the current user. Only one test
        /// network can be provisioned per user.
        /// 
        /// Before the test network can be used, you must complete setup in the Ad
        /// Manager UI. If the test network's owner is a service account, you must add
        /// a non-service account user by calling UserService.CreateUser.
        /// 
        /// Test networks are limited in the following ways:
        /// 
        /// * Test networks have a maximum of 10,000 objects per entity type.
        /// * Test networks cannot serve ads.
        /// * Reports on serving data have zero rows.
        /// * Forecast service results contain mock data.
        /// * Test networks do not have Ad Manager 360 or premium features enabled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Network ProvisionTestNetwork(ProvisionTestNetworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Provisions a test network associated with the current user. Only one test
        /// network can be provisioned per user.
        /// 
        /// Before the test network can be used, you must complete setup in the Ad
        /// Manager UI. If the test network's owner is a service account, you must add
        /// a non-service account user by calling UserService.CreateUser.
        /// 
        /// Test networks are limited in the following ways:
        /// 
        /// * Test networks have a maximum of 10,000 objects per entity type.
        /// * Test networks cannot serve ads.
        /// * Reports on serving data have zero rows.
        /// * Forecast service results contain mock data.
        /// * Test networks do not have Ad Manager 360 or premium features enabled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Network> ProvisionTestNetworkAsync(ProvisionTestNetworkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Provisions a test network associated with the current user. Only one test
        /// network can be provisioned per user.
        /// 
        /// Before the test network can be used, you must complete setup in the Ad
        /// Manager UI. If the test network's owner is a service account, you must add
        /// a non-service account user by calling UserService.CreateUser.
        /// 
        /// Test networks are limited in the following ways:
        /// 
        /// * Test networks have a maximum of 10,000 objects per entity type.
        /// * Test networks cannot serve ads.
        /// * Reports on serving data have zero rows.
        /// * Forecast service results contain mock data.
        /// * Test networks do not have Ad Manager 360 or premium features enabled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Network> ProvisionTestNetworkAsync(ProvisionTestNetworkRequest request, st::CancellationToken cancellationToken) =>
            ProvisionTestNetworkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the [DefaultThirdPartyDataDeclaration] for this network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DefaultThirdPartyDataDeclaration GetDefaultThirdPartyDataDeclaration(GetDefaultThirdPartyDataDeclarationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the [DefaultThirdPartyDataDeclaration] for this network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DefaultThirdPartyDataDeclaration> GetDefaultThirdPartyDataDeclarationAsync(GetDefaultThirdPartyDataDeclarationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the [DefaultThirdPartyDataDeclaration] for this network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DefaultThirdPartyDataDeclaration> GetDefaultThirdPartyDataDeclarationAsync(GetDefaultThirdPartyDataDeclarationRequest request, st::CancellationToken cancellationToken) =>
            GetDefaultThirdPartyDataDeclarationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the [DefaultThirdPartyDataDeclaration] for this network.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of DefaultThirdPartyDataDeclaration.
        /// Format: networks/{network_code}/defaultThirdPartyDataDeclaration
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DefaultThirdPartyDataDeclaration GetDefaultThirdPartyDataDeclaration(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDefaultThirdPartyDataDeclaration(new GetDefaultThirdPartyDataDeclarationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the [DefaultThirdPartyDataDeclaration] for this network.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of DefaultThirdPartyDataDeclaration.
        /// Format: networks/{network_code}/defaultThirdPartyDataDeclaration
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DefaultThirdPartyDataDeclaration> GetDefaultThirdPartyDataDeclarationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDefaultThirdPartyDataDeclarationAsync(new GetDefaultThirdPartyDataDeclarationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the [DefaultThirdPartyDataDeclaration] for this network.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of DefaultThirdPartyDataDeclaration.
        /// Format: networks/{network_code}/defaultThirdPartyDataDeclaration
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DefaultThirdPartyDataDeclaration> GetDefaultThirdPartyDataDeclarationAsync(string name, st::CancellationToken cancellationToken) =>
            GetDefaultThirdPartyDataDeclarationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the [DefaultThirdPartyDataDeclaration] for this network.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of DefaultThirdPartyDataDeclaration.
        /// Format: networks/{network_code}/defaultThirdPartyDataDeclaration
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DefaultThirdPartyDataDeclaration GetDefaultThirdPartyDataDeclaration(DefaultThirdPartyDataDeclarationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDefaultThirdPartyDataDeclaration(new GetDefaultThirdPartyDataDeclarationRequest
            {
                DefaultThirdPartyDataDeclarationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the [DefaultThirdPartyDataDeclaration] for this network.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of DefaultThirdPartyDataDeclaration.
        /// Format: networks/{network_code}/defaultThirdPartyDataDeclaration
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DefaultThirdPartyDataDeclaration> GetDefaultThirdPartyDataDeclarationAsync(DefaultThirdPartyDataDeclarationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDefaultThirdPartyDataDeclarationAsync(new GetDefaultThirdPartyDataDeclarationRequest
            {
                DefaultThirdPartyDataDeclarationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the [DefaultThirdPartyDataDeclaration] for this network.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of DefaultThirdPartyDataDeclaration.
        /// Format: networks/{network_code}/defaultThirdPartyDataDeclaration
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DefaultThirdPartyDataDeclaration> GetDefaultThirdPartyDataDeclarationAsync(DefaultThirdPartyDataDeclarationName name, st::CancellationToken cancellationToken) =>
            GetDefaultThirdPartyDataDeclarationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>NetworkService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Provides methods for handling `Network` objects.
    /// </remarks>
    public sealed partial class NetworkServiceClientImpl : NetworkServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetNetworkRequest, Network> _callGetNetwork;

        private readonly gaxgrpc::ApiCall<ListNetworksRequest, ListNetworksResponse> _callListNetworks;

        private readonly gaxgrpc::ApiCall<UpdateNetworkRequest, Network> _callUpdateNetwork;

        private readonly gaxgrpc::ApiCall<ProvisionTestNetworkRequest, Network> _callProvisionTestNetwork;

        private readonly gaxgrpc::ApiCall<GetDefaultThirdPartyDataDeclarationRequest, DefaultThirdPartyDataDeclaration> _callGetDefaultThirdPartyDataDeclaration;

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
            _callUpdateNetwork = clientHelper.BuildApiCall<UpdateNetworkRequest, Network>("UpdateNetwork", grpcClient.UpdateNetworkAsync, grpcClient.UpdateNetwork, effectiveSettings.UpdateNetworkSettings).WithGoogleRequestParam("network.name", request => request.Network?.Name);
            Modify_ApiCall(ref _callUpdateNetwork);
            Modify_UpdateNetworkApiCall(ref _callUpdateNetwork);
            _callProvisionTestNetwork = clientHelper.BuildApiCall<ProvisionTestNetworkRequest, Network>("ProvisionTestNetwork", grpcClient.ProvisionTestNetworkAsync, grpcClient.ProvisionTestNetwork, effectiveSettings.ProvisionTestNetworkSettings);
            Modify_ApiCall(ref _callProvisionTestNetwork);
            Modify_ProvisionTestNetworkApiCall(ref _callProvisionTestNetwork);
            _callGetDefaultThirdPartyDataDeclaration = clientHelper.BuildApiCall<GetDefaultThirdPartyDataDeclarationRequest, DefaultThirdPartyDataDeclaration>("GetDefaultThirdPartyDataDeclaration", grpcClient.GetDefaultThirdPartyDataDeclarationAsync, grpcClient.GetDefaultThirdPartyDataDeclaration, effectiveSettings.GetDefaultThirdPartyDataDeclarationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDefaultThirdPartyDataDeclaration);
            Modify_GetDefaultThirdPartyDataDeclarationApiCall(ref _callGetDefaultThirdPartyDataDeclaration);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetNetworkApiCall(ref gaxgrpc::ApiCall<GetNetworkRequest, Network> call);

        partial void Modify_ListNetworksApiCall(ref gaxgrpc::ApiCall<ListNetworksRequest, ListNetworksResponse> call);

        partial void Modify_UpdateNetworkApiCall(ref gaxgrpc::ApiCall<UpdateNetworkRequest, Network> call);

        partial void Modify_ProvisionTestNetworkApiCall(ref gaxgrpc::ApiCall<ProvisionTestNetworkRequest, Network> call);

        partial void Modify_GetDefaultThirdPartyDataDeclarationApiCall(ref gaxgrpc::ApiCall<GetDefaultThirdPartyDataDeclarationRequest, DefaultThirdPartyDataDeclaration> call);

        partial void OnConstruction(NetworkService.NetworkServiceClient grpcClient, NetworkServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC NetworkService client</summary>
        public override NetworkService.NetworkServiceClient GrpcClient { get; }

        partial void Modify_GetNetworkRequest(ref GetNetworkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListNetworksRequest(ref ListNetworksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateNetworkRequest(ref UpdateNetworkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ProvisionTestNetworkRequest(ref ProvisionTestNetworkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDefaultThirdPartyDataDeclarationRequest(ref GetDefaultThirdPartyDataDeclarationRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves a `Network` object.
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
        /// Retrieves a `Network` object.
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
        /// Retrieves all the networks the current user has access to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Network"/> resources.</returns>
        public override gax::PagedEnumerable<ListNetworksResponse, Network> ListNetworks(ListNetworksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNetworksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListNetworksRequest, ListNetworksResponse, Network>(_callListNetworks, request, callSettings);
        }

        /// <summary>
        /// Retrieves all the networks the current user has access to.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Network"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListNetworksResponse, Network> ListNetworksAsync(ListNetworksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListNetworksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListNetworksRequest, ListNetworksResponse, Network>(_callListNetworks, request, callSettings);
        }

        /// <summary>
        /// Updates a `Network` object. Currently, only the network display name can be
        /// updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Network UpdateNetwork(UpdateNetworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateNetworkRequest(ref request, ref callSettings);
            return _callUpdateNetwork.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a `Network` object. Currently, only the network display name can be
        /// updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Network> UpdateNetworkAsync(UpdateNetworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateNetworkRequest(ref request, ref callSettings);
            return _callUpdateNetwork.Async(request, callSettings);
        }

        /// <summary>
        /// Provisions a test network associated with the current user. Only one test
        /// network can be provisioned per user.
        /// 
        /// Before the test network can be used, you must complete setup in the Ad
        /// Manager UI. If the test network's owner is a service account, you must add
        /// a non-service account user by calling UserService.CreateUser.
        /// 
        /// Test networks are limited in the following ways:
        /// 
        /// * Test networks have a maximum of 10,000 objects per entity type.
        /// * Test networks cannot serve ads.
        /// * Reports on serving data have zero rows.
        /// * Forecast service results contain mock data.
        /// * Test networks do not have Ad Manager 360 or premium features enabled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Network ProvisionTestNetwork(ProvisionTestNetworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ProvisionTestNetworkRequest(ref request, ref callSettings);
            return _callProvisionTestNetwork.Sync(request, callSettings);
        }

        /// <summary>
        /// Provisions a test network associated with the current user. Only one test
        /// network can be provisioned per user.
        /// 
        /// Before the test network can be used, you must complete setup in the Ad
        /// Manager UI. If the test network's owner is a service account, you must add
        /// a non-service account user by calling UserService.CreateUser.
        /// 
        /// Test networks are limited in the following ways:
        /// 
        /// * Test networks have a maximum of 10,000 objects per entity type.
        /// * Test networks cannot serve ads.
        /// * Reports on serving data have zero rows.
        /// * Forecast service results contain mock data.
        /// * Test networks do not have Ad Manager 360 or premium features enabled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Network> ProvisionTestNetworkAsync(ProvisionTestNetworkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ProvisionTestNetworkRequest(ref request, ref callSettings);
            return _callProvisionTestNetwork.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the [DefaultThirdPartyDataDeclaration] for this network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DefaultThirdPartyDataDeclaration GetDefaultThirdPartyDataDeclaration(GetDefaultThirdPartyDataDeclarationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDefaultThirdPartyDataDeclarationRequest(ref request, ref callSettings);
            return _callGetDefaultThirdPartyDataDeclaration.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the [DefaultThirdPartyDataDeclaration] for this network.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DefaultThirdPartyDataDeclaration> GetDefaultThirdPartyDataDeclarationAsync(GetDefaultThirdPartyDataDeclarationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDefaultThirdPartyDataDeclarationRequest(ref request, ref callSettings);
            return _callGetDefaultThirdPartyDataDeclaration.Async(request, callSettings);
        }
    }

    public partial class ListNetworksRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListNetworksResponse : gaxgrpc::IPageResponse<Network>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Network> GetEnumerator() => Networks.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
