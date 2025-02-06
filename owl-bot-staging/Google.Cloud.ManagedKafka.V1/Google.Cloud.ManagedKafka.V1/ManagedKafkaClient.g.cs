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
    /// <summary>Settings for <see cref="ManagedKafkaClient"/> instances.</summary>
    public sealed partial class ManagedKafkaSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ManagedKafkaSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ManagedKafkaSettings"/>.</returns>
        public static ManagedKafkaSettings GetDefault() => new ManagedKafkaSettings();

        /// <summary>Constructs a new <see cref="ManagedKafkaSettings"/> object with default settings.</summary>
        public ManagedKafkaSettings()
        {
        }

        private ManagedKafkaSettings(ManagedKafkaSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListClustersSettings = existing.ListClustersSettings;
            GetClusterSettings = existing.GetClusterSettings;
            CreateClusterSettings = existing.CreateClusterSettings;
            CreateClusterOperationsSettings = existing.CreateClusterOperationsSettings.Clone();
            UpdateClusterSettings = existing.UpdateClusterSettings;
            UpdateClusterOperationsSettings = existing.UpdateClusterOperationsSettings.Clone();
            DeleteClusterSettings = existing.DeleteClusterSettings;
            DeleteClusterOperationsSettings = existing.DeleteClusterOperationsSettings.Clone();
            ListTopicsSettings = existing.ListTopicsSettings;
            GetTopicSettings = existing.GetTopicSettings;
            CreateTopicSettings = existing.CreateTopicSettings;
            UpdateTopicSettings = existing.UpdateTopicSettings;
            DeleteTopicSettings = existing.DeleteTopicSettings;
            ListConsumerGroupsSettings = existing.ListConsumerGroupsSettings;
            GetConsumerGroupSettings = existing.GetConsumerGroupSettings;
            UpdateConsumerGroupSettings = existing.UpdateConsumerGroupSettings;
            DeleteConsumerGroupSettings = existing.DeleteConsumerGroupSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ManagedKafkaSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedKafkaClient.ListClusters</c> and <c>ManagedKafkaClient.ListClustersAsync</c>.
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
        public gaxgrpc::CallSettings ListClustersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedKafkaClient.GetCluster</c> and <c>ManagedKafkaClient.GetClusterAsync</c>.
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
        public gaxgrpc::CallSettings GetClusterSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedKafkaClient.CreateCluster</c> and <c>ManagedKafkaClient.CreateClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ManagedKafkaClient.CreateCluster</c> and
        /// <c>ManagedKafkaClient.CreateClusterAsync</c>.
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
        public lro::OperationsSettings CreateClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedKafkaClient.UpdateCluster</c> and <c>ManagedKafkaClient.UpdateClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ManagedKafkaClient.UpdateCluster</c> and
        /// <c>ManagedKafkaClient.UpdateClusterAsync</c>.
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
        public lro::OperationsSettings UpdateClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedKafkaClient.DeleteCluster</c> and <c>ManagedKafkaClient.DeleteClusterAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteClusterSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ManagedKafkaClient.DeleteCluster</c> and
        /// <c>ManagedKafkaClient.DeleteClusterAsync</c>.
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
        public lro::OperationsSettings DeleteClusterOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedKafkaClient.ListTopics</c> and <c>ManagedKafkaClient.ListTopicsAsync</c>.
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
        public gaxgrpc::CallSettings ListTopicsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ManagedKafkaClient.GetTopic</c>
        ///  and <c>ManagedKafkaClient.GetTopicAsync</c>.
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
        public gaxgrpc::CallSettings GetTopicSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedKafkaClient.CreateTopic</c> and <c>ManagedKafkaClient.CreateTopicAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTopicSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedKafkaClient.UpdateTopic</c> and <c>ManagedKafkaClient.UpdateTopicAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateTopicSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedKafkaClient.DeleteTopic</c> and <c>ManagedKafkaClient.DeleteTopicAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTopicSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedKafkaClient.ListConsumerGroups</c> and <c>ManagedKafkaClient.ListConsumerGroupsAsync</c>.
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
        public gaxgrpc::CallSettings ListConsumerGroupsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedKafkaClient.GetConsumerGroup</c> and <c>ManagedKafkaClient.GetConsumerGroupAsync</c>.
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
        public gaxgrpc::CallSettings GetConsumerGroupSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedKafkaClient.UpdateConsumerGroup</c> and <c>ManagedKafkaClient.UpdateConsumerGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateConsumerGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ManagedKafkaClient.DeleteConsumerGroup</c> and <c>ManagedKafkaClient.DeleteConsumerGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteConsumerGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ManagedKafkaSettings"/> object.</returns>
        public ManagedKafkaSettings Clone() => new ManagedKafkaSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ManagedKafkaClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class ManagedKafkaClientBuilder : gaxgrpc::ClientBuilderBase<ManagedKafkaClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ManagedKafkaSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ManagedKafkaClientBuilder() : base(ManagedKafkaClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ManagedKafkaClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ManagedKafkaClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ManagedKafkaClient Build()
        {
            ManagedKafkaClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ManagedKafkaClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ManagedKafkaClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ManagedKafkaClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ManagedKafkaClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ManagedKafkaClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ManagedKafkaClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ManagedKafkaClient.ChannelPool;
    }

    /// <summary>ManagedKafka client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The service that a client application uses to manage Apache Kafka clusters,
    /// topics and consumer groups.
    /// </remarks>
    public abstract partial class ManagedKafkaClient
    {
        /// <summary>
        /// The default endpoint for the ManagedKafka service, which is a host of "managedkafka.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "managedkafka.googleapis.com:443";

        /// <summary>The default ManagedKafka scopes.</summary>
        /// <remarks>
        /// The default ManagedKafka scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ManagedKafka.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ManagedKafkaClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ManagedKafkaClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ManagedKafkaClient"/>.</returns>
        public static stt::Task<ManagedKafkaClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ManagedKafkaClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ManagedKafkaClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ManagedKafkaClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ManagedKafkaClient"/>.</returns>
        public static ManagedKafkaClient Create() => new ManagedKafkaClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ManagedKafkaClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ManagedKafkaSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ManagedKafkaClient"/>.</returns>
        internal static ManagedKafkaClient Create(grpccore::CallInvoker callInvoker, ManagedKafkaSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ManagedKafka.ManagedKafkaClient grpcClient = new ManagedKafka.ManagedKafkaClient(callInvoker);
            return new ManagedKafkaClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ManagedKafka client</summary>
        public virtual ManagedKafka.ManagedKafkaClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the clusters in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Cluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListClustersResponse, Cluster> ListClusters(ListClustersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the clusters in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Cluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListClustersResponse, Cluster> ListClustersAsync(ListClustersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the clusters in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location whose clusters are to be listed. Structured
        /// like `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="Cluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListClustersResponse, Cluster> ListClusters(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListClustersRequest request = new ListClustersRequest
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
            return ListClusters(request, callSettings);
        }

        /// <summary>
        /// Lists the clusters in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location whose clusters are to be listed. Structured
        /// like `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Cluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListClustersResponse, Cluster> ListClustersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListClustersRequest request = new ListClustersRequest
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
            return ListClustersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the clusters in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location whose clusters are to be listed. Structured
        /// like `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="Cluster"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListClustersResponse, Cluster> ListClusters(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListClustersRequest request = new ListClustersRequest
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
            return ListClusters(request, callSettings);
        }

        /// <summary>
        /// Lists the clusters in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location whose clusters are to be listed. Structured
        /// like `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Cluster"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListClustersResponse, Cluster> ListClustersAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListClustersRequest request = new ListClustersRequest
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
            return ListClustersAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the properties of a single cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Cluster GetCluster(GetClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the properties of a single cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Cluster> GetClusterAsync(GetClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the properties of a single cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Cluster> GetClusterAsync(GetClusterRequest request, st::CancellationToken cancellationToken) =>
            GetClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the properties of a single cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the cluster whose configuration to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Cluster GetCluster(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCluster(new GetClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the properties of a single cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the cluster whose configuration to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Cluster> GetClusterAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetClusterAsync(new GetClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the properties of a single cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the cluster whose configuration to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Cluster> GetClusterAsync(string name, st::CancellationToken cancellationToken) =>
            GetClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the properties of a single cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the cluster whose configuration to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Cluster GetCluster(ClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCluster(new GetClusterRequest
            {
                ClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the properties of a single cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the cluster whose configuration to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Cluster> GetClusterAsync(ClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            GetClusterAsync(new GetClusterRequest
            {
                ClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the properties of a single cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the cluster whose configuration to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Cluster> GetClusterAsync(ClusterName name, st::CancellationToken cancellationToken) =>
            GetClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new cluster in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, OperationMetadata> CreateCluster(CreateClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new cluster in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> CreateClusterAsync(CreateClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new cluster in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> CreateClusterAsync(CreateClusterRequest request, st::CancellationToken cancellationToken) =>
            CreateClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateCluster</c>.</summary>
        public virtual lro::OperationsClient CreateClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Cluster, OperationMetadata> PollOnceCreateCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Cluster, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> PollOnceCreateClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Cluster, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateClusterOperationsClient, callSettings);

        /// <summary>
        /// Creates a new cluster in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent region in which to create the cluster. Structured like
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="cluster">
        /// Required. Configuration of the cluster to create. Its `name` field is
        /// ignored.
        /// </param>
        /// <param name="clusterId">
        /// Required. The ID to use for the cluster, which will become the final
        /// component of the cluster's name. The ID must be 1-63 characters long, and
        /// match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?` to comply with
        /// RFC 1035.
        /// 
        /// This value is structured like: `my-cluster-id`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, OperationMetadata> CreateCluster(string parent, Cluster cluster, string clusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCluster(new CreateClusterRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
            }, callSettings);

        /// <summary>
        /// Creates a new cluster in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent region in which to create the cluster. Structured like
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="cluster">
        /// Required. Configuration of the cluster to create. Its `name` field is
        /// ignored.
        /// </param>
        /// <param name="clusterId">
        /// Required. The ID to use for the cluster, which will become the final
        /// component of the cluster's name. The ID must be 1-63 characters long, and
        /// match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?` to comply with
        /// RFC 1035.
        /// 
        /// This value is structured like: `my-cluster-id`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> CreateClusterAsync(string parent, Cluster cluster, string clusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateClusterAsync(new CreateClusterRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
            }, callSettings);

        /// <summary>
        /// Creates a new cluster in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent region in which to create the cluster. Structured like
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="cluster">
        /// Required. Configuration of the cluster to create. Its `name` field is
        /// ignored.
        /// </param>
        /// <param name="clusterId">
        /// Required. The ID to use for the cluster, which will become the final
        /// component of the cluster's name. The ID must be 1-63 characters long, and
        /// match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?` to comply with
        /// RFC 1035.
        /// 
        /// This value is structured like: `my-cluster-id`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> CreateClusterAsync(string parent, Cluster cluster, string clusterId, st::CancellationToken cancellationToken) =>
            CreateClusterAsync(parent, cluster, clusterId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new cluster in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent region in which to create the cluster. Structured like
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="cluster">
        /// Required. Configuration of the cluster to create. Its `name` field is
        /// ignored.
        /// </param>
        /// <param name="clusterId">
        /// Required. The ID to use for the cluster, which will become the final
        /// component of the cluster's name. The ID must be 1-63 characters long, and
        /// match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?` to comply with
        /// RFC 1035.
        /// 
        /// This value is structured like: `my-cluster-id`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, OperationMetadata> CreateCluster(gagr::LocationName parent, Cluster cluster, string clusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCluster(new CreateClusterRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
            }, callSettings);

        /// <summary>
        /// Creates a new cluster in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent region in which to create the cluster. Structured like
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="cluster">
        /// Required. Configuration of the cluster to create. Its `name` field is
        /// ignored.
        /// </param>
        /// <param name="clusterId">
        /// Required. The ID to use for the cluster, which will become the final
        /// component of the cluster's name. The ID must be 1-63 characters long, and
        /// match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?` to comply with
        /// RFC 1035.
        /// 
        /// This value is structured like: `my-cluster-id`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> CreateClusterAsync(gagr::LocationName parent, Cluster cluster, string clusterId, gaxgrpc::CallSettings callSettings = null) =>
            CreateClusterAsync(new CreateClusterRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ClusterId = gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)),
                Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
            }, callSettings);

        /// <summary>
        /// Creates a new cluster in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent region in which to create the cluster. Structured like
        /// `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="cluster">
        /// Required. Configuration of the cluster to create. Its `name` field is
        /// ignored.
        /// </param>
        /// <param name="clusterId">
        /// Required. The ID to use for the cluster, which will become the final
        /// component of the cluster's name. The ID must be 1-63 characters long, and
        /// match the regular expression `[a-z]([-a-z0-9]*[a-z0-9])?` to comply with
        /// RFC 1035.
        /// 
        /// This value is structured like: `my-cluster-id`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> CreateClusterAsync(gagr::LocationName parent, Cluster cluster, string clusterId, st::CancellationToken cancellationToken) =>
            CreateClusterAsync(parent, cluster, clusterId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the properties of a single cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Cluster, OperationMetadata> UpdateCluster(UpdateClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the properties of a single cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> UpdateClusterAsync(UpdateClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the properties of a single cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> UpdateClusterAsync(UpdateClusterRequest request, st::CancellationToken cancellationToken) =>
            UpdateClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateCluster</c>.</summary>
        public virtual lro::OperationsClient UpdateClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Cluster, OperationMetadata> PollOnceUpdateCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Cluster, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> PollOnceUpdateClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Cluster, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateClusterOperationsClient, callSettings);

        /// <summary>
        /// Updates the properties of a single cluster.
        /// </summary>
        /// <param name="cluster">
        /// Required. The cluster to update. Its `name` field must be populated.
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
        public virtual lro::Operation<Cluster, OperationMetadata> UpdateCluster(Cluster cluster, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCluster(new UpdateClusterRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
            }, callSettings);

        /// <summary>
        /// Updates the properties of a single cluster.
        /// </summary>
        /// <param name="cluster">
        /// Required. The cluster to update. Its `name` field must be populated.
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
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> UpdateClusterAsync(Cluster cluster, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateClusterAsync(new UpdateClusterRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Cluster = gax::GaxPreconditions.CheckNotNull(cluster, nameof(cluster)),
            }, callSettings);

        /// <summary>
        /// Updates the properties of a single cluster.
        /// </summary>
        /// <param name="cluster">
        /// Required. The cluster to update. Its `name` field must be populated.
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
        public virtual stt::Task<lro::Operation<Cluster, OperationMetadata>> UpdateClusterAsync(Cluster cluster, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateClusterAsync(cluster, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCluster(DeleteClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteClusterAsync(DeleteClusterRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteClusterAsync(DeleteClusterRequest request, st::CancellationToken cancellationToken) =>
            DeleteClusterAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteCluster</c>.</summary>
        public virtual lro::OperationsClient DeleteClusterOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteCluster(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteClusterOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteCluster</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteClusterAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteClusterOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the cluster to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCluster(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCluster(new DeleteClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the cluster to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteClusterAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteClusterAsync(new DeleteClusterRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the cluster to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteClusterAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the cluster to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCluster(ClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCluster(new DeleteClusterRequest
            {
                ClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the cluster to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteClusterAsync(ClusterName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteClusterAsync(new DeleteClusterRequest
            {
                ClusterName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single cluster.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the cluster to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteClusterAsync(ClusterName name, st::CancellationToken cancellationToken) =>
            DeleteClusterAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the topics in a given cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Topic"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTopicsResponse, Topic> ListTopics(ListTopicsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the topics in a given cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Topic"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTopicsResponse, Topic> ListTopicsAsync(ListTopicsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the topics in a given cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent cluster whose topics are to be listed. Structured like
        /// `projects/{project}/locations/{location}/clusters/{cluster}`.
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
        /// <returns>A pageable sequence of <see cref="Topic"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTopicsResponse, Topic> ListTopics(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTopicsRequest request = new ListTopicsRequest
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
            return ListTopics(request, callSettings);
        }

        /// <summary>
        /// Lists the topics in a given cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent cluster whose topics are to be listed. Structured like
        /// `projects/{project}/locations/{location}/clusters/{cluster}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Topic"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTopicsResponse, Topic> ListTopicsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTopicsRequest request = new ListTopicsRequest
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
            return ListTopicsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the topics in a given cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent cluster whose topics are to be listed. Structured like
        /// `projects/{project}/locations/{location}/clusters/{cluster}`.
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
        /// <returns>A pageable sequence of <see cref="Topic"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTopicsResponse, Topic> ListTopics(ClusterName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTopicsRequest request = new ListTopicsRequest
            {
                ParentAsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTopics(request, callSettings);
        }

        /// <summary>
        /// Lists the topics in a given cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent cluster whose topics are to be listed. Structured like
        /// `projects/{project}/locations/{location}/clusters/{cluster}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Topic"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTopicsResponse, Topic> ListTopicsAsync(ClusterName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTopicsRequest request = new ListTopicsRequest
            {
                ParentAsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTopicsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the properties of a single topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Topic GetTopic(GetTopicRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the properties of a single topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> GetTopicAsync(GetTopicRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the properties of a single topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> GetTopicAsync(GetTopicRequest request, st::CancellationToken cancellationToken) =>
            GetTopicAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the properties of a single topic.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the topic whose configuration to return. Structured
        /// like:
        /// projects/{project}/locations/{location}/clusters/{cluster}/topics/{topic}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Topic GetTopic(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTopic(new GetTopicRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the properties of a single topic.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the topic whose configuration to return. Structured
        /// like:
        /// projects/{project}/locations/{location}/clusters/{cluster}/topics/{topic}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> GetTopicAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTopicAsync(new GetTopicRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the properties of a single topic.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the topic whose configuration to return. Structured
        /// like:
        /// projects/{project}/locations/{location}/clusters/{cluster}/topics/{topic}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> GetTopicAsync(string name, st::CancellationToken cancellationToken) =>
            GetTopicAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the properties of a single topic.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the topic whose configuration to return. Structured
        /// like:
        /// projects/{project}/locations/{location}/clusters/{cluster}/topics/{topic}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Topic GetTopic(TopicName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTopic(new GetTopicRequest
            {
                TopicName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the properties of a single topic.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the topic whose configuration to return. Structured
        /// like:
        /// projects/{project}/locations/{location}/clusters/{cluster}/topics/{topic}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> GetTopicAsync(TopicName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTopicAsync(new GetTopicRequest
            {
                TopicName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the properties of a single topic.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the topic whose configuration to return. Structured
        /// like:
        /// projects/{project}/locations/{location}/clusters/{cluster}/topics/{topic}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> GetTopicAsync(TopicName name, st::CancellationToken cancellationToken) =>
            GetTopicAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new topic in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Topic CreateTopic(CreateTopicRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new topic in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> CreateTopicAsync(CreateTopicRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new topic in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> CreateTopicAsync(CreateTopicRequest request, st::CancellationToken cancellationToken) =>
            CreateTopicAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new topic in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent cluster in which to create the topic.
        /// Structured like
        /// `projects/{project}/locations/{location}/clusters/{cluster}`.
        /// </param>
        /// <param name="topic">
        /// Required. Configuration of the topic to create. Its `name` field is
        /// ignored.
        /// </param>
        /// <param name="topicId">
        /// Required. The ID to use for the topic, which will become the final
        /// component of the topic's name.
        /// 
        /// This value is structured like: `my-topic-name`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Topic CreateTopic(string parent, Topic topic, string topicId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTopic(new CreateTopicRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TopicId = gax::GaxPreconditions.CheckNotNullOrEmpty(topicId, nameof(topicId)),
                Topic = gax::GaxPreconditions.CheckNotNull(topic, nameof(topic)),
            }, callSettings);

        /// <summary>
        /// Creates a new topic in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent cluster in which to create the topic.
        /// Structured like
        /// `projects/{project}/locations/{location}/clusters/{cluster}`.
        /// </param>
        /// <param name="topic">
        /// Required. Configuration of the topic to create. Its `name` field is
        /// ignored.
        /// </param>
        /// <param name="topicId">
        /// Required. The ID to use for the topic, which will become the final
        /// component of the topic's name.
        /// 
        /// This value is structured like: `my-topic-name`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> CreateTopicAsync(string parent, Topic topic, string topicId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTopicAsync(new CreateTopicRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TopicId = gax::GaxPreconditions.CheckNotNullOrEmpty(topicId, nameof(topicId)),
                Topic = gax::GaxPreconditions.CheckNotNull(topic, nameof(topic)),
            }, callSettings);

        /// <summary>
        /// Creates a new topic in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent cluster in which to create the topic.
        /// Structured like
        /// `projects/{project}/locations/{location}/clusters/{cluster}`.
        /// </param>
        /// <param name="topic">
        /// Required. Configuration of the topic to create. Its `name` field is
        /// ignored.
        /// </param>
        /// <param name="topicId">
        /// Required. The ID to use for the topic, which will become the final
        /// component of the topic's name.
        /// 
        /// This value is structured like: `my-topic-name`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> CreateTopicAsync(string parent, Topic topic, string topicId, st::CancellationToken cancellationToken) =>
            CreateTopicAsync(parent, topic, topicId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new topic in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent cluster in which to create the topic.
        /// Structured like
        /// `projects/{project}/locations/{location}/clusters/{cluster}`.
        /// </param>
        /// <param name="topic">
        /// Required. Configuration of the topic to create. Its `name` field is
        /// ignored.
        /// </param>
        /// <param name="topicId">
        /// Required. The ID to use for the topic, which will become the final
        /// component of the topic's name.
        /// 
        /// This value is structured like: `my-topic-name`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Topic CreateTopic(ClusterName parent, Topic topic, string topicId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTopic(new CreateTopicRequest
            {
                ParentAsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TopicId = gax::GaxPreconditions.CheckNotNullOrEmpty(topicId, nameof(topicId)),
                Topic = gax::GaxPreconditions.CheckNotNull(topic, nameof(topic)),
            }, callSettings);

        /// <summary>
        /// Creates a new topic in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent cluster in which to create the topic.
        /// Structured like
        /// `projects/{project}/locations/{location}/clusters/{cluster}`.
        /// </param>
        /// <param name="topic">
        /// Required. Configuration of the topic to create. Its `name` field is
        /// ignored.
        /// </param>
        /// <param name="topicId">
        /// Required. The ID to use for the topic, which will become the final
        /// component of the topic's name.
        /// 
        /// This value is structured like: `my-topic-name`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> CreateTopicAsync(ClusterName parent, Topic topic, string topicId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTopicAsync(new CreateTopicRequest
            {
                ParentAsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TopicId = gax::GaxPreconditions.CheckNotNullOrEmpty(topicId, nameof(topicId)),
                Topic = gax::GaxPreconditions.CheckNotNull(topic, nameof(topic)),
            }, callSettings);

        /// <summary>
        /// Creates a new topic in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent cluster in which to create the topic.
        /// Structured like
        /// `projects/{project}/locations/{location}/clusters/{cluster}`.
        /// </param>
        /// <param name="topic">
        /// Required. Configuration of the topic to create. Its `name` field is
        /// ignored.
        /// </param>
        /// <param name="topicId">
        /// Required. The ID to use for the topic, which will become the final
        /// component of the topic's name.
        /// 
        /// This value is structured like: `my-topic-name`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> CreateTopicAsync(ClusterName parent, Topic topic, string topicId, st::CancellationToken cancellationToken) =>
            CreateTopicAsync(parent, topic, topicId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the properties of a single topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Topic UpdateTopic(UpdateTopicRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the properties of a single topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> UpdateTopicAsync(UpdateTopicRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the properties of a single topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> UpdateTopicAsync(UpdateTopicRequest request, st::CancellationToken cancellationToken) =>
            UpdateTopicAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the properties of a single topic.
        /// </summary>
        /// <param name="topic">
        /// Required. The topic to update. Its `name` field must be populated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Topic resource by the update. The fields specified in the update_mask are
        /// relative to the resource, not the full request. A field will be overwritten
        /// if it is in the mask. The mask is required and a value of * will update all
        /// fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Topic UpdateTopic(Topic topic, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTopic(new UpdateTopicRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Topic = gax::GaxPreconditions.CheckNotNull(topic, nameof(topic)),
            }, callSettings);

        /// <summary>
        /// Updates the properties of a single topic.
        /// </summary>
        /// <param name="topic">
        /// Required. The topic to update. Its `name` field must be populated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Topic resource by the update. The fields specified in the update_mask are
        /// relative to the resource, not the full request. A field will be overwritten
        /// if it is in the mask. The mask is required and a value of * will update all
        /// fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> UpdateTopicAsync(Topic topic, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTopicAsync(new UpdateTopicRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Topic = gax::GaxPreconditions.CheckNotNull(topic, nameof(topic)),
            }, callSettings);

        /// <summary>
        /// Updates the properties of a single topic.
        /// </summary>
        /// <param name="topic">
        /// Required. The topic to update. Its `name` field must be populated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Topic resource by the update. The fields specified in the update_mask are
        /// relative to the resource, not the full request. A field will be overwritten
        /// if it is in the mask. The mask is required and a value of * will update all
        /// fields.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Topic> UpdateTopicAsync(Topic topic, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateTopicAsync(topic, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTopic(DeleteTopicRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTopicAsync(DeleteTopicRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTopicAsync(DeleteTopicRequest request, st::CancellationToken cancellationToken) =>
            DeleteTopicAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single topic.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the topic to delete.
        /// `projects/{project}/locations/{location}/clusters/{cluster}/topics/{topic}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTopic(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTopic(new DeleteTopicRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single topic.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the topic to delete.
        /// `projects/{project}/locations/{location}/clusters/{cluster}/topics/{topic}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTopicAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTopicAsync(new DeleteTopicRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single topic.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the topic to delete.
        /// `projects/{project}/locations/{location}/clusters/{cluster}/topics/{topic}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTopicAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteTopicAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single topic.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the topic to delete.
        /// `projects/{project}/locations/{location}/clusters/{cluster}/topics/{topic}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTopic(TopicName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTopic(new DeleteTopicRequest
            {
                TopicName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single topic.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the topic to delete.
        /// `projects/{project}/locations/{location}/clusters/{cluster}/topics/{topic}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTopicAsync(TopicName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTopicAsync(new DeleteTopicRequest
            {
                TopicName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single topic.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the topic to delete.
        /// `projects/{project}/locations/{location}/clusters/{cluster}/topics/{topic}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTopicAsync(TopicName name, st::CancellationToken cancellationToken) =>
            DeleteTopicAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the consumer groups in a given cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ConsumerGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConsumerGroupsResponse, ConsumerGroup> ListConsumerGroups(ListConsumerGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the consumer groups in a given cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ConsumerGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConsumerGroupsResponse, ConsumerGroup> ListConsumerGroupsAsync(ListConsumerGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the consumer groups in a given cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent cluster whose consumer groups are to be listed.
        /// Structured like
        /// `projects/{project}/locations/{location}/clusters/{cluster}`.
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
        /// <returns>A pageable sequence of <see cref="ConsumerGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConsumerGroupsResponse, ConsumerGroup> ListConsumerGroups(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConsumerGroupsRequest request = new ListConsumerGroupsRequest
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
            return ListConsumerGroups(request, callSettings);
        }

        /// <summary>
        /// Lists the consumer groups in a given cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent cluster whose consumer groups are to be listed.
        /// Structured like
        /// `projects/{project}/locations/{location}/clusters/{cluster}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ConsumerGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConsumerGroupsResponse, ConsumerGroup> ListConsumerGroupsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConsumerGroupsRequest request = new ListConsumerGroupsRequest
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
            return ListConsumerGroupsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the consumer groups in a given cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent cluster whose consumer groups are to be listed.
        /// Structured like
        /// `projects/{project}/locations/{location}/clusters/{cluster}`.
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
        /// <returns>A pageable sequence of <see cref="ConsumerGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConsumerGroupsResponse, ConsumerGroup> ListConsumerGroups(ClusterName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConsumerGroupsRequest request = new ListConsumerGroupsRequest
            {
                ParentAsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListConsumerGroups(request, callSettings);
        }

        /// <summary>
        /// Lists the consumer groups in a given cluster.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent cluster whose consumer groups are to be listed.
        /// Structured like
        /// `projects/{project}/locations/{location}/clusters/{cluster}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ConsumerGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConsumerGroupsResponse, ConsumerGroup> ListConsumerGroupsAsync(ClusterName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConsumerGroupsRequest request = new ListConsumerGroupsRequest
            {
                ParentAsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListConsumerGroupsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the properties of a single consumer group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConsumerGroup GetConsumerGroup(GetConsumerGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the properties of a single consumer group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConsumerGroup> GetConsumerGroupAsync(GetConsumerGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the properties of a single consumer group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConsumerGroup> GetConsumerGroupAsync(GetConsumerGroupRequest request, st::CancellationToken cancellationToken) =>
            GetConsumerGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the properties of a single consumer group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the consumer group whose configuration to return.
        /// `projects/{project}/locations/{location}/clusters/{cluster}/consumerGroups/{consumerGroup}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConsumerGroup GetConsumerGroup(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConsumerGroup(new GetConsumerGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the properties of a single consumer group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the consumer group whose configuration to return.
        /// `projects/{project}/locations/{location}/clusters/{cluster}/consumerGroups/{consumerGroup}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConsumerGroup> GetConsumerGroupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConsumerGroupAsync(new GetConsumerGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the properties of a single consumer group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the consumer group whose configuration to return.
        /// `projects/{project}/locations/{location}/clusters/{cluster}/consumerGroups/{consumerGroup}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConsumerGroup> GetConsumerGroupAsync(string name, st::CancellationToken cancellationToken) =>
            GetConsumerGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the properties of a single consumer group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the consumer group whose configuration to return.
        /// `projects/{project}/locations/{location}/clusters/{cluster}/consumerGroups/{consumerGroup}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConsumerGroup GetConsumerGroup(ConsumerGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConsumerGroup(new GetConsumerGroupRequest
            {
                ConsumerGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the properties of a single consumer group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the consumer group whose configuration to return.
        /// `projects/{project}/locations/{location}/clusters/{cluster}/consumerGroups/{consumerGroup}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConsumerGroup> GetConsumerGroupAsync(ConsumerGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConsumerGroupAsync(new GetConsumerGroupRequest
            {
                ConsumerGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the properties of a single consumer group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the consumer group whose configuration to return.
        /// `projects/{project}/locations/{location}/clusters/{cluster}/consumerGroups/{consumerGroup}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConsumerGroup> GetConsumerGroupAsync(ConsumerGroupName name, st::CancellationToken cancellationToken) =>
            GetConsumerGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the properties of a single consumer group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConsumerGroup UpdateConsumerGroup(UpdateConsumerGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the properties of a single consumer group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConsumerGroup> UpdateConsumerGroupAsync(UpdateConsumerGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the properties of a single consumer group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConsumerGroup> UpdateConsumerGroupAsync(UpdateConsumerGroupRequest request, st::CancellationToken cancellationToken) =>
            UpdateConsumerGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the properties of a single consumer group.
        /// </summary>
        /// <param name="consumerGroup">
        /// Required. The consumer group to update. Its `name` field must be populated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// ConsumerGroup resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. The
        /// mask is required and a value of * will update all fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConsumerGroup UpdateConsumerGroup(ConsumerGroup consumerGroup, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConsumerGroup(new UpdateConsumerGroupRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                ConsumerGroup = gax::GaxPreconditions.CheckNotNull(consumerGroup, nameof(consumerGroup)),
            }, callSettings);

        /// <summary>
        /// Updates the properties of a single consumer group.
        /// </summary>
        /// <param name="consumerGroup">
        /// Required. The consumer group to update. Its `name` field must be populated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// ConsumerGroup resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. The
        /// mask is required and a value of * will update all fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConsumerGroup> UpdateConsumerGroupAsync(ConsumerGroup consumerGroup, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConsumerGroupAsync(new UpdateConsumerGroupRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                ConsumerGroup = gax::GaxPreconditions.CheckNotNull(consumerGroup, nameof(consumerGroup)),
            }, callSettings);

        /// <summary>
        /// Updates the properties of a single consumer group.
        /// </summary>
        /// <param name="consumerGroup">
        /// Required. The consumer group to update. Its `name` field must be populated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// ConsumerGroup resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. The
        /// mask is required and a value of * will update all fields.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConsumerGroup> UpdateConsumerGroupAsync(ConsumerGroup consumerGroup, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateConsumerGroupAsync(consumerGroup, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single consumer group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteConsumerGroup(DeleteConsumerGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single consumer group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConsumerGroupAsync(DeleteConsumerGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single consumer group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConsumerGroupAsync(DeleteConsumerGroupRequest request, st::CancellationToken cancellationToken) =>
            DeleteConsumerGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single consumer group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the consumer group to delete.
        /// `projects/{project}/locations/{location}/clusters/{cluster}/consumerGroups/{consumerGroup}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteConsumerGroup(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConsumerGroup(new DeleteConsumerGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single consumer group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the consumer group to delete.
        /// `projects/{project}/locations/{location}/clusters/{cluster}/consumerGroups/{consumerGroup}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConsumerGroupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConsumerGroupAsync(new DeleteConsumerGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single consumer group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the consumer group to delete.
        /// `projects/{project}/locations/{location}/clusters/{cluster}/consumerGroups/{consumerGroup}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConsumerGroupAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteConsumerGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single consumer group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the consumer group to delete.
        /// `projects/{project}/locations/{location}/clusters/{cluster}/consumerGroups/{consumerGroup}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteConsumerGroup(ConsumerGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConsumerGroup(new DeleteConsumerGroupRequest
            {
                ConsumerGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single consumer group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the consumer group to delete.
        /// `projects/{project}/locations/{location}/clusters/{cluster}/consumerGroups/{consumerGroup}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConsumerGroupAsync(ConsumerGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConsumerGroupAsync(new DeleteConsumerGroupRequest
            {
                ConsumerGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single consumer group.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the consumer group to delete.
        /// `projects/{project}/locations/{location}/clusters/{cluster}/consumerGroups/{consumerGroup}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConsumerGroupAsync(ConsumerGroupName name, st::CancellationToken cancellationToken) =>
            DeleteConsumerGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ManagedKafka client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The service that a client application uses to manage Apache Kafka clusters,
    /// topics and consumer groups.
    /// </remarks>
    public sealed partial class ManagedKafkaClientImpl : ManagedKafkaClient
    {
        private readonly gaxgrpc::ApiCall<ListClustersRequest, ListClustersResponse> _callListClusters;

        private readonly gaxgrpc::ApiCall<GetClusterRequest, Cluster> _callGetCluster;

        private readonly gaxgrpc::ApiCall<CreateClusterRequest, lro::Operation> _callCreateCluster;

        private readonly gaxgrpc::ApiCall<UpdateClusterRequest, lro::Operation> _callUpdateCluster;

        private readonly gaxgrpc::ApiCall<DeleteClusterRequest, lro::Operation> _callDeleteCluster;

        private readonly gaxgrpc::ApiCall<ListTopicsRequest, ListTopicsResponse> _callListTopics;

        private readonly gaxgrpc::ApiCall<GetTopicRequest, Topic> _callGetTopic;

        private readonly gaxgrpc::ApiCall<CreateTopicRequest, Topic> _callCreateTopic;

        private readonly gaxgrpc::ApiCall<UpdateTopicRequest, Topic> _callUpdateTopic;

        private readonly gaxgrpc::ApiCall<DeleteTopicRequest, wkt::Empty> _callDeleteTopic;

        private readonly gaxgrpc::ApiCall<ListConsumerGroupsRequest, ListConsumerGroupsResponse> _callListConsumerGroups;

        private readonly gaxgrpc::ApiCall<GetConsumerGroupRequest, ConsumerGroup> _callGetConsumerGroup;

        private readonly gaxgrpc::ApiCall<UpdateConsumerGroupRequest, ConsumerGroup> _callUpdateConsumerGroup;

        private readonly gaxgrpc::ApiCall<DeleteConsumerGroupRequest, wkt::Empty> _callDeleteConsumerGroup;

        /// <summary>
        /// Constructs a client wrapper for the ManagedKafka service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ManagedKafkaSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ManagedKafkaClientImpl(ManagedKafka.ManagedKafkaClient grpcClient, ManagedKafkaSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ManagedKafkaSettings effectiveSettings = settings ?? ManagedKafkaSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateClusterOperationsSettings, logger);
            UpdateClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateClusterOperationsSettings, logger);
            DeleteClusterOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteClusterOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListClusters = clientHelper.BuildApiCall<ListClustersRequest, ListClustersResponse>("ListClusters", grpcClient.ListClustersAsync, grpcClient.ListClusters, effectiveSettings.ListClustersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListClusters);
            Modify_ListClustersApiCall(ref _callListClusters);
            _callGetCluster = clientHelper.BuildApiCall<GetClusterRequest, Cluster>("GetCluster", grpcClient.GetClusterAsync, grpcClient.GetCluster, effectiveSettings.GetClusterSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCluster);
            Modify_GetClusterApiCall(ref _callGetCluster);
            _callCreateCluster = clientHelper.BuildApiCall<CreateClusterRequest, lro::Operation>("CreateCluster", grpcClient.CreateClusterAsync, grpcClient.CreateCluster, effectiveSettings.CreateClusterSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCluster);
            Modify_CreateClusterApiCall(ref _callCreateCluster);
            _callUpdateCluster = clientHelper.BuildApiCall<UpdateClusterRequest, lro::Operation>("UpdateCluster", grpcClient.UpdateClusterAsync, grpcClient.UpdateCluster, effectiveSettings.UpdateClusterSettings).WithGoogleRequestParam("cluster.name", request => request.Cluster?.Name);
            Modify_ApiCall(ref _callUpdateCluster);
            Modify_UpdateClusterApiCall(ref _callUpdateCluster);
            _callDeleteCluster = clientHelper.BuildApiCall<DeleteClusterRequest, lro::Operation>("DeleteCluster", grpcClient.DeleteClusterAsync, grpcClient.DeleteCluster, effectiveSettings.DeleteClusterSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteCluster);
            Modify_DeleteClusterApiCall(ref _callDeleteCluster);
            _callListTopics = clientHelper.BuildApiCall<ListTopicsRequest, ListTopicsResponse>("ListTopics", grpcClient.ListTopicsAsync, grpcClient.ListTopics, effectiveSettings.ListTopicsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTopics);
            Modify_ListTopicsApiCall(ref _callListTopics);
            _callGetTopic = clientHelper.BuildApiCall<GetTopicRequest, Topic>("GetTopic", grpcClient.GetTopicAsync, grpcClient.GetTopic, effectiveSettings.GetTopicSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTopic);
            Modify_GetTopicApiCall(ref _callGetTopic);
            _callCreateTopic = clientHelper.BuildApiCall<CreateTopicRequest, Topic>("CreateTopic", grpcClient.CreateTopicAsync, grpcClient.CreateTopic, effectiveSettings.CreateTopicSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTopic);
            Modify_CreateTopicApiCall(ref _callCreateTopic);
            _callUpdateTopic = clientHelper.BuildApiCall<UpdateTopicRequest, Topic>("UpdateTopic", grpcClient.UpdateTopicAsync, grpcClient.UpdateTopic, effectiveSettings.UpdateTopicSettings).WithGoogleRequestParam("topic.name", request => request.Topic?.Name);
            Modify_ApiCall(ref _callUpdateTopic);
            Modify_UpdateTopicApiCall(ref _callUpdateTopic);
            _callDeleteTopic = clientHelper.BuildApiCall<DeleteTopicRequest, wkt::Empty>("DeleteTopic", grpcClient.DeleteTopicAsync, grpcClient.DeleteTopic, effectiveSettings.DeleteTopicSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTopic);
            Modify_DeleteTopicApiCall(ref _callDeleteTopic);
            _callListConsumerGroups = clientHelper.BuildApiCall<ListConsumerGroupsRequest, ListConsumerGroupsResponse>("ListConsumerGroups", grpcClient.ListConsumerGroupsAsync, grpcClient.ListConsumerGroups, effectiveSettings.ListConsumerGroupsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListConsumerGroups);
            Modify_ListConsumerGroupsApiCall(ref _callListConsumerGroups);
            _callGetConsumerGroup = clientHelper.BuildApiCall<GetConsumerGroupRequest, ConsumerGroup>("GetConsumerGroup", grpcClient.GetConsumerGroupAsync, grpcClient.GetConsumerGroup, effectiveSettings.GetConsumerGroupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetConsumerGroup);
            Modify_GetConsumerGroupApiCall(ref _callGetConsumerGroup);
            _callUpdateConsumerGroup = clientHelper.BuildApiCall<UpdateConsumerGroupRequest, ConsumerGroup>("UpdateConsumerGroup", grpcClient.UpdateConsumerGroupAsync, grpcClient.UpdateConsumerGroup, effectiveSettings.UpdateConsumerGroupSettings).WithGoogleRequestParam("consumer_group.name", request => request.ConsumerGroup?.Name);
            Modify_ApiCall(ref _callUpdateConsumerGroup);
            Modify_UpdateConsumerGroupApiCall(ref _callUpdateConsumerGroup);
            _callDeleteConsumerGroup = clientHelper.BuildApiCall<DeleteConsumerGroupRequest, wkt::Empty>("DeleteConsumerGroup", grpcClient.DeleteConsumerGroupAsync, grpcClient.DeleteConsumerGroup, effectiveSettings.DeleteConsumerGroupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteConsumerGroup);
            Modify_DeleteConsumerGroupApiCall(ref _callDeleteConsumerGroup);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListClustersApiCall(ref gaxgrpc::ApiCall<ListClustersRequest, ListClustersResponse> call);

        partial void Modify_GetClusterApiCall(ref gaxgrpc::ApiCall<GetClusterRequest, Cluster> call);

        partial void Modify_CreateClusterApiCall(ref gaxgrpc::ApiCall<CreateClusterRequest, lro::Operation> call);

        partial void Modify_UpdateClusterApiCall(ref gaxgrpc::ApiCall<UpdateClusterRequest, lro::Operation> call);

        partial void Modify_DeleteClusterApiCall(ref gaxgrpc::ApiCall<DeleteClusterRequest, lro::Operation> call);

        partial void Modify_ListTopicsApiCall(ref gaxgrpc::ApiCall<ListTopicsRequest, ListTopicsResponse> call);

        partial void Modify_GetTopicApiCall(ref gaxgrpc::ApiCall<GetTopicRequest, Topic> call);

        partial void Modify_CreateTopicApiCall(ref gaxgrpc::ApiCall<CreateTopicRequest, Topic> call);

        partial void Modify_UpdateTopicApiCall(ref gaxgrpc::ApiCall<UpdateTopicRequest, Topic> call);

        partial void Modify_DeleteTopicApiCall(ref gaxgrpc::ApiCall<DeleteTopicRequest, wkt::Empty> call);

        partial void Modify_ListConsumerGroupsApiCall(ref gaxgrpc::ApiCall<ListConsumerGroupsRequest, ListConsumerGroupsResponse> call);

        partial void Modify_GetConsumerGroupApiCall(ref gaxgrpc::ApiCall<GetConsumerGroupRequest, ConsumerGroup> call);

        partial void Modify_UpdateConsumerGroupApiCall(ref gaxgrpc::ApiCall<UpdateConsumerGroupRequest, ConsumerGroup> call);

        partial void Modify_DeleteConsumerGroupApiCall(ref gaxgrpc::ApiCall<DeleteConsumerGroupRequest, wkt::Empty> call);

        partial void OnConstruction(ManagedKafka.ManagedKafkaClient grpcClient, ManagedKafkaSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ManagedKafka client</summary>
        public override ManagedKafka.ManagedKafkaClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListClustersRequest(ref ListClustersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetClusterRequest(ref GetClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateClusterRequest(ref CreateClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateClusterRequest(ref UpdateClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteClusterRequest(ref DeleteClusterRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTopicsRequest(ref ListTopicsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTopicRequest(ref GetTopicRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateTopicRequest(ref CreateTopicRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateTopicRequest(ref UpdateTopicRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTopicRequest(ref DeleteTopicRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListConsumerGroupsRequest(ref ListConsumerGroupsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetConsumerGroupRequest(ref GetConsumerGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateConsumerGroupRequest(ref UpdateConsumerGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteConsumerGroupRequest(ref DeleteConsumerGroupRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists the clusters in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Cluster"/> resources.</returns>
        public override gax::PagedEnumerable<ListClustersResponse, Cluster> ListClusters(ListClustersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListClustersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListClustersRequest, ListClustersResponse, Cluster>(_callListClusters, request, callSettings);
        }

        /// <summary>
        /// Lists the clusters in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Cluster"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListClustersResponse, Cluster> ListClustersAsync(ListClustersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListClustersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListClustersRequest, ListClustersResponse, Cluster>(_callListClusters, request, callSettings);
        }

        /// <summary>
        /// Returns the properties of a single cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Cluster GetCluster(GetClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetClusterRequest(ref request, ref callSettings);
            return _callGetCluster.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the properties of a single cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Cluster> GetClusterAsync(GetClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetClusterRequest(ref request, ref callSettings);
            return _callGetCluster.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateCluster</c>.</summary>
        public override lro::OperationsClient CreateClusterOperationsClient { get; }

        /// <summary>
        /// Creates a new cluster in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Cluster, OperationMetadata> CreateCluster(CreateClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateClusterRequest(ref request, ref callSettings);
            return new lro::Operation<Cluster, OperationMetadata>(_callCreateCluster.Sync(request, callSettings), CreateClusterOperationsClient);
        }

        /// <summary>
        /// Creates a new cluster in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Cluster, OperationMetadata>> CreateClusterAsync(CreateClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateClusterRequest(ref request, ref callSettings);
            return new lro::Operation<Cluster, OperationMetadata>(await _callCreateCluster.Async(request, callSettings).ConfigureAwait(false), CreateClusterOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateCluster</c>.</summary>
        public override lro::OperationsClient UpdateClusterOperationsClient { get; }

        /// <summary>
        /// Updates the properties of a single cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Cluster, OperationMetadata> UpdateCluster(UpdateClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateClusterRequest(ref request, ref callSettings);
            return new lro::Operation<Cluster, OperationMetadata>(_callUpdateCluster.Sync(request, callSettings), UpdateClusterOperationsClient);
        }

        /// <summary>
        /// Updates the properties of a single cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Cluster, OperationMetadata>> UpdateClusterAsync(UpdateClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateClusterRequest(ref request, ref callSettings);
            return new lro::Operation<Cluster, OperationMetadata>(await _callUpdateCluster.Async(request, callSettings).ConfigureAwait(false), UpdateClusterOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteCluster</c>.</summary>
        public override lro::OperationsClient DeleteClusterOperationsClient { get; }

        /// <summary>
        /// Deletes a single cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteCluster(DeleteClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteClusterRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteCluster.Sync(request, callSettings), DeleteClusterOperationsClient);
        }

        /// <summary>
        /// Deletes a single cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteClusterAsync(DeleteClusterRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteClusterRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteCluster.Async(request, callSettings).ConfigureAwait(false), DeleteClusterOperationsClient);
        }

        /// <summary>
        /// Lists the topics in a given cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Topic"/> resources.</returns>
        public override gax::PagedEnumerable<ListTopicsResponse, Topic> ListTopics(ListTopicsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTopicsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTopicsRequest, ListTopicsResponse, Topic>(_callListTopics, request, callSettings);
        }

        /// <summary>
        /// Lists the topics in a given cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Topic"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTopicsResponse, Topic> ListTopicsAsync(ListTopicsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTopicsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTopicsRequest, ListTopicsResponse, Topic>(_callListTopics, request, callSettings);
        }

        /// <summary>
        /// Returns the properties of a single topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Topic GetTopic(GetTopicRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTopicRequest(ref request, ref callSettings);
            return _callGetTopic.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the properties of a single topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Topic> GetTopicAsync(GetTopicRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTopicRequest(ref request, ref callSettings);
            return _callGetTopic.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new topic in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Topic CreateTopic(CreateTopicRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTopicRequest(ref request, ref callSettings);
            return _callCreateTopic.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new topic in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Topic> CreateTopicAsync(CreateTopicRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTopicRequest(ref request, ref callSettings);
            return _callCreateTopic.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the properties of a single topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Topic UpdateTopic(UpdateTopicRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTopicRequest(ref request, ref callSettings);
            return _callUpdateTopic.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the properties of a single topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Topic> UpdateTopicAsync(UpdateTopicRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTopicRequest(ref request, ref callSettings);
            return _callUpdateTopic.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a single topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteTopic(DeleteTopicRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTopicRequest(ref request, ref callSettings);
            _callDeleteTopic.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a single topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteTopicAsync(DeleteTopicRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTopicRequest(ref request, ref callSettings);
            return _callDeleteTopic.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the consumer groups in a given cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ConsumerGroup"/> resources.</returns>
        public override gax::PagedEnumerable<ListConsumerGroupsResponse, ConsumerGroup> ListConsumerGroups(ListConsumerGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConsumerGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListConsumerGroupsRequest, ListConsumerGroupsResponse, ConsumerGroup>(_callListConsumerGroups, request, callSettings);
        }

        /// <summary>
        /// Lists the consumer groups in a given cluster.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ConsumerGroup"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListConsumerGroupsResponse, ConsumerGroup> ListConsumerGroupsAsync(ListConsumerGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConsumerGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListConsumerGroupsRequest, ListConsumerGroupsResponse, ConsumerGroup>(_callListConsumerGroups, request, callSettings);
        }

        /// <summary>
        /// Returns the properties of a single consumer group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ConsumerGroup GetConsumerGroup(GetConsumerGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConsumerGroupRequest(ref request, ref callSettings);
            return _callGetConsumerGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the properties of a single consumer group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ConsumerGroup> GetConsumerGroupAsync(GetConsumerGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConsumerGroupRequest(ref request, ref callSettings);
            return _callGetConsumerGroup.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the properties of a single consumer group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ConsumerGroup UpdateConsumerGroup(UpdateConsumerGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConsumerGroupRequest(ref request, ref callSettings);
            return _callUpdateConsumerGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the properties of a single consumer group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ConsumerGroup> UpdateConsumerGroupAsync(UpdateConsumerGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConsumerGroupRequest(ref request, ref callSettings);
            return _callUpdateConsumerGroup.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a single consumer group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteConsumerGroup(DeleteConsumerGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConsumerGroupRequest(ref request, ref callSettings);
            _callDeleteConsumerGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a single consumer group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteConsumerGroupAsync(DeleteConsumerGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConsumerGroupRequest(ref request, ref callSettings);
            return _callDeleteConsumerGroup.Async(request, callSettings);
        }
    }

    public partial class ListClustersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTopicsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListConsumerGroupsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListClustersResponse : gaxgrpc::IPageResponse<Cluster>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Cluster> GetEnumerator() => Clusters.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTopicsResponse : gaxgrpc::IPageResponse<Topic>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Topic> GetEnumerator() => Topics.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListConsumerGroupsResponse : gaxgrpc::IPageResponse<ConsumerGroup>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ConsumerGroup> GetEnumerator() => ConsumerGroups.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ManagedKafka
    {
        public partial class ManagedKafkaClient
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

    public static partial class ManagedKafka
    {
        public partial class ManagedKafkaClient
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
