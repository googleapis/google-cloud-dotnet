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

namespace Google.Monitoring.V3
{

    /// <summary>
    /// Extension methods to assist with using <see cref="MetricServiceClient"/>.
    /// </summary>
    public static partial class MetricServiceExtensions
    {
        /// <summary>
        /// Wrap a GRPC MetricService client for more convenient use.
        /// </summary>
        /// <param name="grpcClient">A GRPC client to wrap.</param>
        /// <param name="settings">
        /// An optional <see cref="MetricServiceSettings"/> to configure this wrapper.
        /// If null or not specified, then the default settings are used.
        /// </param>
        /// <returns>A <see cref="MetricServiceClient"/> that wraps the specified GRPC client.</returns>
        public static MetricServiceClient ToClient(
            this MetricService.MetricServiceClient grpcClient,
            MetricServiceSettings settings = null
        ) => new MetricServiceClientImpl(grpcClient, settings);
    }

    /// <summary>
    /// Settings for a MetricService wrapper.
    /// </summary>
    public sealed partial class MetricServiceSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="MetricServiceSettings"/>.
        /// </summary>
        /// <returns>A new instance of the default MetricServiceSettings.</returns>
        public static MetricServiceSettings GetDefault() => new MetricServiceSettings();

        /// <summary>
        /// Constructs a new MetricServiceSettings object with default settings.
        /// </summary>
        public MetricServiceSettings() { }

        private MetricServiceSettings(MetricServiceSettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListMonitoredResourceDescriptorsSettings = existing.ListMonitoredResourceDescriptorsSettings?.Clone();
            GetMonitoredResourceDescriptorSettings = existing.GetMonitoredResourceDescriptorSettings?.Clone();
            ListMetricDescriptorsSettings = existing.ListMetricDescriptorsSettings?.Clone();
            GetMetricDescriptorSettings = existing.GetMetricDescriptorSettings?.Clone();
            CreateMetricDescriptorSettings = existing.CreateMetricDescriptorSettings?.Clone();
            DeleteMetricDescriptorSettings = existing.DeleteMetricDescriptorSettings?.Clone();
            CreateTimeSeriesSettings = existing.CreateTimeSeriesSettings?.Clone();
        }

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="MetricServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="MetricServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="MetricServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>The "Default" retry backoff for <see cref="MetricServiceClient"/> RPC methods.</returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="MetricServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultRetryBackoff() => new BackoffSettings
        {
            Delay = TimeSpan.FromMilliseconds(100),
            DelayMultiplier = 1.3,
            MaxDelay = TimeSpan.FromMilliseconds(60000),
        };

