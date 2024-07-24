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
    /// <summary>Settings for <see cref="ProjectsClient"/> instances.</summary>
    public sealed partial class ProjectsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ProjectsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ProjectsSettings"/>.</returns>
        public static ProjectsSettings GetDefault() => new ProjectsSettings();

        /// <summary>Constructs a new <see cref="ProjectsSettings"/> object with default settings.</summary>
        public ProjectsSettings()
        {
        }

        private ProjectsSettings(ProjectsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            DisableXpnHostSettings = existing.DisableXpnHostSettings;
            DisableXpnHostOperationsSettings = existing.DisableXpnHostOperationsSettings.Clone();
            DisableXpnResourceSettings = existing.DisableXpnResourceSettings;
            DisableXpnResourceOperationsSettings = existing.DisableXpnResourceOperationsSettings.Clone();
            EnableXpnHostSettings = existing.EnableXpnHostSettings;
            EnableXpnHostOperationsSettings = existing.EnableXpnHostOperationsSettings.Clone();
            EnableXpnResourceSettings = existing.EnableXpnResourceSettings;
            EnableXpnResourceOperationsSettings = existing.EnableXpnResourceOperationsSettings.Clone();
            GetSettings = existing.GetSettings;
            GetXpnHostSettings = existing.GetXpnHostSettings;
            GetXpnResourcesSettings = existing.GetXpnResourcesSettings;
            ListXpnHostsSettings = existing.ListXpnHostsSettings;
            MoveDiskSettings = existing.MoveDiskSettings;
            MoveDiskOperationsSettings = existing.MoveDiskOperationsSettings.Clone();
            MoveInstanceSettings = existing.MoveInstanceSettings;
            MoveInstanceOperationsSettings = existing.MoveInstanceOperationsSettings.Clone();
            SetCloudArmorTierSettings = existing.SetCloudArmorTierSettings;
            SetCloudArmorTierOperationsSettings = existing.SetCloudArmorTierOperationsSettings.Clone();
            SetCommonInstanceMetadataSettings = existing.SetCommonInstanceMetadataSettings;
            SetCommonInstanceMetadataOperationsSettings = existing.SetCommonInstanceMetadataOperationsSettings.Clone();
            SetDefaultNetworkTierSettings = existing.SetDefaultNetworkTierSettings;
            SetDefaultNetworkTierOperationsSettings = existing.SetDefaultNetworkTierOperationsSettings.Clone();
            SetUsageExportBucketSettings = existing.SetUsageExportBucketSettings;
            SetUsageExportBucketOperationsSettings = existing.SetUsageExportBucketOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(ProjectsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProjectsClient.DisableXpnHost</c> and <c>ProjectsClient.DisableXpnHostAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DisableXpnHostSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ProjectsClient.DisableXpnHost</c> and
        /// <c>ProjectsClient.DisableXpnHostAsync</c>.
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
        public lro::OperationsSettings DisableXpnHostOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProjectsClient.DisableXpnResource</c> and <c>ProjectsClient.DisableXpnResourceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DisableXpnResourceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ProjectsClient.DisableXpnResource</c> and
        /// <c>ProjectsClient.DisableXpnResourceAsync</c>.
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
        public lro::OperationsSettings DisableXpnResourceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProjectsClient.EnableXpnHost</c> and <c>ProjectsClient.EnableXpnHostAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings EnableXpnHostSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ProjectsClient.EnableXpnHost</c> and
        /// <c>ProjectsClient.EnableXpnHostAsync</c>.
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
        public lro::OperationsSettings EnableXpnHostOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProjectsClient.EnableXpnResource</c> and <c>ProjectsClient.EnableXpnResourceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings EnableXpnResourceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ProjectsClient.EnableXpnResource</c> and
        /// <c>ProjectsClient.EnableXpnResourceAsync</c>.
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
        public lro::OperationsSettings EnableXpnResourceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ProjectsClient.Get</c> and
        /// <c>ProjectsClient.GetAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ProjectsClient.GetXpnHost</c>
        ///  and <c>ProjectsClient.GetXpnHostAsync</c>.
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
        public gaxgrpc::CallSettings GetXpnHostSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProjectsClient.GetXpnResources</c> and <c>ProjectsClient.GetXpnResourcesAsync</c>.
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
        public gaxgrpc::CallSettings GetXpnResourcesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ProjectsClient.ListXpnHosts</c>
        ///  and <c>ProjectsClient.ListXpnHostsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListXpnHostsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ProjectsClient.MoveDisk</c>
        /// and <c>ProjectsClient.MoveDiskAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MoveDiskSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ProjectsClient.MoveDisk</c> and
        /// <c>ProjectsClient.MoveDiskAsync</c>.
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
        public lro::OperationsSettings MoveDiskOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ProjectsClient.MoveInstance</c>
        ///  and <c>ProjectsClient.MoveInstanceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MoveInstanceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ProjectsClient.MoveInstance</c> and
        /// <c>ProjectsClient.MoveInstanceAsync</c>.
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
        public lro::OperationsSettings MoveInstanceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProjectsClient.SetCloudArmorTier</c> and <c>ProjectsClient.SetCloudArmorTierAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetCloudArmorTierSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ProjectsClient.SetCloudArmorTier</c> and
        /// <c>ProjectsClient.SetCloudArmorTierAsync</c>.
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
        public lro::OperationsSettings SetCloudArmorTierOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProjectsClient.SetCommonInstanceMetadata</c> and <c>ProjectsClient.SetCommonInstanceMetadataAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetCommonInstanceMetadataSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ProjectsClient.SetCommonInstanceMetadata</c> and
        /// <c>ProjectsClient.SetCommonInstanceMetadataAsync</c>.
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
        public lro::OperationsSettings SetCommonInstanceMetadataOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProjectsClient.SetDefaultNetworkTier</c> and <c>ProjectsClient.SetDefaultNetworkTierAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetDefaultNetworkTierSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ProjectsClient.SetDefaultNetworkTier</c> and
        /// <c>ProjectsClient.SetDefaultNetworkTierAsync</c>.
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
        public lro::OperationsSettings SetDefaultNetworkTierOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProjectsClient.SetUsageExportBucket</c> and <c>ProjectsClient.SetUsageExportBucketAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetUsageExportBucketSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ProjectsClient.SetUsageExportBucket</c> and
        /// <c>ProjectsClient.SetUsageExportBucketAsync</c>.
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
        public lro::OperationsSettings SetUsageExportBucketOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ProjectsSettings"/> object.</returns>
        public ProjectsSettings Clone() => new ProjectsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ProjectsClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class ProjectsClientBuilder : gaxgrpc::ClientBuilderBase<ProjectsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ProjectsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ProjectsClientBuilder() : base(ProjectsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ProjectsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ProjectsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ProjectsClient Build()
        {
            ProjectsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ProjectsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ProjectsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ProjectsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ProjectsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ProjectsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ProjectsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ProjectsClient.ChannelPool;
    }

    /// <summary>Projects client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The Projects API.
    /// </remarks>
    public abstract partial class ProjectsClient
    {
        /// <summary>
        /// The default endpoint for the Projects service, which is a host of "compute.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "compute.googleapis.com:443";

        /// <summary>The default Projects scopes.</summary>
        /// <remarks>
        /// The default Projects scopes are:
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Projects.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ProjectsClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="ProjectsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ProjectsClient"/>.</returns>
        public static stt::Task<ProjectsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ProjectsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ProjectsClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="ProjectsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ProjectsClient"/>.</returns>
        public static ProjectsClient Create() => new ProjectsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ProjectsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ProjectsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ProjectsClient"/>.</returns>
        internal static ProjectsClient Create(grpccore::CallInvoker callInvoker, ProjectsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Projects.ProjectsClient grpcClient = new Projects.ProjectsClient(callInvoker);
            return new ProjectsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Projects client</summary>
        public virtual Projects.ProjectsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Disable this project as a shared VPC host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> DisableXpnHost(DisableXpnHostProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disable this project as a shared VPC host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DisableXpnHostAsync(DisableXpnHostProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disable this project as a shared VPC host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DisableXpnHostAsync(DisableXpnHostProjectRequest request, st::CancellationToken cancellationToken) =>
            DisableXpnHostAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DisableXpnHost</c>.</summary>
        public virtual lro::OperationsClient DisableXpnHostOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DisableXpnHost</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceDisableXpnHost(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DisableXpnHostOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DisableXpnHost</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceDisableXpnHostAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DisableXpnHostOperationsClient, callSettings);

        /// <summary>
        /// Disable this project as a shared VPC host project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> DisableXpnHost(string project, gaxgrpc::CallSettings callSettings = null) =>
            DisableXpnHost(new DisableXpnHostProjectRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Disable this project as a shared VPC host project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DisableXpnHostAsync(string project, gaxgrpc::CallSettings callSettings = null) =>
            DisableXpnHostAsync(new DisableXpnHostProjectRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Disable this project as a shared VPC host project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DisableXpnHostAsync(string project, st::CancellationToken cancellationToken) =>
            DisableXpnHostAsync(project, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Disable a service resource (also known as service project) associated with this host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> DisableXpnResource(DisableXpnResourceProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disable a service resource (also known as service project) associated with this host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DisableXpnResourceAsync(DisableXpnResourceProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disable a service resource (also known as service project) associated with this host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DisableXpnResourceAsync(DisableXpnResourceProjectRequest request, st::CancellationToken cancellationToken) =>
            DisableXpnResourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DisableXpnResource</c>.</summary>
        public virtual lro::OperationsClient DisableXpnResourceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DisableXpnResource</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceDisableXpnResource(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DisableXpnResourceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DisableXpnResource</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceDisableXpnResourceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DisableXpnResourceOperationsClient, callSettings);

        /// <summary>
        /// Disable a service resource (also known as service project) associated with this host project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="projectsDisableXpnResourceRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> DisableXpnResource(string project, ProjectsDisableXpnResourceRequest projectsDisableXpnResourceRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            DisableXpnResource(new DisableXpnResourceProjectRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                ProjectsDisableXpnResourceRequestResource = gax::GaxPreconditions.CheckNotNull(projectsDisableXpnResourceRequestResource, nameof(projectsDisableXpnResourceRequestResource)),
            }, callSettings);

        /// <summary>
        /// Disable a service resource (also known as service project) associated with this host project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="projectsDisableXpnResourceRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DisableXpnResourceAsync(string project, ProjectsDisableXpnResourceRequest projectsDisableXpnResourceRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            DisableXpnResourceAsync(new DisableXpnResourceProjectRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                ProjectsDisableXpnResourceRequestResource = gax::GaxPreconditions.CheckNotNull(projectsDisableXpnResourceRequestResource, nameof(projectsDisableXpnResourceRequestResource)),
            }, callSettings);

        /// <summary>
        /// Disable a service resource (also known as service project) associated with this host project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="projectsDisableXpnResourceRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> DisableXpnResourceAsync(string project, ProjectsDisableXpnResourceRequest projectsDisableXpnResourceRequestResource, st::CancellationToken cancellationToken) =>
            DisableXpnResourceAsync(project, projectsDisableXpnResourceRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Enable this project as a shared VPC host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> EnableXpnHost(EnableXpnHostProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enable this project as a shared VPC host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> EnableXpnHostAsync(EnableXpnHostProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enable this project as a shared VPC host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> EnableXpnHostAsync(EnableXpnHostProjectRequest request, st::CancellationToken cancellationToken) =>
            EnableXpnHostAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>EnableXpnHost</c>.</summary>
        public virtual lro::OperationsClient EnableXpnHostOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>EnableXpnHost</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceEnableXpnHost(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), EnableXpnHostOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>EnableXpnHost</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceEnableXpnHostAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), EnableXpnHostOperationsClient, callSettings);

        /// <summary>
        /// Enable this project as a shared VPC host project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> EnableXpnHost(string project, gaxgrpc::CallSettings callSettings = null) =>
            EnableXpnHost(new EnableXpnHostProjectRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Enable this project as a shared VPC host project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> EnableXpnHostAsync(string project, gaxgrpc::CallSettings callSettings = null) =>
            EnableXpnHostAsync(new EnableXpnHostProjectRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Enable this project as a shared VPC host project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> EnableXpnHostAsync(string project, st::CancellationToken cancellationToken) =>
            EnableXpnHostAsync(project, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Enable service resource (a.k.a service project) for a host project, so that subnets in the host project can be used by instances in the service project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> EnableXpnResource(EnableXpnResourceProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enable service resource (a.k.a service project) for a host project, so that subnets in the host project can be used by instances in the service project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> EnableXpnResourceAsync(EnableXpnResourceProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enable service resource (a.k.a service project) for a host project, so that subnets in the host project can be used by instances in the service project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> EnableXpnResourceAsync(EnableXpnResourceProjectRequest request, st::CancellationToken cancellationToken) =>
            EnableXpnResourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>EnableXpnResource</c>.</summary>
        public virtual lro::OperationsClient EnableXpnResourceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>EnableXpnResource</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceEnableXpnResource(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), EnableXpnResourceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>EnableXpnResource</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceEnableXpnResourceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), EnableXpnResourceOperationsClient, callSettings);

        /// <summary>
        /// Enable service resource (a.k.a service project) for a host project, so that subnets in the host project can be used by instances in the service project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="projectsEnableXpnResourceRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> EnableXpnResource(string project, ProjectsEnableXpnResourceRequest projectsEnableXpnResourceRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            EnableXpnResource(new EnableXpnResourceProjectRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                ProjectsEnableXpnResourceRequestResource = gax::GaxPreconditions.CheckNotNull(projectsEnableXpnResourceRequestResource, nameof(projectsEnableXpnResourceRequestResource)),
            }, callSettings);

        /// <summary>
        /// Enable service resource (a.k.a service project) for a host project, so that subnets in the host project can be used by instances in the service project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="projectsEnableXpnResourceRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> EnableXpnResourceAsync(string project, ProjectsEnableXpnResourceRequest projectsEnableXpnResourceRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            EnableXpnResourceAsync(new EnableXpnResourceProjectRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                ProjectsEnableXpnResourceRequestResource = gax::GaxPreconditions.CheckNotNull(projectsEnableXpnResourceRequestResource, nameof(projectsEnableXpnResourceRequestResource)),
            }, callSettings);

        /// <summary>
        /// Enable service resource (a.k.a service project) for a host project, so that subnets in the host project can be used by instances in the service project.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="projectsEnableXpnResourceRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> EnableXpnResourceAsync(string project, ProjectsEnableXpnResourceRequest projectsEnableXpnResourceRequestResource, st::CancellationToken cancellationToken) =>
            EnableXpnResourceAsync(project, projectsEnableXpnResourceRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified Project resource. To decrease latency for this method, you can optionally omit any unneeded information from the response by using a field mask. This practice is especially recommended for unused quota information (the `quotas` field). To exclude one or more fields, set your request's `fields` query parameter to only include the fields you need. For example, to only include the `id` and `selfLink` fields, add the query parameter `?fields=id,selfLink` to your request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Project Get(GetProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified Project resource. To decrease latency for this method, you can optionally omit any unneeded information from the response by using a field mask. This practice is especially recommended for unused quota information (the `quotas` field). To exclude one or more fields, set your request's `fields` query parameter to only include the fields you need. For example, to only include the `id` and `selfLink` fields, add the query parameter `?fields=id,selfLink` to your request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Project> GetAsync(GetProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the specified Project resource. To decrease latency for this method, you can optionally omit any unneeded information from the response by using a field mask. This practice is especially recommended for unused quota information (the `quotas` field). To exclude one or more fields, set your request's `fields` query parameter to only include the fields you need. For example, to only include the `id` and `selfLink` fields, add the query parameter `?fields=id,selfLink` to your request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Project> GetAsync(GetProjectRequest request, st::CancellationToken cancellationToken) =>
            GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the specified Project resource. To decrease latency for this method, you can optionally omit any unneeded information from the response by using a field mask. This practice is especially recommended for unused quota information (the `quotas` field). To exclude one or more fields, set your request's `fields` query parameter to only include the fields you need. For example, to only include the `id` and `selfLink` fields, add the query parameter `?fields=id,selfLink` to your request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Project Get(string project, gaxgrpc::CallSettings callSettings = null) =>
            Get(new GetProjectRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Returns the specified Project resource. To decrease latency for this method, you can optionally omit any unneeded information from the response by using a field mask. This practice is especially recommended for unused quota information (the `quotas` field). To exclude one or more fields, set your request's `fields` query parameter to only include the fields you need. For example, to only include the `id` and `selfLink` fields, add the query parameter `?fields=id,selfLink` to your request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Project> GetAsync(string project, gaxgrpc::CallSettings callSettings = null) =>
            GetAsync(new GetProjectRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Returns the specified Project resource. To decrease latency for this method, you can optionally omit any unneeded information from the response by using a field mask. This practice is especially recommended for unused quota information (the `quotas` field). To exclude one or more fields, set your request's `fields` query parameter to only include the fields you need. For example, to only include the `id` and `selfLink` fields, add the query parameter `?fields=id,selfLink` to your request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Project> GetAsync(string project, st::CancellationToken cancellationToken) =>
            GetAsync(project, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the shared VPC host project that this project links to. May be empty if no link exists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Project GetXpnHost(GetXpnHostProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the shared VPC host project that this project links to. May be empty if no link exists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Project> GetXpnHostAsync(GetXpnHostProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the shared VPC host project that this project links to. May be empty if no link exists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Project> GetXpnHostAsync(GetXpnHostProjectRequest request, st::CancellationToken cancellationToken) =>
            GetXpnHostAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the shared VPC host project that this project links to. May be empty if no link exists.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Project GetXpnHost(string project, gaxgrpc::CallSettings callSettings = null) =>
            GetXpnHost(new GetXpnHostProjectRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Gets the shared VPC host project that this project links to. May be empty if no link exists.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Project> GetXpnHostAsync(string project, gaxgrpc::CallSettings callSettings = null) =>
            GetXpnHostAsync(new GetXpnHostProjectRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Gets the shared VPC host project that this project links to. May be empty if no link exists.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Project> GetXpnHostAsync(string project, st::CancellationToken cancellationToken) =>
            GetXpnHostAsync(project, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets service resources (a.k.a service project) associated with this host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="XpnResourceId"/> resources.</returns>
        public virtual gax::PagedEnumerable<ProjectsGetXpnResources, XpnResourceId> GetXpnResources(GetXpnResourcesProjectsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets service resources (a.k.a service project) associated with this host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="XpnResourceId"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ProjectsGetXpnResources, XpnResourceId> GetXpnResourcesAsync(GetXpnResourcesProjectsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets service resources (a.k.a service project) associated with this host project.
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
        /// <returns>A pageable sequence of <see cref="XpnResourceId"/> resources.</returns>
        public virtual gax::PagedEnumerable<ProjectsGetXpnResources, XpnResourceId> GetXpnResources(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            GetXpnResourcesProjectsRequest request = new GetXpnResourcesProjectsRequest
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
            return GetXpnResources(request, callSettings);
        }

        /// <summary>
        /// Gets service resources (a.k.a service project) associated with this host project.
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
        /// <returns>A pageable asynchronous sequence of <see cref="XpnResourceId"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ProjectsGetXpnResources, XpnResourceId> GetXpnResourcesAsync(string project, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            GetXpnResourcesProjectsRequest request = new GetXpnResourcesProjectsRequest
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
            return GetXpnResourcesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all shared VPC host projects visible to the user in an organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Project"/> resources.</returns>
        public virtual gax::PagedEnumerable<XpnHostList, Project> ListXpnHosts(ListXpnHostsProjectsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all shared VPC host projects visible to the user in an organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Project"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<XpnHostList, Project> ListXpnHostsAsync(ListXpnHostsProjectsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all shared VPC host projects visible to the user in an organization.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="projectsListXpnHostsRequestResource">
        /// The body resource for this request
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
        /// <returns>A pageable sequence of <see cref="Project"/> resources.</returns>
        public virtual gax::PagedEnumerable<XpnHostList, Project> ListXpnHosts(string project, ProjectsListXpnHostsRequest projectsListXpnHostsRequestResource, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListXpnHostsProjectsRequest request = new ListXpnHostsProjectsRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                ProjectsListXpnHostsRequestResource = gax::GaxPreconditions.CheckNotNull(projectsListXpnHostsRequestResource, nameof(projectsListXpnHostsRequestResource)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListXpnHosts(request, callSettings);
        }

        /// <summary>
        /// Lists all shared VPC host projects visible to the user in an organization.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="projectsListXpnHostsRequestResource">
        /// The body resource for this request
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
        /// <returns>A pageable asynchronous sequence of <see cref="Project"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<XpnHostList, Project> ListXpnHostsAsync(string project, ProjectsListXpnHostsRequest projectsListXpnHostsRequestResource, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListXpnHostsProjectsRequest request = new ListXpnHostsProjectsRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                ProjectsListXpnHostsRequestResource = gax::GaxPreconditions.CheckNotNull(projectsListXpnHostsRequestResource, nameof(projectsListXpnHostsRequestResource)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListXpnHostsAsync(request, callSettings);
        }

        /// <summary>
        /// Moves a persistent disk from one zone to another.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> MoveDisk(MoveDiskProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Moves a persistent disk from one zone to another.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> MoveDiskAsync(MoveDiskProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Moves a persistent disk from one zone to another.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> MoveDiskAsync(MoveDiskProjectRequest request, st::CancellationToken cancellationToken) =>
            MoveDiskAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>MoveDisk</c>.</summary>
        public virtual lro::OperationsClient MoveDiskOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>MoveDisk</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceMoveDisk(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), MoveDiskOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>MoveDisk</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceMoveDiskAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), MoveDiskOperationsClient, callSettings);

        /// <summary>
        /// Moves a persistent disk from one zone to another.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="diskMoveRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> MoveDisk(string project, DiskMoveRequest diskMoveRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            MoveDisk(new MoveDiskProjectRequest
            {
                DiskMoveRequestResource = gax::GaxPreconditions.CheckNotNull(diskMoveRequestResource, nameof(diskMoveRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Moves a persistent disk from one zone to another.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="diskMoveRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> MoveDiskAsync(string project, DiskMoveRequest diskMoveRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            MoveDiskAsync(new MoveDiskProjectRequest
            {
                DiskMoveRequestResource = gax::GaxPreconditions.CheckNotNull(diskMoveRequestResource, nameof(diskMoveRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Moves a persistent disk from one zone to another.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="diskMoveRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> MoveDiskAsync(string project, DiskMoveRequest diskMoveRequestResource, st::CancellationToken cancellationToken) =>
            MoveDiskAsync(project, diskMoveRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Moves an instance and its attached persistent disks from one zone to another. *Note*: Moving VMs or disks by using this method might cause unexpected behavior. For more information, see the [known issue](/compute/docs/troubleshooting/known-issues#moving_vms_or_disks_using_the_moveinstance_api_or_the_causes_unexpected_behavior). [Deprecated] This method is deprecated. See [moving instance across zones](/compute/docs/instances/moving-instance-across-zones) instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> MoveInstance(MoveInstanceProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Moves an instance and its attached persistent disks from one zone to another. *Note*: Moving VMs or disks by using this method might cause unexpected behavior. For more information, see the [known issue](/compute/docs/troubleshooting/known-issues#moving_vms_or_disks_using_the_moveinstance_api_or_the_causes_unexpected_behavior). [Deprecated] This method is deprecated. See [moving instance across zones](/compute/docs/instances/moving-instance-across-zones) instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> MoveInstanceAsync(MoveInstanceProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Moves an instance and its attached persistent disks from one zone to another. *Note*: Moving VMs or disks by using this method might cause unexpected behavior. For more information, see the [known issue](/compute/docs/troubleshooting/known-issues#moving_vms_or_disks_using_the_moveinstance_api_or_the_causes_unexpected_behavior). [Deprecated] This method is deprecated. See [moving instance across zones](/compute/docs/instances/moving-instance-across-zones) instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> MoveInstanceAsync(MoveInstanceProjectRequest request, st::CancellationToken cancellationToken) =>
            MoveInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>MoveInstance</c>.</summary>
        public virtual lro::OperationsClient MoveInstanceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>MoveInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceMoveInstance(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), MoveInstanceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>MoveInstance</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceMoveInstanceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), MoveInstanceOperationsClient, callSettings);

        /// <summary>
        /// Moves an instance and its attached persistent disks from one zone to another. *Note*: Moving VMs or disks by using this method might cause unexpected behavior. For more information, see the [known issue](/compute/docs/troubleshooting/known-issues#moving_vms_or_disks_using_the_moveinstance_api_or_the_causes_unexpected_behavior). [Deprecated] This method is deprecated. See [moving instance across zones](/compute/docs/instances/moving-instance-across-zones) instead.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="instanceMoveRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> MoveInstance(string project, InstanceMoveRequest instanceMoveRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            MoveInstance(new MoveInstanceProjectRequest
            {
                InstanceMoveRequestResource = gax::GaxPreconditions.CheckNotNull(instanceMoveRequestResource, nameof(instanceMoveRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Moves an instance and its attached persistent disks from one zone to another. *Note*: Moving VMs or disks by using this method might cause unexpected behavior. For more information, see the [known issue](/compute/docs/troubleshooting/known-issues#moving_vms_or_disks_using_the_moveinstance_api_or_the_causes_unexpected_behavior). [Deprecated] This method is deprecated. See [moving instance across zones](/compute/docs/instances/moving-instance-across-zones) instead.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="instanceMoveRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> MoveInstanceAsync(string project, InstanceMoveRequest instanceMoveRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            MoveInstanceAsync(new MoveInstanceProjectRequest
            {
                InstanceMoveRequestResource = gax::GaxPreconditions.CheckNotNull(instanceMoveRequestResource, nameof(instanceMoveRequestResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Moves an instance and its attached persistent disks from one zone to another. *Note*: Moving VMs or disks by using this method might cause unexpected behavior. For more information, see the [known issue](/compute/docs/troubleshooting/known-issues#moving_vms_or_disks_using_the_moveinstance_api_or_the_causes_unexpected_behavior). [Deprecated] This method is deprecated. See [moving instance across zones](/compute/docs/instances/moving-instance-across-zones) instead.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="instanceMoveRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> MoveInstanceAsync(string project, InstanceMoveRequest instanceMoveRequestResource, st::CancellationToken cancellationToken) =>
            MoveInstanceAsync(project, instanceMoveRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the Cloud Armor tier of the project. To set ENTERPRISE or above the billing account of the project must be subscribed to Cloud Armor Enterprise. See Subscribing to Cloud Armor Enterprise for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetCloudArmorTier(SetCloudArmorTierProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the Cloud Armor tier of the project. To set ENTERPRISE or above the billing account of the project must be subscribed to Cloud Armor Enterprise. See Subscribing to Cloud Armor Enterprise for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetCloudArmorTierAsync(SetCloudArmorTierProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the Cloud Armor tier of the project. To set ENTERPRISE or above the billing account of the project must be subscribed to Cloud Armor Enterprise. See Subscribing to Cloud Armor Enterprise for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetCloudArmorTierAsync(SetCloudArmorTierProjectRequest request, st::CancellationToken cancellationToken) =>
            SetCloudArmorTierAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SetCloudArmorTier</c>.</summary>
        public virtual lro::OperationsClient SetCloudArmorTierOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SetCloudArmorTier</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceSetCloudArmorTier(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetCloudArmorTierOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetCloudArmorTier</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceSetCloudArmorTierAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetCloudArmorTierOperationsClient, callSettings);

        /// <summary>
        /// Sets the Cloud Armor tier of the project. To set ENTERPRISE or above the billing account of the project must be subscribed to Cloud Armor Enterprise. See Subscribing to Cloud Armor Enterprise for more information.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="projectsSetCloudArmorTierRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetCloudArmorTier(string project, ProjectsSetCloudArmorTierRequest projectsSetCloudArmorTierRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetCloudArmorTier(new SetCloudArmorTierProjectRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                ProjectsSetCloudArmorTierRequestResource = gax::GaxPreconditions.CheckNotNull(projectsSetCloudArmorTierRequestResource, nameof(projectsSetCloudArmorTierRequestResource)),
            }, callSettings);

        /// <summary>
        /// Sets the Cloud Armor tier of the project. To set ENTERPRISE or above the billing account of the project must be subscribed to Cloud Armor Enterprise. See Subscribing to Cloud Armor Enterprise for more information.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="projectsSetCloudArmorTierRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetCloudArmorTierAsync(string project, ProjectsSetCloudArmorTierRequest projectsSetCloudArmorTierRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetCloudArmorTierAsync(new SetCloudArmorTierProjectRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                ProjectsSetCloudArmorTierRequestResource = gax::GaxPreconditions.CheckNotNull(projectsSetCloudArmorTierRequestResource, nameof(projectsSetCloudArmorTierRequestResource)),
            }, callSettings);

        /// <summary>
        /// Sets the Cloud Armor tier of the project. To set ENTERPRISE or above the billing account of the project must be subscribed to Cloud Armor Enterprise. See Subscribing to Cloud Armor Enterprise for more information.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="projectsSetCloudArmorTierRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetCloudArmorTierAsync(string project, ProjectsSetCloudArmorTierRequest projectsSetCloudArmorTierRequestResource, st::CancellationToken cancellationToken) =>
            SetCloudArmorTierAsync(project, projectsSetCloudArmorTierRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets metadata common to all instances within the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetCommonInstanceMetadata(SetCommonInstanceMetadataProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets metadata common to all instances within the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetCommonInstanceMetadataAsync(SetCommonInstanceMetadataProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets metadata common to all instances within the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetCommonInstanceMetadataAsync(SetCommonInstanceMetadataProjectRequest request, st::CancellationToken cancellationToken) =>
            SetCommonInstanceMetadataAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SetCommonInstanceMetadata</c>.</summary>
        public virtual lro::OperationsClient SetCommonInstanceMetadataOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetCommonInstanceMetadata</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceSetCommonInstanceMetadata(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetCommonInstanceMetadataOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetCommonInstanceMetadata</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceSetCommonInstanceMetadataAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetCommonInstanceMetadataOperationsClient, callSettings);

        /// <summary>
        /// Sets metadata common to all instances within the specified project using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="metadataResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetCommonInstanceMetadata(string project, Metadata metadataResource, gaxgrpc::CallSettings callSettings = null) =>
            SetCommonInstanceMetadata(new SetCommonInstanceMetadataProjectRequest
            {
                MetadataResource = gax::GaxPreconditions.CheckNotNull(metadataResource, nameof(metadataResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Sets metadata common to all instances within the specified project using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="metadataResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetCommonInstanceMetadataAsync(string project, Metadata metadataResource, gaxgrpc::CallSettings callSettings = null) =>
            SetCommonInstanceMetadataAsync(new SetCommonInstanceMetadataProjectRequest
            {
                MetadataResource = gax::GaxPreconditions.CheckNotNull(metadataResource, nameof(metadataResource)),
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
            }, callSettings);

        /// <summary>
        /// Sets metadata common to all instances within the specified project using the data included in the request.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="metadataResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetCommonInstanceMetadataAsync(string project, Metadata metadataResource, st::CancellationToken cancellationToken) =>
            SetCommonInstanceMetadataAsync(project, metadataResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Sets the default network tier of the project. The default network tier is used when an address/forwardingRule/instance is created without specifying the network tier field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetDefaultNetworkTier(SetDefaultNetworkTierProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the default network tier of the project. The default network tier is used when an address/forwardingRule/instance is created without specifying the network tier field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetDefaultNetworkTierAsync(SetDefaultNetworkTierProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Sets the default network tier of the project. The default network tier is used when an address/forwardingRule/instance is created without specifying the network tier field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetDefaultNetworkTierAsync(SetDefaultNetworkTierProjectRequest request, st::CancellationToken cancellationToken) =>
            SetDefaultNetworkTierAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SetDefaultNetworkTier</c>.</summary>
        public virtual lro::OperationsClient SetDefaultNetworkTierOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SetDefaultNetworkTier</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceSetDefaultNetworkTier(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetDefaultNetworkTierOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetDefaultNetworkTier</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceSetDefaultNetworkTierAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetDefaultNetworkTierOperationsClient, callSettings);

        /// <summary>
        /// Sets the default network tier of the project. The default network tier is used when an address/forwardingRule/instance is created without specifying the network tier field.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="projectsSetDefaultNetworkTierRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetDefaultNetworkTier(string project, ProjectsSetDefaultNetworkTierRequest projectsSetDefaultNetworkTierRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetDefaultNetworkTier(new SetDefaultNetworkTierProjectRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                ProjectsSetDefaultNetworkTierRequestResource = gax::GaxPreconditions.CheckNotNull(projectsSetDefaultNetworkTierRequestResource, nameof(projectsSetDefaultNetworkTierRequestResource)),
            }, callSettings);

        /// <summary>
        /// Sets the default network tier of the project. The default network tier is used when an address/forwardingRule/instance is created without specifying the network tier field.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="projectsSetDefaultNetworkTierRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetDefaultNetworkTierAsync(string project, ProjectsSetDefaultNetworkTierRequest projectsSetDefaultNetworkTierRequestResource, gaxgrpc::CallSettings callSettings = null) =>
            SetDefaultNetworkTierAsync(new SetDefaultNetworkTierProjectRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                ProjectsSetDefaultNetworkTierRequestResource = gax::GaxPreconditions.CheckNotNull(projectsSetDefaultNetworkTierRequestResource, nameof(projectsSetDefaultNetworkTierRequestResource)),
            }, callSettings);

        /// <summary>
        /// Sets the default network tier of the project. The default network tier is used when an address/forwardingRule/instance is created without specifying the network tier field.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="projectsSetDefaultNetworkTierRequestResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetDefaultNetworkTierAsync(string project, ProjectsSetDefaultNetworkTierRequest projectsSetDefaultNetworkTierRequestResource, st::CancellationToken cancellationToken) =>
            SetDefaultNetworkTierAsync(project, projectsSetDefaultNetworkTierRequestResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Enables the usage export feature and sets the usage export bucket where reports are stored. If you provide an empty request body using this method, the usage export feature will be disabled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetUsageExportBucket(SetUsageExportBucketProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enables the usage export feature and sets the usage export bucket where reports are stored. If you provide an empty request body using this method, the usage export feature will be disabled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetUsageExportBucketAsync(SetUsageExportBucketProjectRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enables the usage export feature and sets the usage export bucket where reports are stored. If you provide an empty request body using this method, the usage export feature will be disabled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetUsageExportBucketAsync(SetUsageExportBucketProjectRequest request, st::CancellationToken cancellationToken) =>
            SetUsageExportBucketAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SetUsageExportBucket</c>.</summary>
        public virtual lro::OperationsClient SetUsageExportBucketOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SetUsageExportBucket</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operation, Operation> PollOnceSetUsageExportBucket(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetUsageExportBucketOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetUsageExportBucket</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> PollOnceSetUsageExportBucketAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operation, Operation>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetUsageExportBucketOperationsClient, callSettings);

        /// <summary>
        /// Enables the usage export feature and sets the usage export bucket where reports are stored. If you provide an empty request body using this method, the usage export feature will be disabled.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="usageExportLocationResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operation, Operation> SetUsageExportBucket(string project, UsageExportLocation usageExportLocationResource, gaxgrpc::CallSettings callSettings = null) =>
            SetUsageExportBucket(new SetUsageExportBucketProjectRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                UsageExportLocationResource = gax::GaxPreconditions.CheckNotNull(usageExportLocationResource, nameof(usageExportLocationResource)),
            }, callSettings);

        /// <summary>
        /// Enables the usage export feature and sets the usage export bucket where reports are stored. If you provide an empty request body using this method, the usage export feature will be disabled.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="usageExportLocationResource">
        /// The body resource for this request
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetUsageExportBucketAsync(string project, UsageExportLocation usageExportLocationResource, gaxgrpc::CallSettings callSettings = null) =>
            SetUsageExportBucketAsync(new SetUsageExportBucketProjectRequest
            {
                Project = gax::GaxPreconditions.CheckNotNullOrEmpty(project, nameof(project)),
                UsageExportLocationResource = gax::GaxPreconditions.CheckNotNull(usageExportLocationResource, nameof(usageExportLocationResource)),
            }, callSettings);

        /// <summary>
        /// Enables the usage export feature and sets the usage export bucket where reports are stored. If you provide an empty request body using this method, the usage export feature will be disabled.
        /// </summary>
        /// <param name="project">
        /// Project ID for this request.
        /// </param>
        /// <param name="usageExportLocationResource">
        /// The body resource for this request
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operation, Operation>> SetUsageExportBucketAsync(string project, UsageExportLocation usageExportLocationResource, st::CancellationToken cancellationToken) =>
            SetUsageExportBucketAsync(project, usageExportLocationResource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Projects client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The Projects API.
    /// </remarks>
    public sealed partial class ProjectsClientImpl : ProjectsClient
    {
        private readonly gaxgrpc::ApiCall<DisableXpnHostProjectRequest, Operation> _callDisableXpnHost;

        private readonly gaxgrpc::ApiCall<DisableXpnResourceProjectRequest, Operation> _callDisableXpnResource;

        private readonly gaxgrpc::ApiCall<EnableXpnHostProjectRequest, Operation> _callEnableXpnHost;

        private readonly gaxgrpc::ApiCall<EnableXpnResourceProjectRequest, Operation> _callEnableXpnResource;

        private readonly gaxgrpc::ApiCall<GetProjectRequest, Project> _callGet;

        private readonly gaxgrpc::ApiCall<GetXpnHostProjectRequest, Project> _callGetXpnHost;

        private readonly gaxgrpc::ApiCall<GetXpnResourcesProjectsRequest, ProjectsGetXpnResources> _callGetXpnResources;

        private readonly gaxgrpc::ApiCall<ListXpnHostsProjectsRequest, XpnHostList> _callListXpnHosts;

        private readonly gaxgrpc::ApiCall<MoveDiskProjectRequest, Operation> _callMoveDisk;

        private readonly gaxgrpc::ApiCall<MoveInstanceProjectRequest, Operation> _callMoveInstance;

        private readonly gaxgrpc::ApiCall<SetCloudArmorTierProjectRequest, Operation> _callSetCloudArmorTier;

        private readonly gaxgrpc::ApiCall<SetCommonInstanceMetadataProjectRequest, Operation> _callSetCommonInstanceMetadata;

        private readonly gaxgrpc::ApiCall<SetDefaultNetworkTierProjectRequest, Operation> _callSetDefaultNetworkTier;

        private readonly gaxgrpc::ApiCall<SetUsageExportBucketProjectRequest, Operation> _callSetUsageExportBucket;

        /// <summary>
        /// Constructs a client wrapper for the Projects service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ProjectsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ProjectsClientImpl(Projects.ProjectsClient grpcClient, ProjectsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ProjectsSettings effectiveSettings = settings ?? ProjectsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            DisableXpnHostOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.DisableXpnHostOperationsSettings, logger);
            DisableXpnResourceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.DisableXpnResourceOperationsSettings, logger);
            EnableXpnHostOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.EnableXpnHostOperationsSettings, logger);
            EnableXpnResourceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.EnableXpnResourceOperationsSettings, logger);
            MoveDiskOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.MoveDiskOperationsSettings, logger);
            MoveInstanceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.MoveInstanceOperationsSettings, logger);
            SetCloudArmorTierOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.SetCloudArmorTierOperationsSettings, logger);
            SetCommonInstanceMetadataOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.SetCommonInstanceMetadataOperationsSettings, logger);
            SetDefaultNetworkTierOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.SetDefaultNetworkTierOperationsSettings, logger);
            SetUsageExportBucketOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClientForGlobalOperations(), effectiveSettings.SetUsageExportBucketOperationsSettings, logger);
            _callDisableXpnHost = clientHelper.BuildApiCall<DisableXpnHostProjectRequest, Operation>("DisableXpnHost", grpcClient.DisableXpnHostAsync, grpcClient.DisableXpnHost, effectiveSettings.DisableXpnHostSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callDisableXpnHost);
            Modify_DisableXpnHostApiCall(ref _callDisableXpnHost);
            _callDisableXpnResource = clientHelper.BuildApiCall<DisableXpnResourceProjectRequest, Operation>("DisableXpnResource", grpcClient.DisableXpnResourceAsync, grpcClient.DisableXpnResource, effectiveSettings.DisableXpnResourceSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callDisableXpnResource);
            Modify_DisableXpnResourceApiCall(ref _callDisableXpnResource);
            _callEnableXpnHost = clientHelper.BuildApiCall<EnableXpnHostProjectRequest, Operation>("EnableXpnHost", grpcClient.EnableXpnHostAsync, grpcClient.EnableXpnHost, effectiveSettings.EnableXpnHostSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callEnableXpnHost);
            Modify_EnableXpnHostApiCall(ref _callEnableXpnHost);
            _callEnableXpnResource = clientHelper.BuildApiCall<EnableXpnResourceProjectRequest, Operation>("EnableXpnResource", grpcClient.EnableXpnResourceAsync, grpcClient.EnableXpnResource, effectiveSettings.EnableXpnResourceSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callEnableXpnResource);
            Modify_EnableXpnResourceApiCall(ref _callEnableXpnResource);
            _callGet = clientHelper.BuildApiCall<GetProjectRequest, Project>("Get", grpcClient.GetAsync, grpcClient.Get, effectiveSettings.GetSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callGet);
            Modify_GetApiCall(ref _callGet);
            _callGetXpnHost = clientHelper.BuildApiCall<GetXpnHostProjectRequest, Project>("GetXpnHost", grpcClient.GetXpnHostAsync, grpcClient.GetXpnHost, effectiveSettings.GetXpnHostSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callGetXpnHost);
            Modify_GetXpnHostApiCall(ref _callGetXpnHost);
            _callGetXpnResources = clientHelper.BuildApiCall<GetXpnResourcesProjectsRequest, ProjectsGetXpnResources>("GetXpnResources", grpcClient.GetXpnResourcesAsync, grpcClient.GetXpnResources, effectiveSettings.GetXpnResourcesSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callGetXpnResources);
            Modify_GetXpnResourcesApiCall(ref _callGetXpnResources);
            _callListXpnHosts = clientHelper.BuildApiCall<ListXpnHostsProjectsRequest, XpnHostList>("ListXpnHosts", grpcClient.ListXpnHostsAsync, grpcClient.ListXpnHosts, effectiveSettings.ListXpnHostsSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callListXpnHosts);
            Modify_ListXpnHostsApiCall(ref _callListXpnHosts);
            _callMoveDisk = clientHelper.BuildApiCall<MoveDiskProjectRequest, Operation>("MoveDisk", grpcClient.MoveDiskAsync, grpcClient.MoveDisk, effectiveSettings.MoveDiskSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callMoveDisk);
            Modify_MoveDiskApiCall(ref _callMoveDisk);
            _callMoveInstance = clientHelper.BuildApiCall<MoveInstanceProjectRequest, Operation>("MoveInstance", grpcClient.MoveInstanceAsync, grpcClient.MoveInstance, effectiveSettings.MoveInstanceSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callMoveInstance);
            Modify_MoveInstanceApiCall(ref _callMoveInstance);
            _callSetCloudArmorTier = clientHelper.BuildApiCall<SetCloudArmorTierProjectRequest, Operation>("SetCloudArmorTier", grpcClient.SetCloudArmorTierAsync, grpcClient.SetCloudArmorTier, effectiveSettings.SetCloudArmorTierSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callSetCloudArmorTier);
            Modify_SetCloudArmorTierApiCall(ref _callSetCloudArmorTier);
            _callSetCommonInstanceMetadata = clientHelper.BuildApiCall<SetCommonInstanceMetadataProjectRequest, Operation>("SetCommonInstanceMetadata", grpcClient.SetCommonInstanceMetadataAsync, grpcClient.SetCommonInstanceMetadata, effectiveSettings.SetCommonInstanceMetadataSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callSetCommonInstanceMetadata);
            Modify_SetCommonInstanceMetadataApiCall(ref _callSetCommonInstanceMetadata);
            _callSetDefaultNetworkTier = clientHelper.BuildApiCall<SetDefaultNetworkTierProjectRequest, Operation>("SetDefaultNetworkTier", grpcClient.SetDefaultNetworkTierAsync, grpcClient.SetDefaultNetworkTier, effectiveSettings.SetDefaultNetworkTierSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callSetDefaultNetworkTier);
            Modify_SetDefaultNetworkTierApiCall(ref _callSetDefaultNetworkTier);
            _callSetUsageExportBucket = clientHelper.BuildApiCall<SetUsageExportBucketProjectRequest, Operation>("SetUsageExportBucket", grpcClient.SetUsageExportBucketAsync, grpcClient.SetUsageExportBucket, effectiveSettings.SetUsageExportBucketSettings).WithGoogleRequestParam("project", request => request.Project);
            Modify_ApiCall(ref _callSetUsageExportBucket);
            Modify_SetUsageExportBucketApiCall(ref _callSetUsageExportBucket);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_DisableXpnHostApiCall(ref gaxgrpc::ApiCall<DisableXpnHostProjectRequest, Operation> call);

        partial void Modify_DisableXpnResourceApiCall(ref gaxgrpc::ApiCall<DisableXpnResourceProjectRequest, Operation> call);

        partial void Modify_EnableXpnHostApiCall(ref gaxgrpc::ApiCall<EnableXpnHostProjectRequest, Operation> call);

        partial void Modify_EnableXpnResourceApiCall(ref gaxgrpc::ApiCall<EnableXpnResourceProjectRequest, Operation> call);

        partial void Modify_GetApiCall(ref gaxgrpc::ApiCall<GetProjectRequest, Project> call);

        partial void Modify_GetXpnHostApiCall(ref gaxgrpc::ApiCall<GetXpnHostProjectRequest, Project> call);

        partial void Modify_GetXpnResourcesApiCall(ref gaxgrpc::ApiCall<GetXpnResourcesProjectsRequest, ProjectsGetXpnResources> call);

        partial void Modify_ListXpnHostsApiCall(ref gaxgrpc::ApiCall<ListXpnHostsProjectsRequest, XpnHostList> call);

        partial void Modify_MoveDiskApiCall(ref gaxgrpc::ApiCall<MoveDiskProjectRequest, Operation> call);

        partial void Modify_MoveInstanceApiCall(ref gaxgrpc::ApiCall<MoveInstanceProjectRequest, Operation> call);

        partial void Modify_SetCloudArmorTierApiCall(ref gaxgrpc::ApiCall<SetCloudArmorTierProjectRequest, Operation> call);

        partial void Modify_SetCommonInstanceMetadataApiCall(ref gaxgrpc::ApiCall<SetCommonInstanceMetadataProjectRequest, Operation> call);

        partial void Modify_SetDefaultNetworkTierApiCall(ref gaxgrpc::ApiCall<SetDefaultNetworkTierProjectRequest, Operation> call);

        partial void Modify_SetUsageExportBucketApiCall(ref gaxgrpc::ApiCall<SetUsageExportBucketProjectRequest, Operation> call);

        partial void OnConstruction(Projects.ProjectsClient grpcClient, ProjectsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Projects client</summary>
        public override Projects.ProjectsClient GrpcClient { get; }

        partial void Modify_DisableXpnHostProjectRequest(ref DisableXpnHostProjectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DisableXpnResourceProjectRequest(ref DisableXpnResourceProjectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_EnableXpnHostProjectRequest(ref EnableXpnHostProjectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_EnableXpnResourceProjectRequest(ref EnableXpnResourceProjectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetProjectRequest(ref GetProjectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetXpnHostProjectRequest(ref GetXpnHostProjectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetXpnResourcesProjectsRequest(ref GetXpnResourcesProjectsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListXpnHostsProjectsRequest(ref ListXpnHostsProjectsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MoveDiskProjectRequest(ref MoveDiskProjectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MoveInstanceProjectRequest(ref MoveInstanceProjectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetCloudArmorTierProjectRequest(ref SetCloudArmorTierProjectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetCommonInstanceMetadataProjectRequest(ref SetCommonInstanceMetadataProjectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetDefaultNetworkTierProjectRequest(ref SetDefaultNetworkTierProjectRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetUsageExportBucketProjectRequest(ref SetUsageExportBucketProjectRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>DisableXpnHost</c>.</summary>
        public override lro::OperationsClient DisableXpnHostOperationsClient { get; }

        /// <summary>
        /// Disable this project as a shared VPC host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> DisableXpnHost(DisableXpnHostProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DisableXpnHostProjectRequest(ref request, ref callSettings);
            Operation response = _callDisableXpnHost.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DisableXpnHostOperationsClient);
        }

        /// <summary>
        /// Disable this project as a shared VPC host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> DisableXpnHostAsync(DisableXpnHostProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DisableXpnHostProjectRequest(ref request, ref callSettings);
            Operation response = await _callDisableXpnHost.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DisableXpnHostOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DisableXpnResource</c>.</summary>
        public override lro::OperationsClient DisableXpnResourceOperationsClient { get; }

        /// <summary>
        /// Disable a service resource (also known as service project) associated with this host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> DisableXpnResource(DisableXpnResourceProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DisableXpnResourceProjectRequest(ref request, ref callSettings);
            Operation response = _callDisableXpnResource.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DisableXpnResourceOperationsClient);
        }

        /// <summary>
        /// Disable a service resource (also known as service project) associated with this host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> DisableXpnResourceAsync(DisableXpnResourceProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DisableXpnResourceProjectRequest(ref request, ref callSettings);
            Operation response = await _callDisableXpnResource.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), DisableXpnResourceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>EnableXpnHost</c>.</summary>
        public override lro::OperationsClient EnableXpnHostOperationsClient { get; }

        /// <summary>
        /// Enable this project as a shared VPC host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> EnableXpnHost(EnableXpnHostProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnableXpnHostProjectRequest(ref request, ref callSettings);
            Operation response = _callEnableXpnHost.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), EnableXpnHostOperationsClient);
        }

        /// <summary>
        /// Enable this project as a shared VPC host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> EnableXpnHostAsync(EnableXpnHostProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnableXpnHostProjectRequest(ref request, ref callSettings);
            Operation response = await _callEnableXpnHost.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), EnableXpnHostOperationsClient);
        }

        /// <summary>The long-running operations client for <c>EnableXpnResource</c>.</summary>
        public override lro::OperationsClient EnableXpnResourceOperationsClient { get; }

        /// <summary>
        /// Enable service resource (a.k.a service project) for a host project, so that subnets in the host project can be used by instances in the service project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> EnableXpnResource(EnableXpnResourceProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnableXpnResourceProjectRequest(ref request, ref callSettings);
            Operation response = _callEnableXpnResource.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), EnableXpnResourceOperationsClient);
        }

        /// <summary>
        /// Enable service resource (a.k.a service project) for a host project, so that subnets in the host project can be used by instances in the service project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> EnableXpnResourceAsync(EnableXpnResourceProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnableXpnResourceProjectRequest(ref request, ref callSettings);
            Operation response = await _callEnableXpnResource.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), EnableXpnResourceOperationsClient);
        }

        /// <summary>
        /// Returns the specified Project resource. To decrease latency for this method, you can optionally omit any unneeded information from the response by using a field mask. This practice is especially recommended for unused quota information (the `quotas` field). To exclude one or more fields, set your request's `fields` query parameter to only include the fields you need. For example, to only include the `id` and `selfLink` fields, add the query parameter `?fields=id,selfLink` to your request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Project Get(GetProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProjectRequest(ref request, ref callSettings);
            return _callGet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the specified Project resource. To decrease latency for this method, you can optionally omit any unneeded information from the response by using a field mask. This practice is especially recommended for unused quota information (the `quotas` field). To exclude one or more fields, set your request's `fields` query parameter to only include the fields you need. For example, to only include the `id` and `selfLink` fields, add the query parameter `?fields=id,selfLink` to your request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Project> GetAsync(GetProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProjectRequest(ref request, ref callSettings);
            return _callGet.Async(request, callSettings);
        }

        /// <summary>
        /// Gets the shared VPC host project that this project links to. May be empty if no link exists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Project GetXpnHost(GetXpnHostProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetXpnHostProjectRequest(ref request, ref callSettings);
            return _callGetXpnHost.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the shared VPC host project that this project links to. May be empty if no link exists.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Project> GetXpnHostAsync(GetXpnHostProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetXpnHostProjectRequest(ref request, ref callSettings);
            return _callGetXpnHost.Async(request, callSettings);
        }

        /// <summary>
        /// Gets service resources (a.k.a service project) associated with this host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="XpnResourceId"/> resources.</returns>
        public override gax::PagedEnumerable<ProjectsGetXpnResources, XpnResourceId> GetXpnResources(GetXpnResourcesProjectsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetXpnResourcesProjectsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<GetXpnResourcesProjectsRequest, ProjectsGetXpnResources, XpnResourceId>(_callGetXpnResources, request, callSettings);
        }

        /// <summary>
        /// Gets service resources (a.k.a service project) associated with this host project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="XpnResourceId"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ProjectsGetXpnResources, XpnResourceId> GetXpnResourcesAsync(GetXpnResourcesProjectsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetXpnResourcesProjectsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<GetXpnResourcesProjectsRequest, ProjectsGetXpnResources, XpnResourceId>(_callGetXpnResources, request, callSettings);
        }

        /// <summary>
        /// Lists all shared VPC host projects visible to the user in an organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Project"/> resources.</returns>
        public override gax::PagedEnumerable<XpnHostList, Project> ListXpnHosts(ListXpnHostsProjectsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListXpnHostsProjectsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListXpnHostsProjectsRequest, XpnHostList, Project>(_callListXpnHosts, request, callSettings);
        }

        /// <summary>
        /// Lists all shared VPC host projects visible to the user in an organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Project"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<XpnHostList, Project> ListXpnHostsAsync(ListXpnHostsProjectsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListXpnHostsProjectsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListXpnHostsProjectsRequest, XpnHostList, Project>(_callListXpnHosts, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>MoveDisk</c>.</summary>
        public override lro::OperationsClient MoveDiskOperationsClient { get; }

        /// <summary>
        /// Moves a persistent disk from one zone to another.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> MoveDisk(MoveDiskProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MoveDiskProjectRequest(ref request, ref callSettings);
            Operation response = _callMoveDisk.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), MoveDiskOperationsClient);
        }

        /// <summary>
        /// Moves a persistent disk from one zone to another.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> MoveDiskAsync(MoveDiskProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MoveDiskProjectRequest(ref request, ref callSettings);
            Operation response = await _callMoveDisk.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), MoveDiskOperationsClient);
        }

        /// <summary>The long-running operations client for <c>MoveInstance</c>.</summary>
        public override lro::OperationsClient MoveInstanceOperationsClient { get; }

        /// <summary>
        /// Moves an instance and its attached persistent disks from one zone to another. *Note*: Moving VMs or disks by using this method might cause unexpected behavior. For more information, see the [known issue](/compute/docs/troubleshooting/known-issues#moving_vms_or_disks_using_the_moveinstance_api_or_the_causes_unexpected_behavior). [Deprecated] This method is deprecated. See [moving instance across zones](/compute/docs/instances/moving-instance-across-zones) instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> MoveInstance(MoveInstanceProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MoveInstanceProjectRequest(ref request, ref callSettings);
            Operation response = _callMoveInstance.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), MoveInstanceOperationsClient);
        }

        /// <summary>
        /// Moves an instance and its attached persistent disks from one zone to another. *Note*: Moving VMs or disks by using this method might cause unexpected behavior. For more information, see the [known issue](/compute/docs/troubleshooting/known-issues#moving_vms_or_disks_using_the_moveinstance_api_or_the_causes_unexpected_behavior). [Deprecated] This method is deprecated. See [moving instance across zones](/compute/docs/instances/moving-instance-across-zones) instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> MoveInstanceAsync(MoveInstanceProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MoveInstanceProjectRequest(ref request, ref callSettings);
            Operation response = await _callMoveInstance.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), MoveInstanceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SetCloudArmorTier</c>.</summary>
        public override lro::OperationsClient SetCloudArmorTierOperationsClient { get; }

        /// <summary>
        /// Sets the Cloud Armor tier of the project. To set ENTERPRISE or above the billing account of the project must be subscribed to Cloud Armor Enterprise. See Subscribing to Cloud Armor Enterprise for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> SetCloudArmorTier(SetCloudArmorTierProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetCloudArmorTierProjectRequest(ref request, ref callSettings);
            Operation response = _callSetCloudArmorTier.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetCloudArmorTierOperationsClient);
        }

        /// <summary>
        /// Sets the Cloud Armor tier of the project. To set ENTERPRISE or above the billing account of the project must be subscribed to Cloud Armor Enterprise. See Subscribing to Cloud Armor Enterprise for more information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> SetCloudArmorTierAsync(SetCloudArmorTierProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetCloudArmorTierProjectRequest(ref request, ref callSettings);
            Operation response = await _callSetCloudArmorTier.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetCloudArmorTierOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SetCommonInstanceMetadata</c>.</summary>
        public override lro::OperationsClient SetCommonInstanceMetadataOperationsClient { get; }

        /// <summary>
        /// Sets metadata common to all instances within the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> SetCommonInstanceMetadata(SetCommonInstanceMetadataProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetCommonInstanceMetadataProjectRequest(ref request, ref callSettings);
            Operation response = _callSetCommonInstanceMetadata.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetCommonInstanceMetadataOperationsClient);
        }

        /// <summary>
        /// Sets metadata common to all instances within the specified project using the data included in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> SetCommonInstanceMetadataAsync(SetCommonInstanceMetadataProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetCommonInstanceMetadataProjectRequest(ref request, ref callSettings);
            Operation response = await _callSetCommonInstanceMetadata.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetCommonInstanceMetadataOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SetDefaultNetworkTier</c>.</summary>
        public override lro::OperationsClient SetDefaultNetworkTierOperationsClient { get; }

        /// <summary>
        /// Sets the default network tier of the project. The default network tier is used when an address/forwardingRule/instance is created without specifying the network tier field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> SetDefaultNetworkTier(SetDefaultNetworkTierProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetDefaultNetworkTierProjectRequest(ref request, ref callSettings);
            Operation response = _callSetDefaultNetworkTier.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetDefaultNetworkTierOperationsClient);
        }

        /// <summary>
        /// Sets the default network tier of the project. The default network tier is used when an address/forwardingRule/instance is created without specifying the network tier field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> SetDefaultNetworkTierAsync(SetDefaultNetworkTierProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetDefaultNetworkTierProjectRequest(ref request, ref callSettings);
            Operation response = await _callSetDefaultNetworkTier.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetDefaultNetworkTierOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SetUsageExportBucket</c>.</summary>
        public override lro::OperationsClient SetUsageExportBucketOperationsClient { get; }

        /// <summary>
        /// Enables the usage export feature and sets the usage export bucket where reports are stored. If you provide an empty request body using this method, the usage export feature will be disabled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operation, Operation> SetUsageExportBucket(SetUsageExportBucketProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetUsageExportBucketProjectRequest(ref request, ref callSettings);
            Operation response = _callSetUsageExportBucket.Sync(request, callSettings);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetUsageExportBucketOperationsClient);
        }

        /// <summary>
        /// Enables the usage export feature and sets the usage export bucket where reports are stored. If you provide an empty request body using this method, the usage export feature will be disabled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operation, Operation>> SetUsageExportBucketAsync(SetUsageExportBucketProjectRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetUsageExportBucketProjectRequest(ref request, ref callSettings);
            Operation response = await _callSetUsageExportBucket.Async(request, callSettings).ConfigureAwait(false);
            GetGlobalOperationRequest pollRequest = GetGlobalOperationRequest.FromInitialResponse(response);
            request.PopulatePollRequestFields(pollRequest);
            return new lro::Operation<Operation, Operation>(response.ToLroResponse(pollRequest.ToLroOperationName()), SetUsageExportBucketOperationsClient);
        }
    }

    public partial class GetXpnResourcesProjectsRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class ListXpnHostsProjectsRequest : gaxgrpc::IPageRequest
    {
        /// <inheritdoc/>
        public int PageSize
        {
            get => checked((int)MaxResults);
            set => MaxResults = checked((uint)value);
        }
    }

    public partial class ProjectsGetXpnResources : gaxgrpc::IPageResponse<XpnResourceId>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<XpnResourceId> GetEnumerator() => Resources.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class XpnHostList : gaxgrpc::IPageResponse<Project>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Project> GetEnumerator() => Items.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Projects
    {
        public partial class ProjectsClient
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
