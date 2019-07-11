// Copyright 2019 Google LLC
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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using pb = Google.Protobuf;
using pbwkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Monitoring.V3
{
    /// <summary>
    /// Settings for a <see cref="AlertPolicyServiceClient"/>.
    /// </summary>
    public sealed partial class AlertPolicyServiceSettings : gaxgrpc::ServiceSettingsBase
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
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListAlertPoliciesSettings = existing.ListAlertPoliciesSettings;
            GetAlertPolicySettings = existing.GetAlertPolicySettings;
            CreateAlertPolicySettings = existing.CreateAlertPolicySettings;
            DeleteAlertPolicySettings = existing.DeleteAlertPolicySettings;
            UpdateAlertPolicySettings = existing.UpdateAlertPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(AlertPolicyServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="AlertPolicyServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> IdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="AlertPolicyServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

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
        public static gaxgrpc::BackoffSettings GetDefaultRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(100),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
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
        public static gaxgrpc::BackoffSettings GetDefaultTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(20000),
            maxDelay: sys::TimeSpan.FromMilliseconds(20000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlertPolicyServiceClient.ListAlertPolicies</c> and <c>AlertPolicyServiceClient.ListAlertPoliciesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>AlertPolicyServiceClient.ListAlertPolicies</c> and
        /// <c>AlertPolicyServiceClient.ListAlertPoliciesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListAlertPoliciesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlertPolicyServiceClient.GetAlertPolicy</c> and <c>AlertPolicyServiceClient.GetAlertPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>AlertPolicyServiceClient.GetAlertPolicy</c> and
        /// <c>AlertPolicyServiceClient.GetAlertPolicyAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetAlertPolicySettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlertPolicyServiceClient.CreateAlertPolicy</c> and <c>AlertPolicyServiceClient.CreateAlertPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>AlertPolicyServiceClient.CreateAlertPolicy</c> and
        /// <c>AlertPolicyServiceClient.CreateAlertPolicyAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateAlertPolicySettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlertPolicyServiceClient.DeleteAlertPolicy</c> and <c>AlertPolicyServiceClient.DeleteAlertPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>AlertPolicyServiceClient.DeleteAlertPolicy</c> and
        /// <c>AlertPolicyServiceClient.DeleteAlertPolicyAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAlertPolicySettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AlertPolicyServiceClient.UpdateAlertPolicy</c> and <c>AlertPolicyServiceClient.UpdateAlertPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>AlertPolicyServiceClient.UpdateAlertPolicy</c> and
        /// <c>AlertPolicyServiceClient.UpdateAlertPolicyAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings UpdateAlertPolicySettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="AlertPolicyServiceSettings"/> object.</returns>
        public AlertPolicyServiceSettings Clone() => new AlertPolicyServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AlertPolicyServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class AlertPolicyServiceClientBuilder : gaxgrpc::ClientBuilderBase<AlertPolicyServiceClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public AlertPolicyServiceSettings Settings { get; set; }

        /// <inheritdoc/>
        public override AlertPolicyServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AlertPolicyServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<AlertPolicyServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AlertPolicyServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => AlertPolicyServiceClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => AlertPolicyServiceClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => AlertPolicyServiceClient.ChannelPool;
    }

    /// <summary>
    /// AlertPolicyService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class AlertPolicyServiceClient
    {
        /// <summary>
        /// The default endpoint for the AlertPolicyService service, which is a host of "monitoring.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("monitoring.googleapis.com", 443);

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
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/monitoring",
            "https://www.googleapis.com/auth/monitoring.read",
            "https://www.googleapis.com/auth/monitoring.write",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="AlertPolicyServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Monitoring.V3;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// AlertPolicyServiceClient client = await AlertPolicyServiceClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Monitoring.V3;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     AlertPolicyServiceClient.DefaultEndpoint.Host, AlertPolicyServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// AlertPolicyServiceClient client = AlertPolicyServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="AlertPolicyServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="AlertPolicyServiceClient"/>.</returns>
        public static async stt::Task<AlertPolicyServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, AlertPolicyServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="AlertPolicyServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Monitoring.V3;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// AlertPolicyServiceClient client = AlertPolicyServiceClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Monitoring.V3;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     AlertPolicyServiceClient.DefaultEndpoint.Host, AlertPolicyServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// AlertPolicyServiceClient client = AlertPolicyServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="AlertPolicyServiceSettings"/>.</param>
        /// <returns>The created <see cref="AlertPolicyServiceClient"/>.</returns>
        public static AlertPolicyServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, AlertPolicyServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="AlertPolicyServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="AlertPolicyServiceSettings"/>.</param>
        /// <returns>The created <see cref="AlertPolicyServiceClient"/>.</returns>
        public static AlertPolicyServiceClient Create(grpccore::Channel channel, AlertPolicyServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="AlertPolicyServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="AlertPolicyServiceSettings"/>.</param>
        /// <returns>The created <see cref="AlertPolicyServiceClient"/>.</returns>
        public static AlertPolicyServiceClient Create(grpccore::CallInvoker callInvoker, AlertPolicyServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AlertPolicyService.AlertPolicyServiceClient grpcClient = new AlertPolicyService.AlertPolicyServiceClient(callInvoker);
            return new AlertPolicyServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, AlertPolicyServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, AlertPolicyServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, AlertPolicyServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, AlertPolicyServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC AlertPolicyService client.
        /// </summary>
        public virtual AlertPolicyService.AlertPolicyServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
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
        public virtual gax::PagedAsyncEnumerable<ListAlertPoliciesResponse, AlertPolicy> ListAlertPoliciesAsync(
            ProjectName name,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListAlertPoliciesAsync(
                new ListAlertPoliciesRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
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
        public virtual gax::PagedEnumerable<ListAlertPoliciesResponse, AlertPolicy> ListAlertPolicies(
            ProjectName name,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListAlertPolicies(
                new ListAlertPoliciesRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
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
        /// A pageable asynchronous sequence of <see cref="AlertPolicy"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListAlertPoliciesResponse, AlertPolicy> ListAlertPoliciesAsync(
            string name,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListAlertPoliciesAsync(
                new ListAlertPoliciesRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
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
        public virtual gax::PagedEnumerable<ListAlertPoliciesResponse, AlertPolicy> ListAlertPolicies(
            string name,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListAlertPolicies(
                new ListAlertPoliciesRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
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
        public virtual gax::PagedAsyncEnumerable<ListAlertPoliciesResponse, AlertPolicy> ListAlertPoliciesAsync(
            ListAlertPoliciesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        public virtual gax::PagedEnumerable<ListAlertPoliciesResponse, AlertPolicy> ListAlertPolicies(
            ListAlertPoliciesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        public virtual stt::Task<AlertPolicy> GetAlertPolicyAsync(
            AlertPolicyName name,
            gaxgrpc::CallSettings callSettings = null) => GetAlertPolicyAsync(
                new GetAlertPolicyRequest
                {
                    AlertPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<AlertPolicy> GetAlertPolicyAsync(
            AlertPolicyName name,
            st::CancellationToken cancellationToken) => GetAlertPolicyAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null) => GetAlertPolicy(
                new GetAlertPolicyRequest
                {
                    AlertPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
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
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<AlertPolicy> GetAlertPolicyAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetAlertPolicyAsync(
                new GetAlertPolicyRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<AlertPolicy> GetAlertPolicyAsync(
            string name,
            st::CancellationToken cancellationToken) => GetAlertPolicyAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetAlertPolicy(
                new GetAlertPolicyRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
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
        public virtual stt::Task<AlertPolicy> GetAlertPolicyAsync(
            GetAlertPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets a single alerting policy.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<AlertPolicy> GetAlertPolicyAsync(
            GetAlertPolicyRequest request,
            st::CancellationToken cancellationToken) => GetAlertPolicyAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        public virtual stt::Task<AlertPolicy> CreateAlertPolicyAsync(
            ProjectName name,
            AlertPolicy alertPolicy,
            gaxgrpc::CallSettings callSettings = null) => CreateAlertPolicyAsync(
                new CreateAlertPolicyRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    AlertPolicy = gax::GaxPreconditions.CheckNotNull(alertPolicy, nameof(alertPolicy)),
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<AlertPolicy> CreateAlertPolicyAsync(
            ProjectName name,
            AlertPolicy alertPolicy,
            st::CancellationToken cancellationToken) => CreateAlertPolicyAsync(
                name,
                alertPolicy,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null) => CreateAlertPolicy(
                new CreateAlertPolicyRequest
                {
                    ProjectName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    AlertPolicy = gax::GaxPreconditions.CheckNotNull(alertPolicy, nameof(alertPolicy)),
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
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<AlertPolicy> CreateAlertPolicyAsync(
            string name,
            AlertPolicy alertPolicy,
            gaxgrpc::CallSettings callSettings = null) => CreateAlertPolicyAsync(
                new CreateAlertPolicyRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    AlertPolicy = gax::GaxPreconditions.CheckNotNull(alertPolicy, nameof(alertPolicy)),
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<AlertPolicy> CreateAlertPolicyAsync(
            string name,
            AlertPolicy alertPolicy,
            st::CancellationToken cancellationToken) => CreateAlertPolicyAsync(
                name,
                alertPolicy,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            string name,
            AlertPolicy alertPolicy,
            gaxgrpc::CallSettings callSettings = null) => CreateAlertPolicy(
                new CreateAlertPolicyRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    AlertPolicy = gax::GaxPreconditions.CheckNotNull(alertPolicy, nameof(alertPolicy)),
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
        public virtual stt::Task<AlertPolicy> CreateAlertPolicyAsync(
            CreateAlertPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a new alerting policy.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<AlertPolicy> CreateAlertPolicyAsync(
            CreateAlertPolicyRequest request,
            st::CancellationToken cancellationToken) => CreateAlertPolicyAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        public virtual stt::Task DeleteAlertPolicyAsync(
            AlertPolicyName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteAlertPolicyAsync(
                new DeleteAlertPolicyRequest
                {
                    AlertPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteAlertPolicyAsync(
            AlertPolicyName name,
            st::CancellationToken cancellationToken) => DeleteAlertPolicyAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null) => DeleteAlertPolicy(
                new DeleteAlertPolicyRequest
                {
                    AlertPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
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
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteAlertPolicyAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteAlertPolicyAsync(
                new DeleteAlertPolicyRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteAlertPolicyAsync(
            string name,
            st::CancellationToken cancellationToken) => DeleteAlertPolicyAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteAlertPolicy(
                new DeleteAlertPolicyRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
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
        public virtual stt::Task DeleteAlertPolicyAsync(
            DeleteAlertPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes an alerting policy.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteAlertPolicyAsync(
            DeleteAlertPolicyRequest request,
            st::CancellationToken cancellationToken) => DeleteAlertPolicyAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        public virtual stt::Task<AlertPolicy> UpdateAlertPolicyAsync(
            pbwkt::FieldMask updateMask,
            AlertPolicy alertPolicy,
            gaxgrpc::CallSettings callSettings = null) => UpdateAlertPolicyAsync(
                new UpdateAlertPolicyRequest
                {
                    UpdateMask = updateMask, // Optional
                    AlertPolicy = gax::GaxPreconditions.CheckNotNull(alertPolicy, nameof(alertPolicy)),
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<AlertPolicy> UpdateAlertPolicyAsync(
            pbwkt::FieldMask updateMask,
            AlertPolicy alertPolicy,
            st::CancellationToken cancellationToken) => UpdateAlertPolicyAsync(
                updateMask,
                alertPolicy,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            pbwkt::FieldMask updateMask,
            AlertPolicy alertPolicy,
            gaxgrpc::CallSettings callSettings = null) => UpdateAlertPolicy(
                new UpdateAlertPolicyRequest
                {
                    UpdateMask = updateMask, // Optional
                    AlertPolicy = gax::GaxPreconditions.CheckNotNull(alertPolicy, nameof(alertPolicy)),
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
        public virtual stt::Task<AlertPolicy> UpdateAlertPolicyAsync(
            UpdateAlertPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<AlertPolicy> UpdateAlertPolicyAsync(
            UpdateAlertPolicyRequest request,
            st::CancellationToken cancellationToken) => UpdateAlertPolicyAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// AlertPolicyService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class AlertPolicyServiceClientImpl : AlertPolicyServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListAlertPoliciesRequest, ListAlertPoliciesResponse> _callListAlertPolicies;
        private readonly gaxgrpc::ApiCall<GetAlertPolicyRequest, AlertPolicy> _callGetAlertPolicy;
        private readonly gaxgrpc::ApiCall<CreateAlertPolicyRequest, AlertPolicy> _callCreateAlertPolicy;
        private readonly gaxgrpc::ApiCall<DeleteAlertPolicyRequest, pbwkt::Empty> _callDeleteAlertPolicy;
        private readonly gaxgrpc::ApiCall<UpdateAlertPolicyRequest, AlertPolicy> _callUpdateAlertPolicy;

        /// <summary>
        /// Constructs a client wrapper for the AlertPolicyService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AlertPolicyServiceSettings"/> used within this client </param>
        public AlertPolicyServiceClientImpl(AlertPolicyService.AlertPolicyServiceClient grpcClient, AlertPolicyServiceSettings settings)
        {
            GrpcClient = grpcClient;
            AlertPolicyServiceSettings effectiveSettings = settings ?? AlertPolicyServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callListAlertPolicies = clientHelper.BuildApiCall<ListAlertPoliciesRequest, ListAlertPoliciesResponse>(
                GrpcClient.ListAlertPoliciesAsync, GrpcClient.ListAlertPolicies, effectiveSettings.ListAlertPoliciesSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callGetAlertPolicy = clientHelper.BuildApiCall<GetAlertPolicyRequest, AlertPolicy>(
                GrpcClient.GetAlertPolicyAsync, GrpcClient.GetAlertPolicy, effectiveSettings.GetAlertPolicySettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callCreateAlertPolicy = clientHelper.BuildApiCall<CreateAlertPolicyRequest, AlertPolicy>(
                GrpcClient.CreateAlertPolicyAsync, GrpcClient.CreateAlertPolicy, effectiveSettings.CreateAlertPolicySettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callDeleteAlertPolicy = clientHelper.BuildApiCall<DeleteAlertPolicyRequest, pbwkt::Empty>(
                GrpcClient.DeleteAlertPolicyAsync, GrpcClient.DeleteAlertPolicy, effectiveSettings.DeleteAlertPolicySettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callUpdateAlertPolicy = clientHelper.BuildApiCall<UpdateAlertPolicyRequest, AlertPolicy>(
                GrpcClient.UpdateAlertPolicyAsync, GrpcClient.UpdateAlertPolicy, effectiveSettings.UpdateAlertPolicySettings)
                .WithGoogleRequestParam("alert_policy.name", request => request.AlertPolicy?.Name);
            Modify_ApiCall(ref _callListAlertPolicies);
            Modify_ListAlertPoliciesApiCall(ref _callListAlertPolicies);
            Modify_ApiCall(ref _callGetAlertPolicy);
            Modify_GetAlertPolicyApiCall(ref _callGetAlertPolicy);
            Modify_ApiCall(ref _callCreateAlertPolicy);
            Modify_CreateAlertPolicyApiCall(ref _callCreateAlertPolicy);
            Modify_ApiCall(ref _callDeleteAlertPolicy);
            Modify_DeleteAlertPolicyApiCall(ref _callDeleteAlertPolicy);
            Modify_ApiCall(ref _callUpdateAlertPolicy);
            Modify_UpdateAlertPolicyApiCall(ref _callUpdateAlertPolicy);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        // Partial methods are named to (mostly) ensure there cannot be conflicts with RPC method names.

        // Partial methods called for every ApiCall on construction.
        // Allows modification of all the underlying ApiCall objects.
        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call)
            where TRequest : class, pb::IMessage<TRequest>
            where TResponse : class, pb::IMessage<TResponse>;

        // Partial methods called for each ApiCall on construction.
        // Allows per-RPC-method modification of the underlying ApiCall object.
        partial void Modify_ListAlertPoliciesApiCall(ref gaxgrpc::ApiCall<ListAlertPoliciesRequest, ListAlertPoliciesResponse> call);
        partial void Modify_GetAlertPolicyApiCall(ref gaxgrpc::ApiCall<GetAlertPolicyRequest, AlertPolicy> call);
        partial void Modify_CreateAlertPolicyApiCall(ref gaxgrpc::ApiCall<CreateAlertPolicyRequest, AlertPolicy> call);
        partial void Modify_DeleteAlertPolicyApiCall(ref gaxgrpc::ApiCall<DeleteAlertPolicyRequest, pbwkt::Empty> call);
        partial void Modify_UpdateAlertPolicyApiCall(ref gaxgrpc::ApiCall<UpdateAlertPolicyRequest, AlertPolicy> call);
        partial void OnConstruction(AlertPolicyService.AlertPolicyServiceClient grpcClient, AlertPolicyServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC AlertPolicyService client.
        /// </summary>
        public override AlertPolicyService.AlertPolicyServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_ListAlertPoliciesRequest(ref ListAlertPoliciesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetAlertPolicyRequest(ref GetAlertPolicyRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateAlertPolicyRequest(ref CreateAlertPolicyRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteAlertPolicyRequest(ref DeleteAlertPolicyRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateAlertPolicyRequest(ref UpdateAlertPolicyRequest request, ref gaxgrpc::CallSettings settings);

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
        public override gax::PagedAsyncEnumerable<ListAlertPoliciesResponse, AlertPolicy> ListAlertPoliciesAsync(
            ListAlertPoliciesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAlertPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAlertPoliciesRequest, ListAlertPoliciesResponse, AlertPolicy>(_callListAlertPolicies, request, callSettings);
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
        public override gax::PagedEnumerable<ListAlertPoliciesResponse, AlertPolicy> ListAlertPolicies(
            ListAlertPoliciesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAlertPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAlertPoliciesRequest, ListAlertPoliciesResponse, AlertPolicy>(_callListAlertPolicies, request, callSettings);
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
        public override stt::Task<AlertPolicy> GetAlertPolicyAsync(
            GetAlertPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
            gaxgrpc::CallSettings callSettings = null)
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
        public override stt::Task<AlertPolicy> CreateAlertPolicyAsync(
            CreateAlertPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
            gaxgrpc::CallSettings callSettings = null)
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
        public override stt::Task DeleteAlertPolicyAsync(
            DeleteAlertPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
            gaxgrpc::CallSettings callSettings = null)
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
        public override stt::Task<AlertPolicy> UpdateAlertPolicyAsync(
            UpdateAlertPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAlertPolicyRequest(ref request, ref callSettings);
            return _callUpdateAlertPolicy.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListAlertPoliciesRequest : gaxgrpc::IPageRequest { }
    public partial class ListAlertPoliciesResponse : gaxgrpc::IPageResponse<AlertPolicy>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<AlertPolicy> GetEnumerator() => AlertPolicies.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