        /// <summary>
        /// "Default" timeout backoff for <see cref="MetricServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>The "Default" timeout backoff for <see cref="MetricServiceClient"/> RPC methods.</returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="MetricServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 20000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings
        {
            Delay = TimeSpan.FromMilliseconds(20000),
            DelayMultiplier = 1.0,
            MaxDelay = TimeSpan.FromMilliseconds(20000),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <see cref="MetricServiceClient.ListMonitoredResourceDescriptors"/> and <see cref="MetricServiceClient.ListMonitoredResourceDescriptorsAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="MetricServiceClient.ListMonitoredResourceDescriptors"/> and
        /// <see cref="MetricServiceClient.ListMonitoredResourceDescriptorsAsync"/> <see cref="RetrySettings"/> are:
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
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings ListMonitoredResourceDescriptorsSettings { get; set; } = new CallSettings
        {
            Timing = CallTiming.FromRetry(new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = IdempotentRetryFilter,
                TotalExpiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
            }),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <see cref="MetricServiceClient.GetMonitoredResourceDescriptor"/> and <see cref="MetricServiceClient.GetMonitoredResourceDescriptorAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="MetricServiceClient.GetMonitoredResourceDescriptor"/> and
        /// <see cref="MetricServiceClient.GetMonitoredResourceDescriptorAsync"/> <see cref="RetrySettings"/> are:
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
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings GetMonitoredResourceDescriptorSettings { get; set; } = new CallSettings
        {
            Timing = CallTiming.FromRetry(new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = IdempotentRetryFilter,
                TotalExpiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
            }),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <see cref="MetricServiceClient.ListMetricDescriptors"/> and <see cref="MetricServiceClient.ListMetricDescriptorsAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="MetricServiceClient.ListMetricDescriptors"/> and
        /// <see cref="MetricServiceClient.ListMetricDescriptorsAsync"/> <see cref="RetrySettings"/> are:
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
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings ListMetricDescriptorsSettings { get; set; } = new CallSettings
        {
            Timing = CallTiming.FromRetry(new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = IdempotentRetryFilter,
                TotalExpiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
            }),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <see cref="MetricServiceClient.GetMetricDescriptor"/> and <see cref="MetricServiceClient.GetMetricDescriptorAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="MetricServiceClient.GetMetricDescriptor"/> and
        /// <see cref="MetricServiceClient.GetMetricDescriptorAsync"/> <see cref="RetrySettings"/> are:
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
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings GetMetricDescriptorSettings { get; set; } = new CallSettings
        {
            Timing = CallTiming.FromRetry(new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = IdempotentRetryFilter,
                TotalExpiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
            }),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <see cref="MetricServiceClient.CreateMetricDescriptor"/> and <see cref="MetricServiceClient.CreateMetricDescriptorAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="MetricServiceClient.CreateMetricDescriptor"/> and
        /// <see cref="MetricServiceClient.CreateMetricDescriptorAsync"/> <see cref="RetrySettings"/> are:
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
        public CallSettings CreateMetricDescriptorSettings { get; set; } = new CallSettings
        {
            Timing = CallTiming.FromRetry(new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = NonIdempotentRetryFilter,
                TotalExpiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
            }),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <see cref="MetricServiceClient.DeleteMetricDescriptor"/> and <see cref="MetricServiceClient.DeleteMetricDescriptorAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="MetricServiceClient.DeleteMetricDescriptor"/> and
        /// <see cref="MetricServiceClient.DeleteMetricDescriptorAsync"/> <see cref="RetrySettings"/> are:
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
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings DeleteMetricDescriptorSettings { get; set; } = new CallSettings
        {
            Timing = CallTiming.FromRetry(new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = IdempotentRetryFilter,
                TotalExpiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
            }),
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <see cref="MetricServiceClient.CreateTimeSeries"/> and <see cref="MetricServiceClient.CreateTimeSeriesAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="MetricServiceClient.CreateTimeSeries"/> and
        /// <see cref="MetricServiceClient.CreateTimeSeriesAsync"/> <see cref="RetrySettings"/> are:
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
        public CallSettings CreateTimeSeriesSettings { get; set; } = new CallSettings
        {
            Timing = CallTiming.FromRetry(new RetrySettings
            {
                RetryBackoff = GetDefaultRetryBackoff(),
                TimeoutBackoff = GetDefaultTimeoutBackoff(),
                RetryFilter = NonIdempotentRetryFilter,
                TotalExpiration = Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
            }),
        };


        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this set of MetricService settings.</returns>
        public MetricServiceSettings Clone() => new MetricServiceSettings(this);
    }

