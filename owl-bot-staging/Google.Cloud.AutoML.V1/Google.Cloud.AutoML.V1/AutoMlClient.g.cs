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

namespace Google.Cloud.AutoML.V1
{
    /// <summary>Settings for <see cref="AutoMlClient"/> instances.</summary>
    public sealed partial class AutoMlSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AutoMlSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AutoMlSettings"/>.</returns>
        public static AutoMlSettings GetDefault() => new AutoMlSettings();

        /// <summary>Constructs a new <see cref="AutoMlSettings"/> object with default settings.</summary>
        public AutoMlSettings()
        {
        }

        private AutoMlSettings(AutoMlSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateDatasetSettings = existing.CreateDatasetSettings;
            CreateDatasetOperationsSettings = existing.CreateDatasetOperationsSettings.Clone();
            GetDatasetSettings = existing.GetDatasetSettings;
            ListDatasetsSettings = existing.ListDatasetsSettings;
            UpdateDatasetSettings = existing.UpdateDatasetSettings;
            DeleteDatasetSettings = existing.DeleteDatasetSettings;
            DeleteDatasetOperationsSettings = existing.DeleteDatasetOperationsSettings.Clone();
            ImportDataSettings = existing.ImportDataSettings;
            ImportDataOperationsSettings = existing.ImportDataOperationsSettings.Clone();
            ExportDataSettings = existing.ExportDataSettings;
            ExportDataOperationsSettings = existing.ExportDataOperationsSettings.Clone();
            GetAnnotationSpecSettings = existing.GetAnnotationSpecSettings;
            CreateModelSettings = existing.CreateModelSettings;
            CreateModelOperationsSettings = existing.CreateModelOperationsSettings.Clone();
            GetModelSettings = existing.GetModelSettings;
            ListModelsSettings = existing.ListModelsSettings;
            DeleteModelSettings = existing.DeleteModelSettings;
            DeleteModelOperationsSettings = existing.DeleteModelOperationsSettings.Clone();
            UpdateModelSettings = existing.UpdateModelSettings;
            DeployModelSettings = existing.DeployModelSettings;
            DeployModelOperationsSettings = existing.DeployModelOperationsSettings.Clone();
            UndeployModelSettings = existing.UndeployModelSettings;
            UndeployModelOperationsSettings = existing.UndeployModelOperationsSettings.Clone();
            ExportModelSettings = existing.ExportModelSettings;
            ExportModelOperationsSettings = existing.ExportModelOperationsSettings.Clone();
            GetModelEvaluationSettings = existing.GetModelEvaluationSettings;
            ListModelEvaluationsSettings = existing.ListModelEvaluationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AutoMlSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AutoMlClient.CreateDataset</c>
        ///  and <c>AutoMlClient.CreateDatasetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDatasetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AutoMlClient.CreateDataset</c> and
        /// <c>AutoMlClient.CreateDatasetAsync</c>.
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
        public lro::OperationsSettings CreateDatasetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AutoMlClient.GetDataset</c>
        /// and <c>AutoMlClient.GetDatasetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDatasetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AutoMlClient.ListDatasets</c>
        ///  and <c>AutoMlClient.ListDatasetsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDatasetsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AutoMlClient.UpdateDataset</c>
        ///  and <c>AutoMlClient.UpdateDatasetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDatasetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AutoMlClient.DeleteDataset</c>
        ///  and <c>AutoMlClient.DeleteDatasetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDatasetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AutoMlClient.DeleteDataset</c> and
        /// <c>AutoMlClient.DeleteDatasetAsync</c>.
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
        public lro::OperationsSettings DeleteDatasetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AutoMlClient.ImportData</c>
        /// and <c>AutoMlClient.ImportDataAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ImportDataSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AutoMlClient.ImportData</c> and
        /// <c>AutoMlClient.ImportDataAsync</c>.
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
        public lro::OperationsSettings ImportDataOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AutoMlClient.ExportData</c>
        /// and <c>AutoMlClient.ExportDataAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExportDataSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AutoMlClient.ExportData</c> and
        /// <c>AutoMlClient.ExportDataAsync</c>.
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
        public lro::OperationsSettings ExportDataOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AutoMlClient.GetAnnotationSpec</c> and <c>AutoMlClient.GetAnnotationSpecAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAnnotationSpecSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AutoMlClient.CreateModel</c>
        ///  and <c>AutoMlClient.CreateModelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateModelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AutoMlClient.CreateModel</c> and
        /// <c>AutoMlClient.CreateModelAsync</c>.
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
        public lro::OperationsSettings CreateModelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AutoMlClient.GetModel</c>
        /// and <c>AutoMlClient.GetModelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetModelSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AutoMlClient.ListModels</c>
        /// and <c>AutoMlClient.ListModelsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListModelsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AutoMlClient.DeleteModel</c>
        ///  and <c>AutoMlClient.DeleteModelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteModelSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AutoMlClient.DeleteModel</c> and
        /// <c>AutoMlClient.DeleteModelAsync</c>.
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
        public lro::OperationsSettings DeleteModelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AutoMlClient.UpdateModel</c>
        ///  and <c>AutoMlClient.UpdateModelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateModelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AutoMlClient.DeployModel</c>
        ///  and <c>AutoMlClient.DeployModelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeployModelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AutoMlClient.DeployModel</c> and
        /// <c>AutoMlClient.DeployModelAsync</c>.
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
        public lro::OperationsSettings DeployModelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AutoMlClient.UndeployModel</c>
        ///  and <c>AutoMlClient.UndeployModelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UndeployModelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AutoMlClient.UndeployModel</c> and
        /// <c>AutoMlClient.UndeployModelAsync</c>.
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
        public lro::OperationsSettings UndeployModelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AutoMlClient.ExportModel</c>
        ///  and <c>AutoMlClient.ExportModelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExportModelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>AutoMlClient.ExportModel</c> and
        /// <c>AutoMlClient.ExportModelAsync</c>.
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
        public lro::OperationsSettings ExportModelOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AutoMlClient.GetModelEvaluation</c> and <c>AutoMlClient.GetModelEvaluationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetModelEvaluationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AutoMlClient.ListModelEvaluations</c> and <c>AutoMlClient.ListModelEvaluationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 5 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListModelEvaluationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(5000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AutoMlSettings"/> object.</returns>
        public AutoMlSettings Clone() => new AutoMlSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AutoMlClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class AutoMlClientBuilder : gaxgrpc::ClientBuilderBase<AutoMlClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AutoMlSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AutoMlClientBuilder() : base(AutoMlClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AutoMlClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AutoMlClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AutoMlClient Build()
        {
            AutoMlClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AutoMlClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AutoMlClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AutoMlClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AutoMlClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AutoMlClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AutoMlClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AutoMlClient.ChannelPool;
    }

    /// <summary>AutoMl client wrapper, for convenient use.</summary>
    /// <remarks>
    /// AutoML Server API.
    /// 
    /// The resource names are assigned by the server.
    /// The server never reuses names that it has created after the resources with
    /// those names are deleted.
    /// 
    /// An ID of a resource is the last element of the item's resource name. For
    /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}`, then
    /// the id for the item is `{dataset_id}`.
    /// 
    /// Currently the only supported `location_id` is "us-central1".
    /// 
    /// On any input that is documented to expect a string parameter in
    /// snake_case or dash-case, either of those cases is accepted.
    /// </remarks>
    public abstract partial class AutoMlClient
    {
        /// <summary>
        /// The default endpoint for the AutoMl service, which is a host of "automl.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "automl.googleapis.com:443";

        /// <summary>The default AutoMl scopes.</summary>
        /// <remarks>
        /// The default AutoMl scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AutoMl.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AutoMlClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="AutoMlClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AutoMlClient"/>.</returns>
        public static stt::Task<AutoMlClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AutoMlClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AutoMlClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="AutoMlClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AutoMlClient"/>.</returns>
        public static AutoMlClient Create() => new AutoMlClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AutoMlClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AutoMlSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AutoMlClient"/>.</returns>
        internal static AutoMlClient Create(grpccore::CallInvoker callInvoker, AutoMlSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AutoMl.AutoMlClient grpcClient = new AutoMl.AutoMlClient(callInvoker);
            return new AutoMlClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AutoMl client</summary>
        public virtual AutoMl.AutoMlClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Dataset, OperationMetadata> CreateDataset(CreateDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Dataset, OperationMetadata>> CreateDatasetAsync(CreateDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Dataset, OperationMetadata>> CreateDatasetAsync(CreateDatasetRequest request, st::CancellationToken cancellationToken) =>
            CreateDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateDataset</c>.</summary>
        public virtual lro::OperationsClient CreateDatasetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateDataset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Dataset, OperationMetadata> PollOnceCreateDataset(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Dataset, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDatasetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateDataset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Dataset, OperationMetadata>> PollOnceCreateDatasetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Dataset, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDatasetOperationsClient, callSettings);

        /// <summary>
        /// Creates a dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project to create the dataset for.
        /// </param>
        /// <param name="dataset">
        /// Required. The dataset to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Dataset, OperationMetadata> CreateDataset(string parent, Dataset dataset, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataset(new CreateDatasetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Dataset = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
            }, callSettings);

        /// <summary>
        /// Creates a dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project to create the dataset for.
        /// </param>
        /// <param name="dataset">
        /// Required. The dataset to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Dataset, OperationMetadata>> CreateDatasetAsync(string parent, Dataset dataset, gaxgrpc::CallSettings callSettings = null) =>
            CreateDatasetAsync(new CreateDatasetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Dataset = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
            }, callSettings);

        /// <summary>
        /// Creates a dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project to create the dataset for.
        /// </param>
        /// <param name="dataset">
        /// Required. The dataset to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Dataset, OperationMetadata>> CreateDatasetAsync(string parent, Dataset dataset, st::CancellationToken cancellationToken) =>
            CreateDatasetAsync(parent, dataset, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project to create the dataset for.
        /// </param>
        /// <param name="dataset">
        /// Required. The dataset to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Dataset, OperationMetadata> CreateDataset(gagr::LocationName parent, Dataset dataset, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataset(new CreateDatasetRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Dataset = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
            }, callSettings);

        /// <summary>
        /// Creates a dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project to create the dataset for.
        /// </param>
        /// <param name="dataset">
        /// Required. The dataset to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Dataset, OperationMetadata>> CreateDatasetAsync(gagr::LocationName parent, Dataset dataset, gaxgrpc::CallSettings callSettings = null) =>
            CreateDatasetAsync(new CreateDatasetRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Dataset = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
            }, callSettings);

        /// <summary>
        /// Creates a dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project to create the dataset for.
        /// </param>
        /// <param name="dataset">
        /// Required. The dataset to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Dataset, OperationMetadata>> CreateDatasetAsync(gagr::LocationName parent, Dataset dataset, st::CancellationToken cancellationToken) =>
            CreateDatasetAsync(parent, dataset, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dataset GetDataset(GetDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(GetDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(GetDatasetRequest request, st::CancellationToken cancellationToken) =>
            GetDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the dataset to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dataset GetDataset(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataset(new GetDatasetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the dataset to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDatasetAsync(new GetDatasetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the dataset to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(string name, st::CancellationToken cancellationToken) =>
            GetDatasetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the dataset to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dataset GetDataset(DatasetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataset(new GetDatasetRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the dataset to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(DatasetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDatasetAsync(new GetDatasetRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the dataset to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(DatasetName name, st::CancellationToken cancellationToken) =>
            GetDatasetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists datasets in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Dataset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDatasetsResponse, Dataset> ListDatasets(ListDatasetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists datasets in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Dataset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDatasetsResponse, Dataset> ListDatasetsAsync(ListDatasetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists datasets in a project.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project from which to list datasets.
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
        /// <returns>A pageable sequence of <see cref="Dataset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDatasetsResponse, Dataset> ListDatasets(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDatasetsRequest request = new ListDatasetsRequest
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
            return ListDatasets(request, callSettings);
        }

        /// <summary>
        /// Lists datasets in a project.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project from which to list datasets.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Dataset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDatasetsResponse, Dataset> ListDatasetsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDatasetsRequest request = new ListDatasetsRequest
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
            return ListDatasetsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists datasets in a project.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project from which to list datasets.
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
        /// <returns>A pageable sequence of <see cref="Dataset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDatasetsResponse, Dataset> ListDatasets(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDatasetsRequest request = new ListDatasetsRequest
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
            return ListDatasets(request, callSettings);
        }

        /// <summary>
        /// Lists datasets in a project.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the project from which to list datasets.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Dataset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDatasetsResponse, Dataset> ListDatasetsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDatasetsRequest request = new ListDatasetsRequest
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
            return ListDatasetsAsync(request, callSettings);
        }

        /// <summary>
        /// Updates a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dataset UpdateDataset(UpdateDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> UpdateDatasetAsync(UpdateDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> UpdateDatasetAsync(UpdateDatasetRequest request, st::CancellationToken cancellationToken) =>
            UpdateDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a dataset.
        /// </summary>
        /// <param name="dataset">
        /// Required. The dataset which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dataset UpdateDataset(Dataset dataset, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDataset(new UpdateDatasetRequest
            {
                Dataset = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a dataset.
        /// </summary>
        /// <param name="dataset">
        /// Required. The dataset which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> UpdateDatasetAsync(Dataset dataset, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDatasetAsync(new UpdateDatasetRequest
            {
                Dataset = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a dataset.
        /// </summary>
        /// <param name="dataset">
        /// Required. The dataset which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> UpdateDatasetAsync(Dataset dataset, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDatasetAsync(dataset, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a dataset and all of its contents.
        /// Returns empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes,
        /// and `delete_details` in the
        /// [metadata][google.longrunning.Operation.metadata] field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDataset(DeleteDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a dataset and all of its contents.
        /// Returns empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes,
        /// and `delete_details` in the
        /// [metadata][google.longrunning.Operation.metadata] field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDatasetAsync(DeleteDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a dataset and all of its contents.
        /// Returns empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes,
        /// and `delete_details` in the
        /// [metadata][google.longrunning.Operation.metadata] field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDatasetAsync(DeleteDatasetRequest request, st::CancellationToken cancellationToken) =>
            DeleteDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteDataset</c>.</summary>
        public virtual lro::OperationsClient DeleteDatasetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteDataset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteDataset(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDatasetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteDataset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteDatasetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDatasetOperationsClient, callSettings);

        /// <summary>
        /// Deletes a dataset and all of its contents.
        /// Returns empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes,
        /// and `delete_details` in the
        /// [metadata][google.longrunning.Operation.metadata] field.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the dataset to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDataset(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataset(new DeleteDatasetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a dataset and all of its contents.
        /// Returns empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes,
        /// and `delete_details` in the
        /// [metadata][google.longrunning.Operation.metadata] field.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the dataset to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDatasetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDatasetAsync(new DeleteDatasetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a dataset and all of its contents.
        /// Returns empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes,
        /// and `delete_details` in the
        /// [metadata][google.longrunning.Operation.metadata] field.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the dataset to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDatasetAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDatasetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a dataset and all of its contents.
        /// Returns empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes,
        /// and `delete_details` in the
        /// [metadata][google.longrunning.Operation.metadata] field.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the dataset to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDataset(DatasetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataset(new DeleteDatasetRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a dataset and all of its contents.
        /// Returns empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes,
        /// and `delete_details` in the
        /// [metadata][google.longrunning.Operation.metadata] field.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the dataset to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDatasetAsync(DatasetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDatasetAsync(new DeleteDatasetRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a dataset and all of its contents.
        /// Returns empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes,
        /// and `delete_details` in the
        /// [metadata][google.longrunning.Operation.metadata] field.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the dataset to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDatasetAsync(DatasetName name, st::CancellationToken cancellationToken) =>
            DeleteDatasetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports data into a dataset.
        /// For Tables this method can only be called on an empty Dataset.
        /// 
        /// For Tables:
        /// *   A
        /// [schema_inference_version][google.cloud.automl.v1.InputConfig.params]
        /// parameter must be explicitly set.
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> ImportData(ImportDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports data into a dataset.
        /// For Tables this method can only be called on an empty Dataset.
        /// 
        /// For Tables:
        /// *   A
        /// [schema_inference_version][google.cloud.automl.v1.InputConfig.params]
        /// parameter must be explicitly set.
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> ImportDataAsync(ImportDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports data into a dataset.
        /// For Tables this method can only be called on an empty Dataset.
        /// 
        /// For Tables:
        /// *   A
        /// [schema_inference_version][google.cloud.automl.v1.InputConfig.params]
        /// parameter must be explicitly set.
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> ImportDataAsync(ImportDataRequest request, st::CancellationToken cancellationToken) =>
            ImportDataAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ImportData</c>.</summary>
        public virtual lro::OperationsClient ImportDataOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ImportData</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceImportData(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportDataOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportData</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceImportDataAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportDataOperationsClient, callSettings);

        /// <summary>
        /// Imports data into a dataset.
        /// For Tables this method can only be called on an empty Dataset.
        /// 
        /// For Tables:
        /// *   A
        /// [schema_inference_version][google.cloud.automl.v1.InputConfig.params]
        /// parameter must be explicitly set.
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="name">
        /// Required. Dataset name. Dataset must already exist. All imported
        /// annotations and examples will be added.
        /// </param>
        /// <param name="inputConfig">
        /// Required. The desired input location and its domain specific semantics,
        /// if any.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> ImportData(string name, InputConfig inputConfig, gaxgrpc::CallSettings callSettings = null) =>
            ImportData(new ImportDataRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                InputConfig = gax::GaxPreconditions.CheckNotNull(inputConfig, nameof(inputConfig)),
            }, callSettings);

        /// <summary>
        /// Imports data into a dataset.
        /// For Tables this method can only be called on an empty Dataset.
        /// 
        /// For Tables:
        /// *   A
        /// [schema_inference_version][google.cloud.automl.v1.InputConfig.params]
        /// parameter must be explicitly set.
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="name">
        /// Required. Dataset name. Dataset must already exist. All imported
        /// annotations and examples will be added.
        /// </param>
        /// <param name="inputConfig">
        /// Required. The desired input location and its domain specific semantics,
        /// if any.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> ImportDataAsync(string name, InputConfig inputConfig, gaxgrpc::CallSettings callSettings = null) =>
            ImportDataAsync(new ImportDataRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                InputConfig = gax::GaxPreconditions.CheckNotNull(inputConfig, nameof(inputConfig)),
            }, callSettings);

        /// <summary>
        /// Imports data into a dataset.
        /// For Tables this method can only be called on an empty Dataset.
        /// 
        /// For Tables:
        /// *   A
        /// [schema_inference_version][google.cloud.automl.v1.InputConfig.params]
        /// parameter must be explicitly set.
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="name">
        /// Required. Dataset name. Dataset must already exist. All imported
        /// annotations and examples will be added.
        /// </param>
        /// <param name="inputConfig">
        /// Required. The desired input location and its domain specific semantics,
        /// if any.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> ImportDataAsync(string name, InputConfig inputConfig, st::CancellationToken cancellationToken) =>
            ImportDataAsync(name, inputConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports data into a dataset.
        /// For Tables this method can only be called on an empty Dataset.
        /// 
        /// For Tables:
        /// *   A
        /// [schema_inference_version][google.cloud.automl.v1.InputConfig.params]
        /// parameter must be explicitly set.
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="name">
        /// Required. Dataset name. Dataset must already exist. All imported
        /// annotations and examples will be added.
        /// </param>
        /// <param name="inputConfig">
        /// Required. The desired input location and its domain specific semantics,
        /// if any.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> ImportData(DatasetName name, InputConfig inputConfig, gaxgrpc::CallSettings callSettings = null) =>
            ImportData(new ImportDataRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                InputConfig = gax::GaxPreconditions.CheckNotNull(inputConfig, nameof(inputConfig)),
            }, callSettings);

        /// <summary>
        /// Imports data into a dataset.
        /// For Tables this method can only be called on an empty Dataset.
        /// 
        /// For Tables:
        /// *   A
        /// [schema_inference_version][google.cloud.automl.v1.InputConfig.params]
        /// parameter must be explicitly set.
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="name">
        /// Required. Dataset name. Dataset must already exist. All imported
        /// annotations and examples will be added.
        /// </param>
        /// <param name="inputConfig">
        /// Required. The desired input location and its domain specific semantics,
        /// if any.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> ImportDataAsync(DatasetName name, InputConfig inputConfig, gaxgrpc::CallSettings callSettings = null) =>
            ImportDataAsync(new ImportDataRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                InputConfig = gax::GaxPreconditions.CheckNotNull(inputConfig, nameof(inputConfig)),
            }, callSettings);

        /// <summary>
        /// Imports data into a dataset.
        /// For Tables this method can only be called on an empty Dataset.
        /// 
        /// For Tables:
        /// *   A
        /// [schema_inference_version][google.cloud.automl.v1.InputConfig.params]
        /// parameter must be explicitly set.
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="name">
        /// Required. Dataset name. Dataset must already exist. All imported
        /// annotations and examples will be added.
        /// </param>
        /// <param name="inputConfig">
        /// Required. The desired input location and its domain specific semantics,
        /// if any.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> ImportDataAsync(DatasetName name, InputConfig inputConfig, st::CancellationToken cancellationToken) =>
            ImportDataAsync(name, inputConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports dataset's data to the provided output location.
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> ExportData(ExportDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports dataset's data to the provided output location.
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> ExportDataAsync(ExportDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports dataset's data to the provided output location.
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> ExportDataAsync(ExportDataRequest request, st::CancellationToken cancellationToken) =>
            ExportDataAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExportData</c>.</summary>
        public virtual lro::OperationsClient ExportDataOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ExportData</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceExportData(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportDataOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportData</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceExportDataAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportDataOperationsClient, callSettings);

        /// <summary>
        /// Exports dataset's data to the provided output location.
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the dataset.
        /// </param>
        /// <param name="outputConfig">
        /// Required. The desired output location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> ExportData(string name, OutputConfig outputConfig, gaxgrpc::CallSettings callSettings = null) =>
            ExportData(new ExportDataRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                OutputConfig = gax::GaxPreconditions.CheckNotNull(outputConfig, nameof(outputConfig)),
            }, callSettings);

        /// <summary>
        /// Exports dataset's data to the provided output location.
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the dataset.
        /// </param>
        /// <param name="outputConfig">
        /// Required. The desired output location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> ExportDataAsync(string name, OutputConfig outputConfig, gaxgrpc::CallSettings callSettings = null) =>
            ExportDataAsync(new ExportDataRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                OutputConfig = gax::GaxPreconditions.CheckNotNull(outputConfig, nameof(outputConfig)),
            }, callSettings);

        /// <summary>
        /// Exports dataset's data to the provided output location.
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the dataset.
        /// </param>
        /// <param name="outputConfig">
        /// Required. The desired output location.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> ExportDataAsync(string name, OutputConfig outputConfig, st::CancellationToken cancellationToken) =>
            ExportDataAsync(name, outputConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports dataset's data to the provided output location.
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the dataset.
        /// </param>
        /// <param name="outputConfig">
        /// Required. The desired output location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> ExportData(DatasetName name, OutputConfig outputConfig, gaxgrpc::CallSettings callSettings = null) =>
            ExportData(new ExportDataRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                OutputConfig = gax::GaxPreconditions.CheckNotNull(outputConfig, nameof(outputConfig)),
            }, callSettings);

        /// <summary>
        /// Exports dataset's data to the provided output location.
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the dataset.
        /// </param>
        /// <param name="outputConfig">
        /// Required. The desired output location.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> ExportDataAsync(DatasetName name, OutputConfig outputConfig, gaxgrpc::CallSettings callSettings = null) =>
            ExportDataAsync(new ExportDataRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                OutputConfig = gax::GaxPreconditions.CheckNotNull(outputConfig, nameof(outputConfig)),
            }, callSettings);

        /// <summary>
        /// Exports dataset's data to the provided output location.
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the dataset.
        /// </param>
        /// <param name="outputConfig">
        /// Required. The desired output location.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> ExportDataAsync(DatasetName name, OutputConfig outputConfig, st::CancellationToken cancellationToken) =>
            ExportDataAsync(name, outputConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an annotation spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnnotationSpec GetAnnotationSpec(GetAnnotationSpecRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an annotation spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotationSpec> GetAnnotationSpecAsync(GetAnnotationSpecRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an annotation spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotationSpec> GetAnnotationSpecAsync(GetAnnotationSpecRequest request, st::CancellationToken cancellationToken) =>
            GetAnnotationSpecAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an annotation spec.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the annotation spec to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnnotationSpec GetAnnotationSpec(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnnotationSpec(new GetAnnotationSpecRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an annotation spec.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the annotation spec to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotationSpec> GetAnnotationSpecAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnnotationSpecAsync(new GetAnnotationSpecRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an annotation spec.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the annotation spec to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotationSpec> GetAnnotationSpecAsync(string name, st::CancellationToken cancellationToken) =>
            GetAnnotationSpecAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an annotation spec.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the annotation spec to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnnotationSpec GetAnnotationSpec(AnnotationSpecName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnnotationSpec(new GetAnnotationSpecRequest
            {
                AnnotationSpecName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an annotation spec.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the annotation spec to retrieve.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotationSpec> GetAnnotationSpecAsync(AnnotationSpecName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnnotationSpecAsync(new GetAnnotationSpecRequest
            {
                AnnotationSpecName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an annotation spec.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the annotation spec to retrieve.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotationSpec> GetAnnotationSpecAsync(AnnotationSpecName name, st::CancellationToken cancellationToken) =>
            GetAnnotationSpecAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a model.
        /// Returns a Model in the [response][google.longrunning.Operation.response]
        /// field when it completes.
        /// When you create a model, several model evaluations are created for it:
        /// a global evaluation, and one evaluation for each annotation spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Model, OperationMetadata> CreateModel(CreateModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a model.
        /// Returns a Model in the [response][google.longrunning.Operation.response]
        /// field when it completes.
        /// When you create a model, several model evaluations are created for it:
        /// a global evaluation, and one evaluation for each annotation spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Model, OperationMetadata>> CreateModelAsync(CreateModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a model.
        /// Returns a Model in the [response][google.longrunning.Operation.response]
        /// field when it completes.
        /// When you create a model, several model evaluations are created for it:
        /// a global evaluation, and one evaluation for each annotation spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Model, OperationMetadata>> CreateModelAsync(CreateModelRequest request, st::CancellationToken cancellationToken) =>
            CreateModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateModel</c>.</summary>
        public virtual lro::OperationsClient CreateModelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Model, OperationMetadata> PollOnceCreateModel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Model, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateModelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Model, OperationMetadata>> PollOnceCreateModelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Model, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateModelOperationsClient, callSettings);

        /// <summary>
        /// Creates a model.
        /// Returns a Model in the [response][google.longrunning.Operation.response]
        /// field when it completes.
        /// When you create a model, several model evaluations are created for it:
        /// a global evaluation, and one evaluation for each annotation spec.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent project where the model is being created.
        /// </param>
        /// <param name="model">
        /// Required. The model to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Model, OperationMetadata> CreateModel(string parent, Model model, gaxgrpc::CallSettings callSettings = null) =>
            CreateModel(new CreateModelRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Model = gax::GaxPreconditions.CheckNotNull(model, nameof(model)),
            }, callSettings);

        /// <summary>
        /// Creates a model.
        /// Returns a Model in the [response][google.longrunning.Operation.response]
        /// field when it completes.
        /// When you create a model, several model evaluations are created for it:
        /// a global evaluation, and one evaluation for each annotation spec.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent project where the model is being created.
        /// </param>
        /// <param name="model">
        /// Required. The model to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Model, OperationMetadata>> CreateModelAsync(string parent, Model model, gaxgrpc::CallSettings callSettings = null) =>
            CreateModelAsync(new CreateModelRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Model = gax::GaxPreconditions.CheckNotNull(model, nameof(model)),
            }, callSettings);

        /// <summary>
        /// Creates a model.
        /// Returns a Model in the [response][google.longrunning.Operation.response]
        /// field when it completes.
        /// When you create a model, several model evaluations are created for it:
        /// a global evaluation, and one evaluation for each annotation spec.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent project where the model is being created.
        /// </param>
        /// <param name="model">
        /// Required. The model to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Model, OperationMetadata>> CreateModelAsync(string parent, Model model, st::CancellationToken cancellationToken) =>
            CreateModelAsync(parent, model, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a model.
        /// Returns a Model in the [response][google.longrunning.Operation.response]
        /// field when it completes.
        /// When you create a model, several model evaluations are created for it:
        /// a global evaluation, and one evaluation for each annotation spec.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent project where the model is being created.
        /// </param>
        /// <param name="model">
        /// Required. The model to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Model, OperationMetadata> CreateModel(gagr::LocationName parent, Model model, gaxgrpc::CallSettings callSettings = null) =>
            CreateModel(new CreateModelRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Model = gax::GaxPreconditions.CheckNotNull(model, nameof(model)),
            }, callSettings);

        /// <summary>
        /// Creates a model.
        /// Returns a Model in the [response][google.longrunning.Operation.response]
        /// field when it completes.
        /// When you create a model, several model evaluations are created for it:
        /// a global evaluation, and one evaluation for each annotation spec.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent project where the model is being created.
        /// </param>
        /// <param name="model">
        /// Required. The model to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Model, OperationMetadata>> CreateModelAsync(gagr::LocationName parent, Model model, gaxgrpc::CallSettings callSettings = null) =>
            CreateModelAsync(new CreateModelRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Model = gax::GaxPreconditions.CheckNotNull(model, nameof(model)),
            }, callSettings);

        /// <summary>
        /// Creates a model.
        /// Returns a Model in the [response][google.longrunning.Operation.response]
        /// field when it completes.
        /// When you create a model, several model evaluations are created for it:
        /// a global evaluation, and one evaluation for each annotation spec.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the parent project where the model is being created.
        /// </param>
        /// <param name="model">
        /// Required. The model to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Model, OperationMetadata>> CreateModelAsync(gagr::LocationName parent, Model model, st::CancellationToken cancellationToken) =>
            CreateModelAsync(parent, model, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Model GetModel(GetModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> GetModelAsync(GetModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> GetModelAsync(GetModelRequest request, st::CancellationToken cancellationToken) =>
            GetModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a model.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the model.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Model GetModel(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetModel(new GetModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a model.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the model.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> GetModelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetModelAsync(new GetModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a model.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the model.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> GetModelAsync(string name, st::CancellationToken cancellationToken) =>
            GetModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a model.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the model.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Model GetModel(ModelName name, gaxgrpc::CallSettings callSettings = null) =>
            GetModel(new GetModelRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a model.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the model.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> GetModelAsync(ModelName name, gaxgrpc::CallSettings callSettings = null) =>
            GetModelAsync(new GetModelRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a model.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the model.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> GetModelAsync(ModelName name, st::CancellationToken cancellationToken) =>
            GetModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists models.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Model"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListModelsResponse, Model> ListModels(ListModelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists models.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Model"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListModelsResponse, Model> ListModelsAsync(ListModelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists models.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the project, from which to list the models.
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
        /// <returns>A pageable sequence of <see cref="Model"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListModelsResponse, Model> ListModels(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelsRequest request = new ListModelsRequest
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
            return ListModels(request, callSettings);
        }

        /// <summary>
        /// Lists models.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the project, from which to list the models.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Model"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListModelsResponse, Model> ListModelsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelsRequest request = new ListModelsRequest
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
            return ListModelsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists models.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the project, from which to list the models.
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
        /// <returns>A pageable sequence of <see cref="Model"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListModelsResponse, Model> ListModels(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelsRequest request = new ListModelsRequest
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
            return ListModels(request, callSettings);
        }

        /// <summary>
        /// Lists models.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the project, from which to list the models.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Model"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListModelsResponse, Model> ListModelsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelsRequest request = new ListModelsRequest
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
            return ListModelsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a model.
        /// Returns `google.protobuf.Empty` in the
        /// [response][google.longrunning.Operation.response] field when it completes,
        /// and `delete_details` in the
        /// [metadata][google.longrunning.Operation.metadata] field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteModel(DeleteModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a model.
        /// Returns `google.protobuf.Empty` in the
        /// [response][google.longrunning.Operation.response] field when it completes,
        /// and `delete_details` in the
        /// [metadata][google.longrunning.Operation.metadata] field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteModelAsync(DeleteModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a model.
        /// Returns `google.protobuf.Empty` in the
        /// [response][google.longrunning.Operation.response] field when it completes,
        /// and `delete_details` in the
        /// [metadata][google.longrunning.Operation.metadata] field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteModelAsync(DeleteModelRequest request, st::CancellationToken cancellationToken) =>
            DeleteModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteModel</c>.</summary>
        public virtual lro::OperationsClient DeleteModelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteModel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteModelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteModelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteModelOperationsClient, callSettings);

        /// <summary>
        /// Deletes a model.
        /// Returns `google.protobuf.Empty` in the
        /// [response][google.longrunning.Operation.response] field when it completes,
        /// and `delete_details` in the
        /// [metadata][google.longrunning.Operation.metadata] field.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the model being deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteModel(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteModel(new DeleteModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a model.
        /// Returns `google.protobuf.Empty` in the
        /// [response][google.longrunning.Operation.response] field when it completes,
        /// and `delete_details` in the
        /// [metadata][google.longrunning.Operation.metadata] field.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the model being deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteModelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteModelAsync(new DeleteModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a model.
        /// Returns `google.protobuf.Empty` in the
        /// [response][google.longrunning.Operation.response] field when it completes,
        /// and `delete_details` in the
        /// [metadata][google.longrunning.Operation.metadata] field.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the model being deleted.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteModelAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a model.
        /// Returns `google.protobuf.Empty` in the
        /// [response][google.longrunning.Operation.response] field when it completes,
        /// and `delete_details` in the
        /// [metadata][google.longrunning.Operation.metadata] field.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the model being deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteModel(ModelName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteModel(new DeleteModelRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a model.
        /// Returns `google.protobuf.Empty` in the
        /// [response][google.longrunning.Operation.response] field when it completes,
        /// and `delete_details` in the
        /// [metadata][google.longrunning.Operation.metadata] field.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the model being deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteModelAsync(ModelName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteModelAsync(new DeleteModelRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a model.
        /// Returns `google.protobuf.Empty` in the
        /// [response][google.longrunning.Operation.response] field when it completes,
        /// and `delete_details` in the
        /// [metadata][google.longrunning.Operation.metadata] field.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the model being deleted.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteModelAsync(ModelName name, st::CancellationToken cancellationToken) =>
            DeleteModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Model UpdateModel(UpdateModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> UpdateModelAsync(UpdateModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> UpdateModelAsync(UpdateModelRequest request, st::CancellationToken cancellationToken) =>
            UpdateModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a model.
        /// </summary>
        /// <param name="model">
        /// Required. The model which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Model UpdateModel(Model model, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateModel(new UpdateModelRequest
            {
                Model = gax::GaxPreconditions.CheckNotNull(model, nameof(model)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a model.
        /// </summary>
        /// <param name="model">
        /// Required. The model which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> UpdateModelAsync(Model model, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateModelAsync(new UpdateModelRequest
            {
                Model = gax::GaxPreconditions.CheckNotNull(model, nameof(model)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a model.
        /// </summary>
        /// <param name="model">
        /// Required. The model which replaces the resource on the server.
        /// </param>
        /// <param name="updateMask">
        /// Required. The update mask applies to the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Model> UpdateModelAsync(Model model, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateModelAsync(model, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deploys a model. If a model is already deployed, deploying it with the
        /// same parameters has no effect. Deploying with different parametrs
        /// (as e.g. changing
        /// [node_number][google.cloud.automl.v1p1beta.ImageObjectDetectionModelDeploymentMetadata.node_number])
        /// will reset the deployment state without pausing the model's availability.
        /// 
        /// Only applicable for Text Classification, Image Object Detection , Tables, and Image Segmentation; all other domains manage
        /// deployment automatically.
        /// 
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeployModel(DeployModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deploys a model. If a model is already deployed, deploying it with the
        /// same parameters has no effect. Deploying with different parametrs
        /// (as e.g. changing
        /// [node_number][google.cloud.automl.v1p1beta.ImageObjectDetectionModelDeploymentMetadata.node_number])
        /// will reset the deployment state without pausing the model's availability.
        /// 
        /// Only applicable for Text Classification, Image Object Detection , Tables, and Image Segmentation; all other domains manage
        /// deployment automatically.
        /// 
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeployModelAsync(DeployModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deploys a model. If a model is already deployed, deploying it with the
        /// same parameters has no effect. Deploying with different parametrs
        /// (as e.g. changing
        /// [node_number][google.cloud.automl.v1p1beta.ImageObjectDetectionModelDeploymentMetadata.node_number])
        /// will reset the deployment state without pausing the model's availability.
        /// 
        /// Only applicable for Text Classification, Image Object Detection , Tables, and Image Segmentation; all other domains manage
        /// deployment automatically.
        /// 
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeployModelAsync(DeployModelRequest request, st::CancellationToken cancellationToken) =>
            DeployModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeployModel</c>.</summary>
        public virtual lro::OperationsClient DeployModelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeployModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeployModel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeployModelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeployModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeployModelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeployModelOperationsClient, callSettings);

        /// <summary>
        /// Deploys a model. If a model is already deployed, deploying it with the
        /// same parameters has no effect. Deploying with different parametrs
        /// (as e.g. changing
        /// [node_number][google.cloud.automl.v1p1beta.ImageObjectDetectionModelDeploymentMetadata.node_number])
        /// will reset the deployment state without pausing the model's availability.
        /// 
        /// Only applicable for Text Classification, Image Object Detection , Tables, and Image Segmentation; all other domains manage
        /// deployment automatically.
        /// 
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the model to deploy.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeployModel(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeployModel(new DeployModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deploys a model. If a model is already deployed, deploying it with the
        /// same parameters has no effect. Deploying with different parametrs
        /// (as e.g. changing
        /// [node_number][google.cloud.automl.v1p1beta.ImageObjectDetectionModelDeploymentMetadata.node_number])
        /// will reset the deployment state without pausing the model's availability.
        /// 
        /// Only applicable for Text Classification, Image Object Detection , Tables, and Image Segmentation; all other domains manage
        /// deployment automatically.
        /// 
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the model to deploy.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeployModelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeployModelAsync(new DeployModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deploys a model. If a model is already deployed, deploying it with the
        /// same parameters has no effect. Deploying with different parametrs
        /// (as e.g. changing
        /// [node_number][google.cloud.automl.v1p1beta.ImageObjectDetectionModelDeploymentMetadata.node_number])
        /// will reset the deployment state without pausing the model's availability.
        /// 
        /// Only applicable for Text Classification, Image Object Detection , Tables, and Image Segmentation; all other domains manage
        /// deployment automatically.
        /// 
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the model to deploy.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeployModelAsync(string name, st::CancellationToken cancellationToken) =>
            DeployModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deploys a model. If a model is already deployed, deploying it with the
        /// same parameters has no effect. Deploying with different parametrs
        /// (as e.g. changing
        /// [node_number][google.cloud.automl.v1p1beta.ImageObjectDetectionModelDeploymentMetadata.node_number])
        /// will reset the deployment state without pausing the model's availability.
        /// 
        /// Only applicable for Text Classification, Image Object Detection , Tables, and Image Segmentation; all other domains manage
        /// deployment automatically.
        /// 
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the model to deploy.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeployModel(ModelName name, gaxgrpc::CallSettings callSettings = null) =>
            DeployModel(new DeployModelRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deploys a model. If a model is already deployed, deploying it with the
        /// same parameters has no effect. Deploying with different parametrs
        /// (as e.g. changing
        /// [node_number][google.cloud.automl.v1p1beta.ImageObjectDetectionModelDeploymentMetadata.node_number])
        /// will reset the deployment state without pausing the model's availability.
        /// 
        /// Only applicable for Text Classification, Image Object Detection , Tables, and Image Segmentation; all other domains manage
        /// deployment automatically.
        /// 
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the model to deploy.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeployModelAsync(ModelName name, gaxgrpc::CallSettings callSettings = null) =>
            DeployModelAsync(new DeployModelRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deploys a model. If a model is already deployed, deploying it with the
        /// same parameters has no effect. Deploying with different parametrs
        /// (as e.g. changing
        /// [node_number][google.cloud.automl.v1p1beta.ImageObjectDetectionModelDeploymentMetadata.node_number])
        /// will reset the deployment state without pausing the model's availability.
        /// 
        /// Only applicable for Text Classification, Image Object Detection , Tables, and Image Segmentation; all other domains manage
        /// deployment automatically.
        /// 
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the model to deploy.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeployModelAsync(ModelName name, st::CancellationToken cancellationToken) =>
            DeployModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Undeploys a model. If the model is not deployed this method has no effect.
        /// 
        /// Only applicable for Text Classification, Image Object Detection and Tables;
        /// all other domains manage deployment automatically.
        /// 
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> UndeployModel(UndeployModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Undeploys a model. If the model is not deployed this method has no effect.
        /// 
        /// Only applicable for Text Classification, Image Object Detection and Tables;
        /// all other domains manage deployment automatically.
        /// 
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> UndeployModelAsync(UndeployModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Undeploys a model. If the model is not deployed this method has no effect.
        /// 
        /// Only applicable for Text Classification, Image Object Detection and Tables;
        /// all other domains manage deployment automatically.
        /// 
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> UndeployModelAsync(UndeployModelRequest request, st::CancellationToken cancellationToken) =>
            UndeployModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UndeployModel</c>.</summary>
        public virtual lro::OperationsClient UndeployModelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UndeployModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceUndeployModel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UndeployModelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UndeployModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceUndeployModelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UndeployModelOperationsClient, callSettings);

        /// <summary>
        /// Undeploys a model. If the model is not deployed this method has no effect.
        /// 
        /// Only applicable for Text Classification, Image Object Detection and Tables;
        /// all other domains manage deployment automatically.
        /// 
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the model to undeploy.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> UndeployModel(string name, gaxgrpc::CallSettings callSettings = null) =>
            UndeployModel(new UndeployModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undeploys a model. If the model is not deployed this method has no effect.
        /// 
        /// Only applicable for Text Classification, Image Object Detection and Tables;
        /// all other domains manage deployment automatically.
        /// 
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the model to undeploy.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> UndeployModelAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            UndeployModelAsync(new UndeployModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undeploys a model. If the model is not deployed this method has no effect.
        /// 
        /// Only applicable for Text Classification, Image Object Detection and Tables;
        /// all other domains manage deployment automatically.
        /// 
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the model to undeploy.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> UndeployModelAsync(string name, st::CancellationToken cancellationToken) =>
            UndeployModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Undeploys a model. If the model is not deployed this method has no effect.
        /// 
        /// Only applicable for Text Classification, Image Object Detection and Tables;
        /// all other domains manage deployment automatically.
        /// 
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the model to undeploy.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> UndeployModel(ModelName name, gaxgrpc::CallSettings callSettings = null) =>
            UndeployModel(new UndeployModelRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undeploys a model. If the model is not deployed this method has no effect.
        /// 
        /// Only applicable for Text Classification, Image Object Detection and Tables;
        /// all other domains manage deployment automatically.
        /// 
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the model to undeploy.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> UndeployModelAsync(ModelName name, gaxgrpc::CallSettings callSettings = null) =>
            UndeployModelAsync(new UndeployModelRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undeploys a model. If the model is not deployed this method has no effect.
        /// 
        /// Only applicable for Text Classification, Image Object Detection and Tables;
        /// all other domains manage deployment automatically.
        /// 
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the model to undeploy.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> UndeployModelAsync(ModelName name, st::CancellationToken cancellationToken) =>
            UndeployModelAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports a trained, "export-able", model to a user specified Google Cloud
        /// Storage location. A model is considered export-able if and only if it has
        /// an export format defined for it in
        /// [ModelExportOutputConfig][google.cloud.automl.v1.ModelExportOutputConfig].
        /// 
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> ExportModel(ExportModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports a trained, "export-able", model to a user specified Google Cloud
        /// Storage location. A model is considered export-able if and only if it has
        /// an export format defined for it in
        /// [ModelExportOutputConfig][google.cloud.automl.v1.ModelExportOutputConfig].
        /// 
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> ExportModelAsync(ExportModelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports a trained, "export-able", model to a user specified Google Cloud
        /// Storage location. A model is considered export-able if and only if it has
        /// an export format defined for it in
        /// [ModelExportOutputConfig][google.cloud.automl.v1.ModelExportOutputConfig].
        /// 
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> ExportModelAsync(ExportModelRequest request, st::CancellationToken cancellationToken) =>
            ExportModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExportModel</c>.</summary>
        public virtual lro::OperationsClient ExportModelOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ExportModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceExportModel(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportModelOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportModel</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceExportModelAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportModelOperationsClient, callSettings);

        /// <summary>
        /// Exports a trained, "export-able", model to a user specified Google Cloud
        /// Storage location. A model is considered export-able if and only if it has
        /// an export format defined for it in
        /// [ModelExportOutputConfig][google.cloud.automl.v1.ModelExportOutputConfig].
        /// 
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model to export.
        /// </param>
        /// <param name="outputConfig">
        /// Required. The desired output location and configuration.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> ExportModel(string name, ModelExportOutputConfig outputConfig, gaxgrpc::CallSettings callSettings = null) =>
            ExportModel(new ExportModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                OutputConfig = gax::GaxPreconditions.CheckNotNull(outputConfig, nameof(outputConfig)),
            }, callSettings);

        /// <summary>
        /// Exports a trained, "export-able", model to a user specified Google Cloud
        /// Storage location. A model is considered export-able if and only if it has
        /// an export format defined for it in
        /// [ModelExportOutputConfig][google.cloud.automl.v1.ModelExportOutputConfig].
        /// 
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model to export.
        /// </param>
        /// <param name="outputConfig">
        /// Required. The desired output location and configuration.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> ExportModelAsync(string name, ModelExportOutputConfig outputConfig, gaxgrpc::CallSettings callSettings = null) =>
            ExportModelAsync(new ExportModelRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                OutputConfig = gax::GaxPreconditions.CheckNotNull(outputConfig, nameof(outputConfig)),
            }, callSettings);

        /// <summary>
        /// Exports a trained, "export-able", model to a user specified Google Cloud
        /// Storage location. A model is considered export-able if and only if it has
        /// an export format defined for it in
        /// [ModelExportOutputConfig][google.cloud.automl.v1.ModelExportOutputConfig].
        /// 
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model to export.
        /// </param>
        /// <param name="outputConfig">
        /// Required. The desired output location and configuration.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> ExportModelAsync(string name, ModelExportOutputConfig outputConfig, st::CancellationToken cancellationToken) =>
            ExportModelAsync(name, outputConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports a trained, "export-able", model to a user specified Google Cloud
        /// Storage location. A model is considered export-able if and only if it has
        /// an export format defined for it in
        /// [ModelExportOutputConfig][google.cloud.automl.v1.ModelExportOutputConfig].
        /// 
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model to export.
        /// </param>
        /// <param name="outputConfig">
        /// Required. The desired output location and configuration.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> ExportModel(ModelName name, ModelExportOutputConfig outputConfig, gaxgrpc::CallSettings callSettings = null) =>
            ExportModel(new ExportModelRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                OutputConfig = gax::GaxPreconditions.CheckNotNull(outputConfig, nameof(outputConfig)),
            }, callSettings);

        /// <summary>
        /// Exports a trained, "export-able", model to a user specified Google Cloud
        /// Storage location. A model is considered export-able if and only if it has
        /// an export format defined for it in
        /// [ModelExportOutputConfig][google.cloud.automl.v1.ModelExportOutputConfig].
        /// 
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model to export.
        /// </param>
        /// <param name="outputConfig">
        /// Required. The desired output location and configuration.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> ExportModelAsync(ModelName name, ModelExportOutputConfig outputConfig, gaxgrpc::CallSettings callSettings = null) =>
            ExportModelAsync(new ExportModelRequest
            {
                ModelName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                OutputConfig = gax::GaxPreconditions.CheckNotNull(outputConfig, nameof(outputConfig)),
            }, callSettings);

        /// <summary>
        /// Exports a trained, "export-able", model to a user specified Google Cloud
        /// Storage location. A model is considered export-able if and only if it has
        /// an export format defined for it in
        /// [ModelExportOutputConfig][google.cloud.automl.v1.ModelExportOutputConfig].
        /// 
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the model to export.
        /// </param>
        /// <param name="outputConfig">
        /// Required. The desired output location and configuration.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> ExportModelAsync(ModelName name, ModelExportOutputConfig outputConfig, st::CancellationToken cancellationToken) =>
            ExportModelAsync(name, outputConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a model evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ModelEvaluation GetModelEvaluation(GetModelEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a model evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelEvaluation> GetModelEvaluationAsync(GetModelEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a model evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelEvaluation> GetModelEvaluationAsync(GetModelEvaluationRequest request, st::CancellationToken cancellationToken) =>
            GetModelEvaluationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a model evaluation.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the model evaluation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ModelEvaluation GetModelEvaluation(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetModelEvaluation(new GetModelEvaluationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a model evaluation.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the model evaluation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelEvaluation> GetModelEvaluationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetModelEvaluationAsync(new GetModelEvaluationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a model evaluation.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the model evaluation.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelEvaluation> GetModelEvaluationAsync(string name, st::CancellationToken cancellationToken) =>
            GetModelEvaluationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a model evaluation.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the model evaluation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ModelEvaluation GetModelEvaluation(ModelEvaluationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetModelEvaluation(new GetModelEvaluationRequest
            {
                ModelEvaluationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a model evaluation.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the model evaluation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelEvaluation> GetModelEvaluationAsync(ModelEvaluationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetModelEvaluationAsync(new GetModelEvaluationRequest
            {
                ModelEvaluationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a model evaluation.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name for the model evaluation.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ModelEvaluation> GetModelEvaluationAsync(ModelEvaluationName name, st::CancellationToken cancellationToken) =>
            GetModelEvaluationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists model evaluations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ModelEvaluation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListModelEvaluationsResponse, ModelEvaluation> ListModelEvaluations(ListModelEvaluationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists model evaluations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ModelEvaluation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListModelEvaluationsResponse, ModelEvaluation> ListModelEvaluationsAsync(ListModelEvaluationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists model evaluations.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the model to list the model evaluations for.
        /// If modelId is set as "-", this will list model evaluations from across all
        /// models of the parent location.
        /// </param>
        /// <param name="filter">
        /// Required. An expression for filtering the results of the request.
        /// 
        /// * `annotation_spec_id` - for =, !=  or existence. See example below for
        /// the last.
        /// 
        /// Some examples of using the filter are:
        /// 
        /// * `annotation_spec_id!=4` --&gt; The model evaluation was done for
        /// annotation spec with ID different than 4.
        /// * `NOT annotation_spec_id:*` --&gt; The model evaluation was done for
        /// aggregate of all annotation specs.
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
        /// <returns>A pageable sequence of <see cref="ModelEvaluation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListModelEvaluationsResponse, ModelEvaluation> ListModelEvaluations(string parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelEvaluationsRequest request = new ListModelEvaluationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListModelEvaluations(request, callSettings);
        }

        /// <summary>
        /// Lists model evaluations.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the model to list the model evaluations for.
        /// If modelId is set as "-", this will list model evaluations from across all
        /// models of the parent location.
        /// </param>
        /// <param name="filter">
        /// Required. An expression for filtering the results of the request.
        /// 
        /// * `annotation_spec_id` - for =, !=  or existence. See example below for
        /// the last.
        /// 
        /// Some examples of using the filter are:
        /// 
        /// * `annotation_spec_id!=4` --&gt; The model evaluation was done for
        /// annotation spec with ID different than 4.
        /// * `NOT annotation_spec_id:*` --&gt; The model evaluation was done for
        /// aggregate of all annotation specs.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ModelEvaluation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListModelEvaluationsResponse, ModelEvaluation> ListModelEvaluationsAsync(string parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelEvaluationsRequest request = new ListModelEvaluationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListModelEvaluationsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists model evaluations.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the model to list the model evaluations for.
        /// If modelId is set as "-", this will list model evaluations from across all
        /// models of the parent location.
        /// </param>
        /// <param name="filter">
        /// Required. An expression for filtering the results of the request.
        /// 
        /// * `annotation_spec_id` - for =, !=  or existence. See example below for
        /// the last.
        /// 
        /// Some examples of using the filter are:
        /// 
        /// * `annotation_spec_id!=4` --&gt; The model evaluation was done for
        /// annotation spec with ID different than 4.
        /// * `NOT annotation_spec_id:*` --&gt; The model evaluation was done for
        /// aggregate of all annotation specs.
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
        /// <returns>A pageable sequence of <see cref="ModelEvaluation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListModelEvaluationsResponse, ModelEvaluation> ListModelEvaluations(ModelName parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelEvaluationsRequest request = new ListModelEvaluationsRequest
            {
                ParentAsModelName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListModelEvaluations(request, callSettings);
        }

        /// <summary>
        /// Lists model evaluations.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the model to list the model evaluations for.
        /// If modelId is set as "-", this will list model evaluations from across all
        /// models of the parent location.
        /// </param>
        /// <param name="filter">
        /// Required. An expression for filtering the results of the request.
        /// 
        /// * `annotation_spec_id` - for =, !=  or existence. See example below for
        /// the last.
        /// 
        /// Some examples of using the filter are:
        /// 
        /// * `annotation_spec_id!=4` --&gt; The model evaluation was done for
        /// annotation spec with ID different than 4.
        /// * `NOT annotation_spec_id:*` --&gt; The model evaluation was done for
        /// aggregate of all annotation specs.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ModelEvaluation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListModelEvaluationsResponse, ModelEvaluation> ListModelEvaluationsAsync(ModelName parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListModelEvaluationsRequest request = new ListModelEvaluationsRequest
            {
                ParentAsModelName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = gax::GaxPreconditions.CheckNotNullOrEmpty(filter, nameof(filter)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListModelEvaluationsAsync(request, callSettings);
        }
    }

    /// <summary>AutoMl client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// AutoML Server API.
    /// 
    /// The resource names are assigned by the server.
    /// The server never reuses names that it has created after the resources with
    /// those names are deleted.
    /// 
    /// An ID of a resource is the last element of the item's resource name. For
    /// `projects/{project_id}/locations/{location_id}/datasets/{dataset_id}`, then
    /// the id for the item is `{dataset_id}`.
    /// 
    /// Currently the only supported `location_id` is "us-central1".
    /// 
    /// On any input that is documented to expect a string parameter in
    /// snake_case or dash-case, either of those cases is accepted.
    /// </remarks>
    public sealed partial class AutoMlClientImpl : AutoMlClient
    {
        private readonly gaxgrpc::ApiCall<CreateDatasetRequest, lro::Operation> _callCreateDataset;

        private readonly gaxgrpc::ApiCall<GetDatasetRequest, Dataset> _callGetDataset;

        private readonly gaxgrpc::ApiCall<ListDatasetsRequest, ListDatasetsResponse> _callListDatasets;

        private readonly gaxgrpc::ApiCall<UpdateDatasetRequest, Dataset> _callUpdateDataset;

        private readonly gaxgrpc::ApiCall<DeleteDatasetRequest, lro::Operation> _callDeleteDataset;

        private readonly gaxgrpc::ApiCall<ImportDataRequest, lro::Operation> _callImportData;

        private readonly gaxgrpc::ApiCall<ExportDataRequest, lro::Operation> _callExportData;

        private readonly gaxgrpc::ApiCall<GetAnnotationSpecRequest, AnnotationSpec> _callGetAnnotationSpec;

        private readonly gaxgrpc::ApiCall<CreateModelRequest, lro::Operation> _callCreateModel;

        private readonly gaxgrpc::ApiCall<GetModelRequest, Model> _callGetModel;

        private readonly gaxgrpc::ApiCall<ListModelsRequest, ListModelsResponse> _callListModels;

        private readonly gaxgrpc::ApiCall<DeleteModelRequest, lro::Operation> _callDeleteModel;

        private readonly gaxgrpc::ApiCall<UpdateModelRequest, Model> _callUpdateModel;

        private readonly gaxgrpc::ApiCall<DeployModelRequest, lro::Operation> _callDeployModel;

        private readonly gaxgrpc::ApiCall<UndeployModelRequest, lro::Operation> _callUndeployModel;

        private readonly gaxgrpc::ApiCall<ExportModelRequest, lro::Operation> _callExportModel;

        private readonly gaxgrpc::ApiCall<GetModelEvaluationRequest, ModelEvaluation> _callGetModelEvaluation;

        private readonly gaxgrpc::ApiCall<ListModelEvaluationsRequest, ListModelEvaluationsResponse> _callListModelEvaluations;

        /// <summary>
        /// Constructs a client wrapper for the AutoMl service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AutoMlSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AutoMlClientImpl(AutoMl.AutoMlClient grpcClient, AutoMlSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AutoMlSettings effectiveSettings = settings ?? AutoMlSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateDatasetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateDatasetOperationsSettings, logger);
            DeleteDatasetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteDatasetOperationsSettings, logger);
            ImportDataOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ImportDataOperationsSettings, logger);
            ExportDataOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportDataOperationsSettings, logger);
            CreateModelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateModelOperationsSettings, logger);
            DeleteModelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteModelOperationsSettings, logger);
            DeployModelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeployModelOperationsSettings, logger);
            UndeployModelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UndeployModelOperationsSettings, logger);
            ExportModelOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportModelOperationsSettings, logger);
            _callCreateDataset = clientHelper.BuildApiCall<CreateDatasetRequest, lro::Operation>("CreateDataset", grpcClient.CreateDatasetAsync, grpcClient.CreateDataset, effectiveSettings.CreateDatasetSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDataset);
            Modify_CreateDatasetApiCall(ref _callCreateDataset);
            _callGetDataset = clientHelper.BuildApiCall<GetDatasetRequest, Dataset>("GetDataset", grpcClient.GetDatasetAsync, grpcClient.GetDataset, effectiveSettings.GetDatasetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDataset);
            Modify_GetDatasetApiCall(ref _callGetDataset);
            _callListDatasets = clientHelper.BuildApiCall<ListDatasetsRequest, ListDatasetsResponse>("ListDatasets", grpcClient.ListDatasetsAsync, grpcClient.ListDatasets, effectiveSettings.ListDatasetsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDatasets);
            Modify_ListDatasetsApiCall(ref _callListDatasets);
            _callUpdateDataset = clientHelper.BuildApiCall<UpdateDatasetRequest, Dataset>("UpdateDataset", grpcClient.UpdateDatasetAsync, grpcClient.UpdateDataset, effectiveSettings.UpdateDatasetSettings).WithGoogleRequestParam("dataset.name", request => request.Dataset?.Name);
            Modify_ApiCall(ref _callUpdateDataset);
            Modify_UpdateDatasetApiCall(ref _callUpdateDataset);
            _callDeleteDataset = clientHelper.BuildApiCall<DeleteDatasetRequest, lro::Operation>("DeleteDataset", grpcClient.DeleteDatasetAsync, grpcClient.DeleteDataset, effectiveSettings.DeleteDatasetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDataset);
            Modify_DeleteDatasetApiCall(ref _callDeleteDataset);
            _callImportData = clientHelper.BuildApiCall<ImportDataRequest, lro::Operation>("ImportData", grpcClient.ImportDataAsync, grpcClient.ImportData, effectiveSettings.ImportDataSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callImportData);
            Modify_ImportDataApiCall(ref _callImportData);
            _callExportData = clientHelper.BuildApiCall<ExportDataRequest, lro::Operation>("ExportData", grpcClient.ExportDataAsync, grpcClient.ExportData, effectiveSettings.ExportDataSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callExportData);
            Modify_ExportDataApiCall(ref _callExportData);
            _callGetAnnotationSpec = clientHelper.BuildApiCall<GetAnnotationSpecRequest, AnnotationSpec>("GetAnnotationSpec", grpcClient.GetAnnotationSpecAsync, grpcClient.GetAnnotationSpec, effectiveSettings.GetAnnotationSpecSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAnnotationSpec);
            Modify_GetAnnotationSpecApiCall(ref _callGetAnnotationSpec);
            _callCreateModel = clientHelper.BuildApiCall<CreateModelRequest, lro::Operation>("CreateModel", grpcClient.CreateModelAsync, grpcClient.CreateModel, effectiveSettings.CreateModelSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateModel);
            Modify_CreateModelApiCall(ref _callCreateModel);
            _callGetModel = clientHelper.BuildApiCall<GetModelRequest, Model>("GetModel", grpcClient.GetModelAsync, grpcClient.GetModel, effectiveSettings.GetModelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetModel);
            Modify_GetModelApiCall(ref _callGetModel);
            _callListModels = clientHelper.BuildApiCall<ListModelsRequest, ListModelsResponse>("ListModels", grpcClient.ListModelsAsync, grpcClient.ListModels, effectiveSettings.ListModelsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListModels);
            Modify_ListModelsApiCall(ref _callListModels);
            _callDeleteModel = clientHelper.BuildApiCall<DeleteModelRequest, lro::Operation>("DeleteModel", grpcClient.DeleteModelAsync, grpcClient.DeleteModel, effectiveSettings.DeleteModelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteModel);
            Modify_DeleteModelApiCall(ref _callDeleteModel);
            _callUpdateModel = clientHelper.BuildApiCall<UpdateModelRequest, Model>("UpdateModel", grpcClient.UpdateModelAsync, grpcClient.UpdateModel, effectiveSettings.UpdateModelSettings).WithGoogleRequestParam("model.name", request => request.Model?.Name);
            Modify_ApiCall(ref _callUpdateModel);
            Modify_UpdateModelApiCall(ref _callUpdateModel);
            _callDeployModel = clientHelper.BuildApiCall<DeployModelRequest, lro::Operation>("DeployModel", grpcClient.DeployModelAsync, grpcClient.DeployModel, effectiveSettings.DeployModelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeployModel);
            Modify_DeployModelApiCall(ref _callDeployModel);
            _callUndeployModel = clientHelper.BuildApiCall<UndeployModelRequest, lro::Operation>("UndeployModel", grpcClient.UndeployModelAsync, grpcClient.UndeployModel, effectiveSettings.UndeployModelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUndeployModel);
            Modify_UndeployModelApiCall(ref _callUndeployModel);
            _callExportModel = clientHelper.BuildApiCall<ExportModelRequest, lro::Operation>("ExportModel", grpcClient.ExportModelAsync, grpcClient.ExportModel, effectiveSettings.ExportModelSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callExportModel);
            Modify_ExportModelApiCall(ref _callExportModel);
            _callGetModelEvaluation = clientHelper.BuildApiCall<GetModelEvaluationRequest, ModelEvaluation>("GetModelEvaluation", grpcClient.GetModelEvaluationAsync, grpcClient.GetModelEvaluation, effectiveSettings.GetModelEvaluationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetModelEvaluation);
            Modify_GetModelEvaluationApiCall(ref _callGetModelEvaluation);
            _callListModelEvaluations = clientHelper.BuildApiCall<ListModelEvaluationsRequest, ListModelEvaluationsResponse>("ListModelEvaluations", grpcClient.ListModelEvaluationsAsync, grpcClient.ListModelEvaluations, effectiveSettings.ListModelEvaluationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListModelEvaluations);
            Modify_ListModelEvaluationsApiCall(ref _callListModelEvaluations);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateDatasetApiCall(ref gaxgrpc::ApiCall<CreateDatasetRequest, lro::Operation> call);

        partial void Modify_GetDatasetApiCall(ref gaxgrpc::ApiCall<GetDatasetRequest, Dataset> call);

        partial void Modify_ListDatasetsApiCall(ref gaxgrpc::ApiCall<ListDatasetsRequest, ListDatasetsResponse> call);

        partial void Modify_UpdateDatasetApiCall(ref gaxgrpc::ApiCall<UpdateDatasetRequest, Dataset> call);

        partial void Modify_DeleteDatasetApiCall(ref gaxgrpc::ApiCall<DeleteDatasetRequest, lro::Operation> call);

        partial void Modify_ImportDataApiCall(ref gaxgrpc::ApiCall<ImportDataRequest, lro::Operation> call);

        partial void Modify_ExportDataApiCall(ref gaxgrpc::ApiCall<ExportDataRequest, lro::Operation> call);

        partial void Modify_GetAnnotationSpecApiCall(ref gaxgrpc::ApiCall<GetAnnotationSpecRequest, AnnotationSpec> call);

        partial void Modify_CreateModelApiCall(ref gaxgrpc::ApiCall<CreateModelRequest, lro::Operation> call);

        partial void Modify_GetModelApiCall(ref gaxgrpc::ApiCall<GetModelRequest, Model> call);

        partial void Modify_ListModelsApiCall(ref gaxgrpc::ApiCall<ListModelsRequest, ListModelsResponse> call);

        partial void Modify_DeleteModelApiCall(ref gaxgrpc::ApiCall<DeleteModelRequest, lro::Operation> call);

        partial void Modify_UpdateModelApiCall(ref gaxgrpc::ApiCall<UpdateModelRequest, Model> call);

        partial void Modify_DeployModelApiCall(ref gaxgrpc::ApiCall<DeployModelRequest, lro::Operation> call);

        partial void Modify_UndeployModelApiCall(ref gaxgrpc::ApiCall<UndeployModelRequest, lro::Operation> call);

        partial void Modify_ExportModelApiCall(ref gaxgrpc::ApiCall<ExportModelRequest, lro::Operation> call);

        partial void Modify_GetModelEvaluationApiCall(ref gaxgrpc::ApiCall<GetModelEvaluationRequest, ModelEvaluation> call);

        partial void Modify_ListModelEvaluationsApiCall(ref gaxgrpc::ApiCall<ListModelEvaluationsRequest, ListModelEvaluationsResponse> call);

        partial void OnConstruction(AutoMl.AutoMlClient grpcClient, AutoMlSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AutoMl client</summary>
        public override AutoMl.AutoMlClient GrpcClient { get; }

        partial void Modify_CreateDatasetRequest(ref CreateDatasetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDatasetRequest(ref GetDatasetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDatasetsRequest(ref ListDatasetsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDatasetRequest(ref UpdateDatasetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDatasetRequest(ref DeleteDatasetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportDataRequest(ref ImportDataRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportDataRequest(ref ExportDataRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAnnotationSpecRequest(ref GetAnnotationSpecRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateModelRequest(ref CreateModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetModelRequest(ref GetModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListModelsRequest(ref ListModelsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteModelRequest(ref DeleteModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateModelRequest(ref UpdateModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeployModelRequest(ref DeployModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UndeployModelRequest(ref UndeployModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportModelRequest(ref ExportModelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetModelEvaluationRequest(ref GetModelEvaluationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListModelEvaluationsRequest(ref ListModelEvaluationsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateDataset</c>.</summary>
        public override lro::OperationsClient CreateDatasetOperationsClient { get; }

        /// <summary>
        /// Creates a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Dataset, OperationMetadata> CreateDataset(CreateDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDatasetRequest(ref request, ref callSettings);
            return new lro::Operation<Dataset, OperationMetadata>(_callCreateDataset.Sync(request, callSettings), CreateDatasetOperationsClient);
        }

        /// <summary>
        /// Creates a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Dataset, OperationMetadata>> CreateDatasetAsync(CreateDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDatasetRequest(ref request, ref callSettings);
            return new lro::Operation<Dataset, OperationMetadata>(await _callCreateDataset.Async(request, callSettings).ConfigureAwait(false), CreateDatasetOperationsClient);
        }

        /// <summary>
        /// Gets a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Dataset GetDataset(GetDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDatasetRequest(ref request, ref callSettings);
            return _callGetDataset.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Dataset> GetDatasetAsync(GetDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDatasetRequest(ref request, ref callSettings);
            return _callGetDataset.Async(request, callSettings);
        }

        /// <summary>
        /// Lists datasets in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Dataset"/> resources.</returns>
        public override gax::PagedEnumerable<ListDatasetsResponse, Dataset> ListDatasets(ListDatasetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDatasetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDatasetsRequest, ListDatasetsResponse, Dataset>(_callListDatasets, request, callSettings);
        }

        /// <summary>
        /// Lists datasets in a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Dataset"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDatasetsResponse, Dataset> ListDatasetsAsync(ListDatasetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDatasetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDatasetsRequest, ListDatasetsResponse, Dataset>(_callListDatasets, request, callSettings);
        }

        /// <summary>
        /// Updates a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Dataset UpdateDataset(UpdateDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDatasetRequest(ref request, ref callSettings);
            return _callUpdateDataset.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Dataset> UpdateDatasetAsync(UpdateDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDatasetRequest(ref request, ref callSettings);
            return _callUpdateDataset.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteDataset</c>.</summary>
        public override lro::OperationsClient DeleteDatasetOperationsClient { get; }

        /// <summary>
        /// Deletes a dataset and all of its contents.
        /// Returns empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes,
        /// and `delete_details` in the
        /// [metadata][google.longrunning.Operation.metadata] field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteDataset(DeleteDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDatasetRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteDataset.Sync(request, callSettings), DeleteDatasetOperationsClient);
        }

        /// <summary>
        /// Deletes a dataset and all of its contents.
        /// Returns empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes,
        /// and `delete_details` in the
        /// [metadata][google.longrunning.Operation.metadata] field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDatasetAsync(DeleteDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDatasetRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteDataset.Async(request, callSettings).ConfigureAwait(false), DeleteDatasetOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ImportData</c>.</summary>
        public override lro::OperationsClient ImportDataOperationsClient { get; }

        /// <summary>
        /// Imports data into a dataset.
        /// For Tables this method can only be called on an empty Dataset.
        /// 
        /// For Tables:
        /// *   A
        /// [schema_inference_version][google.cloud.automl.v1.InputConfig.params]
        /// parameter must be explicitly set.
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> ImportData(ImportDataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportDataRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callImportData.Sync(request, callSettings), ImportDataOperationsClient);
        }

        /// <summary>
        /// Imports data into a dataset.
        /// For Tables this method can only be called on an empty Dataset.
        /// 
        /// For Tables:
        /// *   A
        /// [schema_inference_version][google.cloud.automl.v1.InputConfig.params]
        /// parameter must be explicitly set.
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> ImportDataAsync(ImportDataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportDataRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callImportData.Async(request, callSettings).ConfigureAwait(false), ImportDataOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ExportData</c>.</summary>
        public override lro::OperationsClient ExportDataOperationsClient { get; }

        /// <summary>
        /// Exports dataset's data to the provided output location.
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> ExportData(ExportDataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportDataRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callExportData.Sync(request, callSettings), ExportDataOperationsClient);
        }

        /// <summary>
        /// Exports dataset's data to the provided output location.
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> ExportDataAsync(ExportDataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportDataRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callExportData.Async(request, callSettings).ConfigureAwait(false), ExportDataOperationsClient);
        }

        /// <summary>
        /// Gets an annotation spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AnnotationSpec GetAnnotationSpec(GetAnnotationSpecRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAnnotationSpecRequest(ref request, ref callSettings);
            return _callGetAnnotationSpec.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an annotation spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AnnotationSpec> GetAnnotationSpecAsync(GetAnnotationSpecRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAnnotationSpecRequest(ref request, ref callSettings);
            return _callGetAnnotationSpec.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateModel</c>.</summary>
        public override lro::OperationsClient CreateModelOperationsClient { get; }

        /// <summary>
        /// Creates a model.
        /// Returns a Model in the [response][google.longrunning.Operation.response]
        /// field when it completes.
        /// When you create a model, several model evaluations are created for it:
        /// a global evaluation, and one evaluation for each annotation spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Model, OperationMetadata> CreateModel(CreateModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateModelRequest(ref request, ref callSettings);
            return new lro::Operation<Model, OperationMetadata>(_callCreateModel.Sync(request, callSettings), CreateModelOperationsClient);
        }

        /// <summary>
        /// Creates a model.
        /// Returns a Model in the [response][google.longrunning.Operation.response]
        /// field when it completes.
        /// When you create a model, several model evaluations are created for it:
        /// a global evaluation, and one evaluation for each annotation spec.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Model, OperationMetadata>> CreateModelAsync(CreateModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateModelRequest(ref request, ref callSettings);
            return new lro::Operation<Model, OperationMetadata>(await _callCreateModel.Async(request, callSettings).ConfigureAwait(false), CreateModelOperationsClient);
        }

        /// <summary>
        /// Gets a model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Model GetModel(GetModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetModelRequest(ref request, ref callSettings);
            return _callGetModel.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Model> GetModelAsync(GetModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetModelRequest(ref request, ref callSettings);
            return _callGetModel.Async(request, callSettings);
        }

        /// <summary>
        /// Lists models.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Model"/> resources.</returns>
        public override gax::PagedEnumerable<ListModelsResponse, Model> ListModels(ListModelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListModelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListModelsRequest, ListModelsResponse, Model>(_callListModels, request, callSettings);
        }

        /// <summary>
        /// Lists models.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Model"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListModelsResponse, Model> ListModelsAsync(ListModelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListModelsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListModelsRequest, ListModelsResponse, Model>(_callListModels, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteModel</c>.</summary>
        public override lro::OperationsClient DeleteModelOperationsClient { get; }

        /// <summary>
        /// Deletes a model.
        /// Returns `google.protobuf.Empty` in the
        /// [response][google.longrunning.Operation.response] field when it completes,
        /// and `delete_details` in the
        /// [metadata][google.longrunning.Operation.metadata] field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteModel(DeleteModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteModelRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteModel.Sync(request, callSettings), DeleteModelOperationsClient);
        }

        /// <summary>
        /// Deletes a model.
        /// Returns `google.protobuf.Empty` in the
        /// [response][google.longrunning.Operation.response] field when it completes,
        /// and `delete_details` in the
        /// [metadata][google.longrunning.Operation.metadata] field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteModelAsync(DeleteModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteModelRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteModel.Async(request, callSettings).ConfigureAwait(false), DeleteModelOperationsClient);
        }

        /// <summary>
        /// Updates a model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Model UpdateModel(UpdateModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateModelRequest(ref request, ref callSettings);
            return _callUpdateModel.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a model.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Model> UpdateModelAsync(UpdateModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateModelRequest(ref request, ref callSettings);
            return _callUpdateModel.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeployModel</c>.</summary>
        public override lro::OperationsClient DeployModelOperationsClient { get; }

        /// <summary>
        /// Deploys a model. If a model is already deployed, deploying it with the
        /// same parameters has no effect. Deploying with different parametrs
        /// (as e.g. changing
        /// [node_number][google.cloud.automl.v1p1beta.ImageObjectDetectionModelDeploymentMetadata.node_number])
        /// will reset the deployment state without pausing the model's availability.
        /// 
        /// Only applicable for Text Classification, Image Object Detection , Tables, and Image Segmentation; all other domains manage
        /// deployment automatically.
        /// 
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeployModel(DeployModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeployModelRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeployModel.Sync(request, callSettings), DeployModelOperationsClient);
        }

        /// <summary>
        /// Deploys a model. If a model is already deployed, deploying it with the
        /// same parameters has no effect. Deploying with different parametrs
        /// (as e.g. changing
        /// [node_number][google.cloud.automl.v1p1beta.ImageObjectDetectionModelDeploymentMetadata.node_number])
        /// will reset the deployment state without pausing the model's availability.
        /// 
        /// Only applicable for Text Classification, Image Object Detection , Tables, and Image Segmentation; all other domains manage
        /// deployment automatically.
        /// 
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeployModelAsync(DeployModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeployModelRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeployModel.Async(request, callSettings).ConfigureAwait(false), DeployModelOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UndeployModel</c>.</summary>
        public override lro::OperationsClient UndeployModelOperationsClient { get; }

        /// <summary>
        /// Undeploys a model. If the model is not deployed this method has no effect.
        /// 
        /// Only applicable for Text Classification, Image Object Detection and Tables;
        /// all other domains manage deployment automatically.
        /// 
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> UndeployModel(UndeployModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeployModelRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callUndeployModel.Sync(request, callSettings), UndeployModelOperationsClient);
        }

        /// <summary>
        /// Undeploys a model. If the model is not deployed this method has no effect.
        /// 
        /// Only applicable for Text Classification, Image Object Detection and Tables;
        /// all other domains manage deployment automatically.
        /// 
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> UndeployModelAsync(UndeployModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeployModelRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callUndeployModel.Async(request, callSettings).ConfigureAwait(false), UndeployModelOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ExportModel</c>.</summary>
        public override lro::OperationsClient ExportModelOperationsClient { get; }

        /// <summary>
        /// Exports a trained, "export-able", model to a user specified Google Cloud
        /// Storage location. A model is considered export-able if and only if it has
        /// an export format defined for it in
        /// [ModelExportOutputConfig][google.cloud.automl.v1.ModelExportOutputConfig].
        /// 
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> ExportModel(ExportModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportModelRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callExportModel.Sync(request, callSettings), ExportModelOperationsClient);
        }

        /// <summary>
        /// Exports a trained, "export-able", model to a user specified Google Cloud
        /// Storage location. A model is considered export-able if and only if it has
        /// an export format defined for it in
        /// [ModelExportOutputConfig][google.cloud.automl.v1.ModelExportOutputConfig].
        /// 
        /// Returns an empty response in the
        /// [response][google.longrunning.Operation.response] field when it completes.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> ExportModelAsync(ExportModelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportModelRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callExportModel.Async(request, callSettings).ConfigureAwait(false), ExportModelOperationsClient);
        }

        /// <summary>
        /// Gets a model evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ModelEvaluation GetModelEvaluation(GetModelEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetModelEvaluationRequest(ref request, ref callSettings);
            return _callGetModelEvaluation.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a model evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ModelEvaluation> GetModelEvaluationAsync(GetModelEvaluationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetModelEvaluationRequest(ref request, ref callSettings);
            return _callGetModelEvaluation.Async(request, callSettings);
        }

        /// <summary>
        /// Lists model evaluations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ModelEvaluation"/> resources.</returns>
        public override gax::PagedEnumerable<ListModelEvaluationsResponse, ModelEvaluation> ListModelEvaluations(ListModelEvaluationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListModelEvaluationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListModelEvaluationsRequest, ListModelEvaluationsResponse, ModelEvaluation>(_callListModelEvaluations, request, callSettings);
        }

        /// <summary>
        /// Lists model evaluations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ModelEvaluation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListModelEvaluationsResponse, ModelEvaluation> ListModelEvaluationsAsync(ListModelEvaluationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListModelEvaluationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListModelEvaluationsRequest, ListModelEvaluationsResponse, ModelEvaluation>(_callListModelEvaluations, request, callSettings);
        }
    }

    public partial class ListDatasetsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListModelsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListModelEvaluationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDatasetsResponse : gaxgrpc::IPageResponse<Dataset>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Dataset> GetEnumerator() => Datasets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListModelsResponse : gaxgrpc::IPageResponse<Model>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Model> GetEnumerator() => Model.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListModelEvaluationsResponse : gaxgrpc::IPageResponse<ModelEvaluation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ModelEvaluation> GetEnumerator() => ModelEvaluation.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class AutoMl
    {
        public partial class AutoMlClient
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
