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

namespace Google.Logging.V2
{
    /// <summary>
    /// Settings for a <see cref="MetricsServiceV2Client"/>.
    /// </summary>
    public sealed partial class MetricsServiceV2Settings : ServiceSettingsBase
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
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListLogMetricsSettings = existing.ListLogMetricsSettings;
            GetLogMetricSettings = existing.GetLogMetricSettings;
            CreateLogMetricSettings = existing.CreateLogMetricSettings;
            UpdateLogMetricSettings = existing.UpdateLogMetricSettings;
            DeleteLogMetricSettings = existing.DeleteLogMetricSettings;
        }

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="MetricsServiceV2Client"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="MetricsServiceV2Client"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

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
        /// "Default" timeout backoff for <see cref="MetricsServiceV2Client"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="MetricsServiceV2Client"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="MetricsServiceV2Client"/> RPC methods is defined as:
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
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricsServiceV2Client.ListLogMetrics</c> and <c>MetricsServiceV2Client.ListLogMetricsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>MetricsServiceV2Client.ListLogMetrics</c> and
        /// <c>MetricsServiceV2Client.ListLogMetricsAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings ListLogMetricsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(45000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricsServiceV2Client.GetLogMetric</c> and <c>MetricsServiceV2Client.GetLogMetricAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>MetricsServiceV2Client.GetLogMetric</c> and
        /// <c>MetricsServiceV2Client.GetLogMetricAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings GetLogMetricSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(45000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricsServiceV2Client.CreateLogMetric</c> and <c>MetricsServiceV2Client.CreateLogMetricAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>MetricsServiceV2Client.CreateLogMetric</c> and
        /// <c>MetricsServiceV2Client.CreateLogMetricAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings CreateLogMetricSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(45000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricsServiceV2Client.UpdateLogMetric</c> and <c>MetricsServiceV2Client.UpdateLogMetricAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>MetricsServiceV2Client.UpdateLogMetric</c> and
        /// <c>MetricsServiceV2Client.UpdateLogMetricAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings UpdateLogMetricSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(45000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricsServiceV2Client.DeleteLogMetric</c> and <c>MetricsServiceV2Client.DeleteLogMetricAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>MetricsServiceV2Client.DeleteLogMetric</c> and
        /// <c>MetricsServiceV2Client.DeleteLogMetricAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings DeleteLogMetricSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(45000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="MetricsServiceV2Settings"/> object.</returns>
        public MetricsServiceV2Settings Clone() => new MetricsServiceV2Settings(this);
    }

    /// <summary>
    /// MetricsServiceV2 client wrapper, for convenient use.
    /// </summary>
    public abstract partial class MetricsServiceV2Client
    {
        /// <summary>
        /// The default endpoint for the MetricsServiceV2 service, which is a host of "logging.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("logging.googleapis.com", 443);

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
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
            "https://www.googleapis.com/auth/logging.admin",
            "https://www.googleapis.com/auth/logging.read",
            "https://www.googleapis.com/auth/logging.write",
        });

        private static readonly ChannelPool s_channelPool = new ChannelPool(DefaultScopes);

        /// <summary>
        /// Path template for a parent resource. Parameters:
        /// <list type="bullet">
        /// <item><description>project</description></item>
        /// </list>
        /// </summary>
        public static PathTemplate ParentTemplate { get; } = new PathTemplate("projects/{project}");

        /// <summary>
        /// Creates a parent resource name from its component IDs.
        /// </summary>
        /// <param name="projectId">The project ID.</param>
        /// <returns>
        /// The full parent resource name.
        /// </returns>
        public static string FormatParentName(string projectId) => ParentTemplate.Expand(projectId);

        /// <summary>
        /// Path template for a metric resource. Parameters:
        /// <list type="bullet">
        /// <item><description>project</description></item>
        /// <item><description>metric</description></item>
        /// </list>
        /// </summary>
        public static PathTemplate MetricTemplate { get; } = new PathTemplate("projects/{project}/metrics/{metric}");

        /// <summary>
        /// Creates a metric resource name from its component IDs.
        /// </summary>
        /// <param name="projectId">The project ID.</param>
        /// <param name="metricId">The metric ID.</param>
        /// <returns>
        /// The full metric resource name.
        /// </returns>
        public static string FormatMetricName(string projectId, string metricId) => MetricTemplate.Expand(projectId, metricId);

        // Note: we could have parameterless overloads of Create and CreateAsync,
        // documented to just use the default endpoint, settings and credentials.
        // Pros:
        // - Might be more reassuring on first use
        // - Allows method group conversions
        // Con: overloads!

        /// <summary>
        /// Asynchronously creates a <see cref="MetricsServiceV2Client"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="MetricsServiceV2Settings"/>.</param>
        /// <returns>The task representing the created <see cref="MetricsServiceV2Client"/>.</returns>
        public static async Task<MetricsServiceV2Client> CreateAsync(ServiceEndpoint endpoint = null, MetricsServiceV2Settings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="MetricsServiceV2Client"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="MetricsServiceV2Settings"/>.</param>
        /// <returns>The created <see cref="MetricsServiceV2Client"/>.</returns>
        public static MetricsServiceV2Client Create(ServiceEndpoint endpoint = null, MetricsServiceV2Settings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="MetricsServiceV2Client"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="MetricsServiceV2Settings"/>.</param>
        /// <returns>The created <see cref="MetricsServiceV2Client"/>.</returns>
        public static MetricsServiceV2Client Create(Channel channel, MetricsServiceV2Settings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            MetricsServiceV2.MetricsServiceV2Client grpcClient = new MetricsServiceV2.MetricsServiceV2Client(channel);
            return new MetricsServiceV2ClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, MetricsServiceV2Settings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, MetricsServiceV2Settings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, MetricsServiceV2Settings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, MetricsServiceV2Settings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC MetricsServiceV2 client.
        /// </summary>
        public virtual MetricsServiceV2.MetricsServiceV2Client GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="parent">
        ///
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
        public virtual IPagedAsyncEnumerable<ListLogMetricsResponse, LogMetric> ListLogMetricsAsync(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="parent">
        ///
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
        public virtual IPagedEnumerable<ListLogMetricsResponse, LogMetric> ListLogMetrics(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="metricName">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<LogMetric> GetLogMetricAsync(
            string metricName,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="metricName">
        ///
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<LogMetric> GetLogMetricAsync(
            string metricName,
            CancellationToken cancellationToken) => GetLogMetricAsync(
                metricName,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        ///
        /// </summary>
        /// <param name="metricName">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual LogMetric GetLogMetric(
            string metricName,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="parent">
        ///
        /// </param>
        /// <param name="metric">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<LogMetric> CreateLogMetricAsync(
            string parent,
            LogMetric metric,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="parent">
        ///
        /// </param>
        /// <param name="metric">
        ///
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<LogMetric> CreateLogMetricAsync(
            string parent,
            LogMetric metric,
            CancellationToken cancellationToken) => CreateLogMetricAsync(
                parent,
                metric,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        ///
        /// </summary>
        /// <param name="parent">
        ///
        /// </param>
        /// <param name="metric">
        ///
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
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="metricName">
        ///
        /// </param>
        /// <param name="metric">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<LogMetric> UpdateLogMetricAsync(
            string metricName,
            LogMetric metric,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="metricName">
        ///
        /// </param>
        /// <param name="metric">
        ///
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<LogMetric> UpdateLogMetricAsync(
            string metricName,
            LogMetric metric,
            CancellationToken cancellationToken) => UpdateLogMetricAsync(
                metricName,
                metric,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        ///
        /// </summary>
        /// <param name="metricName">
        ///
        /// </param>
        /// <param name="metric">
        ///
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
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="metricName">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteLogMetricAsync(
            string metricName,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="metricName">
        ///
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteLogMetricAsync(
            string metricName,
            CancellationToken cancellationToken) => DeleteLogMetricAsync(
                metricName,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        ///
        /// </summary>
        /// <param name="metricName">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual void DeleteLogMetric(
            string metricName,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    /// <summary>
    /// MetricsServiceV2 client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class MetricsServiceV2ClientImpl : MetricsServiceV2Client
    {
        private readonly ClientHelper _clientHelper;
        private readonly ApiCall<ListLogMetricsRequest, ListLogMetricsResponse> _callListLogMetrics;
        private readonly ApiCall<GetLogMetricRequest, LogMetric> _callGetLogMetric;
        private readonly ApiCall<CreateLogMetricRequest, LogMetric> _callCreateLogMetric;
        private readonly ApiCall<UpdateLogMetricRequest, LogMetric> _callUpdateLogMetric;
        private readonly ApiCall<DeleteLogMetricRequest, Empty> _callDeleteLogMetric;

        /// <summary>
        /// Constructs a client wrapper for the MetricsServiceV2 service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="MetricsServiceV2Settings"/> used within this client </param>
        public MetricsServiceV2ClientImpl(MetricsServiceV2.MetricsServiceV2Client grpcClient, MetricsServiceV2Settings settings)
        {
            this.GrpcClient = grpcClient;
            MetricsServiceV2Settings effectiveSettings = settings ?? MetricsServiceV2Settings.GetDefault();
            _clientHelper = new ClientHelper(effectiveSettings);
            _callListLogMetrics = _clientHelper.BuildApiCall<ListLogMetricsRequest, ListLogMetricsResponse>(
                GrpcClient.ListLogMetricsAsync, GrpcClient.ListLogMetrics, effectiveSettings.ListLogMetricsSettings);
            _callGetLogMetric = _clientHelper.BuildApiCall<GetLogMetricRequest, LogMetric>(
                GrpcClient.GetLogMetricAsync, GrpcClient.GetLogMetric, effectiveSettings.GetLogMetricSettings);
            _callCreateLogMetric = _clientHelper.BuildApiCall<CreateLogMetricRequest, LogMetric>(
                GrpcClient.CreateLogMetricAsync, GrpcClient.CreateLogMetric, effectiveSettings.CreateLogMetricSettings);
            _callUpdateLogMetric = _clientHelper.BuildApiCall<UpdateLogMetricRequest, LogMetric>(
                GrpcClient.UpdateLogMetricAsync, GrpcClient.UpdateLogMetric, effectiveSettings.UpdateLogMetricSettings);
            _callDeleteLogMetric = _clientHelper.BuildApiCall<DeleteLogMetricRequest, Empty>(
                GrpcClient.DeleteLogMetricAsync, GrpcClient.DeleteLogMetric, effectiveSettings.DeleteLogMetricSettings);
        }

        /// <summary>
        /// The underlying gRPC MetricsServiceV2 client.
        /// </summary>
        public override MetricsServiceV2.MetricsServiceV2Client GrpcClient { get; }

        /// <summary>
        ///
        /// </summary>
        /// <param name="parent">
        ///
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
        public override IPagedAsyncEnumerable<ListLogMetricsResponse, LogMetric> ListLogMetricsAsync(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => new PagedAsyncEnumerable<ListLogMetricsRequest, ListLogMetricsResponse, LogMetric>(
                _callListLogMetrics,
                new ListLogMetricsRequest
                {
                    Parent = parent,
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="parent">
        ///
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
        public override IPagedEnumerable<ListLogMetricsResponse, LogMetric> ListLogMetrics(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => new PagedEnumerable<ListLogMetricsRequest, ListLogMetricsResponse, LogMetric>(
                _callListLogMetrics,
                new ListLogMetricsRequest
                {
                    Parent = parent,
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="metricName">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<LogMetric> GetLogMetricAsync(
            string metricName,
            CallSettings callSettings = null) => _callGetLogMetric.Async(
                new GetLogMetricRequest
                {
                    MetricName = metricName,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="metricName">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override LogMetric GetLogMetric(
            string metricName,
            CallSettings callSettings = null) => _callGetLogMetric.Sync(
                new GetLogMetricRequest
                {
                    MetricName = metricName,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="parent">
        ///
        /// </param>
        /// <param name="metric">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<LogMetric> CreateLogMetricAsync(
            string parent,
            LogMetric metric,
            CallSettings callSettings = null) => _callCreateLogMetric.Async(
                new CreateLogMetricRequest
                {
                    Parent = parent,
                    Metric = metric,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="parent">
        ///
        /// </param>
        /// <param name="metric">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override LogMetric CreateLogMetric(
            string parent,
            LogMetric metric,
            CallSettings callSettings = null) => _callCreateLogMetric.Sync(
                new CreateLogMetricRequest
                {
                    Parent = parent,
                    Metric = metric,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="metricName">
        ///
        /// </param>
        /// <param name="metric">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<LogMetric> UpdateLogMetricAsync(
            string metricName,
            LogMetric metric,
            CallSettings callSettings = null) => _callUpdateLogMetric.Async(
                new UpdateLogMetricRequest
                {
                    MetricName = metricName,
                    Metric = metric,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="metricName">
        ///
        /// </param>
        /// <param name="metric">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override LogMetric UpdateLogMetric(
            string metricName,
            LogMetric metric,
            CallSettings callSettings = null) => _callUpdateLogMetric.Sync(
                new UpdateLogMetricRequest
                {
                    MetricName = metricName,
                    Metric = metric,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="metricName">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task DeleteLogMetricAsync(
            string metricName,
            CallSettings callSettings = null) => _callDeleteLogMetric.Async(
                new DeleteLogMetricRequest
                {
                    MetricName = metricName,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="metricName">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override void DeleteLogMetric(
            string metricName,
            CallSettings callSettings = null) => _callDeleteLogMetric.Sync(
                new DeleteLogMetricRequest
                {
                    MetricName = metricName,
                },
                callSettings);

    }

    // Partial classes to enable page-streaming

    public partial class ListLogMetricsRequest : IPageRequest { }
    public partial class ListLogMetricsResponse : IPageResponse<LogMetric>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<LogMetric> GetEnumerator() => Metrics.GetEnumerator();

        <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

}
