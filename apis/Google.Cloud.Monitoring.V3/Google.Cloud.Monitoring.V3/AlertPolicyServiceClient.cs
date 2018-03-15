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
    /// Settings for a <see cref="AlertPolicyServiceClient"/>.
    /// </summary>
    public sealed partial class AlertPolicyServiceSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="AlertPolicyServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="AlertPolicyServiceSettings"/>.
        /// </returns>
        public static AlertPolicyServiceSettings GetDefault() => new AlertPolicyServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AlertPolicyServiceSettings"/> object with default settings.
        /// </summary>
        public AlertPolicyServiceSettings() { }

        private AlertPolicyServiceSettings(AlertPolicyServiceSettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListAlertPoliciesSettings = existing.ListAlertPoliciesSettings;
            GetAlertPolicySettings = existing.GetAlertPolicySettings;
            CreateAlertPolicySettings = existing.CreateAlertPolicySettings;
            DeleteAlertPolicySettings = existing.DeleteAlertPolicySettings;
            UpdateAlertPolicySettings = existing.UpdateAlertPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(AlertPolicyServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="AlertPolicyServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="AlertPolicyServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="AlertPolicyServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="AlertPolicyServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="AlertPolicyServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="AlertPolicyServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="AlertPolicyServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="AlertPolicyServiceClient"/> RPC methods is defined as:
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
        /// <c>AlertPolicyServiceClient.ListAlertPolicies</c> and <c>AlertPolicyServiceClient.ListAlertPoliciesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>AlertPolicyServiceClient.ListAlertPolicies</c> and
        /// <c>AlertPolicyServiceClient.ListAlertPoliciesAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings ListAlertPoliciesSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlertPolicyServiceClient.GetAlertPolicy</c> and <c>AlertPolicyServiceClient.GetAlertPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>AlertPolicyServiceClient.GetAlertPolicy</c> and
        /// <c>AlertPolicyServiceClient.GetAlertPolicyAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings GetAlertPolicySettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlertPolicyServiceClient.CreateAlertPolicy</c> and <c>AlertPolicyServiceClient.CreateAlertPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>AlertPolicyServiceClient.CreateAlertPolicy</c> and
        /// <c>AlertPolicyServiceClient.CreateAlertPolicyAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings CreateAlertPolicySettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlertPolicyServiceClient.DeleteAlertPolicy</c> and <c>AlertPolicyServiceClient.DeleteAlertPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>AlertPolicyServiceClient.DeleteAlertPolicy</c> and
        /// <c>AlertPolicyServiceClient.DeleteAlertPolicyAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings DeleteAlertPolicySettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlertPolicyServiceClient.UpdateAlertPolicy</c> and <c>AlertPolicyServiceClient.UpdateAlertPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>AlertPolicyServiceClient.UpdateAlertPolicy</c> and
        /// <c>AlertPolicyServiceClient.UpdateAlertPolicyAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings UpdateAlertPolicySettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="AlertPolicyServiceSettings"/> object.</returns>
        public AlertPolicyServiceSettings Clone() => new AlertPolicyServiceSettings(this);
    }

    /// <summary>
    /// AlertPolicyService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class AlertPolicyServiceClient
    {
        /// <summary>
        /// The default endpoint for the AlertPolicyService service, which is a host of "monitoring.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("monitoring.googleapis.com", 443);

        /// <summary>
        /// The default AlertPolicyService scopes.
        /// </summary>
        /// <remarks>
        /// The default AlertPolicyService scopes are:
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
        /// Asynchronously creates a <see cref="AlertPolicyServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="AlertPolicyServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="AlertPolicyServiceClient"/>.</returns>
        public static async Task<AlertPolicyServiceClient> CreateAsync(ServiceEndpoint endpoint = null, AlertPolicyServiceSettings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="AlertPolicyServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="AlertPolicyServiceSettings"/>.</param>
        /// <returns>The created <see cref="AlertPolicyServiceClient"/>.</returns>
        public static AlertPolicyServiceClient Create(ServiceEndpoint endpoint = null, AlertPolicyServiceSettings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="AlertPolicyServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="AlertPolicyServiceSettings"/>.</param>
        /// <returns>The created <see cref="AlertPolicyServiceClient"/>.</returns>
        public static AlertPolicyServiceClient Create(Channel channel, AlertPolicyServiceSettings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            AlertPolicyService.AlertPolicyServiceClient grpcClient = new AlertPolicyService.AlertPolicyServiceClient(channel);
            return new AlertPolicyServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, AlertPolicyServiceSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, AlertPolicyServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, AlertPolicyServiceSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, AlertPolicyServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC AlertPolicyService client.
        /// </summary>
        public virtual AlertPolicyService.AlertPolicyServiceClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Lists the existing alerting policies for the project.
        /// </summary>
        /// <param name="name">
        /// The project whose alert policies are to be listed. The format is
        ///
        ///     projects/[PROJECT_ID]
        ///
        /// Note that this field names the parent container in which the alerting
        /// policies to be listed are stored. To retrieve a single alerting policy
        /// by name, use the
        /// [GetAlertPolicy][google.monitoring.v3.AlertPolicyService.GetAlertPolicy]
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
        /// A pageable asynchronous sequence of <see cref="AlertPolicy"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListAlertPoliciesResponse, AlertPolicy> ListAlertPoliciesAsync(
            ProjectName name,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListAlertPoliciesAsync(
                new ListAlertPoliciesRequest
                {
                    ProjectName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the existing alerting policies for the project.
        /// </summary>
        /// <param name="name">
        /// The project whose alert policies are to be listed. The format is
        ///
        ///     projects/[PROJECT_ID]
        ///
        /// Note that this field names the parent container in which the alerting
        /// policies to be listed are stored. To retrieve a single alerting policy
        /// by name, use the
        /// [GetAlertPolicy][google.monitoring.v3.AlertPolicyService.GetAlertPolicy]
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
        /// A pageable sequence of <see cref="AlertPolicy"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListAlertPoliciesResponse, AlertPolicy> ListAlertPolicies(
            ProjectName name,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListAlertPolicies(
                new ListAlertPoliciesRequest
                {
                    ProjectName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the existing alerting policies for the project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="AlertPolicy"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListAlertPoliciesResponse, AlertPolicy> ListAlertPoliciesAsync(
            ListAlertPoliciesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists the existing alerting policies for the project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="AlertPolicy"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListAlertPoliciesResponse, AlertPolicy> ListAlertPolicies(
            ListAlertPoliciesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a single alerting policy.
        /// </summary>
        /// <param name="name">
        /// The alerting policy to retrieve. The format is
        ///
        ///     projects/[PROJECT_ID]/alertPolicies/[ALERT_POLICY_ID]
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<AlertPolicy> GetAlertPolicyAsync(
            AlertPolicyName name,
            CallSettings callSettings = null) => GetAlertPolicyAsync(
                new GetAlertPolicyRequest
                {
                    AlertPolicyName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a single alerting policy.
        /// </summary>
        /// <param name="name">
        /// The alerting policy to retrieve. The format is
        ///
        ///     projects/[PROJECT_ID]/alertPolicies/[ALERT_POLICY_ID]
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<AlertPolicy> GetAlertPolicyAsync(
            AlertPolicyName name,
            CancellationToken cancellationToken) => GetAlertPolicyAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single alerting policy.
        /// </summary>
        /// <param name="name">
        /// The alerting policy to retrieve. The format is
        ///
        ///     projects/[PROJECT_ID]/alertPolicies/[ALERT_POLICY_ID]
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual AlertPolicy GetAlertPolicy(
            AlertPolicyName name,
            CallSettings callSettings = null) => GetAlertPolicy(
                new GetAlertPolicyRequest
                {
                    AlertPolicyName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a single alerting policy.
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
        public virtual Task<AlertPolicy> GetAlertPolicyAsync(
            GetAlertPolicyRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets a single alerting policy.
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
        public virtual AlertPolicy GetAlertPolicy(
            GetAlertPolicyRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new alerting policy.
        /// </summary>
        /// <param name="name">
        /// The project in which to create the alerting policy. The format is
        /// `projects/[PROJECT_ID]`.
        ///
        /// Note that this field names the parent container in which the alerting
        /// policy will be written, not the name of the created policy. The alerting
        /// policy that is returned will have a name that contains a normalized
        /// representation of this name as a prefix but adds a suffix of the form
        /// `/alertPolicies/[POLICY_ID]`, identifying the policy in the container.
        /// </param>
        /// <param name="alertPolicy">
        /// The requested alerting policy. You should omit the `name` field in this
        /// policy. The name will be returned in the new policy, including
        /// a new [ALERT_POLICY_ID] value.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<AlertPolicy> CreateAlertPolicyAsync(
            ProjectName name,
            AlertPolicy alertPolicy,
            CallSettings callSettings = null) => CreateAlertPolicyAsync(
                new CreateAlertPolicyRequest
                {
                    ProjectName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    AlertPolicy = GaxPreconditions.CheckNotNull(alertPolicy, nameof(alertPolicy)),
                },
                callSettings);

        /// <summary>
        /// Creates a new alerting policy.
        /// </summary>
        /// <param name="name">
        /// The project in which to create the alerting policy. The format is
        /// `projects/[PROJECT_ID]`.
        ///
        /// Note that this field names the parent container in which the alerting
        /// policy will be written, not the name of the created policy. The alerting
        /// policy that is returned will have a name that contains a normalized
        /// representation of this name as a prefix but adds a suffix of the form
        /// `/alertPolicies/[POLICY_ID]`, identifying the policy in the container.
        /// </param>
        /// <param name="alertPolicy">
        /// The requested alerting policy. You should omit the `name` field in this
        /// policy. The name will be returned in the new policy, including
        /// a new [ALERT_POLICY_ID] value.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<AlertPolicy> CreateAlertPolicyAsync(
            ProjectName name,
            AlertPolicy alertPolicy,
            CancellationToken cancellationToken) => CreateAlertPolicyAsync(
                name,
                alertPolicy,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new alerting policy.
        /// </summary>
        /// <param name="name">
        /// The project in which to create the alerting policy. The format is
        /// `projects/[PROJECT_ID]`.
        ///
        /// Note that this field names the parent container in which the alerting
        /// policy will be written, not the name of the created policy. The alerting
        /// policy that is returned will have a name that contains a normalized
        /// representation of this name as a prefix but adds a suffix of the form
        /// `/alertPolicies/[POLICY_ID]`, identifying the policy in the container.
        /// </param>
        /// <param name="alertPolicy">
        /// The requested alerting policy. You should omit the `name` field in this
        /// policy. The name will be returned in the new policy, including
        /// a new [ALERT_POLICY_ID] value.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual AlertPolicy CreateAlertPolicy(
            ProjectName name,
            AlertPolicy alertPolicy,
            CallSettings callSettings = null) => CreateAlertPolicy(
                new CreateAlertPolicyRequest
                {
                    ProjectName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                    AlertPolicy = GaxPreconditions.CheckNotNull(alertPolicy, nameof(alertPolicy)),
                },
                callSettings);

        /// <summary>
        /// Creates a new alerting policy.
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
        public virtual Task<AlertPolicy> CreateAlertPolicyAsync(
            CreateAlertPolicyRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a new alerting policy.
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
        public virtual AlertPolicy CreateAlertPolicy(
            CreateAlertPolicyRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes an alerting policy.
        /// </summary>
        /// <param name="name">
        /// The alerting policy to delete. The format is:
        ///
        ///     projects/[PROJECT_ID]/alertPolicies/[ALERT_POLICY_ID]
        ///
        /// For more information, see [AlertPolicy][google.monitoring.v3.AlertPolicy].
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual Task DeleteAlertPolicyAsync(
            AlertPolicyName name,
            CallSettings callSettings = null) => DeleteAlertPolicyAsync(
                new DeleteAlertPolicyRequest
                {
                    AlertPolicyName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes an alerting policy.
        /// </summary>
        /// <param name="name">
        /// The alerting policy to delete. The format is:
        ///
        ///     projects/[PROJECT_ID]/alertPolicies/[ALERT_POLICY_ID]
        ///
        /// For more information, see [AlertPolicy][google.monitoring.v3.AlertPolicy].
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual Task DeleteAlertPolicyAsync(
            AlertPolicyName name,
            CancellationToken cancellationToken) => DeleteAlertPolicyAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an alerting policy.
        /// </summary>
        /// <param name="name">
        /// The alerting policy to delete. The format is:
        ///
        ///     projects/[PROJECT_ID]/alertPolicies/[ALERT_POLICY_ID]
        ///
        /// For more information, see [AlertPolicy][google.monitoring.v3.AlertPolicy].
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteAlertPolicy(
            AlertPolicyName name,
            CallSettings callSettings = null) => DeleteAlertPolicy(
                new DeleteAlertPolicyRequest
                {
                    AlertPolicyName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes an alerting policy.
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
        public virtual Task DeleteAlertPolicyAsync(
            DeleteAlertPolicyRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes an alerting policy.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteAlertPolicy(
            DeleteAlertPolicyRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates an alerting policy. You can either replace the entire policy with
        /// a new one or replace only certain fields in the current alerting policy by
        /// specifying the fields to be updated via `updateMask`. Returns the
        /// updated alerting policy.
        /// </summary>
        /// <param name="updateMask">
        /// Optional. A list of alerting policy field names. If this field is not
        /// empty, each listed field in the existing alerting policy is set to the
        /// value of the corresponding field in the supplied policy (`alert_policy`),
        /// or to the field's default value if the field is not in the supplied
        /// alerting policy.  Fields not listed retain their previous value.
        ///
        /// Examples of valid field masks include `display_name`, `documentation`,
        /// `documentation.content`, `documentation.mime_type`, `user_labels`,
        /// `user_label.nameofkey`, `enabled`, `conditions`, `combiner`, etc.
        ///
        /// If this field is empty, then the supplied alerting policy replaces the
        /// existing policy. It is the same as deleting the existing policy and
        /// adding the supplied policy, except for the following:
        ///
        /// +   The new policy will have the same `[ALERT_POLICY_ID]` as the former
        ///     policy. This gives you continuity with the former policy in your
        ///     notifications and incidents.
        /// +   Conditions in the new policy will keep their former `[CONDITION_ID]` if
        ///     the supplied condition includes the `name` field with that
        ///     `[CONDITION_ID]`. If the supplied condition omits the `name` field,
        ///     then a new `[CONDITION_ID]` is created.
        /// </param>
        /// <param name="alertPolicy">
        /// Required. The updated alerting policy or the updated values for the
        /// fields listed in `update_mask`.
        /// If `update_mask` is not empty, any fields in this policy that are
        /// not in `update_mask` are ignored.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<AlertPolicy> UpdateAlertPolicyAsync(
            FieldMask updateMask,
            AlertPolicy alertPolicy,
            CallSettings callSettings = null) => UpdateAlertPolicyAsync(
                new UpdateAlertPolicyRequest
                {
                    UpdateMask = updateMask, // Optional
                    AlertPolicy = GaxPreconditions.CheckNotNull(alertPolicy, nameof(alertPolicy)),
                },
                callSettings);

        /// <summary>
        /// Updates an alerting policy. You can either replace the entire policy with
        /// a new one or replace only certain fields in the current alerting policy by
        /// specifying the fields to be updated via `updateMask`. Returns the
        /// updated alerting policy.
        /// </summary>
        /// <param name="updateMask">
        /// Optional. A list of alerting policy field names. If this field is not
        /// empty, each listed field in the existing alerting policy is set to the
        /// value of the corresponding field in the supplied policy (`alert_policy`),
        /// or to the field's default value if the field is not in the supplied
        /// alerting policy.  Fields not listed retain their previous value.
        ///
        /// Examples of valid field masks include `display_name`, `documentation`,
        /// `documentation.content`, `documentation.mime_type`, `user_labels`,
        /// `user_label.nameofkey`, `enabled`, `conditions`, `combiner`, etc.
        ///
        /// If this field is empty, then the supplied alerting policy replaces the
        /// existing policy. It is the same as deleting the existing policy and
        /// adding the supplied policy, except for the following:
        ///
        /// +   The new policy will have the same `[ALERT_POLICY_ID]` as the former
        ///     policy. This gives you continuity with the former policy in your
        ///     notifications and incidents.
        /// +   Conditions in the new policy will keep their former `[CONDITION_ID]` if
        ///     the supplied condition includes the `name` field with that
        ///     `[CONDITION_ID]`. If the supplied condition omits the `name` field,
        ///     then a new `[CONDITION_ID]` is created.
        /// </param>
        /// <param name="alertPolicy">
        /// Required. The updated alerting policy or the updated values for the
        /// fields listed in `update_mask`.
        /// If `update_mask` is not empty, any fields in this policy that are
        /// not in `update_mask` are ignored.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<AlertPolicy> UpdateAlertPolicyAsync(
            FieldMask updateMask,
            AlertPolicy alertPolicy,
            CancellationToken cancellationToken) => UpdateAlertPolicyAsync(
                updateMask,
                alertPolicy,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an alerting policy. You can either replace the entire policy with
        /// a new one or replace only certain fields in the current alerting policy by
        /// specifying the fields to be updated via `updateMask`. Returns the
        /// updated alerting policy.
        /// </summary>
        /// <param name="updateMask">
        /// Optional. A list of alerting policy field names. If this field is not
        /// empty, each listed field in the existing alerting policy is set to the
        /// value of the corresponding field in the supplied policy (`alert_policy`),
        /// or to the field's default value if the field is not in the supplied
        /// alerting policy.  Fields not listed retain their previous value.
        ///
        /// Examples of valid field masks include `display_name`, `documentation`,
        /// `documentation.content`, `documentation.mime_type`, `user_labels`,
        /// `user_label.nameofkey`, `enabled`, `conditions`, `combiner`, etc.
        ///
        /// If this field is empty, then the supplied alerting policy replaces the
        /// existing policy. It is the same as deleting the existing policy and
        /// adding the supplied policy, except for the following:
        ///
        /// +   The new policy will have the same `[ALERT_POLICY_ID]` as the former
        ///     policy. This gives you continuity with the former policy in your
        ///     notifications and incidents.
        /// +   Conditions in the new policy will keep their former `[CONDITION_ID]` if
        ///     the supplied condition includes the `name` field with that
        ///     `[CONDITION_ID]`. If the supplied condition omits the `name` field,
        ///     then a new `[CONDITION_ID]` is created.
        /// </param>
        /// <param name="alertPolicy">
        /// Required. The updated alerting policy or the updated values for the
        /// fields listed in `update_mask`.
        /// If `update_mask` is not empty, any fields in this policy that are
        /// not in `update_mask` are ignored.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual AlertPolicy UpdateAlertPolicy(
            FieldMask updateMask,
            AlertPolicy alertPolicy,
            CallSettings callSettings = null) => UpdateAlertPolicy(
                new UpdateAlertPolicyRequest
                {
                    UpdateMask = updateMask, // Optional
                    AlertPolicy = GaxPreconditions.CheckNotNull(alertPolicy, nameof(alertPolicy)),
                },
                callSettings);

        /// <summary>
        /// Updates an alerting policy. You can either replace the entire policy with
        /// a new one or replace only certain fields in the current alerting policy by
        /// specifying the fields to be updated via `updateMask`. Returns the
        /// updated alerting policy.
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
        public virtual Task<AlertPolicy> UpdateAlertPolicyAsync(
            UpdateAlertPolicyRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates an alerting policy. You can either replace the entire policy with
        /// a new one or replace only certain fields in the current alerting policy by
        /// specifying the fields to be updated via `updateMask`. Returns the
        /// updated alerting policy.
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
        public virtual AlertPolicy UpdateAlertPolicy(
            UpdateAlertPolicyRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    /// <summary>
    /// AlertPolicyService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class AlertPolicyServiceClientImpl : AlertPolicyServiceClient
    {
        private readonly ApiCall<ListAlertPoliciesRequest, ListAlertPoliciesResponse> _callListAlertPolicies;
        private readonly ApiCall<GetAlertPolicyRequest, AlertPolicy> _callGetAlertPolicy;
        private readonly ApiCall<CreateAlertPolicyRequest, AlertPolicy> _callCreateAlertPolicy;
        private readonly ApiCall<DeleteAlertPolicyRequest, Empty> _callDeleteAlertPolicy;
        private readonly ApiCall<UpdateAlertPolicyRequest, AlertPolicy> _callUpdateAlertPolicy;

        /// <summary>
        /// Constructs a client wrapper for the AlertPolicyService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AlertPolicyServiceSettings"/> used within this client </param>
        public AlertPolicyServiceClientImpl(AlertPolicyService.AlertPolicyServiceClient grpcClient, AlertPolicyServiceSettings settings)
        {
            GrpcClient = grpcClient;
            AlertPolicyServiceSettings effectiveSettings = settings ?? AlertPolicyServiceSettings.GetDefault();
            ClientHelper clientHelper = new ClientHelper(effectiveSettings);
            _callListAlertPolicies = clientHelper.BuildApiCall<ListAlertPoliciesRequest, ListAlertPoliciesResponse>(
                GrpcClient.ListAlertPoliciesAsync, GrpcClient.ListAlertPolicies, effectiveSettings.ListAlertPoliciesSettings);
            _callGetAlertPolicy = clientHelper.BuildApiCall<GetAlertPolicyRequest, AlertPolicy>(
                GrpcClient.GetAlertPolicyAsync, GrpcClient.GetAlertPolicy, effectiveSettings.GetAlertPolicySettings);
            _callCreateAlertPolicy = clientHelper.BuildApiCall<CreateAlertPolicyRequest, AlertPolicy>(
                GrpcClient.CreateAlertPolicyAsync, GrpcClient.CreateAlertPolicy, effectiveSettings.CreateAlertPolicySettings);
            _callDeleteAlertPolicy = clientHelper.BuildApiCall<DeleteAlertPolicyRequest, Empty>(
                GrpcClient.DeleteAlertPolicyAsync, GrpcClient.DeleteAlertPolicy, effectiveSettings.DeleteAlertPolicySettings);
            _callUpdateAlertPolicy = clientHelper.BuildApiCall<UpdateAlertPolicyRequest, AlertPolicy>(
                GrpcClient.UpdateAlertPolicyAsync, GrpcClient.UpdateAlertPolicy, effectiveSettings.UpdateAlertPolicySettings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void OnConstruction(AlertPolicyService.AlertPolicyServiceClient grpcClient, AlertPolicyServiceSettings effectiveSettings, ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC AlertPolicyService client.
        /// </summary>
        public override AlertPolicyService.AlertPolicyServiceClient GrpcClient { get; }

        // Partial modifier methods contain '_' to ensure no name conflicts with RPC methods.
        partial void Modify_ListAlertPoliciesRequest(ref ListAlertPoliciesRequest request, ref CallSettings settings);
        partial void Modify_GetAlertPolicyRequest(ref GetAlertPolicyRequest request, ref CallSettings settings);
        partial void Modify_CreateAlertPolicyRequest(ref CreateAlertPolicyRequest request, ref CallSettings settings);
        partial void Modify_DeleteAlertPolicyRequest(ref DeleteAlertPolicyRequest request, ref CallSettings settings);
        partial void Modify_UpdateAlertPolicyRequest(ref UpdateAlertPolicyRequest request, ref CallSettings settings);

        /// <summary>
        /// Lists the existing alerting policies for the project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="AlertPolicy"/> resources.
        /// </returns>
        public override PagedAsyncEnumerable<ListAlertPoliciesResponse, AlertPolicy> ListAlertPoliciesAsync(
            ListAlertPoliciesRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListAlertPoliciesRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<ListAlertPoliciesRequest, ListAlertPoliciesResponse, AlertPolicy>(_callListAlertPolicies, request, callSettings);
        }

        /// <summary>
        /// Lists the existing alerting policies for the project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="AlertPolicy"/> resources.
        /// </returns>
        public override PagedEnumerable<ListAlertPoliciesResponse, AlertPolicy> ListAlertPolicies(
            ListAlertPoliciesRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListAlertPoliciesRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<ListAlertPoliciesRequest, ListAlertPoliciesResponse, AlertPolicy>(_callListAlertPolicies, request, callSettings);
        }

        /// <summary>
        /// Gets a single alerting policy.
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
        public override Task<AlertPolicy> GetAlertPolicyAsync(
            GetAlertPolicyRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetAlertPolicyRequest(ref request, ref callSettings);
            return _callGetAlertPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a single alerting policy.
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
        public override AlertPolicy GetAlertPolicy(
            GetAlertPolicyRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetAlertPolicyRequest(ref request, ref callSettings);
            return _callGetAlertPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new alerting policy.
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
        public override Task<AlertPolicy> CreateAlertPolicyAsync(
            CreateAlertPolicyRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateAlertPolicyRequest(ref request, ref callSettings);
            return _callCreateAlertPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new alerting policy.
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
        public override AlertPolicy CreateAlertPolicy(
            CreateAlertPolicyRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateAlertPolicyRequest(ref request, ref callSettings);
            return _callCreateAlertPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an alerting policy.
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
        public override Task DeleteAlertPolicyAsync(
            DeleteAlertPolicyRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteAlertPolicyRequest(ref request, ref callSettings);
            return _callDeleteAlertPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an alerting policy.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteAlertPolicy(
            DeleteAlertPolicyRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteAlertPolicyRequest(ref request, ref callSettings);
            _callDeleteAlertPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an alerting policy. You can either replace the entire policy with
        /// a new one or replace only certain fields in the current alerting policy by
        /// specifying the fields to be updated via `updateMask`. Returns the
        /// updated alerting policy.
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
        public override Task<AlertPolicy> UpdateAlertPolicyAsync(
            UpdateAlertPolicyRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateAlertPolicyRequest(ref request, ref callSettings);
            return _callUpdateAlertPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an alerting policy. You can either replace the entire policy with
        /// a new one or replace only certain fields in the current alerting policy by
        /// specifying the fields to be updated via `updateMask`. Returns the
        /// updated alerting policy.
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
        public override AlertPolicy UpdateAlertPolicy(
            UpdateAlertPolicyRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateAlertPolicyRequest(ref request, ref callSettings);
            return _callUpdateAlertPolicy.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListAlertPoliciesRequest : IPageRequest { }
    public partial class ListAlertPoliciesResponse : IPageResponse<AlertPolicy>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<AlertPolicy> GetEnumerator() => AlertPolicies.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
