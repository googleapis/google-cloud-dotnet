// Copyright 2025 Google LLC
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

#pragma warning disable CS8981
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.SecurityCenter.Settings.V1Beta1
{
    /// <summary>Settings for <see cref="SecurityCenterSettingsServiceClient"/> instances.</summary>
    public sealed partial class SecurityCenterSettingsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SecurityCenterSettingsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SecurityCenterSettingsServiceSettings"/>.</returns>
        public static SecurityCenterSettingsServiceSettings GetDefault() => new SecurityCenterSettingsServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="SecurityCenterSettingsServiceSettings"/> object with default settings.
        /// </summary>
        public SecurityCenterSettingsServiceSettings()
        {
        }

        private SecurityCenterSettingsServiceSettings(SecurityCenterSettingsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetServiceAccountSettings = existing.GetServiceAccountSettings;
            GetSettingsSettings = existing.GetSettingsSettings;
            UpdateSettingsSettings = existing.UpdateSettingsSettings;
            ResetSettingsSettings = existing.ResetSettingsSettings;
            BatchGetSettingsSettings = existing.BatchGetSettingsSettings;
            CalculateEffectiveSettingsSettings = existing.CalculateEffectiveSettingsSettings;
            BatchCalculateEffectiveSettingsSettings = existing.BatchCalculateEffectiveSettingsSettings;
            GetComponentSettingsSettings = existing.GetComponentSettingsSettings;
            UpdateComponentSettingsSettings = existing.UpdateComponentSettingsSettings;
            ResetComponentSettingsSettings = existing.ResetComponentSettingsSettings;
            CalculateEffectiveComponentSettingsSettings = existing.CalculateEffectiveComponentSettingsSettings;
            ListDetectorsSettings = existing.ListDetectorsSettings;
            ListComponentsSettings = existing.ListComponentsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SecurityCenterSettingsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterSettingsServiceClient.GetServiceAccount</c> and
        /// <c>SecurityCenterSettingsServiceClient.GetServiceAccountAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetServiceAccountSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterSettingsServiceClient.GetSettings</c> and
        /// <c>SecurityCenterSettingsServiceClient.GetSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSettingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterSettingsServiceClient.UpdateSettings</c> and
        /// <c>SecurityCenterSettingsServiceClient.UpdateSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSettingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterSettingsServiceClient.ResetSettings</c> and
        /// <c>SecurityCenterSettingsServiceClient.ResetSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResetSettingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterSettingsServiceClient.BatchGetSettings</c> and
        /// <c>SecurityCenterSettingsServiceClient.BatchGetSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchGetSettingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterSettingsServiceClient.CalculateEffectiveSettings</c> and
        /// <c>SecurityCenterSettingsServiceClient.CalculateEffectiveSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CalculateEffectiveSettingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterSettingsServiceClient.BatchCalculateEffectiveSettings</c> and
        /// <c>SecurityCenterSettingsServiceClient.BatchCalculateEffectiveSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchCalculateEffectiveSettingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterSettingsServiceClient.GetComponentSettings</c> and
        /// <c>SecurityCenterSettingsServiceClient.GetComponentSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetComponentSettingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterSettingsServiceClient.UpdateComponentSettings</c> and
        /// <c>SecurityCenterSettingsServiceClient.UpdateComponentSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateComponentSettingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterSettingsServiceClient.ResetComponentSettings</c> and
        /// <c>SecurityCenterSettingsServiceClient.ResetComponentSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResetComponentSettingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterSettingsServiceClient.CalculateEffectiveComponentSettings</c> and
        /// <c>SecurityCenterSettingsServiceClient.CalculateEffectiveComponentSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CalculateEffectiveComponentSettingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterSettingsServiceClient.ListDetectors</c> and
        /// <c>SecurityCenterSettingsServiceClient.ListDetectorsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDetectorsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterSettingsServiceClient.ListComponents</c> and
        /// <c>SecurityCenterSettingsServiceClient.ListComponentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListComponentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SecurityCenterSettingsServiceSettings"/> object.</returns>
        public SecurityCenterSettingsServiceSettings Clone() => new SecurityCenterSettingsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SecurityCenterSettingsServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class SecurityCenterSettingsServiceClientBuilder : gaxgrpc::ClientBuilderBase<SecurityCenterSettingsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SecurityCenterSettingsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SecurityCenterSettingsServiceClientBuilder() : base(SecurityCenterSettingsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SecurityCenterSettingsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SecurityCenterSettingsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SecurityCenterSettingsServiceClient Build()
        {
            SecurityCenterSettingsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SecurityCenterSettingsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SecurityCenterSettingsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SecurityCenterSettingsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SecurityCenterSettingsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SecurityCenterSettingsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SecurityCenterSettingsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SecurityCenterSettingsServiceClient.ChannelPool;
    }

    /// <summary>SecurityCenterSettingsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// ## API Overview
    /// 
    /// The SecurityCenterSettingsService is a sub-api of
    /// `securitycenter.googleapis.com`. The service provides methods to manage
    /// Security Center Settings, and Component Settings for GCP organizations,
    /// folders, projects, and clusters.
    /// </remarks>
    public abstract partial class SecurityCenterSettingsServiceClient
    {
        /// <summary>
        /// The default endpoint for the SecurityCenterSettingsService service, which is a host of
        /// "securitycenter.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "securitycenter.googleapis.com:443";

        /// <summary>The default SecurityCenterSettingsService scopes.</summary>
        /// <remarks>
        /// The default SecurityCenterSettingsService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SecurityCenterSettingsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SecurityCenterSettingsServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="SecurityCenterSettingsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SecurityCenterSettingsServiceClient"/>.</returns>
        public static stt::Task<SecurityCenterSettingsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SecurityCenterSettingsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SecurityCenterSettingsServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="SecurityCenterSettingsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SecurityCenterSettingsServiceClient"/>.</returns>
        public static SecurityCenterSettingsServiceClient Create() =>
            new SecurityCenterSettingsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SecurityCenterSettingsServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SecurityCenterSettingsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SecurityCenterSettingsServiceClient"/>.</returns>
        internal static SecurityCenterSettingsServiceClient Create(grpccore::CallInvoker callInvoker, SecurityCenterSettingsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SecurityCenterSettingsService.SecurityCenterSettingsServiceClient grpcClient = new SecurityCenterSettingsService.SecurityCenterSettingsServiceClient(callInvoker);
            return new SecurityCenterSettingsServiceClientImpl(grpcClient, settings, logger);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/>. Channels which weren't automatically created are not
        /// affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/> will create new channels, which could in turn be shut down
        /// by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC SecurityCenterSettingsService client</summary>
        public virtual SecurityCenterSettingsService.SecurityCenterSettingsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the organizations service account, if it exists, otherwise it
        /// creates the organization service account. This API is idempotent and
        /// will only create a service account once. On subsequent calls it will
        /// return the previously created service account.  SHA, SCC and CTD Infra
        /// Automation will use this SA.  This SA will not have any permissions when
        /// created.  The UI will provision this via IAM or the user will using
        /// their own internal process. This API only creates SAs on the organization.
        /// Folders are not supported and projects will use per-project SAs associated
        /// with APIs enabled on a project. This API will be called by the UX
        /// onboarding workflow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceAccount GetServiceAccount(GetServiceAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the organizations service account, if it exists, otherwise it
        /// creates the organization service account. This API is idempotent and
        /// will only create a service account once. On subsequent calls it will
        /// return the previously created service account.  SHA, SCC and CTD Infra
        /// Automation will use this SA.  This SA will not have any permissions when
        /// created.  The UI will provision this via IAM or the user will using
        /// their own internal process. This API only creates SAs on the organization.
        /// Folders are not supported and projects will use per-project SAs associated
        /// with APIs enabled on a project. This API will be called by the UX
        /// onboarding workflow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccount> GetServiceAccountAsync(GetServiceAccountRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the organizations service account, if it exists, otherwise it
        /// creates the organization service account. This API is idempotent and
        /// will only create a service account once. On subsequent calls it will
        /// return the previously created service account.  SHA, SCC and CTD Infra
        /// Automation will use this SA.  This SA will not have any permissions when
        /// created.  The UI will provision this via IAM or the user will using
        /// their own internal process. This API only creates SAs on the organization.
        /// Folders are not supported and projects will use per-project SAs associated
        /// with APIs enabled on a project. This API will be called by the UX
        /// onboarding workflow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccount> GetServiceAccountAsync(GetServiceAccountRequest request, st::CancellationToken cancellationToken) =>
            GetServiceAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the organizations service account, if it exists, otherwise it
        /// creates the organization service account. This API is idempotent and
        /// will only create a service account once. On subsequent calls it will
        /// return the previously created service account.  SHA, SCC and CTD Infra
        /// Automation will use this SA.  This SA will not have any permissions when
        /// created.  The UI will provision this via IAM or the user will using
        /// their own internal process. This API only creates SAs on the organization.
        /// Folders are not supported and projects will use per-project SAs associated
        /// with APIs enabled on a project. This API will be called by the UX
        /// onboarding workflow.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the service account resource.
        /// Format:
        /// * `organizations/{organization}/serviceAccount`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceAccount GetServiceAccount(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceAccount(new GetServiceAccountRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the organizations service account, if it exists, otherwise it
        /// creates the organization service account. This API is idempotent and
        /// will only create a service account once. On subsequent calls it will
        /// return the previously created service account.  SHA, SCC and CTD Infra
        /// Automation will use this SA.  This SA will not have any permissions when
        /// created.  The UI will provision this via IAM or the user will using
        /// their own internal process. This API only creates SAs on the organization.
        /// Folders are not supported and projects will use per-project SAs associated
        /// with APIs enabled on a project. This API will be called by the UX
        /// onboarding workflow.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the service account resource.
        /// Format:
        /// * `organizations/{organization}/serviceAccount`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccount> GetServiceAccountAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceAccountAsync(new GetServiceAccountRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the organizations service account, if it exists, otherwise it
        /// creates the organization service account. This API is idempotent and
        /// will only create a service account once. On subsequent calls it will
        /// return the previously created service account.  SHA, SCC and CTD Infra
        /// Automation will use this SA.  This SA will not have any permissions when
        /// created.  The UI will provision this via IAM or the user will using
        /// their own internal process. This API only creates SAs on the organization.
        /// Folders are not supported and projects will use per-project SAs associated
        /// with APIs enabled on a project. This API will be called by the UX
        /// onboarding workflow.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the service account resource.
        /// Format:
        /// * `organizations/{organization}/serviceAccount`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccount> GetServiceAccountAsync(string name, st::CancellationToken cancellationToken) =>
            GetServiceAccountAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the organizations service account, if it exists, otherwise it
        /// creates the organization service account. This API is idempotent and
        /// will only create a service account once. On subsequent calls it will
        /// return the previously created service account.  SHA, SCC and CTD Infra
        /// Automation will use this SA.  This SA will not have any permissions when
        /// created.  The UI will provision this via IAM or the user will using
        /// their own internal process. This API only creates SAs on the organization.
        /// Folders are not supported and projects will use per-project SAs associated
        /// with APIs enabled on a project. This API will be called by the UX
        /// onboarding workflow.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the service account resource.
        /// Format:
        /// * `organizations/{organization}/serviceAccount`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ServiceAccount GetServiceAccount(ServiceAccountName name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceAccount(new GetServiceAccountRequest
            {
                ServiceAccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the organizations service account, if it exists, otherwise it
        /// creates the organization service account. This API is idempotent and
        /// will only create a service account once. On subsequent calls it will
        /// return the previously created service account.  SHA, SCC and CTD Infra
        /// Automation will use this SA.  This SA will not have any permissions when
        /// created.  The UI will provision this via IAM or the user will using
        /// their own internal process. This API only creates SAs on the organization.
        /// Folders are not supported and projects will use per-project SAs associated
        /// with APIs enabled on a project. This API will be called by the UX
        /// onboarding workflow.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the service account resource.
        /// Format:
        /// * `organizations/{organization}/serviceAccount`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccount> GetServiceAccountAsync(ServiceAccountName name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceAccountAsync(new GetServiceAccountRequest
            {
                ServiceAccountName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves the organizations service account, if it exists, otherwise it
        /// creates the organization service account. This API is idempotent and
        /// will only create a service account once. On subsequent calls it will
        /// return the previously created service account.  SHA, SCC and CTD Infra
        /// Automation will use this SA.  This SA will not have any permissions when
        /// created.  The UI will provision this via IAM or the user will using
        /// their own internal process. This API only creates SAs on the organization.
        /// Folders are not supported and projects will use per-project SAs associated
        /// with APIs enabled on a project. This API will be called by the UX
        /// onboarding workflow.
        /// </summary>
        /// <param name="name">
        /// Required. The relative resource name of the service account resource.
        /// Format:
        /// * `organizations/{organization}/serviceAccount`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ServiceAccount> GetServiceAccountAsync(ServiceAccountName name, st::CancellationToken cancellationToken) =>
            GetServiceAccountAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the Settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings GetSettings(GetSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the Settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(GetSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the Settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(GetSettingsRequest request, st::CancellationToken cancellationToken) =>
            GetSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the Settings.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the settings to retrieve.
        /// Formats:
        /// * `organizations/{organization}/settings`
        /// * `folders/{folder}/settings`
        /// * `projects/{project}/settings`
        /// * `projects/{project}/locations/{location}/clusters/{cluster}/settings`
        /// * `projects/{project}/regions/{region}/clusters/{cluster}/settings`
        /// * `projects/{project}/zones/{zone}/clusters/{cluster}/settings`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings GetSettings(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSettings(new GetSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the Settings.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the settings to retrieve.
        /// Formats:
        /// * `organizations/{organization}/settings`
        /// * `folders/{folder}/settings`
        /// * `projects/{project}/settings`
        /// * `projects/{project}/locations/{location}/clusters/{cluster}/settings`
        /// * `projects/{project}/regions/{region}/clusters/{cluster}/settings`
        /// * `projects/{project}/zones/{zone}/clusters/{cluster}/settings`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSettingsAsync(new GetSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the Settings.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the settings to retrieve.
        /// Formats:
        /// * `organizations/{organization}/settings`
        /// * `folders/{folder}/settings`
        /// * `projects/{project}/settings`
        /// * `projects/{project}/locations/{location}/clusters/{cluster}/settings`
        /// * `projects/{project}/regions/{region}/clusters/{cluster}/settings`
        /// * `projects/{project}/zones/{zone}/clusters/{cluster}/settings`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(string name, st::CancellationToken cancellationToken) =>
            GetSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the Settings.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the settings to retrieve.
        /// Formats:
        /// * `organizations/{organization}/settings`
        /// * `folders/{folder}/settings`
        /// * `projects/{project}/settings`
        /// * `projects/{project}/locations/{location}/clusters/{cluster}/settings`
        /// * `projects/{project}/regions/{region}/clusters/{cluster}/settings`
        /// * `projects/{project}/zones/{zone}/clusters/{cluster}/settings`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings GetSettings(SettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSettings(new GetSettingsRequest
            {
                SettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the Settings.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the settings to retrieve.
        /// Formats:
        /// * `organizations/{organization}/settings`
        /// * `folders/{folder}/settings`
        /// * `projects/{project}/settings`
        /// * `projects/{project}/locations/{location}/clusters/{cluster}/settings`
        /// * `projects/{project}/regions/{region}/clusters/{cluster}/settings`
        /// * `projects/{project}/zones/{zone}/clusters/{cluster}/settings`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(SettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSettingsAsync(new GetSettingsRequest
            {
                SettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the Settings.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the settings to retrieve.
        /// Formats:
        /// * `organizations/{organization}/settings`
        /// * `folders/{folder}/settings`
        /// * `projects/{project}/settings`
        /// * `projects/{project}/locations/{location}/clusters/{cluster}/settings`
        /// * `projects/{project}/regions/{region}/clusters/{cluster}/settings`
        /// * `projects/{project}/zones/{zone}/clusters/{cluster}/settings`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(SettingsName name, st::CancellationToken cancellationToken) =>
            GetSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the Settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings UpdateSettings(UpdateSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the Settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> UpdateSettingsAsync(UpdateSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the Settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> UpdateSettingsAsync(UpdateSettingsRequest request, st::CancellationToken cancellationToken) =>
            UpdateSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the Settings.
        /// </summary>
        /// <param name="settings">
        /// Required. The settings to update.
        /// 
        /// The settings' `name` field is used to identify the settings to be updated.
        /// Formats:
        /// * `organizations/{organization}/settings`
        /// * `folders/{folder}/settings`
        /// * `projects/{project}/settings`
        /// * `projects/{project}/locations/{location}/clusters/{cluster}/settings`
        /// * `projects/{project}/regions/{region}/clusters/{cluster}/settings`
        /// * `projects/{project}/zones/{zone}/clusters/{cluster}/settings`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated on the settings.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings UpdateSettings(Settings settings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSettings(new UpdateSettingsRequest
            {
                Settings = gax::GaxPreconditions.CheckNotNull(settings, nameof(settings)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the Settings.
        /// </summary>
        /// <param name="settings">
        /// Required. The settings to update.
        /// 
        /// The settings' `name` field is used to identify the settings to be updated.
        /// Formats:
        /// * `organizations/{organization}/settings`
        /// * `folders/{folder}/settings`
        /// * `projects/{project}/settings`
        /// * `projects/{project}/locations/{location}/clusters/{cluster}/settings`
        /// * `projects/{project}/regions/{region}/clusters/{cluster}/settings`
        /// * `projects/{project}/zones/{zone}/clusters/{cluster}/settings`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated on the settings.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> UpdateSettingsAsync(Settings settings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSettingsAsync(new UpdateSettingsRequest
            {
                Settings = gax::GaxPreconditions.CheckNotNull(settings, nameof(settings)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the Settings.
        /// </summary>
        /// <param name="settings">
        /// Required. The settings to update.
        /// 
        /// The settings' `name` field is used to identify the settings to be updated.
        /// Formats:
        /// * `organizations/{organization}/settings`
        /// * `folders/{folder}/settings`
        /// * `projects/{project}/settings`
        /// * `projects/{project}/locations/{location}/clusters/{cluster}/settings`
        /// * `projects/{project}/regions/{region}/clusters/{cluster}/settings`
        /// * `projects/{project}/zones/{zone}/clusters/{cluster}/settings`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated on the settings.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> UpdateSettingsAsync(Settings settings, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSettingsAsync(settings, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reset the organization, folder or project's settings and return
        /// the settings of just that resource to the default.
        /// 
        /// Settings are present at the organization, folder, project, and cluster
        /// levels. Using Reset on a sub-organization level will remove that resource's
        /// override and result in the parent's settings being used (eg: if Reset on a
        /// cluster, project settings will be used).
        /// 
        /// Using Reset on organization will remove the override that was set and
        /// result in default settings being used.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void ResetSettings(ResetSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reset the organization, folder or project's settings and return
        /// the settings of just that resource to the default.
        /// 
        /// Settings are present at the organization, folder, project, and cluster
        /// levels. Using Reset on a sub-organization level will remove that resource's
        /// override and result in the parent's settings being used (eg: if Reset on a
        /// cluster, project settings will be used).
        /// 
        /// Using Reset on organization will remove the override that was set and
        /// result in default settings being used.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ResetSettingsAsync(ResetSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reset the organization, folder or project's settings and return
        /// the settings of just that resource to the default.
        /// 
        /// Settings are present at the organization, folder, project, and cluster
        /// levels. Using Reset on a sub-organization level will remove that resource's
        /// override and result in the parent's settings being used (eg: if Reset on a
        /// cluster, project settings will be used).
        /// 
        /// Using Reset on organization will remove the override that was set and
        /// result in default settings being used.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ResetSettingsAsync(ResetSettingsRequest request, st::CancellationToken cancellationToken) =>
            ResetSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a list of settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchGetSettingsResponse BatchGetSettings(BatchGetSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a list of settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchGetSettingsResponse> BatchGetSettingsAsync(BatchGetSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a list of settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchGetSettingsResponse> BatchGetSettingsAsync(BatchGetSettingsRequest request, st::CancellationToken cancellationToken) =>
            BatchGetSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// CalculateEffectiveSettings looks up all of the Security Center
        /// Settings resources in the GCP resource hierarchy, and calculates the
        /// effective settings on that resource by applying the following rules:
        /// * Settings provided closer to the target resource take precedence over
        /// those further away (e.g. folder will override organization level
        /// settings).
        /// * Product defaults can be overridden at org, folder, project, and cluster
        /// levels.
        /// * Detectors will be filtered out if they belong to a billing tier the
        /// customer
        /// has not configured.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings CalculateEffectiveSettings(CalculateEffectiveSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// CalculateEffectiveSettings looks up all of the Security Center
        /// Settings resources in the GCP resource hierarchy, and calculates the
        /// effective settings on that resource by applying the following rules:
        /// * Settings provided closer to the target resource take precedence over
        /// those further away (e.g. folder will override organization level
        /// settings).
        /// * Product defaults can be overridden at org, folder, project, and cluster
        /// levels.
        /// * Detectors will be filtered out if they belong to a billing tier the
        /// customer
        /// has not configured.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> CalculateEffectiveSettingsAsync(CalculateEffectiveSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// CalculateEffectiveSettings looks up all of the Security Center
        /// Settings resources in the GCP resource hierarchy, and calculates the
        /// effective settings on that resource by applying the following rules:
        /// * Settings provided closer to the target resource take precedence over
        /// those further away (e.g. folder will override organization level
        /// settings).
        /// * Product defaults can be overridden at org, folder, project, and cluster
        /// levels.
        /// * Detectors will be filtered out if they belong to a billing tier the
        /// customer
        /// has not configured.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> CalculateEffectiveSettingsAsync(CalculateEffectiveSettingsRequest request, st::CancellationToken cancellationToken) =>
            CalculateEffectiveSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// CalculateEffectiveSettings looks up all of the Security Center
        /// Settings resources in the GCP resource hierarchy, and calculates the
        /// effective settings on that resource by applying the following rules:
        /// * Settings provided closer to the target resource take precedence over
        /// those further away (e.g. folder will override organization level
        /// settings).
        /// * Product defaults can be overridden at org, folder, project, and cluster
        /// levels.
        /// * Detectors will be filtered out if they belong to a billing tier the
        /// customer
        /// has not configured.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the effective settings to retrieve.
        /// Formats:
        /// * `organizations/{organization}/effectiveSettings`
        /// * `folders/{folder}/effectiveSettings`
        /// * `projects/{project}/effectiveSettings`
        /// * `projects/{project}/locations/{location}/clusters/{cluster}/effectiveSettings`
        /// * `projects/{project}/regions/{region}/clusters/{cluster}/effectiveSettings`
        /// * `projects/{project}/zones/{zone}/clusters/{cluster}/effectiveSettings`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings CalculateEffectiveSettings(string name, gaxgrpc::CallSettings callSettings = null) =>
            CalculateEffectiveSettings(new CalculateEffectiveSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// CalculateEffectiveSettings looks up all of the Security Center
        /// Settings resources in the GCP resource hierarchy, and calculates the
        /// effective settings on that resource by applying the following rules:
        /// * Settings provided closer to the target resource take precedence over
        /// those further away (e.g. folder will override organization level
        /// settings).
        /// * Product defaults can be overridden at org, folder, project, and cluster
        /// levels.
        /// * Detectors will be filtered out if they belong to a billing tier the
        /// customer
        /// has not configured.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the effective settings to retrieve.
        /// Formats:
        /// * `organizations/{organization}/effectiveSettings`
        /// * `folders/{folder}/effectiveSettings`
        /// * `projects/{project}/effectiveSettings`
        /// * `projects/{project}/locations/{location}/clusters/{cluster}/effectiveSettings`
        /// * `projects/{project}/regions/{region}/clusters/{cluster}/effectiveSettings`
        /// * `projects/{project}/zones/{zone}/clusters/{cluster}/effectiveSettings`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> CalculateEffectiveSettingsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            CalculateEffectiveSettingsAsync(new CalculateEffectiveSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// CalculateEffectiveSettings looks up all of the Security Center
        /// Settings resources in the GCP resource hierarchy, and calculates the
        /// effective settings on that resource by applying the following rules:
        /// * Settings provided closer to the target resource take precedence over
        /// those further away (e.g. folder will override organization level
        /// settings).
        /// * Product defaults can be overridden at org, folder, project, and cluster
        /// levels.
        /// * Detectors will be filtered out if they belong to a billing tier the
        /// customer
        /// has not configured.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the effective settings to retrieve.
        /// Formats:
        /// * `organizations/{organization}/effectiveSettings`
        /// * `folders/{folder}/effectiveSettings`
        /// * `projects/{project}/effectiveSettings`
        /// * `projects/{project}/locations/{location}/clusters/{cluster}/effectiveSettings`
        /// * `projects/{project}/regions/{region}/clusters/{cluster}/effectiveSettings`
        /// * `projects/{project}/zones/{zone}/clusters/{cluster}/effectiveSettings`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> CalculateEffectiveSettingsAsync(string name, st::CancellationToken cancellationToken) =>
            CalculateEffectiveSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// CalculateEffectiveSettings looks up all of the Security Center
        /// Settings resources in the GCP resource hierarchy, and calculates the
        /// effective settings on that resource by applying the following rules:
        /// * Settings provided closer to the target resource take precedence over
        /// those further away (e.g. folder will override organization level
        /// settings).
        /// * Product defaults can be overridden at org, folder, project, and cluster
        /// levels.
        /// * Detectors will be filtered out if they belong to a billing tier the
        /// customer
        /// has not configured.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the effective settings to retrieve.
        /// Formats:
        /// * `organizations/{organization}/effectiveSettings`
        /// * `folders/{folder}/effectiveSettings`
        /// * `projects/{project}/effectiveSettings`
        /// * `projects/{project}/locations/{location}/clusters/{cluster}/effectiveSettings`
        /// * `projects/{project}/regions/{region}/clusters/{cluster}/effectiveSettings`
        /// * `projects/{project}/zones/{zone}/clusters/{cluster}/effectiveSettings`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings CalculateEffectiveSettings(SettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            CalculateEffectiveSettings(new CalculateEffectiveSettingsRequest
            {
                SettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// CalculateEffectiveSettings looks up all of the Security Center
        /// Settings resources in the GCP resource hierarchy, and calculates the
        /// effective settings on that resource by applying the following rules:
        /// * Settings provided closer to the target resource take precedence over
        /// those further away (e.g. folder will override organization level
        /// settings).
        /// * Product defaults can be overridden at org, folder, project, and cluster
        /// levels.
        /// * Detectors will be filtered out if they belong to a billing tier the
        /// customer
        /// has not configured.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the effective settings to retrieve.
        /// Formats:
        /// * `organizations/{organization}/effectiveSettings`
        /// * `folders/{folder}/effectiveSettings`
        /// * `projects/{project}/effectiveSettings`
        /// * `projects/{project}/locations/{location}/clusters/{cluster}/effectiveSettings`
        /// * `projects/{project}/regions/{region}/clusters/{cluster}/effectiveSettings`
        /// * `projects/{project}/zones/{zone}/clusters/{cluster}/effectiveSettings`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> CalculateEffectiveSettingsAsync(SettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            CalculateEffectiveSettingsAsync(new CalculateEffectiveSettingsRequest
            {
                SettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// CalculateEffectiveSettings looks up all of the Security Center
        /// Settings resources in the GCP resource hierarchy, and calculates the
        /// effective settings on that resource by applying the following rules:
        /// * Settings provided closer to the target resource take precedence over
        /// those further away (e.g. folder will override organization level
        /// settings).
        /// * Product defaults can be overridden at org, folder, project, and cluster
        /// levels.
        /// * Detectors will be filtered out if they belong to a billing tier the
        /// customer
        /// has not configured.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the effective settings to retrieve.
        /// Formats:
        /// * `organizations/{organization}/effectiveSettings`
        /// * `folders/{folder}/effectiveSettings`
        /// * `projects/{project}/effectiveSettings`
        /// * `projects/{project}/locations/{location}/clusters/{cluster}/effectiveSettings`
        /// * `projects/{project}/regions/{region}/clusters/{cluster}/effectiveSettings`
        /// * `projects/{project}/zones/{zone}/clusters/{cluster}/effectiveSettings`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> CalculateEffectiveSettingsAsync(SettingsName name, st::CancellationToken cancellationToken) =>
            CalculateEffectiveSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a list of effective settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BatchCalculateEffectiveSettingsResponse BatchCalculateEffectiveSettings(BatchCalculateEffectiveSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a list of effective settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCalculateEffectiveSettingsResponse> BatchCalculateEffectiveSettingsAsync(BatchCalculateEffectiveSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a list of effective settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BatchCalculateEffectiveSettingsResponse> BatchCalculateEffectiveSettingsAsync(BatchCalculateEffectiveSettingsRequest request, st::CancellationToken cancellationToken) =>
            BatchCalculateEffectiveSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the Component Settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ComponentSettings GetComponentSettings(GetComponentSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the Component Settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComponentSettings> GetComponentSettingsAsync(GetComponentSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the Component Settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComponentSettings> GetComponentSettingsAsync(GetComponentSettingsRequest request, st::CancellationToken cancellationToken) =>
            GetComponentSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the Component Settings.
        /// </summary>
        /// <param name="name">
        /// Required. The component settings to retrieve.
        /// 
        /// Formats:
        /// * `organizations/{organization}/components/{component}/settings`
        /// * `folders/{folder}/components/{component}/settings`
        /// * `projects/{project}/components/{component}/settings`
        /// * `projects/{project}/locations/{location}/clusters/{cluster}/components/{component}/settings`
        /// * `projects/{project}/regions/{region}/clusters/{cluster}/components/{component}/settings`
        /// * `projects/{project}/zones/{zone}/clusters/{cluster}/components/{component}/settings`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ComponentSettings GetComponentSettings(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetComponentSettings(new GetComponentSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the Component Settings.
        /// </summary>
        /// <param name="name">
        /// Required. The component settings to retrieve.
        /// 
        /// Formats:
        /// * `organizations/{organization}/components/{component}/settings`
        /// * `folders/{folder}/components/{component}/settings`
        /// * `projects/{project}/components/{component}/settings`
        /// * `projects/{project}/locations/{location}/clusters/{cluster}/components/{component}/settings`
        /// * `projects/{project}/regions/{region}/clusters/{cluster}/components/{component}/settings`
        /// * `projects/{project}/zones/{zone}/clusters/{cluster}/components/{component}/settings`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComponentSettings> GetComponentSettingsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetComponentSettingsAsync(new GetComponentSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the Component Settings.
        /// </summary>
        /// <param name="name">
        /// Required. The component settings to retrieve.
        /// 
        /// Formats:
        /// * `organizations/{organization}/components/{component}/settings`
        /// * `folders/{folder}/components/{component}/settings`
        /// * `projects/{project}/components/{component}/settings`
        /// * `projects/{project}/locations/{location}/clusters/{cluster}/components/{component}/settings`
        /// * `projects/{project}/regions/{region}/clusters/{cluster}/components/{component}/settings`
        /// * `projects/{project}/zones/{zone}/clusters/{cluster}/components/{component}/settings`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComponentSettings> GetComponentSettingsAsync(string name, st::CancellationToken cancellationToken) =>
            GetComponentSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the Component Settings.
        /// </summary>
        /// <param name="name">
        /// Required. The component settings to retrieve.
        /// 
        /// Formats:
        /// * `organizations/{organization}/components/{component}/settings`
        /// * `folders/{folder}/components/{component}/settings`
        /// * `projects/{project}/components/{component}/settings`
        /// * `projects/{project}/locations/{location}/clusters/{cluster}/components/{component}/settings`
        /// * `projects/{project}/regions/{region}/clusters/{cluster}/components/{component}/settings`
        /// * `projects/{project}/zones/{zone}/clusters/{cluster}/components/{component}/settings`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ComponentSettings GetComponentSettings(ComponentSettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetComponentSettings(new GetComponentSettingsRequest
            {
                ComponentSettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the Component Settings.
        /// </summary>
        /// <param name="name">
        /// Required. The component settings to retrieve.
        /// 
        /// Formats:
        /// * `organizations/{organization}/components/{component}/settings`
        /// * `folders/{folder}/components/{component}/settings`
        /// * `projects/{project}/components/{component}/settings`
        /// * `projects/{project}/locations/{location}/clusters/{cluster}/components/{component}/settings`
        /// * `projects/{project}/regions/{region}/clusters/{cluster}/components/{component}/settings`
        /// * `projects/{project}/zones/{zone}/clusters/{cluster}/components/{component}/settings`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComponentSettings> GetComponentSettingsAsync(ComponentSettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetComponentSettingsAsync(new GetComponentSettingsRequest
            {
                ComponentSettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the Component Settings.
        /// </summary>
        /// <param name="name">
        /// Required. The component settings to retrieve.
        /// 
        /// Formats:
        /// * `organizations/{organization}/components/{component}/settings`
        /// * `folders/{folder}/components/{component}/settings`
        /// * `projects/{project}/components/{component}/settings`
        /// * `projects/{project}/locations/{location}/clusters/{cluster}/components/{component}/settings`
        /// * `projects/{project}/regions/{region}/clusters/{cluster}/components/{component}/settings`
        /// * `projects/{project}/zones/{zone}/clusters/{cluster}/components/{component}/settings`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComponentSettings> GetComponentSettingsAsync(ComponentSettingsName name, st::CancellationToken cancellationToken) =>
            GetComponentSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the Component Settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ComponentSettings UpdateComponentSettings(UpdateComponentSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the Component Settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComponentSettings> UpdateComponentSettingsAsync(UpdateComponentSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the Component Settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComponentSettings> UpdateComponentSettingsAsync(UpdateComponentSettingsRequest request, st::CancellationToken cancellationToken) =>
            UpdateComponentSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the Component Settings.
        /// </summary>
        /// <param name="componentSettings">
        /// Required. The component settings to update.
        /// 
        /// The component settings' `name` field is used to identify the component
        /// settings to be updated. Formats:
        /// * `organizations/{organization}/components/{component}/settings`
        /// * `folders/{folder}/components/{component}/settings`
        /// * `projects/{project}/components/{component}/settings`
        /// * `projects/{project}/locations/{location}/clusters/{cluster}/components/{component}/settings`
        /// * `projects/{project}/regions/{region}/clusters/{cluster}/components/{component}/settings`
        /// * `projects/{project}/zones/{zone}/clusters/{cluster}/components/{component}/settings`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated on the component settings resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ComponentSettings UpdateComponentSettings(ComponentSettings componentSettings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateComponentSettings(new UpdateComponentSettingsRequest
            {
                ComponentSettings = gax::GaxPreconditions.CheckNotNull(componentSettings, nameof(componentSettings)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the Component Settings.
        /// </summary>
        /// <param name="componentSettings">
        /// Required. The component settings to update.
        /// 
        /// The component settings' `name` field is used to identify the component
        /// settings to be updated. Formats:
        /// * `organizations/{organization}/components/{component}/settings`
        /// * `folders/{folder}/components/{component}/settings`
        /// * `projects/{project}/components/{component}/settings`
        /// * `projects/{project}/locations/{location}/clusters/{cluster}/components/{component}/settings`
        /// * `projects/{project}/regions/{region}/clusters/{cluster}/components/{component}/settings`
        /// * `projects/{project}/zones/{zone}/clusters/{cluster}/components/{component}/settings`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated on the component settings resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComponentSettings> UpdateComponentSettingsAsync(ComponentSettings componentSettings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateComponentSettingsAsync(new UpdateComponentSettingsRequest
            {
                ComponentSettings = gax::GaxPreconditions.CheckNotNull(componentSettings, nameof(componentSettings)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the Component Settings.
        /// </summary>
        /// <param name="componentSettings">
        /// Required. The component settings to update.
        /// 
        /// The component settings' `name` field is used to identify the component
        /// settings to be updated. Formats:
        /// * `organizations/{organization}/components/{component}/settings`
        /// * `folders/{folder}/components/{component}/settings`
        /// * `projects/{project}/components/{component}/settings`
        /// * `projects/{project}/locations/{location}/clusters/{cluster}/components/{component}/settings`
        /// * `projects/{project}/regions/{region}/clusters/{cluster}/components/{component}/settings`
        /// * `projects/{project}/zones/{zone}/clusters/{cluster}/components/{component}/settings`
        /// </param>
        /// <param name="updateMask">
        /// The list of fields to be updated on the component settings resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComponentSettings> UpdateComponentSettingsAsync(ComponentSettings componentSettings, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateComponentSettingsAsync(componentSettings, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Reset the organization, folder or project's component settings and return
        /// the settings to the default. Settings are present at the
        /// organization, folder and project levels. Using Reset for a folder or
        /// project will remove the override that was set and result in the
        /// organization-level settings being used.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void ResetComponentSettings(ResetComponentSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reset the organization, folder or project's component settings and return
        /// the settings to the default. Settings are present at the
        /// organization, folder and project levels. Using Reset for a folder or
        /// project will remove the override that was set and result in the
        /// organization-level settings being used.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ResetComponentSettingsAsync(ResetComponentSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Reset the organization, folder or project's component settings and return
        /// the settings to the default. Settings are present at the
        /// organization, folder and project levels. Using Reset for a folder or
        /// project will remove the override that was set and result in the
        /// organization-level settings being used.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ResetComponentSettingsAsync(ResetComponentSettingsRequest request, st::CancellationToken cancellationToken) =>
            ResetComponentSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the Effective Component Settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ComponentSettings CalculateEffectiveComponentSettings(CalculateEffectiveComponentSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the Effective Component Settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComponentSettings> CalculateEffectiveComponentSettingsAsync(CalculateEffectiveComponentSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the Effective Component Settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComponentSettings> CalculateEffectiveComponentSettingsAsync(CalculateEffectiveComponentSettingsRequest request, st::CancellationToken cancellationToken) =>
            CalculateEffectiveComponentSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the Effective Component Settings.
        /// </summary>
        /// <param name="name">
        /// Required. The effective component settings to retrieve.
        /// 
        /// Formats:
        /// * `organizations/{organization}/components/{component}/settings`
        /// * `folders/{folder}/components/{component}/settings`
        /// * `projects/{project}/components/{component}/settings`
        /// * `projects/{project}/locations/{location}/clusters/{cluster}/components/{component}/settings`
        /// * `projects/{project}/regions/{region}/clusters/{cluster}/components/{component}/settings`
        /// * `projects/{project}/zones/{zone}/clusters/{cluster}/components/{component}/settings`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ComponentSettings CalculateEffectiveComponentSettings(string name, gaxgrpc::CallSettings callSettings = null) =>
            CalculateEffectiveComponentSettings(new CalculateEffectiveComponentSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the Effective Component Settings.
        /// </summary>
        /// <param name="name">
        /// Required. The effective component settings to retrieve.
        /// 
        /// Formats:
        /// * `organizations/{organization}/components/{component}/settings`
        /// * `folders/{folder}/components/{component}/settings`
        /// * `projects/{project}/components/{component}/settings`
        /// * `projects/{project}/locations/{location}/clusters/{cluster}/components/{component}/settings`
        /// * `projects/{project}/regions/{region}/clusters/{cluster}/components/{component}/settings`
        /// * `projects/{project}/zones/{zone}/clusters/{cluster}/components/{component}/settings`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComponentSettings> CalculateEffectiveComponentSettingsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            CalculateEffectiveComponentSettingsAsync(new CalculateEffectiveComponentSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the Effective Component Settings.
        /// </summary>
        /// <param name="name">
        /// Required. The effective component settings to retrieve.
        /// 
        /// Formats:
        /// * `organizations/{organization}/components/{component}/settings`
        /// * `folders/{folder}/components/{component}/settings`
        /// * `projects/{project}/components/{component}/settings`
        /// * `projects/{project}/locations/{location}/clusters/{cluster}/components/{component}/settings`
        /// * `projects/{project}/regions/{region}/clusters/{cluster}/components/{component}/settings`
        /// * `projects/{project}/zones/{zone}/clusters/{cluster}/components/{component}/settings`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComponentSettings> CalculateEffectiveComponentSettingsAsync(string name, st::CancellationToken cancellationToken) =>
            CalculateEffectiveComponentSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the Effective Component Settings.
        /// </summary>
        /// <param name="name">
        /// Required. The effective component settings to retrieve.
        /// 
        /// Formats:
        /// * `organizations/{organization}/components/{component}/settings`
        /// * `folders/{folder}/components/{component}/settings`
        /// * `projects/{project}/components/{component}/settings`
        /// * `projects/{project}/locations/{location}/clusters/{cluster}/components/{component}/settings`
        /// * `projects/{project}/regions/{region}/clusters/{cluster}/components/{component}/settings`
        /// * `projects/{project}/zones/{zone}/clusters/{cluster}/components/{component}/settings`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ComponentSettings CalculateEffectiveComponentSettings(ComponentSettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            CalculateEffectiveComponentSettings(new CalculateEffectiveComponentSettingsRequest
            {
                ComponentSettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the Effective Component Settings.
        /// </summary>
        /// <param name="name">
        /// Required. The effective component settings to retrieve.
        /// 
        /// Formats:
        /// * `organizations/{organization}/components/{component}/settings`
        /// * `folders/{folder}/components/{component}/settings`
        /// * `projects/{project}/components/{component}/settings`
        /// * `projects/{project}/locations/{location}/clusters/{cluster}/components/{component}/settings`
        /// * `projects/{project}/regions/{region}/clusters/{cluster}/components/{component}/settings`
        /// * `projects/{project}/zones/{zone}/clusters/{cluster}/components/{component}/settings`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComponentSettings> CalculateEffectiveComponentSettingsAsync(ComponentSettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            CalculateEffectiveComponentSettingsAsync(new CalculateEffectiveComponentSettingsRequest
            {
                ComponentSettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the Effective Component Settings.
        /// </summary>
        /// <param name="name">
        /// Required. The effective component settings to retrieve.
        /// 
        /// Formats:
        /// * `organizations/{organization}/components/{component}/settings`
        /// * `folders/{folder}/components/{component}/settings`
        /// * `projects/{project}/components/{component}/settings`
        /// * `projects/{project}/locations/{location}/clusters/{cluster}/components/{component}/settings`
        /// * `projects/{project}/regions/{region}/clusters/{cluster}/components/{component}/settings`
        /// * `projects/{project}/zones/{zone}/clusters/{cluster}/components/{component}/settings`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ComponentSettings> CalculateEffectiveComponentSettingsAsync(ComponentSettingsName name, st::CancellationToken cancellationToken) =>
            CalculateEffectiveComponentSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves an unordered list of available detectors.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Detector"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDetectorsResponse, Detector> ListDetectors(ListDetectorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an unordered list of available detectors.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Detector"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDetectorsResponse, Detector> ListDetectorsAsync(ListDetectorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an unordered list of available detectors.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of detectors.
        /// Format:
        /// * `organizations/{organization}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Detector"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDetectorsResponse, Detector> ListDetectors(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDetectorsRequest request = new ListDetectorsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDetectors(request, callSettings);
        }

        /// <summary>
        /// Retrieves an unordered list of available detectors.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of detectors.
        /// Format:
        /// * `organizations/{organization}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Detector"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDetectorsResponse, Detector> ListDetectorsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDetectorsRequest request = new ListDetectorsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDetectorsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves an unordered list of available detectors.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of detectors.
        /// Format:
        /// * `organizations/{organization}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Detector"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDetectorsResponse, Detector> ListDetectors(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDetectorsRequest request = new ListDetectorsRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDetectors(request, callSettings);
        }

        /// <summary>
        /// Retrieves an unordered list of available detectors.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of detectors.
        /// Format:
        /// * `organizations/{organization}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Detector"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDetectorsResponse, Detector> ListDetectorsAsync(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDetectorsRequest request = new ListDetectorsRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDetectorsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves an unordered list of available SCC components.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListComponentsResponse, string> ListComponents(ListComponentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an unordered list of available SCC components.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListComponentsResponse, string> ListComponentsAsync(ListComponentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves an unordered list of available SCC components.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of components.
        /// Format:
        /// * `organizations/{organization}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListComponentsResponse, string> ListComponents(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListComponentsRequest request = new ListComponentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListComponents(request, callSettings);
        }

        /// <summary>
        /// Retrieves an unordered list of available SCC components.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of components.
        /// Format:
        /// * `organizations/{organization}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListComponentsResponse, string> ListComponentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListComponentsRequest request = new ListComponentsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListComponentsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves an unordered list of available SCC components.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of components.
        /// Format:
        /// * `organizations/{organization}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListComponentsResponse, string> ListComponents(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListComponentsRequest request = new ListComponentsRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListComponents(request, callSettings);
        }

        /// <summary>
        /// Retrieves an unordered list of available SCC components.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of components.
        /// Format:
        /// * `organizations/{organization}`
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListComponentsResponse, string> ListComponentsAsync(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListComponentsRequest request = new ListComponentsRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListComponentsAsync(request, callSettings);
        }
    }

    /// <summary>SecurityCenterSettingsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// ## API Overview
    /// 
    /// The SecurityCenterSettingsService is a sub-api of
    /// `securitycenter.googleapis.com`. The service provides methods to manage
    /// Security Center Settings, and Component Settings for GCP organizations,
    /// folders, projects, and clusters.
    /// </remarks>
    public sealed partial class SecurityCenterSettingsServiceClientImpl : SecurityCenterSettingsServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetServiceAccountRequest, ServiceAccount> _callGetServiceAccount;

        private readonly gaxgrpc::ApiCall<GetSettingsRequest, Settings> _callGetSettings;

        private readonly gaxgrpc::ApiCall<UpdateSettingsRequest, Settings> _callUpdateSettings;

        private readonly gaxgrpc::ApiCall<ResetSettingsRequest, wkt::Empty> _callResetSettings;

        private readonly gaxgrpc::ApiCall<BatchGetSettingsRequest, BatchGetSettingsResponse> _callBatchGetSettings;

        private readonly gaxgrpc::ApiCall<CalculateEffectiveSettingsRequest, Settings> _callCalculateEffectiveSettings;

        private readonly gaxgrpc::ApiCall<BatchCalculateEffectiveSettingsRequest, BatchCalculateEffectiveSettingsResponse> _callBatchCalculateEffectiveSettings;

        private readonly gaxgrpc::ApiCall<GetComponentSettingsRequest, ComponentSettings> _callGetComponentSettings;

        private readonly gaxgrpc::ApiCall<UpdateComponentSettingsRequest, ComponentSettings> _callUpdateComponentSettings;

        private readonly gaxgrpc::ApiCall<ResetComponentSettingsRequest, wkt::Empty> _callResetComponentSettings;

        private readonly gaxgrpc::ApiCall<CalculateEffectiveComponentSettingsRequest, ComponentSettings> _callCalculateEffectiveComponentSettings;

        private readonly gaxgrpc::ApiCall<ListDetectorsRequest, ListDetectorsResponse> _callListDetectors;

        private readonly gaxgrpc::ApiCall<ListComponentsRequest, ListComponentsResponse> _callListComponents;

        /// <summary>
        /// Constructs a client wrapper for the SecurityCenterSettingsService service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="SecurityCenterSettingsServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SecurityCenterSettingsServiceClientImpl(SecurityCenterSettingsService.SecurityCenterSettingsServiceClient grpcClient, SecurityCenterSettingsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SecurityCenterSettingsServiceSettings effectiveSettings = settings ?? SecurityCenterSettingsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGetServiceAccount = clientHelper.BuildApiCall<GetServiceAccountRequest, ServiceAccount>("GetServiceAccount", grpcClient.GetServiceAccountAsync, grpcClient.GetServiceAccount, effectiveSettings.GetServiceAccountSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetServiceAccount);
            Modify_GetServiceAccountApiCall(ref _callGetServiceAccount);
            _callGetSettings = clientHelper.BuildApiCall<GetSettingsRequest, Settings>("GetSettings", grpcClient.GetSettingsAsync, grpcClient.GetSettings, effectiveSettings.GetSettingsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSettings);
            Modify_GetSettingsApiCall(ref _callGetSettings);
            _callUpdateSettings = clientHelper.BuildApiCall<UpdateSettingsRequest, Settings>("UpdateSettings", grpcClient.UpdateSettingsAsync, grpcClient.UpdateSettings, effectiveSettings.UpdateSettingsSettings).WithGoogleRequestParam("settings.name", request => request.Settings?.Name);
            Modify_ApiCall(ref _callUpdateSettings);
            Modify_UpdateSettingsApiCall(ref _callUpdateSettings);
            _callResetSettings = clientHelper.BuildApiCall<ResetSettingsRequest, wkt::Empty>("ResetSettings", grpcClient.ResetSettingsAsync, grpcClient.ResetSettings, effectiveSettings.ResetSettingsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callResetSettings);
            Modify_ResetSettingsApiCall(ref _callResetSettings);
            _callBatchGetSettings = clientHelper.BuildApiCall<BatchGetSettingsRequest, BatchGetSettingsResponse>("BatchGetSettings", grpcClient.BatchGetSettingsAsync, grpcClient.BatchGetSettings, effectiveSettings.BatchGetSettingsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchGetSettings);
            Modify_BatchGetSettingsApiCall(ref _callBatchGetSettings);
            _callCalculateEffectiveSettings = clientHelper.BuildApiCall<CalculateEffectiveSettingsRequest, Settings>("CalculateEffectiveSettings", grpcClient.CalculateEffectiveSettingsAsync, grpcClient.CalculateEffectiveSettings, effectiveSettings.CalculateEffectiveSettingsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCalculateEffectiveSettings);
            Modify_CalculateEffectiveSettingsApiCall(ref _callCalculateEffectiveSettings);
            _callBatchCalculateEffectiveSettings = clientHelper.BuildApiCall<BatchCalculateEffectiveSettingsRequest, BatchCalculateEffectiveSettingsResponse>("BatchCalculateEffectiveSettings", grpcClient.BatchCalculateEffectiveSettingsAsync, grpcClient.BatchCalculateEffectiveSettings, effectiveSettings.BatchCalculateEffectiveSettingsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchCalculateEffectiveSettings);
            Modify_BatchCalculateEffectiveSettingsApiCall(ref _callBatchCalculateEffectiveSettings);
            _callGetComponentSettings = clientHelper.BuildApiCall<GetComponentSettingsRequest, ComponentSettings>("GetComponentSettings", grpcClient.GetComponentSettingsAsync, grpcClient.GetComponentSettings, effectiveSettings.GetComponentSettingsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetComponentSettings);
            Modify_GetComponentSettingsApiCall(ref _callGetComponentSettings);
            _callUpdateComponentSettings = clientHelper.BuildApiCall<UpdateComponentSettingsRequest, ComponentSettings>("UpdateComponentSettings", grpcClient.UpdateComponentSettingsAsync, grpcClient.UpdateComponentSettings, effectiveSettings.UpdateComponentSettingsSettings).WithGoogleRequestParam("component_settings.name", request => request.ComponentSettings?.Name);
            Modify_ApiCall(ref _callUpdateComponentSettings);
            Modify_UpdateComponentSettingsApiCall(ref _callUpdateComponentSettings);
            _callResetComponentSettings = clientHelper.BuildApiCall<ResetComponentSettingsRequest, wkt::Empty>("ResetComponentSettings", grpcClient.ResetComponentSettingsAsync, grpcClient.ResetComponentSettings, effectiveSettings.ResetComponentSettingsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callResetComponentSettings);
            Modify_ResetComponentSettingsApiCall(ref _callResetComponentSettings);
            _callCalculateEffectiveComponentSettings = clientHelper.BuildApiCall<CalculateEffectiveComponentSettingsRequest, ComponentSettings>("CalculateEffectiveComponentSettings", grpcClient.CalculateEffectiveComponentSettingsAsync, grpcClient.CalculateEffectiveComponentSettings, effectiveSettings.CalculateEffectiveComponentSettingsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCalculateEffectiveComponentSettings);
            Modify_CalculateEffectiveComponentSettingsApiCall(ref _callCalculateEffectiveComponentSettings);
            _callListDetectors = clientHelper.BuildApiCall<ListDetectorsRequest, ListDetectorsResponse>("ListDetectors", grpcClient.ListDetectorsAsync, grpcClient.ListDetectors, effectiveSettings.ListDetectorsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDetectors);
            Modify_ListDetectorsApiCall(ref _callListDetectors);
            _callListComponents = clientHelper.BuildApiCall<ListComponentsRequest, ListComponentsResponse>("ListComponents", grpcClient.ListComponentsAsync, grpcClient.ListComponents, effectiveSettings.ListComponentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListComponents);
            Modify_ListComponentsApiCall(ref _callListComponents);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetServiceAccountApiCall(ref gaxgrpc::ApiCall<GetServiceAccountRequest, ServiceAccount> call);

        partial void Modify_GetSettingsApiCall(ref gaxgrpc::ApiCall<GetSettingsRequest, Settings> call);

        partial void Modify_UpdateSettingsApiCall(ref gaxgrpc::ApiCall<UpdateSettingsRequest, Settings> call);

        partial void Modify_ResetSettingsApiCall(ref gaxgrpc::ApiCall<ResetSettingsRequest, wkt::Empty> call);

        partial void Modify_BatchGetSettingsApiCall(ref gaxgrpc::ApiCall<BatchGetSettingsRequest, BatchGetSettingsResponse> call);

        partial void Modify_CalculateEffectiveSettingsApiCall(ref gaxgrpc::ApiCall<CalculateEffectiveSettingsRequest, Settings> call);

        partial void Modify_BatchCalculateEffectiveSettingsApiCall(ref gaxgrpc::ApiCall<BatchCalculateEffectiveSettingsRequest, BatchCalculateEffectiveSettingsResponse> call);

        partial void Modify_GetComponentSettingsApiCall(ref gaxgrpc::ApiCall<GetComponentSettingsRequest, ComponentSettings> call);

        partial void Modify_UpdateComponentSettingsApiCall(ref gaxgrpc::ApiCall<UpdateComponentSettingsRequest, ComponentSettings> call);

        partial void Modify_ResetComponentSettingsApiCall(ref gaxgrpc::ApiCall<ResetComponentSettingsRequest, wkt::Empty> call);

        partial void Modify_CalculateEffectiveComponentSettingsApiCall(ref gaxgrpc::ApiCall<CalculateEffectiveComponentSettingsRequest, ComponentSettings> call);

        partial void Modify_ListDetectorsApiCall(ref gaxgrpc::ApiCall<ListDetectorsRequest, ListDetectorsResponse> call);

        partial void Modify_ListComponentsApiCall(ref gaxgrpc::ApiCall<ListComponentsRequest, ListComponentsResponse> call);

        partial void OnConstruction(SecurityCenterSettingsService.SecurityCenterSettingsServiceClient grpcClient, SecurityCenterSettingsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SecurityCenterSettingsService client</summary>
        public override SecurityCenterSettingsService.SecurityCenterSettingsServiceClient GrpcClient { get; }

        partial void Modify_GetServiceAccountRequest(ref GetServiceAccountRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSettingsRequest(ref GetSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSettingsRequest(ref UpdateSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResetSettingsRequest(ref ResetSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchGetSettingsRequest(ref BatchGetSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CalculateEffectiveSettingsRequest(ref CalculateEffectiveSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchCalculateEffectiveSettingsRequest(ref BatchCalculateEffectiveSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetComponentSettingsRequest(ref GetComponentSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateComponentSettingsRequest(ref UpdateComponentSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResetComponentSettingsRequest(ref ResetComponentSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CalculateEffectiveComponentSettingsRequest(ref CalculateEffectiveComponentSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDetectorsRequest(ref ListDetectorsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListComponentsRequest(ref ListComponentsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves the organizations service account, if it exists, otherwise it
        /// creates the organization service account. This API is idempotent and
        /// will only create a service account once. On subsequent calls it will
        /// return the previously created service account.  SHA, SCC and CTD Infra
        /// Automation will use this SA.  This SA will not have any permissions when
        /// created.  The UI will provision this via IAM or the user will using
        /// their own internal process. This API only creates SAs on the organization.
        /// Folders are not supported and projects will use per-project SAs associated
        /// with APIs enabled on a project. This API will be called by the UX
        /// onboarding workflow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ServiceAccount GetServiceAccount(GetServiceAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceAccountRequest(ref request, ref callSettings);
            return _callGetServiceAccount.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves the organizations service account, if it exists, otherwise it
        /// creates the organization service account. This API is idempotent and
        /// will only create a service account once. On subsequent calls it will
        /// return the previously created service account.  SHA, SCC and CTD Infra
        /// Automation will use this SA.  This SA will not have any permissions when
        /// created.  The UI will provision this via IAM or the user will using
        /// their own internal process. This API only creates SAs on the organization.
        /// Folders are not supported and projects will use per-project SAs associated
        /// with APIs enabled on a project. This API will be called by the UX
        /// onboarding workflow.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ServiceAccount> GetServiceAccountAsync(GetServiceAccountRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceAccountRequest(ref request, ref callSettings);
            return _callGetServiceAccount.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the Settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Settings GetSettings(GetSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSettingsRequest(ref request, ref callSettings);
            return _callGetSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the Settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Settings> GetSettingsAsync(GetSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSettingsRequest(ref request, ref callSettings);
            return _callGetSettings.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the Settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Settings UpdateSettings(UpdateSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSettingsRequest(ref request, ref callSettings);
            return _callUpdateSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the Settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Settings> UpdateSettingsAsync(UpdateSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSettingsRequest(ref request, ref callSettings);
            return _callUpdateSettings.Async(request, callSettings);
        }

        /// <summary>
        /// Reset the organization, folder or project's settings and return
        /// the settings of just that resource to the default.
        /// 
        /// Settings are present at the organization, folder, project, and cluster
        /// levels. Using Reset on a sub-organization level will remove that resource's
        /// override and result in the parent's settings being used (eg: if Reset on a
        /// cluster, project settings will be used).
        /// 
        /// Using Reset on organization will remove the override that was set and
        /// result in default settings being used.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void ResetSettings(ResetSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResetSettingsRequest(ref request, ref callSettings);
            _callResetSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Reset the organization, folder or project's settings and return
        /// the settings of just that resource to the default.
        /// 
        /// Settings are present at the organization, folder, project, and cluster
        /// levels. Using Reset on a sub-organization level will remove that resource's
        /// override and result in the parent's settings being used (eg: if Reset on a
        /// cluster, project settings will be used).
        /// 
        /// Using Reset on organization will remove the override that was set and
        /// result in default settings being used.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task ResetSettingsAsync(ResetSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResetSettingsRequest(ref request, ref callSettings);
            return _callResetSettings.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a list of settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchGetSettingsResponse BatchGetSettings(BatchGetSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchGetSettingsRequest(ref request, ref callSettings);
            return _callBatchGetSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a list of settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchGetSettingsResponse> BatchGetSettingsAsync(BatchGetSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchGetSettingsRequest(ref request, ref callSettings);
            return _callBatchGetSettings.Async(request, callSettings);
        }

        /// <summary>
        /// CalculateEffectiveSettings looks up all of the Security Center
        /// Settings resources in the GCP resource hierarchy, and calculates the
        /// effective settings on that resource by applying the following rules:
        /// * Settings provided closer to the target resource take precedence over
        /// those further away (e.g. folder will override organization level
        /// settings).
        /// * Product defaults can be overridden at org, folder, project, and cluster
        /// levels.
        /// * Detectors will be filtered out if they belong to a billing tier the
        /// customer
        /// has not configured.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Settings CalculateEffectiveSettings(CalculateEffectiveSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CalculateEffectiveSettingsRequest(ref request, ref callSettings);
            return _callCalculateEffectiveSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// CalculateEffectiveSettings looks up all of the Security Center
        /// Settings resources in the GCP resource hierarchy, and calculates the
        /// effective settings on that resource by applying the following rules:
        /// * Settings provided closer to the target resource take precedence over
        /// those further away (e.g. folder will override organization level
        /// settings).
        /// * Product defaults can be overridden at org, folder, project, and cluster
        /// levels.
        /// * Detectors will be filtered out if they belong to a billing tier the
        /// customer
        /// has not configured.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Settings> CalculateEffectiveSettingsAsync(CalculateEffectiveSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CalculateEffectiveSettingsRequest(ref request, ref callSettings);
            return _callCalculateEffectiveSettings.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a list of effective settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BatchCalculateEffectiveSettingsResponse BatchCalculateEffectiveSettings(BatchCalculateEffectiveSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCalculateEffectiveSettingsRequest(ref request, ref callSettings);
            return _callBatchCalculateEffectiveSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a list of effective settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BatchCalculateEffectiveSettingsResponse> BatchCalculateEffectiveSettingsAsync(BatchCalculateEffectiveSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchCalculateEffectiveSettingsRequest(ref request, ref callSettings);
            return _callBatchCalculateEffectiveSettings.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the Component Settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ComponentSettings GetComponentSettings(GetComponentSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetComponentSettingsRequest(ref request, ref callSettings);
            return _callGetComponentSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the Component Settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ComponentSettings> GetComponentSettingsAsync(GetComponentSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetComponentSettingsRequest(ref request, ref callSettings);
            return _callGetComponentSettings.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the Component Settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ComponentSettings UpdateComponentSettings(UpdateComponentSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateComponentSettingsRequest(ref request, ref callSettings);
            return _callUpdateComponentSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the Component Settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ComponentSettings> UpdateComponentSettingsAsync(UpdateComponentSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateComponentSettingsRequest(ref request, ref callSettings);
            return _callUpdateComponentSettings.Async(request, callSettings);
        }

        /// <summary>
        /// Reset the organization, folder or project's component settings and return
        /// the settings to the default. Settings are present at the
        /// organization, folder and project levels. Using Reset for a folder or
        /// project will remove the override that was set and result in the
        /// organization-level settings being used.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void ResetComponentSettings(ResetComponentSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResetComponentSettingsRequest(ref request, ref callSettings);
            _callResetComponentSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Reset the organization, folder or project's component settings and return
        /// the settings to the default. Settings are present at the
        /// organization, folder and project levels. Using Reset for a folder or
        /// project will remove the override that was set and result in the
        /// organization-level settings being used.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task ResetComponentSettingsAsync(ResetComponentSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResetComponentSettingsRequest(ref request, ref callSettings);
            return _callResetComponentSettings.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the Effective Component Settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ComponentSettings CalculateEffectiveComponentSettings(CalculateEffectiveComponentSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CalculateEffectiveComponentSettingsRequest(ref request, ref callSettings);
            return _callCalculateEffectiveComponentSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the Effective Component Settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ComponentSettings> CalculateEffectiveComponentSettingsAsync(CalculateEffectiveComponentSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CalculateEffectiveComponentSettingsRequest(ref request, ref callSettings);
            return _callCalculateEffectiveComponentSettings.Async(request, callSettings);
        }

        /// <summary>
        /// Retrieves an unordered list of available detectors.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Detector"/> resources.</returns>
        public override gax::PagedEnumerable<ListDetectorsResponse, Detector> ListDetectors(ListDetectorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDetectorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDetectorsRequest, ListDetectorsResponse, Detector>(_callListDetectors, request, callSettings);
        }

        /// <summary>
        /// Retrieves an unordered list of available detectors.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Detector"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDetectorsResponse, Detector> ListDetectorsAsync(ListDetectorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDetectorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDetectorsRequest, ListDetectorsResponse, Detector>(_callListDetectors, request, callSettings);
        }

        /// <summary>
        /// Retrieves an unordered list of available SCC components.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public override gax::PagedEnumerable<ListComponentsResponse, string> ListComponents(ListComponentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListComponentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListComponentsRequest, ListComponentsResponse, string>(_callListComponents, request, callSettings);
        }

        /// <summary>
        /// Retrieves an unordered list of available SCC components.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListComponentsResponse, string> ListComponentsAsync(ListComponentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListComponentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListComponentsRequest, ListComponentsResponse, string>(_callListComponents, request, callSettings);
        }
    }

    public partial class ListDetectorsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListComponentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDetectorsResponse : gaxgrpc::IPageResponse<Detector>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Detector> GetEnumerator() => Detectors.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListComponentsResponse : gaxgrpc::IPageResponse<string>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<string> GetEnumerator() => Components.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
