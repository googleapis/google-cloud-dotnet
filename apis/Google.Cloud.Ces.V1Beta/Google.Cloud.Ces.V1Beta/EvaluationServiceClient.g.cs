// Copyright 2026 Google LLC
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

namespace Google.Cloud.Ces.V1Beta
{
    /// <summary>Settings for <see cref="EvaluationServiceClient"/> instances.</summary>
    public sealed partial class EvaluationServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="EvaluationServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="EvaluationServiceSettings"/>.</returns>
        public static EvaluationServiceSettings GetDefault() => new EvaluationServiceSettings();

        /// <summary>Constructs a new <see cref="EvaluationServiceSettings"/> object with default settings.</summary>
        public EvaluationServiceSettings()
        {
        }

        private EvaluationServiceSettings(EvaluationServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            RunEvaluationSettings = existing.RunEvaluationSettings;
            RunEvaluationOperationsSettings = existing.RunEvaluationOperationsSettings.Clone();
            UploadEvaluationAudioSettings = existing.UploadEvaluationAudioSettings;
            CreateEvaluationSettings = existing.CreateEvaluationSettings;
            GenerateEvaluationSettings = existing.GenerateEvaluationSettings;
            GenerateEvaluationOperationsSettings = existing.GenerateEvaluationOperationsSettings.Clone();
            ImportEvaluationsSettings = existing.ImportEvaluationsSettings;
            ImportEvaluationsOperationsSettings = existing.ImportEvaluationsOperationsSettings.Clone();
            CreateEvaluationDatasetSettings = existing.CreateEvaluationDatasetSettings;
            UpdateEvaluationSettings = existing.UpdateEvaluationSettings;
            UpdateEvaluationDatasetSettings = existing.UpdateEvaluationDatasetSettings;
            DeleteEvaluationSettings = existing.DeleteEvaluationSettings;
            DeleteEvaluationResultSettings = existing.DeleteEvaluationResultSettings;
            DeleteEvaluationDatasetSettings = existing.DeleteEvaluationDatasetSettings;
            DeleteEvaluationRunSettings = existing.DeleteEvaluationRunSettings;
            DeleteEvaluationRunOperationsSettings = existing.DeleteEvaluationRunOperationsSettings.Clone();
            GetEvaluationSettings = existing.GetEvaluationSettings;
            GetEvaluationResultSettings = existing.GetEvaluationResultSettings;
            GetEvaluationDatasetSettings = existing.GetEvaluationDatasetSettings;
            GetEvaluationRunSettings = existing.GetEvaluationRunSettings;
            ListEvaluationsSettings = existing.ListEvaluationsSettings;
            ListEvaluationResultsSettings = existing.ListEvaluationResultsSettings;
            ListEvaluationDatasetsSettings = existing.ListEvaluationDatasetsSettings;
            ListEvaluationRunsSettings = existing.ListEvaluationRunsSettings;
            ListEvaluationExpectationsSettings = existing.ListEvaluationExpectationsSettings;
            GetEvaluationExpectationSettings = existing.GetEvaluationExpectationSettings;
            CreateEvaluationExpectationSettings = existing.CreateEvaluationExpectationSettings;
            UpdateEvaluationExpectationSettings = existing.UpdateEvaluationExpectationSettings;
            DeleteEvaluationExpectationSettings = existing.DeleteEvaluationExpectationSettings;
            CreateScheduledEvaluationRunSettings = existing.CreateScheduledEvaluationRunSettings;
            GetScheduledEvaluationRunSettings = existing.GetScheduledEvaluationRunSettings;
            ListScheduledEvaluationRunsSettings = existing.ListScheduledEvaluationRunsSettings;
            UpdateScheduledEvaluationRunSettings = existing.UpdateScheduledEvaluationRunSettings;
            DeleteScheduledEvaluationRunSettings = existing.DeleteScheduledEvaluationRunSettings;
            TestPersonaVoiceSettings = existing.TestPersonaVoiceSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(EvaluationServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EvaluationServiceClient.RunEvaluation</c> and <c>EvaluationServiceClient.RunEvaluationAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RunEvaluationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EvaluationServiceClient.RunEvaluation</c> and
        /// <c>EvaluationServiceClient.RunEvaluationAsync</c>.
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
        public lro::OperationsSettings RunEvaluationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EvaluationServiceClient.UploadEvaluationAudio</c> and
        /// <c>EvaluationServiceClient.UploadEvaluationAudioAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UploadEvaluationAudioSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EvaluationServiceClient.CreateEvaluation</c> and <c>EvaluationServiceClient.CreateEvaluationAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateEvaluationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EvaluationServiceClient.GenerateEvaluation</c> and <c>EvaluationServiceClient.GenerateEvaluationAsync</c>
        /// .
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateEvaluationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EvaluationServiceClient.GenerateEvaluation</c> and
        /// <c>EvaluationServiceClient.GenerateEvaluationAsync</c>.
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
        public lro::OperationsSettings GenerateEvaluationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EvaluationServiceClient.ImportEvaluations</c> and <c>EvaluationServiceClient.ImportEvaluationsAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ImportEvaluationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EvaluationServiceClient.ImportEvaluations</c> and
        /// <c>EvaluationServiceClient.ImportEvaluationsAsync</c>.
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
        public lro::OperationsSettings ImportEvaluationsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EvaluationServiceClient.CreateEvaluationDataset</c> and
        /// <c>EvaluationServiceClient.CreateEvaluationDatasetAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateEvaluationDatasetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EvaluationServiceClient.UpdateEvaluation</c> and <c>EvaluationServiceClient.UpdateEvaluationAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateEvaluationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EvaluationServiceClient.UpdateEvaluationDataset</c> and
        /// <c>EvaluationServiceClient.UpdateEvaluationDatasetAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateEvaluationDatasetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EvaluationServiceClient.DeleteEvaluation</c> and <c>EvaluationServiceClient.DeleteEvaluationAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteEvaluationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EvaluationServiceClient.DeleteEvaluationResult</c> and
        /// <c>EvaluationServiceClient.DeleteEvaluationResultAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteEvaluationResultSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EvaluationServiceClient.DeleteEvaluationDataset</c> and
        /// <c>EvaluationServiceClient.DeleteEvaluationDatasetAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteEvaluationDatasetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EvaluationServiceClient.DeleteEvaluationRun</c> and <c>EvaluationServiceClient.DeleteEvaluationRunAsync</c>
        /// .
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteEvaluationRunSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>EvaluationServiceClient.DeleteEvaluationRun</c> and
        /// <c>EvaluationServiceClient.DeleteEvaluationRunAsync</c>.
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
        public lro::OperationsSettings DeleteEvaluationRunOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EvaluationServiceClient.GetEvaluation</c> and <c>EvaluationServiceClient.GetEvaluationAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEvaluationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EvaluationServiceClient.GetEvaluationResult</c> and <c>EvaluationServiceClient.GetEvaluationResultAsync</c>
        /// .
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEvaluationResultSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EvaluationServiceClient.GetEvaluationDataset</c> and <c>EvaluationServiceClient.GetEvaluationDatasetAsync</c>
        /// .
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEvaluationDatasetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EvaluationServiceClient.GetEvaluationRun</c> and <c>EvaluationServiceClient.GetEvaluationRunAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEvaluationRunSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EvaluationServiceClient.ListEvaluations</c> and <c>EvaluationServiceClient.ListEvaluationsAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEvaluationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EvaluationServiceClient.ListEvaluationResults</c> and
        /// <c>EvaluationServiceClient.ListEvaluationResultsAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEvaluationResultsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EvaluationServiceClient.ListEvaluationDatasets</c> and
        /// <c>EvaluationServiceClient.ListEvaluationDatasetsAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEvaluationDatasetsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EvaluationServiceClient.ListEvaluationRuns</c> and <c>EvaluationServiceClient.ListEvaluationRunsAsync</c>
        /// .
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEvaluationRunsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EvaluationServiceClient.ListEvaluationExpectations</c> and
        /// <c>EvaluationServiceClient.ListEvaluationExpectationsAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEvaluationExpectationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EvaluationServiceClient.GetEvaluationExpectation</c> and
        /// <c>EvaluationServiceClient.GetEvaluationExpectationAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEvaluationExpectationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EvaluationServiceClient.CreateEvaluationExpectation</c> and
        /// <c>EvaluationServiceClient.CreateEvaluationExpectationAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateEvaluationExpectationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EvaluationServiceClient.UpdateEvaluationExpectation</c> and
        /// <c>EvaluationServiceClient.UpdateEvaluationExpectationAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateEvaluationExpectationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EvaluationServiceClient.DeleteEvaluationExpectation</c> and
        /// <c>EvaluationServiceClient.DeleteEvaluationExpectationAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteEvaluationExpectationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EvaluationServiceClient.CreateScheduledEvaluationRun</c> and
        /// <c>EvaluationServiceClient.CreateScheduledEvaluationRunAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateScheduledEvaluationRunSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EvaluationServiceClient.GetScheduledEvaluationRun</c> and
        /// <c>EvaluationServiceClient.GetScheduledEvaluationRunAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetScheduledEvaluationRunSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EvaluationServiceClient.ListScheduledEvaluationRuns</c> and
        /// <c>EvaluationServiceClient.ListScheduledEvaluationRunsAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListScheduledEvaluationRunsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EvaluationServiceClient.UpdateScheduledEvaluationRun</c> and
        /// <c>EvaluationServiceClient.UpdateScheduledEvaluationRunAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateScheduledEvaluationRunSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EvaluationServiceClient.DeleteScheduledEvaluationRun</c> and
        /// <c>EvaluationServiceClient.DeleteScheduledEvaluationRunAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteScheduledEvaluationRunSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>EvaluationServiceClient.TestPersonaVoice</c> and <c>EvaluationServiceClient.TestPersonaVoiceAsync</c>.
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TestPersonaVoiceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="EvaluationServiceSettings"/> object.</returns>
        public EvaluationServiceSettings Clone() => new EvaluationServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="EvaluationServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class EvaluationServiceClientBuilder : gaxgrpc::ClientBuilderBase<EvaluationServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public EvaluationServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public EvaluationServiceClientBuilder() : base(EvaluationServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref EvaluationServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<EvaluationServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override EvaluationServiceClient Build()
        {
            EvaluationServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<EvaluationServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<EvaluationServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private EvaluationServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return EvaluationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<EvaluationServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return EvaluationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => EvaluationServiceClient.ChannelPool;
    }

    /// <summary>EvaluationService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// EvaluationService exposes methods to perform evaluation for the CES app.
    /// </remarks>
    public abstract partial class EvaluationServiceClient
    {
        /// <summary>
        /// The default endpoint for the EvaluationService service, which is a host of "ces.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "ces.googleapis.com:443";

        /// <summary>The default EvaluationService scopes.</summary>
        /// <remarks>
        /// The default EvaluationService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/ces</description></item>
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/ces",
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(EvaluationService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="EvaluationServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="EvaluationServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="EvaluationServiceClient"/>.</returns>
        public static stt::Task<EvaluationServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new EvaluationServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="EvaluationServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="EvaluationServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="EvaluationServiceClient"/>.</returns>
        public static EvaluationServiceClient Create() => new EvaluationServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="EvaluationServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="EvaluationServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="EvaluationServiceClient"/>.</returns>
        internal static EvaluationServiceClient Create(grpccore::CallInvoker callInvoker, EvaluationServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            EvaluationService.EvaluationServiceClient grpcClient = new EvaluationService.EvaluationServiceClient(callInvoker);
            return new EvaluationServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC EvaluationService client</summary>
        public virtual EvaluationService.EvaluationServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Runs an evaluation of the app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RunEvaluationResponse, RunEvaluationOperationMetadata> RunEvaluation(RunEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Runs an evaluation of the app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RunEvaluationResponse, RunEvaluationOperationMetadata>> RunEvaluationAsync(RunEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Runs an evaluation of the app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RunEvaluationResponse, RunEvaluationOperationMetadata>> RunEvaluationAsync(RunEvaluationRequest request, st::CancellationToken cancellationToken) =>
            RunEvaluationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RunEvaluation</c>.</summary>
        public virtual lro::OperationsClient RunEvaluationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RunEvaluation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<RunEvaluationResponse, RunEvaluationOperationMetadata> PollOnceRunEvaluation(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RunEvaluationResponse, RunEvaluationOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RunEvaluationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RunEvaluation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<RunEvaluationResponse, RunEvaluationOperationMetadata>> PollOnceRunEvaluationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RunEvaluationResponse, RunEvaluationOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RunEvaluationOperationsClient, callSettings);

        /// <summary>
        /// Runs an evaluation of the app.
        /// </summary>
        /// <param name="app">
        /// Required. The app to evaluate.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RunEvaluationResponse, RunEvaluationOperationMetadata> RunEvaluation(string app, gaxgrpc::CallSettings callSettings = null) =>
            RunEvaluation(new RunEvaluationRequest
            {
                App = gax::GaxPreconditions.CheckNotNullOrEmpty(app, nameof(app)),
            }, callSettings);

        /// <summary>
        /// Runs an evaluation of the app.
        /// </summary>
        /// <param name="app">
        /// Required. The app to evaluate.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RunEvaluationResponse, RunEvaluationOperationMetadata>> RunEvaluationAsync(string app, gaxgrpc::CallSettings callSettings = null) =>
            RunEvaluationAsync(new RunEvaluationRequest
            {
                App = gax::GaxPreconditions.CheckNotNullOrEmpty(app, nameof(app)),
            }, callSettings);

        /// <summary>
        /// Runs an evaluation of the app.
        /// </summary>
        /// <param name="app">
        /// Required. The app to evaluate.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RunEvaluationResponse, RunEvaluationOperationMetadata>> RunEvaluationAsync(string app, st::CancellationToken cancellationToken) =>
            RunEvaluationAsync(app, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Runs an evaluation of the app.
        /// </summary>
        /// <param name="app">
        /// Required. The app to evaluate.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RunEvaluationResponse, RunEvaluationOperationMetadata> RunEvaluation(AppName app, gaxgrpc::CallSettings callSettings = null) =>
            RunEvaluation(new RunEvaluationRequest
            {
                AppAsAppName = gax::GaxPreconditions.CheckNotNull(app, nameof(app)),
            }, callSettings);

        /// <summary>
        /// Runs an evaluation of the app.
        /// </summary>
        /// <param name="app">
        /// Required. The app to evaluate.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RunEvaluationResponse, RunEvaluationOperationMetadata>> RunEvaluationAsync(AppName app, gaxgrpc::CallSettings callSettings = null) =>
            RunEvaluationAsync(new RunEvaluationRequest
            {
                AppAsAppName = gax::GaxPreconditions.CheckNotNull(app, nameof(app)),
            }, callSettings);

        /// <summary>
        /// Runs an evaluation of the app.
        /// </summary>
        /// <param name="app">
        /// Required. The app to evaluate.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RunEvaluationResponse, RunEvaluationOperationMetadata>> RunEvaluationAsync(AppName app, st::CancellationToken cancellationToken) =>
            RunEvaluationAsync(app, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Uploads audio for use in Golden Evaluations. Stores the audio in the Cloud
        /// Storage bucket defined in
        /// 'App.logging_settings.evaluation_audio_recording_config.gcs_bucket' and
        /// returns a transcript.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UploadEvaluationAudioResponse UploadEvaluationAudio(UploadEvaluationAudioRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Uploads audio for use in Golden Evaluations. Stores the audio in the Cloud
        /// Storage bucket defined in
        /// 'App.logging_settings.evaluation_audio_recording_config.gcs_bucket' and
        /// returns a transcript.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UploadEvaluationAudioResponse> UploadEvaluationAudioAsync(UploadEvaluationAudioRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Uploads audio for use in Golden Evaluations. Stores the audio in the Cloud
        /// Storage bucket defined in
        /// 'App.logging_settings.evaluation_audio_recording_config.gcs_bucket' and
        /// returns a transcript.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UploadEvaluationAudioResponse> UploadEvaluationAudioAsync(UploadEvaluationAudioRequest request, st::CancellationToken cancellationToken) =>
            UploadEvaluationAudioAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Uploads audio for use in Golden Evaluations. Stores the audio in the Cloud
        /// Storage bucket defined in
        /// 'App.logging_settings.evaluation_audio_recording_config.gcs_bucket' and
        /// returns a transcript.
        /// </summary>
        /// <param name="app">
        /// Required. The resource name of the App for which to upload the evaluation
        /// audio. Format: `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="audioContent">
        /// Required. The raw audio bytes.
        /// The format of the audio must be single-channel LINEAR16 with a sample
        /// rate of 16kHz (default InputAudioConfig).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UploadEvaluationAudioResponse UploadEvaluationAudio(string app, proto::ByteString audioContent, gaxgrpc::CallSettings callSettings = null) =>
            UploadEvaluationAudio(new UploadEvaluationAudioRequest
            {
                App = gax::GaxPreconditions.CheckNotNullOrEmpty(app, nameof(app)),
                AudioContent = gax::GaxPreconditions.CheckNotNull(audioContent, nameof(audioContent)),
            }, callSettings);

        /// <summary>
        /// Uploads audio for use in Golden Evaluations. Stores the audio in the Cloud
        /// Storage bucket defined in
        /// 'App.logging_settings.evaluation_audio_recording_config.gcs_bucket' and
        /// returns a transcript.
        /// </summary>
        /// <param name="app">
        /// Required. The resource name of the App for which to upload the evaluation
        /// audio. Format: `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="audioContent">
        /// Required. The raw audio bytes.
        /// The format of the audio must be single-channel LINEAR16 with a sample
        /// rate of 16kHz (default InputAudioConfig).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UploadEvaluationAudioResponse> UploadEvaluationAudioAsync(string app, proto::ByteString audioContent, gaxgrpc::CallSettings callSettings = null) =>
            UploadEvaluationAudioAsync(new UploadEvaluationAudioRequest
            {
                App = gax::GaxPreconditions.CheckNotNullOrEmpty(app, nameof(app)),
                AudioContent = gax::GaxPreconditions.CheckNotNull(audioContent, nameof(audioContent)),
            }, callSettings);

        /// <summary>
        /// Uploads audio for use in Golden Evaluations. Stores the audio in the Cloud
        /// Storage bucket defined in
        /// 'App.logging_settings.evaluation_audio_recording_config.gcs_bucket' and
        /// returns a transcript.
        /// </summary>
        /// <param name="app">
        /// Required. The resource name of the App for which to upload the evaluation
        /// audio. Format: `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="audioContent">
        /// Required. The raw audio bytes.
        /// The format of the audio must be single-channel LINEAR16 with a sample
        /// rate of 16kHz (default InputAudioConfig).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UploadEvaluationAudioResponse> UploadEvaluationAudioAsync(string app, proto::ByteString audioContent, st::CancellationToken cancellationToken) =>
            UploadEvaluationAudioAsync(app, audioContent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Uploads audio for use in Golden Evaluations. Stores the audio in the Cloud
        /// Storage bucket defined in
        /// 'App.logging_settings.evaluation_audio_recording_config.gcs_bucket' and
        /// returns a transcript.
        /// </summary>
        /// <param name="app">
        /// Required. The resource name of the App for which to upload the evaluation
        /// audio. Format: `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="audioContent">
        /// Required. The raw audio bytes.
        /// The format of the audio must be single-channel LINEAR16 with a sample
        /// rate of 16kHz (default InputAudioConfig).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UploadEvaluationAudioResponse UploadEvaluationAudio(AppName app, proto::ByteString audioContent, gaxgrpc::CallSettings callSettings = null) =>
            UploadEvaluationAudio(new UploadEvaluationAudioRequest
            {
                AppAsAppName = gax::GaxPreconditions.CheckNotNull(app, nameof(app)),
                AudioContent = gax::GaxPreconditions.CheckNotNull(audioContent, nameof(audioContent)),
            }, callSettings);

        /// <summary>
        /// Uploads audio for use in Golden Evaluations. Stores the audio in the Cloud
        /// Storage bucket defined in
        /// 'App.logging_settings.evaluation_audio_recording_config.gcs_bucket' and
        /// returns a transcript.
        /// </summary>
        /// <param name="app">
        /// Required. The resource name of the App for which to upload the evaluation
        /// audio. Format: `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="audioContent">
        /// Required. The raw audio bytes.
        /// The format of the audio must be single-channel LINEAR16 with a sample
        /// rate of 16kHz (default InputAudioConfig).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UploadEvaluationAudioResponse> UploadEvaluationAudioAsync(AppName app, proto::ByteString audioContent, gaxgrpc::CallSettings callSettings = null) =>
            UploadEvaluationAudioAsync(new UploadEvaluationAudioRequest
            {
                AppAsAppName = gax::GaxPreconditions.CheckNotNull(app, nameof(app)),
                AudioContent = gax::GaxPreconditions.CheckNotNull(audioContent, nameof(audioContent)),
            }, callSettings);

        /// <summary>
        /// Uploads audio for use in Golden Evaluations. Stores the audio in the Cloud
        /// Storage bucket defined in
        /// 'App.logging_settings.evaluation_audio_recording_config.gcs_bucket' and
        /// returns a transcript.
        /// </summary>
        /// <param name="app">
        /// Required. The resource name of the App for which to upload the evaluation
        /// audio. Format: `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="audioContent">
        /// Required. The raw audio bytes.
        /// The format of the audio must be single-channel LINEAR16 with a sample
        /// rate of 16kHz (default InputAudioConfig).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UploadEvaluationAudioResponse> UploadEvaluationAudioAsync(AppName app, proto::ByteString audioContent, st::CancellationToken cancellationToken) =>
            UploadEvaluationAudioAsync(app, audioContent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Evaluation CreateEvaluation(CreateEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> CreateEvaluationAsync(CreateEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> CreateEvaluationAsync(CreateEvaluationRequest request, st::CancellationToken cancellationToken) =>
            CreateEvaluationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an evaluation.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the evaluation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="evaluation">
        /// Required. The evaluation to create.
        /// </param>
        /// <param name="evaluationId">
        /// Optional. The ID to use for the evaluation, which will become the final
        /// component of the evaluation's resource name. If not provided, a unique ID
        /// will be automatically assigned for the evaluation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Evaluation CreateEvaluation(string parent, Evaluation evaluation, string evaluationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEvaluation(new CreateEvaluationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EvaluationId = evaluationId ?? "",
                Evaluation = gax::GaxPreconditions.CheckNotNull(evaluation, nameof(evaluation)),
            }, callSettings);

        /// <summary>
        /// Creates an evaluation.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the evaluation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="evaluation">
        /// Required. The evaluation to create.
        /// </param>
        /// <param name="evaluationId">
        /// Optional. The ID to use for the evaluation, which will become the final
        /// component of the evaluation's resource name. If not provided, a unique ID
        /// will be automatically assigned for the evaluation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> CreateEvaluationAsync(string parent, Evaluation evaluation, string evaluationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEvaluationAsync(new CreateEvaluationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EvaluationId = evaluationId ?? "",
                Evaluation = gax::GaxPreconditions.CheckNotNull(evaluation, nameof(evaluation)),
            }, callSettings);

        /// <summary>
        /// Creates an evaluation.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the evaluation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="evaluation">
        /// Required. The evaluation to create.
        /// </param>
        /// <param name="evaluationId">
        /// Optional. The ID to use for the evaluation, which will become the final
        /// component of the evaluation's resource name. If not provided, a unique ID
        /// will be automatically assigned for the evaluation.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> CreateEvaluationAsync(string parent, Evaluation evaluation, string evaluationId, st::CancellationToken cancellationToken) =>
            CreateEvaluationAsync(parent, evaluation, evaluationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an evaluation.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the evaluation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="evaluation">
        /// Required. The evaluation to create.
        /// </param>
        /// <param name="evaluationId">
        /// Optional. The ID to use for the evaluation, which will become the final
        /// component of the evaluation's resource name. If not provided, a unique ID
        /// will be automatically assigned for the evaluation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Evaluation CreateEvaluation(AppName parent, Evaluation evaluation, string evaluationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEvaluation(new CreateEvaluationRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EvaluationId = evaluationId ?? "",
                Evaluation = gax::GaxPreconditions.CheckNotNull(evaluation, nameof(evaluation)),
            }, callSettings);

        /// <summary>
        /// Creates an evaluation.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the evaluation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="evaluation">
        /// Required. The evaluation to create.
        /// </param>
        /// <param name="evaluationId">
        /// Optional. The ID to use for the evaluation, which will become the final
        /// component of the evaluation's resource name. If not provided, a unique ID
        /// will be automatically assigned for the evaluation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> CreateEvaluationAsync(AppName parent, Evaluation evaluation, string evaluationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEvaluationAsync(new CreateEvaluationRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EvaluationId = evaluationId ?? "",
                Evaluation = gax::GaxPreconditions.CheckNotNull(evaluation, nameof(evaluation)),
            }, callSettings);

        /// <summary>
        /// Creates an evaluation.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the evaluation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="evaluation">
        /// Required. The evaluation to create.
        /// </param>
        /// <param name="evaluationId">
        /// Optional. The ID to use for the evaluation, which will become the final
        /// component of the evaluation's resource name. If not provided, a unique ID
        /// will be automatically assigned for the evaluation.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> CreateEvaluationAsync(AppName parent, Evaluation evaluation, string evaluationId, st::CancellationToken cancellationToken) =>
            CreateEvaluationAsync(parent, evaluation, evaluationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an evaluation.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the evaluation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="evaluation">
        /// Required. The evaluation to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Evaluation CreateEvaluation(string parent, Evaluation evaluation, gaxgrpc::CallSettings callSettings = null) =>
            CreateEvaluation(new CreateEvaluationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Evaluation = gax::GaxPreconditions.CheckNotNull(evaluation, nameof(evaluation)),
            }, callSettings);

        /// <summary>
        /// Creates an evaluation.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the evaluation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="evaluation">
        /// Required. The evaluation to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> CreateEvaluationAsync(string parent, Evaluation evaluation, gaxgrpc::CallSettings callSettings = null) =>
            CreateEvaluationAsync(new CreateEvaluationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Evaluation = gax::GaxPreconditions.CheckNotNull(evaluation, nameof(evaluation)),
            }, callSettings);

        /// <summary>
        /// Creates an evaluation.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the evaluation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="evaluation">
        /// Required. The evaluation to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> CreateEvaluationAsync(string parent, Evaluation evaluation, st::CancellationToken cancellationToken) =>
            CreateEvaluationAsync(parent, evaluation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an evaluation.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the evaluation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="evaluation">
        /// Required. The evaluation to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Evaluation CreateEvaluation(AppName parent, Evaluation evaluation, gaxgrpc::CallSettings callSettings = null) =>
            CreateEvaluation(new CreateEvaluationRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Evaluation = gax::GaxPreconditions.CheckNotNull(evaluation, nameof(evaluation)),
            }, callSettings);

        /// <summary>
        /// Creates an evaluation.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the evaluation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="evaluation">
        /// Required. The evaluation to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> CreateEvaluationAsync(AppName parent, Evaluation evaluation, gaxgrpc::CallSettings callSettings = null) =>
            CreateEvaluationAsync(new CreateEvaluationRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Evaluation = gax::GaxPreconditions.CheckNotNull(evaluation, nameof(evaluation)),
            }, callSettings);

        /// <summary>
        /// Creates an evaluation.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the evaluation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="evaluation">
        /// Required. The evaluation to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> CreateEvaluationAsync(AppName parent, Evaluation evaluation, st::CancellationToken cancellationToken) =>
            CreateEvaluationAsync(parent, evaluation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a golden evaluation from a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Evaluation, GenerateEvaluationOperationMetadata> GenerateEvaluation(GenerateEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a golden evaluation from a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Evaluation, GenerateEvaluationOperationMetadata>> GenerateEvaluationAsync(GenerateEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a golden evaluation from a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Evaluation, GenerateEvaluationOperationMetadata>> GenerateEvaluationAsync(GenerateEvaluationRequest request, st::CancellationToken cancellationToken) =>
            GenerateEvaluationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>GenerateEvaluation</c>.</summary>
        public virtual lro::OperationsClient GenerateEvaluationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>GenerateEvaluation</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Evaluation, GenerateEvaluationOperationMetadata> PollOnceGenerateEvaluation(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Evaluation, GenerateEvaluationOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), GenerateEvaluationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>GenerateEvaluation</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Evaluation, GenerateEvaluationOperationMetadata>> PollOnceGenerateEvaluationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Evaluation, GenerateEvaluationOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), GenerateEvaluationOperationsClient, callSettings);

        /// <summary>
        /// Creates a golden evaluation from a conversation.
        /// </summary>
        /// <param name="conversation">
        /// Required. The conversation to create the golden evaluation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}/conversations/{conversation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Evaluation, GenerateEvaluationOperationMetadata> GenerateEvaluation(string conversation, gaxgrpc::CallSettings callSettings = null) =>
            GenerateEvaluation(new GenerateEvaluationRequest
            {
                Conversation = gax::GaxPreconditions.CheckNotNullOrEmpty(conversation, nameof(conversation)),
            }, callSettings);

        /// <summary>
        /// Creates a golden evaluation from a conversation.
        /// </summary>
        /// <param name="conversation">
        /// Required. The conversation to create the golden evaluation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}/conversations/{conversation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Evaluation, GenerateEvaluationOperationMetadata>> GenerateEvaluationAsync(string conversation, gaxgrpc::CallSettings callSettings = null) =>
            GenerateEvaluationAsync(new GenerateEvaluationRequest
            {
                Conversation = gax::GaxPreconditions.CheckNotNullOrEmpty(conversation, nameof(conversation)),
            }, callSettings);

        /// <summary>
        /// Creates a golden evaluation from a conversation.
        /// </summary>
        /// <param name="conversation">
        /// Required. The conversation to create the golden evaluation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}/conversations/{conversation}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Evaluation, GenerateEvaluationOperationMetadata>> GenerateEvaluationAsync(string conversation, st::CancellationToken cancellationToken) =>
            GenerateEvaluationAsync(conversation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a golden evaluation from a conversation.
        /// </summary>
        /// <param name="conversation">
        /// Required. The conversation to create the golden evaluation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}/conversations/{conversation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Evaluation, GenerateEvaluationOperationMetadata> GenerateEvaluation(ConversationName conversation, gaxgrpc::CallSettings callSettings = null) =>
            GenerateEvaluation(new GenerateEvaluationRequest
            {
                ConversationAsConversationName = gax::GaxPreconditions.CheckNotNull(conversation, nameof(conversation)),
            }, callSettings);

        /// <summary>
        /// Creates a golden evaluation from a conversation.
        /// </summary>
        /// <param name="conversation">
        /// Required. The conversation to create the golden evaluation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}/conversations/{conversation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Evaluation, GenerateEvaluationOperationMetadata>> GenerateEvaluationAsync(ConversationName conversation, gaxgrpc::CallSettings callSettings = null) =>
            GenerateEvaluationAsync(new GenerateEvaluationRequest
            {
                ConversationAsConversationName = gax::GaxPreconditions.CheckNotNull(conversation, nameof(conversation)),
            }, callSettings);

        /// <summary>
        /// Creates a golden evaluation from a conversation.
        /// </summary>
        /// <param name="conversation">
        /// Required. The conversation to create the golden evaluation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}/conversations/{conversation}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Evaluation, GenerateEvaluationOperationMetadata>> GenerateEvaluationAsync(ConversationName conversation, st::CancellationToken cancellationToken) =>
            GenerateEvaluationAsync(conversation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports evaluations into the app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportEvaluationsResponse, ImportEvaluationsOperationMetadata> ImportEvaluations(ImportEvaluationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports evaluations into the app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportEvaluationsResponse, ImportEvaluationsOperationMetadata>> ImportEvaluationsAsync(ImportEvaluationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports evaluations into the app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportEvaluationsResponse, ImportEvaluationsOperationMetadata>> ImportEvaluationsAsync(ImportEvaluationsRequest request, st::CancellationToken cancellationToken) =>
            ImportEvaluationsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ImportEvaluations</c>.</summary>
        public virtual lro::OperationsClient ImportEvaluationsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ImportEvaluations</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ImportEvaluationsResponse, ImportEvaluationsOperationMetadata> PollOnceImportEvaluations(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportEvaluationsResponse, ImportEvaluationsOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportEvaluationsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportEvaluations</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ImportEvaluationsResponse, ImportEvaluationsOperationMetadata>> PollOnceImportEvaluationsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportEvaluationsResponse, ImportEvaluationsOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportEvaluationsOperationsClient, callSettings);

        /// <summary>
        /// Imports evaluations into the app.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to import the evaluations into.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportEvaluationsResponse, ImportEvaluationsOperationMetadata> ImportEvaluations(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ImportEvaluations(new ImportEvaluationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Imports evaluations into the app.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to import the evaluations into.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportEvaluationsResponse, ImportEvaluationsOperationMetadata>> ImportEvaluationsAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ImportEvaluationsAsync(new ImportEvaluationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Imports evaluations into the app.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to import the evaluations into.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportEvaluationsResponse, ImportEvaluationsOperationMetadata>> ImportEvaluationsAsync(string parent, st::CancellationToken cancellationToken) =>
            ImportEvaluationsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports evaluations into the app.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to import the evaluations into.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportEvaluationsResponse, ImportEvaluationsOperationMetadata> ImportEvaluations(AppName parent, gaxgrpc::CallSettings callSettings = null) =>
            ImportEvaluations(new ImportEvaluationsRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Imports evaluations into the app.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to import the evaluations into.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportEvaluationsResponse, ImportEvaluationsOperationMetadata>> ImportEvaluationsAsync(AppName parent, gaxgrpc::CallSettings callSettings = null) =>
            ImportEvaluationsAsync(new ImportEvaluationsRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Imports evaluations into the app.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to import the evaluations into.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportEvaluationsResponse, ImportEvaluationsOperationMetadata>> ImportEvaluationsAsync(AppName parent, st::CancellationToken cancellationToken) =>
            ImportEvaluationsAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an evaluation dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EvaluationDataset CreateEvaluationDataset(CreateEvaluationDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an evaluation dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationDataset> CreateEvaluationDatasetAsync(CreateEvaluationDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an evaluation dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationDataset> CreateEvaluationDatasetAsync(CreateEvaluationDatasetRequest request, st::CancellationToken cancellationToken) =>
            CreateEvaluationDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an evaluation dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the evaluation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="evaluationDataset">
        /// Required. The evaluation dataset to create.
        /// </param>
        /// <param name="evaluationDatasetId">
        /// Optional. The ID to use for the evaluation dataset, which will become the
        /// final component of the evaluation dataset's resource name. If not provided,
        /// a unique ID will be automatically assigned for the evaluation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EvaluationDataset CreateEvaluationDataset(string parent, EvaluationDataset evaluationDataset, string evaluationDatasetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEvaluationDataset(new CreateEvaluationDatasetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EvaluationDatasetId = evaluationDatasetId ?? "",
                EvaluationDataset = gax::GaxPreconditions.CheckNotNull(evaluationDataset, nameof(evaluationDataset)),
            }, callSettings);

        /// <summary>
        /// Creates an evaluation dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the evaluation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="evaluationDataset">
        /// Required. The evaluation dataset to create.
        /// </param>
        /// <param name="evaluationDatasetId">
        /// Optional. The ID to use for the evaluation dataset, which will become the
        /// final component of the evaluation dataset's resource name. If not provided,
        /// a unique ID will be automatically assigned for the evaluation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationDataset> CreateEvaluationDatasetAsync(string parent, EvaluationDataset evaluationDataset, string evaluationDatasetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEvaluationDatasetAsync(new CreateEvaluationDatasetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EvaluationDatasetId = evaluationDatasetId ?? "",
                EvaluationDataset = gax::GaxPreconditions.CheckNotNull(evaluationDataset, nameof(evaluationDataset)),
            }, callSettings);

        /// <summary>
        /// Creates an evaluation dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the evaluation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="evaluationDataset">
        /// Required. The evaluation dataset to create.
        /// </param>
        /// <param name="evaluationDatasetId">
        /// Optional. The ID to use for the evaluation dataset, which will become the
        /// final component of the evaluation dataset's resource name. If not provided,
        /// a unique ID will be automatically assigned for the evaluation.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationDataset> CreateEvaluationDatasetAsync(string parent, EvaluationDataset evaluationDataset, string evaluationDatasetId, st::CancellationToken cancellationToken) =>
            CreateEvaluationDatasetAsync(parent, evaluationDataset, evaluationDatasetId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an evaluation dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the evaluation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="evaluationDataset">
        /// Required. The evaluation dataset to create.
        /// </param>
        /// <param name="evaluationDatasetId">
        /// Optional. The ID to use for the evaluation dataset, which will become the
        /// final component of the evaluation dataset's resource name. If not provided,
        /// a unique ID will be automatically assigned for the evaluation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EvaluationDataset CreateEvaluationDataset(AppName parent, EvaluationDataset evaluationDataset, string evaluationDatasetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEvaluationDataset(new CreateEvaluationDatasetRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EvaluationDatasetId = evaluationDatasetId ?? "",
                EvaluationDataset = gax::GaxPreconditions.CheckNotNull(evaluationDataset, nameof(evaluationDataset)),
            }, callSettings);

        /// <summary>
        /// Creates an evaluation dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the evaluation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="evaluationDataset">
        /// Required. The evaluation dataset to create.
        /// </param>
        /// <param name="evaluationDatasetId">
        /// Optional. The ID to use for the evaluation dataset, which will become the
        /// final component of the evaluation dataset's resource name. If not provided,
        /// a unique ID will be automatically assigned for the evaluation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationDataset> CreateEvaluationDatasetAsync(AppName parent, EvaluationDataset evaluationDataset, string evaluationDatasetId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEvaluationDatasetAsync(new CreateEvaluationDatasetRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EvaluationDatasetId = evaluationDatasetId ?? "",
                EvaluationDataset = gax::GaxPreconditions.CheckNotNull(evaluationDataset, nameof(evaluationDataset)),
            }, callSettings);

        /// <summary>
        /// Creates an evaluation dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the evaluation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="evaluationDataset">
        /// Required. The evaluation dataset to create.
        /// </param>
        /// <param name="evaluationDatasetId">
        /// Optional. The ID to use for the evaluation dataset, which will become the
        /// final component of the evaluation dataset's resource name. If not provided,
        /// a unique ID will be automatically assigned for the evaluation.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationDataset> CreateEvaluationDatasetAsync(AppName parent, EvaluationDataset evaluationDataset, string evaluationDatasetId, st::CancellationToken cancellationToken) =>
            CreateEvaluationDatasetAsync(parent, evaluationDataset, evaluationDatasetId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an evaluation dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the evaluation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="evaluationDataset">
        /// Required. The evaluation dataset to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EvaluationDataset CreateEvaluationDataset(string parent, EvaluationDataset evaluationDataset, gaxgrpc::CallSettings callSettings = null) =>
            CreateEvaluationDataset(new CreateEvaluationDatasetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EvaluationDataset = gax::GaxPreconditions.CheckNotNull(evaluationDataset, nameof(evaluationDataset)),
            }, callSettings);

        /// <summary>
        /// Creates an evaluation dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the evaluation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="evaluationDataset">
        /// Required. The evaluation dataset to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationDataset> CreateEvaluationDatasetAsync(string parent, EvaluationDataset evaluationDataset, gaxgrpc::CallSettings callSettings = null) =>
            CreateEvaluationDatasetAsync(new CreateEvaluationDatasetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EvaluationDataset = gax::GaxPreconditions.CheckNotNull(evaluationDataset, nameof(evaluationDataset)),
            }, callSettings);

        /// <summary>
        /// Creates an evaluation dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the evaluation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="evaluationDataset">
        /// Required. The evaluation dataset to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationDataset> CreateEvaluationDatasetAsync(string parent, EvaluationDataset evaluationDataset, st::CancellationToken cancellationToken) =>
            CreateEvaluationDatasetAsync(parent, evaluationDataset, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an evaluation dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the evaluation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="evaluationDataset">
        /// Required. The evaluation dataset to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EvaluationDataset CreateEvaluationDataset(AppName parent, EvaluationDataset evaluationDataset, gaxgrpc::CallSettings callSettings = null) =>
            CreateEvaluationDataset(new CreateEvaluationDatasetRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EvaluationDataset = gax::GaxPreconditions.CheckNotNull(evaluationDataset, nameof(evaluationDataset)),
            }, callSettings);

        /// <summary>
        /// Creates an evaluation dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the evaluation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="evaluationDataset">
        /// Required. The evaluation dataset to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationDataset> CreateEvaluationDatasetAsync(AppName parent, EvaluationDataset evaluationDataset, gaxgrpc::CallSettings callSettings = null) =>
            CreateEvaluationDatasetAsync(new CreateEvaluationDatasetRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EvaluationDataset = gax::GaxPreconditions.CheckNotNull(evaluationDataset, nameof(evaluationDataset)),
            }, callSettings);

        /// <summary>
        /// Creates an evaluation dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the evaluation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="evaluationDataset">
        /// Required. The evaluation dataset to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationDataset> CreateEvaluationDatasetAsync(AppName parent, EvaluationDataset evaluationDataset, st::CancellationToken cancellationToken) =>
            CreateEvaluationDatasetAsync(parent, evaluationDataset, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Evaluation UpdateEvaluation(UpdateEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> UpdateEvaluationAsync(UpdateEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> UpdateEvaluationAsync(UpdateEvaluationRequest request, st::CancellationToken cancellationToken) =>
            UpdateEvaluationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an evaluation.
        /// </summary>
        /// <param name="evaluation">
        /// Required. The evaluation to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to control which fields get updated. If the
        /// mask is not present, all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Evaluation UpdateEvaluation(Evaluation evaluation, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEvaluation(new UpdateEvaluationRequest
            {
                Evaluation = gax::GaxPreconditions.CheckNotNull(evaluation, nameof(evaluation)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an evaluation.
        /// </summary>
        /// <param name="evaluation">
        /// Required. The evaluation to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to control which fields get updated. If the
        /// mask is not present, all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> UpdateEvaluationAsync(Evaluation evaluation, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEvaluationAsync(new UpdateEvaluationRequest
            {
                Evaluation = gax::GaxPreconditions.CheckNotNull(evaluation, nameof(evaluation)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an evaluation.
        /// </summary>
        /// <param name="evaluation">
        /// Required. The evaluation to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to control which fields get updated. If the
        /// mask is not present, all fields will be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> UpdateEvaluationAsync(Evaluation evaluation, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateEvaluationAsync(evaluation, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an evaluation dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EvaluationDataset UpdateEvaluationDataset(UpdateEvaluationDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an evaluation dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationDataset> UpdateEvaluationDatasetAsync(UpdateEvaluationDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an evaluation dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationDataset> UpdateEvaluationDatasetAsync(UpdateEvaluationDatasetRequest request, st::CancellationToken cancellationToken) =>
            UpdateEvaluationDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an evaluation dataset.
        /// </summary>
        /// <param name="evaluationDataset">
        /// Required. The evaluation dataset to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to control which fields get updated. If the
        /// mask is not present, all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EvaluationDataset UpdateEvaluationDataset(EvaluationDataset evaluationDataset, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEvaluationDataset(new UpdateEvaluationDatasetRequest
            {
                EvaluationDataset = gax::GaxPreconditions.CheckNotNull(evaluationDataset, nameof(evaluationDataset)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an evaluation dataset.
        /// </summary>
        /// <param name="evaluationDataset">
        /// Required. The evaluation dataset to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to control which fields get updated. If the
        /// mask is not present, all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationDataset> UpdateEvaluationDatasetAsync(EvaluationDataset evaluationDataset, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEvaluationDatasetAsync(new UpdateEvaluationDatasetRequest
            {
                EvaluationDataset = gax::GaxPreconditions.CheckNotNull(evaluationDataset, nameof(evaluationDataset)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an evaluation dataset.
        /// </summary>
        /// <param name="evaluationDataset">
        /// Required. The evaluation dataset to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to control which fields get updated. If the
        /// mask is not present, all fields will be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationDataset> UpdateEvaluationDatasetAsync(EvaluationDataset evaluationDataset, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateEvaluationDatasetAsync(evaluationDataset, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEvaluation(DeleteEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEvaluationAsync(DeleteEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEvaluationAsync(DeleteEvaluationRequest request, st::CancellationToken cancellationToken) =>
            DeleteEvaluationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an evaluation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEvaluation(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEvaluation(new DeleteEvaluationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an evaluation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEvaluationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEvaluationAsync(new DeleteEvaluationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an evaluation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEvaluationAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteEvaluationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an evaluation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEvaluation(EvaluationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEvaluation(new DeleteEvaluationRequest
            {
                EvaluationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an evaluation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEvaluationAsync(EvaluationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEvaluationAsync(new DeleteEvaluationRequest
            {
                EvaluationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an evaluation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEvaluationAsync(EvaluationName name, st::CancellationToken cancellationToken) =>
            DeleteEvaluationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an evaluation result.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEvaluationResult(DeleteEvaluationResultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an evaluation result.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEvaluationResultAsync(DeleteEvaluationResultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an evaluation result.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEvaluationResultAsync(DeleteEvaluationResultRequest request, st::CancellationToken cancellationToken) =>
            DeleteEvaluationResultAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an evaluation result.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation result to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEvaluationResult(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEvaluationResult(new DeleteEvaluationResultRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an evaluation result.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation result to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEvaluationResultAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEvaluationResultAsync(new DeleteEvaluationResultRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an evaluation result.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation result to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEvaluationResultAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteEvaluationResultAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an evaluation result.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation result to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEvaluationResult(EvaluationResultName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEvaluationResult(new DeleteEvaluationResultRequest
            {
                EvaluationResultName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an evaluation result.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation result to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEvaluationResultAsync(EvaluationResultName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEvaluationResultAsync(new DeleteEvaluationResultRequest
            {
                EvaluationResultName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an evaluation result.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation result to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEvaluationResultAsync(EvaluationResultName name, st::CancellationToken cancellationToken) =>
            DeleteEvaluationResultAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an evaluation dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEvaluationDataset(DeleteEvaluationDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an evaluation dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEvaluationDatasetAsync(DeleteEvaluationDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an evaluation dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEvaluationDatasetAsync(DeleteEvaluationDatasetRequest request, st::CancellationToken cancellationToken) =>
            DeleteEvaluationDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an evaluation dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation dataset to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEvaluationDataset(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEvaluationDataset(new DeleteEvaluationDatasetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an evaluation dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation dataset to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEvaluationDatasetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEvaluationDatasetAsync(new DeleteEvaluationDatasetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an evaluation dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation dataset to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEvaluationDatasetAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteEvaluationDatasetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an evaluation dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation dataset to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEvaluationDataset(EvaluationDatasetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEvaluationDataset(new DeleteEvaluationDatasetRequest
            {
                EvaluationDatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an evaluation dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation dataset to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEvaluationDatasetAsync(EvaluationDatasetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEvaluationDatasetAsync(new DeleteEvaluationDatasetRequest
            {
                EvaluationDatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an evaluation dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation dataset to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEvaluationDatasetAsync(EvaluationDatasetName name, st::CancellationToken cancellationToken) =>
            DeleteEvaluationDatasetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an evaluation run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteEvaluationRunOperationMetadata> DeleteEvaluationRun(DeleteEvaluationRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an evaluation run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteEvaluationRunOperationMetadata>> DeleteEvaluationRunAsync(DeleteEvaluationRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an evaluation run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteEvaluationRunOperationMetadata>> DeleteEvaluationRunAsync(DeleteEvaluationRunRequest request, st::CancellationToken cancellationToken) =>
            DeleteEvaluationRunAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteEvaluationRun</c>.</summary>
        public virtual lro::OperationsClient DeleteEvaluationRunOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteEvaluationRun</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteEvaluationRunOperationMetadata> PollOnceDeleteEvaluationRun(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteEvaluationRunOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteEvaluationRunOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteEvaluationRun</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteEvaluationRunOperationMetadata>> PollOnceDeleteEvaluationRunAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteEvaluationRunOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteEvaluationRunOperationsClient, callSettings);

        /// <summary>
        /// Deletes an evaluation run.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation run to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteEvaluationRunOperationMetadata> DeleteEvaluationRun(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEvaluationRun(new DeleteEvaluationRunRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an evaluation run.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation run to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteEvaluationRunOperationMetadata>> DeleteEvaluationRunAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEvaluationRunAsync(new DeleteEvaluationRunRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an evaluation run.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation run to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteEvaluationRunOperationMetadata>> DeleteEvaluationRunAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteEvaluationRunAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an evaluation run.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation run to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteEvaluationRunOperationMetadata> DeleteEvaluationRun(EvaluationRunName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEvaluationRun(new DeleteEvaluationRunRequest
            {
                EvaluationRunName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an evaluation run.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation run to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteEvaluationRunOperationMetadata>> DeleteEvaluationRunAsync(EvaluationRunName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEvaluationRunAsync(new DeleteEvaluationRunRequest
            {
                EvaluationRunName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an evaluation run.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation run to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteEvaluationRunOperationMetadata>> DeleteEvaluationRunAsync(EvaluationRunName name, st::CancellationToken cancellationToken) =>
            DeleteEvaluationRunAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specified evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Evaluation GetEvaluation(GetEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of the specified evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> GetEvaluationAsync(GetEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of the specified evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> GetEvaluationAsync(GetEvaluationRequest request, st::CancellationToken cancellationToken) =>
            GetEvaluationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specified evaluation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Evaluation GetEvaluation(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvaluation(new GetEvaluationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified evaluation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> GetEvaluationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvaluationAsync(new GetEvaluationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified evaluation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> GetEvaluationAsync(string name, st::CancellationToken cancellationToken) =>
            GetEvaluationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specified evaluation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Evaluation GetEvaluation(EvaluationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvaluation(new GetEvaluationRequest
            {
                EvaluationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified evaluation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> GetEvaluationAsync(EvaluationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvaluationAsync(new GetEvaluationRequest
            {
                EvaluationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified evaluation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> GetEvaluationAsync(EvaluationName name, st::CancellationToken cancellationToken) =>
            GetEvaluationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specified evaluation result.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EvaluationResult GetEvaluationResult(GetEvaluationResultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of the specified evaluation result.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationResult> GetEvaluationResultAsync(GetEvaluationResultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of the specified evaluation result.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationResult> GetEvaluationResultAsync(GetEvaluationResultRequest request, st::CancellationToken cancellationToken) =>
            GetEvaluationResultAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specified evaluation result.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation result to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EvaluationResult GetEvaluationResult(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvaluationResult(new GetEvaluationResultRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified evaluation result.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation result to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationResult> GetEvaluationResultAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvaluationResultAsync(new GetEvaluationResultRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified evaluation result.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation result to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationResult> GetEvaluationResultAsync(string name, st::CancellationToken cancellationToken) =>
            GetEvaluationResultAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specified evaluation result.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation result to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EvaluationResult GetEvaluationResult(EvaluationResultName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvaluationResult(new GetEvaluationResultRequest
            {
                EvaluationResultName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified evaluation result.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation result to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationResult> GetEvaluationResultAsync(EvaluationResultName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvaluationResultAsync(new GetEvaluationResultRequest
            {
                EvaluationResultName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified evaluation result.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation result to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationResult> GetEvaluationResultAsync(EvaluationResultName name, st::CancellationToken cancellationToken) =>
            GetEvaluationResultAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specified evaluation dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EvaluationDataset GetEvaluationDataset(GetEvaluationDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of the specified evaluation dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationDataset> GetEvaluationDatasetAsync(GetEvaluationDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of the specified evaluation dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationDataset> GetEvaluationDatasetAsync(GetEvaluationDatasetRequest request, st::CancellationToken cancellationToken) =>
            GetEvaluationDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specified evaluation dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation dataset to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EvaluationDataset GetEvaluationDataset(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvaluationDataset(new GetEvaluationDatasetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified evaluation dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation dataset to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationDataset> GetEvaluationDatasetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvaluationDatasetAsync(new GetEvaluationDatasetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified evaluation dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation dataset to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationDataset> GetEvaluationDatasetAsync(string name, st::CancellationToken cancellationToken) =>
            GetEvaluationDatasetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specified evaluation dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation dataset to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EvaluationDataset GetEvaluationDataset(EvaluationDatasetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvaluationDataset(new GetEvaluationDatasetRequest
            {
                EvaluationDatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified evaluation dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation dataset to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationDataset> GetEvaluationDatasetAsync(EvaluationDatasetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvaluationDatasetAsync(new GetEvaluationDatasetRequest
            {
                EvaluationDatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified evaluation dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation dataset to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationDataset> GetEvaluationDatasetAsync(EvaluationDatasetName name, st::CancellationToken cancellationToken) =>
            GetEvaluationDatasetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specified evaluation run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EvaluationRun GetEvaluationRun(GetEvaluationRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of the specified evaluation run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationRun> GetEvaluationRunAsync(GetEvaluationRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of the specified evaluation run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationRun> GetEvaluationRunAsync(GetEvaluationRunRequest request, st::CancellationToken cancellationToken) =>
            GetEvaluationRunAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specified evaluation run.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation run to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EvaluationRun GetEvaluationRun(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvaluationRun(new GetEvaluationRunRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified evaluation run.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation run to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationRun> GetEvaluationRunAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvaluationRunAsync(new GetEvaluationRunRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified evaluation run.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation run to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationRun> GetEvaluationRunAsync(string name, st::CancellationToken cancellationToken) =>
            GetEvaluationRunAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specified evaluation run.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation run to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EvaluationRun GetEvaluationRun(EvaluationRunName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvaluationRun(new GetEvaluationRunRequest
            {
                EvaluationRunName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified evaluation run.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation run to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationRun> GetEvaluationRunAsync(EvaluationRunName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvaluationRunAsync(new GetEvaluationRunRequest
            {
                EvaluationRunName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified evaluation run.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation run to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationRun> GetEvaluationRunAsync(EvaluationRunName name, st::CancellationToken cancellationToken) =>
            GetEvaluationRunAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all evaluations in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Evaluation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEvaluationsResponse, Evaluation> ListEvaluations(ListEvaluationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all evaluations in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Evaluation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEvaluationsResponse, Evaluation> ListEvaluationsAsync(ListEvaluationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all evaluations in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list evaluations from.
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
        /// <returns>A pageable sequence of <see cref="Evaluation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEvaluationsResponse, Evaluation> ListEvaluations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEvaluationsRequest request = new ListEvaluationsRequest
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
            return ListEvaluations(request, callSettings);
        }

        /// <summary>
        /// Lists all evaluations in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list evaluations from.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Evaluation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEvaluationsResponse, Evaluation> ListEvaluationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEvaluationsRequest request = new ListEvaluationsRequest
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
            return ListEvaluationsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all evaluations in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list evaluations from.
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
        /// <returns>A pageable sequence of <see cref="Evaluation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEvaluationsResponse, Evaluation> ListEvaluations(AppName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEvaluationsRequest request = new ListEvaluationsRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEvaluations(request, callSettings);
        }

        /// <summary>
        /// Lists all evaluations in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list evaluations from.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Evaluation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEvaluationsResponse, Evaluation> ListEvaluationsAsync(AppName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEvaluationsRequest request = new ListEvaluationsRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEvaluationsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all evaluation results for a given evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EvaluationResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEvaluationResultsResponse, EvaluationResult> ListEvaluationResults(ListEvaluationResultsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all evaluation results for a given evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EvaluationResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEvaluationResultsResponse, EvaluationResult> ListEvaluationResultsAsync(ListEvaluationResultsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all evaluation results for a given evaluation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the evaluation to list evaluation results
        /// from. To filter by evaluation run, use `-` as the evaluation ID and specify
        /// the evaluation run ID in the filter. For example:
        /// `projects/{project}/locations/{location}/apps/{app}/evaluations/-`
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
        /// <returns>A pageable sequence of <see cref="EvaluationResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEvaluationResultsResponse, EvaluationResult> ListEvaluationResults(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEvaluationResultsRequest request = new ListEvaluationResultsRequest
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
            return ListEvaluationResults(request, callSettings);
        }

        /// <summary>
        /// Lists all evaluation results for a given evaluation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the evaluation to list evaluation results
        /// from. To filter by evaluation run, use `-` as the evaluation ID and specify
        /// the evaluation run ID in the filter. For example:
        /// `projects/{project}/locations/{location}/apps/{app}/evaluations/-`
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
        /// <returns>A pageable asynchronous sequence of <see cref="EvaluationResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEvaluationResultsResponse, EvaluationResult> ListEvaluationResultsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEvaluationResultsRequest request = new ListEvaluationResultsRequest
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
            return ListEvaluationResultsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all evaluation results for a given evaluation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the evaluation to list evaluation results
        /// from. To filter by evaluation run, use `-` as the evaluation ID and specify
        /// the evaluation run ID in the filter. For example:
        /// `projects/{project}/locations/{location}/apps/{app}/evaluations/-`
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
        /// <returns>A pageable sequence of <see cref="EvaluationResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEvaluationResultsResponse, EvaluationResult> ListEvaluationResults(EvaluationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEvaluationResultsRequest request = new ListEvaluationResultsRequest
            {
                ParentAsEvaluationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEvaluationResults(request, callSettings);
        }

        /// <summary>
        /// Lists all evaluation results for a given evaluation.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the evaluation to list evaluation results
        /// from. To filter by evaluation run, use `-` as the evaluation ID and specify
        /// the evaluation run ID in the filter. For example:
        /// `projects/{project}/locations/{location}/apps/{app}/evaluations/-`
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
        /// <returns>A pageable asynchronous sequence of <see cref="EvaluationResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEvaluationResultsResponse, EvaluationResult> ListEvaluationResultsAsync(EvaluationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEvaluationResultsRequest request = new ListEvaluationResultsRequest
            {
                ParentAsEvaluationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEvaluationResultsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all evaluation datasets in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EvaluationDataset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEvaluationDatasetsResponse, EvaluationDataset> ListEvaluationDatasets(ListEvaluationDatasetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all evaluation datasets in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EvaluationDataset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEvaluationDatasetsResponse, EvaluationDataset> ListEvaluationDatasetsAsync(ListEvaluationDatasetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all evaluation datasets in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list evaluation datasets from.
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
        /// <returns>A pageable sequence of <see cref="EvaluationDataset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEvaluationDatasetsResponse, EvaluationDataset> ListEvaluationDatasets(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEvaluationDatasetsRequest request = new ListEvaluationDatasetsRequest
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
            return ListEvaluationDatasets(request, callSettings);
        }

        /// <summary>
        /// Lists all evaluation datasets in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list evaluation datasets from.
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
        /// <returns>A pageable asynchronous sequence of <see cref="EvaluationDataset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEvaluationDatasetsResponse, EvaluationDataset> ListEvaluationDatasetsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEvaluationDatasetsRequest request = new ListEvaluationDatasetsRequest
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
            return ListEvaluationDatasetsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all evaluation datasets in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list evaluation datasets from.
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
        /// <returns>A pageable sequence of <see cref="EvaluationDataset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEvaluationDatasetsResponse, EvaluationDataset> ListEvaluationDatasets(AppName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEvaluationDatasetsRequest request = new ListEvaluationDatasetsRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEvaluationDatasets(request, callSettings);
        }

        /// <summary>
        /// Lists all evaluation datasets in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list evaluation datasets from.
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
        /// <returns>A pageable asynchronous sequence of <see cref="EvaluationDataset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEvaluationDatasetsResponse, EvaluationDataset> ListEvaluationDatasetsAsync(AppName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEvaluationDatasetsRequest request = new ListEvaluationDatasetsRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEvaluationDatasetsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all evaluation runs in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EvaluationRun"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEvaluationRunsResponse, EvaluationRun> ListEvaluationRuns(ListEvaluationRunsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all evaluation runs in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EvaluationRun"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEvaluationRunsResponse, EvaluationRun> ListEvaluationRunsAsync(ListEvaluationRunsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all evaluation runs in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list evaluation runs from.
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
        /// <returns>A pageable sequence of <see cref="EvaluationRun"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEvaluationRunsResponse, EvaluationRun> ListEvaluationRuns(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEvaluationRunsRequest request = new ListEvaluationRunsRequest
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
            return ListEvaluationRuns(request, callSettings);
        }

        /// <summary>
        /// Lists all evaluation runs in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list evaluation runs from.
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
        /// <returns>A pageable asynchronous sequence of <see cref="EvaluationRun"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEvaluationRunsResponse, EvaluationRun> ListEvaluationRunsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEvaluationRunsRequest request = new ListEvaluationRunsRequest
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
            return ListEvaluationRunsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all evaluation runs in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list evaluation runs from.
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
        /// <returns>A pageable sequence of <see cref="EvaluationRun"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEvaluationRunsResponse, EvaluationRun> ListEvaluationRuns(AppName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEvaluationRunsRequest request = new ListEvaluationRunsRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEvaluationRuns(request, callSettings);
        }

        /// <summary>
        /// Lists all evaluation runs in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list evaluation runs from.
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
        /// <returns>A pageable asynchronous sequence of <see cref="EvaluationRun"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEvaluationRunsResponse, EvaluationRun> ListEvaluationRunsAsync(AppName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEvaluationRunsRequest request = new ListEvaluationRunsRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEvaluationRunsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all evaluation expectations in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EvaluationExpectation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEvaluationExpectationsResponse, EvaluationExpectation> ListEvaluationExpectations(ListEvaluationExpectationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all evaluation expectations in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EvaluationExpectation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEvaluationExpectationsResponse, EvaluationExpectation> ListEvaluationExpectationsAsync(ListEvaluationExpectationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all evaluation expectations in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list evaluation expectations
        /// from.
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
        /// <returns>A pageable sequence of <see cref="EvaluationExpectation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEvaluationExpectationsResponse, EvaluationExpectation> ListEvaluationExpectations(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEvaluationExpectationsRequest request = new ListEvaluationExpectationsRequest
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
            return ListEvaluationExpectations(request, callSettings);
        }

        /// <summary>
        /// Lists all evaluation expectations in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list evaluation expectations
        /// from.
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
        /// <returns>A pageable asynchronous sequence of <see cref="EvaluationExpectation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEvaluationExpectationsResponse, EvaluationExpectation> ListEvaluationExpectationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEvaluationExpectationsRequest request = new ListEvaluationExpectationsRequest
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
            return ListEvaluationExpectationsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all evaluation expectations in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list evaluation expectations
        /// from.
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
        /// <returns>A pageable sequence of <see cref="EvaluationExpectation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEvaluationExpectationsResponse, EvaluationExpectation> ListEvaluationExpectations(AppName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEvaluationExpectationsRequest request = new ListEvaluationExpectationsRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEvaluationExpectations(request, callSettings);
        }

        /// <summary>
        /// Lists all evaluation expectations in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list evaluation expectations
        /// from.
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
        /// <returns>A pageable asynchronous sequence of <see cref="EvaluationExpectation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEvaluationExpectationsResponse, EvaluationExpectation> ListEvaluationExpectationsAsync(AppName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEvaluationExpectationsRequest request = new ListEvaluationExpectationsRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEvaluationExpectationsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified evaluation expectation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EvaluationExpectation GetEvaluationExpectation(GetEvaluationExpectationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of the specified evaluation expectation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationExpectation> GetEvaluationExpectationAsync(GetEvaluationExpectationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of the specified evaluation expectation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationExpectation> GetEvaluationExpectationAsync(GetEvaluationExpectationRequest request, st::CancellationToken cancellationToken) =>
            GetEvaluationExpectationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specified evaluation expectation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation expectation to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EvaluationExpectation GetEvaluationExpectation(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvaluationExpectation(new GetEvaluationExpectationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified evaluation expectation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation expectation to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationExpectation> GetEvaluationExpectationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvaluationExpectationAsync(new GetEvaluationExpectationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified evaluation expectation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation expectation to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationExpectation> GetEvaluationExpectationAsync(string name, st::CancellationToken cancellationToken) =>
            GetEvaluationExpectationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specified evaluation expectation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation expectation to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EvaluationExpectation GetEvaluationExpectation(EvaluationExpectationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvaluationExpectation(new GetEvaluationExpectationRequest
            {
                EvaluationExpectationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified evaluation expectation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation expectation to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationExpectation> GetEvaluationExpectationAsync(EvaluationExpectationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvaluationExpectationAsync(new GetEvaluationExpectationRequest
            {
                EvaluationExpectationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified evaluation expectation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation expectation to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationExpectation> GetEvaluationExpectationAsync(EvaluationExpectationName name, st::CancellationToken cancellationToken) =>
            GetEvaluationExpectationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an evaluation expectation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EvaluationExpectation CreateEvaluationExpectation(CreateEvaluationExpectationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an evaluation expectation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationExpectation> CreateEvaluationExpectationAsync(CreateEvaluationExpectationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an evaluation expectation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationExpectation> CreateEvaluationExpectationAsync(CreateEvaluationExpectationRequest request, st::CancellationToken cancellationToken) =>
            CreateEvaluationExpectationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an evaluation expectation.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the evaluation expectation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="evaluationExpectation">
        /// Required. The evaluation expectation to create.
        /// </param>
        /// <param name="evaluationExpectationId">
        /// Optional. The ID to use for the evaluation expectation, which will become
        /// the final component of the evaluation expectation's resource name. If not
        /// provided, a unique ID will be automatically assigned for the evaluation
        /// expectation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EvaluationExpectation CreateEvaluationExpectation(string parent, EvaluationExpectation evaluationExpectation, string evaluationExpectationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEvaluationExpectation(new CreateEvaluationExpectationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EvaluationExpectationId = evaluationExpectationId ?? "",
                EvaluationExpectation = gax::GaxPreconditions.CheckNotNull(evaluationExpectation, nameof(evaluationExpectation)),
            }, callSettings);

        /// <summary>
        /// Creates an evaluation expectation.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the evaluation expectation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="evaluationExpectation">
        /// Required. The evaluation expectation to create.
        /// </param>
        /// <param name="evaluationExpectationId">
        /// Optional. The ID to use for the evaluation expectation, which will become
        /// the final component of the evaluation expectation's resource name. If not
        /// provided, a unique ID will be automatically assigned for the evaluation
        /// expectation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationExpectation> CreateEvaluationExpectationAsync(string parent, EvaluationExpectation evaluationExpectation, string evaluationExpectationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEvaluationExpectationAsync(new CreateEvaluationExpectationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EvaluationExpectationId = evaluationExpectationId ?? "",
                EvaluationExpectation = gax::GaxPreconditions.CheckNotNull(evaluationExpectation, nameof(evaluationExpectation)),
            }, callSettings);

        /// <summary>
        /// Creates an evaluation expectation.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the evaluation expectation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="evaluationExpectation">
        /// Required. The evaluation expectation to create.
        /// </param>
        /// <param name="evaluationExpectationId">
        /// Optional. The ID to use for the evaluation expectation, which will become
        /// the final component of the evaluation expectation's resource name. If not
        /// provided, a unique ID will be automatically assigned for the evaluation
        /// expectation.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationExpectation> CreateEvaluationExpectationAsync(string parent, EvaluationExpectation evaluationExpectation, string evaluationExpectationId, st::CancellationToken cancellationToken) =>
            CreateEvaluationExpectationAsync(parent, evaluationExpectation, evaluationExpectationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an evaluation expectation.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the evaluation expectation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="evaluationExpectation">
        /// Required. The evaluation expectation to create.
        /// </param>
        /// <param name="evaluationExpectationId">
        /// Optional. The ID to use for the evaluation expectation, which will become
        /// the final component of the evaluation expectation's resource name. If not
        /// provided, a unique ID will be automatically assigned for the evaluation
        /// expectation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EvaluationExpectation CreateEvaluationExpectation(AppName parent, EvaluationExpectation evaluationExpectation, string evaluationExpectationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEvaluationExpectation(new CreateEvaluationExpectationRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EvaluationExpectationId = evaluationExpectationId ?? "",
                EvaluationExpectation = gax::GaxPreconditions.CheckNotNull(evaluationExpectation, nameof(evaluationExpectation)),
            }, callSettings);

        /// <summary>
        /// Creates an evaluation expectation.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the evaluation expectation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="evaluationExpectation">
        /// Required. The evaluation expectation to create.
        /// </param>
        /// <param name="evaluationExpectationId">
        /// Optional. The ID to use for the evaluation expectation, which will become
        /// the final component of the evaluation expectation's resource name. If not
        /// provided, a unique ID will be automatically assigned for the evaluation
        /// expectation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationExpectation> CreateEvaluationExpectationAsync(AppName parent, EvaluationExpectation evaluationExpectation, string evaluationExpectationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEvaluationExpectationAsync(new CreateEvaluationExpectationRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EvaluationExpectationId = evaluationExpectationId ?? "",
                EvaluationExpectation = gax::GaxPreconditions.CheckNotNull(evaluationExpectation, nameof(evaluationExpectation)),
            }, callSettings);

        /// <summary>
        /// Creates an evaluation expectation.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the evaluation expectation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="evaluationExpectation">
        /// Required. The evaluation expectation to create.
        /// </param>
        /// <param name="evaluationExpectationId">
        /// Optional. The ID to use for the evaluation expectation, which will become
        /// the final component of the evaluation expectation's resource name. If not
        /// provided, a unique ID will be automatically assigned for the evaluation
        /// expectation.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationExpectation> CreateEvaluationExpectationAsync(AppName parent, EvaluationExpectation evaluationExpectation, string evaluationExpectationId, st::CancellationToken cancellationToken) =>
            CreateEvaluationExpectationAsync(parent, evaluationExpectation, evaluationExpectationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an evaluation expectation.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the evaluation expectation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="evaluationExpectation">
        /// Required. The evaluation expectation to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EvaluationExpectation CreateEvaluationExpectation(string parent, EvaluationExpectation evaluationExpectation, gaxgrpc::CallSettings callSettings = null) =>
            CreateEvaluationExpectation(new CreateEvaluationExpectationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EvaluationExpectation = gax::GaxPreconditions.CheckNotNull(evaluationExpectation, nameof(evaluationExpectation)),
            }, callSettings);

        /// <summary>
        /// Creates an evaluation expectation.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the evaluation expectation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="evaluationExpectation">
        /// Required. The evaluation expectation to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationExpectation> CreateEvaluationExpectationAsync(string parent, EvaluationExpectation evaluationExpectation, gaxgrpc::CallSettings callSettings = null) =>
            CreateEvaluationExpectationAsync(new CreateEvaluationExpectationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EvaluationExpectation = gax::GaxPreconditions.CheckNotNull(evaluationExpectation, nameof(evaluationExpectation)),
            }, callSettings);

        /// <summary>
        /// Creates an evaluation expectation.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the evaluation expectation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="evaluationExpectation">
        /// Required. The evaluation expectation to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationExpectation> CreateEvaluationExpectationAsync(string parent, EvaluationExpectation evaluationExpectation, st::CancellationToken cancellationToken) =>
            CreateEvaluationExpectationAsync(parent, evaluationExpectation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an evaluation expectation.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the evaluation expectation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="evaluationExpectation">
        /// Required. The evaluation expectation to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EvaluationExpectation CreateEvaluationExpectation(AppName parent, EvaluationExpectation evaluationExpectation, gaxgrpc::CallSettings callSettings = null) =>
            CreateEvaluationExpectation(new CreateEvaluationExpectationRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EvaluationExpectation = gax::GaxPreconditions.CheckNotNull(evaluationExpectation, nameof(evaluationExpectation)),
            }, callSettings);

        /// <summary>
        /// Creates an evaluation expectation.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the evaluation expectation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="evaluationExpectation">
        /// Required. The evaluation expectation to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationExpectation> CreateEvaluationExpectationAsync(AppName parent, EvaluationExpectation evaluationExpectation, gaxgrpc::CallSettings callSettings = null) =>
            CreateEvaluationExpectationAsync(new CreateEvaluationExpectationRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EvaluationExpectation = gax::GaxPreconditions.CheckNotNull(evaluationExpectation, nameof(evaluationExpectation)),
            }, callSettings);

        /// <summary>
        /// Creates an evaluation expectation.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the evaluation expectation for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="evaluationExpectation">
        /// Required. The evaluation expectation to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationExpectation> CreateEvaluationExpectationAsync(AppName parent, EvaluationExpectation evaluationExpectation, st::CancellationToken cancellationToken) =>
            CreateEvaluationExpectationAsync(parent, evaluationExpectation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an evaluation expectation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EvaluationExpectation UpdateEvaluationExpectation(UpdateEvaluationExpectationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an evaluation expectation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationExpectation> UpdateEvaluationExpectationAsync(UpdateEvaluationExpectationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an evaluation expectation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationExpectation> UpdateEvaluationExpectationAsync(UpdateEvaluationExpectationRequest request, st::CancellationToken cancellationToken) =>
            UpdateEvaluationExpectationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an evaluation expectation.
        /// </summary>
        /// <param name="evaluationExpectation">
        /// Required. The evaluation expectation to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to control which fields get updated. If the
        /// mask is not present, all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EvaluationExpectation UpdateEvaluationExpectation(EvaluationExpectation evaluationExpectation, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEvaluationExpectation(new UpdateEvaluationExpectationRequest
            {
                EvaluationExpectation = gax::GaxPreconditions.CheckNotNull(evaluationExpectation, nameof(evaluationExpectation)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an evaluation expectation.
        /// </summary>
        /// <param name="evaluationExpectation">
        /// Required. The evaluation expectation to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to control which fields get updated. If the
        /// mask is not present, all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationExpectation> UpdateEvaluationExpectationAsync(EvaluationExpectation evaluationExpectation, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEvaluationExpectationAsync(new UpdateEvaluationExpectationRequest
            {
                EvaluationExpectation = gax::GaxPreconditions.CheckNotNull(evaluationExpectation, nameof(evaluationExpectation)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an evaluation expectation.
        /// </summary>
        /// <param name="evaluationExpectation">
        /// Required. The evaluation expectation to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to control which fields get updated. If the
        /// mask is not present, all fields will be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationExpectation> UpdateEvaluationExpectationAsync(EvaluationExpectation evaluationExpectation, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateEvaluationExpectationAsync(evaluationExpectation, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an evaluation expectation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEvaluationExpectation(DeleteEvaluationExpectationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an evaluation expectation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEvaluationExpectationAsync(DeleteEvaluationExpectationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an evaluation expectation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEvaluationExpectationAsync(DeleteEvaluationExpectationRequest request, st::CancellationToken cancellationToken) =>
            DeleteEvaluationExpectationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an evaluation expectation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation expectation to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEvaluationExpectation(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEvaluationExpectation(new DeleteEvaluationExpectationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an evaluation expectation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation expectation to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEvaluationExpectationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEvaluationExpectationAsync(new DeleteEvaluationExpectationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an evaluation expectation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation expectation to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEvaluationExpectationAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteEvaluationExpectationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an evaluation expectation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation expectation to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEvaluationExpectation(EvaluationExpectationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEvaluationExpectation(new DeleteEvaluationExpectationRequest
            {
                EvaluationExpectationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an evaluation expectation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation expectation to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEvaluationExpectationAsync(EvaluationExpectationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEvaluationExpectationAsync(new DeleteEvaluationExpectationRequest
            {
                EvaluationExpectationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an evaluation expectation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the evaluation expectation to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEvaluationExpectationAsync(EvaluationExpectationName name, st::CancellationToken cancellationToken) =>
            DeleteEvaluationExpectationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a scheduled evaluation run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ScheduledEvaluationRun CreateScheduledEvaluationRun(CreateScheduledEvaluationRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a scheduled evaluation run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScheduledEvaluationRun> CreateScheduledEvaluationRunAsync(CreateScheduledEvaluationRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a scheduled evaluation run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScheduledEvaluationRun> CreateScheduledEvaluationRunAsync(CreateScheduledEvaluationRunRequest request, st::CancellationToken cancellationToken) =>
            CreateScheduledEvaluationRunAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a scheduled evaluation run.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the scheduled evaluation run for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="scheduledEvaluationRun">
        /// Required. The scheduled evaluation run to create.
        /// </param>
        /// <param name="scheduledEvaluationRunId">
        /// Optional. The ID to use for the scheduled evaluation run, which will become
        /// the final component of the scheduled evaluation run's resource name. If not
        /// provided, a unique ID will be automatically assigned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ScheduledEvaluationRun CreateScheduledEvaluationRun(string parent, ScheduledEvaluationRun scheduledEvaluationRun, string scheduledEvaluationRunId, gaxgrpc::CallSettings callSettings = null) =>
            CreateScheduledEvaluationRun(new CreateScheduledEvaluationRunRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ScheduledEvaluationRunId = scheduledEvaluationRunId ?? "",
                ScheduledEvaluationRun = gax::GaxPreconditions.CheckNotNull(scheduledEvaluationRun, nameof(scheduledEvaluationRun)),
            }, callSettings);

        /// <summary>
        /// Creates a scheduled evaluation run.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the scheduled evaluation run for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="scheduledEvaluationRun">
        /// Required. The scheduled evaluation run to create.
        /// </param>
        /// <param name="scheduledEvaluationRunId">
        /// Optional. The ID to use for the scheduled evaluation run, which will become
        /// the final component of the scheduled evaluation run's resource name. If not
        /// provided, a unique ID will be automatically assigned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScheduledEvaluationRun> CreateScheduledEvaluationRunAsync(string parent, ScheduledEvaluationRun scheduledEvaluationRun, string scheduledEvaluationRunId, gaxgrpc::CallSettings callSettings = null) =>
            CreateScheduledEvaluationRunAsync(new CreateScheduledEvaluationRunRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ScheduledEvaluationRunId = scheduledEvaluationRunId ?? "",
                ScheduledEvaluationRun = gax::GaxPreconditions.CheckNotNull(scheduledEvaluationRun, nameof(scheduledEvaluationRun)),
            }, callSettings);

        /// <summary>
        /// Creates a scheduled evaluation run.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the scheduled evaluation run for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="scheduledEvaluationRun">
        /// Required. The scheduled evaluation run to create.
        /// </param>
        /// <param name="scheduledEvaluationRunId">
        /// Optional. The ID to use for the scheduled evaluation run, which will become
        /// the final component of the scheduled evaluation run's resource name. If not
        /// provided, a unique ID will be automatically assigned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScheduledEvaluationRun> CreateScheduledEvaluationRunAsync(string parent, ScheduledEvaluationRun scheduledEvaluationRun, string scheduledEvaluationRunId, st::CancellationToken cancellationToken) =>
            CreateScheduledEvaluationRunAsync(parent, scheduledEvaluationRun, scheduledEvaluationRunId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a scheduled evaluation run.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the scheduled evaluation run for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="scheduledEvaluationRun">
        /// Required. The scheduled evaluation run to create.
        /// </param>
        /// <param name="scheduledEvaluationRunId">
        /// Optional. The ID to use for the scheduled evaluation run, which will become
        /// the final component of the scheduled evaluation run's resource name. If not
        /// provided, a unique ID will be automatically assigned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ScheduledEvaluationRun CreateScheduledEvaluationRun(AppName parent, ScheduledEvaluationRun scheduledEvaluationRun, string scheduledEvaluationRunId, gaxgrpc::CallSettings callSettings = null) =>
            CreateScheduledEvaluationRun(new CreateScheduledEvaluationRunRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ScheduledEvaluationRunId = scheduledEvaluationRunId ?? "",
                ScheduledEvaluationRun = gax::GaxPreconditions.CheckNotNull(scheduledEvaluationRun, nameof(scheduledEvaluationRun)),
            }, callSettings);

        /// <summary>
        /// Creates a scheduled evaluation run.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the scheduled evaluation run for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="scheduledEvaluationRun">
        /// Required. The scheduled evaluation run to create.
        /// </param>
        /// <param name="scheduledEvaluationRunId">
        /// Optional. The ID to use for the scheduled evaluation run, which will become
        /// the final component of the scheduled evaluation run's resource name. If not
        /// provided, a unique ID will be automatically assigned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScheduledEvaluationRun> CreateScheduledEvaluationRunAsync(AppName parent, ScheduledEvaluationRun scheduledEvaluationRun, string scheduledEvaluationRunId, gaxgrpc::CallSettings callSettings = null) =>
            CreateScheduledEvaluationRunAsync(new CreateScheduledEvaluationRunRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ScheduledEvaluationRunId = scheduledEvaluationRunId ?? "",
                ScheduledEvaluationRun = gax::GaxPreconditions.CheckNotNull(scheduledEvaluationRun, nameof(scheduledEvaluationRun)),
            }, callSettings);

        /// <summary>
        /// Creates a scheduled evaluation run.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the scheduled evaluation run for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="scheduledEvaluationRun">
        /// Required. The scheduled evaluation run to create.
        /// </param>
        /// <param name="scheduledEvaluationRunId">
        /// Optional. The ID to use for the scheduled evaluation run, which will become
        /// the final component of the scheduled evaluation run's resource name. If not
        /// provided, a unique ID will be automatically assigned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScheduledEvaluationRun> CreateScheduledEvaluationRunAsync(AppName parent, ScheduledEvaluationRun scheduledEvaluationRun, string scheduledEvaluationRunId, st::CancellationToken cancellationToken) =>
            CreateScheduledEvaluationRunAsync(parent, scheduledEvaluationRun, scheduledEvaluationRunId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a scheduled evaluation run.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the scheduled evaluation run for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="scheduledEvaluationRun">
        /// Required. The scheduled evaluation run to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ScheduledEvaluationRun CreateScheduledEvaluationRun(string parent, ScheduledEvaluationRun scheduledEvaluationRun, gaxgrpc::CallSettings callSettings = null) =>
            CreateScheduledEvaluationRun(new CreateScheduledEvaluationRunRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ScheduledEvaluationRun = gax::GaxPreconditions.CheckNotNull(scheduledEvaluationRun, nameof(scheduledEvaluationRun)),
            }, callSettings);

        /// <summary>
        /// Creates a scheduled evaluation run.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the scheduled evaluation run for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="scheduledEvaluationRun">
        /// Required. The scheduled evaluation run to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScheduledEvaluationRun> CreateScheduledEvaluationRunAsync(string parent, ScheduledEvaluationRun scheduledEvaluationRun, gaxgrpc::CallSettings callSettings = null) =>
            CreateScheduledEvaluationRunAsync(new CreateScheduledEvaluationRunRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ScheduledEvaluationRun = gax::GaxPreconditions.CheckNotNull(scheduledEvaluationRun, nameof(scheduledEvaluationRun)),
            }, callSettings);

        /// <summary>
        /// Creates a scheduled evaluation run.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the scheduled evaluation run for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="scheduledEvaluationRun">
        /// Required. The scheduled evaluation run to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScheduledEvaluationRun> CreateScheduledEvaluationRunAsync(string parent, ScheduledEvaluationRun scheduledEvaluationRun, st::CancellationToken cancellationToken) =>
            CreateScheduledEvaluationRunAsync(parent, scheduledEvaluationRun, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a scheduled evaluation run.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the scheduled evaluation run for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="scheduledEvaluationRun">
        /// Required. The scheduled evaluation run to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ScheduledEvaluationRun CreateScheduledEvaluationRun(AppName parent, ScheduledEvaluationRun scheduledEvaluationRun, gaxgrpc::CallSettings callSettings = null) =>
            CreateScheduledEvaluationRun(new CreateScheduledEvaluationRunRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ScheduledEvaluationRun = gax::GaxPreconditions.CheckNotNull(scheduledEvaluationRun, nameof(scheduledEvaluationRun)),
            }, callSettings);

        /// <summary>
        /// Creates a scheduled evaluation run.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the scheduled evaluation run for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="scheduledEvaluationRun">
        /// Required. The scheduled evaluation run to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScheduledEvaluationRun> CreateScheduledEvaluationRunAsync(AppName parent, ScheduledEvaluationRun scheduledEvaluationRun, gaxgrpc::CallSettings callSettings = null) =>
            CreateScheduledEvaluationRunAsync(new CreateScheduledEvaluationRunRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ScheduledEvaluationRun = gax::GaxPreconditions.CheckNotNull(scheduledEvaluationRun, nameof(scheduledEvaluationRun)),
            }, callSettings);

        /// <summary>
        /// Creates a scheduled evaluation run.
        /// </summary>
        /// <param name="parent">
        /// Required. The app to create the scheduled evaluation run for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="scheduledEvaluationRun">
        /// Required. The scheduled evaluation run to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScheduledEvaluationRun> CreateScheduledEvaluationRunAsync(AppName parent, ScheduledEvaluationRun scheduledEvaluationRun, st::CancellationToken cancellationToken) =>
            CreateScheduledEvaluationRunAsync(parent, scheduledEvaluationRun, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specified scheduled evaluation run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ScheduledEvaluationRun GetScheduledEvaluationRun(GetScheduledEvaluationRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of the specified scheduled evaluation run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScheduledEvaluationRun> GetScheduledEvaluationRunAsync(GetScheduledEvaluationRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of the specified scheduled evaluation run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScheduledEvaluationRun> GetScheduledEvaluationRunAsync(GetScheduledEvaluationRunRequest request, st::CancellationToken cancellationToken) =>
            GetScheduledEvaluationRunAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specified scheduled evaluation run.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the scheduled evaluation run to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ScheduledEvaluationRun GetScheduledEvaluationRun(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetScheduledEvaluationRun(new GetScheduledEvaluationRunRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified scheduled evaluation run.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the scheduled evaluation run to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScheduledEvaluationRun> GetScheduledEvaluationRunAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetScheduledEvaluationRunAsync(new GetScheduledEvaluationRunRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified scheduled evaluation run.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the scheduled evaluation run to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScheduledEvaluationRun> GetScheduledEvaluationRunAsync(string name, st::CancellationToken cancellationToken) =>
            GetScheduledEvaluationRunAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of the specified scheduled evaluation run.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the scheduled evaluation run to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ScheduledEvaluationRun GetScheduledEvaluationRun(ScheduledEvaluationRunName name, gaxgrpc::CallSettings callSettings = null) =>
            GetScheduledEvaluationRun(new GetScheduledEvaluationRunRequest
            {
                ScheduledEvaluationRunName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified scheduled evaluation run.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the scheduled evaluation run to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScheduledEvaluationRun> GetScheduledEvaluationRunAsync(ScheduledEvaluationRunName name, gaxgrpc::CallSettings callSettings = null) =>
            GetScheduledEvaluationRunAsync(new GetScheduledEvaluationRunRequest
            {
                ScheduledEvaluationRunName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of the specified scheduled evaluation run.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the scheduled evaluation run to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScheduledEvaluationRun> GetScheduledEvaluationRunAsync(ScheduledEvaluationRunName name, st::CancellationToken cancellationToken) =>
            GetScheduledEvaluationRunAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all scheduled evaluation runs in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ScheduledEvaluationRun"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListScheduledEvaluationRunsResponse, ScheduledEvaluationRun> ListScheduledEvaluationRuns(ListScheduledEvaluationRunsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all scheduled evaluation runs in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ScheduledEvaluationRun"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListScheduledEvaluationRunsResponse, ScheduledEvaluationRun> ListScheduledEvaluationRunsAsync(ListScheduledEvaluationRunsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all scheduled evaluation runs in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list scheduled evaluation runs
        /// from.
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
        /// <returns>A pageable sequence of <see cref="ScheduledEvaluationRun"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListScheduledEvaluationRunsResponse, ScheduledEvaluationRun> ListScheduledEvaluationRuns(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListScheduledEvaluationRunsRequest request = new ListScheduledEvaluationRunsRequest
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
            return ListScheduledEvaluationRuns(request, callSettings);
        }

        /// <summary>
        /// Lists all scheduled evaluation runs in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list scheduled evaluation runs
        /// from.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ScheduledEvaluationRun"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListScheduledEvaluationRunsResponse, ScheduledEvaluationRun> ListScheduledEvaluationRunsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListScheduledEvaluationRunsRequest request = new ListScheduledEvaluationRunsRequest
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
            return ListScheduledEvaluationRunsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all scheduled evaluation runs in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list scheduled evaluation runs
        /// from.
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
        /// <returns>A pageable sequence of <see cref="ScheduledEvaluationRun"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListScheduledEvaluationRunsResponse, ScheduledEvaluationRun> ListScheduledEvaluationRuns(AppName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListScheduledEvaluationRunsRequest request = new ListScheduledEvaluationRunsRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListScheduledEvaluationRuns(request, callSettings);
        }

        /// <summary>
        /// Lists all scheduled evaluation runs in the given app.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the app to list scheduled evaluation runs
        /// from.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ScheduledEvaluationRun"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListScheduledEvaluationRunsResponse, ScheduledEvaluationRun> ListScheduledEvaluationRunsAsync(AppName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListScheduledEvaluationRunsRequest request = new ListScheduledEvaluationRunsRequest
            {
                ParentAsAppName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListScheduledEvaluationRunsAsync(request, callSettings);
        }

        /// <summary>
        /// Updates a scheduled evaluation run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ScheduledEvaluationRun UpdateScheduledEvaluationRun(UpdateScheduledEvaluationRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a scheduled evaluation run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScheduledEvaluationRun> UpdateScheduledEvaluationRunAsync(UpdateScheduledEvaluationRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a scheduled evaluation run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScheduledEvaluationRun> UpdateScheduledEvaluationRunAsync(UpdateScheduledEvaluationRunRequest request, st::CancellationToken cancellationToken) =>
            UpdateScheduledEvaluationRunAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a scheduled evaluation run.
        /// </summary>
        /// <param name="scheduledEvaluationRun">
        /// Required. The scheduled evaluation run to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to control which fields get updated. If the
        /// mask is not present, all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ScheduledEvaluationRun UpdateScheduledEvaluationRun(ScheduledEvaluationRun scheduledEvaluationRun, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateScheduledEvaluationRun(new UpdateScheduledEvaluationRunRequest
            {
                ScheduledEvaluationRun = gax::GaxPreconditions.CheckNotNull(scheduledEvaluationRun, nameof(scheduledEvaluationRun)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a scheduled evaluation run.
        /// </summary>
        /// <param name="scheduledEvaluationRun">
        /// Required. The scheduled evaluation run to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to control which fields get updated. If the
        /// mask is not present, all fields will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScheduledEvaluationRun> UpdateScheduledEvaluationRunAsync(ScheduledEvaluationRun scheduledEvaluationRun, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateScheduledEvaluationRunAsync(new UpdateScheduledEvaluationRunRequest
            {
                ScheduledEvaluationRun = gax::GaxPreconditions.CheckNotNull(scheduledEvaluationRun, nameof(scheduledEvaluationRun)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a scheduled evaluation run.
        /// </summary>
        /// <param name="scheduledEvaluationRun">
        /// Required. The scheduled evaluation run to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to control which fields get updated. If the
        /// mask is not present, all fields will be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ScheduledEvaluationRun> UpdateScheduledEvaluationRunAsync(ScheduledEvaluationRun scheduledEvaluationRun, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateScheduledEvaluationRunAsync(scheduledEvaluationRun, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a scheduled evaluation run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteScheduledEvaluationRun(DeleteScheduledEvaluationRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a scheduled evaluation run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteScheduledEvaluationRunAsync(DeleteScheduledEvaluationRunRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a scheduled evaluation run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteScheduledEvaluationRunAsync(DeleteScheduledEvaluationRunRequest request, st::CancellationToken cancellationToken) =>
            DeleteScheduledEvaluationRunAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a scheduled evaluation run.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the scheduled evaluation run to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteScheduledEvaluationRun(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteScheduledEvaluationRun(new DeleteScheduledEvaluationRunRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a scheduled evaluation run.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the scheduled evaluation run to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteScheduledEvaluationRunAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteScheduledEvaluationRunAsync(new DeleteScheduledEvaluationRunRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a scheduled evaluation run.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the scheduled evaluation run to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteScheduledEvaluationRunAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteScheduledEvaluationRunAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a scheduled evaluation run.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the scheduled evaluation run to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteScheduledEvaluationRun(ScheduledEvaluationRunName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteScheduledEvaluationRun(new DeleteScheduledEvaluationRunRequest
            {
                ScheduledEvaluationRunName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a scheduled evaluation run.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the scheduled evaluation run to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteScheduledEvaluationRunAsync(ScheduledEvaluationRunName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteScheduledEvaluationRunAsync(new DeleteScheduledEvaluationRunRequest
            {
                ScheduledEvaluationRunName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a scheduled evaluation run.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the scheduled evaluation run to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteScheduledEvaluationRunAsync(ScheduledEvaluationRunName name, st::CancellationToken cancellationToken) =>
            DeleteScheduledEvaluationRunAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Tests the voice of a persona. Also accepts a default persona.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TestPersonaVoiceResponse TestPersonaVoice(TestPersonaVoiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Tests the voice of a persona. Also accepts a default persona.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestPersonaVoiceResponse> TestPersonaVoiceAsync(TestPersonaVoiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Tests the voice of a persona. Also accepts a default persona.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestPersonaVoiceResponse> TestPersonaVoiceAsync(TestPersonaVoiceRequest request, st::CancellationToken cancellationToken) =>
            TestPersonaVoiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Tests the voice of a persona. Also accepts a default persona.
        /// </summary>
        /// <param name="app">
        /// Required. the resource name of the app to test the persona voice for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TestPersonaVoiceResponse TestPersonaVoice(string app, gaxgrpc::CallSettings callSettings = null) =>
            TestPersonaVoice(new TestPersonaVoiceRequest
            {
                App = gax::GaxPreconditions.CheckNotNullOrEmpty(app, nameof(app)),
            }, callSettings);

        /// <summary>
        /// Tests the voice of a persona. Also accepts a default persona.
        /// </summary>
        /// <param name="app">
        /// Required. the resource name of the app to test the persona voice for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestPersonaVoiceResponse> TestPersonaVoiceAsync(string app, gaxgrpc::CallSettings callSettings = null) =>
            TestPersonaVoiceAsync(new TestPersonaVoiceRequest
            {
                App = gax::GaxPreconditions.CheckNotNullOrEmpty(app, nameof(app)),
            }, callSettings);

        /// <summary>
        /// Tests the voice of a persona. Also accepts a default persona.
        /// </summary>
        /// <param name="app">
        /// Required. the resource name of the app to test the persona voice for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestPersonaVoiceResponse> TestPersonaVoiceAsync(string app, st::CancellationToken cancellationToken) =>
            TestPersonaVoiceAsync(app, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Tests the voice of a persona. Also accepts a default persona.
        /// </summary>
        /// <param name="app">
        /// Required. the resource name of the app to test the persona voice for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TestPersonaVoiceResponse TestPersonaVoice(AppName app, gaxgrpc::CallSettings callSettings = null) =>
            TestPersonaVoice(new TestPersonaVoiceRequest
            {
                AppAsAppName = gax::GaxPreconditions.CheckNotNull(app, nameof(app)),
            }, callSettings);

        /// <summary>
        /// Tests the voice of a persona. Also accepts a default persona.
        /// </summary>
        /// <param name="app">
        /// Required. the resource name of the app to test the persona voice for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestPersonaVoiceResponse> TestPersonaVoiceAsync(AppName app, gaxgrpc::CallSettings callSettings = null) =>
            TestPersonaVoiceAsync(new TestPersonaVoiceRequest
            {
                AppAsAppName = gax::GaxPreconditions.CheckNotNull(app, nameof(app)),
            }, callSettings);

        /// <summary>
        /// Tests the voice of a persona. Also accepts a default persona.
        /// </summary>
        /// <param name="app">
        /// Required. the resource name of the app to test the persona voice for.
        /// Format:
        /// `projects/{project}/locations/{location}/apps/{app}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TestPersonaVoiceResponse> TestPersonaVoiceAsync(AppName app, st::CancellationToken cancellationToken) =>
            TestPersonaVoiceAsync(app, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>EvaluationService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// EvaluationService exposes methods to perform evaluation for the CES app.
    /// </remarks>
    public sealed partial class EvaluationServiceClientImpl : EvaluationServiceClient
    {
        private readonly gaxgrpc::ApiCall<RunEvaluationRequest, lro::Operation> _callRunEvaluation;

        private readonly gaxgrpc::ApiCall<UploadEvaluationAudioRequest, UploadEvaluationAudioResponse> _callUploadEvaluationAudio;

        private readonly gaxgrpc::ApiCall<CreateEvaluationRequest, Evaluation> _callCreateEvaluation;

        private readonly gaxgrpc::ApiCall<GenerateEvaluationRequest, lro::Operation> _callGenerateEvaluation;

        private readonly gaxgrpc::ApiCall<ImportEvaluationsRequest, lro::Operation> _callImportEvaluations;

        private readonly gaxgrpc::ApiCall<CreateEvaluationDatasetRequest, EvaluationDataset> _callCreateEvaluationDataset;

        private readonly gaxgrpc::ApiCall<UpdateEvaluationRequest, Evaluation> _callUpdateEvaluation;

        private readonly gaxgrpc::ApiCall<UpdateEvaluationDatasetRequest, EvaluationDataset> _callUpdateEvaluationDataset;

        private readonly gaxgrpc::ApiCall<DeleteEvaluationRequest, wkt::Empty> _callDeleteEvaluation;

        private readonly gaxgrpc::ApiCall<DeleteEvaluationResultRequest, wkt::Empty> _callDeleteEvaluationResult;

        private readonly gaxgrpc::ApiCall<DeleteEvaluationDatasetRequest, wkt::Empty> _callDeleteEvaluationDataset;

        private readonly gaxgrpc::ApiCall<DeleteEvaluationRunRequest, lro::Operation> _callDeleteEvaluationRun;

        private readonly gaxgrpc::ApiCall<GetEvaluationRequest, Evaluation> _callGetEvaluation;

        private readonly gaxgrpc::ApiCall<GetEvaluationResultRequest, EvaluationResult> _callGetEvaluationResult;

        private readonly gaxgrpc::ApiCall<GetEvaluationDatasetRequest, EvaluationDataset> _callGetEvaluationDataset;

        private readonly gaxgrpc::ApiCall<GetEvaluationRunRequest, EvaluationRun> _callGetEvaluationRun;

        private readonly gaxgrpc::ApiCall<ListEvaluationsRequest, ListEvaluationsResponse> _callListEvaluations;

        private readonly gaxgrpc::ApiCall<ListEvaluationResultsRequest, ListEvaluationResultsResponse> _callListEvaluationResults;

        private readonly gaxgrpc::ApiCall<ListEvaluationDatasetsRequest, ListEvaluationDatasetsResponse> _callListEvaluationDatasets;

        private readonly gaxgrpc::ApiCall<ListEvaluationRunsRequest, ListEvaluationRunsResponse> _callListEvaluationRuns;

        private readonly gaxgrpc::ApiCall<ListEvaluationExpectationsRequest, ListEvaluationExpectationsResponse> _callListEvaluationExpectations;

        private readonly gaxgrpc::ApiCall<GetEvaluationExpectationRequest, EvaluationExpectation> _callGetEvaluationExpectation;

        private readonly gaxgrpc::ApiCall<CreateEvaluationExpectationRequest, EvaluationExpectation> _callCreateEvaluationExpectation;

        private readonly gaxgrpc::ApiCall<UpdateEvaluationExpectationRequest, EvaluationExpectation> _callUpdateEvaluationExpectation;

        private readonly gaxgrpc::ApiCall<DeleteEvaluationExpectationRequest, wkt::Empty> _callDeleteEvaluationExpectation;

        private readonly gaxgrpc::ApiCall<CreateScheduledEvaluationRunRequest, ScheduledEvaluationRun> _callCreateScheduledEvaluationRun;

        private readonly gaxgrpc::ApiCall<GetScheduledEvaluationRunRequest, ScheduledEvaluationRun> _callGetScheduledEvaluationRun;

        private readonly gaxgrpc::ApiCall<ListScheduledEvaluationRunsRequest, ListScheduledEvaluationRunsResponse> _callListScheduledEvaluationRuns;

        private readonly gaxgrpc::ApiCall<UpdateScheduledEvaluationRunRequest, ScheduledEvaluationRun> _callUpdateScheduledEvaluationRun;

        private readonly gaxgrpc::ApiCall<DeleteScheduledEvaluationRunRequest, wkt::Empty> _callDeleteScheduledEvaluationRun;

        private readonly gaxgrpc::ApiCall<TestPersonaVoiceRequest, TestPersonaVoiceResponse> _callTestPersonaVoice;

        /// <summary>
        /// Constructs a client wrapper for the EvaluationService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="EvaluationServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public EvaluationServiceClientImpl(EvaluationService.EvaluationServiceClient grpcClient, EvaluationServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            EvaluationServiceSettings effectiveSettings = settings ?? EvaluationServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            RunEvaluationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RunEvaluationOperationsSettings, logger);
            GenerateEvaluationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.GenerateEvaluationOperationsSettings, logger);
            ImportEvaluationsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ImportEvaluationsOperationsSettings, logger);
            DeleteEvaluationRunOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteEvaluationRunOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callRunEvaluation = clientHelper.BuildApiCall<RunEvaluationRequest, lro::Operation>("RunEvaluation", grpcClient.RunEvaluationAsync, grpcClient.RunEvaluation, effectiveSettings.RunEvaluationSettings).WithGoogleRequestParam("app", request => request.App);
            Modify_ApiCall(ref _callRunEvaluation);
            Modify_RunEvaluationApiCall(ref _callRunEvaluation);
            _callUploadEvaluationAudio = clientHelper.BuildApiCall<UploadEvaluationAudioRequest, UploadEvaluationAudioResponse>("UploadEvaluationAudio", grpcClient.UploadEvaluationAudioAsync, grpcClient.UploadEvaluationAudio, effectiveSettings.UploadEvaluationAudioSettings).WithGoogleRequestParam("app", request => request.App);
            Modify_ApiCall(ref _callUploadEvaluationAudio);
            Modify_UploadEvaluationAudioApiCall(ref _callUploadEvaluationAudio);
            _callCreateEvaluation = clientHelper.BuildApiCall<CreateEvaluationRequest, Evaluation>("CreateEvaluation", grpcClient.CreateEvaluationAsync, grpcClient.CreateEvaluation, effectiveSettings.CreateEvaluationSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateEvaluation);
            Modify_CreateEvaluationApiCall(ref _callCreateEvaluation);
            _callGenerateEvaluation = clientHelper.BuildApiCall<GenerateEvaluationRequest, lro::Operation>("GenerateEvaluation", grpcClient.GenerateEvaluationAsync, grpcClient.GenerateEvaluation, effectiveSettings.GenerateEvaluationSettings).WithGoogleRequestParam("conversation", request => request.Conversation);
            Modify_ApiCall(ref _callGenerateEvaluation);
            Modify_GenerateEvaluationApiCall(ref _callGenerateEvaluation);
            _callImportEvaluations = clientHelper.BuildApiCall<ImportEvaluationsRequest, lro::Operation>("ImportEvaluations", grpcClient.ImportEvaluationsAsync, grpcClient.ImportEvaluations, effectiveSettings.ImportEvaluationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callImportEvaluations);
            Modify_ImportEvaluationsApiCall(ref _callImportEvaluations);
            _callCreateEvaluationDataset = clientHelper.BuildApiCall<CreateEvaluationDatasetRequest, EvaluationDataset>("CreateEvaluationDataset", grpcClient.CreateEvaluationDatasetAsync, grpcClient.CreateEvaluationDataset, effectiveSettings.CreateEvaluationDatasetSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateEvaluationDataset);
            Modify_CreateEvaluationDatasetApiCall(ref _callCreateEvaluationDataset);
            _callUpdateEvaluation = clientHelper.BuildApiCall<UpdateEvaluationRequest, Evaluation>("UpdateEvaluation", grpcClient.UpdateEvaluationAsync, grpcClient.UpdateEvaluation, effectiveSettings.UpdateEvaluationSettings).WithGoogleRequestParam("evaluation.name", request => request.Evaluation?.Name);
            Modify_ApiCall(ref _callUpdateEvaluation);
            Modify_UpdateEvaluationApiCall(ref _callUpdateEvaluation);
            _callUpdateEvaluationDataset = clientHelper.BuildApiCall<UpdateEvaluationDatasetRequest, EvaluationDataset>("UpdateEvaluationDataset", grpcClient.UpdateEvaluationDatasetAsync, grpcClient.UpdateEvaluationDataset, effectiveSettings.UpdateEvaluationDatasetSettings).WithGoogleRequestParam("evaluation_dataset.name", request => request.EvaluationDataset?.Name);
            Modify_ApiCall(ref _callUpdateEvaluationDataset);
            Modify_UpdateEvaluationDatasetApiCall(ref _callUpdateEvaluationDataset);
            _callDeleteEvaluation = clientHelper.BuildApiCall<DeleteEvaluationRequest, wkt::Empty>("DeleteEvaluation", grpcClient.DeleteEvaluationAsync, grpcClient.DeleteEvaluation, effectiveSettings.DeleteEvaluationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteEvaluation);
            Modify_DeleteEvaluationApiCall(ref _callDeleteEvaluation);
            _callDeleteEvaluationResult = clientHelper.BuildApiCall<DeleteEvaluationResultRequest, wkt::Empty>("DeleteEvaluationResult", grpcClient.DeleteEvaluationResultAsync, grpcClient.DeleteEvaluationResult, effectiveSettings.DeleteEvaluationResultSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteEvaluationResult);
            Modify_DeleteEvaluationResultApiCall(ref _callDeleteEvaluationResult);
            _callDeleteEvaluationDataset = clientHelper.BuildApiCall<DeleteEvaluationDatasetRequest, wkt::Empty>("DeleteEvaluationDataset", grpcClient.DeleteEvaluationDatasetAsync, grpcClient.DeleteEvaluationDataset, effectiveSettings.DeleteEvaluationDatasetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteEvaluationDataset);
            Modify_DeleteEvaluationDatasetApiCall(ref _callDeleteEvaluationDataset);
            _callDeleteEvaluationRun = clientHelper.BuildApiCall<DeleteEvaluationRunRequest, lro::Operation>("DeleteEvaluationRun", grpcClient.DeleteEvaluationRunAsync, grpcClient.DeleteEvaluationRun, effectiveSettings.DeleteEvaluationRunSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteEvaluationRun);
            Modify_DeleteEvaluationRunApiCall(ref _callDeleteEvaluationRun);
            _callGetEvaluation = clientHelper.BuildApiCall<GetEvaluationRequest, Evaluation>("GetEvaluation", grpcClient.GetEvaluationAsync, grpcClient.GetEvaluation, effectiveSettings.GetEvaluationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEvaluation);
            Modify_GetEvaluationApiCall(ref _callGetEvaluation);
            _callGetEvaluationResult = clientHelper.BuildApiCall<GetEvaluationResultRequest, EvaluationResult>("GetEvaluationResult", grpcClient.GetEvaluationResultAsync, grpcClient.GetEvaluationResult, effectiveSettings.GetEvaluationResultSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEvaluationResult);
            Modify_GetEvaluationResultApiCall(ref _callGetEvaluationResult);
            _callGetEvaluationDataset = clientHelper.BuildApiCall<GetEvaluationDatasetRequest, EvaluationDataset>("GetEvaluationDataset", grpcClient.GetEvaluationDatasetAsync, grpcClient.GetEvaluationDataset, effectiveSettings.GetEvaluationDatasetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEvaluationDataset);
            Modify_GetEvaluationDatasetApiCall(ref _callGetEvaluationDataset);
            _callGetEvaluationRun = clientHelper.BuildApiCall<GetEvaluationRunRequest, EvaluationRun>("GetEvaluationRun", grpcClient.GetEvaluationRunAsync, grpcClient.GetEvaluationRun, effectiveSettings.GetEvaluationRunSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEvaluationRun);
            Modify_GetEvaluationRunApiCall(ref _callGetEvaluationRun);
            _callListEvaluations = clientHelper.BuildApiCall<ListEvaluationsRequest, ListEvaluationsResponse>("ListEvaluations", grpcClient.ListEvaluationsAsync, grpcClient.ListEvaluations, effectiveSettings.ListEvaluationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEvaluations);
            Modify_ListEvaluationsApiCall(ref _callListEvaluations);
            _callListEvaluationResults = clientHelper.BuildApiCall<ListEvaluationResultsRequest, ListEvaluationResultsResponse>("ListEvaluationResults", grpcClient.ListEvaluationResultsAsync, grpcClient.ListEvaluationResults, effectiveSettings.ListEvaluationResultsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEvaluationResults);
            Modify_ListEvaluationResultsApiCall(ref _callListEvaluationResults);
            _callListEvaluationDatasets = clientHelper.BuildApiCall<ListEvaluationDatasetsRequest, ListEvaluationDatasetsResponse>("ListEvaluationDatasets", grpcClient.ListEvaluationDatasetsAsync, grpcClient.ListEvaluationDatasets, effectiveSettings.ListEvaluationDatasetsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEvaluationDatasets);
            Modify_ListEvaluationDatasetsApiCall(ref _callListEvaluationDatasets);
            _callListEvaluationRuns = clientHelper.BuildApiCall<ListEvaluationRunsRequest, ListEvaluationRunsResponse>("ListEvaluationRuns", grpcClient.ListEvaluationRunsAsync, grpcClient.ListEvaluationRuns, effectiveSettings.ListEvaluationRunsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEvaluationRuns);
            Modify_ListEvaluationRunsApiCall(ref _callListEvaluationRuns);
            _callListEvaluationExpectations = clientHelper.BuildApiCall<ListEvaluationExpectationsRequest, ListEvaluationExpectationsResponse>("ListEvaluationExpectations", grpcClient.ListEvaluationExpectationsAsync, grpcClient.ListEvaluationExpectations, effectiveSettings.ListEvaluationExpectationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEvaluationExpectations);
            Modify_ListEvaluationExpectationsApiCall(ref _callListEvaluationExpectations);
            _callGetEvaluationExpectation = clientHelper.BuildApiCall<GetEvaluationExpectationRequest, EvaluationExpectation>("GetEvaluationExpectation", grpcClient.GetEvaluationExpectationAsync, grpcClient.GetEvaluationExpectation, effectiveSettings.GetEvaluationExpectationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEvaluationExpectation);
            Modify_GetEvaluationExpectationApiCall(ref _callGetEvaluationExpectation);
            _callCreateEvaluationExpectation = clientHelper.BuildApiCall<CreateEvaluationExpectationRequest, EvaluationExpectation>("CreateEvaluationExpectation", grpcClient.CreateEvaluationExpectationAsync, grpcClient.CreateEvaluationExpectation, effectiveSettings.CreateEvaluationExpectationSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateEvaluationExpectation);
            Modify_CreateEvaluationExpectationApiCall(ref _callCreateEvaluationExpectation);
            _callUpdateEvaluationExpectation = clientHelper.BuildApiCall<UpdateEvaluationExpectationRequest, EvaluationExpectation>("UpdateEvaluationExpectation", grpcClient.UpdateEvaluationExpectationAsync, grpcClient.UpdateEvaluationExpectation, effectiveSettings.UpdateEvaluationExpectationSettings).WithGoogleRequestParam("evaluation_expectation.name", request => request.EvaluationExpectation?.Name);
            Modify_ApiCall(ref _callUpdateEvaluationExpectation);
            Modify_UpdateEvaluationExpectationApiCall(ref _callUpdateEvaluationExpectation);
            _callDeleteEvaluationExpectation = clientHelper.BuildApiCall<DeleteEvaluationExpectationRequest, wkt::Empty>("DeleteEvaluationExpectation", grpcClient.DeleteEvaluationExpectationAsync, grpcClient.DeleteEvaluationExpectation, effectiveSettings.DeleteEvaluationExpectationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteEvaluationExpectation);
            Modify_DeleteEvaluationExpectationApiCall(ref _callDeleteEvaluationExpectation);
            _callCreateScheduledEvaluationRun = clientHelper.BuildApiCall<CreateScheduledEvaluationRunRequest, ScheduledEvaluationRun>("CreateScheduledEvaluationRun", grpcClient.CreateScheduledEvaluationRunAsync, grpcClient.CreateScheduledEvaluationRun, effectiveSettings.CreateScheduledEvaluationRunSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateScheduledEvaluationRun);
            Modify_CreateScheduledEvaluationRunApiCall(ref _callCreateScheduledEvaluationRun);
            _callGetScheduledEvaluationRun = clientHelper.BuildApiCall<GetScheduledEvaluationRunRequest, ScheduledEvaluationRun>("GetScheduledEvaluationRun", grpcClient.GetScheduledEvaluationRunAsync, grpcClient.GetScheduledEvaluationRun, effectiveSettings.GetScheduledEvaluationRunSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetScheduledEvaluationRun);
            Modify_GetScheduledEvaluationRunApiCall(ref _callGetScheduledEvaluationRun);
            _callListScheduledEvaluationRuns = clientHelper.BuildApiCall<ListScheduledEvaluationRunsRequest, ListScheduledEvaluationRunsResponse>("ListScheduledEvaluationRuns", grpcClient.ListScheduledEvaluationRunsAsync, grpcClient.ListScheduledEvaluationRuns, effectiveSettings.ListScheduledEvaluationRunsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListScheduledEvaluationRuns);
            Modify_ListScheduledEvaluationRunsApiCall(ref _callListScheduledEvaluationRuns);
            _callUpdateScheduledEvaluationRun = clientHelper.BuildApiCall<UpdateScheduledEvaluationRunRequest, ScheduledEvaluationRun>("UpdateScheduledEvaluationRun", grpcClient.UpdateScheduledEvaluationRunAsync, grpcClient.UpdateScheduledEvaluationRun, effectiveSettings.UpdateScheduledEvaluationRunSettings).WithGoogleRequestParam("scheduled_evaluation_run.name", request => request.ScheduledEvaluationRun?.Name);
            Modify_ApiCall(ref _callUpdateScheduledEvaluationRun);
            Modify_UpdateScheduledEvaluationRunApiCall(ref _callUpdateScheduledEvaluationRun);
            _callDeleteScheduledEvaluationRun = clientHelper.BuildApiCall<DeleteScheduledEvaluationRunRequest, wkt::Empty>("DeleteScheduledEvaluationRun", grpcClient.DeleteScheduledEvaluationRunAsync, grpcClient.DeleteScheduledEvaluationRun, effectiveSettings.DeleteScheduledEvaluationRunSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteScheduledEvaluationRun);
            Modify_DeleteScheduledEvaluationRunApiCall(ref _callDeleteScheduledEvaluationRun);
            _callTestPersonaVoice = clientHelper.BuildApiCall<TestPersonaVoiceRequest, TestPersonaVoiceResponse>("TestPersonaVoice", grpcClient.TestPersonaVoiceAsync, grpcClient.TestPersonaVoice, effectiveSettings.TestPersonaVoiceSettings).WithGoogleRequestParam("app", request => request.App);
            Modify_ApiCall(ref _callTestPersonaVoice);
            Modify_TestPersonaVoiceApiCall(ref _callTestPersonaVoice);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_RunEvaluationApiCall(ref gaxgrpc::ApiCall<RunEvaluationRequest, lro::Operation> call);

        partial void Modify_UploadEvaluationAudioApiCall(ref gaxgrpc::ApiCall<UploadEvaluationAudioRequest, UploadEvaluationAudioResponse> call);

        partial void Modify_CreateEvaluationApiCall(ref gaxgrpc::ApiCall<CreateEvaluationRequest, Evaluation> call);

        partial void Modify_GenerateEvaluationApiCall(ref gaxgrpc::ApiCall<GenerateEvaluationRequest, lro::Operation> call);

        partial void Modify_ImportEvaluationsApiCall(ref gaxgrpc::ApiCall<ImportEvaluationsRequest, lro::Operation> call);

        partial void Modify_CreateEvaluationDatasetApiCall(ref gaxgrpc::ApiCall<CreateEvaluationDatasetRequest, EvaluationDataset> call);

        partial void Modify_UpdateEvaluationApiCall(ref gaxgrpc::ApiCall<UpdateEvaluationRequest, Evaluation> call);

        partial void Modify_UpdateEvaluationDatasetApiCall(ref gaxgrpc::ApiCall<UpdateEvaluationDatasetRequest, EvaluationDataset> call);

        partial void Modify_DeleteEvaluationApiCall(ref gaxgrpc::ApiCall<DeleteEvaluationRequest, wkt::Empty> call);

        partial void Modify_DeleteEvaluationResultApiCall(ref gaxgrpc::ApiCall<DeleteEvaluationResultRequest, wkt::Empty> call);

        partial void Modify_DeleteEvaluationDatasetApiCall(ref gaxgrpc::ApiCall<DeleteEvaluationDatasetRequest, wkt::Empty> call);

        partial void Modify_DeleteEvaluationRunApiCall(ref gaxgrpc::ApiCall<DeleteEvaluationRunRequest, lro::Operation> call);

        partial void Modify_GetEvaluationApiCall(ref gaxgrpc::ApiCall<GetEvaluationRequest, Evaluation> call);

        partial void Modify_GetEvaluationResultApiCall(ref gaxgrpc::ApiCall<GetEvaluationResultRequest, EvaluationResult> call);

        partial void Modify_GetEvaluationDatasetApiCall(ref gaxgrpc::ApiCall<GetEvaluationDatasetRequest, EvaluationDataset> call);

        partial void Modify_GetEvaluationRunApiCall(ref gaxgrpc::ApiCall<GetEvaluationRunRequest, EvaluationRun> call);

        partial void Modify_ListEvaluationsApiCall(ref gaxgrpc::ApiCall<ListEvaluationsRequest, ListEvaluationsResponse> call);

        partial void Modify_ListEvaluationResultsApiCall(ref gaxgrpc::ApiCall<ListEvaluationResultsRequest, ListEvaluationResultsResponse> call);

        partial void Modify_ListEvaluationDatasetsApiCall(ref gaxgrpc::ApiCall<ListEvaluationDatasetsRequest, ListEvaluationDatasetsResponse> call);

        partial void Modify_ListEvaluationRunsApiCall(ref gaxgrpc::ApiCall<ListEvaluationRunsRequest, ListEvaluationRunsResponse> call);

        partial void Modify_ListEvaluationExpectationsApiCall(ref gaxgrpc::ApiCall<ListEvaluationExpectationsRequest, ListEvaluationExpectationsResponse> call);

        partial void Modify_GetEvaluationExpectationApiCall(ref gaxgrpc::ApiCall<GetEvaluationExpectationRequest, EvaluationExpectation> call);

        partial void Modify_CreateEvaluationExpectationApiCall(ref gaxgrpc::ApiCall<CreateEvaluationExpectationRequest, EvaluationExpectation> call);

        partial void Modify_UpdateEvaluationExpectationApiCall(ref gaxgrpc::ApiCall<UpdateEvaluationExpectationRequest, EvaluationExpectation> call);

        partial void Modify_DeleteEvaluationExpectationApiCall(ref gaxgrpc::ApiCall<DeleteEvaluationExpectationRequest, wkt::Empty> call);

        partial void Modify_CreateScheduledEvaluationRunApiCall(ref gaxgrpc::ApiCall<CreateScheduledEvaluationRunRequest, ScheduledEvaluationRun> call);

        partial void Modify_GetScheduledEvaluationRunApiCall(ref gaxgrpc::ApiCall<GetScheduledEvaluationRunRequest, ScheduledEvaluationRun> call);

        partial void Modify_ListScheduledEvaluationRunsApiCall(ref gaxgrpc::ApiCall<ListScheduledEvaluationRunsRequest, ListScheduledEvaluationRunsResponse> call);

        partial void Modify_UpdateScheduledEvaluationRunApiCall(ref gaxgrpc::ApiCall<UpdateScheduledEvaluationRunRequest, ScheduledEvaluationRun> call);

        partial void Modify_DeleteScheduledEvaluationRunApiCall(ref gaxgrpc::ApiCall<DeleteScheduledEvaluationRunRequest, wkt::Empty> call);

        partial void Modify_TestPersonaVoiceApiCall(ref gaxgrpc::ApiCall<TestPersonaVoiceRequest, TestPersonaVoiceResponse> call);

        partial void OnConstruction(EvaluationService.EvaluationServiceClient grpcClient, EvaluationServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC EvaluationService client</summary>
        public override EvaluationService.EvaluationServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_RunEvaluationRequest(ref RunEvaluationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UploadEvaluationAudioRequest(ref UploadEvaluationAudioRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateEvaluationRequest(ref CreateEvaluationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateEvaluationRequest(ref GenerateEvaluationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportEvaluationsRequest(ref ImportEvaluationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateEvaluationDatasetRequest(ref CreateEvaluationDatasetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateEvaluationRequest(ref UpdateEvaluationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateEvaluationDatasetRequest(ref UpdateEvaluationDatasetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteEvaluationRequest(ref DeleteEvaluationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteEvaluationResultRequest(ref DeleteEvaluationResultRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteEvaluationDatasetRequest(ref DeleteEvaluationDatasetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteEvaluationRunRequest(ref DeleteEvaluationRunRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEvaluationRequest(ref GetEvaluationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEvaluationResultRequest(ref GetEvaluationResultRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEvaluationDatasetRequest(ref GetEvaluationDatasetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEvaluationRunRequest(ref GetEvaluationRunRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEvaluationsRequest(ref ListEvaluationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEvaluationResultsRequest(ref ListEvaluationResultsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEvaluationDatasetsRequest(ref ListEvaluationDatasetsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEvaluationRunsRequest(ref ListEvaluationRunsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEvaluationExpectationsRequest(ref ListEvaluationExpectationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEvaluationExpectationRequest(ref GetEvaluationExpectationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateEvaluationExpectationRequest(ref CreateEvaluationExpectationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateEvaluationExpectationRequest(ref UpdateEvaluationExpectationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteEvaluationExpectationRequest(ref DeleteEvaluationExpectationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateScheduledEvaluationRunRequest(ref CreateScheduledEvaluationRunRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetScheduledEvaluationRunRequest(ref GetScheduledEvaluationRunRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListScheduledEvaluationRunsRequest(ref ListScheduledEvaluationRunsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateScheduledEvaluationRunRequest(ref UpdateScheduledEvaluationRunRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteScheduledEvaluationRunRequest(ref DeleteScheduledEvaluationRunRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TestPersonaVoiceRequest(ref TestPersonaVoiceRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>RunEvaluation</c>.</summary>
        public override lro::OperationsClient RunEvaluationOperationsClient { get; }

        /// <summary>
        /// Runs an evaluation of the app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<RunEvaluationResponse, RunEvaluationOperationMetadata> RunEvaluation(RunEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunEvaluationRequest(ref request, ref callSettings);
            return new lro::Operation<RunEvaluationResponse, RunEvaluationOperationMetadata>(_callRunEvaluation.Sync(request, callSettings), RunEvaluationOperationsClient);
        }

        /// <summary>
        /// Runs an evaluation of the app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<RunEvaluationResponse, RunEvaluationOperationMetadata>> RunEvaluationAsync(RunEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunEvaluationRequest(ref request, ref callSettings);
            return new lro::Operation<RunEvaluationResponse, RunEvaluationOperationMetadata>(await _callRunEvaluation.Async(request, callSettings).ConfigureAwait(false), RunEvaluationOperationsClient);
        }

        /// <summary>
        /// Uploads audio for use in Golden Evaluations. Stores the audio in the Cloud
        /// Storage bucket defined in
        /// 'App.logging_settings.evaluation_audio_recording_config.gcs_bucket' and
        /// returns a transcript.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UploadEvaluationAudioResponse UploadEvaluationAudio(UploadEvaluationAudioRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UploadEvaluationAudioRequest(ref request, ref callSettings);
            return _callUploadEvaluationAudio.Sync(request, callSettings);
        }

        /// <summary>
        /// Uploads audio for use in Golden Evaluations. Stores the audio in the Cloud
        /// Storage bucket defined in
        /// 'App.logging_settings.evaluation_audio_recording_config.gcs_bucket' and
        /// returns a transcript.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UploadEvaluationAudioResponse> UploadEvaluationAudioAsync(UploadEvaluationAudioRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UploadEvaluationAudioRequest(ref request, ref callSettings);
            return _callUploadEvaluationAudio.Async(request, callSettings);
        }

        /// <summary>
        /// Creates an evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Evaluation CreateEvaluation(CreateEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEvaluationRequest(ref request, ref callSettings);
            return _callCreateEvaluation.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Evaluation> CreateEvaluationAsync(CreateEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEvaluationRequest(ref request, ref callSettings);
            return _callCreateEvaluation.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>GenerateEvaluation</c>.</summary>
        public override lro::OperationsClient GenerateEvaluationOperationsClient { get; }

        /// <summary>
        /// Creates a golden evaluation from a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Evaluation, GenerateEvaluationOperationMetadata> GenerateEvaluation(GenerateEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateEvaluationRequest(ref request, ref callSettings);
            return new lro::Operation<Evaluation, GenerateEvaluationOperationMetadata>(_callGenerateEvaluation.Sync(request, callSettings), GenerateEvaluationOperationsClient);
        }

        /// <summary>
        /// Creates a golden evaluation from a conversation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Evaluation, GenerateEvaluationOperationMetadata>> GenerateEvaluationAsync(GenerateEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateEvaluationRequest(ref request, ref callSettings);
            return new lro::Operation<Evaluation, GenerateEvaluationOperationMetadata>(await _callGenerateEvaluation.Async(request, callSettings).ConfigureAwait(false), GenerateEvaluationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ImportEvaluations</c>.</summary>
        public override lro::OperationsClient ImportEvaluationsOperationsClient { get; }

        /// <summary>
        /// Imports evaluations into the app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ImportEvaluationsResponse, ImportEvaluationsOperationMetadata> ImportEvaluations(ImportEvaluationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportEvaluationsRequest(ref request, ref callSettings);
            return new lro::Operation<ImportEvaluationsResponse, ImportEvaluationsOperationMetadata>(_callImportEvaluations.Sync(request, callSettings), ImportEvaluationsOperationsClient);
        }

        /// <summary>
        /// Imports evaluations into the app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ImportEvaluationsResponse, ImportEvaluationsOperationMetadata>> ImportEvaluationsAsync(ImportEvaluationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportEvaluationsRequest(ref request, ref callSettings);
            return new lro::Operation<ImportEvaluationsResponse, ImportEvaluationsOperationMetadata>(await _callImportEvaluations.Async(request, callSettings).ConfigureAwait(false), ImportEvaluationsOperationsClient);
        }

        /// <summary>
        /// Creates an evaluation dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EvaluationDataset CreateEvaluationDataset(CreateEvaluationDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEvaluationDatasetRequest(ref request, ref callSettings);
            return _callCreateEvaluationDataset.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an evaluation dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EvaluationDataset> CreateEvaluationDatasetAsync(CreateEvaluationDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEvaluationDatasetRequest(ref request, ref callSettings);
            return _callCreateEvaluationDataset.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Evaluation UpdateEvaluation(UpdateEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEvaluationRequest(ref request, ref callSettings);
            return _callUpdateEvaluation.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Evaluation> UpdateEvaluationAsync(UpdateEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEvaluationRequest(ref request, ref callSettings);
            return _callUpdateEvaluation.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an evaluation dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EvaluationDataset UpdateEvaluationDataset(UpdateEvaluationDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEvaluationDatasetRequest(ref request, ref callSettings);
            return _callUpdateEvaluationDataset.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an evaluation dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EvaluationDataset> UpdateEvaluationDatasetAsync(UpdateEvaluationDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEvaluationDatasetRequest(ref request, ref callSettings);
            return _callUpdateEvaluationDataset.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteEvaluation(DeleteEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEvaluationRequest(ref request, ref callSettings);
            _callDeleteEvaluation.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteEvaluationAsync(DeleteEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEvaluationRequest(ref request, ref callSettings);
            return _callDeleteEvaluation.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an evaluation result.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteEvaluationResult(DeleteEvaluationResultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEvaluationResultRequest(ref request, ref callSettings);
            _callDeleteEvaluationResult.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an evaluation result.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteEvaluationResultAsync(DeleteEvaluationResultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEvaluationResultRequest(ref request, ref callSettings);
            return _callDeleteEvaluationResult.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an evaluation dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteEvaluationDataset(DeleteEvaluationDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEvaluationDatasetRequest(ref request, ref callSettings);
            _callDeleteEvaluationDataset.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an evaluation dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteEvaluationDatasetAsync(DeleteEvaluationDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEvaluationDatasetRequest(ref request, ref callSettings);
            return _callDeleteEvaluationDataset.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteEvaluationRun</c>.</summary>
        public override lro::OperationsClient DeleteEvaluationRunOperationsClient { get; }

        /// <summary>
        /// Deletes an evaluation run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteEvaluationRunOperationMetadata> DeleteEvaluationRun(DeleteEvaluationRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEvaluationRunRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteEvaluationRunOperationMetadata>(_callDeleteEvaluationRun.Sync(request, callSettings), DeleteEvaluationRunOperationsClient);
        }

        /// <summary>
        /// Deletes an evaluation run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteEvaluationRunOperationMetadata>> DeleteEvaluationRunAsync(DeleteEvaluationRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEvaluationRunRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteEvaluationRunOperationMetadata>(await _callDeleteEvaluationRun.Async(request, callSettings).ConfigureAwait(false), DeleteEvaluationRunOperationsClient);
        }

        /// <summary>
        /// Gets details of the specified evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Evaluation GetEvaluation(GetEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEvaluationRequest(ref request, ref callSettings);
            return _callGetEvaluation.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Evaluation> GetEvaluationAsync(GetEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEvaluationRequest(ref request, ref callSettings);
            return _callGetEvaluation.Async(request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified evaluation result.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EvaluationResult GetEvaluationResult(GetEvaluationResultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEvaluationResultRequest(ref request, ref callSettings);
            return _callGetEvaluationResult.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified evaluation result.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EvaluationResult> GetEvaluationResultAsync(GetEvaluationResultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEvaluationResultRequest(ref request, ref callSettings);
            return _callGetEvaluationResult.Async(request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified evaluation dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EvaluationDataset GetEvaluationDataset(GetEvaluationDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEvaluationDatasetRequest(ref request, ref callSettings);
            return _callGetEvaluationDataset.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified evaluation dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EvaluationDataset> GetEvaluationDatasetAsync(GetEvaluationDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEvaluationDatasetRequest(ref request, ref callSettings);
            return _callGetEvaluationDataset.Async(request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified evaluation run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EvaluationRun GetEvaluationRun(GetEvaluationRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEvaluationRunRequest(ref request, ref callSettings);
            return _callGetEvaluationRun.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified evaluation run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EvaluationRun> GetEvaluationRunAsync(GetEvaluationRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEvaluationRunRequest(ref request, ref callSettings);
            return _callGetEvaluationRun.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all evaluations in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Evaluation"/> resources.</returns>
        public override gax::PagedEnumerable<ListEvaluationsResponse, Evaluation> ListEvaluations(ListEvaluationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEvaluationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEvaluationsRequest, ListEvaluationsResponse, Evaluation>(_callListEvaluations, request, callSettings);
        }

        /// <summary>
        /// Lists all evaluations in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Evaluation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEvaluationsResponse, Evaluation> ListEvaluationsAsync(ListEvaluationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEvaluationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEvaluationsRequest, ListEvaluationsResponse, Evaluation>(_callListEvaluations, request, callSettings);
        }

        /// <summary>
        /// Lists all evaluation results for a given evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EvaluationResult"/> resources.</returns>
        public override gax::PagedEnumerable<ListEvaluationResultsResponse, EvaluationResult> ListEvaluationResults(ListEvaluationResultsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEvaluationResultsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEvaluationResultsRequest, ListEvaluationResultsResponse, EvaluationResult>(_callListEvaluationResults, request, callSettings);
        }

        /// <summary>
        /// Lists all evaluation results for a given evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EvaluationResult"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEvaluationResultsResponse, EvaluationResult> ListEvaluationResultsAsync(ListEvaluationResultsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEvaluationResultsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEvaluationResultsRequest, ListEvaluationResultsResponse, EvaluationResult>(_callListEvaluationResults, request, callSettings);
        }

        /// <summary>
        /// Lists all evaluation datasets in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EvaluationDataset"/> resources.</returns>
        public override gax::PagedEnumerable<ListEvaluationDatasetsResponse, EvaluationDataset> ListEvaluationDatasets(ListEvaluationDatasetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEvaluationDatasetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEvaluationDatasetsRequest, ListEvaluationDatasetsResponse, EvaluationDataset>(_callListEvaluationDatasets, request, callSettings);
        }

        /// <summary>
        /// Lists all evaluation datasets in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EvaluationDataset"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEvaluationDatasetsResponse, EvaluationDataset> ListEvaluationDatasetsAsync(ListEvaluationDatasetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEvaluationDatasetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEvaluationDatasetsRequest, ListEvaluationDatasetsResponse, EvaluationDataset>(_callListEvaluationDatasets, request, callSettings);
        }

        /// <summary>
        /// Lists all evaluation runs in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EvaluationRun"/> resources.</returns>
        public override gax::PagedEnumerable<ListEvaluationRunsResponse, EvaluationRun> ListEvaluationRuns(ListEvaluationRunsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEvaluationRunsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEvaluationRunsRequest, ListEvaluationRunsResponse, EvaluationRun>(_callListEvaluationRuns, request, callSettings);
        }

        /// <summary>
        /// Lists all evaluation runs in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EvaluationRun"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEvaluationRunsResponse, EvaluationRun> ListEvaluationRunsAsync(ListEvaluationRunsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEvaluationRunsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEvaluationRunsRequest, ListEvaluationRunsResponse, EvaluationRun>(_callListEvaluationRuns, request, callSettings);
        }

        /// <summary>
        /// Lists all evaluation expectations in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EvaluationExpectation"/> resources.</returns>
        public override gax::PagedEnumerable<ListEvaluationExpectationsResponse, EvaluationExpectation> ListEvaluationExpectations(ListEvaluationExpectationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEvaluationExpectationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEvaluationExpectationsRequest, ListEvaluationExpectationsResponse, EvaluationExpectation>(_callListEvaluationExpectations, request, callSettings);
        }

        /// <summary>
        /// Lists all evaluation expectations in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EvaluationExpectation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEvaluationExpectationsResponse, EvaluationExpectation> ListEvaluationExpectationsAsync(ListEvaluationExpectationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEvaluationExpectationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEvaluationExpectationsRequest, ListEvaluationExpectationsResponse, EvaluationExpectation>(_callListEvaluationExpectations, request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified evaluation expectation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EvaluationExpectation GetEvaluationExpectation(GetEvaluationExpectationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEvaluationExpectationRequest(ref request, ref callSettings);
            return _callGetEvaluationExpectation.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified evaluation expectation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EvaluationExpectation> GetEvaluationExpectationAsync(GetEvaluationExpectationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEvaluationExpectationRequest(ref request, ref callSettings);
            return _callGetEvaluationExpectation.Async(request, callSettings);
        }

        /// <summary>
        /// Creates an evaluation expectation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EvaluationExpectation CreateEvaluationExpectation(CreateEvaluationExpectationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEvaluationExpectationRequest(ref request, ref callSettings);
            return _callCreateEvaluationExpectation.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an evaluation expectation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EvaluationExpectation> CreateEvaluationExpectationAsync(CreateEvaluationExpectationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEvaluationExpectationRequest(ref request, ref callSettings);
            return _callCreateEvaluationExpectation.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an evaluation expectation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EvaluationExpectation UpdateEvaluationExpectation(UpdateEvaluationExpectationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEvaluationExpectationRequest(ref request, ref callSettings);
            return _callUpdateEvaluationExpectation.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an evaluation expectation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EvaluationExpectation> UpdateEvaluationExpectationAsync(UpdateEvaluationExpectationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEvaluationExpectationRequest(ref request, ref callSettings);
            return _callUpdateEvaluationExpectation.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an evaluation expectation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteEvaluationExpectation(DeleteEvaluationExpectationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEvaluationExpectationRequest(ref request, ref callSettings);
            _callDeleteEvaluationExpectation.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an evaluation expectation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteEvaluationExpectationAsync(DeleteEvaluationExpectationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEvaluationExpectationRequest(ref request, ref callSettings);
            return _callDeleteEvaluationExpectation.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a scheduled evaluation run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ScheduledEvaluationRun CreateScheduledEvaluationRun(CreateScheduledEvaluationRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateScheduledEvaluationRunRequest(ref request, ref callSettings);
            return _callCreateScheduledEvaluationRun.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a scheduled evaluation run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ScheduledEvaluationRun> CreateScheduledEvaluationRunAsync(CreateScheduledEvaluationRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateScheduledEvaluationRunRequest(ref request, ref callSettings);
            return _callCreateScheduledEvaluationRun.Async(request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified scheduled evaluation run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ScheduledEvaluationRun GetScheduledEvaluationRun(GetScheduledEvaluationRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetScheduledEvaluationRunRequest(ref request, ref callSettings);
            return _callGetScheduledEvaluationRun.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of the specified scheduled evaluation run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ScheduledEvaluationRun> GetScheduledEvaluationRunAsync(GetScheduledEvaluationRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetScheduledEvaluationRunRequest(ref request, ref callSettings);
            return _callGetScheduledEvaluationRun.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all scheduled evaluation runs in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ScheduledEvaluationRun"/> resources.</returns>
        public override gax::PagedEnumerable<ListScheduledEvaluationRunsResponse, ScheduledEvaluationRun> ListScheduledEvaluationRuns(ListScheduledEvaluationRunsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListScheduledEvaluationRunsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListScheduledEvaluationRunsRequest, ListScheduledEvaluationRunsResponse, ScheduledEvaluationRun>(_callListScheduledEvaluationRuns, request, callSettings);
        }

        /// <summary>
        /// Lists all scheduled evaluation runs in the given app.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ScheduledEvaluationRun"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListScheduledEvaluationRunsResponse, ScheduledEvaluationRun> ListScheduledEvaluationRunsAsync(ListScheduledEvaluationRunsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListScheduledEvaluationRunsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListScheduledEvaluationRunsRequest, ListScheduledEvaluationRunsResponse, ScheduledEvaluationRun>(_callListScheduledEvaluationRuns, request, callSettings);
        }

        /// <summary>
        /// Updates a scheduled evaluation run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ScheduledEvaluationRun UpdateScheduledEvaluationRun(UpdateScheduledEvaluationRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateScheduledEvaluationRunRequest(ref request, ref callSettings);
            return _callUpdateScheduledEvaluationRun.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a scheduled evaluation run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ScheduledEvaluationRun> UpdateScheduledEvaluationRunAsync(UpdateScheduledEvaluationRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateScheduledEvaluationRunRequest(ref request, ref callSettings);
            return _callUpdateScheduledEvaluationRun.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a scheduled evaluation run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteScheduledEvaluationRun(DeleteScheduledEvaluationRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteScheduledEvaluationRunRequest(ref request, ref callSettings);
            _callDeleteScheduledEvaluationRun.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a scheduled evaluation run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteScheduledEvaluationRunAsync(DeleteScheduledEvaluationRunRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteScheduledEvaluationRunRequest(ref request, ref callSettings);
            return _callDeleteScheduledEvaluationRun.Async(request, callSettings);
        }

        /// <summary>
        /// Tests the voice of a persona. Also accepts a default persona.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TestPersonaVoiceResponse TestPersonaVoice(TestPersonaVoiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestPersonaVoiceRequest(ref request, ref callSettings);
            return _callTestPersonaVoice.Sync(request, callSettings);
        }

        /// <summary>
        /// Tests the voice of a persona. Also accepts a default persona.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TestPersonaVoiceResponse> TestPersonaVoiceAsync(TestPersonaVoiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TestPersonaVoiceRequest(ref request, ref callSettings);
            return _callTestPersonaVoice.Async(request, callSettings);
        }
    }

    public partial class ListEvaluationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEvaluationResultsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEvaluationDatasetsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEvaluationRunsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEvaluationExpectationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListScheduledEvaluationRunsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEvaluationsResponse : gaxgrpc::IPageResponse<Evaluation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Evaluation> GetEnumerator() => Evaluations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListEvaluationResultsResponse : gaxgrpc::IPageResponse<EvaluationResult>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<EvaluationResult> GetEnumerator() => EvaluationResults.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListEvaluationDatasetsResponse : gaxgrpc::IPageResponse<EvaluationDataset>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<EvaluationDataset> GetEnumerator() => EvaluationDatasets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListEvaluationRunsResponse : gaxgrpc::IPageResponse<EvaluationRun>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<EvaluationRun> GetEnumerator() => EvaluationRuns.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListEvaluationExpectationsResponse : gaxgrpc::IPageResponse<EvaluationExpectation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<EvaluationExpectation> GetEnumerator() => EvaluationExpectations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListScheduledEvaluationRunsResponse : gaxgrpc::IPageResponse<ScheduledEvaluationRun>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ScheduledEvaluationRun> GetEnumerator() => ScheduledEvaluationRuns.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class EvaluationService
    {
        public partial class EvaluationServiceClient
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

    public static partial class EvaluationService
    {
        public partial class EvaluationServiceClient
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
        }
    }
}
