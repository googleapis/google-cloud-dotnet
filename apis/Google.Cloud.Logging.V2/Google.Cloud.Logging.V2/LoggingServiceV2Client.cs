// Copyright 2017, Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using Google.Api;
using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Logging.V2
{
    /// <summary>
    /// Settings for a <see cref="LoggingServiceV2Client"/>.
    /// </summary>
    public sealed partial class LoggingServiceV2Settings : ServiceSettingsBase
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
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            DeleteLogSettings = existing.DeleteLogSettings;
            WriteLogEntriesSettings = existing.WriteLogEntriesSettings;
            ListLogEntriesSettings = existing.ListLogEntriesSettings;
            ListMonitoredResourceDescriptorsSettings = existing.ListMonitoredResourceDescriptorsSettings;
            ListLogsSettings = existing.ListLogsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(LoggingServiceV2Settings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="LoggingServiceV2Client"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Internal"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static Predicate<RpcException> IdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes(StatusCode.DeadlineExceeded, StatusCode.Internal, StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="LoggingServiceV2Client"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

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
        /// <item><description>Maximum delay: 1000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.2</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultRetryBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(100),
            maxDelay: TimeSpan.FromMilliseconds(1000),
            delayMultiplier: 1.2
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
        /// <item><description>Initial timeout: 2000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Maximum timeout: 30000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(2000),
            maxDelay: TimeSpan.FromMilliseconds(30000),
            delayMultiplier: 1.5
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
        /// <item><description>Maximum delay: 1000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.2</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetListRetryBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(100),
            maxDelay: TimeSpan.FromMilliseconds(1000),
            delayMultiplier: 1.2
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
        /// <item><description>Initial timeout: 7000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Maximum timeout: 30000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetListTimeoutBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(7000),
            maxDelay: TimeSpan.FromMilliseconds(30000),
            delayMultiplier: 1.5
        );

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LoggingServiceV2Client.DeleteLog</c> and <c>LoggingServiceV2Client.DeleteLogAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>LoggingServiceV2Client.DeleteLog</c> and
        /// <c>LoggingServiceV2Client.DeleteLogAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 1000 milliseconds</description></item>
        /// <item><description>Initial timeout: 2000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Timeout maximum delay: 30000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Internal"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 45000 milliseconds.
        /// </remarks>
        public CallSettings DeleteLogSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(45000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LoggingServiceV2Client.WriteLogEntries</c> and <c>LoggingServiceV2Client.WriteLogEntriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>LoggingServiceV2Client.WriteLogEntries</c> and
        /// <c>LoggingServiceV2Client.WriteLogEntriesAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 1000 milliseconds</description></item>
        /// <item><description>Initial timeout: 2000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Timeout maximum delay: 30000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 45000 milliseconds.
        /// </remarks>
        public CallSettings WriteLogEntriesSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(45000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LoggingServiceV2Client.ListLogEntries</c> and <c>LoggingServiceV2Client.ListLogEntriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>LoggingServiceV2Client.ListLogEntries</c> and
        /// <c>LoggingServiceV2Client.ListLogEntriesAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 1000 milliseconds</description></item>
        /// <item><description>Initial timeout: 7000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Timeout maximum delay: 30000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Internal"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 45000 milliseconds.
        /// </remarks>
        public CallSettings ListLogEntriesSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetListRetryBackoff(),
                timeoutBackoff: GetListTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(45000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LoggingServiceV2Client.ListMonitoredResourceDescriptors</c> and <c>LoggingServiceV2Client.ListMonitoredResourceDescriptorsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>LoggingServiceV2Client.ListMonitoredResourceDescriptors</c> and
        /// <c>LoggingServiceV2Client.ListMonitoredResourceDescriptorsAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 1000 milliseconds</description></item>
        /// <item><description>Initial timeout: 2000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Timeout maximum delay: 30000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Internal"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 45000 milliseconds.
        /// </remarks>
        public CallSettings ListMonitoredResourceDescriptorsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(45000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LoggingServiceV2Client.ListLogs</c> and <c>LoggingServiceV2Client.ListLogsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>LoggingServiceV2Client.ListLogs</c> and
        /// <c>LoggingServiceV2Client.ListLogsAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.2</description></item>
        /// <item><description>Retry maximum delay: 1000 milliseconds</description></item>
        /// <item><description>Initial timeout: 2000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Timeout maximum delay: 30000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Internal"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 45000 milliseconds.
        /// </remarks>
        public CallSettings ListLogsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(45000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="LoggingServiceV2Settings"/> object.</returns>
        public LoggingServiceV2Settings Clone() => new LoggingServiceV2Settings(this);
    }

    /// <summary>
    /// LoggingServiceV2 client wrapper, for convenient use.
    /// </summary>
    public abstract partial class LoggingServiceV2Client
    {
        /// <summary>
        /// The default endpoint for the LoggingServiceV2 service, which is a host of "logging.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("logging.googleapis.com", 443);

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
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
            "https://www.googleapis.com/auth/logging.admin",
            "https://www.googleapis.com/auth/logging.read",
            "https://www.googleapis.com/auth/logging.write",
        });

        private static readonly ChannelPool s_channelPool = new ChannelPool(DefaultScopes);

        // Note: we could have parameterless overloads of Create and CreateAsync,
        // documented to just use the default endpoint, settings and credentials.
        // Pros:
        // - Might be more reassuring on first use
        // - Allows method group conversions
        // Con: overloads!

        /// <summary>
        /// Asynchronously creates a <see cref="LoggingServiceV2Client"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="LoggingServiceV2Settings"/>.</param>
        /// <returns>The task representing the created <see cref="LoggingServiceV2Client"/>.</returns>
        public static async Task<LoggingServiceV2Client> CreateAsync(ServiceEndpoint endpoint = null, LoggingServiceV2Settings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="LoggingServiceV2Client"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="LoggingServiceV2Settings"/>.</param>
        /// <returns>The created <see cref="LoggingServiceV2Client"/>.</returns>
        public static LoggingServiceV2Client Create(ServiceEndpoint endpoint = null, LoggingServiceV2Settings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="LoggingServiceV2Client"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="LoggingServiceV2Settings"/>.</param>
        /// <returns>The created <see cref="LoggingServiceV2Client"/>.</returns>
        public static LoggingServiceV2Client Create(Channel channel, LoggingServiceV2Settings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            LoggingServiceV2.LoggingServiceV2Client grpcClient = new LoggingServiceV2.LoggingServiceV2Client(channel);
            return new LoggingServiceV2ClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, LoggingServiceV2Settings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, LoggingServiceV2Settings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, LoggingServiceV2Settings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, LoggingServiceV2Settings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC LoggingServiceV2 client.
        /// </summary>
        public virtual LoggingServiceV2.LoggingServiceV2Client GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Deletes all the log entries in a log.
        /// The log reappears if it receives new entries.
        /// Log entries written shortly before the delete operation might not be
        /// deleted.
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
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteLogAsync(
            LogNameOneof logName,
            CallSettings callSettings = null) => DeleteLogAsync(
                new DeleteLogRequest
                {
                    LogNameAsLogNameOneof = GaxPreconditions.CheckNotNull(logName, nameof(logName)),
                },
                callSettings);

        /// <summary>
        /// Deletes all the log entries in a log.
        /// The log reappears if it receives new entries.
        /// Log entries written shortly before the delete operation might not be
        /// deleted.
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
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteLogAsync(
            LogNameOneof logName,
            CancellationToken cancellationToken) => DeleteLogAsync(
                logName,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes all the log entries in a log.
        /// The log reappears if it receives new entries.
        /// Log entries written shortly before the delete operation might not be
        /// deleted.
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
        /// The RPC response.
        /// </returns>
        public virtual void DeleteLog(
            LogNameOneof logName,
            CallSettings callSettings = null) => DeleteLog(
                new DeleteLogRequest
                {
                    LogNameAsLogNameOneof = GaxPreconditions.CheckNotNull(logName, nameof(logName)),
                },
                callSettings);

        /// <summary>
        /// Deletes all the log entries in a log.
        /// The log reappears if it receives new entries.
        /// Log entries written shortly before the delete operation might not be
        /// deleted.
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
        public virtual Task DeleteLogAsync(
            DeleteLogRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes all the log entries in a log.
        /// The log reappears if it receives new entries.
        /// Log entries written shortly before the delete operation might not be
        /// deleted.
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
        public virtual void DeleteLog(
            DeleteLogRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Writes log entries to Stackdriver Logging.
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
        /// `[LOG_ID]` must be URL-encoded. For example,
        /// `"projects/my-project-id/logs/syslog"` or
        /// `"organizations/1234567890/logs/cloudresourcemanager.googleapis.com%2Factivity"`.
        /// For more information about log names, see
        /// [LogEntry][google.logging.v2.LogEntry].
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
        /// Required.  The log entries to write. Values supplied for the fields
        /// `log_name`, `resource`, and `labels` in this `entries.write` request are
        /// inserted into those log entries in this list that do not provide their own
        /// values.
        ///
        /// Stackdriver Logging also creates and inserts values for `timestamp` and
        /// `insert_id` if the entries do not provide them. The created `insert_id` for
        /// the N'th entry in this list will be greater than earlier entries and less
        /// than later entries.  Otherwise, the order of log entries in this list does
        /// not matter.
        ///
        /// To improve throughput and to avoid exceeding the
        /// [quota limit](/logging/quota-policy) for calls to `entries.write`,
        /// you should write multiple log entries at once rather than
        /// calling this method for each individual log entry.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<WriteLogEntriesResponse> WriteLogEntriesAsync(
            LogNameOneof logName,
            MonitoredResource resource,
            IDictionary<string, string> labels,
            IEnumerable<LogEntry> entries,
            CallSettings callSettings = null) => WriteLogEntriesAsync(
                new WriteLogEntriesRequest
                {
                    LogNameAsLogNameOneof = logName, // Optional
                    Resource = resource, // Optional
                    Labels = { labels ?? EmptyDictionary<string, string>.Instance }, // Optional
                    Entries = { GaxPreconditions.CheckNotNull(entries, nameof(entries)) },
                },
                callSettings);

        /// <summary>
        /// Writes log entries to Stackdriver Logging.
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
        /// `[LOG_ID]` must be URL-encoded. For example,
        /// `"projects/my-project-id/logs/syslog"` or
        /// `"organizations/1234567890/logs/cloudresourcemanager.googleapis.com%2Factivity"`.
        /// For more information about log names, see
        /// [LogEntry][google.logging.v2.LogEntry].
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
        /// Required.  The log entries to write. Values supplied for the fields
        /// `log_name`, `resource`, and `labels` in this `entries.write` request are
        /// inserted into those log entries in this list that do not provide their own
        /// values.
        ///
        /// Stackdriver Logging also creates and inserts values for `timestamp` and
        /// `insert_id` if the entries do not provide them. The created `insert_id` for
        /// the N'th entry in this list will be greater than earlier entries and less
        /// than later entries.  Otherwise, the order of log entries in this list does
        /// not matter.
        ///
        /// To improve throughput and to avoid exceeding the
        /// [quota limit](/logging/quota-policy) for calls to `entries.write`,
        /// you should write multiple log entries at once rather than
        /// calling this method for each individual log entry.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<WriteLogEntriesResponse> WriteLogEntriesAsync(
            LogNameOneof logName,
            MonitoredResource resource,
            IDictionary<string, string> labels,
            IEnumerable<LogEntry> entries,
            CancellationToken cancellationToken) => WriteLogEntriesAsync(
                logName,
                resource,
                labels,
                entries,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Writes log entries to Stackdriver Logging.
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
        /// `[LOG_ID]` must be URL-encoded. For example,
        /// `"projects/my-project-id/logs/syslog"` or
        /// `"organizations/1234567890/logs/cloudresourcemanager.googleapis.com%2Factivity"`.
        /// For more information about log names, see
        /// [LogEntry][google.logging.v2.LogEntry].
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
        /// Required.  The log entries to write. Values supplied for the fields
        /// `log_name`, `resource`, and `labels` in this `entries.write` request are
        /// inserted into those log entries in this list that do not provide their own
        /// values.
        ///
        /// Stackdriver Logging also creates and inserts values for `timestamp` and
        /// `insert_id` if the entries do not provide them. The created `insert_id` for
        /// the N'th entry in this list will be greater than earlier entries and less
        /// than later entries.  Otherwise, the order of log entries in this list does
        /// not matter.
        ///
        /// To improve throughput and to avoid exceeding the
        /// [quota limit](/logging/quota-policy) for calls to `entries.write`,
        /// you should write multiple log entries at once rather than
        /// calling this method for each individual log entry.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual WriteLogEntriesResponse WriteLogEntries(
            LogNameOneof logName,
            MonitoredResource resource,
            IDictionary<string, string> labels,
            IEnumerable<LogEntry> entries,
            CallSettings callSettings = null) => WriteLogEntries(
                new WriteLogEntriesRequest
                {
                    LogNameAsLogNameOneof = logName, // Optional
                    Resource = resource, // Optional
                    Labels = { labels ?? EmptyDictionary<string, string>.Instance }, // Optional
                    Entries = { GaxPreconditions.CheckNotNull(entries, nameof(entries)) },
                },
                callSettings);

        /// <summary>
        /// Writes log entries to Stackdriver Logging.
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
        public virtual Task<WriteLogEntriesResponse> WriteLogEntriesAsync(
            WriteLogEntriesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Writes log entries to Stackdriver Logging.
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
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists log entries.  Use this method to retrieve log entries from
        /// Stackdriver Logging.  For ways to export log entries, see
        /// [Exporting Logs](/logging/docs/export).
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
        /// Projects listed in the `project_ids` field are added to this list.
        /// </param>
        /// <param name="filter">
        /// Optional. A filter that chooses which log entries to return.  See [Advanced
        /// Logs Filters](/logging/docs/view/advanced_filters).  Only log entries that
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
        public virtual PagedAsyncEnumerable<ListLogEntriesResponse, LogEntry> ListLogEntriesAsync(
            IEnumerable<string> resourceNames,
            string filter,
            string orderBy,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListLogEntriesAsync(
                new ListLogEntriesRequest
                {
                    ResourceNames = { GaxPreconditions.CheckNotNull(resourceNames, nameof(resourceNames)) },
                    Filter = filter ?? "", // Optional
                    OrderBy = orderBy ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists log entries.  Use this method to retrieve log entries from
        /// Stackdriver Logging.  For ways to export log entries, see
        /// [Exporting Logs](/logging/docs/export).
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
        /// Projects listed in the `project_ids` field are added to this list.
        /// </param>
        /// <param name="filter">
        /// Optional. A filter that chooses which log entries to return.  See [Advanced
        /// Logs Filters](/logging/docs/view/advanced_filters).  Only log entries that
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
        public virtual PagedEnumerable<ListLogEntriesResponse, LogEntry> ListLogEntries(
            IEnumerable<string> resourceNames,
            string filter,
            string orderBy,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListLogEntries(
                new ListLogEntriesRequest
                {
                    ResourceNames = { GaxPreconditions.CheckNotNull(resourceNames, nameof(resourceNames)) },
                    Filter = filter ?? "", // Optional
                    OrderBy = orderBy ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists log entries.  Use this method to retrieve log entries from
        /// Stackdriver Logging.  For ways to export log entries, see
        /// [Exporting Logs](/logging/docs/export).
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
        public virtual PagedAsyncEnumerable<ListLogEntriesResponse, LogEntry> ListLogEntriesAsync(
            ListLogEntriesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists log entries.  Use this method to retrieve log entries from
        /// Stackdriver Logging.  For ways to export log entries, see
        /// [Exporting Logs](/logging/docs/export).
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
        public virtual PagedEnumerable<ListLogEntriesResponse, LogEntry> ListLogEntries(
            ListLogEntriesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists the descriptors for monitored resource types used by Stackdriver
        /// Logging.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="MonitoredResourceDescriptor"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListMonitoredResourceDescriptorsResponse, MonitoredResourceDescriptor> ListMonitoredResourceDescriptorsAsync(
            ListMonitoredResourceDescriptorsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists the descriptors for monitored resource types used by Stackdriver
        /// Logging.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="MonitoredResourceDescriptor"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListMonitoredResourceDescriptorsResponse, MonitoredResourceDescriptor> ListMonitoredResourceDescriptors(
            ListMonitoredResourceDescriptorsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
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
        public virtual PagedAsyncEnumerable<ListLogsResponse, string> ListLogsAsync(
            ParentNameOneof parent,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListLogsAsync(
                new ListLogsRequest
                {
                    ParentAsParentNameOneof = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        public virtual PagedEnumerable<ListLogsResponse, string> ListLogs(
            ParentNameOneof parent,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListLogs(
                new ListLogsRequest
                {
                    ParentAsParentNameOneof = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        public virtual PagedAsyncEnumerable<ListLogsResponse, string> ListLogsAsync(
            ListLogsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
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
        public virtual PagedEnumerable<ListLogsResponse, string> ListLogs(
            ListLogsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    /// <summary>
    /// LoggingServiceV2 client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class LoggingServiceV2ClientImpl : LoggingServiceV2Client
    {
        private readonly ApiCall<DeleteLogRequest, Empty> _callDeleteLog;
        private readonly ApiCall<WriteLogEntriesRequest, WriteLogEntriesResponse> _callWriteLogEntries;
        private readonly ApiCall<ListLogEntriesRequest, ListLogEntriesResponse> _callListLogEntries;
        private readonly ApiCall<ListMonitoredResourceDescriptorsRequest, ListMonitoredResourceDescriptorsResponse> _callListMonitoredResourceDescriptors;
        private readonly ApiCall<ListLogsRequest, ListLogsResponse> _callListLogs;

        /// <summary>
        /// Constructs a client wrapper for the LoggingServiceV2 service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="LoggingServiceV2Settings"/> used within this client </param>
        public LoggingServiceV2ClientImpl(LoggingServiceV2.LoggingServiceV2Client grpcClient, LoggingServiceV2Settings settings)
        {
            this.GrpcClient = grpcClient;
            LoggingServiceV2Settings effectiveSettings = settings ?? LoggingServiceV2Settings.GetDefault();
            ClientHelper clientHelper = new ClientHelper(effectiveSettings);
            _callDeleteLog = clientHelper.BuildApiCall<DeleteLogRequest, Empty>(
                GrpcClient.DeleteLogAsync, GrpcClient.DeleteLog, effectiveSettings.DeleteLogSettings);
            _callWriteLogEntries = clientHelper.BuildApiCall<WriteLogEntriesRequest, WriteLogEntriesResponse>(
                GrpcClient.WriteLogEntriesAsync, GrpcClient.WriteLogEntries, effectiveSettings.WriteLogEntriesSettings);
            _callListLogEntries = clientHelper.BuildApiCall<ListLogEntriesRequest, ListLogEntriesResponse>(
                GrpcClient.ListLogEntriesAsync, GrpcClient.ListLogEntries, effectiveSettings.ListLogEntriesSettings);
            _callListMonitoredResourceDescriptors = clientHelper.BuildApiCall<ListMonitoredResourceDescriptorsRequest, ListMonitoredResourceDescriptorsResponse>(
                GrpcClient.ListMonitoredResourceDescriptorsAsync, GrpcClient.ListMonitoredResourceDescriptors, effectiveSettings.ListMonitoredResourceDescriptorsSettings);
            _callListLogs = clientHelper.BuildApiCall<ListLogsRequest, ListLogsResponse>(
                GrpcClient.ListLogsAsync, GrpcClient.ListLogs, effectiveSettings.ListLogsSettings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void OnConstruction(LoggingServiceV2.LoggingServiceV2Client grpcClient, LoggingServiceV2Settings effectiveSettings, ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC LoggingServiceV2 client.
        /// </summary>
        public override LoggingServiceV2.LoggingServiceV2Client GrpcClient { get; }

        // Partial modifier methods contain '_' to ensure no name conflicts with RPC methods.
        partial void Modify_DeleteLogRequest(ref DeleteLogRequest request, ref CallSettings settings);
        partial void Modify_WriteLogEntriesRequest(ref WriteLogEntriesRequest request, ref CallSettings settings);
        partial void Modify_ListLogEntriesRequest(ref ListLogEntriesRequest request, ref CallSettings settings);
        partial void Modify_ListMonitoredResourceDescriptorsRequest(ref ListMonitoredResourceDescriptorsRequest request, ref CallSettings settings);
        partial void Modify_ListLogsRequest(ref ListLogsRequest request, ref CallSettings settings);

        /// <summary>
        /// Deletes all the log entries in a log.
        /// The log reappears if it receives new entries.
        /// Log entries written shortly before the delete operation might not be
        /// deleted.
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
        public override Task DeleteLogAsync(
            DeleteLogRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteLogRequest(ref request, ref callSettings);
            return _callDeleteLog.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes all the log entries in a log.
        /// The log reappears if it receives new entries.
        /// Log entries written shortly before the delete operation might not be
        /// deleted.
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
        public override void DeleteLog(
            DeleteLogRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteLogRequest(ref request, ref callSettings);
            _callDeleteLog.Sync(request, callSettings);
        }

        /// <summary>
        /// Writes log entries to Stackdriver Logging.
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
        public override Task<WriteLogEntriesResponse> WriteLogEntriesAsync(
            WriteLogEntriesRequest request,
            CallSettings callSettings = null)
        {
            Modify_WriteLogEntriesRequest(ref request, ref callSettings);
            return _callWriteLogEntries.Async(request, callSettings);
        }

        /// <summary>
        /// Writes log entries to Stackdriver Logging.
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
            CallSettings callSettings = null)
        {
            Modify_WriteLogEntriesRequest(ref request, ref callSettings);
            return _callWriteLogEntries.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists log entries.  Use this method to retrieve log entries from
        /// Stackdriver Logging.  For ways to export log entries, see
        /// [Exporting Logs](/logging/docs/export).
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
        public override PagedAsyncEnumerable<ListLogEntriesResponse, LogEntry> ListLogEntriesAsync(
            ListLogEntriesRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListLogEntriesRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<ListLogEntriesRequest, ListLogEntriesResponse, LogEntry>(_callListLogEntries, request, callSettings);
        }

        /// <summary>
        /// Lists log entries.  Use this method to retrieve log entries from
        /// Stackdriver Logging.  For ways to export log entries, see
        /// [Exporting Logs](/logging/docs/export).
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
        public override PagedEnumerable<ListLogEntriesResponse, LogEntry> ListLogEntries(
            ListLogEntriesRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListLogEntriesRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<ListLogEntriesRequest, ListLogEntriesResponse, LogEntry>(_callListLogEntries, request, callSettings);
        }

        /// <summary>
        /// Lists the descriptors for monitored resource types used by Stackdriver
        /// Logging.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="MonitoredResourceDescriptor"/> resources.
        /// </returns>
        public override PagedAsyncEnumerable<ListMonitoredResourceDescriptorsResponse, MonitoredResourceDescriptor> ListMonitoredResourceDescriptorsAsync(
            ListMonitoredResourceDescriptorsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListMonitoredResourceDescriptorsRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<ListMonitoredResourceDescriptorsRequest, ListMonitoredResourceDescriptorsResponse, MonitoredResourceDescriptor>(_callListMonitoredResourceDescriptors, request, callSettings);
        }

        /// <summary>
        /// Lists the descriptors for monitored resource types used by Stackdriver
        /// Logging.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="MonitoredResourceDescriptor"/> resources.
        /// </returns>
        public override PagedEnumerable<ListMonitoredResourceDescriptorsResponse, MonitoredResourceDescriptor> ListMonitoredResourceDescriptors(
            ListMonitoredResourceDescriptorsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListMonitoredResourceDescriptorsRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<ListMonitoredResourceDescriptorsRequest, ListMonitoredResourceDescriptorsResponse, MonitoredResourceDescriptor>(_callListMonitoredResourceDescriptors, request, callSettings);
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
        public override PagedAsyncEnumerable<ListLogsResponse, string> ListLogsAsync(
            ListLogsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListLogsRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<ListLogsRequest, ListLogsResponse, string>(_callListLogs, request, callSettings);
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
        public override PagedEnumerable<ListLogsResponse, string> ListLogs(
            ListLogsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListLogsRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<ListLogsRequest, ListLogsResponse, string>(_callListLogs, request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListLogEntriesRequest : IPageRequest { }
    public partial class ListLogEntriesResponse : IPageResponse<LogEntry>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<LogEntry> GetEnumerator() => Entries.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListMonitoredResourceDescriptorsRequest : IPageRequest { }
    public partial class ListMonitoredResourceDescriptorsResponse : IPageResponse<MonitoredResourceDescriptor>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<MonitoredResourceDescriptor> GetEnumerator() => ResourceDescriptors.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListLogsRequest : IPageRequest { }
    public partial class ListLogsResponse : IPageResponse<string>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<string> GetEnumerator() => LogNames.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

}
