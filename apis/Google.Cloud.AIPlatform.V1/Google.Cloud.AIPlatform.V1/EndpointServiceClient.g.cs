// Copyright 2024 Google LLC
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
using gciv = Google.Cloud.Iam.V1;
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

namespace Google.Cloud.AIPlatform.V1
{
    /// <summary>Settings for <see cref="EndpointServiceClient"/> instances.</summary>
    public sealed partial class EndpointServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="EndpointServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="EndpointServiceSettings"/>.</returns>
        public static EndpointServiceSettings GetDefault() => new EndpointServiceSettings();

        /// <summary>Constructs a new <see cref="EndpointServiceSettings"/> object with default settings.</summary>
        public EndpointServiceSettings()
        {
        }

        private EndpointServiceSettings(EndpointServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateEndpointSettings = existing.CreateEndpointSettings;
            CreateEndpointOperationsSettings = existing.CreateEndpointOperationsSettings.Clone();
            GetEndpointSettings = existing.GetEndpointSettings;
            ListEndpointsSettings = existing.ListEndpointsSettings;
            UpdateEndpointSettings = existing.UpdateEndpointSettings;
            UpdateEndpointLongRunningSettings = existing.UpdateEndpointLongRunningSettings;
            UpdateEndpointLongRunningOperationsSettings = existing.UpdateEndpointLongRunningOperationsSettings.Clone();
            DeleteEndpointSettings = existing.DeleteEndpointSettings;
            DeleteEndpointOperationsSettings = existing.DeleteEndpointOperationsSettings.Clone();
            DeployModelSettings = existing.DeployModelSettings;
            DeployModelOperationsSettings = existing.DeployModelOperationsSettings.Clone();
            UndeployModelSettings = existing.UndeployModelSettings;
            UndeployModelOperationsSettings = existing.UndeployModelOperationsSettings.Clone();
            MutateDeployedModelSettings = existing.MutateDeployedModelSettings;
            MutateDeployedModelOperationsSettings = existing.MutateDeployedModelOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(EndpointServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EndpointServiceClient.CreateEndpoint</c> and <c>EndpointServiceClient.CreateEndpointAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateEndpointSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>EndpointServiceClient.CreateEndpoint</c> and
        /// <c>EndpointServiceClient.CreateEndpointAsync</c>.
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
        public lro::OperationsSettings CreateEndpointOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EndpointServiceClient.GetEndpoint</c> and <c>EndpointServiceClient.GetEndpointAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEndpointSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EndpointServiceClient.ListEndpoints</c> and <c>EndpointServiceClient.ListEndpointsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEndpointsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EndpointServiceClient.UpdateEndpoint</c> and <c>EndpointServiceClient.UpdateEndpointAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateEndpointSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EndpointServiceClient.UpdateEndpointLongRunning</c> and
        /// <c>EndpointServiceClient.UpdateEndpointLongRunningAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateEndpointLongRunningSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>EndpointServiceClient.UpdateEndpointLongRunning</c> and
        /// <c>EndpointServiceClient.UpdateEndpointLongRunningAsync</c>.
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
        public lro::OperationsSettings UpdateEndpointLongRunningOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EndpointServiceClient.DeleteEndpoint</c> and <c>EndpointServiceClient.DeleteEndpointAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteEndpointSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>EndpointServiceClient.DeleteEndpoint</c> and
        /// <c>EndpointServiceClient.DeleteEndpointAsync</c>.
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
        public lro::OperationsSettings DeleteEndpointOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EndpointServiceClient.DeployModel</c> and <c>EndpointServiceClient.DeployModelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeployModelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>EndpointServiceClient.DeployModel</c> and
        /// <c>EndpointServiceClient.DeployModelAsync</c>.
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
        public lro::OperationsSettings DeployModelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EndpointServiceClient.UndeployModel</c> and <c>EndpointServiceClient.UndeployModelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UndeployModelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>EndpointServiceClient.UndeployModel</c> and
        /// <c>EndpointServiceClient.UndeployModelAsync</c>.
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
        public lro::OperationsSettings UndeployModelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EndpointServiceClient.MutateDeployedModel</c> and <c>EndpointServiceClient.MutateDeployedModelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateDeployedModelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>EndpointServiceClient.MutateDeployedModel</c> and
        /// <c>EndpointServiceClient.MutateDeployedModelAsync</c>.
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
        public lro::OperationsSettings MutateDeployedModelOperationsSettings { get; set; } = new lro::OperationsSettings
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
        /// <returns>A deep clone of this <see cref="EndpointServiceSettings"/> object.</returns>
        public EndpointServiceSettings Clone() => new EndpointServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="EndpointServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class EndpointServiceClientBuilder : gaxgrpc::ClientBuilderBase<EndpointServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public EndpointServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public EndpointServiceClientBuilder() : base(EndpointServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref EndpointServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<EndpointServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override EndpointServiceClient Build()
        {
            EndpointServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<EndpointServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<EndpointServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private EndpointServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return EndpointServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<EndpointServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return EndpointServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => EndpointServiceClient.ChannelPool;
    }

    /// <summary>EndpointService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service for managing Vertex AI's Endpoints.
    /// </remarks>
    public abstract partial class EndpointServiceClient
    {
        /// <summary>
        /// The default endpoint for the EndpointService service, which is a host of "aiplatform.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aiplatform.googleapis.com:443";

        /// <summary>The default EndpointService scopes.</summary>
        /// <remarks>
        /// The default EndpointService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(EndpointService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="EndpointServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="EndpointServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="EndpointServiceClient"/>.</returns>
        public static stt::Task<EndpointServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new EndpointServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="EndpointServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="EndpointServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="EndpointServiceClient"/>.</returns>
        public static EndpointServiceClient Create() => new EndpointServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="EndpointServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="EndpointServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="EndpointServiceClient"/>.</returns>
        internal static EndpointServiceClient Create(grpccore::CallInvoker callInvoker, EndpointServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            EndpointService.EndpointServiceClient grpcClient = new EndpointService.EndpointServiceClient(callInvoker);
            return new EndpointServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC EndpointService client</summary>
        public virtual EndpointService.EndpointServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Endpoint, CreateEndpointOperationMetadata> CreateEndpoint(CreateEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Endpoint, CreateEndpointOperationMetadata>> CreateEndpointAsync(CreateEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Endpoint, CreateEndpointOperationMetadata>> CreateEndpointAsync(CreateEndpointRequest request, st::CancellationToken cancellationToken) =>
            CreateEndpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateEndpoint</c>.</summary>
        public virtual lro::OperationsClient CreateEndpointOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateEndpoint</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Endpoint, CreateEndpointOperationMetadata> PollOnceCreateEndpoint(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Endpoint, CreateEndpointOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEndpointOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateEndpoint</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Endpoint, CreateEndpointOperationMetadata>> PollOnceCreateEndpointAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Endpoint, CreateEndpointOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEndpointOperationsClient, callSettings);

        /// <summary>
        /// Creates an Endpoint.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the Endpoint in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="endpoint">
        /// Required. The Endpoint to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Endpoint, CreateEndpointOperationMetadata> CreateEndpoint(string parent, Endpoint endpoint, gaxgrpc::CallSettings callSettings = null) =>
            CreateEndpoint(new CreateEndpointRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Endpoint = gax::GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint)),
            }, callSettings);

        /// <summary>
        /// Creates an Endpoint.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the Endpoint in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="endpoint">
        /// Required. The Endpoint to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Endpoint, CreateEndpointOperationMetadata>> CreateEndpointAsync(string parent, Endpoint endpoint, gaxgrpc::CallSettings callSettings = null) =>
            CreateEndpointAsync(new CreateEndpointRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Endpoint = gax::GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint)),
            }, callSettings);

