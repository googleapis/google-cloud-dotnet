// Copyright 2018 Google LLC
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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Protobuf;
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
    /// Settings for a <see cref="NotificationChannelServiceClient"/>.
    /// </summary>
    public sealed partial class NotificationChannelServiceSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="NotificationChannelServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="NotificationChannelServiceSettings"/>.
        /// </returns>
        public static NotificationChannelServiceSettings GetDefault() => new NotificationChannelServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="NotificationChannelServiceSettings"/> object with default settings.
        /// </summary>
        public NotificationChannelServiceSettings() { }

        private NotificationChannelServiceSettings(NotificationChannelServiceSettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListNotificationChannelDescriptorsSettings = existing.ListNotificationChannelDescriptorsSettings;
            GetNotificationChannelDescriptorSettings = existing.GetNotificationChannelDescriptorSettings;
            ListNotificationChannelsSettings = existing.ListNotificationChannelsSettings;
            GetNotificationChannelSettings = existing.GetNotificationChannelSettings;
            CreateNotificationChannelSettings = existing.CreateNotificationChannelSettings;
            UpdateNotificationChannelSettings = existing.UpdateNotificationChannelSettings;
            DeleteNotificationChannelSettings = existing.DeleteNotificationChannelSettings;
            OnCopy(existing);
        }

        partial void OnCopy(NotificationChannelServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="NotificationChannelServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="NotificationChannelServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="NotificationChannelServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="NotificationChannelServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="NotificationChannelServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="NotificationChannelServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="NotificationChannelServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="NotificationChannelServiceClient"/> RPC methods is defined as:
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
        /// <c>NotificationChannelServiceClient.ListNotificationChannelDescriptors</c> and <c>NotificationChannelServiceClient.ListNotificationChannelDescriptorsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>NotificationChannelServiceClient.ListNotificationChannelDescriptors</c> and
        /// <c>NotificationChannelServiceClient.ListNotificationChannelDescriptorsAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings ListNotificationChannelDescriptorsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotificationChannelServiceClient.GetNotificationChannelDescriptor</c> and <c>NotificationChannelServiceClient.GetNotificationChannelDescriptorAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>NotificationChannelServiceClient.GetNotificationChannelDescriptor</c> and
        /// <c>NotificationChannelServiceClient.GetNotificationChannelDescriptorAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings GetNotificationChannelDescriptorSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotificationChannelServiceClient.ListNotificationChannels</c> and <c>NotificationChannelServiceClient.ListNotificationChannelsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>NotificationChannelServiceClient.ListNotificationChannels</c> and
        /// <c>NotificationChannelServiceClient.ListNotificationChannelsAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings ListNotificationChannelsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotificationChannelServiceClient.GetNotificationChannel</c> and <c>NotificationChannelServiceClient.GetNotificationChannelAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>NotificationChannelServiceClient.GetNotificationChannel</c> and
        /// <c>NotificationChannelServiceClient.GetNotificationChannelAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings GetNotificationChannelSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotificationChannelServiceClient.CreateNotificationChannel</c> and <c>NotificationChannelServiceClient.CreateNotificationChannelAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>NotificationChannelServiceClient.CreateNotificationChannel</c> and
        /// <c>NotificationChannelServiceClient.CreateNotificationChannelAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings CreateNotificationChannelSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotificationChannelServiceClient.UpdateNotificationChannel</c> and <c>NotificationChannelServiceClient.UpdateNotificationChannelAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>NotificationChannelServiceClient.UpdateNotificationChannel</c> and
        /// <c>NotificationChannelServiceClient.UpdateNotificationChannelAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings UpdateNotificationChannelSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>NotificationChannelServiceClient.DeleteNotificationChannel</c> and <c>NotificationChannelServiceClient.DeleteNotificationChannelAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>NotificationChannelServiceClient.DeleteNotificationChannel</c> and
        /// <c>NotificationChannelServiceClient.DeleteNotificationChannelAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings DeleteNotificationChannelSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="NotificationChannelServiceSettings"/> object.</returns>
        public NotificationChannelServiceSettings Clone() => new NotificationChannelServiceSettings(this);
    }

    /// <summary>
    /// NotificationChannelService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class NotificationChannelServiceClient
    {
        /// <summary>
        /// The default endpoint for the NotificationChannelService service, which is a host of "monitoring.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("monitoring.googleapis.com", 443);

        /// <summary>
        /// The default NotificationChannelService scopes.
        /// </summary>
        /// <remarks>
        /// The default NotificationChannelService scopes are:
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
        /// Asynchronously creates a <see cref="NotificationChannelServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="NotificationChannelServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="NotificationChannelServiceClient"/>.</returns>
        public static async Task<NotificationChannelServiceClient> CreateAsync(ServiceEndpoint endpoint = null, NotificationChannelServiceSettings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="NotificationChannelServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="NotificationChannelServiceSettings"/>.</param>
        /// <returns>The created <see cref="NotificationChannelServiceClient"/>.</returns>
        public static NotificationChannelServiceClient Create(ServiceEndpoint endpoint = null, NotificationChannelServiceSettings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="NotificationChannelServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="NotificationChannelServiceSettings"/>.</param>
        /// <returns>The created <see cref="NotificationChannelServiceClient"/>.</returns>
        public static NotificationChannelServiceClient Create(Channel channel, NotificationChannelServiceSettings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            NotificationChannelService.NotificationChannelServiceClient grpcClient = new NotificationChannelService.NotificationChannelServiceClient(channel);
            return new NotificationChannelServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, NotificationChannelServiceSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, NotificationChannelServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, NotificationChannelServiceSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, NotificationChannelServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC NotificationChannelService client.
        /// </summary>
        public virtual NotificationChannelService.NotificationChannelServiceClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Lists the descriptors for supported channel types. The use of descriptors
        /// makes it possible for new channel types to be dynamically added.
        /// </summary>
        /// <param name="name">
        /// The REST resource name of the parent from which to retrieve
        /// the notification channel descriptors. The expected syntax is:
        ///
        ///     projects/[PROJECT_ID]
        ///
        /// Note that this names the parent container in which to look for the
        /// descriptors; to retrieve a single descriptor by name, use the
        /// [GetNotificationChannelDescriptor][google.monitoring.v3.NotificationChannelService.GetNotificationChannelDescriptor]
        /// operation, instead.
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
        /// A pageable asynchronous sequence of <see cref="NotificationChannelDescriptor"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> ListNotificationChannelDescriptorsAsync(
            ProjectName name,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListNotificationChannelDescriptorsAsync(
                new ListNotificationChannelDescriptorsRequest
                {
                    ProjectName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the descriptors for supported channel types. The use of descriptors
        /// makes it possible for new channel types to be dynamically added.
        /// </summary>
        /// <param name="name">
        /// The REST resource name of the parent from which to retrieve
        /// the notification channel descriptors. The expected syntax is:
        ///
        ///     projects/[PROJECT_ID]
        ///
        /// Note that this names the parent container in which to look for the
        /// descriptors; to retrieve a single descriptor by name, use the
        /// [GetNotificationChannelDescriptor][google.monitoring.v3.NotificationChannelService.GetNotificationChannelDescriptor]
        /// operation, instead.
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
        /// A pageable sequence of <see cref="NotificationChannelDescriptor"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> ListNotificationChannelDescriptors(
            ProjectName name,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListNotificationChannelDescriptors(
                new ListNotificationChannelDescriptorsRequest
                {
                    ProjectName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the descriptors for supported channel types. The use of descriptors
        /// makes it possible for new channel types to be dynamically added.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="NotificationChannelDescriptor"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> ListNotificationChannelDescriptorsAsync(
            ListNotificationChannelDescriptorsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists the descriptors for supported channel types. The use of descriptors
        /// makes it possible for new channel types to be dynamically added.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="NotificationChannelDescriptor"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> ListNotificationChannelDescriptors(
            ListNotificationChannelDescriptorsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a single channel descriptor. The descriptor indicates which fields
        /// are expected / permitted for a notification channel of the given type.
        /// </summary>
        /// <param name="name">
        /// The channel type for which to execute the request. The format is
        /// `projects/[PROJECT_ID]/notificationChannelDescriptors/{channel_type}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<NotificationChannelDescriptor> GetNotificationChannelDescriptorAsync(
            NotificationChannelDescriptorName name,
            CallSettings callSettings = null) => GetNotificationChannelDescriptorAsync(
                new GetNotificationChannelDescriptorRequest
                {
                    NotificationChannelDescriptorName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a single channel descriptor. The descriptor indicates which fields
        /// are expected / permitted for a notification channel of the given type.
        /// </summary>
        /// <param name="name">
        /// The channel type for which to execute the request. The format is
        /// `projects/[PROJECT_ID]/notificationChannelDescriptors/{channel_type}`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<NotificationChannelDescriptor> GetNotificationChannelDescriptorAsync(
            NotificationChannelDescriptorName name,
            CancellationToken cancellationToken) => GetNotificationChannelDescriptorAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single channel descriptor. The descriptor indicates which fields
        /// are expected / permitted for a notification channel of the given type.
        /// </summary>
        /// <param name="name">
        /// The channel type for which to execute the request. The format is
        /// `projects/[PROJECT_ID]/notificationChannelDescriptors/{channel_type}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual NotificationChannelDescriptor GetNotificationChannelDescriptor(
            NotificationChannelDescriptorName name,
            CallSettings callSettings = null) => GetNotificationChannelDescriptor(
                new GetNotificationChannelDescriptorRequest
                {
                    NotificationChannelDescriptorName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a single channel descriptor. The descriptor indicates which fields
        /// are expected / permitted for a notification channel of the given type.
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
        public virtual Task<NotificationChannelDescriptor> GetNotificationChannelDescriptorAsync(
            GetNotificationChannelDescriptorRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a single channel descriptor. The descriptor indicates which fields
        /// are expected / permitted for a notification channel of the given type.
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
        public virtual NotificationChannelDescriptor GetNotificationChannelDescriptor(
            GetNotificationChannelDescriptorRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists the notification channels that have been created for the project.
        /// </summary>
        /// <param name="name">
        /// The project on which to execute the request. The format is
        /// `projects/[PROJECT_ID]`. That is, this names the container
        /// in which to look for the notification channels; it does not name a
        /// specific channel. To query a specific channel by REST resource name, use
        /// the
        /// [`GetNotificationChannel`][google.monitoring.v3.NotificationChannelService.GetNotificationChannel] operation.
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
        /// A pageable asynchronous sequence of <see cref="NotificationChannel"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListNotificationChannelsResponse, NotificationChannel> ListNotificationChannelsAsync(
            ProjectName name,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListNotificationChannelsAsync(
                new ListNotificationChannelsRequest
                {
                    ProjectName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the notification channels that have been created for the project.
        /// </summary>
        /// <param name="name">
        /// The project on which to execute the request. The format is
        /// `projects/[PROJECT_ID]`. That is, this names the container
        /// in which to look for the notification channels; it does not name a
        /// specific channel. To query a specific channel by REST resource name, use
        /// the
        /// [`GetNotificationChannel`][google.monitoring.v3.NotificationChannelService.GetNotificationChannel] operation.
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
        /// A pageable sequence of <see cref="NotificationChannel"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListNotificationChannelsResponse, NotificationChannel> ListNotificationChannels(
            ProjectName name,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListNotificationChannels(
                new ListNotificationChannelsRequest
                {
                    ProjectName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the notification channels that have been created for the project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="NotificationChannel"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListNotificationChannelsResponse, NotificationChannel> ListNotificationChannelsAsync(
            ListNotificationChannelsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists the notification channels that have been created for the project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="NotificationChannel"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListNotificationChannelsResponse, NotificationChannel> ListNotificationChannels(
            ListNotificationChannelsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a single notification channel. The channel includes the relevant
        /// configuration details with which the channel was created. However, the
        /// response may truncate or omit passwords, API keys, or other private key
        /// matter and thus the response may not be 100% identical to the information
        /// that was supplied in the call to the create method.
        /// </summary>
        /// <param name="name">
        /// The channel for which to execute the request. The format is
        /// `projects/[PROJECT_ID]/notificationChannels/[CHANNEL_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<NotificationChannel> GetNotificationChannelAsync(
            NotificationChannelName name,
            CallSettings callSettings = null) => GetNotificationChannelAsync(
                new GetNotificationChannelRequest
                {
                    NotificationChannelName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a single notification channel. The channel includes the relevant
        /// configuration details with which the channel was created. However, the
        /// response may truncate or omit passwords, API keys, or other private key
        /// matter and thus the response may not be 100% identical to the information
        /// that was supplied in the call to the create method.
        /// </summary>
        /// <param name="name">
        /// The channel for which to execute the request. The format is
        /// `projects/[PROJECT_ID]/notificationChannels/[CHANNEL_ID]`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<NotificationChannel> GetNotificationChannelAsync(
            NotificationChannelName name,
            CancellationToken cancellationToken) => GetNotificationChannelAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single notification channel. The channel includes the relevant
        /// configuration details with which the channel was created. However, the
        /// response may truncate or omit passwords, API keys, or other private key
        /// matter and thus the response may not be 100% identical to the information
        /// that was supplied in the call to the create method.
        /// </summary>
        /// <param name="name">
        /// The channel for which to execute the request. The format is
        /// `projects/[PROJECT_ID]/notificationChannels/[CHANNEL_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual NotificationChannel GetNotificationChannel(
            NotificationChannelName name,
            CallSettings callSettings = null) => GetNotificationChannel(
                new GetNotificationChannelRequest
                {
                    NotificationChannelName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a single notification channel. The channel includes the relevant
        /// configuration details with which the channel was created. However, the
        /// response may truncate or omit passwords, API keys, or other private key
        /// matter and thus the response may not be 100% identical to the information
        /// that was supplied in the call to the create method.
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
        public virtual Task<NotificationChannel> GetNotificationChannelAsync(
            GetNotificationChannelRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a single notification channel. The channel includes the relevant
        /// configuration details with which the channel was created. However, the
        /// response may truncate or omit passwords, API keys, or other private key
        /// matter and thus the response may not be 100% identical to the information
        /// that was supplied in the call to the create method.
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
        public virtual NotificationChannel GetNotificationChannel(
            GetNotificationChannelRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new notification channel, representing a single notification
        /// endpoint such as an email address, SMS number, or pagerduty service.
        /// </summary>
        /// <param name="name">
        /// The project on which to execute the request. The format is:
        ///
        ///     projects/[PROJECT_ID]
        ///
        /// Note that this names the container into which the channel will be
        /// written. This does not name the newly created channel. The resulting
        /// channel's name will have a normalized version of this field as a prefix,
        /// but will add `/notificationChannels/[CHANNEL_ID]` to identify the channel.
        /// </param>
        /// <param name="notificationChannel">
        /// The definition of the `NotificationChannel` to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<NotificationChannel> CreateNotificationChannelAsync(
            ProjectName name,
            NotificationChannel notificationChannel,
            CallSettings callSettings = null) => CreateNotificationChannelAsync(
                new CreateNotificationChannelRequest
                {
                    ProjectName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    NotificationChannel = GaxPreconditions.CheckNotNull(notificationChannel, nameof(notificationChannel)),
                },
                callSettings);

        /// <summary>
        /// Creates a new notification channel, representing a single notification
        /// endpoint such as an email address, SMS number, or pagerduty service.
        /// </summary>
        /// <param name="name">
        /// The project on which to execute the request. The format is:
        ///
        ///     projects/[PROJECT_ID]
        ///
        /// Note that this names the container into which the channel will be
        /// written. This does not name the newly created channel. The resulting
        /// channel's name will have a normalized version of this field as a prefix,
        /// but will add `/notificationChannels/[CHANNEL_ID]` to identify the channel.
        /// </param>
        /// <param name="notificationChannel">
        /// The definition of the `NotificationChannel` to create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<NotificationChannel> CreateNotificationChannelAsync(
            ProjectName name,
            NotificationChannel notificationChannel,
            CancellationToken cancellationToken) => CreateNotificationChannelAsync(
                name,
                notificationChannel,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new notification channel, representing a single notification
        /// endpoint such as an email address, SMS number, or pagerduty service.
        /// </summary>
        /// <param name="name">
        /// The project on which to execute the request. The format is:
        ///
        ///     projects/[PROJECT_ID]
        ///
        /// Note that this names the container into which the channel will be
        /// written. This does not name the newly created channel. The resulting
        /// channel's name will have a normalized version of this field as a prefix,
        /// but will add `/notificationChannels/[CHANNEL_ID]` to identify the channel.
        /// </param>
        /// <param name="notificationChannel">
        /// The definition of the `NotificationChannel` to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual NotificationChannel CreateNotificationChannel(
            ProjectName name,
            NotificationChannel notificationChannel,
            CallSettings callSettings = null) => CreateNotificationChannel(
                new CreateNotificationChannelRequest
                {
                    ProjectName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    NotificationChannel = GaxPreconditions.CheckNotNull(notificationChannel, nameof(notificationChannel)),
                },
                callSettings);

        /// <summary>
        /// Creates a new notification channel, representing a single notification
        /// endpoint such as an email address, SMS number, or pagerduty service.
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
        public virtual Task<NotificationChannel> CreateNotificationChannelAsync(
            CreateNotificationChannelRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new notification channel, representing a single notification
        /// endpoint such as an email address, SMS number, or pagerduty service.
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
        public virtual NotificationChannel CreateNotificationChannel(
            CreateNotificationChannelRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates a notification channel. Fields not specified in the field mask
        /// remain unchanged.
        /// </summary>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="notificationChannel">
        /// A description of the changes to be applied to the specified
        /// notification channel. The description must provide a definition for
        /// fields to be updated; the names of these fields should also be
        /// included in the `update_mask`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<NotificationChannel> UpdateNotificationChannelAsync(
            FieldMask updateMask,
            NotificationChannel notificationChannel,
            CallSettings callSettings = null) => UpdateNotificationChannelAsync(
                new UpdateNotificationChannelRequest
                {
                    UpdateMask = updateMask, // Optional
                    NotificationChannel = GaxPreconditions.CheckNotNull(notificationChannel, nameof(notificationChannel)),
                },
                callSettings);

        /// <summary>
        /// Updates a notification channel. Fields not specified in the field mask
        /// remain unchanged.
        /// </summary>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="notificationChannel">
        /// A description of the changes to be applied to the specified
        /// notification channel. The description must provide a definition for
        /// fields to be updated; the names of these fields should also be
        /// included in the `update_mask`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<NotificationChannel> UpdateNotificationChannelAsync(
            FieldMask updateMask,
            NotificationChannel notificationChannel,
            CancellationToken cancellationToken) => UpdateNotificationChannelAsync(
                updateMask,
                notificationChannel,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a notification channel. Fields not specified in the field mask
        /// remain unchanged.
        /// </summary>
        /// <param name="updateMask">
        /// The fields to update.
        /// </param>
        /// <param name="notificationChannel">
        /// A description of the changes to be applied to the specified
        /// notification channel. The description must provide a definition for
        /// fields to be updated; the names of these fields should also be
        /// included in the `update_mask`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual NotificationChannel UpdateNotificationChannel(
            FieldMask updateMask,
            NotificationChannel notificationChannel,
            CallSettings callSettings = null) => UpdateNotificationChannel(
                new UpdateNotificationChannelRequest
                {
                    UpdateMask = updateMask, // Optional
                    NotificationChannel = GaxPreconditions.CheckNotNull(notificationChannel, nameof(notificationChannel)),
                },
                callSettings);

        /// <summary>
        /// Updates a notification channel. Fields not specified in the field mask
        /// remain unchanged.
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
        public virtual Task<NotificationChannel> UpdateNotificationChannelAsync(
            UpdateNotificationChannelRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates a notification channel. Fields not specified in the field mask
        /// remain unchanged.
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
        public virtual NotificationChannel UpdateNotificationChannel(
            UpdateNotificationChannelRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a notification channel.
        /// </summary>
        /// <param name="name">
        /// The channel for which to execute the request. The format is
        /// `projects/[PROJECT_ID]/notificationChannels/[CHANNEL_ID]`.
        /// </param>
        /// <param name="force">
        /// If true, the notification channel will be deleted regardless of its
        /// use in alert policies (the policies will be updated to remove the
        /// channel). If false, channels that are still referenced by an existing
        /// alerting policy will fail to be deleted in a delete operation.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual Task DeleteNotificationChannelAsync(
            NotificationChannelName name,
            bool? force,
            CallSettings callSettings = null) => DeleteNotificationChannelAsync(
                new DeleteNotificationChannelRequest
                {
                    NotificationChannelName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Force = force ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Deletes a notification channel.
        /// </summary>
        /// <param name="name">
        /// The channel for which to execute the request. The format is
        /// `projects/[PROJECT_ID]/notificationChannels/[CHANNEL_ID]`.
        /// </param>
        /// <param name="force">
        /// If true, the notification channel will be deleted regardless of its
        /// use in alert policies (the policies will be updated to remove the
        /// channel). If false, channels that are still referenced by an existing
        /// alerting policy will fail to be deleted in a delete operation.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual Task DeleteNotificationChannelAsync(
            NotificationChannelName name,
            bool? force,
            CancellationToken cancellationToken) => DeleteNotificationChannelAsync(
                name,
                force,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a notification channel.
        /// </summary>
        /// <param name="name">
        /// The channel for which to execute the request. The format is
        /// `projects/[PROJECT_ID]/notificationChannels/[CHANNEL_ID]`.
        /// </param>
        /// <param name="force">
        /// If true, the notification channel will be deleted regardless of its
        /// use in alert policies (the policies will be updated to remove the
        /// channel). If false, channels that are still referenced by an existing
        /// alerting policy will fail to be deleted in a delete operation.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteNotificationChannel(
            NotificationChannelName name,
            bool? force,
            CallSettings callSettings = null) => DeleteNotificationChannel(
                new DeleteNotificationChannelRequest
                {
                    NotificationChannelName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Force = force ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Deletes a notification channel.
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
        public virtual Task DeleteNotificationChannelAsync(
            DeleteNotificationChannelRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes a notification channel.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteNotificationChannel(
            DeleteNotificationChannelRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    /// <summary>
    /// NotificationChannelService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class NotificationChannelServiceClientImpl : NotificationChannelServiceClient
    {
        private readonly ApiCall<ListNotificationChannelDescriptorsRequest, ListNotificationChannelDescriptorsResponse> _callListNotificationChannelDescriptors;
        private readonly ApiCall<GetNotificationChannelDescriptorRequest, NotificationChannelDescriptor> _callGetNotificationChannelDescriptor;
        private readonly ApiCall<ListNotificationChannelsRequest, ListNotificationChannelsResponse> _callListNotificationChannels;
        private readonly ApiCall<GetNotificationChannelRequest, NotificationChannel> _callGetNotificationChannel;
        private readonly ApiCall<CreateNotificationChannelRequest, NotificationChannel> _callCreateNotificationChannel;
        private readonly ApiCall<UpdateNotificationChannelRequest, NotificationChannel> _callUpdateNotificationChannel;
        private readonly ApiCall<DeleteNotificationChannelRequest, Empty> _callDeleteNotificationChannel;

        /// <summary>
        /// Constructs a client wrapper for the NotificationChannelService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="NotificationChannelServiceSettings"/> used within this client </param>
        public NotificationChannelServiceClientImpl(NotificationChannelService.NotificationChannelServiceClient grpcClient, NotificationChannelServiceSettings settings)
        {
            GrpcClient = grpcClient;
            NotificationChannelServiceSettings effectiveSettings = settings ?? NotificationChannelServiceSettings.GetDefault();
            ClientHelper clientHelper = new ClientHelper(effectiveSettings);
            _callListNotificationChannelDescriptors = clientHelper.BuildApiCall<ListNotificationChannelDescriptorsRequest, ListNotificationChannelDescriptorsResponse>(
                GrpcClient.ListNotificationChannelDescriptorsAsync, GrpcClient.ListNotificationChannelDescriptors, effectiveSettings.ListNotificationChannelDescriptorsSettings);
            _callGetNotificationChannelDescriptor = clientHelper.BuildApiCall<GetNotificationChannelDescriptorRequest, NotificationChannelDescriptor>(
                GrpcClient.GetNotificationChannelDescriptorAsync, GrpcClient.GetNotificationChannelDescriptor, effectiveSettings.GetNotificationChannelDescriptorSettings);
            _callListNotificationChannels = clientHelper.BuildApiCall<ListNotificationChannelsRequest, ListNotificationChannelsResponse>(
                GrpcClient.ListNotificationChannelsAsync, GrpcClient.ListNotificationChannels, effectiveSettings.ListNotificationChannelsSettings);
            _callGetNotificationChannel = clientHelper.BuildApiCall<GetNotificationChannelRequest, NotificationChannel>(
                GrpcClient.GetNotificationChannelAsync, GrpcClient.GetNotificationChannel, effectiveSettings.GetNotificationChannelSettings);
            _callCreateNotificationChannel = clientHelper.BuildApiCall<CreateNotificationChannelRequest, NotificationChannel>(
                GrpcClient.CreateNotificationChannelAsync, GrpcClient.CreateNotificationChannel, effectiveSettings.CreateNotificationChannelSettings);
            _callUpdateNotificationChannel = clientHelper.BuildApiCall<UpdateNotificationChannelRequest, NotificationChannel>(
                GrpcClient.UpdateNotificationChannelAsync, GrpcClient.UpdateNotificationChannel, effectiveSettings.UpdateNotificationChannelSettings);
            _callDeleteNotificationChannel = clientHelper.BuildApiCall<DeleteNotificationChannelRequest, Empty>(
                GrpcClient.DeleteNotificationChannelAsync, GrpcClient.DeleteNotificationChannel, effectiveSettings.DeleteNotificationChannelSettings);
            Modify_ApiCall(ref _callListNotificationChannelDescriptors);
            Modify_ListNotificationChannelDescriptorsApiCall(ref _callListNotificationChannelDescriptors);
            Modify_ApiCall(ref _callGetNotificationChannelDescriptor);
            Modify_GetNotificationChannelDescriptorApiCall(ref _callGetNotificationChannelDescriptor);
            Modify_ApiCall(ref _callListNotificationChannels);
            Modify_ListNotificationChannelsApiCall(ref _callListNotificationChannels);
            Modify_ApiCall(ref _callGetNotificationChannel);
            Modify_GetNotificationChannelApiCall(ref _callGetNotificationChannel);
            Modify_ApiCall(ref _callCreateNotificationChannel);
            Modify_CreateNotificationChannelApiCall(ref _callCreateNotificationChannel);
            Modify_ApiCall(ref _callUpdateNotificationChannel);
            Modify_UpdateNotificationChannelApiCall(ref _callUpdateNotificationChannel);
            Modify_ApiCall(ref _callDeleteNotificationChannel);
            Modify_DeleteNotificationChannelApiCall(ref _callDeleteNotificationChannel);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        // Partial methods are named to (mostly) ensure there cannot be conflicts with RPC method names.

        // Partial methods called for every ApiCall on construction.
        // Allows modification of all the underlying ApiCall objects.
        partial void Modify_ApiCall<TRequest, TResponse>(ref ApiCall<TRequest, TResponse> call)
            where TRequest : class, IMessage<TRequest>
            where TResponse : class, IMessage<TResponse>;

        // Partial methods called for each ApiCall on construction.
        // Allows per-RPC-method modification of the underlying ApiCall object.
        partial void Modify_ListNotificationChannelDescriptorsApiCall(ref ApiCall<ListNotificationChannelDescriptorsRequest, ListNotificationChannelDescriptorsResponse> call);
        partial void Modify_GetNotificationChannelDescriptorApiCall(ref ApiCall<GetNotificationChannelDescriptorRequest, NotificationChannelDescriptor> call);
        partial void Modify_ListNotificationChannelsApiCall(ref ApiCall<ListNotificationChannelsRequest, ListNotificationChannelsResponse> call);
        partial void Modify_GetNotificationChannelApiCall(ref ApiCall<GetNotificationChannelRequest, NotificationChannel> call);
        partial void Modify_CreateNotificationChannelApiCall(ref ApiCall<CreateNotificationChannelRequest, NotificationChannel> call);
        partial void Modify_UpdateNotificationChannelApiCall(ref ApiCall<UpdateNotificationChannelRequest, NotificationChannel> call);
        partial void Modify_DeleteNotificationChannelApiCall(ref ApiCall<DeleteNotificationChannelRequest, Empty> call);
        partial void OnConstruction(NotificationChannelService.NotificationChannelServiceClient grpcClient, NotificationChannelServiceSettings effectiveSettings, ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC NotificationChannelService client.
        /// </summary>
        public override NotificationChannelService.NotificationChannelServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_ListNotificationChannelDescriptorsRequest(ref ListNotificationChannelDescriptorsRequest request, ref CallSettings settings);
        partial void Modify_GetNotificationChannelDescriptorRequest(ref GetNotificationChannelDescriptorRequest request, ref CallSettings settings);
        partial void Modify_ListNotificationChannelsRequest(ref ListNotificationChannelsRequest request, ref CallSettings settings);
        partial void Modify_GetNotificationChannelRequest(ref GetNotificationChannelRequest request, ref CallSettings settings);
        partial void Modify_CreateNotificationChannelRequest(ref CreateNotificationChannelRequest request, ref CallSettings settings);
        partial void Modify_UpdateNotificationChannelRequest(ref UpdateNotificationChannelRequest request, ref CallSettings settings);
        partial void Modify_DeleteNotificationChannelRequest(ref DeleteNotificationChannelRequest request, ref CallSettings settings);

        /// <summary>
        /// Lists the descriptors for supported channel types. The use of descriptors
        /// makes it possible for new channel types to be dynamically added.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="NotificationChannelDescriptor"/> resources.
        /// </returns>
        public override PagedAsyncEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> ListNotificationChannelDescriptorsAsync(
            ListNotificationChannelDescriptorsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListNotificationChannelDescriptorsRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<ListNotificationChannelDescriptorsRequest, ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor>(_callListNotificationChannelDescriptors, request, callSettings);
        }

        /// <summary>
        /// Lists the descriptors for supported channel types. The use of descriptors
        /// makes it possible for new channel types to be dynamically added.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="NotificationChannelDescriptor"/> resources.
        /// </returns>
        public override PagedEnumerable<ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor> ListNotificationChannelDescriptors(
            ListNotificationChannelDescriptorsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListNotificationChannelDescriptorsRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<ListNotificationChannelDescriptorsRequest, ListNotificationChannelDescriptorsResponse, NotificationChannelDescriptor>(_callListNotificationChannelDescriptors, request, callSettings);
        }

        /// <summary>
        /// Gets a single channel descriptor. The descriptor indicates which fields
        /// are expected / permitted for a notification channel of the given type.
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
        public override Task<NotificationChannelDescriptor> GetNotificationChannelDescriptorAsync(
            GetNotificationChannelDescriptorRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetNotificationChannelDescriptorRequest(ref request, ref callSettings);
            return _callGetNotificationChannelDescriptor.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a single channel descriptor. The descriptor indicates which fields
        /// are expected / permitted for a notification channel of the given type.
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
        public override NotificationChannelDescriptor GetNotificationChannelDescriptor(
            GetNotificationChannelDescriptorRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetNotificationChannelDescriptorRequest(ref request, ref callSettings);
            return _callGetNotificationChannelDescriptor.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists the notification channels that have been created for the project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="NotificationChannel"/> resources.
        /// </returns>
        public override PagedAsyncEnumerable<ListNotificationChannelsResponse, NotificationChannel> ListNotificationChannelsAsync(
            ListNotificationChannelsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListNotificationChannelsRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<ListNotificationChannelsRequest, ListNotificationChannelsResponse, NotificationChannel>(_callListNotificationChannels, request, callSettings);
        }

        /// <summary>
        /// Lists the notification channels that have been created for the project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="NotificationChannel"/> resources.
        /// </returns>
        public override PagedEnumerable<ListNotificationChannelsResponse, NotificationChannel> ListNotificationChannels(
            ListNotificationChannelsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListNotificationChannelsRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<ListNotificationChannelsRequest, ListNotificationChannelsResponse, NotificationChannel>(_callListNotificationChannels, request, callSettings);
        }

        /// <summary>
        /// Gets a single notification channel. The channel includes the relevant
        /// configuration details with which the channel was created. However, the
        /// response may truncate or omit passwords, API keys, or other private key
        /// matter and thus the response may not be 100% identical to the information
        /// that was supplied in the call to the create method.
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
        public override Task<NotificationChannel> GetNotificationChannelAsync(
            GetNotificationChannelRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetNotificationChannelRequest(ref request, ref callSettings);
            return _callGetNotificationChannel.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a single notification channel. The channel includes the relevant
        /// configuration details with which the channel was created. However, the
        /// response may truncate or omit passwords, API keys, or other private key
        /// matter and thus the response may not be 100% identical to the information
        /// that was supplied in the call to the create method.
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
        public override NotificationChannel GetNotificationChannel(
            GetNotificationChannelRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetNotificationChannelRequest(ref request, ref callSettings);
            return _callGetNotificationChannel.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new notification channel, representing a single notification
        /// endpoint such as an email address, SMS number, or pagerduty service.
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
        public override Task<NotificationChannel> CreateNotificationChannelAsync(
            CreateNotificationChannelRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateNotificationChannelRequest(ref request, ref callSettings);
            return _callCreateNotificationChannel.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new notification channel, representing a single notification
        /// endpoint such as an email address, SMS number, or pagerduty service.
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
        public override NotificationChannel CreateNotificationChannel(
            CreateNotificationChannelRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateNotificationChannelRequest(ref request, ref callSettings);
            return _callCreateNotificationChannel.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a notification channel. Fields not specified in the field mask
        /// remain unchanged.
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
        public override Task<NotificationChannel> UpdateNotificationChannelAsync(
            UpdateNotificationChannelRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateNotificationChannelRequest(ref request, ref callSettings);
            return _callUpdateNotificationChannel.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a notification channel. Fields not specified in the field mask
        /// remain unchanged.
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
        public override NotificationChannel UpdateNotificationChannel(
            UpdateNotificationChannelRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateNotificationChannelRequest(ref request, ref callSettings);
            return _callUpdateNotificationChannel.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a notification channel.
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
        public override Task DeleteNotificationChannelAsync(
            DeleteNotificationChannelRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteNotificationChannelRequest(ref request, ref callSettings);
            return _callDeleteNotificationChannel.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a notification channel.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteNotificationChannel(
            DeleteNotificationChannelRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteNotificationChannelRequest(ref request, ref callSettings);
            _callDeleteNotificationChannel.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListNotificationChannelDescriptorsRequest : IPageRequest { }
    public partial class ListNotificationChannelDescriptorsResponse : IPageResponse<NotificationChannelDescriptor>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<NotificationChannelDescriptor> GetEnumerator() => ChannelDescriptors.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListNotificationChannelsRequest : IPageRequest { }
    public partial class ListNotificationChannelsResponse : IPageResponse<NotificationChannel>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<NotificationChannel> GetEnumerator() => NotificationChannels.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
