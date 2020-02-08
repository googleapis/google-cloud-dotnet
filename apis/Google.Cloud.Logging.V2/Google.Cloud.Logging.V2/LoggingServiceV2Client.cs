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

namespace Google.Cloud.Logging.V2
{
    /// <summary>
    /// Settings for a <see cref="LoggingServiceV2Client"/>.
    /// </summary>
    public sealed partial class LoggingServiceV2Settings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="LoggingServiceV2Settings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="LoggingServiceV2Settings"/>.
        /// </returns>
        public static LoggingServiceV2Settings GetDefault() => new LoggingServiceV2Settings();

        /// <summary>
        /// Constructs a new <see cref="LoggingServiceV2Settings"/> object with default settings.
        /// </summary>
        public LoggingServiceV2Settings() { }

        private LoggingServiceV2Settings(LoggingServiceV2Settings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            DeleteLogSettings = existing.DeleteLogSettings;
            WriteLogEntriesSettings = existing.WriteLogEntriesSettings;
            ListLogEntriesSettings = existing.ListLogEntriesSettings;
            ListMonitoredResourceDescriptorsSettings = existing.ListMonitoredResourceDescriptorsSettings;
            ListLogsSettings = existing.ListLogsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(LoggingServiceV2Settings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="LoggingServiceV2Client"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="LoggingServiceV2Client"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="LoggingServiceV2Client"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="LoggingServiceV2Client"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="LoggingServiceV2Client"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="LoggingServiceV2Client"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="LoggingServiceV2Client"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="LoggingServiceV2Client"/> RPC methods is defined as:
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
        /// "List" retry backoff for <see cref="LoggingServiceV2Client"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "List" retry backoff for <see cref="LoggingServiceV2Client"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "List" retry backoff for <see cref="LoggingServiceV2Client"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetListRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(100),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "List" timeout backoff for <see cref="LoggingServiceV2Client"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "List" timeout backoff for <see cref="LoggingServiceV2Client"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "List" timeout backoff for <see cref="LoggingServiceV2Client"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 20000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetListTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(20000),
            maxDelay: sys::TimeSpan.FromMilliseconds(20000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LoggingServiceV2Client.DeleteLog</c> and <c>LoggingServiceV2Client.DeleteLogAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>LoggingServiceV2Client.DeleteLog</c> and
        /// <c>LoggingServiceV2Client.DeleteLogAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings DeleteLogSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LoggingServiceV2Client.WriteLogEntries</c> and <c>LoggingServiceV2Client.WriteLogEntriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>LoggingServiceV2Client.WriteLogEntries</c> and
        /// <c>LoggingServiceV2Client.WriteLogEntriesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings WriteLogEntriesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LoggingServiceV2Client.ListLogEntries</c> and <c>LoggingServiceV2Client.ListLogEntriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>LoggingServiceV2Client.ListLogEntries</c> and
        /// <c>LoggingServiceV2Client.ListLogEntriesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListLogEntriesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LoggingServiceV2Client.ListMonitoredResourceDescriptors</c> and <c>LoggingServiceV2Client.ListMonitoredResourceDescriptorsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>LoggingServiceV2Client.ListMonitoredResourceDescriptors</c> and
        /// <c>LoggingServiceV2Client.ListMonitoredResourceDescriptorsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListMonitoredResourceDescriptorsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LoggingServiceV2Client.ListLogs</c> and <c>LoggingServiceV2Client.ListLogsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>LoggingServiceV2Client.ListLogs</c> and
        /// <c>LoggingServiceV2Client.ListLogsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListLogsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="LoggingServiceV2Settings"/> object.</returns>
        public LoggingServiceV2Settings Clone() => new LoggingServiceV2Settings(this);
    }

    /// <summary>
    /// Builder class for <see cref="LoggingServiceV2Client"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class LoggingServiceV2ClientBuilder : gaxgrpc::ClientBuilderBase<LoggingServiceV2Client>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public LoggingServiceV2Settings Settings { get; set; }

        /// <inheritdoc/>
        public override LoggingServiceV2Client Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return LoggingServiceV2Client.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<LoggingServiceV2Client> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return LoggingServiceV2Client.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => LoggingServiceV2Client.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => LoggingServiceV2Client.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => LoggingServiceV2Client.ChannelPool;
    }

    /// <summary>
    /// LoggingServiceV2 client wrapper, for convenient use.
    /// </summary>
    public abstract partial class LoggingServiceV2Client
    {
        /// <summary>
        /// The default endpoint for the LoggingServiceV2 service, which is a host of "logging.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("logging.googleapis.com", 443);

        /// <summary>
        /// The default LoggingServiceV2 scopes.
        /// </summary>
        /// <remarks>
        /// The default LoggingServiceV2 scopes are:
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
        /// Asynchronously creates a <see cref="LoggingServiceV2Client"/>, applying defaults for all unspecified settings,
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
        /// LoggingServiceV2Client client = await LoggingServiceV2Client.CreateAsync();
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
        ///     LoggingServiceV2Client.DefaultEndpoint.Host, LoggingServiceV2Client.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// LoggingServiceV2Client client = LoggingServiceV2Client.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="LoggingServiceV2Settings"/>.</param>
        /// <returns>The task representing the created <see cref="LoggingServiceV2Client"/>.</returns>
        public static async stt::Task<LoggingServiceV2Client> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, LoggingServiceV2Settings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="LoggingServiceV2Client"/>, applying defaults for all unspecified settings,
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
        /// LoggingServiceV2Client client = LoggingServiceV2Client.Create();
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
        ///     LoggingServiceV2Client.DefaultEndpoint.Host, LoggingServiceV2Client.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// LoggingServiceV2Client client = LoggingServiceV2Client.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="LoggingServiceV2Settings"/>.</param>
        /// <returns>The created <see cref="LoggingServiceV2Client"/>.</returns>
        public static LoggingServiceV2Client Create(gaxgrpc::ServiceEndpoint endpoint = null, LoggingServiceV2Settings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="LoggingServiceV2Client"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="LoggingServiceV2Settings"/>.</param>
        /// <returns>The created <see cref="LoggingServiceV2Client"/>.</returns>
        public static LoggingServiceV2Client Create(grpccore::Channel channel, LoggingServiceV2Settings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="LoggingServiceV2Client"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="LoggingServiceV2Settings"/>.</param>
        /// <returns>The created <see cref="LoggingServiceV2Client"/>.</returns>
        public static LoggingServiceV2Client Create(grpccore::CallInvoker callInvoker, LoggingServiceV2Settings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            LoggingServiceV2.LoggingServiceV2Client grpcClient = new LoggingServiceV2.LoggingServiceV2Client(callInvoker);
            return new LoggingServiceV2ClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, LoggingServiceV2Settings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, LoggingServiceV2Settings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, LoggingServiceV2Settings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, LoggingServiceV2Settings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC LoggingServiceV2 client.
        /// </summary>
        public virtual LoggingServiceV2.LoggingServiceV2Client GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Deletes all the log entries in a log. The log reappears if it receives new
        /// entries. Log entries written shortly before the delete operation might not
        /// be deleted. Entries received after the delete operation with a timestamp
        /// before the operation will be deleted.
        /// </summary>
        /// <param name="logName">
        /// Required. The resource name of the log to delete:
        ///
        ///     "projects/[PROJECT_ID]/logs/[LOG_ID]"
        ///     "organizations/[ORGANIZATION_ID]/logs/[LOG_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/logs/[LOG_ID]"
        ///     "folders/[FOLDER_ID]/logs/[LOG_ID]"
        ///
        /// `[LOG_ID]` must be URL-encoded. For example,
        /// `"projects/my-project-id/logs/syslog"`,
        /// `"organizations/1234567890/logs/cloudresourcemanager.googleapis.com%2Factivity"`.
        /// For more information about log names, see
        /// [LogEntry][google.logging.v2.LogEntry].
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteLogAsync(
            LogNameOneof logName,
            gaxgrpc::CallSettings callSettings = null) => DeleteLogAsync(
                new DeleteLogRequest
                {
                    LogNameAsLogNameOneof = gax::GaxPreconditions.CheckNotNull(logName, nameof(logName)),
                },
                callSettings);

        /// <summary>
        /// Deletes all the log entries in a log. The log reappears if it receives new
        /// entries. Log entries written shortly before the delete operation might not
        /// be deleted. Entries received after the delete operation with a timestamp
        /// before the operation will be deleted.
        /// </summary>
        /// <param name="logName">
        /// Required. The resource name of the log to delete:
        ///
        ///     "projects/[PROJECT_ID]/logs/[LOG_ID]"
        ///     "organizations/[ORGANIZATION_ID]/logs/[LOG_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/logs/[LOG_ID]"
        ///     "folders/[FOLDER_ID]/logs/[LOG_ID]"
        ///
        /// `[LOG_ID]` must be URL-encoded. For example,
        /// `"projects/my-project-id/logs/syslog"`,
        /// `"organizations/1234567890/logs/cloudresourcemanager.googleapis.com%2Factivity"`.
        /// For more information about log names, see
        /// [LogEntry][google.logging.v2.LogEntry].
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteLogAsync(
            LogNameOneof logName,
            st::CancellationToken cancellationToken) => DeleteLogAsync(
                logName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes all the log entries in a log. The log reappears if it receives new
        /// entries. Log entries written shortly before the delete operation might not
        /// be deleted. Entries received after the delete operation with a timestamp
        /// before the operation will be deleted.
        /// </summary>
        /// <param name="logName">
        /// Required. The resource name of the log to delete:
        ///
        ///     "projects/[PROJECT_ID]/logs/[LOG_ID]"
        ///     "organizations/[ORGANIZATION_ID]/logs/[LOG_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/logs/[LOG_ID]"
        ///     "folders/[FOLDER_ID]/logs/[LOG_ID]"
        ///
        /// `[LOG_ID]` must be URL-encoded. For example,
        /// `"projects/my-project-id/logs/syslog"`,
        /// `"organizations/1234567890/logs/cloudresourcemanager.googleapis.com%2Factivity"`.
        /// For more information about log names, see
        /// [LogEntry][google.logging.v2.LogEntry].
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteLog(
            LogNameOneof logName,
            gaxgrpc::CallSettings callSettings = null) => DeleteLog(
                new DeleteLogRequest
                {
                    LogNameAsLogNameOneof = gax::GaxPreconditions.CheckNotNull(logName, nameof(logName)),
                },
                callSettings);

        /// <summary>
        /// Deletes all the log entries in a log. The log reappears if it receives new
        /// entries. Log entries written shortly before the delete operation might not
        /// be deleted. Entries received after the delete operation with a timestamp
        /// before the operation will be deleted.
        /// </summary>
        /// <param name="logName">
        /// Required. The resource name of the log to delete:
        ///
        ///     "projects/[PROJECT_ID]/logs/[LOG_ID]"
        ///     "organizations/[ORGANIZATION_ID]/logs/[LOG_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/logs/[LOG_ID]"
        ///     "folders/[FOLDER_ID]/logs/[LOG_ID]"
        ///
        /// `[LOG_ID]` must be URL-encoded. For example,
        /// `"projects/my-project-id/logs/syslog"`,
        /// `"organizations/1234567890/logs/cloudresourcemanager.googleapis.com%2Factivity"`.
        /// For more information about log names, see
        /// [LogEntry][google.logging.v2.LogEntry].
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteLogAsync(
            string logName,
            gaxgrpc::CallSettings callSettings = null) => DeleteLogAsync(
                new DeleteLogRequest
                {
                    LogName = gax::GaxPreconditions.CheckNotNullOrEmpty(logName, nameof(logName)),
                },
                callSettings);

        /// <summary>
        /// Deletes all the log entries in a log. The log reappears if it receives new
        /// entries. Log entries written shortly before the delete operation might not
        /// be deleted. Entries received after the delete operation with a timestamp
        /// before the operation will be deleted.
        /// </summary>
        /// <param name="logName">
        /// Required. The resource name of the log to delete:
        ///
        ///     "projects/[PROJECT_ID]/logs/[LOG_ID]"
        ///     "organizations/[ORGANIZATION_ID]/logs/[LOG_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/logs/[LOG_ID]"
        ///     "folders/[FOLDER_ID]/logs/[LOG_ID]"
        ///
        /// `[LOG_ID]` must be URL-encoded. For example,
        /// `"projects/my-project-id/logs/syslog"`,
        /// `"organizations/1234567890/logs/cloudresourcemanager.googleapis.com%2Factivity"`.
        /// For more information about log names, see
        /// [LogEntry][google.logging.v2.LogEntry].
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteLogAsync(
            string logName,
            st::CancellationToken cancellationToken) => DeleteLogAsync(
                logName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes all the log entries in a log. The log reappears if it receives new
        /// entries. Log entries written shortly before the delete operation might not
        /// be deleted. Entries received after the delete operation with a timestamp
        /// before the operation will be deleted.
        /// </summary>
        /// <param name="logName">
        /// Required. The resource name of the log to delete:
        ///
        ///     "projects/[PROJECT_ID]/logs/[LOG_ID]"
        ///     "organizations/[ORGANIZATION_ID]/logs/[LOG_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/logs/[LOG_ID]"
        ///     "folders/[FOLDER_ID]/logs/[LOG_ID]"
        ///
        /// `[LOG_ID]` must be URL-encoded. For example,
        /// `"projects/my-project-id/logs/syslog"`,
        /// `"organizations/1234567890/logs/cloudresourcemanager.googleapis.com%2Factivity"`.
        /// For more information about log names, see
        /// [LogEntry][google.logging.v2.LogEntry].
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteLog(
            string logName,
            gaxgrpc::CallSettings callSettings = null) => DeleteLog(
                new DeleteLogRequest
                {
                    LogName = gax::GaxPreconditions.CheckNotNullOrEmpty(logName, nameof(logName)),
                },
                callSettings);

        /// <summary>
        /// Deletes all the log entries in a log. The log reappears if it receives new
        /// entries. Log entries written shortly before the delete operation might not
        /// be deleted. Entries received after the delete operation with a timestamp
        /// before the operation will be deleted.
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
        public virtual stt::Task DeleteLogAsync(
            DeleteLogRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes all the log entries in a log. The log reappears if it receives new
        /// entries. Log entries written shortly before the delete operation might not
        /// be deleted. Entries received after the delete operation with a timestamp
        /// before the operation will be deleted.
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
        public virtual stt::Task DeleteLogAsync(
            DeleteLogRequest request,
            st::CancellationToken cancellationToken) => DeleteLogAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes all the log entries in a log. The log reappears if it receives new
        /// entries. Log entries written shortly before the delete operation might not
        /// be deleted. Entries received after the delete operation with a timestamp
        /// before the operation will be deleted.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteLog(
            DeleteLogRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Writes log entries to Logging. This API method is the
        /// only way to send log entries to Logging. This method
        /// is used, directly or indirectly, by the Logging agent
        /// (fluentd) and all logging libraries configured to use Logging.
        /// A single request may contain log entries for a maximum of 1000
        /// different resources (projects, organizations, billing accounts or
        /// folders)
        /// </summary>
        /// <param name="logName">
        /// Optional. A default log resource name that is assigned to all log entries
        /// in `entries` that do not specify a value for `log_name`:
        ///
        ///     "projects/[PROJECT_ID]/logs/[LOG_ID]"
        ///     "organizations/[ORGANIZATION_ID]/logs/[LOG_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/logs/[LOG_ID]"
        ///     "folders/[FOLDER_ID]/logs/[LOG_ID]"
        ///
        /// `[LOG_ID]` must be URL-encoded. For example:
        ///
        ///     "projects/my-project-id/logs/syslog"
        ///     "organizations/1234567890/logs/cloudresourcemanager.googleapis.com%2Factivity"
        ///
        /// The permission &lt;code&gt;logging.logEntries.create&lt;/code&gt; is needed on each
        /// project, organization, billing account, or folder that is receiving
        /// new log entries, whether the resource is specified in
        /// &lt;code&gt;logName&lt;/code&gt; or in an individual log entry.
        /// </param>
        /// <param name="resource">
        /// Optional. A default monitored resource object that is assigned to all log
        /// entries in `entries` that do not specify a value for `resource`. Example:
        ///
        ///     { "type": "gce_instance",
        ///       "labels": {
        ///         "zone": "us-central1-a", "instance_id": "00000000000000000000" }}
        ///
        /// See [LogEntry][google.logging.v2.LogEntry].
        /// </param>
        /// <param name="labels">
        /// Optional. Default labels that are added to the `labels` field of all log
        /// entries in `entries`. If a log entry already has a label with the same key
        /// as a label in this parameter, then the log entry's label is not changed.
        /// See [LogEntry][google.logging.v2.LogEntry].
        /// </param>
        /// <param name="entries">
        /// Required. The log entries to send to Logging. The order of log
        /// entries in this list does not matter. Values supplied in this method's
        /// `log_name`, `resource`, and `labels` fields are copied into those log
        /// entries in this list that do not include values for their corresponding
        /// fields. For more information, see the
        /// [LogEntry][google.logging.v2.LogEntry] type.
        ///
        /// If the `timestamp` or `insert_id` fields are missing in log entries, then
        /// this method supplies the current time or a unique identifier, respectively.
        /// The supplied values are chosen so that, among the log entries that did not
        /// supply their own values, the entries earlier in the list will sort before
        /// the entries later in the list. See the `entries.list` method.
        ///
        /// Log entries with timestamps that are more than the
        /// [logs retention period](/logging/quota-policy) in the past or more than
        /// 24 hours in the future will not be available when calling `entries.list`.
        /// However, those log entries can still be
        /// [exported with LogSinks](/logging/docs/api/tasks/exporting-logs).
        ///
        /// To improve throughput and to avoid exceeding the
        /// [quota limit](/logging/quota-policy) for calls to `entries.write`,
        /// you should try to include several log entries in this list,
        /// rather than calling this method for each individual log entry.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<WriteLogEntriesResponse> WriteLogEntriesAsync(
            LogNameOneof logName,
            ga::MonitoredResource resource,
            scg::IDictionary<string, string> labels,
            scg::IEnumerable<LogEntry> entries,
            gaxgrpc::CallSettings callSettings = null) => WriteLogEntriesAsync(
                new WriteLogEntriesRequest
                {
                    LogNameAsLogNameOneof = logName, // Optional
                    Resource = resource, // Optional
                    Labels = { labels ?? gax::EmptyDictionary<string, string>.Instance }, // Optional
                    Entries = { gax::GaxPreconditions.CheckNotNull(entries, nameof(entries)) },
                },
                callSettings);

        /// <summary>
        /// Writes log entries to Logging. This API method is the
        /// only way to send log entries to Logging. This method
        /// is used, directly or indirectly, by the Logging agent
        /// (fluentd) and all logging libraries configured to use Logging.
        /// A single request may contain log entries for a maximum of 1000
        /// different resources (projects, organizations, billing accounts or
        /// folders)
        /// </summary>
        /// <param name="logName">
        /// Optional. A default log resource name that is assigned to all log entries
        /// in `entries` that do not specify a value for `log_name`:
        ///
        ///     "projects/[PROJECT_ID]/logs/[LOG_ID]"
        ///     "organizations/[ORGANIZATION_ID]/logs/[LOG_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/logs/[LOG_ID]"
        ///     "folders/[FOLDER_ID]/logs/[LOG_ID]"
        ///
        /// `[LOG_ID]` must be URL-encoded. For example:
        ///
        ///     "projects/my-project-id/logs/syslog"
        ///     "organizations/1234567890/logs/cloudresourcemanager.googleapis.com%2Factivity"
        ///
        /// The permission &lt;code&gt;logging.logEntries.create&lt;/code&gt; is needed on each
        /// project, organization, billing account, or folder that is receiving
        /// new log entries, whether the resource is specified in
        /// &lt;code&gt;logName&lt;/code&gt; or in an individual log entry.
        /// </param>
        /// <param name="resource">
        /// Optional. A default monitored resource object that is assigned to all log
        /// entries in `entries` that do not specify a value for `resource`. Example:
        ///
        ///     { "type": "gce_instance",
        ///       "labels": {
        ///         "zone": "us-central1-a", "instance_id": "00000000000000000000" }}
        ///
        /// See [LogEntry][google.logging.v2.LogEntry].
        /// </param>
        /// <param name="labels">
        /// Optional. Default labels that are added to the `labels` field of all log
        /// entries in `entries`. If a log entry already has a label with the same key
        /// as a label in this parameter, then the log entry's label is not changed.
        /// See [LogEntry][google.logging.v2.LogEntry].
        /// </param>
        /// <param name="entries">
        /// Required. The log entries to send to Logging. The order of log
        /// entries in this list does not matter. Values supplied in this method's
        /// `log_name`, `resource`, and `labels` fields are copied into those log
        /// entries in this list that do not include values for their corresponding
        /// fields. For more information, see the
        /// [LogEntry][google.logging.v2.LogEntry] type.
        ///
        /// If the `timestamp` or `insert_id` fields are missing in log entries, then
        /// this method supplies the current time or a unique identifier, respectively.
        /// The supplied values are chosen so that, among the log entries that did not
        /// supply their own values, the entries earlier in the list will sort before
        /// the entries later in the list. See the `entries.list` method.
        ///
        /// Log entries with timestamps that are more than the
        /// [logs retention period](/logging/quota-policy) in the past or more than
        /// 24 hours in the future will not be available when calling `entries.list`.
        /// However, those log entries can still be
        /// [exported with LogSinks](/logging/docs/api/tasks/exporting-logs).
        ///
        /// To improve throughput and to avoid exceeding the
        /// [quota limit](/logging/quota-policy) for calls to `entries.write`,
        /// you should try to include several log entries in this list,
        /// rather than calling this method for each individual log entry.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<WriteLogEntriesResponse> WriteLogEntriesAsync(
            LogNameOneof logName,
            ga::MonitoredResource resource,
            scg::IDictionary<string, string> labels,
            scg::IEnumerable<LogEntry> entries,
            st::CancellationToken cancellationToken) => WriteLogEntriesAsync(
                logName,
                resource,
                labels,
                entries,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Writes log entries to Logging. This API method is the
        /// only way to send log entries to Logging. This method
        /// is used, directly or indirectly, by the Logging agent
        /// (fluentd) and all logging libraries configured to use Logging.
        /// A single request may contain log entries for a maximum of 1000
        /// different resources (projects, organizations, billing accounts or
        /// folders)
        /// </summary>
        /// <param name="logName">
        /// Optional. A default log resource name that is assigned to all log entries
        /// in `entries` that do not specify a value for `log_name`:
        ///
        ///     "projects/[PROJECT_ID]/logs/[LOG_ID]"
        ///     "organizations/[ORGANIZATION_ID]/logs/[LOG_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/logs/[LOG_ID]"
        ///     "folders/[FOLDER_ID]/logs/[LOG_ID]"
        ///
        /// `[LOG_ID]` must be URL-encoded. For example:
        ///
        ///     "projects/my-project-id/logs/syslog"
        ///     "organizations/1234567890/logs/cloudresourcemanager.googleapis.com%2Factivity"
        ///
        /// The permission &lt;code&gt;logging.logEntries.create&lt;/code&gt; is needed on each
        /// project, organization, billing account, or folder that is receiving
        /// new log entries, whether the resource is specified in
        /// &lt;code&gt;logName&lt;/code&gt; or in an individual log entry.
        /// </param>
        /// <param name="resource">
        /// Optional. A default monitored resource object that is assigned to all log
        /// entries in `entries` that do not specify a value for `resource`. Example:
        ///
        ///     { "type": "gce_instance",
        ///       "labels": {
        ///         "zone": "us-central1-a", "instance_id": "00000000000000000000" }}
        ///
        /// See [LogEntry][google.logging.v2.LogEntry].
        /// </param>
        /// <param name="labels">
        /// Optional. Default labels that are added to the `labels` field of all log
        /// entries in `entries`. If a log entry already has a label with the same key
        /// as a label in this parameter, then the log entry's label is not changed.
        /// See [LogEntry][google.logging.v2.LogEntry].
        /// </param>
        /// <param name="entries">
        /// Required. The log entries to send to Logging. The order of log
        /// entries in this list does not matter. Values supplied in this method's
        /// `log_name`, `resource`, and `labels` fields are copied into those log
        /// entries in this list that do not include values for their corresponding
        /// fields. For more information, see the
        /// [LogEntry][google.logging.v2.LogEntry] type.
        ///
        /// If the `timestamp` or `insert_id` fields are missing in log entries, then
        /// this method supplies the current time or a unique identifier, respectively.
        /// The supplied values are chosen so that, among the log entries that did not
        /// supply their own values, the entries earlier in the list will sort before
        /// the entries later in the list. See the `entries.list` method.
        ///
        /// Log entries with timestamps that are more than the
        /// [logs retention period](/logging/quota-policy) in the past or more than
        /// 24 hours in the future will not be available when calling `entries.list`.
        /// However, those log entries can still be
        /// [exported with LogSinks](/logging/docs/api/tasks/exporting-logs).
        ///
        /// To improve throughput and to avoid exceeding the
        /// [quota limit](/logging/quota-policy) for calls to `entries.write`,
        /// you should try to include several log entries in this list,
        /// rather than calling this method for each individual log entry.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual WriteLogEntriesResponse WriteLogEntries(
            LogNameOneof logName,
            ga::MonitoredResource resource,
            scg::IDictionary<string, string> labels,
            scg::IEnumerable<LogEntry> entries,
            gaxgrpc::CallSettings callSettings = null) => WriteLogEntries(
                new WriteLogEntriesRequest
                {
                    LogNameAsLogNameOneof = logName, // Optional
                    Resource = resource, // Optional
                    Labels = { labels ?? gax::EmptyDictionary<string, string>.Instance }, // Optional
                    Entries = { gax::GaxPreconditions.CheckNotNull(entries, nameof(entries)) },
                },
                callSettings);

        /// <summary>
        /// Writes log entries to Logging. This API method is the
        /// only way to send log entries to Logging. This method
        /// is used, directly or indirectly, by the Logging agent
        /// (fluentd) and all logging libraries configured to use Logging.
        /// A single request may contain log entries for a maximum of 1000
        /// different resources (projects, organizations, billing accounts or
        /// folders)
        /// </summary>
        /// <param name="logName">
        /// Optional. A default log resource name that is assigned to all log entries
        /// in `entries` that do not specify a value for `log_name`:
        ///
        ///     "projects/[PROJECT_ID]/logs/[LOG_ID]"
        ///     "organizations/[ORGANIZATION_ID]/logs/[LOG_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/logs/[LOG_ID]"
        ///     "folders/[FOLDER_ID]/logs/[LOG_ID]"
        ///
        /// `[LOG_ID]` must be URL-encoded. For example:
        ///
        ///     "projects/my-project-id/logs/syslog"
        ///     "organizations/1234567890/logs/cloudresourcemanager.googleapis.com%2Factivity"
        ///
        /// The permission &lt;code&gt;logging.logEntries.create&lt;/code&gt; is needed on each
        /// project, organization, billing account, or folder that is receiving
        /// new log entries, whether the resource is specified in
        /// &lt;code&gt;logName&lt;/code&gt; or in an individual log entry.
        /// </param>
        /// <param name="resource">
        /// Optional. A default monitored resource object that is assigned to all log
        /// entries in `entries` that do not specify a value for `resource`. Example:
        ///
        ///     { "type": "gce_instance",
        ///       "labels": {
        ///         "zone": "us-central1-a", "instance_id": "00000000000000000000" }}
        ///
        /// See [LogEntry][google.logging.v2.LogEntry].
        /// </param>
        /// <param name="labels">
        /// Optional. Default labels that are added to the `labels` field of all log
        /// entries in `entries`. If a log entry already has a label with the same key
        /// as a label in this parameter, then the log entry's label is not changed.
        /// See [LogEntry][google.logging.v2.LogEntry].
        /// </param>
        /// <param name="entries">
        /// Required. The log entries to send to Logging. The order of log
        /// entries in this list does not matter. Values supplied in this method's
        /// `log_name`, `resource`, and `labels` fields are copied into those log
        /// entries in this list that do not include values for their corresponding
        /// fields. For more information, see the
        /// [LogEntry][google.logging.v2.LogEntry] type.
        ///
        /// If the `timestamp` or `insert_id` fields are missing in log entries, then
        /// this method supplies the current time or a unique identifier, respectively.
        /// The supplied values are chosen so that, among the log entries that did not
        /// supply their own values, the entries earlier in the list will sort before
        /// the entries later in the list. See the `entries.list` method.
        ///
        /// Log entries with timestamps that are more than the
        /// [logs retention period](/logging/quota-policy) in the past or more than
        /// 24 hours in the future will not be available when calling `entries.list`.
        /// However, those log entries can still be
        /// [exported with LogSinks](/logging/docs/api/tasks/exporting-logs).
        ///
        /// To improve throughput and to avoid exceeding the
        /// [quota limit](/logging/quota-policy) for calls to `entries.write`,
        /// you should try to include several log entries in this list,
        /// rather than calling this method for each individual log entry.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<WriteLogEntriesResponse> WriteLogEntriesAsync(
            string logName,
            ga::MonitoredResource resource,
            scg::IDictionary<string, string> labels,
            scg::IEnumerable<LogEntry> entries,
            gaxgrpc::CallSettings callSettings = null) => WriteLogEntriesAsync(
                new WriteLogEntriesRequest
                {
                    LogName = logName ?? "", // Optional
                    Resource = resource, // Optional
                    Labels = { labels ?? gax::EmptyDictionary<string, string>.Instance }, // Optional
                    Entries = { gax::GaxPreconditions.CheckNotNull(entries, nameof(entries)) },
                },
                callSettings);

        /// <summary>
        /// Writes log entries to Logging. This API method is the
        /// only way to send log entries to Logging. This method
        /// is used, directly or indirectly, by the Logging agent
        /// (fluentd) and all logging libraries configured to use Logging.
        /// A single request may contain log entries for a maximum of 1000
        /// different resources (projects, organizations, billing accounts or
        /// folders)
        /// </summary>
        /// <param name="logName">
        /// Optional. A default log resource name that is assigned to all log entries
        /// in `entries` that do not specify a value for `log_name`:
        ///
        ///     "projects/[PROJECT_ID]/logs/[LOG_ID]"
        ///     "organizations/[ORGANIZATION_ID]/logs/[LOG_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/logs/[LOG_ID]"
        ///     "folders/[FOLDER_ID]/logs/[LOG_ID]"
        ///
        /// `[LOG_ID]` must be URL-encoded. For example:
        ///
        ///     "projects/my-project-id/logs/syslog"
        ///     "organizations/1234567890/logs/cloudresourcemanager.googleapis.com%2Factivity"
        ///
        /// The permission &lt;code&gt;logging.logEntries.create&lt;/code&gt; is needed on each
        /// project, organization, billing account, or folder that is receiving
        /// new log entries, whether the resource is specified in
        /// &lt;code&gt;logName&lt;/code&gt; or in an individual log entry.
        /// </param>
        /// <param name="resource">
        /// Optional. A default monitored resource object that is assigned to all log
        /// entries in `entries` that do not specify a value for `resource`. Example:
        ///
        ///     { "type": "gce_instance",
        ///       "labels": {
        ///         "zone": "us-central1-a", "instance_id": "00000000000000000000" }}
        ///
        /// See [LogEntry][google.logging.v2.LogEntry].
        /// </param>
        /// <param name="labels">
        /// Optional. Default labels that are added to the `labels` field of all log
        /// entries in `entries`. If a log entry already has a label with the same key
        /// as a label in this parameter, then the log entry's label is not changed.
        /// See [LogEntry][google.logging.v2.LogEntry].
        /// </param>
        /// <param name="entries">
        /// Required. The log entries to send to Logging. The order of log
        /// entries in this list does not matter. Values supplied in this method's
        /// `log_name`, `resource`, and `labels` fields are copied into those log
        /// entries in this list that do not include values for their corresponding
        /// fields. For more information, see the
        /// [LogEntry][google.logging.v2.LogEntry] type.
        ///
        /// If the `timestamp` or `insert_id` fields are missing in log entries, then
        /// this method supplies the current time or a unique identifier, respectively.
        /// The supplied values are chosen so that, among the log entries that did not
        /// supply their own values, the entries earlier in the list will sort before
        /// the entries later in the list. See the `entries.list` method.
        ///
        /// Log entries with timestamps that are more than the
        /// [logs retention period](/logging/quota-policy) in the past or more than
        /// 24 hours in the future will not be available when calling `entries.list`.
        /// However, those log entries can still be
        /// [exported with LogSinks](/logging/docs/api/tasks/exporting-logs).
        ///
        /// To improve throughput and to avoid exceeding the
        /// [quota limit](/logging/quota-policy) for calls to `entries.write`,
        /// you should try to include several log entries in this list,
        /// rather than calling this method for each individual log entry.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<WriteLogEntriesResponse> WriteLogEntriesAsync(
            string logName,
            ga::MonitoredResource resource,
            scg::IDictionary<string, string> labels,
            scg::IEnumerable<LogEntry> entries,
            st::CancellationToken cancellationToken) => WriteLogEntriesAsync(
                logName,
                resource,
                labels,
                entries,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Writes log entries to Logging. This API method is the
        /// only way to send log entries to Logging. This method
        /// is used, directly or indirectly, by the Logging agent
        /// (fluentd) and all logging libraries configured to use Logging.
        /// A single request may contain log entries for a maximum of 1000
        /// different resources (projects, organizations, billing accounts or
        /// folders)
        /// </summary>
        /// <param name="logName">
        /// Optional. A default log resource name that is assigned to all log entries
        /// in `entries` that do not specify a value for `log_name`:
        ///
        ///     "projects/[PROJECT_ID]/logs/[LOG_ID]"
        ///     "organizations/[ORGANIZATION_ID]/logs/[LOG_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/logs/[LOG_ID]"
        ///     "folders/[FOLDER_ID]/logs/[LOG_ID]"
        ///
        /// `[LOG_ID]` must be URL-encoded. For example:
        ///
        ///     "projects/my-project-id/logs/syslog"
        ///     "organizations/1234567890/logs/cloudresourcemanager.googleapis.com%2Factivity"
        ///
        /// The permission &lt;code&gt;logging.logEntries.create&lt;/code&gt; is needed on each
        /// project, organization, billing account, or folder that is receiving
        /// new log entries, whether the resource is specified in
        /// &lt;code&gt;logName&lt;/code&gt; or in an individual log entry.
        /// </param>
        /// <param name="resource">
        /// Optional. A default monitored resource object that is assigned to all log
        /// entries in `entries` that do not specify a value for `resource`. Example:
        ///
        ///     { "type": "gce_instance",
        ///       "labels": {
        ///         "zone": "us-central1-a", "instance_id": "00000000000000000000" }}
        ///
        /// See [LogEntry][google.logging.v2.LogEntry].
        /// </param>
        /// <param name="labels">
        /// Optional. Default labels that are added to the `labels` field of all log
        /// entries in `entries`. If a log entry already has a label with the same key
        /// as a label in this parameter, then the log entry's label is not changed.
        /// See [LogEntry][google.logging.v2.LogEntry].
        /// </param>
        /// <param name="entries">
        /// Required. The log entries to send to Logging. The order of log
        /// entries in this list does not matter. Values supplied in this method's
        /// `log_name`, `resource`, and `labels` fields are copied into those log
        /// entries in this list that do not include values for their corresponding
        /// fields. For more information, see the
        /// [LogEntry][google.logging.v2.LogEntry] type.
        ///
        /// If the `timestamp` or `insert_id` fields are missing in log entries, then
        /// this method supplies the current time or a unique identifier, respectively.
        /// The supplied values are chosen so that, among the log entries that did not
        /// supply their own values, the entries earlier in the list will sort before
        /// the entries later in the list. See the `entries.list` method.
        ///
        /// Log entries with timestamps that are more than the
        /// [logs retention period](/logging/quota-policy) in the past or more than
        /// 24 hours in the future will not be available when calling `entries.list`.
        /// However, those log entries can still be
        /// [exported with LogSinks](/logging/docs/api/tasks/exporting-logs).
        ///
        /// To improve throughput and to avoid exceeding the
        /// [quota limit](/logging/quota-policy) for calls to `entries.write`,
        /// you should try to include several log entries in this list,
        /// rather than calling this method for each individual log entry.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual WriteLogEntriesResponse WriteLogEntries(
            string logName,
            ga::MonitoredResource resource,
            scg::IDictionary<string, string> labels,
            scg::IEnumerable<LogEntry> entries,
            gaxgrpc::CallSettings callSettings = null) => WriteLogEntries(
                new WriteLogEntriesRequest
                {
                    LogName = logName ?? "", // Optional
                    Resource = resource, // Optional
                    Labels = { labels ?? gax::EmptyDictionary<string, string>.Instance }, // Optional
                    Entries = { gax::GaxPreconditions.CheckNotNull(entries, nameof(entries)) },
                },
                callSettings);

        /// <summary>
        /// Writes log entries to Logging. This API method is the
        /// only way to send log entries to Logging. This method
        /// is used, directly or indirectly, by the Logging agent
        /// (fluentd) and all logging libraries configured to use Logging.
        /// A single request may contain log entries for a maximum of 1000
        /// different resources (projects, organizations, billing accounts or
        /// folders)
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
        public virtual stt::Task<WriteLogEntriesResponse> WriteLogEntriesAsync(
            WriteLogEntriesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Writes log entries to Logging. This API method is the
        /// only way to send log entries to Logging. This method
        /// is used, directly or indirectly, by the Logging agent
        /// (fluentd) and all logging libraries configured to use Logging.
        /// A single request may contain log entries for a maximum of 1000
        /// different resources (projects, organizations, billing accounts or
        /// folders)
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
        public virtual stt::Task<WriteLogEntriesResponse> WriteLogEntriesAsync(
            WriteLogEntriesRequest request,
            st::CancellationToken cancellationToken) => WriteLogEntriesAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Writes log entries to Logging. This API method is the
        /// only way to send log entries to Logging. This method
        /// is used, directly or indirectly, by the Logging agent
        /// (fluentd) and all logging libraries configured to use Logging.
        /// A single request may contain log entries for a maximum of 1000
        /// different resources (projects, organizations, billing accounts or
        /// folders)
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
        public virtual WriteLogEntriesResponse WriteLogEntries(
            WriteLogEntriesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists log entries.  Use this method to retrieve log entries that originated
        /// from a project/folder/organization/billing account.  For ways to export log
        /// entries, see [Exporting Logs](/logging/docs/export).
        /// </summary>
        /// <param name="resourceNames">
        /// Required. Names of one or more parent resources from which to
        /// retrieve log entries:
        ///
        ///     "projects/[PROJECT_ID]"
        ///     "organizations/[ORGANIZATION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]"
        ///     "folders/[FOLDER_ID]"
        ///
        ///
        /// Projects listed in the `project_ids` field are added to this list.
        /// </param>
        /// <param name="filter">
        /// Optional. A filter that chooses which log entries to return.  See [Advanced
        /// Logs Queries](/logging/docs/view/advanced-queries).  Only log entries that
        /// match the filter are returned.  An empty filter matches all log entries in
        /// the resources listed in `resource_names`. Referencing a parent resource
        /// that is not listed in `resource_names` will cause the filter to return no
        /// results.
        /// The maximum length of the filter is 20000 characters.
        /// </param>
        /// <param name="orderBy">
        /// Optional. How the results should be sorted.  Presently, the only permitted
        /// values are `"timestamp asc"` (default) and `"timestamp desc"`. The first
        /// option returns entries in order of increasing values of
        /// `LogEntry.timestamp` (oldest first), and the second option returns entries
        /// in order of decreasing timestamps (newest first).  Entries with equal
        /// timestamps are returned in order of their `insert_id` values.
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
        /// A pageable asynchronous sequence of <see cref="LogEntry"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListLogEntriesResponse, LogEntry> ListLogEntriesAsync(
            scg::IEnumerable<ParentNameOneof> resourceNames,
            string filter,
            string orderBy,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListLogEntriesAsync(
                new ListLogEntriesRequest
                {
                    ResourceNamesAsParentNameOneofs = { gax::GaxPreconditions.CheckNotNull(resourceNames, nameof(resourceNames)) },
                    Filter = filter ?? "", // Optional
                    OrderBy = orderBy ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists log entries.  Use this method to retrieve log entries that originated
        /// from a project/folder/organization/billing account.  For ways to export log
        /// entries, see [Exporting Logs](/logging/docs/export).
        /// </summary>
        /// <param name="resourceNames">
        /// Required. Names of one or more parent resources from which to
        /// retrieve log entries:
        ///
        ///     "projects/[PROJECT_ID]"
        ///     "organizations/[ORGANIZATION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]"
        ///     "folders/[FOLDER_ID]"
        ///
        ///
        /// Projects listed in the `project_ids` field are added to this list.
        /// </param>
        /// <param name="filter">
        /// Optional. A filter that chooses which log entries to return.  See [Advanced
        /// Logs Queries](/logging/docs/view/advanced-queries).  Only log entries that
        /// match the filter are returned.  An empty filter matches all log entries in
        /// the resources listed in `resource_names`. Referencing a parent resource
        /// that is not listed in `resource_names` will cause the filter to return no
        /// results.
        /// The maximum length of the filter is 20000 characters.
        /// </param>
        /// <param name="orderBy">
        /// Optional. How the results should be sorted.  Presently, the only permitted
        /// values are `"timestamp asc"` (default) and `"timestamp desc"`. The first
        /// option returns entries in order of increasing values of
        /// `LogEntry.timestamp` (oldest first), and the second option returns entries
        /// in order of decreasing timestamps (newest first).  Entries with equal
        /// timestamps are returned in order of their `insert_id` values.
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
        /// A pageable sequence of <see cref="LogEntry"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListLogEntriesResponse, LogEntry> ListLogEntries(
            scg::IEnumerable<ParentNameOneof> resourceNames,
            string filter,
            string orderBy,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListLogEntries(
                new ListLogEntriesRequest
                {
                    ResourceNamesAsParentNameOneofs = { gax::GaxPreconditions.CheckNotNull(resourceNames, nameof(resourceNames)) },
                    Filter = filter ?? "", // Optional
                    OrderBy = orderBy ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists log entries.  Use this method to retrieve log entries that originated
        /// from a project/folder/organization/billing account.  For ways to export log
        /// entries, see [Exporting Logs](/logging/docs/export).
        /// </summary>
        /// <param name="resourceNames">
        /// Required. Names of one or more parent resources from which to
        /// retrieve log entries:
        ///
        ///     "projects/[PROJECT_ID]"
        ///     "organizations/[ORGANIZATION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]"
        ///     "folders/[FOLDER_ID]"
        ///
        ///
        /// Projects listed in the `project_ids` field are added to this list.
        /// </param>
        /// <param name="filter">
        /// Optional. A filter that chooses which log entries to return.  See [Advanced
        /// Logs Queries](/logging/docs/view/advanced-queries).  Only log entries that
        /// match the filter are returned.  An empty filter matches all log entries in
        /// the resources listed in `resource_names`. Referencing a parent resource
        /// that is not listed in `resource_names` will cause the filter to return no
        /// results.
        /// The maximum length of the filter is 20000 characters.
        /// </param>
        /// <param name="orderBy">
        /// Optional. How the results should be sorted.  Presently, the only permitted
        /// values are `"timestamp asc"` (default) and `"timestamp desc"`. The first
        /// option returns entries in order of increasing values of
        /// `LogEntry.timestamp` (oldest first), and the second option returns entries
        /// in order of decreasing timestamps (newest first).  Entries with equal
        /// timestamps are returned in order of their `insert_id` values.
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
        /// A pageable asynchronous sequence of <see cref="LogEntry"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListLogEntriesResponse, LogEntry> ListLogEntriesAsync(
            scg::IEnumerable<string> resourceNames,
            string filter,
            string orderBy,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListLogEntriesAsync(
                new ListLogEntriesRequest
                {
                    ResourceNames = { gax::GaxPreconditions.CheckNotNull(resourceNames, nameof(resourceNames)) },
                    Filter = filter ?? "", // Optional
                    OrderBy = orderBy ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists log entries.  Use this method to retrieve log entries that originated
        /// from a project/folder/organization/billing account.  For ways to export log
        /// entries, see [Exporting Logs](/logging/docs/export).
        /// </summary>
        /// <param name="resourceNames">
        /// Required. Names of one or more parent resources from which to
        /// retrieve log entries:
        ///
        ///     "projects/[PROJECT_ID]"
        ///     "organizations/[ORGANIZATION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]"
        ///     "folders/[FOLDER_ID]"
        ///
        ///
        /// Projects listed in the `project_ids` field are added to this list.
        /// </param>
        /// <param name="filter">
        /// Optional. A filter that chooses which log entries to return.  See [Advanced
        /// Logs Queries](/logging/docs/view/advanced-queries).  Only log entries that
        /// match the filter are returned.  An empty filter matches all log entries in
        /// the resources listed in `resource_names`. Referencing a parent resource
        /// that is not listed in `resource_names` will cause the filter to return no
        /// results.
        /// The maximum length of the filter is 20000 characters.
        /// </param>
        /// <param name="orderBy">
        /// Optional. How the results should be sorted.  Presently, the only permitted
        /// values are `"timestamp asc"` (default) and `"timestamp desc"`. The first
        /// option returns entries in order of increasing values of
        /// `LogEntry.timestamp` (oldest first), and the second option returns entries
        /// in order of decreasing timestamps (newest first).  Entries with equal
        /// timestamps are returned in order of their `insert_id` values.
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
        /// A pageable sequence of <see cref="LogEntry"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListLogEntriesResponse, LogEntry> ListLogEntries(
            scg::IEnumerable<string> resourceNames,
            string filter,
            string orderBy,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListLogEntries(
                new ListLogEntriesRequest
                {
                    ResourceNames = { gax::GaxPreconditions.CheckNotNull(resourceNames, nameof(resourceNames)) },
                    Filter = filter ?? "", // Optional
                    OrderBy = orderBy ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists log entries.  Use this method to retrieve log entries that originated
        /// from a project/folder/organization/billing account.  For ways to export log
        /// entries, see [Exporting Logs](/logging/docs/export).
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="LogEntry"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListLogEntriesResponse, LogEntry> ListLogEntriesAsync(
            ListLogEntriesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists log entries.  Use this method to retrieve log entries that originated
        /// from a project/folder/organization/billing account.  For ways to export log
        /// entries, see [Exporting Logs](/logging/docs/export).
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="LogEntry"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListLogEntriesResponse, LogEntry> ListLogEntries(
            ListLogEntriesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists the descriptors for monitored resource types used by Logging.
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
        /// Lists the descriptors for monitored resource types used by Logging.
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
        /// Lists the logs in projects, organizations, folders, or billing accounts.
        /// Only logs that have entries are listed.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name that owns the logs:
        ///
        ///     "projects/[PROJECT_ID]"
        ///     "organizations/[ORGANIZATION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]"
        ///     "folders/[FOLDER_ID]"
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
        /// A pageable asynchronous sequence of <see cref="string"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListLogsResponse, string> ListLogsAsync(
            ParentNameOneof parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListLogsAsync(
                new ListLogsRequest
                {
                    ParentAsParentNameOneof = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the logs in projects, organizations, folders, or billing accounts.
        /// Only logs that have entries are listed.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name that owns the logs:
        ///
        ///     "projects/[PROJECT_ID]"
        ///     "organizations/[ORGANIZATION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]"
        ///     "folders/[FOLDER_ID]"
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
        /// A pageable sequence of <see cref="string"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListLogsResponse, string> ListLogs(
            ParentNameOneof parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListLogs(
                new ListLogsRequest
                {
                    ParentAsParentNameOneof = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the logs in projects, organizations, folders, or billing accounts.
        /// Only logs that have entries are listed.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name that owns the logs:
        ///
        ///     "projects/[PROJECT_ID]"
        ///     "organizations/[ORGANIZATION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]"
        ///     "folders/[FOLDER_ID]"
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
        /// A pageable asynchronous sequence of <see cref="string"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListLogsResponse, string> ListLogsAsync(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListLogsAsync(
                new ListLogsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the logs in projects, organizations, folders, or billing accounts.
        /// Only logs that have entries are listed.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name that owns the logs:
        ///
        ///     "projects/[PROJECT_ID]"
        ///     "organizations/[ORGANIZATION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]"
        ///     "folders/[FOLDER_ID]"
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
        /// A pageable sequence of <see cref="string"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListLogsResponse, string> ListLogs(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListLogs(
                new ListLogsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the logs in projects, organizations, folders, or billing accounts.
        /// Only logs that have entries are listed.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="string"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListLogsResponse, string> ListLogsAsync(
            ListLogsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists the logs in projects, organizations, folders, or billing accounts.
        /// Only logs that have entries are listed.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="string"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListLogsResponse, string> ListLogs(
            ListLogsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// LoggingServiceV2 client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class LoggingServiceV2ClientImpl : LoggingServiceV2Client
    {
        private readonly gaxgrpc::ApiCall<DeleteLogRequest, pbwkt::Empty> _callDeleteLog;
        private readonly gaxgrpc::ApiCall<WriteLogEntriesRequest, WriteLogEntriesResponse> _callWriteLogEntries;
        private readonly gaxgrpc::ApiCall<ListLogEntriesRequest, ListLogEntriesResponse> _callListLogEntries;
        private readonly gaxgrpc::ApiCall<ListMonitoredResourceDescriptorsRequest, ListMonitoredResourceDescriptorsResponse> _callListMonitoredResourceDescriptors;
        private readonly gaxgrpc::ApiCall<ListLogsRequest, ListLogsResponse> _callListLogs;

        /// <summary>
        /// Constructs a client wrapper for the LoggingServiceV2 service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="LoggingServiceV2Settings"/> used within this client </param>
        public LoggingServiceV2ClientImpl(LoggingServiceV2.LoggingServiceV2Client grpcClient, LoggingServiceV2Settings settings)
        {
            GrpcClient = grpcClient;
            LoggingServiceV2Settings effectiveSettings = settings ?? LoggingServiceV2Settings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callDeleteLog = clientHelper.BuildApiCall<DeleteLogRequest, pbwkt::Empty>(
                GrpcClient.DeleteLogAsync, GrpcClient.DeleteLog, effectiveSettings.DeleteLogSettings)
                .WithGoogleRequestParam("log_name", request => request.LogName);
            _callWriteLogEntries = clientHelper.BuildApiCall<WriteLogEntriesRequest, WriteLogEntriesResponse>(
                GrpcClient.WriteLogEntriesAsync, GrpcClient.WriteLogEntries, effectiveSettings.WriteLogEntriesSettings);
            _callListLogEntries = clientHelper.BuildApiCall<ListLogEntriesRequest, ListLogEntriesResponse>(
                GrpcClient.ListLogEntriesAsync, GrpcClient.ListLogEntries, effectiveSettings.ListLogEntriesSettings);
            _callListMonitoredResourceDescriptors = clientHelper.BuildApiCall<ListMonitoredResourceDescriptorsRequest, ListMonitoredResourceDescriptorsResponse>(
                GrpcClient.ListMonitoredResourceDescriptorsAsync, GrpcClient.ListMonitoredResourceDescriptors, effectiveSettings.ListMonitoredResourceDescriptorsSettings);
            _callListLogs = clientHelper.BuildApiCall<ListLogsRequest, ListLogsResponse>(
                GrpcClient.ListLogsAsync, GrpcClient.ListLogs, effectiveSettings.ListLogsSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callDeleteLog);
            Modify_DeleteLogApiCall(ref _callDeleteLog);
            Modify_ApiCall(ref _callWriteLogEntries);
            Modify_WriteLogEntriesApiCall(ref _callWriteLogEntries);
            Modify_ApiCall(ref _callListLogEntries);
            Modify_ListLogEntriesApiCall(ref _callListLogEntries);
            Modify_ApiCall(ref _callListMonitoredResourceDescriptors);
            Modify_ListMonitoredResourceDescriptorsApiCall(ref _callListMonitoredResourceDescriptors);
            Modify_ApiCall(ref _callListLogs);
            Modify_ListLogsApiCall(ref _callListLogs);
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
        partial void Modify_DeleteLogApiCall(ref gaxgrpc::ApiCall<DeleteLogRequest, pbwkt::Empty> call);
        partial void Modify_WriteLogEntriesApiCall(ref gaxgrpc::ApiCall<WriteLogEntriesRequest, WriteLogEntriesResponse> call);
        partial void Modify_ListLogEntriesApiCall(ref gaxgrpc::ApiCall<ListLogEntriesRequest, ListLogEntriesResponse> call);
        partial void Modify_ListMonitoredResourceDescriptorsApiCall(ref gaxgrpc::ApiCall<ListMonitoredResourceDescriptorsRequest, ListMonitoredResourceDescriptorsResponse> call);
        partial void Modify_ListLogsApiCall(ref gaxgrpc::ApiCall<ListLogsRequest, ListLogsResponse> call);
        partial void OnConstruction(LoggingServiceV2.LoggingServiceV2Client grpcClient, LoggingServiceV2Settings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC LoggingServiceV2 client.
        /// </summary>
        public override LoggingServiceV2.LoggingServiceV2Client GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_DeleteLogRequest(ref DeleteLogRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_WriteLogEntriesRequest(ref WriteLogEntriesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListLogEntriesRequest(ref ListLogEntriesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListMonitoredResourceDescriptorsRequest(ref ListMonitoredResourceDescriptorsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListLogsRequest(ref ListLogsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Deletes all the log entries in a log. The log reappears if it receives new
        /// entries. Log entries written shortly before the delete operation might not
        /// be deleted. Entries received after the delete operation with a timestamp
        /// before the operation will be deleted.
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
        public override stt::Task DeleteLogAsync(
            DeleteLogRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteLogRequest(ref request, ref callSettings);
            return _callDeleteLog.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes all the log entries in a log. The log reappears if it receives new
        /// entries. Log entries written shortly before the delete operation might not
        /// be deleted. Entries received after the delete operation with a timestamp
        /// before the operation will be deleted.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteLog(
            DeleteLogRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteLogRequest(ref request, ref callSettings);
            _callDeleteLog.Sync(request, callSettings);
        }

        /// <summary>
        /// Writes log entries to Logging. This API method is the
        /// only way to send log entries to Logging. This method
        /// is used, directly or indirectly, by the Logging agent
        /// (fluentd) and all logging libraries configured to use Logging.
        /// A single request may contain log entries for a maximum of 1000
        /// different resources (projects, organizations, billing accounts or
        /// folders)
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
        public override stt::Task<WriteLogEntriesResponse> WriteLogEntriesAsync(
            WriteLogEntriesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_WriteLogEntriesRequest(ref request, ref callSettings);
            return _callWriteLogEntries.Async(request, callSettings);
        }

        /// <summary>
        /// Writes log entries to Logging. This API method is the
        /// only way to send log entries to Logging. This method
        /// is used, directly or indirectly, by the Logging agent
        /// (fluentd) and all logging libraries configured to use Logging.
        /// A single request may contain log entries for a maximum of 1000
        /// different resources (projects, organizations, billing accounts or
        /// folders)
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
        public override WriteLogEntriesResponse WriteLogEntries(
            WriteLogEntriesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_WriteLogEntriesRequest(ref request, ref callSettings);
            return _callWriteLogEntries.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists log entries.  Use this method to retrieve log entries that originated
        /// from a project/folder/organization/billing account.  For ways to export log
        /// entries, see [Exporting Logs](/logging/docs/export).
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="LogEntry"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListLogEntriesResponse, LogEntry> ListLogEntriesAsync(
            ListLogEntriesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLogEntriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListLogEntriesRequest, ListLogEntriesResponse, LogEntry>(_callListLogEntries, request, callSettings);
        }

        /// <summary>
        /// Lists log entries.  Use this method to retrieve log entries that originated
        /// from a project/folder/organization/billing account.  For ways to export log
        /// entries, see [Exporting Logs](/logging/docs/export).
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="LogEntry"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListLogEntriesResponse, LogEntry> ListLogEntries(
            ListLogEntriesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLogEntriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListLogEntriesRequest, ListLogEntriesResponse, LogEntry>(_callListLogEntries, request, callSettings);
        }

        /// <summary>
        /// Lists the descriptors for monitored resource types used by Logging.
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
        /// Lists the descriptors for monitored resource types used by Logging.
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
        /// Lists the logs in projects, organizations, folders, or billing accounts.
        /// Only logs that have entries are listed.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="string"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListLogsResponse, string> ListLogsAsync(
            ListLogsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLogsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListLogsRequest, ListLogsResponse, string>(_callListLogs, request, callSettings);
        }

        /// <summary>
        /// Lists the logs in projects, organizations, folders, or billing accounts.
        /// Only logs that have entries are listed.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="string"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListLogsResponse, string> ListLogs(
            ListLogsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLogsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListLogsRequest, ListLogsResponse, string>(_callListLogs, request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListLogEntriesRequest : gaxgrpc::IPageRequest { }
    public partial class ListLogEntriesResponse : gaxgrpc::IPageResponse<LogEntry>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<LogEntry> GetEnumerator() => Entries.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

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

    public partial class ListLogsRequest : gaxgrpc::IPageRequest { }
    public partial class ListLogsResponse : gaxgrpc::IPageResponse<string>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<string> GetEnumerator() => LogNames.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
