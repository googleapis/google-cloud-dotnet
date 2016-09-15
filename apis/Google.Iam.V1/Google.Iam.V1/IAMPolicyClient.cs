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
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Iam.V1
{
    /// <summary>
    /// Settings for a IAMPolicy wrapper.
    /// </summary>
    public sealed partial class IAMPolicySettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="IAMPolicySettings"/>.
        /// </summary>
        /// <returns>A new instance of the default IAMPolicySettings.</returns>
        public static IAMPolicySettings GetDefault() => new IAMPolicySettings();

        /// <summary>
        /// Constructs a new IAMPolicySettings object with default settings.
        /// </summary>
        public IAMPolicySettings() { }

        private IAMPolicySettings(IAMPolicySettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            SetIamPolicySettings = existing.SetIamPolicySettings?.Clone();
            GetIamPolicySettings = existing.GetIamPolicySettings?.Clone();
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings?.Clone();
        }

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="IAMPolicyClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="IAMPolicyClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="IAMPolicyClient"/> RPC methods.
        /// </summary>
        /// <returns>The "Default" retry backoff for <see cref="IAMPolicyClient"/> RPC methods.</returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="IAMPolicyClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="IAMPolicyClient"/> RPC methods.
        /// </summary>
        /// <returns>The "Default" timeout backoff for <see cref="IAMPolicyClient"/> RPC methods.</returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="IAMPolicyClient"/> RPC methods is defined as:
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
        /// <see cref="IAMPolicyClient.SetIamPolicy"/> and <see cref="IAMPolicyClient.SetIamPolicyAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="IAMPolicyClient.SetIamPolicy"/> and
        /// <see cref="IAMPolicyClient.SetIamPolicyAsync"/> <see cref="RetrySettings"/> are:
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
        public CallSettings SetIamPolicySettings { get; set; } = new CallSettings
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
        /// <see cref="IAMPolicyClient.GetIamPolicy"/> and <see cref="IAMPolicyClient.GetIamPolicyAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="IAMPolicyClient.GetIamPolicy"/> and
        /// <see cref="IAMPolicyClient.GetIamPolicyAsync"/> <see cref="RetrySettings"/> are:
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
        public CallSettings GetIamPolicySettings { get; set; } = new CallSettings
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
        /// <see cref="IAMPolicyClient.TestIamPermissions"/> and <see cref="IAMPolicyClient.TestIamPermissionsAsync"/>.
        /// </summary>
        /// <remarks>
        /// The default <see cref="IAMPolicyClient.TestIamPermissions"/> and
        /// <see cref="IAMPolicyClient.TestIamPermissionsAsync"/> <see cref="RetrySettings"/> are:
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
        public CallSettings TestIamPermissionsSettings { get; set; } = new CallSettings
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
        /// <returns>A deep clone of this set of IAMPolicy settings.</returns>
        public IAMPolicySettings Clone() => new IAMPolicySettings(this);
    }

    /// <summary>
    /// IAMPolicy client wrapper, for convenient use.
    /// </summary>
    public abstract partial class IAMPolicyClient
    {
        /// <summary>
        /// The default IAMPolicy scopes
        /// </summary>
        /// <remarks>
        /// The default IAMPolicy scopes are:
        /// <list type="bullet">
        /// <item><description>""</description></item>
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new string[] {
        });

        private static readonly ChannelPool s_channelPool = new ChannelPool(DefaultScopes);

        // Note: we could have parameterless overloads of Create and CreateAsync,
        // documented to just use the default endpoint, settings and credentials.
        // Pros:
        // - Might be more reassuring on first use
        // - Allows method group conversions
        // Con: overloads!

        /// <summary>
        /// Asynchronously creates a <see cref="IAMPolicyClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="IAMPolicySettings"/>.</param>
        /// <returns>The task representing the created <see cref="IAMPolicyClient"/>.</returns>
        public static async Task<IAMPolicyClient> CreateAsync(ServiceEndpoint endpoint, IAMPolicySettings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="IAMPolicyClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="IAMPolicySettings"/>.</param>
        /// <returns>The created <see cref="IAMPolicyClient"/>.</returns>
        public static IAMPolicyClient Create(ServiceEndpoint endpoint, IAMPolicySettings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="IAMPolicyClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="IAMPolicySettings"/>.</param>
        /// <returns>The created <see cref="IAMPolicyClient"/>.</returns>
        public static IAMPolicyClient Create(Channel channel, IAMPolicySettings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            IAMPolicy.IAMPolicyClient grpcClient = new IAMPolicy.IAMPolicyClient(channel);
            return new IAMPolicyClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, IAMPolicySettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, IAMPolicySettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, IAMPolicySettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, IAMPolicySettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying GRPC IAMPolicy client.
        /// </summary>
        public virtual IAMPolicy.IAMPolicyClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which policy is being specified.
        /// Resource is usually specified as a path, such as,
        /// projects/{project}/zones/{zone}/disks/{disk}.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the 'resource'. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is in general a
        /// valid policy but certain services (like Projects) might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<Policy> SetIamPolicyAsync(
            string resource,
            Policy policy,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which policy is being specified.
        /// Resource is usually specified as a path, such as,
        /// projects/{project}/zones/{zone}/disks/{disk}.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the 'resource'. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is in general a
        /// valid policy but certain services (like Projects) might reject them.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<Policy> SetIamPolicyAsync(
            string resource,
            Policy policy,
            CancellationToken cancellationToken) => SetIamPolicyAsync(
                resource,
                policy,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which policy is being specified.
        /// Resource is usually specified as a path, such as,
        /// projects/{project}/zones/{zone}/disks/{disk}.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the 'resource'. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is in general a
        /// valid policy but certain services (like Projects) might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy SetIamPolicy(
            string resource,
            Policy policy,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the access control policy for a resource. Is empty if the
        /// policy or the resource does not exist.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which policy is being requested. Resource
        /// is usually specified as a path, such as, projects/{project}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<Policy> GetIamPolicyAsync(
            string resource,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the access control policy for a resource. Is empty if the
        /// policy or the resource does not exist.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which policy is being requested. Resource
        /// is usually specified as a path, such as, projects/{project}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<Policy> GetIamPolicyAsync(
            string resource,
            CancellationToken cancellationToken) => GetIamPolicyAsync(
                resource,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Gets the access control policy for a resource. Is empty if the
        /// policy or the resource does not exist.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which policy is being requested. Resource
        /// is usually specified as a path, such as, projects/{project}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy GetIamPolicy(
            string resource,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which policy detail is being requested.
        /// Resource is usually specified as a path, such as, projects/{project}.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the 'resource'. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<TestIamPermissionsResponse> TestIamPermissionsAsync(
            string resource,
            IEnumerable<string> permissions,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which policy detail is being requested.
        /// Resource is usually specified as a path, such as, projects/{project}.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the 'resource'. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed.
        /// </param>
        /// <param name="cancellationToken">A <see cref="CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual Task<TestIamPermissionsResponse> TestIamPermissionsAsync(
            string resource,
            IEnumerable<string> permissions,
            CancellationToken cancellationToken) => TestIamPermissionsAsync(
                resource,
                permissions,
                new CallSettings { CancellationToken = cancellationToken });

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which policy detail is being requested.
        /// Resource is usually specified as a path, such as, projects/{project}.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the 'resource'. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TestIamPermissionsResponse TestIamPermissions(
            string resource,
            IEnumerable<string> permissions,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    public sealed partial class IAMPolicyClientImpl : IAMPolicyClient
    {
        private readonly ClientHelper _clientHelper;
        private readonly ApiCall<SetIamPolicyRequest, Policy> _callSetIamPolicy;
        private readonly ApiCall<GetIamPolicyRequest, Policy> _callGetIamPolicy;
        private readonly ApiCall<TestIamPermissionsRequest, TestIamPermissionsResponse> _callTestIamPermissions;

        public IAMPolicyClientImpl(IAMPolicy.IAMPolicyClient grpcClient, IAMPolicySettings settings)
        {
            this.GrpcClient = grpcClient;
            IAMPolicySettings effectiveSettings = settings ?? IAMPolicySettings.GetDefault();
            _clientHelper = new ClientHelper(effectiveSettings);
            _callSetIamPolicy = _clientHelper.BuildApiCall<SetIamPolicyRequest, Policy>(
                GrpcClient.SetIamPolicyAsync, GrpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings);
            _callGetIamPolicy = _clientHelper.BuildApiCall<GetIamPolicyRequest, Policy>(
                GrpcClient.GetIamPolicyAsync, GrpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings);
            _callTestIamPermissions = _clientHelper.BuildApiCall<TestIamPermissionsRequest, TestIamPermissionsResponse>(
                GrpcClient.TestIamPermissionsAsync, GrpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings);
        }

        public override IAMPolicy.IAMPolicyClient GrpcClient { get; }

        /// <summary>
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which policy is being specified.
        /// Resource is usually specified as a path, such as,
        /// projects/{project}/zones/{zone}/disks/{disk}.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the 'resource'. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is in general a
        /// valid policy but certain services (like Projects) might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
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
        /// Sets the access control policy on the specified resource. Replaces any
        /// existing policy.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which policy is being specified.
        /// Resource is usually specified as a path, such as,
        /// projects/{project}/zones/{zone}/disks/{disk}.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the 'resource'. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is in general a
        /// valid policy but certain services (like Projects) might reject them.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
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
        /// Gets the access control policy for a resource. Is empty if the
        /// policy or the resource does not exist.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which policy is being requested. Resource
        /// is usually specified as a path, such as, projects/{project}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override Task<Policy> GetIamPolicyAsync(
            string resource,
            CallSettings callSettings = null) => _callGetIamPolicy.Async(
                new GetIamPolicyRequest
                {
                    Resource = resource,
                },
                callSettings);

        /// <summary>
        /// Gets the access control policy for a resource. Is empty if the
        /// policy or the resource does not exist.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which policy is being requested. Resource
        /// is usually specified as a path, such as, projects/{project}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Policy GetIamPolicy(
            string resource,
            CallSettings callSettings = null) => _callGetIamPolicy.Sync(
                new GetIamPolicyRequest
                {
                    Resource = resource,
                },
                callSettings);

        /// <summary>
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which policy detail is being requested.
        /// Resource is usually specified as a path, such as, projects/{project}.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the 'resource'. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
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
        /// Returns permissions that a caller has on the specified resource.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which policy detail is being requested.
        /// Resource is usually specified as a path, such as, projects/{project}.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the 'resource'. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
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