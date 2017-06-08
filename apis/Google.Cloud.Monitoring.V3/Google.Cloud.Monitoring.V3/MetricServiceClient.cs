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

namespace Google.Cloud.Monitoring.V3
{
    /// <summary>
    /// Settings for a <see cref="MetricServiceClient"/>.
    /// </summary>
    public sealed partial class MetricServiceSettings : ServiceSettingsBase
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
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
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
        public static BackoffSettings GetDefaultRetryBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(100),
            maxDelay: TimeSpan.FromMilliseconds(60000),
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
        public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(20000),
            maxDelay: TimeSpan.FromMilliseconds(20000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricServiceClient.ListMonitoredResourceDescriptors</c> and <c>MetricServiceClient.ListMonitoredResourceDescriptorsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>MetricServiceClient.ListMonitoredResourceDescriptors</c> and
        /// <c>MetricServiceClient.ListMonitoredResourceDescriptorsAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings ListMonitoredResourceDescriptorsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricServiceClient.GetMonitoredResourceDescriptor</c> and <c>MetricServiceClient.GetMonitoredResourceDescriptorAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>MetricServiceClient.GetMonitoredResourceDescriptor</c> and
        /// <c>MetricServiceClient.GetMonitoredResourceDescriptorAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings GetMonitoredResourceDescriptorSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricServiceClient.ListMetricDescriptors</c> and <c>MetricServiceClient.ListMetricDescriptorsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>MetricServiceClient.ListMetricDescriptors</c> and
        /// <c>MetricServiceClient.ListMetricDescriptorsAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings ListMetricDescriptorsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricServiceClient.GetMetricDescriptor</c> and <c>MetricServiceClient.GetMetricDescriptorAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>MetricServiceClient.GetMetricDescriptor</c> and
        /// <c>MetricServiceClient.GetMetricDescriptorAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings GetMetricDescriptorSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricServiceClient.CreateMetricDescriptor</c> and <c>MetricServiceClient.CreateMetricDescriptorAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>MetricServiceClient.CreateMetricDescriptor</c> and
        /// <c>MetricServiceClient.CreateMetricDescriptorAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings CreateMetricDescriptorSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricServiceClient.DeleteMetricDescriptor</c> and <c>MetricServiceClient.DeleteMetricDescriptorAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>MetricServiceClient.DeleteMetricDescriptor</c> and
        /// <c>MetricServiceClient.DeleteMetricDescriptorAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings DeleteMetricDescriptorSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricServiceClient.ListTimeSeries</c> and <c>MetricServiceClient.ListTimeSeriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>MetricServiceClient.ListTimeSeries</c> and
        /// <c>MetricServiceClient.ListTimeSeriesAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings ListTimeSeriesSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MetricServiceClient.CreateTimeSeries</c> and <c>MetricServiceClient.CreateTimeSeriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>MetricServiceClient.CreateTimeSeries</c> and
        /// <c>MetricServiceClient.CreateTimeSeriesAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings CreateTimeSeriesSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="MetricServiceSettings"/> object.</returns>
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
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/monitoring",
            "https://www.googleapis.com/auth/monitoring.read",
            "https://www.googleapis.com/auth/monitoring.write",
        });

        private static readonly ChannelPool s_channelPool = new ChannelPool(DefaultScopes);

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
        /// The underlying gRPC MetricService client.
        /// </summary>
        public virtual MetricService.MetricServiceClient GrpcClient
        {
            get { throw new NotImplementedException(); }
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
        /// A pageable asynchronous sequence of <see cref="MonitoredResourceDescriptor"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListMonitoredResourceDescriptorsResponse, MonitoredResourceDescriptor> ListMonitoredResourceDescriptorsAsync(
            ProjectName name,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListMonitoredResourceDescriptorsAsync(
                new ListMonitoredResourceDescriptorsRequest
                {
                    ProjectName = GaxPreconditions.CheckNotNull(name, nameof(name)),
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
        /// A pageable sequence of <see cref="MonitoredResourceDescriptor"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListMonitoredResourceDescriptorsResponse, MonitoredResourceDescriptor> ListMonitoredResourceDescriptors(
            ProjectName name,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListMonitoredResourceDescriptors(
                new ListMonitoredResourceDescriptorsRequest
                {
                    ProjectName = GaxPreconditions.CheckNotNull(name, nameof(name)),
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
        /// A pageable asynchronous sequence of <see cref="MonitoredResourceDescriptor"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListMonitoredResourceDescriptorsResponse, MonitoredResourceDescriptor> ListMonitoredResourceDescriptorsAsync(
            ListMonitoredResourceDescriptorsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
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
        /// A pageable sequence of <see cref="MonitoredResourceDescriptor"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListMonitoredResourceDescriptorsResponse, MonitoredResourceDescriptor> ListMonitoredResourceDescriptors(
            ListMonitoredResourceDescriptorsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
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
        public virtual Task<MonitoredResourceDescriptor> GetMonitoredResourceDescriptorAsync(
            MonitoredResourceDescriptorName name,
            CallSettings callSettings = null) => GetMonitoredResourceDescriptorAsync(
                new GetMonitoredResourceDescriptorRequest
                {
                    MonitoredResourceDescriptorName = GaxPreconditions.CheckNotNull(name, nameof(name)),
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
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<MonitoredResourceDescriptor> GetMonitoredResourceDescriptorAsync(
            MonitoredResourceDescriptorName name,
            CancellationToken cancellationToken) => GetMonitoredResourceDescriptorAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual MonitoredResourceDescriptor GetMonitoredResourceDescriptor(
            MonitoredResourceDescriptorName name,
            CallSettings callSettings = null) => GetMonitoredResourceDescriptor(
                new GetMonitoredResourceDescriptorRequest
                {
                    MonitoredResourceDescriptorName = GaxPreconditions.CheckNotNull(name, nameof(name)),
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
        public virtual Task<MonitoredResourceDescriptor> GetMonitoredResourceDescriptorAsync(
            GetMonitoredResourceDescriptorRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
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
        public virtual MonitoredResourceDescriptor GetMonitoredResourceDescriptor(
            GetMonitoredResourceDescriptorRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
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
        /// A pageable asynchronous sequence of <see cref="MetricDescriptor"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListMetricDescriptorsResponse, MetricDescriptor> ListMetricDescriptorsAsync(
            ProjectName name,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListMetricDescriptorsAsync(
                new ListMetricDescriptorsRequest
                {
                    ProjectName = GaxPreconditions.CheckNotNull(name, nameof(name)),
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
        /// A pageable sequence of <see cref="MetricDescriptor"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListMetricDescriptorsResponse, MetricDescriptor> ListMetricDescriptors(
            ProjectName name,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListMetricDescriptors(
                new ListMetricDescriptorsRequest
                {
                    ProjectName = GaxPreconditions.CheckNotNull(name, nameof(name)),
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
        /// A pageable asynchronous sequence of <see cref="MetricDescriptor"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListMetricDescriptorsResponse, MetricDescriptor> ListMetricDescriptorsAsync(
            ListMetricDescriptorsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
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
        /// A pageable sequence of <see cref="MetricDescriptor"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListMetricDescriptorsResponse, MetricDescriptor> ListMetricDescriptors(
            ListMetricDescriptorsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
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
        public virtual Task<MetricDescriptor> GetMetricDescriptorAsync(
            MetricDescriptorName name,
            CallSettings callSettings = null) => GetMetricDescriptorAsync(
                new GetMetricDescriptorRequest
                {
                    MetricDescriptorName = GaxPreconditions.CheckNotNull(name, nameof(name)),
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
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<MetricDescriptor> GetMetricDescriptorAsync(
            MetricDescriptorName name,
            CancellationToken cancellationToken) => GetMetricDescriptorAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual MetricDescriptor GetMetricDescriptor(
            MetricDescriptorName name,
            CallSettings callSettings = null) => GetMetricDescriptor(
                new GetMetricDescriptorRequest
                {
                    MetricDescriptorName = GaxPreconditions.CheckNotNull(name, nameof(name)),
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
        public virtual Task<MetricDescriptor> GetMetricDescriptorAsync(
            GetMetricDescriptorRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
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
        public virtual MetricDescriptor GetMetricDescriptor(
            GetMetricDescriptorRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
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
        public virtual Task<MetricDescriptor> CreateMetricDescriptorAsync(
            ProjectName name,
            MetricDescriptor metricDescriptor,
            CallSettings callSettings = null) => CreateMetricDescriptorAsync(
                new CreateMetricDescriptorRequest
                {
                    ProjectName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    MetricDescriptor = GaxPreconditions.CheckNotNull(metricDescriptor, nameof(metricDescriptor)),
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
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<MetricDescriptor> CreateMetricDescriptorAsync(
            ProjectName name,
            MetricDescriptor metricDescriptor,
            CancellationToken cancellationToken) => CreateMetricDescriptorAsync(
                name,
                metricDescriptor,
                CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual MetricDescriptor CreateMetricDescriptor(
            ProjectName name,
            MetricDescriptor metricDescriptor,
            CallSettings callSettings = null) => CreateMetricDescriptor(
                new CreateMetricDescriptorRequest
                {
                    ProjectName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    MetricDescriptor = GaxPreconditions.CheckNotNull(metricDescriptor, nameof(metricDescriptor)),
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
        public virtual Task<MetricDescriptor> CreateMetricDescriptorAsync(
            CreateMetricDescriptorRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
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
        public virtual MetricDescriptor CreateMetricDescriptor(
            CreateMetricDescriptorRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
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
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteMetricDescriptorAsync(
            MetricDescriptorName name,
            CallSettings callSettings = null) => DeleteMetricDescriptorAsync(
                new DeleteMetricDescriptorRequest
                {
                    MetricDescriptorName = GaxPreconditions.CheckNotNull(name, nameof(name)),
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
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteMetricDescriptorAsync(
            MetricDescriptorName name,
            CancellationToken cancellationToken) => DeleteMetricDescriptorAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

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
        /// The RPC response.
        /// </returns>
        public virtual void DeleteMetricDescriptor(
            MetricDescriptorName name,
            CallSettings callSettings = null) => DeleteMetricDescriptor(
                new DeleteMetricDescriptorRequest
                {
                    MetricDescriptorName = GaxPreconditions.CheckNotNull(name, nameof(name)),
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
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteMetricDescriptorAsync(
            DeleteMetricDescriptorRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
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
        /// The RPC response.
        /// </returns>
        public virtual void DeleteMetricDescriptor(
            DeleteMetricDescriptorRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
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
        ///         metric.label.instance_name = "my-instance-name"
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
        public virtual PagedAsyncEnumerable<ListTimeSeriesResponse, TimeSeries> ListTimeSeriesAsync(
            ProjectName name,
            string filter,
            TimeInterval interval,
            ListTimeSeriesRequest.Types.TimeSeriesView view,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListTimeSeriesAsync(
                new ListTimeSeriesRequest
                {
                    ProjectName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Filter = GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                    Interval = GaxPreconditions.CheckNotNull(interval, nameof(interval)),
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
        ///         metric.label.instance_name = "my-instance-name"
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
        public virtual PagedEnumerable<ListTimeSeriesResponse, TimeSeries> ListTimeSeries(
            ProjectName name,
            string filter,
            TimeInterval interval,
            ListTimeSeriesRequest.Types.TimeSeriesView view,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListTimeSeries(
                new ListTimeSeriesRequest
                {
                    ProjectName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Filter = GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
                    Interval = GaxPreconditions.CheckNotNull(interval, nameof(interval)),
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
        public virtual PagedAsyncEnumerable<ListTimeSeriesResponse, TimeSeries> ListTimeSeriesAsync(
            ListTimeSeriesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
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
        public virtual PagedEnumerable<ListTimeSeriesResponse, TimeSeries> ListTimeSeries(
            ListTimeSeriesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
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
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task CreateTimeSeriesAsync(
            ProjectName name,
            IEnumerable<TimeSeries> timeSeries,
            CallSettings callSettings = null) => CreateTimeSeriesAsync(
                new CreateTimeSeriesRequest
                {
                    ProjectName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    TimeSeries = { GaxPreconditions.CheckNotNull(timeSeries, nameof(timeSeries)) },
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
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task CreateTimeSeriesAsync(
            ProjectName name,
            IEnumerable<TimeSeries> timeSeries,
            CancellationToken cancellationToken) => CreateTimeSeriesAsync(
                name,
                timeSeries,
                CallSettings.FromCancellationToken(cancellationToken));

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
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual void CreateTimeSeries(
            ProjectName name,
            IEnumerable<TimeSeries> timeSeries,
            CallSettings callSettings = null) => CreateTimeSeries(
                new CreateTimeSeriesRequest
                {
                    ProjectName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    TimeSeries = { GaxPreconditions.CheckNotNull(timeSeries, nameof(timeSeries)) },
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
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task CreateTimeSeriesAsync(
            CreateTimeSeriesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
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
        /// The RPC response.
        /// </returns>
        public virtual void CreateTimeSeries(
            CreateTimeSeriesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    /// <summary>
    /// MetricService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class MetricServiceClientImpl : MetricServiceClient
    {
        private readonly ApiCall<ListMonitoredResourceDescriptorsRequest, ListMonitoredResourceDescriptorsResponse> _callListMonitoredResourceDescriptors;
        private readonly ApiCall<GetMonitoredResourceDescriptorRequest, MonitoredResourceDescriptor> _callGetMonitoredResourceDescriptor;
        private readonly ApiCall<ListMetricDescriptorsRequest, ListMetricDescriptorsResponse> _callListMetricDescriptors;
        private readonly ApiCall<GetMetricDescriptorRequest, MetricDescriptor> _callGetMetricDescriptor;
        private readonly ApiCall<CreateMetricDescriptorRequest, MetricDescriptor> _callCreateMetricDescriptor;
        private readonly ApiCall<DeleteMetricDescriptorRequest, Empty> _callDeleteMetricDescriptor;
        private readonly ApiCall<ListTimeSeriesRequest, ListTimeSeriesResponse> _callListTimeSeries;
        private readonly ApiCall<CreateTimeSeriesRequest, Empty> _callCreateTimeSeries;

        /// <summary>
        /// Constructs a client wrapper for the MetricService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="MetricServiceSettings"/> used within this client </param>
        public MetricServiceClientImpl(MetricService.MetricServiceClient grpcClient, MetricServiceSettings settings)
        {
            this.GrpcClient = grpcClient;
            MetricServiceSettings effectiveSettings = settings ?? MetricServiceSettings.GetDefault();
            ClientHelper clientHelper = new ClientHelper(effectiveSettings);
            _callListMonitoredResourceDescriptors = clientHelper.BuildApiCall<ListMonitoredResourceDescriptorsRequest, ListMonitoredResourceDescriptorsResponse>(
                GrpcClient.ListMonitoredResourceDescriptorsAsync, GrpcClient.ListMonitoredResourceDescriptors, effectiveSettings.ListMonitoredResourceDescriptorsSettings);
            _callGetMonitoredResourceDescriptor = clientHelper.BuildApiCall<GetMonitoredResourceDescriptorRequest, MonitoredResourceDescriptor>(
                GrpcClient.GetMonitoredResourceDescriptorAsync, GrpcClient.GetMonitoredResourceDescriptor, effectiveSettings.GetMonitoredResourceDescriptorSettings);
            _callListMetricDescriptors = clientHelper.BuildApiCall<ListMetricDescriptorsRequest, ListMetricDescriptorsResponse>(
                GrpcClient.ListMetricDescriptorsAsync, GrpcClient.ListMetricDescriptors, effectiveSettings.ListMetricDescriptorsSettings);
            _callGetMetricDescriptor = clientHelper.BuildApiCall<GetMetricDescriptorRequest, MetricDescriptor>(
                GrpcClient.GetMetricDescriptorAsync, GrpcClient.GetMetricDescriptor, effectiveSettings.GetMetricDescriptorSettings);
            _callCreateMetricDescriptor = clientHelper.BuildApiCall<CreateMetricDescriptorRequest, MetricDescriptor>(
                GrpcClient.CreateMetricDescriptorAsync, GrpcClient.CreateMetricDescriptor, effectiveSettings.CreateMetricDescriptorSettings);
            _callDeleteMetricDescriptor = clientHelper.BuildApiCall<DeleteMetricDescriptorRequest, Empty>(
                GrpcClient.DeleteMetricDescriptorAsync, GrpcClient.DeleteMetricDescriptor, effectiveSettings.DeleteMetricDescriptorSettings);
            _callListTimeSeries = clientHelper.BuildApiCall<ListTimeSeriesRequest, ListTimeSeriesResponse>(
                GrpcClient.ListTimeSeriesAsync, GrpcClient.ListTimeSeries, effectiveSettings.ListTimeSeriesSettings);
            _callCreateTimeSeries = clientHelper.BuildApiCall<CreateTimeSeriesRequest, Empty>(
                GrpcClient.CreateTimeSeriesAsync, GrpcClient.CreateTimeSeries, effectiveSettings.CreateTimeSeriesSettings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void OnConstruction(MetricService.MetricServiceClient grpcClient, MetricServiceSettings effectiveSettings, ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC MetricService client.
        /// </summary>
        public override MetricService.MetricServiceClient GrpcClient { get; }

        // Partial modifier methods contain '_' to ensure no name conflicts with RPC methods.
        partial void Modify_ListMonitoredResourceDescriptorsRequest(ref ListMonitoredResourceDescriptorsRequest request, ref CallSettings settings);
        partial void Modify_GetMonitoredResourceDescriptorRequest(ref GetMonitoredResourceDescriptorRequest request, ref CallSettings settings);
        partial void Modify_ListMetricDescriptorsRequest(ref ListMetricDescriptorsRequest request, ref CallSettings settings);
        partial void Modify_GetMetricDescriptorRequest(ref GetMetricDescriptorRequest request, ref CallSettings settings);
        partial void Modify_CreateMetricDescriptorRequest(ref CreateMetricDescriptorRequest request, ref CallSettings settings);
        partial void Modify_DeleteMetricDescriptorRequest(ref DeleteMetricDescriptorRequest request, ref CallSettings settings);
        partial void Modify_ListTimeSeriesRequest(ref ListTimeSeriesRequest request, ref CallSettings settings);
        partial void Modify_CreateTimeSeriesRequest(ref CreateTimeSeriesRequest request, ref CallSettings settings);

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
        /// Lists monitored resource descriptors that match a filter. This method does not require a Stackdriver account.
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
        public override Task<MonitoredResourceDescriptor> GetMonitoredResourceDescriptorAsync(
            GetMonitoredResourceDescriptorRequest request,
            CallSettings callSettings = null)
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
        public override MonitoredResourceDescriptor GetMonitoredResourceDescriptor(
            GetMonitoredResourceDescriptorRequest request,
            CallSettings callSettings = null)
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
        /// A pageable asynchronous sequence of <see cref="MetricDescriptor"/> resources.
        /// </returns>
        public override PagedAsyncEnumerable<ListMetricDescriptorsResponse, MetricDescriptor> ListMetricDescriptorsAsync(
            ListMetricDescriptorsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListMetricDescriptorsRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<ListMetricDescriptorsRequest, ListMetricDescriptorsResponse, MetricDescriptor>(_callListMetricDescriptors, request, callSettings);
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
        /// A pageable sequence of <see cref="MetricDescriptor"/> resources.
        /// </returns>
        public override PagedEnumerable<ListMetricDescriptorsResponse, MetricDescriptor> ListMetricDescriptors(
            ListMetricDescriptorsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListMetricDescriptorsRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<ListMetricDescriptorsRequest, ListMetricDescriptorsResponse, MetricDescriptor>(_callListMetricDescriptors, request, callSettings);
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
        public override Task<MetricDescriptor> GetMetricDescriptorAsync(
            GetMetricDescriptorRequest request,
            CallSettings callSettings = null)
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
        public override MetricDescriptor GetMetricDescriptor(
            GetMetricDescriptorRequest request,
            CallSettings callSettings = null)
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
        public override Task<MetricDescriptor> CreateMetricDescriptorAsync(
            CreateMetricDescriptorRequest request,
            CallSettings callSettings = null)
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
        public override MetricDescriptor CreateMetricDescriptor(
            CreateMetricDescriptorRequest request,
            CallSettings callSettings = null)
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
        /// A Task containing the RPC response.
        /// </returns>
        public override Task DeleteMetricDescriptorAsync(
            DeleteMetricDescriptorRequest request,
            CallSettings callSettings = null)
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
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override void DeleteMetricDescriptor(
            DeleteMetricDescriptorRequest request,
            CallSettings callSettings = null)
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
        public override PagedAsyncEnumerable<ListTimeSeriesResponse, TimeSeries> ListTimeSeriesAsync(
            ListTimeSeriesRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListTimeSeriesRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<ListTimeSeriesRequest, ListTimeSeriesResponse, TimeSeries>(_callListTimeSeries, request, callSettings);
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
        public override PagedEnumerable<ListTimeSeriesResponse, TimeSeries> ListTimeSeries(
            ListTimeSeriesRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListTimeSeriesRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<ListTimeSeriesRequest, ListTimeSeriesResponse, TimeSeries>(_callListTimeSeries, request, callSettings);
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
        /// A Task containing the RPC response.
        /// </returns>
        public override Task CreateTimeSeriesAsync(
            CreateTimeSeriesRequest request,
            CallSettings callSettings = null)
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
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override void CreateTimeSeries(
            CreateTimeSeriesRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateTimeSeriesRequest(ref request, ref callSettings);
            _callCreateTimeSeries.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

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

    public partial class ListMetricDescriptorsRequest : IPageRequest { }
    public partial class ListMetricDescriptorsResponse : IPageResponse<MetricDescriptor>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<MetricDescriptor> GetEnumerator() => MetricDescriptors.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTimeSeriesRequest : IPageRequest { }
    public partial class ListTimeSeriesResponse : IPageResponse<TimeSeries>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<TimeSeries> GetEnumerator() => TimeSeries.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

}
