// Copyright 2022 Google LLC
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
using gagr = Google.Api.Gax.ResourceNames;
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.BeyondCorp.ClientConnectorServices.V1
{
    /// <summary>Settings for <see cref="ClientConnectorServicesServiceClient"/> instances.</summary>
    public sealed partial class ClientConnectorServicesServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ClientConnectorServicesServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ClientConnectorServicesServiceSettings"/>.</returns>
        public static ClientConnectorServicesServiceSettings GetDefault() => new ClientConnectorServicesServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ClientConnectorServicesServiceSettings"/> object with default settings.
        /// </summary>
        public ClientConnectorServicesServiceSettings()
        {
        }

        private ClientConnectorServicesServiceSettings(ClientConnectorServicesServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListClientConnectorServicesSettings = existing.ListClientConnectorServicesSettings;
            GetClientConnectorServiceSettings = existing.GetClientConnectorServiceSettings;
            CreateClientConnectorServiceSettings = existing.CreateClientConnectorServiceSettings;
            CreateClientConnectorServiceOperationsSettings = existing.CreateClientConnectorServiceOperationsSettings.Clone();
            UpdateClientConnectorServiceSettings = existing.UpdateClientConnectorServiceSettings;
            UpdateClientConnectorServiceOperationsSettings = existing.UpdateClientConnectorServiceOperationsSettings.Clone();
            DeleteClientConnectorServiceSettings = existing.DeleteClientConnectorServiceSettings;
            DeleteClientConnectorServiceOperationsSettings = existing.DeleteClientConnectorServiceOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(ClientConnectorServicesServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClientConnectorServicesServiceClient.ListClientConnectorServices</c> and
        /// <c>ClientConnectorServicesServiceClient.ListClientConnectorServicesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListClientConnectorServicesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClientConnectorServicesServiceClient.GetClientConnectorService</c> and
        /// <c>ClientConnectorServicesServiceClient.GetClientConnectorServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetClientConnectorServiceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClientConnectorServicesServiceClient.CreateClientConnectorService</c> and
        /// <c>ClientConnectorServicesServiceClient.CreateClientConnectorServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateClientConnectorServiceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>ClientConnectorServicesServiceClient.CreateClientConnectorService</c> and
        /// <c>ClientConnectorServicesServiceClient.CreateClientConnectorServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateClientConnectorServiceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClientConnectorServicesServiceClient.UpdateClientConnectorService</c> and
        /// <c>ClientConnectorServicesServiceClient.UpdateClientConnectorServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateClientConnectorServiceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>ClientConnectorServicesServiceClient.UpdateClientConnectorService</c> and
        /// <c>ClientConnectorServicesServiceClient.UpdateClientConnectorServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings UpdateClientConnectorServiceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ClientConnectorServicesServiceClient.DeleteClientConnectorService</c> and
        /// <c>ClientConnectorServicesServiceClient.DeleteClientConnectorServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteClientConnectorServiceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>ClientConnectorServicesServiceClient.DeleteClientConnectorService</c> and
        /// <c>ClientConnectorServicesServiceClient.DeleteClientConnectorServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteClientConnectorServiceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ClientConnectorServicesServiceSettings"/> object.</returns>
        public ClientConnectorServicesServiceSettings Clone() => new ClientConnectorServicesServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ClientConnectorServicesServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class ClientConnectorServicesServiceClientBuilder : gaxgrpc::ClientBuilderBase<ClientConnectorServicesServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ClientConnectorServicesServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ClientConnectorServicesServiceClientBuilder() : base(ClientConnectorServicesServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ClientConnectorServicesServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ClientConnectorServicesServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ClientConnectorServicesServiceClient Build()
        {
            ClientConnectorServicesServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ClientConnectorServicesServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ClientConnectorServicesServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ClientConnectorServicesServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ClientConnectorServicesServiceClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<ClientConnectorServicesServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ClientConnectorServicesServiceClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ClientConnectorServicesServiceClient.ChannelPool;
    }

    /// <summary>ClientConnectorServicesService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// API Overview:
    /// 
    /// The `beyondcorp.googleapis.com` service implements the Google Cloud
    /// BeyondCorp API.
    /// 
    /// Data Model:
    /// 
    /// The ClientConnectorServicesService exposes the following resources:
    /// 
    /// * Client Connector Services, named as follows:
    /// `projects/{project_id}/locations/{location_id}/client_connector_services/{client_connector_service_id}`.
    /// </remarks>
    public abstract partial class ClientConnectorServicesServiceClient
    {
        /// <summary>
        /// The default endpoint for the ClientConnectorServicesService service, which is a host of
        /// "beyondcorp.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "beyondcorp.googleapis.com:443";

        /// <summary>The default ClientConnectorServicesService scopes.</summary>
        /// <remarks>
        /// The default ClientConnectorServicesService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ClientConnectorServicesService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ClientConnectorServicesServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ClientConnectorServicesServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ClientConnectorServicesServiceClient"/>.</returns>
        public static stt::Task<ClientConnectorServicesServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ClientConnectorServicesServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ClientConnectorServicesServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ClientConnectorServicesServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ClientConnectorServicesServiceClient"/>.</returns>
        public static ClientConnectorServicesServiceClient Create() =>
            new ClientConnectorServicesServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ClientConnectorServicesServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ClientConnectorServicesServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ClientConnectorServicesServiceClient"/>.</returns>
        internal static ClientConnectorServicesServiceClient Create(grpccore::CallInvoker callInvoker, ClientConnectorServicesServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ClientConnectorServicesService.ClientConnectorServicesServiceClient grpcClient = new ClientConnectorServicesService.ClientConnectorServicesServiceClient(callInvoker);
            return new ClientConnectorServicesServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ClientConnectorServicesService client</summary>
        public virtual ClientConnectorServicesService.ClientConnectorServicesServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ClientConnectorServices in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ClientConnectorService"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListClientConnectorServicesResponse, ClientConnectorService> ListClientConnectorServices(ListClientConnectorServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ClientConnectorServices in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ClientConnectorService"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListClientConnectorServicesResponse, ClientConnectorService> ListClientConnectorServicesAsync(ListClientConnectorServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ClientConnectorServices in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListClientConnectorServicesRequest.
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
        /// <returns>A pageable sequence of <see cref="ClientConnectorService"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListClientConnectorServicesResponse, ClientConnectorService> ListClientConnectorServices(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListClientConnectorServices(new ListClientConnectorServicesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists ClientConnectorServices in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListClientConnectorServicesRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ClientConnectorService"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListClientConnectorServicesResponse, ClientConnectorService> ListClientConnectorServicesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListClientConnectorServicesAsync(new ListClientConnectorServicesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists ClientConnectorServices in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListClientConnectorServicesRequest.
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
        /// <returns>A pageable sequence of <see cref="ClientConnectorService"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListClientConnectorServicesResponse, ClientConnectorService> ListClientConnectorServices(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListClientConnectorServices(new ListClientConnectorServicesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists ClientConnectorServices in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListClientConnectorServicesRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ClientConnectorService"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListClientConnectorServicesResponse, ClientConnectorService> ListClientConnectorServicesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListClientConnectorServicesAsync(new ListClientConnectorServicesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets details of a single ClientConnectorService.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ClientConnectorService GetClientConnectorService(GetClientConnectorServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ClientConnectorService.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ClientConnectorService> GetClientConnectorServiceAsync(GetClientConnectorServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ClientConnectorService.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ClientConnectorService> GetClientConnectorServiceAsync(GetClientConnectorServiceRequest request, st::CancellationToken cancellationToken) =>
            GetClientConnectorServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ClientConnectorService.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ClientConnectorService GetClientConnectorService(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetClientConnectorService(new GetClientConnectorServiceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ClientConnectorService.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ClientConnectorService> GetClientConnectorServiceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetClientConnectorServiceAsync(new GetClientConnectorServiceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ClientConnectorService.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ClientConnectorService> GetClientConnectorServiceAsync(string name, st::CancellationToken cancellationToken) =>
            GetClientConnectorServiceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ClientConnectorService.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ClientConnectorService GetClientConnectorService(ClientConnectorServiceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetClientConnectorService(new GetClientConnectorServiceRequest
            {
                ClientConnectorServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ClientConnectorService.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ClientConnectorService> GetClientConnectorServiceAsync(ClientConnectorServiceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetClientConnectorServiceAsync(new GetClientConnectorServiceRequest
            {
                ClientConnectorServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ClientConnectorService.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ClientConnectorService> GetClientConnectorServiceAsync(ClientConnectorServiceName name, st::CancellationToken cancellationToken) =>
            GetClientConnectorServiceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ClientConnectorService in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> CreateClientConnectorService(CreateClientConnectorServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ClientConnectorService in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata>> CreateClientConnectorServiceAsync(CreateClientConnectorServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ClientConnectorService in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata>> CreateClientConnectorServiceAsync(CreateClientConnectorServiceRequest request, st::CancellationToken cancellationToken) =>
            CreateClientConnectorServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateClientConnectorService</c>.</summary>
        public virtual lro::OperationsClient CreateClientConnectorServiceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateClientConnectorService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> PollOnceCreateClientConnectorService(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateClientConnectorServiceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateClientConnectorService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata>> PollOnceCreateClientConnectorServiceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateClientConnectorServiceOperationsClient, callSettings);

        /// <summary>
        /// Creates a new ClientConnectorService in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="clientConnectorService">
        /// Required. The resource being created.
        /// </param>
        /// <param name="clientConnectorServiceId">
        /// Optional. User-settable client connector service resource ID.
        /// * Must start with a letter.
        /// * Must contain between 4-63 characters from `/[a-z][0-9]-/`.
        /// * Must end with a number or a letter.
        /// 
        /// A random system generated name will be assigned
        /// if not specified by the user.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> CreateClientConnectorService(string parent, ClientConnectorService clientConnectorService, string clientConnectorServiceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateClientConnectorService(new CreateClientConnectorServiceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ClientConnectorServiceId = clientConnectorServiceId ?? "",
                ClientConnectorService = gax::GaxPreconditions.CheckNotNull(clientConnectorService, nameof(clientConnectorService)),
            }, callSettings);

        /// <summary>
        /// Creates a new ClientConnectorService in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="clientConnectorService">
        /// Required. The resource being created.
        /// </param>
        /// <param name="clientConnectorServiceId">
        /// Optional. User-settable client connector service resource ID.
        /// * Must start with a letter.
        /// * Must contain between 4-63 characters from `/[a-z][0-9]-/`.
        /// * Must end with a number or a letter.
        /// 
        /// A random system generated name will be assigned
        /// if not specified by the user.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata>> CreateClientConnectorServiceAsync(string parent, ClientConnectorService clientConnectorService, string clientConnectorServiceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateClientConnectorServiceAsync(new CreateClientConnectorServiceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ClientConnectorServiceId = clientConnectorServiceId ?? "",
                ClientConnectorService = gax::GaxPreconditions.CheckNotNull(clientConnectorService, nameof(clientConnectorService)),
            }, callSettings);

        /// <summary>
        /// Creates a new ClientConnectorService in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="clientConnectorService">
        /// Required. The resource being created.
        /// </param>
        /// <param name="clientConnectorServiceId">
        /// Optional. User-settable client connector service resource ID.
        /// * Must start with a letter.
        /// * Must contain between 4-63 characters from `/[a-z][0-9]-/`.
        /// * Must end with a number or a letter.
        /// 
        /// A random system generated name will be assigned
        /// if not specified by the user.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata>> CreateClientConnectorServiceAsync(string parent, ClientConnectorService clientConnectorService, string clientConnectorServiceId, st::CancellationToken cancellationToken) =>
            CreateClientConnectorServiceAsync(parent, clientConnectorService, clientConnectorServiceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ClientConnectorService in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="clientConnectorService">
        /// Required. The resource being created.
        /// </param>
        /// <param name="clientConnectorServiceId">
        /// Optional. User-settable client connector service resource ID.
        /// * Must start with a letter.
        /// * Must contain between 4-63 characters from `/[a-z][0-9]-/`.
        /// * Must end with a number or a letter.
        /// 
        /// A random system generated name will be assigned
        /// if not specified by the user.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> CreateClientConnectorService(gagr::LocationName parent, ClientConnectorService clientConnectorService, string clientConnectorServiceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateClientConnectorService(new CreateClientConnectorServiceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ClientConnectorServiceId = clientConnectorServiceId ?? "",
                ClientConnectorService = gax::GaxPreconditions.CheckNotNull(clientConnectorService, nameof(clientConnectorService)),
            }, callSettings);

        /// <summary>
        /// Creates a new ClientConnectorService in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="clientConnectorService">
        /// Required. The resource being created.
        /// </param>
        /// <param name="clientConnectorServiceId">
        /// Optional. User-settable client connector service resource ID.
        /// * Must start with a letter.
        /// * Must contain between 4-63 characters from `/[a-z][0-9]-/`.
        /// * Must end with a number or a letter.
        /// 
        /// A random system generated name will be assigned
        /// if not specified by the user.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata>> CreateClientConnectorServiceAsync(gagr::LocationName parent, ClientConnectorService clientConnectorService, string clientConnectorServiceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateClientConnectorServiceAsync(new CreateClientConnectorServiceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ClientConnectorServiceId = clientConnectorServiceId ?? "",
                ClientConnectorService = gax::GaxPreconditions.CheckNotNull(clientConnectorService, nameof(clientConnectorService)),
            }, callSettings);

        /// <summary>
        /// Creates a new ClientConnectorService in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="clientConnectorService">
        /// Required. The resource being created.
        /// </param>
        /// <param name="clientConnectorServiceId">
        /// Optional. User-settable client connector service resource ID.
        /// * Must start with a letter.
        /// * Must contain between 4-63 characters from `/[a-z][0-9]-/`.
        /// * Must end with a number or a letter.
        /// 
        /// A random system generated name will be assigned
        /// if not specified by the user.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata>> CreateClientConnectorServiceAsync(gagr::LocationName parent, ClientConnectorService clientConnectorService, string clientConnectorServiceId, st::CancellationToken cancellationToken) =>
            CreateClientConnectorServiceAsync(parent, clientConnectorService, clientConnectorServiceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single ClientConnectorService.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> UpdateClientConnectorService(UpdateClientConnectorServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single ClientConnectorService.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata>> UpdateClientConnectorServiceAsync(UpdateClientConnectorServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single ClientConnectorService.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata>> UpdateClientConnectorServiceAsync(UpdateClientConnectorServiceRequest request, st::CancellationToken cancellationToken) =>
            UpdateClientConnectorServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateClientConnectorService</c>.</summary>
        public virtual lro::OperationsClient UpdateClientConnectorServiceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateClientConnectorService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> PollOnceUpdateClientConnectorService(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateClientConnectorServiceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateClientConnectorService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata>> PollOnceUpdateClientConnectorServiceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateClientConnectorServiceOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single ClientConnectorService.
        /// </summary>
        /// <param name="clientConnectorService">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// ClientConnectorService resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// 
        /// Mutable fields: display_name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> UpdateClientConnectorService(ClientConnectorService clientConnectorService, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateClientConnectorService(new UpdateClientConnectorServiceRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                ClientConnectorService = gax::GaxPreconditions.CheckNotNull(clientConnectorService, nameof(clientConnectorService)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single ClientConnectorService.
        /// </summary>
        /// <param name="clientConnectorService">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// ClientConnectorService resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// 
        /// Mutable fields: display_name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata>> UpdateClientConnectorServiceAsync(ClientConnectorService clientConnectorService, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateClientConnectorServiceAsync(new UpdateClientConnectorServiceRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                ClientConnectorService = gax::GaxPreconditions.CheckNotNull(clientConnectorService, nameof(clientConnectorService)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single ClientConnectorService.
        /// </summary>
        /// <param name="clientConnectorService">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// ClientConnectorService resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// 
        /// Mutable fields: display_name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata>> UpdateClientConnectorServiceAsync(ClientConnectorService clientConnectorService, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateClientConnectorServiceAsync(clientConnectorService, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ClientConnectorService.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, ClientConnectorServiceOperationMetadata> DeleteClientConnectorService(DeleteClientConnectorServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ClientConnectorService.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, ClientConnectorServiceOperationMetadata>> DeleteClientConnectorServiceAsync(DeleteClientConnectorServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ClientConnectorService.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, ClientConnectorServiceOperationMetadata>> DeleteClientConnectorServiceAsync(DeleteClientConnectorServiceRequest request, st::CancellationToken cancellationToken) =>
            DeleteClientConnectorServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteClientConnectorService</c>.</summary>
        public virtual lro::OperationsClient DeleteClientConnectorServiceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteClientConnectorService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, ClientConnectorServiceOperationMetadata> PollOnceDeleteClientConnectorService(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, ClientConnectorServiceOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteClientConnectorServiceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteClientConnectorService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, ClientConnectorServiceOperationMetadata>> PollOnceDeleteClientConnectorServiceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, ClientConnectorServiceOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteClientConnectorServiceOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single ClientConnectorService.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, ClientConnectorServiceOperationMetadata> DeleteClientConnectorService(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteClientConnectorService(new DeleteClientConnectorServiceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ClientConnectorService.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, ClientConnectorServiceOperationMetadata>> DeleteClientConnectorServiceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteClientConnectorServiceAsync(new DeleteClientConnectorServiceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ClientConnectorService.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, ClientConnectorServiceOperationMetadata>> DeleteClientConnectorServiceAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteClientConnectorServiceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ClientConnectorService.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, ClientConnectorServiceOperationMetadata> DeleteClientConnectorService(ClientConnectorServiceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteClientConnectorService(new DeleteClientConnectorServiceRequest
            {
                ClientConnectorServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ClientConnectorService.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, ClientConnectorServiceOperationMetadata>> DeleteClientConnectorServiceAsync(ClientConnectorServiceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteClientConnectorServiceAsync(new DeleteClientConnectorServiceRequest
            {
                ClientConnectorServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ClientConnectorService.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, ClientConnectorServiceOperationMetadata>> DeleteClientConnectorServiceAsync(ClientConnectorServiceName name, st::CancellationToken cancellationToken) =>
            DeleteClientConnectorServiceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ClientConnectorServicesService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// API Overview:
    /// 
    /// The `beyondcorp.googleapis.com` service implements the Google Cloud
    /// BeyondCorp API.
    /// 
    /// Data Model:
    /// 
    /// The ClientConnectorServicesService exposes the following resources:
    /// 
    /// * Client Connector Services, named as follows:
    /// `projects/{project_id}/locations/{location_id}/client_connector_services/{client_connector_service_id}`.
    /// </remarks>
    public sealed partial class ClientConnectorServicesServiceClientImpl : ClientConnectorServicesServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListClientConnectorServicesRequest, ListClientConnectorServicesResponse> _callListClientConnectorServices;

        private readonly gaxgrpc::ApiCall<GetClientConnectorServiceRequest, ClientConnectorService> _callGetClientConnectorService;

        private readonly gaxgrpc::ApiCall<CreateClientConnectorServiceRequest, lro::Operation> _callCreateClientConnectorService;

        private readonly gaxgrpc::ApiCall<UpdateClientConnectorServiceRequest, lro::Operation> _callUpdateClientConnectorService;

        private readonly gaxgrpc::ApiCall<DeleteClientConnectorServiceRequest, lro::Operation> _callDeleteClientConnectorService;

        /// <summary>
        /// Constructs a client wrapper for the ClientConnectorServicesService service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="ClientConnectorServicesServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ClientConnectorServicesServiceClientImpl(ClientConnectorServicesService.ClientConnectorServicesServiceClient grpcClient, ClientConnectorServicesServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ClientConnectorServicesServiceSettings effectiveSettings = settings ?? ClientConnectorServicesServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            CreateClientConnectorServiceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateClientConnectorServiceOperationsSettings, logger);
            UpdateClientConnectorServiceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateClientConnectorServiceOperationsSettings, logger);
            DeleteClientConnectorServiceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteClientConnectorServiceOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListClientConnectorServices = clientHelper.BuildApiCall<ListClientConnectorServicesRequest, ListClientConnectorServicesResponse>("ListClientConnectorServices", grpcClient.ListClientConnectorServicesAsync, grpcClient.ListClientConnectorServices, effectiveSettings.ListClientConnectorServicesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListClientConnectorServices);
            Modify_ListClientConnectorServicesApiCall(ref _callListClientConnectorServices);
            _callGetClientConnectorService = clientHelper.BuildApiCall<GetClientConnectorServiceRequest, ClientConnectorService>("GetClientConnectorService", grpcClient.GetClientConnectorServiceAsync, grpcClient.GetClientConnectorService, effectiveSettings.GetClientConnectorServiceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetClientConnectorService);
            Modify_GetClientConnectorServiceApiCall(ref _callGetClientConnectorService);
            _callCreateClientConnectorService = clientHelper.BuildApiCall<CreateClientConnectorServiceRequest, lro::Operation>("CreateClientConnectorService", grpcClient.CreateClientConnectorServiceAsync, grpcClient.CreateClientConnectorService, effectiveSettings.CreateClientConnectorServiceSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateClientConnectorService);
            Modify_CreateClientConnectorServiceApiCall(ref _callCreateClientConnectorService);
            _callUpdateClientConnectorService = clientHelper.BuildApiCall<UpdateClientConnectorServiceRequest, lro::Operation>("UpdateClientConnectorService", grpcClient.UpdateClientConnectorServiceAsync, grpcClient.UpdateClientConnectorService, effectiveSettings.UpdateClientConnectorServiceSettings).WithGoogleRequestParam("client_connector_service.name", request => request.ClientConnectorService?.Name);
            Modify_ApiCall(ref _callUpdateClientConnectorService);
            Modify_UpdateClientConnectorServiceApiCall(ref _callUpdateClientConnectorService);
            _callDeleteClientConnectorService = clientHelper.BuildApiCall<DeleteClientConnectorServiceRequest, lro::Operation>("DeleteClientConnectorService", grpcClient.DeleteClientConnectorServiceAsync, grpcClient.DeleteClientConnectorService, effectiveSettings.DeleteClientConnectorServiceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteClientConnectorService);
            Modify_DeleteClientConnectorServiceApiCall(ref _callDeleteClientConnectorService);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListClientConnectorServicesApiCall(ref gaxgrpc::ApiCall<ListClientConnectorServicesRequest, ListClientConnectorServicesResponse> call);

        partial void Modify_GetClientConnectorServiceApiCall(ref gaxgrpc::ApiCall<GetClientConnectorServiceRequest, ClientConnectorService> call);

        partial void Modify_CreateClientConnectorServiceApiCall(ref gaxgrpc::ApiCall<CreateClientConnectorServiceRequest, lro::Operation> call);

        partial void Modify_UpdateClientConnectorServiceApiCall(ref gaxgrpc::ApiCall<UpdateClientConnectorServiceRequest, lro::Operation> call);

        partial void Modify_DeleteClientConnectorServiceApiCall(ref gaxgrpc::ApiCall<DeleteClientConnectorServiceRequest, lro::Operation> call);

        partial void OnConstruction(ClientConnectorServicesService.ClientConnectorServicesServiceClient grpcClient, ClientConnectorServicesServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ClientConnectorServicesService client</summary>
        public override ClientConnectorServicesService.ClientConnectorServicesServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListClientConnectorServicesRequest(ref ListClientConnectorServicesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetClientConnectorServiceRequest(ref GetClientConnectorServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateClientConnectorServiceRequest(ref CreateClientConnectorServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateClientConnectorServiceRequest(ref UpdateClientConnectorServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteClientConnectorServiceRequest(ref DeleteClientConnectorServiceRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists ClientConnectorServices in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ClientConnectorService"/> resources.</returns>
        public override gax::PagedEnumerable<ListClientConnectorServicesResponse, ClientConnectorService> ListClientConnectorServices(ListClientConnectorServicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListClientConnectorServicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListClientConnectorServicesRequest, ListClientConnectorServicesResponse, ClientConnectorService>(_callListClientConnectorServices, request, callSettings);
        }

        /// <summary>
        /// Lists ClientConnectorServices in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ClientConnectorService"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListClientConnectorServicesResponse, ClientConnectorService> ListClientConnectorServicesAsync(ListClientConnectorServicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListClientConnectorServicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListClientConnectorServicesRequest, ListClientConnectorServicesResponse, ClientConnectorService>(_callListClientConnectorServices, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ClientConnectorService.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ClientConnectorService GetClientConnectorService(GetClientConnectorServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetClientConnectorServiceRequest(ref request, ref callSettings);
            return _callGetClientConnectorService.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ClientConnectorService.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ClientConnectorService> GetClientConnectorServiceAsync(GetClientConnectorServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetClientConnectorServiceRequest(ref request, ref callSettings);
            return _callGetClientConnectorService.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateClientConnectorService</c>.</summary>
        public override lro::OperationsClient CreateClientConnectorServiceOperationsClient { get; }

        /// <summary>
        /// Creates a new ClientConnectorService in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> CreateClientConnectorService(CreateClientConnectorServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateClientConnectorServiceRequest(ref request, ref callSettings);
            return new lro::Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata>(_callCreateClientConnectorService.Sync(request, callSettings), CreateClientConnectorServiceOperationsClient);
        }

        /// <summary>
        /// Creates a new ClientConnectorService in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata>> CreateClientConnectorServiceAsync(CreateClientConnectorServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateClientConnectorServiceRequest(ref request, ref callSettings);
            return new lro::Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata>(await _callCreateClientConnectorService.Async(request, callSettings).ConfigureAwait(false), CreateClientConnectorServiceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateClientConnectorService</c>.</summary>
        public override lro::OperationsClient UpdateClientConnectorServiceOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single ClientConnectorService.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata> UpdateClientConnectorService(UpdateClientConnectorServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateClientConnectorServiceRequest(ref request, ref callSettings);
            return new lro::Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata>(_callUpdateClientConnectorService.Sync(request, callSettings), UpdateClientConnectorServiceOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single ClientConnectorService.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata>> UpdateClientConnectorServiceAsync(UpdateClientConnectorServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateClientConnectorServiceRequest(ref request, ref callSettings);
            return new lro::Operation<ClientConnectorService, ClientConnectorServiceOperationMetadata>(await _callUpdateClientConnectorService.Async(request, callSettings).ConfigureAwait(false), UpdateClientConnectorServiceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteClientConnectorService</c>.</summary>
        public override lro::OperationsClient DeleteClientConnectorServiceOperationsClient { get; }

        /// <summary>
        /// Deletes a single ClientConnectorService.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, ClientConnectorServiceOperationMetadata> DeleteClientConnectorService(DeleteClientConnectorServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteClientConnectorServiceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, ClientConnectorServiceOperationMetadata>(_callDeleteClientConnectorService.Sync(request, callSettings), DeleteClientConnectorServiceOperationsClient);
        }

        /// <summary>
        /// Deletes a single ClientConnectorService.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, ClientConnectorServiceOperationMetadata>> DeleteClientConnectorServiceAsync(DeleteClientConnectorServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteClientConnectorServiceRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, ClientConnectorServiceOperationMetadata>(await _callDeleteClientConnectorService.Async(request, callSettings).ConfigureAwait(false), DeleteClientConnectorServiceOperationsClient);
        }
    }

    public partial class ListClientConnectorServicesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListClientConnectorServicesResponse : gaxgrpc::IPageResponse<ClientConnectorService>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ClientConnectorService> GetEnumerator() => ClientConnectorServices.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ClientConnectorServicesService
    {
        public partial class ClientConnectorServicesServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() =>
                new lro::Operations.OperationsClient(CallInvoker);
        }
    }

    public static partial class ClientConnectorServicesService
    {
        public partial class ClientConnectorServicesServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="gcl::Locations.LocationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gcl::Locations.LocationsClient"/> for the same target as this client.
            /// </returns>
            public virtual gcl::Locations.LocationsClient CreateLocationsClient() =>
                new gcl::Locations.LocationsClient(CallInvoker);

            /// <summary>
            /// Creates a new instance of <see cref="gciv::IAMPolicy.IAMPolicyClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gciv::IAMPolicy.IAMPolicyClient"/> for the same target as this client.
            /// </returns>
            public virtual gciv::IAMPolicy.IAMPolicyClient CreateIAMPolicyClient() =>
                new gciv::IAMPolicy.IAMPolicyClient(CallInvoker);
        }
    }
}