        /// <summary>
        /// Creates an Endpoint.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the Endpoint in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="endpoint">
        /// Required. The Endpoint to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Endpoint, CreateEndpointOperationMetadata>> CreateEndpointAsync(string parent, Endpoint endpoint, st::CancellationToken cancellationToken) =>
            CreateEndpointAsync(parent, endpoint, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an Endpoint.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the Endpoint in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="endpoint">
        /// Required. The Endpoint to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Endpoint, CreateEndpointOperationMetadata> CreateEndpoint(gagr::LocationName parent, Endpoint endpoint, gaxgrpc::CallSettings callSettings = null) =>
            CreateEndpoint(new CreateEndpointRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Endpoint = gax::GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint)),
            }, callSettings);

        /// <summary>
        /// Creates an Endpoint.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the Endpoint in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="endpoint">
        /// Required. The Endpoint to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Endpoint, CreateEndpointOperationMetadata>> CreateEndpointAsync(gagr::LocationName parent, Endpoint endpoint, gaxgrpc::CallSettings callSettings = null) =>
            CreateEndpointAsync(new CreateEndpointRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Endpoint = gax::GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint)),
            }, callSettings);

        /// <summary>
        /// Creates an Endpoint.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the Endpoint in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="endpoint">
        /// Required. The Endpoint to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Endpoint, CreateEndpointOperationMetadata>> CreateEndpointAsync(gagr::LocationName parent, Endpoint endpoint, st::CancellationToken cancellationToken) =>
            CreateEndpointAsync(parent, endpoint, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an Endpoint.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the Endpoint in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="endpoint">
        /// Required. The Endpoint to create.
        /// </param>
        /// <param name="endpointId">
        /// Immutable. The ID to use for endpoint, which will become the final
        /// component of the endpoint resource name.
        /// If not provided, Vertex AI will generate a value for this ID.
        /// 
        /// If the first character is a letter, this value may be up to 63 characters,
        /// and valid characters are `[a-z0-9-]`. The last character must be a letter
        /// or number.
        /// 
        /// If the first character is a number, this value may be up to 9 characters,
        /// and valid characters are `[0-9]` with no leading zeros.
        /// 
        /// When using HTTP/JSON, this field is populated
        /// based on a query string argument, such as `?endpoint_id=12345`. This is the
        /// fallback for fields that are not included in either the URI or the body.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Endpoint, CreateEndpointOperationMetadata> CreateEndpoint(string parent, Endpoint endpoint, string endpointId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEndpoint(new CreateEndpointRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Endpoint = gax::GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint)),
                EndpointId = endpointId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates an Endpoint.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the Endpoint in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="endpoint">
        /// Required. The Endpoint to create.
        /// </param>
        /// <param name="endpointId">
        /// Immutable. The ID to use for endpoint, which will become the final
        /// component of the endpoint resource name.
        /// If not provided, Vertex AI will generate a value for this ID.
        /// 
        /// If the first character is a letter, this value may be up to 63 characters,
        /// and valid characters are `[a-z0-9-]`. The last character must be a letter
        /// or number.
        /// 
        /// If the first character is a number, this value may be up to 9 characters,
        /// and valid characters are `[0-9]` with no leading zeros.
        /// 
        /// When using HTTP/JSON, this field is populated
        /// based on a query string argument, such as `?endpoint_id=12345`. This is the
        /// fallback for fields that are not included in either the URI or the body.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Endpoint, CreateEndpointOperationMetadata>> CreateEndpointAsync(string parent, Endpoint endpoint, string endpointId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEndpointAsync(new CreateEndpointRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Endpoint = gax::GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint)),
                EndpointId = endpointId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates an Endpoint.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the Endpoint in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="endpoint">
        /// Required. The Endpoint to create.
        /// </param>
        /// <param name="endpointId">
        /// Immutable. The ID to use for endpoint, which will become the final
        /// component of the endpoint resource name.
        /// If not provided, Vertex AI will generate a value for this ID.
        /// 
        /// If the first character is a letter, this value may be up to 63 characters,
        /// and valid characters are `[a-z0-9-]`. The last character must be a letter
        /// or number.
        /// 
        /// If the first character is a number, this value may be up to 9 characters,
        /// and valid characters are `[0-9]` with no leading zeros.
        /// 
        /// When using HTTP/JSON, this field is populated
        /// based on a query string argument, such as `?endpoint_id=12345`. This is the
        /// fallback for fields that are not included in either the URI or the body.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Endpoint, CreateEndpointOperationMetadata>> CreateEndpointAsync(string parent, Endpoint endpoint, string endpointId, st::CancellationToken cancellationToken) =>
            CreateEndpointAsync(parent, endpoint, endpointId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an Endpoint.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the Endpoint in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="endpoint">
        /// Required. The Endpoint to create.
        /// </param>
        /// <param name="endpointId">
        /// Immutable. The ID to use for endpoint, which will become the final
        /// component of the endpoint resource name.
        /// If not provided, Vertex AI will generate a value for this ID.
        /// 
        /// If the first character is a letter, this value may be up to 63 characters,
        /// and valid characters are `[a-z0-9-]`. The last character must be a letter
        /// or number.
        /// 
        /// If the first character is a number, this value may be up to 9 characters,
        /// and valid characters are `[0-9]` with no leading zeros.
        /// 
        /// When using HTTP/JSON, this field is populated
        /// based on a query string argument, such as `?endpoint_id=12345`. This is the
        /// fallback for fields that are not included in either the URI or the body.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Endpoint, CreateEndpointOperationMetadata> CreateEndpoint(gagr::LocationName parent, Endpoint endpoint, string endpointId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEndpoint(new CreateEndpointRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Endpoint = gax::GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint)),
                EndpointId = endpointId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates an Endpoint.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the Endpoint in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="endpoint">
        /// Required. The Endpoint to create.
        /// </param>
        /// <param name="endpointId">
        /// Immutable. The ID to use for endpoint, which will become the final
        /// component of the endpoint resource name.
        /// If not provided, Vertex AI will generate a value for this ID.
        /// 
        /// If the first character is a letter, this value may be up to 63 characters,
        /// and valid characters are `[a-z0-9-]`. The last character must be a letter
        /// or number.
        /// 
        /// If the first character is a number, this value may be up to 9 characters,
        /// and valid characters are `[0-9]` with no leading zeros.
        /// 
        /// When using HTTP/JSON, this field is populated
        /// based on a query string argument, such as `?endpoint_id=12345`. This is the
        /// fallback for fields that are not included in either the URI or the body.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Endpoint, CreateEndpointOperationMetadata>> CreateEndpointAsync(gagr::LocationName parent, Endpoint endpoint, string endpointId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEndpointAsync(new CreateEndpointRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Endpoint = gax::GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint)),
                EndpointId = endpointId ?? "",
            }, callSettings);

        /// <summary>
        /// Creates an Endpoint.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the Endpoint in.
        /// Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="endpoint">
        /// Required. The Endpoint to create.
        /// </param>
        /// <param name="endpointId">
        /// Immutable. The ID to use for endpoint, which will become the final
        /// component of the endpoint resource name.
        /// If not provided, Vertex AI will generate a value for this ID.
        /// 
        /// If the first character is a letter, this value may be up to 63 characters,
        /// and valid characters are `[a-z0-9-]`. The last character must be a letter
        /// or number.
        /// 
        /// If the first character is a number, this value may be up to 9 characters,
        /// and valid characters are `[0-9]` with no leading zeros.
        /// 
        /// When using HTTP/JSON, this field is populated
        /// based on a query string argument, such as `?endpoint_id=12345`. This is the
        /// fallback for fields that are not included in either the URI or the body.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Endpoint, CreateEndpointOperationMetadata>> CreateEndpointAsync(gagr::LocationName parent, Endpoint endpoint, string endpointId, st::CancellationToken cancellationToken) =>
            CreateEndpointAsync(parent, endpoint, endpointId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Endpoint GetEndpoint(GetEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> GetEndpointAsync(GetEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> GetEndpointAsync(GetEndpointRequest request, st::CancellationToken cancellationToken) =>
            GetEndpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Endpoint resource.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Endpoint GetEndpoint(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEndpoint(new GetEndpointRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Endpoint resource.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> GetEndpointAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEndpointAsync(new GetEndpointRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Endpoint resource.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> GetEndpointAsync(string name, st::CancellationToken cancellationToken) =>
            GetEndpointAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Endpoint resource.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Endpoint GetEndpoint(EndpointName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEndpoint(new GetEndpointRequest
            {
                EndpointName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Endpoint resource.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> GetEndpointAsync(EndpointName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEndpointAsync(new GetEndpointRequest
            {
                EndpointName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Endpoint resource.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> GetEndpointAsync(EndpointName name, st::CancellationToken cancellationToken) =>
            GetEndpointAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Endpoints in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Endpoint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEndpointsResponse, Endpoint> ListEndpoints(ListEndpointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Endpoints in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Endpoint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEndpointsResponse, Endpoint> ListEndpointsAsync(ListEndpointsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Endpoints in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to list the
        /// Endpoints. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="Endpoint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEndpointsResponse, Endpoint> ListEndpoints(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEndpointsRequest request = new ListEndpointsRequest
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
            return ListEndpoints(request, callSettings);
        }

        /// <summary>
        /// Lists Endpoints in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to list the
        /// Endpoints. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Endpoint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEndpointsResponse, Endpoint> ListEndpointsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEndpointsRequest request = new ListEndpointsRequest
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
            return ListEndpointsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Endpoints in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to list the
        /// Endpoints. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="Endpoint"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEndpointsResponse, Endpoint> ListEndpoints(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEndpointsRequest request = new ListEndpointsRequest
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
            return ListEndpoints(request, callSettings);
        }

        /// <summary>
        /// Lists Endpoints in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location from which to list the
        /// Endpoints. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Endpoint"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEndpointsResponse, Endpoint> ListEndpointsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEndpointsRequest request = new ListEndpointsRequest
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
            return ListEndpointsAsync(request, callSettings);
        }

        /// <summary>
        /// Updates an Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Endpoint UpdateEndpoint(UpdateEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> UpdateEndpointAsync(UpdateEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> UpdateEndpointAsync(UpdateEndpointRequest request, st::CancellationToken cancellationToken) =>
            UpdateEndpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an Endpoint.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The Endpoint which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource. See
        /// [google.protobuf.FieldMask][google.protobuf.FieldMask].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Endpoint UpdateEndpoint(Endpoint endpoint, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEndpoint(new UpdateEndpointRequest
            {
                Endpoint = gax::GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an Endpoint.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The Endpoint which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource. See
        /// [google.protobuf.FieldMask][google.protobuf.FieldMask].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> UpdateEndpointAsync(Endpoint endpoint, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEndpointAsync(new UpdateEndpointRequest
            {
                Endpoint = gax::GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an Endpoint.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The Endpoint which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource. See
        /// [google.protobuf.FieldMask][google.protobuf.FieldMask].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Endpoint> UpdateEndpointAsync(Endpoint endpoint, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateEndpointAsync(endpoint, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an Endpoint with a long running operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Endpoint, UpdateEndpointOperationMetadata> UpdateEndpointLongRunning(UpdateEndpointLongRunningRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an Endpoint with a long running operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Endpoint, UpdateEndpointOperationMetadata>> UpdateEndpointLongRunningAsync(UpdateEndpointLongRunningRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an Endpoint with a long running operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Endpoint, UpdateEndpointOperationMetadata>> UpdateEndpointLongRunningAsync(UpdateEndpointLongRunningRequest request, st::CancellationToken cancellationToken) =>
            UpdateEndpointLongRunningAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateEndpointLongRunning</c>.</summary>
        public virtual lro::OperationsClient UpdateEndpointLongRunningOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateEndpointLongRunning</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Endpoint, UpdateEndpointOperationMetadata> PollOnceUpdateEndpointLongRunning(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Endpoint, UpdateEndpointOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateEndpointLongRunningOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateEndpointLongRunning</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Endpoint, UpdateEndpointOperationMetadata>> PollOnceUpdateEndpointLongRunningAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Endpoint, UpdateEndpointOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateEndpointLongRunningOperationsClient, callSettings);

        /// <summary>
        /// Updates an Endpoint with a long running operation.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The Endpoint which replaces the resource on the server. Currently
        /// we only support updating the `client_connection_config` field, all the
        /// other fields' update will be blocked.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Endpoint, UpdateEndpointOperationMetadata> UpdateEndpointLongRunning(Endpoint endpoint, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEndpointLongRunning(new UpdateEndpointLongRunningRequest
            {
                Endpoint = gax::GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint)),
            }, callSettings);

        /// <summary>
        /// Updates an Endpoint with a long running operation.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The Endpoint which replaces the resource on the server. Currently
        /// we only support updating the `client_connection_config` field, all the
        /// other fields' update will be blocked.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Endpoint, UpdateEndpointOperationMetadata>> UpdateEndpointLongRunningAsync(Endpoint endpoint, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEndpointLongRunningAsync(new UpdateEndpointLongRunningRequest
            {
                Endpoint = gax::GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint)),
            }, callSettings);

        /// <summary>
        /// Updates an Endpoint with a long running operation.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The Endpoint which replaces the resource on the server. Currently
        /// we only support updating the `client_connection_config` field, all the
        /// other fields' update will be blocked.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Endpoint, UpdateEndpointOperationMetadata>> UpdateEndpointLongRunningAsync(Endpoint endpoint, st::CancellationToken cancellationToken) =>
            UpdateEndpointLongRunningAsync(endpoint, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteEndpoint(DeleteEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteEndpointAsync(DeleteEndpointRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteEndpointAsync(DeleteEndpointRequest request, st::CancellationToken cancellationToken) =>
            DeleteEndpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteEndpoint</c>.</summary>
        public virtual lro::OperationsClient DeleteEndpointOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteEndpoint</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> PollOnceDeleteEndpoint(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteEndpointOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteEndpoint</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> PollOnceDeleteEndpointAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteEndpointOperationsClient, callSettings);

        /// <summary>
        /// Deletes an Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Endpoint resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteEndpoint(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEndpoint(new DeleteEndpointRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Endpoint resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteEndpointAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEndpointAsync(new DeleteEndpointRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Endpoint resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteEndpointAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteEndpointAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Endpoint resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteEndpoint(EndpointName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEndpoint(new DeleteEndpointRequest
            {
                EndpointName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Endpoint resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteEndpointAsync(EndpointName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEndpointAsync(new DeleteEndpointRequest
            {
                EndpointName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an Endpoint.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Endpoint resource to be deleted.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteEndpointAsync(EndpointName name, st::CancellationToken cancellationToken) =>
            DeleteEndpointAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deploys a Model into this Endpoint, creating a DeployedModel within it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeployModelResponse, DeployModelOperationMetadata> DeployModel(DeployModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deploys a Model into this Endpoint, creating a DeployedModel within it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployModelResponse, DeployModelOperationMetadata>> DeployModelAsync(DeployModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deploys a Model into this Endpoint, creating a DeployedModel within it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployModelResponse, DeployModelOperationMetadata>> DeployModelAsync(DeployModelRequest request, st::CancellationToken cancellationToken) =>
            DeployModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeployModel</c>.</summary>
        public virtual lro::OperationsClient DeployModelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeployModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DeployModelResponse, DeployModelOperationMetadata> PollOnceDeployModel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DeployModelResponse, DeployModelOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeployModelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeployModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DeployModelResponse, DeployModelOperationMetadata>> PollOnceDeployModelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DeployModelResponse, DeployModelOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeployModelOperationsClient, callSettings);

        /// <summary>
        /// Deploys a Model into this Endpoint, creating a DeployedModel within it.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint resource into which to deploy a Model.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="deployedModel">
        /// Required. The DeployedModel to be created within the Endpoint. Note that
        /// [Endpoint.traffic_split][google.cloud.aiplatform.v1.Endpoint.traffic_split]
        /// must be updated for the DeployedModel to start receiving traffic, either as
        /// part of this call, or via
        /// [EndpointService.UpdateEndpoint][google.cloud.aiplatform.v1.EndpointService.UpdateEndpoint].
        /// </param>
        /// <param name="trafficSplit">
        /// A map from a DeployedModel's ID to the percentage of this Endpoint's
        /// traffic that should be forwarded to that DeployedModel.
        /// 
        /// If this field is non-empty, then the Endpoint's
        /// [traffic_split][google.cloud.aiplatform.v1.Endpoint.traffic_split] will be
        /// overwritten with it. To refer to the ID of the just being deployed Model, a
        /// "0" should be used, and the actual ID of the new DeployedModel will be
        /// filled in its place by this method. The traffic percentage values must add
        /// up to 100.
        /// 
        /// If this field is empty, then the Endpoint's
        /// [traffic_split][google.cloud.aiplatform.v1.Endpoint.traffic_split] is not
        /// updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeployModelResponse, DeployModelOperationMetadata> DeployModel(string endpoint, DeployedModel deployedModel, scg::IDictionary<string, int> trafficSplit, gaxgrpc::CallSettings callSettings = null) =>
            DeployModel(new DeployModelRequest
            {
                Endpoint = gax::GaxPreconditions.CheckNotNullOrEmpty(endpoint, nameof(endpoint)),
                DeployedModel = gax::GaxPreconditions.CheckNotNull(deployedModel, nameof(deployedModel)),
                TrafficSplit =
                {
                    trafficSplit ?? new scg::Dictionary<string, int>(),
                },
            }, callSettings);

        /// <summary>
        /// Deploys a Model into this Endpoint, creating a DeployedModel within it.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint resource into which to deploy a Model.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="deployedModel">
        /// Required. The DeployedModel to be created within the Endpoint. Note that
        /// [Endpoint.traffic_split][google.cloud.aiplatform.v1.Endpoint.traffic_split]
        /// must be updated for the DeployedModel to start receiving traffic, either as
        /// part of this call, or via
        /// [EndpointService.UpdateEndpoint][google.cloud.aiplatform.v1.EndpointService.UpdateEndpoint].
        /// </param>
        /// <param name="trafficSplit">
        /// A map from a DeployedModel's ID to the percentage of this Endpoint's
        /// traffic that should be forwarded to that DeployedModel.
        /// 
        /// If this field is non-empty, then the Endpoint's
        /// [traffic_split][google.cloud.aiplatform.v1.Endpoint.traffic_split] will be
        /// overwritten with it. To refer to the ID of the just being deployed Model, a
        /// "0" should be used, and the actual ID of the new DeployedModel will be
        /// filled in its place by this method. The traffic percentage values must add
        /// up to 100.
        /// 
        /// If this field is empty, then the Endpoint's
        /// [traffic_split][google.cloud.aiplatform.v1.Endpoint.traffic_split] is not
        /// updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployModelResponse, DeployModelOperationMetadata>> DeployModelAsync(string endpoint, DeployedModel deployedModel, scg::IDictionary<string, int> trafficSplit, gaxgrpc::CallSettings callSettings = null) =>
            DeployModelAsync(new DeployModelRequest
            {
                Endpoint = gax::GaxPreconditions.CheckNotNullOrEmpty(endpoint, nameof(endpoint)),
                DeployedModel = gax::GaxPreconditions.CheckNotNull(deployedModel, nameof(deployedModel)),
                TrafficSplit =
                {
                    trafficSplit ?? new scg::Dictionary<string, int>(),
                },
            }, callSettings);

        /// <summary>
        /// Deploys a Model into this Endpoint, creating a DeployedModel within it.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint resource into which to deploy a Model.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="deployedModel">
        /// Required. The DeployedModel to be created within the Endpoint. Note that
        /// [Endpoint.traffic_split][google.cloud.aiplatform.v1.Endpoint.traffic_split]
        /// must be updated for the DeployedModel to start receiving traffic, either as
        /// part of this call, or via
        /// [EndpointService.UpdateEndpoint][google.cloud.aiplatform.v1.EndpointService.UpdateEndpoint].
        /// </param>
        /// <param name="trafficSplit">
        /// A map from a DeployedModel's ID to the percentage of this Endpoint's
        /// traffic that should be forwarded to that DeployedModel.
        /// 
        /// If this field is non-empty, then the Endpoint's
        /// [traffic_split][google.cloud.aiplatform.v1.Endpoint.traffic_split] will be
        /// overwritten with it. To refer to the ID of the just being deployed Model, a
        /// "0" should be used, and the actual ID of the new DeployedModel will be
        /// filled in its place by this method. The traffic percentage values must add
        /// up to 100.
        /// 
        /// If this field is empty, then the Endpoint's
        /// [traffic_split][google.cloud.aiplatform.v1.Endpoint.traffic_split] is not
        /// updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployModelResponse, DeployModelOperationMetadata>> DeployModelAsync(string endpoint, DeployedModel deployedModel, scg::IDictionary<string, int> trafficSplit, st::CancellationToken cancellationToken) =>
            DeployModelAsync(endpoint, deployedModel, trafficSplit, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deploys a Model into this Endpoint, creating a DeployedModel within it.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint resource into which to deploy a Model.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="deployedModel">
        /// Required. The DeployedModel to be created within the Endpoint. Note that
        /// [Endpoint.traffic_split][google.cloud.aiplatform.v1.Endpoint.traffic_split]
        /// must be updated for the DeployedModel to start receiving traffic, either as
        /// part of this call, or via
        /// [EndpointService.UpdateEndpoint][google.cloud.aiplatform.v1.EndpointService.UpdateEndpoint].
        /// </param>
        /// <param name="trafficSplit">
        /// A map from a DeployedModel's ID to the percentage of this Endpoint's
        /// traffic that should be forwarded to that DeployedModel.
        /// 
        /// If this field is non-empty, then the Endpoint's
        /// [traffic_split][google.cloud.aiplatform.v1.Endpoint.traffic_split] will be
        /// overwritten with it. To refer to the ID of the just being deployed Model, a
        /// "0" should be used, and the actual ID of the new DeployedModel will be
        /// filled in its place by this method. The traffic percentage values must add
        /// up to 100.
        /// 
        /// If this field is empty, then the Endpoint's
        /// [traffic_split][google.cloud.aiplatform.v1.Endpoint.traffic_split] is not
        /// updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeployModelResponse, DeployModelOperationMetadata> DeployModel(EndpointName endpoint, DeployedModel deployedModel, scg::IDictionary<string, int> trafficSplit, gaxgrpc::CallSettings callSettings = null) =>
            DeployModel(new DeployModelRequest
            {
                EndpointAsEndpointName = gax::GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint)),
                DeployedModel = gax::GaxPreconditions.CheckNotNull(deployedModel, nameof(deployedModel)),
                TrafficSplit =
                {
                    trafficSplit ?? new scg::Dictionary<string, int>(),
                },
            }, callSettings);

        /// <summary>
        /// Deploys a Model into this Endpoint, creating a DeployedModel within it.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint resource into which to deploy a Model.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="deployedModel">
        /// Required. The DeployedModel to be created within the Endpoint. Note that
        /// [Endpoint.traffic_split][google.cloud.aiplatform.v1.Endpoint.traffic_split]
        /// must be updated for the DeployedModel to start receiving traffic, either as
        /// part of this call, or via
        /// [EndpointService.UpdateEndpoint][google.cloud.aiplatform.v1.EndpointService.UpdateEndpoint].
        /// </param>
        /// <param name="trafficSplit">
        /// A map from a DeployedModel's ID to the percentage of this Endpoint's
        /// traffic that should be forwarded to that DeployedModel.
        /// 
        /// If this field is non-empty, then the Endpoint's
        /// [traffic_split][google.cloud.aiplatform.v1.Endpoint.traffic_split] will be
        /// overwritten with it. To refer to the ID of the just being deployed Model, a
        /// "0" should be used, and the actual ID of the new DeployedModel will be
        /// filled in its place by this method. The traffic percentage values must add
        /// up to 100.
        /// 
        /// If this field is empty, then the Endpoint's
        /// [traffic_split][google.cloud.aiplatform.v1.Endpoint.traffic_split] is not
        /// updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployModelResponse, DeployModelOperationMetadata>> DeployModelAsync(EndpointName endpoint, DeployedModel deployedModel, scg::IDictionary<string, int> trafficSplit, gaxgrpc::CallSettings callSettings = null) =>
            DeployModelAsync(new DeployModelRequest
            {
                EndpointAsEndpointName = gax::GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint)),
                DeployedModel = gax::GaxPreconditions.CheckNotNull(deployedModel, nameof(deployedModel)),
                TrafficSplit =
                {
                    trafficSplit ?? new scg::Dictionary<string, int>(),
                },
            }, callSettings);

        /// <summary>
        /// Deploys a Model into this Endpoint, creating a DeployedModel within it.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint resource into which to deploy a Model.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="deployedModel">
        /// Required. The DeployedModel to be created within the Endpoint. Note that
        /// [Endpoint.traffic_split][google.cloud.aiplatform.v1.Endpoint.traffic_split]
        /// must be updated for the DeployedModel to start receiving traffic, either as
        /// part of this call, or via
        /// [EndpointService.UpdateEndpoint][google.cloud.aiplatform.v1.EndpointService.UpdateEndpoint].
        /// </param>
        /// <param name="trafficSplit">
        /// A map from a DeployedModel's ID to the percentage of this Endpoint's
        /// traffic that should be forwarded to that DeployedModel.
        /// 
        /// If this field is non-empty, then the Endpoint's
        /// [traffic_split][google.cloud.aiplatform.v1.Endpoint.traffic_split] will be
        /// overwritten with it. To refer to the ID of the just being deployed Model, a
        /// "0" should be used, and the actual ID of the new DeployedModel will be
        /// filled in its place by this method. The traffic percentage values must add
        /// up to 100.
        /// 
        /// If this field is empty, then the Endpoint's
        /// [traffic_split][google.cloud.aiplatform.v1.Endpoint.traffic_split] is not
        /// updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployModelResponse, DeployModelOperationMetadata>> DeployModelAsync(EndpointName endpoint, DeployedModel deployedModel, scg::IDictionary<string, int> trafficSplit, st::CancellationToken cancellationToken) =>
            DeployModelAsync(endpoint, deployedModel, trafficSplit, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Undeploys a Model from an Endpoint, removing a DeployedModel from it, and
        /// freeing all resources it's using.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UndeployModelResponse, UndeployModelOperationMetadata> UndeployModel(UndeployModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Undeploys a Model from an Endpoint, removing a DeployedModel from it, and
        /// freeing all resources it's using.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeployModelResponse, UndeployModelOperationMetadata>> UndeployModelAsync(UndeployModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Undeploys a Model from an Endpoint, removing a DeployedModel from it, and
        /// freeing all resources it's using.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeployModelResponse, UndeployModelOperationMetadata>> UndeployModelAsync(UndeployModelRequest request, st::CancellationToken cancellationToken) =>
            UndeployModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UndeployModel</c>.</summary>
        public virtual lro::OperationsClient UndeployModelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UndeployModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<UndeployModelResponse, UndeployModelOperationMetadata> PollOnceUndeployModel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<UndeployModelResponse, UndeployModelOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UndeployModelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UndeployModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<UndeployModelResponse, UndeployModelOperationMetadata>> PollOnceUndeployModelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<UndeployModelResponse, UndeployModelOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UndeployModelOperationsClient, callSettings);

        /// <summary>
        /// Undeploys a Model from an Endpoint, removing a DeployedModel from it, and
        /// freeing all resources it's using.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint resource from which to undeploy a Model.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="deployedModelId">
        /// Required. The ID of the DeployedModel to be undeployed from the Endpoint.
        /// </param>
        /// <param name="trafficSplit">
        /// If this field is provided, then the Endpoint's
        /// [traffic_split][google.cloud.aiplatform.v1.Endpoint.traffic_split] will be
        /// overwritten with it. If last DeployedModel is being undeployed from the
        /// Endpoint, the [Endpoint.traffic_split] will always end up empty when this
        /// call returns. A DeployedModel will be successfully undeployed only if it
        /// doesn't have any traffic assigned to it when this method executes, or if
        /// this field unassigns any traffic to it.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UndeployModelResponse, UndeployModelOperationMetadata> UndeployModel(string endpoint, string deployedModelId, scg::IDictionary<string, int> trafficSplit, gaxgrpc::CallSettings callSettings = null) =>
            UndeployModel(new UndeployModelRequest
            {
                Endpoint = gax::GaxPreconditions.CheckNotNullOrEmpty(endpoint, nameof(endpoint)),
                DeployedModelId = gax::GaxPreconditions.CheckNotNullOrEmpty(deployedModelId, nameof(deployedModelId)),
                TrafficSplit =
                {
                    trafficSplit ?? new scg::Dictionary<string, int>(),
                },
            }, callSettings);

        /// <summary>
        /// Undeploys a Model from an Endpoint, removing a DeployedModel from it, and
        /// freeing all resources it's using.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint resource from which to undeploy a Model.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="deployedModelId">
        /// Required. The ID of the DeployedModel to be undeployed from the Endpoint.
        /// </param>
        /// <param name="trafficSplit">
        /// If this field is provided, then the Endpoint's
        /// [traffic_split][google.cloud.aiplatform.v1.Endpoint.traffic_split] will be
        /// overwritten with it. If last DeployedModel is being undeployed from the
        /// Endpoint, the [Endpoint.traffic_split] will always end up empty when this
        /// call returns. A DeployedModel will be successfully undeployed only if it
        /// doesn't have any traffic assigned to it when this method executes, or if
        /// this field unassigns any traffic to it.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeployModelResponse, UndeployModelOperationMetadata>> UndeployModelAsync(string endpoint, string deployedModelId, scg::IDictionary<string, int> trafficSplit, gaxgrpc::CallSettings callSettings = null) =>
            UndeployModelAsync(new UndeployModelRequest
            {
                Endpoint = gax::GaxPreconditions.CheckNotNullOrEmpty(endpoint, nameof(endpoint)),
                DeployedModelId = gax::GaxPreconditions.CheckNotNullOrEmpty(deployedModelId, nameof(deployedModelId)),
                TrafficSplit =
                {
                    trafficSplit ?? new scg::Dictionary<string, int>(),
                },
            }, callSettings);

        /// <summary>
        /// Undeploys a Model from an Endpoint, removing a DeployedModel from it, and
        /// freeing all resources it's using.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint resource from which to undeploy a Model.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="deployedModelId">
        /// Required. The ID of the DeployedModel to be undeployed from the Endpoint.
        /// </param>
        /// <param name="trafficSplit">
        /// If this field is provided, then the Endpoint's
        /// [traffic_split][google.cloud.aiplatform.v1.Endpoint.traffic_split] will be
        /// overwritten with it. If last DeployedModel is being undeployed from the
        /// Endpoint, the [Endpoint.traffic_split] will always end up empty when this
        /// call returns. A DeployedModel will be successfully undeployed only if it
        /// doesn't have any traffic assigned to it when this method executes, or if
        /// this field unassigns any traffic to it.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeployModelResponse, UndeployModelOperationMetadata>> UndeployModelAsync(string endpoint, string deployedModelId, scg::IDictionary<string, int> trafficSplit, st::CancellationToken cancellationToken) =>
            UndeployModelAsync(endpoint, deployedModelId, trafficSplit, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Undeploys a Model from an Endpoint, removing a DeployedModel from it, and
        /// freeing all resources it's using.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint resource from which to undeploy a Model.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="deployedModelId">
        /// Required. The ID of the DeployedModel to be undeployed from the Endpoint.
        /// </param>
        /// <param name="trafficSplit">
        /// If this field is provided, then the Endpoint's
        /// [traffic_split][google.cloud.aiplatform.v1.Endpoint.traffic_split] will be
        /// overwritten with it. If last DeployedModel is being undeployed from the
        /// Endpoint, the [Endpoint.traffic_split] will always end up empty when this
        /// call returns. A DeployedModel will be successfully undeployed only if it
        /// doesn't have any traffic assigned to it when this method executes, or if
        /// this field unassigns any traffic to it.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UndeployModelResponse, UndeployModelOperationMetadata> UndeployModel(EndpointName endpoint, string deployedModelId, scg::IDictionary<string, int> trafficSplit, gaxgrpc::CallSettings callSettings = null) =>
            UndeployModel(new UndeployModelRequest
            {
                EndpointAsEndpointName = gax::GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint)),
                DeployedModelId = gax::GaxPreconditions.CheckNotNullOrEmpty(deployedModelId, nameof(deployedModelId)),
                TrafficSplit =
                {
                    trafficSplit ?? new scg::Dictionary<string, int>(),
                },
            }, callSettings);

        /// <summary>
        /// Undeploys a Model from an Endpoint, removing a DeployedModel from it, and
        /// freeing all resources it's using.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint resource from which to undeploy a Model.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="deployedModelId">
        /// Required. The ID of the DeployedModel to be undeployed from the Endpoint.
        /// </param>
        /// <param name="trafficSplit">
        /// If this field is provided, then the Endpoint's
        /// [traffic_split][google.cloud.aiplatform.v1.Endpoint.traffic_split] will be
        /// overwritten with it. If last DeployedModel is being undeployed from the
        /// Endpoint, the [Endpoint.traffic_split] will always end up empty when this
        /// call returns. A DeployedModel will be successfully undeployed only if it
        /// doesn't have any traffic assigned to it when this method executes, or if
        /// this field unassigns any traffic to it.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeployModelResponse, UndeployModelOperationMetadata>> UndeployModelAsync(EndpointName endpoint, string deployedModelId, scg::IDictionary<string, int> trafficSplit, gaxgrpc::CallSettings callSettings = null) =>
            UndeployModelAsync(new UndeployModelRequest
            {
                EndpointAsEndpointName = gax::GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint)),
                DeployedModelId = gax::GaxPreconditions.CheckNotNullOrEmpty(deployedModelId, nameof(deployedModelId)),
                TrafficSplit =
                {
                    trafficSplit ?? new scg::Dictionary<string, int>(),
                },
            }, callSettings);

        /// <summary>
        /// Undeploys a Model from an Endpoint, removing a DeployedModel from it, and
        /// freeing all resources it's using.
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint resource from which to undeploy a Model.
        /// Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="deployedModelId">
        /// Required. The ID of the DeployedModel to be undeployed from the Endpoint.
        /// </param>
        /// <param name="trafficSplit">
        /// If this field is provided, then the Endpoint's
        /// [traffic_split][google.cloud.aiplatform.v1.Endpoint.traffic_split] will be
        /// overwritten with it. If last DeployedModel is being undeployed from the
        /// Endpoint, the [Endpoint.traffic_split] will always end up empty when this
        /// call returns. A DeployedModel will be successfully undeployed only if it
        /// doesn't have any traffic assigned to it when this method executes, or if
        /// this field unassigns any traffic to it.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeployModelResponse, UndeployModelOperationMetadata>> UndeployModelAsync(EndpointName endpoint, string deployedModelId, scg::IDictionary<string, int> trafficSplit, st::CancellationToken cancellationToken) =>
            UndeployModelAsync(endpoint, deployedModelId, trafficSplit, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing deployed model. Updatable fields include
        /// `min_replica_count`, `max_replica_count`, `autoscaling_metric_specs`,
        /// `disable_container_logging` (v1 only), and `enable_container_logging`
        /// (v1beta1 only).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MutateDeployedModelResponse, MutateDeployedModelOperationMetadata> MutateDeployedModel(MutateDeployedModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing deployed model. Updatable fields include
        /// `min_replica_count`, `max_replica_count`, `autoscaling_metric_specs`,
        /// `disable_container_logging` (v1 only), and `enable_container_logging`
        /// (v1beta1 only).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MutateDeployedModelResponse, MutateDeployedModelOperationMetadata>> MutateDeployedModelAsync(MutateDeployedModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing deployed model. Updatable fields include
        /// `min_replica_count`, `max_replica_count`, `autoscaling_metric_specs`,
        /// `disable_container_logging` (v1 only), and `enable_container_logging`
        /// (v1beta1 only).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MutateDeployedModelResponse, MutateDeployedModelOperationMetadata>> MutateDeployedModelAsync(MutateDeployedModelRequest request, st::CancellationToken cancellationToken) =>
            MutateDeployedModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>MutateDeployedModel</c>.</summary>
        public virtual lro::OperationsClient MutateDeployedModelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>MutateDeployedModel</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MutateDeployedModelResponse, MutateDeployedModelOperationMetadata> PollOnceMutateDeployedModel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MutateDeployedModelResponse, MutateDeployedModelOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), MutateDeployedModelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>MutateDeployedModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MutateDeployedModelResponse, MutateDeployedModelOperationMetadata>> PollOnceMutateDeployedModelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MutateDeployedModelResponse, MutateDeployedModelOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), MutateDeployedModelOperationsClient, callSettings);

        /// <summary>
        /// Updates an existing deployed model. Updatable fields include
        /// `min_replica_count`, `max_replica_count`, `autoscaling_metric_specs`,
        /// `disable_container_logging` (v1 only), and `enable_container_logging`
        /// (v1beta1 only).
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint resource into which to mutate a
        /// DeployedModel. Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="deployedModel">
        /// Required. The DeployedModel to be mutated within the Endpoint. Only the
        /// following fields can be mutated:
        /// 
        /// * `min_replica_count` in either
        /// [DedicatedResources][google.cloud.aiplatform.v1.DedicatedResources] or
        /// [AutomaticResources][google.cloud.aiplatform.v1.AutomaticResources]
        /// * `max_replica_count` in either
        /// [DedicatedResources][google.cloud.aiplatform.v1.DedicatedResources] or
        /// [AutomaticResources][google.cloud.aiplatform.v1.AutomaticResources]
        /// * [autoscaling_metric_specs][google.cloud.aiplatform.v1.DedicatedResources.autoscaling_metric_specs]
        /// * `disable_container_logging` (v1 only)
        /// * `enable_container_logging` (v1beta1 only)
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource. See
        /// [google.protobuf.FieldMask][google.protobuf.FieldMask].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MutateDeployedModelResponse, MutateDeployedModelOperationMetadata> MutateDeployedModel(string endpoint, DeployedModel deployedModel, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            MutateDeployedModel(new MutateDeployedModelRequest
            {
                Endpoint = gax::GaxPreconditions.CheckNotNullOrEmpty(endpoint, nameof(endpoint)),
                DeployedModel = gax::GaxPreconditions.CheckNotNull(deployedModel, nameof(deployedModel)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an existing deployed model. Updatable fields include
        /// `min_replica_count`, `max_replica_count`, `autoscaling_metric_specs`,
        /// `disable_container_logging` (v1 only), and `enable_container_logging`
        /// (v1beta1 only).
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint resource into which to mutate a
        /// DeployedModel. Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="deployedModel">
        /// Required. The DeployedModel to be mutated within the Endpoint. Only the
        /// following fields can be mutated:
        /// 
        /// * `min_replica_count` in either
        /// [DedicatedResources][google.cloud.aiplatform.v1.DedicatedResources] or
        /// [AutomaticResources][google.cloud.aiplatform.v1.AutomaticResources]
        /// * `max_replica_count` in either
        /// [DedicatedResources][google.cloud.aiplatform.v1.DedicatedResources] or
        /// [AutomaticResources][google.cloud.aiplatform.v1.AutomaticResources]
        /// * [autoscaling_metric_specs][google.cloud.aiplatform.v1.DedicatedResources.autoscaling_metric_specs]
        /// * `disable_container_logging` (v1 only)
        /// * `enable_container_logging` (v1beta1 only)
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource. See
        /// [google.protobuf.FieldMask][google.protobuf.FieldMask].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MutateDeployedModelResponse, MutateDeployedModelOperationMetadata>> MutateDeployedModelAsync(string endpoint, DeployedModel deployedModel, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            MutateDeployedModelAsync(new MutateDeployedModelRequest
            {
                Endpoint = gax::GaxPreconditions.CheckNotNullOrEmpty(endpoint, nameof(endpoint)),
                DeployedModel = gax::GaxPreconditions.CheckNotNull(deployedModel, nameof(deployedModel)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an existing deployed model. Updatable fields include
        /// `min_replica_count`, `max_replica_count`, `autoscaling_metric_specs`,
        /// `disable_container_logging` (v1 only), and `enable_container_logging`
        /// (v1beta1 only).
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint resource into which to mutate a
        /// DeployedModel. Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="deployedModel">
        /// Required. The DeployedModel to be mutated within the Endpoint. Only the
        /// following fields can be mutated:
        /// 
        /// * `min_replica_count` in either
        /// [DedicatedResources][google.cloud.aiplatform.v1.DedicatedResources] or
        /// [AutomaticResources][google.cloud.aiplatform.v1.AutomaticResources]
        /// * `max_replica_count` in either
        /// [DedicatedResources][google.cloud.aiplatform.v1.DedicatedResources] or
        /// [AutomaticResources][google.cloud.aiplatform.v1.AutomaticResources]
        /// * [autoscaling_metric_specs][google.cloud.aiplatform.v1.DedicatedResources.autoscaling_metric_specs]
        /// * `disable_container_logging` (v1 only)
        /// * `enable_container_logging` (v1beta1 only)
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource. See
        /// [google.protobuf.FieldMask][google.protobuf.FieldMask].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MutateDeployedModelResponse, MutateDeployedModelOperationMetadata>> MutateDeployedModelAsync(string endpoint, DeployedModel deployedModel, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            MutateDeployedModelAsync(endpoint, deployedModel, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing deployed model. Updatable fields include
        /// `min_replica_count`, `max_replica_count`, `autoscaling_metric_specs`,
        /// `disable_container_logging` (v1 only), and `enable_container_logging`
        /// (v1beta1 only).
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint resource into which to mutate a
        /// DeployedModel. Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="deployedModel">
        /// Required. The DeployedModel to be mutated within the Endpoint. Only the
        /// following fields can be mutated:
        /// 
        /// * `min_replica_count` in either
        /// [DedicatedResources][google.cloud.aiplatform.v1.DedicatedResources] or
        /// [AutomaticResources][google.cloud.aiplatform.v1.AutomaticResources]
        /// * `max_replica_count` in either
        /// [DedicatedResources][google.cloud.aiplatform.v1.DedicatedResources] or
        /// [AutomaticResources][google.cloud.aiplatform.v1.AutomaticResources]
        /// * [autoscaling_metric_specs][google.cloud.aiplatform.v1.DedicatedResources.autoscaling_metric_specs]
        /// * `disable_container_logging` (v1 only)
        /// * `enable_container_logging` (v1beta1 only)
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource. See
        /// [google.protobuf.FieldMask][google.protobuf.FieldMask].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MutateDeployedModelResponse, MutateDeployedModelOperationMetadata> MutateDeployedModel(EndpointName endpoint, DeployedModel deployedModel, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            MutateDeployedModel(new MutateDeployedModelRequest
            {
                EndpointAsEndpointName = gax::GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint)),
                DeployedModel = gax::GaxPreconditions.CheckNotNull(deployedModel, nameof(deployedModel)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an existing deployed model. Updatable fields include
        /// `min_replica_count`, `max_replica_count`, `autoscaling_metric_specs`,
        /// `disable_container_logging` (v1 only), and `enable_container_logging`
        /// (v1beta1 only).
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint resource into which to mutate a
        /// DeployedModel. Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="deployedModel">
        /// Required. The DeployedModel to be mutated within the Endpoint. Only the
        /// following fields can be mutated:
        /// 
        /// * `min_replica_count` in either
        /// [DedicatedResources][google.cloud.aiplatform.v1.DedicatedResources] or
        /// [AutomaticResources][google.cloud.aiplatform.v1.AutomaticResources]
        /// * `max_replica_count` in either
        /// [DedicatedResources][google.cloud.aiplatform.v1.DedicatedResources] or
        /// [AutomaticResources][google.cloud.aiplatform.v1.AutomaticResources]
        /// * [autoscaling_metric_specs][google.cloud.aiplatform.v1.DedicatedResources.autoscaling_metric_specs]
        /// * `disable_container_logging` (v1 only)
        /// * `enable_container_logging` (v1beta1 only)
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource. See
        /// [google.protobuf.FieldMask][google.protobuf.FieldMask].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MutateDeployedModelResponse, MutateDeployedModelOperationMetadata>> MutateDeployedModelAsync(EndpointName endpoint, DeployedModel deployedModel, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            MutateDeployedModelAsync(new MutateDeployedModelRequest
            {
                EndpointAsEndpointName = gax::GaxPreconditions.CheckNotNull(endpoint, nameof(endpoint)),
                DeployedModel = gax::GaxPreconditions.CheckNotNull(deployedModel, nameof(deployedModel)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates an existing deployed model. Updatable fields include
        /// `min_replica_count`, `max_replica_count`, `autoscaling_metric_specs`,
        /// `disable_container_logging` (v1 only), and `enable_container_logging`
        /// (v1beta1 only).
        /// </summary>
        /// <param name="endpoint">
        /// Required. The name of the Endpoint resource into which to mutate a
        /// DeployedModel. Format:
        /// `projects/{project}/locations/{location}/endpoints/{endpoint}`
        /// </param>
        /// <param name="deployedModel">
        /// Required. The DeployedModel to be mutated within the Endpoint. Only the
        /// following fields can be mutated:
        /// 
        /// * `min_replica_count` in either
        /// [DedicatedResources][google.cloud.aiplatform.v1.DedicatedResources] or
        /// [AutomaticResources][google.cloud.aiplatform.v1.AutomaticResources]
        /// * `max_replica_count` in either
        /// [DedicatedResources][google.cloud.aiplatform.v1.DedicatedResources] or
        /// [AutomaticResources][google.cloud.aiplatform.v1.AutomaticResources]
        /// * [autoscaling_metric_specs][google.cloud.aiplatform.v1.DedicatedResources.autoscaling_metric_specs]
        /// * `disable_container_logging` (v1 only)
        /// * `enable_container_logging` (v1beta1 only)
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource. See
        /// [google.protobuf.FieldMask][google.protobuf.FieldMask].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MutateDeployedModelResponse, MutateDeployedModelOperationMetadata>> MutateDeployedModelAsync(EndpointName endpoint, DeployedModel deployedModel, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            MutateDeployedModelAsync(endpoint, deployedModel, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>EndpointService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service for managing Vertex AI's Endpoints.
    /// </remarks>
    public sealed partial class EndpointServiceClientImpl : EndpointServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateEndpointRequest, lro::Operation> _callCreateEndpoint;

        private readonly gaxgrpc::ApiCall<GetEndpointRequest, Endpoint> _callGetEndpoint;

        private readonly gaxgrpc::ApiCall<ListEndpointsRequest, ListEndpointsResponse> _callListEndpoints;

        private readonly gaxgrpc::ApiCall<UpdateEndpointRequest, Endpoint> _callUpdateEndpoint;

        private readonly gaxgrpc::ApiCall<UpdateEndpointLongRunningRequest, lro::Operation> _callUpdateEndpointLongRunning;

        private readonly gaxgrpc::ApiCall<DeleteEndpointRequest, lro::Operation> _callDeleteEndpoint;

        private readonly gaxgrpc::ApiCall<DeployModelRequest, lro::Operation> _callDeployModel;

        private readonly gaxgrpc::ApiCall<UndeployModelRequest, lro::Operation> _callUndeployModel;

        private readonly gaxgrpc::ApiCall<MutateDeployedModelRequest, lro::Operation> _callMutateDeployedModel;

        /// <summary>
        /// Constructs a client wrapper for the EndpointService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="EndpointServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public EndpointServiceClientImpl(EndpointService.EndpointServiceClient grpcClient, EndpointServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            EndpointServiceSettings effectiveSettings = settings ?? EndpointServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateEndpointOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateEndpointOperationsSettings, logger);
            UpdateEndpointLongRunningOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateEndpointLongRunningOperationsSettings, logger);
            DeleteEndpointOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteEndpointOperationsSettings, logger);
            DeployModelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeployModelOperationsSettings, logger);
            UndeployModelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UndeployModelOperationsSettings, logger);
            MutateDeployedModelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.MutateDeployedModelOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateEndpoint = clientHelper.BuildApiCall<CreateEndpointRequest, lro::Operation>("CreateEndpoint", grpcClient.CreateEndpointAsync, grpcClient.CreateEndpoint, effectiveSettings.CreateEndpointSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateEndpoint);
            Modify_CreateEndpointApiCall(ref _callCreateEndpoint);
            _callGetEndpoint = clientHelper.BuildApiCall<GetEndpointRequest, Endpoint>("GetEndpoint", grpcClient.GetEndpointAsync, grpcClient.GetEndpoint, effectiveSettings.GetEndpointSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEndpoint);
            Modify_GetEndpointApiCall(ref _callGetEndpoint);
            _callListEndpoints = clientHelper.BuildApiCall<ListEndpointsRequest, ListEndpointsResponse>("ListEndpoints", grpcClient.ListEndpointsAsync, grpcClient.ListEndpoints, effectiveSettings.ListEndpointsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEndpoints);
            Modify_ListEndpointsApiCall(ref _callListEndpoints);
            _callUpdateEndpoint = clientHelper.BuildApiCall<UpdateEndpointRequest, Endpoint>("UpdateEndpoint", grpcClient.UpdateEndpointAsync, grpcClient.UpdateEndpoint, effectiveSettings.UpdateEndpointSettings).WithGoogleRequestParam("endpoint.name", request => request.Endpoint?.Name);
            Modify_ApiCall(ref _callUpdateEndpoint);
            Modify_UpdateEndpointApiCall(ref _callUpdateEndpoint);
            _callUpdateEndpointLongRunning = clientHelper.BuildApiCall<UpdateEndpointLongRunningRequest, lro::Operation>("UpdateEndpointLongRunning", grpcClient.UpdateEndpointLongRunningAsync, grpcClient.UpdateEndpointLongRunning, effectiveSettings.UpdateEndpointLongRunningSettings).WithGoogleRequestParam("endpoint.name", request => request.Endpoint?.Name);
            Modify_ApiCall(ref _callUpdateEndpointLongRunning);
            Modify_UpdateEndpointLongRunningApiCall(ref _callUpdateEndpointLongRunning);
            _callDeleteEndpoint = clientHelper.BuildApiCall<DeleteEndpointRequest, lro::Operation>("DeleteEndpoint", grpcClient.DeleteEndpointAsync, grpcClient.DeleteEndpoint, effectiveSettings.DeleteEndpointSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteEndpoint);
            Modify_DeleteEndpointApiCall(ref _callDeleteEndpoint);
            _callDeployModel = clientHelper.BuildApiCall<DeployModelRequest, lro::Operation>("DeployModel", grpcClient.DeployModelAsync, grpcClient.DeployModel, effectiveSettings.DeployModelSettings).WithGoogleRequestParam("endpoint", request => request.Endpoint);
            Modify_ApiCall(ref _callDeployModel);
            Modify_DeployModelApiCall(ref _callDeployModel);
            _callUndeployModel = clientHelper.BuildApiCall<UndeployModelRequest, lro::Operation>("UndeployModel", grpcClient.UndeployModelAsync, grpcClient.UndeployModel, effectiveSettings.UndeployModelSettings).WithGoogleRequestParam("endpoint", request => request.Endpoint);
            Modify_ApiCall(ref _callUndeployModel);
            Modify_UndeployModelApiCall(ref _callUndeployModel);
            _callMutateDeployedModel = clientHelper.BuildApiCall<MutateDeployedModelRequest, lro::Operation>("MutateDeployedModel", grpcClient.MutateDeployedModelAsync, grpcClient.MutateDeployedModel, effectiveSettings.MutateDeployedModelSettings).WithGoogleRequestParam("endpoint", request => request.Endpoint);
            Modify_ApiCall(ref _callMutateDeployedModel);
            Modify_MutateDeployedModelApiCall(ref _callMutateDeployedModel);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateEndpointApiCall(ref gaxgrpc::ApiCall<CreateEndpointRequest, lro::Operation> call);

        partial void Modify_GetEndpointApiCall(ref gaxgrpc::ApiCall<GetEndpointRequest, Endpoint> call);

        partial void Modify_ListEndpointsApiCall(ref gaxgrpc::ApiCall<ListEndpointsRequest, ListEndpointsResponse> call);

        partial void Modify_UpdateEndpointApiCall(ref gaxgrpc::ApiCall<UpdateEndpointRequest, Endpoint> call);

        partial void Modify_UpdateEndpointLongRunningApiCall(ref gaxgrpc::ApiCall<UpdateEndpointLongRunningRequest, lro::Operation> call);

        partial void Modify_DeleteEndpointApiCall(ref gaxgrpc::ApiCall<DeleteEndpointRequest, lro::Operation> call);

        partial void Modify_DeployModelApiCall(ref gaxgrpc::ApiCall<DeployModelRequest, lro::Operation> call);

        partial void Modify_UndeployModelApiCall(ref gaxgrpc::ApiCall<UndeployModelRequest, lro::Operation> call);

        partial void Modify_MutateDeployedModelApiCall(ref gaxgrpc::ApiCall<MutateDeployedModelRequest, lro::Operation> call);

        partial void OnConstruction(EndpointService.EndpointServiceClient grpcClient, EndpointServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC EndpointService client</summary>
        public override EndpointService.EndpointServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateEndpointRequest(ref CreateEndpointRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEndpointRequest(ref GetEndpointRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEndpointsRequest(ref ListEndpointsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateEndpointRequest(ref UpdateEndpointRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateEndpointLongRunningRequest(ref UpdateEndpointLongRunningRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteEndpointRequest(ref DeleteEndpointRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeployModelRequest(ref DeployModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UndeployModelRequest(ref UndeployModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateDeployedModelRequest(ref MutateDeployedModelRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateEndpoint</c>.</summary>
        public override lro::OperationsClient CreateEndpointOperationsClient { get; }

        /// <summary>
        /// Creates an Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Endpoint, CreateEndpointOperationMetadata> CreateEndpoint(CreateEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEndpointRequest(ref request, ref callSettings);
            return new lro::Operation<Endpoint, CreateEndpointOperationMetadata>(_callCreateEndpoint.Sync(request, callSettings), CreateEndpointOperationsClient);
        }

        /// <summary>
        /// Creates an Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Endpoint, CreateEndpointOperationMetadata>> CreateEndpointAsync(CreateEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEndpointRequest(ref request, ref callSettings);
            return new lro::Operation<Endpoint, CreateEndpointOperationMetadata>(await _callCreateEndpoint.Async(request, callSettings).ConfigureAwait(false), CreateEndpointOperationsClient);
        }

        /// <summary>
        /// Gets an Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Endpoint GetEndpoint(GetEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEndpointRequest(ref request, ref callSettings);
            return _callGetEndpoint.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Endpoint> GetEndpointAsync(GetEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEndpointRequest(ref request, ref callSettings);
            return _callGetEndpoint.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Endpoints in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Endpoint"/> resources.</returns>
        public override gax::PagedEnumerable<ListEndpointsResponse, Endpoint> ListEndpoints(ListEndpointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEndpointsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEndpointsRequest, ListEndpointsResponse, Endpoint>(_callListEndpoints, request, callSettings);
        }

        /// <summary>
        /// Lists Endpoints in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Endpoint"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEndpointsResponse, Endpoint> ListEndpointsAsync(ListEndpointsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEndpointsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEndpointsRequest, ListEndpointsResponse, Endpoint>(_callListEndpoints, request, callSettings);
        }

        /// <summary>
        /// Updates an Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Endpoint UpdateEndpoint(UpdateEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEndpointRequest(ref request, ref callSettings);
            return _callUpdateEndpoint.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Endpoint> UpdateEndpointAsync(UpdateEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEndpointRequest(ref request, ref callSettings);
            return _callUpdateEndpoint.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateEndpointLongRunning</c>.</summary>
        public override lro::OperationsClient UpdateEndpointLongRunningOperationsClient { get; }

        /// <summary>
        /// Updates an Endpoint with a long running operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Endpoint, UpdateEndpointOperationMetadata> UpdateEndpointLongRunning(UpdateEndpointLongRunningRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEndpointLongRunningRequest(ref request, ref callSettings);
            return new lro::Operation<Endpoint, UpdateEndpointOperationMetadata>(_callUpdateEndpointLongRunning.Sync(request, callSettings), UpdateEndpointLongRunningOperationsClient);
        }

        /// <summary>
        /// Updates an Endpoint with a long running operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Endpoint, UpdateEndpointOperationMetadata>> UpdateEndpointLongRunningAsync(UpdateEndpointLongRunningRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEndpointLongRunningRequest(ref request, ref callSettings);
            return new lro::Operation<Endpoint, UpdateEndpointOperationMetadata>(await _callUpdateEndpointLongRunning.Async(request, callSettings).ConfigureAwait(false), UpdateEndpointLongRunningOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteEndpoint</c>.</summary>
        public override lro::OperationsClient DeleteEndpointOperationsClient { get; }

        /// <summary>
        /// Deletes an Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteOperationMetadata> DeleteEndpoint(DeleteEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEndpointRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(_callDeleteEndpoint.Sync(request, callSettings), DeleteEndpointOperationsClient);
        }

        /// <summary>
        /// Deletes an Endpoint.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteOperationMetadata>> DeleteEndpointAsync(DeleteEndpointRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEndpointRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteOperationMetadata>(await _callDeleteEndpoint.Async(request, callSettings).ConfigureAwait(false), DeleteEndpointOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeployModel</c>.</summary>
        public override lro::OperationsClient DeployModelOperationsClient { get; }

        /// <summary>
        /// Deploys a Model into this Endpoint, creating a DeployedModel within it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DeployModelResponse, DeployModelOperationMetadata> DeployModel(DeployModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeployModelRequest(ref request, ref callSettings);
            return new lro::Operation<DeployModelResponse, DeployModelOperationMetadata>(_callDeployModel.Sync(request, callSettings), DeployModelOperationsClient);
        }

        /// <summary>
        /// Deploys a Model into this Endpoint, creating a DeployedModel within it.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DeployModelResponse, DeployModelOperationMetadata>> DeployModelAsync(DeployModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeployModelRequest(ref request, ref callSettings);
            return new lro::Operation<DeployModelResponse, DeployModelOperationMetadata>(await _callDeployModel.Async(request, callSettings).ConfigureAwait(false), DeployModelOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UndeployModel</c>.</summary>
        public override lro::OperationsClient UndeployModelOperationsClient { get; }

        /// <summary>
        /// Undeploys a Model from an Endpoint, removing a DeployedModel from it, and
        /// freeing all resources it's using.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<UndeployModelResponse, UndeployModelOperationMetadata> UndeployModel(UndeployModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeployModelRequest(ref request, ref callSettings);
            return new lro::Operation<UndeployModelResponse, UndeployModelOperationMetadata>(_callUndeployModel.Sync(request, callSettings), UndeployModelOperationsClient);
        }

        /// <summary>
        /// Undeploys a Model from an Endpoint, removing a DeployedModel from it, and
        /// freeing all resources it's using.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<UndeployModelResponse, UndeployModelOperationMetadata>> UndeployModelAsync(UndeployModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeployModelRequest(ref request, ref callSettings);
            return new lro::Operation<UndeployModelResponse, UndeployModelOperationMetadata>(await _callUndeployModel.Async(request, callSettings).ConfigureAwait(false), UndeployModelOperationsClient);
        }

        /// <summary>The long-running operations client for <c>MutateDeployedModel</c>.</summary>
        public override lro::OperationsClient MutateDeployedModelOperationsClient { get; }

        /// <summary>
        /// Updates an existing deployed model. Updatable fields include
        /// `min_replica_count`, `max_replica_count`, `autoscaling_metric_specs`,
        /// `disable_container_logging` (v1 only), and `enable_container_logging`
        /// (v1beta1 only).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MutateDeployedModelResponse, MutateDeployedModelOperationMetadata> MutateDeployedModel(MutateDeployedModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateDeployedModelRequest(ref request, ref callSettings);
            return new lro::Operation<MutateDeployedModelResponse, MutateDeployedModelOperationMetadata>(_callMutateDeployedModel.Sync(request, callSettings), MutateDeployedModelOperationsClient);
        }

        /// <summary>
        /// Updates an existing deployed model. Updatable fields include
        /// `min_replica_count`, `max_replica_count`, `autoscaling_metric_specs`,
        /// `disable_container_logging` (v1 only), and `enable_container_logging`
        /// (v1beta1 only).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MutateDeployedModelResponse, MutateDeployedModelOperationMetadata>> MutateDeployedModelAsync(MutateDeployedModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateDeployedModelRequest(ref request, ref callSettings);
            return new lro::Operation<MutateDeployedModelResponse, MutateDeployedModelOperationMetadata>(await _callMutateDeployedModel.Async(request, callSettings).ConfigureAwait(false), MutateDeployedModelOperationsClient);
        }
    }

    public partial class ListEndpointsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEndpointsResponse : gaxgrpc::IPageResponse<Endpoint>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Endpoint> GetEnumerator() => Endpoints.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class EndpointService
    {
        public partial class EndpointServiceClient
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

    public static partial class EndpointService
    {
        public partial class EndpointServiceClient
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