    /// <summary>
    /// MetricService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class MetricServiceClient
    {
        /// <summary>
        /// The default endpoint for the MetricService service, which is a host of "monitoring.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("monitoring.googleapis.com", 443);

        /// <summary>
        /// The default MetricService scopes
        /// </summary>
        /// <remarks>
        /// The default MetricService scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new string[] {
        });

        private static readonly ChannelPool s_channelPool = new ChannelPool(DefaultScopes);

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
        public static string FormatProjectName(string projectId) => ProjectTemplate.Expand(projectId);

        /// <summary>
        /// Path template for a metricDescriptorPath resource. Parameters:
        /// <list type="bullet">
        /// <item><description>project</description></item>
        /// <item><description>metric_descriptor_path</description></item>
        /// </list>
        /// </summary>
        public static PathTemplate MetricDescriptorPathTemplate { get; } = new PathTemplate("projects/{project}/metricDescriptors/{metric_descriptor_path=**}");

        /// <summary>
        /// Creates a metricDescriptorPath resource name from its component IDs.
        /// </summary>
        /// <param name="projectId">The project ID.</param>
        /// <param name="metric_descriptor_pathId">The metric_descriptor_path ID.</param>
        /// <returns>The full metricDescriptorPath resource name.</returns>
        public static string FormatMetricDescriptorPathName(string projectId, string metric_descriptor_pathId) => MetricDescriptorPathTemplate.Expand(projectId, metric_descriptor_pathId);

        /// <summary>
        /// Path template for a monitoredResourceDescriptor resource. Parameters:
        /// <list type="bullet">
        /// <item><description>project</description></item>
        /// <item><description>monitored_resource_descriptor</description></item>
        /// </list>
        /// </summary>
        public static PathTemplate MonitoredResourceDescriptorTemplate { get; } = new PathTemplate("projects/{project}/monitoredResourceDescriptors/{monitored_resource_descriptor}");

        /// <summary>
        /// Creates a monitoredResourceDescriptor resource name from its component IDs.
        /// </summary>
        /// <param name="projectId">The project ID.</param>
        /// <param name="monitored_resource_descriptorId">The monitored_resource_descriptor ID.</param>
        /// <returns>The full monitoredResourceDescriptor resource name.</returns>
        public static string FormatMonitoredResourceDescriptorName(string projectId, string monitored_resource_descriptorId) => MonitoredResourceDescriptorTemplate.Expand(projectId, monitored_resource_descriptorId);

        // Note: we could have parameterless overloads of Create and CreateAsync,
        // documented to just use the default endpoint, settings and credentials.
        // Pros:
        // - Might be more reassuring on first use
        // - Allows method group conversions
        // Con: overloads!

        /// <summary>
        /// Asynchronously creates a <see cref="MetricServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="MetricServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="MetricServiceClient"/>.</returns>
        public static async Task<MetricServiceClient> CreateAsync(ServiceEndpoint endpoint = null, MetricServiceSettings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="MetricServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="MetricServiceSettings"/>.</param>
        /// <returns>The created <see cref="MetricServiceClient"/>.</returns>
        public static MetricServiceClient Create(ServiceEndpoint endpoint = null, MetricServiceSettings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="MetricServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="MetricServiceSettings"/>.</param>
        /// <returns>The created <see cref="MetricServiceClient"/>.</returns>
        public static MetricServiceClient Create(Channel channel, MetricServiceSettings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            MetricService.MetricServiceClient grpcClient = new MetricService.MetricServiceClient(channel);
            return new MetricServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, MetricServiceSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, MetricServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, MetricServiceSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, MetricServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying GRPC MetricService client.
        /// </summary>
        public virtual MetricService.MetricServiceClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Lists monitored resource descriptors that match a filter. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="filter"></param>
        /// <param name="pageToken">The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.</param>
        /// <param name="pageSize">The size of page to request.
        /// The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of MonitoredResourceDescriptor resources.</returns>
        public virtual IPagedAsyncEnumerable<ListMonitoredResourceDescriptorsResponse, MonitoredResourceDescriptor> ListMonitoredResourceDescriptorsAsync(
            string name,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists monitored resource descriptors that match a filter. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="filter"></param>
        /// <param name="pageToken">The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.</param>
        /// <param name="pageSize">The size of page to request.
        /// The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of MonitoredResourceDescriptor resources.</returns>
        public virtual IPagedEnumerable<ListMonitoredResourceDescriptorsResponse, MonitoredResourceDescriptor> ListMonitoredResourceDescriptors(
            string name,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a single monitored resource descriptor. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<MonitoredResourceDescriptor> GetMonitoredResourceDescriptorAsync(
            string name,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a single monitored resource descriptor. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<MonitoredResourceDescriptor> GetMonitoredResourceDescriptorAsync(
            string name,
            CancellationToken cancellationToken) => GetMonitoredResourceDescriptorAsync(
                name,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Gets a single monitored resource descriptor. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MonitoredResourceDescriptor GetMonitoredResourceDescriptor(
            string name,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists metric descriptors that match a filter. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="filter"></param>
        /// <param name="pageToken">The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.</param>
        /// <param name="pageSize">The size of page to request.
        /// The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of MetricDescriptor resources.</returns>
        public virtual IPagedAsyncEnumerable<ListMetricDescriptorsResponse, MetricDescriptor> ListMetricDescriptorsAsync(
            string name,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists metric descriptors that match a filter. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="filter"></param>
        /// <param name="pageToken">The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.</param>
        /// <param name="pageSize">The size of page to request.
        /// The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of MetricDescriptor resources.</returns>
        public virtual IPagedEnumerable<ListMetricDescriptorsResponse, MetricDescriptor> ListMetricDescriptors(
            string name,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a single metric descriptor. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<MetricDescriptor> GetMetricDescriptorAsync(
            string name,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a single metric descriptor. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<MetricDescriptor> GetMetricDescriptorAsync(
            string name,
            CancellationToken cancellationToken) => GetMetricDescriptorAsync(
                name,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Gets a single metric descriptor. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MetricDescriptor GetMetricDescriptor(
            string name,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="metricDescriptor"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<MetricDescriptor> CreateMetricDescriptorAsync(
            string name,
            MetricDescriptor metricDescriptor,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="metricDescriptor"></param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<MetricDescriptor> CreateMetricDescriptorAsync(
            string name,
            MetricDescriptor metricDescriptor,
            CancellationToken cancellationToken) => CreateMetricDescriptorAsync(
                name,
                metricDescriptor,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="metricDescriptor"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MetricDescriptor CreateMetricDescriptor(
            string name,
            MetricDescriptor metricDescriptor,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task DeleteMetricDescriptorAsync(
            string name,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task DeleteMetricDescriptorAsync(
            string name,
            CancellationToken cancellationToken) => DeleteMetricDescriptorAsync(
                name,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteMetricDescriptor(
            string name,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="timeSeries"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task CreateTimeSeriesAsync(
            string name,
            IEnumerable<TimeSeries> timeSeries,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="timeSeries"></param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task CreateTimeSeriesAsync(
            string name,
            IEnumerable<TimeSeries> timeSeries,
            CancellationToken cancellationToken) => CreateTimeSeriesAsync(
                name,
                timeSeries,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="timeSeries"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CreateTimeSeries(
            string name,
            IEnumerable<TimeSeries> timeSeries,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    public sealed partial class MetricServiceClientImpl : MetricServiceClient
    {
        private readonly ClientHelper _clientHelper;
        private readonly ApiCall<ListMonitoredResourceDescriptorsRequest, ListMonitoredResourceDescriptorsResponse> _callListMonitoredResourceDescriptors;
        private readonly ApiCall<GetMonitoredResourceDescriptorRequest, MonitoredResourceDescriptor> _callGetMonitoredResourceDescriptor;
        private readonly ApiCall<ListMetricDescriptorsRequest, ListMetricDescriptorsResponse> _callListMetricDescriptors;
        private readonly ApiCall<GetMetricDescriptorRequest, MetricDescriptor> _callGetMetricDescriptor;
        private readonly ApiCall<CreateMetricDescriptorRequest, MetricDescriptor> _callCreateMetricDescriptor;
        private readonly ApiCall<DeleteMetricDescriptorRequest, Empty> _callDeleteMetricDescriptor;
        private readonly ApiCall<CreateTimeSeriesRequest, Empty> _callCreateTimeSeries;

        public MetricServiceClientImpl(MetricService.MetricServiceClient grpcClient, MetricServiceSettings settings)
        {
            this.GrpcClient = grpcClient;
            MetricServiceSettings effectiveSettings = settings ?? MetricServiceSettings.GetDefault();
            _clientHelper = new ClientHelper(effectiveSettings);
            _callListMonitoredResourceDescriptors = _clientHelper.BuildApiCall<ListMonitoredResourceDescriptorsRequest, ListMonitoredResourceDescriptorsResponse>(
                GrpcClient.ListMonitoredResourceDescriptorsAsync, GrpcClient.ListMonitoredResourceDescriptors, effectiveSettings.ListMonitoredResourceDescriptorsSettings);
            _callGetMonitoredResourceDescriptor = _clientHelper.BuildApiCall<GetMonitoredResourceDescriptorRequest, MonitoredResourceDescriptor>(
                GrpcClient.GetMonitoredResourceDescriptorAsync, GrpcClient.GetMonitoredResourceDescriptor, effectiveSettings.GetMonitoredResourceDescriptorSettings);
            _callListMetricDescriptors = _clientHelper.BuildApiCall<ListMetricDescriptorsRequest, ListMetricDescriptorsResponse>(
                GrpcClient.ListMetricDescriptorsAsync, GrpcClient.ListMetricDescriptors, effectiveSettings.ListMetricDescriptorsSettings);
            _callGetMetricDescriptor = _clientHelper.BuildApiCall<GetMetricDescriptorRequest, MetricDescriptor>(
                GrpcClient.GetMetricDescriptorAsync, GrpcClient.GetMetricDescriptor, effectiveSettings.GetMetricDescriptorSettings);
            _callCreateMetricDescriptor = _clientHelper.BuildApiCall<CreateMetricDescriptorRequest, MetricDescriptor>(
                GrpcClient.CreateMetricDescriptorAsync, GrpcClient.CreateMetricDescriptor, effectiveSettings.CreateMetricDescriptorSettings);
            _callDeleteMetricDescriptor = _clientHelper.BuildApiCall<DeleteMetricDescriptorRequest, Empty>(
                GrpcClient.DeleteMetricDescriptorAsync, GrpcClient.DeleteMetricDescriptor, effectiveSettings.DeleteMetricDescriptorSettings);
            _callCreateTimeSeries = _clientHelper.BuildApiCall<CreateTimeSeriesRequest, Empty>(
                GrpcClient.CreateTimeSeriesAsync, GrpcClient.CreateTimeSeries, effectiveSettings.CreateTimeSeriesSettings);
        }

        public override MetricService.MetricServiceClient GrpcClient { get; }

        /// <summary>
        /// Lists monitored resource descriptors that match a filter. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="filter"></param>
        /// <param name="pageToken">The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.</param>
        /// <param name="pageSize">The size of page to request.
        /// The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of MonitoredResourceDescriptor resources.</returns>
        public override IPagedAsyncEnumerable<ListMonitoredResourceDescriptorsResponse, MonitoredResourceDescriptor> ListMonitoredResourceDescriptorsAsync(
            string name,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => new PagedAsyncEnumerable<ListMonitoredResourceDescriptorsRequest, ListMonitoredResourceDescriptorsResponse, MonitoredResourceDescriptor>(
                _callListMonitoredResourceDescriptors,
                new ListMonitoredResourceDescriptorsRequest
                {
                    Name = name,
                    Filter = filter,
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists monitored resource descriptors that match a filter. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="filter"></param>
        /// <param name="pageToken">The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.</param>
        /// <param name="pageSize">The size of page to request.
        /// The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of MonitoredResourceDescriptor resources.</returns>
        public override IPagedEnumerable<ListMonitoredResourceDescriptorsResponse, MonitoredResourceDescriptor> ListMonitoredResourceDescriptors(
            string name,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => new PagedEnumerable<ListMonitoredResourceDescriptorsRequest, ListMonitoredResourceDescriptorsResponse, MonitoredResourceDescriptor>(
                _callListMonitoredResourceDescriptors,
                new ListMonitoredResourceDescriptorsRequest
                {
                    Name = name,
                    Filter = filter,
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Gets a single monitored resource descriptor. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<MonitoredResourceDescriptor> GetMonitoredResourceDescriptorAsync(
            string name,
            CallSettings callSettings = null) => _callGetMonitoredResourceDescriptor.Async(
                new GetMonitoredResourceDescriptorRequest
                {
                    Name = name,
                },
                callSettings);

        /// <summary>
        /// Gets a single monitored resource descriptor. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MonitoredResourceDescriptor GetMonitoredResourceDescriptor(
            string name,
            CallSettings callSettings = null) => _callGetMonitoredResourceDescriptor.Sync(
                new GetMonitoredResourceDescriptorRequest
                {
                    Name = name,
                },
                callSettings);

        /// <summary>
        /// Lists metric descriptors that match a filter. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="filter"></param>
        /// <param name="pageToken">The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.</param>
        /// <param name="pageSize">The size of page to request.
        /// The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of MetricDescriptor resources.</returns>
        public override IPagedAsyncEnumerable<ListMetricDescriptorsResponse, MetricDescriptor> ListMetricDescriptorsAsync(
            string name,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => new PagedAsyncEnumerable<ListMetricDescriptorsRequest, ListMetricDescriptorsResponse, MetricDescriptor>(
                _callListMetricDescriptors,
                new ListMetricDescriptorsRequest
                {
                    Name = name,
                    Filter = filter,
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists metric descriptors that match a filter. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="filter"></param>
        /// <param name="pageToken">The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.</param>
        /// <param name="pageSize">The size of page to request.
        /// The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of MetricDescriptor resources.</returns>
        public override IPagedEnumerable<ListMetricDescriptorsResponse, MetricDescriptor> ListMetricDescriptors(
            string name,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => new PagedEnumerable<ListMetricDescriptorsRequest, ListMetricDescriptorsResponse, MetricDescriptor>(
                _callListMetricDescriptors,
                new ListMetricDescriptorsRequest
                {
                    Name = name,
                    Filter = filter,
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Gets a single metric descriptor. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<MetricDescriptor> GetMetricDescriptorAsync(
            string name,
            CallSettings callSettings = null) => _callGetMetricDescriptor.Async(
                new GetMetricDescriptorRequest
                {
                    Name = name,
                },
                callSettings);

        /// <summary>
        /// Gets a single metric descriptor. This method does not require a Stackdriver account.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MetricDescriptor GetMetricDescriptor(
            string name,
            CallSettings callSettings = null) => _callGetMetricDescriptor.Sync(
                new GetMetricDescriptorRequest
                {
                    Name = name,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="metricDescriptor"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<MetricDescriptor> CreateMetricDescriptorAsync(
            string name,
            MetricDescriptor metricDescriptor,
            CallSettings callSettings = null) => _callCreateMetricDescriptor.Async(
                new CreateMetricDescriptorRequest
                {
                    Name = name,
                    MetricDescriptor = metricDescriptor,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="metricDescriptor"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MetricDescriptor CreateMetricDescriptor(
            string name,
            MetricDescriptor metricDescriptor,
            CallSettings callSettings = null) => _callCreateMetricDescriptor.Sync(
                new CreateMetricDescriptorRequest
                {
                    Name = name,
                    MetricDescriptor = metricDescriptor,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task DeleteMetricDescriptorAsync(
            string name,
            CallSettings callSettings = null) => _callDeleteMetricDescriptor.Async(
                new DeleteMetricDescriptorRequest
                {
                    Name = name,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteMetricDescriptor(
            string name,
            CallSettings callSettings = null) => _callDeleteMetricDescriptor.Sync(
                new DeleteMetricDescriptorRequest
                {
                    Name = name,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="timeSeries"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task CreateTimeSeriesAsync(
            string name,
            IEnumerable<TimeSeries> timeSeries,
            CallSettings callSettings = null) => _callCreateTimeSeries.Async(
                new CreateTimeSeriesRequest
                {
                    Name = name,
                    TimeSeries = { timeSeries },
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="name"></param>
        /// <param name="timeSeries"></param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void CreateTimeSeries(
            string name,
            IEnumerable<TimeSeries> timeSeries,
            CallSettings callSettings = null) => _callCreateTimeSeries.Sync(
                new CreateTimeSeriesRequest
                {
                    Name = name,
                    TimeSeries = { timeSeries },
                },
                callSettings);

    }

    // Partial classes to enable page-streaming

    public partial class ListMonitoredResourceDescriptorsRequest : IPageRequest { }
    public partial class ListMonitoredResourceDescriptorsResponse : IPageResponse<MonitoredResourceDescriptor>
    {
        public IEnumerator<MonitoredResourceDescriptor> GetEnumerator() => ResourceDescriptors.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListMetricDescriptorsRequest : IPageRequest { }
    public partial class ListMetricDescriptorsResponse : IPageResponse<MetricDescriptor>
    {
        public IEnumerator<MetricDescriptor> GetEnumerator() => MetricDescriptors.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTimeSeriesRequest : IPageRequest { }
    public partial class ListTimeSeriesResponse : IPageResponse<TimeSeries>
    {
        public IEnumerator<TimeSeries> GetEnumerator() => TimeSeries.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

}