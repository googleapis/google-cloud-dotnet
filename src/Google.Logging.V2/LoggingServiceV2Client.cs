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
using Grpc.Core;
using System;
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
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this set of LoggingServiceV2 settings.</returns>
        public LoggingServiceV2Settings Clone() => CloneInto(new LoggingServiceV2Settings
        {
        });
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
        /// Asynchronously creates a <see cref="LoggingServiceV2Client"/>, applying defaults for all unspecified settings.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="LoggingServiceV2Settings"/>.</param>
        /// <param name="credentials">Optional <see cref="ChannelCredentials"/>.</param>
        /// <returns>The task representing the created <see cref="LoggingServiceV2Client"/>.</returns>
        public static async Task<LoggingServiceV2Client> CreateAsync(
            ServiceEndpoint endpoint = null,
            LoggingServiceV2Settings settings = null,
            ChannelCredentials credentials = null)
        {
            Channel channel = await ClientHelper.CreateChannelAsync(endpoint ?? DefaultEndpoint, credentials).ConfigureAwait(false);
            LoggingServiceV2.LoggingServiceV2Client grpcClient = new LoggingServiceV2.LoggingServiceV2Client(channel);
            return new LoggingServiceV2ClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="LoggingServiceV2Client"/>, applying defaults for all unspecified settings.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="LoggingServiceV2Settings"/>.</param>
        /// <param name="credentials">Optional <see cref="ChannelCredentials"/>.</param>
        /// <returns>The created <see cref="LoggingServiceV2Client"/>.</returns>
        public static LoggingServiceV2Client Create(
            ServiceEndpoint endpoint = null,
            LoggingServiceV2Settings settings = null,
            ChannelCredentials credentials = null)
        {
            Channel channel = ClientHelper.CreateChannel(endpoint ?? DefaultEndpoint, credentials);
            LoggingServiceV2.LoggingServiceV2Client grpcClient = new LoggingServiceV2.LoggingServiceV2Client(channel);
            return new LoggingServiceV2ClientImpl(grpcClient, settings);
        }

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
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual IAsyncEnumerable<LogEntry> ListLogEntriesAsync(
            IEnumerable<string> projectIds,
            string filter,
            string orderBy,
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
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IEnumerable<LogEntry> ListLogEntries(
            IEnumerable<string> projectIds,
            string filter,
            string orderBy,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    public sealed partial class LoggingServiceV2ClientImpl : LoggingServiceV2Client
    {
        private static readonly PageStreamer<LogEntry, ListLogEntriesRequest, ListLogEntriesResponse, string> s_listLogEntriesPageStreamer =
            new PageStreamer<LogEntry, ListLogEntriesRequest, ListLogEntriesResponse, string>(
                (request, token) => {
                    request.PageToken = token;
                    return request;
                },
                response => response.NextPageToken,
                response => response.Entries,
                "" // An empty page-token
            );

        private static readonly PageStreamer<MonitoredResourceDescriptor, ListMonitoredResourceDescriptorsRequest, ListMonitoredResourceDescriptorsResponse, string> s_listMonitoredResourceDescriptorsPageStreamer =
            new PageStreamer<MonitoredResourceDescriptor, ListMonitoredResourceDescriptorsRequest, ListMonitoredResourceDescriptorsResponse, string>(
                (request, token) => {
                    request.PageToken = token;
                    return request;
                },
                response => response.NextPageToken,
                response => response.ResourceDescriptors,
                "" // An empty page-token
            );

        private readonly ClientHelper _clientHelper;

        public LoggingServiceV2ClientImpl(LoggingServiceV2.ILoggingServiceV2Client grpcClient, LoggingServiceV2Settings settings)
        {
            this.GrpcClient = grpcClient;
            LoggingServiceV2Settings effectiveSettings = settings ?? LoggingServiceV2Settings.GetDefault();
            _clientHelper = new ClientHelper(effectiveSettings);
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
            CallSettings callSettings = null)
        {
            DeleteLogRequest request = new DeleteLogRequest
            {
                LogName = logName,
            };
            return GrpcClient.DeleteLogAsync(
                request,
                _clientHelper.BuildCallOptions(null, callSettings)
            ).ResponseAsync;
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
        /// <returns>The RPC response.</returns>
        public override void DeleteLog(
            string logName,
            CallSettings callSettings = null)
        {
            DeleteLogRequest request = new DeleteLogRequest
            {
                LogName = logName,
            };
            GrpcClient.DeleteLog(
                request,
                _clientHelper.BuildCallOptions(null, callSettings));
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
        public override Task<WriteLogEntriesResponse> WriteLogEntriesAsync(
            string logName,
            MonitoredResource resource,
            IDictionary<string, string> labels,
            IEnumerable<LogEntry> entries,
            CallSettings callSettings = null)
        {
            WriteLogEntriesRequest request = new WriteLogEntriesRequest
            {
                LogName = logName,
                Resource = resource,
                Labels = { labels },
                Entries = { entries },
            };
            return GrpcClient.WriteLogEntriesAsync(
                request,
                _clientHelper.BuildCallOptions(null, callSettings)
            ).ResponseAsync;
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
        /// <returns>The RPC response.</returns>
        public override WriteLogEntriesResponse WriteLogEntries(
            string logName,
            MonitoredResource resource,
            IDictionary<string, string> labels,
            IEnumerable<LogEntry> entries,
            CallSettings callSettings = null)
        {
            WriteLogEntriesRequest request = new WriteLogEntriesRequest
            {
                LogName = logName,
                Resource = resource,
                Labels = { labels },
                Entries = { entries },
            };
            return GrpcClient.WriteLogEntries(
                request,
                _clientHelper.BuildCallOptions(null, callSettings));
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
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override IAsyncEnumerable<LogEntry> ListLogEntriesAsync(
            IEnumerable<string> projectIds,
            string filter,
            string orderBy,
            CallSettings callSettings = null)
        {
            ListLogEntriesRequest request = new ListLogEntriesRequest
            {
                ProjectIds = { projectIds },
                Filter = filter,
                OrderBy = orderBy,
            };
            return s_listLogEntriesPageStreamer.FetchAsync(
                request,
                (pageStreamRequest, cancellationToken) => GrpcClient.ListLogEntriesAsync(
                    pageStreamRequest,
                    _clientHelper.BuildCallOptions(cancellationToken, callSettings)
                ).ResponseAsync
            );
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
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override IEnumerable<LogEntry> ListLogEntries(
            IEnumerable<string> projectIds,
            string filter,
            string orderBy,
            CallSettings callSettings = null)
        {
            ListLogEntriesRequest request = new ListLogEntriesRequest
            {
                ProjectIds = { projectIds },
                Filter = filter,
                OrderBy = orderBy,
            };
            return s_listLogEntriesPageStreamer.Fetch(
                request,
                pageStreamRequest => GrpcClient.ListLogEntries(
                    pageStreamRequest,
                    _clientHelper.BuildCallOptions(null, callSettings))
            );
        }

    }
}