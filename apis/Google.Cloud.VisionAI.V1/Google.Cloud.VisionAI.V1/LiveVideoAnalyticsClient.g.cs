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

namespace Google.Cloud.VisionAI.V1
{
    /// <summary>Settings for <see cref="LiveVideoAnalyticsClient"/> instances.</summary>
    public sealed partial class LiveVideoAnalyticsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="LiveVideoAnalyticsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="LiveVideoAnalyticsSettings"/>.</returns>
        public static LiveVideoAnalyticsSettings GetDefault() => new LiveVideoAnalyticsSettings();

        /// <summary>Constructs a new <see cref="LiveVideoAnalyticsSettings"/> object with default settings.</summary>
        public LiveVideoAnalyticsSettings()
        {
        }

        private LiveVideoAnalyticsSettings(LiveVideoAnalyticsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListPublicOperatorsSettings = existing.ListPublicOperatorsSettings;
            ResolveOperatorInfoSettings = existing.ResolveOperatorInfoSettings;
            ListOperatorsSettings = existing.ListOperatorsSettings;
            GetOperatorSettings = existing.GetOperatorSettings;
            CreateOperatorSettings = existing.CreateOperatorSettings;
            CreateOperatorOperationsSettings = existing.CreateOperatorOperationsSettings.Clone();
            UpdateOperatorSettings = existing.UpdateOperatorSettings;
            UpdateOperatorOperationsSettings = existing.UpdateOperatorOperationsSettings.Clone();
            DeleteOperatorSettings = existing.DeleteOperatorSettings;
            DeleteOperatorOperationsSettings = existing.DeleteOperatorOperationsSettings.Clone();
            ListAnalysesSettings = existing.ListAnalysesSettings;
            GetAnalysisSettings = existing.GetAnalysisSettings;
            CreateAnalysisSettings = existing.CreateAnalysisSettings;
            CreateAnalysisOperationsSettings = existing.CreateAnalysisOperationsSettings.Clone();
            UpdateAnalysisSettings = existing.UpdateAnalysisSettings;
            UpdateAnalysisOperationsSettings = existing.UpdateAnalysisOperationsSettings.Clone();
            DeleteAnalysisSettings = existing.DeleteAnalysisSettings;
            DeleteAnalysisOperationsSettings = existing.DeleteAnalysisOperationsSettings.Clone();
            ListProcessesSettings = existing.ListProcessesSettings;
            GetProcessSettings = existing.GetProcessSettings;
            CreateProcessSettings = existing.CreateProcessSettings;
            CreateProcessOperationsSettings = existing.CreateProcessOperationsSettings.Clone();
            UpdateProcessSettings = existing.UpdateProcessSettings;
            UpdateProcessOperationsSettings = existing.UpdateProcessOperationsSettings.Clone();
            DeleteProcessSettings = existing.DeleteProcessSettings;
            DeleteProcessOperationsSettings = existing.DeleteProcessOperationsSettings.Clone();
            BatchRunProcessSettings = existing.BatchRunProcessSettings;
            BatchRunProcessOperationsSettings = existing.BatchRunProcessOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(LiveVideoAnalyticsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LiveVideoAnalyticsClient.ListPublicOperators</c> and <c>LiveVideoAnalyticsClient.ListPublicOperatorsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPublicOperatorsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LiveVideoAnalyticsClient.ResolveOperatorInfo</c> and <c>LiveVideoAnalyticsClient.ResolveOperatorInfoAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResolveOperatorInfoSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LiveVideoAnalyticsClient.ListOperators</c> and <c>LiveVideoAnalyticsClient.ListOperatorsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListOperatorsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LiveVideoAnalyticsClient.GetOperator</c> and <c>LiveVideoAnalyticsClient.GetOperatorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetOperatorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LiveVideoAnalyticsClient.CreateOperator</c> and <c>LiveVideoAnalyticsClient.CreateOperatorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateOperatorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>LiveVideoAnalyticsClient.CreateOperator</c> and
        /// <c>LiveVideoAnalyticsClient.CreateOperatorAsync</c>.
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
        public lro::OperationsSettings CreateOperatorOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LiveVideoAnalyticsClient.UpdateOperator</c> and <c>LiveVideoAnalyticsClient.UpdateOperatorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateOperatorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>LiveVideoAnalyticsClient.UpdateOperator</c> and
        /// <c>LiveVideoAnalyticsClient.UpdateOperatorAsync</c>.
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
        public lro::OperationsSettings UpdateOperatorOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LiveVideoAnalyticsClient.DeleteOperator</c> and <c>LiveVideoAnalyticsClient.DeleteOperatorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteOperatorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>LiveVideoAnalyticsClient.DeleteOperator</c> and
        /// <c>LiveVideoAnalyticsClient.DeleteOperatorAsync</c>.
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
        public lro::OperationsSettings DeleteOperatorOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LiveVideoAnalyticsClient.ListAnalyses</c> and <c>LiveVideoAnalyticsClient.ListAnalysesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAnalysesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LiveVideoAnalyticsClient.GetAnalysis</c> and <c>LiveVideoAnalyticsClient.GetAnalysisAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAnalysisSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LiveVideoAnalyticsClient.CreateAnalysis</c> and <c>LiveVideoAnalyticsClient.CreateAnalysisAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAnalysisSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>LiveVideoAnalyticsClient.CreateAnalysis</c> and
        /// <c>LiveVideoAnalyticsClient.CreateAnalysisAsync</c>.
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
        public lro::OperationsSettings CreateAnalysisOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LiveVideoAnalyticsClient.UpdateAnalysis</c> and <c>LiveVideoAnalyticsClient.UpdateAnalysisAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAnalysisSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>LiveVideoAnalyticsClient.UpdateAnalysis</c> and
        /// <c>LiveVideoAnalyticsClient.UpdateAnalysisAsync</c>.
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
        public lro::OperationsSettings UpdateAnalysisOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LiveVideoAnalyticsClient.DeleteAnalysis</c> and <c>LiveVideoAnalyticsClient.DeleteAnalysisAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAnalysisSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>LiveVideoAnalyticsClient.DeleteAnalysis</c> and
        /// <c>LiveVideoAnalyticsClient.DeleteAnalysisAsync</c>.
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
        public lro::OperationsSettings DeleteAnalysisOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LiveVideoAnalyticsClient.ListProcesses</c> and <c>LiveVideoAnalyticsClient.ListProcessesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListProcessesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LiveVideoAnalyticsClient.GetProcess</c> and <c>LiveVideoAnalyticsClient.GetProcessAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetProcessSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LiveVideoAnalyticsClient.CreateProcess</c> and <c>LiveVideoAnalyticsClient.CreateProcessAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateProcessSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>LiveVideoAnalyticsClient.CreateProcess</c> and
        /// <c>LiveVideoAnalyticsClient.CreateProcessAsync</c>.
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
        public lro::OperationsSettings CreateProcessOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LiveVideoAnalyticsClient.UpdateProcess</c> and <c>LiveVideoAnalyticsClient.UpdateProcessAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateProcessSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>LiveVideoAnalyticsClient.UpdateProcess</c> and
        /// <c>LiveVideoAnalyticsClient.UpdateProcessAsync</c>.
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
        public lro::OperationsSettings UpdateProcessOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LiveVideoAnalyticsClient.DeleteProcess</c> and <c>LiveVideoAnalyticsClient.DeleteProcessAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteProcessSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>LiveVideoAnalyticsClient.DeleteProcess</c> and
        /// <c>LiveVideoAnalyticsClient.DeleteProcessAsync</c>.
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
        public lro::OperationsSettings DeleteProcessOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LiveVideoAnalyticsClient.BatchRunProcess</c> and <c>LiveVideoAnalyticsClient.BatchRunProcessAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchRunProcessSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>LiveVideoAnalyticsClient.BatchRunProcess</c> and
        /// <c>LiveVideoAnalyticsClient.BatchRunProcessAsync</c>.
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
        public lro::OperationsSettings BatchRunProcessOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="LiveVideoAnalyticsSettings"/> object.</returns>
        public LiveVideoAnalyticsSettings Clone() => new LiveVideoAnalyticsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="LiveVideoAnalyticsClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class LiveVideoAnalyticsClientBuilder : gaxgrpc::ClientBuilderBase<LiveVideoAnalyticsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public LiveVideoAnalyticsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public LiveVideoAnalyticsClientBuilder() : base(LiveVideoAnalyticsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref LiveVideoAnalyticsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<LiveVideoAnalyticsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override LiveVideoAnalyticsClient Build()
        {
            LiveVideoAnalyticsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<LiveVideoAnalyticsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<LiveVideoAnalyticsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private LiveVideoAnalyticsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return LiveVideoAnalyticsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<LiveVideoAnalyticsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return LiveVideoAnalyticsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => LiveVideoAnalyticsClient.ChannelPool;
    }

    /// <summary>LiveVideoAnalytics client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources. The service enables clients to run
    /// Live Video Analytics (LVA) on the streaming inputs.
    /// </remarks>
    public abstract partial class LiveVideoAnalyticsClient
    {
        /// <summary>
        /// The default endpoint for the LiveVideoAnalytics service, which is a host of "visionai.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "visionai.googleapis.com:443";

        /// <summary>The default LiveVideoAnalytics scopes.</summary>
        /// <remarks>
        /// The default LiveVideoAnalytics scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(LiveVideoAnalytics.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="LiveVideoAnalyticsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="LiveVideoAnalyticsClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="LiveVideoAnalyticsClient"/>.</returns>
        public static stt::Task<LiveVideoAnalyticsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new LiveVideoAnalyticsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="LiveVideoAnalyticsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="LiveVideoAnalyticsClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="LiveVideoAnalyticsClient"/>.</returns>
        public static LiveVideoAnalyticsClient Create() => new LiveVideoAnalyticsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="LiveVideoAnalyticsClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="LiveVideoAnalyticsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="LiveVideoAnalyticsClient"/>.</returns>
        internal static LiveVideoAnalyticsClient Create(grpccore::CallInvoker callInvoker, LiveVideoAnalyticsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            LiveVideoAnalytics.LiveVideoAnalyticsClient grpcClient = new LiveVideoAnalytics.LiveVideoAnalyticsClient(callInvoker);
            return new LiveVideoAnalyticsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC LiveVideoAnalytics client</summary>
        public virtual LiveVideoAnalytics.LiveVideoAnalyticsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// ListPublicOperators returns all the operators in public registry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Operator"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPublicOperatorsResponse, Operator> ListPublicOperators(ListPublicOperatorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// ListPublicOperators returns all the operators in public registry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Operator"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPublicOperatorsResponse, Operator> ListPublicOperatorsAsync(ListPublicOperatorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// ListPublicOperators returns all the operators in public registry.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListPublicOperatorsRequest.
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
        /// <returns>A pageable sequence of <see cref="Operator"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPublicOperatorsResponse, Operator> ListPublicOperators(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPublicOperatorsRequest request = new ListPublicOperatorsRequest
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
            return ListPublicOperators(request, callSettings);
        }

        /// <summary>
        /// ListPublicOperators returns all the operators in public registry.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListPublicOperatorsRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Operator"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPublicOperatorsResponse, Operator> ListPublicOperatorsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPublicOperatorsRequest request = new ListPublicOperatorsRequest
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
            return ListPublicOperatorsAsync(request, callSettings);
        }

        /// <summary>
        /// ListPublicOperators returns all the operators in public registry.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListPublicOperatorsRequest.
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
        /// <returns>A pageable sequence of <see cref="Operator"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPublicOperatorsResponse, Operator> ListPublicOperators(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPublicOperatorsRequest request = new ListPublicOperatorsRequest
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
            return ListPublicOperators(request, callSettings);
        }

        /// <summary>
        /// ListPublicOperators returns all the operators in public registry.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListPublicOperatorsRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Operator"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPublicOperatorsResponse, Operator> ListPublicOperatorsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPublicOperatorsRequest request = new ListPublicOperatorsRequest
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
            return ListPublicOperatorsAsync(request, callSettings);
        }

