// Copyright 2020 Google LLC
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

namespace Google.Cloud.Logging.V2
{
    /// <summary>
    /// Settings for a <see cref="MetricsServiceV2Client"/>.
    /// </summary>
    public sealed partial class MetricsServiceV2Settings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="MetricsServiceV2Settings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="MetricsServiceV2Settings"/>.
        /// </returns>
        public static MetricsServiceV2Settings GetDefault() => new MetricsServiceV2Settings();

        /// <summary>
        /// Constructs a new <see cref="MetricsServiceV2Settings"/> object with default settings.
        /// </summary>
        public MetricsServiceV2Settings() { }

        private MetricsServiceV2Settings(MetricsServiceV2Settings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListLogMetricsSettings = existing.ListLogMetricsSettings;
            GetLogMetricSettings = existing.GetLogMetricSettings;
            CreateLogMetricSettings = existing.CreateLogMetricSettings;
            UpdateLogMetricSettings = existing.UpdateLogMetricSettings;
            DeleteLogMetricSettings = existing.DeleteLogMetricSettings;
            OnCopy(existing);
        }

        partial void OnCopy(MetricsServiceV2Settings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="MetricsServiceV2Client"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Internal"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> IdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="MetricsServiceV2Client"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="MetricsServiceV2Client"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="MetricsServiceV2Client"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="MetricsServiceV2Client"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="MetricsServiceV2Client"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="MetricsServiceV2Client"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="MetricsServiceV2Client"/> RPC methods is defined as:
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
        /// <c>MetricsServiceV2Client.ListLogMetrics</c> and <c>MetricsServiceV2Client.ListLogMetricsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>MetricsServiceV2Client.ListLogMetrics</c> and
        /// <c>MetricsServiceV2Client.ListLogMetricsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Internal"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListLogMetricsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricsServiceV2Client.GetLogMetric</c> and <c>MetricsServiceV2Client.GetLogMetricAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>MetricsServiceV2Client.GetLogMetric</c> and
        /// <c>MetricsServiceV2Client.GetLogMetricAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Internal"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetLogMetricSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricsServiceV2Client.CreateLogMetric</c> and <c>MetricsServiceV2Client.CreateLogMetricAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>MetricsServiceV2Client.CreateLogMetric</c> and
        /// <c>MetricsServiceV2Client.CreateLogMetricAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateLogMetricSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricsServiceV2Client.UpdateLogMetric</c> and <c>MetricsServiceV2Client.UpdateLogMetricAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>MetricsServiceV2Client.UpdateLogMetric</c> and
        /// <c>MetricsServiceV2Client.UpdateLogMetricAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Internal"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings UpdateLogMetricSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricsServiceV2Client.DeleteLogMetric</c> and <c>MetricsServiceV2Client.DeleteLogMetricAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>MetricsServiceV2Client.DeleteLogMetric</c> and
        /// <c>MetricsServiceV2Client.DeleteLogMetricAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Internal"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings DeleteLogMetricSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="MetricsServiceV2Settings"/> object.</returns>
        public MetricsServiceV2Settings Clone() => new MetricsServiceV2Settings(this);
    }

    /// <summary>
    /// Builder class for <see cref="MetricsServiceV2Client"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class MetricsServiceV2ClientBuilder : gaxgrpc::ClientBuilderBase<MetricsServiceV2Client>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public MetricsServiceV2Settings Settings { get; set; }

