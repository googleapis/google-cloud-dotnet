// Copyright 2019 Google LLC
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
using pb = Google.Protobuf;
using pbwkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Monitoring.V3
{
    /// <summary>
    /// Settings for a <see cref="MetricServiceClient"/>.
    /// </summary>
    public sealed partial class MetricServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="MetricServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="MetricServiceSettings"/>.
        /// </returns>
        public static MetricServiceSettings GetDefault() => new MetricServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="MetricServiceSettings"/> object with default settings.
        /// </summary>
        public MetricServiceSettings() { }

        private MetricServiceSettings(MetricServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListMonitoredResourceDescriptorsSettings = existing.ListMonitoredResourceDescriptorsSettings;
            GetMonitoredResourceDescriptorSettings = existing.GetMonitoredResourceDescriptorSettings;
            ListMetricDescriptorsSettings = existing.ListMetricDescriptorsSettings;
            GetMetricDescriptorSettings = existing.GetMetricDescriptorSettings;
            CreateMetricDescriptorSettings = existing.CreateMetricDescriptorSettings;
            DeleteMetricDescriptorSettings = existing.DeleteMetricDescriptorSettings;
            ListTimeSeriesSettings = existing.ListTimeSeriesSettings;
            CreateTimeSeriesSettings = existing.CreateTimeSeriesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(MetricServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="MetricServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> IdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="MetricServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="MetricServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="MetricServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="MetricServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(100),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="MetricServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="MetricServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="MetricServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 20000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(20000),
            maxDelay: sys::TimeSpan.FromMilliseconds(20000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricServiceClient.ListMonitoredResourceDescriptors</c> and <c>MetricServiceClient.ListMonitoredResourceDescriptorsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>MetricServiceClient.ListMonitoredResourceDescriptors</c> and
        /// <c>MetricServiceClient.ListMonitoredResourceDescriptorsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListMonitoredResourceDescriptorsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricServiceClient.GetMonitoredResourceDescriptor</c> and <c>MetricServiceClient.GetMonitoredResourceDescriptorAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>MetricServiceClient.GetMonitoredResourceDescriptor</c> and
        /// <c>MetricServiceClient.GetMonitoredResourceDescriptorAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetMonitoredResourceDescriptorSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricServiceClient.ListMetricDescriptors</c> and <c>MetricServiceClient.ListMetricDescriptorsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>MetricServiceClient.ListMetricDescriptors</c> and
        /// <c>MetricServiceClient.ListMetricDescriptorsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListMetricDescriptorsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricServiceClient.GetMetricDescriptor</c> and <c>MetricServiceClient.GetMetricDescriptorAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>MetricServiceClient.GetMetricDescriptor</c> and
        /// <c>MetricServiceClient.GetMetricDescriptorAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetMetricDescriptorSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricServiceClient.CreateMetricDescriptor</c> and <c>MetricServiceClient.CreateMetricDescriptorAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>MetricServiceClient.CreateMetricDescriptor</c> and
        /// <c>MetricServiceClient.CreateMetricDescriptorAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings CreateMetricDescriptorSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricServiceClient.DeleteMetricDescriptor</c> and <c>MetricServiceClient.DeleteMetricDescriptorAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>MetricServiceClient.DeleteMetricDescriptor</c> and
        /// <c>MetricServiceClient.DeleteMetricDescriptorAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings DeleteMetricDescriptorSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricServiceClient.ListTimeSeries</c> and <c>MetricServiceClient.ListTimeSeriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>MetricServiceClient.ListTimeSeries</c> and
        /// <c>MetricServiceClient.ListTimeSeriesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListTimeSeriesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricServiceClient.CreateTimeSeries</c> and <c>MetricServiceClient.CreateTimeSeriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>MetricServiceClient.CreateTimeSeries</c> and
        /// <c>MetricServiceClient.CreateTimeSeriesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings CreateTimeSeriesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="MetricServiceSettings"/> object.</returns>
        public MetricServiceSettings Clone() => new MetricServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="MetricServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class MetricServiceClientBuilder : gaxgrpc::ClientBuilderBase<MetricServiceClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public MetricServiceSettings Settings { get; set; }

        /// <inheritdoc/>
        public override MetricServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return MetricServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<MetricServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return MetricServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => MetricServiceClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => MetricServiceClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => MetricServiceClient.ChannelPool;
    }

    /// <summary>
    /// MetricService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class MetricServiceClient
    {
        /// <summary>
        /// The default endpoint for the MetricService service, which is a host of "monitoring.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("monitoring.googleapis.com", 443);

        /// <summary>
        /// The default MetricService scopes.
        /// </summary>
        /// <remarks>
        /// The default MetricService scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/monitoring"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/monitoring.read"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/monitoring.write"</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/monitoring",
            "https://www.googleapis.com/auth/monitoring.read",
            "https://www.googleapis.com/auth/monitoring.write",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="MetricServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Monitoring.V3;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// MetricServiceClient client = await MetricServiceClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Monitoring.V3;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     MetricServiceClient.DefaultEndpoint.Host, MetricServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// MetricServiceClient client = MetricServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="MetricServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="MetricServiceClient"/>.</returns>
        public static async stt::Task<MetricServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, MetricServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="MetricServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Monitoring.V3;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// MetricServiceClient client = MetricServiceClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Monitoring.V3;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     MetricServiceClient.DefaultEndpoint.Host, MetricServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// MetricServiceClient client = MetricServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="MetricServiceSettings"/>.</param>
        /// <returns>The created <see cref="MetricServiceClient"/>.</returns>
        public static MetricServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, MetricServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="MetricServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="MetricServiceSettings"/>.</param>
        /// <returns>The created <see cref="MetricServiceClient"/>.</returns>
        public static MetricServiceClient Create(grpccore::Channel channel, MetricServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="MetricServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="MetricServiceSettings"/>.</param>
        /// <returns>The created <see cref="MetricServiceClient"/>.</returns>
        public static MetricServiceClient Create(grpccore::CallInvoker callInvoker, MetricServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            MetricService.MetricServiceClient grpcClient = new MetricService.MetricServiceClient(callInvoker);
            return new MetricServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, MetricServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, MetricServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, MetricServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, MetricServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC MetricService client.
        /// </summary>
        public virtual MetricService.MetricServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Lists monitored resource descriptors that match a filter. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name">
        /// The project on which to execute the request. The format is
        /// `"projects/{project_id_or_number}"`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ga::MonitoredResourceDescriptor"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListMonitoredResourceDescriptorsResponse, ga::MonitoredResourceDescriptor> ListMonitoredResourceDescriptorsAsync(
            ProjectName name,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListMonitoredResourceDescriptorsAsync(
                new ListMonitoredResourceDescriptorsRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists monitored resource descriptors that match a filter. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name">
        /// The project on which to execute the request. The format is
        /// `"projects/{project_id_or_number}"`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="ga::MonitoredResourceDescriptor"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListMonitoredResourceDescriptorsResponse, ga::MonitoredResourceDescriptor> ListMonitoredResourceDescriptors(
            ProjectName name,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListMonitoredResourceDescriptors(
                new ListMonitoredResourceDescriptorsRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists monitored resource descriptors that match a filter. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name">
        /// The project on which to execute the request. The format is
        /// `"projects/{project_id_or_number}"`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ga::MonitoredResourceDescriptor"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListMonitoredResourceDescriptorsResponse, ga::MonitoredResourceDescriptor> ListMonitoredResourceDescriptorsAsync(
            string name,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListMonitoredResourceDescriptorsAsync(
                new ListMonitoredResourceDescriptorsRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists monitored resource descriptors that match a filter. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name">
        /// The project on which to execute the request. The format is
        /// `"projects/{project_id_or_number}"`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="ga::MonitoredResourceDescriptor"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListMonitoredResourceDescriptorsResponse, ga::MonitoredResourceDescriptor> ListMonitoredResourceDescriptors(
            string name,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListMonitoredResourceDescriptors(
                new ListMonitoredResourceDescriptorsRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists monitored resource descriptors that match a filter. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ga::MonitoredResourceDescriptor"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListMonitoredResourceDescriptorsResponse, ga::MonitoredResourceDescriptor> ListMonitoredResourceDescriptorsAsync(
            ListMonitoredResourceDescriptorsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists monitored resource descriptors that match a filter. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="ga::MonitoredResourceDescriptor"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListMonitoredResourceDescriptorsResponse, ga::MonitoredResourceDescriptor> ListMonitoredResourceDescriptors(
            ListMonitoredResourceDescriptorsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets a single monitored resource descriptor. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name">
        /// The monitored resource descriptor to get.  The format is
        /// `"projects/{project_id_or_number}/monitoredResourceDescriptors/{resource_type}"`.
        /// The `{resource_type}` is a predefined type, such as
        /// `cloudsql_database`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ga::MonitoredResourceDescriptor> GetMonitoredResourceDescriptorAsync(
            MonitoredResourceDescriptorName name,
            gaxgrpc::CallSettings callSettings = null) => GetMonitoredResourceDescriptorAsync(
                new GetMonitoredResourceDescriptorRequest
                {
                    MonitoredResourceDescriptorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a single monitored resource descriptor. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name">
        /// The monitored resource descriptor to get.  The format is
        /// `"projects/{project_id_or_number}/monitoredResourceDescriptors/{resource_type}"`.
        /// The `{resource_type}` is a predefined type, such as
        /// `cloudsql_database`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ga::MonitoredResourceDescriptor> GetMonitoredResourceDescriptorAsync(
            MonitoredResourceDescriptorName name,
            st::CancellationToken cancellationToken) => GetMonitoredResourceDescriptorAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single monitored resource descriptor. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name">
        /// The monitored resource descriptor to get.  The format is
        /// `"projects/{project_id_or_number}/monitoredResourceDescriptors/{resource_type}"`.
        /// The `{resource_type}` is a predefined type, such as
        /// `cloudsql_database`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ga::MonitoredResourceDescriptor GetMonitoredResourceDescriptor(
            MonitoredResourceDescriptorName name,
            gaxgrpc::CallSettings callSettings = null) => GetMonitoredResourceDescriptor(
                new GetMonitoredResourceDescriptorRequest
                {
                    MonitoredResourceDescriptorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a single monitored resource descriptor. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name">
        /// The monitored resource descriptor to get.  The format is
        /// `"projects/{project_id_or_number}/monitoredResourceDescriptors/{resource_type}"`.
        /// The `{resource_type}` is a predefined type, such as
        /// `cloudsql_database`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ga::MonitoredResourceDescriptor> GetMonitoredResourceDescriptorAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetMonitoredResourceDescriptorAsync(
                new GetMonitoredResourceDescriptorRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a single monitored resource descriptor. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name">
        /// The monitored resource descriptor to get.  The format is
        /// `"projects/{project_id_or_number}/monitoredResourceDescriptors/{resource_type}"`.
        /// The `{resource_type}` is a predefined type, such as
        /// `cloudsql_database`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ga::MonitoredResourceDescriptor> GetMonitoredResourceDescriptorAsync(
            string name,
            st::CancellationToken cancellationToken) => GetMonitoredResourceDescriptorAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single monitored resource descriptor. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name">
        /// The monitored resource descriptor to get.  The format is
        /// `"projects/{project_id_or_number}/monitoredResourceDescriptors/{resource_type}"`.
        /// The `{resource_type}` is a predefined type, such as
        /// `cloudsql_database`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ga::MonitoredResourceDescriptor GetMonitoredResourceDescriptor(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetMonitoredResourceDescriptor(
                new GetMonitoredResourceDescriptorRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a single monitored resource descriptor. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ga::MonitoredResourceDescriptor> GetMonitoredResourceDescriptorAsync(
            GetMonitoredResourceDescriptorRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets a single monitored resource descriptor. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ga::MonitoredResourceDescriptor> GetMonitoredResourceDescriptorAsync(
            GetMonitoredResourceDescriptorRequest request,
            st::CancellationToken cancellationToken) => GetMonitoredResourceDescriptorAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single monitored resource descriptor. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ga::MonitoredResourceDescriptor GetMonitoredResourceDescriptor(
            GetMonitoredResourceDescriptorRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists metric descriptors that match a filter. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name">
        /// The project on which to execute the request. The format is
        /// `"projects/{project_id_or_number}"`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ga::MetricDescriptor"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListMetricDescriptorsResponse, ga::MetricDescriptor> ListMetricDescriptorsAsync(
            ProjectName name,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListMetricDescriptorsAsync(
                new ListMetricDescriptorsRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists metric descriptors that match a filter. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name">
        /// The project on which to execute the request. The format is
        /// `"projects/{project_id_or_number}"`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="ga::MetricDescriptor"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListMetricDescriptorsResponse, ga::MetricDescriptor> ListMetricDescriptors(
            ProjectName name,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListMetricDescriptors(
                new ListMetricDescriptorsRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists metric descriptors that match a filter. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name">
        /// The project on which to execute the request. The format is
        /// `"projects/{project_id_or_number}"`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ga::MetricDescriptor"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListMetricDescriptorsResponse, ga::MetricDescriptor> ListMetricDescriptorsAsync(
            string name,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListMetricDescriptorsAsync(
                new ListMetricDescriptorsRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists metric descriptors that match a filter. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name">
        /// The project on which to execute the request. The format is
        /// `"projects/{project_id_or_number}"`.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="ga::MetricDescriptor"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListMetricDescriptorsResponse, ga::MetricDescriptor> ListMetricDescriptors(
            string name,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListMetricDescriptors(
                new ListMetricDescriptorsRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists metric descriptors that match a filter. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ga::MetricDescriptor"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListMetricDescriptorsResponse, ga::MetricDescriptor> ListMetricDescriptorsAsync(
            ListMetricDescriptorsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists metric descriptors that match a filter. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="ga::MetricDescriptor"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListMetricDescriptorsResponse, ga::MetricDescriptor> ListMetricDescriptors(
            ListMetricDescriptorsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets a single metric descriptor. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name">
        /// The metric descriptor on which to execute the request. The format is
        /// `"projects/{project_id_or_number}/metricDescriptors/{metric_id}"`.
        /// An example value of `{metric_id}` is
        /// `"compute.googleapis.com/instance/disk/read_bytes_count"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ga::MetricDescriptor> GetMetricDescriptorAsync(
            MetricDescriptorName name,
            gaxgrpc::CallSettings callSettings = null) => GetMetricDescriptorAsync(
                new GetMetricDescriptorRequest
                {
                    MetricDescriptorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a single metric descriptor. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name">
        /// The metric descriptor on which to execute the request. The format is
        /// `"projects/{project_id_or_number}/metricDescriptors/{metric_id}"`.
        /// An example value of `{metric_id}` is
        /// `"compute.googleapis.com/instance/disk/read_bytes_count"`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ga::MetricDescriptor> GetMetricDescriptorAsync(
            MetricDescriptorName name,
            st::CancellationToken cancellationToken) => GetMetricDescriptorAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single metric descriptor. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name">
        /// The metric descriptor on which to execute the request. The format is
        /// `"projects/{project_id_or_number}/metricDescriptors/{metric_id}"`.
        /// An example value of `{metric_id}` is
        /// `"compute.googleapis.com/instance/disk/read_bytes_count"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ga::MetricDescriptor GetMetricDescriptor(
            MetricDescriptorName name,
            gaxgrpc::CallSettings callSettings = null) => GetMetricDescriptor(
                new GetMetricDescriptorRequest
                {
                    MetricDescriptorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a single metric descriptor. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name">
        /// The metric descriptor on which to execute the request. The format is
        /// `"projects/{project_id_or_number}/metricDescriptors/{metric_id}"`.
        /// An example value of `{metric_id}` is
        /// `"compute.googleapis.com/instance/disk/read_bytes_count"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ga::MetricDescriptor> GetMetricDescriptorAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetMetricDescriptorAsync(
                new GetMetricDescriptorRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a single metric descriptor. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name">
        /// The metric descriptor on which to execute the request. The format is
        /// `"projects/{project_id_or_number}/metricDescriptors/{metric_id}"`.
        /// An example value of `{metric_id}` is
        /// `"compute.googleapis.com/instance/disk/read_bytes_count"`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ga::MetricDescriptor> GetMetricDescriptorAsync(
            string name,
            st::CancellationToken cancellationToken) => GetMetricDescriptorAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single metric descriptor. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name">
        /// The metric descriptor on which to execute the request. The format is
        /// `"projects/{project_id_or_number}/metricDescriptors/{metric_id}"`.
        /// An example value of `{metric_id}` is
        /// `"compute.googleapis.com/instance/disk/read_bytes_count"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ga::MetricDescriptor GetMetricDescriptor(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetMetricDescriptor(
                new GetMetricDescriptorRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a single metric descriptor. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ga::MetricDescriptor> GetMetricDescriptorAsync(
            GetMetricDescriptorRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets a single metric descriptor. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ga::MetricDescriptor> GetMetricDescriptorAsync(
            GetMetricDescriptorRequest request,
            st::CancellationToken cancellationToken) => GetMetricDescriptorAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single metric descriptor. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ga::MetricDescriptor GetMetricDescriptor(
            GetMetricDescriptorRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a new metric descriptor.
        /// User-created metric descriptors define
        /// [custom metrics](/monitoring/custom-metrics).
        /// </summary>
        /// <param name="name">
        /// The project on which to execute the request. The format is
        /// `"projects/{project_id_or_number}"`.
        /// </param>
        /// <param name="metricDescriptor">
        /// The new [custom metric](/monitoring/custom-metrics)
        /// descriptor.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ga::MetricDescriptor> CreateMetricDescriptorAsync(
            ProjectName name,
            ga::MetricDescriptor metricDescriptor,
            gaxgrpc::CallSettings callSettings = null) => CreateMetricDescriptorAsync(
                new CreateMetricDescriptorRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    MetricDescriptor = gax::GaxPreconditions.CheckNotNull(metricDescriptor, nameof(metricDescriptor)),
                },
                callSettings);

        /// <summary>
        /// Creates a new metric descriptor.
        /// User-created metric descriptors define
        /// [custom metrics](/monitoring/custom-metrics).
        /// </summary>
        /// <param name="name">
        /// The project on which to execute the request. The format is
        /// `"projects/{project_id_or_number}"`.
        /// </param>
        /// <param name="metricDescriptor">
        /// The new [custom metric](/monitoring/custom-metrics)
        /// descriptor.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ga::MetricDescriptor> CreateMetricDescriptorAsync(
            ProjectName name,
            ga::MetricDescriptor metricDescriptor,
            st::CancellationToken cancellationToken) => CreateMetricDescriptorAsync(
                name,
                metricDescriptor,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new metric descriptor.
        /// User-created metric descriptors define
        /// [custom metrics](/monitoring/custom-metrics).
        /// </summary>
        /// <param name="name">
        /// The project on which to execute the request. The format is
        /// `"projects/{project_id_or_number}"`.
        /// </param>
        /// <param name="metricDescriptor">
        /// The new [custom metric](/monitoring/custom-metrics)
        /// descriptor.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ga::MetricDescriptor CreateMetricDescriptor(
            ProjectName name,
            ga::MetricDescriptor metricDescriptor,
            gaxgrpc::CallSettings callSettings = null) => CreateMetricDescriptor(
                new CreateMetricDescriptorRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    MetricDescriptor = gax::GaxPreconditions.CheckNotNull(metricDescriptor, nameof(metricDescriptor)),
                },
                callSettings);

        /// <summary>
        /// Creates a new metric descriptor.
        /// User-created metric descriptors define
        /// [custom metrics](/monitoring/custom-metrics).
        /// </summary>
        /// <param name="name">
        /// The project on which to execute the request. The format is
        /// `"projects/{project_id_or_number}"`.
        /// </param>
        /// <param name="metricDescriptor">
        /// The new [custom metric](/monitoring/custom-metrics)
        /// descriptor.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ga::MetricDescriptor> CreateMetricDescriptorAsync(
            string name,
            ga::MetricDescriptor metricDescriptor,
            gaxgrpc::CallSettings callSettings = null) => CreateMetricDescriptorAsync(
                new CreateMetricDescriptorRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    MetricDescriptor = gax::GaxPreconditions.CheckNotNull(metricDescriptor, nameof(metricDescriptor)),
                },
                callSettings);

        /// <summary>
        /// Creates a new metric descriptor.
        /// User-created metric descriptors define
        /// [custom metrics](/monitoring/custom-metrics).
        /// </summary>
        /// <param name="name">
        /// The project on which to execute the request. The format is
        /// `"projects/{project_id_or_number}"`.
        /// </param>
        /// <param name="metricDescriptor">
        /// The new [custom metric](/monitoring/custom-metrics)
        /// descriptor.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ga::MetricDescriptor> CreateMetricDescriptorAsync(
            string name,
            ga::MetricDescriptor metricDescriptor,
            st::CancellationToken cancellationToken) => CreateMetricDescriptorAsync(
                name,
                metricDescriptor,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new metric descriptor.
        /// User-created metric descriptors define
        /// [custom metrics](/monitoring/custom-metrics).
        /// </summary>
        /// <param name="name">
        /// The project on which to execute the request. The format is
        /// `"projects/{project_id_or_number}"`.
        /// </param>
        /// <param name="metricDescriptor">
        /// The new [custom metric](/monitoring/custom-metrics)
        /// descriptor.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ga::MetricDescriptor CreateMetricDescriptor(
            string name,
            ga::MetricDescriptor metricDescriptor,
            gaxgrpc::CallSettings callSettings = null) => CreateMetricDescriptor(
                new CreateMetricDescriptorRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    MetricDescriptor = gax::GaxPreconditions.CheckNotNull(metricDescriptor, nameof(metricDescriptor)),
                },
                callSettings);

        /// <summary>
        /// Creates a new metric descriptor.
        /// User-created metric descriptors define
        /// [custom metrics](/monitoring/custom-metrics).
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ga::MetricDescriptor> CreateMetricDescriptorAsync(
            CreateMetricDescriptorRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a new metric descriptor.
        /// User-created metric descriptors define
        /// [custom metrics](/monitoring/custom-metrics).
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<ga::MetricDescriptor> CreateMetricDescriptorAsync(
            CreateMetricDescriptorRequest request,
            st::CancellationToken cancellationToken) => CreateMetricDescriptorAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new metric descriptor.
        /// User-created metric descriptors define
        /// [custom metrics](/monitoring/custom-metrics).
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual ga::MetricDescriptor CreateMetricDescriptor(
            CreateMetricDescriptorRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes a metric descriptor. Only user-created
        /// [custom metrics](/monitoring/custom-metrics) can be deleted.
        /// </summary>
        /// <param name="name">
        /// The metric descriptor on which to execute the request. The format is
        /// `"projects/{project_id_or_number}/metricDescriptors/{metric_id}"`.
        /// An example of `{metric_id}` is:
        /// `"custom.googleapis.com/my_test_metric"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteMetricDescriptorAsync(
            MetricDescriptorName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteMetricDescriptorAsync(
                new DeleteMetricDescriptorRequest
                {
                    MetricDescriptorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes a metric descriptor. Only user-created
        /// [custom metrics](/monitoring/custom-metrics) can be deleted.
        /// </summary>
        /// <param name="name">
        /// The metric descriptor on which to execute the request. The format is
        /// `"projects/{project_id_or_number}/metricDescriptors/{metric_id}"`.
        /// An example of `{metric_id}` is:
        /// `"custom.googleapis.com/my_test_metric"`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteMetricDescriptorAsync(
            MetricDescriptorName name,
            st::CancellationToken cancellationToken) => DeleteMetricDescriptorAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a metric descriptor. Only user-created
        /// [custom metrics](/monitoring/custom-metrics) can be deleted.
        /// </summary>
        /// <param name="name">
        /// The metric descriptor on which to execute the request. The format is
        /// `"projects/{project_id_or_number}/metricDescriptors/{metric_id}"`.
        /// An example of `{metric_id}` is:
        /// `"custom.googleapis.com/my_test_metric"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteMetricDescriptor(
            MetricDescriptorName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteMetricDescriptor(
                new DeleteMetricDescriptorRequest
                {
                    MetricDescriptorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes a metric descriptor. Only user-created
        /// [custom metrics](/monitoring/custom-metrics) can be deleted.
        /// </summary>
        /// <param name="name">
        /// The metric descriptor on which to execute the request. The format is
        /// `"projects/{project_id_or_number}/metricDescriptors/{metric_id}"`.
        /// An example of `{metric_id}` is:
        /// `"custom.googleapis.com/my_test_metric"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteMetricDescriptorAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteMetricDescriptorAsync(
                new DeleteMetricDescriptorRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes a metric descriptor. Only user-created
        /// [custom metrics](/monitoring/custom-metrics) can be deleted.
        /// </summary>
        /// <param name="name">
        /// The metric descriptor on which to execute the request. The format is
        /// `"projects/{project_id_or_number}/metricDescriptors/{metric_id}"`.
        /// An example of `{metric_id}` is:
        /// `"custom.googleapis.com/my_test_metric"`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteMetricDescriptorAsync(
            string name,
            st::CancellationToken cancellationToken) => DeleteMetricDescriptorAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a metric descriptor. Only user-created
        /// [custom metrics](/monitoring/custom-metrics) can be deleted.
        /// </summary>
        /// <param name="name">
        /// The metric descriptor on which to execute the request. The format is
        /// `"projects/{project_id_or_number}/metricDescriptors/{metric_id}"`.
        /// An example of `{metric_id}` is:
        /// `"custom.googleapis.com/my_test_metric"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteMetricDescriptor(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteMetricDescriptor(
                new DeleteMetricDescriptorRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes a metric descriptor. Only user-created
        /// [custom metrics](/monitoring/custom-metrics) can be deleted.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteMetricDescriptorAsync(
            DeleteMetricDescriptorRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes a metric descriptor. Only user-created
        /// [custom metrics](/monitoring/custom-metrics) can be deleted.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteMetricDescriptorAsync(
            DeleteMetricDescriptorRequest request,
            st::CancellationToken cancellationToken) => DeleteMetricDescriptorAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a metric descriptor. Only user-created
        /// [custom metrics](/monitoring/custom-metrics) can be deleted.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteMetricDescriptor(
            DeleteMetricDescriptorRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists time series that match a filter. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name">
        /// The project on which to execute the request. The format is
        /// "projects/{project_id_or_number}".
        /// </param>
        /// <param name="filter">
        /// A [monitoring filter](/monitoring/api/v3/filters) that specifies which time
        /// series should be returned.  The filter must specify a single metric type,
        /// and can additionally specify metric labels and other information. For
        /// example:
        ///
        ///     metric.type = "compute.googleapis.com/instance/cpu/usage_time" AND
        ///         metric.labels.instance_name = "my-instance-name"
        /// </param>
        /// <param name="interval">
        /// The time interval for which results should be returned. Only time series
        /// that contain data points in the specified interval are included
        /// in the response.
        /// </param>
        /// <param name="view">
        /// Specifies which information is returned about the time series.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="TimeSeries"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListTimeSeriesResponse, TimeSeries> ListTimeSeriesAsync(
            ProjectName name,
            string filter,
            TimeInterval interval,
            ListTimeSeriesRequest.Types.TimeSeriesView view,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListTimeSeriesAsync(
                new ListTimeSeriesRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                    Interval = gax::GaxPreconditions.CheckNotNull(interval, nameof(interval)),
                    View = view,
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists time series that match a filter. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name">
        /// The project on which to execute the request. The format is
        /// "projects/{project_id_or_number}".
        /// </param>
        /// <param name="filter">
        /// A [monitoring filter](/monitoring/api/v3/filters) that specifies which time
        /// series should be returned.  The filter must specify a single metric type,
        /// and can additionally specify metric labels and other information. For
        /// example:
        ///
        ///     metric.type = "compute.googleapis.com/instance/cpu/usage_time" AND
        ///         metric.labels.instance_name = "my-instance-name"
        /// </param>
        /// <param name="interval">
        /// The time interval for which results should be returned. Only time series
        /// that contain data points in the specified interval are included
        /// in the response.
        /// </param>
        /// <param name="view">
        /// Specifies which information is returned about the time series.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="TimeSeries"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListTimeSeriesResponse, TimeSeries> ListTimeSeries(
            ProjectName name,
            string filter,
            TimeInterval interval,
            ListTimeSeriesRequest.Types.TimeSeriesView view,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListTimeSeries(
                new ListTimeSeriesRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                    Interval = gax::GaxPreconditions.CheckNotNull(interval, nameof(interval)),
                    View = view,
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists time series that match a filter. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name">
        /// The project on which to execute the request. The format is
        /// "projects/{project_id_or_number}".
        /// </param>
        /// <param name="filter">
        /// A [monitoring filter](/monitoring/api/v3/filters) that specifies which time
        /// series should be returned.  The filter must specify a single metric type,
        /// and can additionally specify metric labels and other information. For
        /// example:
        ///
        ///     metric.type = "compute.googleapis.com/instance/cpu/usage_time" AND
        ///         metric.labels.instance_name = "my-instance-name"
        /// </param>
        /// <param name="interval">
        /// The time interval for which results should be returned. Only time series
        /// that contain data points in the specified interval are included
        /// in the response.
        /// </param>
        /// <param name="view">
        /// Specifies which information is returned about the time series.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="TimeSeries"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListTimeSeriesResponse, TimeSeries> ListTimeSeriesAsync(
            string name,
            string filter,
            TimeInterval interval,
            ListTimeSeriesRequest.Types.TimeSeriesView view,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListTimeSeriesAsync(
                new ListTimeSeriesRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                    Interval = gax::GaxPreconditions.CheckNotNull(interval, nameof(interval)),
                    View = view,
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists time series that match a filter. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name">
        /// The project on which to execute the request. The format is
        /// "projects/{project_id_or_number}".
        /// </param>
        /// <param name="filter">
        /// A [monitoring filter](/monitoring/api/v3/filters) that specifies which time
        /// series should be returned.  The filter must specify a single metric type,
        /// and can additionally specify metric labels and other information. For
        /// example:
        ///
        ///     metric.type = "compute.googleapis.com/instance/cpu/usage_time" AND
        ///         metric.labels.instance_name = "my-instance-name"
        /// </param>
        /// <param name="interval">
        /// The time interval for which results should be returned. Only time series
        /// that contain data points in the specified interval are included
        /// in the response.
        /// </param>
        /// <param name="view">
        /// Specifies which information is returned about the time series.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="TimeSeries"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListTimeSeriesResponse, TimeSeries> ListTimeSeries(
            string name,
            string filter,
            TimeInterval interval,
            ListTimeSeriesRequest.Types.TimeSeriesView view,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListTimeSeries(
                new ListTimeSeriesRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                    Interval = gax::GaxPreconditions.CheckNotNull(interval, nameof(interval)),
                    View = view,
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists time series that match a filter. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="TimeSeries"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListTimeSeriesResponse, TimeSeries> ListTimeSeriesAsync(
            ListTimeSeriesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists time series that match a filter. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="TimeSeries"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListTimeSeriesResponse, TimeSeries> ListTimeSeries(
            ListTimeSeriesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates or adds data to one or more time series.
        /// The response is empty if all time series in the request were written.
        /// If any time series could not be written, a corresponding failure message is
        /// included in the error response.
        /// </summary>
        /// <param name="name">
        /// The project on which to execute the request. The format is
        /// `"projects/{project_id_or_number}"`.
        /// </param>
        /// <param name="timeSeries">
        /// The new data to be added to a list of time series.
        /// Adds at most one data point to each of several time series.  The new data
        /// point must be more recent than any other point in its time series.  Each
        /// `TimeSeries` value must fully specify a unique time series by supplying
        /// all label values for the metric and the monitored resource.
        ///
        /// The maximum number of `TimeSeries` objects per `Create` request is 200.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task CreateTimeSeriesAsync(
            ProjectName name,
            scg::IEnumerable<TimeSeries> timeSeries,
            gaxgrpc::CallSettings callSettings = null) => CreateTimeSeriesAsync(
                new CreateTimeSeriesRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    TimeSeries = { gax::GaxPreconditions.CheckNotNull(timeSeries, nameof(timeSeries)) },
                },
                callSettings);

        /// <summary>
        /// Creates or adds data to one or more time series.
        /// The response is empty if all time series in the request were written.
        /// If any time series could not be written, a corresponding failure message is
        /// included in the error response.
        /// </summary>
        /// <param name="name">
        /// The project on which to execute the request. The format is
        /// `"projects/{project_id_or_number}"`.
        /// </param>
        /// <param name="timeSeries">
        /// The new data to be added to a list of time series.
        /// Adds at most one data point to each of several time series.  The new data
        /// point must be more recent than any other point in its time series.  Each
        /// `TimeSeries` value must fully specify a unique time series by supplying
        /// all label values for the metric and the monitored resource.
        ///
        /// The maximum number of `TimeSeries` objects per `Create` request is 200.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task CreateTimeSeriesAsync(
            ProjectName name,
            scg::IEnumerable<TimeSeries> timeSeries,
            st::CancellationToken cancellationToken) => CreateTimeSeriesAsync(
                name,
                timeSeries,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or adds data to one or more time series.
        /// The response is empty if all time series in the request were written.
        /// If any time series could not be written, a corresponding failure message is
        /// included in the error response.
        /// </summary>
        /// <param name="name">
        /// The project on which to execute the request. The format is
        /// `"projects/{project_id_or_number}"`.
        /// </param>
        /// <param name="timeSeries">
        /// The new data to be added to a list of time series.
        /// Adds at most one data point to each of several time series.  The new data
        /// point must be more recent than any other point in its time series.  Each
        /// `TimeSeries` value must fully specify a unique time series by supplying
        /// all label values for the metric and the monitored resource.
        ///
        /// The maximum number of `TimeSeries` objects per `Create` request is 200.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void CreateTimeSeries(
            ProjectName name,
            scg::IEnumerable<TimeSeries> timeSeries,
            gaxgrpc::CallSettings callSettings = null) => CreateTimeSeries(
                new CreateTimeSeriesRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    TimeSeries = { gax::GaxPreconditions.CheckNotNull(timeSeries, nameof(timeSeries)) },
                },
                callSettings);

        /// <summary>
        /// Creates or adds data to one or more time series.
        /// The response is empty if all time series in the request were written.
        /// If any time series could not be written, a corresponding failure message is
        /// included in the error response.
        /// </summary>
        /// <param name="name">
        /// The project on which to execute the request. The format is
        /// `"projects/{project_id_or_number}"`.
        /// </param>
        /// <param name="timeSeries">
        /// The new data to be added to a list of time series.
        /// Adds at most one data point to each of several time series.  The new data
        /// point must be more recent than any other point in its time series.  Each
        /// `TimeSeries` value must fully specify a unique time series by supplying
        /// all label values for the metric and the monitored resource.
        ///
        /// The maximum number of `TimeSeries` objects per `Create` request is 200.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task CreateTimeSeriesAsync(
            string name,
            scg::IEnumerable<TimeSeries> timeSeries,
            gaxgrpc::CallSettings callSettings = null) => CreateTimeSeriesAsync(
                new CreateTimeSeriesRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    TimeSeries = { gax::GaxPreconditions.CheckNotNull(timeSeries, nameof(timeSeries)) },
                },
                callSettings);

        /// <summary>
        /// Creates or adds data to one or more time series.
        /// The response is empty if all time series in the request were written.
        /// If any time series could not be written, a corresponding failure message is
        /// included in the error response.
        /// </summary>
        /// <param name="name">
        /// The project on which to execute the request. The format is
        /// `"projects/{project_id_or_number}"`.
        /// </param>
        /// <param name="timeSeries">
        /// The new data to be added to a list of time series.
        /// Adds at most one data point to each of several time series.  The new data
        /// point must be more recent than any other point in its time series.  Each
        /// `TimeSeries` value must fully specify a unique time series by supplying
        /// all label values for the metric and the monitored resource.
        ///
        /// The maximum number of `TimeSeries` objects per `Create` request is 200.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task CreateTimeSeriesAsync(
            string name,
            scg::IEnumerable<TimeSeries> timeSeries,
            st::CancellationToken cancellationToken) => CreateTimeSeriesAsync(
                name,
                timeSeries,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or adds data to one or more time series.
        /// The response is empty if all time series in the request were written.
        /// If any time series could not be written, a corresponding failure message is
        /// included in the error response.
        /// </summary>
        /// <param name="name">
        /// The project on which to execute the request. The format is
        /// `"projects/{project_id_or_number}"`.
        /// </param>
        /// <param name="timeSeries">
        /// The new data to be added to a list of time series.
        /// Adds at most one data point to each of several time series.  The new data
        /// point must be more recent than any other point in its time series.  Each
        /// `TimeSeries` value must fully specify a unique time series by supplying
        /// all label values for the metric and the monitored resource.
        ///
        /// The maximum number of `TimeSeries` objects per `Create` request is 200.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void CreateTimeSeries(
            string name,
            scg::IEnumerable<TimeSeries> timeSeries,
            gaxgrpc::CallSettings callSettings = null) => CreateTimeSeries(
                new CreateTimeSeriesRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    TimeSeries = { gax::GaxPreconditions.CheckNotNull(timeSeries, nameof(timeSeries)) },
                },
                callSettings);

        /// <summary>
        /// Creates or adds data to one or more time series.
        /// The response is empty if all time series in the request were written.
        /// If any time series could not be written, a corresponding failure message is
        /// included in the error response.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task CreateTimeSeriesAsync(
            CreateTimeSeriesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates or adds data to one or more time series.
        /// The response is empty if all time series in the request were written.
        /// If any time series could not be written, a corresponding failure message is
        /// included in the error response.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task CreateTimeSeriesAsync(
            CreateTimeSeriesRequest request,
            st::CancellationToken cancellationToken) => CreateTimeSeriesAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or adds data to one or more time series.
        /// The response is empty if all time series in the request were written.
        /// If any time series could not be written, a corresponding failure message is
        /// included in the error response.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void CreateTimeSeries(
            CreateTimeSeriesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// MetricService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class MetricServiceClientImpl : MetricServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListMonitoredResourceDescriptorsRequest, ListMonitoredResourceDescriptorsResponse> _callListMonitoredResourceDescriptors;
        private readonly gaxgrpc::ApiCall<GetMonitoredResourceDescriptorRequest, ga::MonitoredResourceDescriptor> _callGetMonitoredResourceDescriptor;
        private readonly gaxgrpc::ApiCall<ListMetricDescriptorsRequest, ListMetricDescriptorsResponse> _callListMetricDescriptors;
        private readonly gaxgrpc::ApiCall<GetMetricDescriptorRequest, ga::MetricDescriptor> _callGetMetricDescriptor;
        private readonly gaxgrpc::ApiCall<CreateMetricDescriptorRequest, ga::MetricDescriptor> _callCreateMetricDescriptor;
        private readonly gaxgrpc::ApiCall<DeleteMetricDescriptorRequest, pbwkt::Empty> _callDeleteMetricDescriptor;
        private readonly gaxgrpc::ApiCall<ListTimeSeriesRequest, ListTimeSeriesResponse> _callListTimeSeries;
        private readonly gaxgrpc::ApiCall<CreateTimeSeriesRequest, pbwkt::Empty> _callCreateTimeSeries;

        /// <summary>
        /// Constructs a client wrapper for the MetricService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="MetricServiceSettings"/> used within this client </param>
        public MetricServiceClientImpl(MetricService.MetricServiceClient grpcClient, MetricServiceSettings settings)
        {
            GrpcClient = grpcClient;
            MetricServiceSettings effectiveSettings = settings ?? MetricServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callListMonitoredResourceDescriptors = clientHelper.BuildApiCall<ListMonitoredResourceDescriptorsRequest, ListMonitoredResourceDescriptorsResponse>(
                GrpcClient.ListMonitoredResourceDescriptorsAsync, GrpcClient.ListMonitoredResourceDescriptors, effectiveSettings.ListMonitoredResourceDescriptorsSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callGetMonitoredResourceDescriptor = clientHelper.BuildApiCall<GetMonitoredResourceDescriptorRequest, ga::MonitoredResourceDescriptor>(
                GrpcClient.GetMonitoredResourceDescriptorAsync, GrpcClient.GetMonitoredResourceDescriptor, effectiveSettings.GetMonitoredResourceDescriptorSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callListMetricDescriptors = clientHelper.BuildApiCall<ListMetricDescriptorsRequest, ListMetricDescriptorsResponse>(
                GrpcClient.ListMetricDescriptorsAsync, GrpcClient.ListMetricDescriptors, effectiveSettings.ListMetricDescriptorsSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callGetMetricDescriptor = clientHelper.BuildApiCall<GetMetricDescriptorRequest, ga::MetricDescriptor>(
                GrpcClient.GetMetricDescriptorAsync, GrpcClient.GetMetricDescriptor, effectiveSettings.GetMetricDescriptorSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callCreateMetricDescriptor = clientHelper.BuildApiCall<CreateMetricDescriptorRequest, ga::MetricDescriptor>(
                GrpcClient.CreateMetricDescriptorAsync, GrpcClient.CreateMetricDescriptor, effectiveSettings.CreateMetricDescriptorSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callDeleteMetricDescriptor = clientHelper.BuildApiCall<DeleteMetricDescriptorRequest, pbwkt::Empty>(
                GrpcClient.DeleteMetricDescriptorAsync, GrpcClient.DeleteMetricDescriptor, effectiveSettings.DeleteMetricDescriptorSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callListTimeSeries = clientHelper.BuildApiCall<ListTimeSeriesRequest, ListTimeSeriesResponse>(
                GrpcClient.ListTimeSeriesAsync, GrpcClient.ListTimeSeries, effectiveSettings.ListTimeSeriesSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callCreateTimeSeries = clientHelper.BuildApiCall<CreateTimeSeriesRequest, pbwkt::Empty>(
                GrpcClient.CreateTimeSeriesAsync, GrpcClient.CreateTimeSeries, effectiveSettings.CreateTimeSeriesSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callListMonitoredResourceDescriptors);
            Modify_ListMonitoredResourceDescriptorsApiCall(ref _callListMonitoredResourceDescriptors);
            Modify_ApiCall(ref _callGetMonitoredResourceDescriptor);
            Modify_GetMonitoredResourceDescriptorApiCall(ref _callGetMonitoredResourceDescriptor);
            Modify_ApiCall(ref _callListMetricDescriptors);
            Modify_ListMetricDescriptorsApiCall(ref _callListMetricDescriptors);
            Modify_ApiCall(ref _callGetMetricDescriptor);
            Modify_GetMetricDescriptorApiCall(ref _callGetMetricDescriptor);
            Modify_ApiCall(ref _callCreateMetricDescriptor);
            Modify_CreateMetricDescriptorApiCall(ref _callCreateMetricDescriptor);
            Modify_ApiCall(ref _callDeleteMetricDescriptor);
            Modify_DeleteMetricDescriptorApiCall(ref _callDeleteMetricDescriptor);
            Modify_ApiCall(ref _callListTimeSeries);
            Modify_ListTimeSeriesApiCall(ref _callListTimeSeries);
            Modify_ApiCall(ref _callCreateTimeSeries);
            Modify_CreateTimeSeriesApiCall(ref _callCreateTimeSeries);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        // Partial methods are named to (mostly) ensure there cannot be conflicts with RPC method names.

        // Partial methods called for every ApiCall on construction.
        // Allows modification of all the underlying ApiCall objects.
        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call)
            where TRequest : class, pb::IMessage<TRequest>
            where TResponse : class, pb::IMessage<TResponse>;

        // Partial methods called for each ApiCall on construction.
        // Allows per-RPC-method modification of the underlying ApiCall object.
        partial void Modify_ListMonitoredResourceDescriptorsApiCall(ref gaxgrpc::ApiCall<ListMonitoredResourceDescriptorsRequest, ListMonitoredResourceDescriptorsResponse> call);
        partial void Modify_GetMonitoredResourceDescriptorApiCall(ref gaxgrpc::ApiCall<GetMonitoredResourceDescriptorRequest, ga::MonitoredResourceDescriptor> call);
        partial void Modify_ListMetricDescriptorsApiCall(ref gaxgrpc::ApiCall<ListMetricDescriptorsRequest, ListMetricDescriptorsResponse> call);
        partial void Modify_GetMetricDescriptorApiCall(ref gaxgrpc::ApiCall<GetMetricDescriptorRequest, ga::MetricDescriptor> call);
        partial void Modify_CreateMetricDescriptorApiCall(ref gaxgrpc::ApiCall<CreateMetricDescriptorRequest, ga::MetricDescriptor> call);
        partial void Modify_DeleteMetricDescriptorApiCall(ref gaxgrpc::ApiCall<DeleteMetricDescriptorRequest, pbwkt::Empty> call);
        partial void Modify_ListTimeSeriesApiCall(ref gaxgrpc::ApiCall<ListTimeSeriesRequest, ListTimeSeriesResponse> call);
        partial void Modify_CreateTimeSeriesApiCall(ref gaxgrpc::ApiCall<CreateTimeSeriesRequest, pbwkt::Empty> call);
        partial void OnConstruction(MetricService.MetricServiceClient grpcClient, MetricServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC MetricService client.
        /// </summary>
        public override MetricService.MetricServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_ListMonitoredResourceDescriptorsRequest(ref ListMonitoredResourceDescriptorsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetMonitoredResourceDescriptorRequest(ref GetMonitoredResourceDescriptorRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListMetricDescriptorsRequest(ref ListMetricDescriptorsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetMetricDescriptorRequest(ref GetMetricDescriptorRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateMetricDescriptorRequest(ref CreateMetricDescriptorRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteMetricDescriptorRequest(ref DeleteMetricDescriptorRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListTimeSeriesRequest(ref ListTimeSeriesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateTimeSeriesRequest(ref CreateTimeSeriesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists monitored resource descriptors that match a filter. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ga::MonitoredResourceDescriptor"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListMonitoredResourceDescriptorsResponse, ga::MonitoredResourceDescriptor> ListMonitoredResourceDescriptorsAsync(
            ListMonitoredResourceDescriptorsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMonitoredResourceDescriptorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMonitoredResourceDescriptorsRequest, ListMonitoredResourceDescriptorsResponse, ga::MonitoredResourceDescriptor>(_callListMonitoredResourceDescriptors, request, callSettings);
        }

        /// <summary>
        /// Lists monitored resource descriptors that match a filter. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="ga::MonitoredResourceDescriptor"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListMonitoredResourceDescriptorsResponse, ga::MonitoredResourceDescriptor> ListMonitoredResourceDescriptors(
            ListMonitoredResourceDescriptorsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMonitoredResourceDescriptorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMonitoredResourceDescriptorsRequest, ListMonitoredResourceDescriptorsResponse, ga::MonitoredResourceDescriptor>(_callListMonitoredResourceDescriptors, request, callSettings);
        }

        /// <summary>
        /// Gets a single monitored resource descriptor. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<ga::MonitoredResourceDescriptor> GetMonitoredResourceDescriptorAsync(
            GetMonitoredResourceDescriptorRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMonitoredResourceDescriptorRequest(ref request, ref callSettings);
            return _callGetMonitoredResourceDescriptor.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a single monitored resource descriptor. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override ga::MonitoredResourceDescriptor GetMonitoredResourceDescriptor(
            GetMonitoredResourceDescriptorRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMonitoredResourceDescriptorRequest(ref request, ref callSettings);
            return _callGetMonitoredResourceDescriptor.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists metric descriptors that match a filter. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ga::MetricDescriptor"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListMetricDescriptorsResponse, ga::MetricDescriptor> ListMetricDescriptorsAsync(
            ListMetricDescriptorsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMetricDescriptorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMetricDescriptorsRequest, ListMetricDescriptorsResponse, ga::MetricDescriptor>(_callListMetricDescriptors, request, callSettings);
        }

        /// <summary>
        /// Lists metric descriptors that match a filter. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="ga::MetricDescriptor"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListMetricDescriptorsResponse, ga::MetricDescriptor> ListMetricDescriptors(
            ListMetricDescriptorsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMetricDescriptorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMetricDescriptorsRequest, ListMetricDescriptorsResponse, ga::MetricDescriptor>(_callListMetricDescriptors, request, callSettings);
        }

        /// <summary>
        /// Gets a single metric descriptor. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<ga::MetricDescriptor> GetMetricDescriptorAsync(
            GetMetricDescriptorRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMetricDescriptorRequest(ref request, ref callSettings);
            return _callGetMetricDescriptor.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a single metric descriptor. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override ga::MetricDescriptor GetMetricDescriptor(
            GetMetricDescriptorRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMetricDescriptorRequest(ref request, ref callSettings);
            return _callGetMetricDescriptor.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new metric descriptor.
        /// User-created metric descriptors define
        /// [custom metrics](/monitoring/custom-metrics).
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<ga::MetricDescriptor> CreateMetricDescriptorAsync(
            CreateMetricDescriptorRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMetricDescriptorRequest(ref request, ref callSettings);
            return _callCreateMetricDescriptor.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new metric descriptor.
        /// User-created metric descriptors define
        /// [custom metrics](/monitoring/custom-metrics).
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override ga::MetricDescriptor CreateMetricDescriptor(
            CreateMetricDescriptorRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMetricDescriptorRequest(ref request, ref callSettings);
            return _callCreateMetricDescriptor.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a metric descriptor. Only user-created
        /// [custom metrics](/monitoring/custom-metrics) can be deleted.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public override stt::Task DeleteMetricDescriptorAsync(
            DeleteMetricDescriptorRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMetricDescriptorRequest(ref request, ref callSettings);
            return _callDeleteMetricDescriptor.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a metric descriptor. Only user-created
        /// [custom metrics](/monitoring/custom-metrics) can be deleted.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteMetricDescriptor(
            DeleteMetricDescriptorRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteMetricDescriptorRequest(ref request, ref callSettings);
            _callDeleteMetricDescriptor.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists time series that match a filter. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="TimeSeries"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListTimeSeriesResponse, TimeSeries> ListTimeSeriesAsync(
            ListTimeSeriesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTimeSeriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTimeSeriesRequest, ListTimeSeriesResponse, TimeSeries>(_callListTimeSeries, request, callSettings);
        }

        /// <summary>
        /// Lists time series that match a filter. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="TimeSeries"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListTimeSeriesResponse, TimeSeries> ListTimeSeries(
            ListTimeSeriesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTimeSeriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTimeSeriesRequest, ListTimeSeriesResponse, TimeSeries>(_callListTimeSeries, request, callSettings);
        }

        /// <summary>
        /// Creates or adds data to one or more time series.
        /// The response is empty if all time series in the request were written.
        /// If any time series could not be written, a corresponding failure message is
        /// included in the error response.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public override stt::Task CreateTimeSeriesAsync(
            CreateTimeSeriesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTimeSeriesRequest(ref request, ref callSettings);
            return _callCreateTimeSeries.Async(request, callSettings);
        }

        /// <summary>
        /// Creates or adds data to one or more time series.
        /// The response is empty if all time series in the request were written.
        /// If any time series could not be written, a corresponding failure message is
        /// included in the error response.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void CreateTimeSeries(
            CreateTimeSeriesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTimeSeriesRequest(ref request, ref callSettings);
            _callCreateTimeSeries.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListMonitoredResourceDescriptorsRequest : gaxgrpc::IPageRequest { }
    public partial class ListMonitoredResourceDescriptorsResponse : gaxgrpc::IPageResponse<ga::MonitoredResourceDescriptor>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<ga::MonitoredResourceDescriptor> GetEnumerator() => ResourceDescriptors.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListMetricDescriptorsRequest : gaxgrpc::IPageRequest { }
    public partial class ListMetricDescriptorsResponse : gaxgrpc::IPageResponse<ga::MetricDescriptor>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<ga::MetricDescriptor> GetEnumerator() => MetricDescriptors.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTimeSeriesRequest : gaxgrpc::IPageRequest { }
    public partial class ListTimeSeriesResponse : gaxgrpc::IPageResponse<TimeSeries>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<TimeSeries> GetEnumerator() => TimeSeries.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
