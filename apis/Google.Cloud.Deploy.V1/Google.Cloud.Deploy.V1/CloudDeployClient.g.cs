// Copyright 2021 Google LLC
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
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using gagr = Google.Api.Gax.ResourceNames;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Deploy.V1
{
    /// <summary>Settings for <see cref="CloudDeployClient"/> instances.</summary>
    public sealed partial class CloudDeploySettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CloudDeploySettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CloudDeploySettings"/>.</returns>
        public static CloudDeploySettings GetDefault() => new CloudDeploySettings();

        /// <summary>Constructs a new <see cref="CloudDeploySettings"/> object with default settings.</summary>
        public CloudDeploySettings()
        {
        }

        private CloudDeploySettings(CloudDeploySettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListDeliveryPipelinesSettings = existing.ListDeliveryPipelinesSettings;
            GetDeliveryPipelineSettings = existing.GetDeliveryPipelineSettings;
            CreateDeliveryPipelineSettings = existing.CreateDeliveryPipelineSettings;
            CreateDeliveryPipelineOperationsSettings = existing.CreateDeliveryPipelineOperationsSettings.Clone();
            UpdateDeliveryPipelineSettings = existing.UpdateDeliveryPipelineSettings;
            UpdateDeliveryPipelineOperationsSettings = existing.UpdateDeliveryPipelineOperationsSettings.Clone();
            DeleteDeliveryPipelineSettings = existing.DeleteDeliveryPipelineSettings;
            DeleteDeliveryPipelineOperationsSettings = existing.DeleteDeliveryPipelineOperationsSettings.Clone();
            ListTargetsSettings = existing.ListTargetsSettings;
            GetTargetSettings = existing.GetTargetSettings;
            CreateTargetSettings = existing.CreateTargetSettings;
            CreateTargetOperationsSettings = existing.CreateTargetOperationsSettings.Clone();
            UpdateTargetSettings = existing.UpdateTargetSettings;
            UpdateTargetOperationsSettings = existing.UpdateTargetOperationsSettings.Clone();
            DeleteTargetSettings = existing.DeleteTargetSettings;
            DeleteTargetOperationsSettings = existing.DeleteTargetOperationsSettings.Clone();
            ListReleasesSettings = existing.ListReleasesSettings;
            GetReleaseSettings = existing.GetReleaseSettings;
            CreateReleaseSettings = existing.CreateReleaseSettings;
            CreateReleaseOperationsSettings = existing.CreateReleaseOperationsSettings.Clone();
            ApproveRolloutSettings = existing.ApproveRolloutSettings;
            ListRolloutsSettings = existing.ListRolloutsSettings;
            GetRolloutSettings = existing.GetRolloutSettings;
            CreateRolloutSettings = existing.CreateRolloutSettings;
            CreateRolloutOperationsSettings = existing.CreateRolloutOperationsSettings.Clone();
            GetConfigSettings = existing.GetConfigSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CloudDeploySettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudDeployClient.ListDeliveryPipelines</c> and <c>CloudDeployClient.ListDeliveryPipelinesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDeliveryPipelinesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudDeployClient.GetDeliveryPipeline</c> and <c>CloudDeployClient.GetDeliveryPipelineAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDeliveryPipelineSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudDeployClient.CreateDeliveryPipeline</c> and <c>CloudDeployClient.CreateDeliveryPipelineAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDeliveryPipelineSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudDeployClient.CreateDeliveryPipeline</c> and
        /// <c>CloudDeployClient.CreateDeliveryPipelineAsync</c>.
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
        public lro::OperationsSettings CreateDeliveryPipelineOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudDeployClient.UpdateDeliveryPipeline</c> and <c>CloudDeployClient.UpdateDeliveryPipelineAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDeliveryPipelineSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudDeployClient.UpdateDeliveryPipeline</c> and
        /// <c>CloudDeployClient.UpdateDeliveryPipelineAsync</c>.
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
        public lro::OperationsSettings UpdateDeliveryPipelineOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudDeployClient.DeleteDeliveryPipeline</c> and <c>CloudDeployClient.DeleteDeliveryPipelineAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDeliveryPipelineSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudDeployClient.DeleteDeliveryPipeline</c> and
        /// <c>CloudDeployClient.DeleteDeliveryPipelineAsync</c>.
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
        public lro::OperationsSettings DeleteDeliveryPipelineOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudDeployClient.ListTargets</c> and <c>CloudDeployClient.ListTargetsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTargetsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>CloudDeployClient.GetTarget</c>
        ///  and <c>CloudDeployClient.GetTargetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTargetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudDeployClient.CreateTarget</c> and <c>CloudDeployClient.CreateTargetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTargetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudDeployClient.CreateTarget</c> and
        /// <c>CloudDeployClient.CreateTargetAsync</c>.
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
        public lro::OperationsSettings CreateTargetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudDeployClient.UpdateTarget</c> and <c>CloudDeployClient.UpdateTargetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateTargetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudDeployClient.UpdateTarget</c> and
        /// <c>CloudDeployClient.UpdateTargetAsync</c>.
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
        public lro::OperationsSettings UpdateTargetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudDeployClient.DeleteTarget</c> and <c>CloudDeployClient.DeleteTargetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTargetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudDeployClient.DeleteTarget</c> and
        /// <c>CloudDeployClient.DeleteTargetAsync</c>.
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
        public lro::OperationsSettings DeleteTargetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudDeployClient.ListReleases</c> and <c>CloudDeployClient.ListReleasesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListReleasesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudDeployClient.GetRelease</c> and <c>CloudDeployClient.GetReleaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetReleaseSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudDeployClient.CreateRelease</c> and <c>CloudDeployClient.CreateReleaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateReleaseSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudDeployClient.CreateRelease</c> and
        /// <c>CloudDeployClient.CreateReleaseAsync</c>.
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
        public lro::OperationsSettings CreateReleaseOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudDeployClient.ApproveRollout</c> and <c>CloudDeployClient.ApproveRolloutAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ApproveRolloutSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudDeployClient.ListRollouts</c> and <c>CloudDeployClient.ListRolloutsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListRolloutsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudDeployClient.GetRollout</c> and <c>CloudDeployClient.GetRolloutAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetRolloutSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudDeployClient.CreateRollout</c> and <c>CloudDeployClient.CreateRolloutAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateRolloutSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudDeployClient.CreateRollout</c> and
        /// <c>CloudDeployClient.CreateRolloutAsync</c>.
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
        public lro::OperationsSettings CreateRolloutOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>CloudDeployClient.GetConfig</c>
        ///  and <c>CloudDeployClient.GetConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CloudDeploySettings"/> object.</returns>
        public CloudDeploySettings Clone() => new CloudDeploySettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CloudDeployClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class CloudDeployClientBuilder : gaxgrpc::ClientBuilderBase<CloudDeployClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CloudDeploySettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CloudDeployClientBuilder()
        {
            UseJwtAccessWithScopes = CloudDeployClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref CloudDeployClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CloudDeployClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CloudDeployClient Build()
        {
            CloudDeployClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CloudDeployClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CloudDeployClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CloudDeployClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CloudDeployClient.Create(callInvoker, Settings);
        }

        private async stt::Task<CloudDeployClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CloudDeployClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => CloudDeployClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => CloudDeployClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CloudDeployClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>CloudDeploy client wrapper, for convenient use.</summary>
    /// <remarks>
    /// CloudDeploy service creates and manages Continuous Delivery operations
    /// on Google Cloud Platform via Skaffold (https://skaffold.dev).
    /// </remarks>
    public abstract partial class CloudDeployClient
    {
        /// <summary>
        /// The default endpoint for the CloudDeploy service, which is a host of "clouddeploy.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "clouddeploy.googleapis.com:443";

        /// <summary>The default CloudDeploy scopes.</summary>
        /// <remarks>
        /// The default CloudDeploy scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes, UseJwtAccessWithScopes);

        internal static bool UseJwtAccessWithScopes
        {
            get
            {
                bool useJwtAccessWithScopes = true;
                MaybeUseJwtAccessWithScopes(ref useJwtAccessWithScopes);
                return useJwtAccessWithScopes;
            }
        }

        static partial void MaybeUseJwtAccessWithScopes(ref bool useJwtAccessWithScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="CloudDeployClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CloudDeployClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CloudDeployClient"/>.</returns>
        public static stt::Task<CloudDeployClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CloudDeployClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CloudDeployClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CloudDeployClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CloudDeployClient"/>.</returns>
        public static CloudDeployClient Create() => new CloudDeployClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CloudDeployClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CloudDeploySettings"/>.</param>
        /// <returns>The created <see cref="CloudDeployClient"/>.</returns>
        internal static CloudDeployClient Create(grpccore::CallInvoker callInvoker, CloudDeploySettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CloudDeploy.CloudDeployClient grpcClient = new CloudDeploy.CloudDeployClient(callInvoker);
            return new CloudDeployClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC CloudDeploy client</summary>
        public virtual CloudDeploy.CloudDeployClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists DeliveryPipelines in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DeliveryPipeline"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeliveryPipelinesResponse, DeliveryPipeline> ListDeliveryPipelines(ListDeliveryPipelinesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists DeliveryPipelines in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DeliveryPipeline"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeliveryPipelinesResponse, DeliveryPipeline> ListDeliveryPipelinesAsync(ListDeliveryPipelinesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists DeliveryPipelines in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of pipelines. Format must be
        /// projects/{project_id}/locations/{location_name}.
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
        /// <returns>A pageable sequence of <see cref="DeliveryPipeline"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeliveryPipelinesResponse, DeliveryPipeline> ListDeliveryPipelines(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDeliveryPipelines(new ListDeliveryPipelinesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists DeliveryPipelines in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of pipelines. Format must be
        /// projects/{project_id}/locations/{location_name}.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DeliveryPipeline"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeliveryPipelinesResponse, DeliveryPipeline> ListDeliveryPipelinesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDeliveryPipelinesAsync(new ListDeliveryPipelinesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists DeliveryPipelines in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of pipelines. Format must be
        /// projects/{project_id}/locations/{location_name}.
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
        /// <returns>A pageable sequence of <see cref="DeliveryPipeline"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeliveryPipelinesResponse, DeliveryPipeline> ListDeliveryPipelines(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDeliveryPipelines(new ListDeliveryPipelinesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists DeliveryPipelines in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of pipelines. Format must be
        /// projects/{project_id}/locations/{location_name}.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DeliveryPipeline"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeliveryPipelinesResponse, DeliveryPipeline> ListDeliveryPipelinesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDeliveryPipelinesAsync(new ListDeliveryPipelinesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets details of a single DeliveryPipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeliveryPipeline GetDeliveryPipeline(GetDeliveryPipelineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single DeliveryPipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeliveryPipeline> GetDeliveryPipelineAsync(GetDeliveryPipelineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single DeliveryPipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeliveryPipeline> GetDeliveryPipelineAsync(GetDeliveryPipelineRequest request, st::CancellationToken cancellationToken) =>
            GetDeliveryPipelineAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single DeliveryPipeline.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `DeliveryPipeline`. Format must be
        /// projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeliveryPipeline GetDeliveryPipeline(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeliveryPipeline(new GetDeliveryPipelineRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single DeliveryPipeline.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `DeliveryPipeline`. Format must be
        /// projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeliveryPipeline> GetDeliveryPipelineAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeliveryPipelineAsync(new GetDeliveryPipelineRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single DeliveryPipeline.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `DeliveryPipeline`. Format must be
        /// projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeliveryPipeline> GetDeliveryPipelineAsync(string name, st::CancellationToken cancellationToken) =>
            GetDeliveryPipelineAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single DeliveryPipeline.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `DeliveryPipeline`. Format must be
        /// projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeliveryPipeline GetDeliveryPipeline(DeliveryPipelineName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeliveryPipeline(new GetDeliveryPipelineRequest
            {
                DeliveryPipelineName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single DeliveryPipeline.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `DeliveryPipeline`. Format must be
        /// projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeliveryPipeline> GetDeliveryPipelineAsync(DeliveryPipelineName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeliveryPipelineAsync(new GetDeliveryPipelineRequest
            {
                DeliveryPipelineName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single DeliveryPipeline.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `DeliveryPipeline`. Format must be
        /// projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeliveryPipeline> GetDeliveryPipelineAsync(DeliveryPipelineName name, st::CancellationToken cancellationToken) =>
            GetDeliveryPipelineAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new DeliveryPipeline in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeliveryPipeline, OperationMetadata> CreateDeliveryPipeline(CreateDeliveryPipelineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new DeliveryPipeline in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeliveryPipeline, OperationMetadata>> CreateDeliveryPipelineAsync(CreateDeliveryPipelineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new DeliveryPipeline in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeliveryPipeline, OperationMetadata>> CreateDeliveryPipelineAsync(CreateDeliveryPipelineRequest request, st::CancellationToken cancellationToken) =>
            CreateDeliveryPipelineAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateDeliveryPipeline</c>.</summary>
        public virtual lro::OperationsClient CreateDeliveryPipelineOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateDeliveryPipeline</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DeliveryPipeline, OperationMetadata> PollOnceCreateDeliveryPipeline(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DeliveryPipeline, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDeliveryPipelineOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateDeliveryPipeline</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DeliveryPipeline, OperationMetadata>> PollOnceCreateDeliveryPipelineAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DeliveryPipeline, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDeliveryPipelineOperationsClient, callSettings);

        /// <summary>
        /// Creates a new DeliveryPipeline in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `DeliveryPipeline` should be created.
        /// Format should be projects/{project_id}/locations/{location_name}.
        /// </param>
        /// <param name="deliveryPipeline">
        /// Required. The `DeliveryPipeline` to create.
        /// </param>
        /// <param name="deliveryPipelineId">
        /// Required. ID of the `DeliveryPipeline`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeliveryPipeline, OperationMetadata> CreateDeliveryPipeline(string parent, DeliveryPipeline deliveryPipeline, string deliveryPipelineId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeliveryPipeline(new CreateDeliveryPipelineRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DeliveryPipelineId = gax::GaxPreconditions.CheckNotNullOrEmpty(deliveryPipelineId, nameof(deliveryPipelineId)),
                DeliveryPipeline = gax::GaxPreconditions.CheckNotNull(deliveryPipeline, nameof(deliveryPipeline)),
            }, callSettings);

        /// <summary>
        /// Creates a new DeliveryPipeline in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `DeliveryPipeline` should be created.
        /// Format should be projects/{project_id}/locations/{location_name}.
        /// </param>
        /// <param name="deliveryPipeline">
        /// Required. The `DeliveryPipeline` to create.
        /// </param>
        /// <param name="deliveryPipelineId">
        /// Required. ID of the `DeliveryPipeline`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeliveryPipeline, OperationMetadata>> CreateDeliveryPipelineAsync(string parent, DeliveryPipeline deliveryPipeline, string deliveryPipelineId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeliveryPipelineAsync(new CreateDeliveryPipelineRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DeliveryPipelineId = gax::GaxPreconditions.CheckNotNullOrEmpty(deliveryPipelineId, nameof(deliveryPipelineId)),
                DeliveryPipeline = gax::GaxPreconditions.CheckNotNull(deliveryPipeline, nameof(deliveryPipeline)),
            }, callSettings);

        /// <summary>
        /// Creates a new DeliveryPipeline in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `DeliveryPipeline` should be created.
        /// Format should be projects/{project_id}/locations/{location_name}.
        /// </param>
        /// <param name="deliveryPipeline">
        /// Required. The `DeliveryPipeline` to create.
        /// </param>
        /// <param name="deliveryPipelineId">
        /// Required. ID of the `DeliveryPipeline`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeliveryPipeline, OperationMetadata>> CreateDeliveryPipelineAsync(string parent, DeliveryPipeline deliveryPipeline, string deliveryPipelineId, st::CancellationToken cancellationToken) =>
            CreateDeliveryPipelineAsync(parent, deliveryPipeline, deliveryPipelineId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new DeliveryPipeline in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `DeliveryPipeline` should be created.
        /// Format should be projects/{project_id}/locations/{location_name}.
        /// </param>
        /// <param name="deliveryPipeline">
        /// Required. The `DeliveryPipeline` to create.
        /// </param>
        /// <param name="deliveryPipelineId">
        /// Required. ID of the `DeliveryPipeline`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeliveryPipeline, OperationMetadata> CreateDeliveryPipeline(gagr::LocationName parent, DeliveryPipeline deliveryPipeline, string deliveryPipelineId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeliveryPipeline(new CreateDeliveryPipelineRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DeliveryPipelineId = gax::GaxPreconditions.CheckNotNullOrEmpty(deliveryPipelineId, nameof(deliveryPipelineId)),
                DeliveryPipeline = gax::GaxPreconditions.CheckNotNull(deliveryPipeline, nameof(deliveryPipeline)),
            }, callSettings);

        /// <summary>
        /// Creates a new DeliveryPipeline in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `DeliveryPipeline` should be created.
        /// Format should be projects/{project_id}/locations/{location_name}.
        /// </param>
        /// <param name="deliveryPipeline">
        /// Required. The `DeliveryPipeline` to create.
        /// </param>
        /// <param name="deliveryPipelineId">
        /// Required. ID of the `DeliveryPipeline`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeliveryPipeline, OperationMetadata>> CreateDeliveryPipelineAsync(gagr::LocationName parent, DeliveryPipeline deliveryPipeline, string deliveryPipelineId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeliveryPipelineAsync(new CreateDeliveryPipelineRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DeliveryPipelineId = gax::GaxPreconditions.CheckNotNullOrEmpty(deliveryPipelineId, nameof(deliveryPipelineId)),
                DeliveryPipeline = gax::GaxPreconditions.CheckNotNull(deliveryPipeline, nameof(deliveryPipeline)),
            }, callSettings);

        /// <summary>
        /// Creates a new DeliveryPipeline in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `DeliveryPipeline` should be created.
        /// Format should be projects/{project_id}/locations/{location_name}.
        /// </param>
        /// <param name="deliveryPipeline">
        /// Required. The `DeliveryPipeline` to create.
        /// </param>
        /// <param name="deliveryPipelineId">
        /// Required. ID of the `DeliveryPipeline`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeliveryPipeline, OperationMetadata>> CreateDeliveryPipelineAsync(gagr::LocationName parent, DeliveryPipeline deliveryPipeline, string deliveryPipelineId, st::CancellationToken cancellationToken) =>
            CreateDeliveryPipelineAsync(parent, deliveryPipeline, deliveryPipelineId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single DeliveryPipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeliveryPipeline, OperationMetadata> UpdateDeliveryPipeline(UpdateDeliveryPipelineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single DeliveryPipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeliveryPipeline, OperationMetadata>> UpdateDeliveryPipelineAsync(UpdateDeliveryPipelineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single DeliveryPipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeliveryPipeline, OperationMetadata>> UpdateDeliveryPipelineAsync(UpdateDeliveryPipelineRequest request, st::CancellationToken cancellationToken) =>
            UpdateDeliveryPipelineAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateDeliveryPipeline</c>.</summary>
        public virtual lro::OperationsClient UpdateDeliveryPipelineOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateDeliveryPipeline</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DeliveryPipeline, OperationMetadata> PollOnceUpdateDeliveryPipeline(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DeliveryPipeline, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDeliveryPipelineOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateDeliveryPipeline</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DeliveryPipeline, OperationMetadata>> PollOnceUpdateDeliveryPipelineAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DeliveryPipeline, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDeliveryPipelineOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single DeliveryPipeline.
        /// </summary>
        /// <param name="deliveryPipeline">
        /// Required. The `DeliveryPipeline` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// `DeliveryPipeline` resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeliveryPipeline, OperationMetadata> UpdateDeliveryPipeline(DeliveryPipeline deliveryPipeline, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDeliveryPipeline(new UpdateDeliveryPipelineRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                DeliveryPipeline = gax::GaxPreconditions.CheckNotNull(deliveryPipeline, nameof(deliveryPipeline)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single DeliveryPipeline.
        /// </summary>
        /// <param name="deliveryPipeline">
        /// Required. The `DeliveryPipeline` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// `DeliveryPipeline` resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeliveryPipeline, OperationMetadata>> UpdateDeliveryPipelineAsync(DeliveryPipeline deliveryPipeline, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDeliveryPipelineAsync(new UpdateDeliveryPipelineRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                DeliveryPipeline = gax::GaxPreconditions.CheckNotNull(deliveryPipeline, nameof(deliveryPipeline)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single DeliveryPipeline.
        /// </summary>
        /// <param name="deliveryPipeline">
        /// Required. The `DeliveryPipeline` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// `DeliveryPipeline` resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeliveryPipeline, OperationMetadata>> UpdateDeliveryPipelineAsync(DeliveryPipeline deliveryPipeline, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDeliveryPipelineAsync(deliveryPipeline, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single DeliveryPipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDeliveryPipeline(DeleteDeliveryPipelineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single DeliveryPipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDeliveryPipelineAsync(DeleteDeliveryPipelineRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single DeliveryPipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDeliveryPipelineAsync(DeleteDeliveryPipelineRequest request, st::CancellationToken cancellationToken) =>
            DeleteDeliveryPipelineAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteDeliveryPipeline</c>.</summary>
        public virtual lro::OperationsClient DeleteDeliveryPipelineOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteDeliveryPipeline</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteDeliveryPipeline(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDeliveryPipelineOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteDeliveryPipeline</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteDeliveryPipelineAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDeliveryPipelineOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single DeliveryPipeline.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `DeliveryPipeline` to delete. Format should be
        /// projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDeliveryPipeline(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDeliveryPipeline(new DeleteDeliveryPipelineRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single DeliveryPipeline.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `DeliveryPipeline` to delete. Format should be
        /// projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDeliveryPipelineAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDeliveryPipelineAsync(new DeleteDeliveryPipelineRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single DeliveryPipeline.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `DeliveryPipeline` to delete. Format should be
        /// projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDeliveryPipelineAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDeliveryPipelineAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single DeliveryPipeline.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `DeliveryPipeline` to delete. Format should be
        /// projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDeliveryPipeline(DeliveryPipelineName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDeliveryPipeline(new DeleteDeliveryPipelineRequest
            {
                DeliveryPipelineName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single DeliveryPipeline.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `DeliveryPipeline` to delete. Format should be
        /// projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDeliveryPipelineAsync(DeliveryPipelineName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDeliveryPipelineAsync(new DeleteDeliveryPipelineRequest
            {
                DeliveryPipelineName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single DeliveryPipeline.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `DeliveryPipeline` to delete. Format should be
        /// projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDeliveryPipelineAsync(DeliveryPipelineName name, st::CancellationToken cancellationToken) =>
            DeleteDeliveryPipelineAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Targets in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Target"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTargetsResponse, Target> ListTargets(ListTargetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Targets in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Target"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTargetsResponse, Target> ListTargetsAsync(ListTargetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Targets in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of targets. Format must be
        /// projects/{project_id}/locations/{location_name}.
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
        /// <returns>A pageable sequence of <see cref="Target"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTargetsResponse, Target> ListTargets(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTargets(new ListTargetsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Targets in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of targets. Format must be
        /// projects/{project_id}/locations/{location_name}.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Target"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTargetsResponse, Target> ListTargetsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTargetsAsync(new ListTargetsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Targets in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of targets. Format must be
        /// projects/{project_id}/locations/{location_name}.
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
        /// <returns>A pageable sequence of <see cref="Target"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTargetsResponse, Target> ListTargets(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTargets(new ListTargetsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Targets in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of targets. Format must be
        /// projects/{project_id}/locations/{location_name}.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Target"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTargetsResponse, Target> ListTargetsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListTargetsAsync(new ListTargetsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets details of a single Target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Target GetTarget(GetTargetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Target> GetTargetAsync(GetTargetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Target> GetTargetAsync(GetTargetRequest request, st::CancellationToken cancellationToken) =>
            GetTargetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Target.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `Target`. Format must be
        /// projects/{project_id}/locations/{location_name}/targets/{target_name}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Target GetTarget(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTarget(new GetTargetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Target.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `Target`. Format must be
        /// projects/{project_id}/locations/{location_name}/targets/{target_name}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Target> GetTargetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTargetAsync(new GetTargetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Target.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `Target`. Format must be
        /// projects/{project_id}/locations/{location_name}/targets/{target_name}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Target> GetTargetAsync(string name, st::CancellationToken cancellationToken) =>
            GetTargetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Target.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `Target`. Format must be
        /// projects/{project_id}/locations/{location_name}/targets/{target_name}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Target GetTarget(TargetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTarget(new GetTargetRequest
            {
                TargetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Target.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `Target`. Format must be
        /// projects/{project_id}/locations/{location_name}/targets/{target_name}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Target> GetTargetAsync(TargetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTargetAsync(new GetTargetRequest
            {
                TargetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Target.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `Target`. Format must be
        /// projects/{project_id}/locations/{location_name}/targets/{target_name}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Target> GetTargetAsync(TargetName name, st::CancellationToken cancellationToken) =>
            GetTargetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Target in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Target, OperationMetadata> CreateTarget(CreateTargetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Target in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Target, OperationMetadata>> CreateTargetAsync(CreateTargetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Target in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Target, OperationMetadata>> CreateTargetAsync(CreateTargetRequest request, st::CancellationToken cancellationToken) =>
            CreateTargetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateTarget</c>.</summary>
        public virtual lro::OperationsClient CreateTargetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateTarget</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Target, OperationMetadata> PollOnceCreateTarget(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Target, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateTargetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateTarget</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Target, OperationMetadata>> PollOnceCreateTargetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Target, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateTargetOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Target in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `Target` should be created.
        /// Format should be
        /// projects/{project_id}/locations/{location_name}.
        /// </param>
        /// <param name="target">
        /// Required. The `Target` to create.
        /// </param>
        /// <param name="targetId">
        /// Required. ID of the `Target`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Target, OperationMetadata> CreateTarget(string parent, Target target, string targetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTarget(new CreateTargetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TargetId = gax::GaxPreconditions.CheckNotNullOrEmpty(targetId, nameof(targetId)),
                Target = gax::GaxPreconditions.CheckNotNull(target, nameof(target)),
            }, callSettings);

        /// <summary>
        /// Creates a new Target in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `Target` should be created.
        /// Format should be
        /// projects/{project_id}/locations/{location_name}.
        /// </param>
        /// <param name="target">
        /// Required. The `Target` to create.
        /// </param>
        /// <param name="targetId">
        /// Required. ID of the `Target`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Target, OperationMetadata>> CreateTargetAsync(string parent, Target target, string targetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTargetAsync(new CreateTargetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TargetId = gax::GaxPreconditions.CheckNotNullOrEmpty(targetId, nameof(targetId)),
                Target = gax::GaxPreconditions.CheckNotNull(target, nameof(target)),
            }, callSettings);

        /// <summary>
        /// Creates a new Target in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `Target` should be created.
        /// Format should be
        /// projects/{project_id}/locations/{location_name}.
        /// </param>
        /// <param name="target">
        /// Required. The `Target` to create.
        /// </param>
        /// <param name="targetId">
        /// Required. ID of the `Target`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Target, OperationMetadata>> CreateTargetAsync(string parent, Target target, string targetId, st::CancellationToken cancellationToken) =>
            CreateTargetAsync(parent, target, targetId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Target in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `Target` should be created.
        /// Format should be
        /// projects/{project_id}/locations/{location_name}.
        /// </param>
        /// <param name="target">
        /// Required. The `Target` to create.
        /// </param>
        /// <param name="targetId">
        /// Required. ID of the `Target`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Target, OperationMetadata> CreateTarget(gagr::LocationName parent, Target target, string targetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTarget(new CreateTargetRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TargetId = gax::GaxPreconditions.CheckNotNullOrEmpty(targetId, nameof(targetId)),
                Target = gax::GaxPreconditions.CheckNotNull(target, nameof(target)),
            }, callSettings);

        /// <summary>
        /// Creates a new Target in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `Target` should be created.
        /// Format should be
        /// projects/{project_id}/locations/{location_name}.
        /// </param>
        /// <param name="target">
        /// Required. The `Target` to create.
        /// </param>
        /// <param name="targetId">
        /// Required. ID of the `Target`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Target, OperationMetadata>> CreateTargetAsync(gagr::LocationName parent, Target target, string targetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTargetAsync(new CreateTargetRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TargetId = gax::GaxPreconditions.CheckNotNullOrEmpty(targetId, nameof(targetId)),
                Target = gax::GaxPreconditions.CheckNotNull(target, nameof(target)),
            }, callSettings);

        /// <summary>
        /// Creates a new Target in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `Target` should be created.
        /// Format should be
        /// projects/{project_id}/locations/{location_name}.
        /// </param>
        /// <param name="target">
        /// Required. The `Target` to create.
        /// </param>
        /// <param name="targetId">
        /// Required. ID of the `Target`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Target, OperationMetadata>> CreateTargetAsync(gagr::LocationName parent, Target target, string targetId, st::CancellationToken cancellationToken) =>
            CreateTargetAsync(parent, target, targetId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Target, OperationMetadata> UpdateTarget(UpdateTargetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Target, OperationMetadata>> UpdateTargetAsync(UpdateTargetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Target, OperationMetadata>> UpdateTargetAsync(UpdateTargetRequest request, st::CancellationToken cancellationToken) =>
            UpdateTargetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateTarget</c>.</summary>
        public virtual lro::OperationsClient UpdateTargetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateTarget</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Target, OperationMetadata> PollOnceUpdateTarget(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Target, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateTargetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateTarget</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Target, OperationMetadata>> PollOnceUpdateTargetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Target, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateTargetOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single Target.
        /// </summary>
        /// <param name="target">
        /// Required. The `Target` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Target resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Target, OperationMetadata> UpdateTarget(Target target, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTarget(new UpdateTargetRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Target = gax::GaxPreconditions.CheckNotNull(target, nameof(target)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Target.
        /// </summary>
        /// <param name="target">
        /// Required. The `Target` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Target resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Target, OperationMetadata>> UpdateTargetAsync(Target target, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTargetAsync(new UpdateTargetRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Target = gax::GaxPreconditions.CheckNotNull(target, nameof(target)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Target.
        /// </summary>
        /// <param name="target">
        /// Required. The `Target` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Target resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Target, OperationMetadata>> UpdateTargetAsync(Target target, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateTargetAsync(target, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteTarget(DeleteTargetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTargetAsync(DeleteTargetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTargetAsync(DeleteTargetRequest request, st::CancellationToken cancellationToken) =>
            DeleteTargetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteTarget</c>.</summary>
        public virtual lro::OperationsClient DeleteTargetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteTarget</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteTarget(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteTargetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteTarget</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteTargetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteTargetOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Target.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Target` to delete. Format should be
        /// projects/{project_id}/locations/{location_name}/targets/{target_name}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteTarget(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTarget(new DeleteTargetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Target.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Target` to delete. Format should be
        /// projects/{project_id}/locations/{location_name}/targets/{target_name}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTargetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTargetAsync(new DeleteTargetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Target.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Target` to delete. Format should be
        /// projects/{project_id}/locations/{location_name}/targets/{target_name}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTargetAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteTargetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Target.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Target` to delete. Format should be
        /// projects/{project_id}/locations/{location_name}/targets/{target_name}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteTarget(TargetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTarget(new DeleteTargetRequest
            {
                TargetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Target.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Target` to delete. Format should be
        /// projects/{project_id}/locations/{location_name}/targets/{target_name}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTargetAsync(TargetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTargetAsync(new DeleteTargetRequest
            {
                TargetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Target.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Target` to delete. Format should be
        /// projects/{project_id}/locations/{location_name}/targets/{target_name}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTargetAsync(TargetName name, st::CancellationToken cancellationToken) =>
            DeleteTargetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Releases in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Release"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReleasesResponse, Release> ListReleases(ListReleasesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Releases in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Release"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReleasesResponse, Release> ListReleasesAsync(ListReleasesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Releases in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The `DeliveryPipeline` which owns this collection of `Release` objects.
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
        /// <returns>A pageable sequence of <see cref="Release"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReleasesResponse, Release> ListReleases(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListReleases(new ListReleasesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Releases in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The `DeliveryPipeline` which owns this collection of `Release` objects.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Release"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReleasesResponse, Release> ListReleasesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListReleasesAsync(new ListReleasesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Releases in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The `DeliveryPipeline` which owns this collection of `Release` objects.
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
        /// <returns>A pageable sequence of <see cref="Release"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReleasesResponse, Release> ListReleases(DeliveryPipelineName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListReleases(new ListReleasesRequest
            {
                ParentAsDeliveryPipelineName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Releases in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The `DeliveryPipeline` which owns this collection of `Release` objects.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Release"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReleasesResponse, Release> ListReleasesAsync(DeliveryPipelineName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListReleasesAsync(new ListReleasesRequest
            {
                ParentAsDeliveryPipelineName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets details of a single Release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Release GetRelease(GetReleaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Release> GetReleaseAsync(GetReleaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Release> GetReleaseAsync(GetReleaseRequest request, st::CancellationToken cancellationToken) =>
            GetReleaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Release.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `Release`. Format must be
        /// projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Release GetRelease(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRelease(new GetReleaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Release.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `Release`. Format must be
        /// projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Release> GetReleaseAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReleaseAsync(new GetReleaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Release.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `Release`. Format must be
        /// projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Release> GetReleaseAsync(string name, st::CancellationToken cancellationToken) =>
            GetReleaseAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Release.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `Release`. Format must be
        /// projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Release GetRelease(ReleaseName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRelease(new GetReleaseRequest
            {
                ReleaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Release.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `Release`. Format must be
        /// projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Release> GetReleaseAsync(ReleaseName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReleaseAsync(new GetReleaseRequest
            {
                ReleaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Release.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `Release`. Format must be
        /// projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Release> GetReleaseAsync(ReleaseName name, st::CancellationToken cancellationToken) =>
            GetReleaseAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Release in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Release, OperationMetadata> CreateRelease(CreateReleaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Release in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Release, OperationMetadata>> CreateReleaseAsync(CreateReleaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Release in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Release, OperationMetadata>> CreateReleaseAsync(CreateReleaseRequest request, st::CancellationToken cancellationToken) =>
            CreateReleaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateRelease</c>.</summary>
        public virtual lro::OperationsClient CreateReleaseOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateRelease</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Release, OperationMetadata> PollOnceCreateRelease(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Release, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateReleaseOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateRelease</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Release, OperationMetadata>> PollOnceCreateReleaseAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Release, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateReleaseOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Release in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `Release` should be created.
        /// Format should be
        /// projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}.
        /// </param>
        /// <param name="release">
        /// Required. The `Release` to create.
        /// </param>
        /// <param name="releaseId">
        /// Required. ID of the `Release`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Release, OperationMetadata> CreateRelease(string parent, Release release, string releaseId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRelease(new CreateReleaseRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ReleaseId = gax::GaxPreconditions.CheckNotNullOrEmpty(releaseId, nameof(releaseId)),
                Release = gax::GaxPreconditions.CheckNotNull(release, nameof(release)),
            }, callSettings);

        /// <summary>
        /// Creates a new Release in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `Release` should be created.
        /// Format should be
        /// projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}.
        /// </param>
        /// <param name="release">
        /// Required. The `Release` to create.
        /// </param>
        /// <param name="releaseId">
        /// Required. ID of the `Release`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Release, OperationMetadata>> CreateReleaseAsync(string parent, Release release, string releaseId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReleaseAsync(new CreateReleaseRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ReleaseId = gax::GaxPreconditions.CheckNotNullOrEmpty(releaseId, nameof(releaseId)),
                Release = gax::GaxPreconditions.CheckNotNull(release, nameof(release)),
            }, callSettings);

        /// <summary>
        /// Creates a new Release in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `Release` should be created.
        /// Format should be
        /// projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}.
        /// </param>
        /// <param name="release">
        /// Required. The `Release` to create.
        /// </param>
        /// <param name="releaseId">
        /// Required. ID of the `Release`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Release, OperationMetadata>> CreateReleaseAsync(string parent, Release release, string releaseId, st::CancellationToken cancellationToken) =>
            CreateReleaseAsync(parent, release, releaseId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Release in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `Release` should be created.
        /// Format should be
        /// projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}.
        /// </param>
        /// <param name="release">
        /// Required. The `Release` to create.
        /// </param>
        /// <param name="releaseId">
        /// Required. ID of the `Release`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Release, OperationMetadata> CreateRelease(DeliveryPipelineName parent, Release release, string releaseId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRelease(new CreateReleaseRequest
            {
                ParentAsDeliveryPipelineName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ReleaseId = gax::GaxPreconditions.CheckNotNullOrEmpty(releaseId, nameof(releaseId)),
                Release = gax::GaxPreconditions.CheckNotNull(release, nameof(release)),
            }, callSettings);

        /// <summary>
        /// Creates a new Release in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `Release` should be created.
        /// Format should be
        /// projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}.
        /// </param>
        /// <param name="release">
        /// Required. The `Release` to create.
        /// </param>
        /// <param name="releaseId">
        /// Required. ID of the `Release`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Release, OperationMetadata>> CreateReleaseAsync(DeliveryPipelineName parent, Release release, string releaseId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReleaseAsync(new CreateReleaseRequest
            {
                ParentAsDeliveryPipelineName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ReleaseId = gax::GaxPreconditions.CheckNotNullOrEmpty(releaseId, nameof(releaseId)),
                Release = gax::GaxPreconditions.CheckNotNull(release, nameof(release)),
            }, callSettings);

        /// <summary>
        /// Creates a new Release in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `Release` should be created.
        /// Format should be
        /// projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}.
        /// </param>
        /// <param name="release">
        /// Required. The `Release` to create.
        /// </param>
        /// <param name="releaseId">
        /// Required. ID of the `Release`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Release, OperationMetadata>> CreateReleaseAsync(DeliveryPipelineName parent, Release release, string releaseId, st::CancellationToken cancellationToken) =>
            CreateReleaseAsync(parent, release, releaseId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Approves a Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApproveRolloutResponse ApproveRollout(ApproveRolloutRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Approves a Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApproveRolloutResponse> ApproveRolloutAsync(ApproveRolloutRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Approves a Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApproveRolloutResponse> ApproveRolloutAsync(ApproveRolloutRequest request, st::CancellationToken cancellationToken) =>
            ApproveRolloutAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Approves a Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Rollout. Format is
        /// projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/
        /// releases/{release}/rollouts/{rollout}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApproveRolloutResponse ApproveRollout(string name, gaxgrpc::CallSettings callSettings = null) =>
            ApproveRollout(new ApproveRolloutRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Approves a Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Rollout. Format is
        /// projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/
        /// releases/{release}/rollouts/{rollout}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApproveRolloutResponse> ApproveRolloutAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ApproveRolloutAsync(new ApproveRolloutRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Approves a Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Rollout. Format is
        /// projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/
        /// releases/{release}/rollouts/{rollout}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApproveRolloutResponse> ApproveRolloutAsync(string name, st::CancellationToken cancellationToken) =>
            ApproveRolloutAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Approves a Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Rollout. Format is
        /// projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/
        /// releases/{release}/rollouts/{rollout}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApproveRolloutResponse ApproveRollout(RolloutName name, gaxgrpc::CallSettings callSettings = null) =>
            ApproveRollout(new ApproveRolloutRequest
            {
                RolloutName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Approves a Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Rollout. Format is
        /// projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/
        /// releases/{release}/rollouts/{rollout}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApproveRolloutResponse> ApproveRolloutAsync(RolloutName name, gaxgrpc::CallSettings callSettings = null) =>
            ApproveRolloutAsync(new ApproveRolloutRequest
            {
                RolloutName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Approves a Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Rollout. Format is
        /// projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/
        /// releases/{release}/rollouts/{rollout}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApproveRolloutResponse> ApproveRolloutAsync(RolloutName name, st::CancellationToken cancellationToken) =>
            ApproveRolloutAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Rollouts in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Rollout"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRolloutsResponse, Rollout> ListRollouts(ListRolloutsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Rollouts in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Rollout"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRolloutsResponse, Rollout> ListRolloutsAsync(ListRolloutsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Rollouts in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The `Release` which owns this collection of `Rollout` objects.
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
        /// <returns>A pageable sequence of <see cref="Rollout"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRolloutsResponse, Rollout> ListRollouts(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListRollouts(new ListRolloutsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Rollouts in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The `Release` which owns this collection of `Rollout` objects.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Rollout"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRolloutsResponse, Rollout> ListRolloutsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListRolloutsAsync(new ListRolloutsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Rollouts in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The `Release` which owns this collection of `Rollout` objects.
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
        /// <returns>A pageable sequence of <see cref="Rollout"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRolloutsResponse, Rollout> ListRollouts(ReleaseName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListRollouts(new ListRolloutsRequest
            {
                ParentAsReleaseName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Rollouts in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The `Release` which owns this collection of `Rollout` objects.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Rollout"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRolloutsResponse, Rollout> ListRolloutsAsync(ReleaseName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListRolloutsAsync(new ListRolloutsRequest
            {
                ParentAsReleaseName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets details of a single Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Rollout GetRollout(GetRolloutRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rollout> GetRolloutAsync(GetRolloutRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rollout> GetRolloutAsync(GetRolloutRequest request, st::CancellationToken cancellationToken) =>
            GetRolloutAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `Rollout`. Format must be
        /// projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}/rollouts/{rollout_name}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Rollout GetRollout(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRollout(new GetRolloutRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `Rollout`. Format must be
        /// projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}/rollouts/{rollout_name}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rollout> GetRolloutAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRolloutAsync(new GetRolloutRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `Rollout`. Format must be
        /// projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}/rollouts/{rollout_name}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rollout> GetRolloutAsync(string name, st::CancellationToken cancellationToken) =>
            GetRolloutAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `Rollout`. Format must be
        /// projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}/rollouts/{rollout_name}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Rollout GetRollout(RolloutName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRollout(new GetRolloutRequest
            {
                RolloutName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `Rollout`. Format must be
        /// projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}/rollouts/{rollout_name}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rollout> GetRolloutAsync(RolloutName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRolloutAsync(new GetRolloutRequest
            {
                RolloutName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `Rollout`. Format must be
        /// projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}/rollouts/{rollout_name}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rollout> GetRolloutAsync(RolloutName name, st::CancellationToken cancellationToken) =>
            GetRolloutAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Rollout in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Rollout, OperationMetadata> CreateRollout(CreateRolloutRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Rollout in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Rollout, OperationMetadata>> CreateRolloutAsync(CreateRolloutRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Rollout in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Rollout, OperationMetadata>> CreateRolloutAsync(CreateRolloutRequest request, st::CancellationToken cancellationToken) =>
            CreateRolloutAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateRollout</c>.</summary>
        public virtual lro::OperationsClient CreateRolloutOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateRollout</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Rollout, OperationMetadata> PollOnceCreateRollout(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Rollout, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateRolloutOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateRollout</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Rollout, OperationMetadata>> PollOnceCreateRolloutAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Rollout, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateRolloutOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Rollout in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `Rollout` should be created.
        /// Format should be
        /// projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}.
        /// </param>
        /// <param name="rollout">
        /// Required. The `Rollout` to create.
        /// </param>
        /// <param name="rolloutId">
        /// Required. ID of the `Rollout`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Rollout, OperationMetadata> CreateRollout(string parent, Rollout rollout, string rolloutId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRollout(new CreateRolloutRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RolloutId = gax::GaxPreconditions.CheckNotNullOrEmpty(rolloutId, nameof(rolloutId)),
                Rollout = gax::GaxPreconditions.CheckNotNull(rollout, nameof(rollout)),
            }, callSettings);

        /// <summary>
        /// Creates a new Rollout in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `Rollout` should be created.
        /// Format should be
        /// projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}.
        /// </param>
        /// <param name="rollout">
        /// Required. The `Rollout` to create.
        /// </param>
        /// <param name="rolloutId">
        /// Required. ID of the `Rollout`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Rollout, OperationMetadata>> CreateRolloutAsync(string parent, Rollout rollout, string rolloutId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRolloutAsync(new CreateRolloutRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RolloutId = gax::GaxPreconditions.CheckNotNullOrEmpty(rolloutId, nameof(rolloutId)),
                Rollout = gax::GaxPreconditions.CheckNotNull(rollout, nameof(rollout)),
            }, callSettings);

        /// <summary>
        /// Creates a new Rollout in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `Rollout` should be created.
        /// Format should be
        /// projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}.
        /// </param>
        /// <param name="rollout">
        /// Required. The `Rollout` to create.
        /// </param>
        /// <param name="rolloutId">
        /// Required. ID of the `Rollout`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Rollout, OperationMetadata>> CreateRolloutAsync(string parent, Rollout rollout, string rolloutId, st::CancellationToken cancellationToken) =>
            CreateRolloutAsync(parent, rollout, rolloutId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Rollout in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `Rollout` should be created.
        /// Format should be
        /// projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}.
        /// </param>
        /// <param name="rollout">
        /// Required. The `Rollout` to create.
        /// </param>
        /// <param name="rolloutId">
        /// Required. ID of the `Rollout`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Rollout, OperationMetadata> CreateRollout(ReleaseName parent, Rollout rollout, string rolloutId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRollout(new CreateRolloutRequest
            {
                ParentAsReleaseName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RolloutId = gax::GaxPreconditions.CheckNotNullOrEmpty(rolloutId, nameof(rolloutId)),
                Rollout = gax::GaxPreconditions.CheckNotNull(rollout, nameof(rollout)),
            }, callSettings);

        /// <summary>
        /// Creates a new Rollout in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `Rollout` should be created.
        /// Format should be
        /// projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}.
        /// </param>
        /// <param name="rollout">
        /// Required. The `Rollout` to create.
        /// </param>
        /// <param name="rolloutId">
        /// Required. ID of the `Rollout`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Rollout, OperationMetadata>> CreateRolloutAsync(ReleaseName parent, Rollout rollout, string rolloutId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRolloutAsync(new CreateRolloutRequest
            {
                ParentAsReleaseName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RolloutId = gax::GaxPreconditions.CheckNotNullOrEmpty(rolloutId, nameof(rolloutId)),
                Rollout = gax::GaxPreconditions.CheckNotNull(rollout, nameof(rollout)),
            }, callSettings);

        /// <summary>
        /// Creates a new Rollout in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `Rollout` should be created.
        /// Format should be
        /// projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}.
        /// </param>
        /// <param name="rollout">
        /// Required. The `Rollout` to create.
        /// </param>
        /// <param name="rolloutId">
        /// Required. ID of the `Rollout`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Rollout, OperationMetadata>> CreateRolloutAsync(ReleaseName parent, Rollout rollout, string rolloutId, st::CancellationToken cancellationToken) =>
            CreateRolloutAsync(parent, rollout, rolloutId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the configuration for a location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Config GetConfig(GetConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the configuration for a location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Config> GetConfigAsync(GetConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the configuration for a location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Config> GetConfigAsync(GetConfigRequest request, st::CancellationToken cancellationToken) =>
            GetConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the configuration for a location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of requested configuration.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Config GetConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConfig(new GetConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the configuration for a location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of requested configuration.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Config> GetConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConfigAsync(new GetConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the configuration for a location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of requested configuration.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Config> GetConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the configuration for a location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of requested configuration.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Config GetConfig(ConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConfig(new GetConfigRequest
            {
                ConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the configuration for a location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of requested configuration.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Config> GetConfigAsync(ConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConfigAsync(new GetConfigRequest
            {
                ConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the configuration for a location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of requested configuration.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Config> GetConfigAsync(ConfigName name, st::CancellationToken cancellationToken) =>
            GetConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CloudDeploy client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// CloudDeploy service creates and manages Continuous Delivery operations
    /// on Google Cloud Platform via Skaffold (https://skaffold.dev).
    /// </remarks>
    public sealed partial class CloudDeployClientImpl : CloudDeployClient
    {
        private readonly gaxgrpc::ApiCall<ListDeliveryPipelinesRequest, ListDeliveryPipelinesResponse> _callListDeliveryPipelines;

        private readonly gaxgrpc::ApiCall<GetDeliveryPipelineRequest, DeliveryPipeline> _callGetDeliveryPipeline;

        private readonly gaxgrpc::ApiCall<CreateDeliveryPipelineRequest, lro::Operation> _callCreateDeliveryPipeline;

        private readonly gaxgrpc::ApiCall<UpdateDeliveryPipelineRequest, lro::Operation> _callUpdateDeliveryPipeline;

        private readonly gaxgrpc::ApiCall<DeleteDeliveryPipelineRequest, lro::Operation> _callDeleteDeliveryPipeline;

        private readonly gaxgrpc::ApiCall<ListTargetsRequest, ListTargetsResponse> _callListTargets;

        private readonly gaxgrpc::ApiCall<GetTargetRequest, Target> _callGetTarget;

        private readonly gaxgrpc::ApiCall<CreateTargetRequest, lro::Operation> _callCreateTarget;

        private readonly gaxgrpc::ApiCall<UpdateTargetRequest, lro::Operation> _callUpdateTarget;

        private readonly gaxgrpc::ApiCall<DeleteTargetRequest, lro::Operation> _callDeleteTarget;

        private readonly gaxgrpc::ApiCall<ListReleasesRequest, ListReleasesResponse> _callListReleases;

        private readonly gaxgrpc::ApiCall<GetReleaseRequest, Release> _callGetRelease;

        private readonly gaxgrpc::ApiCall<CreateReleaseRequest, lro::Operation> _callCreateRelease;

        private readonly gaxgrpc::ApiCall<ApproveRolloutRequest, ApproveRolloutResponse> _callApproveRollout;

        private readonly gaxgrpc::ApiCall<ListRolloutsRequest, ListRolloutsResponse> _callListRollouts;

        private readonly gaxgrpc::ApiCall<GetRolloutRequest, Rollout> _callGetRollout;

        private readonly gaxgrpc::ApiCall<CreateRolloutRequest, lro::Operation> _callCreateRollout;

        private readonly gaxgrpc::ApiCall<GetConfigRequest, Config> _callGetConfig;

        /// <summary>
        /// Constructs a client wrapper for the CloudDeploy service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CloudDeploySettings"/> used within this client.</param>
        public CloudDeployClientImpl(CloudDeploy.CloudDeployClient grpcClient, CloudDeploySettings settings)
        {
            GrpcClient = grpcClient;
            CloudDeploySettings effectiveSettings = settings ?? CloudDeploySettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            CreateDeliveryPipelineOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateDeliveryPipelineOperationsSettings);
            UpdateDeliveryPipelineOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateDeliveryPipelineOperationsSettings);
            DeleteDeliveryPipelineOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteDeliveryPipelineOperationsSettings);
            CreateTargetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateTargetOperationsSettings);
            UpdateTargetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateTargetOperationsSettings);
            DeleteTargetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteTargetOperationsSettings);
            CreateReleaseOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateReleaseOperationsSettings);
            CreateRolloutOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateRolloutOperationsSettings);
            _callListDeliveryPipelines = clientHelper.BuildApiCall<ListDeliveryPipelinesRequest, ListDeliveryPipelinesResponse>(grpcClient.ListDeliveryPipelinesAsync, grpcClient.ListDeliveryPipelines, effectiveSettings.ListDeliveryPipelinesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDeliveryPipelines);
            Modify_ListDeliveryPipelinesApiCall(ref _callListDeliveryPipelines);
            _callGetDeliveryPipeline = clientHelper.BuildApiCall<GetDeliveryPipelineRequest, DeliveryPipeline>(grpcClient.GetDeliveryPipelineAsync, grpcClient.GetDeliveryPipeline, effectiveSettings.GetDeliveryPipelineSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDeliveryPipeline);
            Modify_GetDeliveryPipelineApiCall(ref _callGetDeliveryPipeline);
            _callCreateDeliveryPipeline = clientHelper.BuildApiCall<CreateDeliveryPipelineRequest, lro::Operation>(grpcClient.CreateDeliveryPipelineAsync, grpcClient.CreateDeliveryPipeline, effectiveSettings.CreateDeliveryPipelineSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDeliveryPipeline);
            Modify_CreateDeliveryPipelineApiCall(ref _callCreateDeliveryPipeline);
            _callUpdateDeliveryPipeline = clientHelper.BuildApiCall<UpdateDeliveryPipelineRequest, lro::Operation>(grpcClient.UpdateDeliveryPipelineAsync, grpcClient.UpdateDeliveryPipeline, effectiveSettings.UpdateDeliveryPipelineSettings).WithGoogleRequestParam("delivery_pipeline.name", request => request.DeliveryPipeline?.Name);
            Modify_ApiCall(ref _callUpdateDeliveryPipeline);
            Modify_UpdateDeliveryPipelineApiCall(ref _callUpdateDeliveryPipeline);
            _callDeleteDeliveryPipeline = clientHelper.BuildApiCall<DeleteDeliveryPipelineRequest, lro::Operation>(grpcClient.DeleteDeliveryPipelineAsync, grpcClient.DeleteDeliveryPipeline, effectiveSettings.DeleteDeliveryPipelineSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDeliveryPipeline);
            Modify_DeleteDeliveryPipelineApiCall(ref _callDeleteDeliveryPipeline);
            _callListTargets = clientHelper.BuildApiCall<ListTargetsRequest, ListTargetsResponse>(grpcClient.ListTargetsAsync, grpcClient.ListTargets, effectiveSettings.ListTargetsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTargets);
            Modify_ListTargetsApiCall(ref _callListTargets);
            _callGetTarget = clientHelper.BuildApiCall<GetTargetRequest, Target>(grpcClient.GetTargetAsync, grpcClient.GetTarget, effectiveSettings.GetTargetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTarget);
            Modify_GetTargetApiCall(ref _callGetTarget);
            _callCreateTarget = clientHelper.BuildApiCall<CreateTargetRequest, lro::Operation>(grpcClient.CreateTargetAsync, grpcClient.CreateTarget, effectiveSettings.CreateTargetSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTarget);
            Modify_CreateTargetApiCall(ref _callCreateTarget);
            _callUpdateTarget = clientHelper.BuildApiCall<UpdateTargetRequest, lro::Operation>(grpcClient.UpdateTargetAsync, grpcClient.UpdateTarget, effectiveSettings.UpdateTargetSettings).WithGoogleRequestParam("target.name", request => request.Target?.Name);
            Modify_ApiCall(ref _callUpdateTarget);
            Modify_UpdateTargetApiCall(ref _callUpdateTarget);
            _callDeleteTarget = clientHelper.BuildApiCall<DeleteTargetRequest, lro::Operation>(grpcClient.DeleteTargetAsync, grpcClient.DeleteTarget, effectiveSettings.DeleteTargetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTarget);
            Modify_DeleteTargetApiCall(ref _callDeleteTarget);
            _callListReleases = clientHelper.BuildApiCall<ListReleasesRequest, ListReleasesResponse>(grpcClient.ListReleasesAsync, grpcClient.ListReleases, effectiveSettings.ListReleasesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListReleases);
            Modify_ListReleasesApiCall(ref _callListReleases);
            _callGetRelease = clientHelper.BuildApiCall<GetReleaseRequest, Release>(grpcClient.GetReleaseAsync, grpcClient.GetRelease, effectiveSettings.GetReleaseSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRelease);
            Modify_GetReleaseApiCall(ref _callGetRelease);
            _callCreateRelease = clientHelper.BuildApiCall<CreateReleaseRequest, lro::Operation>(grpcClient.CreateReleaseAsync, grpcClient.CreateRelease, effectiveSettings.CreateReleaseSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateRelease);
            Modify_CreateReleaseApiCall(ref _callCreateRelease);
            _callApproveRollout = clientHelper.BuildApiCall<ApproveRolloutRequest, ApproveRolloutResponse>(grpcClient.ApproveRolloutAsync, grpcClient.ApproveRollout, effectiveSettings.ApproveRolloutSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callApproveRollout);
            Modify_ApproveRolloutApiCall(ref _callApproveRollout);
            _callListRollouts = clientHelper.BuildApiCall<ListRolloutsRequest, ListRolloutsResponse>(grpcClient.ListRolloutsAsync, grpcClient.ListRollouts, effectiveSettings.ListRolloutsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRollouts);
            Modify_ListRolloutsApiCall(ref _callListRollouts);
            _callGetRollout = clientHelper.BuildApiCall<GetRolloutRequest, Rollout>(grpcClient.GetRolloutAsync, grpcClient.GetRollout, effectiveSettings.GetRolloutSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRollout);
            Modify_GetRolloutApiCall(ref _callGetRollout);
            _callCreateRollout = clientHelper.BuildApiCall<CreateRolloutRequest, lro::Operation>(grpcClient.CreateRolloutAsync, grpcClient.CreateRollout, effectiveSettings.CreateRolloutSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateRollout);
            Modify_CreateRolloutApiCall(ref _callCreateRollout);
            _callGetConfig = clientHelper.BuildApiCall<GetConfigRequest, Config>(grpcClient.GetConfigAsync, grpcClient.GetConfig, effectiveSettings.GetConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetConfig);
            Modify_GetConfigApiCall(ref _callGetConfig);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListDeliveryPipelinesApiCall(ref gaxgrpc::ApiCall<ListDeliveryPipelinesRequest, ListDeliveryPipelinesResponse> call);

        partial void Modify_GetDeliveryPipelineApiCall(ref gaxgrpc::ApiCall<GetDeliveryPipelineRequest, DeliveryPipeline> call);

        partial void Modify_CreateDeliveryPipelineApiCall(ref gaxgrpc::ApiCall<CreateDeliveryPipelineRequest, lro::Operation> call);

        partial void Modify_UpdateDeliveryPipelineApiCall(ref gaxgrpc::ApiCall<UpdateDeliveryPipelineRequest, lro::Operation> call);

        partial void Modify_DeleteDeliveryPipelineApiCall(ref gaxgrpc::ApiCall<DeleteDeliveryPipelineRequest, lro::Operation> call);

        partial void Modify_ListTargetsApiCall(ref gaxgrpc::ApiCall<ListTargetsRequest, ListTargetsResponse> call);

        partial void Modify_GetTargetApiCall(ref gaxgrpc::ApiCall<GetTargetRequest, Target> call);

        partial void Modify_CreateTargetApiCall(ref gaxgrpc::ApiCall<CreateTargetRequest, lro::Operation> call);

        partial void Modify_UpdateTargetApiCall(ref gaxgrpc::ApiCall<UpdateTargetRequest, lro::Operation> call);

        partial void Modify_DeleteTargetApiCall(ref gaxgrpc::ApiCall<DeleteTargetRequest, lro::Operation> call);

        partial void Modify_ListReleasesApiCall(ref gaxgrpc::ApiCall<ListReleasesRequest, ListReleasesResponse> call);

        partial void Modify_GetReleaseApiCall(ref gaxgrpc::ApiCall<GetReleaseRequest, Release> call);

        partial void Modify_CreateReleaseApiCall(ref gaxgrpc::ApiCall<CreateReleaseRequest, lro::Operation> call);

        partial void Modify_ApproveRolloutApiCall(ref gaxgrpc::ApiCall<ApproveRolloutRequest, ApproveRolloutResponse> call);

        partial void Modify_ListRolloutsApiCall(ref gaxgrpc::ApiCall<ListRolloutsRequest, ListRolloutsResponse> call);

        partial void Modify_GetRolloutApiCall(ref gaxgrpc::ApiCall<GetRolloutRequest, Rollout> call);

        partial void Modify_CreateRolloutApiCall(ref gaxgrpc::ApiCall<CreateRolloutRequest, lro::Operation> call);

        partial void Modify_GetConfigApiCall(ref gaxgrpc::ApiCall<GetConfigRequest, Config> call);

        partial void OnConstruction(CloudDeploy.CloudDeployClient grpcClient, CloudDeploySettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CloudDeploy client</summary>
        public override CloudDeploy.CloudDeployClient GrpcClient { get; }

        partial void Modify_ListDeliveryPipelinesRequest(ref ListDeliveryPipelinesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDeliveryPipelineRequest(ref GetDeliveryPipelineRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateDeliveryPipelineRequest(ref CreateDeliveryPipelineRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDeliveryPipelineRequest(ref UpdateDeliveryPipelineRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDeliveryPipelineRequest(ref DeleteDeliveryPipelineRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTargetsRequest(ref ListTargetsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTargetRequest(ref GetTargetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateTargetRequest(ref CreateTargetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateTargetRequest(ref UpdateTargetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTargetRequest(ref DeleteTargetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListReleasesRequest(ref ListReleasesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetReleaseRequest(ref GetReleaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateReleaseRequest(ref CreateReleaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ApproveRolloutRequest(ref ApproveRolloutRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRolloutsRequest(ref ListRolloutsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRolloutRequest(ref GetRolloutRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateRolloutRequest(ref CreateRolloutRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetConfigRequest(ref GetConfigRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists DeliveryPipelines in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DeliveryPipeline"/> resources.</returns>
        public override gax::PagedEnumerable<ListDeliveryPipelinesResponse, DeliveryPipeline> ListDeliveryPipelines(ListDeliveryPipelinesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDeliveryPipelinesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDeliveryPipelinesRequest, ListDeliveryPipelinesResponse, DeliveryPipeline>(_callListDeliveryPipelines, request, callSettings);
        }

        /// <summary>
        /// Lists DeliveryPipelines in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DeliveryPipeline"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDeliveryPipelinesResponse, DeliveryPipeline> ListDeliveryPipelinesAsync(ListDeliveryPipelinesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDeliveryPipelinesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDeliveryPipelinesRequest, ListDeliveryPipelinesResponse, DeliveryPipeline>(_callListDeliveryPipelines, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single DeliveryPipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DeliveryPipeline GetDeliveryPipeline(GetDeliveryPipelineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDeliveryPipelineRequest(ref request, ref callSettings);
            return _callGetDeliveryPipeline.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single DeliveryPipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DeliveryPipeline> GetDeliveryPipelineAsync(GetDeliveryPipelineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDeliveryPipelineRequest(ref request, ref callSettings);
            return _callGetDeliveryPipeline.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateDeliveryPipeline</c>.</summary>
        public override lro::OperationsClient CreateDeliveryPipelineOperationsClient { get; }

        /// <summary>
        /// Creates a new DeliveryPipeline in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DeliveryPipeline, OperationMetadata> CreateDeliveryPipeline(CreateDeliveryPipelineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDeliveryPipelineRequest(ref request, ref callSettings);
            return new lro::Operation<DeliveryPipeline, OperationMetadata>(_callCreateDeliveryPipeline.Sync(request, callSettings), CreateDeliveryPipelineOperationsClient);
        }

        /// <summary>
        /// Creates a new DeliveryPipeline in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DeliveryPipeline, OperationMetadata>> CreateDeliveryPipelineAsync(CreateDeliveryPipelineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDeliveryPipelineRequest(ref request, ref callSettings);
            return new lro::Operation<DeliveryPipeline, OperationMetadata>(await _callCreateDeliveryPipeline.Async(request, callSettings).ConfigureAwait(false), CreateDeliveryPipelineOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateDeliveryPipeline</c>.</summary>
        public override lro::OperationsClient UpdateDeliveryPipelineOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single DeliveryPipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DeliveryPipeline, OperationMetadata> UpdateDeliveryPipeline(UpdateDeliveryPipelineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDeliveryPipelineRequest(ref request, ref callSettings);
            return new lro::Operation<DeliveryPipeline, OperationMetadata>(_callUpdateDeliveryPipeline.Sync(request, callSettings), UpdateDeliveryPipelineOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single DeliveryPipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DeliveryPipeline, OperationMetadata>> UpdateDeliveryPipelineAsync(UpdateDeliveryPipelineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDeliveryPipelineRequest(ref request, ref callSettings);
            return new lro::Operation<DeliveryPipeline, OperationMetadata>(await _callUpdateDeliveryPipeline.Async(request, callSettings).ConfigureAwait(false), UpdateDeliveryPipelineOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteDeliveryPipeline</c>.</summary>
        public override lro::OperationsClient DeleteDeliveryPipelineOperationsClient { get; }

        /// <summary>
        /// Deletes a single DeliveryPipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteDeliveryPipeline(DeleteDeliveryPipelineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDeliveryPipelineRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteDeliveryPipeline.Sync(request, callSettings), DeleteDeliveryPipelineOperationsClient);
        }

        /// <summary>
        /// Deletes a single DeliveryPipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDeliveryPipelineAsync(DeleteDeliveryPipelineRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDeliveryPipelineRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteDeliveryPipeline.Async(request, callSettings).ConfigureAwait(false), DeleteDeliveryPipelineOperationsClient);
        }

        /// <summary>
        /// Lists Targets in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Target"/> resources.</returns>
        public override gax::PagedEnumerable<ListTargetsResponse, Target> ListTargets(ListTargetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTargetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTargetsRequest, ListTargetsResponse, Target>(_callListTargets, request, callSettings);
        }

        /// <summary>
        /// Lists Targets in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Target"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTargetsResponse, Target> ListTargetsAsync(ListTargetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTargetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTargetsRequest, ListTargetsResponse, Target>(_callListTargets, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Target GetTarget(GetTargetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTargetRequest(ref request, ref callSettings);
            return _callGetTarget.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Target> GetTargetAsync(GetTargetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTargetRequest(ref request, ref callSettings);
            return _callGetTarget.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateTarget</c>.</summary>
        public override lro::OperationsClient CreateTargetOperationsClient { get; }

        /// <summary>
        /// Creates a new Target in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Target, OperationMetadata> CreateTarget(CreateTargetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTargetRequest(ref request, ref callSettings);
            return new lro::Operation<Target, OperationMetadata>(_callCreateTarget.Sync(request, callSettings), CreateTargetOperationsClient);
        }

        /// <summary>
        /// Creates a new Target in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Target, OperationMetadata>> CreateTargetAsync(CreateTargetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTargetRequest(ref request, ref callSettings);
            return new lro::Operation<Target, OperationMetadata>(await _callCreateTarget.Async(request, callSettings).ConfigureAwait(false), CreateTargetOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateTarget</c>.</summary>
        public override lro::OperationsClient UpdateTargetOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single Target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Target, OperationMetadata> UpdateTarget(UpdateTargetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTargetRequest(ref request, ref callSettings);
            return new lro::Operation<Target, OperationMetadata>(_callUpdateTarget.Sync(request, callSettings), UpdateTargetOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single Target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Target, OperationMetadata>> UpdateTargetAsync(UpdateTargetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTargetRequest(ref request, ref callSettings);
            return new lro::Operation<Target, OperationMetadata>(await _callUpdateTarget.Async(request, callSettings).ConfigureAwait(false), UpdateTargetOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteTarget</c>.</summary>
        public override lro::OperationsClient DeleteTargetOperationsClient { get; }

        /// <summary>
        /// Deletes a single Target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteTarget(DeleteTargetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTargetRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteTarget.Sync(request, callSettings), DeleteTargetOperationsClient);
        }

        /// <summary>
        /// Deletes a single Target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTargetAsync(DeleteTargetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTargetRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteTarget.Async(request, callSettings).ConfigureAwait(false), DeleteTargetOperationsClient);
        }

        /// <summary>
        /// Lists Releases in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Release"/> resources.</returns>
        public override gax::PagedEnumerable<ListReleasesResponse, Release> ListReleases(ListReleasesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReleasesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListReleasesRequest, ListReleasesResponse, Release>(_callListReleases, request, callSettings);
        }

        /// <summary>
        /// Lists Releases in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Release"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListReleasesResponse, Release> ListReleasesAsync(ListReleasesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReleasesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListReleasesRequest, ListReleasesResponse, Release>(_callListReleases, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Release GetRelease(GetReleaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReleaseRequest(ref request, ref callSettings);
            return _callGetRelease.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Release> GetReleaseAsync(GetReleaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReleaseRequest(ref request, ref callSettings);
            return _callGetRelease.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateRelease</c>.</summary>
        public override lro::OperationsClient CreateReleaseOperationsClient { get; }

        /// <summary>
        /// Creates a new Release in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Release, OperationMetadata> CreateRelease(CreateReleaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReleaseRequest(ref request, ref callSettings);
            return new lro::Operation<Release, OperationMetadata>(_callCreateRelease.Sync(request, callSettings), CreateReleaseOperationsClient);
        }

        /// <summary>
        /// Creates a new Release in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Release, OperationMetadata>> CreateReleaseAsync(CreateReleaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReleaseRequest(ref request, ref callSettings);
            return new lro::Operation<Release, OperationMetadata>(await _callCreateRelease.Async(request, callSettings).ConfigureAwait(false), CreateReleaseOperationsClient);
        }

        /// <summary>
        /// Approves a Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ApproveRolloutResponse ApproveRollout(ApproveRolloutRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ApproveRolloutRequest(ref request, ref callSettings);
            return _callApproveRollout.Sync(request, callSettings);
        }

        /// <summary>
        /// Approves a Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ApproveRolloutResponse> ApproveRolloutAsync(ApproveRolloutRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ApproveRolloutRequest(ref request, ref callSettings);
            return _callApproveRollout.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Rollouts in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Rollout"/> resources.</returns>
        public override gax::PagedEnumerable<ListRolloutsResponse, Rollout> ListRollouts(ListRolloutsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRolloutsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRolloutsRequest, ListRolloutsResponse, Rollout>(_callListRollouts, request, callSettings);
        }

        /// <summary>
        /// Lists Rollouts in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Rollout"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRolloutsResponse, Rollout> ListRolloutsAsync(ListRolloutsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRolloutsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRolloutsRequest, ListRolloutsResponse, Rollout>(_callListRollouts, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Rollout GetRollout(GetRolloutRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRolloutRequest(ref request, ref callSettings);
            return _callGetRollout.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Rollout> GetRolloutAsync(GetRolloutRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRolloutRequest(ref request, ref callSettings);
            return _callGetRollout.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateRollout</c>.</summary>
        public override lro::OperationsClient CreateRolloutOperationsClient { get; }

        /// <summary>
        /// Creates a new Rollout in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Rollout, OperationMetadata> CreateRollout(CreateRolloutRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRolloutRequest(ref request, ref callSettings);
            return new lro::Operation<Rollout, OperationMetadata>(_callCreateRollout.Sync(request, callSettings), CreateRolloutOperationsClient);
        }

        /// <summary>
        /// Creates a new Rollout in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Rollout, OperationMetadata>> CreateRolloutAsync(CreateRolloutRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateRolloutRequest(ref request, ref callSettings);
            return new lro::Operation<Rollout, OperationMetadata>(await _callCreateRollout.Async(request, callSettings).ConfigureAwait(false), CreateRolloutOperationsClient);
        }

        /// <summary>
        /// Gets the configuration for a location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Config GetConfig(GetConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConfigRequest(ref request, ref callSettings);
            return _callGetConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the configuration for a location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Config> GetConfigAsync(GetConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConfigRequest(ref request, ref callSettings);
            return _callGetConfig.Async(request, callSettings);
        }
    }

    public partial class ListDeliveryPipelinesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTargetsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListReleasesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRolloutsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDeliveryPipelinesResponse : gaxgrpc::IPageResponse<DeliveryPipeline>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DeliveryPipeline> GetEnumerator() => DeliveryPipelines.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTargetsResponse : gaxgrpc::IPageResponse<Target>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Target> GetEnumerator() => Targets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListReleasesResponse : gaxgrpc::IPageResponse<Release>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Release> GetEnumerator() => Releases.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListRolloutsResponse : gaxgrpc::IPageResponse<Rollout>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Rollout> GetEnumerator() => Rollouts.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class CloudDeploy
    {
        public partial class CloudDeployClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() =>
                new lro::Operations.OperationsClient(CallInvoker);
        }
    }
}
