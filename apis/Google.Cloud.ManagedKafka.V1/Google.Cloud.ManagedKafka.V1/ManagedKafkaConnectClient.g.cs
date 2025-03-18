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

namespace Google.Cloud.ManagedKafka.V1
{
    /// <summary>Settings for <see cref="ManagedKafkaConnectClient"/> instances.</summary>
    public sealed partial class ManagedKafkaConnectSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ManagedKafkaConnectSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ManagedKafkaConnectSettings"/>.</returns>
        public static ManagedKafkaConnectSettings GetDefault() => new ManagedKafkaConnectSettings();

        /// <summary>Constructs a new <see cref="ManagedKafkaConnectSettings"/> object with default settings.</summary>
        public ManagedKafkaConnectSettings()
        {
        }

        private ManagedKafkaConnectSettings(ManagedKafkaConnectSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListConnectClustersSettings = existing.ListConnectClustersSettings;
            GetConnectClusterSettings = existing.GetConnectClusterSettings;
            CreateConnectClusterSettings = existing.CreateConnectClusterSettings;
            CreateConnectClusterOperationsSettings = existing.CreateConnectClusterOperationsSettings.Clone();
            UpdateConnectClusterSettings = existing.UpdateConnectClusterSettings;
            UpdateConnectClusterOperationsSettings = existing.UpdateConnectClusterOperationsSettings.Clone();
            DeleteConnectClusterSettings = existing.DeleteConnectClusterSettings;
            DeleteConnectClusterOperationsSettings = existing.DeleteConnectClusterOperationsSettings.Clone();
            ListConnectorsSettings = existing.ListConnectorsSettings;
            GetConnectorSettings = existing.GetConnectorSettings;
            CreateConnectorSettings = existing.CreateConnectorSettings;
            UpdateConnectorSettings = existing.UpdateConnectorSettings;
            DeleteConnectorSettings = existing.DeleteConnectorSettings;
            PauseConnectorSettings = existing.PauseConnectorSettings;
            ResumeConnectorSettings = existing.ResumeConnectorSettings;
            RestartConnectorSettings = existing.RestartConnectorSettings;
            StopConnectorSettings = existing.StopConnectorSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ManagedKafkaConnectSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedKafkaConnectClient.ListConnectClusters</c> and
        /// <c>ManagedKafkaConnectClient.ListConnectClustersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListConnectClustersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedKafkaConnectClient.GetConnectCluster</c> and <c>ManagedKafkaConnectClient.GetConnectClusterAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetConnectClusterSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedKafkaConnectClient.CreateConnectCluster</c> and
        /// <c>ManagedKafkaConnectClient.CreateConnectClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateConnectClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ManagedKafkaConnectClient.CreateConnectCluster</c> and
        /// <c>ManagedKafkaConnectClient.CreateConnectClusterAsync</c>.
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
        public lro::OperationsSettings CreateConnectClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedKafkaConnectClient.UpdateConnectCluster</c> and
        /// <c>ManagedKafkaConnectClient.UpdateConnectClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateConnectClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ManagedKafkaConnectClient.UpdateConnectCluster</c> and
        /// <c>ManagedKafkaConnectClient.UpdateConnectClusterAsync</c>.
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
        public lro::OperationsSettings UpdateConnectClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedKafkaConnectClient.DeleteConnectCluster</c> and
        /// <c>ManagedKafkaConnectClient.DeleteConnectClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteConnectClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ManagedKafkaConnectClient.DeleteConnectCluster</c> and
        /// <c>ManagedKafkaConnectClient.DeleteConnectClusterAsync</c>.
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
        public lro::OperationsSettings DeleteConnectClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedKafkaConnectClient.ListConnectors</c> and <c>ManagedKafkaConnectClient.ListConnectorsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListConnectorsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedKafkaConnectClient.GetConnector</c> and <c>ManagedKafkaConnectClient.GetConnectorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetConnectorSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedKafkaConnectClient.CreateConnector</c> and <c>ManagedKafkaConnectClient.CreateConnectorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateConnectorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedKafkaConnectClient.UpdateConnector</c> and <c>ManagedKafkaConnectClient.UpdateConnectorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateConnectorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedKafkaConnectClient.DeleteConnector</c> and <c>ManagedKafkaConnectClient.DeleteConnectorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteConnectorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedKafkaConnectClient.PauseConnector</c> and <c>ManagedKafkaConnectClient.PauseConnectorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PauseConnectorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedKafkaConnectClient.ResumeConnector</c> and <c>ManagedKafkaConnectClient.ResumeConnectorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResumeConnectorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedKafkaConnectClient.RestartConnector</c> and <c>ManagedKafkaConnectClient.RestartConnectorAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RestartConnectorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedKafkaConnectClient.StopConnector</c> and <c>ManagedKafkaConnectClient.StopConnectorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StopConnectorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ManagedKafkaConnectSettings"/> object.</returns>
        public ManagedKafkaConnectSettings Clone() => new ManagedKafkaConnectSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ManagedKafkaConnectClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ManagedKafkaConnectClientBuilder : gaxgrpc::ClientBuilderBase<ManagedKafkaConnectClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ManagedKafkaConnectSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ManagedKafkaConnectClientBuilder() : base(ManagedKafkaConnectClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ManagedKafkaConnectClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ManagedKafkaConnectClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ManagedKafkaConnectClient Build()
        {
            ManagedKafkaConnectClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ManagedKafkaConnectClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ManagedKafkaConnectClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ManagedKafkaConnectClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ManagedKafkaConnectClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ManagedKafkaConnectClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ManagedKafkaConnectClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ManagedKafkaConnectClient.ChannelPool;
    }

    /// <summary>ManagedKafkaConnect client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The service that a client application uses to manage Apache Kafka Connect
    /// clusters and connectors.
    /// </remarks>
    public abstract partial class ManagedKafkaConnectClient
    {
        /// <summary>
        /// The default endpoint for the ManagedKafkaConnect service, which is a host of "managedkafka.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "managedkafka.googleapis.com:443";

        /// <summary>The default ManagedKafkaConnect scopes.</summary>
        /// <remarks>
        /// The default ManagedKafkaConnect scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ManagedKafkaConnect.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ManagedKafkaConnectClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="ManagedKafkaConnectClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ManagedKafkaConnectClient"/>.</returns>
        public static stt::Task<ManagedKafkaConnectClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ManagedKafkaConnectClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ManagedKafkaConnectClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="ManagedKafkaConnectClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ManagedKafkaConnectClient"/>.</returns>
        public static ManagedKafkaConnectClient Create() => new ManagedKafkaConnectClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ManagedKafkaConnectClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ManagedKafkaConnectSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ManagedKafkaConnectClient"/>.</returns>
        internal static ManagedKafkaConnectClient Create(grpccore::CallInvoker callInvoker, ManagedKafkaConnectSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ManagedKafkaConnect.ManagedKafkaConnectClient grpcClient = new ManagedKafkaConnect.ManagedKafkaConnectClient(callInvoker);
            return new ManagedKafkaConnectClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ManagedKafkaConnect client</summary>
        public virtual ManagedKafkaConnect.ManagedKafkaConnectClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the Kafka Connect clusters in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ConnectCluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConnectClustersResponse, ConnectCluster> ListConnectClusters(ListConnectClustersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the Kafka Connect clusters in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ConnectCluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConnectClustersResponse, ConnectCluster> ListConnectClustersAsync(ListConnectClustersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the Kafka Connect clusters in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project/location whose Connect clusters are to be
        /// listed. Structured like `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="ConnectCluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConnectClustersResponse, ConnectCluster> ListConnectClusters(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectClustersRequest request = new ListConnectClustersRequest
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
            return ListConnectClusters(request, callSettings);
        }

        /// <summary>
        /// Lists the Kafka Connect clusters in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project/location whose Connect clusters are to be
        /// listed. Structured like `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ConnectCluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConnectClustersResponse, ConnectCluster> ListConnectClustersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectClustersRequest request = new ListConnectClustersRequest
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
            return ListConnectClustersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the Kafka Connect clusters in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project/location whose Connect clusters are to be
        /// listed. Structured like `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="ConnectCluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConnectClustersResponse, ConnectCluster> ListConnectClusters(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectClustersRequest request = new ListConnectClustersRequest
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
            return ListConnectClusters(request, callSettings);
        }

        /// <summary>
        /// Lists the Kafka Connect clusters in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project/location whose Connect clusters are to be
        /// listed. Structured like `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ConnectCluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConnectClustersResponse, ConnectCluster> ListConnectClustersAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectClustersRequest request = new ListConnectClustersRequest
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
            return ListConnectClustersAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the properties of a single Kafka Connect cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConnectCluster GetConnectCluster(GetConnectClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the properties of a single Kafka Connect cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectCluster> GetConnectClusterAsync(GetConnectClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the properties of a single Kafka Connect cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectCluster> GetConnectClusterAsync(GetConnectClusterRequest request, st::CancellationToken cancellationToken) =>
            GetConnectClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the properties of a single Kafka Connect cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Kafka Connect cluster whose configuration to
        /// return. Structured like
        /// `projects/{project}/locations/{location}/connectClusters/{connect_cluster_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConnectCluster GetConnectCluster(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectCluster(new GetConnectClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the properties of a single Kafka Connect cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Kafka Connect cluster whose configuration to
        /// return. Structured like
        /// `projects/{project}/locations/{location}/connectClusters/{connect_cluster_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectCluster> GetConnectClusterAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectClusterAsync(new GetConnectClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the properties of a single Kafka Connect cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Kafka Connect cluster whose configuration to
        /// return. Structured like
        /// `projects/{project}/locations/{location}/connectClusters/{connect_cluster_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectCluster> GetConnectClusterAsync(string name, st::CancellationToken cancellationToken) =>
            GetConnectClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the properties of a single Kafka Connect cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Kafka Connect cluster whose configuration to
        /// return. Structured like
        /// `projects/{project}/locations/{location}/connectClusters/{connect_cluster_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConnectCluster GetConnectCluster(ConnectClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectCluster(new GetConnectClusterRequest
            {
                ConnectClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the properties of a single Kafka Connect cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Kafka Connect cluster whose configuration to
        /// return. Structured like
        /// `projects/{project}/locations/{location}/connectClusters/{connect_cluster_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectCluster> GetConnectClusterAsync(ConnectClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectClusterAsync(new GetConnectClusterRequest
            {
                ConnectClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the properties of a single Kafka Connect cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Kafka Connect cluster whose configuration to
        /// return. Structured like
        /// `projects/{project}/locations/{location}/connectClusters/{connect_cluster_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConnectCluster> GetConnectClusterAsync(ConnectClusterName name, st::CancellationToken cancellationToken) =>
            GetConnectClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Kafka Connect cluster in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConnectCluster, OperationMetadata> CreateConnectCluster(CreateConnectClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Kafka Connect cluster in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectCluster, OperationMetadata>> CreateConnectClusterAsync(CreateConnectClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Kafka Connect cluster in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectCluster, OperationMetadata>> CreateConnectClusterAsync(CreateConnectClusterRequest request, st::CancellationToken cancellationToken) =>
            CreateConnectClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateConnectCluster</c>.</summary>
        public virtual lro::OperationsClient CreateConnectClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateConnectCluster</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ConnectCluster, OperationMetadata> PollOnceCreateConnectCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConnectCluster, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateConnectClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateConnectCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ConnectCluster, OperationMetadata>> PollOnceCreateConnectClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConnectCluster, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateConnectClusterOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Kafka Connect cluster in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project/location in which to create the Kafka Connect
        /// cluster. Structured like
        /// `projects/{project}/locations/{location}/`.
        /// </param>
        /// <param name="connectCluster">
        /// Required. Configuration of the Kafka Connect cluster to create. Its `name`
        /// field is ignored.
        /// </param>
        /// <param name="connectClusterId">
        /// Required. The ID to use for the Connect cluster, which will become the
        /// final component of the cluster's name. The ID must be 1-63 characters long,
        /// and match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?` to comply
        /// with RFC 1035.
        /// 
        /// This value is structured like: `my-cluster-id`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConnectCluster, OperationMetadata> CreateConnectCluster(string parent, ConnectCluster connectCluster, string connectClusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnectCluster(new CreateConnectClusterRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ConnectClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(connectClusterId, nameof(connectClusterId)),
                ConnectCluster = gax::GaxPreconditions.CheckNotNull(connectCluster, nameof(connectCluster)),
            }, callSettings);

        /// <summary>
        /// Creates a new Kafka Connect cluster in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project/location in which to create the Kafka Connect
        /// cluster. Structured like
        /// `projects/{project}/locations/{location}/`.
        /// </param>
        /// <param name="connectCluster">
        /// Required. Configuration of the Kafka Connect cluster to create. Its `name`
        /// field is ignored.
        /// </param>
        /// <param name="connectClusterId">
        /// Required. The ID to use for the Connect cluster, which will become the
        /// final component of the cluster's name. The ID must be 1-63 characters long,
        /// and match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?` to comply
        /// with RFC 1035.
        /// 
        /// This value is structured like: `my-cluster-id`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectCluster, OperationMetadata>> CreateConnectClusterAsync(string parent, ConnectCluster connectCluster, string connectClusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnectClusterAsync(new CreateConnectClusterRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ConnectClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(connectClusterId, nameof(connectClusterId)),
                ConnectCluster = gax::GaxPreconditions.CheckNotNull(connectCluster, nameof(connectCluster)),
            }, callSettings);

        /// <summary>
        /// Creates a new Kafka Connect cluster in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project/location in which to create the Kafka Connect
        /// cluster. Structured like
        /// `projects/{project}/locations/{location}/`.
        /// </param>
        /// <param name="connectCluster">
        /// Required. Configuration of the Kafka Connect cluster to create. Its `name`
        /// field is ignored.
        /// </param>
        /// <param name="connectClusterId">
        /// Required. The ID to use for the Connect cluster, which will become the
        /// final component of the cluster's name. The ID must be 1-63 characters long,
        /// and match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?` to comply
        /// with RFC 1035.
        /// 
        /// This value is structured like: `my-cluster-id`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectCluster, OperationMetadata>> CreateConnectClusterAsync(string parent, ConnectCluster connectCluster, string connectClusterId, st::CancellationToken cancellationToken) =>
            CreateConnectClusterAsync(parent, connectCluster, connectClusterId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Kafka Connect cluster in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project/location in which to create the Kafka Connect
        /// cluster. Structured like
        /// `projects/{project}/locations/{location}/`.
        /// </param>
        /// <param name="connectCluster">
        /// Required. Configuration of the Kafka Connect cluster to create. Its `name`
        /// field is ignored.
        /// </param>
        /// <param name="connectClusterId">
        /// Required. The ID to use for the Connect cluster, which will become the
        /// final component of the cluster's name. The ID must be 1-63 characters long,
        /// and match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?` to comply
        /// with RFC 1035.
        /// 
        /// This value is structured like: `my-cluster-id`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConnectCluster, OperationMetadata> CreateConnectCluster(gagr::LocationName parent, ConnectCluster connectCluster, string connectClusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnectCluster(new CreateConnectClusterRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ConnectClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(connectClusterId, nameof(connectClusterId)),
                ConnectCluster = gax::GaxPreconditions.CheckNotNull(connectCluster, nameof(connectCluster)),
            }, callSettings);

        /// <summary>
        /// Creates a new Kafka Connect cluster in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project/location in which to create the Kafka Connect
        /// cluster. Structured like
        /// `projects/{project}/locations/{location}/`.
        /// </param>
        /// <param name="connectCluster">
        /// Required. Configuration of the Kafka Connect cluster to create. Its `name`
        /// field is ignored.
        /// </param>
        /// <param name="connectClusterId">
        /// Required. The ID to use for the Connect cluster, which will become the
        /// final component of the cluster's name. The ID must be 1-63 characters long,
        /// and match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?` to comply
        /// with RFC 1035.
        /// 
        /// This value is structured like: `my-cluster-id`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectCluster, OperationMetadata>> CreateConnectClusterAsync(gagr::LocationName parent, ConnectCluster connectCluster, string connectClusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnectClusterAsync(new CreateConnectClusterRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ConnectClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(connectClusterId, nameof(connectClusterId)),
                ConnectCluster = gax::GaxPreconditions.CheckNotNull(connectCluster, nameof(connectCluster)),
            }, callSettings);

        /// <summary>
        /// Creates a new Kafka Connect cluster in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent project/location in which to create the Kafka Connect
        /// cluster. Structured like
        /// `projects/{project}/locations/{location}/`.
        /// </param>
        /// <param name="connectCluster">
        /// Required. Configuration of the Kafka Connect cluster to create. Its `name`
        /// field is ignored.
        /// </param>
        /// <param name="connectClusterId">
        /// Required. The ID to use for the Connect cluster, which will become the
        /// final component of the cluster's name. The ID must be 1-63 characters long,
        /// and match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?` to comply
        /// with RFC 1035.
        /// 
        /// This value is structured like: `my-cluster-id`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectCluster, OperationMetadata>> CreateConnectClusterAsync(gagr::LocationName parent, ConnectCluster connectCluster, string connectClusterId, st::CancellationToken cancellationToken) =>
            CreateConnectClusterAsync(parent, connectCluster, connectClusterId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the properties of a single Kafka Connect cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConnectCluster, OperationMetadata> UpdateConnectCluster(UpdateConnectClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the properties of a single Kafka Connect cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectCluster, OperationMetadata>> UpdateConnectClusterAsync(UpdateConnectClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the properties of a single Kafka Connect cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectCluster, OperationMetadata>> UpdateConnectClusterAsync(UpdateConnectClusterRequest request, st::CancellationToken cancellationToken) =>
            UpdateConnectClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateConnectCluster</c>.</summary>
        public virtual lro::OperationsClient UpdateConnectClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateConnectCluster</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ConnectCluster, OperationMetadata> PollOnceUpdateConnectCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConnectCluster, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateConnectClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateConnectCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ConnectCluster, OperationMetadata>> PollOnceUpdateConnectClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ConnectCluster, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateConnectClusterOperationsClient, callSettings);

        /// <summary>
        /// Updates the properties of a single Kafka Connect cluster.
        /// </summary>
        /// <param name="connectCluster">
        /// Required. The Kafka Connect cluster to update. Its `name` field must be
        /// populated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// cluster resource by the update. The fields specified in the update_mask are
        /// relative to the resource, not the full request. A field will be overwritten
        /// if it is in the mask. The mask is required and a value of * will update all
        /// fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ConnectCluster, OperationMetadata> UpdateConnectCluster(ConnectCluster connectCluster, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConnectCluster(new UpdateConnectClusterRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                ConnectCluster = gax::GaxPreconditions.CheckNotNull(connectCluster, nameof(connectCluster)),
            }, callSettings);

        /// <summary>
        /// Updates the properties of a single Kafka Connect cluster.
        /// </summary>
        /// <param name="connectCluster">
        /// Required. The Kafka Connect cluster to update. Its `name` field must be
        /// populated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// cluster resource by the update. The fields specified in the update_mask are
        /// relative to the resource, not the full request. A field will be overwritten
        /// if it is in the mask. The mask is required and a value of * will update all
        /// fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectCluster, OperationMetadata>> UpdateConnectClusterAsync(ConnectCluster connectCluster, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConnectClusterAsync(new UpdateConnectClusterRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                ConnectCluster = gax::GaxPreconditions.CheckNotNull(connectCluster, nameof(connectCluster)),
            }, callSettings);

        /// <summary>
        /// Updates the properties of a single Kafka Connect cluster.
        /// </summary>
        /// <param name="connectCluster">
        /// Required. The Kafka Connect cluster to update. Its `name` field must be
        /// populated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// cluster resource by the update. The fields specified in the update_mask are
        /// relative to the resource, not the full request. A field will be overwritten
        /// if it is in the mask. The mask is required and a value of * will update all
        /// fields.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ConnectCluster, OperationMetadata>> UpdateConnectClusterAsync(ConnectCluster connectCluster, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateConnectClusterAsync(connectCluster, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Connect cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteConnectCluster(DeleteConnectClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Connect cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectClusterAsync(DeleteConnectClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Connect cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectClusterAsync(DeleteConnectClusterRequest request, st::CancellationToken cancellationToken) =>
            DeleteConnectClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteConnectCluster</c>.</summary>
        public virtual lro::OperationsClient DeleteConnectClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteConnectCluster</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteConnectCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteConnectClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteConnectCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteConnectClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteConnectClusterOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Connect cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Kafka Connect cluster to delete.
        /// Structured like
        /// `projects/{project}/locations/{location}/connectClusters/{connect_cluster_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteConnectCluster(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnectCluster(new DeleteConnectClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Connect cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Kafka Connect cluster to delete.
        /// Structured like
        /// `projects/{project}/locations/{location}/connectClusters/{connect_cluster_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectClusterAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnectClusterAsync(new DeleteConnectClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Connect cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Kafka Connect cluster to delete.
        /// Structured like
        /// `projects/{project}/locations/{location}/connectClusters/{connect_cluster_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectClusterAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteConnectClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Connect cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Kafka Connect cluster to delete.
        /// Structured like
        /// `projects/{project}/locations/{location}/connectClusters/{connect_cluster_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteConnectCluster(ConnectClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnectCluster(new DeleteConnectClusterRequest
            {
                ConnectClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Connect cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Kafka Connect cluster to delete.
        /// Structured like
        /// `projects/{project}/locations/{location}/connectClusters/{connect_cluster_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectClusterAsync(ConnectClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnectClusterAsync(new DeleteConnectClusterRequest
            {
                ConnectClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Connect cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Kafka Connect cluster to delete.
        /// Structured like
        /// `projects/{project}/locations/{location}/connectClusters/{connect_cluster_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectClusterAsync(ConnectClusterName name, st::CancellationToken cancellationToken) =>
            DeleteConnectClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the connectors in a given Connect cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Connector"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConnectorsResponse, Connector> ListConnectors(ListConnectorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the connectors in a given Connect cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Connector"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConnectorsResponse, Connector> ListConnectorsAsync(ListConnectorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the connectors in a given Connect cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent Connect cluster whose connectors are to be listed.
        /// Structured like
        /// `projects/{project}/locations/{location}/connectClusters/{connect_cluster_id}`.
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
        /// Lists the connectors in a given Connect cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent Connect cluster whose connectors are to be listed.
        /// Structured like
        /// `projects/{project}/locations/{location}/connectClusters/{connect_cluster_id}`.
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
        /// Lists the connectors in a given Connect cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent Connect cluster whose connectors are to be listed.
        /// Structured like
        /// `projects/{project}/locations/{location}/connectClusters/{connect_cluster_id}`.
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
        public virtual gax::PagedEnumerable<ListConnectorsResponse, Connector> ListConnectors(ConnectClusterName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectorsRequest request = new ListConnectorsRequest
            {
                ParentAsConnectClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Lists the connectors in a given Connect cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent Connect cluster whose connectors are to be listed.
        /// Structured like
        /// `projects/{project}/locations/{location}/connectClusters/{connect_cluster_id}`.
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
        public virtual gax::PagedAsyncEnumerable<ListConnectorsResponse, Connector> ListConnectorsAsync(ConnectClusterName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectorsRequest request = new ListConnectorsRequest
            {
                ParentAsConnectClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Returns the properties of a single connector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Connector GetConnector(GetConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the properties of a single connector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connector> GetConnectorAsync(GetConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the properties of a single connector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connector> GetConnectorAsync(GetConnectorRequest request, st::CancellationToken cancellationToken) =>
            GetConnectorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the properties of a single connector.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connector whose configuration to return.
        /// Structured like:
        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Connector GetConnector(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnector(new GetConnectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the properties of a single connector.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connector whose configuration to return.
        /// Structured like:
        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connector> GetConnectorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectorAsync(new GetConnectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the properties of a single connector.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connector whose configuration to return.
        /// Structured like:
        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connector> GetConnectorAsync(string name, st::CancellationToken cancellationToken) =>
            GetConnectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the properties of a single connector.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connector whose configuration to return.
        /// Structured like:
        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Connector GetConnector(ConnectorName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnector(new GetConnectorRequest
            {
                ConnectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the properties of a single connector.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connector whose configuration to return.
        /// Structured like:
        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connector> GetConnectorAsync(ConnectorName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectorAsync(new GetConnectorRequest
            {
                ConnectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the properties of a single connector.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connector whose configuration to return.
        /// Structured like:
        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connector> GetConnectorAsync(ConnectorName name, st::CancellationToken cancellationToken) =>
            GetConnectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new connector in a given Connect cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Connector CreateConnector(CreateConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new connector in a given Connect cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connector> CreateConnectorAsync(CreateConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new connector in a given Connect cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connector> CreateConnectorAsync(CreateConnectorRequest request, st::CancellationToken cancellationToken) =>
            CreateConnectorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new connector in a given Connect cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent Connect cluster in which to create the connector.
        /// Structured like
        /// `projects/{project}/locations/{location}/connectClusters/{connect_cluster_id}`.
        /// </param>
        /// <param name="connector">
        /// Required. The connector to create.
        /// </param>
        /// <param name="connectorId">
        /// Required. The ID to use for the connector, which will become the final
        /// component of the connector's name. The ID must be 1-63 characters long, and
        /// match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?` to comply with
        /// RFC 1035.
        /// 
        /// This value is structured like: `my-connector-id`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Connector CreateConnector(string parent, Connector connector, string connectorId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnector(new CreateConnectorRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ConnectorId = gax::GaxPreconditions.CheckNotNullOrEmpty(connectorId, nameof(connectorId)),
                Connector = gax::GaxPreconditions.CheckNotNull(connector, nameof(connector)),
            }, callSettings);

        /// <summary>
        /// Creates a new connector in a given Connect cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent Connect cluster in which to create the connector.
        /// Structured like
        /// `projects/{project}/locations/{location}/connectClusters/{connect_cluster_id}`.
        /// </param>
        /// <param name="connector">
        /// Required. The connector to create.
        /// </param>
        /// <param name="connectorId">
        /// Required. The ID to use for the connector, which will become the final
        /// component of the connector's name. The ID must be 1-63 characters long, and
        /// match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?` to comply with
        /// RFC 1035.
        /// 
        /// This value is structured like: `my-connector-id`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connector> CreateConnectorAsync(string parent, Connector connector, string connectorId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnectorAsync(new CreateConnectorRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ConnectorId = gax::GaxPreconditions.CheckNotNullOrEmpty(connectorId, nameof(connectorId)),
                Connector = gax::GaxPreconditions.CheckNotNull(connector, nameof(connector)),
            }, callSettings);

        /// <summary>
        /// Creates a new connector in a given Connect cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent Connect cluster in which to create the connector.
        /// Structured like
        /// `projects/{project}/locations/{location}/connectClusters/{connect_cluster_id}`.
        /// </param>
        /// <param name="connector">
        /// Required. The connector to create.
        /// </param>
        /// <param name="connectorId">
        /// Required. The ID to use for the connector, which will become the final
        /// component of the connector's name. The ID must be 1-63 characters long, and
        /// match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?` to comply with
        /// RFC 1035.
        /// 
        /// This value is structured like: `my-connector-id`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connector> CreateConnectorAsync(string parent, Connector connector, string connectorId, st::CancellationToken cancellationToken) =>
            CreateConnectorAsync(parent, connector, connectorId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new connector in a given Connect cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent Connect cluster in which to create the connector.
        /// Structured like
        /// `projects/{project}/locations/{location}/connectClusters/{connect_cluster_id}`.
        /// </param>
        /// <param name="connector">
        /// Required. The connector to create.
        /// </param>
        /// <param name="connectorId">
        /// Required. The ID to use for the connector, which will become the final
        /// component of the connector's name. The ID must be 1-63 characters long, and
        /// match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?` to comply with
        /// RFC 1035.
        /// 
        /// This value is structured like: `my-connector-id`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Connector CreateConnector(ConnectClusterName parent, Connector connector, string connectorId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnector(new CreateConnectorRequest
            {
                ParentAsConnectClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ConnectorId = gax::GaxPreconditions.CheckNotNullOrEmpty(connectorId, nameof(connectorId)),
                Connector = gax::GaxPreconditions.CheckNotNull(connector, nameof(connector)),
            }, callSettings);

        /// <summary>
        /// Creates a new connector in a given Connect cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent Connect cluster in which to create the connector.
        /// Structured like
        /// `projects/{project}/locations/{location}/connectClusters/{connect_cluster_id}`.
        /// </param>
        /// <param name="connector">
        /// Required. The connector to create.
        /// </param>
        /// <param name="connectorId">
        /// Required. The ID to use for the connector, which will become the final
        /// component of the connector's name. The ID must be 1-63 characters long, and
        /// match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?` to comply with
        /// RFC 1035.
        /// 
        /// This value is structured like: `my-connector-id`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connector> CreateConnectorAsync(ConnectClusterName parent, Connector connector, string connectorId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnectorAsync(new CreateConnectorRequest
            {
                ParentAsConnectClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ConnectorId = gax::GaxPreconditions.CheckNotNullOrEmpty(connectorId, nameof(connectorId)),
                Connector = gax::GaxPreconditions.CheckNotNull(connector, nameof(connector)),
            }, callSettings);

        /// <summary>
        /// Creates a new connector in a given Connect cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent Connect cluster in which to create the connector.
        /// Structured like
        /// `projects/{project}/locations/{location}/connectClusters/{connect_cluster_id}`.
        /// </param>
        /// <param name="connector">
        /// Required. The connector to create.
        /// </param>
        /// <param name="connectorId">
        /// Required. The ID to use for the connector, which will become the final
        /// component of the connector's name. The ID must be 1-63 characters long, and
        /// match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?` to comply with
        /// RFC 1035.
        /// 
        /// This value is structured like: `my-connector-id`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connector> CreateConnectorAsync(ConnectClusterName parent, Connector connector, string connectorId, st::CancellationToken cancellationToken) =>
            CreateConnectorAsync(parent, connector, connectorId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the properties of a connector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Connector UpdateConnector(UpdateConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the properties of a connector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connector> UpdateConnectorAsync(UpdateConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the properties of a connector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connector> UpdateConnectorAsync(UpdateConnectorRequest request, st::CancellationToken cancellationToken) =>
            UpdateConnectorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the properties of a connector.
        /// </summary>
        /// <param name="connector">
        /// Required. The connector to update. Its `name` field must be populated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// cluster resource by the update. The fields specified in the update_mask are
        /// relative to the resource, not the full request. A field will be overwritten
        /// if it is in the mask. The mask is required and a value of * will update all
        /// fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Connector UpdateConnector(Connector connector, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConnector(new UpdateConnectorRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Connector = gax::GaxPreconditions.CheckNotNull(connector, nameof(connector)),
            }, callSettings);

        /// <summary>
        /// Updates the properties of a connector.
        /// </summary>
        /// <param name="connector">
        /// Required. The connector to update. Its `name` field must be populated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// cluster resource by the update. The fields specified in the update_mask are
        /// relative to the resource, not the full request. A field will be overwritten
        /// if it is in the mask. The mask is required and a value of * will update all
        /// fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connector> UpdateConnectorAsync(Connector connector, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConnectorAsync(new UpdateConnectorRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Connector = gax::GaxPreconditions.CheckNotNull(connector, nameof(connector)),
            }, callSettings);

        /// <summary>
        /// Updates the properties of a connector.
        /// </summary>
        /// <param name="connector">
        /// Required. The connector to update. Its `name` field must be populated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// cluster resource by the update. The fields specified in the update_mask are
        /// relative to the resource, not the full request. A field will be overwritten
        /// if it is in the mask. The mask is required and a value of * will update all
        /// fields.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connector> UpdateConnectorAsync(Connector connector, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateConnectorAsync(connector, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a connector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteConnector(DeleteConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a connector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConnectorAsync(DeleteConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a connector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConnectorAsync(DeleteConnectorRequest request, st::CancellationToken cancellationToken) =>
            DeleteConnectorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a connector.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connector to delete.
        /// Structured like:
        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteConnector(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnector(new DeleteConnectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a connector.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connector to delete.
        /// Structured like:
        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConnectorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnectorAsync(new DeleteConnectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a connector.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connector to delete.
        /// Structured like:
        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConnectorAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteConnectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a connector.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connector to delete.
        /// Structured like:
        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteConnector(ConnectorName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnector(new DeleteConnectorRequest
            {
                ConnectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a connector.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connector to delete.
        /// Structured like:
        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConnectorAsync(ConnectorName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnectorAsync(new DeleteConnectorRequest
            {
                ConnectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a connector.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connector to delete.
        /// Structured like:
        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConnectorAsync(ConnectorName name, st::CancellationToken cancellationToken) =>
            DeleteConnectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Pauses the connector and its tasks.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PauseConnectorResponse PauseConnector(PauseConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Pauses the connector and its tasks.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PauseConnectorResponse> PauseConnectorAsync(PauseConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Pauses the connector and its tasks.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PauseConnectorResponse> PauseConnectorAsync(PauseConnectorRequest request, st::CancellationToken cancellationToken) =>
            PauseConnectorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Pauses the connector and its tasks.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connector to pause.
        /// Structured like:
        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PauseConnectorResponse PauseConnector(string name, gaxgrpc::CallSettings callSettings = null) =>
            PauseConnector(new PauseConnectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Pauses the connector and its tasks.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connector to pause.
        /// Structured like:
        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PauseConnectorResponse> PauseConnectorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            PauseConnectorAsync(new PauseConnectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Pauses the connector and its tasks.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connector to pause.
        /// Structured like:
        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PauseConnectorResponse> PauseConnectorAsync(string name, st::CancellationToken cancellationToken) =>
            PauseConnectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Pauses the connector and its tasks.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connector to pause.
        /// Structured like:
        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PauseConnectorResponse PauseConnector(ConnectorName name, gaxgrpc::CallSettings callSettings = null) =>
            PauseConnector(new PauseConnectorRequest
            {
                ConnectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Pauses the connector and its tasks.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connector to pause.
        /// Structured like:
        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PauseConnectorResponse> PauseConnectorAsync(ConnectorName name, gaxgrpc::CallSettings callSettings = null) =>
            PauseConnectorAsync(new PauseConnectorRequest
            {
                ConnectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Pauses the connector and its tasks.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connector to pause.
        /// Structured like:
        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PauseConnectorResponse> PauseConnectorAsync(ConnectorName name, st::CancellationToken cancellationToken) =>
            PauseConnectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resumes the connector and its tasks.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ResumeConnectorResponse ResumeConnector(ResumeConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resumes the connector and its tasks.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResumeConnectorResponse> ResumeConnectorAsync(ResumeConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resumes the connector and its tasks.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResumeConnectorResponse> ResumeConnectorAsync(ResumeConnectorRequest request, st::CancellationToken cancellationToken) =>
            ResumeConnectorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resumes the connector and its tasks.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connector to pause.
        /// Structured like:
        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ResumeConnectorResponse ResumeConnector(string name, gaxgrpc::CallSettings callSettings = null) =>
            ResumeConnector(new ResumeConnectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Resumes the connector and its tasks.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connector to pause.
        /// Structured like:
        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResumeConnectorResponse> ResumeConnectorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ResumeConnectorAsync(new ResumeConnectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Resumes the connector and its tasks.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connector to pause.
        /// Structured like:
        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResumeConnectorResponse> ResumeConnectorAsync(string name, st::CancellationToken cancellationToken) =>
            ResumeConnectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resumes the connector and its tasks.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connector to pause.
        /// Structured like:
        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ResumeConnectorResponse ResumeConnector(ConnectorName name, gaxgrpc::CallSettings callSettings = null) =>
            ResumeConnector(new ResumeConnectorRequest
            {
                ConnectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Resumes the connector and its tasks.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connector to pause.
        /// Structured like:
        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResumeConnectorResponse> ResumeConnectorAsync(ConnectorName name, gaxgrpc::CallSettings callSettings = null) =>
            ResumeConnectorAsync(new ResumeConnectorRequest
            {
                ConnectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Resumes the connector and its tasks.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connector to pause.
        /// Structured like:
        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResumeConnectorResponse> ResumeConnectorAsync(ConnectorName name, st::CancellationToken cancellationToken) =>
            ResumeConnectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Restarts the connector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RestartConnectorResponse RestartConnector(RestartConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restarts the connector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RestartConnectorResponse> RestartConnectorAsync(RestartConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restarts the connector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RestartConnectorResponse> RestartConnectorAsync(RestartConnectorRequest request, st::CancellationToken cancellationToken) =>
            RestartConnectorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Restarts the connector.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connector to restart.
        /// Structured like:
        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RestartConnectorResponse RestartConnector(string name, gaxgrpc::CallSettings callSettings = null) =>
            RestartConnector(new RestartConnectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Restarts the connector.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connector to restart.
        /// Structured like:
        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RestartConnectorResponse> RestartConnectorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            RestartConnectorAsync(new RestartConnectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Restarts the connector.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connector to restart.
        /// Structured like:
        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RestartConnectorResponse> RestartConnectorAsync(string name, st::CancellationToken cancellationToken) =>
            RestartConnectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Restarts the connector.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connector to restart.
        /// Structured like:
        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RestartConnectorResponse RestartConnector(ConnectorName name, gaxgrpc::CallSettings callSettings = null) =>
            RestartConnector(new RestartConnectorRequest
            {
                ConnectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Restarts the connector.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connector to restart.
        /// Structured like:
        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RestartConnectorResponse> RestartConnectorAsync(ConnectorName name, gaxgrpc::CallSettings callSettings = null) =>
            RestartConnectorAsync(new RestartConnectorRequest
            {
                ConnectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Restarts the connector.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connector to restart.
        /// Structured like:
        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RestartConnectorResponse> RestartConnectorAsync(ConnectorName name, st::CancellationToken cancellationToken) =>
            RestartConnectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Stops the connector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StopConnectorResponse StopConnector(StopConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops the connector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StopConnectorResponse> StopConnectorAsync(StopConnectorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops the connector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StopConnectorResponse> StopConnectorAsync(StopConnectorRequest request, st::CancellationToken cancellationToken) =>
            StopConnectorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Stops the connector.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connector to stop.
        /// Structured like:
        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StopConnectorResponse StopConnector(string name, gaxgrpc::CallSettings callSettings = null) =>
            StopConnector(new StopConnectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stops the connector.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connector to stop.
        /// Structured like:
        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StopConnectorResponse> StopConnectorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            StopConnectorAsync(new StopConnectorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stops the connector.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connector to stop.
        /// Structured like:
        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StopConnectorResponse> StopConnectorAsync(string name, st::CancellationToken cancellationToken) =>
            StopConnectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Stops the connector.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connector to stop.
        /// Structured like:
        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StopConnectorResponse StopConnector(ConnectorName name, gaxgrpc::CallSettings callSettings = null) =>
            StopConnector(new StopConnectorRequest
            {
                ConnectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stops the connector.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connector to stop.
        /// Structured like:
        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StopConnectorResponse> StopConnectorAsync(ConnectorName name, gaxgrpc::CallSettings callSettings = null) =>
            StopConnectorAsync(new StopConnectorRequest
            {
                ConnectorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stops the connector.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the connector to stop.
        /// Structured like:
        /// projects/{project}/locations/{location}/connectClusters/{connectCluster}/connectors/{connector}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StopConnectorResponse> StopConnectorAsync(ConnectorName name, st::CancellationToken cancellationToken) =>
            StopConnectorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ManagedKafkaConnect client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The service that a client application uses to manage Apache Kafka Connect
    /// clusters and connectors.
    /// </remarks>
    public sealed partial class ManagedKafkaConnectClientImpl : ManagedKafkaConnectClient
    {
        private readonly gaxgrpc::ApiCall<ListConnectClustersRequest, ListConnectClustersResponse> _callListConnectClusters;

        private readonly gaxgrpc::ApiCall<GetConnectClusterRequest, ConnectCluster> _callGetConnectCluster;

        private readonly gaxgrpc::ApiCall<CreateConnectClusterRequest, lro::Operation> _callCreateConnectCluster;

        private readonly gaxgrpc::ApiCall<UpdateConnectClusterRequest, lro::Operation> _callUpdateConnectCluster;

        private readonly gaxgrpc::ApiCall<DeleteConnectClusterRequest, lro::Operation> _callDeleteConnectCluster;

        private readonly gaxgrpc::ApiCall<ListConnectorsRequest, ListConnectorsResponse> _callListConnectors;

        private readonly gaxgrpc::ApiCall<GetConnectorRequest, Connector> _callGetConnector;

        private readonly gaxgrpc::ApiCall<CreateConnectorRequest, Connector> _callCreateConnector;

        private readonly gaxgrpc::ApiCall<UpdateConnectorRequest, Connector> _callUpdateConnector;

        private readonly gaxgrpc::ApiCall<DeleteConnectorRequest, wkt::Empty> _callDeleteConnector;

        private readonly gaxgrpc::ApiCall<PauseConnectorRequest, PauseConnectorResponse> _callPauseConnector;

        private readonly gaxgrpc::ApiCall<ResumeConnectorRequest, ResumeConnectorResponse> _callResumeConnector;

        private readonly gaxgrpc::ApiCall<RestartConnectorRequest, RestartConnectorResponse> _callRestartConnector;

        private readonly gaxgrpc::ApiCall<StopConnectorRequest, StopConnectorResponse> _callStopConnector;

        /// <summary>
        /// Constructs a client wrapper for the ManagedKafkaConnect service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ManagedKafkaConnectSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ManagedKafkaConnectClientImpl(ManagedKafkaConnect.ManagedKafkaConnectClient grpcClient, ManagedKafkaConnectSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ManagedKafkaConnectSettings effectiveSettings = settings ?? ManagedKafkaConnectSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateConnectClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateConnectClusterOperationsSettings, logger);
            UpdateConnectClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateConnectClusterOperationsSettings, logger);
            DeleteConnectClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteConnectClusterOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListConnectClusters = clientHelper.BuildApiCall<ListConnectClustersRequest, ListConnectClustersResponse>("ListConnectClusters", grpcClient.ListConnectClustersAsync, grpcClient.ListConnectClusters, effectiveSettings.ListConnectClustersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListConnectClusters);
            Modify_ListConnectClustersApiCall(ref _callListConnectClusters);
            _callGetConnectCluster = clientHelper.BuildApiCall<GetConnectClusterRequest, ConnectCluster>("GetConnectCluster", grpcClient.GetConnectClusterAsync, grpcClient.GetConnectCluster, effectiveSettings.GetConnectClusterSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetConnectCluster);
            Modify_GetConnectClusterApiCall(ref _callGetConnectCluster);
            _callCreateConnectCluster = clientHelper.BuildApiCall<CreateConnectClusterRequest, lro::Operation>("CreateConnectCluster", grpcClient.CreateConnectClusterAsync, grpcClient.CreateConnectCluster, effectiveSettings.CreateConnectClusterSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateConnectCluster);
            Modify_CreateConnectClusterApiCall(ref _callCreateConnectCluster);
            _callUpdateConnectCluster = clientHelper.BuildApiCall<UpdateConnectClusterRequest, lro::Operation>("UpdateConnectCluster", grpcClient.UpdateConnectClusterAsync, grpcClient.UpdateConnectCluster, effectiveSettings.UpdateConnectClusterSettings).WithGoogleRequestParam("connect_cluster.name", request => request.ConnectCluster?.Name);
            Modify_ApiCall(ref _callUpdateConnectCluster);
            Modify_UpdateConnectClusterApiCall(ref _callUpdateConnectCluster);
            _callDeleteConnectCluster = clientHelper.BuildApiCall<DeleteConnectClusterRequest, lro::Operation>("DeleteConnectCluster", grpcClient.DeleteConnectClusterAsync, grpcClient.DeleteConnectCluster, effectiveSettings.DeleteConnectClusterSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteConnectCluster);
            Modify_DeleteConnectClusterApiCall(ref _callDeleteConnectCluster);
            _callListConnectors = clientHelper.BuildApiCall<ListConnectorsRequest, ListConnectorsResponse>("ListConnectors", grpcClient.ListConnectorsAsync, grpcClient.ListConnectors, effectiveSettings.ListConnectorsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListConnectors);
            Modify_ListConnectorsApiCall(ref _callListConnectors);
            _callGetConnector = clientHelper.BuildApiCall<GetConnectorRequest, Connector>("GetConnector", grpcClient.GetConnectorAsync, grpcClient.GetConnector, effectiveSettings.GetConnectorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetConnector);
            Modify_GetConnectorApiCall(ref _callGetConnector);
            _callCreateConnector = clientHelper.BuildApiCall<CreateConnectorRequest, Connector>("CreateConnector", grpcClient.CreateConnectorAsync, grpcClient.CreateConnector, effectiveSettings.CreateConnectorSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateConnector);
            Modify_CreateConnectorApiCall(ref _callCreateConnector);
            _callUpdateConnector = clientHelper.BuildApiCall<UpdateConnectorRequest, Connector>("UpdateConnector", grpcClient.UpdateConnectorAsync, grpcClient.UpdateConnector, effectiveSettings.UpdateConnectorSettings).WithGoogleRequestParam("connector.name", request => request.Connector?.Name);
            Modify_ApiCall(ref _callUpdateConnector);
            Modify_UpdateConnectorApiCall(ref _callUpdateConnector);
            _callDeleteConnector = clientHelper.BuildApiCall<DeleteConnectorRequest, wkt::Empty>("DeleteConnector", grpcClient.DeleteConnectorAsync, grpcClient.DeleteConnector, effectiveSettings.DeleteConnectorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteConnector);
            Modify_DeleteConnectorApiCall(ref _callDeleteConnector);
            _callPauseConnector = clientHelper.BuildApiCall<PauseConnectorRequest, PauseConnectorResponse>("PauseConnector", grpcClient.PauseConnectorAsync, grpcClient.PauseConnector, effectiveSettings.PauseConnectorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callPauseConnector);
            Modify_PauseConnectorApiCall(ref _callPauseConnector);
            _callResumeConnector = clientHelper.BuildApiCall<ResumeConnectorRequest, ResumeConnectorResponse>("ResumeConnector", grpcClient.ResumeConnectorAsync, grpcClient.ResumeConnector, effectiveSettings.ResumeConnectorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callResumeConnector);
            Modify_ResumeConnectorApiCall(ref _callResumeConnector);
            _callRestartConnector = clientHelper.BuildApiCall<RestartConnectorRequest, RestartConnectorResponse>("RestartConnector", grpcClient.RestartConnectorAsync, grpcClient.RestartConnector, effectiveSettings.RestartConnectorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRestartConnector);
            Modify_RestartConnectorApiCall(ref _callRestartConnector);
            _callStopConnector = clientHelper.BuildApiCall<StopConnectorRequest, StopConnectorResponse>("StopConnector", grpcClient.StopConnectorAsync, grpcClient.StopConnector, effectiveSettings.StopConnectorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callStopConnector);
            Modify_StopConnectorApiCall(ref _callStopConnector);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListConnectClustersApiCall(ref gaxgrpc::ApiCall<ListConnectClustersRequest, ListConnectClustersResponse> call);

        partial void Modify_GetConnectClusterApiCall(ref gaxgrpc::ApiCall<GetConnectClusterRequest, ConnectCluster> call);

        partial void Modify_CreateConnectClusterApiCall(ref gaxgrpc::ApiCall<CreateConnectClusterRequest, lro::Operation> call);

        partial void Modify_UpdateConnectClusterApiCall(ref gaxgrpc::ApiCall<UpdateConnectClusterRequest, lro::Operation> call);

        partial void Modify_DeleteConnectClusterApiCall(ref gaxgrpc::ApiCall<DeleteConnectClusterRequest, lro::Operation> call);

        partial void Modify_ListConnectorsApiCall(ref gaxgrpc::ApiCall<ListConnectorsRequest, ListConnectorsResponse> call);

        partial void Modify_GetConnectorApiCall(ref gaxgrpc::ApiCall<GetConnectorRequest, Connector> call);

        partial void Modify_CreateConnectorApiCall(ref gaxgrpc::ApiCall<CreateConnectorRequest, Connector> call);

        partial void Modify_UpdateConnectorApiCall(ref gaxgrpc::ApiCall<UpdateConnectorRequest, Connector> call);

        partial void Modify_DeleteConnectorApiCall(ref gaxgrpc::ApiCall<DeleteConnectorRequest, wkt::Empty> call);

        partial void Modify_PauseConnectorApiCall(ref gaxgrpc::ApiCall<PauseConnectorRequest, PauseConnectorResponse> call);

        partial void Modify_ResumeConnectorApiCall(ref gaxgrpc::ApiCall<ResumeConnectorRequest, ResumeConnectorResponse> call);

        partial void Modify_RestartConnectorApiCall(ref gaxgrpc::ApiCall<RestartConnectorRequest, RestartConnectorResponse> call);

        partial void Modify_StopConnectorApiCall(ref gaxgrpc::ApiCall<StopConnectorRequest, StopConnectorResponse> call);

        partial void OnConstruction(ManagedKafkaConnect.ManagedKafkaConnectClient grpcClient, ManagedKafkaConnectSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ManagedKafkaConnect client</summary>
        public override ManagedKafkaConnect.ManagedKafkaConnectClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListConnectClustersRequest(ref ListConnectClustersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetConnectClusterRequest(ref GetConnectClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateConnectClusterRequest(ref CreateConnectClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateConnectClusterRequest(ref UpdateConnectClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteConnectClusterRequest(ref DeleteConnectClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListConnectorsRequest(ref ListConnectorsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetConnectorRequest(ref GetConnectorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateConnectorRequest(ref CreateConnectorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateConnectorRequest(ref UpdateConnectorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteConnectorRequest(ref DeleteConnectorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PauseConnectorRequest(ref PauseConnectorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResumeConnectorRequest(ref ResumeConnectorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RestartConnectorRequest(ref RestartConnectorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StopConnectorRequest(ref StopConnectorRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists the Kafka Connect clusters in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ConnectCluster"/> resources.</returns>
        public override gax::PagedEnumerable<ListConnectClustersResponse, ConnectCluster> ListConnectClusters(ListConnectClustersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConnectClustersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListConnectClustersRequest, ListConnectClustersResponse, ConnectCluster>(_callListConnectClusters, request, callSettings);
        }

        /// <summary>
        /// Lists the Kafka Connect clusters in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ConnectCluster"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListConnectClustersResponse, ConnectCluster> ListConnectClustersAsync(ListConnectClustersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConnectClustersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListConnectClustersRequest, ListConnectClustersResponse, ConnectCluster>(_callListConnectClusters, request, callSettings);
        }

        /// <summary>
        /// Returns the properties of a single Kafka Connect cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ConnectCluster GetConnectCluster(GetConnectClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConnectClusterRequest(ref request, ref callSettings);
            return _callGetConnectCluster.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the properties of a single Kafka Connect cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ConnectCluster> GetConnectClusterAsync(GetConnectClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConnectClusterRequest(ref request, ref callSettings);
            return _callGetConnectCluster.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateConnectCluster</c>.</summary>
        public override lro::OperationsClient CreateConnectClusterOperationsClient { get; }

        /// <summary>
        /// Creates a new Kafka Connect cluster in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ConnectCluster, OperationMetadata> CreateConnectCluster(CreateConnectClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConnectClusterRequest(ref request, ref callSettings);
            return new lro::Operation<ConnectCluster, OperationMetadata>(_callCreateConnectCluster.Sync(request, callSettings), CreateConnectClusterOperationsClient);
        }

        /// <summary>
        /// Creates a new Kafka Connect cluster in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ConnectCluster, OperationMetadata>> CreateConnectClusterAsync(CreateConnectClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConnectClusterRequest(ref request, ref callSettings);
            return new lro::Operation<ConnectCluster, OperationMetadata>(await _callCreateConnectCluster.Async(request, callSettings).ConfigureAwait(false), CreateConnectClusterOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateConnectCluster</c>.</summary>
        public override lro::OperationsClient UpdateConnectClusterOperationsClient { get; }

        /// <summary>
        /// Updates the properties of a single Kafka Connect cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ConnectCluster, OperationMetadata> UpdateConnectCluster(UpdateConnectClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConnectClusterRequest(ref request, ref callSettings);
            return new lro::Operation<ConnectCluster, OperationMetadata>(_callUpdateConnectCluster.Sync(request, callSettings), UpdateConnectClusterOperationsClient);
        }

        /// <summary>
        /// Updates the properties of a single Kafka Connect cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ConnectCluster, OperationMetadata>> UpdateConnectClusterAsync(UpdateConnectClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConnectClusterRequest(ref request, ref callSettings);
            return new lro::Operation<ConnectCluster, OperationMetadata>(await _callUpdateConnectCluster.Async(request, callSettings).ConfigureAwait(false), UpdateConnectClusterOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteConnectCluster</c>.</summary>
        public override lro::OperationsClient DeleteConnectClusterOperationsClient { get; }

        /// <summary>
        /// Deletes a single Connect cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteConnectCluster(DeleteConnectClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConnectClusterRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteConnectCluster.Sync(request, callSettings), DeleteConnectClusterOperationsClient);
        }

        /// <summary>
        /// Deletes a single Connect cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteConnectClusterAsync(DeleteConnectClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConnectClusterRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteConnectCluster.Async(request, callSettings).ConfigureAwait(false), DeleteConnectClusterOperationsClient);
        }

        /// <summary>
        /// Lists the connectors in a given Connect cluster.
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
        /// Lists the connectors in a given Connect cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Connector"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListConnectorsResponse, Connector> ListConnectorsAsync(ListConnectorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConnectorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListConnectorsRequest, ListConnectorsResponse, Connector>(_callListConnectors, request, callSettings);
        }

        /// <summary>
        /// Returns the properties of a single connector.
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
        /// Returns the properties of a single connector.
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
        /// Creates a new connector in a given Connect cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Connector CreateConnector(CreateConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConnectorRequest(ref request, ref callSettings);
            return _callCreateConnector.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new connector in a given Connect cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Connector> CreateConnectorAsync(CreateConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConnectorRequest(ref request, ref callSettings);
            return _callCreateConnector.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the properties of a connector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Connector UpdateConnector(UpdateConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConnectorRequest(ref request, ref callSettings);
            return _callUpdateConnector.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the properties of a connector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Connector> UpdateConnectorAsync(UpdateConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConnectorRequest(ref request, ref callSettings);
            return _callUpdateConnector.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a connector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteConnector(DeleteConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConnectorRequest(ref request, ref callSettings);
            _callDeleteConnector.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a connector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteConnectorAsync(DeleteConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConnectorRequest(ref request, ref callSettings);
            return _callDeleteConnector.Async(request, callSettings);
        }

        /// <summary>
        /// Pauses the connector and its tasks.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PauseConnectorResponse PauseConnector(PauseConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PauseConnectorRequest(ref request, ref callSettings);
            return _callPauseConnector.Sync(request, callSettings);
        }

        /// <summary>
        /// Pauses the connector and its tasks.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PauseConnectorResponse> PauseConnectorAsync(PauseConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PauseConnectorRequest(ref request, ref callSettings);
            return _callPauseConnector.Async(request, callSettings);
        }

        /// <summary>
        /// Resumes the connector and its tasks.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ResumeConnectorResponse ResumeConnector(ResumeConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResumeConnectorRequest(ref request, ref callSettings);
            return _callResumeConnector.Sync(request, callSettings);
        }

        /// <summary>
        /// Resumes the connector and its tasks.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ResumeConnectorResponse> ResumeConnectorAsync(ResumeConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResumeConnectorRequest(ref request, ref callSettings);
            return _callResumeConnector.Async(request, callSettings);
        }

        /// <summary>
        /// Restarts the connector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RestartConnectorResponse RestartConnector(RestartConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestartConnectorRequest(ref request, ref callSettings);
            return _callRestartConnector.Sync(request, callSettings);
        }

        /// <summary>
        /// Restarts the connector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RestartConnectorResponse> RestartConnectorAsync(RestartConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestartConnectorRequest(ref request, ref callSettings);
            return _callRestartConnector.Async(request, callSettings);
        }

        /// <summary>
        /// Stops the connector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override StopConnectorResponse StopConnector(StopConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopConnectorRequest(ref request, ref callSettings);
            return _callStopConnector.Sync(request, callSettings);
        }

        /// <summary>
        /// Stops the connector.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<StopConnectorResponse> StopConnectorAsync(StopConnectorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StopConnectorRequest(ref request, ref callSettings);
            return _callStopConnector.Async(request, callSettings);
        }
    }

    public partial class ListConnectClustersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListConnectorsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListConnectClustersResponse : gaxgrpc::IPageResponse<ConnectCluster>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ConnectCluster> GetEnumerator() => ConnectClusters.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListConnectorsResponse : gaxgrpc::IPageResponse<Connector>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Connector> GetEnumerator() => Connectors.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ManagedKafkaConnect
    {
        public partial class ManagedKafkaConnectClient
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

    public static partial class ManagedKafkaConnect
    {
        public partial class ManagedKafkaConnectClient
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
