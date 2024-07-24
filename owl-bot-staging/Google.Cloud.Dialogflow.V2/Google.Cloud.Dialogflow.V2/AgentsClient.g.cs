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

namespace Google.Cloud.Dialogflow.V2
{
    /// <summary>Settings for <see cref="AgentsClient"/> instances.</summary>
    public sealed partial class AgentsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AgentsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AgentsSettings"/>.</returns>
        public static AgentsSettings GetDefault() => new AgentsSettings();

        /// <summary>Constructs a new <see cref="AgentsSettings"/> object with default settings.</summary>
        public AgentsSettings()
        {
        }

        private AgentsSettings(AgentsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetAgentSettings = existing.GetAgentSettings;
            SetAgentSettings = existing.SetAgentSettings;
            DeleteAgentSettings = existing.DeleteAgentSettings;
            SearchAgentsSettings = existing.SearchAgentsSettings;
            TrainAgentSettings = existing.TrainAgentSettings;
            TrainAgentOperationsSettings = existing.TrainAgentOperationsSettings.Clone();
            ExportAgentSettings = existing.ExportAgentSettings;
            ExportAgentOperationsSettings = existing.ExportAgentOperationsSettings.Clone();
            ImportAgentSettings = existing.ImportAgentSettings;
            ImportAgentOperationsSettings = existing.ImportAgentOperationsSettings.Clone();
            RestoreAgentSettings = existing.RestoreAgentSettings;
            RestoreAgentOperationsSettings = existing.RestoreAgentOperationsSettings.Clone();
            GetValidationResultSettings = existing.GetValidationResultSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AgentsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AgentsClient.GetAgent</c>
        /// and <c>AgentsClient.GetAgentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAgentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AgentsClient.SetAgent</c>
        /// and <c>AgentsClient.SetAgentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetAgentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AgentsClient.DeleteAgent</c>
        ///  and <c>AgentsClient.DeleteAgentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAgentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AgentsClient.SearchAgents</c>
        ///  and <c>AgentsClient.SearchAgentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchAgentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AgentsClient.TrainAgent</c>
        /// and <c>AgentsClient.TrainAgentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TrainAgentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AgentsClient.TrainAgent</c> and
        /// <c>AgentsClient.TrainAgentAsync</c>.
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
        public lro::OperationsSettings TrainAgentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AgentsClient.ExportAgent</c>
        ///  and <c>AgentsClient.ExportAgentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExportAgentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AgentsClient.ExportAgent</c> and
        /// <c>AgentsClient.ExportAgentAsync</c>.
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
        public lro::OperationsSettings ExportAgentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AgentsClient.ImportAgent</c>
        ///  and <c>AgentsClient.ImportAgentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ImportAgentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AgentsClient.ImportAgent</c> and
        /// <c>AgentsClient.ImportAgentAsync</c>.
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
        public lro::OperationsSettings ImportAgentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AgentsClient.RestoreAgent</c>
        ///  and <c>AgentsClient.RestoreAgentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RestoreAgentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AgentsClient.RestoreAgent</c> and
        /// <c>AgentsClient.RestoreAgentAsync</c>.
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
        public lro::OperationsSettings RestoreAgentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AgentsClient.GetValidationResult</c> and <c>AgentsClient.GetValidationResultAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetValidationResultSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AgentsSettings"/> object.</returns>
        public AgentsSettings Clone() => new AgentsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AgentsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class AgentsClientBuilder : gaxgrpc::ClientBuilderBase<AgentsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AgentsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AgentsClientBuilder() : base(AgentsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AgentsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AgentsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AgentsClient Build()
        {
            AgentsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AgentsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AgentsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AgentsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AgentsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AgentsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AgentsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AgentsClient.ChannelPool;
    }

    /// <summary>Agents client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Agents][google.cloud.dialogflow.v2.Agent].
    /// </remarks>
    public abstract partial class AgentsClient
    {
        /// <summary>
        /// The default endpoint for the Agents service, which is a host of "dialogflow.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dialogflow.googleapis.com:443";

        /// <summary>The default Agents scopes.</summary>
        /// <remarks>
        /// The default Agents scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/dialogflow</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/dialogflow",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Agents.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AgentsClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="AgentsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AgentsClient"/>.</returns>
        public static stt::Task<AgentsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AgentsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AgentsClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="AgentsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AgentsClient"/>.</returns>
        public static AgentsClient Create() => new AgentsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AgentsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AgentsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AgentsClient"/>.</returns>
        internal static AgentsClient Create(grpccore::CallInvoker callInvoker, AgentsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Agents.AgentsClient grpcClient = new Agents.AgentsClient(callInvoker);
            return new AgentsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Agents client</summary>
        public virtual Agents.AgentsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Agent GetAgent(GetAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> GetAgentAsync(GetAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> GetAgentAsync(GetAgentRequest request, st::CancellationToken cancellationToken) =>
            GetAgentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to fetch is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Agent GetAgent(string parent, gaxgrpc::CallSettings callSettings = null) =>
            GetAgent(new GetAgentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to fetch is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> GetAgentAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            GetAgentAsync(new GetAgentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to fetch is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> GetAgentAsync(string parent, st::CancellationToken cancellationToken) =>
            GetAgentAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to fetch is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Agent GetAgent(gagr::ProjectName parent, gaxgrpc::CallSettings callSettings = null) =>
            GetAgent(new GetAgentRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to fetch is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> GetAgentAsync(gagr::ProjectName parent, gaxgrpc::CallSettings callSettings = null) =>
            GetAgentAsync(new GetAgentRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to fetch is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> GetAgentAsync(gagr::ProjectName parent, st::CancellationToken cancellationToken) =>
            GetAgentAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to fetch is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Agent GetAgent(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            GetAgent(new GetAgentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to fetch is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> GetAgentAsync(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            GetAgentAsync(new GetAgentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Retrieves the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to fetch is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> GetAgentAsync(gagr::LocationName parent, st::CancellationToken cancellationToken) =>
            GetAgentAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates/updates the specified agent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Agent SetAgent(SetAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates/updates the specified agent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> SetAgentAsync(SetAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates/updates the specified agent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> SetAgentAsync(SetAgentRequest request, st::CancellationToken cancellationToken) =>
            SetAgentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates/updates the specified agent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="agent">
        /// Required. The agent to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Agent SetAgent(Agent agent, gaxgrpc::CallSettings callSettings = null) =>
            SetAgent(new SetAgentRequest
            {
                Agent = gax::GaxPreconditions.CheckNotNull(agent, nameof(agent)),
            }, callSettings);

        /// <summary>
        /// Creates/updates the specified agent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="agent">
        /// Required. The agent to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> SetAgentAsync(Agent agent, gaxgrpc::CallSettings callSettings = null) =>
            SetAgentAsync(new SetAgentRequest
            {
                Agent = gax::GaxPreconditions.CheckNotNull(agent, nameof(agent)),
            }, callSettings);

        /// <summary>
        /// Creates/updates the specified agent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="agent">
        /// Required. The agent to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Agent> SetAgentAsync(Agent agent, st::CancellationToken cancellationToken) =>
            SetAgentAsync(agent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAgent(DeleteAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAgentAsync(DeleteAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAgentAsync(DeleteAgentRequest request, st::CancellationToken cancellationToken) =>
            DeleteAgentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to delete is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAgent(string parent, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAgent(new DeleteAgentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to delete is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAgentAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAgentAsync(new DeleteAgentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to delete is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAgentAsync(string parent, st::CancellationToken cancellationToken) =>
            DeleteAgentAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to delete is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAgent(gagr::ProjectName parent, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAgent(new DeleteAgentRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to delete is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAgentAsync(gagr::ProjectName parent, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAgentAsync(new DeleteAgentRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to delete is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAgentAsync(gagr::ProjectName parent, st::CancellationToken cancellationToken) =>
            DeleteAgentAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to delete is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAgent(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAgent(new DeleteAgentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to delete is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAgentAsync(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAgentAsync(new DeleteAgentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to delete is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAgentAsync(gagr::LocationName parent, st::CancellationToken cancellationToken) =>
            DeleteAgentAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the list of agents.
        /// 
        /// Since there is at most one conversational agent per project, this method is
        /// useful primarily for listing all agents across projects the caller has
        /// access to. One can achieve that with a wildcard project collection id "-".
        /// Refer to [List
        /// Sub-Collections](https://cloud.google.com/apis/design/design_patterns#list_sub-collections).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Agent"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchAgentsResponse, Agent> SearchAgents(SearchAgentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of agents.
        /// 
        /// Since there is at most one conversational agent per project, this method is
        /// useful primarily for listing all agents across projects the caller has
        /// access to. One can achieve that with a wildcard project collection id "-".
        /// Refer to [List
        /// Sub-Collections](https://cloud.google.com/apis/design/design_patterns#list_sub-collections).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Agent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchAgentsResponse, Agent> SearchAgentsAsync(SearchAgentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of agents.
        /// 
        /// Since there is at most one conversational agent per project, this method is
        /// useful primarily for listing all agents across projects the caller has
        /// access to. One can achieve that with a wildcard project collection id "-".
        /// Refer to [List
        /// Sub-Collections](https://cloud.google.com/apis/design/design_patterns#list_sub-collections).
        /// </summary>
        /// <param name="parent">
        /// Required. The project to list agents from.
        /// Format: `projects/&lt;Project ID or '-'&gt;`.
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
        /// <returns>A pageable sequence of <see cref="Agent"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchAgentsResponse, Agent> SearchAgents(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchAgentsRequest request = new SearchAgentsRequest
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
            return SearchAgents(request, callSettings);
        }

        /// <summary>
        /// Returns the list of agents.
        /// 
        /// Since there is at most one conversational agent per project, this method is
        /// useful primarily for listing all agents across projects the caller has
        /// access to. One can achieve that with a wildcard project collection id "-".
        /// Refer to [List
        /// Sub-Collections](https://cloud.google.com/apis/design/design_patterns#list_sub-collections).
        /// </summary>
        /// <param name="parent">
        /// Required. The project to list agents from.
        /// Format: `projects/&lt;Project ID or '-'&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Agent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchAgentsResponse, Agent> SearchAgentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchAgentsRequest request = new SearchAgentsRequest
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
            return SearchAgentsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the list of agents.
        /// 
        /// Since there is at most one conversational agent per project, this method is
        /// useful primarily for listing all agents across projects the caller has
        /// access to. One can achieve that with a wildcard project collection id "-".
        /// Refer to [List
        /// Sub-Collections](https://cloud.google.com/apis/design/design_patterns#list_sub-collections).
        /// </summary>
        /// <param name="parent">
        /// Required. The project to list agents from.
        /// Format: `projects/&lt;Project ID or '-'&gt;`.
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
        /// <returns>A pageable sequence of <see cref="Agent"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchAgentsResponse, Agent> SearchAgents(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchAgentsRequest request = new SearchAgentsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchAgents(request, callSettings);
        }

        /// <summary>
        /// Returns the list of agents.
        /// 
        /// Since there is at most one conversational agent per project, this method is
        /// useful primarily for listing all agents across projects the caller has
        /// access to. One can achieve that with a wildcard project collection id "-".
        /// Refer to [List
        /// Sub-Collections](https://cloud.google.com/apis/design/design_patterns#list_sub-collections).
        /// </summary>
        /// <param name="parent">
        /// Required. The project to list agents from.
        /// Format: `projects/&lt;Project ID or '-'&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Agent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchAgentsResponse, Agent> SearchAgentsAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchAgentsRequest request = new SearchAgentsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchAgentsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the list of agents.
        /// 
        /// Since there is at most one conversational agent per project, this method is
        /// useful primarily for listing all agents across projects the caller has
        /// access to. One can achieve that with a wildcard project collection id "-".
        /// Refer to [List
        /// Sub-Collections](https://cloud.google.com/apis/design/design_patterns#list_sub-collections).
        /// </summary>
        /// <param name="parent">
        /// Required. The project to list agents from.
        /// Format: `projects/&lt;Project ID or '-'&gt;`.
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
        /// <returns>A pageable sequence of <see cref="Agent"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchAgentsResponse, Agent> SearchAgents(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchAgentsRequest request = new SearchAgentsRequest
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
            return SearchAgents(request, callSettings);
        }

        /// <summary>
        /// Returns the list of agents.
        /// 
        /// Since there is at most one conversational agent per project, this method is
        /// useful primarily for listing all agents across projects the caller has
        /// access to. One can achieve that with a wildcard project collection id "-".
        /// Refer to [List
        /// Sub-Collections](https://cloud.google.com/apis/design/design_patterns#list_sub-collections).
        /// </summary>
        /// <param name="parent">
        /// Required. The project to list agents from.
        /// Format: `projects/&lt;Project ID or '-'&gt;`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Agent"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchAgentsResponse, Agent> SearchAgentsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchAgentsRequest request = new SearchAgentsRequest
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
            return SearchAgentsAsync(request, callSettings);
        }

        /// <summary>
        /// Trains the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Struct> TrainAgent(TrainAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Trains the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> TrainAgentAsync(TrainAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Trains the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> TrainAgentAsync(TrainAgentRequest request, st::CancellationToken cancellationToken) =>
            TrainAgentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>TrainAgent</c>.</summary>
        public virtual lro::OperationsClient TrainAgentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>TrainAgent</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Struct> PollOnceTrainAgent(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, wkt::Struct>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), TrainAgentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>TrainAgent</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> PollOnceTrainAgentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, wkt::Struct>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), TrainAgentOperationsClient, callSettings);

        /// <summary>
        /// Trains the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to train is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Struct> TrainAgent(string parent, gaxgrpc::CallSettings callSettings = null) =>
            TrainAgent(new TrainAgentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Trains the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to train is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> TrainAgentAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            TrainAgentAsync(new TrainAgentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Trains the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to train is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> TrainAgentAsync(string parent, st::CancellationToken cancellationToken) =>
            TrainAgentAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Trains the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to train is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Struct> TrainAgent(gagr::ProjectName parent, gaxgrpc::CallSettings callSettings = null) =>
            TrainAgent(new TrainAgentRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Trains the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to train is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> TrainAgentAsync(gagr::ProjectName parent, gaxgrpc::CallSettings callSettings = null) =>
            TrainAgentAsync(new TrainAgentRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Trains the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to train is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> TrainAgentAsync(gagr::ProjectName parent, st::CancellationToken cancellationToken) =>
            TrainAgentAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Trains the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to train is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Struct> TrainAgent(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            TrainAgent(new TrainAgentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Trains the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to train is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> TrainAgentAsync(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            TrainAgentAsync(new TrainAgentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Trains the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to train is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> TrainAgentAsync(gagr::LocationName parent, st::CancellationToken cancellationToken) =>
            TrainAgentAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports the specified agent to a ZIP file.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`:
        /// [ExportAgentResponse][google.cloud.dialogflow.v2.ExportAgentResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportAgentResponse, wkt::Struct> ExportAgent(ExportAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports the specified agent to a ZIP file.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`:
        /// [ExportAgentResponse][google.cloud.dialogflow.v2.ExportAgentResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportAgentResponse, wkt::Struct>> ExportAgentAsync(ExportAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports the specified agent to a ZIP file.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`:
        /// [ExportAgentResponse][google.cloud.dialogflow.v2.ExportAgentResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportAgentResponse, wkt::Struct>> ExportAgentAsync(ExportAgentRequest request, st::CancellationToken cancellationToken) =>
            ExportAgentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExportAgent</c>.</summary>
        public virtual lro::OperationsClient ExportAgentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ExportAgent</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ExportAgentResponse, wkt::Struct> PollOnceExportAgent(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportAgentResponse, wkt::Struct>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportAgentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportAgent</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ExportAgentResponse, wkt::Struct>> PollOnceExportAgentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportAgentResponse, wkt::Struct>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportAgentOperationsClient, callSettings);

        /// <summary>
        /// Exports the specified agent to a ZIP file.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`:
        /// [ExportAgentResponse][google.cloud.dialogflow.v2.ExportAgentResponse]
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to export is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportAgentResponse, wkt::Struct> ExportAgent(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ExportAgent(new ExportAgentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Exports the specified agent to a ZIP file.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`:
        /// [ExportAgentResponse][google.cloud.dialogflow.v2.ExportAgentResponse]
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to export is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportAgentResponse, wkt::Struct>> ExportAgentAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ExportAgentAsync(new ExportAgentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Exports the specified agent to a ZIP file.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`:
        /// [ExportAgentResponse][google.cloud.dialogflow.v2.ExportAgentResponse]
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to export is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportAgentResponse, wkt::Struct>> ExportAgentAsync(string parent, st::CancellationToken cancellationToken) =>
            ExportAgentAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports the specified agent to a ZIP file.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`:
        /// [ExportAgentResponse][google.cloud.dialogflow.v2.ExportAgentResponse]
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to export is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportAgentResponse, wkt::Struct> ExportAgent(gagr::ProjectName parent, gaxgrpc::CallSettings callSettings = null) =>
            ExportAgent(new ExportAgentRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Exports the specified agent to a ZIP file.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`:
        /// [ExportAgentResponse][google.cloud.dialogflow.v2.ExportAgentResponse]
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to export is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportAgentResponse, wkt::Struct>> ExportAgentAsync(gagr::ProjectName parent, gaxgrpc::CallSettings callSettings = null) =>
            ExportAgentAsync(new ExportAgentRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Exports the specified agent to a ZIP file.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`:
        /// [ExportAgentResponse][google.cloud.dialogflow.v2.ExportAgentResponse]
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to export is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportAgentResponse, wkt::Struct>> ExportAgentAsync(gagr::ProjectName parent, st::CancellationToken cancellationToken) =>
            ExportAgentAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports the specified agent to a ZIP file.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`:
        /// [ExportAgentResponse][google.cloud.dialogflow.v2.ExportAgentResponse]
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to export is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportAgentResponse, wkt::Struct> ExportAgent(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            ExportAgent(new ExportAgentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Exports the specified agent to a ZIP file.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`:
        /// [ExportAgentResponse][google.cloud.dialogflow.v2.ExportAgentResponse]
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to export is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportAgentResponse, wkt::Struct>> ExportAgentAsync(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            ExportAgentAsync(new ExportAgentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Exports the specified agent to a ZIP file.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`:
        /// [ExportAgentResponse][google.cloud.dialogflow.v2.ExportAgentResponse]
        /// </summary>
        /// <param name="parent">
        /// Required. The project that the agent to export is associated with.
        /// Format: `projects/&lt;Project ID&gt;`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportAgentResponse, wkt::Struct>> ExportAgentAsync(gagr::LocationName parent, st::CancellationToken cancellationToken) =>
            ExportAgentAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports the specified agent from a ZIP file.
        /// 
        /// Uploads new intents and entity types without deleting the existing ones.
        /// Intents and entity types with the same name are replaced with the new
        /// versions from
        /// [ImportAgentRequest][google.cloud.dialogflow.v2.ImportAgentRequest]. After
        /// the import, the imported draft agent will be trained automatically (unless
        /// disabled in agent settings). However, once the import is done, training may
        /// not be completed yet. Please call
        /// [TrainAgent][google.cloud.dialogflow.v2.Agents.TrainAgent] and wait for the
        /// operation it returns in order to train explicitly.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// The operation only tracks when importing is complete, not when it is done
        /// training.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Struct> ImportAgent(ImportAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports the specified agent from a ZIP file.
        /// 
        /// Uploads new intents and entity types without deleting the existing ones.
        /// Intents and entity types with the same name are replaced with the new
        /// versions from
        /// [ImportAgentRequest][google.cloud.dialogflow.v2.ImportAgentRequest]. After
        /// the import, the imported draft agent will be trained automatically (unless
        /// disabled in agent settings). However, once the import is done, training may
        /// not be completed yet. Please call
        /// [TrainAgent][google.cloud.dialogflow.v2.Agents.TrainAgent] and wait for the
        /// operation it returns in order to train explicitly.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// The operation only tracks when importing is complete, not when it is done
        /// training.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> ImportAgentAsync(ImportAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports the specified agent from a ZIP file.
        /// 
        /// Uploads new intents and entity types without deleting the existing ones.
        /// Intents and entity types with the same name are replaced with the new
        /// versions from
        /// [ImportAgentRequest][google.cloud.dialogflow.v2.ImportAgentRequest]. After
        /// the import, the imported draft agent will be trained automatically (unless
        /// disabled in agent settings). However, once the import is done, training may
        /// not be completed yet. Please call
        /// [TrainAgent][google.cloud.dialogflow.v2.Agents.TrainAgent] and wait for the
        /// operation it returns in order to train explicitly.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// The operation only tracks when importing is complete, not when it is done
        /// training.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> ImportAgentAsync(ImportAgentRequest request, st::CancellationToken cancellationToken) =>
            ImportAgentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ImportAgent</c>.</summary>
        public virtual lro::OperationsClient ImportAgentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ImportAgent</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Struct> PollOnceImportAgent(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, wkt::Struct>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportAgentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportAgent</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> PollOnceImportAgentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, wkt::Struct>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportAgentOperationsClient, callSettings);

        /// <summary>
        /// Restores the specified agent from a ZIP file.
        /// 
        /// Replaces the current agent version with a new one. All the intents and
        /// entity types in the older version are deleted. After the restore, the
        /// restored draft agent will be trained automatically (unless disabled in
        /// agent settings). However, once the restore is done, training may not be
        /// completed yet. Please call
        /// [TrainAgent][google.cloud.dialogflow.v2.Agents.TrainAgent] and wait for the
        /// operation it returns in order to train explicitly.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// The operation only tracks when restoring is complete, not when it is done
        /// training.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Struct> RestoreAgent(RestoreAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restores the specified agent from a ZIP file.
        /// 
        /// Replaces the current agent version with a new one. All the intents and
        /// entity types in the older version are deleted. After the restore, the
        /// restored draft agent will be trained automatically (unless disabled in
        /// agent settings). However, once the restore is done, training may not be
        /// completed yet. Please call
        /// [TrainAgent][google.cloud.dialogflow.v2.Agents.TrainAgent] and wait for the
        /// operation it returns in order to train explicitly.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// The operation only tracks when restoring is complete, not when it is done
        /// training.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> RestoreAgentAsync(RestoreAgentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restores the specified agent from a ZIP file.
        /// 
        /// Replaces the current agent version with a new one. All the intents and
        /// entity types in the older version are deleted. After the restore, the
        /// restored draft agent will be trained automatically (unless disabled in
        /// agent settings). However, once the restore is done, training may not be
        /// completed yet. Please call
        /// [TrainAgent][google.cloud.dialogflow.v2.Agents.TrainAgent] and wait for the
        /// operation it returns in order to train explicitly.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// The operation only tracks when restoring is complete, not when it is done
        /// training.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> RestoreAgentAsync(RestoreAgentRequest request, st::CancellationToken cancellationToken) =>
            RestoreAgentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RestoreAgent</c>.</summary>
        public virtual lro::OperationsClient RestoreAgentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RestoreAgent</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Struct> PollOnceRestoreAgent(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, wkt::Struct>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RestoreAgentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RestoreAgent</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> PollOnceRestoreAgentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, wkt::Struct>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RestoreAgentOperationsClient, callSettings);

        /// <summary>
        /// Gets agent validation result. Agent validation is performed during
        /// training time and is updated automatically when training is completed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ValidationResult GetValidationResult(GetValidationResultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets agent validation result. Agent validation is performed during
        /// training time and is updated automatically when training is completed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ValidationResult> GetValidationResultAsync(GetValidationResultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets agent validation result. Agent validation is performed during
        /// training time and is updated automatically when training is completed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ValidationResult> GetValidationResultAsync(GetValidationResultRequest request, st::CancellationToken cancellationToken) =>
            GetValidationResultAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Agents client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for managing [Agents][google.cloud.dialogflow.v2.Agent].
    /// </remarks>
    public sealed partial class AgentsClientImpl : AgentsClient
    {
        private readonly gaxgrpc::ApiCall<GetAgentRequest, Agent> _callGetAgent;

        private readonly gaxgrpc::ApiCall<SetAgentRequest, Agent> _callSetAgent;

        private readonly gaxgrpc::ApiCall<DeleteAgentRequest, wkt::Empty> _callDeleteAgent;

        private readonly gaxgrpc::ApiCall<SearchAgentsRequest, SearchAgentsResponse> _callSearchAgents;

        private readonly gaxgrpc::ApiCall<TrainAgentRequest, lro::Operation> _callTrainAgent;

        private readonly gaxgrpc::ApiCall<ExportAgentRequest, lro::Operation> _callExportAgent;

        private readonly gaxgrpc::ApiCall<ImportAgentRequest, lro::Operation> _callImportAgent;

        private readonly gaxgrpc::ApiCall<RestoreAgentRequest, lro::Operation> _callRestoreAgent;

        private readonly gaxgrpc::ApiCall<GetValidationResultRequest, ValidationResult> _callGetValidationResult;

        /// <summary>
        /// Constructs a client wrapper for the Agents service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AgentsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AgentsClientImpl(Agents.AgentsClient grpcClient, AgentsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AgentsSettings effectiveSettings = settings ?? AgentsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            TrainAgentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.TrainAgentOperationsSettings, logger);
            ExportAgentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportAgentOperationsSettings, logger);
            ImportAgentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ImportAgentOperationsSettings, logger);
            RestoreAgentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RestoreAgentOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callGetAgent = clientHelper.BuildApiCall<GetAgentRequest, Agent>("GetAgent", grpcClient.GetAgentAsync, grpcClient.GetAgent, effectiveSettings.GetAgentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callGetAgent);
            Modify_GetAgentApiCall(ref _callGetAgent);
            _callSetAgent = clientHelper.BuildApiCall<SetAgentRequest, Agent>("SetAgent", grpcClient.SetAgentAsync, grpcClient.SetAgent, effectiveSettings.SetAgentSettings).WithGoogleRequestParam("agent.parent", request => request.Agent?.Parent);
            Modify_ApiCall(ref _callSetAgent);
            Modify_SetAgentApiCall(ref _callSetAgent);
            _callDeleteAgent = clientHelper.BuildApiCall<DeleteAgentRequest, wkt::Empty>("DeleteAgent", grpcClient.DeleteAgentAsync, grpcClient.DeleteAgent, effectiveSettings.DeleteAgentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callDeleteAgent);
            Modify_DeleteAgentApiCall(ref _callDeleteAgent);
            _callSearchAgents = clientHelper.BuildApiCall<SearchAgentsRequest, SearchAgentsResponse>("SearchAgents", grpcClient.SearchAgentsAsync, grpcClient.SearchAgents, effectiveSettings.SearchAgentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSearchAgents);
            Modify_SearchAgentsApiCall(ref _callSearchAgents);
            _callTrainAgent = clientHelper.BuildApiCall<TrainAgentRequest, lro::Operation>("TrainAgent", grpcClient.TrainAgentAsync, grpcClient.TrainAgent, effectiveSettings.TrainAgentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callTrainAgent);
            Modify_TrainAgentApiCall(ref _callTrainAgent);
            _callExportAgent = clientHelper.BuildApiCall<ExportAgentRequest, lro::Operation>("ExportAgent", grpcClient.ExportAgentAsync, grpcClient.ExportAgent, effectiveSettings.ExportAgentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callExportAgent);
            Modify_ExportAgentApiCall(ref _callExportAgent);
            _callImportAgent = clientHelper.BuildApiCall<ImportAgentRequest, lro::Operation>("ImportAgent", grpcClient.ImportAgentAsync, grpcClient.ImportAgent, effectiveSettings.ImportAgentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callImportAgent);
            Modify_ImportAgentApiCall(ref _callImportAgent);
            _callRestoreAgent = clientHelper.BuildApiCall<RestoreAgentRequest, lro::Operation>("RestoreAgent", grpcClient.RestoreAgentAsync, grpcClient.RestoreAgent, effectiveSettings.RestoreAgentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callRestoreAgent);
            Modify_RestoreAgentApiCall(ref _callRestoreAgent);
            _callGetValidationResult = clientHelper.BuildApiCall<GetValidationResultRequest, ValidationResult>("GetValidationResult", grpcClient.GetValidationResultAsync, grpcClient.GetValidationResult, effectiveSettings.GetValidationResultSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callGetValidationResult);
            Modify_GetValidationResultApiCall(ref _callGetValidationResult);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetAgentApiCall(ref gaxgrpc::ApiCall<GetAgentRequest, Agent> call);

        partial void Modify_SetAgentApiCall(ref gaxgrpc::ApiCall<SetAgentRequest, Agent> call);

        partial void Modify_DeleteAgentApiCall(ref gaxgrpc::ApiCall<DeleteAgentRequest, wkt::Empty> call);

        partial void Modify_SearchAgentsApiCall(ref gaxgrpc::ApiCall<SearchAgentsRequest, SearchAgentsResponse> call);

        partial void Modify_TrainAgentApiCall(ref gaxgrpc::ApiCall<TrainAgentRequest, lro::Operation> call);

        partial void Modify_ExportAgentApiCall(ref gaxgrpc::ApiCall<ExportAgentRequest, lro::Operation> call);

        partial void Modify_ImportAgentApiCall(ref gaxgrpc::ApiCall<ImportAgentRequest, lro::Operation> call);

        partial void Modify_RestoreAgentApiCall(ref gaxgrpc::ApiCall<RestoreAgentRequest, lro::Operation> call);

        partial void Modify_GetValidationResultApiCall(ref gaxgrpc::ApiCall<GetValidationResultRequest, ValidationResult> call);

        partial void OnConstruction(Agents.AgentsClient grpcClient, AgentsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Agents client</summary>
        public override Agents.AgentsClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_GetAgentRequest(ref GetAgentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetAgentRequest(ref SetAgentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAgentRequest(ref DeleteAgentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchAgentsRequest(ref SearchAgentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TrainAgentRequest(ref TrainAgentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportAgentRequest(ref ExportAgentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportAgentRequest(ref ImportAgentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RestoreAgentRequest(ref RestoreAgentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetValidationResultRequest(ref GetValidationResultRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Agent GetAgent(GetAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAgentRequest(ref request, ref callSettings);
            return _callGetAgent.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Agent> GetAgentAsync(GetAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAgentRequest(ref request, ref callSettings);
            return _callGetAgent.Async(request, callSettings);
        }

        /// <summary>
        /// Creates/updates the specified agent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Agent SetAgent(SetAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetAgentRequest(ref request, ref callSettings);
            return _callSetAgent.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates/updates the specified agent.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Agent> SetAgentAsync(SetAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetAgentRequest(ref request, ref callSettings);
            return _callSetAgent.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteAgent(DeleteAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAgentRequest(ref request, ref callSettings);
            _callDeleteAgent.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified agent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteAgentAsync(DeleteAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAgentRequest(ref request, ref callSettings);
            return _callDeleteAgent.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the list of agents.
        /// 
        /// Since there is at most one conversational agent per project, this method is
        /// useful primarily for listing all agents across projects the caller has
        /// access to. One can achieve that with a wildcard project collection id "-".
        /// Refer to [List
        /// Sub-Collections](https://cloud.google.com/apis/design/design_patterns#list_sub-collections).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Agent"/> resources.</returns>
        public override gax::PagedEnumerable<SearchAgentsResponse, Agent> SearchAgents(SearchAgentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchAgentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchAgentsRequest, SearchAgentsResponse, Agent>(_callSearchAgents, request, callSettings);
        }

        /// <summary>
        /// Returns the list of agents.
        /// 
        /// Since there is at most one conversational agent per project, this method is
        /// useful primarily for listing all agents across projects the caller has
        /// access to. One can achieve that with a wildcard project collection id "-".
        /// Refer to [List
        /// Sub-Collections](https://cloud.google.com/apis/design/design_patterns#list_sub-collections).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Agent"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchAgentsResponse, Agent> SearchAgentsAsync(SearchAgentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchAgentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchAgentsRequest, SearchAgentsResponse, Agent>(_callSearchAgents, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>TrainAgent</c>.</summary>
        public override lro::OperationsClient TrainAgentOperationsClient { get; }

        /// <summary>
        /// Trains the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, wkt::Struct> TrainAgent(TrainAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TrainAgentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, wkt::Struct>(_callTrainAgent.Sync(request, callSettings), TrainAgentOperationsClient);
        }

        /// <summary>
        /// Trains the specified agent.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> TrainAgentAsync(TrainAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TrainAgentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, wkt::Struct>(await _callTrainAgent.Async(request, callSettings).ConfigureAwait(false), TrainAgentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ExportAgent</c>.</summary>
        public override lro::OperationsClient ExportAgentOperationsClient { get; }

        /// <summary>
        /// Exports the specified agent to a ZIP file.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`:
        /// [ExportAgentResponse][google.cloud.dialogflow.v2.ExportAgentResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ExportAgentResponse, wkt::Struct> ExportAgent(ExportAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportAgentRequest(ref request, ref callSettings);
            return new lro::Operation<ExportAgentResponse, wkt::Struct>(_callExportAgent.Sync(request, callSettings), ExportAgentOperationsClient);
        }

        /// <summary>
        /// Exports the specified agent to a ZIP file.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`:
        /// [ExportAgentResponse][google.cloud.dialogflow.v2.ExportAgentResponse]
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ExportAgentResponse, wkt::Struct>> ExportAgentAsync(ExportAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportAgentRequest(ref request, ref callSettings);
            return new lro::Operation<ExportAgentResponse, wkt::Struct>(await _callExportAgent.Async(request, callSettings).ConfigureAwait(false), ExportAgentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ImportAgent</c>.</summary>
        public override lro::OperationsClient ImportAgentOperationsClient { get; }

        /// <summary>
        /// Imports the specified agent from a ZIP file.
        /// 
        /// Uploads new intents and entity types without deleting the existing ones.
        /// Intents and entity types with the same name are replaced with the new
        /// versions from
        /// [ImportAgentRequest][google.cloud.dialogflow.v2.ImportAgentRequest]. After
        /// the import, the imported draft agent will be trained automatically (unless
        /// disabled in agent settings). However, once the import is done, training may
        /// not be completed yet. Please call
        /// [TrainAgent][google.cloud.dialogflow.v2.Agents.TrainAgent] and wait for the
        /// operation it returns in order to train explicitly.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// The operation only tracks when importing is complete, not when it is done
        /// training.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, wkt::Struct> ImportAgent(ImportAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportAgentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, wkt::Struct>(_callImportAgent.Sync(request, callSettings), ImportAgentOperationsClient);
        }

        /// <summary>
        /// Imports the specified agent from a ZIP file.
        /// 
        /// Uploads new intents and entity types without deleting the existing ones.
        /// Intents and entity types with the same name are replaced with the new
        /// versions from
        /// [ImportAgentRequest][google.cloud.dialogflow.v2.ImportAgentRequest]. After
        /// the import, the imported draft agent will be trained automatically (unless
        /// disabled in agent settings). However, once the import is done, training may
        /// not be completed yet. Please call
        /// [TrainAgent][google.cloud.dialogflow.v2.Agents.TrainAgent] and wait for the
        /// operation it returns in order to train explicitly.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// The operation only tracks when importing is complete, not when it is done
        /// training.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> ImportAgentAsync(ImportAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportAgentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, wkt::Struct>(await _callImportAgent.Async(request, callSettings).ConfigureAwait(false), ImportAgentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>RestoreAgent</c>.</summary>
        public override lro::OperationsClient RestoreAgentOperationsClient { get; }

        /// <summary>
        /// Restores the specified agent from a ZIP file.
        /// 
        /// Replaces the current agent version with a new one. All the intents and
        /// entity types in the older version are deleted. After the restore, the
        /// restored draft agent will be trained automatically (unless disabled in
        /// agent settings). However, once the restore is done, training may not be
        /// completed yet. Please call
        /// [TrainAgent][google.cloud.dialogflow.v2.Agents.TrainAgent] and wait for the
        /// operation it returns in order to train explicitly.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// The operation only tracks when restoring is complete, not when it is done
        /// training.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, wkt::Struct> RestoreAgent(RestoreAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestoreAgentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, wkt::Struct>(_callRestoreAgent.Sync(request, callSettings), RestoreAgentOperationsClient);
        }

        /// <summary>
        /// Restores the specified agent from a ZIP file.
        /// 
        /// Replaces the current agent version with a new one. All the intents and
        /// entity types in the older version are deleted. After the restore, the
        /// restored draft agent will be trained automatically (unless disabled in
        /// agent settings). However, once the restore is done, training may not be
        /// completed yet. Please call
        /// [TrainAgent][google.cloud.dialogflow.v2.Agents.TrainAgent] and wait for the
        /// operation it returns in order to train explicitly.
        /// 
        /// This method is a [long-running
        /// operation](https://cloud.google.com/dialogflow/es/docs/how/long-running-operations).
        /// The returned `Operation` type has the following method-specific fields:
        /// 
        /// - `metadata`: An empty [Struct
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#struct)
        /// - `response`: An [Empty
        /// message](https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#empty)
        /// 
        /// The operation only tracks when restoring is complete, not when it is done
        /// training.
        /// 
        /// Note: You should always train an agent prior to sending it queries. See the
        /// [training
        /// documentation](https://cloud.google.com/dialogflow/es/docs/training).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, wkt::Struct>> RestoreAgentAsync(RestoreAgentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestoreAgentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, wkt::Struct>(await _callRestoreAgent.Async(request, callSettings).ConfigureAwait(false), RestoreAgentOperationsClient);
        }

        /// <summary>
        /// Gets agent validation result. Agent validation is performed during
        /// training time and is updated automatically when training is completed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ValidationResult GetValidationResult(GetValidationResultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetValidationResultRequest(ref request, ref callSettings);
            return _callGetValidationResult.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets agent validation result. Agent validation is performed during
        /// training time and is updated automatically when training is completed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ValidationResult> GetValidationResultAsync(GetValidationResultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetValidationResultRequest(ref request, ref callSettings);
            return _callGetValidationResult.Async(request, callSettings);
        }
    }

    public partial class SearchAgentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchAgentsResponse : gaxgrpc::IPageResponse<Agent>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Agent> GetEnumerator() => Agents.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Agents
    {
        public partial class AgentsClient
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

    public static partial class Agents
    {
        public partial class AgentsClient
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
