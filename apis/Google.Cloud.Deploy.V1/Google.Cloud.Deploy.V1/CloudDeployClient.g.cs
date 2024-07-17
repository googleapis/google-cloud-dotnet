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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gciv = Google.Cloud.Iam.V1;
using gcl = Google.Cloud.Location;
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
using wkt = Google.Protobuf.WellKnownTypes;

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
            RollbackTargetSettings = existing.RollbackTargetSettings;
            GetTargetSettings = existing.GetTargetSettings;
            CreateTargetSettings = existing.CreateTargetSettings;
            CreateTargetOperationsSettings = existing.CreateTargetOperationsSettings.Clone();
            UpdateTargetSettings = existing.UpdateTargetSettings;
            UpdateTargetOperationsSettings = existing.UpdateTargetOperationsSettings.Clone();
            DeleteTargetSettings = existing.DeleteTargetSettings;
            DeleteTargetOperationsSettings = existing.DeleteTargetOperationsSettings.Clone();
            ListCustomTargetTypesSettings = existing.ListCustomTargetTypesSettings;
            GetCustomTargetTypeSettings = existing.GetCustomTargetTypeSettings;
            CreateCustomTargetTypeSettings = existing.CreateCustomTargetTypeSettings;
            CreateCustomTargetTypeOperationsSettings = existing.CreateCustomTargetTypeOperationsSettings.Clone();
            UpdateCustomTargetTypeSettings = existing.UpdateCustomTargetTypeSettings;
            UpdateCustomTargetTypeOperationsSettings = existing.UpdateCustomTargetTypeOperationsSettings.Clone();
            DeleteCustomTargetTypeSettings = existing.DeleteCustomTargetTypeSettings;
            DeleteCustomTargetTypeOperationsSettings = existing.DeleteCustomTargetTypeOperationsSettings.Clone();
            ListReleasesSettings = existing.ListReleasesSettings;
            GetReleaseSettings = existing.GetReleaseSettings;
            CreateReleaseSettings = existing.CreateReleaseSettings;
            CreateReleaseOperationsSettings = existing.CreateReleaseOperationsSettings.Clone();
            AbandonReleaseSettings = existing.AbandonReleaseSettings;
            CreateDeployPolicySettings = existing.CreateDeployPolicySettings;
            CreateDeployPolicyOperationsSettings = existing.CreateDeployPolicyOperationsSettings.Clone();
            UpdateDeployPolicySettings = existing.UpdateDeployPolicySettings;
            UpdateDeployPolicyOperationsSettings = existing.UpdateDeployPolicyOperationsSettings.Clone();
            DeleteDeployPolicySettings = existing.DeleteDeployPolicySettings;
            DeleteDeployPolicyOperationsSettings = existing.DeleteDeployPolicyOperationsSettings.Clone();
            ListDeployPoliciesSettings = existing.ListDeployPoliciesSettings;
            GetDeployPolicySettings = existing.GetDeployPolicySettings;
            ApproveRolloutSettings = existing.ApproveRolloutSettings;
            AdvanceRolloutSettings = existing.AdvanceRolloutSettings;
            CancelRolloutSettings = existing.CancelRolloutSettings;
            ListRolloutsSettings = existing.ListRolloutsSettings;
            GetRolloutSettings = existing.GetRolloutSettings;
            CreateRolloutSettings = existing.CreateRolloutSettings;
            CreateRolloutOperationsSettings = existing.CreateRolloutOperationsSettings.Clone();
            IgnoreJobSettings = existing.IgnoreJobSettings;
            RetryJobSettings = existing.RetryJobSettings;
            ListJobRunsSettings = existing.ListJobRunsSettings;
            GetJobRunSettings = existing.GetJobRunSettings;
            TerminateJobRunSettings = existing.TerminateJobRunSettings;
            GetConfigSettings = existing.GetConfigSettings;
            CreateAutomationSettings = existing.CreateAutomationSettings;
            CreateAutomationOperationsSettings = existing.CreateAutomationOperationsSettings.Clone();
            UpdateAutomationSettings = existing.UpdateAutomationSettings;
            UpdateAutomationOperationsSettings = existing.UpdateAutomationOperationsSettings.Clone();
            DeleteAutomationSettings = existing.DeleteAutomationSettings;
            DeleteAutomationOperationsSettings = existing.DeleteAutomationOperationsSettings.Clone();
            GetAutomationSettings = existing.GetAutomationSettings;
            ListAutomationsSettings = existing.ListAutomationsSettings;
            GetAutomationRunSettings = existing.GetAutomationRunSettings;
            ListAutomationRunsSettings = existing.ListAutomationRunsSettings;
            CancelAutomationRunSettings = existing.CancelAutomationRunSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
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
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
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
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
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
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTargetsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudDeployClient.RollbackTarget</c> and <c>CloudDeployClient.RollbackTargetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RollbackTargetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

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
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
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
        /// <c>CloudDeployClient.ListCustomTargetTypes</c> and <c>CloudDeployClient.ListCustomTargetTypesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCustomTargetTypesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudDeployClient.GetCustomTargetType</c> and <c>CloudDeployClient.GetCustomTargetTypeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCustomTargetTypeSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudDeployClient.CreateCustomTargetType</c> and <c>CloudDeployClient.CreateCustomTargetTypeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateCustomTargetTypeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudDeployClient.CreateCustomTargetType</c> and
        /// <c>CloudDeployClient.CreateCustomTargetTypeAsync</c>.
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
        public lro::OperationsSettings CreateCustomTargetTypeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudDeployClient.UpdateCustomTargetType</c> and <c>CloudDeployClient.UpdateCustomTargetTypeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateCustomTargetTypeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudDeployClient.UpdateCustomTargetType</c> and
        /// <c>CloudDeployClient.UpdateCustomTargetTypeAsync</c>.
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
        public lro::OperationsSettings UpdateCustomTargetTypeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudDeployClient.DeleteCustomTargetType</c> and <c>CloudDeployClient.DeleteCustomTargetTypeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteCustomTargetTypeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudDeployClient.DeleteCustomTargetType</c> and
        /// <c>CloudDeployClient.DeleteCustomTargetTypeAsync</c>.
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
        public lro::OperationsSettings DeleteCustomTargetTypeOperationsSettings { get; set; } = new lro::OperationsSettings
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
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
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
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
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
        /// <c>CloudDeployClient.AbandonRelease</c> and <c>CloudDeployClient.AbandonReleaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AbandonReleaseSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudDeployClient.CreateDeployPolicy</c> and <c>CloudDeployClient.CreateDeployPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDeployPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudDeployClient.CreateDeployPolicy</c> and
        /// <c>CloudDeployClient.CreateDeployPolicyAsync</c>.
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
        public lro::OperationsSettings CreateDeployPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudDeployClient.UpdateDeployPolicy</c> and <c>CloudDeployClient.UpdateDeployPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDeployPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudDeployClient.UpdateDeployPolicy</c> and
        /// <c>CloudDeployClient.UpdateDeployPolicyAsync</c>.
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
        public lro::OperationsSettings UpdateDeployPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudDeployClient.DeleteDeployPolicy</c> and <c>CloudDeployClient.DeleteDeployPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDeployPolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudDeployClient.DeleteDeployPolicy</c> and
        /// <c>CloudDeployClient.DeleteDeployPolicyAsync</c>.
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
        public lro::OperationsSettings DeleteDeployPolicyOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudDeployClient.ListDeployPolicies</c> and <c>CloudDeployClient.ListDeployPoliciesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDeployPoliciesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudDeployClient.GetDeployPolicy</c> and <c>CloudDeployClient.GetDeployPolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDeployPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

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
        /// <c>CloudDeployClient.AdvanceRollout</c> and <c>CloudDeployClient.AdvanceRolloutAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AdvanceRolloutSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudDeployClient.CancelRollout</c> and <c>CloudDeployClient.CancelRolloutAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CancelRolloutSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

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
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
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
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>CloudDeployClient.IgnoreJob</c>
        ///  and <c>CloudDeployClient.IgnoreJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings IgnoreJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>CloudDeployClient.RetryJob</c>
        ///  and <c>CloudDeployClient.RetryJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RetryJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudDeployClient.ListJobRuns</c> and <c>CloudDeployClient.ListJobRunsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListJobRunsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>CloudDeployClient.GetJobRun</c>
        ///  and <c>CloudDeployClient.GetJobRunAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetJobRunSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudDeployClient.TerminateJobRun</c> and <c>CloudDeployClient.TerminateJobRunAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TerminateJobRunSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

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
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudDeployClient.CreateAutomation</c> and <c>CloudDeployClient.CreateAutomationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAutomationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudDeployClient.CreateAutomation</c> and
        /// <c>CloudDeployClient.CreateAutomationAsync</c>.
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
        public lro::OperationsSettings CreateAutomationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudDeployClient.UpdateAutomation</c> and <c>CloudDeployClient.UpdateAutomationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAutomationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudDeployClient.UpdateAutomation</c> and
        /// <c>CloudDeployClient.UpdateAutomationAsync</c>.
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
        public lro::OperationsSettings UpdateAutomationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudDeployClient.DeleteAutomation</c> and <c>CloudDeployClient.DeleteAutomationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAutomationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudDeployClient.DeleteAutomation</c> and
        /// <c>CloudDeployClient.DeleteAutomationAsync</c>.
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
        public lro::OperationsSettings DeleteAutomationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudDeployClient.GetAutomation</c> and <c>CloudDeployClient.GetAutomationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAutomationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudDeployClient.ListAutomations</c> and <c>CloudDeployClient.ListAutomationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAutomationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudDeployClient.GetAutomationRun</c> and <c>CloudDeployClient.GetAutomationRunAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAutomationRunSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudDeployClient.ListAutomationRuns</c> and <c>CloudDeployClient.ListAutomationRunsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAutomationRunsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudDeployClient.CancelAutomationRun</c> and <c>CloudDeployClient.CancelAutomationRunAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CancelAutomationRunSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

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
        public CloudDeployClientBuilder() : base(CloudDeployClient.ServiceMetadata)
        {
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
            return CloudDeployClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CloudDeployClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CloudDeployClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CloudDeployClient.ChannelPool;
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

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CloudDeploy.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

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
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CloudDeployClient"/>.</returns>
        internal static CloudDeployClient Create(grpccore::CallInvoker callInvoker, CloudDeploySettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CloudDeploy.CloudDeployClient grpcClient = new CloudDeploy.CloudDeployClient(callInvoker);
            return new CloudDeployClientImpl(grpcClient, settings, logger);
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

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

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
        /// Required. The parent, which owns this collection of pipelines. Format must
        /// be `projects/{project_id}/locations/{location_name}`.
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
        /// Required. The parent, which owns this collection of pipelines. Format must
        /// be `projects/{project_id}/locations/{location_name}`.
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
        /// Required. The parent, which owns this collection of pipelines. Format must
        /// be `projects/{project_id}/locations/{location_name}`.
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
        /// Required. The parent, which owns this collection of pipelines. Format must
        /// be `projects/{project_id}/locations/{location_name}`.
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
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
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
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
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
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
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
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
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
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
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
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
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
        /// Required. The parent collection in which the `DeliveryPipeline` must be
        /// created. The format is `projects/{project_id}/locations/{location_name}`.
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
        /// Required. The parent collection in which the `DeliveryPipeline` must be
        /// created. The format is `projects/{project_id}/locations/{location_name}`.
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
        /// Required. The parent collection in which the `DeliveryPipeline` must be
        /// created. The format is `projects/{project_id}/locations/{location_name}`.
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
        /// Required. The parent collection in which the `DeliveryPipeline` must be
        /// created. The format is `projects/{project_id}/locations/{location_name}`.
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
        /// Required. The parent collection in which the `DeliveryPipeline` must be
        /// created. The format is `projects/{project_id}/locations/{location_name}`.
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
        /// Required. The parent collection in which the `DeliveryPipeline` must be
        /// created. The format is `projects/{project_id}/locations/{location_name}`.
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
        /// Required. Field mask is used to specify the fields to be overwritten by the
        /// update in the `DeliveryPipeline` resource. The fields specified in the
        /// update_mask are relative to the resource, not the full request. A field
        /// will be overwritten if it's in the mask. If the user doesn't provide a mask
        /// then all fields are overwritten.
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
        /// Required. Field mask is used to specify the fields to be overwritten by the
        /// update in the `DeliveryPipeline` resource. The fields specified in the
        /// update_mask are relative to the resource, not the full request. A field
        /// will be overwritten if it's in the mask. If the user doesn't provide a mask
        /// then all fields are overwritten.
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
        /// Required. Field mask is used to specify the fields to be overwritten by the
        /// update in the `DeliveryPipeline` resource. The fields specified in the
        /// update_mask are relative to the resource, not the full request. A field
        /// will be overwritten if it's in the mask. If the user doesn't provide a mask
        /// then all fields are overwritten.
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
        /// Required. The name of the `DeliveryPipeline` to delete. The format is
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
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
        /// Required. The name of the `DeliveryPipeline` to delete. The format is
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
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
        /// Required. The name of the `DeliveryPipeline` to delete. The format is
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDeliveryPipelineAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDeliveryPipelineAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single DeliveryPipeline.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `DeliveryPipeline` to delete. The format is
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
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
        /// Required. The name of the `DeliveryPipeline` to delete. The format is
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
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
        /// Required. The name of the `DeliveryPipeline` to delete. The format is
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
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
        /// `projects/{project_id}/locations/{location_name}`.
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
        /// `projects/{project_id}/locations/{location_name}`.
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
        /// `projects/{project_id}/locations/{location_name}`.
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
        /// `projects/{project_id}/locations/{location_name}`.
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
        /// Creates a `Rollout` to roll back the specified target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RollbackTargetResponse RollbackTarget(RollbackTargetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `Rollout` to roll back the specified target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RollbackTargetResponse> RollbackTargetAsync(RollbackTargetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `Rollout` to roll back the specified target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RollbackTargetResponse> RollbackTargetAsync(RollbackTargetRequest request, st::CancellationToken cancellationToken) =>
            RollbackTargetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `Rollout` to roll back the specified target.
        /// </summary>
        /// <param name="name">
        /// Required. The `DeliveryPipeline` for which the rollback `Rollout` must be
        /// created. The format is
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
        /// </param>
        /// <param name="targetId">
        /// Required. ID of the `Target` that is being rolled back.
        /// </param>
        /// <param name="rolloutId">
        /// Required. ID of the rollback `Rollout` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RollbackTargetResponse RollbackTarget(string name, string targetId, string rolloutId, gaxgrpc::CallSettings callSettings = null) =>
            RollbackTarget(new RollbackTargetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                TargetId = gax::GaxPreconditions.CheckNotNullOrEmpty(targetId, nameof(targetId)),
                RolloutId = gax::GaxPreconditions.CheckNotNullOrEmpty(rolloutId, nameof(rolloutId)),
            }, callSettings);

        /// <summary>
        /// Creates a `Rollout` to roll back the specified target.
        /// </summary>
        /// <param name="name">
        /// Required. The `DeliveryPipeline` for which the rollback `Rollout` must be
        /// created. The format is
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
        /// </param>
        /// <param name="targetId">
        /// Required. ID of the `Target` that is being rolled back.
        /// </param>
        /// <param name="rolloutId">
        /// Required. ID of the rollback `Rollout` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RollbackTargetResponse> RollbackTargetAsync(string name, string targetId, string rolloutId, gaxgrpc::CallSettings callSettings = null) =>
            RollbackTargetAsync(new RollbackTargetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                TargetId = gax::GaxPreconditions.CheckNotNullOrEmpty(targetId, nameof(targetId)),
                RolloutId = gax::GaxPreconditions.CheckNotNullOrEmpty(rolloutId, nameof(rolloutId)),
            }, callSettings);

        /// <summary>
        /// Creates a `Rollout` to roll back the specified target.
        /// </summary>
        /// <param name="name">
        /// Required. The `DeliveryPipeline` for which the rollback `Rollout` must be
        /// created. The format is
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
        /// </param>
        /// <param name="targetId">
        /// Required. ID of the `Target` that is being rolled back.
        /// </param>
        /// <param name="rolloutId">
        /// Required. ID of the rollback `Rollout` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RollbackTargetResponse> RollbackTargetAsync(string name, string targetId, string rolloutId, st::CancellationToken cancellationToken) =>
            RollbackTargetAsync(name, targetId, rolloutId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `Rollout` to roll back the specified target.
        /// </summary>
        /// <param name="name">
        /// Required. The `DeliveryPipeline` for which the rollback `Rollout` must be
        /// created. The format is
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
        /// </param>
        /// <param name="targetId">
        /// Required. ID of the `Target` that is being rolled back.
        /// </param>
        /// <param name="rolloutId">
        /// Required. ID of the rollback `Rollout` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RollbackTargetResponse RollbackTarget(DeliveryPipelineName name, string targetId, string rolloutId, gaxgrpc::CallSettings callSettings = null) =>
            RollbackTarget(new RollbackTargetRequest
            {
                DeliveryPipelineName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                TargetId = gax::GaxPreconditions.CheckNotNullOrEmpty(targetId, nameof(targetId)),
                RolloutId = gax::GaxPreconditions.CheckNotNullOrEmpty(rolloutId, nameof(rolloutId)),
            }, callSettings);

        /// <summary>
        /// Creates a `Rollout` to roll back the specified target.
        /// </summary>
        /// <param name="name">
        /// Required. The `DeliveryPipeline` for which the rollback `Rollout` must be
        /// created. The format is
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
        /// </param>
        /// <param name="targetId">
        /// Required. ID of the `Target` that is being rolled back.
        /// </param>
        /// <param name="rolloutId">
        /// Required. ID of the rollback `Rollout` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RollbackTargetResponse> RollbackTargetAsync(DeliveryPipelineName name, string targetId, string rolloutId, gaxgrpc::CallSettings callSettings = null) =>
            RollbackTargetAsync(new RollbackTargetRequest
            {
                DeliveryPipelineName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                TargetId = gax::GaxPreconditions.CheckNotNullOrEmpty(targetId, nameof(targetId)),
                RolloutId = gax::GaxPreconditions.CheckNotNullOrEmpty(rolloutId, nameof(rolloutId)),
            }, callSettings);

        /// <summary>
        /// Creates a `Rollout` to roll back the specified target.
        /// </summary>
        /// <param name="name">
        /// Required. The `DeliveryPipeline` for which the rollback `Rollout` must be
        /// created. The format is
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
        /// </param>
        /// <param name="targetId">
        /// Required. ID of the `Target` that is being rolled back.
        /// </param>
        /// <param name="rolloutId">
        /// Required. ID of the rollback `Rollout` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RollbackTargetResponse> RollbackTargetAsync(DeliveryPipelineName name, string targetId, string rolloutId, st::CancellationToken cancellationToken) =>
            RollbackTargetAsync(name, targetId, rolloutId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// `projects/{project_id}/locations/{location_name}/targets/{target_name}`.
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
        /// `projects/{project_id}/locations/{location_name}/targets/{target_name}`.
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
        /// `projects/{project_id}/locations/{location_name}/targets/{target_name}`.
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
        /// `projects/{project_id}/locations/{location_name}/targets/{target_name}`.
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
        /// `projects/{project_id}/locations/{location_name}/targets/{target_name}`.
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
        /// `projects/{project_id}/locations/{location_name}/targets/{target_name}`.
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
        /// Required. The parent collection in which the `Target` must be created.
        /// The format is
        /// `projects/{project_id}/locations/{location_name}`.
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
        /// Required. The parent collection in which the `Target` must be created.
        /// The format is
        /// `projects/{project_id}/locations/{location_name}`.
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
        /// Required. The parent collection in which the `Target` must be created.
        /// The format is
        /// `projects/{project_id}/locations/{location_name}`.
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
        /// Required. The parent collection in which the `Target` must be created.
        /// The format is
        /// `projects/{project_id}/locations/{location_name}`.
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
        /// Required. The parent collection in which the `Target` must be created.
        /// The format is
        /// `projects/{project_id}/locations/{location_name}`.
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
        /// Required. The parent collection in which the `Target` must be created.
        /// The format is
        /// `projects/{project_id}/locations/{location_name}`.
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
        /// Required. Field mask is used to specify the fields to be overwritten by the
        /// update in the `Target` resource. The fields specified in the update_mask
        /// are relative to the resource, not the full request. A field will be
        /// overwritten if it's in the mask. If the user doesn't provide a mask then
        /// all fields are overwritten.
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
        /// Required. Field mask is used to specify the fields to be overwritten by the
        /// update in the `Target` resource. The fields specified in the update_mask
        /// are relative to the resource, not the full request. A field will be
        /// overwritten if it's in the mask. If the user doesn't provide a mask then
        /// all fields are overwritten.
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
        /// Required. Field mask is used to specify the fields to be overwritten by the
        /// update in the `Target` resource. The fields specified in the update_mask
        /// are relative to the resource, not the full request. A field will be
        /// overwritten if it's in the mask. If the user doesn't provide a mask then
        /// all fields are overwritten.
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
        /// Required. The name of the `Target` to delete. The format is
        /// `projects/{project_id}/locations/{location_name}/targets/{target_name}`.
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
        /// Required. The name of the `Target` to delete. The format is
        /// `projects/{project_id}/locations/{location_name}/targets/{target_name}`.
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
        /// Required. The name of the `Target` to delete. The format is
        /// `projects/{project_id}/locations/{location_name}/targets/{target_name}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTargetAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteTargetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Target.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Target` to delete. The format is
        /// `projects/{project_id}/locations/{location_name}/targets/{target_name}`.
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
        /// Required. The name of the `Target` to delete. The format is
        /// `projects/{project_id}/locations/{location_name}/targets/{target_name}`.
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
        /// Required. The name of the `Target` to delete. The format is
        /// `projects/{project_id}/locations/{location_name}/targets/{target_name}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteTargetAsync(TargetName name, st::CancellationToken cancellationToken) =>
            DeleteTargetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists CustomTargetTypes in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CustomTargetType"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCustomTargetTypesResponse, CustomTargetType> ListCustomTargetTypes(ListCustomTargetTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists CustomTargetTypes in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CustomTargetType"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCustomTargetTypesResponse, CustomTargetType> ListCustomTargetTypesAsync(ListCustomTargetTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists CustomTargetTypes in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns this collection of custom target types.
        /// Format must be `projects/{project_id}/locations/{location_name}`.
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
        /// <returns>A pageable sequence of <see cref="CustomTargetType"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCustomTargetTypesResponse, CustomTargetType> ListCustomTargetTypes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCustomTargetTypes(new ListCustomTargetTypesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists CustomTargetTypes in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns this collection of custom target types.
        /// Format must be `projects/{project_id}/locations/{location_name}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CustomTargetType"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCustomTargetTypesResponse, CustomTargetType> ListCustomTargetTypesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCustomTargetTypesAsync(new ListCustomTargetTypesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists CustomTargetTypes in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns this collection of custom target types.
        /// Format must be `projects/{project_id}/locations/{location_name}`.
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
        /// <returns>A pageable sequence of <see cref="CustomTargetType"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCustomTargetTypesResponse, CustomTargetType> ListCustomTargetTypes(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCustomTargetTypes(new ListCustomTargetTypesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists CustomTargetTypes in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent that owns this collection of custom target types.
        /// Format must be `projects/{project_id}/locations/{location_name}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CustomTargetType"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCustomTargetTypesResponse, CustomTargetType> ListCustomTargetTypesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCustomTargetTypesAsync(new ListCustomTargetTypesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets details of a single CustomTargetType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomTargetType GetCustomTargetType(GetCustomTargetTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single CustomTargetType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomTargetType> GetCustomTargetTypeAsync(GetCustomTargetTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single CustomTargetType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomTargetType> GetCustomTargetTypeAsync(GetCustomTargetTypeRequest request, st::CancellationToken cancellationToken) =>
            GetCustomTargetTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single CustomTargetType.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `CustomTargetType`. Format must be
        /// `projects/{project_id}/locations/{location_name}/customTargetTypes/{custom_target_type}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomTargetType GetCustomTargetType(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomTargetType(new GetCustomTargetTypeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single CustomTargetType.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `CustomTargetType`. Format must be
        /// `projects/{project_id}/locations/{location_name}/customTargetTypes/{custom_target_type}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomTargetType> GetCustomTargetTypeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomTargetTypeAsync(new GetCustomTargetTypeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single CustomTargetType.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `CustomTargetType`. Format must be
        /// `projects/{project_id}/locations/{location_name}/customTargetTypes/{custom_target_type}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomTargetType> GetCustomTargetTypeAsync(string name, st::CancellationToken cancellationToken) =>
            GetCustomTargetTypeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single CustomTargetType.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `CustomTargetType`. Format must be
        /// `projects/{project_id}/locations/{location_name}/customTargetTypes/{custom_target_type}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomTargetType GetCustomTargetType(CustomTargetTypeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomTargetType(new GetCustomTargetTypeRequest
            {
                CustomTargetTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single CustomTargetType.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `CustomTargetType`. Format must be
        /// `projects/{project_id}/locations/{location_name}/customTargetTypes/{custom_target_type}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomTargetType> GetCustomTargetTypeAsync(CustomTargetTypeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomTargetTypeAsync(new GetCustomTargetTypeRequest
            {
                CustomTargetTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single CustomTargetType.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `CustomTargetType`. Format must be
        /// `projects/{project_id}/locations/{location_name}/customTargetTypes/{custom_target_type}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomTargetType> GetCustomTargetTypeAsync(CustomTargetTypeName name, st::CancellationToken cancellationToken) =>
            GetCustomTargetTypeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new CustomTargetType in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CustomTargetType, OperationMetadata> CreateCustomTargetType(CreateCustomTargetTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new CustomTargetType in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CustomTargetType, OperationMetadata>> CreateCustomTargetTypeAsync(CreateCustomTargetTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new CustomTargetType in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CustomTargetType, OperationMetadata>> CreateCustomTargetTypeAsync(CreateCustomTargetTypeRequest request, st::CancellationToken cancellationToken) =>
            CreateCustomTargetTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateCustomTargetType</c>.</summary>
        public virtual lro::OperationsClient CreateCustomTargetTypeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateCustomTargetType</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CustomTargetType, OperationMetadata> PollOnceCreateCustomTargetType(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CustomTargetType, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateCustomTargetTypeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateCustomTargetType</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CustomTargetType, OperationMetadata>> PollOnceCreateCustomTargetTypeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CustomTargetType, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateCustomTargetTypeOperationsClient, callSettings);

        /// <summary>
        /// Creates a new CustomTargetType in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `CustomTargetType` must be
        /// created. The format is `projects/{project_id}/locations/{location_name}`.
        /// </param>
        /// <param name="customTargetType">
        /// Required. The `CustomTargetType` to create.
        /// </param>
        /// <param name="customTargetTypeId">
        /// Required. ID of the `CustomTargetType`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CustomTargetType, OperationMetadata> CreateCustomTargetType(string parent, CustomTargetType customTargetType, string customTargetTypeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCustomTargetType(new CreateCustomTargetTypeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CustomTargetTypeId = gax::GaxPreconditions.CheckNotNullOrEmpty(customTargetTypeId, nameof(customTargetTypeId)),
                CustomTargetType = gax::GaxPreconditions.CheckNotNull(customTargetType, nameof(customTargetType)),
            }, callSettings);

        /// <summary>
        /// Creates a new CustomTargetType in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `CustomTargetType` must be
        /// created. The format is `projects/{project_id}/locations/{location_name}`.
        /// </param>
        /// <param name="customTargetType">
        /// Required. The `CustomTargetType` to create.
        /// </param>
        /// <param name="customTargetTypeId">
        /// Required. ID of the `CustomTargetType`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CustomTargetType, OperationMetadata>> CreateCustomTargetTypeAsync(string parent, CustomTargetType customTargetType, string customTargetTypeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCustomTargetTypeAsync(new CreateCustomTargetTypeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CustomTargetTypeId = gax::GaxPreconditions.CheckNotNullOrEmpty(customTargetTypeId, nameof(customTargetTypeId)),
                CustomTargetType = gax::GaxPreconditions.CheckNotNull(customTargetType, nameof(customTargetType)),
            }, callSettings);

        /// <summary>
        /// Creates a new CustomTargetType in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `CustomTargetType` must be
        /// created. The format is `projects/{project_id}/locations/{location_name}`.
        /// </param>
        /// <param name="customTargetType">
        /// Required. The `CustomTargetType` to create.
        /// </param>
        /// <param name="customTargetTypeId">
        /// Required. ID of the `CustomTargetType`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CustomTargetType, OperationMetadata>> CreateCustomTargetTypeAsync(string parent, CustomTargetType customTargetType, string customTargetTypeId, st::CancellationToken cancellationToken) =>
            CreateCustomTargetTypeAsync(parent, customTargetType, customTargetTypeId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new CustomTargetType in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `CustomTargetType` must be
        /// created. The format is `projects/{project_id}/locations/{location_name}`.
        /// </param>
        /// <param name="customTargetType">
        /// Required. The `CustomTargetType` to create.
        /// </param>
        /// <param name="customTargetTypeId">
        /// Required. ID of the `CustomTargetType`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CustomTargetType, OperationMetadata> CreateCustomTargetType(gagr::LocationName parent, CustomTargetType customTargetType, string customTargetTypeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCustomTargetType(new CreateCustomTargetTypeRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CustomTargetTypeId = gax::GaxPreconditions.CheckNotNullOrEmpty(customTargetTypeId, nameof(customTargetTypeId)),
                CustomTargetType = gax::GaxPreconditions.CheckNotNull(customTargetType, nameof(customTargetType)),
            }, callSettings);

        /// <summary>
        /// Creates a new CustomTargetType in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `CustomTargetType` must be
        /// created. The format is `projects/{project_id}/locations/{location_name}`.
        /// </param>
        /// <param name="customTargetType">
        /// Required. The `CustomTargetType` to create.
        /// </param>
        /// <param name="customTargetTypeId">
        /// Required. ID of the `CustomTargetType`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CustomTargetType, OperationMetadata>> CreateCustomTargetTypeAsync(gagr::LocationName parent, CustomTargetType customTargetType, string customTargetTypeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCustomTargetTypeAsync(new CreateCustomTargetTypeRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CustomTargetTypeId = gax::GaxPreconditions.CheckNotNullOrEmpty(customTargetTypeId, nameof(customTargetTypeId)),
                CustomTargetType = gax::GaxPreconditions.CheckNotNull(customTargetType, nameof(customTargetType)),
            }, callSettings);

        /// <summary>
        /// Creates a new CustomTargetType in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `CustomTargetType` must be
        /// created. The format is `projects/{project_id}/locations/{location_name}`.
        /// </param>
        /// <param name="customTargetType">
        /// Required. The `CustomTargetType` to create.
        /// </param>
        /// <param name="customTargetTypeId">
        /// Required. ID of the `CustomTargetType`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CustomTargetType, OperationMetadata>> CreateCustomTargetTypeAsync(gagr::LocationName parent, CustomTargetType customTargetType, string customTargetTypeId, st::CancellationToken cancellationToken) =>
            CreateCustomTargetTypeAsync(parent, customTargetType, customTargetTypeId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a single CustomTargetType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CustomTargetType, OperationMetadata> UpdateCustomTargetType(UpdateCustomTargetTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a single CustomTargetType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CustomTargetType, OperationMetadata>> UpdateCustomTargetTypeAsync(UpdateCustomTargetTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a single CustomTargetType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CustomTargetType, OperationMetadata>> UpdateCustomTargetTypeAsync(UpdateCustomTargetTypeRequest request, st::CancellationToken cancellationToken) =>
            UpdateCustomTargetTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateCustomTargetType</c>.</summary>
        public virtual lro::OperationsClient UpdateCustomTargetTypeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateCustomTargetType</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CustomTargetType, OperationMetadata> PollOnceUpdateCustomTargetType(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CustomTargetType, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateCustomTargetTypeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateCustomTargetType</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CustomTargetType, OperationMetadata>> PollOnceUpdateCustomTargetTypeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CustomTargetType, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateCustomTargetTypeOperationsClient, callSettings);

        /// <summary>
        /// Updates a single CustomTargetType.
        /// </summary>
        /// <param name="customTargetType">
        /// Required. The `CustomTargetType` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten by the
        /// update in the `CustomTargetType` resource. The fields specified in the
        /// update_mask are relative to the resource, not the full request. A field
        /// will be overwritten if it's in the mask. If the user doesn't provide a mask
        /// then all fields are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CustomTargetType, OperationMetadata> UpdateCustomTargetType(CustomTargetType customTargetType, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCustomTargetType(new UpdateCustomTargetTypeRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                CustomTargetType = gax::GaxPreconditions.CheckNotNull(customTargetType, nameof(customTargetType)),
            }, callSettings);

        /// <summary>
        /// Updates a single CustomTargetType.
        /// </summary>
        /// <param name="customTargetType">
        /// Required. The `CustomTargetType` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten by the
        /// update in the `CustomTargetType` resource. The fields specified in the
        /// update_mask are relative to the resource, not the full request. A field
        /// will be overwritten if it's in the mask. If the user doesn't provide a mask
        /// then all fields are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CustomTargetType, OperationMetadata>> UpdateCustomTargetTypeAsync(CustomTargetType customTargetType, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCustomTargetTypeAsync(new UpdateCustomTargetTypeRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                CustomTargetType = gax::GaxPreconditions.CheckNotNull(customTargetType, nameof(customTargetType)),
            }, callSettings);

        /// <summary>
        /// Updates a single CustomTargetType.
        /// </summary>
        /// <param name="customTargetType">
        /// Required. The `CustomTargetType` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten by the
        /// update in the `CustomTargetType` resource. The fields specified in the
        /// update_mask are relative to the resource, not the full request. A field
        /// will be overwritten if it's in the mask. If the user doesn't provide a mask
        /// then all fields are overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CustomTargetType, OperationMetadata>> UpdateCustomTargetTypeAsync(CustomTargetType customTargetType, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateCustomTargetTypeAsync(customTargetType, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single CustomTargetType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCustomTargetType(DeleteCustomTargetTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single CustomTargetType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCustomTargetTypeAsync(DeleteCustomTargetTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single CustomTargetType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCustomTargetTypeAsync(DeleteCustomTargetTypeRequest request, st::CancellationToken cancellationToken) =>
            DeleteCustomTargetTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteCustomTargetType</c>.</summary>
        public virtual lro::OperationsClient DeleteCustomTargetTypeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteCustomTargetType</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteCustomTargetType(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteCustomTargetTypeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteCustomTargetType</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteCustomTargetTypeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteCustomTargetTypeOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single CustomTargetType.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `CustomTargetType` to delete. Format must be
        /// `projects/{project_id}/locations/{location_name}/customTargetTypes/{custom_target_type}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCustomTargetType(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCustomTargetType(new DeleteCustomTargetTypeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single CustomTargetType.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `CustomTargetType` to delete. Format must be
        /// `projects/{project_id}/locations/{location_name}/customTargetTypes/{custom_target_type}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCustomTargetTypeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCustomTargetTypeAsync(new DeleteCustomTargetTypeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single CustomTargetType.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `CustomTargetType` to delete. Format must be
        /// `projects/{project_id}/locations/{location_name}/customTargetTypes/{custom_target_type}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCustomTargetTypeAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteCustomTargetTypeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single CustomTargetType.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `CustomTargetType` to delete. Format must be
        /// `projects/{project_id}/locations/{location_name}/customTargetTypes/{custom_target_type}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCustomTargetType(CustomTargetTypeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCustomTargetType(new DeleteCustomTargetTypeRequest
            {
                CustomTargetTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single CustomTargetType.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `CustomTargetType` to delete. Format must be
        /// `projects/{project_id}/locations/{location_name}/customTargetTypes/{custom_target_type}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCustomTargetTypeAsync(CustomTargetTypeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCustomTargetTypeAsync(new DeleteCustomTargetTypeRequest
            {
                CustomTargetTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single CustomTargetType.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `CustomTargetType` to delete. Format must be
        /// `projects/{project_id}/locations/{location_name}/customTargetTypes/{custom_target_type}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCustomTargetTypeAsync(CustomTargetTypeName name, st::CancellationToken cancellationToken) =>
            DeleteCustomTargetTypeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// Required. The `DeliveryPipeline` which owns this collection of `Release`
        /// objects.
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
        /// Required. The `DeliveryPipeline` which owns this collection of `Release`
        /// objects.
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
        /// Required. The `DeliveryPipeline` which owns this collection of `Release`
        /// objects.
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
        /// Required. The `DeliveryPipeline` which owns this collection of `Release`
        /// objects.
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
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}`.
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
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}`.
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
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}`.
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
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}`.
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
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}`.
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
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}`.
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
        /// Required. The parent collection in which the `Release` is created.
        /// The format is
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
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
        /// Required. The parent collection in which the `Release` is created.
        /// The format is
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
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
        /// Required. The parent collection in which the `Release` is created.
        /// The format is
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
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
        /// Required. The parent collection in which the `Release` is created.
        /// The format is
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
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
        /// Required. The parent collection in which the `Release` is created.
        /// The format is
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
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
        /// Required. The parent collection in which the `Release` is created.
        /// The format is
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
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
        /// Abandons a Release in the Delivery Pipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AbandonReleaseResponse AbandonRelease(AbandonReleaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Abandons a Release in the Delivery Pipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AbandonReleaseResponse> AbandonReleaseAsync(AbandonReleaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Abandons a Release in the Delivery Pipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AbandonReleaseResponse> AbandonReleaseAsync(AbandonReleaseRequest request, st::CancellationToken cancellationToken) =>
            AbandonReleaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Abandons a Release in the Delivery Pipeline.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Release. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AbandonReleaseResponse AbandonRelease(string name, gaxgrpc::CallSettings callSettings = null) =>
            AbandonRelease(new AbandonReleaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Abandons a Release in the Delivery Pipeline.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Release. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AbandonReleaseResponse> AbandonReleaseAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            AbandonReleaseAsync(new AbandonReleaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Abandons a Release in the Delivery Pipeline.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Release. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AbandonReleaseResponse> AbandonReleaseAsync(string name, st::CancellationToken cancellationToken) =>
            AbandonReleaseAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Abandons a Release in the Delivery Pipeline.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Release. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AbandonReleaseResponse AbandonRelease(ReleaseName name, gaxgrpc::CallSettings callSettings = null) =>
            AbandonRelease(new AbandonReleaseRequest
            {
                ReleaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Abandons a Release in the Delivery Pipeline.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Release. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AbandonReleaseResponse> AbandonReleaseAsync(ReleaseName name, gaxgrpc::CallSettings callSettings = null) =>
            AbandonReleaseAsync(new AbandonReleaseRequest
            {
                ReleaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Abandons a Release in the Delivery Pipeline.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Release. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AbandonReleaseResponse> AbandonReleaseAsync(ReleaseName name, st::CancellationToken cancellationToken) =>
            AbandonReleaseAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new DeployPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeployPolicy, OperationMetadata> CreateDeployPolicy(CreateDeployPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new DeployPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployPolicy, OperationMetadata>> CreateDeployPolicyAsync(CreateDeployPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new DeployPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployPolicy, OperationMetadata>> CreateDeployPolicyAsync(CreateDeployPolicyRequest request, st::CancellationToken cancellationToken) =>
            CreateDeployPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateDeployPolicy</c>.</summary>
        public virtual lro::OperationsClient CreateDeployPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateDeployPolicy</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DeployPolicy, OperationMetadata> PollOnceCreateDeployPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DeployPolicy, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDeployPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateDeployPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DeployPolicy, OperationMetadata>> PollOnceCreateDeployPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DeployPolicy, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDeployPolicyOperationsClient, callSettings);

        /// <summary>
        /// Creates a new DeployPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `DeployPolicy` must be
        /// created. The format is `projects/{project_id}/locations/{location_name}`.
        /// </param>
        /// <param name="deployPolicy">
        /// Required. The `DeployPolicy` to create.
        /// </param>
        /// <param name="deployPolicyId">
        /// Required. ID of the `DeployPolicy`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeployPolicy, OperationMetadata> CreateDeployPolicy(string parent, DeployPolicy deployPolicy, string deployPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeployPolicy(new CreateDeployPolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DeployPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(deployPolicyId, nameof(deployPolicyId)),
                DeployPolicy = gax::GaxPreconditions.CheckNotNull(deployPolicy, nameof(deployPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new DeployPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `DeployPolicy` must be
        /// created. The format is `projects/{project_id}/locations/{location_name}`.
        /// </param>
        /// <param name="deployPolicy">
        /// Required. The `DeployPolicy` to create.
        /// </param>
        /// <param name="deployPolicyId">
        /// Required. ID of the `DeployPolicy`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployPolicy, OperationMetadata>> CreateDeployPolicyAsync(string parent, DeployPolicy deployPolicy, string deployPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeployPolicyAsync(new CreateDeployPolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DeployPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(deployPolicyId, nameof(deployPolicyId)),
                DeployPolicy = gax::GaxPreconditions.CheckNotNull(deployPolicy, nameof(deployPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new DeployPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `DeployPolicy` must be
        /// created. The format is `projects/{project_id}/locations/{location_name}`.
        /// </param>
        /// <param name="deployPolicy">
        /// Required. The `DeployPolicy` to create.
        /// </param>
        /// <param name="deployPolicyId">
        /// Required. ID of the `DeployPolicy`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployPolicy, OperationMetadata>> CreateDeployPolicyAsync(string parent, DeployPolicy deployPolicy, string deployPolicyId, st::CancellationToken cancellationToken) =>
            CreateDeployPolicyAsync(parent, deployPolicy, deployPolicyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new DeployPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `DeployPolicy` must be
        /// created. The format is `projects/{project_id}/locations/{location_name}`.
        /// </param>
        /// <param name="deployPolicy">
        /// Required. The `DeployPolicy` to create.
        /// </param>
        /// <param name="deployPolicyId">
        /// Required. ID of the `DeployPolicy`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeployPolicy, OperationMetadata> CreateDeployPolicy(gagr::LocationName parent, DeployPolicy deployPolicy, string deployPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeployPolicy(new CreateDeployPolicyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DeployPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(deployPolicyId, nameof(deployPolicyId)),
                DeployPolicy = gax::GaxPreconditions.CheckNotNull(deployPolicy, nameof(deployPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new DeployPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `DeployPolicy` must be
        /// created. The format is `projects/{project_id}/locations/{location_name}`.
        /// </param>
        /// <param name="deployPolicy">
        /// Required. The `DeployPolicy` to create.
        /// </param>
        /// <param name="deployPolicyId">
        /// Required. ID of the `DeployPolicy`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployPolicy, OperationMetadata>> CreateDeployPolicyAsync(gagr::LocationName parent, DeployPolicy deployPolicy, string deployPolicyId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeployPolicyAsync(new CreateDeployPolicyRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DeployPolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(deployPolicyId, nameof(deployPolicyId)),
                DeployPolicy = gax::GaxPreconditions.CheckNotNull(deployPolicy, nameof(deployPolicy)),
            }, callSettings);

        /// <summary>
        /// Creates a new DeployPolicy in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `DeployPolicy` must be
        /// created. The format is `projects/{project_id}/locations/{location_name}`.
        /// </param>
        /// <param name="deployPolicy">
        /// Required. The `DeployPolicy` to create.
        /// </param>
        /// <param name="deployPolicyId">
        /// Required. ID of the `DeployPolicy`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployPolicy, OperationMetadata>> CreateDeployPolicyAsync(gagr::LocationName parent, DeployPolicy deployPolicy, string deployPolicyId, st::CancellationToken cancellationToken) =>
            CreateDeployPolicyAsync(parent, deployPolicy, deployPolicyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single DeployPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeployPolicy, OperationMetadata> UpdateDeployPolicy(UpdateDeployPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single DeployPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployPolicy, OperationMetadata>> UpdateDeployPolicyAsync(UpdateDeployPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single DeployPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployPolicy, OperationMetadata>> UpdateDeployPolicyAsync(UpdateDeployPolicyRequest request, st::CancellationToken cancellationToken) =>
            UpdateDeployPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateDeployPolicy</c>.</summary>
        public virtual lro::OperationsClient UpdateDeployPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateDeployPolicy</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DeployPolicy, OperationMetadata> PollOnceUpdateDeployPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DeployPolicy, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDeployPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateDeployPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DeployPolicy, OperationMetadata>> PollOnceUpdateDeployPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DeployPolicy, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDeployPolicyOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single DeployPolicy.
        /// </summary>
        /// <param name="deployPolicy">
        /// Required. The `DeployPolicy` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten by the
        /// update in the `DeployPolicy` resource. The fields specified in the
        /// update_mask are relative to the resource, not the full request. A field
        /// will be overwritten if it's in the mask. If the user doesn't provide a mask
        /// then all fields are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeployPolicy, OperationMetadata> UpdateDeployPolicy(DeployPolicy deployPolicy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDeployPolicy(new UpdateDeployPolicyRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                DeployPolicy = gax::GaxPreconditions.CheckNotNull(deployPolicy, nameof(deployPolicy)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single DeployPolicy.
        /// </summary>
        /// <param name="deployPolicy">
        /// Required. The `DeployPolicy` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten by the
        /// update in the `DeployPolicy` resource. The fields specified in the
        /// update_mask are relative to the resource, not the full request. A field
        /// will be overwritten if it's in the mask. If the user doesn't provide a mask
        /// then all fields are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployPolicy, OperationMetadata>> UpdateDeployPolicyAsync(DeployPolicy deployPolicy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDeployPolicyAsync(new UpdateDeployPolicyRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                DeployPolicy = gax::GaxPreconditions.CheckNotNull(deployPolicy, nameof(deployPolicy)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single DeployPolicy.
        /// </summary>
        /// <param name="deployPolicy">
        /// Required. The `DeployPolicy` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten by the
        /// update in the `DeployPolicy` resource. The fields specified in the
        /// update_mask are relative to the resource, not the full request. A field
        /// will be overwritten if it's in the mask. If the user doesn't provide a mask
        /// then all fields are overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployPolicy, OperationMetadata>> UpdateDeployPolicyAsync(DeployPolicy deployPolicy, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDeployPolicyAsync(deployPolicy, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single DeployPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDeployPolicy(DeleteDeployPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single DeployPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDeployPolicyAsync(DeleteDeployPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single DeployPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDeployPolicyAsync(DeleteDeployPolicyRequest request, st::CancellationToken cancellationToken) =>
            DeleteDeployPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteDeployPolicy</c>.</summary>
        public virtual lro::OperationsClient DeleteDeployPolicyOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteDeployPolicy</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteDeployPolicy(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDeployPolicyOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteDeployPolicy</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteDeployPolicyAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDeployPolicyOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single DeployPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `DeployPolicy` to delete. The format is
        /// `projects/{project_id}/locations/{location_name}/deployPolicies/{deploy_policy_name}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDeployPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDeployPolicy(new DeleteDeployPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single DeployPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `DeployPolicy` to delete. The format is
        /// `projects/{project_id}/locations/{location_name}/deployPolicies/{deploy_policy_name}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDeployPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDeployPolicyAsync(new DeleteDeployPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single DeployPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `DeployPolicy` to delete. The format is
        /// `projects/{project_id}/locations/{location_name}/deployPolicies/{deploy_policy_name}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDeployPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDeployPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single DeployPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `DeployPolicy` to delete. The format is
        /// `projects/{project_id}/locations/{location_name}/deployPolicies/{deploy_policy_name}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDeployPolicy(DeployPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDeployPolicy(new DeleteDeployPolicyRequest
            {
                DeployPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single DeployPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `DeployPolicy` to delete. The format is
        /// `projects/{project_id}/locations/{location_name}/deployPolicies/{deploy_policy_name}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDeployPolicyAsync(DeployPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDeployPolicyAsync(new DeleteDeployPolicyRequest
            {
                DeployPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single DeployPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `DeployPolicy` to delete. The format is
        /// `projects/{project_id}/locations/{location_name}/deployPolicies/{deploy_policy_name}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDeployPolicyAsync(DeployPolicyName name, st::CancellationToken cancellationToken) =>
            DeleteDeployPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists DeployPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DeployPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeployPoliciesResponse, DeployPolicy> ListDeployPolicies(ListDeployPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists DeployPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DeployPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeployPoliciesResponse, DeployPolicy> ListDeployPoliciesAsync(ListDeployPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists DeployPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of deploy policies. Format
        /// must be `projects/{project_id}/locations/{location_name}`.
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
        /// <returns>A pageable sequence of <see cref="DeployPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeployPoliciesResponse, DeployPolicy> ListDeployPolicies(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDeployPolicies(new ListDeployPoliciesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists DeployPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of deploy policies. Format
        /// must be `projects/{project_id}/locations/{location_name}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DeployPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeployPoliciesResponse, DeployPolicy> ListDeployPoliciesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDeployPoliciesAsync(new ListDeployPoliciesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists DeployPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of deploy policies. Format
        /// must be `projects/{project_id}/locations/{location_name}`.
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
        /// <returns>A pageable sequence of <see cref="DeployPolicy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeployPoliciesResponse, DeployPolicy> ListDeployPolicies(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDeployPolicies(new ListDeployPoliciesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists DeployPolicies in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of deploy policies. Format
        /// must be `projects/{project_id}/locations/{location_name}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DeployPolicy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeployPoliciesResponse, DeployPolicy> ListDeployPoliciesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDeployPoliciesAsync(new ListDeployPoliciesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets details of a single DeployPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeployPolicy GetDeployPolicy(GetDeployPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single DeployPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeployPolicy> GetDeployPolicyAsync(GetDeployPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single DeployPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeployPolicy> GetDeployPolicyAsync(GetDeployPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetDeployPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single DeployPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `DeployPolicy`. Format must be
        /// `projects/{project_id}/locations/{location_name}/deployPolicies/{deploy_policy_name}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeployPolicy GetDeployPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeployPolicy(new GetDeployPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single DeployPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `DeployPolicy`. Format must be
        /// `projects/{project_id}/locations/{location_name}/deployPolicies/{deploy_policy_name}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeployPolicy> GetDeployPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeployPolicyAsync(new GetDeployPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single DeployPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `DeployPolicy`. Format must be
        /// `projects/{project_id}/locations/{location_name}/deployPolicies/{deploy_policy_name}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeployPolicy> GetDeployPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            GetDeployPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single DeployPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `DeployPolicy`. Format must be
        /// `projects/{project_id}/locations/{location_name}/deployPolicies/{deploy_policy_name}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeployPolicy GetDeployPolicy(DeployPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeployPolicy(new GetDeployPolicyRequest
            {
                DeployPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single DeployPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `DeployPolicy`. Format must be
        /// `projects/{project_id}/locations/{location_name}/deployPolicies/{deploy_policy_name}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeployPolicy> GetDeployPolicyAsync(DeployPolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeployPolicyAsync(new GetDeployPolicyRequest
            {
                DeployPolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single DeployPolicy.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `DeployPolicy`. Format must be
        /// `projects/{project_id}/locations/{location_name}/deployPolicies/{deploy_policy_name}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeployPolicy> GetDeployPolicyAsync(DeployPolicyName name, st::CancellationToken cancellationToken) =>
            GetDeployPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
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
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
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
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
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
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
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
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
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
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApproveRolloutResponse> ApproveRolloutAsync(RolloutName name, st::CancellationToken cancellationToken) =>
            ApproveRolloutAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Advances a Rollout in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AdvanceRolloutResponse AdvanceRollout(AdvanceRolloutRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Advances a Rollout in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdvanceRolloutResponse> AdvanceRolloutAsync(AdvanceRolloutRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Advances a Rollout in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdvanceRolloutResponse> AdvanceRolloutAsync(AdvanceRolloutRequest request, st::CancellationToken cancellationToken) =>
            AdvanceRolloutAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Advances a Rollout in a given project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Rollout. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
        /// </param>
        /// <param name="phaseId">
        /// Required. The phase ID to advance the `Rollout` to.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AdvanceRolloutResponse AdvanceRollout(string name, string phaseId, gaxgrpc::CallSettings callSettings = null) =>
            AdvanceRollout(new AdvanceRolloutRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                PhaseId = gax::GaxPreconditions.CheckNotNullOrEmpty(phaseId, nameof(phaseId)),
            }, callSettings);

        /// <summary>
        /// Advances a Rollout in a given project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Rollout. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
        /// </param>
        /// <param name="phaseId">
        /// Required. The phase ID to advance the `Rollout` to.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdvanceRolloutResponse> AdvanceRolloutAsync(string name, string phaseId, gaxgrpc::CallSettings callSettings = null) =>
            AdvanceRolloutAsync(new AdvanceRolloutRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                PhaseId = gax::GaxPreconditions.CheckNotNullOrEmpty(phaseId, nameof(phaseId)),
            }, callSettings);

        /// <summary>
        /// Advances a Rollout in a given project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Rollout. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
        /// </param>
        /// <param name="phaseId">
        /// Required. The phase ID to advance the `Rollout` to.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdvanceRolloutResponse> AdvanceRolloutAsync(string name, string phaseId, st::CancellationToken cancellationToken) =>
            AdvanceRolloutAsync(name, phaseId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Advances a Rollout in a given project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Rollout. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
        /// </param>
        /// <param name="phaseId">
        /// Required. The phase ID to advance the `Rollout` to.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AdvanceRolloutResponse AdvanceRollout(RolloutName name, string phaseId, gaxgrpc::CallSettings callSettings = null) =>
            AdvanceRollout(new AdvanceRolloutRequest
            {
                RolloutName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                PhaseId = gax::GaxPreconditions.CheckNotNullOrEmpty(phaseId, nameof(phaseId)),
            }, callSettings);

        /// <summary>
        /// Advances a Rollout in a given project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Rollout. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
        /// </param>
        /// <param name="phaseId">
        /// Required. The phase ID to advance the `Rollout` to.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdvanceRolloutResponse> AdvanceRolloutAsync(RolloutName name, string phaseId, gaxgrpc::CallSettings callSettings = null) =>
            AdvanceRolloutAsync(new AdvanceRolloutRequest
            {
                RolloutName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                PhaseId = gax::GaxPreconditions.CheckNotNullOrEmpty(phaseId, nameof(phaseId)),
            }, callSettings);

        /// <summary>
        /// Advances a Rollout in a given project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Rollout. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
        /// </param>
        /// <param name="phaseId">
        /// Required. The phase ID to advance the `Rollout` to.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AdvanceRolloutResponse> AdvanceRolloutAsync(RolloutName name, string phaseId, st::CancellationToken cancellationToken) =>
            AdvanceRolloutAsync(name, phaseId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels a Rollout in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CancelRolloutResponse CancelRollout(CancelRolloutRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels a Rollout in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CancelRolloutResponse> CancelRolloutAsync(CancelRolloutRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels a Rollout in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CancelRolloutResponse> CancelRolloutAsync(CancelRolloutRequest request, st::CancellationToken cancellationToken) =>
            CancelRolloutAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels a Rollout in a given project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Rollout. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CancelRolloutResponse CancelRollout(string name, gaxgrpc::CallSettings callSettings = null) =>
            CancelRollout(new CancelRolloutRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels a Rollout in a given project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Rollout. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CancelRolloutResponse> CancelRolloutAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            CancelRolloutAsync(new CancelRolloutRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels a Rollout in a given project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Rollout. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CancelRolloutResponse> CancelRolloutAsync(string name, st::CancellationToken cancellationToken) =>
            CancelRolloutAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels a Rollout in a given project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Rollout. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CancelRolloutResponse CancelRollout(RolloutName name, gaxgrpc::CallSettings callSettings = null) =>
            CancelRollout(new CancelRolloutRequest
            {
                RolloutName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels a Rollout in a given project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Rollout. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CancelRolloutResponse> CancelRolloutAsync(RolloutName name, gaxgrpc::CallSettings callSettings = null) =>
            CancelRolloutAsync(new CancelRolloutRequest
            {
                RolloutName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels a Rollout in a given project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Rollout. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CancelRolloutResponse> CancelRolloutAsync(RolloutName name, st::CancellationToken cancellationToken) =>
            CancelRolloutAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}/rollouts/{rollout_name}`.
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
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}/rollouts/{rollout_name}`.
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
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}/rollouts/{rollout_name}`.
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
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}/rollouts/{rollout_name}`.
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
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}/rollouts/{rollout_name}`.
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
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}/rollouts/{rollout_name}`.
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
        /// Required. The parent collection in which the `Rollout` must be created.
        /// The format is
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}`.
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
        /// Required. The parent collection in which the `Rollout` must be created.
        /// The format is
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}`.
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
        /// Required. The parent collection in which the `Rollout` must be created.
        /// The format is
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}`.
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
        /// Required. The parent collection in which the `Rollout` must be created.
        /// The format is
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}`.
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
        /// Required. The parent collection in which the `Rollout` must be created.
        /// The format is
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}`.
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
        /// Required. The parent collection in which the `Rollout` must be created.
        /// The format is
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}`.
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
        /// Ignores the specified Job in a Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IgnoreJobResponse IgnoreJob(IgnoreJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Ignores the specified Job in a Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IgnoreJobResponse> IgnoreJobAsync(IgnoreJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Ignores the specified Job in a Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IgnoreJobResponse> IgnoreJobAsync(IgnoreJobRequest request, st::CancellationToken cancellationToken) =>
            IgnoreJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Ignores the specified Job in a Rollout.
        /// </summary>
        /// <param name="rollout">
        /// Required. Name of the Rollout. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
        /// </param>
        /// <param name="phaseId">
        /// Required. The phase ID the Job to ignore belongs to.
        /// </param>
        /// <param name="jobId">
        /// Required. The job ID for the Job to ignore.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IgnoreJobResponse IgnoreJob(string rollout, string phaseId, string jobId, gaxgrpc::CallSettings callSettings = null) =>
            IgnoreJob(new IgnoreJobRequest
            {
                Rollout = gax::GaxPreconditions.CheckNotNullOrEmpty(rollout, nameof(rollout)),
                PhaseId = gax::GaxPreconditions.CheckNotNullOrEmpty(phaseId, nameof(phaseId)),
                JobId = gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)),
            }, callSettings);

        /// <summary>
        /// Ignores the specified Job in a Rollout.
        /// </summary>
        /// <param name="rollout">
        /// Required. Name of the Rollout. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
        /// </param>
        /// <param name="phaseId">
        /// Required. The phase ID the Job to ignore belongs to.
        /// </param>
        /// <param name="jobId">
        /// Required. The job ID for the Job to ignore.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IgnoreJobResponse> IgnoreJobAsync(string rollout, string phaseId, string jobId, gaxgrpc::CallSettings callSettings = null) =>
            IgnoreJobAsync(new IgnoreJobRequest
            {
                Rollout = gax::GaxPreconditions.CheckNotNullOrEmpty(rollout, nameof(rollout)),
                PhaseId = gax::GaxPreconditions.CheckNotNullOrEmpty(phaseId, nameof(phaseId)),
                JobId = gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)),
            }, callSettings);

        /// <summary>
        /// Ignores the specified Job in a Rollout.
        /// </summary>
        /// <param name="rollout">
        /// Required. Name of the Rollout. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
        /// </param>
        /// <param name="phaseId">
        /// Required. The phase ID the Job to ignore belongs to.
        /// </param>
        /// <param name="jobId">
        /// Required. The job ID for the Job to ignore.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IgnoreJobResponse> IgnoreJobAsync(string rollout, string phaseId, string jobId, st::CancellationToken cancellationToken) =>
            IgnoreJobAsync(rollout, phaseId, jobId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Ignores the specified Job in a Rollout.
        /// </summary>
        /// <param name="rollout">
        /// Required. Name of the Rollout. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
        /// </param>
        /// <param name="phaseId">
        /// Required. The phase ID the Job to ignore belongs to.
        /// </param>
        /// <param name="jobId">
        /// Required. The job ID for the Job to ignore.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual IgnoreJobResponse IgnoreJob(RolloutName rollout, string phaseId, string jobId, gaxgrpc::CallSettings callSettings = null) =>
            IgnoreJob(new IgnoreJobRequest
            {
                RolloutAsRolloutName = gax::GaxPreconditions.CheckNotNull(rollout, nameof(rollout)),
                PhaseId = gax::GaxPreconditions.CheckNotNullOrEmpty(phaseId, nameof(phaseId)),
                JobId = gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)),
            }, callSettings);

        /// <summary>
        /// Ignores the specified Job in a Rollout.
        /// </summary>
        /// <param name="rollout">
        /// Required. Name of the Rollout. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
        /// </param>
        /// <param name="phaseId">
        /// Required. The phase ID the Job to ignore belongs to.
        /// </param>
        /// <param name="jobId">
        /// Required. The job ID for the Job to ignore.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IgnoreJobResponse> IgnoreJobAsync(RolloutName rollout, string phaseId, string jobId, gaxgrpc::CallSettings callSettings = null) =>
            IgnoreJobAsync(new IgnoreJobRequest
            {
                RolloutAsRolloutName = gax::GaxPreconditions.CheckNotNull(rollout, nameof(rollout)),
                PhaseId = gax::GaxPreconditions.CheckNotNullOrEmpty(phaseId, nameof(phaseId)),
                JobId = gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)),
            }, callSettings);

        /// <summary>
        /// Ignores the specified Job in a Rollout.
        /// </summary>
        /// <param name="rollout">
        /// Required. Name of the Rollout. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
        /// </param>
        /// <param name="phaseId">
        /// Required. The phase ID the Job to ignore belongs to.
        /// </param>
        /// <param name="jobId">
        /// Required. The job ID for the Job to ignore.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<IgnoreJobResponse> IgnoreJobAsync(RolloutName rollout, string phaseId, string jobId, st::CancellationToken cancellationToken) =>
            IgnoreJobAsync(rollout, phaseId, jobId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retries the specified Job in a Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RetryJobResponse RetryJob(RetryJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retries the specified Job in a Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetryJobResponse> RetryJobAsync(RetryJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retries the specified Job in a Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetryJobResponse> RetryJobAsync(RetryJobRequest request, st::CancellationToken cancellationToken) =>
            RetryJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retries the specified Job in a Rollout.
        /// </summary>
        /// <param name="rollout">
        /// Required. Name of the Rollout. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
        /// </param>
        /// <param name="phaseId">
        /// Required. The phase ID the Job to retry belongs to.
        /// </param>
        /// <param name="jobId">
        /// Required. The job ID for the Job to retry.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RetryJobResponse RetryJob(string rollout, string phaseId, string jobId, gaxgrpc::CallSettings callSettings = null) =>
            RetryJob(new RetryJobRequest
            {
                Rollout = gax::GaxPreconditions.CheckNotNullOrEmpty(rollout, nameof(rollout)),
                PhaseId = gax::GaxPreconditions.CheckNotNullOrEmpty(phaseId, nameof(phaseId)),
                JobId = gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)),
            }, callSettings);

        /// <summary>
        /// Retries the specified Job in a Rollout.
        /// </summary>
        /// <param name="rollout">
        /// Required. Name of the Rollout. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
        /// </param>
        /// <param name="phaseId">
        /// Required. The phase ID the Job to retry belongs to.
        /// </param>
        /// <param name="jobId">
        /// Required. The job ID for the Job to retry.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetryJobResponse> RetryJobAsync(string rollout, string phaseId, string jobId, gaxgrpc::CallSettings callSettings = null) =>
            RetryJobAsync(new RetryJobRequest
            {
                Rollout = gax::GaxPreconditions.CheckNotNullOrEmpty(rollout, nameof(rollout)),
                PhaseId = gax::GaxPreconditions.CheckNotNullOrEmpty(phaseId, nameof(phaseId)),
                JobId = gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)),
            }, callSettings);

        /// <summary>
        /// Retries the specified Job in a Rollout.
        /// </summary>
        /// <param name="rollout">
        /// Required. Name of the Rollout. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
        /// </param>
        /// <param name="phaseId">
        /// Required. The phase ID the Job to retry belongs to.
        /// </param>
        /// <param name="jobId">
        /// Required. The job ID for the Job to retry.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetryJobResponse> RetryJobAsync(string rollout, string phaseId, string jobId, st::CancellationToken cancellationToken) =>
            RetryJobAsync(rollout, phaseId, jobId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retries the specified Job in a Rollout.
        /// </summary>
        /// <param name="rollout">
        /// Required. Name of the Rollout. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
        /// </param>
        /// <param name="phaseId">
        /// Required. The phase ID the Job to retry belongs to.
        /// </param>
        /// <param name="jobId">
        /// Required. The job ID for the Job to retry.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RetryJobResponse RetryJob(RolloutName rollout, string phaseId, string jobId, gaxgrpc::CallSettings callSettings = null) =>
            RetryJob(new RetryJobRequest
            {
                RolloutAsRolloutName = gax::GaxPreconditions.CheckNotNull(rollout, nameof(rollout)),
                PhaseId = gax::GaxPreconditions.CheckNotNullOrEmpty(phaseId, nameof(phaseId)),
                JobId = gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)),
            }, callSettings);

        /// <summary>
        /// Retries the specified Job in a Rollout.
        /// </summary>
        /// <param name="rollout">
        /// Required. Name of the Rollout. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
        /// </param>
        /// <param name="phaseId">
        /// Required. The phase ID the Job to retry belongs to.
        /// </param>
        /// <param name="jobId">
        /// Required. The job ID for the Job to retry.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetryJobResponse> RetryJobAsync(RolloutName rollout, string phaseId, string jobId, gaxgrpc::CallSettings callSettings = null) =>
            RetryJobAsync(new RetryJobRequest
            {
                RolloutAsRolloutName = gax::GaxPreconditions.CheckNotNull(rollout, nameof(rollout)),
                PhaseId = gax::GaxPreconditions.CheckNotNullOrEmpty(phaseId, nameof(phaseId)),
                JobId = gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)),
            }, callSettings);

        /// <summary>
        /// Retries the specified Job in a Rollout.
        /// </summary>
        /// <param name="rollout">
        /// Required. Name of the Rollout. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}`.
        /// </param>
        /// <param name="phaseId">
        /// Required. The phase ID the Job to retry belongs to.
        /// </param>
        /// <param name="jobId">
        /// Required. The job ID for the Job to retry.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RetryJobResponse> RetryJobAsync(RolloutName rollout, string phaseId, string jobId, st::CancellationToken cancellationToken) =>
            RetryJobAsync(rollout, phaseId, jobId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists JobRuns in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="JobRun"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListJobRunsResponse, JobRun> ListJobRuns(ListJobRunsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists JobRuns in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="JobRun"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListJobRunsResponse, JobRun> ListJobRunsAsync(ListJobRunsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists JobRuns in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The `Rollout` which owns this collection of `JobRun` objects.
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
        /// <returns>A pageable sequence of <see cref="JobRun"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListJobRunsResponse, JobRun> ListJobRuns(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListJobRuns(new ListJobRunsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists JobRuns in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The `Rollout` which owns this collection of `JobRun` objects.
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
        /// <returns>A pageable asynchronous sequence of <see cref="JobRun"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListJobRunsResponse, JobRun> ListJobRunsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListJobRunsAsync(new ListJobRunsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists JobRuns in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The `Rollout` which owns this collection of `JobRun` objects.
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
        /// <returns>A pageable sequence of <see cref="JobRun"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListJobRunsResponse, JobRun> ListJobRuns(RolloutName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListJobRuns(new ListJobRunsRequest
            {
                ParentAsRolloutName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists JobRuns in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The `Rollout` which owns this collection of `JobRun` objects.
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
        /// <returns>A pageable asynchronous sequence of <see cref="JobRun"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListJobRunsResponse, JobRun> ListJobRunsAsync(RolloutName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListJobRunsAsync(new ListJobRunsRequest
            {
                ParentAsRolloutName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets details of a single JobRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual JobRun GetJobRun(GetJobRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single JobRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<JobRun> GetJobRunAsync(GetJobRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single JobRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<JobRun> GetJobRunAsync(GetJobRunRequest request, st::CancellationToken cancellationToken) =>
            GetJobRunAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single JobRun.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `JobRun`. Format must be
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}/rollouts/{rollout_name}/jobRuns/{job_run_name}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual JobRun GetJobRun(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetJobRun(new GetJobRunRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single JobRun.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `JobRun`. Format must be
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}/rollouts/{rollout_name}/jobRuns/{job_run_name}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<JobRun> GetJobRunAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetJobRunAsync(new GetJobRunRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single JobRun.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `JobRun`. Format must be
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}/rollouts/{rollout_name}/jobRuns/{job_run_name}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<JobRun> GetJobRunAsync(string name, st::CancellationToken cancellationToken) =>
            GetJobRunAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single JobRun.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `JobRun`. Format must be
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}/rollouts/{rollout_name}/jobRuns/{job_run_name}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual JobRun GetJobRun(JobRunName name, gaxgrpc::CallSettings callSettings = null) =>
            GetJobRun(new GetJobRunRequest
            {
                JobRunName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single JobRun.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `JobRun`. Format must be
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}/rollouts/{rollout_name}/jobRuns/{job_run_name}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<JobRun> GetJobRunAsync(JobRunName name, gaxgrpc::CallSettings callSettings = null) =>
            GetJobRunAsync(new GetJobRunRequest
            {
                JobRunName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single JobRun.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `JobRun`. Format must be
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/releases/{release_name}/rollouts/{rollout_name}/jobRuns/{job_run_name}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<JobRun> GetJobRunAsync(JobRunName name, st::CancellationToken cancellationToken) =>
            GetJobRunAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Terminates a Job Run in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TerminateJobRunResponse TerminateJobRun(TerminateJobRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Terminates a Job Run in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TerminateJobRunResponse> TerminateJobRunAsync(TerminateJobRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Terminates a Job Run in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TerminateJobRunResponse> TerminateJobRunAsync(TerminateJobRunRequest request, st::CancellationToken cancellationToken) =>
            TerminateJobRunAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Terminates a Job Run in a given project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `JobRun`. Format must be
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}/jobRuns/{jobRun}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TerminateJobRunResponse TerminateJobRun(string name, gaxgrpc::CallSettings callSettings = null) =>
            TerminateJobRun(new TerminateJobRunRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Terminates a Job Run in a given project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `JobRun`. Format must be
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}/jobRuns/{jobRun}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TerminateJobRunResponse> TerminateJobRunAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            TerminateJobRunAsync(new TerminateJobRunRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Terminates a Job Run in a given project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `JobRun`. Format must be
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}/jobRuns/{jobRun}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TerminateJobRunResponse> TerminateJobRunAsync(string name, st::CancellationToken cancellationToken) =>
            TerminateJobRunAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Terminates a Job Run in a given project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `JobRun`. Format must be
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}/jobRuns/{jobRun}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TerminateJobRunResponse TerminateJobRun(JobRunName name, gaxgrpc::CallSettings callSettings = null) =>
            TerminateJobRun(new TerminateJobRunRequest
            {
                JobRunName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Terminates a Job Run in a given project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `JobRun`. Format must be
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}/jobRuns/{jobRun}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TerminateJobRunResponse> TerminateJobRunAsync(JobRunName name, gaxgrpc::CallSettings callSettings = null) =>
            TerminateJobRunAsync(new TerminateJobRunRequest
            {
                JobRunName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Terminates a Job Run in a given project and location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `JobRun`. Format must be
        /// `projects/{project}/locations/{location}/deliveryPipelines/{deliveryPipeline}/releases/{release}/rollouts/{rollout}/jobRuns/{jobRun}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TerminateJobRunResponse> TerminateJobRunAsync(JobRunName name, st::CancellationToken cancellationToken) =>
            TerminateJobRunAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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

        /// <summary>
        /// Creates a new Automation in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Automation, OperationMetadata> CreateAutomation(CreateAutomationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Automation in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Automation, OperationMetadata>> CreateAutomationAsync(CreateAutomationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Automation in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Automation, OperationMetadata>> CreateAutomationAsync(CreateAutomationRequest request, st::CancellationToken cancellationToken) =>
            CreateAutomationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateAutomation</c>.</summary>
        public virtual lro::OperationsClient CreateAutomationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateAutomation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Automation, OperationMetadata> PollOnceCreateAutomation(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Automation, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAutomationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateAutomation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Automation, OperationMetadata>> PollOnceCreateAutomationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Automation, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAutomationOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Automation in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `Automation` must be created.
        /// The format is
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
        /// </param>
        /// <param name="automation">
        /// Required. The `Automation` to create.
        /// </param>
        /// <param name="automationId">
        /// Required. ID of the `Automation`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Automation, OperationMetadata> CreateAutomation(string parent, Automation automation, string automationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAutomation(new CreateAutomationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AutomationId = gax::GaxPreconditions.CheckNotNullOrEmpty(automationId, nameof(automationId)),
                Automation = gax::GaxPreconditions.CheckNotNull(automation, nameof(automation)),
            }, callSettings);

        /// <summary>
        /// Creates a new Automation in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `Automation` must be created.
        /// The format is
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
        /// </param>
        /// <param name="automation">
        /// Required. The `Automation` to create.
        /// </param>
        /// <param name="automationId">
        /// Required. ID of the `Automation`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Automation, OperationMetadata>> CreateAutomationAsync(string parent, Automation automation, string automationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAutomationAsync(new CreateAutomationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AutomationId = gax::GaxPreconditions.CheckNotNullOrEmpty(automationId, nameof(automationId)),
                Automation = gax::GaxPreconditions.CheckNotNull(automation, nameof(automation)),
            }, callSettings);

        /// <summary>
        /// Creates a new Automation in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `Automation` must be created.
        /// The format is
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
        /// </param>
        /// <param name="automation">
        /// Required. The `Automation` to create.
        /// </param>
        /// <param name="automationId">
        /// Required. ID of the `Automation`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Automation, OperationMetadata>> CreateAutomationAsync(string parent, Automation automation, string automationId, st::CancellationToken cancellationToken) =>
            CreateAutomationAsync(parent, automation, automationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Automation in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `Automation` must be created.
        /// The format is
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
        /// </param>
        /// <param name="automation">
        /// Required. The `Automation` to create.
        /// </param>
        /// <param name="automationId">
        /// Required. ID of the `Automation`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Automation, OperationMetadata> CreateAutomation(DeliveryPipelineName parent, Automation automation, string automationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAutomation(new CreateAutomationRequest
            {
                ParentAsDeliveryPipelineName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AutomationId = gax::GaxPreconditions.CheckNotNullOrEmpty(automationId, nameof(automationId)),
                Automation = gax::GaxPreconditions.CheckNotNull(automation, nameof(automation)),
            }, callSettings);

        /// <summary>
        /// Creates a new Automation in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `Automation` must be created.
        /// The format is
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
        /// </param>
        /// <param name="automation">
        /// Required. The `Automation` to create.
        /// </param>
        /// <param name="automationId">
        /// Required. ID of the `Automation`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Automation, OperationMetadata>> CreateAutomationAsync(DeliveryPipelineName parent, Automation automation, string automationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAutomationAsync(new CreateAutomationRequest
            {
                ParentAsDeliveryPipelineName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AutomationId = gax::GaxPreconditions.CheckNotNullOrEmpty(automationId, nameof(automationId)),
                Automation = gax::GaxPreconditions.CheckNotNull(automation, nameof(automation)),
            }, callSettings);

        /// <summary>
        /// Creates a new Automation in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent collection in which the `Automation` must be created.
        /// The format is
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
        /// </param>
        /// <param name="automation">
        /// Required. The `Automation` to create.
        /// </param>
        /// <param name="automationId">
        /// Required. ID of the `Automation`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Automation, OperationMetadata>> CreateAutomationAsync(DeliveryPipelineName parent, Automation automation, string automationId, st::CancellationToken cancellationToken) =>
            CreateAutomationAsync(parent, automation, automationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Automation resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Automation, OperationMetadata> UpdateAutomation(UpdateAutomationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Automation resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Automation, OperationMetadata>> UpdateAutomationAsync(UpdateAutomationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Automation resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Automation, OperationMetadata>> UpdateAutomationAsync(UpdateAutomationRequest request, st::CancellationToken cancellationToken) =>
            UpdateAutomationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateAutomation</c>.</summary>
        public virtual lro::OperationsClient UpdateAutomationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateAutomation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Automation, OperationMetadata> PollOnceUpdateAutomation(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Automation, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAutomationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateAutomation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Automation, OperationMetadata>> PollOnceUpdateAutomationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Automation, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAutomationOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single Automation resource.
        /// </summary>
        /// <param name="automation">
        /// Required. The `Automation` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten by the
        /// update in the `Automation` resource. The fields specified in the
        /// update_mask are relative to the resource, not the full request. A field
        /// will be overwritten if it's in the mask. If the user doesn't provide a mask
        /// then all fields are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Automation, OperationMetadata> UpdateAutomation(Automation automation, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAutomation(new UpdateAutomationRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Automation = gax::GaxPreconditions.CheckNotNull(automation, nameof(automation)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Automation resource.
        /// </summary>
        /// <param name="automation">
        /// Required. The `Automation` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten by the
        /// update in the `Automation` resource. The fields specified in the
        /// update_mask are relative to the resource, not the full request. A field
        /// will be overwritten if it's in the mask. If the user doesn't provide a mask
        /// then all fields are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Automation, OperationMetadata>> UpdateAutomationAsync(Automation automation, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAutomationAsync(new UpdateAutomationRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Automation = gax::GaxPreconditions.CheckNotNull(automation, nameof(automation)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Automation resource.
        /// </summary>
        /// <param name="automation">
        /// Required. The `Automation` to update.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten by the
        /// update in the `Automation` resource. The fields specified in the
        /// update_mask are relative to the resource, not the full request. A field
        /// will be overwritten if it's in the mask. If the user doesn't provide a mask
        /// then all fields are overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Automation, OperationMetadata>> UpdateAutomationAsync(Automation automation, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAutomationAsync(automation, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Automation resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAutomation(DeleteAutomationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Automation resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAutomationAsync(DeleteAutomationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Automation resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAutomationAsync(DeleteAutomationRequest request, st::CancellationToken cancellationToken) =>
            DeleteAutomationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteAutomation</c>.</summary>
        public virtual lro::OperationsClient DeleteAutomationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteAutomation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteAutomation(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAutomationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteAutomation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteAutomationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAutomationOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Automation resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Automation` to delete. The format is
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/automations/{automation_name}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAutomation(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAutomation(new DeleteAutomationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Automation resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Automation` to delete. The format is
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/automations/{automation_name}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAutomationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAutomationAsync(new DeleteAutomationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Automation resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Automation` to delete. The format is
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/automations/{automation_name}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAutomationAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAutomationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Automation resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Automation` to delete. The format is
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/automations/{automation_name}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAutomation(AutomationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAutomation(new DeleteAutomationRequest
            {
                AutomationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Automation resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Automation` to delete. The format is
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/automations/{automation_name}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAutomationAsync(AutomationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAutomationAsync(new DeleteAutomationRequest
            {
                AutomationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Automation resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `Automation` to delete. The format is
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/automations/{automation_name}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAutomationAsync(AutomationName name, st::CancellationToken cancellationToken) =>
            DeleteAutomationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Automation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Automation GetAutomation(GetAutomationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Automation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Automation> GetAutomationAsync(GetAutomationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Automation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Automation> GetAutomationAsync(GetAutomationRequest request, st::CancellationToken cancellationToken) =>
            GetAutomationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Automation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `Automation`. Format must be
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/automations/{automation_name}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Automation GetAutomation(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAutomation(new GetAutomationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Automation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `Automation`. Format must be
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/automations/{automation_name}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Automation> GetAutomationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAutomationAsync(new GetAutomationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Automation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `Automation`. Format must be
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/automations/{automation_name}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Automation> GetAutomationAsync(string name, st::CancellationToken cancellationToken) =>
            GetAutomationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Automation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `Automation`. Format must be
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/automations/{automation_name}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Automation GetAutomation(AutomationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAutomation(new GetAutomationRequest
            {
                AutomationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Automation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `Automation`. Format must be
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/automations/{automation_name}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Automation> GetAutomationAsync(AutomationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAutomationAsync(new GetAutomationRequest
            {
                AutomationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Automation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `Automation`. Format must be
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}/automations/{automation_name}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Automation> GetAutomationAsync(AutomationName name, st::CancellationToken cancellationToken) =>
            GetAutomationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Automations in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Automation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAutomationsResponse, Automation> ListAutomations(ListAutomationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Automations in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Automation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAutomationsResponse, Automation> ListAutomationsAsync(ListAutomationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Automations in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent `Delivery Pipeline`, which owns this collection of
        /// automations. Format must be
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
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
        /// <returns>A pageable sequence of <see cref="Automation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAutomationsResponse, Automation> ListAutomations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAutomations(new ListAutomationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Automations in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent `Delivery Pipeline`, which owns this collection of
        /// automations. Format must be
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Automation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAutomationsResponse, Automation> ListAutomationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAutomationsAsync(new ListAutomationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Automations in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent `Delivery Pipeline`, which owns this collection of
        /// automations. Format must be
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
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
        /// <returns>A pageable sequence of <see cref="Automation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAutomationsResponse, Automation> ListAutomations(DeliveryPipelineName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAutomations(new ListAutomationsRequest
            {
                ParentAsDeliveryPipelineName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists Automations in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent `Delivery Pipeline`, which owns this collection of
        /// automations. Format must be
        /// `projects/{project_id}/locations/{location_name}/deliveryPipelines/{pipeline_name}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Automation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAutomationsResponse, Automation> ListAutomationsAsync(DeliveryPipelineName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAutomationsAsync(new ListAutomationsRequest
            {
                ParentAsDeliveryPipelineName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets details of a single AutomationRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AutomationRun GetAutomationRun(GetAutomationRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single AutomationRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutomationRun> GetAutomationRunAsync(GetAutomationRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single AutomationRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutomationRun> GetAutomationRunAsync(GetAutomationRunRequest request, st::CancellationToken cancellationToken) =>
            GetAutomationRunAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single AutomationRun.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `AutomationRun`. Format must be
        /// `projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automationRuns/{automation_run}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AutomationRun GetAutomationRun(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAutomationRun(new GetAutomationRunRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single AutomationRun.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `AutomationRun`. Format must be
        /// `projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automationRuns/{automation_run}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutomationRun> GetAutomationRunAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAutomationRunAsync(new GetAutomationRunRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single AutomationRun.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `AutomationRun`. Format must be
        /// `projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automationRuns/{automation_run}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutomationRun> GetAutomationRunAsync(string name, st::CancellationToken cancellationToken) =>
            GetAutomationRunAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single AutomationRun.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `AutomationRun`. Format must be
        /// `projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automationRuns/{automation_run}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AutomationRun GetAutomationRun(AutomationRunName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAutomationRun(new GetAutomationRunRequest
            {
                AutomationRunName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single AutomationRun.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `AutomationRun`. Format must be
        /// `projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automationRuns/{automation_run}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutomationRun> GetAutomationRunAsync(AutomationRunName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAutomationRunAsync(new GetAutomationRunRequest
            {
                AutomationRunName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single AutomationRun.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `AutomationRun`. Format must be
        /// `projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automationRuns/{automation_run}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AutomationRun> GetAutomationRunAsync(AutomationRunName name, st::CancellationToken cancellationToken) =>
            GetAutomationRunAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists AutomationRuns in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AutomationRun"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAutomationRunsResponse, AutomationRun> ListAutomationRuns(ListAutomationRunsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists AutomationRuns in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AutomationRun"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAutomationRunsResponse, AutomationRun> ListAutomationRunsAsync(ListAutomationRunsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists AutomationRuns in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent `Delivery Pipeline`, which owns this collection of
        /// automationRuns. Format must be
        /// `projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}`.
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
        /// <returns>A pageable sequence of <see cref="AutomationRun"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAutomationRunsResponse, AutomationRun> ListAutomationRuns(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAutomationRuns(new ListAutomationRunsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists AutomationRuns in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent `Delivery Pipeline`, which owns this collection of
        /// automationRuns. Format must be
        /// `projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AutomationRun"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAutomationRunsResponse, AutomationRun> ListAutomationRunsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAutomationRunsAsync(new ListAutomationRunsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists AutomationRuns in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent `Delivery Pipeline`, which owns this collection of
        /// automationRuns. Format must be
        /// `projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}`.
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
        /// <returns>A pageable sequence of <see cref="AutomationRun"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAutomationRunsResponse, AutomationRun> ListAutomationRuns(DeliveryPipelineName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAutomationRuns(new ListAutomationRunsRequest
            {
                ParentAsDeliveryPipelineName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists AutomationRuns in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent `Delivery Pipeline`, which owns this collection of
        /// automationRuns. Format must be
        /// `projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AutomationRun"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAutomationRunsResponse, AutomationRun> ListAutomationRunsAsync(DeliveryPipelineName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAutomationRunsAsync(new ListAutomationRunsRequest
            {
                ParentAsDeliveryPipelineName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Cancels an AutomationRun. The `state` of the `AutomationRun` after
        /// cancelling is `CANCELLED`. `CancelAutomationRun` can be called on
        /// AutomationRun in the state `IN_PROGRESS` and `PENDING`; AutomationRun
        /// in a different state returns an `FAILED_PRECONDITION` error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CancelAutomationRunResponse CancelAutomationRun(CancelAutomationRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels an AutomationRun. The `state` of the `AutomationRun` after
        /// cancelling is `CANCELLED`. `CancelAutomationRun` can be called on
        /// AutomationRun in the state `IN_PROGRESS` and `PENDING`; AutomationRun
        /// in a different state returns an `FAILED_PRECONDITION` error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CancelAutomationRunResponse> CancelAutomationRunAsync(CancelAutomationRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels an AutomationRun. The `state` of the `AutomationRun` after
        /// cancelling is `CANCELLED`. `CancelAutomationRun` can be called on
        /// AutomationRun in the state `IN_PROGRESS` and `PENDING`; AutomationRun
        /// in a different state returns an `FAILED_PRECONDITION` error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CancelAutomationRunResponse> CancelAutomationRunAsync(CancelAutomationRunRequest request, st::CancellationToken cancellationToken) =>
            CancelAutomationRunAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels an AutomationRun. The `state` of the `AutomationRun` after
        /// cancelling is `CANCELLED`. `CancelAutomationRun` can be called on
        /// AutomationRun in the state `IN_PROGRESS` and `PENDING`; AutomationRun
        /// in a different state returns an `FAILED_PRECONDITION` error.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `AutomationRun`. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automationRuns/{automation_run}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CancelAutomationRunResponse CancelAutomationRun(string name, gaxgrpc::CallSettings callSettings = null) =>
            CancelAutomationRun(new CancelAutomationRunRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels an AutomationRun. The `state` of the `AutomationRun` after
        /// cancelling is `CANCELLED`. `CancelAutomationRun` can be called on
        /// AutomationRun in the state `IN_PROGRESS` and `PENDING`; AutomationRun
        /// in a different state returns an `FAILED_PRECONDITION` error.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `AutomationRun`. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automationRuns/{automation_run}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CancelAutomationRunResponse> CancelAutomationRunAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            CancelAutomationRunAsync(new CancelAutomationRunRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels an AutomationRun. The `state` of the `AutomationRun` after
        /// cancelling is `CANCELLED`. `CancelAutomationRun` can be called on
        /// AutomationRun in the state `IN_PROGRESS` and `PENDING`; AutomationRun
        /// in a different state returns an `FAILED_PRECONDITION` error.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `AutomationRun`. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automationRuns/{automation_run}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CancelAutomationRunResponse> CancelAutomationRunAsync(string name, st::CancellationToken cancellationToken) =>
            CancelAutomationRunAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels an AutomationRun. The `state` of the `AutomationRun` after
        /// cancelling is `CANCELLED`. `CancelAutomationRun` can be called on
        /// AutomationRun in the state `IN_PROGRESS` and `PENDING`; AutomationRun
        /// in a different state returns an `FAILED_PRECONDITION` error.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `AutomationRun`. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automationRuns/{automation_run}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CancelAutomationRunResponse CancelAutomationRun(AutomationRunName name, gaxgrpc::CallSettings callSettings = null) =>
            CancelAutomationRun(new CancelAutomationRunRequest
            {
                AutomationRunName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels an AutomationRun. The `state` of the `AutomationRun` after
        /// cancelling is `CANCELLED`. `CancelAutomationRun` can be called on
        /// AutomationRun in the state `IN_PROGRESS` and `PENDING`; AutomationRun
        /// in a different state returns an `FAILED_PRECONDITION` error.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `AutomationRun`. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automationRuns/{automation_run}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CancelAutomationRunResponse> CancelAutomationRunAsync(AutomationRunName name, gaxgrpc::CallSettings callSettings = null) =>
            CancelAutomationRunAsync(new CancelAutomationRunRequest
            {
                AutomationRunName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels an AutomationRun. The `state` of the `AutomationRun` after
        /// cancelling is `CANCELLED`. `CancelAutomationRun` can be called on
        /// AutomationRun in the state `IN_PROGRESS` and `PENDING`; AutomationRun
        /// in a different state returns an `FAILED_PRECONDITION` error.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the `AutomationRun`. Format is
        /// `projects/{project}/locations/{location}/deliveryPipelines/{delivery_pipeline}/automationRuns/{automation_run}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CancelAutomationRunResponse> CancelAutomationRunAsync(AutomationRunName name, st::CancellationToken cancellationToken) =>
            CancelAutomationRunAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
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

        private readonly gaxgrpc::ApiCall<RollbackTargetRequest, RollbackTargetResponse> _callRollbackTarget;

        private readonly gaxgrpc::ApiCall<GetTargetRequest, Target> _callGetTarget;

        private readonly gaxgrpc::ApiCall<CreateTargetRequest, lro::Operation> _callCreateTarget;

        private readonly gaxgrpc::ApiCall<UpdateTargetRequest, lro::Operation> _callUpdateTarget;

        private readonly gaxgrpc::ApiCall<DeleteTargetRequest, lro::Operation> _callDeleteTarget;

        private readonly gaxgrpc::ApiCall<ListCustomTargetTypesRequest, ListCustomTargetTypesResponse> _callListCustomTargetTypes;

        private readonly gaxgrpc::ApiCall<GetCustomTargetTypeRequest, CustomTargetType> _callGetCustomTargetType;

        private readonly gaxgrpc::ApiCall<CreateCustomTargetTypeRequest, lro::Operation> _callCreateCustomTargetType;

        private readonly gaxgrpc::ApiCall<UpdateCustomTargetTypeRequest, lro::Operation> _callUpdateCustomTargetType;

        private readonly gaxgrpc::ApiCall<DeleteCustomTargetTypeRequest, lro::Operation> _callDeleteCustomTargetType;

        private readonly gaxgrpc::ApiCall<ListReleasesRequest, ListReleasesResponse> _callListReleases;

        private readonly gaxgrpc::ApiCall<GetReleaseRequest, Release> _callGetRelease;

        private readonly gaxgrpc::ApiCall<CreateReleaseRequest, lro::Operation> _callCreateRelease;

        private readonly gaxgrpc::ApiCall<AbandonReleaseRequest, AbandonReleaseResponse> _callAbandonRelease;

        private readonly gaxgrpc::ApiCall<CreateDeployPolicyRequest, lro::Operation> _callCreateDeployPolicy;

        private readonly gaxgrpc::ApiCall<UpdateDeployPolicyRequest, lro::Operation> _callUpdateDeployPolicy;

        private readonly gaxgrpc::ApiCall<DeleteDeployPolicyRequest, lro::Operation> _callDeleteDeployPolicy;

        private readonly gaxgrpc::ApiCall<ListDeployPoliciesRequest, ListDeployPoliciesResponse> _callListDeployPolicies;

        private readonly gaxgrpc::ApiCall<GetDeployPolicyRequest, DeployPolicy> _callGetDeployPolicy;

        private readonly gaxgrpc::ApiCall<ApproveRolloutRequest, ApproveRolloutResponse> _callApproveRollout;

        private readonly gaxgrpc::ApiCall<AdvanceRolloutRequest, AdvanceRolloutResponse> _callAdvanceRollout;

        private readonly gaxgrpc::ApiCall<CancelRolloutRequest, CancelRolloutResponse> _callCancelRollout;

        private readonly gaxgrpc::ApiCall<ListRolloutsRequest, ListRolloutsResponse> _callListRollouts;

        private readonly gaxgrpc::ApiCall<GetRolloutRequest, Rollout> _callGetRollout;

        private readonly gaxgrpc::ApiCall<CreateRolloutRequest, lro::Operation> _callCreateRollout;

        private readonly gaxgrpc::ApiCall<IgnoreJobRequest, IgnoreJobResponse> _callIgnoreJob;

        private readonly gaxgrpc::ApiCall<RetryJobRequest, RetryJobResponse> _callRetryJob;

        private readonly gaxgrpc::ApiCall<ListJobRunsRequest, ListJobRunsResponse> _callListJobRuns;

        private readonly gaxgrpc::ApiCall<GetJobRunRequest, JobRun> _callGetJobRun;

        private readonly gaxgrpc::ApiCall<TerminateJobRunRequest, TerminateJobRunResponse> _callTerminateJobRun;

        private readonly gaxgrpc::ApiCall<GetConfigRequest, Config> _callGetConfig;

        private readonly gaxgrpc::ApiCall<CreateAutomationRequest, lro::Operation> _callCreateAutomation;

        private readonly gaxgrpc::ApiCall<UpdateAutomationRequest, lro::Operation> _callUpdateAutomation;

        private readonly gaxgrpc::ApiCall<DeleteAutomationRequest, lro::Operation> _callDeleteAutomation;

        private readonly gaxgrpc::ApiCall<GetAutomationRequest, Automation> _callGetAutomation;

        private readonly gaxgrpc::ApiCall<ListAutomationsRequest, ListAutomationsResponse> _callListAutomations;

        private readonly gaxgrpc::ApiCall<GetAutomationRunRequest, AutomationRun> _callGetAutomationRun;

        private readonly gaxgrpc::ApiCall<ListAutomationRunsRequest, ListAutomationRunsResponse> _callListAutomationRuns;

        private readonly gaxgrpc::ApiCall<CancelAutomationRunRequest, CancelAutomationRunResponse> _callCancelAutomationRun;

        /// <summary>
        /// Constructs a client wrapper for the CloudDeploy service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CloudDeploySettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CloudDeployClientImpl(CloudDeploy.CloudDeployClient grpcClient, CloudDeploySettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CloudDeploySettings effectiveSettings = settings ?? CloudDeploySettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateDeliveryPipelineOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateDeliveryPipelineOperationsSettings, logger);
            UpdateDeliveryPipelineOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateDeliveryPipelineOperationsSettings, logger);
            DeleteDeliveryPipelineOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteDeliveryPipelineOperationsSettings, logger);
            CreateTargetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateTargetOperationsSettings, logger);
            UpdateTargetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateTargetOperationsSettings, logger);
            DeleteTargetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteTargetOperationsSettings, logger);
            CreateCustomTargetTypeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateCustomTargetTypeOperationsSettings, logger);
            UpdateCustomTargetTypeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateCustomTargetTypeOperationsSettings, logger);
            DeleteCustomTargetTypeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteCustomTargetTypeOperationsSettings, logger);
            CreateReleaseOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateReleaseOperationsSettings, logger);
            CreateDeployPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateDeployPolicyOperationsSettings, logger);
            UpdateDeployPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateDeployPolicyOperationsSettings, logger);
            DeleteDeployPolicyOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteDeployPolicyOperationsSettings, logger);
            CreateRolloutOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateRolloutOperationsSettings, logger);
            CreateAutomationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateAutomationOperationsSettings, logger);
            UpdateAutomationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateAutomationOperationsSettings, logger);
            DeleteAutomationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteAutomationOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListDeliveryPipelines = clientHelper.BuildApiCall<ListDeliveryPipelinesRequest, ListDeliveryPipelinesResponse>("ListDeliveryPipelines", grpcClient.ListDeliveryPipelinesAsync, grpcClient.ListDeliveryPipelines, effectiveSettings.ListDeliveryPipelinesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDeliveryPipelines);
            Modify_ListDeliveryPipelinesApiCall(ref _callListDeliveryPipelines);
            _callGetDeliveryPipeline = clientHelper.BuildApiCall<GetDeliveryPipelineRequest, DeliveryPipeline>("GetDeliveryPipeline", grpcClient.GetDeliveryPipelineAsync, grpcClient.GetDeliveryPipeline, effectiveSettings.GetDeliveryPipelineSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDeliveryPipeline);
            Modify_GetDeliveryPipelineApiCall(ref _callGetDeliveryPipeline);
            _callCreateDeliveryPipeline = clientHelper.BuildApiCall<CreateDeliveryPipelineRequest, lro::Operation>("CreateDeliveryPipeline", grpcClient.CreateDeliveryPipelineAsync, grpcClient.CreateDeliveryPipeline, effectiveSettings.CreateDeliveryPipelineSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDeliveryPipeline);
            Modify_CreateDeliveryPipelineApiCall(ref _callCreateDeliveryPipeline);
            _callUpdateDeliveryPipeline = clientHelper.BuildApiCall<UpdateDeliveryPipelineRequest, lro::Operation>("UpdateDeliveryPipeline", grpcClient.UpdateDeliveryPipelineAsync, grpcClient.UpdateDeliveryPipeline, effectiveSettings.UpdateDeliveryPipelineSettings).WithGoogleRequestParam("delivery_pipeline.name", request => request.DeliveryPipeline?.Name);
            Modify_ApiCall(ref _callUpdateDeliveryPipeline);
            Modify_UpdateDeliveryPipelineApiCall(ref _callUpdateDeliveryPipeline);
            _callDeleteDeliveryPipeline = clientHelper.BuildApiCall<DeleteDeliveryPipelineRequest, lro::Operation>("DeleteDeliveryPipeline", grpcClient.DeleteDeliveryPipelineAsync, grpcClient.DeleteDeliveryPipeline, effectiveSettings.DeleteDeliveryPipelineSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDeliveryPipeline);
            Modify_DeleteDeliveryPipelineApiCall(ref _callDeleteDeliveryPipeline);
            _callListTargets = clientHelper.BuildApiCall<ListTargetsRequest, ListTargetsResponse>("ListTargets", grpcClient.ListTargetsAsync, grpcClient.ListTargets, effectiveSettings.ListTargetsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTargets);
            Modify_ListTargetsApiCall(ref _callListTargets);
            _callRollbackTarget = clientHelper.BuildApiCall<RollbackTargetRequest, RollbackTargetResponse>("RollbackTarget", grpcClient.RollbackTargetAsync, grpcClient.RollbackTarget, effectiveSettings.RollbackTargetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRollbackTarget);
            Modify_RollbackTargetApiCall(ref _callRollbackTarget);
            _callGetTarget = clientHelper.BuildApiCall<GetTargetRequest, Target>("GetTarget", grpcClient.GetTargetAsync, grpcClient.GetTarget, effectiveSettings.GetTargetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTarget);
            Modify_GetTargetApiCall(ref _callGetTarget);
            _callCreateTarget = clientHelper.BuildApiCall<CreateTargetRequest, lro::Operation>("CreateTarget", grpcClient.CreateTargetAsync, grpcClient.CreateTarget, effectiveSettings.CreateTargetSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTarget);
            Modify_CreateTargetApiCall(ref _callCreateTarget);
            _callUpdateTarget = clientHelper.BuildApiCall<UpdateTargetRequest, lro::Operation>("UpdateTarget", grpcClient.UpdateTargetAsync, grpcClient.UpdateTarget, effectiveSettings.UpdateTargetSettings).WithGoogleRequestParam("target.name", request => request.Target?.Name);
            Modify_ApiCall(ref _callUpdateTarget);
            Modify_UpdateTargetApiCall(ref _callUpdateTarget);
            _callDeleteTarget = clientHelper.BuildApiCall<DeleteTargetRequest, lro::Operation>("DeleteTarget", grpcClient.DeleteTargetAsync, grpcClient.DeleteTarget, effectiveSettings.DeleteTargetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTarget);
            Modify_DeleteTargetApiCall(ref _callDeleteTarget);
            _callListCustomTargetTypes = clientHelper.BuildApiCall<ListCustomTargetTypesRequest, ListCustomTargetTypesResponse>("ListCustomTargetTypes", grpcClient.ListCustomTargetTypesAsync, grpcClient.ListCustomTargetTypes, effectiveSettings.ListCustomTargetTypesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCustomTargetTypes);
            Modify_ListCustomTargetTypesApiCall(ref _callListCustomTargetTypes);
            _callGetCustomTargetType = clientHelper.BuildApiCall<GetCustomTargetTypeRequest, CustomTargetType>("GetCustomTargetType", grpcClient.GetCustomTargetTypeAsync, grpcClient.GetCustomTargetType, effectiveSettings.GetCustomTargetTypeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCustomTargetType);
            Modify_GetCustomTargetTypeApiCall(ref _callGetCustomTargetType);
            _callCreateCustomTargetType = clientHelper.BuildApiCall<CreateCustomTargetTypeRequest, lro::Operation>("CreateCustomTargetType", grpcClient.CreateCustomTargetTypeAsync, grpcClient.CreateCustomTargetType, effectiveSettings.CreateCustomTargetTypeSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCustomTargetType);
            Modify_CreateCustomTargetTypeApiCall(ref _callCreateCustomTargetType);
            _callUpdateCustomTargetType = clientHelper.BuildApiCall<UpdateCustomTargetTypeRequest, lro::Operation>("UpdateCustomTargetType", grpcClient.UpdateCustomTargetTypeAsync, grpcClient.UpdateCustomTargetType, effectiveSettings.UpdateCustomTargetTypeSettings).WithGoogleRequestParam("custom_target_type.name", request => request.CustomTargetType?.Name);
            Modify_ApiCall(ref _callUpdateCustomTargetType);
            Modify_UpdateCustomTargetTypeApiCall(ref _callUpdateCustomTargetType);
            _callDeleteCustomTargetType = clientHelper.BuildApiCall<DeleteCustomTargetTypeRequest, lro::Operation>("DeleteCustomTargetType", grpcClient.DeleteCustomTargetTypeAsync, grpcClient.DeleteCustomTargetType, effectiveSettings.DeleteCustomTargetTypeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteCustomTargetType);
            Modify_DeleteCustomTargetTypeApiCall(ref _callDeleteCustomTargetType);
            _callListReleases = clientHelper.BuildApiCall<ListReleasesRequest, ListReleasesResponse>("ListReleases", grpcClient.ListReleasesAsync, grpcClient.ListReleases, effectiveSettings.ListReleasesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListReleases);
            Modify_ListReleasesApiCall(ref _callListReleases);
            _callGetRelease = clientHelper.BuildApiCall<GetReleaseRequest, Release>("GetRelease", grpcClient.GetReleaseAsync, grpcClient.GetRelease, effectiveSettings.GetReleaseSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRelease);
            Modify_GetReleaseApiCall(ref _callGetRelease);
            _callCreateRelease = clientHelper.BuildApiCall<CreateReleaseRequest, lro::Operation>("CreateRelease", grpcClient.CreateReleaseAsync, grpcClient.CreateRelease, effectiveSettings.CreateReleaseSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateRelease);
            Modify_CreateReleaseApiCall(ref _callCreateRelease);
            _callAbandonRelease = clientHelper.BuildApiCall<AbandonReleaseRequest, AbandonReleaseResponse>("AbandonRelease", grpcClient.AbandonReleaseAsync, grpcClient.AbandonRelease, effectiveSettings.AbandonReleaseSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callAbandonRelease);
            Modify_AbandonReleaseApiCall(ref _callAbandonRelease);
            _callCreateDeployPolicy = clientHelper.BuildApiCall<CreateDeployPolicyRequest, lro::Operation>("CreateDeployPolicy", grpcClient.CreateDeployPolicyAsync, grpcClient.CreateDeployPolicy, effectiveSettings.CreateDeployPolicySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDeployPolicy);
            Modify_CreateDeployPolicyApiCall(ref _callCreateDeployPolicy);
            _callUpdateDeployPolicy = clientHelper.BuildApiCall<UpdateDeployPolicyRequest, lro::Operation>("UpdateDeployPolicy", grpcClient.UpdateDeployPolicyAsync, grpcClient.UpdateDeployPolicy, effectiveSettings.UpdateDeployPolicySettings).WithGoogleRequestParam("deploy_policy.name", request => request.DeployPolicy?.Name);
            Modify_ApiCall(ref _callUpdateDeployPolicy);
            Modify_UpdateDeployPolicyApiCall(ref _callUpdateDeployPolicy);
            _callDeleteDeployPolicy = clientHelper.BuildApiCall<DeleteDeployPolicyRequest, lro::Operation>("DeleteDeployPolicy", grpcClient.DeleteDeployPolicyAsync, grpcClient.DeleteDeployPolicy, effectiveSettings.DeleteDeployPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDeployPolicy);
            Modify_DeleteDeployPolicyApiCall(ref _callDeleteDeployPolicy);
            _callListDeployPolicies = clientHelper.BuildApiCall<ListDeployPoliciesRequest, ListDeployPoliciesResponse>("ListDeployPolicies", grpcClient.ListDeployPoliciesAsync, grpcClient.ListDeployPolicies, effectiveSettings.ListDeployPoliciesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDeployPolicies);
            Modify_ListDeployPoliciesApiCall(ref _callListDeployPolicies);
            _callGetDeployPolicy = clientHelper.BuildApiCall<GetDeployPolicyRequest, DeployPolicy>("GetDeployPolicy", grpcClient.GetDeployPolicyAsync, grpcClient.GetDeployPolicy, effectiveSettings.GetDeployPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDeployPolicy);
            Modify_GetDeployPolicyApiCall(ref _callGetDeployPolicy);
            _callApproveRollout = clientHelper.BuildApiCall<ApproveRolloutRequest, ApproveRolloutResponse>("ApproveRollout", grpcClient.ApproveRolloutAsync, grpcClient.ApproveRollout, effectiveSettings.ApproveRolloutSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callApproveRollout);
            Modify_ApproveRolloutApiCall(ref _callApproveRollout);
            _callAdvanceRollout = clientHelper.BuildApiCall<AdvanceRolloutRequest, AdvanceRolloutResponse>("AdvanceRollout", grpcClient.AdvanceRolloutAsync, grpcClient.AdvanceRollout, effectiveSettings.AdvanceRolloutSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callAdvanceRollout);
            Modify_AdvanceRolloutApiCall(ref _callAdvanceRollout);
            _callCancelRollout = clientHelper.BuildApiCall<CancelRolloutRequest, CancelRolloutResponse>("CancelRollout", grpcClient.CancelRolloutAsync, grpcClient.CancelRollout, effectiveSettings.CancelRolloutSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCancelRollout);
            Modify_CancelRolloutApiCall(ref _callCancelRollout);
            _callListRollouts = clientHelper.BuildApiCall<ListRolloutsRequest, ListRolloutsResponse>("ListRollouts", grpcClient.ListRolloutsAsync, grpcClient.ListRollouts, effectiveSettings.ListRolloutsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRollouts);
            Modify_ListRolloutsApiCall(ref _callListRollouts);
            _callGetRollout = clientHelper.BuildApiCall<GetRolloutRequest, Rollout>("GetRollout", grpcClient.GetRolloutAsync, grpcClient.GetRollout, effectiveSettings.GetRolloutSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRollout);
            Modify_GetRolloutApiCall(ref _callGetRollout);
            _callCreateRollout = clientHelper.BuildApiCall<CreateRolloutRequest, lro::Operation>("CreateRollout", grpcClient.CreateRolloutAsync, grpcClient.CreateRollout, effectiveSettings.CreateRolloutSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateRollout);
            Modify_CreateRolloutApiCall(ref _callCreateRollout);
            _callIgnoreJob = clientHelper.BuildApiCall<IgnoreJobRequest, IgnoreJobResponse>("IgnoreJob", grpcClient.IgnoreJobAsync, grpcClient.IgnoreJob, effectiveSettings.IgnoreJobSettings).WithGoogleRequestParam("rollout", request => request.Rollout);
            Modify_ApiCall(ref _callIgnoreJob);
            Modify_IgnoreJobApiCall(ref _callIgnoreJob);
            _callRetryJob = clientHelper.BuildApiCall<RetryJobRequest, RetryJobResponse>("RetryJob", grpcClient.RetryJobAsync, grpcClient.RetryJob, effectiveSettings.RetryJobSettings).WithGoogleRequestParam("rollout", request => request.Rollout);
            Modify_ApiCall(ref _callRetryJob);
            Modify_RetryJobApiCall(ref _callRetryJob);
            _callListJobRuns = clientHelper.BuildApiCall<ListJobRunsRequest, ListJobRunsResponse>("ListJobRuns", grpcClient.ListJobRunsAsync, grpcClient.ListJobRuns, effectiveSettings.ListJobRunsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListJobRuns);
            Modify_ListJobRunsApiCall(ref _callListJobRuns);
            _callGetJobRun = clientHelper.BuildApiCall<GetJobRunRequest, JobRun>("GetJobRun", grpcClient.GetJobRunAsync, grpcClient.GetJobRun, effectiveSettings.GetJobRunSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetJobRun);
            Modify_GetJobRunApiCall(ref _callGetJobRun);
            _callTerminateJobRun = clientHelper.BuildApiCall<TerminateJobRunRequest, TerminateJobRunResponse>("TerminateJobRun", grpcClient.TerminateJobRunAsync, grpcClient.TerminateJobRun, effectiveSettings.TerminateJobRunSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callTerminateJobRun);
            Modify_TerminateJobRunApiCall(ref _callTerminateJobRun);
            _callGetConfig = clientHelper.BuildApiCall<GetConfigRequest, Config>("GetConfig", grpcClient.GetConfigAsync, grpcClient.GetConfig, effectiveSettings.GetConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetConfig);
            Modify_GetConfigApiCall(ref _callGetConfig);
            _callCreateAutomation = clientHelper.BuildApiCall<CreateAutomationRequest, lro::Operation>("CreateAutomation", grpcClient.CreateAutomationAsync, grpcClient.CreateAutomation, effectiveSettings.CreateAutomationSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAutomation);
            Modify_CreateAutomationApiCall(ref _callCreateAutomation);
            _callUpdateAutomation = clientHelper.BuildApiCall<UpdateAutomationRequest, lro::Operation>("UpdateAutomation", grpcClient.UpdateAutomationAsync, grpcClient.UpdateAutomation, effectiveSettings.UpdateAutomationSettings).WithGoogleRequestParam("automation.name", request => request.Automation?.Name);
            Modify_ApiCall(ref _callUpdateAutomation);
            Modify_UpdateAutomationApiCall(ref _callUpdateAutomation);
            _callDeleteAutomation = clientHelper.BuildApiCall<DeleteAutomationRequest, lro::Operation>("DeleteAutomation", grpcClient.DeleteAutomationAsync, grpcClient.DeleteAutomation, effectiveSettings.DeleteAutomationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAutomation);
            Modify_DeleteAutomationApiCall(ref _callDeleteAutomation);
            _callGetAutomation = clientHelper.BuildApiCall<GetAutomationRequest, Automation>("GetAutomation", grpcClient.GetAutomationAsync, grpcClient.GetAutomation, effectiveSettings.GetAutomationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAutomation);
            Modify_GetAutomationApiCall(ref _callGetAutomation);
            _callListAutomations = clientHelper.BuildApiCall<ListAutomationsRequest, ListAutomationsResponse>("ListAutomations", grpcClient.ListAutomationsAsync, grpcClient.ListAutomations, effectiveSettings.ListAutomationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAutomations);
            Modify_ListAutomationsApiCall(ref _callListAutomations);
            _callGetAutomationRun = clientHelper.BuildApiCall<GetAutomationRunRequest, AutomationRun>("GetAutomationRun", grpcClient.GetAutomationRunAsync, grpcClient.GetAutomationRun, effectiveSettings.GetAutomationRunSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAutomationRun);
            Modify_GetAutomationRunApiCall(ref _callGetAutomationRun);
            _callListAutomationRuns = clientHelper.BuildApiCall<ListAutomationRunsRequest, ListAutomationRunsResponse>("ListAutomationRuns", grpcClient.ListAutomationRunsAsync, grpcClient.ListAutomationRuns, effectiveSettings.ListAutomationRunsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAutomationRuns);
            Modify_ListAutomationRunsApiCall(ref _callListAutomationRuns);
            _callCancelAutomationRun = clientHelper.BuildApiCall<CancelAutomationRunRequest, CancelAutomationRunResponse>("CancelAutomationRun", grpcClient.CancelAutomationRunAsync, grpcClient.CancelAutomationRun, effectiveSettings.CancelAutomationRunSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCancelAutomationRun);
            Modify_CancelAutomationRunApiCall(ref _callCancelAutomationRun);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListDeliveryPipelinesApiCall(ref gaxgrpc::ApiCall<ListDeliveryPipelinesRequest, ListDeliveryPipelinesResponse> call);

        partial void Modify_GetDeliveryPipelineApiCall(ref gaxgrpc::ApiCall<GetDeliveryPipelineRequest, DeliveryPipeline> call);

        partial void Modify_CreateDeliveryPipelineApiCall(ref gaxgrpc::ApiCall<CreateDeliveryPipelineRequest, lro::Operation> call);

        partial void Modify_UpdateDeliveryPipelineApiCall(ref gaxgrpc::ApiCall<UpdateDeliveryPipelineRequest, lro::Operation> call);

        partial void Modify_DeleteDeliveryPipelineApiCall(ref gaxgrpc::ApiCall<DeleteDeliveryPipelineRequest, lro::Operation> call);

        partial void Modify_ListTargetsApiCall(ref gaxgrpc::ApiCall<ListTargetsRequest, ListTargetsResponse> call);

        partial void Modify_RollbackTargetApiCall(ref gaxgrpc::ApiCall<RollbackTargetRequest, RollbackTargetResponse> call);

        partial void Modify_GetTargetApiCall(ref gaxgrpc::ApiCall<GetTargetRequest, Target> call);

        partial void Modify_CreateTargetApiCall(ref gaxgrpc::ApiCall<CreateTargetRequest, lro::Operation> call);

        partial void Modify_UpdateTargetApiCall(ref gaxgrpc::ApiCall<UpdateTargetRequest, lro::Operation> call);

        partial void Modify_DeleteTargetApiCall(ref gaxgrpc::ApiCall<DeleteTargetRequest, lro::Operation> call);

        partial void Modify_ListCustomTargetTypesApiCall(ref gaxgrpc::ApiCall<ListCustomTargetTypesRequest, ListCustomTargetTypesResponse> call);

        partial void Modify_GetCustomTargetTypeApiCall(ref gaxgrpc::ApiCall<GetCustomTargetTypeRequest, CustomTargetType> call);

        partial void Modify_CreateCustomTargetTypeApiCall(ref gaxgrpc::ApiCall<CreateCustomTargetTypeRequest, lro::Operation> call);

        partial void Modify_UpdateCustomTargetTypeApiCall(ref gaxgrpc::ApiCall<UpdateCustomTargetTypeRequest, lro::Operation> call);

        partial void Modify_DeleteCustomTargetTypeApiCall(ref gaxgrpc::ApiCall<DeleteCustomTargetTypeRequest, lro::Operation> call);

        partial void Modify_ListReleasesApiCall(ref gaxgrpc::ApiCall<ListReleasesRequest, ListReleasesResponse> call);

        partial void Modify_GetReleaseApiCall(ref gaxgrpc::ApiCall<GetReleaseRequest, Release> call);

        partial void Modify_CreateReleaseApiCall(ref gaxgrpc::ApiCall<CreateReleaseRequest, lro::Operation> call);

        partial void Modify_AbandonReleaseApiCall(ref gaxgrpc::ApiCall<AbandonReleaseRequest, AbandonReleaseResponse> call);

        partial void Modify_CreateDeployPolicyApiCall(ref gaxgrpc::ApiCall<CreateDeployPolicyRequest, lro::Operation> call);

        partial void Modify_UpdateDeployPolicyApiCall(ref gaxgrpc::ApiCall<UpdateDeployPolicyRequest, lro::Operation> call);

        partial void Modify_DeleteDeployPolicyApiCall(ref gaxgrpc::ApiCall<DeleteDeployPolicyRequest, lro::Operation> call);

        partial void Modify_ListDeployPoliciesApiCall(ref gaxgrpc::ApiCall<ListDeployPoliciesRequest, ListDeployPoliciesResponse> call);

        partial void Modify_GetDeployPolicyApiCall(ref gaxgrpc::ApiCall<GetDeployPolicyRequest, DeployPolicy> call);

        partial void Modify_ApproveRolloutApiCall(ref gaxgrpc::ApiCall<ApproveRolloutRequest, ApproveRolloutResponse> call);

        partial void Modify_AdvanceRolloutApiCall(ref gaxgrpc::ApiCall<AdvanceRolloutRequest, AdvanceRolloutResponse> call);

        partial void Modify_CancelRolloutApiCall(ref gaxgrpc::ApiCall<CancelRolloutRequest, CancelRolloutResponse> call);

        partial void Modify_ListRolloutsApiCall(ref gaxgrpc::ApiCall<ListRolloutsRequest, ListRolloutsResponse> call);

        partial void Modify_GetRolloutApiCall(ref gaxgrpc::ApiCall<GetRolloutRequest, Rollout> call);

        partial void Modify_CreateRolloutApiCall(ref gaxgrpc::ApiCall<CreateRolloutRequest, lro::Operation> call);

        partial void Modify_IgnoreJobApiCall(ref gaxgrpc::ApiCall<IgnoreJobRequest, IgnoreJobResponse> call);

        partial void Modify_RetryJobApiCall(ref gaxgrpc::ApiCall<RetryJobRequest, RetryJobResponse> call);

        partial void Modify_ListJobRunsApiCall(ref gaxgrpc::ApiCall<ListJobRunsRequest, ListJobRunsResponse> call);

        partial void Modify_GetJobRunApiCall(ref gaxgrpc::ApiCall<GetJobRunRequest, JobRun> call);

        partial void Modify_TerminateJobRunApiCall(ref gaxgrpc::ApiCall<TerminateJobRunRequest, TerminateJobRunResponse> call);

        partial void Modify_GetConfigApiCall(ref gaxgrpc::ApiCall<GetConfigRequest, Config> call);

        partial void Modify_CreateAutomationApiCall(ref gaxgrpc::ApiCall<CreateAutomationRequest, lro::Operation> call);

        partial void Modify_UpdateAutomationApiCall(ref gaxgrpc::ApiCall<UpdateAutomationRequest, lro::Operation> call);

        partial void Modify_DeleteAutomationApiCall(ref gaxgrpc::ApiCall<DeleteAutomationRequest, lro::Operation> call);

        partial void Modify_GetAutomationApiCall(ref gaxgrpc::ApiCall<GetAutomationRequest, Automation> call);

        partial void Modify_ListAutomationsApiCall(ref gaxgrpc::ApiCall<ListAutomationsRequest, ListAutomationsResponse> call);

        partial void Modify_GetAutomationRunApiCall(ref gaxgrpc::ApiCall<GetAutomationRunRequest, AutomationRun> call);

        partial void Modify_ListAutomationRunsApiCall(ref gaxgrpc::ApiCall<ListAutomationRunsRequest, ListAutomationRunsResponse> call);

        partial void Modify_CancelAutomationRunApiCall(ref gaxgrpc::ApiCall<CancelAutomationRunRequest, CancelAutomationRunResponse> call);

        partial void OnConstruction(CloudDeploy.CloudDeployClient grpcClient, CloudDeploySettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CloudDeploy client</summary>
        public override CloudDeploy.CloudDeployClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListDeliveryPipelinesRequest(ref ListDeliveryPipelinesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDeliveryPipelineRequest(ref GetDeliveryPipelineRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateDeliveryPipelineRequest(ref CreateDeliveryPipelineRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDeliveryPipelineRequest(ref UpdateDeliveryPipelineRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDeliveryPipelineRequest(ref DeleteDeliveryPipelineRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTargetsRequest(ref ListTargetsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RollbackTargetRequest(ref RollbackTargetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTargetRequest(ref GetTargetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateTargetRequest(ref CreateTargetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateTargetRequest(ref UpdateTargetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTargetRequest(ref DeleteTargetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCustomTargetTypesRequest(ref ListCustomTargetTypesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCustomTargetTypeRequest(ref GetCustomTargetTypeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateCustomTargetTypeRequest(ref CreateCustomTargetTypeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCustomTargetTypeRequest(ref UpdateCustomTargetTypeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteCustomTargetTypeRequest(ref DeleteCustomTargetTypeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListReleasesRequest(ref ListReleasesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetReleaseRequest(ref GetReleaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateReleaseRequest(ref CreateReleaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AbandonReleaseRequest(ref AbandonReleaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateDeployPolicyRequest(ref CreateDeployPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDeployPolicyRequest(ref UpdateDeployPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDeployPolicyRequest(ref DeleteDeployPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDeployPoliciesRequest(ref ListDeployPoliciesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDeployPolicyRequest(ref GetDeployPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ApproveRolloutRequest(ref ApproveRolloutRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AdvanceRolloutRequest(ref AdvanceRolloutRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CancelRolloutRequest(ref CancelRolloutRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRolloutsRequest(ref ListRolloutsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRolloutRequest(ref GetRolloutRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateRolloutRequest(ref CreateRolloutRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_IgnoreJobRequest(ref IgnoreJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RetryJobRequest(ref RetryJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListJobRunsRequest(ref ListJobRunsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetJobRunRequest(ref GetJobRunRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TerminateJobRunRequest(ref TerminateJobRunRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetConfigRequest(ref GetConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAutomationRequest(ref CreateAutomationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAutomationRequest(ref UpdateAutomationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAutomationRequest(ref DeleteAutomationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAutomationRequest(ref GetAutomationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAutomationsRequest(ref ListAutomationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAutomationRunRequest(ref GetAutomationRunRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAutomationRunsRequest(ref ListAutomationRunsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CancelAutomationRunRequest(ref CancelAutomationRunRequest request, ref gaxgrpc::CallSettings settings);

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
        /// Creates a `Rollout` to roll back the specified target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RollbackTargetResponse RollbackTarget(RollbackTargetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RollbackTargetRequest(ref request, ref callSettings);
            return _callRollbackTarget.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a `Rollout` to roll back the specified target.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RollbackTargetResponse> RollbackTargetAsync(RollbackTargetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RollbackTargetRequest(ref request, ref callSettings);
            return _callRollbackTarget.Async(request, callSettings);
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
        /// Lists CustomTargetTypes in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CustomTargetType"/> resources.</returns>
        public override gax::PagedEnumerable<ListCustomTargetTypesResponse, CustomTargetType> ListCustomTargetTypes(ListCustomTargetTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCustomTargetTypesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCustomTargetTypesRequest, ListCustomTargetTypesResponse, CustomTargetType>(_callListCustomTargetTypes, request, callSettings);
        }

        /// <summary>
        /// Lists CustomTargetTypes in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CustomTargetType"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCustomTargetTypesResponse, CustomTargetType> ListCustomTargetTypesAsync(ListCustomTargetTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCustomTargetTypesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCustomTargetTypesRequest, ListCustomTargetTypesResponse, CustomTargetType>(_callListCustomTargetTypes, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single CustomTargetType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CustomTargetType GetCustomTargetType(GetCustomTargetTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomTargetTypeRequest(ref request, ref callSettings);
            return _callGetCustomTargetType.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single CustomTargetType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CustomTargetType> GetCustomTargetTypeAsync(GetCustomTargetTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomTargetTypeRequest(ref request, ref callSettings);
            return _callGetCustomTargetType.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateCustomTargetType</c>.</summary>
        public override lro::OperationsClient CreateCustomTargetTypeOperationsClient { get; }

        /// <summary>
        /// Creates a new CustomTargetType in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CustomTargetType, OperationMetadata> CreateCustomTargetType(CreateCustomTargetTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCustomTargetTypeRequest(ref request, ref callSettings);
            return new lro::Operation<CustomTargetType, OperationMetadata>(_callCreateCustomTargetType.Sync(request, callSettings), CreateCustomTargetTypeOperationsClient);
        }

        /// <summary>
        /// Creates a new CustomTargetType in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CustomTargetType, OperationMetadata>> CreateCustomTargetTypeAsync(CreateCustomTargetTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCustomTargetTypeRequest(ref request, ref callSettings);
            return new lro::Operation<CustomTargetType, OperationMetadata>(await _callCreateCustomTargetType.Async(request, callSettings).ConfigureAwait(false), CreateCustomTargetTypeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateCustomTargetType</c>.</summary>
        public override lro::OperationsClient UpdateCustomTargetTypeOperationsClient { get; }

        /// <summary>
        /// Updates a single CustomTargetType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CustomTargetType, OperationMetadata> UpdateCustomTargetType(UpdateCustomTargetTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCustomTargetTypeRequest(ref request, ref callSettings);
            return new lro::Operation<CustomTargetType, OperationMetadata>(_callUpdateCustomTargetType.Sync(request, callSettings), UpdateCustomTargetTypeOperationsClient);
        }

        /// <summary>
        /// Updates a single CustomTargetType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CustomTargetType, OperationMetadata>> UpdateCustomTargetTypeAsync(UpdateCustomTargetTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCustomTargetTypeRequest(ref request, ref callSettings);
            return new lro::Operation<CustomTargetType, OperationMetadata>(await _callUpdateCustomTargetType.Async(request, callSettings).ConfigureAwait(false), UpdateCustomTargetTypeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteCustomTargetType</c>.</summary>
        public override lro::OperationsClient DeleteCustomTargetTypeOperationsClient { get; }

        /// <summary>
        /// Deletes a single CustomTargetType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteCustomTargetType(DeleteCustomTargetTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCustomTargetTypeRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteCustomTargetType.Sync(request, callSettings), DeleteCustomTargetTypeOperationsClient);
        }

        /// <summary>
        /// Deletes a single CustomTargetType.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCustomTargetTypeAsync(DeleteCustomTargetTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCustomTargetTypeRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteCustomTargetType.Async(request, callSettings).ConfigureAwait(false), DeleteCustomTargetTypeOperationsClient);
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
        /// Abandons a Release in the Delivery Pipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AbandonReleaseResponse AbandonRelease(AbandonReleaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AbandonReleaseRequest(ref request, ref callSettings);
            return _callAbandonRelease.Sync(request, callSettings);
        }

        /// <summary>
        /// Abandons a Release in the Delivery Pipeline.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AbandonReleaseResponse> AbandonReleaseAsync(AbandonReleaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AbandonReleaseRequest(ref request, ref callSettings);
            return _callAbandonRelease.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateDeployPolicy</c>.</summary>
        public override lro::OperationsClient CreateDeployPolicyOperationsClient { get; }

        /// <summary>
        /// Creates a new DeployPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DeployPolicy, OperationMetadata> CreateDeployPolicy(CreateDeployPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDeployPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<DeployPolicy, OperationMetadata>(_callCreateDeployPolicy.Sync(request, callSettings), CreateDeployPolicyOperationsClient);
        }

        /// <summary>
        /// Creates a new DeployPolicy in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DeployPolicy, OperationMetadata>> CreateDeployPolicyAsync(CreateDeployPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDeployPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<DeployPolicy, OperationMetadata>(await _callCreateDeployPolicy.Async(request, callSettings).ConfigureAwait(false), CreateDeployPolicyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateDeployPolicy</c>.</summary>
        public override lro::OperationsClient UpdateDeployPolicyOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single DeployPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DeployPolicy, OperationMetadata> UpdateDeployPolicy(UpdateDeployPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDeployPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<DeployPolicy, OperationMetadata>(_callUpdateDeployPolicy.Sync(request, callSettings), UpdateDeployPolicyOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single DeployPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DeployPolicy, OperationMetadata>> UpdateDeployPolicyAsync(UpdateDeployPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDeployPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<DeployPolicy, OperationMetadata>(await _callUpdateDeployPolicy.Async(request, callSettings).ConfigureAwait(false), UpdateDeployPolicyOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteDeployPolicy</c>.</summary>
        public override lro::OperationsClient DeleteDeployPolicyOperationsClient { get; }

        /// <summary>
        /// Deletes a single DeployPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteDeployPolicy(DeleteDeployPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDeployPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteDeployPolicy.Sync(request, callSettings), DeleteDeployPolicyOperationsClient);
        }

        /// <summary>
        /// Deletes a single DeployPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDeployPolicyAsync(DeleteDeployPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDeployPolicyRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteDeployPolicy.Async(request, callSettings).ConfigureAwait(false), DeleteDeployPolicyOperationsClient);
        }

        /// <summary>
        /// Lists DeployPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DeployPolicy"/> resources.</returns>
        public override gax::PagedEnumerable<ListDeployPoliciesResponse, DeployPolicy> ListDeployPolicies(ListDeployPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDeployPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDeployPoliciesRequest, ListDeployPoliciesResponse, DeployPolicy>(_callListDeployPolicies, request, callSettings);
        }

        /// <summary>
        /// Lists DeployPolicies in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DeployPolicy"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDeployPoliciesResponse, DeployPolicy> ListDeployPoliciesAsync(ListDeployPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDeployPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDeployPoliciesRequest, ListDeployPoliciesResponse, DeployPolicy>(_callListDeployPolicies, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single DeployPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DeployPolicy GetDeployPolicy(GetDeployPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDeployPolicyRequest(ref request, ref callSettings);
            return _callGetDeployPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single DeployPolicy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DeployPolicy> GetDeployPolicyAsync(GetDeployPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDeployPolicyRequest(ref request, ref callSettings);
            return _callGetDeployPolicy.Async(request, callSettings);
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
        /// Advances a Rollout in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AdvanceRolloutResponse AdvanceRollout(AdvanceRolloutRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AdvanceRolloutRequest(ref request, ref callSettings);
            return _callAdvanceRollout.Sync(request, callSettings);
        }

        /// <summary>
        /// Advances a Rollout in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AdvanceRolloutResponse> AdvanceRolloutAsync(AdvanceRolloutRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AdvanceRolloutRequest(ref request, ref callSettings);
            return _callAdvanceRollout.Async(request, callSettings);
        }

        /// <summary>
        /// Cancels a Rollout in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CancelRolloutResponse CancelRollout(CancelRolloutRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelRolloutRequest(ref request, ref callSettings);
            return _callCancelRollout.Sync(request, callSettings);
        }

        /// <summary>
        /// Cancels a Rollout in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CancelRolloutResponse> CancelRolloutAsync(CancelRolloutRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelRolloutRequest(ref request, ref callSettings);
            return _callCancelRollout.Async(request, callSettings);
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
        /// Ignores the specified Job in a Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override IgnoreJobResponse IgnoreJob(IgnoreJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_IgnoreJobRequest(ref request, ref callSettings);
            return _callIgnoreJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Ignores the specified Job in a Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<IgnoreJobResponse> IgnoreJobAsync(IgnoreJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_IgnoreJobRequest(ref request, ref callSettings);
            return _callIgnoreJob.Async(request, callSettings);
        }

        /// <summary>
        /// Retries the specified Job in a Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RetryJobResponse RetryJob(RetryJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RetryJobRequest(ref request, ref callSettings);
            return _callRetryJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Retries the specified Job in a Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RetryJobResponse> RetryJobAsync(RetryJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RetryJobRequest(ref request, ref callSettings);
            return _callRetryJob.Async(request, callSettings);
        }

        /// <summary>
        /// Lists JobRuns in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="JobRun"/> resources.</returns>
        public override gax::PagedEnumerable<ListJobRunsResponse, JobRun> ListJobRuns(ListJobRunsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListJobRunsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListJobRunsRequest, ListJobRunsResponse, JobRun>(_callListJobRuns, request, callSettings);
        }

        /// <summary>
        /// Lists JobRuns in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="JobRun"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListJobRunsResponse, JobRun> ListJobRunsAsync(ListJobRunsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListJobRunsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListJobRunsRequest, ListJobRunsResponse, JobRun>(_callListJobRuns, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single JobRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override JobRun GetJobRun(GetJobRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetJobRunRequest(ref request, ref callSettings);
            return _callGetJobRun.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single JobRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<JobRun> GetJobRunAsync(GetJobRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetJobRunRequest(ref request, ref callSettings);
            return _callGetJobRun.Async(request, callSettings);
        }

        /// <summary>
        /// Terminates a Job Run in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TerminateJobRunResponse TerminateJobRun(TerminateJobRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TerminateJobRunRequest(ref request, ref callSettings);
            return _callTerminateJobRun.Sync(request, callSettings);
        }

        /// <summary>
        /// Terminates a Job Run in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TerminateJobRunResponse> TerminateJobRunAsync(TerminateJobRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TerminateJobRunRequest(ref request, ref callSettings);
            return _callTerminateJobRun.Async(request, callSettings);
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

        /// <summary>The long-running operations client for <c>CreateAutomation</c>.</summary>
        public override lro::OperationsClient CreateAutomationOperationsClient { get; }

        /// <summary>
        /// Creates a new Automation in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Automation, OperationMetadata> CreateAutomation(CreateAutomationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAutomationRequest(ref request, ref callSettings);
            return new lro::Operation<Automation, OperationMetadata>(_callCreateAutomation.Sync(request, callSettings), CreateAutomationOperationsClient);
        }

        /// <summary>
        /// Creates a new Automation in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Automation, OperationMetadata>> CreateAutomationAsync(CreateAutomationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAutomationRequest(ref request, ref callSettings);
            return new lro::Operation<Automation, OperationMetadata>(await _callCreateAutomation.Async(request, callSettings).ConfigureAwait(false), CreateAutomationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateAutomation</c>.</summary>
        public override lro::OperationsClient UpdateAutomationOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single Automation resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Automation, OperationMetadata> UpdateAutomation(UpdateAutomationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAutomationRequest(ref request, ref callSettings);
            return new lro::Operation<Automation, OperationMetadata>(_callUpdateAutomation.Sync(request, callSettings), UpdateAutomationOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single Automation resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Automation, OperationMetadata>> UpdateAutomationAsync(UpdateAutomationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAutomationRequest(ref request, ref callSettings);
            return new lro::Operation<Automation, OperationMetadata>(await _callUpdateAutomation.Async(request, callSettings).ConfigureAwait(false), UpdateAutomationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteAutomation</c>.</summary>
        public override lro::OperationsClient DeleteAutomationOperationsClient { get; }

        /// <summary>
        /// Deletes a single Automation resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteAutomation(DeleteAutomationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAutomationRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteAutomation.Sync(request, callSettings), DeleteAutomationOperationsClient);
        }

        /// <summary>
        /// Deletes a single Automation resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAutomationAsync(DeleteAutomationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAutomationRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteAutomation.Async(request, callSettings).ConfigureAwait(false), DeleteAutomationOperationsClient);
        }

        /// <summary>
        /// Gets details of a single Automation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Automation GetAutomation(GetAutomationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAutomationRequest(ref request, ref callSettings);
            return _callGetAutomation.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Automation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Automation> GetAutomationAsync(GetAutomationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAutomationRequest(ref request, ref callSettings);
            return _callGetAutomation.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Automations in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Automation"/> resources.</returns>
        public override gax::PagedEnumerable<ListAutomationsResponse, Automation> ListAutomations(ListAutomationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAutomationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAutomationsRequest, ListAutomationsResponse, Automation>(_callListAutomations, request, callSettings);
        }

        /// <summary>
        /// Lists Automations in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Automation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAutomationsResponse, Automation> ListAutomationsAsync(ListAutomationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAutomationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAutomationsRequest, ListAutomationsResponse, Automation>(_callListAutomations, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single AutomationRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AutomationRun GetAutomationRun(GetAutomationRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAutomationRunRequest(ref request, ref callSettings);
            return _callGetAutomationRun.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single AutomationRun.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AutomationRun> GetAutomationRunAsync(GetAutomationRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAutomationRunRequest(ref request, ref callSettings);
            return _callGetAutomationRun.Async(request, callSettings);
        }

        /// <summary>
        /// Lists AutomationRuns in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AutomationRun"/> resources.</returns>
        public override gax::PagedEnumerable<ListAutomationRunsResponse, AutomationRun> ListAutomationRuns(ListAutomationRunsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAutomationRunsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAutomationRunsRequest, ListAutomationRunsResponse, AutomationRun>(_callListAutomationRuns, request, callSettings);
        }

        /// <summary>
        /// Lists AutomationRuns in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AutomationRun"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAutomationRunsResponse, AutomationRun> ListAutomationRunsAsync(ListAutomationRunsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAutomationRunsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAutomationRunsRequest, ListAutomationRunsResponse, AutomationRun>(_callListAutomationRuns, request, callSettings);
        }

        /// <summary>
        /// Cancels an AutomationRun. The `state` of the `AutomationRun` after
        /// cancelling is `CANCELLED`. `CancelAutomationRun` can be called on
        /// AutomationRun in the state `IN_PROGRESS` and `PENDING`; AutomationRun
        /// in a different state returns an `FAILED_PRECONDITION` error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CancelAutomationRunResponse CancelAutomationRun(CancelAutomationRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelAutomationRunRequest(ref request, ref callSettings);
            return _callCancelAutomationRun.Sync(request, callSettings);
        }

        /// <summary>
        /// Cancels an AutomationRun. The `state` of the `AutomationRun` after
        /// cancelling is `CANCELLED`. `CancelAutomationRun` can be called on
        /// AutomationRun in the state `IN_PROGRESS` and `PENDING`; AutomationRun
        /// in a different state returns an `FAILED_PRECONDITION` error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CancelAutomationRunResponse> CancelAutomationRunAsync(CancelAutomationRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelAutomationRunRequest(ref request, ref callSettings);
            return _callCancelAutomationRun.Async(request, callSettings);
        }
    }

    public partial class ListDeliveryPipelinesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTargetsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCustomTargetTypesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListReleasesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDeployPoliciesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRolloutsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListJobRunsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAutomationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAutomationRunsRequest : gaxgrpc::IPageRequest
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

    public partial class ListCustomTargetTypesResponse : gaxgrpc::IPageResponse<CustomTargetType>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CustomTargetType> GetEnumerator() => CustomTargetTypes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListReleasesResponse : gaxgrpc::IPageResponse<Release>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Release> GetEnumerator() => Releases.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDeployPoliciesResponse : gaxgrpc::IPageResponse<DeployPolicy>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DeployPolicy> GetEnumerator() => DeployPolicies.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListRolloutsResponse : gaxgrpc::IPageResponse<Rollout>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Rollout> GetEnumerator() => Rollouts.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListJobRunsResponse : gaxgrpc::IPageResponse<JobRun>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<JobRun> GetEnumerator() => JobRuns.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAutomationsResponse : gaxgrpc::IPageResponse<Automation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Automation> GetEnumerator() => Automations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAutomationRunsResponse : gaxgrpc::IPageResponse<AutomationRun>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AutomationRun> GetEnumerator() => AutomationRuns.GetEnumerator();

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

    public static partial class CloudDeploy
    {
        public partial class CloudDeployClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="gcl::Locations.LocationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gcl::Locations.LocationsClient"/> for the same target as this client.
            /// </returns>
            public virtual gcl::Locations.LocationsClient CreateLocationsClient() =>
                new gcl::Locations.LocationsClient(CallInvoker);

            /// <summary>
            /// Creates a new instance of <see cref="gciv::IAMPolicy.IAMPolicyClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>
            /// A new <see cref="gciv::IAMPolicy.IAMPolicyClient"/> for the same target as this client.
            /// </returns>
            public virtual gciv::IAMPolicy.IAMPolicyClient CreateIAMPolicyClient() =>
                new gciv::IAMPolicy.IAMPolicyClient(CallInvoker);
        }
    }
}
