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
    /// Settings for a <see cref="UptimeCheckServiceClient"/>.
    /// </summary>
    public sealed partial class UptimeCheckServiceSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="UptimeCheckServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="UptimeCheckServiceSettings"/>.
        /// </returns>
        public static UptimeCheckServiceSettings GetDefault() => new UptimeCheckServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="UptimeCheckServiceSettings"/> object with default settings.
        /// </summary>
        public UptimeCheckServiceSettings() { }

        private UptimeCheckServiceSettings(UptimeCheckServiceSettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListUptimeCheckConfigsSettings = existing.ListUptimeCheckConfigsSettings;
            GetUptimeCheckConfigSettings = existing.GetUptimeCheckConfigSettings;
            CreateUptimeCheckConfigSettings = existing.CreateUptimeCheckConfigSettings;
            UpdateUptimeCheckConfigSettings = existing.UpdateUptimeCheckConfigSettings;
            DeleteUptimeCheckConfigSettings = existing.DeleteUptimeCheckConfigSettings;
            ListUptimeCheckIpsSettings = existing.ListUptimeCheckIpsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(UptimeCheckServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="UptimeCheckServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="UptimeCheckServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="UptimeCheckServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="UptimeCheckServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="UptimeCheckServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="UptimeCheckServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="UptimeCheckServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="UptimeCheckServiceClient"/> RPC methods is defined as:
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
        /// <c>UptimeCheckServiceClient.ListUptimeCheckConfigs</c> and <c>UptimeCheckServiceClient.ListUptimeCheckConfigsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>UptimeCheckServiceClient.ListUptimeCheckConfigs</c> and
        /// <c>UptimeCheckServiceClient.ListUptimeCheckConfigsAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings ListUptimeCheckConfigsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UptimeCheckServiceClient.GetUptimeCheckConfig</c> and <c>UptimeCheckServiceClient.GetUptimeCheckConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>UptimeCheckServiceClient.GetUptimeCheckConfig</c> and
        /// <c>UptimeCheckServiceClient.GetUptimeCheckConfigAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings GetUptimeCheckConfigSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UptimeCheckServiceClient.CreateUptimeCheckConfig</c> and <c>UptimeCheckServiceClient.CreateUptimeCheckConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>UptimeCheckServiceClient.CreateUptimeCheckConfig</c> and
        /// <c>UptimeCheckServiceClient.CreateUptimeCheckConfigAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings CreateUptimeCheckConfigSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UptimeCheckServiceClient.UpdateUptimeCheckConfig</c> and <c>UptimeCheckServiceClient.UpdateUptimeCheckConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>UptimeCheckServiceClient.UpdateUptimeCheckConfig</c> and
        /// <c>UptimeCheckServiceClient.UpdateUptimeCheckConfigAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings UpdateUptimeCheckConfigSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UptimeCheckServiceClient.DeleteUptimeCheckConfig</c> and <c>UptimeCheckServiceClient.DeleteUptimeCheckConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>UptimeCheckServiceClient.DeleteUptimeCheckConfig</c> and
        /// <c>UptimeCheckServiceClient.DeleteUptimeCheckConfigAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings DeleteUptimeCheckConfigSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UptimeCheckServiceClient.ListUptimeCheckIps</c> and <c>UptimeCheckServiceClient.ListUptimeCheckIpsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>UptimeCheckServiceClient.ListUptimeCheckIps</c> and
        /// <c>UptimeCheckServiceClient.ListUptimeCheckIpsAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings ListUptimeCheckIpsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="UptimeCheckServiceSettings"/> object.</returns>
        public UptimeCheckServiceSettings Clone() => new UptimeCheckServiceSettings(this);
    }

    /// <summary>
    /// UptimeCheckService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class UptimeCheckServiceClient
    {
        /// <summary>
        /// The default endpoint for the UptimeCheckService service, which is a host of "monitoring.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("monitoring.googleapis.com", 443);

        /// <summary>
        /// The default UptimeCheckService scopes.
        /// </summary>
        /// <remarks>
        /// The default UptimeCheckService scopes are:
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
        /// Asynchronously creates a <see cref="UptimeCheckServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="UptimeCheckServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="UptimeCheckServiceClient"/>.</returns>
        public static async Task<UptimeCheckServiceClient> CreateAsync(ServiceEndpoint endpoint = null, UptimeCheckServiceSettings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="UptimeCheckServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="UptimeCheckServiceSettings"/>.</param>
        /// <returns>The created <see cref="UptimeCheckServiceClient"/>.</returns>
        public static UptimeCheckServiceClient Create(ServiceEndpoint endpoint = null, UptimeCheckServiceSettings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="UptimeCheckServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="UptimeCheckServiceSettings"/>.</param>
        /// <returns>The created <see cref="UptimeCheckServiceClient"/>.</returns>
        public static UptimeCheckServiceClient Create(Channel channel, UptimeCheckServiceSettings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            UptimeCheckService.UptimeCheckServiceClient grpcClient = new UptimeCheckService.UptimeCheckServiceClient(channel);
            return new UptimeCheckServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, UptimeCheckServiceSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, UptimeCheckServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, UptimeCheckServiceSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, UptimeCheckServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC UptimeCheckService client.
        /// </summary>
        public virtual UptimeCheckService.UptimeCheckServiceClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Lists the existing valid uptime check configurations for the project,
        /// leaving out any invalid configurations.
        /// </summary>
        /// <param name="parent">
        /// The project whose uptime check configurations are listed. The format is
        ///
        ///   `projects/[PROJECT_ID]`.
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
        /// A pageable asynchronous sequence of <see cref="UptimeCheckConfig"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> ListUptimeCheckConfigsAsync(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListUptimeCheckConfigsAsync(
                new ListUptimeCheckConfigsRequest
                {
                    Parent = GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the existing valid uptime check configurations for the project,
        /// leaving out any invalid configurations.
        /// </summary>
        /// <param name="parent">
        /// The project whose uptime check configurations are listed. The format is
        ///
        ///   `projects/[PROJECT_ID]`.
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
        /// A pageable sequence of <see cref="UptimeCheckConfig"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> ListUptimeCheckConfigs(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListUptimeCheckConfigs(
                new ListUptimeCheckConfigsRequest
                {
                    Parent = GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the existing valid uptime check configurations for the project,
        /// leaving out any invalid configurations.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="UptimeCheckConfig"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> ListUptimeCheckConfigsAsync(
            ListUptimeCheckConfigsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists the existing valid uptime check configurations for the project,
        /// leaving out any invalid configurations.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="UptimeCheckConfig"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> ListUptimeCheckConfigs(
            ListUptimeCheckConfigsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a single uptime check configuration.
        /// </summary>
        /// <param name="name">
        /// The uptime check configuration to retrieve. The format is
        ///
        ///   `projects/[PROJECT_ID]/uptimeCheckConfigs/[UPTIME_CHECK_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<UptimeCheckConfig> GetUptimeCheckConfigAsync(
            string name,
            CallSettings callSettings = null) => GetUptimeCheckConfigAsync(
                new GetUptimeCheckConfigRequest
                {
                    Name = GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a single uptime check configuration.
        /// </summary>
        /// <param name="name">
        /// The uptime check configuration to retrieve. The format is
        ///
        ///   `projects/[PROJECT_ID]/uptimeCheckConfigs/[UPTIME_CHECK_ID]`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<UptimeCheckConfig> GetUptimeCheckConfigAsync(
            string name,
            CancellationToken cancellationToken) => GetUptimeCheckConfigAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single uptime check configuration.
        /// </summary>
        /// <param name="name">
        /// The uptime check configuration to retrieve. The format is
        ///
        ///   `projects/[PROJECT_ID]/uptimeCheckConfigs/[UPTIME_CHECK_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual UptimeCheckConfig GetUptimeCheckConfig(
            string name,
            CallSettings callSettings = null) => GetUptimeCheckConfig(
                new GetUptimeCheckConfigRequest
                {
                    Name = GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a single uptime check configuration.
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
        public virtual Task<UptimeCheckConfig> GetUptimeCheckConfigAsync(
            GetUptimeCheckConfigRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a single uptime check configuration.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<UptimeCheckConfig> GetUptimeCheckConfigAsync(
            GetUptimeCheckConfigRequest request,
            CancellationToken cancellationToken) => GetUptimeCheckConfigAsync(
                request,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single uptime check configuration.
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
        public virtual UptimeCheckConfig GetUptimeCheckConfig(
            GetUptimeCheckConfigRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new uptime check configuration.
        /// </summary>
        /// <param name="parent">
        /// The project in which to create the uptime check. The format is:
        ///
        ///   `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="uptimeCheckConfig">
        /// The new uptime check configuration.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<UptimeCheckConfig> CreateUptimeCheckConfigAsync(
            string parent,
            UptimeCheckConfig uptimeCheckConfig,
            CallSettings callSettings = null) => CreateUptimeCheckConfigAsync(
                new CreateUptimeCheckConfigRequest
                {
                    Parent = GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    UptimeCheckConfig = GaxPreconditions.CheckNotNull(uptimeCheckConfig, nameof(uptimeCheckConfig)),
                },
                callSettings);

        /// <summary>
        /// Creates a new uptime check configuration.
        /// </summary>
        /// <param name="parent">
        /// The project in which to create the uptime check. The format is:
        ///
        ///   `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="uptimeCheckConfig">
        /// The new uptime check configuration.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<UptimeCheckConfig> CreateUptimeCheckConfigAsync(
            string parent,
            UptimeCheckConfig uptimeCheckConfig,
            CancellationToken cancellationToken) => CreateUptimeCheckConfigAsync(
                parent,
                uptimeCheckConfig,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new uptime check configuration.
        /// </summary>
        /// <param name="parent">
        /// The project in which to create the uptime check. The format is:
        ///
        ///   `projects/[PROJECT_ID]`.
        /// </param>
        /// <param name="uptimeCheckConfig">
        /// The new uptime check configuration.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual UptimeCheckConfig CreateUptimeCheckConfig(
            string parent,
            UptimeCheckConfig uptimeCheckConfig,
            CallSettings callSettings = null) => CreateUptimeCheckConfig(
                new CreateUptimeCheckConfigRequest
                {
                    Parent = GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    UptimeCheckConfig = GaxPreconditions.CheckNotNull(uptimeCheckConfig, nameof(uptimeCheckConfig)),
                },
                callSettings);

        /// <summary>
        /// Creates a new uptime check configuration.
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
        public virtual Task<UptimeCheckConfig> CreateUptimeCheckConfigAsync(
            CreateUptimeCheckConfigRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new uptime check configuration.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<UptimeCheckConfig> CreateUptimeCheckConfigAsync(
            CreateUptimeCheckConfigRequest request,
            CancellationToken cancellationToken) => CreateUptimeCheckConfigAsync(
                request,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new uptime check configuration.
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
        public virtual UptimeCheckConfig CreateUptimeCheckConfig(
            CreateUptimeCheckConfigRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates an uptime check configuration. You can either replace the entire
        /// configuration with a new one or replace only certain fields in the current
        /// configuration by specifying the fields to be updated via `"updateMask"`.
        /// Returns the updated configuration.
        /// </summary>
        /// <param name="uptimeCheckConfig">
        /// Required. If an `"updateMask"` has been specified, this field gives
        /// the values for the set of fields mentioned in the `"updateMask"`. If an
        /// `"updateMask"` has not been given, this uptime check configuration replaces
        /// the current configuration. If a field is mentioned in `"updateMask`" but
        /// the corresonding field is omitted in this partial uptime check
        /// configuration, it has the effect of deleting/clearing the field from the
        /// configuration on the server.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<UptimeCheckConfig> UpdateUptimeCheckConfigAsync(
            UptimeCheckConfig uptimeCheckConfig,
            CallSettings callSettings = null) => UpdateUptimeCheckConfigAsync(
                new UpdateUptimeCheckConfigRequest
                {
                    UptimeCheckConfig = GaxPreconditions.CheckNotNull(uptimeCheckConfig, nameof(uptimeCheckConfig)),
                },
                callSettings);

        /// <summary>
        /// Updates an uptime check configuration. You can either replace the entire
        /// configuration with a new one or replace only certain fields in the current
        /// configuration by specifying the fields to be updated via `"updateMask"`.
        /// Returns the updated configuration.
        /// </summary>
        /// <param name="uptimeCheckConfig">
        /// Required. If an `"updateMask"` has been specified, this field gives
        /// the values for the set of fields mentioned in the `"updateMask"`. If an
        /// `"updateMask"` has not been given, this uptime check configuration replaces
        /// the current configuration. If a field is mentioned in `"updateMask`" but
        /// the corresonding field is omitted in this partial uptime check
        /// configuration, it has the effect of deleting/clearing the field from the
        /// configuration on the server.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<UptimeCheckConfig> UpdateUptimeCheckConfigAsync(
            UptimeCheckConfig uptimeCheckConfig,
            CancellationToken cancellationToken) => UpdateUptimeCheckConfigAsync(
                uptimeCheckConfig,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an uptime check configuration. You can either replace the entire
        /// configuration with a new one or replace only certain fields in the current
        /// configuration by specifying the fields to be updated via `"updateMask"`.
        /// Returns the updated configuration.
        /// </summary>
        /// <param name="uptimeCheckConfig">
        /// Required. If an `"updateMask"` has been specified, this field gives
        /// the values for the set of fields mentioned in the `"updateMask"`. If an
        /// `"updateMask"` has not been given, this uptime check configuration replaces
        /// the current configuration. If a field is mentioned in `"updateMask`" but
        /// the corresonding field is omitted in this partial uptime check
        /// configuration, it has the effect of deleting/clearing the field from the
        /// configuration on the server.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual UptimeCheckConfig UpdateUptimeCheckConfig(
            UptimeCheckConfig uptimeCheckConfig,
            CallSettings callSettings = null) => UpdateUptimeCheckConfig(
                new UpdateUptimeCheckConfigRequest
                {
                    UptimeCheckConfig = GaxPreconditions.CheckNotNull(uptimeCheckConfig, nameof(uptimeCheckConfig)),
                },
                callSettings);

        /// <summary>
        /// Updates an uptime check configuration. You can either replace the entire
        /// configuration with a new one or replace only certain fields in the current
        /// configuration by specifying the fields to be updated via `"updateMask"`.
        /// Returns the updated configuration.
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
        public virtual Task<UptimeCheckConfig> UpdateUptimeCheckConfigAsync(
            UpdateUptimeCheckConfigRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates an uptime check configuration. You can either replace the entire
        /// configuration with a new one or replace only certain fields in the current
        /// configuration by specifying the fields to be updated via `"updateMask"`.
        /// Returns the updated configuration.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<UptimeCheckConfig> UpdateUptimeCheckConfigAsync(
            UpdateUptimeCheckConfigRequest request,
            CancellationToken cancellationToken) => UpdateUptimeCheckConfigAsync(
                request,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an uptime check configuration. You can either replace the entire
        /// configuration with a new one or replace only certain fields in the current
        /// configuration by specifying the fields to be updated via `"updateMask"`.
        /// Returns the updated configuration.
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
        public virtual UptimeCheckConfig UpdateUptimeCheckConfig(
            UpdateUptimeCheckConfigRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes an uptime check configuration. Note that this method will fail
        /// if the uptime check configuration is referenced by an alert policy or
        /// other dependent configs that would be rendered invalid by the deletion.
        /// </summary>
        /// <param name="name">
        /// The uptime check configuration to delete. The format is
        ///
        ///   `projects/[PROJECT_ID]/uptimeCheckConfigs/[UPTIME_CHECK_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual Task DeleteUptimeCheckConfigAsync(
            string name,
            CallSettings callSettings = null) => DeleteUptimeCheckConfigAsync(
                new DeleteUptimeCheckConfigRequest
                {
                    Name = GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes an uptime check configuration. Note that this method will fail
        /// if the uptime check configuration is referenced by an alert policy or
        /// other dependent configs that would be rendered invalid by the deletion.
        /// </summary>
        /// <param name="name">
        /// The uptime check configuration to delete. The format is
        ///
        ///   `projects/[PROJECT_ID]/uptimeCheckConfigs/[UPTIME_CHECK_ID]`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual Task DeleteUptimeCheckConfigAsync(
            string name,
            CancellationToken cancellationToken) => DeleteUptimeCheckConfigAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an uptime check configuration. Note that this method will fail
        /// if the uptime check configuration is referenced by an alert policy or
        /// other dependent configs that would be rendered invalid by the deletion.
        /// </summary>
        /// <param name="name">
        /// The uptime check configuration to delete. The format is
        ///
        ///   `projects/[PROJECT_ID]/uptimeCheckConfigs/[UPTIME_CHECK_ID]`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteUptimeCheckConfig(
            string name,
            CallSettings callSettings = null) => DeleteUptimeCheckConfig(
                new DeleteUptimeCheckConfigRequest
                {
                    Name = GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes an uptime check configuration. Note that this method will fail
        /// if the uptime check configuration is referenced by an alert policy or
        /// other dependent configs that would be rendered invalid by the deletion.
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
        public virtual Task DeleteUptimeCheckConfigAsync(
            DeleteUptimeCheckConfigRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes an uptime check configuration. Note that this method will fail
        /// if the uptime check configuration is referenced by an alert policy or
        /// other dependent configs that would be rendered invalid by the deletion.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual Task DeleteUptimeCheckConfigAsync(
            DeleteUptimeCheckConfigRequest request,
            CancellationToken cancellationToken) => DeleteUptimeCheckConfigAsync(
                request,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an uptime check configuration. Note that this method will fail
        /// if the uptime check configuration is referenced by an alert policy or
        /// other dependent configs that would be rendered invalid by the deletion.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteUptimeCheckConfig(
            DeleteUptimeCheckConfigRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the list of IPs that checkers run from
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="UptimeCheckIp"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListUptimeCheckIpsResponse, UptimeCheckIp> ListUptimeCheckIpsAsync(
            ListUptimeCheckIpsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns the list of IPs that checkers run from
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="UptimeCheckIp"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListUptimeCheckIpsResponse, UptimeCheckIp> ListUptimeCheckIps(
            ListUptimeCheckIpsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    /// <summary>
    /// UptimeCheckService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class UptimeCheckServiceClientImpl : UptimeCheckServiceClient
    {
        private readonly ApiCall<ListUptimeCheckConfigsRequest, ListUptimeCheckConfigsResponse> _callListUptimeCheckConfigs;
        private readonly ApiCall<GetUptimeCheckConfigRequest, UptimeCheckConfig> _callGetUptimeCheckConfig;
        private readonly ApiCall<CreateUptimeCheckConfigRequest, UptimeCheckConfig> _callCreateUptimeCheckConfig;
        private readonly ApiCall<UpdateUptimeCheckConfigRequest, UptimeCheckConfig> _callUpdateUptimeCheckConfig;
        private readonly ApiCall<DeleteUptimeCheckConfigRequest, Empty> _callDeleteUptimeCheckConfig;
        private readonly ApiCall<ListUptimeCheckIpsRequest, ListUptimeCheckIpsResponse> _callListUptimeCheckIps;

        /// <summary>
        /// Constructs a client wrapper for the UptimeCheckService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="UptimeCheckServiceSettings"/> used within this client </param>
        public UptimeCheckServiceClientImpl(UptimeCheckService.UptimeCheckServiceClient grpcClient, UptimeCheckServiceSettings settings)
        {
            GrpcClient = grpcClient;
            UptimeCheckServiceSettings effectiveSettings = settings ?? UptimeCheckServiceSettings.GetDefault();
            ClientHelper clientHelper = new ClientHelper(effectiveSettings);
            _callListUptimeCheckConfigs = clientHelper.BuildApiCall<ListUptimeCheckConfigsRequest, ListUptimeCheckConfigsResponse>(
                GrpcClient.ListUptimeCheckConfigsAsync, GrpcClient.ListUptimeCheckConfigs, effectiveSettings.ListUptimeCheckConfigsSettings);
            _callGetUptimeCheckConfig = clientHelper.BuildApiCall<GetUptimeCheckConfigRequest, UptimeCheckConfig>(
                GrpcClient.GetUptimeCheckConfigAsync, GrpcClient.GetUptimeCheckConfig, effectiveSettings.GetUptimeCheckConfigSettings);
            _callCreateUptimeCheckConfig = clientHelper.BuildApiCall<CreateUptimeCheckConfigRequest, UptimeCheckConfig>(
                GrpcClient.CreateUptimeCheckConfigAsync, GrpcClient.CreateUptimeCheckConfig, effectiveSettings.CreateUptimeCheckConfigSettings);
            _callUpdateUptimeCheckConfig = clientHelper.BuildApiCall<UpdateUptimeCheckConfigRequest, UptimeCheckConfig>(
                GrpcClient.UpdateUptimeCheckConfigAsync, GrpcClient.UpdateUptimeCheckConfig, effectiveSettings.UpdateUptimeCheckConfigSettings);
            _callDeleteUptimeCheckConfig = clientHelper.BuildApiCall<DeleteUptimeCheckConfigRequest, Empty>(
                GrpcClient.DeleteUptimeCheckConfigAsync, GrpcClient.DeleteUptimeCheckConfig, effectiveSettings.DeleteUptimeCheckConfigSettings);
            _callListUptimeCheckIps = clientHelper.BuildApiCall<ListUptimeCheckIpsRequest, ListUptimeCheckIpsResponse>(
                GrpcClient.ListUptimeCheckIpsAsync, GrpcClient.ListUptimeCheckIps, effectiveSettings.ListUptimeCheckIpsSettings);
            Modify_ApiCall(ref _callListUptimeCheckConfigs);
            Modify_ListUptimeCheckConfigsApiCall(ref _callListUptimeCheckConfigs);
            Modify_ApiCall(ref _callGetUptimeCheckConfig);
            Modify_GetUptimeCheckConfigApiCall(ref _callGetUptimeCheckConfig);
            Modify_ApiCall(ref _callCreateUptimeCheckConfig);
            Modify_CreateUptimeCheckConfigApiCall(ref _callCreateUptimeCheckConfig);
            Modify_ApiCall(ref _callUpdateUptimeCheckConfig);
            Modify_UpdateUptimeCheckConfigApiCall(ref _callUpdateUptimeCheckConfig);
            Modify_ApiCall(ref _callDeleteUptimeCheckConfig);
            Modify_DeleteUptimeCheckConfigApiCall(ref _callDeleteUptimeCheckConfig);
            Modify_ApiCall(ref _callListUptimeCheckIps);
            Modify_ListUptimeCheckIpsApiCall(ref _callListUptimeCheckIps);
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
        partial void Modify_ListUptimeCheckConfigsApiCall(ref ApiCall<ListUptimeCheckConfigsRequest, ListUptimeCheckConfigsResponse> call);
        partial void Modify_GetUptimeCheckConfigApiCall(ref ApiCall<GetUptimeCheckConfigRequest, UptimeCheckConfig> call);
        partial void Modify_CreateUptimeCheckConfigApiCall(ref ApiCall<CreateUptimeCheckConfigRequest, UptimeCheckConfig> call);
        partial void Modify_UpdateUptimeCheckConfigApiCall(ref ApiCall<UpdateUptimeCheckConfigRequest, UptimeCheckConfig> call);
        partial void Modify_DeleteUptimeCheckConfigApiCall(ref ApiCall<DeleteUptimeCheckConfigRequest, Empty> call);
        partial void Modify_ListUptimeCheckIpsApiCall(ref ApiCall<ListUptimeCheckIpsRequest, ListUptimeCheckIpsResponse> call);
        partial void OnConstruction(UptimeCheckService.UptimeCheckServiceClient grpcClient, UptimeCheckServiceSettings effectiveSettings, ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC UptimeCheckService client.
        /// </summary>
        public override UptimeCheckService.UptimeCheckServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_ListUptimeCheckConfigsRequest(ref ListUptimeCheckConfigsRequest request, ref CallSettings settings);
        partial void Modify_GetUptimeCheckConfigRequest(ref GetUptimeCheckConfigRequest request, ref CallSettings settings);
        partial void Modify_CreateUptimeCheckConfigRequest(ref CreateUptimeCheckConfigRequest request, ref CallSettings settings);
        partial void Modify_UpdateUptimeCheckConfigRequest(ref UpdateUptimeCheckConfigRequest request, ref CallSettings settings);
        partial void Modify_DeleteUptimeCheckConfigRequest(ref DeleteUptimeCheckConfigRequest request, ref CallSettings settings);
        partial void Modify_ListUptimeCheckIpsRequest(ref ListUptimeCheckIpsRequest request, ref CallSettings settings);

        /// <summary>
        /// Lists the existing valid uptime check configurations for the project,
        /// leaving out any invalid configurations.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="UptimeCheckConfig"/> resources.
        /// </returns>
        public override PagedAsyncEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> ListUptimeCheckConfigsAsync(
            ListUptimeCheckConfigsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListUptimeCheckConfigsRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<ListUptimeCheckConfigsRequest, ListUptimeCheckConfigsResponse, UptimeCheckConfig>(_callListUptimeCheckConfigs, request, callSettings);
        }

        /// <summary>
        /// Lists the existing valid uptime check configurations for the project,
        /// leaving out any invalid configurations.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="UptimeCheckConfig"/> resources.
        /// </returns>
        public override PagedEnumerable<ListUptimeCheckConfigsResponse, UptimeCheckConfig> ListUptimeCheckConfigs(
            ListUptimeCheckConfigsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListUptimeCheckConfigsRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<ListUptimeCheckConfigsRequest, ListUptimeCheckConfigsResponse, UptimeCheckConfig>(_callListUptimeCheckConfigs, request, callSettings);
        }

        /// <summary>
        /// Gets a single uptime check configuration.
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
        public override Task<UptimeCheckConfig> GetUptimeCheckConfigAsync(
            GetUptimeCheckConfigRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetUptimeCheckConfigRequest(ref request, ref callSettings);
            return _callGetUptimeCheckConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a single uptime check configuration.
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
        public override UptimeCheckConfig GetUptimeCheckConfig(
            GetUptimeCheckConfigRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetUptimeCheckConfigRequest(ref request, ref callSettings);
            return _callGetUptimeCheckConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new uptime check configuration.
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
        public override Task<UptimeCheckConfig> CreateUptimeCheckConfigAsync(
            CreateUptimeCheckConfigRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateUptimeCheckConfigRequest(ref request, ref callSettings);
            return _callCreateUptimeCheckConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new uptime check configuration.
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
        public override UptimeCheckConfig CreateUptimeCheckConfig(
            CreateUptimeCheckConfigRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateUptimeCheckConfigRequest(ref request, ref callSettings);
            return _callCreateUptimeCheckConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an uptime check configuration. You can either replace the entire
        /// configuration with a new one or replace only certain fields in the current
        /// configuration by specifying the fields to be updated via `"updateMask"`.
        /// Returns the updated configuration.
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
        public override Task<UptimeCheckConfig> UpdateUptimeCheckConfigAsync(
            UpdateUptimeCheckConfigRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateUptimeCheckConfigRequest(ref request, ref callSettings);
            return _callUpdateUptimeCheckConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an uptime check configuration. You can either replace the entire
        /// configuration with a new one or replace only certain fields in the current
        /// configuration by specifying the fields to be updated via `"updateMask"`.
        /// Returns the updated configuration.
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
        public override UptimeCheckConfig UpdateUptimeCheckConfig(
            UpdateUptimeCheckConfigRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateUptimeCheckConfigRequest(ref request, ref callSettings);
            return _callUpdateUptimeCheckConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an uptime check configuration. Note that this method will fail
        /// if the uptime check configuration is referenced by an alert policy or
        /// other dependent configs that would be rendered invalid by the deletion.
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
        public override Task DeleteUptimeCheckConfigAsync(
            DeleteUptimeCheckConfigRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteUptimeCheckConfigRequest(ref request, ref callSettings);
            return _callDeleteUptimeCheckConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an uptime check configuration. Note that this method will fail
        /// if the uptime check configuration is referenced by an alert policy or
        /// other dependent configs that would be rendered invalid by the deletion.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteUptimeCheckConfig(
            DeleteUptimeCheckConfigRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteUptimeCheckConfigRequest(ref request, ref callSettings);
            _callDeleteUptimeCheckConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the list of IPs that checkers run from
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="UptimeCheckIp"/> resources.
        /// </returns>
        public override PagedAsyncEnumerable<ListUptimeCheckIpsResponse, UptimeCheckIp> ListUptimeCheckIpsAsync(
            ListUptimeCheckIpsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListUptimeCheckIpsRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<ListUptimeCheckIpsRequest, ListUptimeCheckIpsResponse, UptimeCheckIp>(_callListUptimeCheckIps, request, callSettings);
        }

        /// <summary>
        /// Returns the list of IPs that checkers run from
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="UptimeCheckIp"/> resources.
        /// </returns>
        public override PagedEnumerable<ListUptimeCheckIpsResponse, UptimeCheckIp> ListUptimeCheckIps(
            ListUptimeCheckIpsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListUptimeCheckIpsRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<ListUptimeCheckIpsRequest, ListUptimeCheckIpsResponse, UptimeCheckIp>(_callListUptimeCheckIps, request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListUptimeCheckConfigsRequest : IPageRequest { }
    public partial class ListUptimeCheckConfigsResponse : IPageResponse<UptimeCheckConfig>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<UptimeCheckConfig> GetEnumerator() => UptimeCheckConfigs.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListUptimeCheckIpsRequest : IPageRequest { }
    public partial class ListUptimeCheckIpsResponse : IPageResponse<UptimeCheckIp>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<UptimeCheckIp> GetEnumerator() => UptimeCheckIps.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
