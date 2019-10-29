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
using iam = Google.Cloud.Iam.V1;
using lro = Google.LongRunning;
using pb = Google.Protobuf;
using pbwkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using linq = System.Linq;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Spanner.Admin.Instance.V1
{
    /// <summary>
    /// Settings for a <see cref="InstanceAdminClient"/>.
    /// </summary>
    public sealed partial class InstanceAdminSettings : gaxgrpc::ServiceSettingsBase
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
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
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
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="InstanceAdminClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="InstanceAdminClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="InstanceAdminClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="InstanceAdminClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="InstanceAdminClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="InstanceAdminClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="InstanceAdminClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="InstanceAdminClient"/> RPC methods is defined as:
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
        /// <c>InstanceAdminClient.ListInstanceConfigs</c> and <c>InstanceAdminClient.ListInstanceConfigsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>InstanceAdminClient.ListInstanceConfigs</c> and
        /// <c>InstanceAdminClient.ListInstanceConfigsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListInstanceConfigsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceAdminClient.GetInstanceConfig</c> and <c>InstanceAdminClient.GetInstanceConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>InstanceAdminClient.GetInstanceConfig</c> and
        /// <c>InstanceAdminClient.GetInstanceConfigAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetInstanceConfigSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceAdminClient.ListInstances</c> and <c>InstanceAdminClient.ListInstancesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>InstanceAdminClient.ListInstances</c> and
        /// <c>InstanceAdminClient.ListInstancesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings ListInstancesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceAdminClient.GetInstance</c> and <c>InstanceAdminClient.GetInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>InstanceAdminClient.GetInstance</c> and
        /// <c>InstanceAdminClient.GetInstanceAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceAdminClient.CreateInstance</c> and <c>InstanceAdminClient.CreateInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>InstanceAdminClient.CreateInstance</c> and
        /// <c>InstanceAdminClient.CreateInstanceAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstanceAdminClient.CreateInstance</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 500 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 5000 milliseconds</description></item>
        /// <item><description>Total timeout: 300000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(
                gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000L)),
                sys::TimeSpan.FromMilliseconds(500L),
                1.5,
                sys::TimeSpan.FromMilliseconds(5000L))
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceAdminClient.UpdateInstance</c> and <c>InstanceAdminClient.UpdateInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>InstanceAdminClient.UpdateInstance</c> and
        /// <c>InstanceAdminClient.UpdateInstanceAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings UpdateInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>InstanceAdminClient.UpdateInstance</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 500 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 5000 milliseconds</description></item>
        /// <item><description>Total timeout: 300000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings UpdateInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(
                gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000L)),
                sys::TimeSpan.FromMilliseconds(500L),
                1.5,
                sys::TimeSpan.FromMilliseconds(5000L))
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceAdminClient.DeleteInstance</c> and <c>InstanceAdminClient.DeleteInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>InstanceAdminClient.DeleteInstance</c> and
        /// <c>InstanceAdminClient.DeleteInstanceAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings DeleteInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceAdminClient.SetIamPolicy</c> and <c>InstanceAdminClient.SetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>InstanceAdminClient.SetIamPolicy</c> and
        /// <c>InstanceAdminClient.SetIamPolicyAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings SetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceAdminClient.GetIamPolicy</c> and <c>InstanceAdminClient.GetIamPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>InstanceAdminClient.GetIamPolicy</c> and
        /// <c>InstanceAdminClient.GetIamPolicyAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetIamPolicySettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>InstanceAdminClient.TestIamPermissions</c> and <c>InstanceAdminClient.TestIamPermissionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>InstanceAdminClient.TestIamPermissions</c> and
        /// <c>InstanceAdminClient.TestIamPermissionsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings TestIamPermissionsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="InstanceAdminSettings"/> object.</returns>
        public InstanceAdminSettings Clone() => new InstanceAdminSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="InstanceAdminClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class InstanceAdminClientBuilder : gaxgrpc::ClientBuilderBase<InstanceAdminClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public InstanceAdminSettings Settings { get; set; }

        /// <inheritdoc/>
        public override InstanceAdminClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return InstanceAdminClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<InstanceAdminClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return InstanceAdminClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => InstanceAdminClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => InstanceAdminClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => InstanceAdminClient.ChannelPool;
    }

    /// <summary>
    /// InstanceAdmin client wrapper, for convenient use.
    /// </summary>
    public abstract partial class InstanceAdminClient
    {
        /// <summary>
        /// The default endpoint for the InstanceAdmin service, which is a host of "spanner.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("spanner.googleapis.com", 443);

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
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/spanner.admin",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="InstanceAdminClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Spanner.Admin.Instance.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// InstanceAdminClient client = await InstanceAdminClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Spanner.Admin.Instance.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     InstanceAdminClient.DefaultEndpoint.Host, InstanceAdminClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// InstanceAdminClient client = InstanceAdminClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="InstanceAdminSettings"/>.</param>
        /// <returns>The task representing the created <see cref="InstanceAdminClient"/>.</returns>
        public static async stt::Task<InstanceAdminClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, InstanceAdminSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="InstanceAdminClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Spanner.Admin.Instance.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// InstanceAdminClient client = InstanceAdminClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Spanner.Admin.Instance.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     InstanceAdminClient.DefaultEndpoint.Host, InstanceAdminClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// InstanceAdminClient client = InstanceAdminClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="InstanceAdminSettings"/>.</param>
        /// <returns>The created <see cref="InstanceAdminClient"/>.</returns>
        public static InstanceAdminClient Create(gaxgrpc::ServiceEndpoint endpoint = null, InstanceAdminSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="InstanceAdminClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="InstanceAdminSettings"/>.</param>
        /// <returns>The created <see cref="InstanceAdminClient"/>.</returns>
        public static InstanceAdminClient Create(grpccore::Channel channel, InstanceAdminSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="InstanceAdminClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="InstanceAdminSettings"/>.</param>
        /// <returns>The created <see cref="InstanceAdminClient"/>.</returns>
        public static InstanceAdminClient Create(grpccore::CallInvoker callInvoker, InstanceAdminSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            InstanceAdmin.InstanceAdminClient grpcClient = new InstanceAdmin.InstanceAdminClient(callInvoker);
            return new InstanceAdminClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, InstanceAdminSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, InstanceAdminSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, InstanceAdminSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, InstanceAdminSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC InstanceAdmin client.
        /// </summary>
        public virtual InstanceAdmin.InstanceAdminClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
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
        public virtual gax::PagedAsyncEnumerable<ListInstanceConfigsResponse, InstanceConfig> ListInstanceConfigsAsync(
            ProjectName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListInstanceConfigsAsync(
                new ListInstanceConfigsRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        public virtual gax::PagedEnumerable<ListInstanceConfigsResponse, InstanceConfig> ListInstanceConfigs(
            ProjectName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListInstanceConfigs(
                new ListInstanceConfigsRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// A pageable asynchronous sequence of <see cref="InstanceConfig"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListInstanceConfigsResponse, InstanceConfig> ListInstanceConfigsAsync(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListInstanceConfigsAsync(
                new ListInstanceConfigsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
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
        public virtual gax::PagedEnumerable<ListInstanceConfigsResponse, InstanceConfig> ListInstanceConfigs(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListInstanceConfigs(
                new ListInstanceConfigsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
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
        public virtual gax::PagedAsyncEnumerable<ListInstanceConfigsResponse, InstanceConfig> ListInstanceConfigsAsync(
            ListInstanceConfigsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        public virtual gax::PagedEnumerable<ListInstanceConfigsResponse, InstanceConfig> ListInstanceConfigs(
            ListInstanceConfigsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        public virtual stt::Task<InstanceConfig> GetInstanceConfigAsync(
            InstanceConfigName name,
            gaxgrpc::CallSettings callSettings = null) => GetInstanceConfigAsync(
                new GetInstanceConfigRequest
                {
                    InstanceConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<InstanceConfig> GetInstanceConfigAsync(
            InstanceConfigName name,
            st::CancellationToken cancellationToken) => GetInstanceConfigAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null) => GetInstanceConfig(
                new GetInstanceConfigRequest
                {
                    InstanceConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

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
        public virtual stt::Task<InstanceConfig> GetInstanceConfigAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetInstanceConfigAsync(
                new GetInstanceConfigRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<InstanceConfig> GetInstanceConfigAsync(
            string name,
            st::CancellationToken cancellationToken) => GetInstanceConfigAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetInstanceConfig(
                new GetInstanceConfigRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
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
        public virtual stt::Task<InstanceConfig> GetInstanceConfigAsync(
            GetInstanceConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets information about a particular instance configuration.
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
        public virtual stt::Task<InstanceConfig> GetInstanceConfigAsync(
            GetInstanceConfigRequest request,
            st::CancellationToken cancellationToken) => GetInstanceConfigAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        public virtual gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(
            ProjectName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListInstancesAsync(
                new ListInstancesRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        public virtual gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(
            ProjectName parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListInstances(
                new ListInstancesRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// A pageable asynchronous sequence of <see cref="Instance"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListInstancesAsync(
                new ListInstancesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
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
        public virtual gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListInstances(
                new ListInstancesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
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
        public virtual gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(
            ListInstancesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        public virtual gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(
            ListInstancesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        public virtual stt::Task<Instance> GetInstanceAsync(
            InstanceName name,
            gaxgrpc::CallSettings callSettings = null) => GetInstanceAsync(
                new GetInstanceRequest
                {
                    InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Instance> GetInstanceAsync(
            InstanceName name,
            st::CancellationToken cancellationToken) => GetInstanceAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null) => GetInstance(
                new GetInstanceRequest
                {
                    InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

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
        public virtual stt::Task<Instance> GetInstanceAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetInstanceAsync(
                new GetInstanceRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Instance> GetInstanceAsync(
            string name,
            st::CancellationToken cancellationToken) => GetInstanceAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetInstance(
                new GetInstanceRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
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
        public virtual stt::Task<Instance> GetInstanceAsync(
            GetInstanceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets information about a particular instance.
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
        public virtual stt::Task<Instance> GetInstanceAsync(
            GetInstanceRequest request,
            st::CancellationToken cancellationToken) => GetInstanceAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        /// form `[a-z][-a-z0-9]*[a-z0-9]` and must be between 2 and 64 characters in
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
        public virtual stt::Task<lro::Operation<Instance, CreateInstanceMetadata>> CreateInstanceAsync(
            ProjectName parent,
            string instanceId,
            Instance instance,
            gaxgrpc::CallSettings callSettings = null) => CreateInstanceAsync(
                new CreateInstanceRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                    Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
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
        /// form `[a-z][-a-z0-9]*[a-z0-9]` and must be between 2 and 64 characters in
        /// length.
        /// </param>
        /// <param name="instance">
        /// Required. The instance to create.  The name may be omitted, but if
        /// specified must be `&lt;parent&gt;/instances/&lt;instance_id&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<Instance, CreateInstanceMetadata>> CreateInstanceAsync(
            ProjectName parent,
            string instanceId,
            Instance instance,
            st::CancellationToken cancellationToken) => CreateInstanceAsync(
                parent,
                instanceId,
                instance,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// form `[a-z][-a-z0-9]*[a-z0-9]` and must be between 2 and 64 characters in
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
        public virtual lro::Operation<Instance, CreateInstanceMetadata> CreateInstance(
            ProjectName parent,
            string instanceId,
            Instance instance,
            gaxgrpc::CallSettings callSettings = null) => CreateInstance(
                new CreateInstanceRequest
                {
                    ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                    Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
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
        /// form `[a-z][-a-z0-9]*[a-z0-9]` and must be between 2 and 64 characters in
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
        public virtual stt::Task<lro::Operation<Instance, CreateInstanceMetadata>> CreateInstanceAsync(
            string parent,
            string instanceId,
            Instance instance,
            gaxgrpc::CallSettings callSettings = null) => CreateInstanceAsync(
                new CreateInstanceRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                    Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
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
        /// form `[a-z][-a-z0-9]*[a-z0-9]` and must be between 2 and 64 characters in
        /// length.
        /// </param>
        /// <param name="instance">
        /// Required. The instance to create.  The name may be omitted, but if
        /// specified must be `&lt;parent&gt;/instances/&lt;instance_id&gt;`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<Instance, CreateInstanceMetadata>> CreateInstanceAsync(
            string parent,
            string instanceId,
            Instance instance,
            st::CancellationToken cancellationToken) => CreateInstanceAsync(
                parent,
                instanceId,
                instance,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// form `[a-z][-a-z0-9]*[a-z0-9]` and must be between 2 and 64 characters in
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
        public virtual lro::Operation<Instance, CreateInstanceMetadata> CreateInstance(
            string parent,
            string instanceId,
            Instance instance,
            gaxgrpc::CallSettings callSettings = null) => CreateInstance(
                new CreateInstanceRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    InstanceId = gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)),
                    Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
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
        public virtual stt::Task<lro::Operation<Instance, CreateInstanceMetadata>> CreateInstanceAsync(
            CreateInstanceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateInstanceAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, CreateInstanceMetadata>> PollOnceCreateInstanceAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<Instance, CreateInstanceMetadata>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
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
        public virtual lro::Operation<Instance, CreateInstanceMetadata> CreateInstance(
            CreateInstanceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>CreateInstance</c>.
        /// </summary>
        public virtual lro::OperationsClient CreateInstanceOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateInstance</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, CreateInstanceMetadata> PollOnceCreateInstance(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<Instance, CreateInstanceMetadata>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
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
        public virtual stt::Task<lro::Operation<Instance, UpdateInstanceMetadata>> UpdateInstanceAsync(
            InstanceName instance,
            pbwkt::FieldMask fieldMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateInstanceAsync(
                new UpdateInstanceRequest
                {
                    InstanceAsInstanceName = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                    FieldMask = gax::GaxPreconditions.CheckNotNull(fieldMask, nameof(fieldMask)),
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<Instance, UpdateInstanceMetadata>> UpdateInstanceAsync(
            InstanceName instance,
            pbwkt::FieldMask fieldMask,
            st::CancellationToken cancellationToken) => UpdateInstanceAsync(
                instance,
                fieldMask,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual lro::Operation<Instance, UpdateInstanceMetadata> UpdateInstance(
            InstanceName instance,
            pbwkt::FieldMask fieldMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateInstance(
                new UpdateInstanceRequest
                {
                    InstanceAsInstanceName = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                    FieldMask = gax::GaxPreconditions.CheckNotNull(fieldMask, nameof(fieldMask)),
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
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<Instance, UpdateInstanceMetadata>> UpdateInstanceAsync(
            Instance instance,
            pbwkt::FieldMask fieldMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateInstanceAsync(
                new UpdateInstanceRequest
                {
                    Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                    FieldMask = gax::GaxPreconditions.CheckNotNull(fieldMask, nameof(fieldMask)),
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<Instance, UpdateInstanceMetadata>> UpdateInstanceAsync(
            Instance instance,
            pbwkt::FieldMask fieldMask,
            st::CancellationToken cancellationToken) => UpdateInstanceAsync(
                instance,
                fieldMask,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual lro::Operation<Instance, UpdateInstanceMetadata> UpdateInstance(
            Instance instance,
            pbwkt::FieldMask fieldMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateInstance(
                new UpdateInstanceRequest
                {
                    Instance = gax::GaxPreconditions.CheckNotNull(instance, nameof(instance)),
                    FieldMask = gax::GaxPreconditions.CheckNotNull(fieldMask, nameof(fieldMask)),
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
        public virtual stt::Task<lro::Operation<Instance, UpdateInstanceMetadata>> UpdateInstanceAsync(
            UpdateInstanceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateInstanceAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instance, UpdateInstanceMetadata>> PollOnceUpdateInstanceAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<Instance, UpdateInstanceMetadata>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
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
        public virtual lro::Operation<Instance, UpdateInstanceMetadata> UpdateInstance(
            UpdateInstanceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>UpdateInstance</c>.
        /// </summary>
        public virtual lro::OperationsClient UpdateInstanceOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateInstance</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instance, UpdateInstanceMetadata> PollOnceUpdateInstance(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<Instance, UpdateInstanceMetadata>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
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
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteInstanceAsync(
            InstanceName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteInstanceAsync(
                new DeleteInstanceRequest
                {
                    InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteInstanceAsync(
            InstanceName name,
            st::CancellationToken cancellationToken) => DeleteInstanceAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual void DeleteInstance(
            InstanceName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteInstance(
                new DeleteInstanceRequest
                {
                    InstanceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
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
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteInstanceAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteInstanceAsync(
                new DeleteInstanceRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
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
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteInstanceAsync(
            string name,
            st::CancellationToken cancellationToken) => DeleteInstanceAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual void DeleteInstance(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteInstance(
                new DeleteInstanceRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
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
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteInstanceAsync(
            DeleteInstanceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteInstanceAsync(
            DeleteInstanceRequest request,
            st::CancellationToken cancellationToken) => DeleteInstanceAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual void DeleteInstance(
            DeleteInstanceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        /// See the operation documentation for the appropriate value for this field.
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
        public virtual stt::Task<iam::Policy> SetIamPolicyAsync(
            gax::IResourceName resource,
            iam::Policy policy,
            gaxgrpc::CallSettings callSettings = null) => SetIamPolicyAsync(
                new iam::SetIamPolicyRequest
                {
                    ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                    Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
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
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::Policy> SetIamPolicyAsync(
            gax::IResourceName resource,
            iam::Policy policy,
            st::CancellationToken cancellationToken) => SetIamPolicyAsync(
                resource,
                policy,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on an instance resource. Replaces any
        /// existing policy.
        ///
        /// Authorization requires `spanner.instances.setIamPolicy` on
        /// [resource][google.iam.v1.SetIamPolicyRequest.resource].
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
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
        public virtual iam::Policy SetIamPolicy(
            gax::IResourceName resource,
            iam::Policy policy,
            gaxgrpc::CallSettings callSettings = null) => SetIamPolicy(
                new iam::SetIamPolicyRequest
                {
                    ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                    Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
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
        /// See the operation documentation for the appropriate value for this field.
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
        public virtual stt::Task<iam::Policy> SetIamPolicyAsync(
            string resource,
            iam::Policy policy,
            gaxgrpc::CallSettings callSettings = null) => SetIamPolicyAsync(
                new iam::SetIamPolicyRequest
                {
                    Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                    Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
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
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="policy">
        /// REQUIRED: The complete policy to be applied to the `resource`. The size of
        /// the policy is limited to a few 10s of KB. An empty policy is a
        /// valid policy but certain Cloud Platform services (such as Projects)
        /// might reject them.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::Policy> SetIamPolicyAsync(
            string resource,
            iam::Policy policy,
            st::CancellationToken cancellationToken) => SetIamPolicyAsync(
                resource,
                policy,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the access control policy on an instance resource. Replaces any
        /// existing policy.
        ///
        /// Authorization requires `spanner.instances.setIamPolicy` on
        /// [resource][google.iam.v1.SetIamPolicyRequest.resource].
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being specified.
        /// See the operation documentation for the appropriate value for this field.
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
        public virtual iam::Policy SetIamPolicy(
            string resource,
            iam::Policy policy,
            gaxgrpc::CallSettings callSettings = null) => SetIamPolicy(
                new iam::SetIamPolicyRequest
                {
                    Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                    Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
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
        public virtual stt::Task<iam::Policy> SetIamPolicyAsync(
            iam::SetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::Policy> SetIamPolicyAsync(
            iam::SetIamPolicyRequest request,
            st::CancellationToken cancellationToken) => SetIamPolicyAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual iam::Policy SetIamPolicy(
            iam::SetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::Policy> GetIamPolicyAsync(
            gax::IResourceName resource,
            gaxgrpc::CallSettings callSettings = null) => GetIamPolicyAsync(
                new iam::GetIamPolicyRequest
                {
                    ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
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
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::Policy> GetIamPolicyAsync(
            gax::IResourceName resource,
            st::CancellationToken cancellationToken) => GetIamPolicyAsync(
                resource,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for an instance resource. Returns an empty
        /// policy if an instance exists but does not have a policy set.
        ///
        /// Authorization requires `spanner.instances.getIamPolicy` on
        /// [resource][google.iam.v1.GetIamPolicyRequest.resource].
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual iam::Policy GetIamPolicy(
            gax::IResourceName resource,
            gaxgrpc::CallSettings callSettings = null) => GetIamPolicy(
                new iam::GetIamPolicyRequest
                {
                    ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
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
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::Policy> GetIamPolicyAsync(
            string resource,
            gaxgrpc::CallSettings callSettings = null) => GetIamPolicyAsync(
                new iam::GetIamPolicyRequest
                {
                    Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
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
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::Policy> GetIamPolicyAsync(
            string resource,
            st::CancellationToken cancellationToken) => GetIamPolicyAsync(
                resource,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the access control policy for an instance resource. Returns an empty
        /// policy if an instance exists but does not have a policy set.
        ///
        /// Authorization requires `spanner.instances.getIamPolicy` on
        /// [resource][google.iam.v1.GetIamPolicyRequest.resource].
        /// </summary>
        /// <param name="resource">
        /// REQUIRED: The resource for which the policy is being requested.
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual iam::Policy GetIamPolicy(
            string resource,
            gaxgrpc::CallSettings callSettings = null) => GetIamPolicy(
                new iam::GetIamPolicyRequest
                {
                    Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
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
        public virtual stt::Task<iam::Policy> GetIamPolicyAsync(
            iam::GetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::Policy> GetIamPolicyAsync(
            iam::GetIamPolicyRequest request,
            st::CancellationToken cancellationToken) => GetIamPolicyAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual iam::Policy GetIamPolicy(
            iam::GetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        /// See the operation documentation for the appropriate value for this field.
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
        public virtual stt::Task<iam::TestIamPermissionsResponse> TestIamPermissionsAsync(
            gax::IResourceName resource,
            scg::IEnumerable<string> permissions,
            gaxgrpc::CallSettings callSettings = null) => TestIamPermissionsAsync(
                new iam::TestIamPermissionsRequest
                {
                    ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                    Permissions = { permissions ?? linq::Enumerable.Empty<string>() }, // Optional
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
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::TestIamPermissionsResponse> TestIamPermissionsAsync(
            gax::IResourceName resource,
            scg::IEnumerable<string> permissions,
            st::CancellationToken cancellationToken) => TestIamPermissionsAsync(
                resource,
                permissions,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// See the operation documentation for the appropriate value for this field.
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
        public virtual iam::TestIamPermissionsResponse TestIamPermissions(
            gax::IResourceName resource,
            scg::IEnumerable<string> permissions,
            gaxgrpc::CallSettings callSettings = null) => TestIamPermissions(
                new iam::TestIamPermissionsRequest
                {
                    ResourceAsResourceName = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
                    Permissions = { permissions ?? linq::Enumerable.Empty<string>() }, // Optional
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
        /// See the operation documentation for the appropriate value for this field.
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
        public virtual stt::Task<iam::TestIamPermissionsResponse> TestIamPermissionsAsync(
            string resource,
            scg::IEnumerable<string> permissions,
            gaxgrpc::CallSettings callSettings = null) => TestIamPermissionsAsync(
                new iam::TestIamPermissionsRequest
                {
                    Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                    Permissions = { permissions ?? linq::Enumerable.Empty<string>() }, // Optional
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
        /// See the operation documentation for the appropriate value for this field.
        /// </param>
        /// <param name="permissions">
        /// The set of permissions to check for the `resource`. Permissions with
        /// wildcards (such as '*' or 'storage.*') are not allowed. For more
        /// information see
        /// [IAM Overview](https://cloud.google.com/iam/docs/overview#permissions).
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::TestIamPermissionsResponse> TestIamPermissionsAsync(
            string resource,
            scg::IEnumerable<string> permissions,
            st::CancellationToken cancellationToken) => TestIamPermissionsAsync(
                resource,
                permissions,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// See the operation documentation for the appropriate value for this field.
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
        public virtual iam::TestIamPermissionsResponse TestIamPermissions(
            string resource,
            scg::IEnumerable<string> permissions,
            gaxgrpc::CallSettings callSettings = null) => TestIamPermissions(
                new iam::TestIamPermissionsRequest
                {
                    Resource = gax::GaxPreconditions.CheckNotNullOrEmpty(resource, nameof(resource)),
                    Permissions = { permissions ?? linq::Enumerable.Empty<string>() }, // Optional
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
        public virtual stt::Task<iam::TestIamPermissionsResponse> TestIamPermissionsAsync(
            iam::TestIamPermissionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
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
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<iam::TestIamPermissionsResponse> TestIamPermissionsAsync(
            iam::TestIamPermissionsRequest request,
            st::CancellationToken cancellationToken) => TestIamPermissionsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        public virtual iam::TestIamPermissionsResponse TestIamPermissions(
            iam::TestIamPermissionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// InstanceAdmin client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class InstanceAdminClientImpl : InstanceAdminClient
    {
        private readonly gaxgrpc::ApiCall<ListInstanceConfigsRequest, ListInstanceConfigsResponse> _callListInstanceConfigs;
        private readonly gaxgrpc::ApiCall<GetInstanceConfigRequest, InstanceConfig> _callGetInstanceConfig;
        private readonly gaxgrpc::ApiCall<ListInstancesRequest, ListInstancesResponse> _callListInstances;
        private readonly gaxgrpc::ApiCall<GetInstanceRequest, Instance> _callGetInstance;
        private readonly gaxgrpc::ApiCall<CreateInstanceRequest, lro::Operation> _callCreateInstance;
        private readonly gaxgrpc::ApiCall<UpdateInstanceRequest, lro::Operation> _callUpdateInstance;
        private readonly gaxgrpc::ApiCall<DeleteInstanceRequest, pbwkt::Empty> _callDeleteInstance;
        private readonly gaxgrpc::ApiCall<iam::SetIamPolicyRequest, iam::Policy> _callSetIamPolicy;
        private readonly gaxgrpc::ApiCall<iam::GetIamPolicyRequest, iam::Policy> _callGetIamPolicy;
        private readonly gaxgrpc::ApiCall<iam::TestIamPermissionsRequest, iam::TestIamPermissionsResponse> _callTestIamPermissions;

        /// <summary>
        /// Constructs a client wrapper for the InstanceAdmin service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="InstanceAdminSettings"/> used within this client </param>
        public InstanceAdminClientImpl(InstanceAdmin.InstanceAdminClient grpcClient, InstanceAdminSettings settings)
        {
            GrpcClient = grpcClient;
            InstanceAdminSettings effectiveSettings = settings ?? InstanceAdminSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            CreateInstanceOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.CreateInstanceOperationsSettings);
            UpdateInstanceOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.UpdateInstanceOperationsSettings);
            _callListInstanceConfigs = clientHelper.BuildApiCall<ListInstanceConfigsRequest, ListInstanceConfigsResponse>(
                GrpcClient.ListInstanceConfigsAsync, GrpcClient.ListInstanceConfigs, effectiveSettings.ListInstanceConfigsSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callGetInstanceConfig = clientHelper.BuildApiCall<GetInstanceConfigRequest, InstanceConfig>(
                GrpcClient.GetInstanceConfigAsync, GrpcClient.GetInstanceConfig, effectiveSettings.GetInstanceConfigSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callListInstances = clientHelper.BuildApiCall<ListInstancesRequest, ListInstancesResponse>(
                GrpcClient.ListInstancesAsync, GrpcClient.ListInstances, effectiveSettings.ListInstancesSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callGetInstance = clientHelper.BuildApiCall<GetInstanceRequest, Instance>(
                GrpcClient.GetInstanceAsync, GrpcClient.GetInstance, effectiveSettings.GetInstanceSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callCreateInstance = clientHelper.BuildApiCall<CreateInstanceRequest, lro::Operation>(
                GrpcClient.CreateInstanceAsync, GrpcClient.CreateInstance, effectiveSettings.CreateInstanceSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callUpdateInstance = clientHelper.BuildApiCall<UpdateInstanceRequest, lro::Operation>(
                GrpcClient.UpdateInstanceAsync, GrpcClient.UpdateInstance, effectiveSettings.UpdateInstanceSettings)
                .WithGoogleRequestParam("instance.name", request => request.Instance?.Name);
            _callDeleteInstance = clientHelper.BuildApiCall<DeleteInstanceRequest, pbwkt::Empty>(
                GrpcClient.DeleteInstanceAsync, GrpcClient.DeleteInstance, effectiveSettings.DeleteInstanceSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callSetIamPolicy = clientHelper.BuildApiCall<iam::SetIamPolicyRequest, iam::Policy>(
                GrpcClient.SetIamPolicyAsync, GrpcClient.SetIamPolicy, effectiveSettings.SetIamPolicySettings)
                .WithGoogleRequestParam("resource", request => request.Resource);
            _callGetIamPolicy = clientHelper.BuildApiCall<iam::GetIamPolicyRequest, iam::Policy>(
                GrpcClient.GetIamPolicyAsync, GrpcClient.GetIamPolicy, effectiveSettings.GetIamPolicySettings)
                .WithGoogleRequestParam("resource", request => request.Resource);
            _callTestIamPermissions = clientHelper.BuildApiCall<iam::TestIamPermissionsRequest, iam::TestIamPermissionsResponse>(
                GrpcClient.TestIamPermissionsAsync, GrpcClient.TestIamPermissions, effectiveSettings.TestIamPermissionsSettings)
                .WithGoogleRequestParam("resource", request => request.Resource);
            Modify_ApiCall(ref _callListInstanceConfigs);
            Modify_ListInstanceConfigsApiCall(ref _callListInstanceConfigs);
            Modify_ApiCall(ref _callGetInstanceConfig);
            Modify_GetInstanceConfigApiCall(ref _callGetInstanceConfig);
            Modify_ApiCall(ref _callListInstances);
            Modify_ListInstancesApiCall(ref _callListInstances);
            Modify_ApiCall(ref _callGetInstance);
            Modify_GetInstanceApiCall(ref _callGetInstance);
            Modify_ApiCall(ref _callCreateInstance);
            Modify_CreateInstanceApiCall(ref _callCreateInstance);
            Modify_ApiCall(ref _callUpdateInstance);
            Modify_UpdateInstanceApiCall(ref _callUpdateInstance);
            Modify_ApiCall(ref _callDeleteInstance);
            Modify_DeleteInstanceApiCall(ref _callDeleteInstance);
            Modify_ApiCall(ref _callSetIamPolicy);
            Modify_SetIamPolicyApiCall(ref _callSetIamPolicy);
            Modify_ApiCall(ref _callGetIamPolicy);
            Modify_GetIamPolicyApiCall(ref _callGetIamPolicy);
            Modify_ApiCall(ref _callTestIamPermissions);
            Modify_TestIamPermissionsApiCall(ref _callTestIamPermissions);
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
        partial void Modify_ListInstanceConfigsApiCall(ref gaxgrpc::ApiCall<ListInstanceConfigsRequest, ListInstanceConfigsResponse> call);
        partial void Modify_GetInstanceConfigApiCall(ref gaxgrpc::ApiCall<GetInstanceConfigRequest, InstanceConfig> call);
        partial void Modify_ListInstancesApiCall(ref gaxgrpc::ApiCall<ListInstancesRequest, ListInstancesResponse> call);
        partial void Modify_GetInstanceApiCall(ref gaxgrpc::ApiCall<GetInstanceRequest, Instance> call);
        partial void Modify_CreateInstanceApiCall(ref gaxgrpc::ApiCall<CreateInstanceRequest, lro::Operation> call);
        partial void Modify_UpdateInstanceApiCall(ref gaxgrpc::ApiCall<UpdateInstanceRequest, lro::Operation> call);
        partial void Modify_DeleteInstanceApiCall(ref gaxgrpc::ApiCall<DeleteInstanceRequest, pbwkt::Empty> call);
        partial void Modify_SetIamPolicyApiCall(ref gaxgrpc::ApiCall<iam::SetIamPolicyRequest, iam::Policy> call);
        partial void Modify_GetIamPolicyApiCall(ref gaxgrpc::ApiCall<iam::GetIamPolicyRequest, iam::Policy> call);
        partial void Modify_TestIamPermissionsApiCall(ref gaxgrpc::ApiCall<iam::TestIamPermissionsRequest, iam::TestIamPermissionsResponse> call);
        partial void OnConstruction(InstanceAdmin.InstanceAdminClient grpcClient, InstanceAdminSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC InstanceAdmin client.
        /// </summary>
        public override InstanceAdmin.InstanceAdminClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_ListInstanceConfigsRequest(ref ListInstanceConfigsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetInstanceConfigRequest(ref GetInstanceConfigRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListInstancesRequest(ref ListInstancesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetInstanceRequest(ref GetInstanceRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateInstanceRequest(ref CreateInstanceRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateInstanceRequest(ref UpdateInstanceRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteInstanceRequest(ref DeleteInstanceRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_SetIamPolicyRequest(ref iam::SetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetIamPolicyRequest(ref iam::GetIamPolicyRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_TestIamPermissionsRequest(ref iam::TestIamPermissionsRequest request, ref gaxgrpc::CallSettings settings);

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
        public override gax::PagedAsyncEnumerable<ListInstanceConfigsResponse, InstanceConfig> ListInstanceConfigsAsync(
            ListInstanceConfigsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstanceConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListInstanceConfigsRequest, ListInstanceConfigsResponse, InstanceConfig>(_callListInstanceConfigs, request, callSettings);
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
        public override gax::PagedEnumerable<ListInstanceConfigsResponse, InstanceConfig> ListInstanceConfigs(
            ListInstanceConfigsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstanceConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListInstanceConfigsRequest, ListInstanceConfigsResponse, InstanceConfig>(_callListInstanceConfigs, request, callSettings);
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
        public override stt::Task<InstanceConfig> GetInstanceConfigAsync(
            GetInstanceConfigRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
            gaxgrpc::CallSettings callSettings = null)
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
        public override gax::PagedAsyncEnumerable<ListInstancesResponse, Instance> ListInstancesAsync(
            ListInstancesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstancesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListInstancesRequest, ListInstancesResponse, Instance>(_callListInstances, request, callSettings);
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
        public override gax::PagedEnumerable<ListInstancesResponse, Instance> ListInstances(
            ListInstancesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstancesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListInstancesRequest, ListInstancesResponse, Instance>(_callListInstances, request, callSettings);
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
        public override stt::Task<Instance> GetInstanceAsync(
            GetInstanceRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
            gaxgrpc::CallSettings callSettings = null)
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
        public override async stt::Task<lro::Operation<Instance, CreateInstanceMetadata>> CreateInstanceAsync(
            CreateInstanceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, CreateInstanceMetadata>(
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
        public override lro::Operation<Instance, CreateInstanceMetadata> CreateInstance(
            CreateInstanceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, CreateInstanceMetadata>(
                _callCreateInstance.Sync(request, callSettings), CreateInstanceOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>CreateInstance</c>.
        /// </summary>
        public override lro::OperationsClient CreateInstanceOperationsClient { get; }

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
        public override async stt::Task<lro::Operation<Instance, UpdateInstanceMetadata>> UpdateInstanceAsync(
            UpdateInstanceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, UpdateInstanceMetadata>(
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
        public override lro::Operation<Instance, UpdateInstanceMetadata> UpdateInstance(
            UpdateInstanceRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInstanceRequest(ref request, ref callSettings);
            return new lro::Operation<Instance, UpdateInstanceMetadata>(
                _callUpdateInstance.Sync(request, callSettings), UpdateInstanceOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>UpdateInstance</c>.
        /// </summary>
        public override lro::OperationsClient UpdateInstanceOperationsClient { get; }

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
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public override stt::Task DeleteInstanceAsync(
            DeleteInstanceRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
        public override void DeleteInstance(
            DeleteInstanceRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
        public override stt::Task<iam::Policy> SetIamPolicyAsync(
            iam::SetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
        public override iam::Policy SetIamPolicy(
            iam::SetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
        public override stt::Task<iam::Policy> GetIamPolicyAsync(
            iam::GetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
        public override iam::Policy GetIamPolicy(
            iam::GetIamPolicyRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
        public override stt::Task<iam::TestIamPermissionsResponse> TestIamPermissionsAsync(
            iam::TestIamPermissionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
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
        public override iam::TestIamPermissionsResponse TestIamPermissions(
            iam::TestIamPermissionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestIamPermissionsRequest(ref request, ref callSettings);
            return _callTestIamPermissions.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListInstanceConfigsRequest : gaxgrpc::IPageRequest { }
    public partial class ListInstanceConfigsResponse : gaxgrpc::IPageResponse<InstanceConfig>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<InstanceConfig> GetEnumerator() => InstanceConfigs.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListInstancesRequest : gaxgrpc::IPageRequest { }
    public partial class ListInstancesResponse : gaxgrpc::IPageResponse<Instance>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<Instance> GetEnumerator() => Instances.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    // Partial Grpc class to enable LRO client creation
    public static partial class InstanceAdmin
    {
        public partial class InstanceAdminClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() => new lro::Operations.OperationsClient(CallInvoker);
        }
    }


}
