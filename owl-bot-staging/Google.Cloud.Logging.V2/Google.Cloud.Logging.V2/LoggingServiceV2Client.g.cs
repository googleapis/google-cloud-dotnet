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
using ga = Google.Api;
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Logging.V2
{
    /// <summary>Settings for <see cref="LoggingServiceV2Client"/> instances.</summary>
    public sealed partial class LoggingServiceV2Settings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="LoggingServiceV2Settings"/>.</summary>
        /// <returns>A new instance of the default <see cref="LoggingServiceV2Settings"/>.</returns>
        public static LoggingServiceV2Settings GetDefault() => new LoggingServiceV2Settings();

        /// <summary>Constructs a new <see cref="LoggingServiceV2Settings"/> object with default settings.</summary>
        public LoggingServiceV2Settings()
        {
        }

        private LoggingServiceV2Settings(LoggingServiceV2Settings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            DeleteLogSettings = existing.DeleteLogSettings;
            WriteLogEntriesSettings = existing.WriteLogEntriesSettings;
            ListLogEntriesSettings = existing.ListLogEntriesSettings;
            ListMonitoredResourceDescriptorsSettings = existing.ListMonitoredResourceDescriptorsSettings;
            ListLogsSettings = existing.ListLogsSettings;
            TailLogEntriesSettings = existing.TailLogEntriesSettings;
            TailLogEntriesStreamingSettings = existing.TailLogEntriesStreamingSettings;
            OnCopy(existing);
        }

        partial void OnCopy(LoggingServiceV2Settings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LoggingServiceV2Client.DeleteLog</c> and <c>LoggingServiceV2Client.DeleteLogAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteLogSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LoggingServiceV2Client.WriteLogEntries</c> and <c>LoggingServiceV2Client.WriteLogEntriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings WriteLogEntriesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LoggingServiceV2Client.ListLogEntries</c> and <c>LoggingServiceV2Client.ListLogEntriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListLogEntriesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LoggingServiceV2Client.ListMonitoredResourceDescriptors</c> and
        /// <c>LoggingServiceV2Client.ListMonitoredResourceDescriptorsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListMonitoredResourceDescriptorsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LoggingServiceV2Client.ListLogs</c> and <c>LoggingServiceV2Client.ListLogsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Internal"/>, <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListLogsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LoggingServiceV2Client.TailLogEntries</c> and <c>LoggingServiceV2Client.TailLogEntriesAsync</c>.
        /// </summary>
        /// <remarks>Timeout: 3600 seconds.</remarks>
        public gaxgrpc::CallSettings TailLogEntriesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)));

        /// <summary>
        /// <see cref="gaxgrpc::BidirectionalStreamingSettings"/> for calls to <c>LoggingServiceV2Client.TailLogEntries</c>
        ///  and <c>LoggingServiceV2Client.TailLogEntriesAsync</c>.
        /// </summary>
        /// <remarks>The default local send queue size is 100.</remarks>
        public gaxgrpc::BidirectionalStreamingSettings TailLogEntriesStreamingSettings { get; set; } = new gaxgrpc::BidirectionalStreamingSettings(100);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="LoggingServiceV2Settings"/> object.</returns>
        public LoggingServiceV2Settings Clone() => new LoggingServiceV2Settings(this);
    }

    /// <summary>
    /// Builder class for <see cref="LoggingServiceV2Client"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class LoggingServiceV2ClientBuilder : gaxgrpc::ClientBuilderBase<LoggingServiceV2Client>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public LoggingServiceV2Settings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public LoggingServiceV2ClientBuilder() : base(LoggingServiceV2Client.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref LoggingServiceV2Client client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<LoggingServiceV2Client> task);

        /// <summary>Builds the resulting client.</summary>
        public override LoggingServiceV2Client Build()
        {
            LoggingServiceV2Client client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<LoggingServiceV2Client> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<LoggingServiceV2Client> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private LoggingServiceV2Client BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return LoggingServiceV2Client.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<LoggingServiceV2Client> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return LoggingServiceV2Client.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => LoggingServiceV2Client.ChannelPool;
    }

    /// <summary>LoggingServiceV2 client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for ingesting and querying logs.
    /// </remarks>
    public abstract partial class LoggingServiceV2Client
    {
        /// <summary>
        /// The default endpoint for the LoggingServiceV2 service, which is a host of "logging.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "logging.googleapis.com:443";

        /// <summary>The default LoggingServiceV2 scopes.</summary>
        /// <remarks>
        /// The default LoggingServiceV2 scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform.read-only</description></item>
        /// <item><description>https://www.googleapis.com/auth/logging.admin</description></item>
        /// <item><description>https://www.googleapis.com/auth/logging.read</description></item>
        /// <item><description>https://www.googleapis.com/auth/logging.write</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
            "https://www.googleapis.com/auth/logging.admin",
            "https://www.googleapis.com/auth/logging.read",
            "https://www.googleapis.com/auth/logging.write",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(LoggingServiceV2.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="LoggingServiceV2Client"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="LoggingServiceV2ClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="LoggingServiceV2Client"/>.</returns>
        public static stt::Task<LoggingServiceV2Client> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new LoggingServiceV2ClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="LoggingServiceV2Client"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="LoggingServiceV2ClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="LoggingServiceV2Client"/>.</returns>
        public static LoggingServiceV2Client Create() => new LoggingServiceV2ClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="LoggingServiceV2Client"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="LoggingServiceV2Settings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="LoggingServiceV2Client"/>.</returns>
        internal static LoggingServiceV2Client Create(grpccore::CallInvoker callInvoker, LoggingServiceV2Settings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            LoggingServiceV2.LoggingServiceV2Client grpcClient = new LoggingServiceV2.LoggingServiceV2Client(callInvoker);
            return new LoggingServiceV2ClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC LoggingServiceV2 client</summary>
        public virtual LoggingServiceV2.LoggingServiceV2Client GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes all the log entries in a log for the _Default Log Bucket. The log
        /// reappears if it receives new entries. Log entries written shortly before
        /// the delete operation might not be deleted. Entries received after the
        /// delete operation with a timestamp before the operation will be deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteLog(DeleteLogRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes all the log entries in a log for the _Default Log Bucket. The log
        /// reappears if it receives new entries. Log entries written shortly before
        /// the delete operation might not be deleted. Entries received after the
        /// delete operation with a timestamp before the operation will be deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteLogAsync(DeleteLogRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes all the log entries in a log for the _Default Log Bucket. The log
        /// reappears if it receives new entries. Log entries written shortly before
        /// the delete operation might not be deleted. Entries received after the
        /// delete operation with a timestamp before the operation will be deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteLogAsync(DeleteLogRequest request, st::CancellationToken cancellationToken) =>
            DeleteLogAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes all the log entries in a log for the _Default Log Bucket. The log
        /// reappears if it receives new entries. Log entries written shortly before
        /// the delete operation might not be deleted. Entries received after the
        /// delete operation with a timestamp before the operation will be deleted.
        /// </summary>
        /// <param name="logName">
        /// Required. The resource name of the log to delete:
        /// 
        /// * `projects/[PROJECT_ID]/logs/[LOG_ID]`
        /// * `organizations/[ORGANIZATION_ID]/logs/[LOG_ID]`
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/logs/[LOG_ID]`
        /// * `folders/[FOLDER_ID]/logs/[LOG_ID]`
        /// 
        /// `[LOG_ID]` must be URL-encoded. For example,
        /// `"projects/my-project-id/logs/syslog"`,
        /// `"organizations/123/logs/cloudaudit.googleapis.com%2Factivity"`.
        /// 
        /// For more information about log names, see
        /// [LogEntry][google.logging.v2.LogEntry].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteLog(string logName, gaxgrpc::CallSettings callSettings = null) =>
            DeleteLog(new DeleteLogRequest
            {
                LogName = gax::GaxPreconditions.CheckNotNullOrEmpty(logName, nameof(logName)),
            }, callSettings);

        /// <summary>
        /// Deletes all the log entries in a log for the _Default Log Bucket. The log
        /// reappears if it receives new entries. Log entries written shortly before
        /// the delete operation might not be deleted. Entries received after the
        /// delete operation with a timestamp before the operation will be deleted.
        /// </summary>
        /// <param name="logName">
        /// Required. The resource name of the log to delete:
        /// 
        /// * `projects/[PROJECT_ID]/logs/[LOG_ID]`
        /// * `organizations/[ORGANIZATION_ID]/logs/[LOG_ID]`
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/logs/[LOG_ID]`
        /// * `folders/[FOLDER_ID]/logs/[LOG_ID]`
        /// 
        /// `[LOG_ID]` must be URL-encoded. For example,
        /// `"projects/my-project-id/logs/syslog"`,
        /// `"organizations/123/logs/cloudaudit.googleapis.com%2Factivity"`.
        /// 
        /// For more information about log names, see
        /// [LogEntry][google.logging.v2.LogEntry].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteLogAsync(string logName, gaxgrpc::CallSettings callSettings = null) =>
            DeleteLogAsync(new DeleteLogRequest
            {
                LogName = gax::GaxPreconditions.CheckNotNullOrEmpty(logName, nameof(logName)),
            }, callSettings);

        /// <summary>
        /// Deletes all the log entries in a log for the _Default Log Bucket. The log
        /// reappears if it receives new entries. Log entries written shortly before
        /// the delete operation might not be deleted. Entries received after the
        /// delete operation with a timestamp before the operation will be deleted.
        /// </summary>
        /// <param name="logName">
        /// Required. The resource name of the log to delete:
        /// 
        /// * `projects/[PROJECT_ID]/logs/[LOG_ID]`
        /// * `organizations/[ORGANIZATION_ID]/logs/[LOG_ID]`
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/logs/[LOG_ID]`
        /// * `folders/[FOLDER_ID]/logs/[LOG_ID]`
        /// 
        /// `[LOG_ID]` must be URL-encoded. For example,
        /// `"projects/my-project-id/logs/syslog"`,
        /// `"organizations/123/logs/cloudaudit.googleapis.com%2Factivity"`.
        /// 
        /// For more information about log names, see
        /// [LogEntry][google.logging.v2.LogEntry].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteLogAsync(string logName, st::CancellationToken cancellationToken) =>
            DeleteLogAsync(logName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes all the log entries in a log for the _Default Log Bucket. The log
        /// reappears if it receives new entries. Log entries written shortly before
        /// the delete operation might not be deleted. Entries received after the
        /// delete operation with a timestamp before the operation will be deleted.
        /// </summary>
        /// <param name="logName">
        /// Required. The resource name of the log to delete:
        /// 
        /// * `projects/[PROJECT_ID]/logs/[LOG_ID]`
        /// * `organizations/[ORGANIZATION_ID]/logs/[LOG_ID]`
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/logs/[LOG_ID]`
        /// * `folders/[FOLDER_ID]/logs/[LOG_ID]`
        /// 
        /// `[LOG_ID]` must be URL-encoded. For example,
        /// `"projects/my-project-id/logs/syslog"`,
        /// `"organizations/123/logs/cloudaudit.googleapis.com%2Factivity"`.
        /// 
        /// For more information about log names, see
        /// [LogEntry][google.logging.v2.LogEntry].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteLog(LogName logName, gaxgrpc::CallSettings callSettings = null) =>
            DeleteLog(new DeleteLogRequest
            {
                LogNameAsLogName = gax::GaxPreconditions.CheckNotNull(logName, nameof(logName)),
            }, callSettings);

        /// <summary>
        /// Deletes all the log entries in a log for the _Default Log Bucket. The log
        /// reappears if it receives new entries. Log entries written shortly before
        /// the delete operation might not be deleted. Entries received after the
        /// delete operation with a timestamp before the operation will be deleted.
        /// </summary>
        /// <param name="logName">
        /// Required. The resource name of the log to delete:
        /// 
        /// * `projects/[PROJECT_ID]/logs/[LOG_ID]`
        /// * `organizations/[ORGANIZATION_ID]/logs/[LOG_ID]`
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/logs/[LOG_ID]`
        /// * `folders/[FOLDER_ID]/logs/[LOG_ID]`
        /// 
        /// `[LOG_ID]` must be URL-encoded. For example,
        /// `"projects/my-project-id/logs/syslog"`,
        /// `"organizations/123/logs/cloudaudit.googleapis.com%2Factivity"`.
        /// 
        /// For more information about log names, see
        /// [LogEntry][google.logging.v2.LogEntry].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteLogAsync(LogName logName, gaxgrpc::CallSettings callSettings = null) =>
            DeleteLogAsync(new DeleteLogRequest
            {
                LogNameAsLogName = gax::GaxPreconditions.CheckNotNull(logName, nameof(logName)),
            }, callSettings);

        /// <summary>
        /// Deletes all the log entries in a log for the _Default Log Bucket. The log
        /// reappears if it receives new entries. Log entries written shortly before
        /// the delete operation might not be deleted. Entries received after the
        /// delete operation with a timestamp before the operation will be deleted.
        /// </summary>
        /// <param name="logName">
        /// Required. The resource name of the log to delete:
        /// 
        /// * `projects/[PROJECT_ID]/logs/[LOG_ID]`
        /// * `organizations/[ORGANIZATION_ID]/logs/[LOG_ID]`
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/logs/[LOG_ID]`
        /// * `folders/[FOLDER_ID]/logs/[LOG_ID]`
        /// 
        /// `[LOG_ID]` must be URL-encoded. For example,
        /// `"projects/my-project-id/logs/syslog"`,
        /// `"organizations/123/logs/cloudaudit.googleapis.com%2Factivity"`.
        /// 
        /// For more information about log names, see
        /// [LogEntry][google.logging.v2.LogEntry].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteLogAsync(LogName logName, st::CancellationToken cancellationToken) =>
            DeleteLogAsync(logName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Writes log entries to Logging. This API method is the
        /// only way to send log entries to Logging. This method
        /// is used, directly or indirectly, by the Logging agent
        /// (fluentd) and all logging libraries configured to use Logging.
        /// A single request may contain log entries for a maximum of 1000
        /// different resources (projects, organizations, billing accounts or
        /// folders)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WriteLogEntriesResponse WriteLogEntries(WriteLogEntriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Writes log entries to Logging. This API method is the
        /// only way to send log entries to Logging. This method
        /// is used, directly or indirectly, by the Logging agent
        /// (fluentd) and all logging libraries configured to use Logging.
        /// A single request may contain log entries for a maximum of 1000
        /// different resources (projects, organizations, billing accounts or
        /// folders)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WriteLogEntriesResponse> WriteLogEntriesAsync(WriteLogEntriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Writes log entries to Logging. This API method is the
        /// only way to send log entries to Logging. This method
        /// is used, directly or indirectly, by the Logging agent
        /// (fluentd) and all logging libraries configured to use Logging.
        /// A single request may contain log entries for a maximum of 1000
        /// different resources (projects, organizations, billing accounts or
        /// folders)
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WriteLogEntriesResponse> WriteLogEntriesAsync(WriteLogEntriesRequest request, st::CancellationToken cancellationToken) =>
            WriteLogEntriesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// * `projects/[PROJECT_ID]/logs/[LOG_ID]`
        /// * `organizations/[ORGANIZATION_ID]/logs/[LOG_ID]`
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/logs/[LOG_ID]`
        /// * `folders/[FOLDER_ID]/logs/[LOG_ID]`
        /// 
        /// `[LOG_ID]` must be URL-encoded. For example:
        /// 
        /// "projects/my-project-id/logs/syslog"
        /// "organizations/123/logs/cloudaudit.googleapis.com%2Factivity"
        /// 
        /// The permission `logging.logEntries.create` is needed on each project,
        /// organization, billing account, or folder that is receiving new log
        /// entries, whether the resource is specified in `logName` or in an
        /// individual log entry.
        /// </param>
        /// <param name="resource">
        /// Optional. A default monitored resource object that is assigned to all log
        /// entries in `entries` that do not specify a value for `resource`. Example:
        /// 
        /// { "type": "gce_instance",
        /// "labels": {
        /// "zone": "us-central1-a", "instance_id": "00000000000000000000" }}
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
        /// [logs retention period](https://cloud.google.com/logging/quotas) in
        /// the past or more than 24 hours in the future will not be available when
        /// calling `entries.list`. However, those log entries can still be [exported
        /// with
        /// LogSinks](https://cloud.google.com/logging/docs/api/tasks/exporting-logs).
        /// 
        /// To improve throughput and to avoid exceeding the
        /// [quota limit](https://cloud.google.com/logging/quotas) for calls to
        /// `entries.write`, you should try to include several log entries in this
        /// list, rather than calling this method for each individual log entry.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WriteLogEntriesResponse WriteLogEntries(string logName, ga::MonitoredResource resource, scg::IDictionary<string, string> labels, scg::IEnumerable<LogEntry> entries, gaxgrpc::CallSettings callSettings = null) =>
            WriteLogEntries(new WriteLogEntriesRequest
            {
                LogName = logName ?? "",
                Resource = resource,
                Labels =
                {
                    labels ?? new scg::Dictionary<string, string>(),
                },
                Entries =
                {
                    gax::GaxPreconditions.CheckNotNull(entries, nameof(entries)),
                },
            }, callSettings);

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
        /// * `projects/[PROJECT_ID]/logs/[LOG_ID]`
        /// * `organizations/[ORGANIZATION_ID]/logs/[LOG_ID]`
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/logs/[LOG_ID]`
        /// * `folders/[FOLDER_ID]/logs/[LOG_ID]`
        /// 
        /// `[LOG_ID]` must be URL-encoded. For example:
        /// 
        /// "projects/my-project-id/logs/syslog"
        /// "organizations/123/logs/cloudaudit.googleapis.com%2Factivity"
        /// 
        /// The permission `logging.logEntries.create` is needed on each project,
        /// organization, billing account, or folder that is receiving new log
        /// entries, whether the resource is specified in `logName` or in an
        /// individual log entry.
        /// </param>
        /// <param name="resource">
        /// Optional. A default monitored resource object that is assigned to all log
        /// entries in `entries` that do not specify a value for `resource`. Example:
        /// 
        /// { "type": "gce_instance",
        /// "labels": {
        /// "zone": "us-central1-a", "instance_id": "00000000000000000000" }}
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
        /// [logs retention period](https://cloud.google.com/logging/quotas) in
        /// the past or more than 24 hours in the future will not be available when
        /// calling `entries.list`. However, those log entries can still be [exported
        /// with
        /// LogSinks](https://cloud.google.com/logging/docs/api/tasks/exporting-logs).
        /// 
        /// To improve throughput and to avoid exceeding the
        /// [quota limit](https://cloud.google.com/logging/quotas) for calls to
        /// `entries.write`, you should try to include several log entries in this
        /// list, rather than calling this method for each individual log entry.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WriteLogEntriesResponse> WriteLogEntriesAsync(string logName, ga::MonitoredResource resource, scg::IDictionary<string, string> labels, scg::IEnumerable<LogEntry> entries, gaxgrpc::CallSettings callSettings = null) =>
            WriteLogEntriesAsync(new WriteLogEntriesRequest
            {
                LogName = logName ?? "",
                Resource = resource,
                Labels =
                {
                    labels ?? new scg::Dictionary<string, string>(),
                },
                Entries =
                {
                    gax::GaxPreconditions.CheckNotNull(entries, nameof(entries)),
                },
            }, callSettings);

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
        /// * `projects/[PROJECT_ID]/logs/[LOG_ID]`
        /// * `organizations/[ORGANIZATION_ID]/logs/[LOG_ID]`
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/logs/[LOG_ID]`
        /// * `folders/[FOLDER_ID]/logs/[LOG_ID]`
        /// 
        /// `[LOG_ID]` must be URL-encoded. For example:
        /// 
        /// "projects/my-project-id/logs/syslog"
        /// "organizations/123/logs/cloudaudit.googleapis.com%2Factivity"
        /// 
        /// The permission `logging.logEntries.create` is needed on each project,
        /// organization, billing account, or folder that is receiving new log
        /// entries, whether the resource is specified in `logName` or in an
        /// individual log entry.
        /// </param>
        /// <param name="resource">
        /// Optional. A default monitored resource object that is assigned to all log
        /// entries in `entries` that do not specify a value for `resource`. Example:
        /// 
        /// { "type": "gce_instance",
        /// "labels": {
        /// "zone": "us-central1-a", "instance_id": "00000000000000000000" }}
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
        /// [logs retention period](https://cloud.google.com/logging/quotas) in
        /// the past or more than 24 hours in the future will not be available when
        /// calling `entries.list`. However, those log entries can still be [exported
        /// with
        /// LogSinks](https://cloud.google.com/logging/docs/api/tasks/exporting-logs).
        /// 
        /// To improve throughput and to avoid exceeding the
        /// [quota limit](https://cloud.google.com/logging/quotas) for calls to
        /// `entries.write`, you should try to include several log entries in this
        /// list, rather than calling this method for each individual log entry.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WriteLogEntriesResponse> WriteLogEntriesAsync(string logName, ga::MonitoredResource resource, scg::IDictionary<string, string> labels, scg::IEnumerable<LogEntry> entries, st::CancellationToken cancellationToken) =>
            WriteLogEntriesAsync(logName, resource, labels, entries, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// * `projects/[PROJECT_ID]/logs/[LOG_ID]`
        /// * `organizations/[ORGANIZATION_ID]/logs/[LOG_ID]`
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/logs/[LOG_ID]`
        /// * `folders/[FOLDER_ID]/logs/[LOG_ID]`
        /// 
        /// `[LOG_ID]` must be URL-encoded. For example:
        /// 
        /// "projects/my-project-id/logs/syslog"
        /// "organizations/123/logs/cloudaudit.googleapis.com%2Factivity"
        /// 
        /// The permission `logging.logEntries.create` is needed on each project,
        /// organization, billing account, or folder that is receiving new log
        /// entries, whether the resource is specified in `logName` or in an
        /// individual log entry.
        /// </param>
        /// <param name="resource">
        /// Optional. A default monitored resource object that is assigned to all log
        /// entries in `entries` that do not specify a value for `resource`. Example:
        /// 
        /// { "type": "gce_instance",
        /// "labels": {
        /// "zone": "us-central1-a", "instance_id": "00000000000000000000" }}
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
        /// [logs retention period](https://cloud.google.com/logging/quotas) in
        /// the past or more than 24 hours in the future will not be available when
        /// calling `entries.list`. However, those log entries can still be [exported
        /// with
        /// LogSinks](https://cloud.google.com/logging/docs/api/tasks/exporting-logs).
        /// 
        /// To improve throughput and to avoid exceeding the
        /// [quota limit](https://cloud.google.com/logging/quotas) for calls to
        /// `entries.write`, you should try to include several log entries in this
        /// list, rather than calling this method for each individual log entry.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WriteLogEntriesResponse WriteLogEntries(LogName logName, ga::MonitoredResource resource, scg::IDictionary<string, string> labels, scg::IEnumerable<LogEntry> entries, gaxgrpc::CallSettings callSettings = null) =>
            WriteLogEntries(new WriteLogEntriesRequest
            {
                LogNameAsLogName = logName,
                Resource = resource,
                Labels =
                {
                    labels ?? new scg::Dictionary<string, string>(),
                },
                Entries =
                {
                    gax::GaxPreconditions.CheckNotNull(entries, nameof(entries)),
                },
            }, callSettings);

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
        /// * `projects/[PROJECT_ID]/logs/[LOG_ID]`
        /// * `organizations/[ORGANIZATION_ID]/logs/[LOG_ID]`
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/logs/[LOG_ID]`
        /// * `folders/[FOLDER_ID]/logs/[LOG_ID]`
        /// 
        /// `[LOG_ID]` must be URL-encoded. For example:
        /// 
        /// "projects/my-project-id/logs/syslog"
        /// "organizations/123/logs/cloudaudit.googleapis.com%2Factivity"
        /// 
        /// The permission `logging.logEntries.create` is needed on each project,
        /// organization, billing account, or folder that is receiving new log
        /// entries, whether the resource is specified in `logName` or in an
        /// individual log entry.
        /// </param>
        /// <param name="resource">
        /// Optional. A default monitored resource object that is assigned to all log
        /// entries in `entries` that do not specify a value for `resource`. Example:
        /// 
        /// { "type": "gce_instance",
        /// "labels": {
        /// "zone": "us-central1-a", "instance_id": "00000000000000000000" }}
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
        /// [logs retention period](https://cloud.google.com/logging/quotas) in
        /// the past or more than 24 hours in the future will not be available when
        /// calling `entries.list`. However, those log entries can still be [exported
        /// with
        /// LogSinks](https://cloud.google.com/logging/docs/api/tasks/exporting-logs).
        /// 
        /// To improve throughput and to avoid exceeding the
        /// [quota limit](https://cloud.google.com/logging/quotas) for calls to
        /// `entries.write`, you should try to include several log entries in this
        /// list, rather than calling this method for each individual log entry.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WriteLogEntriesResponse> WriteLogEntriesAsync(LogName logName, ga::MonitoredResource resource, scg::IDictionary<string, string> labels, scg::IEnumerable<LogEntry> entries, gaxgrpc::CallSettings callSettings = null) =>
            WriteLogEntriesAsync(new WriteLogEntriesRequest
            {
                LogNameAsLogName = logName,
                Resource = resource,
                Labels =
                {
                    labels ?? new scg::Dictionary<string, string>(),
                },
                Entries =
                {
                    gax::GaxPreconditions.CheckNotNull(entries, nameof(entries)),
                },
            }, callSettings);

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
        /// * `projects/[PROJECT_ID]/logs/[LOG_ID]`
        /// * `organizations/[ORGANIZATION_ID]/logs/[LOG_ID]`
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/logs/[LOG_ID]`
        /// * `folders/[FOLDER_ID]/logs/[LOG_ID]`
        /// 
        /// `[LOG_ID]` must be URL-encoded. For example:
        /// 
        /// "projects/my-project-id/logs/syslog"
        /// "organizations/123/logs/cloudaudit.googleapis.com%2Factivity"
        /// 
        /// The permission `logging.logEntries.create` is needed on each project,
        /// organization, billing account, or folder that is receiving new log
        /// entries, whether the resource is specified in `logName` or in an
        /// individual log entry.
        /// </param>
        /// <param name="resource">
        /// Optional. A default monitored resource object that is assigned to all log
        /// entries in `entries` that do not specify a value for `resource`. Example:
        /// 
        /// { "type": "gce_instance",
        /// "labels": {
        /// "zone": "us-central1-a", "instance_id": "00000000000000000000" }}
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
        /// [logs retention period](https://cloud.google.com/logging/quotas) in
        /// the past or more than 24 hours in the future will not be available when
        /// calling `entries.list`. However, those log entries can still be [exported
        /// with
        /// LogSinks](https://cloud.google.com/logging/docs/api/tasks/exporting-logs).
        /// 
        /// To improve throughput and to avoid exceeding the
        /// [quota limit](https://cloud.google.com/logging/quotas) for calls to
        /// `entries.write`, you should try to include several log entries in this
        /// list, rather than calling this method for each individual log entry.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WriteLogEntriesResponse> WriteLogEntriesAsync(LogName logName, ga::MonitoredResource resource, scg::IDictionary<string, string> labels, scg::IEnumerable<LogEntry> entries, st::CancellationToken cancellationToken) =>
            WriteLogEntriesAsync(logName, resource, labels, entries, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists log entries.  Use this method to retrieve log entries that originated
        /// from a project/folder/organization/billing account.  For ways to export log
        /// entries, see [Exporting
        /// Logs](https://cloud.google.com/logging/docs/export).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LogEntry"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLogEntriesResponse, LogEntry> ListLogEntries(ListLogEntriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists log entries.  Use this method to retrieve log entries that originated
        /// from a project/folder/organization/billing account.  For ways to export log
        /// entries, see [Exporting
        /// Logs](https://cloud.google.com/logging/docs/export).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LogEntry"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLogEntriesResponse, LogEntry> ListLogEntriesAsync(ListLogEntriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists log entries.  Use this method to retrieve log entries that originated
        /// from a project/folder/organization/billing account.  For ways to export log
        /// entries, see [Exporting
        /// Logs](https://cloud.google.com/logging/docs/export).
        /// </summary>
        /// <param name="resourceNames">
        /// Required. Names of one or more parent resources from which to
        /// retrieve log entries:
        /// 
        /// *  `projects/[PROJECT_ID]`
        /// *  `organizations/[ORGANIZATION_ID]`
        /// *  `billingAccounts/[BILLING_ACCOUNT_ID]`
        /// *  `folders/[FOLDER_ID]`
        /// 
        /// May alternatively be one or more views:
        /// 
        /// * `projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]`
        /// * `organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]`
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]`
        /// * `folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]`
        /// 
        /// Projects listed in the `project_ids` field are added to this list.
        /// A maximum of 100 resources may be specified in a single request.
        /// </param>
        /// <param name="filter">
        /// Optional. Only log entries that match the filter are returned.  An empty
        /// filter matches all log entries in the resources listed in `resource_names`.
        /// Referencing a parent resource that is not listed in `resource_names` will
        /// cause the filter to return no results. The maximum length of a filter is
        /// 20,000 characters.
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
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LogEntry"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLogEntriesResponse, LogEntry> ListLogEntries(scg::IEnumerable<string> resourceNames, string filter, string orderBy, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLogEntriesRequest request = new ListLogEntriesRequest
            {
                ResourceNames =
                {
                    gax::GaxPreconditions.CheckNotNull(resourceNames, nameof(resourceNames)),
                },
                Filter = filter ?? "",
                OrderBy = orderBy ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListLogEntries(request, callSettings);
        }

        /// <summary>
        /// Lists log entries.  Use this method to retrieve log entries that originated
        /// from a project/folder/organization/billing account.  For ways to export log
        /// entries, see [Exporting
        /// Logs](https://cloud.google.com/logging/docs/export).
        /// </summary>
        /// <param name="resourceNames">
        /// Required. Names of one or more parent resources from which to
        /// retrieve log entries:
        /// 
        /// *  `projects/[PROJECT_ID]`
        /// *  `organizations/[ORGANIZATION_ID]`
        /// *  `billingAccounts/[BILLING_ACCOUNT_ID]`
        /// *  `folders/[FOLDER_ID]`
        /// 
        /// May alternatively be one or more views:
        /// 
        /// * `projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]`
        /// * `organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]`
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]`
        /// * `folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]`
        /// 
        /// Projects listed in the `project_ids` field are added to this list.
        /// A maximum of 100 resources may be specified in a single request.
        /// </param>
        /// <param name="filter">
        /// Optional. Only log entries that match the filter are returned.  An empty
        /// filter matches all log entries in the resources listed in `resource_names`.
        /// Referencing a parent resource that is not listed in `resource_names` will
        /// cause the filter to return no results. The maximum length of a filter is
        /// 20,000 characters.
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
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LogEntry"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLogEntriesResponse, LogEntry> ListLogEntriesAsync(scg::IEnumerable<string> resourceNames, string filter, string orderBy, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLogEntriesRequest request = new ListLogEntriesRequest
            {
                ResourceNames =
                {
                    gax::GaxPreconditions.CheckNotNull(resourceNames, nameof(resourceNames)),
                },
                Filter = filter ?? "",
                OrderBy = orderBy ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListLogEntriesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists log entries.  Use this method to retrieve log entries that originated
        /// from a project/folder/organization/billing account.  For ways to export log
        /// entries, see [Exporting
        /// Logs](https://cloud.google.com/logging/docs/export).
        /// </summary>
        /// <param name="resourceNames">
        /// Required. Names of one or more parent resources from which to
        /// retrieve log entries:
        /// 
        /// *  `projects/[PROJECT_ID]`
        /// *  `organizations/[ORGANIZATION_ID]`
        /// *  `billingAccounts/[BILLING_ACCOUNT_ID]`
        /// *  `folders/[FOLDER_ID]`
        /// 
        /// May alternatively be one or more views:
        /// 
        /// * `projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]`
        /// * `organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]`
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]`
        /// * `folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]`
        /// 
        /// Projects listed in the `project_ids` field are added to this list.
        /// A maximum of 100 resources may be specified in a single request.
        /// </param>
        /// <param name="filter">
        /// Optional. Only log entries that match the filter are returned.  An empty
        /// filter matches all log entries in the resources listed in `resource_names`.
        /// Referencing a parent resource that is not listed in `resource_names` will
        /// cause the filter to return no results. The maximum length of a filter is
        /// 20,000 characters.
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
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LogEntry"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLogEntriesResponse, LogEntry> ListLogEntries(scg::IEnumerable<gagr::ProjectName> resourceNames, string filter, string orderBy, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLogEntriesRequest request = new ListLogEntriesRequest
            {
                ResourceNamesAsProjectNames =
                {
                    gax::GaxPreconditions.CheckNotNull(resourceNames, nameof(resourceNames)),
                },
                Filter = filter ?? "",
                OrderBy = orderBy ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListLogEntries(request, callSettings);
        }

        /// <summary>
        /// Lists log entries.  Use this method to retrieve log entries that originated
        /// from a project/folder/organization/billing account.  For ways to export log
        /// entries, see [Exporting
        /// Logs](https://cloud.google.com/logging/docs/export).
        /// </summary>
        /// <param name="resourceNames">
        /// Required. Names of one or more parent resources from which to
        /// retrieve log entries:
        /// 
        /// *  `projects/[PROJECT_ID]`
        /// *  `organizations/[ORGANIZATION_ID]`
        /// *  `billingAccounts/[BILLING_ACCOUNT_ID]`
        /// *  `folders/[FOLDER_ID]`
        /// 
        /// May alternatively be one or more views:
        /// 
        /// * `projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]`
        /// * `organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]`
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]`
        /// * `folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]`
        /// 
        /// Projects listed in the `project_ids` field are added to this list.
        /// A maximum of 100 resources may be specified in a single request.
        /// </param>
        /// <param name="filter">
        /// Optional. Only log entries that match the filter are returned.  An empty
        /// filter matches all log entries in the resources listed in `resource_names`.
        /// Referencing a parent resource that is not listed in `resource_names` will
        /// cause the filter to return no results. The maximum length of a filter is
        /// 20,000 characters.
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
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LogEntry"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLogEntriesResponse, LogEntry> ListLogEntriesAsync(scg::IEnumerable<gagr::ProjectName> resourceNames, string filter, string orderBy, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLogEntriesRequest request = new ListLogEntriesRequest
            {
                ResourceNamesAsProjectNames =
                {
                    gax::GaxPreconditions.CheckNotNull(resourceNames, nameof(resourceNames)),
                },
                Filter = filter ?? "",
                OrderBy = orderBy ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListLogEntriesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists log entries.  Use this method to retrieve log entries that originated
        /// from a project/folder/organization/billing account.  For ways to export log
        /// entries, see [Exporting
        /// Logs](https://cloud.google.com/logging/docs/export).
        /// </summary>
        /// <param name="resourceNames">
        /// Required. Names of one or more parent resources from which to
        /// retrieve log entries:
        /// 
        /// *  `projects/[PROJECT_ID]`
        /// *  `organizations/[ORGANIZATION_ID]`
        /// *  `billingAccounts/[BILLING_ACCOUNT_ID]`
        /// *  `folders/[FOLDER_ID]`
        /// 
        /// May alternatively be one or more views:
        /// 
        /// * `projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]`
        /// * `organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]`
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]`
        /// * `folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]`
        /// 
        /// Projects listed in the `project_ids` field are added to this list.
        /// A maximum of 100 resources may be specified in a single request.
        /// </param>
        /// <param name="filter">
        /// Optional. Only log entries that match the filter are returned.  An empty
        /// filter matches all log entries in the resources listed in `resource_names`.
        /// Referencing a parent resource that is not listed in `resource_names` will
        /// cause the filter to return no results. The maximum length of a filter is
        /// 20,000 characters.
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
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LogEntry"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLogEntriesResponse, LogEntry> ListLogEntries(scg::IEnumerable<gagr::OrganizationName> resourceNames, string filter, string orderBy, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLogEntriesRequest request = new ListLogEntriesRequest
            {
                ResourceNamesAsOrganizationNames =
                {
                    gax::GaxPreconditions.CheckNotNull(resourceNames, nameof(resourceNames)),
                },
                Filter = filter ?? "",
                OrderBy = orderBy ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListLogEntries(request, callSettings);
        }

        /// <summary>
        /// Lists log entries.  Use this method to retrieve log entries that originated
        /// from a project/folder/organization/billing account.  For ways to export log
        /// entries, see [Exporting
        /// Logs](https://cloud.google.com/logging/docs/export).
        /// </summary>
        /// <param name="resourceNames">
        /// Required. Names of one or more parent resources from which to
        /// retrieve log entries:
        /// 
        /// *  `projects/[PROJECT_ID]`
        /// *  `organizations/[ORGANIZATION_ID]`
        /// *  `billingAccounts/[BILLING_ACCOUNT_ID]`
        /// *  `folders/[FOLDER_ID]`
        /// 
        /// May alternatively be one or more views:
        /// 
        /// * `projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]`
        /// * `organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]`
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]`
        /// * `folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]`
        /// 
        /// Projects listed in the `project_ids` field are added to this list.
        /// A maximum of 100 resources may be specified in a single request.
        /// </param>
        /// <param name="filter">
        /// Optional. Only log entries that match the filter are returned.  An empty
        /// filter matches all log entries in the resources listed in `resource_names`.
        /// Referencing a parent resource that is not listed in `resource_names` will
        /// cause the filter to return no results. The maximum length of a filter is
        /// 20,000 characters.
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
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LogEntry"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLogEntriesResponse, LogEntry> ListLogEntriesAsync(scg::IEnumerable<gagr::OrganizationName> resourceNames, string filter, string orderBy, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLogEntriesRequest request = new ListLogEntriesRequest
            {
                ResourceNamesAsOrganizationNames =
                {
                    gax::GaxPreconditions.CheckNotNull(resourceNames, nameof(resourceNames)),
                },
                Filter = filter ?? "",
                OrderBy = orderBy ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListLogEntriesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists log entries.  Use this method to retrieve log entries that originated
        /// from a project/folder/organization/billing account.  For ways to export log
        /// entries, see [Exporting
        /// Logs](https://cloud.google.com/logging/docs/export).
        /// </summary>
        /// <param name="resourceNames">
        /// Required. Names of one or more parent resources from which to
        /// retrieve log entries:
        /// 
        /// *  `projects/[PROJECT_ID]`
        /// *  `organizations/[ORGANIZATION_ID]`
        /// *  `billingAccounts/[BILLING_ACCOUNT_ID]`
        /// *  `folders/[FOLDER_ID]`
        /// 
        /// May alternatively be one or more views:
        /// 
        /// * `projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]`
        /// * `organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]`
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]`
        /// * `folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]`
        /// 
        /// Projects listed in the `project_ids` field are added to this list.
        /// A maximum of 100 resources may be specified in a single request.
        /// </param>
        /// <param name="filter">
        /// Optional. Only log entries that match the filter are returned.  An empty
        /// filter matches all log entries in the resources listed in `resource_names`.
        /// Referencing a parent resource that is not listed in `resource_names` will
        /// cause the filter to return no results. The maximum length of a filter is
        /// 20,000 characters.
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
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LogEntry"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLogEntriesResponse, LogEntry> ListLogEntries(scg::IEnumerable<gagr::FolderName> resourceNames, string filter, string orderBy, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLogEntriesRequest request = new ListLogEntriesRequest
            {
                ResourceNamesAsFolderNames =
                {
                    gax::GaxPreconditions.CheckNotNull(resourceNames, nameof(resourceNames)),
                },
                Filter = filter ?? "",
                OrderBy = orderBy ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListLogEntries(request, callSettings);
        }

        /// <summary>
        /// Lists log entries.  Use this method to retrieve log entries that originated
        /// from a project/folder/organization/billing account.  For ways to export log
        /// entries, see [Exporting
        /// Logs](https://cloud.google.com/logging/docs/export).
        /// </summary>
        /// <param name="resourceNames">
        /// Required. Names of one or more parent resources from which to
        /// retrieve log entries:
        /// 
        /// *  `projects/[PROJECT_ID]`
        /// *  `organizations/[ORGANIZATION_ID]`
        /// *  `billingAccounts/[BILLING_ACCOUNT_ID]`
        /// *  `folders/[FOLDER_ID]`
        /// 
        /// May alternatively be one or more views:
        /// 
        /// * `projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]`
        /// * `organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]`
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]`
        /// * `folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]`
        /// 
        /// Projects listed in the `project_ids` field are added to this list.
        /// A maximum of 100 resources may be specified in a single request.
        /// </param>
        /// <param name="filter">
        /// Optional. Only log entries that match the filter are returned.  An empty
        /// filter matches all log entries in the resources listed in `resource_names`.
        /// Referencing a parent resource that is not listed in `resource_names` will
        /// cause the filter to return no results. The maximum length of a filter is
        /// 20,000 characters.
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
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LogEntry"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLogEntriesResponse, LogEntry> ListLogEntriesAsync(scg::IEnumerable<gagr::FolderName> resourceNames, string filter, string orderBy, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLogEntriesRequest request = new ListLogEntriesRequest
            {
                ResourceNamesAsFolderNames =
                {
                    gax::GaxPreconditions.CheckNotNull(resourceNames, nameof(resourceNames)),
                },
                Filter = filter ?? "",
                OrderBy = orderBy ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListLogEntriesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists log entries.  Use this method to retrieve log entries that originated
        /// from a project/folder/organization/billing account.  For ways to export log
        /// entries, see [Exporting
        /// Logs](https://cloud.google.com/logging/docs/export).
        /// </summary>
        /// <param name="resourceNames">
        /// Required. Names of one or more parent resources from which to
        /// retrieve log entries:
        /// 
        /// *  `projects/[PROJECT_ID]`
        /// *  `organizations/[ORGANIZATION_ID]`
        /// *  `billingAccounts/[BILLING_ACCOUNT_ID]`
        /// *  `folders/[FOLDER_ID]`
        /// 
        /// May alternatively be one or more views:
        /// 
        /// * `projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]`
        /// * `organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]`
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]`
        /// * `folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]`
        /// 
        /// Projects listed in the `project_ids` field are added to this list.
        /// A maximum of 100 resources may be specified in a single request.
        /// </param>
        /// <param name="filter">
        /// Optional. Only log entries that match the filter are returned.  An empty
        /// filter matches all log entries in the resources listed in `resource_names`.
        /// Referencing a parent resource that is not listed in `resource_names` will
        /// cause the filter to return no results. The maximum length of a filter is
        /// 20,000 characters.
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
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LogEntry"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLogEntriesResponse, LogEntry> ListLogEntries(scg::IEnumerable<gagr::BillingAccountName> resourceNames, string filter, string orderBy, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLogEntriesRequest request = new ListLogEntriesRequest
            {
                ResourceNamesAsBillingAccountNames =
                {
                    gax::GaxPreconditions.CheckNotNull(resourceNames, nameof(resourceNames)),
                },
                Filter = filter ?? "",
                OrderBy = orderBy ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListLogEntries(request, callSettings);
        }

        /// <summary>
        /// Lists log entries.  Use this method to retrieve log entries that originated
        /// from a project/folder/organization/billing account.  For ways to export log
        /// entries, see [Exporting
        /// Logs](https://cloud.google.com/logging/docs/export).
        /// </summary>
        /// <param name="resourceNames">
        /// Required. Names of one or more parent resources from which to
        /// retrieve log entries:
        /// 
        /// *  `projects/[PROJECT_ID]`
        /// *  `organizations/[ORGANIZATION_ID]`
        /// *  `billingAccounts/[BILLING_ACCOUNT_ID]`
        /// *  `folders/[FOLDER_ID]`
        /// 
        /// May alternatively be one or more views:
        /// 
        /// * `projects/[PROJECT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]`
        /// * `organizations/[ORGANIZATION_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]`
        /// * `billingAccounts/[BILLING_ACCOUNT_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]`
        /// * `folders/[FOLDER_ID]/locations/[LOCATION_ID]/buckets/[BUCKET_ID]/views/[VIEW_ID]`
        /// 
        /// Projects listed in the `project_ids` field are added to this list.
        /// A maximum of 100 resources may be specified in a single request.
        /// </param>
        /// <param name="filter">
        /// Optional. Only log entries that match the filter are returned.  An empty
        /// filter matches all log entries in the resources listed in `resource_names`.
        /// Referencing a parent resource that is not listed in `resource_names` will
        /// cause the filter to return no results. The maximum length of a filter is
        /// 20,000 characters.
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
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LogEntry"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLogEntriesResponse, LogEntry> ListLogEntriesAsync(scg::IEnumerable<gagr::BillingAccountName> resourceNames, string filter, string orderBy, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLogEntriesRequest request = new ListLogEntriesRequest
            {
                ResourceNamesAsBillingAccountNames =
                {
                    gax::GaxPreconditions.CheckNotNull(resourceNames, nameof(resourceNames)),
                },
                Filter = filter ?? "",
                OrderBy = orderBy ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListLogEntriesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the descriptors for monitored resource types used by Logging.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ga::MonitoredResourceDescriptor"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMonitoredResourceDescriptorsResponse, ga::MonitoredResourceDescriptor> ListMonitoredResourceDescriptors(ListMonitoredResourceDescriptorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the descriptors for monitored resource types used by Logging.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ga::MonitoredResourceDescriptor"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListMonitoredResourceDescriptorsResponse, ga::MonitoredResourceDescriptor> ListMonitoredResourceDescriptorsAsync(ListMonitoredResourceDescriptorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the logs in projects, organizations, folders, or billing accounts.
        /// Only logs that have entries are listed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLogsResponse, string> ListLogs(ListLogsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the logs in projects, organizations, folders, or billing accounts.
        /// Only logs that have entries are listed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLogsResponse, string> ListLogsAsync(ListLogsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the logs in projects, organizations, folders, or billing accounts.
        /// Only logs that have entries are listed.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name to list logs for:
        /// 
        /// *  `projects/[PROJECT_ID]`
        /// *  `organizations/[ORGANIZATION_ID]`
        /// *  `billingAccounts/[BILLING_ACCOUNT_ID]`
        /// *  `folders/[FOLDER_ID]`
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
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLogsResponse, string> ListLogs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLogsRequest request = new ListLogsRequest
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
            return ListLogs(request, callSettings);
        }

        /// <summary>
        /// Lists the logs in projects, organizations, folders, or billing accounts.
        /// Only logs that have entries are listed.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name to list logs for:
        /// 
        /// *  `projects/[PROJECT_ID]`
        /// *  `organizations/[ORGANIZATION_ID]`
        /// *  `billingAccounts/[BILLING_ACCOUNT_ID]`
        /// *  `folders/[FOLDER_ID]`
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
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLogsResponse, string> ListLogsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLogsRequest request = new ListLogsRequest
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
            return ListLogsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the logs in projects, organizations, folders, or billing accounts.
        /// Only logs that have entries are listed.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name to list logs for:
        /// 
        /// *  `projects/[PROJECT_ID]`
        /// *  `organizations/[ORGANIZATION_ID]`
        /// *  `billingAccounts/[BILLING_ACCOUNT_ID]`
        /// *  `folders/[FOLDER_ID]`
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
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLogsResponse, string> ListLogs(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLogsRequest request = new ListLogsRequest
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
            return ListLogs(request, callSettings);
        }

        /// <summary>
        /// Lists the logs in projects, organizations, folders, or billing accounts.
        /// Only logs that have entries are listed.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name to list logs for:
        /// 
        /// *  `projects/[PROJECT_ID]`
        /// *  `organizations/[ORGANIZATION_ID]`
        /// *  `billingAccounts/[BILLING_ACCOUNT_ID]`
        /// *  `folders/[FOLDER_ID]`
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
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLogsResponse, string> ListLogsAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLogsRequest request = new ListLogsRequest
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
            return ListLogsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the logs in projects, organizations, folders, or billing accounts.
        /// Only logs that have entries are listed.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name to list logs for:
        /// 
        /// *  `projects/[PROJECT_ID]`
        /// *  `organizations/[ORGANIZATION_ID]`
        /// *  `billingAccounts/[BILLING_ACCOUNT_ID]`
        /// *  `folders/[FOLDER_ID]`
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
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLogsResponse, string> ListLogs(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLogsRequest request = new ListLogsRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListLogs(request, callSettings);
        }

        /// <summary>
        /// Lists the logs in projects, organizations, folders, or billing accounts.
        /// Only logs that have entries are listed.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name to list logs for:
        /// 
        /// *  `projects/[PROJECT_ID]`
        /// *  `organizations/[ORGANIZATION_ID]`
        /// *  `billingAccounts/[BILLING_ACCOUNT_ID]`
        /// *  `folders/[FOLDER_ID]`
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
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLogsResponse, string> ListLogsAsync(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLogsRequest request = new ListLogsRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListLogsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the logs in projects, organizations, folders, or billing accounts.
        /// Only logs that have entries are listed.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name to list logs for:
        /// 
        /// *  `projects/[PROJECT_ID]`
        /// *  `organizations/[ORGANIZATION_ID]`
        /// *  `billingAccounts/[BILLING_ACCOUNT_ID]`
        /// *  `folders/[FOLDER_ID]`
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
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLogsResponse, string> ListLogs(gagr::FolderName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLogsRequest request = new ListLogsRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListLogs(request, callSettings);
        }

        /// <summary>
        /// Lists the logs in projects, organizations, folders, or billing accounts.
        /// Only logs that have entries are listed.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name to list logs for:
        /// 
        /// *  `projects/[PROJECT_ID]`
        /// *  `organizations/[ORGANIZATION_ID]`
        /// *  `billingAccounts/[BILLING_ACCOUNT_ID]`
        /// *  `folders/[FOLDER_ID]`
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
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLogsResponse, string> ListLogsAsync(gagr::FolderName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLogsRequest request = new ListLogsRequest
            {
                ParentAsFolderName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListLogsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the logs in projects, organizations, folders, or billing accounts.
        /// Only logs that have entries are listed.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name to list logs for:
        /// 
        /// *  `projects/[PROJECT_ID]`
        /// *  `organizations/[ORGANIZATION_ID]`
        /// *  `billingAccounts/[BILLING_ACCOUNT_ID]`
        /// *  `folders/[FOLDER_ID]`
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
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLogsResponse, string> ListLogs(gagr::BillingAccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLogsRequest request = new ListLogsRequest
            {
                ParentAsBillingAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListLogs(request, callSettings);
        }

        /// <summary>
        /// Lists the logs in projects, organizations, folders, or billing accounts.
        /// Only logs that have entries are listed.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name to list logs for:
        /// 
        /// *  `projects/[PROJECT_ID]`
        /// *  `organizations/[ORGANIZATION_ID]`
        /// *  `billingAccounts/[BILLING_ACCOUNT_ID]`
        /// *  `folders/[FOLDER_ID]`
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
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLogsResponse, string> ListLogsAsync(gagr::BillingAccountName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLogsRequest request = new ListLogsRequest
            {
                ParentAsBillingAccountName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListLogsAsync(request, callSettings);
        }

        /// <summary>
        /// Bidirectional streaming methods for
        /// <see cref="TailLogEntries(gaxgrpc::CallSettings,gaxgrpc::BidirectionalStreamingSettings)"/>.
        /// </summary>
        public abstract partial class TailLogEntriesStream : gaxgrpc::BidirectionalStreamingBase<TailLogEntriesRequest, TailLogEntriesResponse>
        {
        }

        /// <summary>
        /// Streaming read of log entries as they are ingested. Until the stream is
        /// terminated, it will continue reading logs.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public virtual TailLogEntriesStream TailLogEntries(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null) =>
            throw new sys::NotImplementedException();
    }

    /// <summary>LoggingServiceV2 client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for ingesting and querying logs.
    /// </remarks>
    public sealed partial class LoggingServiceV2ClientImpl : LoggingServiceV2Client
    {
        private readonly gaxgrpc::ApiCall<DeleteLogRequest, wkt::Empty> _callDeleteLog;

        private readonly gaxgrpc::ApiCall<WriteLogEntriesRequest, WriteLogEntriesResponse> _callWriteLogEntries;

        private readonly gaxgrpc::ApiCall<ListLogEntriesRequest, ListLogEntriesResponse> _callListLogEntries;

        private readonly gaxgrpc::ApiCall<ListMonitoredResourceDescriptorsRequest, ListMonitoredResourceDescriptorsResponse> _callListMonitoredResourceDescriptors;

        private readonly gaxgrpc::ApiCall<ListLogsRequest, ListLogsResponse> _callListLogs;

        private readonly gaxgrpc::ApiBidirectionalStreamingCall<TailLogEntriesRequest, TailLogEntriesResponse> _callTailLogEntries;

        /// <summary>
        /// Constructs a client wrapper for the LoggingServiceV2 service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="LoggingServiceV2Settings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public LoggingServiceV2ClientImpl(LoggingServiceV2.LoggingServiceV2Client grpcClient, LoggingServiceV2Settings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            LoggingServiceV2Settings effectiveSettings = settings ?? LoggingServiceV2Settings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callDeleteLog = clientHelper.BuildApiCall<DeleteLogRequest, wkt::Empty>("DeleteLog", grpcClient.DeleteLogAsync, grpcClient.DeleteLog, effectiveSettings.DeleteLogSettings).WithGoogleRequestParam("log_name", request => request.LogName);
            Modify_ApiCall(ref _callDeleteLog);
            Modify_DeleteLogApiCall(ref _callDeleteLog);
            _callWriteLogEntries = clientHelper.BuildApiCall<WriteLogEntriesRequest, WriteLogEntriesResponse>("WriteLogEntries", grpcClient.WriteLogEntriesAsync, grpcClient.WriteLogEntries, effectiveSettings.WriteLogEntriesSettings);
            Modify_ApiCall(ref _callWriteLogEntries);
            Modify_WriteLogEntriesApiCall(ref _callWriteLogEntries);
            _callListLogEntries = clientHelper.BuildApiCall<ListLogEntriesRequest, ListLogEntriesResponse>("ListLogEntries", grpcClient.ListLogEntriesAsync, grpcClient.ListLogEntries, effectiveSettings.ListLogEntriesSettings);
            Modify_ApiCall(ref _callListLogEntries);
            Modify_ListLogEntriesApiCall(ref _callListLogEntries);
            _callListMonitoredResourceDescriptors = clientHelper.BuildApiCall<ListMonitoredResourceDescriptorsRequest, ListMonitoredResourceDescriptorsResponse>("ListMonitoredResourceDescriptors", grpcClient.ListMonitoredResourceDescriptorsAsync, grpcClient.ListMonitoredResourceDescriptors, effectiveSettings.ListMonitoredResourceDescriptorsSettings);
            Modify_ApiCall(ref _callListMonitoredResourceDescriptors);
            Modify_ListMonitoredResourceDescriptorsApiCall(ref _callListMonitoredResourceDescriptors);
            _callListLogs = clientHelper.BuildApiCall<ListLogsRequest, ListLogsResponse>("ListLogs", grpcClient.ListLogsAsync, grpcClient.ListLogs, effectiveSettings.ListLogsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListLogs);
            Modify_ListLogsApiCall(ref _callListLogs);
            _callTailLogEntries = clientHelper.BuildApiCall<TailLogEntriesRequest, TailLogEntriesResponse>("TailLogEntries", grpcClient.TailLogEntries, effectiveSettings.TailLogEntriesSettings, effectiveSettings.TailLogEntriesStreamingSettings);
            Modify_ApiCall(ref _callTailLogEntries);
            Modify_TailLogEntriesApiCall(ref _callTailLogEntries);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiBidirectionalStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_DeleteLogApiCall(ref gaxgrpc::ApiCall<DeleteLogRequest, wkt::Empty> call);

        partial void Modify_WriteLogEntriesApiCall(ref gaxgrpc::ApiCall<WriteLogEntriesRequest, WriteLogEntriesResponse> call);

        partial void Modify_ListLogEntriesApiCall(ref gaxgrpc::ApiCall<ListLogEntriesRequest, ListLogEntriesResponse> call);

        partial void Modify_ListMonitoredResourceDescriptorsApiCall(ref gaxgrpc::ApiCall<ListMonitoredResourceDescriptorsRequest, ListMonitoredResourceDescriptorsResponse> call);

        partial void Modify_ListLogsApiCall(ref gaxgrpc::ApiCall<ListLogsRequest, ListLogsResponse> call);

        partial void Modify_TailLogEntriesApiCall(ref gaxgrpc::ApiBidirectionalStreamingCall<TailLogEntriesRequest, TailLogEntriesResponse> call);

        partial void OnConstruction(LoggingServiceV2.LoggingServiceV2Client grpcClient, LoggingServiceV2Settings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC LoggingServiceV2 client</summary>
        public override LoggingServiceV2.LoggingServiceV2Client GrpcClient { get; }

        partial void Modify_DeleteLogRequest(ref DeleteLogRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_WriteLogEntriesRequest(ref WriteLogEntriesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListLogEntriesRequest(ref ListLogEntriesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListMonitoredResourceDescriptorsRequest(ref ListMonitoredResourceDescriptorsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListLogsRequest(ref ListLogsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TailLogEntriesRequestCallSettings(ref gaxgrpc::CallSettings settings);

        partial void Modify_TailLogEntriesRequestRequest(ref TailLogEntriesRequest request);

        /// <summary>
        /// Deletes all the log entries in a log for the _Default Log Bucket. The log
        /// reappears if it receives new entries. Log entries written shortly before
        /// the delete operation might not be deleted. Entries received after the
        /// delete operation with a timestamp before the operation will be deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteLog(DeleteLogRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteLogRequest(ref request, ref callSettings);
            _callDeleteLog.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes all the log entries in a log for the _Default Log Bucket. The log
        /// reappears if it receives new entries. Log entries written shortly before
        /// the delete operation might not be deleted. Entries received after the
        /// delete operation with a timestamp before the operation will be deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteLogAsync(DeleteLogRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteLogRequest(ref request, ref callSettings);
            return _callDeleteLog.Async(request, callSettings);
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
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override WriteLogEntriesResponse WriteLogEntries(WriteLogEntriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_WriteLogEntriesRequest(ref request, ref callSettings);
            return _callWriteLogEntries.Sync(request, callSettings);
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
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<WriteLogEntriesResponse> WriteLogEntriesAsync(WriteLogEntriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_WriteLogEntriesRequest(ref request, ref callSettings);
            return _callWriteLogEntries.Async(request, callSettings);
        }

        /// <summary>
        /// Lists log entries.  Use this method to retrieve log entries that originated
        /// from a project/folder/organization/billing account.  For ways to export log
        /// entries, see [Exporting
        /// Logs](https://cloud.google.com/logging/docs/export).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="LogEntry"/> resources.</returns>
        public override gax::PagedEnumerable<ListLogEntriesResponse, LogEntry> ListLogEntries(ListLogEntriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLogEntriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListLogEntriesRequest, ListLogEntriesResponse, LogEntry>(_callListLogEntries, request, callSettings);
        }

        /// <summary>
        /// Lists log entries.  Use this method to retrieve log entries that originated
        /// from a project/folder/organization/billing account.  For ways to export log
        /// entries, see [Exporting
        /// Logs](https://cloud.google.com/logging/docs/export).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="LogEntry"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListLogEntriesResponse, LogEntry> ListLogEntriesAsync(ListLogEntriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLogEntriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListLogEntriesRequest, ListLogEntriesResponse, LogEntry>(_callListLogEntries, request, callSettings);
        }

        /// <summary>
        /// Lists the descriptors for monitored resource types used by Logging.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ga::MonitoredResourceDescriptor"/> resources.</returns>
        public override gax::PagedEnumerable<ListMonitoredResourceDescriptorsResponse, ga::MonitoredResourceDescriptor> ListMonitoredResourceDescriptors(ListMonitoredResourceDescriptorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMonitoredResourceDescriptorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMonitoredResourceDescriptorsRequest, ListMonitoredResourceDescriptorsResponse, ga::MonitoredResourceDescriptor>(_callListMonitoredResourceDescriptors, request, callSettings);
        }

        /// <summary>
        /// Lists the descriptors for monitored resource types used by Logging.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ga::MonitoredResourceDescriptor"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListMonitoredResourceDescriptorsResponse, ga::MonitoredResourceDescriptor> ListMonitoredResourceDescriptorsAsync(ListMonitoredResourceDescriptorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMonitoredResourceDescriptorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMonitoredResourceDescriptorsRequest, ListMonitoredResourceDescriptorsResponse, ga::MonitoredResourceDescriptor>(_callListMonitoredResourceDescriptors, request, callSettings);
        }

        /// <summary>
        /// Lists the logs in projects, organizations, folders, or billing accounts.
        /// Only logs that have entries are listed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public override gax::PagedEnumerable<ListLogsResponse, string> ListLogs(ListLogsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLogsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListLogsRequest, ListLogsResponse, string>(_callListLogs, request, callSettings);
        }

        /// <summary>
        /// Lists the logs in projects, organizations, folders, or billing accounts.
        /// Only logs that have entries are listed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListLogsResponse, string> ListLogsAsync(ListLogsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLogsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListLogsRequest, ListLogsResponse, string>(_callListLogs, request, callSettings);
        }

        internal sealed partial class TailLogEntriesStreamImpl : TailLogEntriesStream
        {
            /// <summary>Construct the bidirectional streaming method for <c>TailLogEntries</c>.</summary>
            /// <param name="service">The service containing this streaming method.</param>
            /// <param name="call">The underlying gRPC duplex streaming call.</param>
            /// <param name="writeBuffer">
            /// The <see cref="gaxgrpc::BufferedClientStreamWriter{TailLogEntriesRequest}"/> instance associated with
            /// this streaming call.
            /// </param>
            public TailLogEntriesStreamImpl(LoggingServiceV2ClientImpl service, grpccore::AsyncDuplexStreamingCall<TailLogEntriesRequest, TailLogEntriesResponse> call, gaxgrpc::BufferedClientStreamWriter<TailLogEntriesRequest> writeBuffer)
            {
                _service = service;
                GrpcCall = call;
                _writeBuffer = writeBuffer;
            }

            private LoggingServiceV2ClientImpl _service;

            private gaxgrpc::BufferedClientStreamWriter<TailLogEntriesRequest> _writeBuffer;

            public override grpccore::AsyncDuplexStreamingCall<TailLogEntriesRequest, TailLogEntriesResponse> GrpcCall { get; }

            private TailLogEntriesRequest ModifyRequest(TailLogEntriesRequest request)
            {
                _service.Modify_TailLogEntriesRequestRequest(ref request);
                return request;
            }

            public override stt::Task TryWriteAsync(TailLogEntriesRequest message) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message));

            public override stt::Task WriteAsync(TailLogEntriesRequest message) =>
                _writeBuffer.WriteAsync(ModifyRequest(message));

            public override stt::Task TryWriteAsync(TailLogEntriesRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.TryWriteAsync(ModifyRequest(message), options);

            public override stt::Task WriteAsync(TailLogEntriesRequest message, grpccore::WriteOptions options) =>
                _writeBuffer.WriteAsync(ModifyRequest(message), options);

            public override stt::Task TryWriteCompleteAsync() => _writeBuffer.TryWriteCompleteAsync();

            public override stt::Task WriteCompleteAsync() => _writeBuffer.WriteCompleteAsync();
        }

        /// <summary>
        /// Streaming read of log entries as they are ingested. Until the stream is
        /// terminated, it will continue reading logs.
        /// </summary>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <param name="streamingSettings">If not null, applies streaming overrides to this RPC call.</param>
        /// <returns>The client-server stream.</returns>
        public override LoggingServiceV2Client.TailLogEntriesStream TailLogEntries(gaxgrpc::CallSettings callSettings = null, gaxgrpc::BidirectionalStreamingSettings streamingSettings = null)
        {
            Modify_TailLogEntriesRequestCallSettings(ref callSettings);
            gaxgrpc::BidirectionalStreamingSettings effectiveStreamingSettings = streamingSettings ?? _callTailLogEntries.StreamingSettings;
            grpccore::AsyncDuplexStreamingCall<TailLogEntriesRequest, TailLogEntriesResponse> call = _callTailLogEntries.Call(callSettings);
            gaxgrpc::BufferedClientStreamWriter<TailLogEntriesRequest> writeBuffer = new gaxgrpc::BufferedClientStreamWriter<TailLogEntriesRequest>(call.RequestStream, effectiveStreamingSettings.BufferedClientWriterCapacity);
            return new TailLogEntriesStreamImpl(this, call, writeBuffer);
        }
    }

    public partial class ListLogEntriesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMonitoredResourceDescriptorsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListLogsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListLogEntriesResponse : gaxgrpc::IPageResponse<LogEntry>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<LogEntry> GetEnumerator() => Entries.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListMonitoredResourceDescriptorsResponse : gaxgrpc::IPageResponse<ga::MonitoredResourceDescriptor>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ga::MonitoredResourceDescriptor> GetEnumerator() => ResourceDescriptors.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListLogsResponse : gaxgrpc::IPageResponse<string>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<string> GetEnumerator() => LogNames.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
