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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gcl = Google.Cloud.Location;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using lro = Google.LongRunning;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.VpcAccess.V1
{
    /// <summary>Settings for <see cref="VpcAccessServiceClient"/> instances.</summary>
    public sealed partial class VpcAccessServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="VpcAccessServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="VpcAccessServiceSettings"/>.</returns>
        public static VpcAccessServiceSettings GetDefault() => new VpcAccessServiceSettings();

        /// <summary>Constructs a new <see cref="VpcAccessServiceSettings"/> object with default settings.</summary>
        public VpcAccessServiceSettings()
        {
        }

        private VpcAccessServiceSettings(VpcAccessServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateConnectorSettings = existing.CreateConnectorSettings;
            CreateConnectorOperationsSettings = existing.CreateConnectorOperationsSettings.Clone();
            GetConnectorSettings = existing.GetConnectorSettings;
            ListConnectorsSettings = existing.ListConnectorsSettings;
            DeleteConnectorSettings = existing.DeleteConnectorSettings;
            DeleteConnectorOperationsSettings = existing.DeleteConnectorOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(VpcAccessServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VpcAccessServiceClient.CreateConnector</c> and <c>VpcAccessServiceClient.CreateConnectorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateConnectorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VpcAccessServiceClient.CreateConnector</c> and
        /// <c>VpcAccessServiceClient.CreateConnectorAsync</c>.
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
        public lro::OperationsSettings CreateConnectorOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VpcAccessServiceClient.GetConnector</c> and <c>VpcAccessServiceClient.GetConnectorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetConnectorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VpcAccessServiceClient.ListConnectors</c> and <c>VpcAccessServiceClient.ListConnectorsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListConnectorsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>VpcAccessServiceClient.DeleteConnector</c> and <c>VpcAccessServiceClient.DeleteConnectorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteConnectorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VpcAccessServiceClient.DeleteConnector</c> and
        /// <c>VpcAccessServiceClient.DeleteConnectorAsync</c>.
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
        public lro::OperationsSettings DeleteConnectorOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="VpcAccessServiceSettings"/> object.</returns>
        public VpcAccessServiceSettings Clone() => new VpcAccessServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="VpcAccessServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class VpcAccessServiceClientBuilder : gaxgrpc::ClientBuilderBase<VpcAccessServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public VpcAccessServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public VpcAccessServiceClientBuilder() : base(VpcAccessServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref VpcAccessServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<VpcAccessServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override VpcAccessServiceClient Build()
        {
            VpcAccessServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<VpcAccessServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<VpcAccessServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private VpcAccessServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return VpcAccessServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<VpcAccessServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return VpcAccessServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => VpcAccessServiceClient.ChannelPool;
    }

    /// <summary>VpcAccessService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Serverless VPC Access API allows users to create and manage connectors for
    /// App Engine, Cloud Functions and Cloud Run to have internal connections to
    /// Virtual Private Cloud networks.
    /// </remarks>
    public abstract partial class VpcAccessServiceClient
    {
        /// <summary>
        /// The default endpoint for the VpcAccessService service, which is a host of "vpcaccess.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "vpcaccess.googleapis.com:443";

        /// <summary>The default VpcAccessService scopes.</summary>
        /// <remarks>
        /// The default VpcAccessService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(VpcAccessService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="VpcAccessServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="VpcAccessServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="VpcAccessServiceClient"/>.</returns>
        public static stt::Task<VpcAccessServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new VpcAccessServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="VpcAccessServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="VpcAccessServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="VpcAccessServiceClient"/>.</returns>
        public static VpcAccessServiceClient Create() => new VpcAccessServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="VpcAccessServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="VpcAccessServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="VpcAccessServiceClient"/>.</returns>
        internal static VpcAccessServiceClient Create(grpccore::CallInvoker callInvoker, VpcAccessServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            VpcAccessService.VpcAccessServiceClient grpcClient = new VpcAccessService.VpcAccessServiceClient(callInvoker);
            return new VpcAccessServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC VpcAccessService client</summary>
        public virtual VpcAccessService.VpcAccessServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Serverless VPC Access connector, returns an operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Connector, OperationMetadata> CreateConnector(CreateConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Serverless VPC Access connector, returns an operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Connector, OperationMetadata>> CreateConnectorAsync(CreateConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Serverless VPC Access connector, returns an operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Connector, OperationMetadata>> CreateConnectorAsync(CreateConnectorRequest request, st::CancellationToken cancellationToken) =>
            CreateConnectorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateConnector</c>.</summary>
        public virtual lro::OperationsClient CreateConnectorOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateConnector</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Connector, OperationMetadata> PollOnceCreateConnector(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Connector, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateConnectorOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateConnector</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Connector, OperationMetadata>> PollOnceCreateConnectorAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Connector, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateConnectorOperationsClient, callSettings);

        /// <summary>
        /// Creates a Serverless VPC Access connector, returns an operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location in which the configuration should be created,
        /// specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="connectorId">
        /// Required. The ID to use for this connector.
        /// </param>
        /// <param name="connector">
        /// Required. Resource to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Connector, OperationMetadata> CreateConnector(string parent, string connectorId, Connector connector, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnector(new CreateConnectorRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ConnectorId = gax::GaxPreconditions.CheckNotNullOrEmpty(connectorId, nameof(connectorId)),
                Connector = gax::GaxPreconditions.CheckNotNull(connector, nameof(connector)),
            }, callSettings);

        /// <summary>
        /// Creates a Serverless VPC Access connector, returns an operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location in which the configuration should be created,
        /// specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="connectorId">
        /// Required. The ID to use for this connector.
        /// </param>
        /// <param name="connector">
        /// Required. Resource to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Connector, OperationMetadata>> CreateConnectorAsync(string parent, string connectorId, Connector connector, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnectorAsync(new CreateConnectorRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ConnectorId = gax::GaxPreconditions.CheckNotNullOrEmpty(connectorId, nameof(connectorId)),
                Connector = gax::GaxPreconditions.CheckNotNull(connector, nameof(connector)),
            }, callSettings);

        /// <summary>
        /// Creates a Serverless VPC Access connector, returns an operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location in which the configuration should be created,
        /// specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="connectorId">
        /// Required. The ID to use for this connector.
        /// </param>
        /// <param name="connector">
        /// Required. Resource to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Connector, OperationMetadata>> CreateConnectorAsync(string parent, string connectorId, Connector connector, st::CancellationToken cancellationToken) =>
            CreateConnectorAsync(parent, connectorId, connector, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Serverless VPC Access connector, returns an operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location in which the configuration should be created,
        /// specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="connectorId">
        /// Required. The ID to use for this connector.
        /// </param>
        /// <param name="connector">
        /// Required. Resource to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Connector, OperationMetadata> CreateConnector(gagr::LocationName parent, string connectorId, Connector connector, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnector(new CreateConnectorRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ConnectorId = gax::GaxPreconditions.CheckNotNullOrEmpty(connectorId, nameof(connectorId)),
                Connector = gax::GaxPreconditions.CheckNotNull(connector, nameof(connector)),
            }, callSettings);

        /// <summary>
        /// Creates a Serverless VPC Access connector, returns an operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location in which the configuration should be created,
        /// specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="connectorId">
        /// Required. The ID to use for this connector.
        /// </param>
        /// <param name="connector">
        /// Required. Resource to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Connector, OperationMetadata>> CreateConnectorAsync(gagr::LocationName parent, string connectorId, Connector connector, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnectorAsync(new CreateConnectorRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ConnectorId = gax::GaxPreconditions.CheckNotNullOrEmpty(connectorId, nameof(connectorId)),
                Connector = gax::GaxPreconditions.CheckNotNull(connector, nameof(connector)),
            }, callSettings);

        /// <summary>
        /// Creates a Serverless VPC Access connector, returns an operation.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location in which the configuration should be created,
        /// specified in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="connectorId">
        /// Required. The ID to use for this connector.
        /// </param>
        /// <param name="connector">
        /// Required. Resource to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Connector, OperationMetadata>> CreateConnectorAsync(gagr::LocationName parent, string connectorId, Connector connector, st::CancellationToken cancellationToken) =>
            CreateConnectorAsync(parent, connectorId, connector, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Serverless VPC Access connector. Returns NOT_FOUND if the resource
        /// does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Connector GetConnector(GetConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a Serverless VPC Access connector. Returns NOT_FOUND if the resource
        /// does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connector> GetConnectorAsync(GetConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a Serverless VPC Access connector. Returns NOT_FOUND if the resource
        /// does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connector> GetConnectorAsync(GetConnectorRequest request, st::CancellationToken cancellationToken) =>
            GetConnectorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Serverless VPC Access connector. Returns NOT_FOUND if the resource
        /// does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. Name of a Serverless VPC Access connector to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Connector GetConnector(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnector(new GetConnectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Serverless VPC Access connector. Returns NOT_FOUND if the resource
        /// does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. Name of a Serverless VPC Access connector to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connector> GetConnectorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectorAsync(new GetConnectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Serverless VPC Access connector. Returns NOT_FOUND if the resource
        /// does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. Name of a Serverless VPC Access connector to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connector> GetConnectorAsync(string name, st::CancellationToken cancellationToken) =>
            GetConnectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a Serverless VPC Access connector. Returns NOT_FOUND if the resource
        /// does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. Name of a Serverless VPC Access connector to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Connector GetConnector(ConnectorName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnector(new GetConnectorRequest
            {
                ConnectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Serverless VPC Access connector. Returns NOT_FOUND if the resource
        /// does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. Name of a Serverless VPC Access connector to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connector> GetConnectorAsync(ConnectorName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectorAsync(new GetConnectorRequest
            {
                ConnectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a Serverless VPC Access connector. Returns NOT_FOUND if the resource
        /// does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. Name of a Serverless VPC Access connector to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connector> GetConnectorAsync(ConnectorName name, st::CancellationToken cancellationToken) =>
            GetConnectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Serverless VPC Access connectors.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Connector"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConnectorsResponse, Connector> ListConnectors(ListConnectorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Serverless VPC Access connectors.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Connector"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConnectorsResponse, Connector> ListConnectorsAsync(ListConnectorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Serverless VPC Access connectors.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the routes should be listed.
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
        /// <returns>A pageable sequence of <see cref="Connector"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConnectorsResponse, Connector> ListConnectors(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectorsRequest request = new ListConnectorsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListConnectors(request, callSettings);
        }

        /// <summary>
        /// Lists Serverless VPC Access connectors.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the routes should be listed.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Connector"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConnectorsResponse, Connector> ListConnectorsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectorsRequest request = new ListConnectorsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListConnectorsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Serverless VPC Access connectors.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the routes should be listed.
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
        /// <returns>A pageable sequence of <see cref="Connector"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConnectorsResponse, Connector> ListConnectors(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectorsRequest request = new ListConnectorsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListConnectors(request, callSettings);
        }

        /// <summary>
        /// Lists Serverless VPC Access connectors.
        /// </summary>
        /// <param name="parent">
        /// Required. The project and location from which the routes should be listed.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Connector"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConnectorsResponse, Connector> ListConnectorsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectorsRequest request = new ListConnectorsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListConnectorsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a Serverless VPC Access connector. Returns NOT_FOUND if the
        /// resource does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteConnector(DeleteConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Serverless VPC Access connector. Returns NOT_FOUND if the
        /// resource does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectorAsync(DeleteConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a Serverless VPC Access connector. Returns NOT_FOUND if the
        /// resource does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectorAsync(DeleteConnectorRequest request, st::CancellationToken cancellationToken) =>
            DeleteConnectorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteConnector</c>.</summary>
        public virtual lro::OperationsClient DeleteConnectorOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteConnector</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteConnector(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteConnectorOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteConnector</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteConnectorAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteConnectorOperationsClient, callSettings);

        /// <summary>
        /// Deletes a Serverless VPC Access connector. Returns NOT_FOUND if the
        /// resource does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. Name of a Serverless VPC Access connector to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteConnector(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnector(new DeleteConnectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Serverless VPC Access connector. Returns NOT_FOUND if the
        /// resource does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. Name of a Serverless VPC Access connector to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnectorAsync(new DeleteConnectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Serverless VPC Access connector. Returns NOT_FOUND if the
        /// resource does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. Name of a Serverless VPC Access connector to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectorAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteConnectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a Serverless VPC Access connector. Returns NOT_FOUND if the
        /// resource does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. Name of a Serverless VPC Access connector to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteConnector(ConnectorName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnector(new DeleteConnectorRequest
            {
                ConnectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Serverless VPC Access connector. Returns NOT_FOUND if the
        /// resource does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. Name of a Serverless VPC Access connector to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectorAsync(ConnectorName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnectorAsync(new DeleteConnectorRequest
            {
                ConnectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a Serverless VPC Access connector. Returns NOT_FOUND if the
        /// resource does not exist.
        /// </summary>
        /// <param name="name">
        /// Required. Name of a Serverless VPC Access connector to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectorAsync(ConnectorName name, st::CancellationToken cancellationToken) =>
            DeleteConnectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>VpcAccessService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Serverless VPC Access API allows users to create and manage connectors for
    /// App Engine, Cloud Functions and Cloud Run to have internal connections to
    /// Virtual Private Cloud networks.
    /// </remarks>
    public sealed partial class VpcAccessServiceClientImpl : VpcAccessServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateConnectorRequest, lro::Operation> _callCreateConnector;

        private readonly gaxgrpc::ApiCall<GetConnectorRequest, Connector> _callGetConnector;

        private readonly gaxgrpc::ApiCall<ListConnectorsRequest, ListConnectorsResponse> _callListConnectors;

        private readonly gaxgrpc::ApiCall<DeleteConnectorRequest, lro::Operation> _callDeleteConnector;

        /// <summary>
        /// Constructs a client wrapper for the VpcAccessService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="VpcAccessServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public VpcAccessServiceClientImpl(VpcAccessService.VpcAccessServiceClient grpcClient, VpcAccessServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            VpcAccessServiceSettings effectiveSettings = settings ?? VpcAccessServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateConnectorOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateConnectorOperationsSettings, logger);
            DeleteConnectorOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteConnectorOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callCreateConnector = clientHelper.BuildApiCall<CreateConnectorRequest, lro::Operation>("CreateConnector", grpcClient.CreateConnectorAsync, grpcClient.CreateConnector, effectiveSettings.CreateConnectorSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateConnector);
            Modify_CreateConnectorApiCall(ref _callCreateConnector);
            _callGetConnector = clientHelper.BuildApiCall<GetConnectorRequest, Connector>("GetConnector", grpcClient.GetConnectorAsync, grpcClient.GetConnector, effectiveSettings.GetConnectorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetConnector);
            Modify_GetConnectorApiCall(ref _callGetConnector);
            _callListConnectors = clientHelper.BuildApiCall<ListConnectorsRequest, ListConnectorsResponse>("ListConnectors", grpcClient.ListConnectorsAsync, grpcClient.ListConnectors, effectiveSettings.ListConnectorsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListConnectors);
            Modify_ListConnectorsApiCall(ref _callListConnectors);
            _callDeleteConnector = clientHelper.BuildApiCall<DeleteConnectorRequest, lro::Operation>("DeleteConnector", grpcClient.DeleteConnectorAsync, grpcClient.DeleteConnector, effectiveSettings.DeleteConnectorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteConnector);
            Modify_DeleteConnectorApiCall(ref _callDeleteConnector);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateConnectorApiCall(ref gaxgrpc::ApiCall<CreateConnectorRequest, lro::Operation> call);

        partial void Modify_GetConnectorApiCall(ref gaxgrpc::ApiCall<GetConnectorRequest, Connector> call);

        partial void Modify_ListConnectorsApiCall(ref gaxgrpc::ApiCall<ListConnectorsRequest, ListConnectorsResponse> call);

        partial void Modify_DeleteConnectorApiCall(ref gaxgrpc::ApiCall<DeleteConnectorRequest, lro::Operation> call);

        partial void OnConstruction(VpcAccessService.VpcAccessServiceClient grpcClient, VpcAccessServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC VpcAccessService client</summary>
        public override VpcAccessService.VpcAccessServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_CreateConnectorRequest(ref CreateConnectorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetConnectorRequest(ref GetConnectorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListConnectorsRequest(ref ListConnectorsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteConnectorRequest(ref DeleteConnectorRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateConnector</c>.</summary>
        public override lro::OperationsClient CreateConnectorOperationsClient { get; }

        /// <summary>
        /// Creates a Serverless VPC Access connector, returns an operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Connector, OperationMetadata> CreateConnector(CreateConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConnectorRequest(ref request, ref callSettings);
            return new lro::Operation<Connector, OperationMetadata>(_callCreateConnector.Sync(request, callSettings), CreateConnectorOperationsClient);
        }

        /// <summary>
        /// Creates a Serverless VPC Access connector, returns an operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Connector, OperationMetadata>> CreateConnectorAsync(CreateConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConnectorRequest(ref request, ref callSettings);
            return new lro::Operation<Connector, OperationMetadata>(await _callCreateConnector.Async(request, callSettings).ConfigureAwait(false), CreateConnectorOperationsClient);
        }

        /// <summary>
        /// Gets a Serverless VPC Access connector. Returns NOT_FOUND if the resource
        /// does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Connector GetConnector(GetConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConnectorRequest(ref request, ref callSettings);
            return _callGetConnector.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a Serverless VPC Access connector. Returns NOT_FOUND if the resource
        /// does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Connector> GetConnectorAsync(GetConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConnectorRequest(ref request, ref callSettings);
            return _callGetConnector.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Serverless VPC Access connectors.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Connector"/> resources.</returns>
        public override gax::PagedEnumerable<ListConnectorsResponse, Connector> ListConnectors(ListConnectorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConnectorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListConnectorsRequest, ListConnectorsResponse, Connector>(_callListConnectors, request, callSettings);
        }

        /// <summary>
        /// Lists Serverless VPC Access connectors.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Connector"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListConnectorsResponse, Connector> ListConnectorsAsync(ListConnectorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConnectorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListConnectorsRequest, ListConnectorsResponse, Connector>(_callListConnectors, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteConnector</c>.</summary>
        public override lro::OperationsClient DeleteConnectorOperationsClient { get; }

        /// <summary>
        /// Deletes a Serverless VPC Access connector. Returns NOT_FOUND if the
        /// resource does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteConnector(DeleteConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConnectorRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteConnector.Sync(request, callSettings), DeleteConnectorOperationsClient);
        }

        /// <summary>
        /// Deletes a Serverless VPC Access connector. Returns NOT_FOUND if the
        /// resource does not exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectorAsync(DeleteConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConnectorRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteConnector.Async(request, callSettings).ConfigureAwait(false), DeleteConnectorOperationsClient);
        }
    }

    public partial class ListConnectorsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListConnectorsResponse : gaxgrpc::IPageResponse<Connector>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Connector> GetEnumerator() => Connectors.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class VpcAccessService
    {
        public partial class VpcAccessServiceClient
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

    public static partial class VpcAccessService
    {
        public partial class VpcAccessServiceClient
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
        }
    }
}