        /// <summary>
        /// ResolveOperatorInfo returns the operator information based on the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ResolveOperatorInfoResponse ResolveOperatorInfo(ResolveOperatorInfoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// ResolveOperatorInfo returns the operator information based on the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResolveOperatorInfoResponse> ResolveOperatorInfoAsync(ResolveOperatorInfoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// ResolveOperatorInfo returns the operator information based on the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResolveOperatorInfoResponse> ResolveOperatorInfoAsync(ResolveOperatorInfoRequest request, st::CancellationToken cancellationToken) =>
            ResolveOperatorInfoAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// ResolveOperatorInfo returns the operator information based on the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ResolveOperatorInfoRequest.
        /// </param>
        /// <param name="queries">
        /// Required. The operator queries.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ResolveOperatorInfoResponse ResolveOperatorInfo(string parent, scg::IEnumerable<OperatorQuery> queries, gaxgrpc::CallSettings callSettings = null) =>
            ResolveOperatorInfo(new ResolveOperatorInfoRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Queries =
                {
                    gax::GaxPreconditions.CheckNotNull(queries, nameof(queries)),
                },
            }, callSettings);

        /// <summary>
        /// ResolveOperatorInfo returns the operator information based on the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ResolveOperatorInfoRequest.
        /// </param>
        /// <param name="queries">
        /// Required. The operator queries.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResolveOperatorInfoResponse> ResolveOperatorInfoAsync(string parent, scg::IEnumerable<OperatorQuery> queries, gaxgrpc::CallSettings callSettings = null) =>
            ResolveOperatorInfoAsync(new ResolveOperatorInfoRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Queries =
                {
                    gax::GaxPreconditions.CheckNotNull(queries, nameof(queries)),
                },
            }, callSettings);

        /// <summary>
        /// ResolveOperatorInfo returns the operator information based on the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ResolveOperatorInfoRequest.
        /// </param>
        /// <param name="queries">
        /// Required. The operator queries.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResolveOperatorInfoResponse> ResolveOperatorInfoAsync(string parent, scg::IEnumerable<OperatorQuery> queries, st::CancellationToken cancellationToken) =>
            ResolveOperatorInfoAsync(parent, queries, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// ResolveOperatorInfo returns the operator information based on the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ResolveOperatorInfoRequest.
        /// </param>
        /// <param name="queries">
        /// Required. The operator queries.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ResolveOperatorInfoResponse ResolveOperatorInfo(gagr::LocationName parent, scg::IEnumerable<OperatorQuery> queries, gaxgrpc::CallSettings callSettings = null) =>
            ResolveOperatorInfo(new ResolveOperatorInfoRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Queries =
                {
                    gax::GaxPreconditions.CheckNotNull(queries, nameof(queries)),
                },
            }, callSettings);

        /// <summary>
        /// ResolveOperatorInfo returns the operator information based on the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ResolveOperatorInfoRequest.
        /// </param>
        /// <param name="queries">
        /// Required. The operator queries.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResolveOperatorInfoResponse> ResolveOperatorInfoAsync(gagr::LocationName parent, scg::IEnumerable<OperatorQuery> queries, gaxgrpc::CallSettings callSettings = null) =>
            ResolveOperatorInfoAsync(new ResolveOperatorInfoRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Queries =
                {
                    gax::GaxPreconditions.CheckNotNull(queries, nameof(queries)),
                },
            }, callSettings);

        /// <summary>
        /// ResolveOperatorInfo returns the operator information based on the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ResolveOperatorInfoRequest.
        /// </param>
        /// <param name="queries">
        /// Required. The operator queries.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResolveOperatorInfoResponse> ResolveOperatorInfoAsync(gagr::LocationName parent, scg::IEnumerable<OperatorQuery> queries, st::CancellationToken cancellationToken) =>
            ResolveOperatorInfoAsync(parent, queries, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Operators in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Operator"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOperatorsResponse, Operator> ListOperators(ListOperatorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Operators in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Operator"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOperatorsResponse, Operator> ListOperatorsAsync(ListOperatorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Operators in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListOperatorsRequest.
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
        /// <returns>A pageable sequence of <see cref="Operator"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOperatorsResponse, Operator> ListOperators(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOperatorsRequest request = new ListOperatorsRequest
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
            return ListOperators(request, callSettings);
        }

        /// <summary>
        /// Lists Operators in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListOperatorsRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Operator"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOperatorsResponse, Operator> ListOperatorsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOperatorsRequest request = new ListOperatorsRequest
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
            return ListOperatorsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Operators in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListOperatorsRequest.
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
        /// <returns>A pageable sequence of <see cref="Operator"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOperatorsResponse, Operator> ListOperators(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOperatorsRequest request = new ListOperatorsRequest
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
            return ListOperators(request, callSettings);
        }

        /// <summary>
        /// Lists Operators in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListOperatorsRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Operator"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOperatorsResponse, Operator> ListOperatorsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListOperatorsRequest request = new ListOperatorsRequest
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
            return ListOperatorsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Operator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operator GetOperator(GetOperatorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Operator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operator> GetOperatorAsync(GetOperatorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Operator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operator> GetOperatorAsync(GetOperatorRequest request, st::CancellationToken cancellationToken) =>
            GetOperatorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Operator.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operator GetOperator(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOperator(new GetOperatorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Operator.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operator> GetOperatorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetOperatorAsync(new GetOperatorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Operator.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operator> GetOperatorAsync(string name, st::CancellationToken cancellationToken) =>
            GetOperatorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Operator.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Operator GetOperator(OperatorName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOperator(new GetOperatorRequest
            {
                OperatorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Operator.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operator> GetOperatorAsync(OperatorName name, gaxgrpc::CallSettings callSettings = null) =>
            GetOperatorAsync(new GetOperatorRequest
            {
                OperatorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Operator.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Operator> GetOperatorAsync(OperatorName name, st::CancellationToken cancellationToken) =>
            GetOperatorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Operator in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operator, OperationMetadata> CreateOperator(CreateOperatorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Operator in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operator, OperationMetadata>> CreateOperatorAsync(CreateOperatorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Operator in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operator, OperationMetadata>> CreateOperatorAsync(CreateOperatorRequest request, st::CancellationToken cancellationToken) =>
            CreateOperatorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateOperator</c>.</summary>
        public virtual lro::OperationsClient CreateOperatorOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateOperator</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operator, OperationMetadata> PollOnceCreateOperator(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operator, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateOperatorOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateOperator</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operator, OperationMetadata>> PollOnceCreateOperatorAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operator, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateOperatorOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Operator in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="operator">
        /// Required. The resource being created.
        /// </param>
        /// <param name="operatorId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operator, OperationMetadata> CreateOperator(string parent, Operator @operator, string operatorId, gaxgrpc::CallSettings callSettings = null) =>
            CreateOperator(new CreateOperatorRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                OperatorId = gax::GaxPreconditions.CheckNotNullOrEmpty(operatorId, nameof(operatorId)),
                Operator = gax::GaxPreconditions.CheckNotNull(@operator, nameof(@operator)),
            }, callSettings);

        /// <summary>
        /// Creates a new Operator in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="operator">
        /// Required. The resource being created.
        /// </param>
        /// <param name="operatorId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operator, OperationMetadata>> CreateOperatorAsync(string parent, Operator @operator, string operatorId, gaxgrpc::CallSettings callSettings = null) =>
            CreateOperatorAsync(new CreateOperatorRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                OperatorId = gax::GaxPreconditions.CheckNotNullOrEmpty(operatorId, nameof(operatorId)),
                Operator = gax::GaxPreconditions.CheckNotNull(@operator, nameof(@operator)),
            }, callSettings);

        /// <summary>
        /// Creates a new Operator in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="operator">
        /// Required. The resource being created.
        /// </param>
        /// <param name="operatorId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operator, OperationMetadata>> CreateOperatorAsync(string parent, Operator @operator, string operatorId, st::CancellationToken cancellationToken) =>
            CreateOperatorAsync(parent, @operator, operatorId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Operator in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="operator">
        /// Required. The resource being created.
        /// </param>
        /// <param name="operatorId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operator, OperationMetadata> CreateOperator(gagr::LocationName parent, Operator @operator, string operatorId, gaxgrpc::CallSettings callSettings = null) =>
            CreateOperator(new CreateOperatorRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OperatorId = gax::GaxPreconditions.CheckNotNullOrEmpty(operatorId, nameof(operatorId)),
                Operator = gax::GaxPreconditions.CheckNotNull(@operator, nameof(@operator)),
            }, callSettings);

        /// <summary>
        /// Creates a new Operator in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="operator">
        /// Required. The resource being created.
        /// </param>
        /// <param name="operatorId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operator, OperationMetadata>> CreateOperatorAsync(gagr::LocationName parent, Operator @operator, string operatorId, gaxgrpc::CallSettings callSettings = null) =>
            CreateOperatorAsync(new CreateOperatorRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                OperatorId = gax::GaxPreconditions.CheckNotNullOrEmpty(operatorId, nameof(operatorId)),
                Operator = gax::GaxPreconditions.CheckNotNull(@operator, nameof(@operator)),
            }, callSettings);

        /// <summary>
        /// Creates a new Operator in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="operator">
        /// Required. The resource being created.
        /// </param>
        /// <param name="operatorId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operator, OperationMetadata>> CreateOperatorAsync(gagr::LocationName parent, Operator @operator, string operatorId, st::CancellationToken cancellationToken) =>
            CreateOperatorAsync(parent, @operator, operatorId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Operator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operator, OperationMetadata> UpdateOperator(UpdateOperatorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Operator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operator, OperationMetadata>> UpdateOperatorAsync(UpdateOperatorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Operator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operator, OperationMetadata>> UpdateOperatorAsync(UpdateOperatorRequest request, st::CancellationToken cancellationToken) =>
            UpdateOperatorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateOperator</c>.</summary>
        public virtual lro::OperationsClient UpdateOperatorOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateOperator</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Operator, OperationMetadata> PollOnceUpdateOperator(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operator, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateOperatorOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateOperator</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Operator, OperationMetadata>> PollOnceUpdateOperatorAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Operator, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateOperatorOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single Operator.
        /// </summary>
        /// <param name="operator">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Operator resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Operator, OperationMetadata> UpdateOperator(Operator @operator, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateOperator(new UpdateOperatorRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Operator = gax::GaxPreconditions.CheckNotNull(@operator, nameof(@operator)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Operator.
        /// </summary>
        /// <param name="operator">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Operator resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operator, OperationMetadata>> UpdateOperatorAsync(Operator @operator, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateOperatorAsync(new UpdateOperatorRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Operator = gax::GaxPreconditions.CheckNotNull(@operator, nameof(@operator)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Operator.
        /// </summary>
        /// <param name="operator">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Operator resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Operator, OperationMetadata>> UpdateOperatorAsync(Operator @operator, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateOperatorAsync(@operator, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Operator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteOperator(DeleteOperatorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Operator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteOperatorAsync(DeleteOperatorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Operator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteOperatorAsync(DeleteOperatorRequest request, st::CancellationToken cancellationToken) =>
            DeleteOperatorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteOperator</c>.</summary>
        public virtual lro::OperationsClient DeleteOperatorOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteOperator</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteOperator(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteOperatorOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteOperator</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteOperatorAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteOperatorOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Operator.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteOperator(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteOperator(new DeleteOperatorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Operator.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteOperatorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteOperatorAsync(new DeleteOperatorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Operator.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteOperatorAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteOperatorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Operator.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteOperator(OperatorName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteOperator(new DeleteOperatorRequest
            {
                OperatorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Operator.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteOperatorAsync(OperatorName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteOperatorAsync(new DeleteOperatorRequest
            {
                OperatorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Operator.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteOperatorAsync(OperatorName name, st::CancellationToken cancellationToken) =>
            DeleteOperatorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Analyses in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Analysis"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAnalysesResponse, Analysis> ListAnalyses(ListAnalysesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Analyses in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Analysis"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAnalysesResponse, Analysis> ListAnalysesAsync(ListAnalysesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Analyses in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListAnalysesRequest
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
        /// <returns>A pageable sequence of <see cref="Analysis"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAnalysesResponse, Analysis> ListAnalyses(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAnalysesRequest request = new ListAnalysesRequest
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
            return ListAnalyses(request, callSettings);
        }

        /// <summary>
        /// Lists Analyses in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListAnalysesRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="Analysis"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAnalysesResponse, Analysis> ListAnalysesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAnalysesRequest request = new ListAnalysesRequest
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
            return ListAnalysesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Analyses in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListAnalysesRequest
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
        /// <returns>A pageable sequence of <see cref="Analysis"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAnalysesResponse, Analysis> ListAnalyses(ClusterName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAnalysesRequest request = new ListAnalysesRequest
            {
                ParentAsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAnalyses(request, callSettings);
        }

        /// <summary>
        /// Lists Analyses in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListAnalysesRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="Analysis"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAnalysesResponse, Analysis> ListAnalysesAsync(ClusterName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAnalysesRequest request = new ListAnalysesRequest
            {
                ParentAsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListAnalysesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Analysis.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Analysis GetAnalysis(GetAnalysisRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Analysis.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Analysis> GetAnalysisAsync(GetAnalysisRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Analysis.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Analysis> GetAnalysisAsync(GetAnalysisRequest request, st::CancellationToken cancellationToken) =>
            GetAnalysisAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Analysis.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Analysis GetAnalysis(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnalysis(new GetAnalysisRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Analysis.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Analysis> GetAnalysisAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnalysisAsync(new GetAnalysisRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Analysis.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Analysis> GetAnalysisAsync(string name, st::CancellationToken cancellationToken) =>
            GetAnalysisAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Analysis.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Analysis GetAnalysis(AnalysisName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnalysis(new GetAnalysisRequest
            {
                AnalysisName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Analysis.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Analysis> GetAnalysisAsync(AnalysisName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnalysisAsync(new GetAnalysisRequest
            {
                AnalysisName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Analysis.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Analysis> GetAnalysisAsync(AnalysisName name, st::CancellationToken cancellationToken) =>
            GetAnalysisAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Analysis in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Analysis, OperationMetadata> CreateAnalysis(CreateAnalysisRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Analysis in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Analysis, OperationMetadata>> CreateAnalysisAsync(CreateAnalysisRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Analysis in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Analysis, OperationMetadata>> CreateAnalysisAsync(CreateAnalysisRequest request, st::CancellationToken cancellationToken) =>
            CreateAnalysisAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateAnalysis</c>.</summary>
        public virtual lro::OperationsClient CreateAnalysisOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateAnalysis</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Analysis, OperationMetadata> PollOnceCreateAnalysis(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Analysis, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAnalysisOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateAnalysis</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Analysis, OperationMetadata>> PollOnceCreateAnalysisAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Analysis, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAnalysisOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Analysis in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="analysis">
        /// Required. The resource being created.
        /// </param>
        /// <param name="analysisId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Analysis, OperationMetadata> CreateAnalysis(string parent, Analysis analysis, string analysisId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAnalysis(new CreateAnalysisRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AnalysisId = gax::GaxPreconditions.CheckNotNullOrEmpty(analysisId, nameof(analysisId)),
                Analysis = gax::GaxPreconditions.CheckNotNull(analysis, nameof(analysis)),
            }, callSettings);

        /// <summary>
        /// Creates a new Analysis in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="analysis">
        /// Required. The resource being created.
        /// </param>
        /// <param name="analysisId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Analysis, OperationMetadata>> CreateAnalysisAsync(string parent, Analysis analysis, string analysisId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAnalysisAsync(new CreateAnalysisRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AnalysisId = gax::GaxPreconditions.CheckNotNullOrEmpty(analysisId, nameof(analysisId)),
                Analysis = gax::GaxPreconditions.CheckNotNull(analysis, nameof(analysis)),
            }, callSettings);

        /// <summary>
        /// Creates a new Analysis in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="analysis">
        /// Required. The resource being created.
        /// </param>
        /// <param name="analysisId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Analysis, OperationMetadata>> CreateAnalysisAsync(string parent, Analysis analysis, string analysisId, st::CancellationToken cancellationToken) =>
            CreateAnalysisAsync(parent, analysis, analysisId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Analysis in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="analysis">
        /// Required. The resource being created.
        /// </param>
        /// <param name="analysisId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Analysis, OperationMetadata> CreateAnalysis(ClusterName parent, Analysis analysis, string analysisId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAnalysis(new CreateAnalysisRequest
            {
                ParentAsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AnalysisId = gax::GaxPreconditions.CheckNotNullOrEmpty(analysisId, nameof(analysisId)),
                Analysis = gax::GaxPreconditions.CheckNotNull(analysis, nameof(analysis)),
            }, callSettings);

        /// <summary>
        /// Creates a new Analysis in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="analysis">
        /// Required. The resource being created.
        /// </param>
        /// <param name="analysisId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Analysis, OperationMetadata>> CreateAnalysisAsync(ClusterName parent, Analysis analysis, string analysisId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAnalysisAsync(new CreateAnalysisRequest
            {
                ParentAsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AnalysisId = gax::GaxPreconditions.CheckNotNullOrEmpty(analysisId, nameof(analysisId)),
                Analysis = gax::GaxPreconditions.CheckNotNull(analysis, nameof(analysis)),
            }, callSettings);

        /// <summary>
        /// Creates a new Analysis in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="analysis">
        /// Required. The resource being created.
        /// </param>
        /// <param name="analysisId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Analysis, OperationMetadata>> CreateAnalysisAsync(ClusterName parent, Analysis analysis, string analysisId, st::CancellationToken cancellationToken) =>
            CreateAnalysisAsync(parent, analysis, analysisId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Analysis.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Analysis, OperationMetadata> UpdateAnalysis(UpdateAnalysisRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Analysis.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Analysis, OperationMetadata>> UpdateAnalysisAsync(UpdateAnalysisRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Analysis.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Analysis, OperationMetadata>> UpdateAnalysisAsync(UpdateAnalysisRequest request, st::CancellationToken cancellationToken) =>
            UpdateAnalysisAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateAnalysis</c>.</summary>
        public virtual lro::OperationsClient UpdateAnalysisOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateAnalysis</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Analysis, OperationMetadata> PollOnceUpdateAnalysis(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Analysis, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAnalysisOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateAnalysis</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Analysis, OperationMetadata>> PollOnceUpdateAnalysisAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Analysis, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAnalysisOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single Analysis.
        /// </summary>
        /// <param name="analysis">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Analysis resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Analysis, OperationMetadata> UpdateAnalysis(Analysis analysis, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAnalysis(new UpdateAnalysisRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Analysis = gax::GaxPreconditions.CheckNotNull(analysis, nameof(analysis)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Analysis.
        /// </summary>
        /// <param name="analysis">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Analysis resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Analysis, OperationMetadata>> UpdateAnalysisAsync(Analysis analysis, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAnalysisAsync(new UpdateAnalysisRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Analysis = gax::GaxPreconditions.CheckNotNull(analysis, nameof(analysis)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Analysis.
        /// </summary>
        /// <param name="analysis">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Analysis resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Analysis, OperationMetadata>> UpdateAnalysisAsync(Analysis analysis, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAnalysisAsync(analysis, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Analysis.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAnalysis(DeleteAnalysisRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Analysis.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAnalysisAsync(DeleteAnalysisRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Analysis.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAnalysisAsync(DeleteAnalysisRequest request, st::CancellationToken cancellationToken) =>
            DeleteAnalysisAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteAnalysis</c>.</summary>
        public virtual lro::OperationsClient DeleteAnalysisOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteAnalysis</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteAnalysis(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAnalysisOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteAnalysis</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteAnalysisAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAnalysisOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Analysis.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAnalysis(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAnalysis(new DeleteAnalysisRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Analysis.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAnalysisAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAnalysisAsync(new DeleteAnalysisRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Analysis.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAnalysisAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAnalysisAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Analysis.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAnalysis(AnalysisName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAnalysis(new DeleteAnalysisRequest
            {
                AnalysisName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Analysis.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAnalysisAsync(AnalysisName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAnalysisAsync(new DeleteAnalysisRequest
            {
                AnalysisName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Analysis.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAnalysisAsync(AnalysisName name, st::CancellationToken cancellationToken) =>
            DeleteAnalysisAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Processes in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Process"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProcessesResponse, Process> ListProcesses(ListProcessesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Processes in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Process"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProcessesResponse, Process> ListProcessesAsync(ListProcessesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Processes in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListProcessesRequest.
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
        /// <returns>A pageable sequence of <see cref="Process"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProcessesResponse, Process> ListProcesses(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProcessesRequest request = new ListProcessesRequest
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
            return ListProcesses(request, callSettings);
        }

        /// <summary>
        /// Lists Processes in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListProcessesRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Process"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProcessesResponse, Process> ListProcessesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProcessesRequest request = new ListProcessesRequest
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
            return ListProcessesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Processes in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListProcessesRequest.
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
        /// <returns>A pageable sequence of <see cref="Process"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProcessesResponse, Process> ListProcesses(ClusterName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProcessesRequest request = new ListProcessesRequest
            {
                ParentAsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListProcesses(request, callSettings);
        }

        /// <summary>
        /// Lists Processes in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListProcessesRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Process"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProcessesResponse, Process> ListProcessesAsync(ClusterName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProcessesRequest request = new ListProcessesRequest
            {
                ParentAsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListProcessesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Process.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Process GetProcess(GetProcessRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Process.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Process> GetProcessAsync(GetProcessRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Process.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Process> GetProcessAsync(GetProcessRequest request, st::CancellationToken cancellationToken) =>
            GetProcessAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Process.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Process GetProcess(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProcess(new GetProcessRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Process.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Process> GetProcessAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProcessAsync(new GetProcessRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Process.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Process> GetProcessAsync(string name, st::CancellationToken cancellationToken) =>
            GetProcessAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Process.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Process GetProcess(ProcessName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProcess(new GetProcessRequest
            {
                ProcessName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Process.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Process> GetProcessAsync(ProcessName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProcessAsync(new GetProcessRequest
            {
                ProcessName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Process.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Process> GetProcessAsync(ProcessName name, st::CancellationToken cancellationToken) =>
            GetProcessAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Process in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Process, OperationMetadata> CreateProcess(CreateProcessRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Process in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Process, OperationMetadata>> CreateProcessAsync(CreateProcessRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Process in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Process, OperationMetadata>> CreateProcessAsync(CreateProcessRequest request, st::CancellationToken cancellationToken) =>
            CreateProcessAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateProcess</c>.</summary>
        public virtual lro::OperationsClient CreateProcessOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateProcess</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Process, OperationMetadata> PollOnceCreateProcess(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Process, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateProcessOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateProcess</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Process, OperationMetadata>> PollOnceCreateProcessAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Process, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateProcessOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Process in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="process">
        /// Required. The resource being created.
        /// </param>
        /// <param name="processId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Process, OperationMetadata> CreateProcess(string parent, Process process, string processId, gaxgrpc::CallSettings callSettings = null) =>
            CreateProcess(new CreateProcessRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ProcessId = gax::GaxPreconditions.CheckNotNullOrEmpty(processId, nameof(processId)),
                Process = gax::GaxPreconditions.CheckNotNull(process, nameof(process)),
            }, callSettings);

        /// <summary>
        /// Creates a new Process in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="process">
        /// Required. The resource being created.
        /// </param>
        /// <param name="processId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Process, OperationMetadata>> CreateProcessAsync(string parent, Process process, string processId, gaxgrpc::CallSettings callSettings = null) =>
            CreateProcessAsync(new CreateProcessRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ProcessId = gax::GaxPreconditions.CheckNotNullOrEmpty(processId, nameof(processId)),
                Process = gax::GaxPreconditions.CheckNotNull(process, nameof(process)),
            }, callSettings);

        /// <summary>
        /// Creates a new Process in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="process">
        /// Required. The resource being created.
        /// </param>
        /// <param name="processId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Process, OperationMetadata>> CreateProcessAsync(string parent, Process process, string processId, st::CancellationToken cancellationToken) =>
            CreateProcessAsync(parent, process, processId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Process in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="process">
        /// Required. The resource being created.
        /// </param>
        /// <param name="processId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Process, OperationMetadata> CreateProcess(ClusterName parent, Process process, string processId, gaxgrpc::CallSettings callSettings = null) =>
            CreateProcess(new CreateProcessRequest
            {
                ParentAsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ProcessId = gax::GaxPreconditions.CheckNotNullOrEmpty(processId, nameof(processId)),
                Process = gax::GaxPreconditions.CheckNotNull(process, nameof(process)),
            }, callSettings);

        /// <summary>
        /// Creates a new Process in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="process">
        /// Required. The resource being created.
        /// </param>
        /// <param name="processId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Process, OperationMetadata>> CreateProcessAsync(ClusterName parent, Process process, string processId, gaxgrpc::CallSettings callSettings = null) =>
            CreateProcessAsync(new CreateProcessRequest
            {
                ParentAsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ProcessId = gax::GaxPreconditions.CheckNotNullOrEmpty(processId, nameof(processId)),
                Process = gax::GaxPreconditions.CheckNotNull(process, nameof(process)),
            }, callSettings);

        /// <summary>
        /// Creates a new Process in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="process">
        /// Required. The resource being created.
        /// </param>
        /// <param name="processId">
        /// Required. Id of the requesting object.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Process, OperationMetadata>> CreateProcessAsync(ClusterName parent, Process process, string processId, st::CancellationToken cancellationToken) =>
            CreateProcessAsync(parent, process, processId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Process.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Process, OperationMetadata> UpdateProcess(UpdateProcessRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Process.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Process, OperationMetadata>> UpdateProcessAsync(UpdateProcessRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Process.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Process, OperationMetadata>> UpdateProcessAsync(UpdateProcessRequest request, st::CancellationToken cancellationToken) =>
            UpdateProcessAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateProcess</c>.</summary>
        public virtual lro::OperationsClient UpdateProcessOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateProcess</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Process, OperationMetadata> PollOnceUpdateProcess(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Process, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateProcessOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateProcess</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Process, OperationMetadata>> PollOnceUpdateProcessAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Process, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateProcessOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single Process.
        /// </summary>
        /// <param name="process">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Process resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Process, OperationMetadata> UpdateProcess(Process process, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateProcess(new UpdateProcessRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Process = gax::GaxPreconditions.CheckNotNull(process, nameof(process)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Process.
        /// </summary>
        /// <param name="process">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Process resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Process, OperationMetadata>> UpdateProcessAsync(Process process, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateProcessAsync(new UpdateProcessRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Process = gax::GaxPreconditions.CheckNotNull(process, nameof(process)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Process.
        /// </summary>
        /// <param name="process">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Process resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Process, OperationMetadata>> UpdateProcessAsync(Process process, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateProcessAsync(process, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Process.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteProcess(DeleteProcessRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Process.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteProcessAsync(DeleteProcessRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Process.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteProcessAsync(DeleteProcessRequest request, st::CancellationToken cancellationToken) =>
            DeleteProcessAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteProcess</c>.</summary>
        public virtual lro::OperationsClient DeleteProcessOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteProcess</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteProcess(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteProcessOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteProcess</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteProcessAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteProcessOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Process.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteProcess(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProcess(new DeleteProcessRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Process.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteProcessAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProcessAsync(new DeleteProcessRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Process.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteProcessAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteProcessAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Process.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteProcess(ProcessName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProcess(new DeleteProcessRequest
            {
                ProcessName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Process.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteProcessAsync(ProcessName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProcessAsync(new DeleteProcessRequest
            {
                ProcessName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Process.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteProcessAsync(ProcessName name, st::CancellationToken cancellationToken) =>
            DeleteProcessAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Run all of the processes to "completion". Max time for each process is
        /// the LRO time limit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchRunProcessResponse, OperationMetadata> BatchRunProcess(BatchRunProcessRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Run all of the processes to "completion". Max time for each process is
        /// the LRO time limit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchRunProcessResponse, OperationMetadata>> BatchRunProcessAsync(BatchRunProcessRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Run all of the processes to "completion". Max time for each process is
        /// the LRO time limit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchRunProcessResponse, OperationMetadata>> BatchRunProcessAsync(BatchRunProcessRequest request, st::CancellationToken cancellationToken) =>
            BatchRunProcessAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BatchRunProcess</c>.</summary>
        public virtual lro::OperationsClient BatchRunProcessOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchRunProcess</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BatchRunProcessResponse, OperationMetadata> PollOnceBatchRunProcess(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchRunProcessResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchRunProcessOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchRunProcess</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BatchRunProcessResponse, OperationMetadata>> PollOnceBatchRunProcessAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchRunProcessResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchRunProcessOperationsClient, callSettings);

        /// <summary>
        /// Run all of the processes to "completion". Max time for each process is
        /// the LRO time limit.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource shared by all processes being created.
        /// </param>
        /// <param name="requests">
        /// Required. The create process requests.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchRunProcessResponse, OperationMetadata> BatchRunProcess(string parent, scg::IEnumerable<CreateProcessRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchRunProcess(new BatchRunProcessRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Run all of the processes to "completion". Max time for each process is
        /// the LRO time limit.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource shared by all processes being created.
        /// </param>
        /// <param name="requests">
        /// Required. The create process requests.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchRunProcessResponse, OperationMetadata>> BatchRunProcessAsync(string parent, scg::IEnumerable<CreateProcessRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchRunProcessAsync(new BatchRunProcessRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Run all of the processes to "completion". Max time for each process is
        /// the LRO time limit.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource shared by all processes being created.
        /// </param>
        /// <param name="requests">
        /// Required. The create process requests.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchRunProcessResponse, OperationMetadata>> BatchRunProcessAsync(string parent, scg::IEnumerable<CreateProcessRequest> requests, st::CancellationToken cancellationToken) =>
            BatchRunProcessAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Run all of the processes to "completion". Max time for each process is
        /// the LRO time limit.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource shared by all processes being created.
        /// </param>
        /// <param name="requests">
        /// Required. The create process requests.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchRunProcessResponse, OperationMetadata> BatchRunProcess(ClusterName parent, scg::IEnumerable<CreateProcessRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchRunProcess(new BatchRunProcessRequest
            {
                ParentAsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Run all of the processes to "completion". Max time for each process is
        /// the LRO time limit.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource shared by all processes being created.
        /// </param>
        /// <param name="requests">
        /// Required. The create process requests.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchRunProcessResponse, OperationMetadata>> BatchRunProcessAsync(ClusterName parent, scg::IEnumerable<CreateProcessRequest> requests, gaxgrpc::CallSettings callSettings = null) =>
            BatchRunProcessAsync(new BatchRunProcessRequest
            {
                ParentAsClusterName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Requests =
                {
                    gax::GaxPreconditions.CheckNotNull(requests, nameof(requests)),
                },
            }, callSettings);

        /// <summary>
        /// Run all of the processes to "completion". Max time for each process is
        /// the LRO time limit.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource shared by all processes being created.
        /// </param>
        /// <param name="requests">
        /// Required. The create process requests.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchRunProcessResponse, OperationMetadata>> BatchRunProcessAsync(ClusterName parent, scg::IEnumerable<CreateProcessRequest> requests, st::CancellationToken cancellationToken) =>
            BatchRunProcessAsync(parent, requests, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>LiveVideoAnalytics client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources. The service enables clients to run
    /// Live Video Analytics (LVA) on the streaming inputs.
    /// </remarks>
    public sealed partial class LiveVideoAnalyticsClientImpl : LiveVideoAnalyticsClient
    {
        private readonly gaxgrpc::ApiCall<ListPublicOperatorsRequest, ListPublicOperatorsResponse> _callListPublicOperators;

        private readonly gaxgrpc::ApiCall<ResolveOperatorInfoRequest, ResolveOperatorInfoResponse> _callResolveOperatorInfo;

        private readonly gaxgrpc::ApiCall<ListOperatorsRequest, ListOperatorsResponse> _callListOperators;

        private readonly gaxgrpc::ApiCall<GetOperatorRequest, Operator> _callGetOperator;

        private readonly gaxgrpc::ApiCall<CreateOperatorRequest, lro::Operation> _callCreateOperator;

        private readonly gaxgrpc::ApiCall<UpdateOperatorRequest, lro::Operation> _callUpdateOperator;

        private readonly gaxgrpc::ApiCall<DeleteOperatorRequest, lro::Operation> _callDeleteOperator;

        private readonly gaxgrpc::ApiCall<ListAnalysesRequest, ListAnalysesResponse> _callListAnalyses;

        private readonly gaxgrpc::ApiCall<GetAnalysisRequest, Analysis> _callGetAnalysis;

        private readonly gaxgrpc::ApiCall<CreateAnalysisRequest, lro::Operation> _callCreateAnalysis;

        private readonly gaxgrpc::ApiCall<UpdateAnalysisRequest, lro::Operation> _callUpdateAnalysis;

        private readonly gaxgrpc::ApiCall<DeleteAnalysisRequest, lro::Operation> _callDeleteAnalysis;

        private readonly gaxgrpc::ApiCall<ListProcessesRequest, ListProcessesResponse> _callListProcesses;

        private readonly gaxgrpc::ApiCall<GetProcessRequest, Process> _callGetProcess;

        private readonly gaxgrpc::ApiCall<CreateProcessRequest, lro::Operation> _callCreateProcess;

        private readonly gaxgrpc::ApiCall<UpdateProcessRequest, lro::Operation> _callUpdateProcess;

        private readonly gaxgrpc::ApiCall<DeleteProcessRequest, lro::Operation> _callDeleteProcess;

        private readonly gaxgrpc::ApiCall<BatchRunProcessRequest, lro::Operation> _callBatchRunProcess;

        /// <summary>
        /// Constructs a client wrapper for the LiveVideoAnalytics service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="LiveVideoAnalyticsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public LiveVideoAnalyticsClientImpl(LiveVideoAnalytics.LiveVideoAnalyticsClient grpcClient, LiveVideoAnalyticsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            LiveVideoAnalyticsSettings effectiveSettings = settings ?? LiveVideoAnalyticsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateOperatorOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateOperatorOperationsSettings, logger);
            UpdateOperatorOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateOperatorOperationsSettings, logger);
            DeleteOperatorOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteOperatorOperationsSettings, logger);
            CreateAnalysisOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateAnalysisOperationsSettings, logger);
            UpdateAnalysisOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateAnalysisOperationsSettings, logger);
            DeleteAnalysisOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteAnalysisOperationsSettings, logger);
            CreateProcessOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateProcessOperationsSettings, logger);
            UpdateProcessOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateProcessOperationsSettings, logger);
            DeleteProcessOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteProcessOperationsSettings, logger);
            BatchRunProcessOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BatchRunProcessOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListPublicOperators = clientHelper.BuildApiCall<ListPublicOperatorsRequest, ListPublicOperatorsResponse>("ListPublicOperators", grpcClient.ListPublicOperatorsAsync, grpcClient.ListPublicOperators, effectiveSettings.ListPublicOperatorsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPublicOperators);
            Modify_ListPublicOperatorsApiCall(ref _callListPublicOperators);
            _callResolveOperatorInfo = clientHelper.BuildApiCall<ResolveOperatorInfoRequest, ResolveOperatorInfoResponse>("ResolveOperatorInfo", grpcClient.ResolveOperatorInfoAsync, grpcClient.ResolveOperatorInfo, effectiveSettings.ResolveOperatorInfoSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callResolveOperatorInfo);
            Modify_ResolveOperatorInfoApiCall(ref _callResolveOperatorInfo);
            _callListOperators = clientHelper.BuildApiCall<ListOperatorsRequest, ListOperatorsResponse>("ListOperators", grpcClient.ListOperatorsAsync, grpcClient.ListOperators, effectiveSettings.ListOperatorsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListOperators);
            Modify_ListOperatorsApiCall(ref _callListOperators);
            _callGetOperator = clientHelper.BuildApiCall<GetOperatorRequest, Operator>("GetOperator", grpcClient.GetOperatorAsync, grpcClient.GetOperator, effectiveSettings.GetOperatorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetOperator);
            Modify_GetOperatorApiCall(ref _callGetOperator);
            _callCreateOperator = clientHelper.BuildApiCall<CreateOperatorRequest, lro::Operation>("CreateOperator", grpcClient.CreateOperatorAsync, grpcClient.CreateOperator, effectiveSettings.CreateOperatorSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateOperator);
            Modify_CreateOperatorApiCall(ref _callCreateOperator);
            _callUpdateOperator = clientHelper.BuildApiCall<UpdateOperatorRequest, lro::Operation>("UpdateOperator", grpcClient.UpdateOperatorAsync, grpcClient.UpdateOperator, effectiveSettings.UpdateOperatorSettings).WithGoogleRequestParam("operator.name", request => request.Operator?.Name);
            Modify_ApiCall(ref _callUpdateOperator);
            Modify_UpdateOperatorApiCall(ref _callUpdateOperator);
            _callDeleteOperator = clientHelper.BuildApiCall<DeleteOperatorRequest, lro::Operation>("DeleteOperator", grpcClient.DeleteOperatorAsync, grpcClient.DeleteOperator, effectiveSettings.DeleteOperatorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteOperator);
            Modify_DeleteOperatorApiCall(ref _callDeleteOperator);
            _callListAnalyses = clientHelper.BuildApiCall<ListAnalysesRequest, ListAnalysesResponse>("ListAnalyses", grpcClient.ListAnalysesAsync, grpcClient.ListAnalyses, effectiveSettings.ListAnalysesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAnalyses);
            Modify_ListAnalysesApiCall(ref _callListAnalyses);
            _callGetAnalysis = clientHelper.BuildApiCall<GetAnalysisRequest, Analysis>("GetAnalysis", grpcClient.GetAnalysisAsync, grpcClient.GetAnalysis, effectiveSettings.GetAnalysisSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAnalysis);
            Modify_GetAnalysisApiCall(ref _callGetAnalysis);
            _callCreateAnalysis = clientHelper.BuildApiCall<CreateAnalysisRequest, lro::Operation>("CreateAnalysis", grpcClient.CreateAnalysisAsync, grpcClient.CreateAnalysis, effectiveSettings.CreateAnalysisSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAnalysis);
            Modify_CreateAnalysisApiCall(ref _callCreateAnalysis);
            _callUpdateAnalysis = clientHelper.BuildApiCall<UpdateAnalysisRequest, lro::Operation>("UpdateAnalysis", grpcClient.UpdateAnalysisAsync, grpcClient.UpdateAnalysis, effectiveSettings.UpdateAnalysisSettings).WithGoogleRequestParam("analysis.name", request => request.Analysis?.Name);
            Modify_ApiCall(ref _callUpdateAnalysis);
            Modify_UpdateAnalysisApiCall(ref _callUpdateAnalysis);
            _callDeleteAnalysis = clientHelper.BuildApiCall<DeleteAnalysisRequest, lro::Operation>("DeleteAnalysis", grpcClient.DeleteAnalysisAsync, grpcClient.DeleteAnalysis, effectiveSettings.DeleteAnalysisSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAnalysis);
            Modify_DeleteAnalysisApiCall(ref _callDeleteAnalysis);
            _callListProcesses = clientHelper.BuildApiCall<ListProcessesRequest, ListProcessesResponse>("ListProcesses", grpcClient.ListProcessesAsync, grpcClient.ListProcesses, effectiveSettings.ListProcessesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListProcesses);
            Modify_ListProcessesApiCall(ref _callListProcesses);
            _callGetProcess = clientHelper.BuildApiCall<GetProcessRequest, Process>("GetProcess", grpcClient.GetProcessAsync, grpcClient.GetProcess, effectiveSettings.GetProcessSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetProcess);
            Modify_GetProcessApiCall(ref _callGetProcess);
            _callCreateProcess = clientHelper.BuildApiCall<CreateProcessRequest, lro::Operation>("CreateProcess", grpcClient.CreateProcessAsync, grpcClient.CreateProcess, effectiveSettings.CreateProcessSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateProcess);
            Modify_CreateProcessApiCall(ref _callCreateProcess);
            _callUpdateProcess = clientHelper.BuildApiCall<UpdateProcessRequest, lro::Operation>("UpdateProcess", grpcClient.UpdateProcessAsync, grpcClient.UpdateProcess, effectiveSettings.UpdateProcessSettings).WithGoogleRequestParam("process.name", request => request.Process?.Name);
            Modify_ApiCall(ref _callUpdateProcess);
            Modify_UpdateProcessApiCall(ref _callUpdateProcess);
            _callDeleteProcess = clientHelper.BuildApiCall<DeleteProcessRequest, lro::Operation>("DeleteProcess", grpcClient.DeleteProcessAsync, grpcClient.DeleteProcess, effectiveSettings.DeleteProcessSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteProcess);
            Modify_DeleteProcessApiCall(ref _callDeleteProcess);
            _callBatchRunProcess = clientHelper.BuildApiCall<BatchRunProcessRequest, lro::Operation>("BatchRunProcess", grpcClient.BatchRunProcessAsync, grpcClient.BatchRunProcess, effectiveSettings.BatchRunProcessSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callBatchRunProcess);
            Modify_BatchRunProcessApiCall(ref _callBatchRunProcess);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListPublicOperatorsApiCall(ref gaxgrpc::ApiCall<ListPublicOperatorsRequest, ListPublicOperatorsResponse> call);

        partial void Modify_ResolveOperatorInfoApiCall(ref gaxgrpc::ApiCall<ResolveOperatorInfoRequest, ResolveOperatorInfoResponse> call);

        partial void Modify_ListOperatorsApiCall(ref gaxgrpc::ApiCall<ListOperatorsRequest, ListOperatorsResponse> call);

        partial void Modify_GetOperatorApiCall(ref gaxgrpc::ApiCall<GetOperatorRequest, Operator> call);

        partial void Modify_CreateOperatorApiCall(ref gaxgrpc::ApiCall<CreateOperatorRequest, lro::Operation> call);

        partial void Modify_UpdateOperatorApiCall(ref gaxgrpc::ApiCall<UpdateOperatorRequest, lro::Operation> call);

        partial void Modify_DeleteOperatorApiCall(ref gaxgrpc::ApiCall<DeleteOperatorRequest, lro::Operation> call);

        partial void Modify_ListAnalysesApiCall(ref gaxgrpc::ApiCall<ListAnalysesRequest, ListAnalysesResponse> call);

        partial void Modify_GetAnalysisApiCall(ref gaxgrpc::ApiCall<GetAnalysisRequest, Analysis> call);

        partial void Modify_CreateAnalysisApiCall(ref gaxgrpc::ApiCall<CreateAnalysisRequest, lro::Operation> call);

        partial void Modify_UpdateAnalysisApiCall(ref gaxgrpc::ApiCall<UpdateAnalysisRequest, lro::Operation> call);

        partial void Modify_DeleteAnalysisApiCall(ref gaxgrpc::ApiCall<DeleteAnalysisRequest, lro::Operation> call);

        partial void Modify_ListProcessesApiCall(ref gaxgrpc::ApiCall<ListProcessesRequest, ListProcessesResponse> call);

        partial void Modify_GetProcessApiCall(ref gaxgrpc::ApiCall<GetProcessRequest, Process> call);

        partial void Modify_CreateProcessApiCall(ref gaxgrpc::ApiCall<CreateProcessRequest, lro::Operation> call);

        partial void Modify_UpdateProcessApiCall(ref gaxgrpc::ApiCall<UpdateProcessRequest, lro::Operation> call);

        partial void Modify_DeleteProcessApiCall(ref gaxgrpc::ApiCall<DeleteProcessRequest, lro::Operation> call);

        partial void Modify_BatchRunProcessApiCall(ref gaxgrpc::ApiCall<BatchRunProcessRequest, lro::Operation> call);

        partial void OnConstruction(LiveVideoAnalytics.LiveVideoAnalyticsClient grpcClient, LiveVideoAnalyticsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC LiveVideoAnalytics client</summary>
        public override LiveVideoAnalytics.LiveVideoAnalyticsClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListPublicOperatorsRequest(ref ListPublicOperatorsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResolveOperatorInfoRequest(ref ResolveOperatorInfoRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListOperatorsRequest(ref ListOperatorsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetOperatorRequest(ref GetOperatorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateOperatorRequest(ref CreateOperatorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateOperatorRequest(ref UpdateOperatorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteOperatorRequest(ref DeleteOperatorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAnalysesRequest(ref ListAnalysesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAnalysisRequest(ref GetAnalysisRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAnalysisRequest(ref CreateAnalysisRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAnalysisRequest(ref UpdateAnalysisRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAnalysisRequest(ref DeleteAnalysisRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListProcessesRequest(ref ListProcessesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetProcessRequest(ref GetProcessRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateProcessRequest(ref CreateProcessRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateProcessRequest(ref UpdateProcessRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteProcessRequest(ref DeleteProcessRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchRunProcessRequest(ref BatchRunProcessRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// ListPublicOperators returns all the operators in public registry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Operator"/> resources.</returns>
        public override gax::PagedEnumerable<ListPublicOperatorsResponse, Operator> ListPublicOperators(ListPublicOperatorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPublicOperatorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPublicOperatorsRequest, ListPublicOperatorsResponse, Operator>(_callListPublicOperators, request, callSettings);
        }

        /// <summary>
        /// ListPublicOperators returns all the operators in public registry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Operator"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPublicOperatorsResponse, Operator> ListPublicOperatorsAsync(ListPublicOperatorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPublicOperatorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPublicOperatorsRequest, ListPublicOperatorsResponse, Operator>(_callListPublicOperators, request, callSettings);
        }

        /// <summary>
        /// ResolveOperatorInfo returns the operator information based on the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ResolveOperatorInfoResponse ResolveOperatorInfo(ResolveOperatorInfoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResolveOperatorInfoRequest(ref request, ref callSettings);
            return _callResolveOperatorInfo.Sync(request, callSettings);
        }

        /// <summary>
        /// ResolveOperatorInfo returns the operator information based on the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ResolveOperatorInfoResponse> ResolveOperatorInfoAsync(ResolveOperatorInfoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResolveOperatorInfoRequest(ref request, ref callSettings);
            return _callResolveOperatorInfo.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Operators in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Operator"/> resources.</returns>
        public override gax::PagedEnumerable<ListOperatorsResponse, Operator> ListOperators(ListOperatorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOperatorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListOperatorsRequest, ListOperatorsResponse, Operator>(_callListOperators, request, callSettings);
        }

        /// <summary>
        /// Lists Operators in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Operator"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListOperatorsResponse, Operator> ListOperatorsAsync(ListOperatorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOperatorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListOperatorsRequest, ListOperatorsResponse, Operator>(_callListOperators, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Operator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Operator GetOperator(GetOperatorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOperatorRequest(ref request, ref callSettings);
            return _callGetOperator.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Operator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Operator> GetOperatorAsync(GetOperatorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOperatorRequest(ref request, ref callSettings);
            return _callGetOperator.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateOperator</c>.</summary>
        public override lro::OperationsClient CreateOperatorOperationsClient { get; }

        /// <summary>
        /// Creates a new Operator in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operator, OperationMetadata> CreateOperator(CreateOperatorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateOperatorRequest(ref request, ref callSettings);
            return new lro::Operation<Operator, OperationMetadata>(_callCreateOperator.Sync(request, callSettings), CreateOperatorOperationsClient);
        }

        /// <summary>
        /// Creates a new Operator in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operator, OperationMetadata>> CreateOperatorAsync(CreateOperatorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateOperatorRequest(ref request, ref callSettings);
            return new lro::Operation<Operator, OperationMetadata>(await _callCreateOperator.Async(request, callSettings).ConfigureAwait(false), CreateOperatorOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateOperator</c>.</summary>
        public override lro::OperationsClient UpdateOperatorOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single Operator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Operator, OperationMetadata> UpdateOperator(UpdateOperatorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateOperatorRequest(ref request, ref callSettings);
            return new lro::Operation<Operator, OperationMetadata>(_callUpdateOperator.Sync(request, callSettings), UpdateOperatorOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single Operator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Operator, OperationMetadata>> UpdateOperatorAsync(UpdateOperatorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateOperatorRequest(ref request, ref callSettings);
            return new lro::Operation<Operator, OperationMetadata>(await _callUpdateOperator.Async(request, callSettings).ConfigureAwait(false), UpdateOperatorOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteOperator</c>.</summary>
        public override lro::OperationsClient DeleteOperatorOperationsClient { get; }

        /// <summary>
        /// Deletes a single Operator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteOperator(DeleteOperatorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteOperatorRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteOperator.Sync(request, callSettings), DeleteOperatorOperationsClient);
        }

        /// <summary>
        /// Deletes a single Operator.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteOperatorAsync(DeleteOperatorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteOperatorRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteOperator.Async(request, callSettings).ConfigureAwait(false), DeleteOperatorOperationsClient);
        }

        /// <summary>
        /// Lists Analyses in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Analysis"/> resources.</returns>
        public override gax::PagedEnumerable<ListAnalysesResponse, Analysis> ListAnalyses(ListAnalysesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAnalysesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAnalysesRequest, ListAnalysesResponse, Analysis>(_callListAnalyses, request, callSettings);
        }

        /// <summary>
        /// Lists Analyses in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Analysis"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAnalysesResponse, Analysis> ListAnalysesAsync(ListAnalysesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAnalysesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAnalysesRequest, ListAnalysesResponse, Analysis>(_callListAnalyses, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Analysis.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Analysis GetAnalysis(GetAnalysisRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAnalysisRequest(ref request, ref callSettings);
            return _callGetAnalysis.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Analysis.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Analysis> GetAnalysisAsync(GetAnalysisRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAnalysisRequest(ref request, ref callSettings);
            return _callGetAnalysis.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateAnalysis</c>.</summary>
        public override lro::OperationsClient CreateAnalysisOperationsClient { get; }

        /// <summary>
        /// Creates a new Analysis in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Analysis, OperationMetadata> CreateAnalysis(CreateAnalysisRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAnalysisRequest(ref request, ref callSettings);
            return new lro::Operation<Analysis, OperationMetadata>(_callCreateAnalysis.Sync(request, callSettings), CreateAnalysisOperationsClient);
        }

        /// <summary>
        /// Creates a new Analysis in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Analysis, OperationMetadata>> CreateAnalysisAsync(CreateAnalysisRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAnalysisRequest(ref request, ref callSettings);
            return new lro::Operation<Analysis, OperationMetadata>(await _callCreateAnalysis.Async(request, callSettings).ConfigureAwait(false), CreateAnalysisOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateAnalysis</c>.</summary>
        public override lro::OperationsClient UpdateAnalysisOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single Analysis.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Analysis, OperationMetadata> UpdateAnalysis(UpdateAnalysisRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAnalysisRequest(ref request, ref callSettings);
            return new lro::Operation<Analysis, OperationMetadata>(_callUpdateAnalysis.Sync(request, callSettings), UpdateAnalysisOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single Analysis.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Analysis, OperationMetadata>> UpdateAnalysisAsync(UpdateAnalysisRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAnalysisRequest(ref request, ref callSettings);
            return new lro::Operation<Analysis, OperationMetadata>(await _callUpdateAnalysis.Async(request, callSettings).ConfigureAwait(false), UpdateAnalysisOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteAnalysis</c>.</summary>
        public override lro::OperationsClient DeleteAnalysisOperationsClient { get; }

        /// <summary>
        /// Deletes a single Analysis.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteAnalysis(DeleteAnalysisRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAnalysisRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteAnalysis.Sync(request, callSettings), DeleteAnalysisOperationsClient);
        }

        /// <summary>
        /// Deletes a single Analysis.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAnalysisAsync(DeleteAnalysisRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAnalysisRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteAnalysis.Async(request, callSettings).ConfigureAwait(false), DeleteAnalysisOperationsClient);
        }

        /// <summary>
        /// Lists Processes in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Process"/> resources.</returns>
        public override gax::PagedEnumerable<ListProcessesResponse, Process> ListProcesses(ListProcessesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProcessesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListProcessesRequest, ListProcessesResponse, Process>(_callListProcesses, request, callSettings);
        }

        /// <summary>
        /// Lists Processes in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Process"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListProcessesResponse, Process> ListProcessesAsync(ListProcessesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProcessesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListProcessesRequest, ListProcessesResponse, Process>(_callListProcesses, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Process.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Process GetProcess(GetProcessRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProcessRequest(ref request, ref callSettings);
            return _callGetProcess.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Process.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Process> GetProcessAsync(GetProcessRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProcessRequest(ref request, ref callSettings);
            return _callGetProcess.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateProcess</c>.</summary>
        public override lro::OperationsClient CreateProcessOperationsClient { get; }

        /// <summary>
        /// Creates a new Process in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Process, OperationMetadata> CreateProcess(CreateProcessRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateProcessRequest(ref request, ref callSettings);
            return new lro::Operation<Process, OperationMetadata>(_callCreateProcess.Sync(request, callSettings), CreateProcessOperationsClient);
        }

        /// <summary>
        /// Creates a new Process in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Process, OperationMetadata>> CreateProcessAsync(CreateProcessRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateProcessRequest(ref request, ref callSettings);
            return new lro::Operation<Process, OperationMetadata>(await _callCreateProcess.Async(request, callSettings).ConfigureAwait(false), CreateProcessOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateProcess</c>.</summary>
        public override lro::OperationsClient UpdateProcessOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single Process.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Process, OperationMetadata> UpdateProcess(UpdateProcessRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateProcessRequest(ref request, ref callSettings);
            return new lro::Operation<Process, OperationMetadata>(_callUpdateProcess.Sync(request, callSettings), UpdateProcessOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single Process.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Process, OperationMetadata>> UpdateProcessAsync(UpdateProcessRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateProcessRequest(ref request, ref callSettings);
            return new lro::Operation<Process, OperationMetadata>(await _callUpdateProcess.Async(request, callSettings).ConfigureAwait(false), UpdateProcessOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteProcess</c>.</summary>
        public override lro::OperationsClient DeleteProcessOperationsClient { get; }

        /// <summary>
        /// Deletes a single Process.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteProcess(DeleteProcessRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteProcessRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteProcess.Sync(request, callSettings), DeleteProcessOperationsClient);
        }

        /// <summary>
        /// Deletes a single Process.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteProcessAsync(DeleteProcessRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteProcessRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteProcess.Async(request, callSettings).ConfigureAwait(false), DeleteProcessOperationsClient);
        }

        /// <summary>The long-running operations client for <c>BatchRunProcess</c>.</summary>
        public override lro::OperationsClient BatchRunProcessOperationsClient { get; }

        /// <summary>
        /// Run all of the processes to "completion". Max time for each process is
        /// the LRO time limit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BatchRunProcessResponse, OperationMetadata> BatchRunProcess(BatchRunProcessRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchRunProcessRequest(ref request, ref callSettings);
            return new lro::Operation<BatchRunProcessResponse, OperationMetadata>(_callBatchRunProcess.Sync(request, callSettings), BatchRunProcessOperationsClient);
        }

        /// <summary>
        /// Run all of the processes to "completion". Max time for each process is
        /// the LRO time limit.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BatchRunProcessResponse, OperationMetadata>> BatchRunProcessAsync(BatchRunProcessRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchRunProcessRequest(ref request, ref callSettings);
            return new lro::Operation<BatchRunProcessResponse, OperationMetadata>(await _callBatchRunProcess.Async(request, callSettings).ConfigureAwait(false), BatchRunProcessOperationsClient);
        }
    }

    public partial class ListPublicOperatorsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListOperatorsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAnalysesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListProcessesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPublicOperatorsResponse : gaxgrpc::IPageResponse<Operator>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Operator> GetEnumerator() => Operators.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListOperatorsResponse : gaxgrpc::IPageResponse<Operator>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Operator> GetEnumerator() => Operators.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAnalysesResponse : gaxgrpc::IPageResponse<Analysis>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Analysis> GetEnumerator() => Analyses.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListProcessesResponse : gaxgrpc::IPageResponse<Process>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Process> GetEnumerator() => Processes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class LiveVideoAnalytics
    {
        public partial class LiveVideoAnalyticsClient
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

    public static partial class LiveVideoAnalytics
    {
        public partial class LiveVideoAnalyticsClient
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
