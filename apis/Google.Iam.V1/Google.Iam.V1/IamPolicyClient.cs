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

namespace Google.Iam.V1
{
    /// <summary>
    /// Settings for a <see cref="IamPolicyClient"/>.
    /// </summary>
    public sealed partial class IamPolicySettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="IamPolicySettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="IamPolicySettings"/>.
        /// </returns>
        public static IamPolicySettings GetDefault() => new IamPolicySettings();

        /// <summary>
        /// Constructs a new <see cref="IamPolicySettings"/> object with default settings.
        /// </summary>
        public IamPolicySettings() { }

        private IamPolicySettings(IamPolicySettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            SetIamPolicySettings = existing.SetIamPolicySettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
        }

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="IamPolicyClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="IamPolicyClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="IamPolicyClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="IamPolicyClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="IamPolicyClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="IamPolicyClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="IamPolicyClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="IamPolicyClient"/> RPC methods is defined as:
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
        /// <c>IamPolicyClient.SetIamPolicy</c> and <c>IamPolicyClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IamPolicyClient.SetIamPolicy</c> and
        /// <c>IamPolicyClient.SetIamPolicyAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings SetIamPolicySettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IamPolicyClient.GetIamPolicy</c> and <c>IamPolicyClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IamPolicyClient.GetIamPolicy</c> and
        /// <c>IamPolicyClient.GetIamPolicyAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings GetIamPolicySettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IamPolicyClient.TestIamPermissions</c> and <c>IamPolicyClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>IamPolicyClient.TestIamPermissions</c> and
        /// <c>IamPolicyClient.TestIamPermissionsAsync</c> <see cref="RetrySettings"/> are:
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
        public CallSettings TestIamPermissionsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="IamPolicySettings"/> object.</returns>
        public IamPolicySettings Clone() => new IamPolicySettings(this);
    }

    /// <summary>
    /// IamPolicy client wrapper, for convenient use.
    /// </summary>
    public abstract partial class IamPolicyClient
    {
        /// <summary>
        /// The default endpoint for the IamPolicy service, which is a host of "iam.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("iam.googleapis.com", 443);

        /// <summary>
        /// The default IamPolicy scopes.
        /// </summary>
        /// <remarks>
        /// The default IamPolicy scopes are:
        /// <list type="bullet">
        /// <item><description>""</description></item>
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new string[] {
            "",
        });

        private static readonly ChannelPool s_channelPool = new ChannelPool(DefaultScopes);

        // Note: we could have parameterless overloads of Create and CreateAsync,
        // documented to just use the default endpoint, settings and credentials.
        // Pros:
        // - Might be more reassuring on first use
        // - Allows method group conversions
        // Con: overloads!

        /// <summary>
        /// Asynchronously creates a <see cref="IamPolicyClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="IamPolicySettings"/>.</param>
        /// <returns>The task representing the created <see cref="IamPolicyClient"/>.</returns>
        public static async Task<IamPolicyClient> CreateAsync(ServiceEndpoint endpoint = null, IamPolicySettings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="IamPolicyClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="IamPolicySettings"/>.</param>
        /// <returns>The created <see cref="IamPolicyClient"/>.</returns>
        public static IamPolicyClient Create(ServiceEndpoint endpoint = null, IamPolicySettings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="IamPolicyClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="IamPolicySettings"/>.</param>
        /// <returns>The created <see cref="IamPolicyClient"/>.</returns>
        public static IamPolicyClient Create(Channel channel, IamPolicySettings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            IAMPolicy.IAMPolicyClient grpcClient = new IAMPolicy.IAMPolicyClient(channel);
            return new IamPolicyClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, IamPolicySettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, IamPolicySettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, IamPolicySettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, IamPolicySettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC IamPolicy client.
        /// </summary>
        public virtual IAMPolicy.IAMPolicyClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="resource">
        ///
        /// </param>
        /// <param name="policy">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Policy> SetIamPolicyAsync(
            string resource,
            Policy policy,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="resource">
        ///
        /// </param>
        /// <param name="policy">
        ///
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Policy> SetIamPolicyAsync(
            string resource,
            Policy policy,
            CancellationToken cancellationToken) => SetIamPolicyAsync(
                resource,
                policy,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        ///
        /// </summary>
        /// <param name="resource">
        ///
        /// </param>
        /// <param name="policy">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Policy SetIamPolicy(
            string resource,
            Policy policy,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="resource">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Policy> GetIamPolicyAsync(
            string resource,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="resource">
        ///
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Policy> GetIamPolicyAsync(
            string resource,
            CancellationToken cancellationToken) => GetIamPolicyAsync(
                resource,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        ///
        /// </summary>
        /// <param name="resource">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Policy GetIamPolicy(
            string resource,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="resource">
        ///
        /// </param>
        /// <param name="permissions">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<TestIamPermissionsResponse> TestIamPermissionsAsync(
            string resource,
            IEnumerable<string> permissions,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="resource">
        ///
        /// </param>
        /// <param name="permissions">
        ///
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<TestIamPermissionsResponse> TestIamPermissionsAsync(
            string resource,
            IEnumerable<string> permissions,
            CancellationToken cancellationToken) => TestIamPermissionsAsync(
                resource,
                permissions,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        ///
        /// </summary>
        /// <param name="resource">
        ///
        /// </param>
        /// <param name="permissions">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual TestIamPermissionsResponse TestIamPermissions(
            string resource,
            IEnumerable<string> permissions,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    /// <summary>
    /// IamPolicy client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class IamPolicyClientImpl : IamPolicyClient
    {
        private readonly ClientHelper _clientHelper;
        private readonly ApiCall<SetIamPolicyRequest, Policy> _callSetIamPolicy;
        private readonly ApiCall<GetIamPolicyRequest, Policy> _callGetIamPolicy;
        private readonly ApiCall<TestIamPermissionsRequest, TestIamPermissionsResponse> _callTestIamPermissions;

        /// <summary>
        /// Constructs a client wrapper for the IamPolicy service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="IamPolicySettings"/> used within this client </param>
        public IamPolicyClientImpl(IAMPolicy.IAMPolicyClient grpcClient, IamPolicySettings settings)
        {
            this.GrpcClient = grpcClient;
            IamPolicySettings effectiveSettings = settings ?? IamPolicySettings.GetDefault();
            _clientHelper = new ClientHelper(effectiveSettings);
            _callSetIamPolicy = _clientHelper.BuildApiCall<SetIamPolicyRequest, Policy>(
                GrpcClient.SetIamPolicyAsync, GrpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings);
            _callGetIamPolicy = _clientHelper.BuildApiCall<GetIamPolicyRequest, Policy>(
                GrpcClient.GetIamPolicyAsync, GrpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings);
            _callTestIamPermissions = _clientHelper.BuildApiCall<TestIamPermissionsRequest, TestIamPermissionsResponse>(
                GrpcClient.TestIamPermissionsAsync, GrpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings);
        }

        /// <summary>
        /// The underlying gRPC IamPolicy client.
        /// </summary>
        public override IAMPolicy.IAMPolicyClient GrpcClient { get; }

        /// <summary>
        ///
        /// </summary>
        /// <param name="resource">
        ///
        /// </param>
        /// <param name="policy">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<Policy> SetIamPolicyAsync(
            string resource,
            Policy policy,
            CallSettings callSettings = null) => _callSetIamPolicy.Async(
                new SetIamPolicyRequest
                {
                    Resource = resource,
                    Policy = policy,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="resource">
        ///
        /// </param>
        /// <param name="policy">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override Policy SetIamPolicy(
            string resource,
            Policy policy,
            CallSettings callSettings = null) => _callSetIamPolicy.Sync(
                new SetIamPolicyRequest
                {
                    Resource = resource,
                    Policy = policy,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="resource">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<Policy> GetIamPolicyAsync(
            string resource,
            CallSettings callSettings = null) => _callGetIamPolicy.Async(
                new GetIamPolicyRequest
                {
                    Resource = resource,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="resource">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override Policy GetIamPolicy(
            string resource,
            CallSettings callSettings = null) => _callGetIamPolicy.Sync(
                new GetIamPolicyRequest
                {
                    Resource = resource,
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="resource">
        ///
        /// </param>
        /// <param name="permissions">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override Task<TestIamPermissionsResponse> TestIamPermissionsAsync(
            string resource,
            IEnumerable<string> permissions,
            CallSettings callSettings = null) => _callTestIamPermissions.Async(
                new TestIamPermissionsRequest
                {
                    Resource = resource,
                    Permissions = { permissions },
                },
                callSettings);

        /// <summary>
        ///
        /// </summary>
        /// <param name="resource">
        ///
        /// </param>
        /// <param name="permissions">
        ///
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override TestIamPermissionsResponse TestIamPermissions(
            string resource,
            IEnumerable<string> permissions,
            CallSettings callSettings = null) => _callTestIamPermissions.Sync(
                new TestIamPermissionsRequest
                {
                    Resource = resource,
                    Permissions = { permissions },
                },
                callSettings);

    }

    // Partial classes to enable page-streaming

}
