// Copyright 2024 Google LLC
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
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using lro = Google.LongRunning;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Cloud.Compute.V1
{
    /// <summary>Settings for <see cref="TargetHttpsProxiesClient"/> instances.</summary>
    public sealed partial class TargetHttpsProxiesSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="TargetHttpsProxiesSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="TargetHttpsProxiesSettings"/>.</returns>
        public static TargetHttpsProxiesSettings GetDefault() => new TargetHttpsProxiesSettings();

        /// <summary>Constructs a new <see cref="TargetHttpsProxiesSettings"/> object with default settings.</summary>
        public TargetHttpsProxiesSettings()
        {
        }

        private TargetHttpsProxiesSettings(TargetHttpsProxiesSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            AggregatedListSettings = existing.AggregatedListSettings;
            DeleteSettings = existing.DeleteSettings;
            DeleteOperationsSettings = existing.DeleteOperationsSettings.Clone();
            GetSettings = existing.GetSettings;
            InsertSettings = existing.InsertSettings;
            InsertOperationsSettings = existing.InsertOperationsSettings.Clone();
            ListSettings = existing.ListSettings;
            PatchSettings = existing.PatchSettings;
            PatchOperationsSettings = existing.PatchOperationsSettings.Clone();
            SetCertificateMapSettings = existing.SetCertificateMapSettings;
            SetCertificateMapOperationsSettings = existing.SetCertificateMapOperationsSettings.Clone();
            SetQuicOverrideSettings = existing.SetQuicOverrideSettings;
            SetQuicOverrideOperationsSettings = existing.SetQuicOverrideOperationsSettings.Clone();
            SetSslCertificatesSettings = existing.SetSslCertificatesSettings;
            SetSslCertificatesOperationsSettings = existing.SetSslCertificatesOperationsSettings.Clone();
            SetSslPolicySettings = existing.SetSslPolicySettings;
            SetSslPolicyOperationsSettings = existing.SetSslPolicyOperationsSettings.Clone();
            SetUrlMapSettings = existing.SetUrlMapSettings;
            SetUrlMapOperationsSettings = existing.SetUrlMapOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(TargetHttpsProxiesSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TargetHttpsProxiesClient.AggregatedList</c> and <c>TargetHttpsProxiesClient.AggregatedListAsync</c>.
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
        public gaxgrpc::CallSettings AggregatedListSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TargetHttpsProxiesClient.Delete</c> and <c>TargetHttpsProxiesClient.DeleteAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TargetHttpsProxiesClient.Delete</c> and
        /// <c>TargetHttpsProxiesClient.DeleteAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TargetHttpsProxiesClient.Get</c> and <c>TargetHttpsProxiesClient.GetAsync</c>.
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
        public gaxgrpc::CallSettings GetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TargetHttpsProxiesClient.Insert</c> and <c>TargetHttpsProxiesClient.InsertAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InsertSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TargetHttpsProxiesClient.Insert</c> and
        /// <c>TargetHttpsProxiesClient.InsertAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings InsertOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TargetHttpsProxiesClient.List</c> and <c>TargetHttpsProxiesClient.ListAsync</c>.
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
        public gaxgrpc::CallSettings ListSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TargetHttpsProxiesClient.Patch</c> and <c>TargetHttpsProxiesClient.PatchAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PatchSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TargetHttpsProxiesClient.Patch</c> and
        /// <c>TargetHttpsProxiesClient.PatchAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings PatchOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TargetHttpsProxiesClient.SetCertificateMap</c> and <c>TargetHttpsProxiesClient.SetCertificateMapAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetCertificateMapSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TargetHttpsProxiesClient.SetCertificateMap</c> and
        /// <c>TargetHttpsProxiesClient.SetCertificateMapAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings SetCertificateMapOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TargetHttpsProxiesClient.SetQuicOverride</c> and <c>TargetHttpsProxiesClient.SetQuicOverrideAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetQuicOverrideSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TargetHttpsProxiesClient.SetQuicOverride</c> and
        /// <c>TargetHttpsProxiesClient.SetQuicOverrideAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings SetQuicOverrideOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TargetHttpsProxiesClient.SetSslCertificates</c> and <c>TargetHttpsProxiesClient.SetSslCertificatesAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetSslCertificatesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TargetHttpsProxiesClient.SetSslCertificates</c> and
        /// <c>TargetHttpsProxiesClient.SetSslCertificatesAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings SetSslCertificatesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TargetHttpsProxiesClient.SetSslPolicy</c> and <c>TargetHttpsProxiesClient.SetSslPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetSslPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TargetHttpsProxiesClient.SetSslPolicy</c> and
        /// <c>TargetHttpsProxiesClient.SetSslPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings SetSslPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TargetHttpsProxiesClient.SetUrlMap</c> and <c>TargetHttpsProxiesClient.SetUrlMapAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetUrlMapSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TargetHttpsProxiesClient.SetUrlMap</c> and
        /// <c>TargetHttpsProxiesClient.SetUrlMapAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings SetUrlMapOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="TargetHttpsProxiesSettings"/> object.</returns>
        public TargetHttpsProxiesSettings Clone() => new TargetHttpsProxiesSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="TargetHttpsProxiesClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class TargetHttpsProxiesClientBuilder : gaxgrpc::ClientBuilderBase<TargetHttpsProxiesClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public TargetHttpsProxiesSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public TargetHttpsProxiesClientBuilder() : base(TargetHttpsProxiesClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref TargetHttpsProxiesClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<TargetHttpsProxiesClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override TargetHttpsProxiesClient Build()
        {
            TargetHttpsProxiesClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<TargetHttpsProxiesClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<TargetHttpsProxiesClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private TargetHttpsProxiesClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return TargetHttpsProxiesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<TargetHttpsProxiesClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return TargetHttpsProxiesClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => TargetHttpsProxiesClient.ChannelPool;
    }

    /// <summary>TargetHttpsProxies client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The TargetHttpsProxies API.
    /// </remarks>
    public abstract partial class TargetHttpsProxiesClient
    {
        /// <summary>
        /// The default endpoint for the TargetHttpsProxies service, which is a host of "compute.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default TargetHttpsProxies scopes.</summary>
        /// <remarks>
        /// The default TargetHttpsProxies scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/compute</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/compute",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(TargetHttpsProxies.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="TargetHttpsProxiesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TargetHttpsProxiesClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="TargetHttpsProxiesClient"/>.</returns>
        public static stt::Task<TargetHttpsProxiesClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new TargetHttpsProxiesClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="TargetHttpsProxiesClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="TargetHttpsProxiesClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="TargetHttpsProxiesClient"/>.</returns>
        public static TargetHttpsProxiesClient Create() => new TargetHttpsProxiesClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="TargetHttpsProxiesClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="TargetHttpsProxiesSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="TargetHttpsProxiesClient"/>.</returns>
        internal static TargetHttpsProxiesClient Create(grpccore::CallInvoker callInvoker, TargetHttpsProxiesSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            TargetHttpsProxies.TargetHttpsProxiesClient grpcClient = new TargetHttpsProxies.TargetHttpsProxiesClient(callInvoker);
            return new TargetHttpsProxiesClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC TargetHttpsProxies client</summary>
        public virtual TargetHttpsProxies.TargetHttpsProxiesClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of all TargetHttpsProxy resources, regional and global, available to the specified project. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.</returns>
        public virtual gax::PagedEnumerable<TargetHttpsProxyAggregatedList, scg::KeyValuePair<string, TargetHttpsProxiesScopedList>> AggregatedList(AggregatedListTargetHttpsProxiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of all TargetHttpsProxy resources, regional and global, available to the specified project. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<TargetHttpsProxyAggregatedList, scg::KeyValuePair<string, TargetHttpsProxiesScopedList>> AggregatedListAsync(AggregatedListTargetHttpsProxiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of all TargetHttpsProxy resources, regional and global, available to the specified project. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="project">
        /// Name of the project scoping this request.
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
        /// <returns>A pageable sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.</returns>
        public virtual gax::PagedEnumerable<TargetHttpsProxyAggregatedList, scg::KeyValuePair<string, TargetHttpsProxiesScopedList>> AggregatedList(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            AggregatedListTargetHttpsProxiesRequest request = new AggregatedListTargetHttpsProxiesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return AggregatedList(request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of all TargetHttpsProxy resources, regional and global, available to the specified project. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="project">
        /// Name of the project scoping this request.
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
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<TargetHttpsProxyAggregatedList, scg::KeyValuePair<string, TargetHttpsProxiesScopedList>> AggregatedListAsync(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            AggregatedListTargetHttpsProxiesRequest request = new AggregatedListTargetHttpsProxiesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return AggregatedListAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified TargetHttpsProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Delete(DeleteTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified TargetHttpsProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified TargetHttpsProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteTargetHttpsProxyRequest request, st::CancellationToken cancellationToken) =>
            DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>Delete</c>.</summary>
        public virtual lro::OperationsClient DeleteOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Delete</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceDelete(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Delete</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceDeleteAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteOperationsClient, callSettings);

        /// <summary>
        /// Deletes the specified TargetHttpsProxy resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Delete(string project, string targetHttpsProxy, gaxgrpc::CallSettings callSettings = null) =>
            Delete(new DeleteTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetHttpsProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpsProxy, nameof(targetHttpsProxy)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified TargetHttpsProxy resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(string project, string targetHttpsProxy, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAsync(new DeleteTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetHttpsProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpsProxy, nameof(targetHttpsProxy)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified TargetHttpsProxy resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(string project, string targetHttpsProxy, st::CancellationToken cancellationToken) =>
            DeleteAsync(project, targetHttpsProxy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified TargetHttpsProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TargetHttpsProxy Get(GetTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified TargetHttpsProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetHttpsProxy> GetAsync(GetTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified TargetHttpsProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetHttpsProxy> GetAsync(GetTargetHttpsProxyRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified TargetHttpsProxy resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TargetHttpsProxy Get(string project, string targetHttpsProxy, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetHttpsProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpsProxy, nameof(targetHttpsProxy)),
            }, callSettings);

        /// <summary>
        /// Returns the specified TargetHttpsProxy resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource to return.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetHttpsProxy> GetAsync(string project, string targetHttpsProxy, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetHttpsProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpsProxy, nameof(targetHttpsProxy)),
            }, callSettings);

        /// <summary>
        /// Returns the specified TargetHttpsProxy resource.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource to return.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TargetHttpsProxy> GetAsync(string project, string targetHttpsProxy, st::CancellationToken cancellationToken) =>
            GetAsync(project, targetHttpsProxy, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a TargetHttpsProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Insert(InsertTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a TargetHttpsProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a TargetHttpsProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertTargetHttpsProxyRequest request, st::CancellationToken cancellationToken) =>
            InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>Insert</c>.</summary>
        public virtual lro::OperationsClient InsertOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Insert</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceInsert(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), InsertOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Insert</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceInsertAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), InsertOperationsClient, callSettings);

        /// <summary>
        /// Creates a TargetHttpsProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Insert(string project, TargetHttpsProxy targetHttpsProxyResource, gaxgrpc::CallSettings callSettings = null) =>
            Insert(new InsertTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetHttpsProxyResource = gax::GaxPreconditions.CheckNotNull(targetHttpsProxyResource, nameof(targetHttpsProxyResource)),
            }, callSettings);

        /// <summary>
        /// Creates a TargetHttpsProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(string project, TargetHttpsProxy targetHttpsProxyResource, gaxgrpc::CallSettings callSettings = null) =>
            InsertAsync(new InsertTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetHttpsProxyResource = gax::GaxPreconditions.CheckNotNull(targetHttpsProxyResource, nameof(targetHttpsProxyResource)),
            }, callSettings);

        /// <summary>
        /// Creates a TargetHttpsProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> InsertAsync(string project, TargetHttpsProxy targetHttpsProxyResource, st::CancellationToken cancellationToken) =>
            InsertAsync(project, targetHttpsProxyResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves the list of TargetHttpsProxy resources available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TargetHttpsProxy"/> resources.</returns>
        public virtual gax::PagedEnumerable<TargetHttpsProxyList, TargetHttpsProxy> List(ListTargetHttpsProxiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of TargetHttpsProxy resources available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TargetHttpsProxy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<TargetHttpsProxyList, TargetHttpsProxy> ListAsync(ListTargetHttpsProxiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves the list of TargetHttpsProxy resources available to the specified project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
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
        /// <returns>A pageable sequence of <see cref="TargetHttpsProxy"/> resources.</returns>
        public virtual gax::PagedEnumerable<TargetHttpsProxyList, TargetHttpsProxy> List(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTargetHttpsProxiesRequest request = new ListTargetHttpsProxiesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return List(request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of TargetHttpsProxy resources available to the specified project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TargetHttpsProxy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<TargetHttpsProxyList, TargetHttpsProxy> ListAsync(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTargetHttpsProxiesRequest request = new ListTargetHttpsProxiesRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAsync(request, callSettings);
        }

        /// <summary>
        /// Patches the specified TargetHttpsProxy resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Patch(PatchTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches the specified TargetHttpsProxy resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PatchAsync(PatchTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Patches the specified TargetHttpsProxy resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PatchAsync(PatchTargetHttpsProxyRequest request, st::CancellationToken cancellationToken) =>
            PatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>Patch</c>.</summary>
        public virtual lro::OperationsClient PatchOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Patch</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOncePatch(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PatchOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>Patch</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOncePatchAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PatchOperationsClient, callSettings);

        /// <summary>
        /// Patches the specified TargetHttpsProxy resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource to patch.
        /// </param>
        /// <param name="targetHttpsProxyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> Patch(string project, string targetHttpsProxy, TargetHttpsProxy targetHttpsProxyResource, gaxgrpc::CallSettings callSettings = null) =>
            Patch(new PatchTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetHttpsProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpsProxy, nameof(targetHttpsProxy)),
                TargetHttpsProxyResource = gax::GaxPreconditions.CheckNotNull(targetHttpsProxyResource, nameof(targetHttpsProxyResource)),
            }, callSettings);

        /// <summary>
        /// Patches the specified TargetHttpsProxy resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource to patch.
        /// </param>
        /// <param name="targetHttpsProxyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PatchAsync(string project, string targetHttpsProxy, TargetHttpsProxy targetHttpsProxyResource, gaxgrpc::CallSettings callSettings = null) =>
            PatchAsync(new PatchTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetHttpsProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpsProxy, nameof(targetHttpsProxy)),
                TargetHttpsProxyResource = gax::GaxPreconditions.CheckNotNull(targetHttpsProxyResource, nameof(targetHttpsProxyResource)),
            }, callSettings);

        /// <summary>
        /// Patches the specified TargetHttpsProxy resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource to patch.
        /// </param>
        /// <param name="targetHttpsProxyResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PatchAsync(string project, string targetHttpsProxy, TargetHttpsProxy targetHttpsProxyResource, st::CancellationToken cancellationToken) =>
            PatchAsync(project, targetHttpsProxy, targetHttpsProxyResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Changes the Certificate Map for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetCertificateMap(SetCertificateMapTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes the Certificate Map for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetCertificateMapAsync(SetCertificateMapTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes the Certificate Map for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetCertificateMapAsync(SetCertificateMapTargetHttpsProxyRequest request, st::CancellationToken cancellationToken) =>
            SetCertificateMapAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SetCertificateMap</c>.</summary>
        public virtual lro::OperationsClient SetCertificateMapOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SetCertificateMap</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceSetCertificateMap(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetCertificateMapOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetCertificateMap</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceSetCertificateMapAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetCertificateMapOperationsClient, callSettings);

        /// <summary>
        /// Changes the Certificate Map for TargetHttpsProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource whose CertificateMap is to be set. The name must be 1-63 characters long, and comply with RFC1035.
        /// </param>
        /// <param name="targetHttpsProxiesSetCertificateMapRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetCertificateMap(string project, string targetHttpsProxy, TargetHttpsProxiesSetCertificateMapRequest targetHttpsProxiesSetCertificateMapRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetCertificateMap(new SetCertificateMapTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetHttpsProxiesSetCertificateMapRequestResource = gax::GaxPreconditions.CheckNotNull(targetHttpsProxiesSetCertificateMapRequestResource, nameof(targetHttpsProxiesSetCertificateMapRequestResource)),
                TargetHttpsProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpsProxy, nameof(targetHttpsProxy)),
            }, callSettings);

        /// <summary>
        /// Changes the Certificate Map for TargetHttpsProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource whose CertificateMap is to be set. The name must be 1-63 characters long, and comply with RFC1035.
        /// </param>
        /// <param name="targetHttpsProxiesSetCertificateMapRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetCertificateMapAsync(string project, string targetHttpsProxy, TargetHttpsProxiesSetCertificateMapRequest targetHttpsProxiesSetCertificateMapRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetCertificateMapAsync(new SetCertificateMapTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetHttpsProxiesSetCertificateMapRequestResource = gax::GaxPreconditions.CheckNotNull(targetHttpsProxiesSetCertificateMapRequestResource, nameof(targetHttpsProxiesSetCertificateMapRequestResource)),
                TargetHttpsProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpsProxy, nameof(targetHttpsProxy)),
            }, callSettings);

        /// <summary>
        /// Changes the Certificate Map for TargetHttpsProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource whose CertificateMap is to be set. The name must be 1-63 characters long, and comply with RFC1035.
        /// </param>
        /// <param name="targetHttpsProxiesSetCertificateMapRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetCertificateMapAsync(string project, string targetHttpsProxy, TargetHttpsProxiesSetCertificateMapRequest targetHttpsProxiesSetCertificateMapRequestResource, st::CancellationToken cancellationToken) =>
            SetCertificateMapAsync(project, targetHttpsProxy, targetHttpsProxiesSetCertificateMapRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the QUIC override policy for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetQuicOverride(SetQuicOverrideTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the QUIC override policy for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetQuicOverrideAsync(SetQuicOverrideTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the QUIC override policy for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetQuicOverrideAsync(SetQuicOverrideTargetHttpsProxyRequest request, st::CancellationToken cancellationToken) =>
            SetQuicOverrideAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SetQuicOverride</c>.</summary>
        public virtual lro::OperationsClient SetQuicOverrideOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SetQuicOverride</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceSetQuicOverride(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetQuicOverrideOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetQuicOverride</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceSetQuicOverrideAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetQuicOverrideOperationsClient, callSettings);

        /// <summary>
        /// Sets the QUIC override policy for TargetHttpsProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource to set the QUIC override policy for. The name should conform to RFC1035.
        /// </param>
        /// <param name="targetHttpsProxiesSetQuicOverrideRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetQuicOverride(string project, string targetHttpsProxy, TargetHttpsProxiesSetQuicOverrideRequest targetHttpsProxiesSetQuicOverrideRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetQuicOverride(new SetQuicOverrideTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetHttpsProxiesSetQuicOverrideRequestResource = gax::GaxPreconditions.CheckNotNull(targetHttpsProxiesSetQuicOverrideRequestResource, nameof(targetHttpsProxiesSetQuicOverrideRequestResource)),
                TargetHttpsProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpsProxy, nameof(targetHttpsProxy)),
            }, callSettings);

        /// <summary>
        /// Sets the QUIC override policy for TargetHttpsProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource to set the QUIC override policy for. The name should conform to RFC1035.
        /// </param>
        /// <param name="targetHttpsProxiesSetQuicOverrideRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetQuicOverrideAsync(string project, string targetHttpsProxy, TargetHttpsProxiesSetQuicOverrideRequest targetHttpsProxiesSetQuicOverrideRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetQuicOverrideAsync(new SetQuicOverrideTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetHttpsProxiesSetQuicOverrideRequestResource = gax::GaxPreconditions.CheckNotNull(targetHttpsProxiesSetQuicOverrideRequestResource, nameof(targetHttpsProxiesSetQuicOverrideRequestResource)),
                TargetHttpsProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpsProxy, nameof(targetHttpsProxy)),
            }, callSettings);

        /// <summary>
        /// Sets the QUIC override policy for TargetHttpsProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource to set the QUIC override policy for. The name should conform to RFC1035.
        /// </param>
        /// <param name="targetHttpsProxiesSetQuicOverrideRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetQuicOverrideAsync(string project, string targetHttpsProxy, TargetHttpsProxiesSetQuicOverrideRequest targetHttpsProxiesSetQuicOverrideRequestResource, st::CancellationToken cancellationToken) =>
            SetQuicOverrideAsync(project, targetHttpsProxy, targetHttpsProxiesSetQuicOverrideRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Replaces SslCertificates for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetSslCertificates(SetSslCertificatesTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Replaces SslCertificates for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetSslCertificatesAsync(SetSslCertificatesTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Replaces SslCertificates for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetSslCertificatesAsync(SetSslCertificatesTargetHttpsProxyRequest request, st::CancellationToken cancellationToken) =>
            SetSslCertificatesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SetSslCertificates</c>.</summary>
        public virtual lro::OperationsClient SetSslCertificatesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SetSslCertificates</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceSetSslCertificates(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetSslCertificatesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetSslCertificates</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceSetSslCertificatesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetSslCertificatesOperationsClient, callSettings);

        /// <summary>
        /// Replaces SslCertificates for TargetHttpsProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource to set an SslCertificates resource for.
        /// </param>
        /// <param name="targetHttpsProxiesSetSslCertificatesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetSslCertificates(string project, string targetHttpsProxy, TargetHttpsProxiesSetSslCertificatesRequest targetHttpsProxiesSetSslCertificatesRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetSslCertificates(new SetSslCertificatesTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetHttpsProxiesSetSslCertificatesRequestResource = gax::GaxPreconditions.CheckNotNull(targetHttpsProxiesSetSslCertificatesRequestResource, nameof(targetHttpsProxiesSetSslCertificatesRequestResource)),
                TargetHttpsProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpsProxy, nameof(targetHttpsProxy)),
            }, callSettings);

        /// <summary>
        /// Replaces SslCertificates for TargetHttpsProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource to set an SslCertificates resource for.
        /// </param>
        /// <param name="targetHttpsProxiesSetSslCertificatesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetSslCertificatesAsync(string project, string targetHttpsProxy, TargetHttpsProxiesSetSslCertificatesRequest targetHttpsProxiesSetSslCertificatesRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetSslCertificatesAsync(new SetSslCertificatesTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetHttpsProxiesSetSslCertificatesRequestResource = gax::GaxPreconditions.CheckNotNull(targetHttpsProxiesSetSslCertificatesRequestResource, nameof(targetHttpsProxiesSetSslCertificatesRequestResource)),
                TargetHttpsProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpsProxy, nameof(targetHttpsProxy)),
            }, callSettings);

        /// <summary>
        /// Replaces SslCertificates for TargetHttpsProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource to set an SslCertificates resource for.
        /// </param>
        /// <param name="targetHttpsProxiesSetSslCertificatesRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetSslCertificatesAsync(string project, string targetHttpsProxy, TargetHttpsProxiesSetSslCertificatesRequest targetHttpsProxiesSetSslCertificatesRequestResource, st::CancellationToken cancellationToken) =>
            SetSslCertificatesAsync(project, targetHttpsProxy, targetHttpsProxiesSetSslCertificatesRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the SSL policy for TargetHttpsProxy. The SSL policy specifies the server-side support for SSL features. This affects connections between clients and the HTTPS proxy load balancer. They do not affect the connection between the load balancer and the backends.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetSslPolicy(SetSslPolicyTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the SSL policy for TargetHttpsProxy. The SSL policy specifies the server-side support for SSL features. This affects connections between clients and the HTTPS proxy load balancer. They do not affect the connection between the load balancer and the backends.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetSslPolicyAsync(SetSslPolicyTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the SSL policy for TargetHttpsProxy. The SSL policy specifies the server-side support for SSL features. This affects connections between clients and the HTTPS proxy load balancer. They do not affect the connection between the load balancer and the backends.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetSslPolicyAsync(SetSslPolicyTargetHttpsProxyRequest request, st::CancellationToken cancellationToken) =>
            SetSslPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SetSslPolicy</c>.</summary>
        public virtual lro::OperationsClient SetSslPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SetSslPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceSetSslPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetSslPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetSslPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceSetSslPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetSslPolicyOperationsClient, callSettings);

        /// <summary>
        /// Sets the SSL policy for TargetHttpsProxy. The SSL policy specifies the server-side support for SSL features. This affects connections between clients and the HTTPS proxy load balancer. They do not affect the connection between the load balancer and the backends.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource whose SSL policy is to be set. The name must be 1-63 characters long, and comply with RFC1035.
        /// </param>
        /// <param name="sslPolicyReferenceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetSslPolicy(string project, string targetHttpsProxy, SslPolicyReference sslPolicyReferenceResource, gaxgrpc::CallSettings callSettings = null) =>
            SetSslPolicy(new SetSslPolicyTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                SslPolicyReferenceResource = gax::GaxPreconditions.CheckNotNull(sslPolicyReferenceResource, nameof(sslPolicyReferenceResource)),
                TargetHttpsProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpsProxy, nameof(targetHttpsProxy)),
            }, callSettings);

        /// <summary>
        /// Sets the SSL policy for TargetHttpsProxy. The SSL policy specifies the server-side support for SSL features. This affects connections between clients and the HTTPS proxy load balancer. They do not affect the connection between the load balancer and the backends.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource whose SSL policy is to be set. The name must be 1-63 characters long, and comply with RFC1035.
        /// </param>
        /// <param name="sslPolicyReferenceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetSslPolicyAsync(string project, string targetHttpsProxy, SslPolicyReference sslPolicyReferenceResource, gaxgrpc::CallSettings callSettings = null) =>
            SetSslPolicyAsync(new SetSslPolicyTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                SslPolicyReferenceResource = gax::GaxPreconditions.CheckNotNull(sslPolicyReferenceResource, nameof(sslPolicyReferenceResource)),
                TargetHttpsProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpsProxy, nameof(targetHttpsProxy)),
            }, callSettings);

        /// <summary>
        /// Sets the SSL policy for TargetHttpsProxy. The SSL policy specifies the server-side support for SSL features. This affects connections between clients and the HTTPS proxy load balancer. They do not affect the connection between the load balancer and the backends.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource whose SSL policy is to be set. The name must be 1-63 characters long, and comply with RFC1035.
        /// </param>
        /// <param name="sslPolicyReferenceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetSslPolicyAsync(string project, string targetHttpsProxy, SslPolicyReference sslPolicyReferenceResource, st::CancellationToken cancellationToken) =>
            SetSslPolicyAsync(project, targetHttpsProxy, sslPolicyReferenceResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Changes the URL map for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetUrlMap(SetUrlMapTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes the URL map for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetUrlMapAsync(SetUrlMapTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Changes the URL map for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetUrlMapAsync(SetUrlMapTargetHttpsProxyRequest request, st::CancellationToken cancellationToken) =>
            SetUrlMapAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SetUrlMap</c>.</summary>
        public virtual lro::OperationsClient SetUrlMapOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SetUrlMap</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceSetUrlMap(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetUrlMapOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetUrlMap</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceSetUrlMapAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetUrlMapOperationsClient, callSettings);

        /// <summary>
        /// Changes the URL map for TargetHttpsProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource whose URL map is to be set.
        /// </param>
        /// <param name="urlMapReferenceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetUrlMap(string project, string targetHttpsProxy, UrlMapReference urlMapReferenceResource, gaxgrpc::CallSettings callSettings = null) =>
            SetUrlMap(new SetUrlMapTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetHttpsProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpsProxy, nameof(targetHttpsProxy)),
                UrlMapReferenceResource = gax::GaxPreconditions.CheckNotNull(urlMapReferenceResource, nameof(urlMapReferenceResource)),
            }, callSettings);

        /// <summary>
        /// Changes the URL map for TargetHttpsProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource whose URL map is to be set.
        /// </param>
        /// <param name="urlMapReferenceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetUrlMapAsync(string project, string targetHttpsProxy, UrlMapReference urlMapReferenceResource, gaxgrpc::CallSettings callSettings = null) =>
            SetUrlMapAsync(new SetUrlMapTargetHttpsProxyRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                TargetHttpsProxy = gax::GaxPreconditions.CheckNotNullOrEmpty(targetHttpsProxy, nameof(targetHttpsProxy)),
                UrlMapReferenceResource = gax::GaxPreconditions.CheckNotNull(urlMapReferenceResource, nameof(urlMapReferenceResource)),
            }, callSettings);

        /// <summary>
        /// Changes the URL map for TargetHttpsProxy.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="targetHttpsProxy">
        /// Name of the TargetHttpsProxy resource whose URL map is to be set.
        /// </param>
        /// <param name="urlMapReferenceResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetUrlMapAsync(string project, string targetHttpsProxy, UrlMapReference urlMapReferenceResource, st::CancellationToken cancellationToken) =>
            SetUrlMapAsync(project, targetHttpsProxy, urlMapReferenceResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>TargetHttpsProxies client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The TargetHttpsProxies API.
    /// </remarks>
    public sealed partial class TargetHttpsProxiesClientImpl : TargetHttpsProxiesClient
    {
        private readonly gaxgrpc::ApiCall<AggregatedListTargetHttpsProxiesRequest, TargetHttpsProxyAggregatedList> _callAggregatedList;

        private readonly gaxgrpc::ApiCall<DeleteTargetHttpsProxyRequest, Operation> _callDelete;

        private readonly gaxgrpc::ApiCall<GetTargetHttpsProxyRequest, TargetHttpsProxy> _callGet;

        private readonly gaxgrpc::ApiCall<InsertTargetHttpsProxyRequest, Operation> _callInsert;

        private readonly gaxgrpc::ApiCall<ListTargetHttpsProxiesRequest, TargetHttpsProxyList> _callList;

        private readonly gaxgrpc::ApiCall<PatchTargetHttpsProxyRequest, Operation> _callPatch;

        private readonly gaxgrpc::ApiCall<SetCertificateMapTargetHttpsProxyRequest, Operation> _callSetCertificateMap;

        private readonly gaxgrpc::ApiCall<SetQuicOverrideTargetHttpsProxyRequest, Operation> _callSetQuicOverride;

        private readonly gaxgrpc::ApiCall<SetSslCertificatesTargetHttpsProxyRequest, Operation> _callSetSslCertificates;

        private readonly gaxgrpc::ApiCall<SetSslPolicyTargetHttpsProxyRequest, Operation> _callSetSslPolicy;

        private readonly gaxgrpc::ApiCall<SetUrlMapTargetHttpsProxyRequest, Operation> _callSetUrlMap;

        /// <summary>
        /// Constructs a client wrapper for the TargetHttpsProxies service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="TargetHttpsProxiesSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public TargetHttpsProxiesClientImpl(TargetHttpsProxies.TargetHttpsProxiesClient grpcClient, TargetHttpsProxiesSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            TargetHttpsProxiesSettings effectiveSettings = settings ?? TargetHttpsProxiesSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            DeleteOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.DeleteOperationsSettings, logger);
            InsertOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.InsertOperationsSettings, logger);
            PatchOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.PatchOperationsSettings, logger);
            SetCertificateMapOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.SetCertificateMapOperationsSettings, logger);
            SetQuicOverrideOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.SetQuicOverrideOperationsSettings, logger);
            SetSslCertificatesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.SetSslCertificatesOperationsSettings, logger);
            SetSslPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.SetSslPolicyOperationsSettings, logger);
            SetUrlMapOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.SetUrlMapOperationsSettings, logger);
            _callAggregatedList = clientHelper.BuildApiCall<AggregatedListTargetHttpsProxiesRequest, TargetHttpsProxyAggregatedList>("AggregatedList", grpcClient.AggregatedListAsync, grpcClient.AggregatedList, effectiveSettings.AggregatedListSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callAggregatedList);
            Modify_AggregatedListApiCall(ref _callAggregatedList);
            _callDelete = clientHelper.BuildApiCall<DeleteTargetHttpsProxyRequest, Operation>("Delete", grpcClient.DeleteAsync, grpcClient.Delete, effectiveSettings.DeleteSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("target_https_proxy", request => request.TargetHttpsProxy);
            Modify_ApiCall(ref _callDelete);
            Modify_DeleteApiCall(ref _callDelete);
            _callGet = clientHelper.BuildApiCall<GetTargetHttpsProxyRequest, TargetHttpsProxy>("Get", grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("target_https_proxy", request => request.TargetHttpsProxy);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callInsert = clientHelper.BuildApiCall<InsertTargetHttpsProxyRequest, Operation>("Insert", grpcClient.InsertAsync, grpcClient.Insert, effectiveSettings.InsertSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callInsert);
            Modify_InsertApiCall(ref _callInsert);
            _callList = clientHelper.BuildApiCall<ListTargetHttpsProxiesRequest, TargetHttpsProxyList>("List", grpcClient.ListAsync, grpcClient.List, effectiveSettings.ListSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callList);
            Modify_ListApiCall(ref _callList);
            _callPatch = clientHelper.BuildApiCall<PatchTargetHttpsProxyRequest, Operation>("Patch", grpcClient.PatchAsync, grpcClient.Patch, effectiveSettings.PatchSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("target_https_proxy", request => request.TargetHttpsProxy);
            Modify_ApiCall(ref _callPatch);
            Modify_PatchApiCall(ref _callPatch);
            _callSetCertificateMap = clientHelper.BuildApiCall<SetCertificateMapTargetHttpsProxyRequest, Operation>("SetCertificateMap", grpcClient.SetCertificateMapAsync, grpcClient.SetCertificateMap, effectiveSettings.SetCertificateMapSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("target_https_proxy", request => request.TargetHttpsProxy);
            Modify_ApiCall(ref _callSetCertificateMap);
            Modify_SetCertificateMapApiCall(ref _callSetCertificateMap);
            _callSetQuicOverride = clientHelper.BuildApiCall<SetQuicOverrideTargetHttpsProxyRequest, Operation>("SetQuicOverride", grpcClient.SetQuicOverrideAsync, grpcClient.SetQuicOverride, effectiveSettings.SetQuicOverrideSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("target_https_proxy", request => request.TargetHttpsProxy);
            Modify_ApiCall(ref _callSetQuicOverride);
            Modify_SetQuicOverrideApiCall(ref _callSetQuicOverride);
            _callSetSslCertificates = clientHelper.BuildApiCall<SetSslCertificatesTargetHttpsProxyRequest, Operation>("SetSslCertificates", grpcClient.SetSslCertificatesAsync, grpcClient.SetSslCertificates, effectiveSettings.SetSslCertificatesSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("target_https_proxy", request => request.TargetHttpsProxy);
            Modify_ApiCall(ref _callSetSslCertificates);
            Modify_SetSslCertificatesApiCall(ref _callSetSslCertificates);
            _callSetSslPolicy = clientHelper.BuildApiCall<SetSslPolicyTargetHttpsProxyRequest, Operation>("SetSslPolicy", grpcClient.SetSslPolicyAsync, grpcClient.SetSslPolicy, effectiveSettings.SetSslPolicySettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("target_https_proxy", request => request.TargetHttpsProxy);
            Modify_ApiCall(ref _callSetSslPolicy);
            Modify_SetSslPolicyApiCall(ref _callSetSslPolicy);
            _callSetUrlMap = clientHelper.BuildApiCall<SetUrlMapTargetHttpsProxyRequest, Operation>("SetUrlMap", grpcClient.SetUrlMapAsync, grpcClient.SetUrlMap, effectiveSettings.SetUrlMapSettings).WithGoogleRequestParam("project", request => request.Project).WithGoogleRequestParam("target_https_proxy", request => request.TargetHttpsProxy);
            Modify_ApiCall(ref _callSetUrlMap);
            Modify_SetUrlMapApiCall(ref _callSetUrlMap);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_AggregatedListApiCall(ref gaxgrpc::ApiCall<AggregatedListTargetHttpsProxiesRequest, TargetHttpsProxyAggregatedList> call);

        partial void Modify_DeleteApiCall(ref gaxgrpc::ApiCall<DeleteTargetHttpsProxyRequest, Operation> call);

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetTargetHttpsProxyRequest, TargetHttpsProxy> call);

        partial void Modify_InsertApiCall(ref gaxgrpc::ApiCall<InsertTargetHttpsProxyRequest, Operation> call);

        partial void Modify_ListApiCall(ref gaxgrpc::ApiCall<ListTargetHttpsProxiesRequest, TargetHttpsProxyList> call);

        partial void Modify_PatchApiCall(ref gaxgrpc::ApiCall<PatchTargetHttpsProxyRequest, Operation> call);

        partial void Modify_SetCertificateMapApiCall(ref gaxgrpc::ApiCall<SetCertificateMapTargetHttpsProxyRequest, Operation> call);

        partial void Modify_SetQuicOverrideApiCall(ref gaxgrpc::ApiCall<SetQuicOverrideTargetHttpsProxyRequest, Operation> call);

        partial void Modify_SetSslCertificatesApiCall(ref gaxgrpc::ApiCall<SetSslCertificatesTargetHttpsProxyRequest, Operation> call);

        partial void Modify_SetSslPolicyApiCall(ref gaxgrpc::ApiCall<SetSslPolicyTargetHttpsProxyRequest, Operation> call);

        partial void Modify_SetUrlMapApiCall(ref gaxgrpc::ApiCall<SetUrlMapTargetHttpsProxyRequest, Operation> call);

        partial void OnConstruction(TargetHttpsProxies.TargetHttpsProxiesClient grpcClient, TargetHttpsProxiesSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC TargetHttpsProxies client</summary>
        public override TargetHttpsProxies.TargetHttpsProxiesClient GrpcClient { get; }

        partial void Modify_AggregatedListTargetHttpsProxiesRequest(ref AggregatedListTargetHttpsProxiesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTargetHttpsProxyRequest(ref DeleteTargetHttpsProxyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTargetHttpsProxyRequest(ref GetTargetHttpsProxyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_InsertTargetHttpsProxyRequest(ref InsertTargetHttpsProxyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTargetHttpsProxiesRequest(ref ListTargetHttpsProxiesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PatchTargetHttpsProxyRequest(ref PatchTargetHttpsProxyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetCertificateMapTargetHttpsProxyRequest(ref SetCertificateMapTargetHttpsProxyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetQuicOverrideTargetHttpsProxyRequest(ref SetQuicOverrideTargetHttpsProxyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetSslCertificatesTargetHttpsProxyRequest(ref SetSslCertificatesTargetHttpsProxyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetSslPolicyTargetHttpsProxyRequest(ref SetSslPolicyTargetHttpsProxyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetUrlMapTargetHttpsProxyRequest(ref SetUrlMapTargetHttpsProxyRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Retrieves the list of all TargetHttpsProxy resources, regional and global, available to the specified project. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.</returns>
        public override gax::PagedEnumerable<TargetHttpsProxyAggregatedList, scg::KeyValuePair<string, TargetHttpsProxiesScopedList>> AggregatedList(AggregatedListTargetHttpsProxiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregatedListTargetHttpsProxiesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<AggregatedListTargetHttpsProxiesRequest, TargetHttpsProxyAggregatedList, scg::KeyValuePair<string, TargetHttpsProxiesScopedList>>(_callAggregatedList, request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of all TargetHttpsProxy resources, regional and global, available to the specified project. To prevent failure, Google recommends that you set the `returnPartialSuccess` parameter to `true`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="scg::KeyValuePair{TKey,TValue}"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<TargetHttpsProxyAggregatedList, scg::KeyValuePair<string, TargetHttpsProxiesScopedList>> AggregatedListAsync(AggregatedListTargetHttpsProxiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AggregatedListTargetHttpsProxiesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<AggregatedListTargetHttpsProxiesRequest, TargetHttpsProxyAggregatedList, scg::KeyValuePair<string, TargetHttpsProxiesScopedList>>(_callAggregatedList, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>Delete</c>.</summary>
        public override lro::OperationsClient DeleteOperationsClient { get; }

        /// <summary>
        /// Deletes the specified TargetHttpsProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Delete(DeleteTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTargetHttpsProxyRequest(ref request, ref callSettings);
            Operation response = _callDelete.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteOperationsClient);
        }

        /// <summary>
        /// Deletes the specified TargetHttpsProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> DeleteAsync(DeleteTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTargetHttpsProxyRequest(ref request, ref callSettings);
            Operation response = await _callDelete.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DeleteOperationsClient);
        }

        /// <summary>
        /// Returns the specified TargetHttpsProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TargetHttpsProxy Get(GetTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTargetHttpsProxyRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified TargetHttpsProxy resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TargetHttpsProxy> GetAsync(GetTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTargetHttpsProxyRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>Insert</c>.</summary>
        public override lro::OperationsClient InsertOperationsClient { get; }

        /// <summary>
        /// Creates a TargetHttpsProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Insert(InsertTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertTargetHttpsProxyRequest(ref request, ref callSettings);
            Operation response = _callInsert.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), InsertOperationsClient);
        }

        /// <summary>
        /// Creates a TargetHttpsProxy resource in the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> InsertAsync(InsertTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InsertTargetHttpsProxyRequest(ref request, ref callSettings);
            Operation response = await _callInsert.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), InsertOperationsClient);
        }

        /// <summary>
        /// Retrieves the list of TargetHttpsProxy resources available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TargetHttpsProxy"/> resources.</returns>
        public override gax::PagedEnumerable<TargetHttpsProxyList, TargetHttpsProxy> List(ListTargetHttpsProxiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTargetHttpsProxiesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTargetHttpsProxiesRequest, TargetHttpsProxyList, TargetHttpsProxy>(_callList, request, callSettings);
        }

        /// <summary>
        /// Retrieves the list of TargetHttpsProxy resources available to the specified project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TargetHttpsProxy"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<TargetHttpsProxyList, TargetHttpsProxy> ListAsync(ListTargetHttpsProxiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTargetHttpsProxiesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTargetHttpsProxiesRequest, TargetHttpsProxyList, TargetHttpsProxy>(_callList, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>Patch</c>.</summary>
        public override lro::OperationsClient PatchOperationsClient { get; }

        /// <summary>
        /// Patches the specified TargetHttpsProxy resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> Patch(PatchTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchTargetHttpsProxyRequest(ref request, ref callSettings);
            Operation response = _callPatch.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), PatchOperationsClient);
        }

        /// <summary>
        /// Patches the specified TargetHttpsProxy resource with the data included in the request. This method supports PATCH semantics and uses JSON merge patch format and processing rules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> PatchAsync(PatchTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PatchTargetHttpsProxyRequest(ref request, ref callSettings);
            Operation response = await _callPatch.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), PatchOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SetCertificateMap</c>.</summary>
        public override lro::OperationsClient SetCertificateMapOperationsClient { get; }

        /// <summary>
        /// Changes the Certificate Map for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> SetCertificateMap(SetCertificateMapTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetCertificateMapTargetHttpsProxyRequest(ref request, ref callSettings);
            Operation response = _callSetCertificateMap.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetCertificateMapOperationsClient);
        }

        /// <summary>
        /// Changes the Certificate Map for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> SetCertificateMapAsync(SetCertificateMapTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetCertificateMapTargetHttpsProxyRequest(ref request, ref callSettings);
            Operation response = await _callSetCertificateMap.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetCertificateMapOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SetQuicOverride</c>.</summary>
        public override lro::OperationsClient SetQuicOverrideOperationsClient { get; }

        /// <summary>
        /// Sets the QUIC override policy for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> SetQuicOverride(SetQuicOverrideTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetQuicOverrideTargetHttpsProxyRequest(ref request, ref callSettings);
            Operation response = _callSetQuicOverride.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetQuicOverrideOperationsClient);
        }

        /// <summary>
        /// Sets the QUIC override policy for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> SetQuicOverrideAsync(SetQuicOverrideTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetQuicOverrideTargetHttpsProxyRequest(ref request, ref callSettings);
            Operation response = await _callSetQuicOverride.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetQuicOverrideOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SetSslCertificates</c>.</summary>
        public override lro::OperationsClient SetSslCertificatesOperationsClient { get; }

        /// <summary>
        /// Replaces SslCertificates for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> SetSslCertificates(SetSslCertificatesTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetSslCertificatesTargetHttpsProxyRequest(ref request, ref callSettings);
            Operation response = _callSetSslCertificates.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetSslCertificatesOperationsClient);
        }

        /// <summary>
        /// Replaces SslCertificates for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> SetSslCertificatesAsync(SetSslCertificatesTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetSslCertificatesTargetHttpsProxyRequest(ref request, ref callSettings);
            Operation response = await _callSetSslCertificates.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetSslCertificatesOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SetSslPolicy</c>.</summary>
        public override lro::OperationsClient SetSslPolicyOperationsClient { get; }

        /// <summary>
        /// Sets the SSL policy for TargetHttpsProxy. The SSL policy specifies the server-side support for SSL features. This affects connections between clients and the HTTPS proxy load balancer. They do not affect the connection between the load balancer and the backends.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> SetSslPolicy(SetSslPolicyTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetSslPolicyTargetHttpsProxyRequest(ref request, ref callSettings);
            Operation response = _callSetSslPolicy.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetSslPolicyOperationsClient);
        }

        /// <summary>
        /// Sets the SSL policy for TargetHttpsProxy. The SSL policy specifies the server-side support for SSL features. This affects connections between clients and the HTTPS proxy load balancer. They do not affect the connection between the load balancer and the backends.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> SetSslPolicyAsync(SetSslPolicyTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetSslPolicyTargetHttpsProxyRequest(ref request, ref callSettings);
            Operation response = await _callSetSslPolicy.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetSslPolicyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SetUrlMap</c>.</summary>
        public override lro::OperationsClient SetUrlMapOperationsClient { get; }

        /// <summary>
        /// Changes the URL map for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> SetUrlMap(SetUrlMapTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetUrlMapTargetHttpsProxyRequest(ref request, ref callSettings);
            Operation response = _callSetUrlMap.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetUrlMapOperationsClient);
        }

        /// <summary>
        /// Changes the URL map for TargetHttpsProxy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> SetUrlMapAsync(SetUrlMapTargetHttpsProxyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetUrlMapTargetHttpsProxyRequest(ref request, ref callSettings);
            Operation response = await _callSetUrlMap.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetUrlMapOperationsClient);
        }
    }

    public partial class AggregatedListTargetHttpsProxiesRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class ListTargetHttpsProxiesRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class TargetHttpsProxyAggregatedList : gaxgrpc::IPageResponse<scg::KeyValuePair<string, TargetHttpsProxiesScopedList>>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<scg::KeyValuePair<string, TargetHttpsProxiesScopedList>> GetEnumerator() =>
            Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class TargetHttpsProxies
    {
        public partial class TargetHttpsProxiesClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client, delegating to GlobalOperations.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClientForGlobalOperations() =>
                GlobalOperations.GlobalOperationsClient.CreateOperationsClient(CallInvoker);
        }
    }
}
