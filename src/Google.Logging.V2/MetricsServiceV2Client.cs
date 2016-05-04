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
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Logging.V2
{

    /// <summary>
    /// Extension methods to assist with using <see cref="MetricsServiceV2Client"/>.
    /// </summary>
    public static partial class MetricsServiceV2Extensions
    {
        /// <summary>
        /// Wrap a GRPC MetricsServiceV2 client for more convenient use.
        /// </summary>
        /// <param name="grpcClient">A GRPC client to wrap.</param>
        /// <param name="settings">
        /// An optional <see cref="MetricsServiceV2Settings"/> to configure this wrapper.
        /// If null or not specified, then the default settings are used.
        /// </param>
        /// <returns>A <see cref="MetricsServiceV2Client"/> that wraps the specified GRPC client.</returns>
        public static MetricsServiceV2Client ToClient(
            this MetricsServiceV2.IMetricsServiceV2Client grpcClient,
            MetricsServiceV2Settings settings = null
        ) => new MetricsServiceV2ClientImpl(grpcClient, settings);
    }

    /// <summary>
    /// Settings for a MetricsServiceV2 wrapper.
    /// </summary>
    public sealed partial class MetricsServiceV2Settings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="MetricsServiceV2Settings"/>.
        /// </summary>
        /// <returns>A new instance of the default MetricsServiceV2Settings.</returns>
        public static MetricsServiceV2Settings GetDefault() => new MetricsServiceV2Settings();

        /// <summary>
        /// Constructs a new MetricsServiceV2Settings object with default settings.
        /// </summary>
        public MetricsServiceV2Settings() { }

        private MetricsServiceV2Settings(MetricsServiceV2Settings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListLogMetricsSettings = existing.ListLogMetricsSettings?.Clone();
            GetLogMetricSettings = existing.GetLogMetricSettings?.Clone();
            CreateLogMetricSettings = existing.CreateLogMetricSettings?.Clone();
            UpdateLogMetricSettings = existing.UpdateLogMetricSettings?.Clone();
            DeleteLogMetricSettings = existing.DeleteLogMetricSettings?.Clone();
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
        /// There are no RPC <see cref="StatusCode">s eligilbe for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="MetricsServiceV2Client"/> RPC methods.
        /// </summary>
        /// <returns>The "Default" retry backoff for <see cref="MetricsServiceV2Client"/> RPC methods.</returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="MetricsServiceV2Client"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="MetricsServiceV2Client"/> RPC methods.
        /// </summary>
        /// <returns>The "Default" timeout backoff for <see cref="MetricsServiceV2Client"/> RPC methods.</returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="MetricsServiceV2Client"/> RPC methods is defined as:
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
        /// <see cref="CallSettings"/> for asynchronous and synchronous calls to
        /// <see cref="MetricsServiceV2Client.ListLogMetrics"/> and <see cref="MetricsServiceV2Client.ListLogMetricsAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="MetricsServiceV2Client.ListLogMetrics"/> and
        /// <see cref="MetricsServiceV2Client.ListLogMetricsAsync"/> <see cref="RetrySettings"/> are:
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
        public CallSettings ListLogMetricsSettings { get; set; } = new CallSettings
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
        /// <see cref="MetricsServiceV2Client.GetLogMetric"/> and <see cref="MetricsServiceV2Client.GetLogMetricAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="MetricsServiceV2Client.GetLogMetric"/> and
        /// <see cref="MetricsServiceV2Client.GetLogMetricAsync"/> <see cref="RetrySettings"/> are:
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
        public CallSettings GetLogMetricSettings { get; set; } = new CallSettings
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
        /// <see cref="MetricsServiceV2Client.CreateLogMetric"/> and <see cref="MetricsServiceV2Client.CreateLogMetricAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="MetricsServiceV2Client.CreateLogMetric"/> and
        /// <see cref="MetricsServiceV2Client.CreateLogMetricAsync"/> <see cref="RetrySettings"/> are:
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
        public CallSettings CreateLogMetricSettings { get; set; } = new CallSettings
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
        /// <see cref="MetricsServiceV2Client.UpdateLogMetric"/> and <see cref="MetricsServiceV2Client.UpdateLogMetricAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="MetricsServiceV2Client.UpdateLogMetric"/> and
        /// <see cref="MetricsServiceV2Client.UpdateLogMetricAsync"/> <see cref="RetrySettings"/> are:
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
        public CallSettings UpdateLogMetricSettings { get; set; } = new CallSettings
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
        /// <see cref="MetricsServiceV2Client.DeleteLogMetric"/> and <see cref="MetricsServiceV2Client.DeleteLogMetricAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="MetricsServiceV2Client.DeleteLogMetric"/> and
        /// <see cref="MetricsServiceV2Client.DeleteLogMetricAsync"/> <see cref="RetrySettings"/> are:
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
        public CallSettings DeleteLogMetricSettings { get; set; } = new CallSettings
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
        /// <returns>A deep clone of this set of MetricsServiceV2 settings.</returns>
        public MetricsServiceV2Settings Clone() => new MetricsServiceV2Settings(this);
    }

    /// <summary>
    /// MetricsServiceV2 client wrapper, for convenient use.
    /// </summary>
    public abstract partial class MetricsServiceV2Client
    {
        private static readonly ChannelPool s_channelPool = new ChannelPool();

        /// <summary>
        /// The default endpoint for the MetricsServiceV2 service, which is a host of "logging.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("logging.googleapis.com", 443);

        /// <summary>
        /// The default MetricsServiceV2 scopes
        /// </summary>
        /// <remarks>
        /// The default MetricsServiceV2 scopes are:
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
        /// <returns>The full metric resource name.</returns>
        public static string GetMetricName(string projectId, string metricId) => MetricTemplate.Expand(projectId, metricId);

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
        /// The underlying GRPC MetricsServiceV2 client.
        /// </summary>
        public virtual MetricsServiceV2.IMetricsServiceV2Client GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Lists logs-based metrics.
        /// </summary>
        /// <param name="project_name">
        /// Required. The resource name of the project containing the metrics.
        /// Example: `"projects/my-project-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual IAsyncEnumerable<LogMetric> ListLogMetricsAsync(
            string projectName,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists logs-based metrics.
        /// </summary>
        /// <param name="project_name">
        /// Required. The resource name of the project containing the metrics.
        /// Example: `"projects/my-project-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IEnumerable<LogMetric> ListLogMetrics(
            string projectName,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a logs-based metric.
        /// </summary>
        /// <param name="metric_name">
        /// The resource name of the desired metric.
        /// Example: `"projects/my-project-id/metrics/my-metric-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<LogMetric> GetLogMetricAsync(
            string metricName,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a logs-based metric.
        /// </summary>
        /// <param name="metric_name">
        /// The resource name of the desired metric.
        /// Example: `"projects/my-project-id/metrics/my-metric-id"`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<LogMetric> GetLogMetricAsync(
            string metricName,
            CancellationToken cancellationToken) => GetLogMetricAsync(
                metricName,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Gets a logs-based metric.
        /// </summary>
        /// <param name="metric_name">
        /// The resource name of the desired metric.
        /// Example: `"projects/my-project-id/metrics/my-metric-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogMetric GetLogMetric(
            string metricName,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a logs-based metric.
        /// </summary>
        /// <param name="project_name">
        /// The resource name of the project in which to create the metric.
        /// Example: `"projects/my-project-id"`.
        ///
        /// The new metric must be provided in the request.
        /// </param>
        /// <param name="metric">
        /// The new logs-based metric, which must not have an identifier that
        /// already exists.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<LogMetric> CreateLogMetricAsync(
            string projectName,
            LogMetric metric,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a logs-based metric.
        /// </summary>
        /// <param name="project_name">
        /// The resource name of the project in which to create the metric.
        /// Example: `"projects/my-project-id"`.
        ///
        /// The new metric must be provided in the request.
        /// </param>
        /// <param name="metric">
        /// The new logs-based metric, which must not have an identifier that
        /// already exists.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<LogMetric> CreateLogMetricAsync(
            string projectName,
            LogMetric metric,
            CancellationToken cancellationToken) => CreateLogMetricAsync(
                projectName,
                metric,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Creates a logs-based metric.
        /// </summary>
        /// <param name="project_name">
        /// The resource name of the project in which to create the metric.
        /// Example: `"projects/my-project-id"`.
        ///
        /// The new metric must be provided in the request.
        /// </param>
        /// <param name="metric">
        /// The new logs-based metric, which must not have an identifier that
        /// already exists.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogMetric CreateLogMetric(
            string projectName,
            LogMetric metric,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates or updates a logs-based metric.
        /// </summary>
        /// <param name="metric_name">
        /// The resource name of the metric to update.
        /// Example: `"projects/my-project-id/metrics/my-metric-id"`.
        ///
        /// The updated metric must be provided in the request and have the
        /// same identifier that is specified in `metricName`.
        /// If the metric does not exist, it is created.
        /// </param>
        /// <param name="metric">
        /// The updated metric, whose name must be the same as the
        /// metric identifier in `metricName`. If `metricName` does not
        /// exist, then a new metric is created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<LogMetric> UpdateLogMetricAsync(
            string metricName,
            LogMetric metric,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates or updates a logs-based metric.
        /// </summary>
        /// <param name="metric_name">
        /// The resource name of the metric to update.
        /// Example: `"projects/my-project-id/metrics/my-metric-id"`.
        ///
        /// The updated metric must be provided in the request and have the
        /// same identifier that is specified in `metricName`.
        /// If the metric does not exist, it is created.
        /// </param>
        /// <param name="metric">
        /// The updated metric, whose name must be the same as the
        /// metric identifier in `metricName`. If `metricName` does not
        /// exist, then a new metric is created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<LogMetric> UpdateLogMetricAsync(
            string metricName,
            LogMetric metric,
            CancellationToken cancellationToken) => UpdateLogMetricAsync(
                metricName,
                metric,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Creates or updates a logs-based metric.
        /// </summary>
        /// <param name="metric_name">
        /// The resource name of the metric to update.
        /// Example: `"projects/my-project-id/metrics/my-metric-id"`.
        ///
        /// The updated metric must be provided in the request and have the
        /// same identifier that is specified in `metricName`.
        /// If the metric does not exist, it is created.
        /// </param>
        /// <param name="metric">
        /// The updated metric, whose name must be the same as the
        /// metric identifier in `metricName`. If `metricName` does not
        /// exist, then a new metric is created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LogMetric UpdateLogMetric(
            string metricName,
            LogMetric metric,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a logs-based metric.
        /// </summary>
        /// <param name="metric_name">
        /// The resource name of the metric to delete.
        /// Example: `"projects/my-project-id/metrics/my-metric-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task DeleteLogMetricAsync(
            string metricName,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a logs-based metric.
        /// </summary>
        /// <param name="metric_name">
        /// The resource name of the metric to delete.
        /// Example: `"projects/my-project-id/metrics/my-metric-id"`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task DeleteLogMetricAsync(
            string metricName,
            CancellationToken cancellationToken) => DeleteLogMetricAsync(
                metricName,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Deletes a logs-based metric.
        /// </summary>
        /// <param name="metric_name">
        /// The resource name of the metric to delete.
        /// Example: `"projects/my-project-id/metrics/my-metric-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteLogMetric(
            string metricName,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    public sealed partial class MetricsServiceV2ClientImpl : MetricsServiceV2Client
    {
        private static readonly PageStreamer<LogMetric, ListLogMetricsRequest, ListLogMetricsResponse, string> s_listLogMetricsPageStreamer =
            new PageStreamer<LogMetric, ListLogMetricsRequest, ListLogMetricsResponse, string>(
                (request, token) => {
                    request.PageToken = token;
                    return request;
                },
                response => response.NextPageToken,
                response => response.Metrics,
                "" // An empty page-token
            );

        private readonly ClientHelper _clientHelper;
        private readonly ApiCall<ListLogMetricsRequest, ListLogMetricsResponse> _callListLogMetrics;
        private readonly ApiCall<GetLogMetricRequest, LogMetric> _callGetLogMetric;
        private readonly ApiCall<CreateLogMetricRequest, LogMetric> _callCreateLogMetric;
        private readonly ApiCall<UpdateLogMetricRequest, LogMetric> _callUpdateLogMetric;
        private readonly ApiCall<DeleteLogMetricRequest, Empty> _callDeleteLogMetric;

        public MetricsServiceV2ClientImpl(MetricsServiceV2.IMetricsServiceV2Client grpcClient, MetricsServiceV2Settings settings)
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

        public override MetricsServiceV2.IMetricsServiceV2Client GrpcClient { get; }

        /// <summary>
        /// Lists logs-based metrics.
        /// </summary>
        /// <param name="project_name">
        /// Required. The resource name of the project containing the metrics.
        /// Example: `"projects/my-project-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override IAsyncEnumerable<LogMetric> ListLogMetricsAsync(
            string projectName,
            CallSettings callSettings = null) => s_listLogMetricsPageStreamer.FetchAsync(
                callSettings,
                new ListLogMetricsRequest
                {
                    ProjectName = projectName,
                },
                _callListLogMetrics);

        /// <summary>
        /// Lists logs-based metrics.
        /// </summary>
        /// <param name="project_name">
        /// Required. The resource name of the project containing the metrics.
        /// Example: `"projects/my-project-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override IEnumerable<LogMetric> ListLogMetrics(
            string projectName,
            CallSettings callSettings = null) => s_listLogMetricsPageStreamer.Fetch(
                callSettings,
                new ListLogMetricsRequest
                {
                    ProjectName = projectName,
                },
                _callListLogMetrics);

        /// <summary>
        /// Gets a logs-based metric.
        /// </summary>
        /// <param name="metric_name">
        /// The resource name of the desired metric.
        /// Example: `"projects/my-project-id/metrics/my-metric-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<LogMetric> GetLogMetricAsync(
            string metricName,
            CallSettings callSettings = null) => _callGetLogMetric.Async(
                new GetLogMetricRequest
                {
                    MetricName = metricName,
                },
                callSettings);

        /// <summary>
        /// Gets a logs-based metric.
        /// </summary>
        /// <param name="metric_name">
        /// The resource name of the desired metric.
        /// Example: `"projects/my-project-id/metrics/my-metric-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LogMetric GetLogMetric(
            string metricName,
            CallSettings callSettings = null) => _callGetLogMetric.Sync(
                new GetLogMetricRequest
                {
                    MetricName = metricName,
                },
                callSettings);

        /// <summary>
        /// Creates a logs-based metric.
        /// </summary>
        /// <param name="project_name">
        /// The resource name of the project in which to create the metric.
        /// Example: `"projects/my-project-id"`.
        ///
        /// The new metric must be provided in the request.
        /// </param>
        /// <param name="metric">
        /// The new logs-based metric, which must not have an identifier that
        /// already exists.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<LogMetric> CreateLogMetricAsync(
            string projectName,
            LogMetric metric,
            CallSettings callSettings = null) => _callCreateLogMetric.Async(
                new CreateLogMetricRequest
                {
                    ProjectName = projectName,
                    Metric = metric,
                },
                callSettings);

        /// <summary>
        /// Creates a logs-based metric.
        /// </summary>
        /// <param name="project_name">
        /// The resource name of the project in which to create the metric.
        /// Example: `"projects/my-project-id"`.
        ///
        /// The new metric must be provided in the request.
        /// </param>
        /// <param name="metric">
        /// The new logs-based metric, which must not have an identifier that
        /// already exists.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LogMetric CreateLogMetric(
            string projectName,
            LogMetric metric,
            CallSettings callSettings = null) => _callCreateLogMetric.Sync(
                new CreateLogMetricRequest
                {
                    ProjectName = projectName,
                    Metric = metric,
                },
                callSettings);

        /// <summary>
        /// Creates or updates a logs-based metric.
        /// </summary>
        /// <param name="metric_name">
        /// The resource name of the metric to update.
        /// Example: `"projects/my-project-id/metrics/my-metric-id"`.
        ///
        /// The updated metric must be provided in the request and have the
        /// same identifier that is specified in `metricName`.
        /// If the metric does not exist, it is created.
        /// </param>
        /// <param name="metric">
        /// The updated metric, whose name must be the same as the
        /// metric identifier in `metricName`. If `metricName` does not
        /// exist, then a new metric is created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
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
        /// Creates or updates a logs-based metric.
        /// </summary>
        /// <param name="metric_name">
        /// The resource name of the metric to update.
        /// Example: `"projects/my-project-id/metrics/my-metric-id"`.
        ///
        /// The updated metric must be provided in the request and have the
        /// same identifier that is specified in `metricName`.
        /// If the metric does not exist, it is created.
        /// </param>
        /// <param name="metric">
        /// The updated metric, whose name must be the same as the
        /// metric identifier in `metricName`. If `metricName` does not
        /// exist, then a new metric is created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
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
        /// Deletes a logs-based metric.
        /// </summary>
        /// <param name="metric_name">
        /// The resource name of the metric to delete.
        /// Example: `"projects/my-project-id/metrics/my-metric-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task DeleteLogMetricAsync(
            string metricName,
            CallSettings callSettings = null) => _callDeleteLogMetric.Async(
                new DeleteLogMetricRequest
                {
                    MetricName = metricName,
                },
                callSettings);

        /// <summary>
        /// Deletes a logs-based metric.
        /// </summary>
        /// <param name="metric_name">
        /// The resource name of the metric to delete.
        /// Example: `"projects/my-project-id/metrics/my-metric-id"`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteLogMetric(
            string metricName,
            CallSettings callSettings = null) => _callDeleteLogMetric.Sync(
                new DeleteLogMetricRequest
                {
                    MetricName = metricName,
                },
                callSettings);

    }
}