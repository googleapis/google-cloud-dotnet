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

namespace Google.Cloud.CloudBuild.V1
{
    /// <summary>Settings for <see cref="CloudBuildClient"/> instances.</summary>
    public sealed partial class CloudBuildSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CloudBuildSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CloudBuildSettings"/>.</returns>
        public static CloudBuildSettings GetDefault() => new CloudBuildSettings();

        /// <summary>Constructs a new <see cref="CloudBuildSettings"/> object with default settings.</summary>
        public CloudBuildSettings()
        {
        }

        private CloudBuildSettings(CloudBuildSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateBuildSettings = existing.CreateBuildSettings;
            CreateBuildOperationsSettings = existing.CreateBuildOperationsSettings.Clone();
            GetBuildSettings = existing.GetBuildSettings;
            ListBuildsSettings = existing.ListBuildsSettings;
            CancelBuildSettings = existing.CancelBuildSettings;
            RetryBuildSettings = existing.RetryBuildSettings;
            RetryBuildOperationsSettings = existing.RetryBuildOperationsSettings.Clone();
            ApproveBuildSettings = existing.ApproveBuildSettings;
            ApproveBuildOperationsSettings = existing.ApproveBuildOperationsSettings.Clone();
            CreateBuildTriggerSettings = existing.CreateBuildTriggerSettings;
            GetBuildTriggerSettings = existing.GetBuildTriggerSettings;
            ListBuildTriggersSettings = existing.ListBuildTriggersSettings;
            DeleteBuildTriggerSettings = existing.DeleteBuildTriggerSettings;
            UpdateBuildTriggerSettings = existing.UpdateBuildTriggerSettings;
            RunBuildTriggerSettings = existing.RunBuildTriggerSettings;
            RunBuildTriggerOperationsSettings = existing.RunBuildTriggerOperationsSettings.Clone();
            ReceiveTriggerWebhookSettings = existing.ReceiveTriggerWebhookSettings;
            CreateWorkerPoolSettings = existing.CreateWorkerPoolSettings;
            CreateWorkerPoolOperationsSettings = existing.CreateWorkerPoolOperationsSettings.Clone();
            GetWorkerPoolSettings = existing.GetWorkerPoolSettings;
            DeleteWorkerPoolSettings = existing.DeleteWorkerPoolSettings;
            DeleteWorkerPoolOperationsSettings = existing.DeleteWorkerPoolOperationsSettings.Clone();
            UpdateWorkerPoolSettings = existing.UpdateWorkerPoolSettings;
            UpdateWorkerPoolOperationsSettings = existing.UpdateWorkerPoolOperationsSettings.Clone();
            ListWorkerPoolsSettings = existing.ListWorkerPoolsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CloudBuildSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudBuildClient.CreateBuild</c> and <c>CloudBuildClient.CreateBuildAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateBuildSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudBuildClient.CreateBuild</c> and
        /// <c>CloudBuildClient.CreateBuildAsync</c>.
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
        public lro::OperationsSettings CreateBuildOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>CloudBuildClient.GetBuild</c>
        ///  and <c>CloudBuildClient.GetBuildAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetBuildSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>CloudBuildClient.ListBuilds</c>
        ///  and <c>CloudBuildClient.ListBuildsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListBuildsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudBuildClient.CancelBuild</c> and <c>CloudBuildClient.CancelBuildAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CancelBuildSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>CloudBuildClient.RetryBuild</c>
        ///  and <c>CloudBuildClient.RetryBuildAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RetryBuildSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudBuildClient.RetryBuild</c> and
        /// <c>CloudBuildClient.RetryBuildAsync</c>.
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
        public lro::OperationsSettings RetryBuildOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudBuildClient.ApproveBuild</c> and <c>CloudBuildClient.ApproveBuildAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ApproveBuildSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudBuildClient.ApproveBuild</c> and
        /// <c>CloudBuildClient.ApproveBuildAsync</c>.
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
        public lro::OperationsSettings ApproveBuildOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudBuildClient.CreateBuildTrigger</c> and <c>CloudBuildClient.CreateBuildTriggerAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateBuildTriggerSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudBuildClient.GetBuildTrigger</c> and <c>CloudBuildClient.GetBuildTriggerAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetBuildTriggerSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudBuildClient.ListBuildTriggers</c> and <c>CloudBuildClient.ListBuildTriggersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListBuildTriggersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudBuildClient.DeleteBuildTrigger</c> and <c>CloudBuildClient.DeleteBuildTriggerAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteBuildTriggerSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudBuildClient.UpdateBuildTrigger</c> and <c>CloudBuildClient.UpdateBuildTriggerAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateBuildTriggerSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudBuildClient.RunBuildTrigger</c> and <c>CloudBuildClient.RunBuildTriggerAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RunBuildTriggerSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudBuildClient.RunBuildTrigger</c> and
        /// <c>CloudBuildClient.RunBuildTriggerAsync</c>.
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
        public lro::OperationsSettings RunBuildTriggerOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudBuildClient.ReceiveTriggerWebhook</c> and <c>CloudBuildClient.ReceiveTriggerWebhookAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReceiveTriggerWebhookSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudBuildClient.CreateWorkerPool</c> and <c>CloudBuildClient.CreateWorkerPoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateWorkerPoolSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudBuildClient.CreateWorkerPool</c> and
        /// <c>CloudBuildClient.CreateWorkerPoolAsync</c>.
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
        public lro::OperationsSettings CreateWorkerPoolOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudBuildClient.GetWorkerPool</c> and <c>CloudBuildClient.GetWorkerPoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetWorkerPoolSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudBuildClient.DeleteWorkerPool</c> and <c>CloudBuildClient.DeleteWorkerPoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteWorkerPoolSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudBuildClient.DeleteWorkerPool</c> and
        /// <c>CloudBuildClient.DeleteWorkerPoolAsync</c>.
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
        public lro::OperationsSettings DeleteWorkerPoolOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudBuildClient.UpdateWorkerPool</c> and <c>CloudBuildClient.UpdateWorkerPoolAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateWorkerPoolSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudBuildClient.UpdateWorkerPool</c> and
        /// <c>CloudBuildClient.UpdateWorkerPoolAsync</c>.
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
        public lro::OperationsSettings UpdateWorkerPoolOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudBuildClient.ListWorkerPools</c> and <c>CloudBuildClient.ListWorkerPoolsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListWorkerPoolsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CloudBuildSettings"/> object.</returns>
        public CloudBuildSettings Clone() => new CloudBuildSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CloudBuildClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class CloudBuildClientBuilder : gaxgrpc::ClientBuilderBase<CloudBuildClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CloudBuildSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CloudBuildClientBuilder() : base(CloudBuildClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CloudBuildClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CloudBuildClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CloudBuildClient Build()
        {
            CloudBuildClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CloudBuildClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CloudBuildClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CloudBuildClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CloudBuildClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CloudBuildClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CloudBuildClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CloudBuildClient.ChannelPool;
    }

    /// <summary>CloudBuild client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Creates and manages builds on Google Cloud Platform.
    /// 
    /// The main concept used by this API is a `Build`, which describes the location
    /// of the source to build, how to build the source, and where to store the
    /// built artifacts, if any.
    /// 
    /// A user can list previously-requested builds or get builds by their ID to
    /// determine the status of the build.
    /// </remarks>
    public abstract partial class CloudBuildClient
    {
        /// <summary>
        /// The default endpoint for the CloudBuild service, which is a host of "cloudbuild.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudbuild.googleapis.com:443";

        /// <summary>The default CloudBuild scopes.</summary>
        /// <remarks>
        /// The default CloudBuild scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CloudBuild.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CloudBuildClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CloudBuildClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CloudBuildClient"/>.</returns>
        public static stt::Task<CloudBuildClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CloudBuildClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CloudBuildClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="CloudBuildClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CloudBuildClient"/>.</returns>
        public static CloudBuildClient Create() => new CloudBuildClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CloudBuildClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CloudBuildSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CloudBuildClient"/>.</returns>
        internal static CloudBuildClient Create(grpccore::CallInvoker callInvoker, CloudBuildSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CloudBuild.CloudBuildClient grpcClient = new CloudBuild.CloudBuildClient(callInvoker);
            return new CloudBuildClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CloudBuild client</summary>
        public virtual CloudBuild.CloudBuildClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Starts a build with the specified configuration.
        /// 
        /// This method returns a long-running `Operation`, which includes the build
        /// ID. Pass the build ID to `GetBuild` to determine the build status (such as
        /// `SUCCESS` or `FAILURE`).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Build, BuildOperationMetadata> CreateBuild(CreateBuildRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts a build with the specified configuration.
        /// 
        /// This method returns a long-running `Operation`, which includes the build
        /// ID. Pass the build ID to `GetBuild` to determine the build status (such as
        /// `SUCCESS` or `FAILURE`).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Build, BuildOperationMetadata>> CreateBuildAsync(CreateBuildRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts a build with the specified configuration.
        /// 
        /// This method returns a long-running `Operation`, which includes the build
        /// ID. Pass the build ID to `GetBuild` to determine the build status (such as
        /// `SUCCESS` or `FAILURE`).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Build, BuildOperationMetadata>> CreateBuildAsync(CreateBuildRequest request, st::CancellationToken cancellationToken) =>
            CreateBuildAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateBuild</c>.</summary>
        public virtual lro::OperationsClient CreateBuildOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateBuild</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Build, BuildOperationMetadata> PollOnceCreateBuild(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Build, BuildOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateBuildOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateBuild</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Build, BuildOperationMetadata>> PollOnceCreateBuildAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Build, BuildOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateBuildOperationsClient, callSettings);

        /// <summary>
        /// Starts a build with the specified configuration.
        /// 
        /// This method returns a long-running `Operation`, which includes the build
        /// ID. Pass the build ID to `GetBuild` to determine the build status (such as
        /// `SUCCESS` or `FAILURE`).
        /// </summary>
        /// <param name="projectId">
        /// Required. ID of the project.
        /// </param>
        /// <param name="build">
        /// Required. Build resource to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Build, BuildOperationMetadata> CreateBuild(string projectId, Build build, gaxgrpc::CallSettings callSettings = null) =>
            CreateBuild(new CreateBuildRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Build = gax::GaxPreconditions.CheckNotNull(build, nameof(build)),
            }, callSettings);

        /// <summary>
        /// Starts a build with the specified configuration.
        /// 
        /// This method returns a long-running `Operation`, which includes the build
        /// ID. Pass the build ID to `GetBuild` to determine the build status (such as
        /// `SUCCESS` or `FAILURE`).
        /// </summary>
        /// <param name="projectId">
        /// Required. ID of the project.
        /// </param>
        /// <param name="build">
        /// Required. Build resource to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Build, BuildOperationMetadata>> CreateBuildAsync(string projectId, Build build, gaxgrpc::CallSettings callSettings = null) =>
            CreateBuildAsync(new CreateBuildRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Build = gax::GaxPreconditions.CheckNotNull(build, nameof(build)),
            }, callSettings);

        /// <summary>
        /// Starts a build with the specified configuration.
        /// 
        /// This method returns a long-running `Operation`, which includes the build
        /// ID. Pass the build ID to `GetBuild` to determine the build status (such as
        /// `SUCCESS` or `FAILURE`).
        /// </summary>
        /// <param name="projectId">
        /// Required. ID of the project.
        /// </param>
        /// <param name="build">
        /// Required. Build resource to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Build, BuildOperationMetadata>> CreateBuildAsync(string projectId, Build build, st::CancellationToken cancellationToken) =>
            CreateBuildAsync(projectId, build, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns information about a previously requested build.
        /// 
        /// The `Build` that is returned includes its status (such as `SUCCESS`,
        /// `FAILURE`, or `WORKING`), and timing information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Build GetBuild(GetBuildRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns information about a previously requested build.
        /// 
        /// The `Build` that is returned includes its status (such as `SUCCESS`,
        /// `FAILURE`, or `WORKING`), and timing information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Build> GetBuildAsync(GetBuildRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns information about a previously requested build.
        /// 
        /// The `Build` that is returned includes its status (such as `SUCCESS`,
        /// `FAILURE`, or `WORKING`), and timing information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Build> GetBuildAsync(GetBuildRequest request, st::CancellationToken cancellationToken) =>
            GetBuildAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns information about a previously requested build.
        /// 
        /// The `Build` that is returned includes its status (such as `SUCCESS`,
        /// `FAILURE`, or `WORKING`), and timing information.
        /// </summary>
        /// <param name="projectId">
        /// Required. ID of the project.
        /// </param>
        /// <param name="id">
        /// Required. ID of the build.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Build GetBuild(string projectId, string id, gaxgrpc::CallSettings callSettings = null) =>
            GetBuild(new GetBuildRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Id = gax::GaxPreconditions.CheckNotNullOrEmpty(id, nameof(id)),
            }, callSettings);

        /// <summary>
        /// Returns information about a previously requested build.
        /// 
        /// The `Build` that is returned includes its status (such as `SUCCESS`,
        /// `FAILURE`, or `WORKING`), and timing information.
        /// </summary>
        /// <param name="projectId">
        /// Required. ID of the project.
        /// </param>
        /// <param name="id">
        /// Required. ID of the build.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Build> GetBuildAsync(string projectId, string id, gaxgrpc::CallSettings callSettings = null) =>
            GetBuildAsync(new GetBuildRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Id = gax::GaxPreconditions.CheckNotNullOrEmpty(id, nameof(id)),
            }, callSettings);

        /// <summary>
        /// Returns information about a previously requested build.
        /// 
        /// The `Build` that is returned includes its status (such as `SUCCESS`,
        /// `FAILURE`, or `WORKING`), and timing information.
        /// </summary>
        /// <param name="projectId">
        /// Required. ID of the project.
        /// </param>
        /// <param name="id">
        /// Required. ID of the build.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Build> GetBuildAsync(string projectId, string id, st::CancellationToken cancellationToken) =>
            GetBuildAsync(projectId, id, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists previously requested builds.
        /// 
        /// Previously requested builds may still be in-progress, or may have finished
        /// successfully or unsuccessfully.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Build"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBuildsResponse, Build> ListBuilds(ListBuildsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists previously requested builds.
        /// 
        /// Previously requested builds may still be in-progress, or may have finished
        /// successfully or unsuccessfully.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Build"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBuildsResponse, Build> ListBuildsAsync(ListBuildsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists previously requested builds.
        /// 
        /// Previously requested builds may still be in-progress, or may have finished
        /// successfully or unsuccessfully.
        /// </summary>
        /// <param name="projectId">
        /// Required. ID of the project.
        /// </param>
        /// <param name="filter">
        /// The raw filter text to constrain the results.
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
        /// <returns>A pageable sequence of <see cref="Build"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBuildsResponse, Build> ListBuilds(string projectId, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBuildsRequest request = new ListBuildsRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Filter = filter ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListBuilds(request, callSettings);
        }

        /// <summary>
        /// Lists previously requested builds.
        /// 
        /// Previously requested builds may still be in-progress, or may have finished
        /// successfully or unsuccessfully.
        /// </summary>
        /// <param name="projectId">
        /// Required. ID of the project.
        /// </param>
        /// <param name="filter">
        /// The raw filter text to constrain the results.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Build"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBuildsResponse, Build> ListBuildsAsync(string projectId, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBuildsRequest request = new ListBuildsRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Filter = filter ?? "",
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListBuildsAsync(request, callSettings);
        }