        /// <inheritdoc/>
        public override MetricsServiceV2Client Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return MetricsServiceV2Client.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<MetricsServiceV2Client> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return MetricsServiceV2Client.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => MetricsServiceV2Client.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => MetricsServiceV2Client.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => MetricsServiceV2Client.ChannelPool;
    }

    /// <summary>
    /// MetricsServiceV2 client wrapper, for convenient use.
    /// </summary>
    public abstract partial class MetricsServiceV2Client
    {
        /// <summary>
        /// The default endpoint for the MetricsServiceV2 service, which is a host of "logging.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("logging.googleapis.com", 443);

        /// <summary>
        /// The default MetricsServiceV2 scopes.
        /// </summary>
        /// <remarks>
        /// The default MetricsServiceV2 scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform.read-only"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/logging.admin"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/logging.read"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/logging.write"</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
            "https://www.googleapis.com/auth/logging.admin",
            "https://www.googleapis.com/auth/logging.read",
            "https://www.googleapis.com/auth/logging.write",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="MetricsServiceV2Client"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Logging.V2;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// MetricsServiceV2Client client = await MetricsServiceV2Client.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Logging.V2;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     MetricsServiceV2Client.DefaultEndpoint.Host, MetricsServiceV2Client.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// MetricsServiceV2Client client = MetricsServiceV2Client.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="MetricsServiceV2Settings"/>.</param>
        /// <returns>The task representing the created <see cref="MetricsServiceV2Client"/>.</returns>
        public static async stt::Task<MetricsServiceV2Client> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, MetricsServiceV2Settings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="MetricsServiceV2Client"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Logging.V2;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// MetricsServiceV2Client client = MetricsServiceV2Client.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Logging.V2;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     MetricsServiceV2Client.DefaultEndpoint.Host, MetricsServiceV2Client.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// MetricsServiceV2Client client = MetricsServiceV2Client.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="MetricsServiceV2Settings"/>.</param>
        /// <returns>The created <see cref="MetricsServiceV2Client"/>.</returns>
        public static MetricsServiceV2Client Create(gaxgrpc::ServiceEndpoint endpoint = null, MetricsServiceV2Settings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="MetricsServiceV2Client"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="MetricsServiceV2Settings"/>.</param>
        /// <returns>The created <see cref="MetricsServiceV2Client"/>.</returns>
        public static MetricsServiceV2Client Create(grpccore::Channel channel, MetricsServiceV2Settings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="MetricsServiceV2Client"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="MetricsServiceV2Settings"/>.</param>
        /// <returns>The created <see cref="MetricsServiceV2Client"/>.</returns>
        public static MetricsServiceV2Client Create(grpccore::CallInvoker callInvoker, MetricsServiceV2Settings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            MetricsServiceV2.MetricsServiceV2Client grpcClient = new MetricsServiceV2.MetricsServiceV2Client(callInvoker);
            return new MetricsServiceV2ClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, MetricsServiceV2Settings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, MetricsServiceV2Settings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, MetricsServiceV2Settings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, MetricsServiceV2Settings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC MetricsServiceV2 client.
        /// </summary>
        public virtual MetricsServiceV2.MetricsServiceV2Client GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Lists logs-based metrics.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project containing the metrics:
        ///
        ///     "projects/[PROJECT_ID]"
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
        /// A pageable asynchronous sequence of <see cref="LogMetric"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListLogMetricsResponse, LogMetric> ListLogMetricsAsync(
            ParentNameOneof parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListLogMetricsAsync(
                new ListLogMetricsRequest
                {
                    ParentAsParentNameOneof = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists logs-based metrics.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project containing the metrics:
        ///
        ///     "projects/[PROJECT_ID]"
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
        /// A pageable sequence of <see cref="LogMetric"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListLogMetricsResponse, LogMetric> ListLogMetrics(
            ParentNameOneof parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListLogMetrics(
                new ListLogMetricsRequest
                {
                    ParentAsParentNameOneof = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists logs-based metrics.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project containing the metrics:
        ///
        ///     "projects/[PROJECT_ID]"
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
        /// A pageable asynchronous sequence of <see cref="LogMetric"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListLogMetricsResponse, LogMetric> ListLogMetricsAsync(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListLogMetricsAsync(
                new ListLogMetricsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists logs-based metrics.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project containing the metrics:
        ///
        ///     "projects/[PROJECT_ID]"
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
        /// A pageable sequence of <see cref="LogMetric"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListLogMetricsResponse, LogMetric> ListLogMetrics(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListLogMetrics(
                new ListLogMetricsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists logs-based metrics.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="LogMetric"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListLogMetricsResponse, LogMetric> ListLogMetricsAsync(
            ListLogMetricsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists logs-based metrics.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="LogMetric"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListLogMetricsResponse, LogMetric> ListLogMetrics(
            ListLogMetricsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets a logs-based metric.
        /// </summary>
        /// <param name="metricName">
        /// Required. The resource name of the desired metric:
        ///
        ///     "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<LogMetric> GetLogMetricAsync(
            MetricNameOneof metricName,
            gaxgrpc::CallSettings callSettings = null) => GetLogMetricAsync(
                new GetLogMetricRequest
                {
                    MetricNameAsMetricNameOneof = gax::GaxPreconditions.CheckNotNull(metricName, nameof(metricName)),
                },
                callSettings);

        /// <summary>
        /// Gets a logs-based metric.
        /// </summary>
        /// <param name="metricName">
        /// Required. The resource name of the desired metric:
        ///
        ///     "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<LogMetric> GetLogMetricAsync(
            MetricNameOneof metricName,
            st::CancellationToken cancellationToken) => GetLogMetricAsync(
                metricName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a logs-based metric.
        /// </summary>
        /// <param name="metricName">
        /// Required. The resource name of the desired metric:
        ///
        ///     "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual LogMetric GetLogMetric(
            MetricNameOneof metricName,
            gaxgrpc::CallSettings callSettings = null) => GetLogMetric(
                new GetLogMetricRequest
                {
                    MetricNameAsMetricNameOneof = gax::GaxPreconditions.CheckNotNull(metricName, nameof(metricName)),
                },
                callSettings);

        /// <summary>
        /// Gets a logs-based metric.
        /// </summary>
        /// <param name="metricName">
        /// Required. The resource name of the desired metric:
        ///
        ///     "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<LogMetric> GetLogMetricAsync(
            string metricName,
            gaxgrpc::CallSettings callSettings = null) => GetLogMetricAsync(
                new GetLogMetricRequest
                {
                    MetricName = gax::GaxPreconditions.CheckNotNullOrEmpty(metricName, nameof(metricName)),
                },
                callSettings);

        /// <summary>
        /// Gets a logs-based metric.
        /// </summary>
        /// <param name="metricName">
        /// Required. The resource name of the desired metric:
        ///
        ///     "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<LogMetric> GetLogMetricAsync(
            string metricName,
            st::CancellationToken cancellationToken) => GetLogMetricAsync(
                metricName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a logs-based metric.
        /// </summary>
        /// <param name="metricName">
        /// Required. The resource name of the desired metric:
        ///
        ///     "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual LogMetric GetLogMetric(
            string metricName,
            gaxgrpc::CallSettings callSettings = null) => GetLogMetric(
                new GetLogMetricRequest
                {
                    MetricName = gax::GaxPreconditions.CheckNotNullOrEmpty(metricName, nameof(metricName)),
                },
                callSettings);

        /// <summary>
        /// Gets a logs-based metric.
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
        public virtual stt::Task<LogMetric> GetLogMetricAsync(
            GetLogMetricRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets a logs-based metric.
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
        public virtual stt::Task<LogMetric> GetLogMetricAsync(
            GetLogMetricRequest request,
            st::CancellationToken cancellationToken) => GetLogMetricAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a logs-based metric.
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
        public virtual LogMetric GetLogMetric(
            GetLogMetricRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a logs-based metric.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project in which to create the metric:
        ///
        ///     "projects/[PROJECT_ID]"
        ///
        /// The new metric must be provided in the request.
        /// </param>
        /// <param name="metric">
        /// Required. The new logs-based metric, which must not have an identifier that
        /// already exists.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<LogMetric> CreateLogMetricAsync(
            ParentNameOneof parent,
            LogMetric metric,
            gaxgrpc::CallSettings callSettings = null) => CreateLogMetricAsync(
                new CreateLogMetricRequest
                {
                    ParentAsParentNameOneof = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Metric = gax::GaxPreconditions.CheckNotNull(metric, nameof(metric)),
                },
                callSettings);

        /// <summary>
        /// Creates a logs-based metric.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project in which to create the metric:
        ///
        ///     "projects/[PROJECT_ID]"
        ///
        /// The new metric must be provided in the request.
        /// </param>
        /// <param name="metric">
        /// Required. The new logs-based metric, which must not have an identifier that
        /// already exists.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<LogMetric> CreateLogMetricAsync(
            ParentNameOneof parent,
            LogMetric metric,
            st::CancellationToken cancellationToken) => CreateLogMetricAsync(
                parent,
                metric,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a logs-based metric.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project in which to create the metric:
        ///
        ///     "projects/[PROJECT_ID]"
        ///
        /// The new metric must be provided in the request.
        /// </param>
        /// <param name="metric">
        /// Required. The new logs-based metric, which must not have an identifier that
        /// already exists.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual LogMetric CreateLogMetric(
            ParentNameOneof parent,
            LogMetric metric,
            gaxgrpc::CallSettings callSettings = null) => CreateLogMetric(
                new CreateLogMetricRequest
                {
                    ParentAsParentNameOneof = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Metric = gax::GaxPreconditions.CheckNotNull(metric, nameof(metric)),
                },
                callSettings);

        /// <summary>
        /// Creates a logs-based metric.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project in which to create the metric:
        ///
        ///     "projects/[PROJECT_ID]"
        ///
        /// The new metric must be provided in the request.
        /// </param>
        /// <param name="metric">
        /// Required. The new logs-based metric, which must not have an identifier that
        /// already exists.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<LogMetric> CreateLogMetricAsync(
            string parent,
            LogMetric metric,
            gaxgrpc::CallSettings callSettings = null) => CreateLogMetricAsync(
                new CreateLogMetricRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Metric = gax::GaxPreconditions.CheckNotNull(metric, nameof(metric)),
                },
                callSettings);

        /// <summary>
        /// Creates a logs-based metric.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project in which to create the metric:
        ///
        ///     "projects/[PROJECT_ID]"
        ///
        /// The new metric must be provided in the request.
        /// </param>
        /// <param name="metric">
        /// Required. The new logs-based metric, which must not have an identifier that
        /// already exists.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<LogMetric> CreateLogMetricAsync(
            string parent,
            LogMetric metric,
            st::CancellationToken cancellationToken) => CreateLogMetricAsync(
                parent,
                metric,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a logs-based metric.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project in which to create the metric:
        ///
        ///     "projects/[PROJECT_ID]"
        ///
        /// The new metric must be provided in the request.
        /// </param>
        /// <param name="metric">
        /// Required. The new logs-based metric, which must not have an identifier that
        /// already exists.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual LogMetric CreateLogMetric(
            string parent,
            LogMetric metric,
            gaxgrpc::CallSettings callSettings = null) => CreateLogMetric(
                new CreateLogMetricRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Metric = gax::GaxPreconditions.CheckNotNull(metric, nameof(metric)),
                },
                callSettings);

        /// <summary>
        /// Creates a logs-based metric.
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
        public virtual stt::Task<LogMetric> CreateLogMetricAsync(
            CreateLogMetricRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a logs-based metric.
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
        public virtual stt::Task<LogMetric> CreateLogMetricAsync(
            CreateLogMetricRequest request,
            st::CancellationToken cancellationToken) => CreateLogMetricAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a logs-based metric.
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
        public virtual LogMetric CreateLogMetric(
            CreateLogMetricRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates or updates a logs-based metric.
        /// </summary>
        /// <param name="metricName">
        /// Required. The resource name of the metric to update:
        ///
        ///     "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
        ///
        /// The updated metric must be provided in the request and it's
        /// `name` field must be the same as `[METRIC_ID]` If the metric
        /// does not exist in `[PROJECT_ID]`, then a new metric is created.
        /// </param>
        /// <param name="metric">
        /// Required. The updated metric.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<LogMetric> UpdateLogMetricAsync(
            MetricNameOneof metricName,
            LogMetric metric,
            gaxgrpc::CallSettings callSettings = null) => UpdateLogMetricAsync(
                new UpdateLogMetricRequest
                {
                    MetricNameAsMetricNameOneof = gax::GaxPreconditions.CheckNotNull(metricName, nameof(metricName)),
                    Metric = gax::GaxPreconditions.CheckNotNull(metric, nameof(metric)),
                },
                callSettings);

        /// <summary>
        /// Creates or updates a logs-based metric.
        /// </summary>
        /// <param name="metricName">
        /// Required. The resource name of the metric to update:
        ///
        ///     "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
        ///
        /// The updated metric must be provided in the request and it's
        /// `name` field must be the same as `[METRIC_ID]` If the metric
        /// does not exist in `[PROJECT_ID]`, then a new metric is created.
        /// </param>
        /// <param name="metric">
        /// Required. The updated metric.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<LogMetric> UpdateLogMetricAsync(
            MetricNameOneof metricName,
            LogMetric metric,
            st::CancellationToken cancellationToken) => UpdateLogMetricAsync(
                metricName,
                metric,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or updates a logs-based metric.
        /// </summary>
        /// <param name="metricName">
        /// Required. The resource name of the metric to update:
        ///
        ///     "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
        ///
        /// The updated metric must be provided in the request and it's
        /// `name` field must be the same as `[METRIC_ID]` If the metric
        /// does not exist in `[PROJECT_ID]`, then a new metric is created.
        /// </param>
        /// <param name="metric">
        /// Required. The updated metric.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual LogMetric UpdateLogMetric(
            MetricNameOneof metricName,
            LogMetric metric,
            gaxgrpc::CallSettings callSettings = null) => UpdateLogMetric(
                new UpdateLogMetricRequest
                {
                    MetricNameAsMetricNameOneof = gax::GaxPreconditions.CheckNotNull(metricName, nameof(metricName)),
                    Metric = gax::GaxPreconditions.CheckNotNull(metric, nameof(metric)),
                },
                callSettings);

        /// <summary>
        /// Creates or updates a logs-based metric.
        /// </summary>
        /// <param name="metricName">
        /// Required. The resource name of the metric to update:
        ///
        ///     "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
        ///
        /// The updated metric must be provided in the request and it's
        /// `name` field must be the same as `[METRIC_ID]` If the metric
        /// does not exist in `[PROJECT_ID]`, then a new metric is created.
        /// </param>
        /// <param name="metric">
        /// Required. The updated metric.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<LogMetric> UpdateLogMetricAsync(
            string metricName,
            LogMetric metric,
            gaxgrpc::CallSettings callSettings = null) => UpdateLogMetricAsync(
                new UpdateLogMetricRequest
                {
                    MetricName = gax::GaxPreconditions.CheckNotNullOrEmpty(metricName, nameof(metricName)),
                    Metric = gax::GaxPreconditions.CheckNotNull(metric, nameof(metric)),
                },
                callSettings);

        /// <summary>
        /// Creates or updates a logs-based metric.
        /// </summary>
        /// <param name="metricName">
        /// Required. The resource name of the metric to update:
        ///
        ///     "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
        ///
        /// The updated metric must be provided in the request and it's
        /// `name` field must be the same as `[METRIC_ID]` If the metric
        /// does not exist in `[PROJECT_ID]`, then a new metric is created.
        /// </param>
        /// <param name="metric">
        /// Required. The updated metric.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<LogMetric> UpdateLogMetricAsync(
            string metricName,
            LogMetric metric,
            st::CancellationToken cancellationToken) => UpdateLogMetricAsync(
                metricName,
                metric,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or updates a logs-based metric.
        /// </summary>
        /// <param name="metricName">
        /// Required. The resource name of the metric to update:
        ///
        ///     "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
        ///
        /// The updated metric must be provided in the request and it's
        /// `name` field must be the same as `[METRIC_ID]` If the metric
        /// does not exist in `[PROJECT_ID]`, then a new metric is created.
        /// </param>
        /// <param name="metric">
        /// Required. The updated metric.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual LogMetric UpdateLogMetric(
            string metricName,
            LogMetric metric,
            gaxgrpc::CallSettings callSettings = null) => UpdateLogMetric(
                new UpdateLogMetricRequest
                {
                    MetricName = gax::GaxPreconditions.CheckNotNullOrEmpty(metricName, nameof(metricName)),
                    Metric = gax::GaxPreconditions.CheckNotNull(metric, nameof(metric)),
                },
                callSettings);

        /// <summary>
        /// Creates or updates a logs-based metric.
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
        public virtual stt::Task<LogMetric> UpdateLogMetricAsync(
            UpdateLogMetricRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates or updates a logs-based metric.
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
        public virtual stt::Task<LogMetric> UpdateLogMetricAsync(
            UpdateLogMetricRequest request,
            st::CancellationToken cancellationToken) => UpdateLogMetricAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or updates a logs-based metric.
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
        public virtual LogMetric UpdateLogMetric(
            UpdateLogMetricRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes a logs-based metric.
        /// </summary>
        /// <param name="metricName">
        /// Required. The resource name of the metric to delete:
        ///
        ///     "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteLogMetricAsync(
            MetricNameOneof metricName,
            gaxgrpc::CallSettings callSettings = null) => DeleteLogMetricAsync(
                new DeleteLogMetricRequest
                {
                    MetricNameAsMetricNameOneof = gax::GaxPreconditions.CheckNotNull(metricName, nameof(metricName)),
                },
                callSettings);

        /// <summary>
        /// Deletes a logs-based metric.
        /// </summary>
        /// <param name="metricName">
        /// Required. The resource name of the metric to delete:
        ///
        ///     "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteLogMetricAsync(
            MetricNameOneof metricName,
            st::CancellationToken cancellationToken) => DeleteLogMetricAsync(
                metricName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a logs-based metric.
        /// </summary>
        /// <param name="metricName">
        /// Required. The resource name of the metric to delete:
        ///
        ///     "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteLogMetric(
            MetricNameOneof metricName,
            gaxgrpc::CallSettings callSettings = null) => DeleteLogMetric(
                new DeleteLogMetricRequest
                {
                    MetricNameAsMetricNameOneof = gax::GaxPreconditions.CheckNotNull(metricName, nameof(metricName)),
                },
                callSettings);

        /// <summary>
        /// Deletes a logs-based metric.
        /// </summary>
        /// <param name="metricName">
        /// Required. The resource name of the metric to delete:
        ///
        ///     "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteLogMetricAsync(
            string metricName,
            gaxgrpc::CallSettings callSettings = null) => DeleteLogMetricAsync(
                new DeleteLogMetricRequest
                {
                    MetricName = gax::GaxPreconditions.CheckNotNullOrEmpty(metricName, nameof(metricName)),
                },
                callSettings);

        /// <summary>
        /// Deletes a logs-based metric.
        /// </summary>
        /// <param name="metricName">
        /// Required. The resource name of the metric to delete:
        ///
        ///     "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteLogMetricAsync(
            string metricName,
            st::CancellationToken cancellationToken) => DeleteLogMetricAsync(
                metricName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a logs-based metric.
        /// </summary>
        /// <param name="metricName">
        /// Required. The resource name of the metric to delete:
        ///
        ///     "projects/[PROJECT_ID]/metrics/[METRIC_ID]"
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteLogMetric(
            string metricName,
            gaxgrpc::CallSettings callSettings = null) => DeleteLogMetric(
                new DeleteLogMetricRequest
                {
                    MetricName = gax::GaxPreconditions.CheckNotNullOrEmpty(metricName, nameof(metricName)),
                },
                callSettings);

        /// <summary>
        /// Deletes a logs-based metric.
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
        public virtual stt::Task DeleteLogMetricAsync(
            DeleteLogMetricRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes a logs-based metric.
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
        public virtual stt::Task DeleteLogMetricAsync(
            DeleteLogMetricRequest request,
            st::CancellationToken cancellationToken) => DeleteLogMetricAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a logs-based metric.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteLogMetric(
            DeleteLogMetricRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// MetricsServiceV2 client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class MetricsServiceV2ClientImpl : MetricsServiceV2Client
    {
        private readonly gaxgrpc::ApiCall<ListLogMetricsRequest, ListLogMetricsResponse> _callListLogMetrics;
        private readonly gaxgrpc::ApiCall<GetLogMetricRequest, LogMetric> _callGetLogMetric;
        private readonly gaxgrpc::ApiCall<CreateLogMetricRequest, LogMetric> _callCreateLogMetric;
        private readonly gaxgrpc::ApiCall<UpdateLogMetricRequest, LogMetric> _callUpdateLogMetric;
        private readonly gaxgrpc::ApiCall<DeleteLogMetricRequest, pbwkt::Empty> _callDeleteLogMetric;

        /// <summary>
        /// Constructs a client wrapper for the MetricsServiceV2 service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="MetricsServiceV2Settings"/> used within this client </param>
        public MetricsServiceV2ClientImpl(MetricsServiceV2.MetricsServiceV2Client grpcClient, MetricsServiceV2Settings settings)
        {
            GrpcClient = grpcClient;
            MetricsServiceV2Settings effectiveSettings = settings ?? MetricsServiceV2Settings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callListLogMetrics = clientHelper.BuildApiCall<ListLogMetricsRequest, ListLogMetricsResponse>(
                GrpcClient.ListLogMetricsAsync, GrpcClient.ListLogMetrics, effectiveSettings.ListLogMetricsSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callGetLogMetric = clientHelper.BuildApiCall<GetLogMetricRequest, LogMetric>(
                GrpcClient.GetLogMetricAsync, GrpcClient.GetLogMetric, effectiveSettings.GetLogMetricSettings)
                .WithGoogleRequestParam("metric_name", request => request.MetricName);
            _callCreateLogMetric = clientHelper.BuildApiCall<CreateLogMetricRequest, LogMetric>(
                GrpcClient.CreateLogMetricAsync, GrpcClient.CreateLogMetric, effectiveSettings.CreateLogMetricSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callUpdateLogMetric = clientHelper.BuildApiCall<UpdateLogMetricRequest, LogMetric>(
                GrpcClient.UpdateLogMetricAsync, GrpcClient.UpdateLogMetric, effectiveSettings.UpdateLogMetricSettings)
                .WithGoogleRequestParam("metric_name", request => request.MetricName);
            _callDeleteLogMetric = clientHelper.BuildApiCall<DeleteLogMetricRequest, pbwkt::Empty>(
                GrpcClient.DeleteLogMetricAsync, GrpcClient.DeleteLogMetric, effectiveSettings.DeleteLogMetricSettings)
                .WithGoogleRequestParam("metric_name", request => request.MetricName);
            Modify_ApiCall(ref _callListLogMetrics);
            Modify_ListLogMetricsApiCall(ref _callListLogMetrics);
            Modify_ApiCall(ref _callGetLogMetric);
            Modify_GetLogMetricApiCall(ref _callGetLogMetric);
            Modify_ApiCall(ref _callCreateLogMetric);
            Modify_CreateLogMetricApiCall(ref _callCreateLogMetric);
            Modify_ApiCall(ref _callUpdateLogMetric);
            Modify_UpdateLogMetricApiCall(ref _callUpdateLogMetric);
            Modify_ApiCall(ref _callDeleteLogMetric);
            Modify_DeleteLogMetricApiCall(ref _callDeleteLogMetric);
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
        partial void Modify_ListLogMetricsApiCall(ref gaxgrpc::ApiCall<ListLogMetricsRequest, ListLogMetricsResponse> call);
        partial void Modify_GetLogMetricApiCall(ref gaxgrpc::ApiCall<GetLogMetricRequest, LogMetric> call);
        partial void Modify_CreateLogMetricApiCall(ref gaxgrpc::ApiCall<CreateLogMetricRequest, LogMetric> call);
        partial void Modify_UpdateLogMetricApiCall(ref gaxgrpc::ApiCall<UpdateLogMetricRequest, LogMetric> call);
        partial void Modify_DeleteLogMetricApiCall(ref gaxgrpc::ApiCall<DeleteLogMetricRequest, pbwkt::Empty> call);
        partial void OnConstruction(MetricsServiceV2.MetricsServiceV2Client grpcClient, MetricsServiceV2Settings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC MetricsServiceV2 client.
        /// </summary>
        public override MetricsServiceV2.MetricsServiceV2Client GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_ListLogMetricsRequest(ref ListLogMetricsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetLogMetricRequest(ref GetLogMetricRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateLogMetricRequest(ref CreateLogMetricRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateLogMetricRequest(ref UpdateLogMetricRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteLogMetricRequest(ref DeleteLogMetricRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists logs-based metrics.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="LogMetric"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListLogMetricsResponse, LogMetric> ListLogMetricsAsync(
            ListLogMetricsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLogMetricsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListLogMetricsRequest, ListLogMetricsResponse, LogMetric>(_callListLogMetrics, request, callSettings);
        }

        /// <summary>
        /// Lists logs-based metrics.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="LogMetric"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListLogMetricsResponse, LogMetric> ListLogMetrics(
            ListLogMetricsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLogMetricsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListLogMetricsRequest, ListLogMetricsResponse, LogMetric>(_callListLogMetrics, request, callSettings);
        }

        /// <summary>
        /// Gets a logs-based metric.
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
        public override stt::Task<LogMetric> GetLogMetricAsync(
            GetLogMetricRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLogMetricRequest(ref request, ref callSettings);
            return _callGetLogMetric.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a logs-based metric.
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
        public override LogMetric GetLogMetric(
            GetLogMetricRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLogMetricRequest(ref request, ref callSettings);
            return _callGetLogMetric.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a logs-based metric.
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
        public override stt::Task<LogMetric> CreateLogMetricAsync(
            CreateLogMetricRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateLogMetricRequest(ref request, ref callSettings);
            return _callCreateLogMetric.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a logs-based metric.
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
        public override LogMetric CreateLogMetric(
            CreateLogMetricRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateLogMetricRequest(ref request, ref callSettings);
            return _callCreateLogMetric.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates or updates a logs-based metric.
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
        public override stt::Task<LogMetric> UpdateLogMetricAsync(
            UpdateLogMetricRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateLogMetricRequest(ref request, ref callSettings);
            return _callUpdateLogMetric.Async(request, callSettings);
        }

        /// <summary>
        /// Creates or updates a logs-based metric.
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
        public override LogMetric UpdateLogMetric(
            UpdateLogMetricRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateLogMetricRequest(ref request, ref callSettings);
            return _callUpdateLogMetric.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a logs-based metric.
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
        public override stt::Task DeleteLogMetricAsync(
            DeleteLogMetricRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteLogMetricRequest(ref request, ref callSettings);
            return _callDeleteLogMetric.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a logs-based metric.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteLogMetric(
            DeleteLogMetricRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteLogMetricRequest(ref request, ref callSettings);
            _callDeleteLogMetric.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListLogMetricsRequest : gaxgrpc::IPageRequest { }
    public partial class ListLogMetricsResponse : gaxgrpc::IPageResponse<LogMetric>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<LogMetric> GetEnumerator() => Metrics.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
