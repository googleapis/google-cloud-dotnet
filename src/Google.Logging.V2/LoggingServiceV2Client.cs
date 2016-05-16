// Copyright 2016 Google Inc. All Rights Reserved.
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
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Logging.V2
{

    /// <summary>
    /// Extension methods to assist with using <see cref="LoggingServiceV2Client"/>.
    /// </summary>
    public static partial class LoggingServiceV2Extensions
    {
        /// <summary>
        /// Wrap a GRPC LoggingServiceV2 client for more convenient use.
        /// </summary>
        /// <param name="grpcClient">A GRPC client to wrap.</param>
        /// <param name="settings">
        /// An optional <see cref="LoggingServiceV2Settings"/> to configure this wrapper.
        /// If null or not specified, then the default settings are used.
        /// </param>
        /// <returns>A <see cref="LoggingServiceV2Client"/> that wraps the specified GRPC client.</returns>
        public static LoggingServiceV2Client ToClient(
            this LoggingServiceV2.ILoggingServiceV2Client grpcClient,
            LoggingServiceV2Settings settings = null
        ) => new LoggingServiceV2ClientImpl(grpcClient, settings);
    }

    /// <summary>
    /// Settings for a LoggingServiceV2 wrapper.
    /// </summary>
    public sealed partial class LoggingServiceV2Settings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="LoggingServiceV2Settings"/>.
        /// </summary>
        /// <returns>A new instance of the default LoggingServiceV2Settings.</returns>
        public static LoggingServiceV2Settings GetDefault() => new LoggingServiceV2Settings();

        /// <summary>
        /// Constructs a new LoggingServiceV2Settings object with default settings.
        /// </summary>
        public LoggingServiceV2Settings() { }

        private LoggingServiceV2Settings(LoggingServiceV2Settings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            DeleteLogSettings = existing.DeleteLogSettings?.Clone();
            WriteLogEntriesSettings = existing.WriteLogEntriesSettings?.Clone();
            ListLogEntriesSettings = existing.ListLogEntriesSettings?.Clone();
            ListMonitoredResourceDescriptorsSettings = existing.ListMonitoredResourceDescriptorsSettings?.Clone();
        }

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="LoggingServiceV2Client"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static Predicate<RpcException> IdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes(StatusCode.DeadlineExceeded, StatusCode.Unavailable);

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
        /// <returns>The "Default" retry backoff for <see cref="LoggingServiceV2Client"/> RPC methods.</returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="LoggingServiceV2Client"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.2</description></item>
        /// <item><description>Maximum delay: 1000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultRetryBackoff() => new BackoffSettings
        {
            Delay = TimeSpan.FromMilliseconds(100),
            DelayMultiplier = 1.2,
            MaxDelay = TimeSpan.FromMilliseconds(1000),
        };

        /// <summary>
        /// "Default" timeout backoff for <see cref="LoggingServiceV2Client"/> RPC methods.
        /// </summary>
        /// <returns>The "Default" timeout backoff for <see cref="LoggingServiceV2Client"/> RPC methods.</returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="LoggingServiceV2Client"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 2000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Maximum timeout: 30000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings
        {
            Delay = TimeSpan.FromMilliseconds(2000),
            DelayMultiplier = 1.5,
            MaxDelay = TimeSpan.FromMilliseconds(30000),
        };

        /// <summary>
        /// "List" retry backoff for <see cref="LoggingServiceV2Client"/> RPC methods.
        /// </summary>
        /// <returns>The "List" retry backoff for <see cref="LoggingServiceV2Client"/> RPC methods.</returns>
        /// <remarks>
        /// The "List" retry backoff for <see cref="LoggingServiceV2Client"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.2</description></item>
        /// <item><description>Maximum delay: 1000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetListRetryBackoff() => new BackoffSettings
        {
            Delay = TimeSpan.FromMilliseconds(100),
            DelayMultiplier = 1.2,
            MaxDelay = TimeSpan.FromMilliseconds(1000),
        };

        /// <summary>
        /// "List" timeout backoff for <see cref="LoggingServiceV2Client"/> RPC methods.
        /// </summary>
        /// <returns>The "List" timeout backoff for <see cref="LoggingServiceV2Client"/> RPC methods.</returns>
        /// <remarks>
        /// The "List" timeout backoff for <see cref="LoggingServiceV2Client"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 7000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.5</description></item>
        /// <item><description>Maximum timeout: 30000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetListTimeoutBackoff() => new BackoffSettings
        {
            Delay = TimeSpan.FromMilliseconds(7000),
            DelayMultiplier = 1.5,
            MaxDelay = TimeSpan.FromMilliseconds(30000),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for asynchronous and synchronous calls to
        /// <see cref="LoggingServiceV2Client.DeleteLog"/> and <see cref="LoggingServiceV2Client.DeleteLogAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="LoggingServiceV2Client.DeleteLog"/> and
        /// <see cref="LoggingServiceV2Client.DeleteLogAsync"/> <see cref="RetrySettings"/> are:
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
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 45000 milliseconds.
        /// </remarks>
        public CallSettings DeleteLogSettings { get; set; } = new CallSettings
        {
            RetrySettings = new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = IdempotentRetryFilter,
            },
            Expiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(45000)),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for asynchronous and synchronous calls to
        /// <see cref="LoggingServiceV2Client.WriteLogEntries"/> and <see cref="LoggingServiceV2Client.WriteLogEntriesAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="LoggingServiceV2Client.WriteLogEntries"/> and
        /// <see cref="LoggingServiceV2Client.WriteLogEntriesAsync"/> <see cref="RetrySettings"/> are:
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
        public CallSettings WriteLogEntriesSettings { get; set; } = new CallSettings
        {
            RetrySettings = new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = NonIdempotentRetryFilter,
            },
            Expiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(45000)),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for asynchronous and synchronous calls to
        /// <see cref="LoggingServiceV2Client.ListLogEntries"/> and <see cref="LoggingServiceV2Client.ListLogEntriesAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="LoggingServiceV2Client.ListLogEntries"/> and
        /// <see cref="LoggingServiceV2Client.ListLogEntriesAsync"/> <see cref="RetrySettings"/> are:
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
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 45000 milliseconds.
        /// </remarks>
        public CallSettings ListLogEntriesSettings { get; set; } = new CallSettings
        {
            RetrySettings = new RetrySettings
            {
                RetryBackoff = GetListRetryBackoff(),
                TimeoutBackoff = GetListTimeoutBackoff(),
                RetryFilter = IdempotentRetryFilter,
            },
            Expiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(45000)),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for asynchronous and synchronous calls to
        /// <see cref="LoggingServiceV2Client.ListMonitoredResourceDescriptors"/> and <see cref="LoggingServiceV2Client.ListMonitoredResourceDescriptorsAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="LoggingServiceV2Client.ListMonitoredResourceDescriptors"/> and
        /// <see cref="LoggingServiceV2Client.ListMonitoredResourceDescriptorsAsync"/> <see cref="RetrySettings"/> are:
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
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 45000 milliseconds.
        /// </remarks>
        public CallSettings ListMonitoredResourceDescriptorsSettings { get; set; } = new CallSettings
        {
            RetrySettings = new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = IdempotentRetryFilter,
            },
            Expiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(45000)),
        };


        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this set of LoggingServiceV2 settings.</returns>
        public LoggingServiceV2Settings Clone() => new LoggingServiceV2Settings(this);
    }

    /// <summary>
    /// LoggingServiceV2 client wrapper, for convenient use.
    /// </summary>
    public abstract partial class LoggingServiceV2Client
    {
        private static readonly ChannelPool s_channelPool = new ChannelPool();

        /// <summary>
        /// The default endpoint for the LoggingServiceV2 service, which is a host of "logging.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("logging.googleapis.com", 443);

        /// <summary>
        /// The default LoggingServiceV2 scopes
        /// </summary>
        /// <remarks>
        /// The default LoggingServiceV2 scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/logging.write"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/logging.admin"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/logging.read"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform.read-only"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new[] {
            "https://www.googleapis.com/auth/logging.write",
            "https://www.googleapis.com/auth/logging.admin",
            "https://www.googleapis.com/auth/logging.read",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>
        /// Path template for a project resource. Parameters:
        /// <list type="bullet">
        /// <item><description>project</description></item>
        /// </list>
        /// </summary>
        public static PathTemplate ProjectTemplate { get; } = new PathTemplate("projects/{project}");

        /// <summary>
        /// Creates a project resource name from its component IDs.
        /// </summary>
        /// <param name="projectId">The project ID.</param>
        /// <returns>The full project resource name.</returns>
        public static string GetProjectName(string projectId) => ProjectTemplate.Expand(projectId);

        /// <summary>
        /// Path template for a log resource. Parameters:
        /// <list type="bullet">
        /// <item><description>project</description></item>
        /// <item><description>log</description></item>
        /// </list>
        /// </summary>
        public static PathTemplate LogTemplate { get; } = new PathTemplate("projects/{project}/logs/{log}");

        /// <summary>
        /// Creates a log resource name from its component IDs.
        /// </summary>
        /// <param name="projectId">The project ID.</param>
        /// <param name="logId">The log ID.</param>
        /// <returns>The full log resource name.</returns>
        public static string GetLogName(string projectId, string logId) => LogTemplate.Expand(projectId, logId);

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
        /// The underlying GRPC LoggingServiceV2 client.
        /// </summary>
        public virtual LoggingServiceV2.ILoggingServiceV2Client GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Deletes a log and all its log entries.
        /// The log will reappear if it receives new entries.
        /// </summary>
        /// <param name="log_name">
        /// Required. The resource name of the log to delete.  Example:
        /// `"projects/my-project/logs/syslog"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task DeleteLogAsync(
            string logName,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a log and all its log entries.
        /// The log will reappear if it receives new entries.
        /// </summary>
        /// <param name="log_name">
        /// Required. The resource name of the log to delete.  Example:
        /// `"projects/my-project/logs/syslog"`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task DeleteLogAsync(
            string logName,
            CancellationToken cancellationToken) => DeleteLogAsync(
                logName,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Deletes a log and all its log entries.
        /// The log will reappear if it receives new entries.
        /// </summary>
        /// <param name="log_name">
        /// Required. The resource name of the log to delete.  Example:
        /// `"projects/my-project/logs/syslog"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteLog(
            string logName,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Writes log entries to Cloud Logging.
        /// All log entries in Cloud Logging are written by this method.
        /// </summary>
        /// <param name="log_name">
        /// Optional. A default log resource name for those log entries in `entries`
        /// that do not specify their own `logName`.  Example:
        /// `"projects/my-project/logs/syslog"`.  See
        /// [LogEntry][google.logging.v2.LogEntry].
        /// </param>
        /// <param name="resource">
        /// Optional. A default monitored resource for those log entries in `entries`
        /// that do not specify their own `resource`.
        /// </param>
        /// <param name="labels">
        /// Optional. User-defined `key:value` items that are added to
        /// the `labels` field of each log entry in `entries`, except when a log
        /// entry specifies its own `key:value` item with the same key.
        /// Example: `{ "size": "large", "color":"red" }`
        /// </param>
        /// <param name="entries">
        /// Required. The log entries to write. The log entries must have values for
        /// all required fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<WriteLogEntriesResponse> WriteLogEntriesAsync(
            string logName,
            MonitoredResource resource,
            IDictionary<string, string> labels,
            IEnumerable<LogEntry> entries,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Writes log entries to Cloud Logging.
        /// All log entries in Cloud Logging are written by this method.
        /// </summary>
        /// <param name="log_name">
        /// Optional. A default log resource name for those log entries in `entries`
        /// that do not specify their own `logName`.  Example:
        /// `"projects/my-project/logs/syslog"`.  See
        /// [LogEntry][google.logging.v2.LogEntry].
        /// </param>
        /// <param name="resource">
        /// Optional. A default monitored resource for those log entries in `entries`
        /// that do not specify their own `resource`.
        /// </param>
        /// <param name="labels">
        /// Optional. User-defined `key:value` items that are added to
        /// the `labels` field of each log entry in `entries`, except when a log
        /// entry specifies its own `key:value` item with the same key.
        /// Example: `{ "size": "large", "color":"red" }`
        /// </param>
        /// <param name="entries">
        /// Required. The log entries to write. The log entries must have values for
        /// all required fields.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<WriteLogEntriesResponse> WriteLogEntriesAsync(
            string logName,
            MonitoredResource resource,
            IDictionary<string, string> labels,
            IEnumerable<LogEntry> entries,
            CancellationToken cancellationToken) => WriteLogEntriesAsync(
                logName,
                resource,
                labels,
                entries,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Writes log entries to Cloud Logging.
        /// All log entries in Cloud Logging are written by this method.
        /// </summary>
        /// <param name="log_name">
        /// Optional. A default log resource name for those log entries in `entries`
        /// that do not specify their own `logName`.  Example:
        /// `"projects/my-project/logs/syslog"`.  See
        /// [LogEntry][google.logging.v2.LogEntry].
        /// </param>
        /// <param name="resource">
        /// Optional. A default monitored resource for those log entries in `entries`
        /// that do not specify their own `resource`.
        /// </param>
        /// <param name="labels">
        /// Optional. User-defined `key:value` items that are added to
        /// the `labels` field of each log entry in `entries`, except when a log
        /// entry specifies its own `key:value` item with the same key.
        /// Example: `{ "size": "large", "color":"red" }`
        /// </param>
        /// <param name="entries">
        /// Required. The log entries to write. The log entries must have values for
        /// all required fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WriteLogEntriesResponse WriteLogEntries(
            string logName,
            MonitoredResource resource,
            IDictionary<string, string> labels,
            IEnumerable<LogEntry> entries,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists log entries.  Use this method to retrieve log entries from Cloud
        /// Logging.  For ways to export log entries, see
        /// [Exporting Logs](/logging/docs/export).
        /// </summary>
        /// <param name="project_ids">
        /// Required. One or more project IDs or project numbers from which to retrieve
        /// log entries.  Examples of a project ID: `"my-project-1A"`, `"1234567890"`.
        /// </param>
        /// <param name="filter">
        /// Optional. An [advanced logs filter](/logging/docs/view/advanced_filters).
        /// The filter is compared against all log entries in the projects specified by
        /// `projectIds`.  Only entries that match the filter are retrieved.  An empty
        /// filter matches all log entries.
        /// </param>
        /// <param name="order_by">
        /// Optional. How the results should be sorted.  Presently, the only permitted
        /// values are `"timestamp"` (default) and `"timestamp desc"`.  The first
        /// option returns entries in order of increasing values of
        /// `LogEntry.timestamp` (oldest first), and the second option returns entries
        /// in order of decreasing timestamps (newest first).  Entries with equal
        /// timestamps are returned in order of `LogEntry.insertId`.
        /// </param>
        /// <param name="pageToken">The token returned from the previous request.
        /// <c>Null</c> or an empty string retrieves the first page.</param>
        /// <param name="pageSize">The size of page to request, the response will not be larger
        /// than this, but may be smaller. <c>Null</c> or 0 uses a server-defined page size.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>An asynchronous sequence of pages of LogEntry items.</returns>
        public virtual IPagedAsyncEnumerable<ListLogEntriesResponse, LogEntry> ListLogEntriesPageStreamAsync(
            IEnumerable<string> projectIds,
            string filter,
            string orderBy,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists log entries.  Use this method to retrieve log entries from Cloud
        /// Logging.  For ways to export log entries, see
        /// [Exporting Logs](/logging/docs/export).
        /// </summary>
        /// <param name="project_ids">
        /// Required. One or more project IDs or project numbers from which to retrieve
        /// log entries.  Examples of a project ID: `"my-project-1A"`, `"1234567890"`.
        /// </param>
        /// <param name="filter">
        /// Optional. An [advanced logs filter](/logging/docs/view/advanced_filters).
        /// The filter is compared against all log entries in the projects specified by
        /// `projectIds`.  Only entries that match the filter are retrieved.  An empty
        /// filter matches all log entries.
        /// </param>
        /// <param name="order_by">
        /// Optional. How the results should be sorted.  Presently, the only permitted
        /// values are `"timestamp"` (default) and `"timestamp desc"`.  The first
        /// option returns entries in order of increasing values of
        /// `LogEntry.timestamp` (oldest first), and the second option returns entries
        /// in order of decreasing timestamps (newest first).  Entries with equal
        /// timestamps are returned in order of `LogEntry.insertId`.
        /// </param>
        /// <param name="pageToken">The token returned from the previous request.
        /// <c>Null</c> or an empty string retrieves the first page.</param>
        /// <param name="pageSize">The size of page to request, the response will not be larger
        /// than this, but may be smaller. <c>Null</c> or 0 uses a server-defined page size.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A sequence of pages of LogEntry items.</returns>
        public virtual IPagedEnumerable<ListLogEntriesResponse, LogEntry> ListLogEntriesPageStream(
            IEnumerable<string> projectIds,
            string filter,
            string orderBy,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }


    }

    public sealed partial class LoggingServiceV2ClientImpl : LoggingServiceV2Client
    {
        private readonly ClientHelper _clientHelper;
        private readonly ApiCall<DeleteLogRequest, Empty> _callDeleteLog;
        private readonly ApiCall<WriteLogEntriesRequest, WriteLogEntriesResponse> _callWriteLogEntries;
        private readonly ApiCall<ListLogEntriesRequest, ListLogEntriesResponse> _callListLogEntries;
        private readonly ApiCall<ListMonitoredResourceDescriptorsRequest, ListMonitoredResourceDescriptorsResponse> _callListMonitoredResourceDescriptors;

        public LoggingServiceV2ClientImpl(LoggingServiceV2.ILoggingServiceV2Client grpcClient, LoggingServiceV2Settings settings)
        {
            this.GrpcClient = grpcClient;
            LoggingServiceV2Settings effectiveSettings = settings ?? LoggingServiceV2Settings.GetDefault();
            _clientHelper = new ClientHelper(effectiveSettings);
            _callDeleteLog = _clientHelper.BuildApiCall<DeleteLogRequest, Empty>(
                GrpcClient.DeleteLogAsync, GrpcClient.DeleteLog, effectiveSettings.DeleteLogSettings);
            _callWriteLogEntries = _clientHelper.BuildApiCall<WriteLogEntriesRequest, WriteLogEntriesResponse>(
                GrpcClient.WriteLogEntriesAsync, GrpcClient.WriteLogEntries, effectiveSettings.WriteLogEntriesSettings);
            _callListLogEntries = _clientHelper.BuildApiCall<ListLogEntriesRequest, ListLogEntriesResponse>(
                GrpcClient.ListLogEntriesAsync, GrpcClient.ListLogEntries, effectiveSettings.ListLogEntriesSettings);
            _callListMonitoredResourceDescriptors = _clientHelper.BuildApiCall<ListMonitoredResourceDescriptorsRequest, ListMonitoredResourceDescriptorsResponse>(
                GrpcClient.ListMonitoredResourceDescriptorsAsync, GrpcClient.ListMonitoredResourceDescriptors, effectiveSettings.ListMonitoredResourceDescriptorsSettings);
        }

        public override LoggingServiceV2.ILoggingServiceV2Client GrpcClient { get; }

        /// <summary>
        /// Deletes a log and all its log entries.
        /// The log will reappear if it receives new entries.
        /// </summary>
        /// <param name="log_name">
        /// Required. The resource name of the log to delete.  Example:
        /// `"projects/my-project/logs/syslog"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task DeleteLogAsync(
            string logName,
            CallSettings callSettings = null) => _callDeleteLog.Async(
                new DeleteLogRequest
                {
                    LogName = logName,
                },
                callSettings);

        /// <summary>
        /// Deletes a log and all its log entries.
        /// The log will reappear if it receives new entries.
        /// </summary>
        /// <param name="log_name">
        /// Required. The resource name of the log to delete.  Example:
        /// `"projects/my-project/logs/syslog"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteLog(
            string logName,
            CallSettings callSettings = null) => _callDeleteLog.Sync(
                new DeleteLogRequest
                {
                    LogName = logName,
                },
                callSettings);

        /// <summary>
        /// Writes log entries to Cloud Logging.
        /// All log entries in Cloud Logging are written by this method.
        /// </summary>
        /// <param name="log_name">
        /// Optional. A default log resource name for those log entries in `entries`
        /// that do not specify their own `logName`.  Example:
        /// `"projects/my-project/logs/syslog"`.  See
        /// [LogEntry][google.logging.v2.LogEntry].
        /// </param>
        /// <param name="resource">
        /// Optional. A default monitored resource for those log entries in `entries`
        /// that do not specify their own `resource`.
        /// </param>
        /// <param name="labels">
        /// Optional. User-defined `key:value` items that are added to
        /// the `labels` field of each log entry in `entries`, except when a log
        /// entry specifies its own `key:value` item with the same key.
        /// Example: `{ "size": "large", "color":"red" }`
        /// </param>
        /// <param name="entries">
        /// Required. The log entries to write. The log entries must have values for
        /// all required fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<WriteLogEntriesResponse> WriteLogEntriesAsync(
            string logName,
            MonitoredResource resource,
            IDictionary<string, string> labels,
            IEnumerable<LogEntry> entries,
            CallSettings callSettings = null) => _callWriteLogEntries.Async(
                new WriteLogEntriesRequest
                {
                    LogName = logName,
                    Resource = resource,
                    Labels = { labels },
                    Entries = { entries },
                },
                callSettings);

        /// <summary>
        /// Writes log entries to Cloud Logging.
        /// All log entries in Cloud Logging are written by this method.
        /// </summary>
        /// <param name="log_name">
        /// Optional. A default log resource name for those log entries in `entries`
        /// that do not specify their own `logName`.  Example:
        /// `"projects/my-project/logs/syslog"`.  See
        /// [LogEntry][google.logging.v2.LogEntry].
        /// </param>
        /// <param name="resource">
        /// Optional. A default monitored resource for those log entries in `entries`
        /// that do not specify their own `resource`.
        /// </param>
        /// <param name="labels">
        /// Optional. User-defined `key:value` items that are added to
        /// the `labels` field of each log entry in `entries`, except when a log
        /// entry specifies its own `key:value` item with the same key.
        /// Example: `{ "size": "large", "color":"red" }`
        /// </param>
        /// <param name="entries">
        /// Required. The log entries to write. The log entries must have values for
        /// all required fields.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override WriteLogEntriesResponse WriteLogEntries(
            string logName,
            MonitoredResource resource,
            IDictionary<string, string> labels,
            IEnumerable<LogEntry> entries,
            CallSettings callSettings = null) => _callWriteLogEntries.Sync(
                new WriteLogEntriesRequest
                {
                    LogName = logName,
                    Resource = resource,
                    Labels = { labels },
                    Entries = { entries },
                },
                callSettings);

        /// <summary>
        /// Lists log entries.  Use this method to retrieve log entries from Cloud
        /// Logging.  For ways to export log entries, see
        /// [Exporting Logs](/logging/docs/export).
        /// </summary>
        /// <param name="project_ids">
        /// Required. One or more project IDs or project numbers from which to retrieve
        /// log entries.  Examples of a project ID: `"my-project-1A"`, `"1234567890"`.
        /// </param>
        /// <param name="filter">
        /// Optional. An [advanced logs filter](/logging/docs/view/advanced_filters).
        /// The filter is compared against all log entries in the projects specified by
        /// `projectIds`.  Only entries that match the filter are retrieved.  An empty
        /// filter matches all log entries.
        /// </param>
        /// <param name="order_by">
        /// Optional. How the results should be sorted.  Presently, the only permitted
        /// values are `"timestamp"` (default) and `"timestamp desc"`.  The first
        /// option returns entries in order of increasing values of
        /// `LogEntry.timestamp` (oldest first), and the second option returns entries
        /// in order of decreasing timestamps (newest first).  Entries with equal
        /// timestamps are returned in order of `LogEntry.insertId`.
        /// </param>
        /// <param name="pageToken">The token returned from the previous request.
        /// <c>Null</c> or an empty string retrieves the first page.</param>
        /// <param name="pageSize">The size of page to request, the response will not be larger
        /// than this, but may be smaller. <c>Null</c> or 0 uses a server-defined page size.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>An asynchronous sequence of pages of LogEntry items.</returns>
        public override IPagedAsyncEnumerable<ListLogEntriesResponse, LogEntry> ListLogEntriesPageStreamAsync(
            IEnumerable<string> projectIds,
            string filter,
            string orderBy,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => new PagedAsyncEnumerable<ListLogEntriesRequest, ListLogEntriesResponse, LogEntry>(
                _callListLogEntries,
                new ListLogEntriesRequest
                {
                    ProjectIds = { projectIds },
                    Filter = filter,
                    OrderBy = orderBy,
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists log entries.  Use this method to retrieve log entries from Cloud
        /// Logging.  For ways to export log entries, see
        /// [Exporting Logs](/logging/docs/export).
        /// </summary>
        /// <param name="project_ids">
        /// Required. One or more project IDs or project numbers from which to retrieve
        /// log entries.  Examples of a project ID: `"my-project-1A"`, `"1234567890"`.
        /// </param>
        /// <param name="filter">
        /// Optional. An [advanced logs filter](/logging/docs/view/advanced_filters).
        /// The filter is compared against all log entries in the projects specified by
        /// `projectIds`.  Only entries that match the filter are retrieved.  An empty
        /// filter matches all log entries.
        /// </param>
        /// <param name="order_by">
        /// Optional. How the results should be sorted.  Presently, the only permitted
        /// values are `"timestamp"` (default) and `"timestamp desc"`.  The first
        /// option returns entries in order of increasing values of
        /// `LogEntry.timestamp` (oldest first), and the second option returns entries
        /// in order of decreasing timestamps (newest first).  Entries with equal
        /// timestamps are returned in order of `LogEntry.insertId`.
        /// </param>
        /// <param name="pageToken">The token returned from the previous request.
        /// <c>Null</c> or an empty string retrieves the first page.</param>
        /// <param name="pageSize">The size of page to request, the response will not be larger
        /// than this, but may be smaller. <c>Null</c> or 0 uses a server-defined page size.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A sequence of pages of LogEntry items.</returns>
        public override IPagedEnumerable<ListLogEntriesResponse, LogEntry> ListLogEntriesPageStream(
            IEnumerable<string> projectIds,
            string filter,
            string orderBy,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => new PagedEnumerable<ListLogEntriesRequest, ListLogEntriesResponse, LogEntry>(
                _callListLogEntries,
                new ListLogEntriesRequest
                {
                    ProjectIds = { projectIds },
                    Filter = filter,
                    OrderBy = orderBy,
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);


    }

    // Partial classes to enable page-streaming

    public partial class ListLogEntriesRequest : IPageRequest { }
    public partial class ListLogEntriesResponse : IPageResponse<LogEntry>
    {
        public IEnumerator<LogEntry> GetEnumerator() => Entries.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListMonitoredResourceDescriptorsRequest : IPageRequest { }
    public partial class ListMonitoredResourceDescriptorsResponse : IPageResponse<MonitoredResourceDescriptor>
    {
        public IEnumerator<MonitoredResourceDescriptor> GetEnumerator() => ResourceDescriptors.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

}