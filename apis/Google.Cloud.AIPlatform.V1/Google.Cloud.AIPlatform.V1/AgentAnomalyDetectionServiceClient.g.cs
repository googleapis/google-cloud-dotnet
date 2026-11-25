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
    /// <summary>Settings for <see cref="AgentAnomalyDetectionServiceClient"/> instances.</summary>
    public sealed partial class AgentAnomalyDetectionServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AgentAnomalyDetectionServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AgentAnomalyDetectionServiceSettings"/>.</returns>
        public static AgentAnomalyDetectionServiceSettings GetDefault() => new AgentAnomalyDetectionServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AgentAnomalyDetectionServiceSettings"/> object with default settings.
        /// </summary>
        public AgentAnomalyDetectionServiceSettings()
        {
        }

        private AgentAnomalyDetectionServiceSettings(AgentAnomalyDetectionServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetAgentAnomalyDetectionScopeSettings = existing.GetAgentAnomalyDetectionScopeSettings;
            GetMonitoredAgentSettings = existing.GetMonitoredAgentSettings;
            ListMonitoredAgentsSettings = existing.ListMonitoredAgentsSettings;
            EnableMonitoredAgentSettings = existing.EnableMonitoredAgentSettings;
            EnableMonitoredAgentOperationsSettings = existing.EnableMonitoredAgentOperationsSettings.Clone();
            DisableMonitoredAgentSettings = existing.DisableMonitoredAgentSettings;
            DisableMonitoredAgentOperationsSettings = existing.DisableMonitoredAgentOperationsSettings.Clone();
            DeleteAgentAnomalyDetectionScopeSettings = existing.DeleteAgentAnomalyDetectionScopeSettings;
            DeleteAgentAnomalyDetectionScopeOperationsSettings = existing.DeleteAgentAnomalyDetectionScopeOperationsSettings.Clone();
            CreateAgentAnomalyDetectionScopeSettings = existing.CreateAgentAnomalyDetectionScopeSettings;
            CreateAgentAnomalyDetectionScopeOperationsSettings = existing.CreateAgentAnomalyDetectionScopeOperationsSettings.Clone();
            ListAgentAnomalyDetectionScopesSettings = existing.ListAgentAnomalyDetectionScopesSettings;
            ListAnalyzedSessionsSettings = existing.ListAnalyzedSessionsSettings;
            GetAnalyzedSessionSettings = existing.GetAnalyzedSessionSettings;
            ListAnalyzedInvocationsSettings = existing.ListAnalyzedInvocationsSettings;
            GetAnalyzedInvocationSettings = existing.GetAnalyzedInvocationSettings;
            AggregateAnalyzedSessionsSettings = existing.AggregateAnalyzedSessionsSettings;
            ClearTrainingDataSettings = existing.ClearTrainingDataSettings;
            ClearTrainingDataOperationsSettings = existing.ClearTrainingDataOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(AgentAnomalyDetectionServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentAnomalyDetectionServiceClient.GetAgentAnomalyDetectionScope</c> and
        /// <c>AgentAnomalyDetectionServiceClient.GetAgentAnomalyDetectionScopeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAgentAnomalyDetectionScopeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentAnomalyDetectionServiceClient.GetMonitoredAgent</c> and
        /// <c>AgentAnomalyDetectionServiceClient.GetMonitoredAgentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMonitoredAgentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentAnomalyDetectionServiceClient.ListMonitoredAgents</c> and
        /// <c>AgentAnomalyDetectionServiceClient.ListMonitoredAgentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListMonitoredAgentsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentAnomalyDetectionServiceClient.EnableMonitoredAgent</c> and
        /// <c>AgentAnomalyDetectionServiceClient.EnableMonitoredAgentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings EnableMonitoredAgentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>AgentAnomalyDetectionServiceClient.EnableMonitoredAgent</c>
        /// and <c>AgentAnomalyDetectionServiceClient.EnableMonitoredAgentAsync</c>.
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
        public lro::OperationsSettings EnableMonitoredAgentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentAnomalyDetectionServiceClient.DisableMonitoredAgent</c> and
        /// <c>AgentAnomalyDetectionServiceClient.DisableMonitoredAgentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DisableMonitoredAgentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>AgentAnomalyDetectionServiceClient.DisableMonitoredAgent</c>
        /// and <c>AgentAnomalyDetectionServiceClient.DisableMonitoredAgentAsync</c>.
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
        public lro::OperationsSettings DisableMonitoredAgentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentAnomalyDetectionServiceClient.DeleteAgentAnomalyDetectionScope</c> and
        /// <c>AgentAnomalyDetectionServiceClient.DeleteAgentAnomalyDetectionScopeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAgentAnomalyDetectionScopeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>AgentAnomalyDetectionServiceClient.DeleteAgentAnomalyDetectionScope</c> and
        /// <c>AgentAnomalyDetectionServiceClient.DeleteAgentAnomalyDetectionScopeAsync</c>.
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
        public lro::OperationsSettings DeleteAgentAnomalyDetectionScopeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentAnomalyDetectionServiceClient.CreateAgentAnomalyDetectionScope</c> and
        /// <c>AgentAnomalyDetectionServiceClient.CreateAgentAnomalyDetectionScopeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAgentAnomalyDetectionScopeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>AgentAnomalyDetectionServiceClient.CreateAgentAnomalyDetectionScope</c> and
        /// <c>AgentAnomalyDetectionServiceClient.CreateAgentAnomalyDetectionScopeAsync</c>.
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
        public lro::OperationsSettings CreateAgentAnomalyDetectionScopeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentAnomalyDetectionServiceClient.ListAgentAnomalyDetectionScopes</c> and
        /// <c>AgentAnomalyDetectionServiceClient.ListAgentAnomalyDetectionScopesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAgentAnomalyDetectionScopesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentAnomalyDetectionServiceClient.ListAnalyzedSessions</c> and
        /// <c>AgentAnomalyDetectionServiceClient.ListAnalyzedSessionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAnalyzedSessionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentAnomalyDetectionServiceClient.GetAnalyzedSession</c> and
        /// <c>AgentAnomalyDetectionServiceClient.GetAnalyzedSessionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAnalyzedSessionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentAnomalyDetectionServiceClient.ListAnalyzedInvocations</c> and
        /// <c>AgentAnomalyDetectionServiceClient.ListAnalyzedInvocationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAnalyzedInvocationsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentAnomalyDetectionServiceClient.GetAnalyzedInvocation</c> and
        /// <c>AgentAnomalyDetectionServiceClient.GetAnalyzedInvocationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAnalyzedInvocationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentAnomalyDetectionServiceClient.AggregateAnalyzedSessions</c> and
        /// <c>AgentAnomalyDetectionServiceClient.AggregateAnalyzedSessionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AggregateAnalyzedSessionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentAnomalyDetectionServiceClient.ClearTrainingData</c> and
        /// <c>AgentAnomalyDetectionServiceClient.ClearTrainingDataAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ClearTrainingDataSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>AgentAnomalyDetectionServiceClient.ClearTrainingData</c> and
        /// <c>AgentAnomalyDetectionServiceClient.ClearTrainingDataAsync</c>.
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
        public lro::OperationsSettings ClearTrainingDataOperationsSettings { get; set; } = new lro::OperationsSettings
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
        /// <returns>A deep clone of this <see cref="AgentAnomalyDetectionServiceSettings"/> object.</returns>
        public AgentAnomalyDetectionServiceSettings Clone() => new AgentAnomalyDetectionServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AgentAnomalyDetectionServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class AgentAnomalyDetectionServiceClientBuilder : gaxgrpc::ClientBuilderBase<AgentAnomalyDetectionServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AgentAnomalyDetectionServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AgentAnomalyDetectionServiceClientBuilder() : base(AgentAnomalyDetectionServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AgentAnomalyDetectionServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AgentAnomalyDetectionServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AgentAnomalyDetectionServiceClient Build()
        {
            AgentAnomalyDetectionServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AgentAnomalyDetectionServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AgentAnomalyDetectionServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AgentAnomalyDetectionServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AgentAnomalyDetectionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AgentAnomalyDetectionServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AgentAnomalyDetectionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AgentAnomalyDetectionServiceClient.ChannelPool;
    }

    /// <summary>AgentAnomalyDetectionService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service for managing Agent Anomaly Detection for monitored agents.
    /// </remarks>
    public abstract partial class AgentAnomalyDetectionServiceClient
    {
        /// <summary>
        /// The default endpoint for the AgentAnomalyDetectionService service, which is a host of
        /// "aiplatform.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "aiplatform.googleapis.com:443";

        /// <summary>The default AgentAnomalyDetectionService scopes.</summary>
        /// <remarks>
        /// The default AgentAnomalyDetectionService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AgentAnomalyDetectionService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AgentAnomalyDetectionServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="AgentAnomalyDetectionServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AgentAnomalyDetectionServiceClient"/>.</returns>
        public static stt::Task<AgentAnomalyDetectionServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AgentAnomalyDetectionServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AgentAnomalyDetectionServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="AgentAnomalyDetectionServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AgentAnomalyDetectionServiceClient"/>.</returns>
        public static AgentAnomalyDetectionServiceClient Create() => new AgentAnomalyDetectionServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AgentAnomalyDetectionServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AgentAnomalyDetectionServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AgentAnomalyDetectionServiceClient"/>.</returns>
        internal static AgentAnomalyDetectionServiceClient Create(grpccore::CallInvoker callInvoker, AgentAnomalyDetectionServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AgentAnomalyDetectionService.AgentAnomalyDetectionServiceClient grpcClient = new AgentAnomalyDetectionService.AgentAnomalyDetectionServiceClient(callInvoker);
            return new AgentAnomalyDetectionServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AgentAnomalyDetectionService client</summary>
        public virtual AgentAnomalyDetectionService.AgentAnomalyDetectionServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a specific AgentAnomalyDetectionScope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AgentAnomalyDetectionScope GetAgentAnomalyDetectionScope(GetAgentAnomalyDetectionScopeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a specific AgentAnomalyDetectionScope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AgentAnomalyDetectionScope> GetAgentAnomalyDetectionScopeAsync(GetAgentAnomalyDetectionScopeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a specific AgentAnomalyDetectionScope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AgentAnomalyDetectionScope> GetAgentAnomalyDetectionScopeAsync(GetAgentAnomalyDetectionScopeRequest request, st::CancellationToken cancellationToken) =>
            GetAgentAnomalyDetectionScopeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a specific AgentAnomalyDetectionScope.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AgentAnomalyDetectionScope resource.
        /// Format:
        /// `projects/{project}/locations/{location}/agentAnomalyDetectionScopes/{agent_anomaly_detection_scope}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AgentAnomalyDetectionScope GetAgentAnomalyDetectionScope(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAgentAnomalyDetectionScope(new GetAgentAnomalyDetectionScopeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific AgentAnomalyDetectionScope.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AgentAnomalyDetectionScope resource.
        /// Format:
        /// `projects/{project}/locations/{location}/agentAnomalyDetectionScopes/{agent_anomaly_detection_scope}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AgentAnomalyDetectionScope> GetAgentAnomalyDetectionScopeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAgentAnomalyDetectionScopeAsync(new GetAgentAnomalyDetectionScopeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific AgentAnomalyDetectionScope.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AgentAnomalyDetectionScope resource.
        /// Format:
        /// `projects/{project}/locations/{location}/agentAnomalyDetectionScopes/{agent_anomaly_detection_scope}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AgentAnomalyDetectionScope> GetAgentAnomalyDetectionScopeAsync(string name, st::CancellationToken cancellationToken) =>
            GetAgentAnomalyDetectionScopeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a specific AgentAnomalyDetectionScope.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AgentAnomalyDetectionScope resource.
        /// Format:
        /// `projects/{project}/locations/{location}/agentAnomalyDetectionScopes/{agent_anomaly_detection_scope}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AgentAnomalyDetectionScope GetAgentAnomalyDetectionScope(AgentAnomalyDetectionScopeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAgentAnomalyDetectionScope(new GetAgentAnomalyDetectionScopeRequest
            {
                AgentAnomalyDetectionScopeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific AgentAnomalyDetectionScope.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AgentAnomalyDetectionScope resource.
        /// Format:
        /// `projects/{project}/locations/{location}/agentAnomalyDetectionScopes/{agent_anomaly_detection_scope}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AgentAnomalyDetectionScope> GetAgentAnomalyDetectionScopeAsync(AgentAnomalyDetectionScopeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAgentAnomalyDetectionScopeAsync(new GetAgentAnomalyDetectionScopeRequest
            {
                AgentAnomalyDetectionScopeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific AgentAnomalyDetectionScope.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AgentAnomalyDetectionScope resource.
        /// Format:
        /// `projects/{project}/locations/{location}/agentAnomalyDetectionScopes/{agent_anomaly_detection_scope}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AgentAnomalyDetectionScope> GetAgentAnomalyDetectionScopeAsync(AgentAnomalyDetectionScopeName name, st::CancellationToken cancellationToken) =>
            GetAgentAnomalyDetectionScopeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a specific MonitoredAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MonitoredAgent GetMonitoredAgent(GetMonitoredAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a specific MonitoredAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MonitoredAgent> GetMonitoredAgentAsync(GetMonitoredAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a specific MonitoredAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MonitoredAgent> GetMonitoredAgentAsync(GetMonitoredAgentRequest request, st::CancellationToken cancellationToken) =>
            GetMonitoredAgentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a specific MonitoredAgent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MonitoredAgent resource.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MonitoredAgent GetMonitoredAgent(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMonitoredAgent(new GetMonitoredAgentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific MonitoredAgent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MonitoredAgent resource.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MonitoredAgent> GetMonitoredAgentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetMonitoredAgentAsync(new GetMonitoredAgentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific MonitoredAgent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MonitoredAgent resource.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MonitoredAgent> GetMonitoredAgentAsync(string name, st::CancellationToken cancellationToken) =>
            GetMonitoredAgentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a specific MonitoredAgent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MonitoredAgent resource.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MonitoredAgent GetMonitoredAgent(MonitoredAgentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMonitoredAgent(new GetMonitoredAgentRequest
            {
                MonitoredAgentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific MonitoredAgent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MonitoredAgent resource.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MonitoredAgent> GetMonitoredAgentAsync(MonitoredAgentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetMonitoredAgentAsync(new GetMonitoredAgentRequest
            {
                MonitoredAgentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific MonitoredAgent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MonitoredAgent resource.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MonitoredAgent> GetMonitoredAgentAsync(MonitoredAgentName name, st::CancellationToken cancellationToken) =>
            GetMonitoredAgentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists MonitoredAgents in a specific Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MonitoredAgent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMonitoredAgentsResponse, MonitoredAgent> ListMonitoredAgents(ListMonitoredAgentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists MonitoredAgents in a specific Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MonitoredAgent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMonitoredAgentsResponse, MonitoredAgent> ListMonitoredAgentsAsync(ListMonitoredAgentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists MonitoredAgents in a specific Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the
        /// MonitoredAgents from. Format:
        /// `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="MonitoredAgent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMonitoredAgentsResponse, MonitoredAgent> ListMonitoredAgents(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMonitoredAgentsRequest request = new ListMonitoredAgentsRequest
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
            return ListMonitoredAgents(request, callSettings);
        }

        /// <summary>
        /// Lists MonitoredAgents in a specific Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the
        /// MonitoredAgents from. Format:
        /// `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="MonitoredAgent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMonitoredAgentsResponse, MonitoredAgent> ListMonitoredAgentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMonitoredAgentsRequest request = new ListMonitoredAgentsRequest
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
            return ListMonitoredAgentsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists MonitoredAgents in a specific Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the
        /// MonitoredAgents from. Format:
        /// `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="MonitoredAgent"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMonitoredAgentsResponse, MonitoredAgent> ListMonitoredAgents(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMonitoredAgentsRequest request = new ListMonitoredAgentsRequest
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
            return ListMonitoredAgents(request, callSettings);
        }

        /// <summary>
        /// Lists MonitoredAgents in a specific Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the
        /// MonitoredAgents from. Format:
        /// `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="MonitoredAgent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMonitoredAgentsResponse, MonitoredAgent> ListMonitoredAgentsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListMonitoredAgentsRequest request = new ListMonitoredAgentsRequest
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
            return ListMonitoredAgentsAsync(request, callSettings);
        }

        /// <summary>
        /// Enables a specific MonitoredAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MonitoredAgent, EnableMonitoredAgentOperationMetadata> EnableMonitoredAgent(EnableMonitoredAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enables a specific MonitoredAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MonitoredAgent, EnableMonitoredAgentOperationMetadata>> EnableMonitoredAgentAsync(EnableMonitoredAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enables a specific MonitoredAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MonitoredAgent, EnableMonitoredAgentOperationMetadata>> EnableMonitoredAgentAsync(EnableMonitoredAgentRequest request, st::CancellationToken cancellationToken) =>
            EnableMonitoredAgentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>EnableMonitoredAgent</c>.</summary>
        public virtual lro::OperationsClient EnableMonitoredAgentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>EnableMonitoredAgent</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MonitoredAgent, EnableMonitoredAgentOperationMetadata> PollOnceEnableMonitoredAgent(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MonitoredAgent, EnableMonitoredAgentOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), EnableMonitoredAgentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>EnableMonitoredAgent</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MonitoredAgent, EnableMonitoredAgentOperationMetadata>> PollOnceEnableMonitoredAgentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MonitoredAgent, EnableMonitoredAgentOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), EnableMonitoredAgentOperationsClient, callSettings);

        /// <summary>
        /// Enables a specific MonitoredAgent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MonitoredAgent resource to be enabled.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MonitoredAgent, EnableMonitoredAgentOperationMetadata> EnableMonitoredAgent(string name, gaxgrpc::CallSettings callSettings = null) =>
            EnableMonitoredAgent(new EnableMonitoredAgentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Enables a specific MonitoredAgent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MonitoredAgent resource to be enabled.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MonitoredAgent, EnableMonitoredAgentOperationMetadata>> EnableMonitoredAgentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            EnableMonitoredAgentAsync(new EnableMonitoredAgentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Enables a specific MonitoredAgent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MonitoredAgent resource to be enabled.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MonitoredAgent, EnableMonitoredAgentOperationMetadata>> EnableMonitoredAgentAsync(string name, st::CancellationToken cancellationToken) =>
            EnableMonitoredAgentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Enables a specific MonitoredAgent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MonitoredAgent resource to be enabled.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MonitoredAgent, EnableMonitoredAgentOperationMetadata> EnableMonitoredAgent(MonitoredAgentName name, gaxgrpc::CallSettings callSettings = null) =>
            EnableMonitoredAgent(new EnableMonitoredAgentRequest
            {
                MonitoredAgentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Enables a specific MonitoredAgent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MonitoredAgent resource to be enabled.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MonitoredAgent, EnableMonitoredAgentOperationMetadata>> EnableMonitoredAgentAsync(MonitoredAgentName name, gaxgrpc::CallSettings callSettings = null) =>
            EnableMonitoredAgentAsync(new EnableMonitoredAgentRequest
            {
                MonitoredAgentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Enables a specific MonitoredAgent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MonitoredAgent resource to be enabled.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MonitoredAgent, EnableMonitoredAgentOperationMetadata>> EnableMonitoredAgentAsync(MonitoredAgentName name, st::CancellationToken cancellationToken) =>
            EnableMonitoredAgentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Disables a specific MonitoredAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MonitoredAgent, DisableMonitoredAgentOperationMetadata> DisableMonitoredAgent(DisableMonitoredAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disables a specific MonitoredAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MonitoredAgent, DisableMonitoredAgentOperationMetadata>> DisableMonitoredAgentAsync(DisableMonitoredAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disables a specific MonitoredAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MonitoredAgent, DisableMonitoredAgentOperationMetadata>> DisableMonitoredAgentAsync(DisableMonitoredAgentRequest request, st::CancellationToken cancellationToken) =>
            DisableMonitoredAgentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DisableMonitoredAgent</c>.</summary>
        public virtual lro::OperationsClient DisableMonitoredAgentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DisableMonitoredAgent</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<MonitoredAgent, DisableMonitoredAgentOperationMetadata> PollOnceDisableMonitoredAgent(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MonitoredAgent, DisableMonitoredAgentOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DisableMonitoredAgentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DisableMonitoredAgent</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<MonitoredAgent, DisableMonitoredAgentOperationMetadata>> PollOnceDisableMonitoredAgentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<MonitoredAgent, DisableMonitoredAgentOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DisableMonitoredAgentOperationsClient, callSettings);

        /// <summary>
        /// Disables a specific MonitoredAgent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MonitoredAgent resource to be disabled.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MonitoredAgent, DisableMonitoredAgentOperationMetadata> DisableMonitoredAgent(string name, gaxgrpc::CallSettings callSettings = null) =>
            DisableMonitoredAgent(new DisableMonitoredAgentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Disables a specific MonitoredAgent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MonitoredAgent resource to be disabled.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MonitoredAgent, DisableMonitoredAgentOperationMetadata>> DisableMonitoredAgentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DisableMonitoredAgentAsync(new DisableMonitoredAgentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Disables a specific MonitoredAgent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MonitoredAgent resource to be disabled.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MonitoredAgent, DisableMonitoredAgentOperationMetadata>> DisableMonitoredAgentAsync(string name, st::CancellationToken cancellationToken) =>
            DisableMonitoredAgentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Disables a specific MonitoredAgent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MonitoredAgent resource to be disabled.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<MonitoredAgent, DisableMonitoredAgentOperationMetadata> DisableMonitoredAgent(MonitoredAgentName name, gaxgrpc::CallSettings callSettings = null) =>
            DisableMonitoredAgent(new DisableMonitoredAgentRequest
            {
                MonitoredAgentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Disables a specific MonitoredAgent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MonitoredAgent resource to be disabled.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MonitoredAgent, DisableMonitoredAgentOperationMetadata>> DisableMonitoredAgentAsync(MonitoredAgentName name, gaxgrpc::CallSettings callSettings = null) =>
            DisableMonitoredAgentAsync(new DisableMonitoredAgentRequest
            {
                MonitoredAgentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Disables a specific MonitoredAgent.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the MonitoredAgent resource to be disabled.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<MonitoredAgent, DisableMonitoredAgentOperationMetadata>> DisableMonitoredAgentAsync(MonitoredAgentName name, st::CancellationToken cancellationToken) =>
            DisableMonitoredAgentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a specific AgentAnomalyDetectionScope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteAgentAnomalyDetectionScopeOperationMetadata> DeleteAgentAnomalyDetectionScope(DeleteAgentAnomalyDetectionScopeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a specific AgentAnomalyDetectionScope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteAgentAnomalyDetectionScopeOperationMetadata>> DeleteAgentAnomalyDetectionScopeAsync(DeleteAgentAnomalyDetectionScopeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a specific AgentAnomalyDetectionScope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteAgentAnomalyDetectionScopeOperationMetadata>> DeleteAgentAnomalyDetectionScopeAsync(DeleteAgentAnomalyDetectionScopeRequest request, st::CancellationToken cancellationToken) =>
            DeleteAgentAnomalyDetectionScopeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteAgentAnomalyDetectionScope</c>.</summary>
        public virtual lro::OperationsClient DeleteAgentAnomalyDetectionScopeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteAgentAnomalyDetectionScope</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteAgentAnomalyDetectionScopeOperationMetadata> PollOnceDeleteAgentAnomalyDetectionScope(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteAgentAnomalyDetectionScopeOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAgentAnomalyDetectionScopeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteAgentAnomalyDetectionScope</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteAgentAnomalyDetectionScopeOperationMetadata>> PollOnceDeleteAgentAnomalyDetectionScopeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteAgentAnomalyDetectionScopeOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAgentAnomalyDetectionScopeOperationsClient, callSettings);

        /// <summary>
        /// Deletes a specific AgentAnomalyDetectionScope.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AgentAnomalyDetectionScope resource to be
        /// deleted. Format:
        /// `projects/{project}/locations/{location}/agentAnomalyDetectionScopes/{agent_anomaly_detection_scope}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteAgentAnomalyDetectionScopeOperationMetadata> DeleteAgentAnomalyDetectionScope(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAgentAnomalyDetectionScope(new DeleteAgentAnomalyDetectionScopeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific AgentAnomalyDetectionScope.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AgentAnomalyDetectionScope resource to be
        /// deleted. Format:
        /// `projects/{project}/locations/{location}/agentAnomalyDetectionScopes/{agent_anomaly_detection_scope}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteAgentAnomalyDetectionScopeOperationMetadata>> DeleteAgentAnomalyDetectionScopeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAgentAnomalyDetectionScopeAsync(new DeleteAgentAnomalyDetectionScopeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific AgentAnomalyDetectionScope.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AgentAnomalyDetectionScope resource to be
        /// deleted. Format:
        /// `projects/{project}/locations/{location}/agentAnomalyDetectionScopes/{agent_anomaly_detection_scope}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteAgentAnomalyDetectionScopeOperationMetadata>> DeleteAgentAnomalyDetectionScopeAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAgentAnomalyDetectionScopeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a specific AgentAnomalyDetectionScope.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AgentAnomalyDetectionScope resource to be
        /// deleted. Format:
        /// `projects/{project}/locations/{location}/agentAnomalyDetectionScopes/{agent_anomaly_detection_scope}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteAgentAnomalyDetectionScopeOperationMetadata> DeleteAgentAnomalyDetectionScope(AgentAnomalyDetectionScopeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAgentAnomalyDetectionScope(new DeleteAgentAnomalyDetectionScopeRequest
            {
                AgentAnomalyDetectionScopeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific AgentAnomalyDetectionScope.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AgentAnomalyDetectionScope resource to be
        /// deleted. Format:
        /// `projects/{project}/locations/{location}/agentAnomalyDetectionScopes/{agent_anomaly_detection_scope}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteAgentAnomalyDetectionScopeOperationMetadata>> DeleteAgentAnomalyDetectionScopeAsync(AgentAnomalyDetectionScopeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAgentAnomalyDetectionScopeAsync(new DeleteAgentAnomalyDetectionScopeRequest
            {
                AgentAnomalyDetectionScopeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a specific AgentAnomalyDetectionScope.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AgentAnomalyDetectionScope resource to be
        /// deleted. Format:
        /// `projects/{project}/locations/{location}/agentAnomalyDetectionScopes/{agent_anomaly_detection_scope}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteAgentAnomalyDetectionScopeOperationMetadata>> DeleteAgentAnomalyDetectionScopeAsync(AgentAnomalyDetectionScopeName name, st::CancellationToken cancellationToken) =>
            DeleteAgentAnomalyDetectionScopeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new AgentAnomalyDetectionScope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AgentAnomalyDetectionScope, CreateAgentAnomalyDetectionScopeOperationMetadata> CreateAgentAnomalyDetectionScope(CreateAgentAnomalyDetectionScopeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new AgentAnomalyDetectionScope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AgentAnomalyDetectionScope, CreateAgentAnomalyDetectionScopeOperationMetadata>> CreateAgentAnomalyDetectionScopeAsync(CreateAgentAnomalyDetectionScopeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new AgentAnomalyDetectionScope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AgentAnomalyDetectionScope, CreateAgentAnomalyDetectionScopeOperationMetadata>> CreateAgentAnomalyDetectionScopeAsync(CreateAgentAnomalyDetectionScopeRequest request, st::CancellationToken cancellationToken) =>
            CreateAgentAnomalyDetectionScopeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateAgentAnomalyDetectionScope</c>.</summary>
        public virtual lro::OperationsClient CreateAgentAnomalyDetectionScopeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateAgentAnomalyDetectionScope</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AgentAnomalyDetectionScope, CreateAgentAnomalyDetectionScopeOperationMetadata> PollOnceCreateAgentAnomalyDetectionScope(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AgentAnomalyDetectionScope, CreateAgentAnomalyDetectionScopeOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAgentAnomalyDetectionScopeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateAgentAnomalyDetectionScope</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AgentAnomalyDetectionScope, CreateAgentAnomalyDetectionScopeOperationMetadata>> PollOnceCreateAgentAnomalyDetectionScopeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AgentAnomalyDetectionScope, CreateAgentAnomalyDetectionScopeOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAgentAnomalyDetectionScopeOperationsClient, callSettings);

        /// <summary>
        /// Creates a new AgentAnomalyDetectionScope.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the
        /// AgentAnomalyDetectionScope in. Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="agentAnomalyDetectionScope">
        /// Required. The AgentAnomalyDetectionScope to create.
        /// </param>
        /// <param name="agentAnomalyDetectionScopeId">
        /// Required. The ID to use for the AgentAnomalyDetectionScope, which will
        /// become the final component of the AgentAnomalyDetectionScope's resource
        /// name.
        /// 
        /// This value should be 1-63 characters, and valid characters
        /// are /[a-z]([a-z0-9-]{0,61}[a-z0-9])?/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AgentAnomalyDetectionScope, CreateAgentAnomalyDetectionScopeOperationMetadata> CreateAgentAnomalyDetectionScope(string parent, AgentAnomalyDetectionScope agentAnomalyDetectionScope, string agentAnomalyDetectionScopeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAgentAnomalyDetectionScope(new CreateAgentAnomalyDetectionScopeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AgentAnomalyDetectionScope = gax::GaxPreconditions.CheckNotNull(agentAnomalyDetectionScope, nameof(agentAnomalyDetectionScope)),
                AgentAnomalyDetectionScopeId = gax::GaxPreconditions.CheckNotNullOrEmpty(agentAnomalyDetectionScopeId, nameof(agentAnomalyDetectionScopeId)),
            }, callSettings);

        /// <summary>
        /// Creates a new AgentAnomalyDetectionScope.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the
        /// AgentAnomalyDetectionScope in. Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="agentAnomalyDetectionScope">
        /// Required. The AgentAnomalyDetectionScope to create.
        /// </param>
        /// <param name="agentAnomalyDetectionScopeId">
        /// Required. The ID to use for the AgentAnomalyDetectionScope, which will
        /// become the final component of the AgentAnomalyDetectionScope's resource
        /// name.
        /// 
        /// This value should be 1-63 characters, and valid characters
        /// are /[a-z]([a-z0-9-]{0,61}[a-z0-9])?/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AgentAnomalyDetectionScope, CreateAgentAnomalyDetectionScopeOperationMetadata>> CreateAgentAnomalyDetectionScopeAsync(string parent, AgentAnomalyDetectionScope agentAnomalyDetectionScope, string agentAnomalyDetectionScopeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAgentAnomalyDetectionScopeAsync(new CreateAgentAnomalyDetectionScopeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AgentAnomalyDetectionScope = gax::GaxPreconditions.CheckNotNull(agentAnomalyDetectionScope, nameof(agentAnomalyDetectionScope)),
                AgentAnomalyDetectionScopeId = gax::GaxPreconditions.CheckNotNullOrEmpty(agentAnomalyDetectionScopeId, nameof(agentAnomalyDetectionScopeId)),
            }, callSettings);

        /// <summary>
        /// Creates a new AgentAnomalyDetectionScope.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the
        /// AgentAnomalyDetectionScope in. Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="agentAnomalyDetectionScope">
        /// Required. The AgentAnomalyDetectionScope to create.
        /// </param>
        /// <param name="agentAnomalyDetectionScopeId">
        /// Required. The ID to use for the AgentAnomalyDetectionScope, which will
        /// become the final component of the AgentAnomalyDetectionScope's resource
        /// name.
        /// 
        /// This value should be 1-63 characters, and valid characters
        /// are /[a-z]([a-z0-9-]{0,61}[a-z0-9])?/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AgentAnomalyDetectionScope, CreateAgentAnomalyDetectionScopeOperationMetadata>> CreateAgentAnomalyDetectionScopeAsync(string parent, AgentAnomalyDetectionScope agentAnomalyDetectionScope, string agentAnomalyDetectionScopeId, st::CancellationToken cancellationToken) =>
            CreateAgentAnomalyDetectionScopeAsync(parent, agentAnomalyDetectionScope, agentAnomalyDetectionScopeId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new AgentAnomalyDetectionScope.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the
        /// AgentAnomalyDetectionScope in. Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="agentAnomalyDetectionScope">
        /// Required. The AgentAnomalyDetectionScope to create.
        /// </param>
        /// <param name="agentAnomalyDetectionScopeId">
        /// Required. The ID to use for the AgentAnomalyDetectionScope, which will
        /// become the final component of the AgentAnomalyDetectionScope's resource
        /// name.
        /// 
        /// This value should be 1-63 characters, and valid characters
        /// are /[a-z]([a-z0-9-]{0,61}[a-z0-9])?/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AgentAnomalyDetectionScope, CreateAgentAnomalyDetectionScopeOperationMetadata> CreateAgentAnomalyDetectionScope(gagr::LocationName parent, AgentAnomalyDetectionScope agentAnomalyDetectionScope, string agentAnomalyDetectionScopeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAgentAnomalyDetectionScope(new CreateAgentAnomalyDetectionScopeRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AgentAnomalyDetectionScope = gax::GaxPreconditions.CheckNotNull(agentAnomalyDetectionScope, nameof(agentAnomalyDetectionScope)),
                AgentAnomalyDetectionScopeId = gax::GaxPreconditions.CheckNotNullOrEmpty(agentAnomalyDetectionScopeId, nameof(agentAnomalyDetectionScopeId)),
            }, callSettings);

        /// <summary>
        /// Creates a new AgentAnomalyDetectionScope.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the
        /// AgentAnomalyDetectionScope in. Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="agentAnomalyDetectionScope">
        /// Required. The AgentAnomalyDetectionScope to create.
        /// </param>
        /// <param name="agentAnomalyDetectionScopeId">
        /// Required. The ID to use for the AgentAnomalyDetectionScope, which will
        /// become the final component of the AgentAnomalyDetectionScope's resource
        /// name.
        /// 
        /// This value should be 1-63 characters, and valid characters
        /// are /[a-z]([a-z0-9-]{0,61}[a-z0-9])?/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AgentAnomalyDetectionScope, CreateAgentAnomalyDetectionScopeOperationMetadata>> CreateAgentAnomalyDetectionScopeAsync(gagr::LocationName parent, AgentAnomalyDetectionScope agentAnomalyDetectionScope, string agentAnomalyDetectionScopeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAgentAnomalyDetectionScopeAsync(new CreateAgentAnomalyDetectionScopeRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AgentAnomalyDetectionScope = gax::GaxPreconditions.CheckNotNull(agentAnomalyDetectionScope, nameof(agentAnomalyDetectionScope)),
                AgentAnomalyDetectionScopeId = gax::GaxPreconditions.CheckNotNullOrEmpty(agentAnomalyDetectionScopeId, nameof(agentAnomalyDetectionScopeId)),
            }, callSettings);

        /// <summary>
        /// Creates a new AgentAnomalyDetectionScope.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to create the
        /// AgentAnomalyDetectionScope in. Format:
        /// `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="agentAnomalyDetectionScope">
        /// Required. The AgentAnomalyDetectionScope to create.
        /// </param>
        /// <param name="agentAnomalyDetectionScopeId">
        /// Required. The ID to use for the AgentAnomalyDetectionScope, which will
        /// become the final component of the AgentAnomalyDetectionScope's resource
        /// name.
        /// 
        /// This value should be 1-63 characters, and valid characters
        /// are /[a-z]([a-z0-9-]{0,61}[a-z0-9])?/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AgentAnomalyDetectionScope, CreateAgentAnomalyDetectionScopeOperationMetadata>> CreateAgentAnomalyDetectionScopeAsync(gagr::LocationName parent, AgentAnomalyDetectionScope agentAnomalyDetectionScope, string agentAnomalyDetectionScopeId, st::CancellationToken cancellationToken) =>
            CreateAgentAnomalyDetectionScopeAsync(parent, agentAnomalyDetectionScope, agentAnomalyDetectionScopeId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists AgentAnomalyDetectionScopes in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AgentAnomalyDetectionScope"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAgentAnomalyDetectionScopesResponse, AgentAnomalyDetectionScope> ListAgentAnomalyDetectionScopes(ListAgentAnomalyDetectionScopesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists AgentAnomalyDetectionScopes in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AgentAnomalyDetectionScope"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAgentAnomalyDetectionScopesResponse, AgentAnomalyDetectionScope> ListAgentAnomalyDetectionScopesAsync(ListAgentAnomalyDetectionScopesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists AgentAnomalyDetectionScopes in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the
        /// AgentAnomalyDetectionScopes from. Format:
        /// `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="AgentAnomalyDetectionScope"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAgentAnomalyDetectionScopesResponse, AgentAnomalyDetectionScope> ListAgentAnomalyDetectionScopes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAgentAnomalyDetectionScopesRequest request = new ListAgentAnomalyDetectionScopesRequest
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
            return ListAgentAnomalyDetectionScopes(request, callSettings);
        }

        /// <summary>
        /// Lists AgentAnomalyDetectionScopes in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the
        /// AgentAnomalyDetectionScopes from. Format:
        /// `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="AgentAnomalyDetectionScope"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAgentAnomalyDetectionScopesResponse, AgentAnomalyDetectionScope> ListAgentAnomalyDetectionScopesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAgentAnomalyDetectionScopesRequest request = new ListAgentAnomalyDetectionScopesRequest
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
            return ListAgentAnomalyDetectionScopesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists AgentAnomalyDetectionScopes in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the
        /// AgentAnomalyDetectionScopes from. Format:
        /// `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="AgentAnomalyDetectionScope"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAgentAnomalyDetectionScopesResponse, AgentAnomalyDetectionScope> ListAgentAnomalyDetectionScopes(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAgentAnomalyDetectionScopesRequest request = new ListAgentAnomalyDetectionScopesRequest
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
            return ListAgentAnomalyDetectionScopes(request, callSettings);
        }

        /// <summary>
        /// Lists AgentAnomalyDetectionScopes in a Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the Location to list the
        /// AgentAnomalyDetectionScopes from. Format:
        /// `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="AgentAnomalyDetectionScope"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAgentAnomalyDetectionScopesResponse, AgentAnomalyDetectionScope> ListAgentAnomalyDetectionScopesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAgentAnomalyDetectionScopesRequest request = new ListAgentAnomalyDetectionScopesRequest
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
            return ListAgentAnomalyDetectionScopesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists AnalyzedSessions in a MonitoredAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AnalyzedSession"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAnalyzedSessionsResponse, AnalyzedSession> ListAnalyzedSessions(ListAnalyzedSessionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists AnalyzedSessions in a MonitoredAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AnalyzedSession"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAnalyzedSessionsResponse, AnalyzedSession> ListAnalyzedSessionsAsync(ListAnalyzedSessionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists AnalyzedSessions in a MonitoredAgent.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent MonitoredAgent resource.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}`
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
        /// <returns>A pageable sequence of <see cref="AnalyzedSession"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAnalyzedSessionsResponse, AnalyzedSession> ListAnalyzedSessions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAnalyzedSessionsRequest request = new ListAnalyzedSessionsRequest
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
            return ListAnalyzedSessions(request, callSettings);
        }

        /// <summary>
        /// Lists AnalyzedSessions in a MonitoredAgent.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent MonitoredAgent resource.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="AnalyzedSession"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAnalyzedSessionsResponse, AnalyzedSession> ListAnalyzedSessionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAnalyzedSessionsRequest request = new ListAnalyzedSessionsRequest
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
            return ListAnalyzedSessionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists AnalyzedSessions in a MonitoredAgent.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent MonitoredAgent resource.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}`
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
        /// <returns>A pageable sequence of <see cref="AnalyzedSession"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAnalyzedSessionsResponse, AnalyzedSession> ListAnalyzedSessions(MonitoredAgentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAnalyzedSessionsRequest request = new ListAnalyzedSessionsRequest
            {
                ParentAsMonitoredAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAnalyzedSessions(request, callSettings);
        }

        /// <summary>
        /// Lists AnalyzedSessions in a MonitoredAgent.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent MonitoredAgent resource.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="AnalyzedSession"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAnalyzedSessionsResponse, AnalyzedSession> ListAnalyzedSessionsAsync(MonitoredAgentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAnalyzedSessionsRequest request = new ListAnalyzedSessionsRequest
            {
                ParentAsMonitoredAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAnalyzedSessionsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a specific AnalyzedSession.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyzedSession GetAnalyzedSession(GetAnalyzedSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a specific AnalyzedSession.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzedSession> GetAnalyzedSessionAsync(GetAnalyzedSessionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a specific AnalyzedSession.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzedSession> GetAnalyzedSessionAsync(GetAnalyzedSessionRequest request, st::CancellationToken cancellationToken) =>
            GetAnalyzedSessionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a specific AnalyzedSession.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AnalyzedSession resource.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}/analyzedSessions/{analyzed_session}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyzedSession GetAnalyzedSession(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnalyzedSession(new GetAnalyzedSessionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific AnalyzedSession.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AnalyzedSession resource.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}/analyzedSessions/{analyzed_session}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzedSession> GetAnalyzedSessionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnalyzedSessionAsync(new GetAnalyzedSessionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific AnalyzedSession.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AnalyzedSession resource.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}/analyzedSessions/{analyzed_session}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzedSession> GetAnalyzedSessionAsync(string name, st::CancellationToken cancellationToken) =>
            GetAnalyzedSessionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a specific AnalyzedSession.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AnalyzedSession resource.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}/analyzedSessions/{analyzed_session}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyzedSession GetAnalyzedSession(AnalyzedSessionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnalyzedSession(new GetAnalyzedSessionRequest
            {
                AnalyzedSessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific AnalyzedSession.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AnalyzedSession resource.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}/analyzedSessions/{analyzed_session}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzedSession> GetAnalyzedSessionAsync(AnalyzedSessionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnalyzedSessionAsync(new GetAnalyzedSessionRequest
            {
                AnalyzedSessionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific AnalyzedSession.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AnalyzedSession resource.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}/analyzedSessions/{analyzed_session}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzedSession> GetAnalyzedSessionAsync(AnalyzedSessionName name, st::CancellationToken cancellationToken) =>
            GetAnalyzedSessionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists AnalyzedInvocations in a MonitoredAgent's AnalyzedSession.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AnalyzedInvocation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAnalyzedInvocationsResponse, AnalyzedInvocation> ListAnalyzedInvocations(ListAnalyzedInvocationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists AnalyzedInvocations in a MonitoredAgent's AnalyzedSession.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AnalyzedInvocation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAnalyzedInvocationsResponse, AnalyzedInvocation> ListAnalyzedInvocationsAsync(ListAnalyzedInvocationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists AnalyzedInvocations in a MonitoredAgent's AnalyzedSession.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent AnalyzedSession resource.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}/analyzedSessions/{analyzed_session}`
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
        /// <returns>A pageable sequence of <see cref="AnalyzedInvocation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAnalyzedInvocationsResponse, AnalyzedInvocation> ListAnalyzedInvocations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAnalyzedInvocationsRequest request = new ListAnalyzedInvocationsRequest
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
            return ListAnalyzedInvocations(request, callSettings);
        }

        /// <summary>
        /// Lists AnalyzedInvocations in a MonitoredAgent's AnalyzedSession.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent AnalyzedSession resource.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}/analyzedSessions/{analyzed_session}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="AnalyzedInvocation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAnalyzedInvocationsResponse, AnalyzedInvocation> ListAnalyzedInvocationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAnalyzedInvocationsRequest request = new ListAnalyzedInvocationsRequest
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
            return ListAnalyzedInvocationsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists AnalyzedInvocations in a MonitoredAgent's AnalyzedSession.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent AnalyzedSession resource.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}/analyzedSessions/{analyzed_session}`
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
        /// <returns>A pageable sequence of <see cref="AnalyzedInvocation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAnalyzedInvocationsResponse, AnalyzedInvocation> ListAnalyzedInvocations(AnalyzedSessionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAnalyzedInvocationsRequest request = new ListAnalyzedInvocationsRequest
            {
                ParentAsAnalyzedSessionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAnalyzedInvocations(request, callSettings);
        }

        /// <summary>
        /// Lists AnalyzedInvocations in a MonitoredAgent's AnalyzedSession.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent AnalyzedSession resource.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}/analyzedSessions/{analyzed_session}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="AnalyzedInvocation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAnalyzedInvocationsResponse, AnalyzedInvocation> ListAnalyzedInvocationsAsync(AnalyzedSessionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAnalyzedInvocationsRequest request = new ListAnalyzedInvocationsRequest
            {
                ParentAsAnalyzedSessionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAnalyzedInvocationsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a specific AnalyzedInvocation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyzedInvocation GetAnalyzedInvocation(GetAnalyzedInvocationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a specific AnalyzedInvocation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzedInvocation> GetAnalyzedInvocationAsync(GetAnalyzedInvocationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the details of a specific AnalyzedInvocation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzedInvocation> GetAnalyzedInvocationAsync(GetAnalyzedInvocationRequest request, st::CancellationToken cancellationToken) =>
            GetAnalyzedInvocationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a specific AnalyzedInvocation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AnalyzedInvocation resource.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}/analyzedSessions/{analyzed_session}/analyzedInvocations/{analyzed_invocation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyzedInvocation GetAnalyzedInvocation(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnalyzedInvocation(new GetAnalyzedInvocationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific AnalyzedInvocation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AnalyzedInvocation resource.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}/analyzedSessions/{analyzed_session}/analyzedInvocations/{analyzed_invocation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzedInvocation> GetAnalyzedInvocationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnalyzedInvocationAsync(new GetAnalyzedInvocationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific AnalyzedInvocation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AnalyzedInvocation resource.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}/analyzedSessions/{analyzed_session}/analyzedInvocations/{analyzed_invocation}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzedInvocation> GetAnalyzedInvocationAsync(string name, st::CancellationToken cancellationToken) =>
            GetAnalyzedInvocationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the details of a specific AnalyzedInvocation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AnalyzedInvocation resource.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}/analyzedSessions/{analyzed_session}/analyzedInvocations/{analyzed_invocation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnalyzedInvocation GetAnalyzedInvocation(AnalyzedInvocationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnalyzedInvocation(new GetAnalyzedInvocationRequest
            {
                AnalyzedInvocationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific AnalyzedInvocation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AnalyzedInvocation resource.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}/analyzedSessions/{analyzed_session}/analyzedInvocations/{analyzed_invocation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzedInvocation> GetAnalyzedInvocationAsync(AnalyzedInvocationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnalyzedInvocationAsync(new GetAnalyzedInvocationRequest
            {
                AnalyzedInvocationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the details of a specific AnalyzedInvocation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the AnalyzedInvocation resource.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}/analyzedSessions/{analyzed_session}/analyzedInvocations/{analyzed_invocation}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnalyzedInvocation> GetAnalyzedInvocationAsync(AnalyzedInvocationName name, st::CancellationToken cancellationToken) =>
            GetAnalyzedInvocationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Aggregates AnalyzedSessions across MonitoredAgents.
        /// 
        /// To aggregate across all MonitoredAgents in a
        /// location, use the following format for the parent field:
        /// `projects/{project}/locations/{location}/monitoredAgents/-`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable sequence of <see cref="AggregateAnalyzedSessionsResponse.Types.AgentAggregate"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<AggregateAnalyzedSessionsResponse, AggregateAnalyzedSessionsResponse.Types.AgentAggregate> AggregateAnalyzedSessions(AggregateAnalyzedSessionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Aggregates AnalyzedSessions across MonitoredAgents.
        /// 
        /// To aggregate across all MonitoredAgents in a
        /// location, use the following format for the parent field:
        /// `projects/{project}/locations/{location}/monitoredAgents/-`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="AggregateAnalyzedSessionsResponse.Types.AgentAggregate"/>
        /// resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<AggregateAnalyzedSessionsResponse, AggregateAnalyzedSessionsResponse.Types.AgentAggregate> AggregateAnalyzedSessionsAsync(AggregateAnalyzedSessionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Aggregates AnalyzedSessions across MonitoredAgents.
        /// 
        /// To aggregate across all MonitoredAgents in a
        /// location, use the following format for the parent field:
        /// `projects/{project}/locations/{location}/monitoredAgents/-`
        /// </summary>
        /// <param name="parent">
        /// Required. The parent MonitoredAgent resource. Use the `-` wildcard
        /// for the monitored_agent segment to aggregate across multiple agents in the
        /// location.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}`
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
        /// A pageable sequence of <see cref="AggregateAnalyzedSessionsResponse.Types.AgentAggregate"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<AggregateAnalyzedSessionsResponse, AggregateAnalyzedSessionsResponse.Types.AgentAggregate> AggregateAnalyzedSessions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            AggregateAnalyzedSessionsRequest request = new AggregateAnalyzedSessionsRequest
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
            return AggregateAnalyzedSessions(request, callSettings);
        }

        /// <summary>
        /// Aggregates AnalyzedSessions across MonitoredAgents.
        /// 
        /// To aggregate across all MonitoredAgents in a
        /// location, use the following format for the parent field:
        /// `projects/{project}/locations/{location}/monitoredAgents/-`
        /// </summary>
        /// <param name="parent">
        /// Required. The parent MonitoredAgent resource. Use the `-` wildcard
        /// for the monitored_agent segment to aggregate across multiple agents in the
        /// location.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}`
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
        /// A pageable asynchronous sequence of <see cref="AggregateAnalyzedSessionsResponse.Types.AgentAggregate"/>
        /// resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<AggregateAnalyzedSessionsResponse, AggregateAnalyzedSessionsResponse.Types.AgentAggregate> AggregateAnalyzedSessionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            AggregateAnalyzedSessionsRequest request = new AggregateAnalyzedSessionsRequest
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
            return AggregateAnalyzedSessionsAsync(request, callSettings);
        }

        /// <summary>
        /// Aggregates AnalyzedSessions across MonitoredAgents.
        /// 
        /// To aggregate across all MonitoredAgents in a
        /// location, use the following format for the parent field:
        /// `projects/{project}/locations/{location}/monitoredAgents/-`
        /// </summary>
        /// <param name="parent">
        /// Required. The parent MonitoredAgent resource. Use the `-` wildcard
        /// for the monitored_agent segment to aggregate across multiple agents in the
        /// location.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}`
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
        /// A pageable sequence of <see cref="AggregateAnalyzedSessionsResponse.Types.AgentAggregate"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<AggregateAnalyzedSessionsResponse, AggregateAnalyzedSessionsResponse.Types.AgentAggregate> AggregateAnalyzedSessions(MonitoredAgentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            AggregateAnalyzedSessionsRequest request = new AggregateAnalyzedSessionsRequest
            {
                ParentAsMonitoredAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return AggregateAnalyzedSessions(request, callSettings);
        }

        /// <summary>
        /// Aggregates AnalyzedSessions across MonitoredAgents.
        /// 
        /// To aggregate across all MonitoredAgents in a
        /// location, use the following format for the parent field:
        /// `projects/{project}/locations/{location}/monitoredAgents/-`
        /// </summary>
        /// <param name="parent">
        /// Required. The parent MonitoredAgent resource. Use the `-` wildcard
        /// for the monitored_agent segment to aggregate across multiple agents in the
        /// location.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}`
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
        /// A pageable asynchronous sequence of <see cref="AggregateAnalyzedSessionsResponse.Types.AgentAggregate"/>
        /// resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<AggregateAnalyzedSessionsResponse, AggregateAnalyzedSessionsResponse.Types.AgentAggregate> AggregateAnalyzedSessionsAsync(MonitoredAgentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            AggregateAnalyzedSessionsRequest request = new AggregateAnalyzedSessionsRequest
            {
                ParentAsMonitoredAgentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return AggregateAnalyzedSessionsAsync(request, callSettings);
        }

        /// <summary>
        /// Clears (purges) the trained model artifacts derived from a MonitoredAgent's
        /// data. The purged model is rebuilt by the next scheduled training run.
        /// 
        /// To clear every MonitoredAgent in a location's scope, use the `-` wildcard
        /// agent segment for the name field:
        /// `projects/{project}/locations/{location}/monitoredAgents/-`
        /// 
        /// This is the on-demand data-deletion path for customers who have deleted the
        /// underlying logs / observability data a model was trained on. It deletes
        /// only the derived model artifacts (it does NOT delete the scope or stop
        /// monitoring). To stop monitoring an agent entirely, disable it via
        /// DisableMonitoredAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ClearTrainingDataResponse, ClearTrainingDataOperationMetadata> ClearTrainingData(ClearTrainingDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Clears (purges) the trained model artifacts derived from a MonitoredAgent's
        /// data. The purged model is rebuilt by the next scheduled training run.
        /// 
        /// To clear every MonitoredAgent in a location's scope, use the `-` wildcard
        /// agent segment for the name field:
        /// `projects/{project}/locations/{location}/monitoredAgents/-`
        /// 
        /// This is the on-demand data-deletion path for customers who have deleted the
        /// underlying logs / observability data a model was trained on. It deletes
        /// only the derived model artifacts (it does NOT delete the scope or stop
        /// monitoring). To stop monitoring an agent entirely, disable it via
        /// DisableMonitoredAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ClearTrainingDataResponse, ClearTrainingDataOperationMetadata>> ClearTrainingDataAsync(ClearTrainingDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Clears (purges) the trained model artifacts derived from a MonitoredAgent's
        /// data. The purged model is rebuilt by the next scheduled training run.
        /// 
        /// To clear every MonitoredAgent in a location's scope, use the `-` wildcard
        /// agent segment for the name field:
        /// `projects/{project}/locations/{location}/monitoredAgents/-`
        /// 
        /// This is the on-demand data-deletion path for customers who have deleted the
        /// underlying logs / observability data a model was trained on. It deletes
        /// only the derived model artifacts (it does NOT delete the scope or stop
        /// monitoring). To stop monitoring an agent entirely, disable it via
        /// DisableMonitoredAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ClearTrainingDataResponse, ClearTrainingDataOperationMetadata>> ClearTrainingDataAsync(ClearTrainingDataRequest request, st::CancellationToken cancellationToken) =>
            ClearTrainingDataAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ClearTrainingData</c>.</summary>
        public virtual lro::OperationsClient ClearTrainingDataOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ClearTrainingData</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ClearTrainingDataResponse, ClearTrainingDataOperationMetadata> PollOnceClearTrainingData(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ClearTrainingDataResponse, ClearTrainingDataOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ClearTrainingDataOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ClearTrainingData</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ClearTrainingDataResponse, ClearTrainingDataOperationMetadata>> PollOnceClearTrainingDataAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ClearTrainingDataResponse, ClearTrainingDataOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ClearTrainingDataOperationsClient, callSettings);

        /// <summary>
        /// Clears (purges) the trained model artifacts derived from a MonitoredAgent's
        /// data. The purged model is rebuilt by the next scheduled training run.
        /// 
        /// To clear every MonitoredAgent in a location's scope, use the `-` wildcard
        /// agent segment for the name field:
        /// `projects/{project}/locations/{location}/monitoredAgents/-`
        /// 
        /// This is the on-demand data-deletion path for customers who have deleted the
        /// underlying logs / observability data a model was trained on. It deletes
        /// only the derived model artifacts (it does NOT delete the scope or stop
        /// monitoring). To stop monitoring an agent entirely, disable it via
        /// DisableMonitoredAgent.
        /// </summary>
        /// <param name="name">
        /// Required. The MonitoredAgent whose trained model artifacts to purge. Use
        /// the
        /// `-` wildcard agent segment to purge every MonitoredAgent in the scope.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ClearTrainingDataResponse, ClearTrainingDataOperationMetadata> ClearTrainingData(string name, gaxgrpc::CallSettings callSettings = null) =>
            ClearTrainingData(new ClearTrainingDataRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Clears (purges) the trained model artifacts derived from a MonitoredAgent's
        /// data. The purged model is rebuilt by the next scheduled training run.
        /// 
        /// To clear every MonitoredAgent in a location's scope, use the `-` wildcard
        /// agent segment for the name field:
        /// `projects/{project}/locations/{location}/monitoredAgents/-`
        /// 
        /// This is the on-demand data-deletion path for customers who have deleted the
        /// underlying logs / observability data a model was trained on. It deletes
        /// only the derived model artifacts (it does NOT delete the scope or stop
        /// monitoring). To stop monitoring an agent entirely, disable it via
        /// DisableMonitoredAgent.
        /// </summary>
        /// <param name="name">
        /// Required. The MonitoredAgent whose trained model artifacts to purge. Use
        /// the
        /// `-` wildcard agent segment to purge every MonitoredAgent in the scope.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ClearTrainingDataResponse, ClearTrainingDataOperationMetadata>> ClearTrainingDataAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ClearTrainingDataAsync(new ClearTrainingDataRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Clears (purges) the trained model artifacts derived from a MonitoredAgent's
        /// data. The purged model is rebuilt by the next scheduled training run.
        /// 
        /// To clear every MonitoredAgent in a location's scope, use the `-` wildcard
        /// agent segment for the name field:
        /// `projects/{project}/locations/{location}/monitoredAgents/-`
        /// 
        /// This is the on-demand data-deletion path for customers who have deleted the
        /// underlying logs / observability data a model was trained on. It deletes
        /// only the derived model artifacts (it does NOT delete the scope or stop
        /// monitoring). To stop monitoring an agent entirely, disable it via
        /// DisableMonitoredAgent.
        /// </summary>
        /// <param name="name">
        /// Required. The MonitoredAgent whose trained model artifacts to purge. Use
        /// the
        /// `-` wildcard agent segment to purge every MonitoredAgent in the scope.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ClearTrainingDataResponse, ClearTrainingDataOperationMetadata>> ClearTrainingDataAsync(string name, st::CancellationToken cancellationToken) =>
            ClearTrainingDataAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Clears (purges) the trained model artifacts derived from a MonitoredAgent's
        /// data. The purged model is rebuilt by the next scheduled training run.
        /// 
        /// To clear every MonitoredAgent in a location's scope, use the `-` wildcard
        /// agent segment for the name field:
        /// `projects/{project}/locations/{location}/monitoredAgents/-`
        /// 
        /// This is the on-demand data-deletion path for customers who have deleted the
        /// underlying logs / observability data a model was trained on. It deletes
        /// only the derived model artifacts (it does NOT delete the scope or stop
        /// monitoring). To stop monitoring an agent entirely, disable it via
        /// DisableMonitoredAgent.
        /// </summary>
        /// <param name="name">
        /// Required. The MonitoredAgent whose trained model artifacts to purge. Use
        /// the
        /// `-` wildcard agent segment to purge every MonitoredAgent in the scope.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ClearTrainingDataResponse, ClearTrainingDataOperationMetadata> ClearTrainingData(MonitoredAgentName name, gaxgrpc::CallSettings callSettings = null) =>
            ClearTrainingData(new ClearTrainingDataRequest
            {
                MonitoredAgentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Clears (purges) the trained model artifacts derived from a MonitoredAgent's
        /// data. The purged model is rebuilt by the next scheduled training run.
        /// 
        /// To clear every MonitoredAgent in a location's scope, use the `-` wildcard
        /// agent segment for the name field:
        /// `projects/{project}/locations/{location}/monitoredAgents/-`
        /// 
        /// This is the on-demand data-deletion path for customers who have deleted the
        /// underlying logs / observability data a model was trained on. It deletes
        /// only the derived model artifacts (it does NOT delete the scope or stop
        /// monitoring). To stop monitoring an agent entirely, disable it via
        /// DisableMonitoredAgent.
        /// </summary>
        /// <param name="name">
        /// Required. The MonitoredAgent whose trained model artifacts to purge. Use
        /// the
        /// `-` wildcard agent segment to purge every MonitoredAgent in the scope.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ClearTrainingDataResponse, ClearTrainingDataOperationMetadata>> ClearTrainingDataAsync(MonitoredAgentName name, gaxgrpc::CallSettings callSettings = null) =>
            ClearTrainingDataAsync(new ClearTrainingDataRequest
            {
                MonitoredAgentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Clears (purges) the trained model artifacts derived from a MonitoredAgent's
        /// data. The purged model is rebuilt by the next scheduled training run.
        /// 
        /// To clear every MonitoredAgent in a location's scope, use the `-` wildcard
        /// agent segment for the name field:
        /// `projects/{project}/locations/{location}/monitoredAgents/-`
        /// 
        /// This is the on-demand data-deletion path for customers who have deleted the
        /// underlying logs / observability data a model was trained on. It deletes
        /// only the derived model artifacts (it does NOT delete the scope or stop
        /// monitoring). To stop monitoring an agent entirely, disable it via
        /// DisableMonitoredAgent.
        /// </summary>
        /// <param name="name">
        /// Required. The MonitoredAgent whose trained model artifacts to purge. Use
        /// the
        /// `-` wildcard agent segment to purge every MonitoredAgent in the scope.
        /// Format:
        /// `projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ClearTrainingDataResponse, ClearTrainingDataOperationMetadata>> ClearTrainingDataAsync(MonitoredAgentName name, st::CancellationToken cancellationToken) =>
            ClearTrainingDataAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AgentAnomalyDetectionService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service for managing Agent Anomaly Detection for monitored agents.
    /// </remarks>
    public sealed partial class AgentAnomalyDetectionServiceClientImpl : AgentAnomalyDetectionServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetAgentAnomalyDetectionScopeRequest, AgentAnomalyDetectionScope> _callGetAgentAnomalyDetectionScope;

        private readonly gaxgrpc::ApiCall<GetMonitoredAgentRequest, MonitoredAgent> _callGetMonitoredAgent;

        private readonly gaxgrpc::ApiCall<ListMonitoredAgentsRequest, ListMonitoredAgentsResponse> _callListMonitoredAgents;

        private readonly gaxgrpc::ApiCall<EnableMonitoredAgentRequest, lro::Operation> _callEnableMonitoredAgent;

        private readonly gaxgrpc::ApiCall<DisableMonitoredAgentRequest, lro::Operation> _callDisableMonitoredAgent;

        private readonly gaxgrpc::ApiCall<DeleteAgentAnomalyDetectionScopeRequest, lro::Operation> _callDeleteAgentAnomalyDetectionScope;

        private readonly gaxgrpc::ApiCall<CreateAgentAnomalyDetectionScopeRequest, lro::Operation> _callCreateAgentAnomalyDetectionScope;

        private readonly gaxgrpc::ApiCall<ListAgentAnomalyDetectionScopesRequest, ListAgentAnomalyDetectionScopesResponse> _callListAgentAnomalyDetectionScopes;

        private readonly gaxgrpc::ApiCall<ListAnalyzedSessionsRequest, ListAnalyzedSessionsResponse> _callListAnalyzedSessions;

        private readonly gaxgrpc::ApiCall<GetAnalyzedSessionRequest, AnalyzedSession> _callGetAnalyzedSession;

        private readonly gaxgrpc::ApiCall<ListAnalyzedInvocationsRequest, ListAnalyzedInvocationsResponse> _callListAnalyzedInvocations;

        private readonly gaxgrpc::ApiCall<GetAnalyzedInvocationRequest, AnalyzedInvocation> _callGetAnalyzedInvocation;

        private readonly gaxgrpc::ApiCall<AggregateAnalyzedSessionsRequest, AggregateAnalyzedSessionsResponse> _callAggregateAnalyzedSessions;

        private readonly gaxgrpc::ApiCall<ClearTrainingDataRequest, lro::Operation> _callClearTrainingData;

        /// <summary>
        /// Constructs a client wrapper for the AgentAnomalyDetectionService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="AgentAnomalyDetectionServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AgentAnomalyDetectionServiceClientImpl(AgentAnomalyDetectionService.AgentAnomalyDetectionServiceClient grpcClient, AgentAnomalyDetectionServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AgentAnomalyDetectionServiceSettings effectiveSettings = settings ?? AgentAnomalyDetectionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            EnableMonitoredAgentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.EnableMonitoredAgentOperationsSettings, logger);
            DisableMonitoredAgentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DisableMonitoredAgentOperationsSettings, logger);
            DeleteAgentAnomalyDetectionScopeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteAgentAnomalyDetectionScopeOperationsSettings, logger);
            CreateAgentAnomalyDetectionScopeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateAgentAnomalyDetectionScopeOperationsSettings, logger);
            ClearTrainingDataOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ClearTrainingDataOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callGetAgentAnomalyDetectionScope = clientHelper.BuildApiCall<GetAgentAnomalyDetectionScopeRequest, AgentAnomalyDetectionScope>("GetAgentAnomalyDetectionScope", grpcClient.GetAgentAnomalyDetectionScopeAsync, grpcClient.GetAgentAnomalyDetectionScope, effectiveSettings.GetAgentAnomalyDetectionScopeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAgentAnomalyDetectionScope);
            Modify_GetAgentAnomalyDetectionScopeApiCall(ref _callGetAgentAnomalyDetectionScope);
            _callGetMonitoredAgent = clientHelper.BuildApiCall<GetMonitoredAgentRequest, MonitoredAgent>("GetMonitoredAgent", grpcClient.GetMonitoredAgentAsync, grpcClient.GetMonitoredAgent, effectiveSettings.GetMonitoredAgentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetMonitoredAgent);
            Modify_GetMonitoredAgentApiCall(ref _callGetMonitoredAgent);
            _callListMonitoredAgents = clientHelper.BuildApiCall<ListMonitoredAgentsRequest, ListMonitoredAgentsResponse>("ListMonitoredAgents", grpcClient.ListMonitoredAgentsAsync, grpcClient.ListMonitoredAgents, effectiveSettings.ListMonitoredAgentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListMonitoredAgents);
            Modify_ListMonitoredAgentsApiCall(ref _callListMonitoredAgents);
            _callEnableMonitoredAgent = clientHelper.BuildApiCall<EnableMonitoredAgentRequest, lro::Operation>("EnableMonitoredAgent", grpcClient.EnableMonitoredAgentAsync, grpcClient.EnableMonitoredAgent, effectiveSettings.EnableMonitoredAgentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callEnableMonitoredAgent);
            Modify_EnableMonitoredAgentApiCall(ref _callEnableMonitoredAgent);
            _callDisableMonitoredAgent = clientHelper.BuildApiCall<DisableMonitoredAgentRequest, lro::Operation>("DisableMonitoredAgent", grpcClient.DisableMonitoredAgentAsync, grpcClient.DisableMonitoredAgent, effectiveSettings.DisableMonitoredAgentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDisableMonitoredAgent);
            Modify_DisableMonitoredAgentApiCall(ref _callDisableMonitoredAgent);
            _callDeleteAgentAnomalyDetectionScope = clientHelper.BuildApiCall<DeleteAgentAnomalyDetectionScopeRequest, lro::Operation>("DeleteAgentAnomalyDetectionScope", grpcClient.DeleteAgentAnomalyDetectionScopeAsync, grpcClient.DeleteAgentAnomalyDetectionScope, effectiveSettings.DeleteAgentAnomalyDetectionScopeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAgentAnomalyDetectionScope);
            Modify_DeleteAgentAnomalyDetectionScopeApiCall(ref _callDeleteAgentAnomalyDetectionScope);
            _callCreateAgentAnomalyDetectionScope = clientHelper.BuildApiCall<CreateAgentAnomalyDetectionScopeRequest, lro::Operation>("CreateAgentAnomalyDetectionScope", grpcClient.CreateAgentAnomalyDetectionScopeAsync, grpcClient.CreateAgentAnomalyDetectionScope, effectiveSettings.CreateAgentAnomalyDetectionScopeSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAgentAnomalyDetectionScope);
            Modify_CreateAgentAnomalyDetectionScopeApiCall(ref _callCreateAgentAnomalyDetectionScope);
            _callListAgentAnomalyDetectionScopes = clientHelper.BuildApiCall<ListAgentAnomalyDetectionScopesRequest, ListAgentAnomalyDetectionScopesResponse>("ListAgentAnomalyDetectionScopes", grpcClient.ListAgentAnomalyDetectionScopesAsync, grpcClient.ListAgentAnomalyDetectionScopes, effectiveSettings.ListAgentAnomalyDetectionScopesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAgentAnomalyDetectionScopes);
            Modify_ListAgentAnomalyDetectionScopesApiCall(ref _callListAgentAnomalyDetectionScopes);
            _callListAnalyzedSessions = clientHelper.BuildApiCall<ListAnalyzedSessionsRequest, ListAnalyzedSessionsResponse>("ListAnalyzedSessions", grpcClient.ListAnalyzedSessionsAsync, grpcClient.ListAnalyzedSessions, effectiveSettings.ListAnalyzedSessionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAnalyzedSessions);
            Modify_ListAnalyzedSessionsApiCall(ref _callListAnalyzedSessions);
            _callGetAnalyzedSession = clientHelper.BuildApiCall<GetAnalyzedSessionRequest, AnalyzedSession>("GetAnalyzedSession", grpcClient.GetAnalyzedSessionAsync, grpcClient.GetAnalyzedSession, effectiveSettings.GetAnalyzedSessionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAnalyzedSession);
            Modify_GetAnalyzedSessionApiCall(ref _callGetAnalyzedSession);
            _callListAnalyzedInvocations = clientHelper.BuildApiCall<ListAnalyzedInvocationsRequest, ListAnalyzedInvocationsResponse>("ListAnalyzedInvocations", grpcClient.ListAnalyzedInvocationsAsync, grpcClient.ListAnalyzedInvocations, effectiveSettings.ListAnalyzedInvocationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAnalyzedInvocations);
            Modify_ListAnalyzedInvocationsApiCall(ref _callListAnalyzedInvocations);
            _callGetAnalyzedInvocation = clientHelper.BuildApiCall<GetAnalyzedInvocationRequest, AnalyzedInvocation>("GetAnalyzedInvocation", grpcClient.GetAnalyzedInvocationAsync, grpcClient.GetAnalyzedInvocation, effectiveSettings.GetAnalyzedInvocationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAnalyzedInvocation);
            Modify_GetAnalyzedInvocationApiCall(ref _callGetAnalyzedInvocation);
            _callAggregateAnalyzedSessions = clientHelper.BuildApiCall<AggregateAnalyzedSessionsRequest, AggregateAnalyzedSessionsResponse>("AggregateAnalyzedSessions", grpcClient.AggregateAnalyzedSessionsAsync, grpcClient.AggregateAnalyzedSessions, effectiveSettings.AggregateAnalyzedSessionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callAggregateAnalyzedSessions);
            Modify_AggregateAnalyzedSessionsApiCall(ref _callAggregateAnalyzedSessions);
            _callClearTrainingData = clientHelper.BuildApiCall<ClearTrainingDataRequest, lro::Operation>("ClearTrainingData", grpcClient.ClearTrainingDataAsync, grpcClient.ClearTrainingData, effectiveSettings.ClearTrainingDataSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callClearTrainingData);
            Modify_ClearTrainingDataApiCall(ref _callClearTrainingData);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetAgentAnomalyDetectionScopeApiCall(ref gaxgrpc::ApiCall<GetAgentAnomalyDetectionScopeRequest, AgentAnomalyDetectionScope> call);

        partial void Modify_GetMonitoredAgentApiCall(ref gaxgrpc::ApiCall<GetMonitoredAgentRequest, MonitoredAgent> call);

        partial void Modify_ListMonitoredAgentsApiCall(ref gaxgrpc::ApiCall<ListMonitoredAgentsRequest, ListMonitoredAgentsResponse> call);

        partial void Modify_EnableMonitoredAgentApiCall(ref gaxgrpc::ApiCall<EnableMonitoredAgentRequest, lro::Operation> call);

        partial void Modify_DisableMonitoredAgentApiCall(ref gaxgrpc::ApiCall<DisableMonitoredAgentRequest, lro::Operation> call);

        partial void Modify_DeleteAgentAnomalyDetectionScopeApiCall(ref gaxgrpc::ApiCall<DeleteAgentAnomalyDetectionScopeRequest, lro::Operation> call);

        partial void Modify_CreateAgentAnomalyDetectionScopeApiCall(ref gaxgrpc::ApiCall<CreateAgentAnomalyDetectionScopeRequest, lro::Operation> call);

        partial void Modify_ListAgentAnomalyDetectionScopesApiCall(ref gaxgrpc::ApiCall<ListAgentAnomalyDetectionScopesRequest, ListAgentAnomalyDetectionScopesResponse> call);

        partial void Modify_ListAnalyzedSessionsApiCall(ref gaxgrpc::ApiCall<ListAnalyzedSessionsRequest, ListAnalyzedSessionsResponse> call);

        partial void Modify_GetAnalyzedSessionApiCall(ref gaxgrpc::ApiCall<GetAnalyzedSessionRequest, AnalyzedSession> call);

        partial void Modify_ListAnalyzedInvocationsApiCall(ref gaxgrpc::ApiCall<ListAnalyzedInvocationsRequest, ListAnalyzedInvocationsResponse> call);

        partial void Modify_GetAnalyzedInvocationApiCall(ref gaxgrpc::ApiCall<GetAnalyzedInvocationRequest, AnalyzedInvocation> call);

        partial void Modify_AggregateAnalyzedSessionsApiCall(ref gaxgrpc::ApiCall<AggregateAnalyzedSessionsRequest, AggregateAnalyzedSessionsResponse> call);

        partial void Modify_ClearTrainingDataApiCall(ref gaxgrpc::ApiCall<ClearTrainingDataRequest, lro::Operation> call);

        partial void OnConstruction(AgentAnomalyDetectionService.AgentAnomalyDetectionServiceClient grpcClient, AgentAnomalyDetectionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AgentAnomalyDetectionService client</summary>
        public override AgentAnomalyDetectionService.AgentAnomalyDetectionServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_GetAgentAnomalyDetectionScopeRequest(ref GetAgentAnomalyDetectionScopeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMonitoredAgentRequest(ref GetMonitoredAgentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListMonitoredAgentsRequest(ref ListMonitoredAgentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_EnableMonitoredAgentRequest(ref EnableMonitoredAgentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DisableMonitoredAgentRequest(ref DisableMonitoredAgentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAgentAnomalyDetectionScopeRequest(ref DeleteAgentAnomalyDetectionScopeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAgentAnomalyDetectionScopeRequest(ref CreateAgentAnomalyDetectionScopeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAgentAnomalyDetectionScopesRequest(ref ListAgentAnomalyDetectionScopesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAnalyzedSessionsRequest(ref ListAnalyzedSessionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAnalyzedSessionRequest(ref GetAnalyzedSessionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAnalyzedInvocationsRequest(ref ListAnalyzedInvocationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAnalyzedInvocationRequest(ref GetAnalyzedInvocationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AggregateAnalyzedSessionsRequest(ref AggregateAnalyzedSessionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ClearTrainingDataRequest(ref ClearTrainingDataRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets the details of a specific AgentAnomalyDetectionScope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AgentAnomalyDetectionScope GetAgentAnomalyDetectionScope(GetAgentAnomalyDetectionScopeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAgentAnomalyDetectionScopeRequest(ref request, ref callSettings);
            return _callGetAgentAnomalyDetectionScope.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a specific AgentAnomalyDetectionScope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AgentAnomalyDetectionScope> GetAgentAnomalyDetectionScopeAsync(GetAgentAnomalyDetectionScopeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAgentAnomalyDetectionScopeRequest(ref request, ref callSettings);
            return _callGetAgentAnomalyDetectionScope.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a specific MonitoredAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MonitoredAgent GetMonitoredAgent(GetMonitoredAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMonitoredAgentRequest(ref request, ref callSettings);
            return _callGetMonitoredAgent.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a specific MonitoredAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MonitoredAgent> GetMonitoredAgentAsync(GetMonitoredAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMonitoredAgentRequest(ref request, ref callSettings);
            return _callGetMonitoredAgent.Async(request, callSettings);
        }

        /// <summary>
        /// Lists MonitoredAgents in a specific Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MonitoredAgent"/> resources.</returns>
        public override gax::PagedEnumerable<ListMonitoredAgentsResponse, MonitoredAgent> ListMonitoredAgents(ListMonitoredAgentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMonitoredAgentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMonitoredAgentsRequest, ListMonitoredAgentsResponse, MonitoredAgent>(_callListMonitoredAgents, request, callSettings);
        }

        /// <summary>
        /// Lists MonitoredAgents in a specific Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MonitoredAgent"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMonitoredAgentsResponse, MonitoredAgent> ListMonitoredAgentsAsync(ListMonitoredAgentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMonitoredAgentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMonitoredAgentsRequest, ListMonitoredAgentsResponse, MonitoredAgent>(_callListMonitoredAgents, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>EnableMonitoredAgent</c>.</summary>
        public override lro::OperationsClient EnableMonitoredAgentOperationsClient { get; }

        /// <summary>
        /// Enables a specific MonitoredAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MonitoredAgent, EnableMonitoredAgentOperationMetadata> EnableMonitoredAgent(EnableMonitoredAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnableMonitoredAgentRequest(ref request, ref callSettings);
            return new lro::Operation<MonitoredAgent, EnableMonitoredAgentOperationMetadata>(_callEnableMonitoredAgent.Sync(request, callSettings), EnableMonitoredAgentOperationsClient);
        }

        /// <summary>
        /// Enables a specific MonitoredAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MonitoredAgent, EnableMonitoredAgentOperationMetadata>> EnableMonitoredAgentAsync(EnableMonitoredAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnableMonitoredAgentRequest(ref request, ref callSettings);
            return new lro::Operation<MonitoredAgent, EnableMonitoredAgentOperationMetadata>(await _callEnableMonitoredAgent.Async(request, callSettings).ConfigureAwait(false), EnableMonitoredAgentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DisableMonitoredAgent</c>.</summary>
        public override lro::OperationsClient DisableMonitoredAgentOperationsClient { get; }

        /// <summary>
        /// Disables a specific MonitoredAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<MonitoredAgent, DisableMonitoredAgentOperationMetadata> DisableMonitoredAgent(DisableMonitoredAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DisableMonitoredAgentRequest(ref request, ref callSettings);
            return new lro::Operation<MonitoredAgent, DisableMonitoredAgentOperationMetadata>(_callDisableMonitoredAgent.Sync(request, callSettings), DisableMonitoredAgentOperationsClient);
        }

        /// <summary>
        /// Disables a specific MonitoredAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<MonitoredAgent, DisableMonitoredAgentOperationMetadata>> DisableMonitoredAgentAsync(DisableMonitoredAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DisableMonitoredAgentRequest(ref request, ref callSettings);
            return new lro::Operation<MonitoredAgent, DisableMonitoredAgentOperationMetadata>(await _callDisableMonitoredAgent.Async(request, callSettings).ConfigureAwait(false), DisableMonitoredAgentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteAgentAnomalyDetectionScope</c>.</summary>
        public override lro::OperationsClient DeleteAgentAnomalyDetectionScopeOperationsClient { get; }

        /// <summary>
        /// Deletes a specific AgentAnomalyDetectionScope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteAgentAnomalyDetectionScopeOperationMetadata> DeleteAgentAnomalyDetectionScope(DeleteAgentAnomalyDetectionScopeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAgentAnomalyDetectionScopeRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteAgentAnomalyDetectionScopeOperationMetadata>(_callDeleteAgentAnomalyDetectionScope.Sync(request, callSettings), DeleteAgentAnomalyDetectionScopeOperationsClient);
        }

        /// <summary>
        /// Deletes a specific AgentAnomalyDetectionScope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteAgentAnomalyDetectionScopeOperationMetadata>> DeleteAgentAnomalyDetectionScopeAsync(DeleteAgentAnomalyDetectionScopeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAgentAnomalyDetectionScopeRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteAgentAnomalyDetectionScopeOperationMetadata>(await _callDeleteAgentAnomalyDetectionScope.Async(request, callSettings).ConfigureAwait(false), DeleteAgentAnomalyDetectionScopeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateAgentAnomalyDetectionScope</c>.</summary>
        public override lro::OperationsClient CreateAgentAnomalyDetectionScopeOperationsClient { get; }

        /// <summary>
        /// Creates a new AgentAnomalyDetectionScope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AgentAnomalyDetectionScope, CreateAgentAnomalyDetectionScopeOperationMetadata> CreateAgentAnomalyDetectionScope(CreateAgentAnomalyDetectionScopeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAgentAnomalyDetectionScopeRequest(ref request, ref callSettings);
            return new lro::Operation<AgentAnomalyDetectionScope, CreateAgentAnomalyDetectionScopeOperationMetadata>(_callCreateAgentAnomalyDetectionScope.Sync(request, callSettings), CreateAgentAnomalyDetectionScopeOperationsClient);
        }

        /// <summary>
        /// Creates a new AgentAnomalyDetectionScope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AgentAnomalyDetectionScope, CreateAgentAnomalyDetectionScopeOperationMetadata>> CreateAgentAnomalyDetectionScopeAsync(CreateAgentAnomalyDetectionScopeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAgentAnomalyDetectionScopeRequest(ref request, ref callSettings);
            return new lro::Operation<AgentAnomalyDetectionScope, CreateAgentAnomalyDetectionScopeOperationMetadata>(await _callCreateAgentAnomalyDetectionScope.Async(request, callSettings).ConfigureAwait(false), CreateAgentAnomalyDetectionScopeOperationsClient);
        }

        /// <summary>
        /// Lists AgentAnomalyDetectionScopes in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AgentAnomalyDetectionScope"/> resources.</returns>
        public override gax::PagedEnumerable<ListAgentAnomalyDetectionScopesResponse, AgentAnomalyDetectionScope> ListAgentAnomalyDetectionScopes(ListAgentAnomalyDetectionScopesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAgentAnomalyDetectionScopesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAgentAnomalyDetectionScopesRequest, ListAgentAnomalyDetectionScopesResponse, AgentAnomalyDetectionScope>(_callListAgentAnomalyDetectionScopes, request, callSettings);
        }

        /// <summary>
        /// Lists AgentAnomalyDetectionScopes in a Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AgentAnomalyDetectionScope"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAgentAnomalyDetectionScopesResponse, AgentAnomalyDetectionScope> ListAgentAnomalyDetectionScopesAsync(ListAgentAnomalyDetectionScopesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAgentAnomalyDetectionScopesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAgentAnomalyDetectionScopesRequest, ListAgentAnomalyDetectionScopesResponse, AgentAnomalyDetectionScope>(_callListAgentAnomalyDetectionScopes, request, callSettings);
        }

        /// <summary>
        /// Lists AnalyzedSessions in a MonitoredAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AnalyzedSession"/> resources.</returns>
        public override gax::PagedEnumerable<ListAnalyzedSessionsResponse, AnalyzedSession> ListAnalyzedSessions(ListAnalyzedSessionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAnalyzedSessionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAnalyzedSessionsRequest, ListAnalyzedSessionsResponse, AnalyzedSession>(_callListAnalyzedSessions, request, callSettings);
        }

        /// <summary>
        /// Lists AnalyzedSessions in a MonitoredAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AnalyzedSession"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAnalyzedSessionsResponse, AnalyzedSession> ListAnalyzedSessionsAsync(ListAnalyzedSessionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAnalyzedSessionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAnalyzedSessionsRequest, ListAnalyzedSessionsResponse, AnalyzedSession>(_callListAnalyzedSessions, request, callSettings);
        }

        /// <summary>
        /// Gets the details of a specific AnalyzedSession.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AnalyzedSession GetAnalyzedSession(GetAnalyzedSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAnalyzedSessionRequest(ref request, ref callSettings);
            return _callGetAnalyzedSession.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a specific AnalyzedSession.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AnalyzedSession> GetAnalyzedSessionAsync(GetAnalyzedSessionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAnalyzedSessionRequest(ref request, ref callSettings);
            return _callGetAnalyzedSession.Async(request, callSettings);
        }

        /// <summary>
        /// Lists AnalyzedInvocations in a MonitoredAgent's AnalyzedSession.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AnalyzedInvocation"/> resources.</returns>
        public override gax::PagedEnumerable<ListAnalyzedInvocationsResponse, AnalyzedInvocation> ListAnalyzedInvocations(ListAnalyzedInvocationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAnalyzedInvocationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAnalyzedInvocationsRequest, ListAnalyzedInvocationsResponse, AnalyzedInvocation>(_callListAnalyzedInvocations, request, callSettings);
        }

        /// <summary>
        /// Lists AnalyzedInvocations in a MonitoredAgent's AnalyzedSession.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AnalyzedInvocation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAnalyzedInvocationsResponse, AnalyzedInvocation> ListAnalyzedInvocationsAsync(ListAnalyzedInvocationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAnalyzedInvocationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAnalyzedInvocationsRequest, ListAnalyzedInvocationsResponse, AnalyzedInvocation>(_callListAnalyzedInvocations, request, callSettings);
        }

        /// <summary>
        /// Gets the details of a specific AnalyzedInvocation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AnalyzedInvocation GetAnalyzedInvocation(GetAnalyzedInvocationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAnalyzedInvocationRequest(ref request, ref callSettings);
            return _callGetAnalyzedInvocation.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the details of a specific AnalyzedInvocation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AnalyzedInvocation> GetAnalyzedInvocationAsync(GetAnalyzedInvocationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAnalyzedInvocationRequest(ref request, ref callSettings);
            return _callGetAnalyzedInvocation.Async(request, callSettings);
        }

        /// <summary>
        /// Aggregates AnalyzedSessions across MonitoredAgents.
        /// 
        /// To aggregate across all MonitoredAgents in a
        /// location, use the following format for the parent field:
        /// `projects/{project}/locations/{location}/monitoredAgents/-`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable sequence of <see cref="AggregateAnalyzedSessionsResponse.Types.AgentAggregate"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<AggregateAnalyzedSessionsResponse, AggregateAnalyzedSessionsResponse.Types.AgentAggregate> AggregateAnalyzedSessions(AggregateAnalyzedSessionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregateAnalyzedSessionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<AggregateAnalyzedSessionsRequest, AggregateAnalyzedSessionsResponse, AggregateAnalyzedSessionsResponse.Types.AgentAggregate>(_callAggregateAnalyzedSessions, request, callSettings);
        }

        /// <summary>
        /// Aggregates AnalyzedSessions across MonitoredAgents.
        /// 
        /// To aggregate across all MonitoredAgents in a
        /// location, use the following format for the parent field:
        /// `projects/{project}/locations/{location}/monitoredAgents/-`
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="AggregateAnalyzedSessionsResponse.Types.AgentAggregate"/>
        /// resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<AggregateAnalyzedSessionsResponse, AggregateAnalyzedSessionsResponse.Types.AgentAggregate> AggregateAnalyzedSessionsAsync(AggregateAnalyzedSessionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregateAnalyzedSessionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<AggregateAnalyzedSessionsRequest, AggregateAnalyzedSessionsResponse, AggregateAnalyzedSessionsResponse.Types.AgentAggregate>(_callAggregateAnalyzedSessions, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>ClearTrainingData</c>.</summary>
        public override lro::OperationsClient ClearTrainingDataOperationsClient { get; }

        /// <summary>
        /// Clears (purges) the trained model artifacts derived from a MonitoredAgent's
        /// data. The purged model is rebuilt by the next scheduled training run.
        /// 
        /// To clear every MonitoredAgent in a location's scope, use the `-` wildcard
        /// agent segment for the name field:
        /// `projects/{project}/locations/{location}/monitoredAgents/-`
        /// 
        /// This is the on-demand data-deletion path for customers who have deleted the
        /// underlying logs / observability data a model was trained on. It deletes
        /// only the derived model artifacts (it does NOT delete the scope or stop
        /// monitoring). To stop monitoring an agent entirely, disable it via
        /// DisableMonitoredAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ClearTrainingDataResponse, ClearTrainingDataOperationMetadata> ClearTrainingData(ClearTrainingDataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ClearTrainingDataRequest(ref request, ref callSettings);
            return new lro::Operation<ClearTrainingDataResponse, ClearTrainingDataOperationMetadata>(_callClearTrainingData.Sync(request, callSettings), ClearTrainingDataOperationsClient);
        }

        /// <summary>
        /// Clears (purges) the trained model artifacts derived from a MonitoredAgent's
        /// data. The purged model is rebuilt by the next scheduled training run.
        /// 
        /// To clear every MonitoredAgent in a location's scope, use the `-` wildcard
        /// agent segment for the name field:
        /// `projects/{project}/locations/{location}/monitoredAgents/-`
        /// 
        /// This is the on-demand data-deletion path for customers who have deleted the
        /// underlying logs / observability data a model was trained on. It deletes
        /// only the derived model artifacts (it does NOT delete the scope or stop
        /// monitoring). To stop monitoring an agent entirely, disable it via
        /// DisableMonitoredAgent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ClearTrainingDataResponse, ClearTrainingDataOperationMetadata>> ClearTrainingDataAsync(ClearTrainingDataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ClearTrainingDataRequest(ref request, ref callSettings);
            return new lro::Operation<ClearTrainingDataResponse, ClearTrainingDataOperationMetadata>(await _callClearTrainingData.Async(request, callSettings).ConfigureAwait(false), ClearTrainingDataOperationsClient);
        }
    }

    public partial class ListMonitoredAgentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAgentAnomalyDetectionScopesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAnalyzedSessionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAnalyzedInvocationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class AggregateAnalyzedSessionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMonitoredAgentsResponse : gaxgrpc::IPageResponse<MonitoredAgent>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<MonitoredAgent> GetEnumerator() => MonitoredAgents.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAgentAnomalyDetectionScopesResponse : gaxgrpc::IPageResponse<AgentAnomalyDetectionScope>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AgentAnomalyDetectionScope> GetEnumerator() => AgentAnomalyDetectionScopes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAnalyzedSessionsResponse : gaxgrpc::IPageResponse<AnalyzedSession>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AnalyzedSession> GetEnumerator() => AnalyzedSessions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAnalyzedInvocationsResponse : gaxgrpc::IPageResponse<AnalyzedInvocation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AnalyzedInvocation> GetEnumerator() => AnalyzedInvocations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class AggregateAnalyzedSessionsResponse : gaxgrpc::IPageResponse<AggregateAnalyzedSessionsResponse.Types.AgentAggregate>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Types.AgentAggregate> GetEnumerator() => AgentAggregates.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class AgentAnomalyDetectionService
    {
        public partial class AgentAnomalyDetectionServiceClient
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

    public static partial class AgentAnomalyDetectionService
    {
        public partial class AgentAnomalyDetectionServiceClient
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
