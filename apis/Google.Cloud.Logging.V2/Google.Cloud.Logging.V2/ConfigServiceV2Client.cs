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

namespace Google.Cloud.Logging.V2
{
    /// <summary>
    /// Settings for a <see cref="ConfigServiceV2Client"/>.
    /// </summary>
    public sealed partial class ConfigServiceV2Settings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="ConfigServiceV2Settings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="ConfigServiceV2Settings"/>.
        /// </returns>
        public static ConfigServiceV2Settings GetDefault() => new ConfigServiceV2Settings();

        /// <summary>
        /// Constructs a new <see cref="ConfigServiceV2Settings"/> object with default settings.
        /// </summary>
        public ConfigServiceV2Settings() { }

        private ConfigServiceV2Settings(ConfigServiceV2Settings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListSinksSettings = existing.ListSinksSettings;
            GetSinkSettings = existing.GetSinkSettings;
            CreateSinkSettings = existing.CreateSinkSettings;
            UpdateSinkSettings = existing.UpdateSinkSettings;
            DeleteSinkSettings = existing.DeleteSinkSettings;
            ListExclusionsSettings = existing.ListExclusionsSettings;
            GetExclusionSettings = existing.GetExclusionSettings;
            CreateExclusionSettings = existing.CreateExclusionSettings;
            UpdateExclusionSettings = existing.UpdateExclusionSettings;
            DeleteExclusionSettings = existing.DeleteExclusionSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ConfigServiceV2Settings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="ConfigServiceV2Client"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Internal"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> IdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Internal, grpccore::StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="ConfigServiceV2Client"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="ConfigServiceV2Client"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="ConfigServiceV2Client"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="ConfigServiceV2Client"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="ConfigServiceV2Client"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="ConfigServiceV2Client"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="ConfigServiceV2Client"/> RPC methods is defined as:
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
        /// "WriteSink" retry backoff for <see cref="ConfigServiceV2Client"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "WriteSink" retry backoff for <see cref="ConfigServiceV2Client"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "WriteSink" retry backoff for <see cref="ConfigServiceV2Client"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetWriteSinkRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(100),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "WriteSink" timeout backoff for <see cref="ConfigServiceV2Client"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "WriteSink" timeout backoff for <see cref="ConfigServiceV2Client"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "WriteSink" timeout backoff for <see cref="ConfigServiceV2Client"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 20000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetWriteSinkTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(20000),
            maxDelay: sys::TimeSpan.FromMilliseconds(20000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.ListSinks</c> and <c>ConfigServiceV2Client.ListSinksAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ConfigServiceV2Client.ListSinks</c> and
        /// <c>ConfigServiceV2Client.ListSinksAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Internal"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListSinksSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.GetSink</c> and <c>ConfigServiceV2Client.GetSinkAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ConfigServiceV2Client.GetSink</c> and
        /// <c>ConfigServiceV2Client.GetSinkAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Internal"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetSinkSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.CreateSink</c> and <c>ConfigServiceV2Client.CreateSinkAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ConfigServiceV2Client.CreateSink</c> and
        /// <c>ConfigServiceV2Client.CreateSinkAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateSinkSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.UpdateSink</c> and <c>ConfigServiceV2Client.UpdateSinkAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ConfigServiceV2Client.UpdateSink</c> and
        /// <c>ConfigServiceV2Client.UpdateSinkAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Internal"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSinkSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.DeleteSink</c> and <c>ConfigServiceV2Client.DeleteSinkAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ConfigServiceV2Client.DeleteSink</c> and
        /// <c>ConfigServiceV2Client.DeleteSinkAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Internal"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSinkSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.ListExclusions</c> and <c>ConfigServiceV2Client.ListExclusionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ConfigServiceV2Client.ListExclusions</c> and
        /// <c>ConfigServiceV2Client.ListExclusionsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Internal"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListExclusionsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.GetExclusion</c> and <c>ConfigServiceV2Client.GetExclusionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ConfigServiceV2Client.GetExclusion</c> and
        /// <c>ConfigServiceV2Client.GetExclusionAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Internal"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetExclusionSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.CreateExclusion</c> and <c>ConfigServiceV2Client.CreateExclusionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ConfigServiceV2Client.CreateExclusion</c> and
        /// <c>ConfigServiceV2Client.CreateExclusionAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings CreateExclusionSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.UpdateExclusion</c> and <c>ConfigServiceV2Client.UpdateExclusionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ConfigServiceV2Client.UpdateExclusion</c> and
        /// <c>ConfigServiceV2Client.UpdateExclusionAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings UpdateExclusionSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigServiceV2Client.DeleteExclusion</c> and <c>ConfigServiceV2Client.DeleteExclusionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ConfigServiceV2Client.DeleteExclusion</c> and
        /// <c>ConfigServiceV2Client.DeleteExclusionAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        /// <item><description><see cref="grpccore::StatusCode.Internal"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings DeleteExclusionSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="ConfigServiceV2Settings"/> object.</returns>
        public ConfigServiceV2Settings Clone() => new ConfigServiceV2Settings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ConfigServiceV2Client"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class ConfigServiceV2ClientBuilder : gaxgrpc::ClientBuilderBase<ConfigServiceV2Client>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public ConfigServiceV2Settings Settings { get; set; }

        /// <inheritdoc/>
        public override ConfigServiceV2Client Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ConfigServiceV2Client.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<ConfigServiceV2Client> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ConfigServiceV2Client.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => ConfigServiceV2Client.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => ConfigServiceV2Client.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => ConfigServiceV2Client.ChannelPool;
    }

    /// <summary>
    /// ConfigServiceV2 client wrapper, for convenient use.
    /// </summary>
    public abstract partial class ConfigServiceV2Client
    {
        /// <summary>
        /// The default endpoint for the ConfigServiceV2 service, which is a host of "logging.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("logging.googleapis.com", 443);

        /// <summary>
        /// The default ConfigServiceV2 scopes.
        /// </summary>
        /// <remarks>
        /// The default ConfigServiceV2 scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform.read-only"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/logging.admin"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/logging.read"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/logging.write"</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-platform.read-only",
            "https://www.googleapis.com/auth/logging.admin",
            "https://www.googleapis.com/auth/logging.read",
            "https://www.googleapis.com/auth/logging.write",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="ConfigServiceV2Client"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Logging.V2;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ConfigServiceV2Client client = await ConfigServiceV2Client.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Logging.V2;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ConfigServiceV2Client.DefaultEndpoint.Host, ConfigServiceV2Client.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ConfigServiceV2Client client = ConfigServiceV2Client.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ConfigServiceV2Settings"/>.</param>
        /// <returns>The task representing the created <see cref="ConfigServiceV2Client"/>.</returns>
        public static async stt::Task<ConfigServiceV2Client> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, ConfigServiceV2Settings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="ConfigServiceV2Client"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Logging.V2;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ConfigServiceV2Client client = ConfigServiceV2Client.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Logging.V2;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ConfigServiceV2Client.DefaultEndpoint.Host, ConfigServiceV2Client.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ConfigServiceV2Client client = ConfigServiceV2Client.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ConfigServiceV2Settings"/>.</param>
        /// <returns>The created <see cref="ConfigServiceV2Client"/>.</returns>
        public static ConfigServiceV2Client Create(gaxgrpc::ServiceEndpoint endpoint = null, ConfigServiceV2Settings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="ConfigServiceV2Client"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ConfigServiceV2Settings"/>.</param>
        /// <returns>The created <see cref="ConfigServiceV2Client"/>.</returns>
        public static ConfigServiceV2Client Create(grpccore::Channel channel, ConfigServiceV2Settings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="ConfigServiceV2Client"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ConfigServiceV2Settings"/>.</param>
        /// <returns>The created <see cref="ConfigServiceV2Client"/>.</returns>
        public static ConfigServiceV2Client Create(grpccore::CallInvoker callInvoker, ConfigServiceV2Settings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ConfigServiceV2.ConfigServiceV2Client grpcClient = new ConfigServiceV2.ConfigServiceV2Client(callInvoker);
            return new ConfigServiceV2ClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, ConfigServiceV2Settings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, ConfigServiceV2Settings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, ConfigServiceV2Settings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, ConfigServiceV2Settings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC ConfigServiceV2 client.
        /// </summary>
        public virtual ConfigServiceV2.ConfigServiceV2Client GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose sinks are to be listed:
        ///
        ///     "projects/[PROJECT_ID]"
        ///     "organizations/[ORGANIZATION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]"
        ///     "folders/[FOLDER_ID]"
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
        /// A pageable asynchronous sequence of <see cref="LogSink"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListSinksResponse, LogSink> ListSinksAsync(
            ParentNameOneof parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListSinksAsync(
                new ListSinksRequest
                {
                    ParentAsParentNameOneof = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose sinks are to be listed:
        ///
        ///     "projects/[PROJECT_ID]"
        ///     "organizations/[ORGANIZATION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]"
        ///     "folders/[FOLDER_ID]"
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
        /// A pageable sequence of <see cref="LogSink"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListSinksResponse, LogSink> ListSinks(
            ParentNameOneof parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListSinks(
                new ListSinksRequest
                {
                    ParentAsParentNameOneof = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose sinks are to be listed:
        ///
        ///     "projects/[PROJECT_ID]"
        ///     "organizations/[ORGANIZATION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]"
        ///     "folders/[FOLDER_ID]"
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
        /// A pageable asynchronous sequence of <see cref="LogSink"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListSinksResponse, LogSink> ListSinksAsync(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListSinksAsync(
                new ListSinksRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose sinks are to be listed:
        ///
        ///     "projects/[PROJECT_ID]"
        ///     "organizations/[ORGANIZATION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]"
        ///     "folders/[FOLDER_ID]"
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
        /// A pageable sequence of <see cref="LogSink"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListSinksResponse, LogSink> ListSinks(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListSinks(
                new ListSinksRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="LogSink"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListSinksResponse, LogSink> ListSinksAsync(
            ListSinksRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="LogSink"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListSinksResponse, LogSink> ListSinks(
            ListSinksRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The resource name of the sink:
        ///
        ///     "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        ///     "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        ///     "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        ///
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<LogSink> GetSinkAsync(
            SinkNameOneof sinkName,
            gaxgrpc::CallSettings callSettings = null) => GetSinkAsync(
                new GetSinkRequest
                {
                    SinkNameAsSinkNameOneof = gax::GaxPreconditions.CheckNotNull(sinkName, nameof(sinkName)),
                },
                callSettings);

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The resource name of the sink:
        ///
        ///     "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        ///     "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        ///     "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        ///
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<LogSink> GetSinkAsync(
            SinkNameOneof sinkName,
            st::CancellationToken cancellationToken) => GetSinkAsync(
                sinkName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The resource name of the sink:
        ///
        ///     "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        ///     "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        ///     "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        ///
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual LogSink GetSink(
            SinkNameOneof sinkName,
            gaxgrpc::CallSettings callSettings = null) => GetSink(
                new GetSinkRequest
                {
                    SinkNameAsSinkNameOneof = gax::GaxPreconditions.CheckNotNull(sinkName, nameof(sinkName)),
                },
                callSettings);

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The resource name of the sink:
        ///
        ///     "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        ///     "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        ///     "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        ///
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<LogSink> GetSinkAsync(
            string sinkName,
            gaxgrpc::CallSettings callSettings = null) => GetSinkAsync(
                new GetSinkRequest
                {
                    SinkName = gax::GaxPreconditions.CheckNotNullOrEmpty(sinkName, nameof(sinkName)),
                },
                callSettings);

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The resource name of the sink:
        ///
        ///     "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        ///     "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        ///     "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        ///
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<LogSink> GetSinkAsync(
            string sinkName,
            st::CancellationToken cancellationToken) => GetSinkAsync(
                sinkName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a sink.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The resource name of the sink:
        ///
        ///     "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        ///     "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        ///     "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        ///
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual LogSink GetSink(
            string sinkName,
            gaxgrpc::CallSettings callSettings = null) => GetSink(
                new GetSinkRequest
                {
                    SinkName = gax::GaxPreconditions.CheckNotNullOrEmpty(sinkName, nameof(sinkName)),
                },
                callSettings);

        /// <summary>
        /// Gets a sink.
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
        public virtual stt::Task<LogSink> GetSinkAsync(
            GetSinkRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets a sink.
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
        public virtual stt::Task<LogSink> GetSinkAsync(
            GetSinkRequest request,
            st::CancellationToken cancellationToken) => GetSinkAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a sink.
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
        public virtual LogSink GetSink(
            GetSinkRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource in which to create the sink:
        ///
        ///     "projects/[PROJECT_ID]"
        ///     "organizations/[ORGANIZATION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]"
        ///     "folders/[FOLDER_ID]"
        ///
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="sink">
        /// Required. The new sink, whose `name` parameter is a sink identifier that
        /// is not already in use.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<LogSink> CreateSinkAsync(
            ParentNameOneof parent,
            LogSink sink,
            gaxgrpc::CallSettings callSettings = null) => CreateSinkAsync(
                new CreateSinkRequest
                {
                    ParentAsParentNameOneof = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
                },
                callSettings);

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource in which to create the sink:
        ///
        ///     "projects/[PROJECT_ID]"
        ///     "organizations/[ORGANIZATION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]"
        ///     "folders/[FOLDER_ID]"
        ///
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="sink">
        /// Required. The new sink, whose `name` parameter is a sink identifier that
        /// is not already in use.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<LogSink> CreateSinkAsync(
            ParentNameOneof parent,
            LogSink sink,
            st::CancellationToken cancellationToken) => CreateSinkAsync(
                parent,
                sink,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource in which to create the sink:
        ///
        ///     "projects/[PROJECT_ID]"
        ///     "organizations/[ORGANIZATION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]"
        ///     "folders/[FOLDER_ID]"
        ///
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="sink">
        /// Required. The new sink, whose `name` parameter is a sink identifier that
        /// is not already in use.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual LogSink CreateSink(
            ParentNameOneof parent,
            LogSink sink,
            gaxgrpc::CallSettings callSettings = null) => CreateSink(
                new CreateSinkRequest
                {
                    ParentAsParentNameOneof = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
                },
                callSettings);

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource in which to create the sink:
        ///
        ///     "projects/[PROJECT_ID]"
        ///     "organizations/[ORGANIZATION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]"
        ///     "folders/[FOLDER_ID]"
        ///
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="sink">
        /// Required. The new sink, whose `name` parameter is a sink identifier that
        /// is not already in use.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<LogSink> CreateSinkAsync(
            string parent,
            LogSink sink,
            gaxgrpc::CallSettings callSettings = null) => CreateSinkAsync(
                new CreateSinkRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
                },
                callSettings);

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource in which to create the sink:
        ///
        ///     "projects/[PROJECT_ID]"
        ///     "organizations/[ORGANIZATION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]"
        ///     "folders/[FOLDER_ID]"
        ///
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="sink">
        /// Required. The new sink, whose `name` parameter is a sink identifier that
        /// is not already in use.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<LogSink> CreateSinkAsync(
            string parent,
            LogSink sink,
            st::CancellationToken cancellationToken) => CreateSinkAsync(
                parent,
                sink,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource in which to create the sink:
        ///
        ///     "projects/[PROJECT_ID]"
        ///     "organizations/[ORGANIZATION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]"
        ///     "folders/[FOLDER_ID]"
        ///
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="sink">
        /// Required. The new sink, whose `name` parameter is a sink identifier that
        /// is not already in use.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual LogSink CreateSink(
            string parent,
            LogSink sink,
            gaxgrpc::CallSettings callSettings = null) => CreateSink(
                new CreateSinkRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
                },
                callSettings);

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
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
        public virtual stt::Task<LogSink> CreateSinkAsync(
            CreateSinkRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
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
        public virtual stt::Task<LogSink> CreateSinkAsync(
            CreateSinkRequest request,
            st::CancellationToken cancellationToken) => CreateSinkAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
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
        public virtual LogSink CreateSink(
            CreateSinkRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        ///
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to update, including the
        /// parent resource and the sink identifier:
        ///
        ///     "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        ///     "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        ///     "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        ///
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="sink">
        /// Required. The updated sink, whose name is the same identifier that appears
        /// as part of `sink_name`.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask that specifies the fields in `sink` that need
        /// an update. A sink field will be overwritten if, and only if, it is
        /// in the update mask. `name` and output only fields cannot be updated.
        ///
        /// An empty updateMask is temporarily treated as using the following mask
        /// for backwards compatibility purposes:
        ///   destination,filter,includeChildren
        /// At some point in the future, behavior will be removed and specifying an
        /// empty updateMask will be an error.
        ///
        /// For a detailed `FieldMask` definition, see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.FieldMask
        ///
        /// Example: `updateMask=filter`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<LogSink> UpdateSinkAsync(
            SinkNameOneof sinkName,
            LogSink sink,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateSinkAsync(
                new UpdateSinkRequest
                {
                    SinkNameAsSinkNameOneof = gax::GaxPreconditions.CheckNotNull(sinkName, nameof(sinkName)),
                    Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
                    UpdateMask = updateMask, // Optional
                },
                callSettings);

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        ///
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to update, including the
        /// parent resource and the sink identifier:
        ///
        ///     "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        ///     "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        ///     "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        ///
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="sink">
        /// Required. The updated sink, whose name is the same identifier that appears
        /// as part of `sink_name`.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask that specifies the fields in `sink` that need
        /// an update. A sink field will be overwritten if, and only if, it is
        /// in the update mask. `name` and output only fields cannot be updated.
        ///
        /// An empty updateMask is temporarily treated as using the following mask
        /// for backwards compatibility purposes:
        ///   destination,filter,includeChildren
        /// At some point in the future, behavior will be removed and specifying an
        /// empty updateMask will be an error.
        ///
        /// For a detailed `FieldMask` definition, see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.FieldMask
        ///
        /// Example: `updateMask=filter`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<LogSink> UpdateSinkAsync(
            SinkNameOneof sinkName,
            LogSink sink,
            pbwkt::FieldMask updateMask,
            st::CancellationToken cancellationToken) => UpdateSinkAsync(
                sinkName,
                sink,
                updateMask,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        ///
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to update, including the
        /// parent resource and the sink identifier:
        ///
        ///     "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        ///     "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        ///     "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        ///
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="sink">
        /// Required. The updated sink, whose name is the same identifier that appears
        /// as part of `sink_name`.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask that specifies the fields in `sink` that need
        /// an update. A sink field will be overwritten if, and only if, it is
        /// in the update mask. `name` and output only fields cannot be updated.
        ///
        /// An empty updateMask is temporarily treated as using the following mask
        /// for backwards compatibility purposes:
        ///   destination,filter,includeChildren
        /// At some point in the future, behavior will be removed and specifying an
        /// empty updateMask will be an error.
        ///
        /// For a detailed `FieldMask` definition, see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.FieldMask
        ///
        /// Example: `updateMask=filter`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual LogSink UpdateSink(
            SinkNameOneof sinkName,
            LogSink sink,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateSink(
                new UpdateSinkRequest
                {
                    SinkNameAsSinkNameOneof = gax::GaxPreconditions.CheckNotNull(sinkName, nameof(sinkName)),
                    Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
                    UpdateMask = updateMask, // Optional
                },
                callSettings);

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        ///
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to update, including the
        /// parent resource and the sink identifier:
        ///
        ///     "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        ///     "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        ///     "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        ///
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="sink">
        /// Required. The updated sink, whose name is the same identifier that appears
        /// as part of `sink_name`.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask that specifies the fields in `sink` that need
        /// an update. A sink field will be overwritten if, and only if, it is
        /// in the update mask. `name` and output only fields cannot be updated.
        ///
        /// An empty updateMask is temporarily treated as using the following mask
        /// for backwards compatibility purposes:
        ///   destination,filter,includeChildren
        /// At some point in the future, behavior will be removed and specifying an
        /// empty updateMask will be an error.
        ///
        /// For a detailed `FieldMask` definition, see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.FieldMask
        ///
        /// Example: `updateMask=filter`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<LogSink> UpdateSinkAsync(
            string sinkName,
            LogSink sink,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateSinkAsync(
                new UpdateSinkRequest
                {
                    SinkName = gax::GaxPreconditions.CheckNotNullOrEmpty(sinkName, nameof(sinkName)),
                    Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
                    UpdateMask = updateMask, // Optional
                },
                callSettings);

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        ///
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to update, including the
        /// parent resource and the sink identifier:
        ///
        ///     "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        ///     "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        ///     "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        ///
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="sink">
        /// Required. The updated sink, whose name is the same identifier that appears
        /// as part of `sink_name`.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask that specifies the fields in `sink` that need
        /// an update. A sink field will be overwritten if, and only if, it is
        /// in the update mask. `name` and output only fields cannot be updated.
        ///
        /// An empty updateMask is temporarily treated as using the following mask
        /// for backwards compatibility purposes:
        ///   destination,filter,includeChildren
        /// At some point in the future, behavior will be removed and specifying an
        /// empty updateMask will be an error.
        ///
        /// For a detailed `FieldMask` definition, see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.FieldMask
        ///
        /// Example: `updateMask=filter`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<LogSink> UpdateSinkAsync(
            string sinkName,
            LogSink sink,
            pbwkt::FieldMask updateMask,
            st::CancellationToken cancellationToken) => UpdateSinkAsync(
                sinkName,
                sink,
                updateMask,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        ///
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to update, including the
        /// parent resource and the sink identifier:
        ///
        ///     "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        ///     "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        ///     "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        ///
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="sink">
        /// Required. The updated sink, whose name is the same identifier that appears
        /// as part of `sink_name`.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask that specifies the fields in `sink` that need
        /// an update. A sink field will be overwritten if, and only if, it is
        /// in the update mask. `name` and output only fields cannot be updated.
        ///
        /// An empty updateMask is temporarily treated as using the following mask
        /// for backwards compatibility purposes:
        ///   destination,filter,includeChildren
        /// At some point in the future, behavior will be removed and specifying an
        /// empty updateMask will be an error.
        ///
        /// For a detailed `FieldMask` definition, see
        /// https://developers.google.com/protocol-buffers/docs/reference/google.protobuf#google.protobuf.FieldMask
        ///
        /// Example: `updateMask=filter`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual LogSink UpdateSink(
            string sinkName,
            LogSink sink,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateSink(
                new UpdateSinkRequest
                {
                    SinkName = gax::GaxPreconditions.CheckNotNullOrEmpty(sinkName, nameof(sinkName)),
                    Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
                    UpdateMask = updateMask, // Optional
                },
                callSettings);

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        ///
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to update, including the
        /// parent resource and the sink identifier:
        ///
        ///     "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        ///     "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        ///     "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        ///
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="sink">
        /// Required. The updated sink, whose name is the same identifier that appears
        /// as part of `sink_name`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<LogSink> UpdateSinkAsync(
            SinkNameOneof sinkName,
            LogSink sink,
            gaxgrpc::CallSettings callSettings = null) => UpdateSinkAsync(
                new UpdateSinkRequest
                {
                    SinkNameAsSinkNameOneof = gax::GaxPreconditions.CheckNotNull(sinkName, nameof(sinkName)),
                    Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
                },
                callSettings);

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        ///
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to update, including the
        /// parent resource and the sink identifier:
        ///
        ///     "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        ///     "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        ///     "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        ///
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="sink">
        /// Required. The updated sink, whose name is the same identifier that appears
        /// as part of `sink_name`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<LogSink> UpdateSinkAsync(
            SinkNameOneof sinkName,
            LogSink sink,
            st::CancellationToken cancellationToken) => UpdateSinkAsync(
                sinkName,
                sink,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        ///
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to update, including the
        /// parent resource and the sink identifier:
        ///
        ///     "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        ///     "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        ///     "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        ///
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="sink">
        /// Required. The updated sink, whose name is the same identifier that appears
        /// as part of `sink_name`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual LogSink UpdateSink(
            SinkNameOneof sinkName,
            LogSink sink,
            gaxgrpc::CallSettings callSettings = null) => UpdateSink(
                new UpdateSinkRequest
                {
                    SinkNameAsSinkNameOneof = gax::GaxPreconditions.CheckNotNull(sinkName, nameof(sinkName)),
                    Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
                },
                callSettings);

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        ///
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to update, including the
        /// parent resource and the sink identifier:
        ///
        ///     "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        ///     "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        ///     "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        ///
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="sink">
        /// Required. The updated sink, whose name is the same identifier that appears
        /// as part of `sink_name`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<LogSink> UpdateSinkAsync(
            string sinkName,
            LogSink sink,
            gaxgrpc::CallSettings callSettings = null) => UpdateSinkAsync(
                new UpdateSinkRequest
                {
                    SinkName = gax::GaxPreconditions.CheckNotNullOrEmpty(sinkName, nameof(sinkName)),
                    Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
                },
                callSettings);

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        ///
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to update, including the
        /// parent resource and the sink identifier:
        ///
        ///     "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        ///     "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        ///     "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        ///
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="sink">
        /// Required. The updated sink, whose name is the same identifier that appears
        /// as part of `sink_name`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<LogSink> UpdateSinkAsync(
            string sinkName,
            LogSink sink,
            st::CancellationToken cancellationToken) => UpdateSinkAsync(
                sinkName,
                sink,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        ///
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to update, including the
        /// parent resource and the sink identifier:
        ///
        ///     "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        ///     "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        ///     "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        ///
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="sink">
        /// Required. The updated sink, whose name is the same identifier that appears
        /// as part of `sink_name`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual LogSink UpdateSink(
            string sinkName,
            LogSink sink,
            gaxgrpc::CallSettings callSettings = null) => UpdateSink(
                new UpdateSinkRequest
                {
                    SinkName = gax::GaxPreconditions.CheckNotNullOrEmpty(sinkName, nameof(sinkName)),
                    Sink = gax::GaxPreconditions.CheckNotNull(sink, nameof(sink)),
                },
                callSettings);

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        ///
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
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
        public virtual stt::Task<LogSink> UpdateSinkAsync(
            UpdateSinkRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        ///
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
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
        public virtual stt::Task<LogSink> UpdateSinkAsync(
            UpdateSinkRequest request,
            st::CancellationToken cancellationToken) => UpdateSinkAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        ///
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
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
        public virtual LogSink UpdateSink(
            UpdateSinkRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes a sink. If the sink has a unique `writer_identity`, then that
        /// service account is also deleted.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to delete, including the
        /// parent resource and the sink identifier:
        ///
        ///     "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        ///     "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        ///     "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        ///
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteSinkAsync(
            SinkNameOneof sinkName,
            gaxgrpc::CallSettings callSettings = null) => DeleteSinkAsync(
                new DeleteSinkRequest
                {
                    SinkNameAsSinkNameOneof = gax::GaxPreconditions.CheckNotNull(sinkName, nameof(sinkName)),
                },
                callSettings);

        /// <summary>
        /// Deletes a sink. If the sink has a unique `writer_identity`, then that
        /// service account is also deleted.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to delete, including the
        /// parent resource and the sink identifier:
        ///
        ///     "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        ///     "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        ///     "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        ///
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteSinkAsync(
            SinkNameOneof sinkName,
            st::CancellationToken cancellationToken) => DeleteSinkAsync(
                sinkName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a sink. If the sink has a unique `writer_identity`, then that
        /// service account is also deleted.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to delete, including the
        /// parent resource and the sink identifier:
        ///
        ///     "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        ///     "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        ///     "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        ///
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteSink(
            SinkNameOneof sinkName,
            gaxgrpc::CallSettings callSettings = null) => DeleteSink(
                new DeleteSinkRequest
                {
                    SinkNameAsSinkNameOneof = gax::GaxPreconditions.CheckNotNull(sinkName, nameof(sinkName)),
                },
                callSettings);

        /// <summary>
        /// Deletes a sink. If the sink has a unique `writer_identity`, then that
        /// service account is also deleted.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to delete, including the
        /// parent resource and the sink identifier:
        ///
        ///     "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        ///     "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        ///     "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        ///
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteSinkAsync(
            string sinkName,
            gaxgrpc::CallSettings callSettings = null) => DeleteSinkAsync(
                new DeleteSinkRequest
                {
                    SinkName = gax::GaxPreconditions.CheckNotNullOrEmpty(sinkName, nameof(sinkName)),
                },
                callSettings);

        /// <summary>
        /// Deletes a sink. If the sink has a unique `writer_identity`, then that
        /// service account is also deleted.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to delete, including the
        /// parent resource and the sink identifier:
        ///
        ///     "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        ///     "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        ///     "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        ///
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteSinkAsync(
            string sinkName,
            st::CancellationToken cancellationToken) => DeleteSinkAsync(
                sinkName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a sink. If the sink has a unique `writer_identity`, then that
        /// service account is also deleted.
        /// </summary>
        /// <param name="sinkName">
        /// Required. The full resource name of the sink to delete, including the
        /// parent resource and the sink identifier:
        ///
        ///     "projects/[PROJECT_ID]/sinks/[SINK_ID]"
        ///     "organizations/[ORGANIZATION_ID]/sinks/[SINK_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/sinks/[SINK_ID]"
        ///     "folders/[FOLDER_ID]/sinks/[SINK_ID]"
        ///
        /// Example: `"projects/my-project-id/sinks/my-sink-id"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteSink(
            string sinkName,
            gaxgrpc::CallSettings callSettings = null) => DeleteSink(
                new DeleteSinkRequest
                {
                    SinkName = gax::GaxPreconditions.CheckNotNullOrEmpty(sinkName, nameof(sinkName)),
                },
                callSettings);

        /// <summary>
        /// Deletes a sink. If the sink has a unique `writer_identity`, then that
        /// service account is also deleted.
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
        public virtual stt::Task DeleteSinkAsync(
            DeleteSinkRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes a sink. If the sink has a unique `writer_identity`, then that
        /// service account is also deleted.
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
        public virtual stt::Task DeleteSinkAsync(
            DeleteSinkRequest request,
            st::CancellationToken cancellationToken) => DeleteSinkAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a sink. If the sink has a unique `writer_identity`, then that
        /// service account is also deleted.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteSink(
            DeleteSinkRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists all the exclusions in a parent resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose exclusions are to be listed.
        ///
        ///     "projects/[PROJECT_ID]"
        ///     "organizations/[ORGANIZATION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]"
        ///     "folders/[FOLDER_ID]"
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
        /// A pageable asynchronous sequence of <see cref="LogExclusion"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListExclusionsResponse, LogExclusion> ListExclusionsAsync(
            ParentNameOneof parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListExclusionsAsync(
                new ListExclusionsRequest
                {
                    ParentAsParentNameOneof = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists all the exclusions in a parent resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose exclusions are to be listed.
        ///
        ///     "projects/[PROJECT_ID]"
        ///     "organizations/[ORGANIZATION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]"
        ///     "folders/[FOLDER_ID]"
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
        /// A pageable sequence of <see cref="LogExclusion"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListExclusionsResponse, LogExclusion> ListExclusions(
            ParentNameOneof parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListExclusions(
                new ListExclusionsRequest
                {
                    ParentAsParentNameOneof = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists all the exclusions in a parent resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose exclusions are to be listed.
        ///
        ///     "projects/[PROJECT_ID]"
        ///     "organizations/[ORGANIZATION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]"
        ///     "folders/[FOLDER_ID]"
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
        /// A pageable asynchronous sequence of <see cref="LogExclusion"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListExclusionsResponse, LogExclusion> ListExclusionsAsync(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListExclusionsAsync(
                new ListExclusionsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists all the exclusions in a parent resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource whose exclusions are to be listed.
        ///
        ///     "projects/[PROJECT_ID]"
        ///     "organizations/[ORGANIZATION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]"
        ///     "folders/[FOLDER_ID]"
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
        /// A pageable sequence of <see cref="LogExclusion"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListExclusionsResponse, LogExclusion> ListExclusions(
            string parent,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListExclusions(
                new ListExclusionsRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists all the exclusions in a parent resource.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="LogExclusion"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListExclusionsResponse, LogExclusion> ListExclusionsAsync(
            ListExclusionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists all the exclusions in a parent resource.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="LogExclusion"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListExclusionsResponse, LogExclusion> ListExclusions(
            ListExclusionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets the description of an exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion:
        ///
        ///     "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        ///
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<LogExclusion> GetExclusionAsync(
            ExclusionNameOneof name,
            gaxgrpc::CallSettings callSettings = null) => GetExclusionAsync(
                new GetExclusionRequest
                {
                    ExclusionNameOneof = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the description of an exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion:
        ///
        ///     "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        ///
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<LogExclusion> GetExclusionAsync(
            ExclusionNameOneof name,
            st::CancellationToken cancellationToken) => GetExclusionAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the description of an exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion:
        ///
        ///     "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        ///
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual LogExclusion GetExclusion(
            ExclusionNameOneof name,
            gaxgrpc::CallSettings callSettings = null) => GetExclusion(
                new GetExclusionRequest
                {
                    ExclusionNameOneof = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the description of an exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion:
        ///
        ///     "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        ///
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<LogExclusion> GetExclusionAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetExclusionAsync(
                new GetExclusionRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the description of an exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion:
        ///
        ///     "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        ///
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<LogExclusion> GetExclusionAsync(
            string name,
            st::CancellationToken cancellationToken) => GetExclusionAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the description of an exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion:
        ///
        ///     "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        ///
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual LogExclusion GetExclusion(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetExclusion(
                new GetExclusionRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets the description of an exclusion.
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
        public virtual stt::Task<LogExclusion> GetExclusionAsync(
            GetExclusionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets the description of an exclusion.
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
        public virtual stt::Task<LogExclusion> GetExclusionAsync(
            GetExclusionRequest request,
            st::CancellationToken cancellationToken) => GetExclusionAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the description of an exclusion.
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
        public virtual LogExclusion GetExclusion(
            GetExclusionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a new exclusion in a specified parent resource.
        /// Only log entries belonging to that resource can be excluded.
        /// You can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the exclusion:
        ///
        ///     "projects/[PROJECT_ID]"
        ///     "organizations/[ORGANIZATION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]"
        ///     "folders/[FOLDER_ID]"
        ///
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="exclusion">
        /// Required. The new exclusion, whose `name` parameter is an exclusion name
        /// that is not already used in the parent resource.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<LogExclusion> CreateExclusionAsync(
            ParentNameOneof parent,
            LogExclusion exclusion,
            gaxgrpc::CallSettings callSettings = null) => CreateExclusionAsync(
                new CreateExclusionRequest
                {
                    ParentAsParentNameOneof = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Exclusion = gax::GaxPreconditions.CheckNotNull(exclusion, nameof(exclusion)),
                },
                callSettings);

        /// <summary>
        /// Creates a new exclusion in a specified parent resource.
        /// Only log entries belonging to that resource can be excluded.
        /// You can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the exclusion:
        ///
        ///     "projects/[PROJECT_ID]"
        ///     "organizations/[ORGANIZATION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]"
        ///     "folders/[FOLDER_ID]"
        ///
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="exclusion">
        /// Required. The new exclusion, whose `name` parameter is an exclusion name
        /// that is not already used in the parent resource.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<LogExclusion> CreateExclusionAsync(
            ParentNameOneof parent,
            LogExclusion exclusion,
            st::CancellationToken cancellationToken) => CreateExclusionAsync(
                parent,
                exclusion,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new exclusion in a specified parent resource.
        /// Only log entries belonging to that resource can be excluded.
        /// You can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the exclusion:
        ///
        ///     "projects/[PROJECT_ID]"
        ///     "organizations/[ORGANIZATION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]"
        ///     "folders/[FOLDER_ID]"
        ///
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="exclusion">
        /// Required. The new exclusion, whose `name` parameter is an exclusion name
        /// that is not already used in the parent resource.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual LogExclusion CreateExclusion(
            ParentNameOneof parent,
            LogExclusion exclusion,
            gaxgrpc::CallSettings callSettings = null) => CreateExclusion(
                new CreateExclusionRequest
                {
                    ParentAsParentNameOneof = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Exclusion = gax::GaxPreconditions.CheckNotNull(exclusion, nameof(exclusion)),
                },
                callSettings);

        /// <summary>
        /// Creates a new exclusion in a specified parent resource.
        /// Only log entries belonging to that resource can be excluded.
        /// You can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the exclusion:
        ///
        ///     "projects/[PROJECT_ID]"
        ///     "organizations/[ORGANIZATION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]"
        ///     "folders/[FOLDER_ID]"
        ///
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="exclusion">
        /// Required. The new exclusion, whose `name` parameter is an exclusion name
        /// that is not already used in the parent resource.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<LogExclusion> CreateExclusionAsync(
            string parent,
            LogExclusion exclusion,
            gaxgrpc::CallSettings callSettings = null) => CreateExclusionAsync(
                new CreateExclusionRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Exclusion = gax::GaxPreconditions.CheckNotNull(exclusion, nameof(exclusion)),
                },
                callSettings);

        /// <summary>
        /// Creates a new exclusion in a specified parent resource.
        /// Only log entries belonging to that resource can be excluded.
        /// You can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the exclusion:
        ///
        ///     "projects/[PROJECT_ID]"
        ///     "organizations/[ORGANIZATION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]"
        ///     "folders/[FOLDER_ID]"
        ///
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="exclusion">
        /// Required. The new exclusion, whose `name` parameter is an exclusion name
        /// that is not already used in the parent resource.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<LogExclusion> CreateExclusionAsync(
            string parent,
            LogExclusion exclusion,
            st::CancellationToken cancellationToken) => CreateExclusionAsync(
                parent,
                exclusion,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new exclusion in a specified parent resource.
        /// Only log entries belonging to that resource can be excluded.
        /// You can have up to 10 exclusions in a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the exclusion:
        ///
        ///     "projects/[PROJECT_ID]"
        ///     "organizations/[ORGANIZATION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]"
        ///     "folders/[FOLDER_ID]"
        ///
        /// Examples: `"projects/my-logging-project"`, `"organizations/123456789"`.
        /// </param>
        /// <param name="exclusion">
        /// Required. The new exclusion, whose `name` parameter is an exclusion name
        /// that is not already used in the parent resource.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual LogExclusion CreateExclusion(
            string parent,
            LogExclusion exclusion,
            gaxgrpc::CallSettings callSettings = null) => CreateExclusion(
                new CreateExclusionRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Exclusion = gax::GaxPreconditions.CheckNotNull(exclusion, nameof(exclusion)),
                },
                callSettings);

        /// <summary>
        /// Creates a new exclusion in a specified parent resource.
        /// Only log entries belonging to that resource can be excluded.
        /// You can have up to 10 exclusions in a resource.
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
        public virtual stt::Task<LogExclusion> CreateExclusionAsync(
            CreateExclusionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a new exclusion in a specified parent resource.
        /// Only log entries belonging to that resource can be excluded.
        /// You can have up to 10 exclusions in a resource.
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
        public virtual stt::Task<LogExclusion> CreateExclusionAsync(
            CreateExclusionRequest request,
            st::CancellationToken cancellationToken) => CreateExclusionAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new exclusion in a specified parent resource.
        /// Only log entries belonging to that resource can be excluded.
        /// You can have up to 10 exclusions in a resource.
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
        public virtual LogExclusion CreateExclusion(
            CreateExclusionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Changes one or more properties of an existing exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the exclusion to update:
        ///
        ///     "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        ///
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="exclusion">
        /// Required. New values for the existing exclusion. Only the fields specified
        /// in `update_mask` are relevant.
        /// </param>
        /// <param name="updateMask">
        /// Required. A non-empty list of fields to change in the existing exclusion.
        /// New values for the fields are taken from the corresponding fields in the
        /// [LogExclusion][google.logging.v2.LogExclusion] included in this request. Fields not mentioned in
        /// `update_mask` are not changed and are ignored in the request.
        ///
        /// For example, to change the filter and description of an exclusion,
        /// specify an `update_mask` of `"filter,description"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<LogExclusion> UpdateExclusionAsync(
            ExclusionNameOneof name,
            LogExclusion exclusion,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateExclusionAsync(
                new UpdateExclusionRequest
                {
                    ExclusionNameOneof = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Exclusion = gax::GaxPreconditions.CheckNotNull(exclusion, nameof(exclusion)),
                    UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                },
                callSettings);

        /// <summary>
        /// Changes one or more properties of an existing exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the exclusion to update:
        ///
        ///     "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        ///
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="exclusion">
        /// Required. New values for the existing exclusion. Only the fields specified
        /// in `update_mask` are relevant.
        /// </param>
        /// <param name="updateMask">
        /// Required. A non-empty list of fields to change in the existing exclusion.
        /// New values for the fields are taken from the corresponding fields in the
        /// [LogExclusion][google.logging.v2.LogExclusion] included in this request. Fields not mentioned in
        /// `update_mask` are not changed and are ignored in the request.
        ///
        /// For example, to change the filter and description of an exclusion,
        /// specify an `update_mask` of `"filter,description"`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<LogExclusion> UpdateExclusionAsync(
            ExclusionNameOneof name,
            LogExclusion exclusion,
            pbwkt::FieldMask updateMask,
            st::CancellationToken cancellationToken) => UpdateExclusionAsync(
                name,
                exclusion,
                updateMask,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Changes one or more properties of an existing exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the exclusion to update:
        ///
        ///     "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        ///
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="exclusion">
        /// Required. New values for the existing exclusion. Only the fields specified
        /// in `update_mask` are relevant.
        /// </param>
        /// <param name="updateMask">
        /// Required. A non-empty list of fields to change in the existing exclusion.
        /// New values for the fields are taken from the corresponding fields in the
        /// [LogExclusion][google.logging.v2.LogExclusion] included in this request. Fields not mentioned in
        /// `update_mask` are not changed and are ignored in the request.
        ///
        /// For example, to change the filter and description of an exclusion,
        /// specify an `update_mask` of `"filter,description"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual LogExclusion UpdateExclusion(
            ExclusionNameOneof name,
            LogExclusion exclusion,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateExclusion(
                new UpdateExclusionRequest
                {
                    ExclusionNameOneof = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                    Exclusion = gax::GaxPreconditions.CheckNotNull(exclusion, nameof(exclusion)),
                    UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                },
                callSettings);

        /// <summary>
        /// Changes one or more properties of an existing exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the exclusion to update:
        ///
        ///     "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        ///
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="exclusion">
        /// Required. New values for the existing exclusion. Only the fields specified
        /// in `update_mask` are relevant.
        /// </param>
        /// <param name="updateMask">
        /// Required. A non-empty list of fields to change in the existing exclusion.
        /// New values for the fields are taken from the corresponding fields in the
        /// [LogExclusion][google.logging.v2.LogExclusion] included in this request. Fields not mentioned in
        /// `update_mask` are not changed and are ignored in the request.
        ///
        /// For example, to change the filter and description of an exclusion,
        /// specify an `update_mask` of `"filter,description"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<LogExclusion> UpdateExclusionAsync(
            string name,
            LogExclusion exclusion,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateExclusionAsync(
                new UpdateExclusionRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    Exclusion = gax::GaxPreconditions.CheckNotNull(exclusion, nameof(exclusion)),
                    UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                },
                callSettings);

        /// <summary>
        /// Changes one or more properties of an existing exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the exclusion to update:
        ///
        ///     "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        ///
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="exclusion">
        /// Required. New values for the existing exclusion. Only the fields specified
        /// in `update_mask` are relevant.
        /// </param>
        /// <param name="updateMask">
        /// Required. A non-empty list of fields to change in the existing exclusion.
        /// New values for the fields are taken from the corresponding fields in the
        /// [LogExclusion][google.logging.v2.LogExclusion] included in this request. Fields not mentioned in
        /// `update_mask` are not changed and are ignored in the request.
        ///
        /// For example, to change the filter and description of an exclusion,
        /// specify an `update_mask` of `"filter,description"`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<LogExclusion> UpdateExclusionAsync(
            string name,
            LogExclusion exclusion,
            pbwkt::FieldMask updateMask,
            st::CancellationToken cancellationToken) => UpdateExclusionAsync(
                name,
                exclusion,
                updateMask,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Changes one or more properties of an existing exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the exclusion to update:
        ///
        ///     "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        ///
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="exclusion">
        /// Required. New values for the existing exclusion. Only the fields specified
        /// in `update_mask` are relevant.
        /// </param>
        /// <param name="updateMask">
        /// Required. A non-empty list of fields to change in the existing exclusion.
        /// New values for the fields are taken from the corresponding fields in the
        /// [LogExclusion][google.logging.v2.LogExclusion] included in this request. Fields not mentioned in
        /// `update_mask` are not changed and are ignored in the request.
        ///
        /// For example, to change the filter and description of an exclusion,
        /// specify an `update_mask` of `"filter,description"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual LogExclusion UpdateExclusion(
            string name,
            LogExclusion exclusion,
            pbwkt::FieldMask updateMask,
            gaxgrpc::CallSettings callSettings = null) => UpdateExclusion(
                new UpdateExclusionRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                    Exclusion = gax::GaxPreconditions.CheckNotNull(exclusion, nameof(exclusion)),
                    UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                },
                callSettings);

        /// <summary>
        /// Changes one or more properties of an existing exclusion.
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
        public virtual stt::Task<LogExclusion> UpdateExclusionAsync(
            UpdateExclusionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Changes one or more properties of an existing exclusion.
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
        public virtual stt::Task<LogExclusion> UpdateExclusionAsync(
            UpdateExclusionRequest request,
            st::CancellationToken cancellationToken) => UpdateExclusionAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Changes one or more properties of an existing exclusion.
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
        public virtual LogExclusion UpdateExclusion(
            UpdateExclusionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes an exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion to delete:
        ///
        ///     "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        ///
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteExclusionAsync(
            ExclusionNameOneof name,
            gaxgrpc::CallSettings callSettings = null) => DeleteExclusionAsync(
                new DeleteExclusionRequest
                {
                    ExclusionNameOneof = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes an exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion to delete:
        ///
        ///     "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        ///
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteExclusionAsync(
            ExclusionNameOneof name,
            st::CancellationToken cancellationToken) => DeleteExclusionAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion to delete:
        ///
        ///     "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        ///
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteExclusion(
            ExclusionNameOneof name,
            gaxgrpc::CallSettings callSettings = null) => DeleteExclusion(
                new DeleteExclusionRequest
                {
                    ExclusionNameOneof = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes an exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion to delete:
        ///
        ///     "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        ///
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteExclusionAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteExclusionAsync(
                new DeleteExclusionRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes an exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion to delete:
        ///
        ///     "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        ///
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task that completes when the RPC has completed.
        /// </returns>
        public virtual stt::Task DeleteExclusionAsync(
            string name,
            st::CancellationToken cancellationToken) => DeleteExclusionAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an exclusion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of an existing exclusion to delete:
        ///
        ///     "projects/[PROJECT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "organizations/[ORGANIZATION_ID]/exclusions/[EXCLUSION_ID]"
        ///     "billingAccounts/[BILLING_ACCOUNT_ID]/exclusions/[EXCLUSION_ID]"
        ///     "folders/[FOLDER_ID]/exclusions/[EXCLUSION_ID]"
        ///
        /// Example: `"projects/my-project-id/exclusions/my-exclusion-id"`.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteExclusion(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteExclusion(
                new DeleteExclusionRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes an exclusion.
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
        public virtual stt::Task DeleteExclusionAsync(
            DeleteExclusionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes an exclusion.
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
        public virtual stt::Task DeleteExclusionAsync(
            DeleteExclusionRequest request,
            st::CancellationToken cancellationToken) => DeleteExclusionAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an exclusion.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public virtual void DeleteExclusion(
            DeleteExclusionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// ConfigServiceV2 client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class ConfigServiceV2ClientImpl : ConfigServiceV2Client
    {
        private readonly gaxgrpc::ApiCall<ListSinksRequest, ListSinksResponse> _callListSinks;
        private readonly gaxgrpc::ApiCall<GetSinkRequest, LogSink> _callGetSink;
        private readonly gaxgrpc::ApiCall<CreateSinkRequest, LogSink> _callCreateSink;
        private readonly gaxgrpc::ApiCall<UpdateSinkRequest, LogSink> _callUpdateSink;
        private readonly gaxgrpc::ApiCall<DeleteSinkRequest, pbwkt::Empty> _callDeleteSink;
        private readonly gaxgrpc::ApiCall<ListExclusionsRequest, ListExclusionsResponse> _callListExclusions;
        private readonly gaxgrpc::ApiCall<GetExclusionRequest, LogExclusion> _callGetExclusion;
        private readonly gaxgrpc::ApiCall<CreateExclusionRequest, LogExclusion> _callCreateExclusion;
        private readonly gaxgrpc::ApiCall<UpdateExclusionRequest, LogExclusion> _callUpdateExclusion;
        private readonly gaxgrpc::ApiCall<DeleteExclusionRequest, pbwkt::Empty> _callDeleteExclusion;

        /// <summary>
        /// Constructs a client wrapper for the ConfigServiceV2 service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ConfigServiceV2Settings"/> used within this client </param>
        public ConfigServiceV2ClientImpl(ConfigServiceV2.ConfigServiceV2Client grpcClient, ConfigServiceV2Settings settings)
        {
            GrpcClient = grpcClient;
            ConfigServiceV2Settings effectiveSettings = settings ?? ConfigServiceV2Settings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callListSinks = clientHelper.BuildApiCall<ListSinksRequest, ListSinksResponse>(
                GrpcClient.ListSinksAsync, GrpcClient.ListSinks, effectiveSettings.ListSinksSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callGetSink = clientHelper.BuildApiCall<GetSinkRequest, LogSink>(
                GrpcClient.GetSinkAsync, GrpcClient.GetSink, effectiveSettings.GetSinkSettings)
                .WithGoogleRequestParam("sink_name", request => request.SinkName);
            _callCreateSink = clientHelper.BuildApiCall<CreateSinkRequest, LogSink>(
                GrpcClient.CreateSinkAsync, GrpcClient.CreateSink, effectiveSettings.CreateSinkSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callUpdateSink = clientHelper.BuildApiCall<UpdateSinkRequest, LogSink>(
                GrpcClient.UpdateSinkAsync, GrpcClient.UpdateSink, effectiveSettings.UpdateSinkSettings)
                .WithGoogleRequestParam("sink_name", request => request.SinkName);
            _callDeleteSink = clientHelper.BuildApiCall<DeleteSinkRequest, pbwkt::Empty>(
                GrpcClient.DeleteSinkAsync, GrpcClient.DeleteSink, effectiveSettings.DeleteSinkSettings)
                .WithGoogleRequestParam("sink_name", request => request.SinkName);
            _callListExclusions = clientHelper.BuildApiCall<ListExclusionsRequest, ListExclusionsResponse>(
                GrpcClient.ListExclusionsAsync, GrpcClient.ListExclusions, effectiveSettings.ListExclusionsSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callGetExclusion = clientHelper.BuildApiCall<GetExclusionRequest, LogExclusion>(
                GrpcClient.GetExclusionAsync, GrpcClient.GetExclusion, effectiveSettings.GetExclusionSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callCreateExclusion = clientHelper.BuildApiCall<CreateExclusionRequest, LogExclusion>(
                GrpcClient.CreateExclusionAsync, GrpcClient.CreateExclusion, effectiveSettings.CreateExclusionSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callUpdateExclusion = clientHelper.BuildApiCall<UpdateExclusionRequest, LogExclusion>(
                GrpcClient.UpdateExclusionAsync, GrpcClient.UpdateExclusion, effectiveSettings.UpdateExclusionSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callDeleteExclusion = clientHelper.BuildApiCall<DeleteExclusionRequest, pbwkt::Empty>(
                GrpcClient.DeleteExclusionAsync, GrpcClient.DeleteExclusion, effectiveSettings.DeleteExclusionSettings)
                .WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callListSinks);
            Modify_ListSinksApiCall(ref _callListSinks);
            Modify_ApiCall(ref _callGetSink);
            Modify_GetSinkApiCall(ref _callGetSink);
            Modify_ApiCall(ref _callCreateSink);
            Modify_CreateSinkApiCall(ref _callCreateSink);
            Modify_ApiCall(ref _callUpdateSink);
            Modify_UpdateSinkApiCall(ref _callUpdateSink);
            Modify_ApiCall(ref _callDeleteSink);
            Modify_DeleteSinkApiCall(ref _callDeleteSink);
            Modify_ApiCall(ref _callListExclusions);
            Modify_ListExclusionsApiCall(ref _callListExclusions);
            Modify_ApiCall(ref _callGetExclusion);
            Modify_GetExclusionApiCall(ref _callGetExclusion);
            Modify_ApiCall(ref _callCreateExclusion);
            Modify_CreateExclusionApiCall(ref _callCreateExclusion);
            Modify_ApiCall(ref _callUpdateExclusion);
            Modify_UpdateExclusionApiCall(ref _callUpdateExclusion);
            Modify_ApiCall(ref _callDeleteExclusion);
            Modify_DeleteExclusionApiCall(ref _callDeleteExclusion);
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
        partial void Modify_ListSinksApiCall(ref gaxgrpc::ApiCall<ListSinksRequest, ListSinksResponse> call);
        partial void Modify_GetSinkApiCall(ref gaxgrpc::ApiCall<GetSinkRequest, LogSink> call);
        partial void Modify_CreateSinkApiCall(ref gaxgrpc::ApiCall<CreateSinkRequest, LogSink> call);
        partial void Modify_UpdateSinkApiCall(ref gaxgrpc::ApiCall<UpdateSinkRequest, LogSink> call);
        partial void Modify_DeleteSinkApiCall(ref gaxgrpc::ApiCall<DeleteSinkRequest, pbwkt::Empty> call);
        partial void Modify_ListExclusionsApiCall(ref gaxgrpc::ApiCall<ListExclusionsRequest, ListExclusionsResponse> call);
        partial void Modify_GetExclusionApiCall(ref gaxgrpc::ApiCall<GetExclusionRequest, LogExclusion> call);
        partial void Modify_CreateExclusionApiCall(ref gaxgrpc::ApiCall<CreateExclusionRequest, LogExclusion> call);
        partial void Modify_UpdateExclusionApiCall(ref gaxgrpc::ApiCall<UpdateExclusionRequest, LogExclusion> call);
        partial void Modify_DeleteExclusionApiCall(ref gaxgrpc::ApiCall<DeleteExclusionRequest, pbwkt::Empty> call);
        partial void OnConstruction(ConfigServiceV2.ConfigServiceV2Client grpcClient, ConfigServiceV2Settings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC ConfigServiceV2 client.
        /// </summary>
        public override ConfigServiceV2.ConfigServiceV2Client GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_ListSinksRequest(ref ListSinksRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetSinkRequest(ref GetSinkRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateSinkRequest(ref CreateSinkRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateSinkRequest(ref UpdateSinkRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteSinkRequest(ref DeleteSinkRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListExclusionsRequest(ref ListExclusionsRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetExclusionRequest(ref GetExclusionRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateExclusionRequest(ref CreateExclusionRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_UpdateExclusionRequest(ref UpdateExclusionRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteExclusionRequest(ref DeleteExclusionRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="LogSink"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListSinksResponse, LogSink> ListSinksAsync(
            ListSinksRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSinksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSinksRequest, ListSinksResponse, LogSink>(_callListSinks, request, callSettings);
        }

        /// <summary>
        /// Lists sinks.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="LogSink"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListSinksResponse, LogSink> ListSinks(
            ListSinksRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSinksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSinksRequest, ListSinksResponse, LogSink>(_callListSinks, request, callSettings);
        }

        /// <summary>
        /// Gets a sink.
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
        public override stt::Task<LogSink> GetSinkAsync(
            GetSinkRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSinkRequest(ref request, ref callSettings);
            return _callGetSink.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a sink.
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
        public override LogSink GetSink(
            GetSinkRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSinkRequest(ref request, ref callSettings);
            return _callGetSink.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
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
        public override stt::Task<LogSink> CreateSinkAsync(
            CreateSinkRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSinkRequest(ref request, ref callSettings);
            return _callCreateSink.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a sink that exports specified log entries to a destination. The
        /// export of newly-ingested log entries begins immediately, unless the sink's
        /// `writer_identity` is not permitted to write to the destination. A sink can
        /// export log entries only from the resource owning the sink.
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
        public override LogSink CreateSink(
            CreateSinkRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSinkRequest(ref request, ref callSettings);
            return _callCreateSink.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        ///
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
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
        public override stt::Task<LogSink> UpdateSinkAsync(
            UpdateSinkRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSinkRequest(ref request, ref callSettings);
            return _callUpdateSink.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a sink. This method replaces the following fields in the existing
        /// sink with values from the new sink: `destination`, and `filter`.
        ///
        /// The updated sink might also have a new `writer_identity`; see the
        /// `unique_writer_identity` field.
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
        public override LogSink UpdateSink(
            UpdateSinkRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSinkRequest(ref request, ref callSettings);
            return _callUpdateSink.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a sink. If the sink has a unique `writer_identity`, then that
        /// service account is also deleted.
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
        public override stt::Task DeleteSinkAsync(
            DeleteSinkRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSinkRequest(ref request, ref callSettings);
            return _callDeleteSink.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a sink. If the sink has a unique `writer_identity`, then that
        /// service account is also deleted.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteSink(
            DeleteSinkRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSinkRequest(ref request, ref callSettings);
            _callDeleteSink.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists all the exclusions in a parent resource.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="LogExclusion"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListExclusionsResponse, LogExclusion> ListExclusionsAsync(
            ListExclusionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListExclusionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListExclusionsRequest, ListExclusionsResponse, LogExclusion>(_callListExclusions, request, callSettings);
        }

        /// <summary>
        /// Lists all the exclusions in a parent resource.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="LogExclusion"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListExclusionsResponse, LogExclusion> ListExclusions(
            ListExclusionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListExclusionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListExclusionsRequest, ListExclusionsResponse, LogExclusion>(_callListExclusions, request, callSettings);
        }

        /// <summary>
        /// Gets the description of an exclusion.
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
        public override stt::Task<LogExclusion> GetExclusionAsync(
            GetExclusionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetExclusionRequest(ref request, ref callSettings);
            return _callGetExclusion.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the description of an exclusion.
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
        public override LogExclusion GetExclusion(
            GetExclusionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetExclusionRequest(ref request, ref callSettings);
            return _callGetExclusion.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new exclusion in a specified parent resource.
        /// Only log entries belonging to that resource can be excluded.
        /// You can have up to 10 exclusions in a resource.
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
        public override stt::Task<LogExclusion> CreateExclusionAsync(
            CreateExclusionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateExclusionRequest(ref request, ref callSettings);
            return _callCreateExclusion.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new exclusion in a specified parent resource.
        /// Only log entries belonging to that resource can be excluded.
        /// You can have up to 10 exclusions in a resource.
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
        public override LogExclusion CreateExclusion(
            CreateExclusionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateExclusionRequest(ref request, ref callSettings);
            return _callCreateExclusion.Sync(request, callSettings);
        }

        /// <summary>
        /// Changes one or more properties of an existing exclusion.
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
        public override stt::Task<LogExclusion> UpdateExclusionAsync(
            UpdateExclusionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateExclusionRequest(ref request, ref callSettings);
            return _callUpdateExclusion.Async(request, callSettings);
        }

        /// <summary>
        /// Changes one or more properties of an existing exclusion.
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
        public override LogExclusion UpdateExclusion(
            UpdateExclusionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateExclusionRequest(ref request, ref callSettings);
            return _callUpdateExclusion.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an exclusion.
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
        public override stt::Task DeleteExclusionAsync(
            DeleteExclusionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteExclusionRequest(ref request, ref callSettings);
            return _callDeleteExclusion.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an exclusion.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        public override void DeleteExclusion(
            DeleteExclusionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteExclusionRequest(ref request, ref callSettings);
            _callDeleteExclusion.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming

    public partial class ListSinksRequest : gaxgrpc::IPageRequest { }
    public partial class ListSinksResponse : gaxgrpc::IPageResponse<LogSink>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<LogSink> GetEnumerator() => Sinks.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListExclusionsRequest : gaxgrpc::IPageRequest { }
    public partial class ListExclusionsResponse : gaxgrpc::IPageResponse<LogExclusion>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<LogExclusion> GetEnumerator() => Exclusions.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }


}
