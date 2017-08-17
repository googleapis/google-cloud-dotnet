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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.Iam.V1;
using Google.LongRunning;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Cloud.Spanner.Admin.Instance.V1
{
    /// <summary>
    /// Settings for a <see cref="InstanceAdminClient"/>.
    /// </summary>
    public sealed partial class InstanceAdminSettings : ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="InstanceAdminSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="InstanceAdminSettings"/>.
        /// </returns>
        public static InstanceAdminSettings GetDefault() => new InstanceAdminSettings();

        /// <summary>
        /// Constructs a new <see cref="InstanceAdminSettings"/> object with default settings.
        /// </summary>
        public InstanceAdminSettings() { }

        private InstanceAdminSettings(InstanceAdminSettings existing) : base(existing)
        {
            GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListInstanceConfigsSettings = existing.ListInstanceConfigsSettings;
            GetInstanceConfigSettings = existing.GetInstanceConfigSettings;
            ListInstancesSettings = existing.ListInstancesSettings;
            GetInstanceSettings = existing.GetInstanceSettings;
            CreateInstanceSettings = existing.CreateInstanceSettings;
            CreateInstanceOperationsSettings = existing.CreateInstanceOperationsSettings?.Clone();
            UpdateInstanceSettings = existing.UpdateInstanceSettings;
            UpdateInstanceOperationsSettings = existing.UpdateInstanceOperationsSettings?.Clone();
            DeleteInstanceSettings = existing.DeleteInstanceSettings;
            SetIamPolicySettings = existing.SetIamPolicySettings;
            GetIamPolicySettings = existing.GetIamPolicySettings;
            TestIamPermissionsSettings = existing.TestIamPermissionsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(InstanceAdminSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="InstanceAdminClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="InstanceAdminClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static Predicate<RpcException> NonIdempotentRetryFilter { get; } =
            RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="InstanceAdminClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="InstanceAdminClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="InstanceAdminClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 1000 milliseconds</description></item>
        /// <item><description>Maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultRetryBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(1000),
            maxDelay: TimeSpan.FromMilliseconds(32000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="InstanceAdminClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="InstanceAdminClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="InstanceAdminClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 60000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static BackoffSettings GetDefaultTimeoutBackoff() => new BackoffSettings(
            delay: TimeSpan.FromMilliseconds(60000),
            maxDelay: TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceAdminClient.ListInstanceConfigs</c> and <c>InstanceAdminClient.ListInstanceConfigsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>InstanceAdminClient.ListInstanceConfigs</c> and
        /// <c>InstanceAdminClient.ListInstanceConfigsAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings ListInstanceConfigsSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceAdminClient.GetInstanceConfig</c> and <c>InstanceAdminClient.GetInstanceConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>InstanceAdminClient.GetInstanceConfig</c> and
        /// <c>InstanceAdminClient.GetInstanceConfigAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings GetInstanceConfigSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceAdminClient.ListInstances</c> and <c>InstanceAdminClient.ListInstancesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>InstanceAdminClient.ListInstances</c> and
        /// <c>InstanceAdminClient.ListInstancesAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings ListInstancesSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceAdminClient.GetInstance</c> and <c>InstanceAdminClient.GetInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>InstanceAdminClient.GetInstance</c> and
        /// <c>InstanceAdminClient.GetInstanceAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings GetInstanceSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceAdminClient.CreateInstance</c> and <c>InstanceAdminClient.CreateInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>InstanceAdminClient.CreateInstance</c> and
        /// <c>InstanceAdminClient.CreateInstanceAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings CreateInstanceSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstanceAdminClient.CreateInstance</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45000 milliseconds</description></item>
        /// <item><description>Total timeout: 86400000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public OperationsSettings CreateInstanceOperationsSettings { get; set; } = new OperationsSettings
        {
            DefaultPollSettings = new PollSettings(
                Expiration.FromTimeout(TimeSpan.FromMilliseconds(86400000L)),
                TimeSpan.FromMilliseconds(20000L),
                1.5,
                TimeSpan.FromMilliseconds(45000L))
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceAdminClient.UpdateInstance</c> and <c>InstanceAdminClient.UpdateInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>InstanceAdminClient.UpdateInstance</c> and
        /// <c>InstanceAdminClient.UpdateInstanceAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings UpdateInstanceSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstanceAdminClient.UpdateInstance</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45000 milliseconds</description></item>
        /// <item><description>Total timeout: 86400000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public OperationsSettings UpdateInstanceOperationsSettings { get; set; } = new OperationsSettings
        {
            DefaultPollSettings = new PollSettings(
                Expiration.FromTimeout(TimeSpan.FromMilliseconds(86400000L)),
                TimeSpan.FromMilliseconds(20000L),
                1.5,
                TimeSpan.FromMilliseconds(45000L))
        };

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceAdminClient.DeleteInstance</c> and <c>InstanceAdminClient.DeleteInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>InstanceAdminClient.DeleteInstance</c> and
        /// <c>InstanceAdminClient.DeleteInstanceAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings DeleteInstanceSettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceAdminClient.SetIamPolicy</c> and <c>InstanceAdminClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>InstanceAdminClient.SetIamPolicy</c> and
        /// <c>InstanceAdminClient.SetIamPolicyAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
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
        /// <c>InstanceAdminClient.GetIamPolicy</c> and <c>InstanceAdminClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>InstanceAdminClient.GetIamPolicy</c> and
        /// <c>InstanceAdminClient.GetIamPolicyAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public CallSettings GetIamPolicySettings { get; set; } = CallSettings.FromCallTiming(
            CallTiming.FromRetry(new RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceAdminClient.TestIamPermissions</c> and <c>InstanceAdminClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>InstanceAdminClient.TestIamPermissions</c> and
        /// <c>InstanceAdminClient.TestIamPermissionsAsync</c> <see cref="RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 32000 milliseconds</description></item>
        /// <item><description>Initial timeout: 60000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 60000 milliseconds</description></item>
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
        /// <returns>A deep clone of this <see cref="InstanceAdminSettings"/> object.</returns>
        public InstanceAdminSettings Clone() => new InstanceAdminSettings(this);
    }

    /// <summary>
    /// InstanceAdmin client wrapper, for convenient use.
    /// </summary>
    public abstract partial class InstanceAdminClient
    {
        /// <summary>
        /// The default endpoint for the InstanceAdmin service, which is a host of "spanner.googleapis.com" and a port of 443.
        /// </summary>
        public static ServiceEndpoint DefaultEndpoint { get; } = new ServiceEndpoint("spanner.googleapis.com", 443);

        /// <summary>
        /// The default InstanceAdmin scopes.
        /// </summary>
        /// <remarks>
        /// The default InstanceAdmin scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/spanner.admin"</description></item>
        /// </list>
        /// </remarks>
        public static IReadOnlyList<string> DefaultScopes { get; } = new ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/spanner.admin",
        });

        private static readonly ChannelPool s_channelPool = new ChannelPool(DefaultScopes);

        // Note: we could have parameterless overloads of Create and CreateAsync,
        // documented to just use the default endpoint, settings and credentials.
        // Pros:
        // - Might be more reassuring on first use
        // - Allows method group conversions
        // Con: overloads!

        /// <summary>
        /// Asynchronously creates a <see cref="InstanceAdminClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="InstanceAdminSettings"/>.</param>
        /// <returns>The task representing the created <see cref="InstanceAdminClient"/>.</returns>
        public static async Task<InstanceAdminClient> CreateAsync(ServiceEndpoint endpoint = null, InstanceAdminSettings settings = null)
        {
            Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="InstanceAdminClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary.
        /// </summary>
        /// <param name="endpoint">Optional <see cref="ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="InstanceAdminSettings"/>.</param>
        /// <returns>The created <see cref="InstanceAdminClient"/>.</returns>
        public static InstanceAdminClient Create(ServiceEndpoint endpoint = null, InstanceAdminSettings settings = null)
        {
            Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="InstanceAdminClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="InstanceAdminSettings"/>.</param>
        /// <returns>The created <see cref="InstanceAdminClient"/>.</returns>
        public static InstanceAdminClient Create(Channel channel, InstanceAdminSettings settings = null)
        {
            GaxPreconditions.CheckNotNull(channel, nameof(channel));
            InstanceAdmin.InstanceAdminClient grpcClient = new InstanceAdmin.InstanceAdminClient(channel);
            return new InstanceAdminClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(ServiceEndpoint, InstanceAdminSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, InstanceAdminSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(ServiceEndpoint, InstanceAdminSettings)"/>
        /// and <see cref="CreateAsync(ServiceEndpoint, InstanceAdminSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC InstanceAdmin client.
        /// </summary>
        public virtual InstanceAdmin.InstanceAdminClient GrpcClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Lists the supported instance configurations for a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project for which a list of supported instance
        /// configurations is requested. Values are of the form
        /// `projects/&lt;project&gt;`.
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
        /// A pageable asynchronous sequence of <see cref="InstanceConfig"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListInstanceConfigsResponse, InstanceConfig> ListInstanceConfigsAsync(
            ProjectName parent,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListInstanceConfigsAsync(
                new ListInstanceConfigsRequest
                {
                    ParentAsProjectName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the supported instance configurations for a given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project for which a list of supported instance
        /// configurations is requested. Values are of the form
        /// `projects/&lt;project&gt;`.
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
        /// A pageable sequence of <see cref="InstanceConfig"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListInstanceConfigsResponse, InstanceConfig> ListInstanceConfigs(
            ProjectName parent,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListInstanceConfigs(
                new ListInstanceConfigsRequest
                {
                    ParentAsProjectName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists the supported instance configurations for a given project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="InstanceConfig"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListInstanceConfigsResponse, InstanceConfig> ListInstanceConfigsAsync(
            ListInstanceConfigsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists the supported instance configurations for a given project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="InstanceConfig"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListInstanceConfigsResponse, InstanceConfig> ListInstanceConfigs(
            ListInstanceConfigsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets information about a particular instance configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the requested instance configuration. Values are of
        /// the form `projects/&lt;project&gt;/instanceConfigs/&lt;config&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<InstanceConfig> GetInstanceConfigAsync(
            InstanceConfigName name,
            CallSettings callSettings = null) => GetInstanceConfigAsync(
                new GetInstanceConfigRequest
                {
                    InstanceConfigName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets information about a particular instance configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the requested instance configuration. Values are of
        /// the form `projects/&lt;project&gt;/instanceConfigs/&lt;config&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<InstanceConfig> GetInstanceConfigAsync(
            InstanceConfigName name,
            CancellationToken cancellationToken) => GetInstanceConfigAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a particular instance configuration.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the requested instance configuration. Values are of
        /// the form `projects/&lt;project&gt;/instanceConfigs/&lt;config&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual InstanceConfig GetInstanceConfig(
            InstanceConfigName name,
            CallSettings callSettings = null) => GetInstanceConfig(
                new GetInstanceConfigRequest
                {
                    InstanceConfigName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets information about a particular instance configuration.
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
        public virtual Task<InstanceConfig> GetInstanceConfigAsync(
            GetInstanceConfigRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets information about a particular instance configuration.
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
        public virtual InstanceConfig GetInstanceConfig(
            GetInstanceConfigRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists all instances in the given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project for which a list of instances is
        /// requested. Values are of the form `projects/&lt;project&gt;`.
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
        /// A pageable asynchronous sequence of <see cref="Instance"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(
            ProjectName parent,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListInstancesAsync(
                new ListInstancesRequest
                {
                    ParentAsProjectName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists all instances in the given project.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project for which a list of instances is
        /// requested. Values are of the form `projects/&lt;project&gt;`.
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
        /// A pageable sequence of <see cref="Instance"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListInstancesResponse, Instance> ListInstances(
            ProjectName parent,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => ListInstances(
                new ListInstancesRequest
                {
                    ParentAsProjectName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists all instances in the given project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Instance"/> resources.
        /// </returns>
        public virtual PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(
            ListInstancesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Lists all instances in the given project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Instance"/> resources.
        /// </returns>
        public virtual PagedEnumerable<ListInstancesResponse, Instance> ListInstances(
            ListInstancesRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets information about a particular instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the requested instance. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Instance> GetInstanceAsync(
            InstanceName name,
            CallSettings callSettings = null) => GetInstanceAsync(
                new GetInstanceRequest
                {
                    InstanceName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets information about a particular instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the requested instance. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Instance> GetInstanceAsync(
            InstanceName name,
            CancellationToken cancellationToken) => GetInstanceAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about a particular instance.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the requested instance. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Instance GetInstance(
            InstanceName name,
            CallSettings callSettings = null) => GetInstance(
                new GetInstanceRequest
                {
                    InstanceName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets information about a particular instance.
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
        public virtual Task<Instance> GetInstanceAsync(
            GetInstanceRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets information about a particular instance.
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
        public virtual Instance GetInstance(
            GetInstanceRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates an instance and begins preparing it to begin serving. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new
        /// instance. The instance name is assigned by the caller. If the
        /// named instance already exists, `CreateInstance` returns
        /// `ALREADY_EXISTS`.
        ///
        /// Immediately upon completion of this request:
        ///
        ///   * The instance is readable via the API, with all requested attributes
        ///     but no allocated resources. Its state is `CREATING`.
        ///
        /// Until completion of the returned operation:
        ///
        ///   * Cancelling the operation renders the instance immediately unreadable
        ///     via the API.
        ///   * The instance can be deleted.
        ///   * All other attempts to modify the instance are rejected.
        ///
        /// Upon completion of the returned operation:
        ///
        ///   * Billing for all successfully-allocated resources begins (some types
        ///     may have lower than the requested levels).
        ///   * Databases can be created in the instance.
        ///   * The instance's allocated resource levels are readable via the API.
        ///   * The instance's state becomes `READY`.
        ///
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;instance_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track creation of the instance.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstanceMetadata][google.spanner.admin.instance.v1.CreateInstanceMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Instance][google.spanner.admin.instance.v1.Instance], if successful.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which to create the instance. Values
        /// are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="instanceId">
        /// Required. The ID of the instance to create.  Valid identifiers are of the
        /// form `[a-z][-a-z0-9]*[a-z0-9]` and must be between 6 and 30 characters in
        /// length.
        /// </param>
        /// <param name="instance">
        /// Required. The instance to create.  The name may be omitted, but if
        /// specified must be `&lt;parent&gt;/instances/&lt;instance_id&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<Instance, CreateInstanceMetadata>> CreateInstanceAsync(
            ProjectName parent,
            InstanceName instanceId,
            Instance instance,
            CallSettings callSettings = null) => CreateInstanceAsync(
                new CreateInstanceRequest
                {
                    ParentAsProjectName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    InstanceIdAsInstanceName = GaxPreconditions.CheckNotNull(instanceId, nameof(instanceId)),
                    Instance = GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                },
                callSettings);

        /// <summary>
        /// Creates an instance and begins preparing it to begin serving. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new
        /// instance. The instance name is assigned by the caller. If the
        /// named instance already exists, `CreateInstance` returns
        /// `ALREADY_EXISTS`.
        ///
        /// Immediately upon completion of this request:
        ///
        ///   * The instance is readable via the API, with all requested attributes
        ///     but no allocated resources. Its state is `CREATING`.
        ///
        /// Until completion of the returned operation:
        ///
        ///   * Cancelling the operation renders the instance immediately unreadable
        ///     via the API.
        ///   * The instance can be deleted.
        ///   * All other attempts to modify the instance are rejected.
        ///
        /// Upon completion of the returned operation:
        ///
        ///   * Billing for all successfully-allocated resources begins (some types
        ///     may have lower than the requested levels).
        ///   * Databases can be created in the instance.
        ///   * The instance's allocated resource levels are readable via the API.
        ///   * The instance's state becomes `READY`.
        ///
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;instance_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track creation of the instance.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstanceMetadata][google.spanner.admin.instance.v1.CreateInstanceMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Instance][google.spanner.admin.instance.v1.Instance], if successful.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which to create the instance. Values
        /// are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="instanceId">
        /// Required. The ID of the instance to create.  Valid identifiers are of the
        /// form `[a-z][-a-z0-9]*[a-z0-9]` and must be between 6 and 30 characters in
        /// length.
        /// </param>
        /// <param name="instance">
        /// Required. The instance to create.  The name may be omitted, but if
        /// specified must be `&lt;parent&gt;/instances/&lt;instance_id&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<Instance, CreateInstanceMetadata>> CreateInstanceAsync(
            ProjectName parent,
            InstanceName instanceId,
            Instance instance,
            CancellationToken cancellationToken) => CreateInstanceAsync(
                parent,
                instanceId,
                instance,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an instance and begins preparing it to begin serving. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new
        /// instance. The instance name is assigned by the caller. If the
        /// named instance already exists, `CreateInstance` returns
        /// `ALREADY_EXISTS`.
        ///
        /// Immediately upon completion of this request:
        ///
        ///   * The instance is readable via the API, with all requested attributes
        ///     but no allocated resources. Its state is `CREATING`.
        ///
        /// Until completion of the returned operation:
        ///
        ///   * Cancelling the operation renders the instance immediately unreadable
        ///     via the API.
        ///   * The instance can be deleted.
        ///   * All other attempts to modify the instance are rejected.
        ///
        /// Upon completion of the returned operation:
        ///
        ///   * Billing for all successfully-allocated resources begins (some types
        ///     may have lower than the requested levels).
        ///   * Databases can be created in the instance.
        ///   * The instance's allocated resource levels are readable via the API.
        ///   * The instance's state becomes `READY`.
        ///
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;instance_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track creation of the instance.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstanceMetadata][google.spanner.admin.instance.v1.CreateInstanceMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Instance][google.spanner.admin.instance.v1.Instance], if successful.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project in which to create the instance. Values
        /// are of the form `projects/&lt;project&gt;`.
        /// </param>
        /// <param name="instanceId">
        /// Required. The ID of the instance to create.  Valid identifiers are of the
        /// form `[a-z][-a-z0-9]*[a-z0-9]` and must be between 6 and 30 characters in
        /// length.
        /// </param>
        /// <param name="instance">
        /// Required. The instance to create.  The name may be omitted, but if
        /// specified must be `&lt;parent&gt;/instances/&lt;instance_id&gt;`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation<Instance, CreateInstanceMetadata> CreateInstance(
            ProjectName parent,
            InstanceName instanceId,
            Instance instance,
            CallSettings callSettings = null) => CreateInstance(
                new CreateInstanceRequest
                {
                    ParentAsProjectName = GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    InstanceIdAsInstanceName = GaxPreconditions.CheckNotNull(instanceId, nameof(instanceId)),
                    Instance = GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                },
                callSettings);

        /// <summary>
        /// Creates an instance and begins preparing it to begin serving. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new
        /// instance. The instance name is assigned by the caller. If the
        /// named instance already exists, `CreateInstance` returns
        /// `ALREADY_EXISTS`.
        ///
        /// Immediately upon completion of this request:
        ///
        ///   * The instance is readable via the API, with all requested attributes
        ///     but no allocated resources. Its state is `CREATING`.
        ///
        /// Until completion of the returned operation:
        ///
        ///   * Cancelling the operation renders the instance immediately unreadable
        ///     via the API.
        ///   * The instance can be deleted.
        ///   * All other attempts to modify the instance are rejected.
        ///
        /// Upon completion of the returned operation:
        ///
        ///   * Billing for all successfully-allocated resources begins (some types
        ///     may have lower than the requested levels).
        ///   * Databases can be created in the instance.
        ///   * The instance's allocated resource levels are readable via the API.
        ///   * The instance's state becomes `READY`.
        ///
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;instance_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track creation of the instance.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstanceMetadata][google.spanner.admin.instance.v1.CreateInstanceMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Instance][google.spanner.admin.instance.v1.Instance], if successful.
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
        public virtual Task<Operation<Instance, CreateInstanceMetadata>> CreateInstanceAsync(
            CreateInstanceRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateInstanceAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual Task<Operation<Instance, CreateInstanceMetadata>> PollOnceCreateInstanceAsync(
            string operationName,
            CallSettings callSettings = null) => Operation<Instance, CreateInstanceMetadata>.PollOnceFromNameAsync(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                CreateInstanceOperationsClient,
                callSettings);

        /// <summary>
        /// Creates an instance and begins preparing it to begin serving. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new
        /// instance. The instance name is assigned by the caller. If the
        /// named instance already exists, `CreateInstance` returns
        /// `ALREADY_EXISTS`.
        ///
        /// Immediately upon completion of this request:
        ///
        ///   * The instance is readable via the API, with all requested attributes
        ///     but no allocated resources. Its state is `CREATING`.
        ///
        /// Until completion of the returned operation:
        ///
        ///   * Cancelling the operation renders the instance immediately unreadable
        ///     via the API.
        ///   * The instance can be deleted.
        ///   * All other attempts to modify the instance are rejected.
        ///
        /// Upon completion of the returned operation:
        ///
        ///   * Billing for all successfully-allocated resources begins (some types
        ///     may have lower than the requested levels).
        ///   * Databases can be created in the instance.
        ///   * The instance's allocated resource levels are readable via the API.
        ///   * The instance's state becomes `READY`.
        ///
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;instance_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track creation of the instance.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstanceMetadata][google.spanner.admin.instance.v1.CreateInstanceMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Instance][google.spanner.admin.instance.v1.Instance], if successful.
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
        public virtual Operation<Instance, CreateInstanceMetadata> CreateInstance(
            CreateInstanceRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>CreateInstance</c>.
        /// </summary>
        public virtual OperationsClient CreateInstanceOperationsClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateInstance</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual Operation<Instance, CreateInstanceMetadata> PollOnceCreateInstance(
            string operationName,
            CallSettings callSettings = null) => Operation<Instance, CreateInstanceMetadata>.PollOnceFromName(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                CreateInstanceOperationsClient,
                callSettings);

        /// <summary>
        /// Updates an instance, and begins allocating or releasing resources
        /// as requested. The returned [long-running
        /// operation][google.longrunning.Operation] can be used to track the
        /// progress of updating the instance. If the named instance does not
        /// exist, returns `NOT_FOUND`.
        ///
        /// Immediately upon completion of this request:
        ///
        ///   * For resource types for which a decrease in the instance's allocation
        ///     has been requested, billing is based on the newly-requested level.
        ///
        /// Until completion of the returned operation:
        ///
        ///   * Cancelling the operation sets its metadata's
        ///     [cancel_time][google.spanner.admin.instance.v1.UpdateInstanceMetadata.cancel_time], and begins
        ///     restoring resources to their pre-request values. The operation
        ///     is guaranteed to succeed at undoing all resource changes,
        ///     after which point it terminates with a `CANCELLED` status.
        ///   * All other attempts to modify the instance are rejected.
        ///   * Reading the instance via the API continues to give the pre-request
        ///     resource levels.
        ///
        /// Upon completion of the returned operation:
        ///
        ///   * Billing begins for all successfully-allocated resources (some types
        ///     may have lower than the requested levels).
        ///   * All newly-reserved resources are available for serving the instance's
        ///     tables.
        ///   * The instance's new resource levels are readable via the API.
        ///
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;instance_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track the instance modification.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateInstanceMetadata][google.spanner.admin.instance.v1.UpdateInstanceMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Instance][google.spanner.admin.instance.v1.Instance], if successful.
        ///
        /// Authorization requires `spanner.instances.update` permission on
        /// resource [name][google.spanner.admin.instance.v1.Instance.name].
        /// </summary>
        /// <param name="instance">
        /// Required. The instance to update, which must always include the instance
        /// name.  Otherwise, only fields mentioned in [][google.spanner.admin.instance.v1.UpdateInstanceRequest.field_mask] need be included.
        /// </param>
        /// <param name="fieldMask">
        /// Required. A mask specifying which fields in [][google.spanner.admin.instance.v1.UpdateInstanceRequest.instance] should be updated.
        /// The field mask must always be specified; this prevents any future fields in
        /// [][google.spanner.admin.instance.v1.Instance] from being erased accidentally by clients that do not know
        /// about them.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<Instance, UpdateInstanceMetadata>> UpdateInstanceAsync(
            Instance instance,
            FieldMask fieldMask,
            CallSettings callSettings = null) => UpdateInstanceAsync(
                new UpdateInstanceRequest
                {
                    Instance = GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                    FieldMask = GaxPreconditions.CheckNotNull(fieldMask, nameof(fieldMask)),
                },
                callSettings);

        /// <summary>
        /// Updates an instance, and begins allocating or releasing resources
        /// as requested. The returned [long-running
        /// operation][google.longrunning.Operation] can be used to track the
        /// progress of updating the instance. If the named instance does not
        /// exist, returns `NOT_FOUND`.
        ///
        /// Immediately upon completion of this request:
        ///
        ///   * For resource types for which a decrease in the instance's allocation
        ///     has been requested, billing is based on the newly-requested level.
        ///
        /// Until completion of the returned operation:
        ///
        ///   * Cancelling the operation sets its metadata's
        ///     [cancel_time][google.spanner.admin.instance.v1.UpdateInstanceMetadata.cancel_time], and begins
        ///     restoring resources to their pre-request values. The operation
        ///     is guaranteed to succeed at undoing all resource changes,
        ///     after which point it terminates with a `CANCELLED` status.
        ///   * All other attempts to modify the instance are rejected.
        ///   * Reading the instance via the API continues to give the pre-request
        ///     resource levels.
        ///
        /// Upon completion of the returned operation:
        ///
        ///   * Billing begins for all successfully-allocated resources (some types
        ///     may have lower than the requested levels).
        ///   * All newly-reserved resources are available for serving the instance's
        ///     tables.
        ///   * The instance's new resource levels are readable via the API.
        ///
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;instance_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track the instance modification.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateInstanceMetadata][google.spanner.admin.instance.v1.UpdateInstanceMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Instance][google.spanner.admin.instance.v1.Instance], if successful.
        ///
        /// Authorization requires `spanner.instances.update` permission on
        /// resource [name][google.spanner.admin.instance.v1.Instance.name].
        /// </summary>
        /// <param name="instance">
        /// Required. The instance to update, which must always include the instance
        /// name.  Otherwise, only fields mentioned in [][google.spanner.admin.instance.v1.UpdateInstanceRequest.field_mask] need be included.
        /// </param>
        /// <param name="fieldMask">
        /// Required. A mask specifying which fields in [][google.spanner.admin.instance.v1.UpdateInstanceRequest.instance] should be updated.
        /// The field mask must always be specified; this prevents any future fields in
        /// [][google.spanner.admin.instance.v1.Instance] from being erased accidentally by clients that do not know
        /// about them.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Operation<Instance, UpdateInstanceMetadata>> UpdateInstanceAsync(
            Instance instance,
            FieldMask fieldMask,
            CancellationToken cancellationToken) => UpdateInstanceAsync(
                instance,
                fieldMask,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an instance, and begins allocating or releasing resources
        /// as requested. The returned [long-running
        /// operation][google.longrunning.Operation] can be used to track the
        /// progress of updating the instance. If the named instance does not
        /// exist, returns `NOT_FOUND`.
        ///
        /// Immediately upon completion of this request:
        ///
        ///   * For resource types for which a decrease in the instance's allocation
        ///     has been requested, billing is based on the newly-requested level.
        ///
        /// Until completion of the returned operation:
        ///
        ///   * Cancelling the operation sets its metadata's
        ///     [cancel_time][google.spanner.admin.instance.v1.UpdateInstanceMetadata.cancel_time], and begins
        ///     restoring resources to their pre-request values. The operation
        ///     is guaranteed to succeed at undoing all resource changes,
        ///     after which point it terminates with a `CANCELLED` status.
        ///   * All other attempts to modify the instance are rejected.
        ///   * Reading the instance via the API continues to give the pre-request
        ///     resource levels.
        ///
        /// Upon completion of the returned operation:
        ///
        ///   * Billing begins for all successfully-allocated resources (some types
        ///     may have lower than the requested levels).
        ///   * All newly-reserved resources are available for serving the instance's
        ///     tables.
        ///   * The instance's new resource levels are readable via the API.
        ///
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;instance_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track the instance modification.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateInstanceMetadata][google.spanner.admin.instance.v1.UpdateInstanceMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Instance][google.spanner.admin.instance.v1.Instance], if successful.
        ///
        /// Authorization requires `spanner.instances.update` permission on
        /// resource [name][google.spanner.admin.instance.v1.Instance.name].
        /// </summary>
        /// <param name="instance">
        /// Required. The instance to update, which must always include the instance
        /// name.  Otherwise, only fields mentioned in [][google.spanner.admin.instance.v1.UpdateInstanceRequest.field_mask] need be included.
        /// </param>
        /// <param name="fieldMask">
        /// Required. A mask specifying which fields in [][google.spanner.admin.instance.v1.UpdateInstanceRequest.instance] should be updated.
        /// The field mask must always be specified; this prevents any future fields in
        /// [][google.spanner.admin.instance.v1.Instance] from being erased accidentally by clients that do not know
        /// about them.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Operation<Instance, UpdateInstanceMetadata> UpdateInstance(
            Instance instance,
            FieldMask fieldMask,
            CallSettings callSettings = null) => UpdateInstance(
                new UpdateInstanceRequest
                {
                    Instance = GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                    FieldMask = GaxPreconditions.CheckNotNull(fieldMask, nameof(fieldMask)),
                },
                callSettings);

        /// <summary>
        /// Updates an instance, and begins allocating or releasing resources
        /// as requested. The returned [long-running
        /// operation][google.longrunning.Operation] can be used to track the
        /// progress of updating the instance. If the named instance does not
        /// exist, returns `NOT_FOUND`.
        ///
        /// Immediately upon completion of this request:
        ///
        ///   * For resource types for which a decrease in the instance's allocation
        ///     has been requested, billing is based on the newly-requested level.
        ///
        /// Until completion of the returned operation:
        ///
        ///   * Cancelling the operation sets its metadata's
        ///     [cancel_time][google.spanner.admin.instance.v1.UpdateInstanceMetadata.cancel_time], and begins
        ///     restoring resources to their pre-request values. The operation
        ///     is guaranteed to succeed at undoing all resource changes,
        ///     after which point it terminates with a `CANCELLED` status.
        ///   * All other attempts to modify the instance are rejected.
        ///   * Reading the instance via the API continues to give the pre-request
        ///     resource levels.
        ///
        /// Upon completion of the returned operation:
        ///
        ///   * Billing begins for all successfully-allocated resources (some types
        ///     may have lower than the requested levels).
        ///   * All newly-reserved resources are available for serving the instance's
        ///     tables.
        ///   * The instance's new resource levels are readable via the API.
        ///
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;instance_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track the instance modification.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateInstanceMetadata][google.spanner.admin.instance.v1.UpdateInstanceMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Instance][google.spanner.admin.instance.v1.Instance], if successful.
        ///
        /// Authorization requires `spanner.instances.update` permission on
        /// resource [name][google.spanner.admin.instance.v1.Instance.name].
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
        public virtual Task<Operation<Instance, UpdateInstanceMetadata>> UpdateInstanceAsync(
            UpdateInstanceRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateInstanceAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual Task<Operation<Instance, UpdateInstanceMetadata>> PollOnceUpdateInstanceAsync(
            string operationName,
            CallSettings callSettings = null) => Operation<Instance, UpdateInstanceMetadata>.PollOnceFromNameAsync(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                UpdateInstanceOperationsClient,
                callSettings);

        /// <summary>
        /// Updates an instance, and begins allocating or releasing resources
        /// as requested. The returned [long-running
        /// operation][google.longrunning.Operation] can be used to track the
        /// progress of updating the instance. If the named instance does not
        /// exist, returns `NOT_FOUND`.
        ///
        /// Immediately upon completion of this request:
        ///
        ///   * For resource types for which a decrease in the instance's allocation
        ///     has been requested, billing is based on the newly-requested level.
        ///
        /// Until completion of the returned operation:
        ///
        ///   * Cancelling the operation sets its metadata's
        ///     [cancel_time][google.spanner.admin.instance.v1.UpdateInstanceMetadata.cancel_time], and begins
        ///     restoring resources to their pre-request values. The operation
        ///     is guaranteed to succeed at undoing all resource changes,
        ///     after which point it terminates with a `CANCELLED` status.
        ///   * All other attempts to modify the instance are rejected.
        ///   * Reading the instance via the API continues to give the pre-request
        ///     resource levels.
        ///
        /// Upon completion of the returned operation:
        ///
        ///   * Billing begins for all successfully-allocated resources (some types
        ///     may have lower than the requested levels).
        ///   * All newly-reserved resources are available for serving the instance's
        ///     tables.
        ///   * The instance's new resource levels are readable via the API.
        ///
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;instance_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track the instance modification.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateInstanceMetadata][google.spanner.admin.instance.v1.UpdateInstanceMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Instance][google.spanner.admin.instance.v1.Instance], if successful.
        ///
        /// Authorization requires `spanner.instances.update` permission on
        /// resource [name][google.spanner.admin.instance.v1.Instance.name].
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
        public virtual Operation<Instance, UpdateInstanceMetadata> UpdateInstance(
            UpdateInstanceRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>UpdateInstance</c>.
        /// </summary>
        public virtual OperationsClient UpdateInstanceOperationsClient
        {
            get { throw new NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateInstance</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual Operation<Instance, UpdateInstanceMetadata> PollOnceUpdateInstance(
            string operationName,
            CallSettings callSettings = null) => Operation<Instance, UpdateInstanceMetadata>.PollOnceFromName(
                GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                UpdateInstanceOperationsClient,
                callSettings);

        /// <summary>
        /// Deletes an instance.
        ///
        /// Immediately upon completion of the request:
        ///
        ///   * Billing ceases for all of the instance's reserved resources.
        ///
        /// Soon afterward:
        ///
        ///   * The instance and *all of its databases* immediately and
        ///     irrevocably disappear from the API. All data in the databases
        ///     is permanently deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the instance to be deleted. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteInstanceAsync(
            InstanceName name,
            CallSettings callSettings = null) => DeleteInstanceAsync(
                new DeleteInstanceRequest
                {
                    InstanceName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes an instance.
        ///
        /// Immediately upon completion of the request:
        ///
        ///   * Billing ceases for all of the instance's reserved resources.
        ///
        /// Soon afterward:
        ///
        ///   * The instance and *all of its databases* immediately and
        ///     irrevocably disappear from the API. All data in the databases
        ///     is permanently deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the instance to be deleted. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task DeleteInstanceAsync(
            InstanceName name,
            CancellationToken cancellationToken) => DeleteInstanceAsync(
                name,
                CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an instance.
        ///
        /// Immediately upon completion of the request:
        ///
        ///   * Billing ceases for all of the instance's reserved resources.
        ///
        /// Soon afterward:
        ///
        ///   * The instance and *all of its databases* immediately and
        ///     irrevocably disappear from the API. All data in the databases
        ///     is permanently deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the instance to be deleted. Values are of the form
        /// `projects/&lt;project&gt;/instances/&lt;instance&gt;`
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual void DeleteInstance(
            InstanceName name,
            CallSettings callSettings = null) => DeleteInstance(
                new DeleteInstanceRequest
                {
                    InstanceName = GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes an instance.
        ///
        /// Immediately upon completion of the request:
        ///
        ///   * Billing ceases for all of the instance's reserved resources.
        ///
        /// Soon afterward:
        ///
        ///   * The instance and *all of its databases* immediately and
        ///     irrevocably disappear from the API. All data in the databases
        ///     is permanently deleted.
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
        public virtual Task DeleteInstanceAsync(
            DeleteInstanceRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes an instance.
        ///
        /// Immediately upon completion of the request:
        ///
        ///   * Billing ceases for all of the instance's reserved resources.
        ///
        /// Soon afterward:
        ///
        ///   * The instance and *all of its databases* immediately and
        ///     irrevocably disappear from the API. All data in the databases
        ///     is permanently deleted.
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
        public virtual void DeleteInstance(
            DeleteInstanceRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the access control policy on an instance resource. Replaces any
        /// existing policy.
        ///
        /// Authorization requires `spanner.instances.setIamPolicy` on
        /// [resource][google.iam.v1.SetIamPolicyRequest.resource].
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// `resource` is usually specified as a path. For example, a Project
        /// resource is specified as `projects/{project}`.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
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
            CallSettings callSettings = null) => SetIamPolicyAsync(
                new SetIamPolicyRequest
                {
                    Resource = GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                    Policy = GaxPreconditions.CheckNotNull(policy, nameof(policy)),
                },
                callSettings);

        /// <summary>
        /// Sets the access control policy on an instance resource. Replaces any
        /// existing policy.
        ///
        /// Authorization requires `spanner.instances.setIamPolicy` on
        /// [resource][google.iam.v1.SetIamPolicyRequest.resource].
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// `resource` is usually specified as a path. For example, a Project
        /// resource is specified as `projects/{project}`.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
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
        /// Sets the access control policy on an instance resource. Replaces any
        /// existing policy.
        ///
        /// Authorization requires `spanner.instances.setIamPolicy` on
        /// [resource][google.iam.v1.SetIamPolicyRequest.resource].
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// `resource` is usually specified as a path. For example, a Project
        /// resource is specified as `projects/{project}`.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
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
            CallSettings callSettings = null) => SetIamPolicy(
                new SetIamPolicyRequest
                {
                    Resource = GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                    Policy = GaxPreconditions.CheckNotNull(policy, nameof(policy)),
                },
                callSettings);

        /// <summary>
        /// Sets the access control policy on an instance resource. Replaces any
        /// existing policy.
        ///
        /// Authorization requires `spanner.instances.setIamPolicy` on
        /// [resource][google.iam.v1.SetIamPolicyRequest.resource].
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
        public virtual Task<Policy> SetIamPolicyAsync(
            SetIamPolicyRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sets the access control policy on an instance resource. Replaces any
        /// existing policy.
        ///
        /// Authorization requires `spanner.instances.setIamPolicy` on
        /// [resource][google.iam.v1.SetIamPolicyRequest.resource].
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
        public virtual Policy SetIamPolicy(
            SetIamPolicyRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the access control policy for an instance resource. Returns an empty
        /// policy if an instance exists but does not have a policy set.
        ///
        /// Authorization requires `spanner.instances.getIamPolicy` on
        /// [resource][google.iam.v1.GetIamPolicyRequest.resource].
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// `resource` is usually specified as a path. For example, a Project
        /// resource is specified as `projects/{project}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual Task<Policy> GetIamPolicyAsync(
            string resource,
            CallSettings callSettings = null) => GetIamPolicyAsync(
                new GetIamPolicyRequest
                {
                    Resource = GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                },
                callSettings);

        /// <summary>
        /// Gets the access control policy for an instance resource. Returns an empty
        /// policy if an instance exists but does not have a policy set.
        ///
        /// Authorization requires `spanner.instances.getIamPolicy` on
        /// [resource][google.iam.v1.GetIamPolicyRequest.resource].
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// `resource` is usually specified as a path. For example, a Project
        /// resource is specified as `projects/{project}`.
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
        /// Gets the access control policy for an instance resource. Returns an empty
        /// policy if an instance exists but does not have a policy set.
        ///
        /// Authorization requires `spanner.instances.getIamPolicy` on
        /// [resource][google.iam.v1.GetIamPolicyRequest.resource].
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// `resource` is usually specified as a path. For example, a Project
        /// resource is specified as `projects/{project}`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Policy GetIamPolicy(
            string resource,
            CallSettings callSettings = null) => GetIamPolicy(
                new GetIamPolicyRequest
                {
                    Resource = GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                },
                callSettings);

        /// <summary>
        /// Gets the access control policy for an instance resource. Returns an empty
        /// policy if an instance exists but does not have a policy set.
        ///
        /// Authorization requires `spanner.instances.getIamPolicy` on
        /// [resource][google.iam.v1.GetIamPolicyRequest.resource].
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
        public virtual Task<Policy> GetIamPolicyAsync(
            GetIamPolicyRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the access control policy for an instance resource. Returns an empty
        /// policy if an instance exists but does not have a policy set.
        ///
        /// Authorization requires `spanner.instances.getIamPolicy` on
        /// [resource][google.iam.v1.GetIamPolicyRequest.resource].
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
        public virtual Policy GetIamPolicy(
            GetIamPolicyRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns permissions that the caller has on the specified instance resource.
        ///
        /// Attempting this RPC on a non-existent Cloud Spanner instance resource will
        /// result in a NOT_FOUND error if the user has `spanner.instances.list`
        /// permission on the containing Google Cloud Project. Otherwise returns an
        /// empty set of permissions.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// `resource` is usually specified as a path. For example, a Project
        /// resource is specified as `projects/{project}`.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
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
            CallSettings callSettings = null) => TestIamPermissionsAsync(
                new TestIamPermissionsRequest
                {
                    Resource = GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                    Permissions = { GaxPreconditions.CheckNotNull(permissions, nameof(permissions)) },
                },
                callSettings);

        /// <summary>
        /// Returns permissions that the caller has on the specified instance resource.
        ///
        /// Attempting this RPC on a non-existent Cloud Spanner instance resource will
        /// result in a NOT_FOUND error if the user has `spanner.instances.list`
        /// permission on the containing Google Cloud Project. Otherwise returns an
        /// empty set of permissions.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// `resource` is usually specified as a path. For example, a Project
        /// resource is specified as `projects/{project}`.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
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
        /// Returns permissions that the caller has on the specified instance resource.
        ///
        /// Attempting this RPC on a non-existent Cloud Spanner instance resource will
        /// result in a NOT_FOUND error if the user has `spanner.instances.list`
        /// permission on the containing Google Cloud Project. Otherwise returns an
        /// empty set of permissions.
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy detail is being requested.
        /// `resource` is usually specified as a path. For example, a Project
        /// resource is specified as `projects/{project}`.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
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
            CallSettings callSettings = null) => TestIamPermissions(
                new TestIamPermissionsRequest
                {
                    Resource = GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                    Permissions = { GaxPreconditions.CheckNotNull(permissions, nameof(permissions)) },
                },
                callSettings);

        /// <summary>
        /// Returns permissions that the caller has on the specified instance resource.
        ///
        /// Attempting this RPC on a non-existent Cloud Spanner instance resource will
        /// result in a NOT_FOUND error if the user has `spanner.instances.list`
        /// permission on the containing Google Cloud Project. Otherwise returns an
        /// empty set of permissions.
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
        public virtual Task<TestIamPermissionsResponse> TestIamPermissionsAsync(
            TestIamPermissionsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Returns permissions that the caller has on the specified instance resource.
        ///
        /// Attempting this RPC on a non-existent Cloud Spanner instance resource will
        /// result in a NOT_FOUND error if the user has `spanner.instances.list`
        /// permission on the containing Google Cloud Project. Otherwise returns an
        /// empty set of permissions.
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
        public virtual TestIamPermissionsResponse TestIamPermissions(
            TestIamPermissionsRequest request,
            CallSettings callSettings = null)
        {
            throw new NotImplementedException();
        }

    }

    /// <summary>
    /// InstanceAdmin client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class InstanceAdminClientImpl : InstanceAdminClient
    {
        private readonly ApiCall<ListInstanceConfigsRequest, ListInstanceConfigsResponse> _callListInstanceConfigs;
        private readonly ApiCall<GetInstanceConfigRequest, InstanceConfig> _callGetInstanceConfig;
        private readonly ApiCall<ListInstancesRequest, ListInstancesResponse> _callListInstances;
        private readonly ApiCall<GetInstanceRequest, Instance> _callGetInstance;
        private readonly ApiCall<CreateInstanceRequest, Operation> _callCreateInstance;
        private readonly ApiCall<UpdateInstanceRequest, Operation> _callUpdateInstance;
        private readonly ApiCall<DeleteInstanceRequest, Empty> _callDeleteInstance;
        private readonly ApiCall<SetIamPolicyRequest, Policy> _callSetIamPolicy;
        private readonly ApiCall<GetIamPolicyRequest, Policy> _callGetIamPolicy;
        private readonly ApiCall<TestIamPermissionsRequest, TestIamPermissionsResponse> _callTestIamPermissions;

        /// <summary>
        /// Constructs a client wrapper for the InstanceAdmin service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="InstanceAdminSettings"/> used within this client </param>
        public InstanceAdminClientImpl(InstanceAdmin.InstanceAdminClient grpcClient, InstanceAdminSettings settings)
        {
            GrpcClient = grpcClient;
            InstanceAdminSettings effectiveSettings = settings ?? InstanceAdminSettings.GetDefault();
            ClientHelper clientHelper = new ClientHelper(effectiveSettings);
            CreateInstanceOperationsClient = new OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.CreateInstanceOperationsSettings);
            UpdateInstanceOperationsClient = new OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.UpdateInstanceOperationsSettings);
            _callListInstanceConfigs = clientHelper.BuildApiCall<ListInstanceConfigsRequest, ListInstanceConfigsResponse>(
                GrpcClient.ListInstanceConfigsAsync, GrpcClient.ListInstanceConfigs, effectiveSettings.ListInstanceConfigsSettings);
            _callGetInstanceConfig = clientHelper.BuildApiCall<GetInstanceConfigRequest, InstanceConfig>(
                GrpcClient.GetInstanceConfigAsync, GrpcClient.GetInstanceConfig, effectiveSettings.GetInstanceConfigSettings);
            _callListInstances = clientHelper.BuildApiCall<ListInstancesRequest, ListInstancesResponse>(
                GrpcClient.ListInstancesAsync, GrpcClient.ListInstances, effectiveSettings.ListInstancesSettings);
            _callGetInstance = clientHelper.BuildApiCall<GetInstanceRequest, Instance>(
                GrpcClient.GetInstanceAsync, GrpcClient.GetInstance, effectiveSettings.GetInstanceSettings);
            _callCreateInstance = clientHelper.BuildApiCall<CreateInstanceRequest, Operation>(
                GrpcClient.CreateInstanceAsync, GrpcClient.CreateInstance, effectiveSettings.CreateInstanceSettings);
            _callUpdateInstance = clientHelper.BuildApiCall<UpdateInstanceRequest, Operation>(
                GrpcClient.UpdateInstanceAsync, GrpcClient.UpdateInstance, effectiveSettings.UpdateInstanceSettings);
            _callDeleteInstance = clientHelper.BuildApiCall<DeleteInstanceRequest, Empty>(
                GrpcClient.DeleteInstanceAsync, GrpcClient.DeleteInstance, effectiveSettings.DeleteInstanceSettings);
            _callSetIamPolicy = clientHelper.BuildApiCall<SetIamPolicyRequest, Policy>(
                GrpcClient.SetIamPolicyAsync, GrpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings);
            _callGetIamPolicy = clientHelper.BuildApiCall<GetIamPolicyRequest, Policy>(
                GrpcClient.GetIamPolicyAsync, GrpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings);
            _callTestIamPermissions = clientHelper.BuildApiCall<TestIamPermissionsRequest, TestIamPermissionsResponse>(
                GrpcClient.TestIamPermissionsAsync, GrpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void OnConstruction(InstanceAdmin.InstanceAdminClient grpcClient, InstanceAdminSettings effectiveSettings, ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC InstanceAdmin client.
        /// </summary>
        public override InstanceAdmin.InstanceAdminClient GrpcClient { get; }

        // Partial modifier methods contain '_' to ensure no name conflicts with RPC methods.
        partial void Modify_ListInstanceConfigsRequest(ref ListInstanceConfigsRequest request, ref CallSettings settings);
        partial void Modify_GetInstanceConfigRequest(ref GetInstanceConfigRequest request, ref CallSettings settings);
        partial void Modify_ListInstancesRequest(ref ListInstancesRequest request, ref CallSettings settings);
        partial void Modify_GetInstanceRequest(ref GetInstanceRequest request, ref CallSettings settings);
        partial void Modify_CreateInstanceRequest(ref CreateInstanceRequest request, ref CallSettings settings);
        partial void Modify_UpdateInstanceRequest(ref UpdateInstanceRequest request, ref CallSettings settings);
        partial void Modify_DeleteInstanceRequest(ref DeleteInstanceRequest request, ref CallSettings settings);
        partial void Modify_SetIamPolicyRequest(ref SetIamPolicyRequest request, ref CallSettings settings);
        partial void Modify_GetIamPolicyRequest(ref GetIamPolicyRequest request, ref CallSettings settings);
        partial void Modify_TestIamPermissionsRequest(ref TestIamPermissionsRequest request, ref CallSettings settings);

        /// <summary>
        /// Lists the supported instance configurations for a given project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="InstanceConfig"/> resources.
        /// </returns>
        public override PagedAsyncEnumerable<ListInstanceConfigsResponse, InstanceConfig> ListInstanceConfigsAsync(
            ListInstanceConfigsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListInstanceConfigsRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<ListInstanceConfigsRequest, ListInstanceConfigsResponse, InstanceConfig>(_callListInstanceConfigs, request, callSettings);
        }

        /// <summary>
        /// Lists the supported instance configurations for a given project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="InstanceConfig"/> resources.
        /// </returns>
        public override PagedEnumerable<ListInstanceConfigsResponse, InstanceConfig> ListInstanceConfigs(
            ListInstanceConfigsRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListInstanceConfigsRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<ListInstanceConfigsRequest, ListInstanceConfigsResponse, InstanceConfig>(_callListInstanceConfigs, request, callSettings);
        }

        /// <summary>
        /// Gets information about a particular instance configuration.
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
        public override Task<InstanceConfig> GetInstanceConfigAsync(
            GetInstanceConfigRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetInstanceConfigRequest(ref request, ref callSettings);
            return _callGetInstanceConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Gets information about a particular instance configuration.
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
        public override InstanceConfig GetInstanceConfig(
            GetInstanceConfigRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetInstanceConfigRequest(ref request, ref callSettings);
            return _callGetInstanceConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists all instances in the given project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Instance"/> resources.
        /// </returns>
        public override PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(
            ListInstancesRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListInstancesRequest(ref request, ref callSettings);
            return new GrpcPagedAsyncEnumerable<ListInstancesRequest, ListInstancesResponse, Instance>(_callListInstances, request, callSettings);
        }

        /// <summary>
        /// Lists all instances in the given project.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Instance"/> resources.
        /// </returns>
        public override PagedEnumerable<ListInstancesResponse, Instance> ListInstances(
            ListInstancesRequest request,
            CallSettings callSettings = null)
        {
            Modify_ListInstancesRequest(ref request, ref callSettings);
            return new GrpcPagedEnumerable<ListInstancesRequest, ListInstancesResponse, Instance>(_callListInstances, request, callSettings);
        }

        /// <summary>
        /// Gets information about a particular instance.
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
        public override Task<Instance> GetInstanceAsync(
            GetInstanceRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetInstanceRequest(ref request, ref callSettings);
            return _callGetInstance.Async(request, callSettings);
        }

        /// <summary>
        /// Gets information about a particular instance.
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
        public override Instance GetInstance(
            GetInstanceRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetInstanceRequest(ref request, ref callSettings);
            return _callGetInstance.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an instance and begins preparing it to begin serving. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new
        /// instance. The instance name is assigned by the caller. If the
        /// named instance already exists, `CreateInstance` returns
        /// `ALREADY_EXISTS`.
        ///
        /// Immediately upon completion of this request:
        ///
        ///   * The instance is readable via the API, with all requested attributes
        ///     but no allocated resources. Its state is `CREATING`.
        ///
        /// Until completion of the returned operation:
        ///
        ///   * Cancelling the operation renders the instance immediately unreadable
        ///     via the API.
        ///   * The instance can be deleted.
        ///   * All other attempts to modify the instance are rejected.
        ///
        /// Upon completion of the returned operation:
        ///
        ///   * Billing for all successfully-allocated resources begins (some types
        ///     may have lower than the requested levels).
        ///   * Databases can be created in the instance.
        ///   * The instance's allocated resource levels are readable via the API.
        ///   * The instance's state becomes `READY`.
        ///
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;instance_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track creation of the instance.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstanceMetadata][google.spanner.admin.instance.v1.CreateInstanceMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Instance][google.spanner.admin.instance.v1.Instance], if successful.
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
        public override async Task<Operation<Instance, CreateInstanceMetadata>> CreateInstanceAsync(
            CreateInstanceRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateInstanceRequest(ref request, ref callSettings);
            return new Operation<Instance, CreateInstanceMetadata>(
                await _callCreateInstance.Async(request, callSettings).ConfigureAwait(false), CreateInstanceOperationsClient);
        }

        /// <summary>
        /// Creates an instance and begins preparing it to begin serving. The
        /// returned [long-running operation][google.longrunning.Operation]
        /// can be used to track the progress of preparing the new
        /// instance. The instance name is assigned by the caller. If the
        /// named instance already exists, `CreateInstance` returns
        /// `ALREADY_EXISTS`.
        ///
        /// Immediately upon completion of this request:
        ///
        ///   * The instance is readable via the API, with all requested attributes
        ///     but no allocated resources. Its state is `CREATING`.
        ///
        /// Until completion of the returned operation:
        ///
        ///   * Cancelling the operation renders the instance immediately unreadable
        ///     via the API.
        ///   * The instance can be deleted.
        ///   * All other attempts to modify the instance are rejected.
        ///
        /// Upon completion of the returned operation:
        ///
        ///   * Billing for all successfully-allocated resources begins (some types
        ///     may have lower than the requested levels).
        ///   * Databases can be created in the instance.
        ///   * The instance's allocated resource levels are readable via the API.
        ///   * The instance's state becomes `READY`.
        ///
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;instance_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track creation of the instance.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [CreateInstanceMetadata][google.spanner.admin.instance.v1.CreateInstanceMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Instance][google.spanner.admin.instance.v1.Instance], if successful.
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
        public override Operation<Instance, CreateInstanceMetadata> CreateInstance(
            CreateInstanceRequest request,
            CallSettings callSettings = null)
        {
            Modify_CreateInstanceRequest(ref request, ref callSettings);
            return new Operation<Instance, CreateInstanceMetadata>(
                _callCreateInstance.Sync(request, callSettings), CreateInstanceOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>CreateInstance</c>.
        /// </summary>
        public override OperationsClient CreateInstanceOperationsClient { get; }

        /// <summary>
        /// Updates an instance, and begins allocating or releasing resources
        /// as requested. The returned [long-running
        /// operation][google.longrunning.Operation] can be used to track the
        /// progress of updating the instance. If the named instance does not
        /// exist, returns `NOT_FOUND`.
        ///
        /// Immediately upon completion of this request:
        ///
        ///   * For resource types for which a decrease in the instance's allocation
        ///     has been requested, billing is based on the newly-requested level.
        ///
        /// Until completion of the returned operation:
        ///
        ///   * Cancelling the operation sets its metadata's
        ///     [cancel_time][google.spanner.admin.instance.v1.UpdateInstanceMetadata.cancel_time], and begins
        ///     restoring resources to their pre-request values. The operation
        ///     is guaranteed to succeed at undoing all resource changes,
        ///     after which point it terminates with a `CANCELLED` status.
        ///   * All other attempts to modify the instance are rejected.
        ///   * Reading the instance via the API continues to give the pre-request
        ///     resource levels.
        ///
        /// Upon completion of the returned operation:
        ///
        ///   * Billing begins for all successfully-allocated resources (some types
        ///     may have lower than the requested levels).
        ///   * All newly-reserved resources are available for serving the instance's
        ///     tables.
        ///   * The instance's new resource levels are readable via the API.
        ///
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;instance_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track the instance modification.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateInstanceMetadata][google.spanner.admin.instance.v1.UpdateInstanceMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Instance][google.spanner.admin.instance.v1.Instance], if successful.
        ///
        /// Authorization requires `spanner.instances.update` permission on
        /// resource [name][google.spanner.admin.instance.v1.Instance.name].
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
        public override async Task<Operation<Instance, UpdateInstanceMetadata>> UpdateInstanceAsync(
            UpdateInstanceRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateInstanceRequest(ref request, ref callSettings);
            return new Operation<Instance, UpdateInstanceMetadata>(
                await _callUpdateInstance.Async(request, callSettings).ConfigureAwait(false), UpdateInstanceOperationsClient);
        }

        /// <summary>
        /// Updates an instance, and begins allocating or releasing resources
        /// as requested. The returned [long-running
        /// operation][google.longrunning.Operation] can be used to track the
        /// progress of updating the instance. If the named instance does not
        /// exist, returns `NOT_FOUND`.
        ///
        /// Immediately upon completion of this request:
        ///
        ///   * For resource types for which a decrease in the instance's allocation
        ///     has been requested, billing is based on the newly-requested level.
        ///
        /// Until completion of the returned operation:
        ///
        ///   * Cancelling the operation sets its metadata's
        ///     [cancel_time][google.spanner.admin.instance.v1.UpdateInstanceMetadata.cancel_time], and begins
        ///     restoring resources to their pre-request values. The operation
        ///     is guaranteed to succeed at undoing all resource changes,
        ///     after which point it terminates with a `CANCELLED` status.
        ///   * All other attempts to modify the instance are rejected.
        ///   * Reading the instance via the API continues to give the pre-request
        ///     resource levels.
        ///
        /// Upon completion of the returned operation:
        ///
        ///   * Billing begins for all successfully-allocated resources (some types
        ///     may have lower than the requested levels).
        ///   * All newly-reserved resources are available for serving the instance's
        ///     tables.
        ///   * The instance's new resource levels are readable via the API.
        ///
        /// The returned [long-running operation][google.longrunning.Operation] will
        /// have a name of the format `&lt;instance_name&gt;/operations/&lt;operation_id&gt;` and
        /// can be used to track the instance modification.  The
        /// [metadata][google.longrunning.Operation.metadata] field type is
        /// [UpdateInstanceMetadata][google.spanner.admin.instance.v1.UpdateInstanceMetadata].
        /// The [response][google.longrunning.Operation.response] field type is
        /// [Instance][google.spanner.admin.instance.v1.Instance], if successful.
        ///
        /// Authorization requires `spanner.instances.update` permission on
        /// resource [name][google.spanner.admin.instance.v1.Instance.name].
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
        public override Operation<Instance, UpdateInstanceMetadata> UpdateInstance(
            UpdateInstanceRequest request,
            CallSettings callSettings = null)
        {
            Modify_UpdateInstanceRequest(ref request, ref callSettings);
            return new Operation<Instance, UpdateInstanceMetadata>(
                _callUpdateInstance.Sync(request, callSettings), UpdateInstanceOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>UpdateInstance</c>.
        /// </summary>
        public override OperationsClient UpdateInstanceOperationsClient { get; }

        /// <summary>
        /// Deletes an instance.
        ///
        /// Immediately upon completion of the request:
        ///
        ///   * Billing ceases for all of the instance's reserved resources.
        ///
        /// Soon afterward:
        ///
        ///   * The instance and *all of its databases* immediately and
        ///     irrevocably disappear from the API. All data in the databases
        ///     is permanently deleted.
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
        public override Task DeleteInstanceAsync(
            DeleteInstanceRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteInstanceRequest(ref request, ref callSettings);
            return _callDeleteInstance.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an instance.
        ///
        /// Immediately upon completion of the request:
        ///
        ///   * Billing ceases for all of the instance's reserved resources.
        ///
        /// Soon afterward:
        ///
        ///   * The instance and *all of its databases* immediately and
        ///     irrevocably disappear from the API. All data in the databases
        ///     is permanently deleted.
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
        public override void DeleteInstance(
            DeleteInstanceRequest request,
            CallSettings callSettings = null)
        {
            Modify_DeleteInstanceRequest(ref request, ref callSettings);
            _callDeleteInstance.Sync(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy on an instance resource. Replaces any
        /// existing policy.
        ///
        /// Authorization requires `spanner.instances.setIamPolicy` on
        /// [resource][google.iam.v1.SetIamPolicyRequest.resource].
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
        public override Task<Policy> SetIamPolicyAsync(
            SetIamPolicyRequest request,
            CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Sets the access control policy on an instance resource. Replaces any
        /// existing policy.
        ///
        /// Authorization requires `spanner.instances.setIamPolicy` on
        /// [resource][google.iam.v1.SetIamPolicyRequest.resource].
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
        public override Policy SetIamPolicy(
            SetIamPolicyRequest request,
            CallSettings callSettings = null)
        {
            Modify_SetIamPolicyRequest(ref request, ref callSettings);
            return _callSetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for an instance resource. Returns an empty
        /// policy if an instance exists but does not have a policy set.
        ///
        /// Authorization requires `spanner.instances.getIamPolicy` on
        /// [resource][google.iam.v1.GetIamPolicyRequest.resource].
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
        public override Task<Policy> GetIamPolicyAsync(
            GetIamPolicyRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the access control policy for an instance resource. Returns an empty
        /// policy if an instance exists but does not have a policy set.
        ///
        /// Authorization requires `spanner.instances.getIamPolicy` on
        /// [resource][google.iam.v1.GetIamPolicyRequest.resource].
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
        public override Policy GetIamPolicy(
            GetIamPolicyRequest request,
            CallSettings callSettings = null)
        {
            Modify_GetIamPolicyRequest(ref request, ref callSettings);
            return _callGetIamPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that the caller has on the specified instance resource.
        ///
        /// Attempting this RPC on a non-existent Cloud Spanner instance resource will
        /// result in a NOT_FOUND error if the user has `spanner.instances.list`
        /// permission on the containing Google Cloud Project. Otherwise returns an
        /// empty set of permissions.
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
        public override Task<TestIamPermissionsResponse> TestIamPermissionsAsync(
            TestIamPermissionsRequest request,
            CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Async(request, callSettings);
        }

        /// <summary>
        /// Returns permissions that the caller has on the specified instance resource.
        ///
        /// Attempting this RPC on a non-existent Cloud Spanner instance resource will
        /// result in a NOT_FOUND error if the user has `spanner.instances.list`
        /// permission on the containing Google Cloud Project. Otherwise returns an
        /// empty set of permissions.
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
        public override TestIamPermissionsResponse TestIamPermissions(
            TestIamPermissionsRequest request,
            CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListInstanceConfigsRequest : IPageRequest { }
    public partial class ListInstanceConfigsResponse : IPageResponse<InstanceConfig>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<InstanceConfig> GetEnumerator() => InstanceConfigs.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListInstancesRequest : IPageRequest { }
    public partial class ListInstancesResponse : IPageResponse<Instance>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public IEnumerator<Instance> GetEnumerator() => Instances.GetEnumerator();

        /// <inheritdoc/>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    // Partial Grpc class to enable LRO client creation
    public static partial class InstanceAdmin
    {
        public partial class InstanceAdminClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="Operations.OperationsClient"/> using the same call invoker as this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual Operations.OperationsClient CreateOperationsClient() => new Operations.OperationsClient(CallInvoker);
        }
    }


}