        /// <summary>
        /// Cancels a build in progress.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Build CancelBuild(CancelBuildRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels a build in progress.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Build> CancelBuildAsync(CancelBuildRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels a build in progress.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Build> CancelBuildAsync(CancelBuildRequest request, st::CancellationToken cancellationToken) =>
            CancelBuildAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels a build in progress.
        /// </summary>
        /// <param name="projectId">
        /// Required. ID of the project.
        /// </param>
        /// <param name="id">
        /// Required. ID of the build.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Build CancelBuild(string projectId, string id, gaxgrpc::CallSettings callSettings = null) =>
            CancelBuild(new CancelBuildRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Id = gax::GaxPreconditions.CheckNotNullOrEmpty(id, nameof(id)),
            }, callSettings);

        /// <summary>
        /// Cancels a build in progress.
        /// </summary>
        /// <param name="projectId">
        /// Required. ID of the project.
        /// </param>
        /// <param name="id">
        /// Required. ID of the build.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Build> CancelBuildAsync(string projectId, string id, gaxgrpc::CallSettings callSettings = null) =>
            CancelBuildAsync(new CancelBuildRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Id = gax::GaxPreconditions.CheckNotNullOrEmpty(id, nameof(id)),
            }, callSettings);

        /// <summary>
        /// Cancels a build in progress.
        /// </summary>
        /// <param name="projectId">
        /// Required. ID of the project.
        /// </param>
        /// <param name="id">
        /// Required. ID of the build.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Build> CancelBuildAsync(string projectId, string id, st::CancellationToken cancellationToken) =>
            CancelBuildAsync(projectId, id, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new build based on the specified build.
        /// 
        /// This method creates a new build using the original build request, which may
        /// or may not result in an identical build.
        /// 
        /// For triggered builds:
        /// 
        /// * Triggered builds resolve to a precise revision; therefore a retry of a
        /// triggered build will result in a build that uses the same revision.
        /// 
        /// For non-triggered builds that specify `RepoSource`:
        /// 
        /// * If the original build built from the tip of a branch, the retried build
        /// will build from the tip of that branch, which may not be the same revision
        /// as the original build.
        /// * If the original build specified a commit sha or revision ID, the retried
        /// build will use the identical source.
        /// 
        /// For builds that specify `StorageSource`:
        /// 
        /// * If the original build pulled source from Cloud Storage without
        /// specifying the generation of the object, the new build will use the current
        /// object, which may be different from the original build source.
        /// * If the original build pulled source from Cloud Storage and specified the
        /// generation of the object, the new build will attempt to use the same
        /// object, which may or may not be available depending on the bucket's
        /// lifecycle management settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Build, BuildOperationMetadata> RetryBuild(RetryBuildRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new build based on the specified build.
        /// 
        /// This method creates a new build using the original build request, which may
        /// or may not result in an identical build.
        /// 
        /// For triggered builds:
        /// 
        /// * Triggered builds resolve to a precise revision; therefore a retry of a
        /// triggered build will result in a build that uses the same revision.
        /// 
        /// For non-triggered builds that specify `RepoSource`:
        /// 
        /// * If the original build built from the tip of a branch, the retried build
        /// will build from the tip of that branch, which may not be the same revision
        /// as the original build.
        /// * If the original build specified a commit sha or revision ID, the retried
        /// build will use the identical source.
        /// 
        /// For builds that specify `StorageSource`:
        /// 
        /// * If the original build pulled source from Cloud Storage without
        /// specifying the generation of the object, the new build will use the current
        /// object, which may be different from the original build source.
        /// * If the original build pulled source from Cloud Storage and specified the
        /// generation of the object, the new build will attempt to use the same
        /// object, which may or may not be available depending on the bucket's
        /// lifecycle management settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Build, BuildOperationMetadata>> RetryBuildAsync(RetryBuildRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new build based on the specified build.
        /// 
        /// This method creates a new build using the original build request, which may
        /// or may not result in an identical build.
        /// 
        /// For triggered builds:
        /// 
        /// * Triggered builds resolve to a precise revision; therefore a retry of a
        /// triggered build will result in a build that uses the same revision.
        /// 
        /// For non-triggered builds that specify `RepoSource`:
        /// 
        /// * If the original build built from the tip of a branch, the retried build
        /// will build from the tip of that branch, which may not be the same revision
        /// as the original build.
        /// * If the original build specified a commit sha or revision ID, the retried
        /// build will use the identical source.
        /// 
        /// For builds that specify `StorageSource`:
        /// 
        /// * If the original build pulled source from Cloud Storage without
        /// specifying the generation of the object, the new build will use the current
        /// object, which may be different from the original build source.
        /// * If the original build pulled source from Cloud Storage and specified the
        /// generation of the object, the new build will attempt to use the same
        /// object, which may or may not be available depending on the bucket's
        /// lifecycle management settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Build, BuildOperationMetadata>> RetryBuildAsync(RetryBuildRequest request, st::CancellationToken cancellationToken) =>
            RetryBuildAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RetryBuild</c>.</summary>
        public virtual lro::OperationsClient RetryBuildOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RetryBuild</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Build, BuildOperationMetadata> PollOnceRetryBuild(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Build, BuildOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RetryBuildOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RetryBuild</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Build, BuildOperationMetadata>> PollOnceRetryBuildAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Build, BuildOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RetryBuildOperationsClient, callSettings);

        /// <summary>
        /// Creates a new build based on the specified build.
        /// 
        /// This method creates a new build using the original build request, which may
        /// or may not result in an identical build.
        /// 
        /// For triggered builds:
        /// 
        /// * Triggered builds resolve to a precise revision; therefore a retry of a
        /// triggered build will result in a build that uses the same revision.
        /// 
        /// For non-triggered builds that specify `RepoSource`:
        /// 
        /// * If the original build built from the tip of a branch, the retried build
        /// will build from the tip of that branch, which may not be the same revision
        /// as the original build.
        /// * If the original build specified a commit sha or revision ID, the retried
        /// build will use the identical source.
        /// 
        /// For builds that specify `StorageSource`:
        /// 
        /// * If the original build pulled source from Cloud Storage without
        /// specifying the generation of the object, the new build will use the current
        /// object, which may be different from the original build source.
        /// * If the original build pulled source from Cloud Storage and specified the
        /// generation of the object, the new build will attempt to use the same
        /// object, which may or may not be available depending on the bucket's
        /// lifecycle management settings.
        /// </summary>
        /// <param name="projectId">
        /// Required. ID of the project.
        /// </param>
        /// <param name="id">
        /// Required. Build ID of the original build.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Build, BuildOperationMetadata> RetryBuild(string projectId, string id, gaxgrpc::CallSettings callSettings = null) =>
            RetryBuild(new RetryBuildRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Id = gax::GaxPreconditions.CheckNotNullOrEmpty(id, nameof(id)),
            }, callSettings);

        /// <summary>
        /// Creates a new build based on the specified build.
        /// 
        /// This method creates a new build using the original build request, which may
        /// or may not result in an identical build.
        /// 
        /// For triggered builds:
        /// 
        /// * Triggered builds resolve to a precise revision; therefore a retry of a
        /// triggered build will result in a build that uses the same revision.
        /// 
        /// For non-triggered builds that specify `RepoSource`:
        /// 
        /// * If the original build built from the tip of a branch, the retried build
        /// will build from the tip of that branch, which may not be the same revision
        /// as the original build.
        /// * If the original build specified a commit sha or revision ID, the retried
        /// build will use the identical source.
        /// 
        /// For builds that specify `StorageSource`:
        /// 
        /// * If the original build pulled source from Cloud Storage without
        /// specifying the generation of the object, the new build will use the current
        /// object, which may be different from the original build source.
        /// * If the original build pulled source from Cloud Storage and specified the
        /// generation of the object, the new build will attempt to use the same
        /// object, which may or may not be available depending on the bucket's
        /// lifecycle management settings.
        /// </summary>
        /// <param name="projectId">
        /// Required. ID of the project.
        /// </param>
        /// <param name="id">
        /// Required. Build ID of the original build.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Build, BuildOperationMetadata>> RetryBuildAsync(string projectId, string id, gaxgrpc::CallSettings callSettings = null) =>
            RetryBuildAsync(new RetryBuildRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Id = gax::GaxPreconditions.CheckNotNullOrEmpty(id, nameof(id)),
            }, callSettings);

        /// <summary>
        /// Creates a new build based on the specified build.
        /// 
        /// This method creates a new build using the original build request, which may
        /// or may not result in an identical build.
        /// 
        /// For triggered builds:
        /// 
        /// * Triggered builds resolve to a precise revision; therefore a retry of a
        /// triggered build will result in a build that uses the same revision.
        /// 
        /// For non-triggered builds that specify `RepoSource`:
        /// 
        /// * If the original build built from the tip of a branch, the retried build
        /// will build from the tip of that branch, which may not be the same revision
        /// as the original build.
        /// * If the original build specified a commit sha or revision ID, the retried
        /// build will use the identical source.
        /// 
        /// For builds that specify `StorageSource`:
        /// 
        /// * If the original build pulled source from Cloud Storage without
        /// specifying the generation of the object, the new build will use the current
        /// object, which may be different from the original build source.
        /// * If the original build pulled source from Cloud Storage and specified the
        /// generation of the object, the new build will attempt to use the same
        /// object, which may or may not be available depending on the bucket's
        /// lifecycle management settings.
        /// </summary>
        /// <param name="projectId">
        /// Required. ID of the project.
        /// </param>
        /// <param name="id">
        /// Required. Build ID of the original build.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Build, BuildOperationMetadata>> RetryBuildAsync(string projectId, string id, st::CancellationToken cancellationToken) =>
            RetryBuildAsync(projectId, id, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Approves or rejects a pending build.
        /// 
        /// If approved, the returned LRO will be analogous to the LRO returned from
        /// a CreateBuild call.
        /// 
        /// If rejected, the returned LRO will be immediately done.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Build, BuildOperationMetadata> ApproveBuild(ApproveBuildRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Approves or rejects a pending build.
        /// 
        /// If approved, the returned LRO will be analogous to the LRO returned from
        /// a CreateBuild call.
        /// 
        /// If rejected, the returned LRO will be immediately done.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Build, BuildOperationMetadata>> ApproveBuildAsync(ApproveBuildRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Approves or rejects a pending build.
        /// 
        /// If approved, the returned LRO will be analogous to the LRO returned from
        /// a CreateBuild call.
        /// 
        /// If rejected, the returned LRO will be immediately done.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Build, BuildOperationMetadata>> ApproveBuildAsync(ApproveBuildRequest request, st::CancellationToken cancellationToken) =>
            ApproveBuildAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ApproveBuild</c>.</summary>
        public virtual lro::OperationsClient ApproveBuildOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ApproveBuild</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Build, BuildOperationMetadata> PollOnceApproveBuild(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Build, BuildOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ApproveBuildOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ApproveBuild</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Build, BuildOperationMetadata>> PollOnceApproveBuildAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Build, BuildOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ApproveBuildOperationsClient, callSettings);

        /// <summary>
        /// Approves or rejects a pending build.
        /// 
        /// If approved, the returned LRO will be analogous to the LRO returned from
        /// a CreateBuild call.
        /// 
        /// If rejected, the returned LRO will be immediately done.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the target build.
        /// For example: "projects/{$project_id}/builds/{$build_id}"
        /// </param>
        /// <param name="approvalResult">
        /// Approval decision and metadata.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Build, BuildOperationMetadata> ApproveBuild(string name, ApprovalResult approvalResult, gaxgrpc::CallSettings callSettings = null) =>
            ApproveBuild(new ApproveBuildRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                ApprovalResult = approvalResult,
            }, callSettings);

        /// <summary>
        /// Approves or rejects a pending build.
        /// 
        /// If approved, the returned LRO will be analogous to the LRO returned from
        /// a CreateBuild call.
        /// 
        /// If rejected, the returned LRO will be immediately done.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the target build.
        /// For example: "projects/{$project_id}/builds/{$build_id}"
        /// </param>
        /// <param name="approvalResult">
        /// Approval decision and metadata.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Build, BuildOperationMetadata>> ApproveBuildAsync(string name, ApprovalResult approvalResult, gaxgrpc::CallSettings callSettings = null) =>
            ApproveBuildAsync(new ApproveBuildRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                ApprovalResult = approvalResult,
            }, callSettings);

        /// <summary>
        /// Approves or rejects a pending build.
        /// 
        /// If approved, the returned LRO will be analogous to the LRO returned from
        /// a CreateBuild call.
        /// 
        /// If rejected, the returned LRO will be immediately done.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the target build.
        /// For example: "projects/{$project_id}/builds/{$build_id}"
        /// </param>
        /// <param name="approvalResult">
        /// Approval decision and metadata.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Build, BuildOperationMetadata>> ApproveBuildAsync(string name, ApprovalResult approvalResult, st::CancellationToken cancellationToken) =>
            ApproveBuildAsync(name, approvalResult, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new `BuildTrigger`.
        /// 
        /// This API is experimental.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BuildTrigger CreateBuildTrigger(CreateBuildTriggerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new `BuildTrigger`.
        /// 
        /// This API is experimental.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BuildTrigger> CreateBuildTriggerAsync(CreateBuildTriggerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new `BuildTrigger`.
        /// 
        /// This API is experimental.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BuildTrigger> CreateBuildTriggerAsync(CreateBuildTriggerRequest request, st::CancellationToken cancellationToken) =>
            CreateBuildTriggerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new `BuildTrigger`.
        /// 
        /// This API is experimental.
        /// </summary>
        /// <param name="projectId">
        /// Required. ID of the project for which to configure automatic builds.
        /// </param>
        /// <param name="trigger">
        /// Required. `BuildTrigger` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BuildTrigger CreateBuildTrigger(string projectId, BuildTrigger trigger, gaxgrpc::CallSettings callSettings = null) =>
            CreateBuildTrigger(new CreateBuildTriggerRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Trigger = gax::GaxPreconditions.CheckNotNull(trigger, nameof(trigger)),
            }, callSettings);

        /// <summary>
        /// Creates a new `BuildTrigger`.
        /// 
        /// This API is experimental.
        /// </summary>
        /// <param name="projectId">
        /// Required. ID of the project for which to configure automatic builds.
        /// </param>
        /// <param name="trigger">
        /// Required. `BuildTrigger` to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BuildTrigger> CreateBuildTriggerAsync(string projectId, BuildTrigger trigger, gaxgrpc::CallSettings callSettings = null) =>
            CreateBuildTriggerAsync(new CreateBuildTriggerRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                Trigger = gax::GaxPreconditions.CheckNotNull(trigger, nameof(trigger)),
            }, callSettings);

        /// <summary>
        /// Creates a new `BuildTrigger`.
        /// 
        /// This API is experimental.
        /// </summary>
        /// <param name="projectId">
        /// Required. ID of the project for which to configure automatic builds.
        /// </param>
        /// <param name="trigger">
        /// Required. `BuildTrigger` to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BuildTrigger> CreateBuildTriggerAsync(string projectId, BuildTrigger trigger, st::CancellationToken cancellationToken) =>
            CreateBuildTriggerAsync(projectId, trigger, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns information about a `BuildTrigger`.
        /// 
        /// This API is experimental.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BuildTrigger GetBuildTrigger(GetBuildTriggerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns information about a `BuildTrigger`.
        /// 
        /// This API is experimental.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BuildTrigger> GetBuildTriggerAsync(GetBuildTriggerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns information about a `BuildTrigger`.
        /// 
        /// This API is experimental.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BuildTrigger> GetBuildTriggerAsync(GetBuildTriggerRequest request, st::CancellationToken cancellationToken) =>
            GetBuildTriggerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns information about a `BuildTrigger`.
        /// 
        /// This API is experimental.
        /// </summary>
        /// <param name="projectId">
        /// Required. ID of the project that owns the trigger.
        /// </param>
        /// <param name="triggerId">
        /// Required. Identifier (`id` or `name`) of the `BuildTrigger` to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BuildTrigger GetBuildTrigger(string projectId, string triggerId, gaxgrpc::CallSettings callSettings = null) =>
            GetBuildTrigger(new GetBuildTriggerRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                TriggerId = gax::GaxPreconditions.CheckNotNullOrEmpty(triggerId, nameof(triggerId)),
            }, callSettings);

        /// <summary>
        /// Returns information about a `BuildTrigger`.
        /// 
        /// This API is experimental.
        /// </summary>
        /// <param name="projectId">
        /// Required. ID of the project that owns the trigger.
        /// </param>
        /// <param name="triggerId">
        /// Required. Identifier (`id` or `name`) of the `BuildTrigger` to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BuildTrigger> GetBuildTriggerAsync(string projectId, string triggerId, gaxgrpc::CallSettings callSettings = null) =>
            GetBuildTriggerAsync(new GetBuildTriggerRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                TriggerId = gax::GaxPreconditions.CheckNotNullOrEmpty(triggerId, nameof(triggerId)),
            }, callSettings);

        /// <summary>
        /// Returns information about a `BuildTrigger`.
        /// 
        /// This API is experimental.
        /// </summary>
        /// <param name="projectId">
        /// Required. ID of the project that owns the trigger.
        /// </param>
        /// <param name="triggerId">
        /// Required. Identifier (`id` or `name`) of the `BuildTrigger` to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BuildTrigger> GetBuildTriggerAsync(string projectId, string triggerId, st::CancellationToken cancellationToken) =>
            GetBuildTriggerAsync(projectId, triggerId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists existing `BuildTrigger`s.
        /// 
        /// This API is experimental.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BuildTrigger"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBuildTriggersResponse, BuildTrigger> ListBuildTriggers(ListBuildTriggersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists existing `BuildTrigger`s.
        /// 
        /// This API is experimental.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BuildTrigger"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBuildTriggersResponse, BuildTrigger> ListBuildTriggersAsync(ListBuildTriggersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists existing `BuildTrigger`s.
        /// 
        /// This API is experimental.
        /// </summary>
        /// <param name="projectId">
        /// Required. ID of the project for which to list BuildTriggers.
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
        /// <returns>A pageable sequence of <see cref="BuildTrigger"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBuildTriggersResponse, BuildTrigger> ListBuildTriggers(string projectId, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBuildTriggersRequest request = new ListBuildTriggersRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListBuildTriggers(request, callSettings);
        }

        /// <summary>
        /// Lists existing `BuildTrigger`s.
        /// 
        /// This API is experimental.
        /// </summary>
        /// <param name="projectId">
        /// Required. ID of the project for which to list BuildTriggers.
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
        /// <returns>A pageable asynchronous sequence of <see cref="BuildTrigger"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBuildTriggersResponse, BuildTrigger> ListBuildTriggersAsync(string projectId, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBuildTriggersRequest request = new ListBuildTriggersRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListBuildTriggersAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a `BuildTrigger` by its project ID and trigger ID.
        /// 
        /// This API is experimental.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteBuildTrigger(DeleteBuildTriggerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a `BuildTrigger` by its project ID and trigger ID.
        /// 
        /// This API is experimental.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBuildTriggerAsync(DeleteBuildTriggerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a `BuildTrigger` by its project ID and trigger ID.
        /// 
        /// This API is experimental.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBuildTriggerAsync(DeleteBuildTriggerRequest request, st::CancellationToken cancellationToken) =>
            DeleteBuildTriggerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a `BuildTrigger` by its project ID and trigger ID.
        /// 
        /// This API is experimental.
        /// </summary>
        /// <param name="projectId">
        /// Required. ID of the project that owns the trigger.
        /// </param>
        /// <param name="triggerId">
        /// Required. ID of the `BuildTrigger` to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteBuildTrigger(string projectId, string triggerId, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBuildTrigger(new DeleteBuildTriggerRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                TriggerId = gax::GaxPreconditions.CheckNotNullOrEmpty(triggerId, nameof(triggerId)),
            }, callSettings);

        /// <summary>
        /// Deletes a `BuildTrigger` by its project ID and trigger ID.
        /// 
        /// This API is experimental.
        /// </summary>
        /// <param name="projectId">
        /// Required. ID of the project that owns the trigger.
        /// </param>
        /// <param name="triggerId">
        /// Required. ID of the `BuildTrigger` to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBuildTriggerAsync(string projectId, string triggerId, gaxgrpc::CallSettings callSettings = null) =>
            DeleteBuildTriggerAsync(new DeleteBuildTriggerRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                TriggerId = gax::GaxPreconditions.CheckNotNullOrEmpty(triggerId, nameof(triggerId)),
            }, callSettings);

        /// <summary>
        /// Deletes a `BuildTrigger` by its project ID and trigger ID.
        /// 
        /// This API is experimental.
        /// </summary>
        /// <param name="projectId">
        /// Required. ID of the project that owns the trigger.
        /// </param>
        /// <param name="triggerId">
        /// Required. ID of the `BuildTrigger` to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteBuildTriggerAsync(string projectId, string triggerId, st::CancellationToken cancellationToken) =>
            DeleteBuildTriggerAsync(projectId, triggerId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `BuildTrigger` by its project ID and trigger ID.
        /// 
        /// This API is experimental.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BuildTrigger UpdateBuildTrigger(UpdateBuildTriggerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `BuildTrigger` by its project ID and trigger ID.
        /// 
        /// This API is experimental.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BuildTrigger> UpdateBuildTriggerAsync(UpdateBuildTriggerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `BuildTrigger` by its project ID and trigger ID.
        /// 
        /// This API is experimental.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BuildTrigger> UpdateBuildTriggerAsync(UpdateBuildTriggerRequest request, st::CancellationToken cancellationToken) =>
            UpdateBuildTriggerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `BuildTrigger` by its project ID and trigger ID.
        /// 
        /// This API is experimental.
        /// </summary>
        /// <param name="projectId">
        /// Required. ID of the project that owns the trigger.
        /// </param>
        /// <param name="triggerId">
        /// Required. ID of the `BuildTrigger` to update.
        /// </param>
        /// <param name="trigger">
        /// Required. `BuildTrigger` to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual BuildTrigger UpdateBuildTrigger(string projectId, string triggerId, BuildTrigger trigger, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBuildTrigger(new UpdateBuildTriggerRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                TriggerId = gax::GaxPreconditions.CheckNotNullOrEmpty(triggerId, nameof(triggerId)),
                Trigger = gax::GaxPreconditions.CheckNotNull(trigger, nameof(trigger)),
            }, callSettings);

        /// <summary>
        /// Updates a `BuildTrigger` by its project ID and trigger ID.
        /// 
        /// This API is experimental.
        /// </summary>
        /// <param name="projectId">
        /// Required. ID of the project that owns the trigger.
        /// </param>
        /// <param name="triggerId">
        /// Required. ID of the `BuildTrigger` to update.
        /// </param>
        /// <param name="trigger">
        /// Required. `BuildTrigger` to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BuildTrigger> UpdateBuildTriggerAsync(string projectId, string triggerId, BuildTrigger trigger, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBuildTriggerAsync(new UpdateBuildTriggerRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                TriggerId = gax::GaxPreconditions.CheckNotNullOrEmpty(triggerId, nameof(triggerId)),
                Trigger = gax::GaxPreconditions.CheckNotNull(trigger, nameof(trigger)),
            }, callSettings);

        /// <summary>
        /// Updates a `BuildTrigger` by its project ID and trigger ID.
        /// 
        /// This API is experimental.
        /// </summary>
        /// <param name="projectId">
        /// Required. ID of the project that owns the trigger.
        /// </param>
        /// <param name="triggerId">
        /// Required. ID of the `BuildTrigger` to update.
        /// </param>
        /// <param name="trigger">
        /// Required. `BuildTrigger` to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<BuildTrigger> UpdateBuildTriggerAsync(string projectId, string triggerId, BuildTrigger trigger, st::CancellationToken cancellationToken) =>
            UpdateBuildTriggerAsync(projectId, triggerId, trigger, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Runs a `BuildTrigger` at a particular source revision.
        /// 
        /// To run a regional or global trigger, use the POST request
        /// that includes the location endpoint in the path (ex.
        /// v1/projects/{projectId}/locations/{region}/triggers/{triggerId}:run). The
        /// POST request that does not include the location endpoint in the path can
        /// only be used when running global triggers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Build, BuildOperationMetadata> RunBuildTrigger(RunBuildTriggerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Runs a `BuildTrigger` at a particular source revision.
        /// 
        /// To run a regional or global trigger, use the POST request
        /// that includes the location endpoint in the path (ex.
        /// v1/projects/{projectId}/locations/{region}/triggers/{triggerId}:run). The
        /// POST request that does not include the location endpoint in the path can
        /// only be used when running global triggers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Build, BuildOperationMetadata>> RunBuildTriggerAsync(RunBuildTriggerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Runs a `BuildTrigger` at a particular source revision.
        /// 
        /// To run a regional or global trigger, use the POST request
        /// that includes the location endpoint in the path (ex.
        /// v1/projects/{projectId}/locations/{region}/triggers/{triggerId}:run). The
        /// POST request that does not include the location endpoint in the path can
        /// only be used when running global triggers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Build, BuildOperationMetadata>> RunBuildTriggerAsync(RunBuildTriggerRequest request, st::CancellationToken cancellationToken) =>
            RunBuildTriggerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RunBuildTrigger</c>.</summary>
        public virtual lro::OperationsClient RunBuildTriggerOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RunBuildTrigger</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Build, BuildOperationMetadata> PollOnceRunBuildTrigger(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Build, BuildOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RunBuildTriggerOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RunBuildTrigger</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Build, BuildOperationMetadata>> PollOnceRunBuildTriggerAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Build, BuildOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RunBuildTriggerOperationsClient, callSettings);

        /// <summary>
        /// Runs a `BuildTrigger` at a particular source revision.
        /// 
        /// To run a regional or global trigger, use the POST request
        /// that includes the location endpoint in the path (ex.
        /// v1/projects/{projectId}/locations/{region}/triggers/{triggerId}:run). The
        /// POST request that does not include the location endpoint in the path can
        /// only be used when running global triggers.
        /// </summary>
        /// <param name="projectId">
        /// Required. ID of the project.
        /// </param>
        /// <param name="triggerId">
        /// Required. ID of the trigger.
        /// </param>
        /// <param name="source">
        /// Source to build against this trigger.
        /// Branch and tag names cannot consist of regular expressions.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Build, BuildOperationMetadata> RunBuildTrigger(string projectId, string triggerId, RepoSource source, gaxgrpc::CallSettings callSettings = null) =>
            RunBuildTrigger(new RunBuildTriggerRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                TriggerId = gax::GaxPreconditions.CheckNotNullOrEmpty(triggerId, nameof(triggerId)),
                Source = source,
            }, callSettings);

        /// <summary>
        /// Runs a `BuildTrigger` at a particular source revision.
        /// 
        /// To run a regional or global trigger, use the POST request
        /// that includes the location endpoint in the path (ex.
        /// v1/projects/{projectId}/locations/{region}/triggers/{triggerId}:run). The
        /// POST request that does not include the location endpoint in the path can
        /// only be used when running global triggers.
        /// </summary>
        /// <param name="projectId">
        /// Required. ID of the project.
        /// </param>
        /// <param name="triggerId">
        /// Required. ID of the trigger.
        /// </param>
        /// <param name="source">
        /// Source to build against this trigger.
        /// Branch and tag names cannot consist of regular expressions.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Build, BuildOperationMetadata>> RunBuildTriggerAsync(string projectId, string triggerId, RepoSource source, gaxgrpc::CallSettings callSettings = null) =>
            RunBuildTriggerAsync(new RunBuildTriggerRequest
            {
                ProjectId = gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)),
                TriggerId = gax::GaxPreconditions.CheckNotNullOrEmpty(triggerId, nameof(triggerId)),
                Source = source,
            }, callSettings);

        /// <summary>
        /// Runs a `BuildTrigger` at a particular source revision.
        /// 
        /// To run a regional or global trigger, use the POST request
        /// that includes the location endpoint in the path (ex.
        /// v1/projects/{projectId}/locations/{region}/triggers/{triggerId}:run). The
        /// POST request that does not include the location endpoint in the path can
        /// only be used when running global triggers.
        /// </summary>
        /// <param name="projectId">
        /// Required. ID of the project.
        /// </param>
        /// <param name="triggerId">
        /// Required. ID of the trigger.
        /// </param>
        /// <param name="source">
        /// Source to build against this trigger.
        /// Branch and tag names cannot consist of regular expressions.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Build, BuildOperationMetadata>> RunBuildTriggerAsync(string projectId, string triggerId, RepoSource source, st::CancellationToken cancellationToken) =>
            RunBuildTriggerAsync(projectId, triggerId, source, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// ReceiveTriggerWebhook [Experimental] is called when the API receives a
        /// webhook request targeted at a specific trigger.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReceiveTriggerWebhookResponse ReceiveTriggerWebhook(ReceiveTriggerWebhookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// ReceiveTriggerWebhook [Experimental] is called when the API receives a
        /// webhook request targeted at a specific trigger.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReceiveTriggerWebhookResponse> ReceiveTriggerWebhookAsync(ReceiveTriggerWebhookRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// ReceiveTriggerWebhook [Experimental] is called when the API receives a
        /// webhook request targeted at a specific trigger.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReceiveTriggerWebhookResponse> ReceiveTriggerWebhookAsync(ReceiveTriggerWebhookRequest request, st::CancellationToken cancellationToken) =>
            ReceiveTriggerWebhookAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `WorkerPool`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkerPool, CreateWorkerPoolOperationMetadata> CreateWorkerPool(CreateWorkerPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `WorkerPool`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkerPool, CreateWorkerPoolOperationMetadata>> CreateWorkerPoolAsync(CreateWorkerPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a `WorkerPool`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkerPool, CreateWorkerPoolOperationMetadata>> CreateWorkerPoolAsync(CreateWorkerPoolRequest request, st::CancellationToken cancellationToken) =>
            CreateWorkerPoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateWorkerPool</c>.</summary>
        public virtual lro::OperationsClient CreateWorkerPoolOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateWorkerPool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<WorkerPool, CreateWorkerPoolOperationMetadata> PollOnceCreateWorkerPool(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<WorkerPool, CreateWorkerPoolOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateWorkerPoolOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateWorkerPool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<WorkerPool, CreateWorkerPoolOperationMetadata>> PollOnceCreateWorkerPoolAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<WorkerPool, CreateWorkerPoolOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateWorkerPoolOperationsClient, callSettings);

        /// <summary>
        /// Creates a `WorkerPool`.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this worker pool will be created.
        /// Format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="workerPool">
        /// Required. `WorkerPool` resource to create.
        /// </param>
        /// <param name="workerPoolId">
        /// Required. Immutable. The ID to use for the `WorkerPool`, which will become
        /// the final component of the resource name.
        /// 
        /// This value should be 1-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkerPool, CreateWorkerPoolOperationMetadata> CreateWorkerPool(string parent, WorkerPool workerPool, string workerPoolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkerPool(new CreateWorkerPoolRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                WorkerPool = gax::GaxPreconditions.CheckNotNull(workerPool, nameof(workerPool)),
                WorkerPoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(workerPoolId, nameof(workerPoolId)),
            }, callSettings);

        /// <summary>
        /// Creates a `WorkerPool`.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this worker pool will be created.
        /// Format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="workerPool">
        /// Required. `WorkerPool` resource to create.
        /// </param>
        /// <param name="workerPoolId">
        /// Required. Immutable. The ID to use for the `WorkerPool`, which will become
        /// the final component of the resource name.
        /// 
        /// This value should be 1-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkerPool, CreateWorkerPoolOperationMetadata>> CreateWorkerPoolAsync(string parent, WorkerPool workerPool, string workerPoolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkerPoolAsync(new CreateWorkerPoolRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                WorkerPool = gax::GaxPreconditions.CheckNotNull(workerPool, nameof(workerPool)),
                WorkerPoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(workerPoolId, nameof(workerPoolId)),
            }, callSettings);

        /// <summary>
        /// Creates a `WorkerPool`.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this worker pool will be created.
        /// Format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="workerPool">
        /// Required. `WorkerPool` resource to create.
        /// </param>
        /// <param name="workerPoolId">
        /// Required. Immutable. The ID to use for the `WorkerPool`, which will become
        /// the final component of the resource name.
        /// 
        /// This value should be 1-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkerPool, CreateWorkerPoolOperationMetadata>> CreateWorkerPoolAsync(string parent, WorkerPool workerPool, string workerPoolId, st::CancellationToken cancellationToken) =>
            CreateWorkerPoolAsync(parent, workerPool, workerPoolId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a `WorkerPool`.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this worker pool will be created.
        /// Format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="workerPool">
        /// Required. `WorkerPool` resource to create.
        /// </param>
        /// <param name="workerPoolId">
        /// Required. Immutable. The ID to use for the `WorkerPool`, which will become
        /// the final component of the resource name.
        /// 
        /// This value should be 1-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkerPool, CreateWorkerPoolOperationMetadata> CreateWorkerPool(gagr::LocationName parent, WorkerPool workerPool, string workerPoolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkerPool(new CreateWorkerPoolRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                WorkerPool = gax::GaxPreconditions.CheckNotNull(workerPool, nameof(workerPool)),
                WorkerPoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(workerPoolId, nameof(workerPoolId)),
            }, callSettings);

        /// <summary>
        /// Creates a `WorkerPool`.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this worker pool will be created.
        /// Format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="workerPool">
        /// Required. `WorkerPool` resource to create.
        /// </param>
        /// <param name="workerPoolId">
        /// Required. Immutable. The ID to use for the `WorkerPool`, which will become
        /// the final component of the resource name.
        /// 
        /// This value should be 1-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkerPool, CreateWorkerPoolOperationMetadata>> CreateWorkerPoolAsync(gagr::LocationName parent, WorkerPool workerPool, string workerPoolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateWorkerPoolAsync(new CreateWorkerPoolRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                WorkerPool = gax::GaxPreconditions.CheckNotNull(workerPool, nameof(workerPool)),
                WorkerPoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(workerPoolId, nameof(workerPoolId)),
            }, callSettings);

        /// <summary>
        /// Creates a `WorkerPool`.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource where this worker pool will be created.
        /// Format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="workerPool">
        /// Required. `WorkerPool` resource to create.
        /// </param>
        /// <param name="workerPoolId">
        /// Required. Immutable. The ID to use for the `WorkerPool`, which will become
        /// the final component of the resource name.
        /// 
        /// This value should be 1-63 characters, and valid characters
        /// are /[a-z][0-9]-/.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkerPool, CreateWorkerPoolOperationMetadata>> CreateWorkerPoolAsync(gagr::LocationName parent, WorkerPool workerPool, string workerPoolId, st::CancellationToken cancellationToken) =>
            CreateWorkerPoolAsync(parent, workerPool, workerPoolId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns details of a `WorkerPool`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkerPool GetWorkerPool(GetWorkerPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns details of a `WorkerPool`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkerPool> GetWorkerPoolAsync(GetWorkerPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns details of a `WorkerPool`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkerPool> GetWorkerPoolAsync(GetWorkerPoolRequest request, st::CancellationToken cancellationToken) =>
            GetWorkerPoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns details of a `WorkerPool`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `WorkerPool` to retrieve.
        /// Format: `projects/{project}/locations/{location}/workerPools/{workerPool}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkerPool GetWorkerPool(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkerPool(new GetWorkerPoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns details of a `WorkerPool`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `WorkerPool` to retrieve.
        /// Format: `projects/{project}/locations/{location}/workerPools/{workerPool}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkerPool> GetWorkerPoolAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkerPoolAsync(new GetWorkerPoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns details of a `WorkerPool`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `WorkerPool` to retrieve.
        /// Format: `projects/{project}/locations/{location}/workerPools/{workerPool}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkerPool> GetWorkerPoolAsync(string name, st::CancellationToken cancellationToken) =>
            GetWorkerPoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns details of a `WorkerPool`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `WorkerPool` to retrieve.
        /// Format: `projects/{project}/locations/{location}/workerPools/{workerPool}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual WorkerPool GetWorkerPool(WorkerPoolName name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkerPool(new GetWorkerPoolRequest
            {
                WorkerPoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns details of a `WorkerPool`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `WorkerPool` to retrieve.
        /// Format: `projects/{project}/locations/{location}/workerPools/{workerPool}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkerPool> GetWorkerPoolAsync(WorkerPoolName name, gaxgrpc::CallSettings callSettings = null) =>
            GetWorkerPoolAsync(new GetWorkerPoolRequest
            {
                WorkerPoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns details of a `WorkerPool`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `WorkerPool` to retrieve.
        /// Format: `projects/{project}/locations/{location}/workerPools/{workerPool}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<WorkerPool> GetWorkerPoolAsync(WorkerPoolName name, st::CancellationToken cancellationToken) =>
            GetWorkerPoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a `WorkerPool`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteWorkerPoolOperationMetadata> DeleteWorkerPool(DeleteWorkerPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a `WorkerPool`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteWorkerPoolOperationMetadata>> DeleteWorkerPoolAsync(DeleteWorkerPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a `WorkerPool`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteWorkerPoolOperationMetadata>> DeleteWorkerPoolAsync(DeleteWorkerPoolRequest request, st::CancellationToken cancellationToken) =>
            DeleteWorkerPoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteWorkerPool</c>.</summary>
        public virtual lro::OperationsClient DeleteWorkerPoolOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteWorkerPool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteWorkerPoolOperationMetadata> PollOnceDeleteWorkerPool(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteWorkerPoolOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteWorkerPoolOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteWorkerPool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteWorkerPoolOperationMetadata>> PollOnceDeleteWorkerPoolAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteWorkerPoolOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteWorkerPoolOperationsClient, callSettings);

        /// <summary>
        /// Deletes a `WorkerPool`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `WorkerPool` to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/workerPools/{workerPool}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteWorkerPoolOperationMetadata> DeleteWorkerPool(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkerPool(new DeleteWorkerPoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a `WorkerPool`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `WorkerPool` to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/workerPools/{workerPool}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteWorkerPoolOperationMetadata>> DeleteWorkerPoolAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkerPoolAsync(new DeleteWorkerPoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a `WorkerPool`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `WorkerPool` to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/workerPools/{workerPool}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteWorkerPoolOperationMetadata>> DeleteWorkerPoolAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteWorkerPoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a `WorkerPool`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `WorkerPool` to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/workerPools/{workerPool}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteWorkerPoolOperationMetadata> DeleteWorkerPool(WorkerPoolName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkerPool(new DeleteWorkerPoolRequest
            {
                WorkerPoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a `WorkerPool`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `WorkerPool` to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/workerPools/{workerPool}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteWorkerPoolOperationMetadata>> DeleteWorkerPoolAsync(WorkerPoolName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteWorkerPoolAsync(new DeleteWorkerPoolRequest
            {
                WorkerPoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a `WorkerPool`.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the `WorkerPool` to delete.
        /// Format:
        /// `projects/{project}/locations/{location}/workerPools/{workerPool}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteWorkerPoolOperationMetadata>> DeleteWorkerPoolAsync(WorkerPoolName name, st::CancellationToken cancellationToken) =>
            DeleteWorkerPoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a `WorkerPool`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkerPool, UpdateWorkerPoolOperationMetadata> UpdateWorkerPool(UpdateWorkerPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `WorkerPool`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkerPool, UpdateWorkerPoolOperationMetadata>> UpdateWorkerPoolAsync(UpdateWorkerPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a `WorkerPool`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkerPool, UpdateWorkerPoolOperationMetadata>> UpdateWorkerPoolAsync(UpdateWorkerPoolRequest request, st::CancellationToken cancellationToken) =>
            UpdateWorkerPoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateWorkerPool</c>.</summary>
        public virtual lro::OperationsClient UpdateWorkerPoolOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateWorkerPool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<WorkerPool, UpdateWorkerPoolOperationMetadata> PollOnceUpdateWorkerPool(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<WorkerPool, UpdateWorkerPoolOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateWorkerPoolOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateWorkerPool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<WorkerPool, UpdateWorkerPoolOperationMetadata>> PollOnceUpdateWorkerPoolAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<WorkerPool, UpdateWorkerPoolOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateWorkerPoolOperationsClient, callSettings);

        /// <summary>
        /// Updates a `WorkerPool`.
        /// </summary>
        /// <param name="workerPool">
        /// Required. The `WorkerPool` to update.
        /// 
        /// The `name` field is used to identify the `WorkerPool` to update.
        /// Format: `projects/{project}/locations/{location}/workerPools/{workerPool}`.
        /// </param>
        /// <param name="updateMask">
        /// A mask specifying which fields in `worker_pool` to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<WorkerPool, UpdateWorkerPoolOperationMetadata> UpdateWorkerPool(WorkerPool workerPool, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateWorkerPool(new UpdateWorkerPoolRequest
            {
                WorkerPool = gax::GaxPreconditions.CheckNotNull(workerPool, nameof(workerPool)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a `WorkerPool`.
        /// </summary>
        /// <param name="workerPool">
        /// Required. The `WorkerPool` to update.
        /// 
        /// The `name` field is used to identify the `WorkerPool` to update.
        /// Format: `projects/{project}/locations/{location}/workerPools/{workerPool}`.
        /// </param>
        /// <param name="updateMask">
        /// A mask specifying which fields in `worker_pool` to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkerPool, UpdateWorkerPoolOperationMetadata>> UpdateWorkerPoolAsync(WorkerPool workerPool, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateWorkerPoolAsync(new UpdateWorkerPoolRequest
            {
                WorkerPool = gax::GaxPreconditions.CheckNotNull(workerPool, nameof(workerPool)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a `WorkerPool`.
        /// </summary>
        /// <param name="workerPool">
        /// Required. The `WorkerPool` to update.
        /// 
        /// The `name` field is used to identify the `WorkerPool` to update.
        /// Format: `projects/{project}/locations/{location}/workerPools/{workerPool}`.
        /// </param>
        /// <param name="updateMask">
        /// A mask specifying which fields in `worker_pool` to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<WorkerPool, UpdateWorkerPoolOperationMetadata>> UpdateWorkerPoolAsync(WorkerPool workerPool, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateWorkerPoolAsync(workerPool, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists `WorkerPool`s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="WorkerPool"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkerPoolsResponse, WorkerPool> ListWorkerPools(ListWorkerPoolsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `WorkerPool`s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="WorkerPool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkerPoolsResponse, WorkerPool> ListWorkerPoolsAsync(ListWorkerPoolsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists `WorkerPool`s.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the collection of `WorkerPools`.
        /// Format: `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="WorkerPool"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkerPoolsResponse, WorkerPool> ListWorkerPools(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkerPoolsRequest request = new ListWorkerPoolsRequest
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
            return ListWorkerPools(request, callSettings);
        }

        /// <summary>
        /// Lists `WorkerPool`s.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the collection of `WorkerPools`.
        /// Format: `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="WorkerPool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkerPoolsResponse, WorkerPool> ListWorkerPoolsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkerPoolsRequest request = new ListWorkerPoolsRequest
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
            return ListWorkerPoolsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists `WorkerPool`s.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the collection of `WorkerPools`.
        /// Format: `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable sequence of <see cref="WorkerPool"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListWorkerPoolsResponse, WorkerPool> ListWorkerPools(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkerPoolsRequest request = new ListWorkerPoolsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListWorkerPools(request, callSettings);
        }

        /// <summary>
        /// Lists `WorkerPool`s.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent of the collection of `WorkerPools`.
        /// Format: `projects/{project}/locations/{location}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="WorkerPool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListWorkerPoolsResponse, WorkerPool> ListWorkerPoolsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListWorkerPoolsRequest request = new ListWorkerPoolsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListWorkerPoolsAsync(request, callSettings);
        }
    }

    /// <summary>CloudBuild client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Creates and manages builds on Google Cloud Platform.
    /// 
    /// The main concept used by this API is a `Build`, which describes the location
    /// of the source to build, how to build the source, and where to store the
    /// built artifacts, if any.
    /// 
    /// A user can list previously-requested builds or get builds by their ID to
    /// determine the status of the build.
    /// </remarks>
    public sealed partial class CloudBuildClientImpl : CloudBuildClient
    {
        private readonly gaxgrpc::ApiCall<CreateBuildRequest, lro::Operation> _callCreateBuild;

        private readonly gaxgrpc::ApiCall<GetBuildRequest, Build> _callGetBuild;

        private readonly gaxgrpc::ApiCall<ListBuildsRequest, ListBuildsResponse> _callListBuilds;

        private readonly gaxgrpc::ApiCall<CancelBuildRequest, Build> _callCancelBuild;

        private readonly gaxgrpc::ApiCall<RetryBuildRequest, lro::Operation> _callRetryBuild;

        private readonly gaxgrpc::ApiCall<ApproveBuildRequest, lro::Operation> _callApproveBuild;

        private readonly gaxgrpc::ApiCall<CreateBuildTriggerRequest, BuildTrigger> _callCreateBuildTrigger;

        private readonly gaxgrpc::ApiCall<GetBuildTriggerRequest, BuildTrigger> _callGetBuildTrigger;

        private readonly gaxgrpc::ApiCall<ListBuildTriggersRequest, ListBuildTriggersResponse> _callListBuildTriggers;

        private readonly gaxgrpc::ApiCall<DeleteBuildTriggerRequest, wkt::Empty> _callDeleteBuildTrigger;

        private readonly gaxgrpc::ApiCall<UpdateBuildTriggerRequest, BuildTrigger> _callUpdateBuildTrigger;

        private readonly gaxgrpc::ApiCall<RunBuildTriggerRequest, lro::Operation> _callRunBuildTrigger;

        private readonly gaxgrpc::ApiCall<ReceiveTriggerWebhookRequest, ReceiveTriggerWebhookResponse> _callReceiveTriggerWebhook;

        private readonly gaxgrpc::ApiCall<CreateWorkerPoolRequest, lro::Operation> _callCreateWorkerPool;

        private readonly gaxgrpc::ApiCall<GetWorkerPoolRequest, WorkerPool> _callGetWorkerPool;

        private readonly gaxgrpc::ApiCall<DeleteWorkerPoolRequest, lro::Operation> _callDeleteWorkerPool;

        private readonly gaxgrpc::ApiCall<UpdateWorkerPoolRequest, lro::Operation> _callUpdateWorkerPool;

        private readonly gaxgrpc::ApiCall<ListWorkerPoolsRequest, ListWorkerPoolsResponse> _callListWorkerPools;

        /// <summary>
        /// Constructs a client wrapper for the CloudBuild service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CloudBuildSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CloudBuildClientImpl(CloudBuild.CloudBuildClient grpcClient, CloudBuildSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CloudBuildSettings effectiveSettings = settings ?? CloudBuildSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateBuildOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateBuildOperationsSettings, logger);
            RetryBuildOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RetryBuildOperationsSettings, logger);
            ApproveBuildOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ApproveBuildOperationsSettings, logger);
            RunBuildTriggerOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RunBuildTriggerOperationsSettings, logger);
            CreateWorkerPoolOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateWorkerPoolOperationsSettings, logger);
            DeleteWorkerPoolOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteWorkerPoolOperationsSettings, logger);
            UpdateWorkerPoolOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateWorkerPoolOperationsSettings, logger);
            _callCreateBuild = clientHelper.BuildApiCall<CreateBuildRequest, lro::Operation>("CreateBuild", grpcClient.CreateBuildAsync, grpcClient.CreateBuild, effectiveSettings.CreateBuildSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<CreateBuildRequest>().WithExtractedParameter("location", "^projects/[^/]+/locations/([^/]+)/?$", request => request.Parent));
            Modify_ApiCall(ref _callCreateBuild);
            Modify_CreateBuildApiCall(ref _callCreateBuild);
            _callGetBuild = clientHelper.BuildApiCall<GetBuildRequest, Build>("GetBuild", grpcClient.GetBuildAsync, grpcClient.GetBuild, effectiveSettings.GetBuildSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<GetBuildRequest>().WithExtractedParameter("location", "^projects/[^/]+/locations/([^/]+)/builds/[^/]+/?$", request => request.Name));
            Modify_ApiCall(ref _callGetBuild);
            Modify_GetBuildApiCall(ref _callGetBuild);
            _callListBuilds = clientHelper.BuildApiCall<ListBuildsRequest, ListBuildsResponse>("ListBuilds", grpcClient.ListBuildsAsync, grpcClient.ListBuilds, effectiveSettings.ListBuildsSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<ListBuildsRequest>().WithExtractedParameter("location", "^projects/[^/]+/locations/([^/]+)/?$", request => request.Parent));
            Modify_ApiCall(ref _callListBuilds);
            Modify_ListBuildsApiCall(ref _callListBuilds);
            _callCancelBuild = clientHelper.BuildApiCall<CancelBuildRequest, Build>("CancelBuild", grpcClient.CancelBuildAsync, grpcClient.CancelBuild, effectiveSettings.CancelBuildSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<CancelBuildRequest>().WithExtractedParameter("location", "^projects/[^/]+/locations/([^/]+)/builds/[^/]+/?$", request => request.Name));
            Modify_ApiCall(ref _callCancelBuild);
            Modify_CancelBuildApiCall(ref _callCancelBuild);
            _callRetryBuild = clientHelper.BuildApiCall<RetryBuildRequest, lro::Operation>("RetryBuild", grpcClient.RetryBuildAsync, grpcClient.RetryBuild, effectiveSettings.RetryBuildSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<RetryBuildRequest>().WithExtractedParameter("location", "^projects/[^/]+/locations/([^/]+)/builds/[^/]+/?$", request => request.Name));
            Modify_ApiCall(ref _callRetryBuild);
            Modify_RetryBuildApiCall(ref _callRetryBuild);
            _callApproveBuild = clientHelper.BuildApiCall<ApproveBuildRequest, lro::Operation>("ApproveBuild", grpcClient.ApproveBuildAsync, grpcClient.ApproveBuild, effectiveSettings.ApproveBuildSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<ApproveBuildRequest>().WithExtractedParameter("location", "^projects/[^/]+/locations/([^/]+)/builds/[^/]+/?$", request => request.Name));
            Modify_ApiCall(ref _callApproveBuild);
            Modify_ApproveBuildApiCall(ref _callApproveBuild);
            _callCreateBuildTrigger = clientHelper.BuildApiCall<CreateBuildTriggerRequest, BuildTrigger>("CreateBuildTrigger", grpcClient.CreateBuildTriggerAsync, grpcClient.CreateBuildTrigger, effectiveSettings.CreateBuildTriggerSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<CreateBuildTriggerRequest>().WithExtractedParameter("location", "^projects/[^/]+/locations/([^/]+)/?$", request => request.Parent));
            Modify_ApiCall(ref _callCreateBuildTrigger);
            Modify_CreateBuildTriggerApiCall(ref _callCreateBuildTrigger);
            _callGetBuildTrigger = clientHelper.BuildApiCall<GetBuildTriggerRequest, BuildTrigger>("GetBuildTrigger", grpcClient.GetBuildTriggerAsync, grpcClient.GetBuildTrigger, effectiveSettings.GetBuildTriggerSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<GetBuildTriggerRequest>().WithExtractedParameter("location", "^projects/[^/]+/locations/([^/]+)/triggers/[^/]+/?$", request => request.Name));
            Modify_ApiCall(ref _callGetBuildTrigger);
            Modify_GetBuildTriggerApiCall(ref _callGetBuildTrigger);
            _callListBuildTriggers = clientHelper.BuildApiCall<ListBuildTriggersRequest, ListBuildTriggersResponse>("ListBuildTriggers", grpcClient.ListBuildTriggersAsync, grpcClient.ListBuildTriggers, effectiveSettings.ListBuildTriggersSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<ListBuildTriggersRequest>().WithExtractedParameter("location", "^projects/[^/]+/locations/([^/]+)/?$", request => request.Parent));
            Modify_ApiCall(ref _callListBuildTriggers);
            Modify_ListBuildTriggersApiCall(ref _callListBuildTriggers);
            _callDeleteBuildTrigger = clientHelper.BuildApiCall<DeleteBuildTriggerRequest, wkt::Empty>("DeleteBuildTrigger", grpcClient.DeleteBuildTriggerAsync, grpcClient.DeleteBuildTrigger, effectiveSettings.DeleteBuildTriggerSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<DeleteBuildTriggerRequest>().WithExtractedParameter("location", "^projects/[^/]+/locations/([^/]+)/triggers/[^/]+/?$", request => request.Name));
            Modify_ApiCall(ref _callDeleteBuildTrigger);
            Modify_DeleteBuildTriggerApiCall(ref _callDeleteBuildTrigger);
            _callUpdateBuildTrigger = clientHelper.BuildApiCall<UpdateBuildTriggerRequest, BuildTrigger>("UpdateBuildTrigger", grpcClient.UpdateBuildTriggerAsync, grpcClient.UpdateBuildTrigger, effectiveSettings.UpdateBuildTriggerSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<UpdateBuildTriggerRequest>().WithExtractedParameter("location", "^projects/[^/]+/locations/([^/]+)/triggers/[^/]+/?$", request => request.Trigger?.ResourceName));
            Modify_ApiCall(ref _callUpdateBuildTrigger);
            Modify_UpdateBuildTriggerApiCall(ref _callUpdateBuildTrigger);
            _callRunBuildTrigger = clientHelper.BuildApiCall<RunBuildTriggerRequest, lro::Operation>("RunBuildTrigger", grpcClient.RunBuildTriggerAsync, grpcClient.RunBuildTrigger, effectiveSettings.RunBuildTriggerSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<RunBuildTriggerRequest>().WithExtractedParameter("location", "^projects/[^/]+/locations/([^/]+)/triggers/[^/]+/?$", request => request.Name));
            Modify_ApiCall(ref _callRunBuildTrigger);
            Modify_RunBuildTriggerApiCall(ref _callRunBuildTrigger);
            _callReceiveTriggerWebhook = clientHelper.BuildApiCall<ReceiveTriggerWebhookRequest, ReceiveTriggerWebhookResponse>("ReceiveTriggerWebhook", grpcClient.ReceiveTriggerWebhookAsync, grpcClient.ReceiveTriggerWebhook, effectiveSettings.ReceiveTriggerWebhookSettings).WithGoogleRequestParam("project_id", request => request.ProjectId).WithGoogleRequestParam("trigger", request => request.Trigger);
            Modify_ApiCall(ref _callReceiveTriggerWebhook);
            Modify_ReceiveTriggerWebhookApiCall(ref _callReceiveTriggerWebhook);
            _callCreateWorkerPool = clientHelper.BuildApiCall<CreateWorkerPoolRequest, lro::Operation>("CreateWorkerPool", grpcClient.CreateWorkerPoolAsync, grpcClient.CreateWorkerPool, effectiveSettings.CreateWorkerPoolSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<CreateWorkerPoolRequest>().WithExtractedParameter("location", "^projects/[^/]+/locations/([^/]+)/?$", request => request.Parent));
            Modify_ApiCall(ref _callCreateWorkerPool);
            Modify_CreateWorkerPoolApiCall(ref _callCreateWorkerPool);
            _callGetWorkerPool = clientHelper.BuildApiCall<GetWorkerPoolRequest, WorkerPool>("GetWorkerPool", grpcClient.GetWorkerPoolAsync, grpcClient.GetWorkerPool, effectiveSettings.GetWorkerPoolSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<GetWorkerPoolRequest>().WithExtractedParameter("location", "^projects/[^/]+/locations/([^/]+)/workerPools/[^/]+/?$", request => request.Name));
            Modify_ApiCall(ref _callGetWorkerPool);
            Modify_GetWorkerPoolApiCall(ref _callGetWorkerPool);
            _callDeleteWorkerPool = clientHelper.BuildApiCall<DeleteWorkerPoolRequest, lro::Operation>("DeleteWorkerPool", grpcClient.DeleteWorkerPoolAsync, grpcClient.DeleteWorkerPool, effectiveSettings.DeleteWorkerPoolSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<DeleteWorkerPoolRequest>().WithExtractedParameter("location", "^projects/[^/]+/locations/([^/]+)/workerPools/[^/]+/?$", request => request.Name));
            Modify_ApiCall(ref _callDeleteWorkerPool);
            Modify_DeleteWorkerPoolApiCall(ref _callDeleteWorkerPool);
            _callUpdateWorkerPool = clientHelper.BuildApiCall<UpdateWorkerPoolRequest, lro::Operation>("UpdateWorkerPool", grpcClient.UpdateWorkerPoolAsync, grpcClient.UpdateWorkerPool, effectiveSettings.UpdateWorkerPoolSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<UpdateWorkerPoolRequest>().WithExtractedParameter("location", "^projects/[^/]+/locations/([^/]+)/workerPools/[^/]+/?$", request => request.WorkerPool?.Name));
            Modify_ApiCall(ref _callUpdateWorkerPool);
            Modify_UpdateWorkerPoolApiCall(ref _callUpdateWorkerPool);
            _callListWorkerPools = clientHelper.BuildApiCall<ListWorkerPoolsRequest, ListWorkerPoolsResponse>("ListWorkerPools", grpcClient.ListWorkerPoolsAsync, grpcClient.ListWorkerPools, effectiveSettings.ListWorkerPoolsSettings).WithExtractedGoogleRequestParam(new gaxgrpc::RoutingHeaderExtractor<ListWorkerPoolsRequest>().WithExtractedParameter("location", "^projects/[^/]+/locations/([^/]+)/?$", request => request.Parent));
            Modify_ApiCall(ref _callListWorkerPools);
            Modify_ListWorkerPoolsApiCall(ref _callListWorkerPools);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateBuildApiCall(ref gaxgrpc::ApiCall<CreateBuildRequest, lro::Operation> call);

        partial void Modify_GetBuildApiCall(ref gaxgrpc::ApiCall<GetBuildRequest, Build> call);

        partial void Modify_ListBuildsApiCall(ref gaxgrpc::ApiCall<ListBuildsRequest, ListBuildsResponse> call);

        partial void Modify_CancelBuildApiCall(ref gaxgrpc::ApiCall<CancelBuildRequest, Build> call);

        partial void Modify_RetryBuildApiCall(ref gaxgrpc::ApiCall<RetryBuildRequest, lro::Operation> call);

        partial void Modify_ApproveBuildApiCall(ref gaxgrpc::ApiCall<ApproveBuildRequest, lro::Operation> call);

        partial void Modify_CreateBuildTriggerApiCall(ref gaxgrpc::ApiCall<CreateBuildTriggerRequest, BuildTrigger> call);

        partial void Modify_GetBuildTriggerApiCall(ref gaxgrpc::ApiCall<GetBuildTriggerRequest, BuildTrigger> call);

        partial void Modify_ListBuildTriggersApiCall(ref gaxgrpc::ApiCall<ListBuildTriggersRequest, ListBuildTriggersResponse> call);

        partial void Modify_DeleteBuildTriggerApiCall(ref gaxgrpc::ApiCall<DeleteBuildTriggerRequest, wkt::Empty> call);

        partial void Modify_UpdateBuildTriggerApiCall(ref gaxgrpc::ApiCall<UpdateBuildTriggerRequest, BuildTrigger> call);

        partial void Modify_RunBuildTriggerApiCall(ref gaxgrpc::ApiCall<RunBuildTriggerRequest, lro::Operation> call);

        partial void Modify_ReceiveTriggerWebhookApiCall(ref gaxgrpc::ApiCall<ReceiveTriggerWebhookRequest, ReceiveTriggerWebhookResponse> call);

        partial void Modify_CreateWorkerPoolApiCall(ref gaxgrpc::ApiCall<CreateWorkerPoolRequest, lro::Operation> call);

        partial void Modify_GetWorkerPoolApiCall(ref gaxgrpc::ApiCall<GetWorkerPoolRequest, WorkerPool> call);

        partial void Modify_DeleteWorkerPoolApiCall(ref gaxgrpc::ApiCall<DeleteWorkerPoolRequest, lro::Operation> call);

        partial void Modify_UpdateWorkerPoolApiCall(ref gaxgrpc::ApiCall<UpdateWorkerPoolRequest, lro::Operation> call);

        partial void Modify_ListWorkerPoolsApiCall(ref gaxgrpc::ApiCall<ListWorkerPoolsRequest, ListWorkerPoolsResponse> call);

        partial void OnConstruction(CloudBuild.CloudBuildClient grpcClient, CloudBuildSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CloudBuild client</summary>
        public override CloudBuild.CloudBuildClient GrpcClient { get; }

        partial void Modify_CreateBuildRequest(ref CreateBuildRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBuildRequest(ref GetBuildRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBuildsRequest(ref ListBuildsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CancelBuildRequest(ref CancelBuildRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RetryBuildRequest(ref RetryBuildRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ApproveBuildRequest(ref ApproveBuildRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateBuildTriggerRequest(ref CreateBuildTriggerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBuildTriggerRequest(ref GetBuildTriggerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBuildTriggersRequest(ref ListBuildTriggersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteBuildTriggerRequest(ref DeleteBuildTriggerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateBuildTriggerRequest(ref UpdateBuildTriggerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RunBuildTriggerRequest(ref RunBuildTriggerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReceiveTriggerWebhookRequest(ref ReceiveTriggerWebhookRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateWorkerPoolRequest(ref CreateWorkerPoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetWorkerPoolRequest(ref GetWorkerPoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteWorkerPoolRequest(ref DeleteWorkerPoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateWorkerPoolRequest(ref UpdateWorkerPoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListWorkerPoolsRequest(ref ListWorkerPoolsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateBuild</c>.</summary>
        public override lro::OperationsClient CreateBuildOperationsClient { get; }

        /// <summary>
        /// Starts a build with the specified configuration.
        /// 
        /// This method returns a long-running `Operation`, which includes the build
        /// ID. Pass the build ID to `GetBuild` to determine the build status (such as
        /// `SUCCESS` or `FAILURE`).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Build, BuildOperationMetadata> CreateBuild(CreateBuildRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBuildRequest(ref request, ref callSettings);
            return new lro::Operation<Build, BuildOperationMetadata>(_callCreateBuild.Sync(request, callSettings), CreateBuildOperationsClient);
        }

        /// <summary>
        /// Starts a build with the specified configuration.
        /// 
        /// This method returns a long-running `Operation`, which includes the build
        /// ID. Pass the build ID to `GetBuild` to determine the build status (such as
        /// `SUCCESS` or `FAILURE`).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Build, BuildOperationMetadata>> CreateBuildAsync(CreateBuildRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBuildRequest(ref request, ref callSettings);
            return new lro::Operation<Build, BuildOperationMetadata>(await _callCreateBuild.Async(request, callSettings).ConfigureAwait(false), CreateBuildOperationsClient);
        }

        /// <summary>
        /// Returns information about a previously requested build.
        /// 
        /// The `Build` that is returned includes its status (such as `SUCCESS`,
        /// `FAILURE`, or `WORKING`), and timing information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Build GetBuild(GetBuildRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBuildRequest(ref request, ref callSettings);
            return _callGetBuild.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns information about a previously requested build.
        /// 
        /// The `Build` that is returned includes its status (such as `SUCCESS`,
        /// `FAILURE`, or `WORKING`), and timing information.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Build> GetBuildAsync(GetBuildRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBuildRequest(ref request, ref callSettings);
            return _callGetBuild.Async(request, callSettings);
        }

        /// <summary>
        /// Lists previously requested builds.
        /// 
        /// Previously requested builds may still be in-progress, or may have finished
        /// successfully or unsuccessfully.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Build"/> resources.</returns>
        public override gax::PagedEnumerable<ListBuildsResponse, Build> ListBuilds(ListBuildsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBuildsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListBuildsRequest, ListBuildsResponse, Build>(_callListBuilds, request, callSettings);
        }

        /// <summary>
        /// Lists previously requested builds.
        /// 
        /// Previously requested builds may still be in-progress, or may have finished
        /// successfully or unsuccessfully.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Build"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListBuildsResponse, Build> ListBuildsAsync(ListBuildsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBuildsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBuildsRequest, ListBuildsResponse, Build>(_callListBuilds, request, callSettings);
        }

        /// <summary>
        /// Cancels a build in progress.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Build CancelBuild(CancelBuildRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelBuildRequest(ref request, ref callSettings);
            return _callCancelBuild.Sync(request, callSettings);
        }

        /// <summary>
        /// Cancels a build in progress.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Build> CancelBuildAsync(CancelBuildRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelBuildRequest(ref request, ref callSettings);
            return _callCancelBuild.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>RetryBuild</c>.</summary>
        public override lro::OperationsClient RetryBuildOperationsClient { get; }

        /// <summary>
        /// Creates a new build based on the specified build.
        /// 
        /// This method creates a new build using the original build request, which may
        /// or may not result in an identical build.
        /// 
        /// For triggered builds:
        /// 
        /// * Triggered builds resolve to a precise revision; therefore a retry of a
        /// triggered build will result in a build that uses the same revision.
        /// 
        /// For non-triggered builds that specify `RepoSource`:
        /// 
        /// * If the original build built from the tip of a branch, the retried build
        /// will build from the tip of that branch, which may not be the same revision
        /// as the original build.
        /// * If the original build specified a commit sha or revision ID, the retried
        /// build will use the identical source.
        /// 
        /// For builds that specify `StorageSource`:
        /// 
        /// * If the original build pulled source from Cloud Storage without
        /// specifying the generation of the object, the new build will use the current
        /// object, which may be different from the original build source.
        /// * If the original build pulled source from Cloud Storage and specified the
        /// generation of the object, the new build will attempt to use the same
        /// object, which may or may not be available depending on the bucket's
        /// lifecycle management settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Build, BuildOperationMetadata> RetryBuild(RetryBuildRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RetryBuildRequest(ref request, ref callSettings);
            return new lro::Operation<Build, BuildOperationMetadata>(_callRetryBuild.Sync(request, callSettings), RetryBuildOperationsClient);
        }

        /// <summary>
        /// Creates a new build based on the specified build.
        /// 
        /// This method creates a new build using the original build request, which may
        /// or may not result in an identical build.
        /// 
        /// For triggered builds:
        /// 
        /// * Triggered builds resolve to a precise revision; therefore a retry of a
        /// triggered build will result in a build that uses the same revision.
        /// 
        /// For non-triggered builds that specify `RepoSource`:
        /// 
        /// * If the original build built from the tip of a branch, the retried build
        /// will build from the tip of that branch, which may not be the same revision
        /// as the original build.
        /// * If the original build specified a commit sha or revision ID, the retried
        /// build will use the identical source.
        /// 
        /// For builds that specify `StorageSource`:
        /// 
        /// * If the original build pulled source from Cloud Storage without
        /// specifying the generation of the object, the new build will use the current
        /// object, which may be different from the original build source.
        /// * If the original build pulled source from Cloud Storage and specified the
        /// generation of the object, the new build will attempt to use the same
        /// object, which may or may not be available depending on the bucket's
        /// lifecycle management settings.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Build, BuildOperationMetadata>> RetryBuildAsync(RetryBuildRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RetryBuildRequest(ref request, ref callSettings);
            return new lro::Operation<Build, BuildOperationMetadata>(await _callRetryBuild.Async(request, callSettings).ConfigureAwait(false), RetryBuildOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ApproveBuild</c>.</summary>
        public override lro::OperationsClient ApproveBuildOperationsClient { get; }

        /// <summary>
        /// Approves or rejects a pending build.
        /// 
        /// If approved, the returned LRO will be analogous to the LRO returned from
        /// a CreateBuild call.
        /// 
        /// If rejected, the returned LRO will be immediately done.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Build, BuildOperationMetadata> ApproveBuild(ApproveBuildRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ApproveBuildRequest(ref request, ref callSettings);
            return new lro::Operation<Build, BuildOperationMetadata>(_callApproveBuild.Sync(request, callSettings), ApproveBuildOperationsClient);
        }

        /// <summary>
        /// Approves or rejects a pending build.
        /// 
        /// If approved, the returned LRO will be analogous to the LRO returned from
        /// a CreateBuild call.
        /// 
        /// If rejected, the returned LRO will be immediately done.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Build, BuildOperationMetadata>> ApproveBuildAsync(ApproveBuildRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ApproveBuildRequest(ref request, ref callSettings);
            return new lro::Operation<Build, BuildOperationMetadata>(await _callApproveBuild.Async(request, callSettings).ConfigureAwait(false), ApproveBuildOperationsClient);
        }

        /// <summary>
        /// Creates a new `BuildTrigger`.
        /// 
        /// This API is experimental.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BuildTrigger CreateBuildTrigger(CreateBuildTriggerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBuildTriggerRequest(ref request, ref callSettings);
            return _callCreateBuildTrigger.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new `BuildTrigger`.
        /// 
        /// This API is experimental.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BuildTrigger> CreateBuildTriggerAsync(CreateBuildTriggerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBuildTriggerRequest(ref request, ref callSettings);
            return _callCreateBuildTrigger.Async(request, callSettings);
        }

        /// <summary>
        /// Returns information about a `BuildTrigger`.
        /// 
        /// This API is experimental.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BuildTrigger GetBuildTrigger(GetBuildTriggerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBuildTriggerRequest(ref request, ref callSettings);
            return _callGetBuildTrigger.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns information about a `BuildTrigger`.
        /// 
        /// This API is experimental.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BuildTrigger> GetBuildTriggerAsync(GetBuildTriggerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBuildTriggerRequest(ref request, ref callSettings);
            return _callGetBuildTrigger.Async(request, callSettings);
        }

        /// <summary>
        /// Lists existing `BuildTrigger`s.
        /// 
        /// This API is experimental.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BuildTrigger"/> resources.</returns>
        public override gax::PagedEnumerable<ListBuildTriggersResponse, BuildTrigger> ListBuildTriggers(ListBuildTriggersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBuildTriggersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListBuildTriggersRequest, ListBuildTriggersResponse, BuildTrigger>(_callListBuildTriggers, request, callSettings);
        }

        /// <summary>
        /// Lists existing `BuildTrigger`s.
        /// 
        /// This API is experimental.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BuildTrigger"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListBuildTriggersResponse, BuildTrigger> ListBuildTriggersAsync(ListBuildTriggersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBuildTriggersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBuildTriggersRequest, ListBuildTriggersResponse, BuildTrigger>(_callListBuildTriggers, request, callSettings);
        }

        /// <summary>
        /// Deletes a `BuildTrigger` by its project ID and trigger ID.
        /// 
        /// This API is experimental.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteBuildTrigger(DeleteBuildTriggerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBuildTriggerRequest(ref request, ref callSettings);
            _callDeleteBuildTrigger.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a `BuildTrigger` by its project ID and trigger ID.
        /// 
        /// This API is experimental.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteBuildTriggerAsync(DeleteBuildTriggerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteBuildTriggerRequest(ref request, ref callSettings);
            return _callDeleteBuildTrigger.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a `BuildTrigger` by its project ID and trigger ID.
        /// 
        /// This API is experimental.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override BuildTrigger UpdateBuildTrigger(UpdateBuildTriggerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBuildTriggerRequest(ref request, ref callSettings);
            return _callUpdateBuildTrigger.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a `BuildTrigger` by its project ID and trigger ID.
        /// 
        /// This API is experimental.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<BuildTrigger> UpdateBuildTriggerAsync(UpdateBuildTriggerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBuildTriggerRequest(ref request, ref callSettings);
            return _callUpdateBuildTrigger.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>RunBuildTrigger</c>.</summary>
        public override lro::OperationsClient RunBuildTriggerOperationsClient { get; }

        /// <summary>
        /// Runs a `BuildTrigger` at a particular source revision.
        /// 
        /// To run a regional or global trigger, use the POST request
        /// that includes the location endpoint in the path (ex.
        /// v1/projects/{projectId}/locations/{region}/triggers/{triggerId}:run). The
        /// POST request that does not include the location endpoint in the path can
        /// only be used when running global triggers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Build, BuildOperationMetadata> RunBuildTrigger(RunBuildTriggerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunBuildTriggerRequest(ref request, ref callSettings);
            return new lro::Operation<Build, BuildOperationMetadata>(_callRunBuildTrigger.Sync(request, callSettings), RunBuildTriggerOperationsClient);
        }

        /// <summary>
        /// Runs a `BuildTrigger` at a particular source revision.
        /// 
        /// To run a regional or global trigger, use the POST request
        /// that includes the location endpoint in the path (ex.
        /// v1/projects/{projectId}/locations/{region}/triggers/{triggerId}:run). The
        /// POST request that does not include the location endpoint in the path can
        /// only be used when running global triggers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Build, BuildOperationMetadata>> RunBuildTriggerAsync(RunBuildTriggerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunBuildTriggerRequest(ref request, ref callSettings);
            return new lro::Operation<Build, BuildOperationMetadata>(await _callRunBuildTrigger.Async(request, callSettings).ConfigureAwait(false), RunBuildTriggerOperationsClient);
        }

        /// <summary>
        /// ReceiveTriggerWebhook [Experimental] is called when the API receives a
        /// webhook request targeted at a specific trigger.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReceiveTriggerWebhookResponse ReceiveTriggerWebhook(ReceiveTriggerWebhookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReceiveTriggerWebhookRequest(ref request, ref callSettings);
            return _callReceiveTriggerWebhook.Sync(request, callSettings);
        }

        /// <summary>
        /// ReceiveTriggerWebhook [Experimental] is called when the API receives a
        /// webhook request targeted at a specific trigger.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReceiveTriggerWebhookResponse> ReceiveTriggerWebhookAsync(ReceiveTriggerWebhookRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReceiveTriggerWebhookRequest(ref request, ref callSettings);
            return _callReceiveTriggerWebhook.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateWorkerPool</c>.</summary>
        public override lro::OperationsClient CreateWorkerPoolOperationsClient { get; }

        /// <summary>
        /// Creates a `WorkerPool`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<WorkerPool, CreateWorkerPoolOperationMetadata> CreateWorkerPool(CreateWorkerPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateWorkerPoolRequest(ref request, ref callSettings);
            return new lro::Operation<WorkerPool, CreateWorkerPoolOperationMetadata>(_callCreateWorkerPool.Sync(request, callSettings), CreateWorkerPoolOperationsClient);
        }

        /// <summary>
        /// Creates a `WorkerPool`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<WorkerPool, CreateWorkerPoolOperationMetadata>> CreateWorkerPoolAsync(CreateWorkerPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateWorkerPoolRequest(ref request, ref callSettings);
            return new lro::Operation<WorkerPool, CreateWorkerPoolOperationMetadata>(await _callCreateWorkerPool.Async(request, callSettings).ConfigureAwait(false), CreateWorkerPoolOperationsClient);
        }

        /// <summary>
        /// Returns details of a `WorkerPool`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override WorkerPool GetWorkerPool(GetWorkerPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWorkerPoolRequest(ref request, ref callSettings);
            return _callGetWorkerPool.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns details of a `WorkerPool`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<WorkerPool> GetWorkerPoolAsync(GetWorkerPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetWorkerPoolRequest(ref request, ref callSettings);
            return _callGetWorkerPool.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteWorkerPool</c>.</summary>
        public override lro::OperationsClient DeleteWorkerPoolOperationsClient { get; }

        /// <summary>
        /// Deletes a `WorkerPool`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteWorkerPoolOperationMetadata> DeleteWorkerPool(DeleteWorkerPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteWorkerPoolRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteWorkerPoolOperationMetadata>(_callDeleteWorkerPool.Sync(request, callSettings), DeleteWorkerPoolOperationsClient);
        }

        /// <summary>
        /// Deletes a `WorkerPool`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteWorkerPoolOperationMetadata>> DeleteWorkerPoolAsync(DeleteWorkerPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteWorkerPoolRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteWorkerPoolOperationMetadata>(await _callDeleteWorkerPool.Async(request, callSettings).ConfigureAwait(false), DeleteWorkerPoolOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateWorkerPool</c>.</summary>
        public override lro::OperationsClient UpdateWorkerPoolOperationsClient { get; }

        /// <summary>
        /// Updates a `WorkerPool`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<WorkerPool, UpdateWorkerPoolOperationMetadata> UpdateWorkerPool(UpdateWorkerPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateWorkerPoolRequest(ref request, ref callSettings);
            return new lro::Operation<WorkerPool, UpdateWorkerPoolOperationMetadata>(_callUpdateWorkerPool.Sync(request, callSettings), UpdateWorkerPoolOperationsClient);
        }

        /// <summary>
        /// Updates a `WorkerPool`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<WorkerPool, UpdateWorkerPoolOperationMetadata>> UpdateWorkerPoolAsync(UpdateWorkerPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateWorkerPoolRequest(ref request, ref callSettings);
            return new lro::Operation<WorkerPool, UpdateWorkerPoolOperationMetadata>(await _callUpdateWorkerPool.Async(request, callSettings).ConfigureAwait(false), UpdateWorkerPoolOperationsClient);
        }

        /// <summary>
        /// Lists `WorkerPool`s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="WorkerPool"/> resources.</returns>
        public override gax::PagedEnumerable<ListWorkerPoolsResponse, WorkerPool> ListWorkerPools(ListWorkerPoolsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListWorkerPoolsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListWorkerPoolsRequest, ListWorkerPoolsResponse, WorkerPool>(_callListWorkerPools, request, callSettings);
        }

        /// <summary>
        /// Lists `WorkerPool`s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="WorkerPool"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListWorkerPoolsResponse, WorkerPool> ListWorkerPoolsAsync(ListWorkerPoolsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListWorkerPoolsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListWorkerPoolsRequest, ListWorkerPoolsResponse, WorkerPool>(_callListWorkerPools, request, callSettings);
        }
    }

    public partial class ListBuildsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBuildTriggersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListWorkerPoolsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBuildsResponse : gaxgrpc::IPageResponse<Build>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Build> GetEnumerator() => Builds.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListBuildTriggersResponse : gaxgrpc::IPageResponse<BuildTrigger>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<BuildTrigger> GetEnumerator() => Triggers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListWorkerPoolsResponse : gaxgrpc::IPageResponse<WorkerPool>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<WorkerPool> GetEnumerator() => WorkerPools.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class CloudBuild
    {
        public partial class CloudBuildClient
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
