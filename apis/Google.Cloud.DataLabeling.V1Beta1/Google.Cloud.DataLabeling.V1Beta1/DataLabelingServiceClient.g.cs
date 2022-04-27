// Copyright 2022 Google LLC
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
using gagr = Google.Api.Gax.ResourceNames;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.DataLabeling.V1Beta1
{
    /// <summary>Settings for <see cref="DataLabelingServiceClient"/> instances.</summary>
    public sealed partial class DataLabelingServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DataLabelingServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DataLabelingServiceSettings"/>.</returns>
        public static DataLabelingServiceSettings GetDefault() => new DataLabelingServiceSettings();

        /// <summary>Constructs a new <see cref="DataLabelingServiceSettings"/> object with default settings.</summary>
        public DataLabelingServiceSettings()
        {
        }

        private DataLabelingServiceSettings(DataLabelingServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateDatasetSettings = existing.CreateDatasetSettings;
            GetDatasetSettings = existing.GetDatasetSettings;
            ListDatasetsSettings = existing.ListDatasetsSettings;
            DeleteDatasetSettings = existing.DeleteDatasetSettings;
            ImportDataSettings = existing.ImportDataSettings;
            ImportDataOperationsSettings = existing.ImportDataOperationsSettings.Clone();
            ExportDataSettings = existing.ExportDataSettings;
            ExportDataOperationsSettings = existing.ExportDataOperationsSettings.Clone();
            GetDataItemSettings = existing.GetDataItemSettings;
            ListDataItemsSettings = existing.ListDataItemsSettings;
            GetAnnotatedDatasetSettings = existing.GetAnnotatedDatasetSettings;
            ListAnnotatedDatasetsSettings = existing.ListAnnotatedDatasetsSettings;
            DeleteAnnotatedDatasetSettings = existing.DeleteAnnotatedDatasetSettings;
            LabelImageSettings = existing.LabelImageSettings;
            LabelImageOperationsSettings = existing.LabelImageOperationsSettings.Clone();
            LabelVideoSettings = existing.LabelVideoSettings;
            LabelVideoOperationsSettings = existing.LabelVideoOperationsSettings.Clone();
            LabelTextSettings = existing.LabelTextSettings;
            LabelTextOperationsSettings = existing.LabelTextOperationsSettings.Clone();
            GetExampleSettings = existing.GetExampleSettings;
            ListExamplesSettings = existing.ListExamplesSettings;
            CreateAnnotationSpecSetSettings = existing.CreateAnnotationSpecSetSettings;
            GetAnnotationSpecSetSettings = existing.GetAnnotationSpecSetSettings;
            ListAnnotationSpecSetsSettings = existing.ListAnnotationSpecSetsSettings;
            DeleteAnnotationSpecSetSettings = existing.DeleteAnnotationSpecSetSettings;
            CreateInstructionSettings = existing.CreateInstructionSettings;
            CreateInstructionOperationsSettings = existing.CreateInstructionOperationsSettings.Clone();
            GetInstructionSettings = existing.GetInstructionSettings;
            ListInstructionsSettings = existing.ListInstructionsSettings;
            DeleteInstructionSettings = existing.DeleteInstructionSettings;
            GetEvaluationSettings = existing.GetEvaluationSettings;
            SearchEvaluationsSettings = existing.SearchEvaluationsSettings;
            SearchExampleComparisonsSettings = existing.SearchExampleComparisonsSettings;
            CreateEvaluationJobSettings = existing.CreateEvaluationJobSettings;
            UpdateEvaluationJobSettings = existing.UpdateEvaluationJobSettings;
            GetEvaluationJobSettings = existing.GetEvaluationJobSettings;
            PauseEvaluationJobSettings = existing.PauseEvaluationJobSettings;
            ResumeEvaluationJobSettings = existing.ResumeEvaluationJobSettings;
            DeleteEvaluationJobSettings = existing.DeleteEvaluationJobSettings;
            ListEvaluationJobsSettings = existing.ListEvaluationJobsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DataLabelingServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataLabelingServiceClient.CreateDataset</c> and <c>DataLabelingServiceClient.CreateDatasetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDatasetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataLabelingServiceClient.GetDataset</c> and <c>DataLabelingServiceClient.GetDatasetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDatasetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataLabelingServiceClient.ListDatasets</c> and <c>DataLabelingServiceClient.ListDatasetsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDatasetsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataLabelingServiceClient.DeleteDataset</c> and <c>DataLabelingServiceClient.DeleteDatasetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDatasetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataLabelingServiceClient.ImportData</c> and <c>DataLabelingServiceClient.ImportDataAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ImportDataSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataLabelingServiceClient.ImportData</c> and
        /// <c>DataLabelingServiceClient.ImportDataAsync</c>.
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
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataLabelingServiceClient.ExportData</c> and <c>DataLabelingServiceClient.ExportDataAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExportDataSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataLabelingServiceClient.ExportData</c> and
        /// <c>DataLabelingServiceClient.ExportDataAsync</c>.
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
        /// <c>DataLabelingServiceClient.GetDataItem</c> and <c>DataLabelingServiceClient.GetDataItemAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDataItemSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataLabelingServiceClient.ListDataItems</c> and <c>DataLabelingServiceClient.ListDataItemsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDataItemsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataLabelingServiceClient.GetAnnotatedDataset</c> and
        /// <c>DataLabelingServiceClient.GetAnnotatedDatasetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAnnotatedDatasetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataLabelingServiceClient.ListAnnotatedDatasets</c> and
        /// <c>DataLabelingServiceClient.ListAnnotatedDatasetsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAnnotatedDatasetsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataLabelingServiceClient.DeleteAnnotatedDataset</c> and
        /// <c>DataLabelingServiceClient.DeleteAnnotatedDatasetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAnnotatedDatasetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataLabelingServiceClient.LabelImage</c> and <c>DataLabelingServiceClient.LabelImageAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings LabelImageSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataLabelingServiceClient.LabelImage</c> and
        /// <c>DataLabelingServiceClient.LabelImageAsync</c>.
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
        public lro::OperationsSettings LabelImageOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataLabelingServiceClient.LabelVideo</c> and <c>DataLabelingServiceClient.LabelVideoAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings LabelVideoSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataLabelingServiceClient.LabelVideo</c> and
        /// <c>DataLabelingServiceClient.LabelVideoAsync</c>.
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
        public lro::OperationsSettings LabelVideoOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataLabelingServiceClient.LabelText</c> and <c>DataLabelingServiceClient.LabelTextAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings LabelTextSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataLabelingServiceClient.LabelText</c> and
        /// <c>DataLabelingServiceClient.LabelTextAsync</c>.
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
        public lro::OperationsSettings LabelTextOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataLabelingServiceClient.GetExample</c> and <c>DataLabelingServiceClient.GetExampleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetExampleSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataLabelingServiceClient.ListExamples</c> and <c>DataLabelingServiceClient.ListExamplesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListExamplesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataLabelingServiceClient.CreateAnnotationSpecSet</c> and
        /// <c>DataLabelingServiceClient.CreateAnnotationSpecSetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAnnotationSpecSetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataLabelingServiceClient.GetAnnotationSpecSet</c> and
        /// <c>DataLabelingServiceClient.GetAnnotationSpecSetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAnnotationSpecSetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataLabelingServiceClient.ListAnnotationSpecSets</c> and
        /// <c>DataLabelingServiceClient.ListAnnotationSpecSetsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAnnotationSpecSetsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataLabelingServiceClient.DeleteAnnotationSpecSet</c> and
        /// <c>DataLabelingServiceClient.DeleteAnnotationSpecSetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAnnotationSpecSetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataLabelingServiceClient.CreateInstruction</c> and <c>DataLabelingServiceClient.CreateInstructionAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateInstructionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DataLabelingServiceClient.CreateInstruction</c> and
        /// <c>DataLabelingServiceClient.CreateInstructionAsync</c>.
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
        public lro::OperationsSettings CreateInstructionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataLabelingServiceClient.GetInstruction</c> and <c>DataLabelingServiceClient.GetInstructionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetInstructionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataLabelingServiceClient.ListInstructions</c> and <c>DataLabelingServiceClient.ListInstructionsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListInstructionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataLabelingServiceClient.DeleteInstruction</c> and <c>DataLabelingServiceClient.DeleteInstructionAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteInstructionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataLabelingServiceClient.GetEvaluation</c> and <c>DataLabelingServiceClient.GetEvaluationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEvaluationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataLabelingServiceClient.SearchEvaluations</c> and <c>DataLabelingServiceClient.SearchEvaluationsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchEvaluationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataLabelingServiceClient.SearchExampleComparisons</c> and
        /// <c>DataLabelingServiceClient.SearchExampleComparisonsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchExampleComparisonsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataLabelingServiceClient.CreateEvaluationJob</c> and
        /// <c>DataLabelingServiceClient.CreateEvaluationJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateEvaluationJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataLabelingServiceClient.UpdateEvaluationJob</c> and
        /// <c>DataLabelingServiceClient.UpdateEvaluationJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateEvaluationJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataLabelingServiceClient.GetEvaluationJob</c> and <c>DataLabelingServiceClient.GetEvaluationJobAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEvaluationJobSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataLabelingServiceClient.PauseEvaluationJob</c> and <c>DataLabelingServiceClient.PauseEvaluationJobAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PauseEvaluationJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataLabelingServiceClient.ResumeEvaluationJob</c> and
        /// <c>DataLabelingServiceClient.ResumeEvaluationJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResumeEvaluationJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataLabelingServiceClient.DeleteEvaluationJob</c> and
        /// <c>DataLabelingServiceClient.DeleteEvaluationJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteEvaluationJobSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DataLabelingServiceClient.ListEvaluationJobs</c> and <c>DataLabelingServiceClient.ListEvaluationJobsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 30000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 30 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEvaluationJobsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(30000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(30000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DataLabelingServiceSettings"/> object.</returns>
        public DataLabelingServiceSettings Clone() => new DataLabelingServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DataLabelingServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class DataLabelingServiceClientBuilder : gaxgrpc::ClientBuilderBase<DataLabelingServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DataLabelingServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DataLabelingServiceClientBuilder() : base(DataLabelingServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DataLabelingServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DataLabelingServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DataLabelingServiceClient Build()
        {
            DataLabelingServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DataLabelingServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DataLabelingServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DataLabelingServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DataLabelingServiceClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<DataLabelingServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DataLabelingServiceClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DataLabelingServiceClient.ChannelPool;
    }

    /// <summary>DataLabelingService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service for the AI Platform Data Labeling API.
    /// </remarks>
    public abstract partial class DataLabelingServiceClient
    {
        /// <summary>
        /// The default endpoint for the DataLabelingService service, which is a host of "datalabeling.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "datalabeling.googleapis.com:443";

        /// <summary>The default DataLabelingService scopes.</summary>
        /// <remarks>
        /// The default DataLabelingService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DataLabelingService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DataLabelingServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="DataLabelingServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DataLabelingServiceClient"/>.</returns>
        public static stt::Task<DataLabelingServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DataLabelingServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DataLabelingServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="DataLabelingServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DataLabelingServiceClient"/>.</returns>
        public static DataLabelingServiceClient Create() => new DataLabelingServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DataLabelingServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DataLabelingServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DataLabelingServiceClient"/>.</returns>
        internal static DataLabelingServiceClient Create(grpccore::CallInvoker callInvoker, DataLabelingServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DataLabelingService.DataLabelingServiceClient grpcClient = new DataLabelingService.DataLabelingServiceClient(callInvoker);
            return new DataLabelingServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DataLabelingService client</summary>
        public virtual DataLabelingService.DataLabelingServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates dataset. If success return a Dataset resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dataset CreateDataset(CreateDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates dataset. If success return a Dataset resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> CreateDatasetAsync(CreateDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates dataset. If success return a Dataset resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> CreateDatasetAsync(CreateDatasetRequest request, st::CancellationToken cancellationToken) =>
            CreateDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates dataset. If success return a Dataset resource.
        /// </summary>
        /// <param name="parent">
        /// Required. Dataset resource parent, format:
        /// projects/{project_id}
        /// </param>
        /// <param name="dataset">
        /// Required. The dataset to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dataset CreateDataset(string parent, Dataset dataset, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataset(new CreateDatasetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Dataset = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
            }, callSettings);

        /// <summary>
        /// Creates dataset. If success return a Dataset resource.
        /// </summary>
        /// <param name="parent">
        /// Required. Dataset resource parent, format:
        /// projects/{project_id}
        /// </param>
        /// <param name="dataset">
        /// Required. The dataset to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> CreateDatasetAsync(string parent, Dataset dataset, gaxgrpc::CallSettings callSettings = null) =>
            CreateDatasetAsync(new CreateDatasetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Dataset = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
            }, callSettings);

        /// <summary>
        /// Creates dataset. If success return a Dataset resource.
        /// </summary>
        /// <param name="parent">
        /// Required. Dataset resource parent, format:
        /// projects/{project_id}
        /// </param>
        /// <param name="dataset">
        /// Required. The dataset to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> CreateDatasetAsync(string parent, Dataset dataset, st::CancellationToken cancellationToken) =>
            CreateDatasetAsync(parent, dataset, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates dataset. If success return a Dataset resource.
        /// </summary>
        /// <param name="parent">
        /// Required. Dataset resource parent, format:
        /// projects/{project_id}
        /// </param>
        /// <param name="dataset">
        /// Required. The dataset to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dataset CreateDataset(gagr::ProjectName parent, Dataset dataset, gaxgrpc::CallSettings callSettings = null) =>
            CreateDataset(new CreateDatasetRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Dataset = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
            }, callSettings);

        /// <summary>
        /// Creates dataset. If success return a Dataset resource.
        /// </summary>
        /// <param name="parent">
        /// Required. Dataset resource parent, format:
        /// projects/{project_id}
        /// </param>
        /// <param name="dataset">
        /// Required. The dataset to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> CreateDatasetAsync(gagr::ProjectName parent, Dataset dataset, gaxgrpc::CallSettings callSettings = null) =>
            CreateDatasetAsync(new CreateDatasetRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Dataset = gax::GaxPreconditions.CheckNotNull(dataset, nameof(dataset)),
            }, callSettings);

        /// <summary>
        /// Creates dataset. If success return a Dataset resource.
        /// </summary>
        /// <param name="parent">
        /// Required. Dataset resource parent, format:
        /// projects/{project_id}
        /// </param>
        /// <param name="dataset">
        /// Required. The dataset to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> CreateDatasetAsync(gagr::ProjectName parent, Dataset dataset, st::CancellationToken cancellationToken) =>
            CreateDatasetAsync(parent, dataset, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets dataset by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dataset GetDataset(GetDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets dataset by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(GetDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets dataset by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(GetDatasetRequest request, st::CancellationToken cancellationToken) =>
            GetDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets dataset by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Dataset resource name, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dataset GetDataset(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataset(new GetDatasetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets dataset by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Dataset resource name, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDatasetAsync(new GetDatasetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets dataset by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Dataset resource name, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(string name, st::CancellationToken cancellationToken) =>
            GetDatasetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets dataset by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Dataset resource name, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dataset GetDataset(DatasetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataset(new GetDatasetRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets dataset by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Dataset resource name, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(DatasetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDatasetAsync(new GetDatasetRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets dataset by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Dataset resource name, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(DatasetName name, st::CancellationToken cancellationToken) =>
            GetDatasetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists datasets under a project. Pagination is supported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Dataset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDatasetsResponse, Dataset> ListDatasets(ListDatasetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists datasets under a project. Pagination is supported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Dataset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDatasetsResponse, Dataset> ListDatasetsAsync(ListDatasetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists datasets under a project. Pagination is supported.
        /// </summary>
        /// <param name="parent">
        /// Required. Dataset resource parent, format:
        /// projects/{project_id}
        /// </param>
        /// <param name="filter">
        /// Optional. Filter on dataset is not supported at this moment.
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
        public virtual gax::PagedEnumerable<ListDatasetsResponse, Dataset> ListDatasets(string parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDatasets(new ListDatasetsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = filter ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists datasets under a project. Pagination is supported.
        /// </summary>
        /// <param name="parent">
        /// Required. Dataset resource parent, format:
        /// projects/{project_id}
        /// </param>
        /// <param name="filter">
        /// Optional. Filter on dataset is not supported at this moment.
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
        public virtual gax::PagedAsyncEnumerable<ListDatasetsResponse, Dataset> ListDatasetsAsync(string parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDatasetsAsync(new ListDatasetsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = filter ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists datasets under a project. Pagination is supported.
        /// </summary>
        /// <param name="parent">
        /// Required. Dataset resource parent, format:
        /// projects/{project_id}
        /// </param>
        /// <param name="filter">
        /// Optional. Filter on dataset is not supported at this moment.
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
        public virtual gax::PagedEnumerable<ListDatasetsResponse, Dataset> ListDatasets(gagr::ProjectName parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDatasets(new ListDatasetsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = filter ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists datasets under a project. Pagination is supported.
        /// </summary>
        /// <param name="parent">
        /// Required. Dataset resource parent, format:
        /// projects/{project_id}
        /// </param>
        /// <param name="filter">
        /// Optional. Filter on dataset is not supported at this moment.
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
        public virtual gax::PagedAsyncEnumerable<ListDatasetsResponse, Dataset> ListDatasetsAsync(gagr::ProjectName parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDatasetsAsync(new ListDatasetsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = filter ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Deletes a dataset by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDataset(DeleteDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a dataset by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDatasetAsync(DeleteDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a dataset by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDatasetAsync(DeleteDatasetRequest request, st::CancellationToken cancellationToken) =>
            DeleteDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a dataset by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Dataset resource name, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDataset(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataset(new DeleteDatasetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a dataset by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Dataset resource name, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDatasetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDatasetAsync(new DeleteDatasetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a dataset by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Dataset resource name, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDatasetAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDatasetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a dataset by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Dataset resource name, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDataset(DatasetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDataset(new DeleteDatasetRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a dataset by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Dataset resource name, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDatasetAsync(DatasetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDatasetAsync(new DeleteDatasetRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a dataset by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Dataset resource name, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDatasetAsync(DatasetName name, st::CancellationToken cancellationToken) =>
            DeleteDatasetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports data into dataset based on source locations defined in request.
        /// It can be called multiple times for the same dataset. Each dataset can
        /// only have one long running operation running on it. For example, no
        /// labeling task (also long running operation) can be started while
        /// importing is still ongoing. Vice versa.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportDataOperationResponse, ImportDataOperationMetadata> ImportData(ImportDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports data into dataset based on source locations defined in request.
        /// It can be called multiple times for the same dataset. Each dataset can
        /// only have one long running operation running on it. For example, no
        /// labeling task (also long running operation) can be started while
        /// importing is still ongoing. Vice versa.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportDataOperationResponse, ImportDataOperationMetadata>> ImportDataAsync(ImportDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports data into dataset based on source locations defined in request.
        /// It can be called multiple times for the same dataset. Each dataset can
        /// only have one long running operation running on it. For example, no
        /// labeling task (also long running operation) can be started while
        /// importing is still ongoing. Vice versa.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportDataOperationResponse, ImportDataOperationMetadata>> ImportDataAsync(ImportDataRequest request, st::CancellationToken cancellationToken) =>
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
        public virtual lro::Operation<ImportDataOperationResponse, ImportDataOperationMetadata> PollOnceImportData(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportDataOperationResponse, ImportDataOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportDataOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ImportData</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ImportDataOperationResponse, ImportDataOperationMetadata>> PollOnceImportDataAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ImportDataOperationResponse, ImportDataOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ImportDataOperationsClient, callSettings);

        /// <summary>
        /// Imports data into dataset based on source locations defined in request.
        /// It can be called multiple times for the same dataset. Each dataset can
        /// only have one long running operation running on it. For example, no
        /// labeling task (also long running operation) can be started while
        /// importing is still ongoing. Vice versa.
        /// </summary>
        /// <param name="name">
        /// Required. Dataset resource name, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="inputConfig">
        /// Required. Specify the input source of the data.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportDataOperationResponse, ImportDataOperationMetadata> ImportData(string name, InputConfig inputConfig, gaxgrpc::CallSettings callSettings = null) =>
            ImportData(new ImportDataRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                InputConfig = gax::GaxPreconditions.CheckNotNull(inputConfig, nameof(inputConfig)),
            }, callSettings);

        /// <summary>
        /// Imports data into dataset based on source locations defined in request.
        /// It can be called multiple times for the same dataset. Each dataset can
        /// only have one long running operation running on it. For example, no
        /// labeling task (also long running operation) can be started while
        /// importing is still ongoing. Vice versa.
        /// </summary>
        /// <param name="name">
        /// Required. Dataset resource name, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="inputConfig">
        /// Required. Specify the input source of the data.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportDataOperationResponse, ImportDataOperationMetadata>> ImportDataAsync(string name, InputConfig inputConfig, gaxgrpc::CallSettings callSettings = null) =>
            ImportDataAsync(new ImportDataRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                InputConfig = gax::GaxPreconditions.CheckNotNull(inputConfig, nameof(inputConfig)),
            }, callSettings);

        /// <summary>
        /// Imports data into dataset based on source locations defined in request.
        /// It can be called multiple times for the same dataset. Each dataset can
        /// only have one long running operation running on it. For example, no
        /// labeling task (also long running operation) can be started while
        /// importing is still ongoing. Vice versa.
        /// </summary>
        /// <param name="name">
        /// Required. Dataset resource name, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="inputConfig">
        /// Required. Specify the input source of the data.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportDataOperationResponse, ImportDataOperationMetadata>> ImportDataAsync(string name, InputConfig inputConfig, st::CancellationToken cancellationToken) =>
            ImportDataAsync(name, inputConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports data into dataset based on source locations defined in request.
        /// It can be called multiple times for the same dataset. Each dataset can
        /// only have one long running operation running on it. For example, no
        /// labeling task (also long running operation) can be started while
        /// importing is still ongoing. Vice versa.
        /// </summary>
        /// <param name="name">
        /// Required. Dataset resource name, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="inputConfig">
        /// Required. Specify the input source of the data.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ImportDataOperationResponse, ImportDataOperationMetadata> ImportData(DatasetName name, InputConfig inputConfig, gaxgrpc::CallSettings callSettings = null) =>
            ImportData(new ImportDataRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                InputConfig = gax::GaxPreconditions.CheckNotNull(inputConfig, nameof(inputConfig)),
            }, callSettings);

        /// <summary>
        /// Imports data into dataset based on source locations defined in request.
        /// It can be called multiple times for the same dataset. Each dataset can
        /// only have one long running operation running on it. For example, no
        /// labeling task (also long running operation) can be started while
        /// importing is still ongoing. Vice versa.
        /// </summary>
        /// <param name="name">
        /// Required. Dataset resource name, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="inputConfig">
        /// Required. Specify the input source of the data.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportDataOperationResponse, ImportDataOperationMetadata>> ImportDataAsync(DatasetName name, InputConfig inputConfig, gaxgrpc::CallSettings callSettings = null) =>
            ImportDataAsync(new ImportDataRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                InputConfig = gax::GaxPreconditions.CheckNotNull(inputConfig, nameof(inputConfig)),
            }, callSettings);

        /// <summary>
        /// Imports data into dataset based on source locations defined in request.
        /// It can be called multiple times for the same dataset. Each dataset can
        /// only have one long running operation running on it. For example, no
        /// labeling task (also long running operation) can be started while
        /// importing is still ongoing. Vice versa.
        /// </summary>
        /// <param name="name">
        /// Required. Dataset resource name, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="inputConfig">
        /// Required. Specify the input source of the data.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ImportDataOperationResponse, ImportDataOperationMetadata>> ImportDataAsync(DatasetName name, InputConfig inputConfig, st::CancellationToken cancellationToken) =>
            ImportDataAsync(name, inputConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports data and annotations from dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportDataOperationResponse, ExportDataOperationMetadata> ExportData(ExportDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports data and annotations from dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportDataOperationResponse, ExportDataOperationMetadata>> ExportDataAsync(ExportDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports data and annotations from dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportDataOperationResponse, ExportDataOperationMetadata>> ExportDataAsync(ExportDataRequest request, st::CancellationToken cancellationToken) =>
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
        public virtual lro::Operation<ExportDataOperationResponse, ExportDataOperationMetadata> PollOnceExportData(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportDataOperationResponse, ExportDataOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportDataOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportData</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ExportDataOperationResponse, ExportDataOperationMetadata>> PollOnceExportDataAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportDataOperationResponse, ExportDataOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportDataOperationsClient, callSettings);

        /// <summary>
        /// Exports data and annotations from dataset.
        /// </summary>
        /// <param name="name">
        /// Required. Dataset resource name, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="annotatedDataset">
        /// Required. Annotated dataset resource name. DataItem in
        /// Dataset and their annotations in specified annotated dataset will be
        /// exported. It's in format of
        /// projects/{project_id}/datasets/{dataset_id}/annotatedDatasets/
        /// {annotated_dataset_id}
        /// </param>
        /// <param name="filter">
        /// Optional. Filter is not supported at this moment.
        /// </param>
        /// <param name="outputConfig">
        /// Required. Specify the output destination.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportDataOperationResponse, ExportDataOperationMetadata> ExportData(string name, string annotatedDataset, string filter, OutputConfig outputConfig, gaxgrpc::CallSettings callSettings = null) =>
            ExportData(new ExportDataRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                AnnotatedDataset = gax::GaxPreconditions.CheckNotNullOrEmpty(annotatedDataset, nameof(annotatedDataset)),
                Filter = filter ?? "",
                OutputConfig = gax::GaxPreconditions.CheckNotNull(outputConfig, nameof(outputConfig)),
            }, callSettings);

        /// <summary>
        /// Exports data and annotations from dataset.
        /// </summary>
        /// <param name="name">
        /// Required. Dataset resource name, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="annotatedDataset">
        /// Required. Annotated dataset resource name. DataItem in
        /// Dataset and their annotations in specified annotated dataset will be
        /// exported. It's in format of
        /// projects/{project_id}/datasets/{dataset_id}/annotatedDatasets/
        /// {annotated_dataset_id}
        /// </param>
        /// <param name="filter">
        /// Optional. Filter is not supported at this moment.
        /// </param>
        /// <param name="outputConfig">
        /// Required. Specify the output destination.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportDataOperationResponse, ExportDataOperationMetadata>> ExportDataAsync(string name, string annotatedDataset, string filter, OutputConfig outputConfig, gaxgrpc::CallSettings callSettings = null) =>
            ExportDataAsync(new ExportDataRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                AnnotatedDataset = gax::GaxPreconditions.CheckNotNullOrEmpty(annotatedDataset, nameof(annotatedDataset)),
                Filter = filter ?? "",
                OutputConfig = gax::GaxPreconditions.CheckNotNull(outputConfig, nameof(outputConfig)),
            }, callSettings);

        /// <summary>
        /// Exports data and annotations from dataset.
        /// </summary>
        /// <param name="name">
        /// Required. Dataset resource name, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="annotatedDataset">
        /// Required. Annotated dataset resource name. DataItem in
        /// Dataset and their annotations in specified annotated dataset will be
        /// exported. It's in format of
        /// projects/{project_id}/datasets/{dataset_id}/annotatedDatasets/
        /// {annotated_dataset_id}
        /// </param>
        /// <param name="filter">
        /// Optional. Filter is not supported at this moment.
        /// </param>
        /// <param name="outputConfig">
        /// Required. Specify the output destination.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportDataOperationResponse, ExportDataOperationMetadata>> ExportDataAsync(string name, string annotatedDataset, string filter, OutputConfig outputConfig, st::CancellationToken cancellationToken) =>
            ExportDataAsync(name, annotatedDataset, filter, outputConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports data and annotations from dataset.
        /// </summary>
        /// <param name="name">
        /// Required. Dataset resource name, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="annotatedDataset">
        /// Required. Annotated dataset resource name. DataItem in
        /// Dataset and their annotations in specified annotated dataset will be
        /// exported. It's in format of
        /// projects/{project_id}/datasets/{dataset_id}/annotatedDatasets/
        /// {annotated_dataset_id}
        /// </param>
        /// <param name="filter">
        /// Optional. Filter is not supported at this moment.
        /// </param>
        /// <param name="outputConfig">
        /// Required. Specify the output destination.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportDataOperationResponse, ExportDataOperationMetadata> ExportData(DatasetName name, AnnotatedDatasetName annotatedDataset, string filter, OutputConfig outputConfig, gaxgrpc::CallSettings callSettings = null) =>
            ExportData(new ExportDataRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                AnnotatedDatasetAsAnnotatedDatasetName = gax::GaxPreconditions.CheckNotNull(annotatedDataset, nameof(annotatedDataset)),
                Filter = filter ?? "",
                OutputConfig = gax::GaxPreconditions.CheckNotNull(outputConfig, nameof(outputConfig)),
            }, callSettings);

        /// <summary>
        /// Exports data and annotations from dataset.
        /// </summary>
        /// <param name="name">
        /// Required. Dataset resource name, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="annotatedDataset">
        /// Required. Annotated dataset resource name. DataItem in
        /// Dataset and their annotations in specified annotated dataset will be
        /// exported. It's in format of
        /// projects/{project_id}/datasets/{dataset_id}/annotatedDatasets/
        /// {annotated_dataset_id}
        /// </param>
        /// <param name="filter">
        /// Optional. Filter is not supported at this moment.
        /// </param>
        /// <param name="outputConfig">
        /// Required. Specify the output destination.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportDataOperationResponse, ExportDataOperationMetadata>> ExportDataAsync(DatasetName name, AnnotatedDatasetName annotatedDataset, string filter, OutputConfig outputConfig, gaxgrpc::CallSettings callSettings = null) =>
            ExportDataAsync(new ExportDataRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                AnnotatedDatasetAsAnnotatedDatasetName = gax::GaxPreconditions.CheckNotNull(annotatedDataset, nameof(annotatedDataset)),
                Filter = filter ?? "",
                OutputConfig = gax::GaxPreconditions.CheckNotNull(outputConfig, nameof(outputConfig)),
            }, callSettings);

        /// <summary>
        /// Exports data and annotations from dataset.
        /// </summary>
        /// <param name="name">
        /// Required. Dataset resource name, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="annotatedDataset">
        /// Required. Annotated dataset resource name. DataItem in
        /// Dataset and their annotations in specified annotated dataset will be
        /// exported. It's in format of
        /// projects/{project_id}/datasets/{dataset_id}/annotatedDatasets/
        /// {annotated_dataset_id}
        /// </param>
        /// <param name="filter">
        /// Optional. Filter is not supported at this moment.
        /// </param>
        /// <param name="outputConfig">
        /// Required. Specify the output destination.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportDataOperationResponse, ExportDataOperationMetadata>> ExportDataAsync(DatasetName name, AnnotatedDatasetName annotatedDataset, string filter, OutputConfig outputConfig, st::CancellationToken cancellationToken) =>
            ExportDataAsync(name, annotatedDataset, filter, outputConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a data item in a dataset by resource name. This API can be
        /// called after data are imported into dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataItem GetDataItem(GetDataItemRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a data item in a dataset by resource name. This API can be
        /// called after data are imported into dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataItem> GetDataItemAsync(GetDataItemRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a data item in a dataset by resource name. This API can be
        /// called after data are imported into dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataItem> GetDataItemAsync(GetDataItemRequest request, st::CancellationToken cancellationToken) =>
            GetDataItemAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a data item in a dataset by resource name. This API can be
        /// called after data are imported into dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data item to get, format:
        /// projects/{project_id}/datasets/{dataset_id}/dataItems/{data_item_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataItem GetDataItem(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataItem(new GetDataItemRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a data item in a dataset by resource name. This API can be
        /// called after data are imported into dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data item to get, format:
        /// projects/{project_id}/datasets/{dataset_id}/dataItems/{data_item_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataItem> GetDataItemAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataItemAsync(new GetDataItemRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a data item in a dataset by resource name. This API can be
        /// called after data are imported into dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data item to get, format:
        /// projects/{project_id}/datasets/{dataset_id}/dataItems/{data_item_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataItem> GetDataItemAsync(string name, st::CancellationToken cancellationToken) =>
            GetDataItemAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a data item in a dataset by resource name. This API can be
        /// called after data are imported into dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data item to get, format:
        /// projects/{project_id}/datasets/{dataset_id}/dataItems/{data_item_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DataItem GetDataItem(DataItemName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataItem(new GetDataItemRequest
            {
                DataItemName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a data item in a dataset by resource name. This API can be
        /// called after data are imported into dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data item to get, format:
        /// projects/{project_id}/datasets/{dataset_id}/dataItems/{data_item_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataItem> GetDataItemAsync(DataItemName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataItemAsync(new GetDataItemRequest
            {
                DataItemName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a data item in a dataset by resource name. This API can be
        /// called after data are imported into dataset.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the data item to get, format:
        /// projects/{project_id}/datasets/{dataset_id}/dataItems/{data_item_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DataItem> GetDataItemAsync(DataItemName name, st::CancellationToken cancellationToken) =>
            GetDataItemAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists data items in a dataset. This API can be called after data
        /// are imported into dataset. Pagination is supported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataItem"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataItemsResponse, DataItem> ListDataItems(ListDataItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists data items in a dataset. This API can be called after data
        /// are imported into dataset. Pagination is supported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataItem"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataItemsResponse, DataItem> ListDataItemsAsync(ListDataItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists data items in a dataset. This API can be called after data
        /// are imported into dataset. Pagination is supported.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the dataset to list data items, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="filter">
        /// Optional. Filter is not supported at this moment.
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
        /// <returns>A pageable sequence of <see cref="DataItem"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataItemsResponse, DataItem> ListDataItems(string parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDataItems(new ListDataItemsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = filter ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists data items in a dataset. This API can be called after data
        /// are imported into dataset. Pagination is supported.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the dataset to list data items, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="filter">
        /// Optional. Filter is not supported at this moment.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataItem"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataItemsResponse, DataItem> ListDataItemsAsync(string parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDataItemsAsync(new ListDataItemsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = filter ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists data items in a dataset. This API can be called after data
        /// are imported into dataset. Pagination is supported.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the dataset to list data items, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="filter">
        /// Optional. Filter is not supported at this moment.
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
        /// <returns>A pageable sequence of <see cref="DataItem"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDataItemsResponse, DataItem> ListDataItems(DatasetName parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDataItems(new ListDataItemsRequest
            {
                ParentAsDatasetName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = filter ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists data items in a dataset. This API can be called after data
        /// are imported into dataset. Pagination is supported.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the dataset to list data items, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="filter">
        /// Optional. Filter is not supported at this moment.
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
        /// <returns>A pageable asynchronous sequence of <see cref="DataItem"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDataItemsResponse, DataItem> ListDataItemsAsync(DatasetName parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListDataItemsAsync(new ListDataItemsRequest
            {
                ParentAsDatasetName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = filter ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Gets an annotated dataset by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnnotatedDataset GetAnnotatedDataset(GetAnnotatedDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an annotated dataset by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotatedDataset> GetAnnotatedDatasetAsync(GetAnnotatedDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an annotated dataset by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotatedDataset> GetAnnotatedDatasetAsync(GetAnnotatedDatasetRequest request, st::CancellationToken cancellationToken) =>
            GetAnnotatedDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an annotated dataset by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the annotated dataset to get, format:
        /// projects/{project_id}/datasets/{dataset_id}/annotatedDatasets/
        /// {annotated_dataset_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnnotatedDataset GetAnnotatedDataset(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnnotatedDataset(new GetAnnotatedDatasetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an annotated dataset by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the annotated dataset to get, format:
        /// projects/{project_id}/datasets/{dataset_id}/annotatedDatasets/
        /// {annotated_dataset_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotatedDataset> GetAnnotatedDatasetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnnotatedDatasetAsync(new GetAnnotatedDatasetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an annotated dataset by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the annotated dataset to get, format:
        /// projects/{project_id}/datasets/{dataset_id}/annotatedDatasets/
        /// {annotated_dataset_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotatedDataset> GetAnnotatedDatasetAsync(string name, st::CancellationToken cancellationToken) =>
            GetAnnotatedDatasetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an annotated dataset by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the annotated dataset to get, format:
        /// projects/{project_id}/datasets/{dataset_id}/annotatedDatasets/
        /// {annotated_dataset_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnnotatedDataset GetAnnotatedDataset(AnnotatedDatasetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnnotatedDataset(new GetAnnotatedDatasetRequest
            {
                AnnotatedDatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an annotated dataset by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the annotated dataset to get, format:
        /// projects/{project_id}/datasets/{dataset_id}/annotatedDatasets/
        /// {annotated_dataset_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotatedDataset> GetAnnotatedDatasetAsync(AnnotatedDatasetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnnotatedDatasetAsync(new GetAnnotatedDatasetRequest
            {
                AnnotatedDatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an annotated dataset by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the annotated dataset to get, format:
        /// projects/{project_id}/datasets/{dataset_id}/annotatedDatasets/
        /// {annotated_dataset_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotatedDataset> GetAnnotatedDatasetAsync(AnnotatedDatasetName name, st::CancellationToken cancellationToken) =>
            GetAnnotatedDatasetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists annotated datasets for a dataset. Pagination is supported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AnnotatedDataset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAnnotatedDatasetsResponse, AnnotatedDataset> ListAnnotatedDatasets(ListAnnotatedDatasetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists annotated datasets for a dataset. Pagination is supported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AnnotatedDataset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAnnotatedDatasetsResponse, AnnotatedDataset> ListAnnotatedDatasetsAsync(ListAnnotatedDatasetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists annotated datasets for a dataset. Pagination is supported.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the dataset to list annotated datasets, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="filter">
        /// Optional. Filter is not supported at this moment.
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
        /// <returns>A pageable sequence of <see cref="AnnotatedDataset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAnnotatedDatasetsResponse, AnnotatedDataset> ListAnnotatedDatasets(string parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAnnotatedDatasets(new ListAnnotatedDatasetsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = filter ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists annotated datasets for a dataset. Pagination is supported.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the dataset to list annotated datasets, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="filter">
        /// Optional. Filter is not supported at this moment.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AnnotatedDataset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAnnotatedDatasetsResponse, AnnotatedDataset> ListAnnotatedDatasetsAsync(string parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAnnotatedDatasetsAsync(new ListAnnotatedDatasetsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = filter ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists annotated datasets for a dataset. Pagination is supported.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the dataset to list annotated datasets, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="filter">
        /// Optional. Filter is not supported at this moment.
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
        /// <returns>A pageable sequence of <see cref="AnnotatedDataset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAnnotatedDatasetsResponse, AnnotatedDataset> ListAnnotatedDatasets(DatasetName parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAnnotatedDatasets(new ListAnnotatedDatasetsRequest
            {
                ParentAsDatasetName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = filter ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists annotated datasets for a dataset. Pagination is supported.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the dataset to list annotated datasets, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="filter">
        /// Optional. Filter is not supported at this moment.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AnnotatedDataset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAnnotatedDatasetsResponse, AnnotatedDataset> ListAnnotatedDatasetsAsync(DatasetName parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAnnotatedDatasetsAsync(new ListAnnotatedDatasetsRequest
            {
                ParentAsDatasetName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = filter ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Deletes an annotated dataset by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAnnotatedDataset(DeleteAnnotatedDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an annotated dataset by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnnotatedDatasetAsync(DeleteAnnotatedDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an annotated dataset by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnnotatedDatasetAsync(DeleteAnnotatedDatasetRequest request, st::CancellationToken cancellationToken) =>
            DeleteAnnotatedDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts a labeling task for image. The type of image labeling task is
        /// configured by feature in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AnnotatedDataset, LabelOperationMetadata> LabelImage(LabelImageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts a labeling task for image. The type of image labeling task is
        /// configured by feature in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AnnotatedDataset, LabelOperationMetadata>> LabelImageAsync(LabelImageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts a labeling task for image. The type of image labeling task is
        /// configured by feature in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AnnotatedDataset, LabelOperationMetadata>> LabelImageAsync(LabelImageRequest request, st::CancellationToken cancellationToken) =>
            LabelImageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>LabelImage</c>.</summary>
        public virtual lro::OperationsClient LabelImageOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>LabelImage</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AnnotatedDataset, LabelOperationMetadata> PollOnceLabelImage(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AnnotatedDataset, LabelOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), LabelImageOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>LabelImage</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AnnotatedDataset, LabelOperationMetadata>> PollOnceLabelImageAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AnnotatedDataset, LabelOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), LabelImageOperationsClient, callSettings);

        /// <summary>
        /// Starts a labeling task for image. The type of image labeling task is
        /// configured by feature in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the dataset to request labeling task, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="basicConfig">
        /// Required. Basic human annotation config.
        /// </param>
        /// <param name="feature">
        /// Required. The type of image labeling task.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AnnotatedDataset, LabelOperationMetadata> LabelImage(string parent, HumanAnnotationConfig basicConfig, LabelImageRequest.Types.Feature feature, gaxgrpc::CallSettings callSettings = null) =>
            LabelImage(new LabelImageRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BasicConfig = gax::GaxPreconditions.CheckNotNull(basicConfig, nameof(basicConfig)),
                Feature = feature,
            }, callSettings);

        /// <summary>
        /// Starts a labeling task for image. The type of image labeling task is
        /// configured by feature in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the dataset to request labeling task, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="basicConfig">
        /// Required. Basic human annotation config.
        /// </param>
        /// <param name="feature">
        /// Required. The type of image labeling task.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AnnotatedDataset, LabelOperationMetadata>> LabelImageAsync(string parent, HumanAnnotationConfig basicConfig, LabelImageRequest.Types.Feature feature, gaxgrpc::CallSettings callSettings = null) =>
            LabelImageAsync(new LabelImageRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BasicConfig = gax::GaxPreconditions.CheckNotNull(basicConfig, nameof(basicConfig)),
                Feature = feature,
            }, callSettings);

        /// <summary>
        /// Starts a labeling task for image. The type of image labeling task is
        /// configured by feature in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the dataset to request labeling task, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="basicConfig">
        /// Required. Basic human annotation config.
        /// </param>
        /// <param name="feature">
        /// Required. The type of image labeling task.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AnnotatedDataset, LabelOperationMetadata>> LabelImageAsync(string parent, HumanAnnotationConfig basicConfig, LabelImageRequest.Types.Feature feature, st::CancellationToken cancellationToken) =>
            LabelImageAsync(parent, basicConfig, feature, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts a labeling task for image. The type of image labeling task is
        /// configured by feature in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the dataset to request labeling task, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="basicConfig">
        /// Required. Basic human annotation config.
        /// </param>
        /// <param name="feature">
        /// Required. The type of image labeling task.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AnnotatedDataset, LabelOperationMetadata> LabelImage(DatasetName parent, HumanAnnotationConfig basicConfig, LabelImageRequest.Types.Feature feature, gaxgrpc::CallSettings callSettings = null) =>
            LabelImage(new LabelImageRequest
            {
                ParentAsDatasetName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BasicConfig = gax::GaxPreconditions.CheckNotNull(basicConfig, nameof(basicConfig)),
                Feature = feature,
            }, callSettings);

        /// <summary>
        /// Starts a labeling task for image. The type of image labeling task is
        /// configured by feature in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the dataset to request labeling task, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="basicConfig">
        /// Required. Basic human annotation config.
        /// </param>
        /// <param name="feature">
        /// Required. The type of image labeling task.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AnnotatedDataset, LabelOperationMetadata>> LabelImageAsync(DatasetName parent, HumanAnnotationConfig basicConfig, LabelImageRequest.Types.Feature feature, gaxgrpc::CallSettings callSettings = null) =>
            LabelImageAsync(new LabelImageRequest
            {
                ParentAsDatasetName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BasicConfig = gax::GaxPreconditions.CheckNotNull(basicConfig, nameof(basicConfig)),
                Feature = feature,
            }, callSettings);

        /// <summary>
        /// Starts a labeling task for image. The type of image labeling task is
        /// configured by feature in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the dataset to request labeling task, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="basicConfig">
        /// Required. Basic human annotation config.
        /// </param>
        /// <param name="feature">
        /// Required. The type of image labeling task.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AnnotatedDataset, LabelOperationMetadata>> LabelImageAsync(DatasetName parent, HumanAnnotationConfig basicConfig, LabelImageRequest.Types.Feature feature, st::CancellationToken cancellationToken) =>
            LabelImageAsync(parent, basicConfig, feature, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts a labeling task for video. The type of video labeling task is
        /// configured by feature in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AnnotatedDataset, LabelOperationMetadata> LabelVideo(LabelVideoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts a labeling task for video. The type of video labeling task is
        /// configured by feature in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AnnotatedDataset, LabelOperationMetadata>> LabelVideoAsync(LabelVideoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts a labeling task for video. The type of video labeling task is
        /// configured by feature in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AnnotatedDataset, LabelOperationMetadata>> LabelVideoAsync(LabelVideoRequest request, st::CancellationToken cancellationToken) =>
            LabelVideoAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>LabelVideo</c>.</summary>
        public virtual lro::OperationsClient LabelVideoOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>LabelVideo</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AnnotatedDataset, LabelOperationMetadata> PollOnceLabelVideo(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AnnotatedDataset, LabelOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), LabelVideoOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>LabelVideo</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AnnotatedDataset, LabelOperationMetadata>> PollOnceLabelVideoAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AnnotatedDataset, LabelOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), LabelVideoOperationsClient, callSettings);

        /// <summary>
        /// Starts a labeling task for video. The type of video labeling task is
        /// configured by feature in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the dataset to request labeling task, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="basicConfig">
        /// Required. Basic human annotation config.
        /// </param>
        /// <param name="feature">
        /// Required. The type of video labeling task.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AnnotatedDataset, LabelOperationMetadata> LabelVideo(string parent, HumanAnnotationConfig basicConfig, LabelVideoRequest.Types.Feature feature, gaxgrpc::CallSettings callSettings = null) =>
            LabelVideo(new LabelVideoRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BasicConfig = gax::GaxPreconditions.CheckNotNull(basicConfig, nameof(basicConfig)),
                Feature = feature,
            }, callSettings);

        /// <summary>
        /// Starts a labeling task for video. The type of video labeling task is
        /// configured by feature in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the dataset to request labeling task, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="basicConfig">
        /// Required. Basic human annotation config.
        /// </param>
        /// <param name="feature">
        /// Required. The type of video labeling task.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AnnotatedDataset, LabelOperationMetadata>> LabelVideoAsync(string parent, HumanAnnotationConfig basicConfig, LabelVideoRequest.Types.Feature feature, gaxgrpc::CallSettings callSettings = null) =>
            LabelVideoAsync(new LabelVideoRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BasicConfig = gax::GaxPreconditions.CheckNotNull(basicConfig, nameof(basicConfig)),
                Feature = feature,
            }, callSettings);

        /// <summary>
        /// Starts a labeling task for video. The type of video labeling task is
        /// configured by feature in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the dataset to request labeling task, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="basicConfig">
        /// Required. Basic human annotation config.
        /// </param>
        /// <param name="feature">
        /// Required. The type of video labeling task.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AnnotatedDataset, LabelOperationMetadata>> LabelVideoAsync(string parent, HumanAnnotationConfig basicConfig, LabelVideoRequest.Types.Feature feature, st::CancellationToken cancellationToken) =>
            LabelVideoAsync(parent, basicConfig, feature, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts a labeling task for video. The type of video labeling task is
        /// configured by feature in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the dataset to request labeling task, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="basicConfig">
        /// Required. Basic human annotation config.
        /// </param>
        /// <param name="feature">
        /// Required. The type of video labeling task.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AnnotatedDataset, LabelOperationMetadata> LabelVideo(DatasetName parent, HumanAnnotationConfig basicConfig, LabelVideoRequest.Types.Feature feature, gaxgrpc::CallSettings callSettings = null) =>
            LabelVideo(new LabelVideoRequest
            {
                ParentAsDatasetName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BasicConfig = gax::GaxPreconditions.CheckNotNull(basicConfig, nameof(basicConfig)),
                Feature = feature,
            }, callSettings);

        /// <summary>
        /// Starts a labeling task for video. The type of video labeling task is
        /// configured by feature in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the dataset to request labeling task, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="basicConfig">
        /// Required. Basic human annotation config.
        /// </param>
        /// <param name="feature">
        /// Required. The type of video labeling task.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AnnotatedDataset, LabelOperationMetadata>> LabelVideoAsync(DatasetName parent, HumanAnnotationConfig basicConfig, LabelVideoRequest.Types.Feature feature, gaxgrpc::CallSettings callSettings = null) =>
            LabelVideoAsync(new LabelVideoRequest
            {
                ParentAsDatasetName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BasicConfig = gax::GaxPreconditions.CheckNotNull(basicConfig, nameof(basicConfig)),
                Feature = feature,
            }, callSettings);

        /// <summary>
        /// Starts a labeling task for video. The type of video labeling task is
        /// configured by feature in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the dataset to request labeling task, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="basicConfig">
        /// Required. Basic human annotation config.
        /// </param>
        /// <param name="feature">
        /// Required. The type of video labeling task.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AnnotatedDataset, LabelOperationMetadata>> LabelVideoAsync(DatasetName parent, HumanAnnotationConfig basicConfig, LabelVideoRequest.Types.Feature feature, st::CancellationToken cancellationToken) =>
            LabelVideoAsync(parent, basicConfig, feature, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts a labeling task for text. The type of text labeling task is
        /// configured by feature in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AnnotatedDataset, LabelOperationMetadata> LabelText(LabelTextRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts a labeling task for text. The type of text labeling task is
        /// configured by feature in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AnnotatedDataset, LabelOperationMetadata>> LabelTextAsync(LabelTextRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts a labeling task for text. The type of text labeling task is
        /// configured by feature in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AnnotatedDataset, LabelOperationMetadata>> LabelTextAsync(LabelTextRequest request, st::CancellationToken cancellationToken) =>
            LabelTextAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>LabelText</c>.</summary>
        public virtual lro::OperationsClient LabelTextOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>LabelText</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AnnotatedDataset, LabelOperationMetadata> PollOnceLabelText(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AnnotatedDataset, LabelOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), LabelTextOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>LabelText</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AnnotatedDataset, LabelOperationMetadata>> PollOnceLabelTextAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AnnotatedDataset, LabelOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), LabelTextOperationsClient, callSettings);

        /// <summary>
        /// Starts a labeling task for text. The type of text labeling task is
        /// configured by feature in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the data set to request labeling task, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="basicConfig">
        /// Required. Basic human annotation config.
        /// </param>
        /// <param name="feature">
        /// Required. The type of text labeling task.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AnnotatedDataset, LabelOperationMetadata> LabelText(string parent, HumanAnnotationConfig basicConfig, LabelTextRequest.Types.Feature feature, gaxgrpc::CallSettings callSettings = null) =>
            LabelText(new LabelTextRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BasicConfig = gax::GaxPreconditions.CheckNotNull(basicConfig, nameof(basicConfig)),
                Feature = feature,
            }, callSettings);

        /// <summary>
        /// Starts a labeling task for text. The type of text labeling task is
        /// configured by feature in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the data set to request labeling task, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="basicConfig">
        /// Required. Basic human annotation config.
        /// </param>
        /// <param name="feature">
        /// Required. The type of text labeling task.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AnnotatedDataset, LabelOperationMetadata>> LabelTextAsync(string parent, HumanAnnotationConfig basicConfig, LabelTextRequest.Types.Feature feature, gaxgrpc::CallSettings callSettings = null) =>
            LabelTextAsync(new LabelTextRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BasicConfig = gax::GaxPreconditions.CheckNotNull(basicConfig, nameof(basicConfig)),
                Feature = feature,
            }, callSettings);

        /// <summary>
        /// Starts a labeling task for text. The type of text labeling task is
        /// configured by feature in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the data set to request labeling task, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="basicConfig">
        /// Required. Basic human annotation config.
        /// </param>
        /// <param name="feature">
        /// Required. The type of text labeling task.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AnnotatedDataset, LabelOperationMetadata>> LabelTextAsync(string parent, HumanAnnotationConfig basicConfig, LabelTextRequest.Types.Feature feature, st::CancellationToken cancellationToken) =>
            LabelTextAsync(parent, basicConfig, feature, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts a labeling task for text. The type of text labeling task is
        /// configured by feature in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the data set to request labeling task, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="basicConfig">
        /// Required. Basic human annotation config.
        /// </param>
        /// <param name="feature">
        /// Required. The type of text labeling task.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AnnotatedDataset, LabelOperationMetadata> LabelText(DatasetName parent, HumanAnnotationConfig basicConfig, LabelTextRequest.Types.Feature feature, gaxgrpc::CallSettings callSettings = null) =>
            LabelText(new LabelTextRequest
            {
                ParentAsDatasetName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BasicConfig = gax::GaxPreconditions.CheckNotNull(basicConfig, nameof(basicConfig)),
                Feature = feature,
            }, callSettings);

        /// <summary>
        /// Starts a labeling task for text. The type of text labeling task is
        /// configured by feature in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the data set to request labeling task, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="basicConfig">
        /// Required. Basic human annotation config.
        /// </param>
        /// <param name="feature">
        /// Required. The type of text labeling task.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AnnotatedDataset, LabelOperationMetadata>> LabelTextAsync(DatasetName parent, HumanAnnotationConfig basicConfig, LabelTextRequest.Types.Feature feature, gaxgrpc::CallSettings callSettings = null) =>
            LabelTextAsync(new LabelTextRequest
            {
                ParentAsDatasetName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BasicConfig = gax::GaxPreconditions.CheckNotNull(basicConfig, nameof(basicConfig)),
                Feature = feature,
            }, callSettings);

        /// <summary>
        /// Starts a labeling task for text. The type of text labeling task is
        /// configured by feature in the request.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the data set to request labeling task, format:
        /// projects/{project_id}/datasets/{dataset_id}
        /// </param>
        /// <param name="basicConfig">
        /// Required. Basic human annotation config.
        /// </param>
        /// <param name="feature">
        /// Required. The type of text labeling task.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AnnotatedDataset, LabelOperationMetadata>> LabelTextAsync(DatasetName parent, HumanAnnotationConfig basicConfig, LabelTextRequest.Types.Feature feature, st::CancellationToken cancellationToken) =>
            LabelTextAsync(parent, basicConfig, feature, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an example by resource name, including both data and annotation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Example GetExample(GetExampleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an example by resource name, including both data and annotation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> GetExampleAsync(GetExampleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an example by resource name, including both data and annotation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> GetExampleAsync(GetExampleRequest request, st::CancellationToken cancellationToken) =>
            GetExampleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an example by resource name, including both data and annotation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of example, format:
        /// projects/{project_id}/datasets/{dataset_id}/annotatedDatasets/
        /// {annotated_dataset_id}/examples/{example_id}
        /// </param>
        /// <param name="filter">
        /// Optional. An expression for filtering Examples. Filter by
        /// annotation_spec.display_name is supported. Format
        /// "annotation_spec.display_name = {display_name}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Example GetExample(string name, string filter, gaxgrpc::CallSettings callSettings = null) =>
            GetExample(new GetExampleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Filter = filter ?? "",
            }, callSettings);

        /// <summary>
        /// Gets an example by resource name, including both data and annotation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of example, format:
        /// projects/{project_id}/datasets/{dataset_id}/annotatedDatasets/
        /// {annotated_dataset_id}/examples/{example_id}
        /// </param>
        /// <param name="filter">
        /// Optional. An expression for filtering Examples. Filter by
        /// annotation_spec.display_name is supported. Format
        /// "annotation_spec.display_name = {display_name}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> GetExampleAsync(string name, string filter, gaxgrpc::CallSettings callSettings = null) =>
            GetExampleAsync(new GetExampleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Filter = filter ?? "",
            }, callSettings);

        /// <summary>
        /// Gets an example by resource name, including both data and annotation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of example, format:
        /// projects/{project_id}/datasets/{dataset_id}/annotatedDatasets/
        /// {annotated_dataset_id}/examples/{example_id}
        /// </param>
        /// <param name="filter">
        /// Optional. An expression for filtering Examples. Filter by
        /// annotation_spec.display_name is supported. Format
        /// "annotation_spec.display_name = {display_name}"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> GetExampleAsync(string name, string filter, st::CancellationToken cancellationToken) =>
            GetExampleAsync(name, filter, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an example by resource name, including both data and annotation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of example, format:
        /// projects/{project_id}/datasets/{dataset_id}/annotatedDatasets/
        /// {annotated_dataset_id}/examples/{example_id}
        /// </param>
        /// <param name="filter">
        /// Optional. An expression for filtering Examples. Filter by
        /// annotation_spec.display_name is supported. Format
        /// "annotation_spec.display_name = {display_name}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Example GetExample(ExampleName name, string filter, gaxgrpc::CallSettings callSettings = null) =>
            GetExample(new GetExampleRequest
            {
                ExampleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Filter = filter ?? "",
            }, callSettings);

        /// <summary>
        /// Gets an example by resource name, including both data and annotation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of example, format:
        /// projects/{project_id}/datasets/{dataset_id}/annotatedDatasets/
        /// {annotated_dataset_id}/examples/{example_id}
        /// </param>
        /// <param name="filter">
        /// Optional. An expression for filtering Examples. Filter by
        /// annotation_spec.display_name is supported. Format
        /// "annotation_spec.display_name = {display_name}"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> GetExampleAsync(ExampleName name, string filter, gaxgrpc::CallSettings callSettings = null) =>
            GetExampleAsync(new GetExampleRequest
            {
                ExampleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Filter = filter ?? "",
            }, callSettings);

        /// <summary>
        /// Gets an example by resource name, including both data and annotation.
        /// </summary>
        /// <param name="name">
        /// Required. Name of example, format:
        /// projects/{project_id}/datasets/{dataset_id}/annotatedDatasets/
        /// {annotated_dataset_id}/examples/{example_id}
        /// </param>
        /// <param name="filter">
        /// Optional. An expression for filtering Examples. Filter by
        /// annotation_spec.display_name is supported. Format
        /// "annotation_spec.display_name = {display_name}"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Example> GetExampleAsync(ExampleName name, string filter, st::CancellationToken cancellationToken) =>
            GetExampleAsync(name, filter, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists examples in an annotated dataset. Pagination is supported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Example"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExamplesResponse, Example> ListExamples(ListExamplesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists examples in an annotated dataset. Pagination is supported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Example"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExamplesResponse, Example> ListExamplesAsync(ListExamplesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists examples in an annotated dataset. Pagination is supported.
        /// </summary>
        /// <param name="parent">
        /// Required. Example resource parent.
        /// </param>
        /// <param name="filter">
        /// Optional. An expression for filtering Examples. For annotated datasets that
        /// have annotation spec set, filter by
        /// annotation_spec.display_name is supported. Format
        /// "annotation_spec.display_name = {display_name}"
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
        /// <returns>A pageable sequence of <see cref="Example"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExamplesResponse, Example> ListExamples(string parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListExamples(new ListExamplesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = filter ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists examples in an annotated dataset. Pagination is supported.
        /// </summary>
        /// <param name="parent">
        /// Required. Example resource parent.
        /// </param>
        /// <param name="filter">
        /// Optional. An expression for filtering Examples. For annotated datasets that
        /// have annotation spec set, filter by
        /// annotation_spec.display_name is supported. Format
        /// "annotation_spec.display_name = {display_name}"
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
        /// <returns>A pageable asynchronous sequence of <see cref="Example"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExamplesResponse, Example> ListExamplesAsync(string parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListExamplesAsync(new ListExamplesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = filter ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists examples in an annotated dataset. Pagination is supported.
        /// </summary>
        /// <param name="parent">
        /// Required. Example resource parent.
        /// </param>
        /// <param name="filter">
        /// Optional. An expression for filtering Examples. For annotated datasets that
        /// have annotation spec set, filter by
        /// annotation_spec.display_name is supported. Format
        /// "annotation_spec.display_name = {display_name}"
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
        /// <returns>A pageable sequence of <see cref="Example"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExamplesResponse, Example> ListExamples(AnnotatedDatasetName parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListExamples(new ListExamplesRequest
            {
                ParentAsAnnotatedDatasetName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = filter ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists examples in an annotated dataset. Pagination is supported.
        /// </summary>
        /// <param name="parent">
        /// Required. Example resource parent.
        /// </param>
        /// <param name="filter">
        /// Optional. An expression for filtering Examples. For annotated datasets that
        /// have annotation spec set, filter by
        /// annotation_spec.display_name is supported. Format
        /// "annotation_spec.display_name = {display_name}"
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
        /// <returns>A pageable asynchronous sequence of <see cref="Example"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExamplesResponse, Example> ListExamplesAsync(AnnotatedDatasetName parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListExamplesAsync(new ListExamplesRequest
            {
                ParentAsAnnotatedDatasetName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = filter ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Creates an annotation spec set by providing a set of labels.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnnotationSpecSet CreateAnnotationSpecSet(CreateAnnotationSpecSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an annotation spec set by providing a set of labels.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotationSpecSet> CreateAnnotationSpecSetAsync(CreateAnnotationSpecSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an annotation spec set by providing a set of labels.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotationSpecSet> CreateAnnotationSpecSetAsync(CreateAnnotationSpecSetRequest request, st::CancellationToken cancellationToken) =>
            CreateAnnotationSpecSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an annotation spec set by providing a set of labels.
        /// </summary>
        /// <param name="parent">
        /// Required. AnnotationSpecSet resource parent, format:
        /// projects/{project_id}
        /// </param>
        /// <param name="annotationSpecSet">
        /// Required. Annotation spec set to create. Annotation specs must be included.
        /// Only one annotation spec will be accepted for annotation specs with same
        /// display_name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnnotationSpecSet CreateAnnotationSpecSet(string parent, AnnotationSpecSet annotationSpecSet, gaxgrpc::CallSettings callSettings = null) =>
            CreateAnnotationSpecSet(new CreateAnnotationSpecSetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AnnotationSpecSet = gax::GaxPreconditions.CheckNotNull(annotationSpecSet, nameof(annotationSpecSet)),
            }, callSettings);

        /// <summary>
        /// Creates an annotation spec set by providing a set of labels.
        /// </summary>
        /// <param name="parent">
        /// Required. AnnotationSpecSet resource parent, format:
        /// projects/{project_id}
        /// </param>
        /// <param name="annotationSpecSet">
        /// Required. Annotation spec set to create. Annotation specs must be included.
        /// Only one annotation spec will be accepted for annotation specs with same
        /// display_name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotationSpecSet> CreateAnnotationSpecSetAsync(string parent, AnnotationSpecSet annotationSpecSet, gaxgrpc::CallSettings callSettings = null) =>
            CreateAnnotationSpecSetAsync(new CreateAnnotationSpecSetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AnnotationSpecSet = gax::GaxPreconditions.CheckNotNull(annotationSpecSet, nameof(annotationSpecSet)),
            }, callSettings);

        /// <summary>
        /// Creates an annotation spec set by providing a set of labels.
        /// </summary>
        /// <param name="parent">
        /// Required. AnnotationSpecSet resource parent, format:
        /// projects/{project_id}
        /// </param>
        /// <param name="annotationSpecSet">
        /// Required. Annotation spec set to create. Annotation specs must be included.
        /// Only one annotation spec will be accepted for annotation specs with same
        /// display_name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotationSpecSet> CreateAnnotationSpecSetAsync(string parent, AnnotationSpecSet annotationSpecSet, st::CancellationToken cancellationToken) =>
            CreateAnnotationSpecSetAsync(parent, annotationSpecSet, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an annotation spec set by providing a set of labels.
        /// </summary>
        /// <param name="parent">
        /// Required. AnnotationSpecSet resource parent, format:
        /// projects/{project_id}
        /// </param>
        /// <param name="annotationSpecSet">
        /// Required. Annotation spec set to create. Annotation specs must be included.
        /// Only one annotation spec will be accepted for annotation specs with same
        /// display_name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnnotationSpecSet CreateAnnotationSpecSet(gagr::ProjectName parent, AnnotationSpecSet annotationSpecSet, gaxgrpc::CallSettings callSettings = null) =>
            CreateAnnotationSpecSet(new CreateAnnotationSpecSetRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AnnotationSpecSet = gax::GaxPreconditions.CheckNotNull(annotationSpecSet, nameof(annotationSpecSet)),
            }, callSettings);

        /// <summary>
        /// Creates an annotation spec set by providing a set of labels.
        /// </summary>
        /// <param name="parent">
        /// Required. AnnotationSpecSet resource parent, format:
        /// projects/{project_id}
        /// </param>
        /// <param name="annotationSpecSet">
        /// Required. Annotation spec set to create. Annotation specs must be included.
        /// Only one annotation spec will be accepted for annotation specs with same
        /// display_name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotationSpecSet> CreateAnnotationSpecSetAsync(gagr::ProjectName parent, AnnotationSpecSet annotationSpecSet, gaxgrpc::CallSettings callSettings = null) =>
            CreateAnnotationSpecSetAsync(new CreateAnnotationSpecSetRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AnnotationSpecSet = gax::GaxPreconditions.CheckNotNull(annotationSpecSet, nameof(annotationSpecSet)),
            }, callSettings);

        /// <summary>
        /// Creates an annotation spec set by providing a set of labels.
        /// </summary>
        /// <param name="parent">
        /// Required. AnnotationSpecSet resource parent, format:
        /// projects/{project_id}
        /// </param>
        /// <param name="annotationSpecSet">
        /// Required. Annotation spec set to create. Annotation specs must be included.
        /// Only one annotation spec will be accepted for annotation specs with same
        /// display_name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotationSpecSet> CreateAnnotationSpecSetAsync(gagr::ProjectName parent, AnnotationSpecSet annotationSpecSet, st::CancellationToken cancellationToken) =>
            CreateAnnotationSpecSetAsync(parent, annotationSpecSet, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an annotation spec set by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnnotationSpecSet GetAnnotationSpecSet(GetAnnotationSpecSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an annotation spec set by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotationSpecSet> GetAnnotationSpecSetAsync(GetAnnotationSpecSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an annotation spec set by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotationSpecSet> GetAnnotationSpecSetAsync(GetAnnotationSpecSetRequest request, st::CancellationToken cancellationToken) =>
            GetAnnotationSpecSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an annotation spec set by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. AnnotationSpecSet resource name, format:
        /// projects/{project_id}/annotationSpecSets/{annotation_spec_set_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnnotationSpecSet GetAnnotationSpecSet(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnnotationSpecSet(new GetAnnotationSpecSetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an annotation spec set by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. AnnotationSpecSet resource name, format:
        /// projects/{project_id}/annotationSpecSets/{annotation_spec_set_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotationSpecSet> GetAnnotationSpecSetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnnotationSpecSetAsync(new GetAnnotationSpecSetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an annotation spec set by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. AnnotationSpecSet resource name, format:
        /// projects/{project_id}/annotationSpecSets/{annotation_spec_set_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotationSpecSet> GetAnnotationSpecSetAsync(string name, st::CancellationToken cancellationToken) =>
            GetAnnotationSpecSetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an annotation spec set by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. AnnotationSpecSet resource name, format:
        /// projects/{project_id}/annotationSpecSets/{annotation_spec_set_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AnnotationSpecSet GetAnnotationSpecSet(AnnotationSpecSetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnnotationSpecSet(new GetAnnotationSpecSetRequest
            {
                AnnotationSpecSetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an annotation spec set by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. AnnotationSpecSet resource name, format:
        /// projects/{project_id}/annotationSpecSets/{annotation_spec_set_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotationSpecSet> GetAnnotationSpecSetAsync(AnnotationSpecSetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAnnotationSpecSetAsync(new GetAnnotationSpecSetRequest
            {
                AnnotationSpecSetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an annotation spec set by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. AnnotationSpecSet resource name, format:
        /// projects/{project_id}/annotationSpecSets/{annotation_spec_set_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AnnotationSpecSet> GetAnnotationSpecSetAsync(AnnotationSpecSetName name, st::CancellationToken cancellationToken) =>
            GetAnnotationSpecSetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists annotation spec sets for a project. Pagination is supported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AnnotationSpecSet"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAnnotationSpecSetsResponse, AnnotationSpecSet> ListAnnotationSpecSets(ListAnnotationSpecSetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists annotation spec sets for a project. Pagination is supported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AnnotationSpecSet"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAnnotationSpecSetsResponse, AnnotationSpecSet> ListAnnotationSpecSetsAsync(ListAnnotationSpecSetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists annotation spec sets for a project. Pagination is supported.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent of AnnotationSpecSet resource, format:
        /// projects/{project_id}
        /// </param>
        /// <param name="filter">
        /// Optional. Filter is not supported at this moment.
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
        /// <returns>A pageable sequence of <see cref="AnnotationSpecSet"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAnnotationSpecSetsResponse, AnnotationSpecSet> ListAnnotationSpecSets(string parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAnnotationSpecSets(new ListAnnotationSpecSetsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = filter ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists annotation spec sets for a project. Pagination is supported.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent of AnnotationSpecSet resource, format:
        /// projects/{project_id}
        /// </param>
        /// <param name="filter">
        /// Optional. Filter is not supported at this moment.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AnnotationSpecSet"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAnnotationSpecSetsResponse, AnnotationSpecSet> ListAnnotationSpecSetsAsync(string parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAnnotationSpecSetsAsync(new ListAnnotationSpecSetsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = filter ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists annotation spec sets for a project. Pagination is supported.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent of AnnotationSpecSet resource, format:
        /// projects/{project_id}
        /// </param>
        /// <param name="filter">
        /// Optional. Filter is not supported at this moment.
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
        /// <returns>A pageable sequence of <see cref="AnnotationSpecSet"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAnnotationSpecSetsResponse, AnnotationSpecSet> ListAnnotationSpecSets(gagr::ProjectName parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAnnotationSpecSets(new ListAnnotationSpecSetsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = filter ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists annotation spec sets for a project. Pagination is supported.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent of AnnotationSpecSet resource, format:
        /// projects/{project_id}
        /// </param>
        /// <param name="filter">
        /// Optional. Filter is not supported at this moment.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AnnotationSpecSet"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAnnotationSpecSetsResponse, AnnotationSpecSet> ListAnnotationSpecSetsAsync(gagr::ProjectName parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListAnnotationSpecSetsAsync(new ListAnnotationSpecSetsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = filter ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Deletes an annotation spec set by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAnnotationSpecSet(DeleteAnnotationSpecSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an annotation spec set by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnnotationSpecSetAsync(DeleteAnnotationSpecSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an annotation spec set by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnnotationSpecSetAsync(DeleteAnnotationSpecSetRequest request, st::CancellationToken cancellationToken) =>
            DeleteAnnotationSpecSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an annotation spec set by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. AnnotationSpec resource name, format:
        /// `projects/{project_id}/annotationSpecSets/{annotation_spec_set_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAnnotationSpecSet(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAnnotationSpecSet(new DeleteAnnotationSpecSetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an annotation spec set by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. AnnotationSpec resource name, format:
        /// `projects/{project_id}/annotationSpecSets/{annotation_spec_set_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnnotationSpecSetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAnnotationSpecSetAsync(new DeleteAnnotationSpecSetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an annotation spec set by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. AnnotationSpec resource name, format:
        /// `projects/{project_id}/annotationSpecSets/{annotation_spec_set_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnnotationSpecSetAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAnnotationSpecSetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an annotation spec set by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. AnnotationSpec resource name, format:
        /// `projects/{project_id}/annotationSpecSets/{annotation_spec_set_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteAnnotationSpecSet(AnnotationSpecSetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAnnotationSpecSet(new DeleteAnnotationSpecSetRequest
            {
                AnnotationSpecSetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an annotation spec set by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. AnnotationSpec resource name, format:
        /// `projects/{project_id}/annotationSpecSets/{annotation_spec_set_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnnotationSpecSetAsync(AnnotationSpecSetName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAnnotationSpecSetAsync(new DeleteAnnotationSpecSetRequest
            {
                AnnotationSpecSetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an annotation spec set by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. AnnotationSpec resource name, format:
        /// `projects/{project_id}/annotationSpecSets/{annotation_spec_set_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteAnnotationSpecSetAsync(AnnotationSpecSetName name, st::CancellationToken cancellationToken) =>
            DeleteAnnotationSpecSetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an instruction for how data should be labeled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instruction, CreateInstructionMetadata> CreateInstruction(CreateInstructionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an instruction for how data should be labeled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instruction, CreateInstructionMetadata>> CreateInstructionAsync(CreateInstructionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an instruction for how data should be labeled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instruction, CreateInstructionMetadata>> CreateInstructionAsync(CreateInstructionRequest request, st::CancellationToken cancellationToken) =>
            CreateInstructionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateInstruction</c>.</summary>
        public virtual lro::OperationsClient CreateInstructionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateInstruction</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Instruction, CreateInstructionMetadata> PollOnceCreateInstruction(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instruction, CreateInstructionMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateInstructionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateInstruction</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Instruction, CreateInstructionMetadata>> PollOnceCreateInstructionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Instruction, CreateInstructionMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateInstructionOperationsClient, callSettings);

        /// <summary>
        /// Creates an instruction for how data should be labeled.
        /// </summary>
        /// <param name="parent">
        /// Required. Instruction resource parent, format:
        /// projects/{project_id}
        /// </param>
        /// <param name="instruction">
        /// Required. Instruction of how to perform the labeling task.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instruction, CreateInstructionMetadata> CreateInstruction(string parent, Instruction instruction, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstruction(new CreateInstructionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Instruction = gax::GaxPreconditions.CheckNotNull(instruction, nameof(instruction)),
            }, callSettings);

        /// <summary>
        /// Creates an instruction for how data should be labeled.
        /// </summary>
        /// <param name="parent">
        /// Required. Instruction resource parent, format:
        /// projects/{project_id}
        /// </param>
        /// <param name="instruction">
        /// Required. Instruction of how to perform the labeling task.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instruction, CreateInstructionMetadata>> CreateInstructionAsync(string parent, Instruction instruction, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstructionAsync(new CreateInstructionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Instruction = gax::GaxPreconditions.CheckNotNull(instruction, nameof(instruction)),
            }, callSettings);

        /// <summary>
        /// Creates an instruction for how data should be labeled.
        /// </summary>
        /// <param name="parent">
        /// Required. Instruction resource parent, format:
        /// projects/{project_id}
        /// </param>
        /// <param name="instruction">
        /// Required. Instruction of how to perform the labeling task.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instruction, CreateInstructionMetadata>> CreateInstructionAsync(string parent, Instruction instruction, st::CancellationToken cancellationToken) =>
            CreateInstructionAsync(parent, instruction, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an instruction for how data should be labeled.
        /// </summary>
        /// <param name="parent">
        /// Required. Instruction resource parent, format:
        /// projects/{project_id}
        /// </param>
        /// <param name="instruction">
        /// Required. Instruction of how to perform the labeling task.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Instruction, CreateInstructionMetadata> CreateInstruction(gagr::ProjectName parent, Instruction instruction, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstruction(new CreateInstructionRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Instruction = gax::GaxPreconditions.CheckNotNull(instruction, nameof(instruction)),
            }, callSettings);

        /// <summary>
        /// Creates an instruction for how data should be labeled.
        /// </summary>
        /// <param name="parent">
        /// Required. Instruction resource parent, format:
        /// projects/{project_id}
        /// </param>
        /// <param name="instruction">
        /// Required. Instruction of how to perform the labeling task.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instruction, CreateInstructionMetadata>> CreateInstructionAsync(gagr::ProjectName parent, Instruction instruction, gaxgrpc::CallSettings callSettings = null) =>
            CreateInstructionAsync(new CreateInstructionRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Instruction = gax::GaxPreconditions.CheckNotNull(instruction, nameof(instruction)),
            }, callSettings);

        /// <summary>
        /// Creates an instruction for how data should be labeled.
        /// </summary>
        /// <param name="parent">
        /// Required. Instruction resource parent, format:
        /// projects/{project_id}
        /// </param>
        /// <param name="instruction">
        /// Required. Instruction of how to perform the labeling task.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Instruction, CreateInstructionMetadata>> CreateInstructionAsync(gagr::ProjectName parent, Instruction instruction, st::CancellationToken cancellationToken) =>
            CreateInstructionAsync(parent, instruction, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an instruction by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instruction GetInstruction(GetInstructionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an instruction by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instruction> GetInstructionAsync(GetInstructionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an instruction by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instruction> GetInstructionAsync(GetInstructionRequest request, st::CancellationToken cancellationToken) =>
            GetInstructionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an instruction by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Instruction resource name, format:
        /// projects/{project_id}/instructions/{instruction_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instruction GetInstruction(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstruction(new GetInstructionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an instruction by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Instruction resource name, format:
        /// projects/{project_id}/instructions/{instruction_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instruction> GetInstructionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstructionAsync(new GetInstructionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an instruction by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Instruction resource name, format:
        /// projects/{project_id}/instructions/{instruction_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instruction> GetInstructionAsync(string name, st::CancellationToken cancellationToken) =>
            GetInstructionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an instruction by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Instruction resource name, format:
        /// projects/{project_id}/instructions/{instruction_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Instruction GetInstruction(InstructionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstruction(new GetInstructionRequest
            {
                InstructionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an instruction by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Instruction resource name, format:
        /// projects/{project_id}/instructions/{instruction_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instruction> GetInstructionAsync(InstructionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInstructionAsync(new GetInstructionRequest
            {
                InstructionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an instruction by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Instruction resource name, format:
        /// projects/{project_id}/instructions/{instruction_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Instruction> GetInstructionAsync(InstructionName name, st::CancellationToken cancellationToken) =>
            GetInstructionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists instructions for a project. Pagination is supported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Instruction"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstructionsResponse, Instruction> ListInstructions(ListInstructionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists instructions for a project. Pagination is supported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Instruction"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstructionsResponse, Instruction> ListInstructionsAsync(ListInstructionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists instructions for a project. Pagination is supported.
        /// </summary>
        /// <param name="parent">
        /// Required. Instruction resource parent, format:
        /// projects/{project_id}
        /// </param>
        /// <param name="filter">
        /// Optional. Filter is not supported at this moment.
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
        /// <returns>A pageable sequence of <see cref="Instruction"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstructionsResponse, Instruction> ListInstructions(string parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListInstructions(new ListInstructionsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = filter ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists instructions for a project. Pagination is supported.
        /// </summary>
        /// <param name="parent">
        /// Required. Instruction resource parent, format:
        /// projects/{project_id}
        /// </param>
        /// <param name="filter">
        /// Optional. Filter is not supported at this moment.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Instruction"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstructionsResponse, Instruction> ListInstructionsAsync(string parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListInstructionsAsync(new ListInstructionsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = filter ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists instructions for a project. Pagination is supported.
        /// </summary>
        /// <param name="parent">
        /// Required. Instruction resource parent, format:
        /// projects/{project_id}
        /// </param>
        /// <param name="filter">
        /// Optional. Filter is not supported at this moment.
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
        /// <returns>A pageable sequence of <see cref="Instruction"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInstructionsResponse, Instruction> ListInstructions(gagr::ProjectName parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListInstructions(new ListInstructionsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = filter ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists instructions for a project. Pagination is supported.
        /// </summary>
        /// <param name="parent">
        /// Required. Instruction resource parent, format:
        /// projects/{project_id}
        /// </param>
        /// <param name="filter">
        /// Optional. Filter is not supported at this moment.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Instruction"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInstructionsResponse, Instruction> ListInstructionsAsync(gagr::ProjectName parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListInstructionsAsync(new ListInstructionsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = filter ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Deletes an instruction object by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteInstruction(DeleteInstructionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an instruction object by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteInstructionAsync(DeleteInstructionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an instruction object by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteInstructionAsync(DeleteInstructionRequest request, st::CancellationToken cancellationToken) =>
            DeleteInstructionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an instruction object by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Instruction resource name, format:
        /// projects/{project_id}/instructions/{instruction_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteInstruction(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstruction(new DeleteInstructionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an instruction object by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Instruction resource name, format:
        /// projects/{project_id}/instructions/{instruction_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteInstructionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstructionAsync(new DeleteInstructionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an instruction object by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Instruction resource name, format:
        /// projects/{project_id}/instructions/{instruction_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteInstructionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteInstructionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an instruction object by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Instruction resource name, format:
        /// projects/{project_id}/instructions/{instruction_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteInstruction(InstructionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstruction(new DeleteInstructionRequest
            {
                InstructionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an instruction object by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Instruction resource name, format:
        /// projects/{project_id}/instructions/{instruction_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteInstructionAsync(InstructionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInstructionAsync(new DeleteInstructionRequest
            {
                InstructionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an instruction object by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Instruction resource name, format:
        /// projects/{project_id}/instructions/{instruction_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteInstructionAsync(InstructionName name, st::CancellationToken cancellationToken) =>
            DeleteInstructionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an evaluation by resource name (to search, use
        /// [projects.evaluations.search][google.cloud.datalabeling.v1beta1.DataLabelingService.SearchEvaluations]).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Evaluation GetEvaluation(GetEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an evaluation by resource name (to search, use
        /// [projects.evaluations.search][google.cloud.datalabeling.v1beta1.DataLabelingService.SearchEvaluations]).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> GetEvaluationAsync(GetEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an evaluation by resource name (to search, use
        /// [projects.evaluations.search][google.cloud.datalabeling.v1beta1.DataLabelingService.SearchEvaluations]).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> GetEvaluationAsync(GetEvaluationRequest request, st::CancellationToken cancellationToken) =>
            GetEvaluationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an evaluation by resource name (to search, use
        /// [projects.evaluations.search][google.cloud.datalabeling.v1beta1.DataLabelingService.SearchEvaluations]).
        /// </summary>
        /// <param name="name">
        /// Required. Name of the evaluation. Format:
        /// 
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;/datasets/&amp;lt;var&amp;gt;{dataset_id}&amp;lt;/var&amp;gt;/evaluations/&amp;lt;var&amp;gt;{evaluation_id}&amp;lt;/var&amp;gt;'
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Evaluation GetEvaluation(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvaluation(new GetEvaluationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an evaluation by resource name (to search, use
        /// [projects.evaluations.search][google.cloud.datalabeling.v1beta1.DataLabelingService.SearchEvaluations]).
        /// </summary>
        /// <param name="name">
        /// Required. Name of the evaluation. Format:
        /// 
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;/datasets/&amp;lt;var&amp;gt;{dataset_id}&amp;lt;/var&amp;gt;/evaluations/&amp;lt;var&amp;gt;{evaluation_id}&amp;lt;/var&amp;gt;'
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> GetEvaluationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvaluationAsync(new GetEvaluationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an evaluation by resource name (to search, use
        /// [projects.evaluations.search][google.cloud.datalabeling.v1beta1.DataLabelingService.SearchEvaluations]).
        /// </summary>
        /// <param name="name">
        /// Required. Name of the evaluation. Format:
        /// 
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;/datasets/&amp;lt;var&amp;gt;{dataset_id}&amp;lt;/var&amp;gt;/evaluations/&amp;lt;var&amp;gt;{evaluation_id}&amp;lt;/var&amp;gt;'
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> GetEvaluationAsync(string name, st::CancellationToken cancellationToken) =>
            GetEvaluationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an evaluation by resource name (to search, use
        /// [projects.evaluations.search][google.cloud.datalabeling.v1beta1.DataLabelingService.SearchEvaluations]).
        /// </summary>
        /// <param name="name">
        /// Required. Name of the evaluation. Format:
        /// 
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;/datasets/&amp;lt;var&amp;gt;{dataset_id}&amp;lt;/var&amp;gt;/evaluations/&amp;lt;var&amp;gt;{evaluation_id}&amp;lt;/var&amp;gt;'
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Evaluation GetEvaluation(EvaluationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvaluation(new GetEvaluationRequest
            {
                EvaluationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an evaluation by resource name (to search, use
        /// [projects.evaluations.search][google.cloud.datalabeling.v1beta1.DataLabelingService.SearchEvaluations]).
        /// </summary>
        /// <param name="name">
        /// Required. Name of the evaluation. Format:
        /// 
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;/datasets/&amp;lt;var&amp;gt;{dataset_id}&amp;lt;/var&amp;gt;/evaluations/&amp;lt;var&amp;gt;{evaluation_id}&amp;lt;/var&amp;gt;'
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> GetEvaluationAsync(EvaluationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvaluationAsync(new GetEvaluationRequest
            {
                EvaluationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an evaluation by resource name (to search, use
        /// [projects.evaluations.search][google.cloud.datalabeling.v1beta1.DataLabelingService.SearchEvaluations]).
        /// </summary>
        /// <param name="name">
        /// Required. Name of the evaluation. Format:
        /// 
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;/datasets/&amp;lt;var&amp;gt;{dataset_id}&amp;lt;/var&amp;gt;/evaluations/&amp;lt;var&amp;gt;{evaluation_id}&amp;lt;/var&amp;gt;'
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> GetEvaluationAsync(EvaluationName name, st::CancellationToken cancellationToken) =>
            GetEvaluationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Searches [evaluations][google.cloud.datalabeling.v1beta1.Evaluation] within a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Evaluation"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchEvaluationsResponse, Evaluation> SearchEvaluations(SearchEvaluationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches [evaluations][google.cloud.datalabeling.v1beta1.Evaluation] within a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Evaluation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchEvaluationsResponse, Evaluation> SearchEvaluationsAsync(SearchEvaluationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches [evaluations][google.cloud.datalabeling.v1beta1.Evaluation] within a project.
        /// </summary>
        /// <param name="parent">
        /// Required. Evaluation search parent (project ID). Format:
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;"
        /// </param>
        /// <param name="filter">
        /// Optional. To search evaluations, you can filter by the following:
        /// 
        /// * evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.evaluation_job_id (the last part of
        /// [EvaluationJob.name][google.cloud.datalabeling.v1beta1.EvaluationJob.name])
        /// * evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.model_id (the &amp;lt;var&amp;gt;{model_name}&amp;lt;/var&amp;gt; portion
        /// of [EvaluationJob.modelVersion][google.cloud.datalabeling.v1beta1.EvaluationJob.model_version])
        /// * evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.evaluation_job_run_time_start (Minimum
        /// threshold for the
        /// [evaluationJobRunTime][google.cloud.datalabeling.v1beta1.Evaluation.evaluation_job_run_time] that created
        /// the evaluation)
        /// * evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.evaluation_job_run_time_end (Maximum
        /// threshold for the
        /// [evaluationJobRunTime][google.cloud.datalabeling.v1beta1.Evaluation.evaluation_job_run_time] that created
        /// the evaluation)
        /// * evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.job_state ([EvaluationJob.state][google.cloud.datalabeling.v1beta1.EvaluationJob.state])
        /// * annotation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;spec.display_name (the Evaluation contains a
        /// metric for the annotation spec with this
        /// [displayName][google.cloud.datalabeling.v1beta1.AnnotationSpec.display_name])
        /// 
        /// To filter by multiple critiera, use the `AND` operator or the `OR`
        /// operator. The following examples shows a string that filters by several
        /// critiera:
        /// 
        /// "evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.evaluation_job_id =
        /// &amp;lt;var&amp;gt;{evaluation_job_id}&amp;lt;/var&amp;gt; AND evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.model_id =
        /// &amp;lt;var&amp;gt;{model_name}&amp;lt;/var&amp;gt; AND
        /// evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.evaluation_job_run_time_start =
        /// &amp;lt;var&amp;gt;{timestamp_1}&amp;lt;/var&amp;gt; AND
        /// evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.evaluation_job_run_time_end =
        /// &amp;lt;var&amp;gt;{timestamp_2}&amp;lt;/var&amp;gt; AND annotation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;spec.display_name =
        /// &amp;lt;var&amp;gt;{display_name}&amp;lt;/var&amp;gt;"
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
        public virtual gax::PagedEnumerable<SearchEvaluationsResponse, Evaluation> SearchEvaluations(string parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            SearchEvaluations(new SearchEvaluationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = filter ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Searches [evaluations][google.cloud.datalabeling.v1beta1.Evaluation] within a project.
        /// </summary>
        /// <param name="parent">
        /// Required. Evaluation search parent (project ID). Format:
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;"
        /// </param>
        /// <param name="filter">
        /// Optional. To search evaluations, you can filter by the following:
        /// 
        /// * evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.evaluation_job_id (the last part of
        /// [EvaluationJob.name][google.cloud.datalabeling.v1beta1.EvaluationJob.name])
        /// * evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.model_id (the &amp;lt;var&amp;gt;{model_name}&amp;lt;/var&amp;gt; portion
        /// of [EvaluationJob.modelVersion][google.cloud.datalabeling.v1beta1.EvaluationJob.model_version])
        /// * evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.evaluation_job_run_time_start (Minimum
        /// threshold for the
        /// [evaluationJobRunTime][google.cloud.datalabeling.v1beta1.Evaluation.evaluation_job_run_time] that created
        /// the evaluation)
        /// * evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.evaluation_job_run_time_end (Maximum
        /// threshold for the
        /// [evaluationJobRunTime][google.cloud.datalabeling.v1beta1.Evaluation.evaluation_job_run_time] that created
        /// the evaluation)
        /// * evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.job_state ([EvaluationJob.state][google.cloud.datalabeling.v1beta1.EvaluationJob.state])
        /// * annotation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;spec.display_name (the Evaluation contains a
        /// metric for the annotation spec with this
        /// [displayName][google.cloud.datalabeling.v1beta1.AnnotationSpec.display_name])
        /// 
        /// To filter by multiple critiera, use the `AND` operator or the `OR`
        /// operator. The following examples shows a string that filters by several
        /// critiera:
        /// 
        /// "evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.evaluation_job_id =
        /// &amp;lt;var&amp;gt;{evaluation_job_id}&amp;lt;/var&amp;gt; AND evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.model_id =
        /// &amp;lt;var&amp;gt;{model_name}&amp;lt;/var&amp;gt; AND
        /// evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.evaluation_job_run_time_start =
        /// &amp;lt;var&amp;gt;{timestamp_1}&amp;lt;/var&amp;gt; AND
        /// evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.evaluation_job_run_time_end =
        /// &amp;lt;var&amp;gt;{timestamp_2}&amp;lt;/var&amp;gt; AND annotation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;spec.display_name =
        /// &amp;lt;var&amp;gt;{display_name}&amp;lt;/var&amp;gt;"
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
        public virtual gax::PagedAsyncEnumerable<SearchEvaluationsResponse, Evaluation> SearchEvaluationsAsync(string parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            SearchEvaluationsAsync(new SearchEvaluationsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = filter ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Searches [evaluations][google.cloud.datalabeling.v1beta1.Evaluation] within a project.
        /// </summary>
        /// <param name="parent">
        /// Required. Evaluation search parent (project ID). Format:
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;"
        /// </param>
        /// <param name="filter">
        /// Optional. To search evaluations, you can filter by the following:
        /// 
        /// * evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.evaluation_job_id (the last part of
        /// [EvaluationJob.name][google.cloud.datalabeling.v1beta1.EvaluationJob.name])
        /// * evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.model_id (the &amp;lt;var&amp;gt;{model_name}&amp;lt;/var&amp;gt; portion
        /// of [EvaluationJob.modelVersion][google.cloud.datalabeling.v1beta1.EvaluationJob.model_version])
        /// * evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.evaluation_job_run_time_start (Minimum
        /// threshold for the
        /// [evaluationJobRunTime][google.cloud.datalabeling.v1beta1.Evaluation.evaluation_job_run_time] that created
        /// the evaluation)
        /// * evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.evaluation_job_run_time_end (Maximum
        /// threshold for the
        /// [evaluationJobRunTime][google.cloud.datalabeling.v1beta1.Evaluation.evaluation_job_run_time] that created
        /// the evaluation)
        /// * evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.job_state ([EvaluationJob.state][google.cloud.datalabeling.v1beta1.EvaluationJob.state])
        /// * annotation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;spec.display_name (the Evaluation contains a
        /// metric for the annotation spec with this
        /// [displayName][google.cloud.datalabeling.v1beta1.AnnotationSpec.display_name])
        /// 
        /// To filter by multiple critiera, use the `AND` operator or the `OR`
        /// operator. The following examples shows a string that filters by several
        /// critiera:
        /// 
        /// "evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.evaluation_job_id =
        /// &amp;lt;var&amp;gt;{evaluation_job_id}&amp;lt;/var&amp;gt; AND evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.model_id =
        /// &amp;lt;var&amp;gt;{model_name}&amp;lt;/var&amp;gt; AND
        /// evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.evaluation_job_run_time_start =
        /// &amp;lt;var&amp;gt;{timestamp_1}&amp;lt;/var&amp;gt; AND
        /// evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.evaluation_job_run_time_end =
        /// &amp;lt;var&amp;gt;{timestamp_2}&amp;lt;/var&amp;gt; AND annotation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;spec.display_name =
        /// &amp;lt;var&amp;gt;{display_name}&amp;lt;/var&amp;gt;"
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
        public virtual gax::PagedEnumerable<SearchEvaluationsResponse, Evaluation> SearchEvaluations(EvaluationName parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            SearchEvaluations(new SearchEvaluationsRequest
            {
                ParentAsEvaluationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = filter ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Searches [evaluations][google.cloud.datalabeling.v1beta1.Evaluation] within a project.
        /// </summary>
        /// <param name="parent">
        /// Required. Evaluation search parent (project ID). Format:
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;"
        /// </param>
        /// <param name="filter">
        /// Optional. To search evaluations, you can filter by the following:
        /// 
        /// * evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.evaluation_job_id (the last part of
        /// [EvaluationJob.name][google.cloud.datalabeling.v1beta1.EvaluationJob.name])
        /// * evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.model_id (the &amp;lt;var&amp;gt;{model_name}&amp;lt;/var&amp;gt; portion
        /// of [EvaluationJob.modelVersion][google.cloud.datalabeling.v1beta1.EvaluationJob.model_version])
        /// * evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.evaluation_job_run_time_start (Minimum
        /// threshold for the
        /// [evaluationJobRunTime][google.cloud.datalabeling.v1beta1.Evaluation.evaluation_job_run_time] that created
        /// the evaluation)
        /// * evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.evaluation_job_run_time_end (Maximum
        /// threshold for the
        /// [evaluationJobRunTime][google.cloud.datalabeling.v1beta1.Evaluation.evaluation_job_run_time] that created
        /// the evaluation)
        /// * evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.job_state ([EvaluationJob.state][google.cloud.datalabeling.v1beta1.EvaluationJob.state])
        /// * annotation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;spec.display_name (the Evaluation contains a
        /// metric for the annotation spec with this
        /// [displayName][google.cloud.datalabeling.v1beta1.AnnotationSpec.display_name])
        /// 
        /// To filter by multiple critiera, use the `AND` operator or the `OR`
        /// operator. The following examples shows a string that filters by several
        /// critiera:
        /// 
        /// "evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.evaluation_job_id =
        /// &amp;lt;var&amp;gt;{evaluation_job_id}&amp;lt;/var&amp;gt; AND evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.model_id =
        /// &amp;lt;var&amp;gt;{model_name}&amp;lt;/var&amp;gt; AND
        /// evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.evaluation_job_run_time_start =
        /// &amp;lt;var&amp;gt;{timestamp_1}&amp;lt;/var&amp;gt; AND
        /// evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.evaluation_job_run_time_end =
        /// &amp;lt;var&amp;gt;{timestamp_2}&amp;lt;/var&amp;gt; AND annotation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;spec.display_name =
        /// &amp;lt;var&amp;gt;{display_name}&amp;lt;/var&amp;gt;"
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
        public virtual gax::PagedAsyncEnumerable<SearchEvaluationsResponse, Evaluation> SearchEvaluationsAsync(EvaluationName parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            SearchEvaluationsAsync(new SearchEvaluationsRequest
            {
                ParentAsEvaluationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = filter ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Searches example comparisons from an evaluation. The return format is a
        /// list of example comparisons that show ground truth and prediction(s) for
        /// a single input. Search by providing an evaluation ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable sequence of <see cref="SearchExampleComparisonsResponse.Types.ExampleComparison"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<SearchExampleComparisonsResponse, SearchExampleComparisonsResponse.Types.ExampleComparison> SearchExampleComparisons(SearchExampleComparisonsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches example comparisons from an evaluation. The return format is a
        /// list of example comparisons that show ground truth and prediction(s) for
        /// a single input. Search by providing an evaluation ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="SearchExampleComparisonsResponse.Types.ExampleComparison"/>
        /// resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<SearchExampleComparisonsResponse, SearchExampleComparisonsResponse.Types.ExampleComparison> SearchExampleComparisonsAsync(SearchExampleComparisonsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches example comparisons from an evaluation. The return format is a
        /// list of example comparisons that show ground truth and prediction(s) for
        /// a single input. Search by providing an evaluation ID.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the [Evaluation][google.cloud.datalabeling.v1beta1.Evaluation] resource to search for example
        /// comparisons from. Format:
        /// 
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;/datasets/&amp;lt;var&amp;gt;{dataset_id}&amp;lt;/var&amp;gt;/evaluations/&amp;lt;var&amp;gt;{evaluation_id}&amp;lt;/var&amp;gt;"
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
        /// A pageable sequence of <see cref="SearchExampleComparisonsResponse.Types.ExampleComparison"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<SearchExampleComparisonsResponse, SearchExampleComparisonsResponse.Types.ExampleComparison> SearchExampleComparisons(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            SearchExampleComparisons(new SearchExampleComparisonsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Searches example comparisons from an evaluation. The return format is a
        /// list of example comparisons that show ground truth and prediction(s) for
        /// a single input. Search by providing an evaluation ID.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the [Evaluation][google.cloud.datalabeling.v1beta1.Evaluation] resource to search for example
        /// comparisons from. Format:
        /// 
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;/datasets/&amp;lt;var&amp;gt;{dataset_id}&amp;lt;/var&amp;gt;/evaluations/&amp;lt;var&amp;gt;{evaluation_id}&amp;lt;/var&amp;gt;"
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
        /// A pageable asynchronous sequence of <see cref="SearchExampleComparisonsResponse.Types.ExampleComparison"/>
        /// resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<SearchExampleComparisonsResponse, SearchExampleComparisonsResponse.Types.ExampleComparison> SearchExampleComparisonsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            SearchExampleComparisonsAsync(new SearchExampleComparisonsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Searches example comparisons from an evaluation. The return format is a
        /// list of example comparisons that show ground truth and prediction(s) for
        /// a single input. Search by providing an evaluation ID.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the [Evaluation][google.cloud.datalabeling.v1beta1.Evaluation] resource to search for example
        /// comparisons from. Format:
        /// 
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;/datasets/&amp;lt;var&amp;gt;{dataset_id}&amp;lt;/var&amp;gt;/evaluations/&amp;lt;var&amp;gt;{evaluation_id}&amp;lt;/var&amp;gt;"
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
        /// A pageable sequence of <see cref="SearchExampleComparisonsResponse.Types.ExampleComparison"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<SearchExampleComparisonsResponse, SearchExampleComparisonsResponse.Types.ExampleComparison> SearchExampleComparisons(EvaluationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            SearchExampleComparisons(new SearchExampleComparisonsRequest
            {
                ParentAsEvaluationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Searches example comparisons from an evaluation. The return format is a
        /// list of example comparisons that show ground truth and prediction(s) for
        /// a single input. Search by providing an evaluation ID.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the [Evaluation][google.cloud.datalabeling.v1beta1.Evaluation] resource to search for example
        /// comparisons from. Format:
        /// 
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;/datasets/&amp;lt;var&amp;gt;{dataset_id}&amp;lt;/var&amp;gt;/evaluations/&amp;lt;var&amp;gt;{evaluation_id}&amp;lt;/var&amp;gt;"
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
        /// A pageable asynchronous sequence of <see cref="SearchExampleComparisonsResponse.Types.ExampleComparison"/>
        /// resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<SearchExampleComparisonsResponse, SearchExampleComparisonsResponse.Types.ExampleComparison> SearchExampleComparisonsAsync(EvaluationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            SearchExampleComparisonsAsync(new SearchExampleComparisonsRequest
            {
                ParentAsEvaluationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Creates an evaluation job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EvaluationJob CreateEvaluationJob(CreateEvaluationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an evaluation job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationJob> CreateEvaluationJobAsync(CreateEvaluationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an evaluation job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationJob> CreateEvaluationJobAsync(CreateEvaluationJobRequest request, st::CancellationToken cancellationToken) =>
            CreateEvaluationJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an evaluation job.
        /// </summary>
        /// <param name="parent">
        /// Required. Evaluation job resource parent. Format:
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;"
        /// </param>
        /// <param name="job">
        /// Required. The evaluation job to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EvaluationJob CreateEvaluationJob(string parent, EvaluationJob job, gaxgrpc::CallSettings callSettings = null) =>
            CreateEvaluationJob(new CreateEvaluationJobRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
            }, callSettings);

        /// <summary>
        /// Creates an evaluation job.
        /// </summary>
        /// <param name="parent">
        /// Required. Evaluation job resource parent. Format:
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;"
        /// </param>
        /// <param name="job">
        /// Required. The evaluation job to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationJob> CreateEvaluationJobAsync(string parent, EvaluationJob job, gaxgrpc::CallSettings callSettings = null) =>
            CreateEvaluationJobAsync(new CreateEvaluationJobRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
            }, callSettings);

        /// <summary>
        /// Creates an evaluation job.
        /// </summary>
        /// <param name="parent">
        /// Required. Evaluation job resource parent. Format:
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;"
        /// </param>
        /// <param name="job">
        /// Required. The evaluation job to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationJob> CreateEvaluationJobAsync(string parent, EvaluationJob job, st::CancellationToken cancellationToken) =>
            CreateEvaluationJobAsync(parent, job, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an evaluation job.
        /// </summary>
        /// <param name="parent">
        /// Required. Evaluation job resource parent. Format:
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;"
        /// </param>
        /// <param name="job">
        /// Required. The evaluation job to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EvaluationJob CreateEvaluationJob(gagr::ProjectName parent, EvaluationJob job, gaxgrpc::CallSettings callSettings = null) =>
            CreateEvaluationJob(new CreateEvaluationJobRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
            }, callSettings);

        /// <summary>
        /// Creates an evaluation job.
        /// </summary>
        /// <param name="parent">
        /// Required. Evaluation job resource parent. Format:
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;"
        /// </param>
        /// <param name="job">
        /// Required. The evaluation job to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationJob> CreateEvaluationJobAsync(gagr::ProjectName parent, EvaluationJob job, gaxgrpc::CallSettings callSettings = null) =>
            CreateEvaluationJobAsync(new CreateEvaluationJobRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
            }, callSettings);

        /// <summary>
        /// Creates an evaluation job.
        /// </summary>
        /// <param name="parent">
        /// Required. Evaluation job resource parent. Format:
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;"
        /// </param>
        /// <param name="job">
        /// Required. The evaluation job to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationJob> CreateEvaluationJobAsync(gagr::ProjectName parent, EvaluationJob job, st::CancellationToken cancellationToken) =>
            CreateEvaluationJobAsync(parent, job, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an evaluation job. You can only update certain fields of the job's
        /// [EvaluationJobConfig][google.cloud.datalabeling.v1beta1.EvaluationJobConfig]: `humanAnnotationConfig.instruction`,
        /// `exampleCount`, and `exampleSamplePercentage`.
        /// 
        /// If you want to change any other aspect of the evaluation job, you must
        /// delete the job and create a new one.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EvaluationJob UpdateEvaluationJob(UpdateEvaluationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an evaluation job. You can only update certain fields of the job's
        /// [EvaluationJobConfig][google.cloud.datalabeling.v1beta1.EvaluationJobConfig]: `humanAnnotationConfig.instruction`,
        /// `exampleCount`, and `exampleSamplePercentage`.
        /// 
        /// If you want to change any other aspect of the evaluation job, you must
        /// delete the job and create a new one.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationJob> UpdateEvaluationJobAsync(UpdateEvaluationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an evaluation job. You can only update certain fields of the job's
        /// [EvaluationJobConfig][google.cloud.datalabeling.v1beta1.EvaluationJobConfig]: `humanAnnotationConfig.instruction`,
        /// `exampleCount`, and `exampleSamplePercentage`.
        /// 
        /// If you want to change any other aspect of the evaluation job, you must
        /// delete the job and create a new one.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationJob> UpdateEvaluationJobAsync(UpdateEvaluationJobRequest request, st::CancellationToken cancellationToken) =>
            UpdateEvaluationJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an evaluation job. You can only update certain fields of the job's
        /// [EvaluationJobConfig][google.cloud.datalabeling.v1beta1.EvaluationJobConfig]: `humanAnnotationConfig.instruction`,
        /// `exampleCount`, and `exampleSamplePercentage`.
        /// 
        /// If you want to change any other aspect of the evaluation job, you must
        /// delete the job and create a new one.
        /// </summary>
        /// <param name="evaluationJob">
        /// Required. Evaluation job that is going to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Mask for which fields to update. You can only provide the
        /// following fields:
        /// 
        /// * `evaluationJobConfig.humanAnnotationConfig.instruction`
        /// * `evaluationJobConfig.exampleCount`
        /// * `evaluationJobConfig.exampleSamplePercentage`
        /// 
        /// You can provide more than one of these fields by separating them with
        /// commas.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EvaluationJob UpdateEvaluationJob(EvaluationJob evaluationJob, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEvaluationJob(new UpdateEvaluationJobRequest
            {
                EvaluationJob = gax::GaxPreconditions.CheckNotNull(evaluationJob, nameof(evaluationJob)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an evaluation job. You can only update certain fields of the job's
        /// [EvaluationJobConfig][google.cloud.datalabeling.v1beta1.EvaluationJobConfig]: `humanAnnotationConfig.instruction`,
        /// `exampleCount`, and `exampleSamplePercentage`.
        /// 
        /// If you want to change any other aspect of the evaluation job, you must
        /// delete the job and create a new one.
        /// </summary>
        /// <param name="evaluationJob">
        /// Required. Evaluation job that is going to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Mask for which fields to update. You can only provide the
        /// following fields:
        /// 
        /// * `evaluationJobConfig.humanAnnotationConfig.instruction`
        /// * `evaluationJobConfig.exampleCount`
        /// * `evaluationJobConfig.exampleSamplePercentage`
        /// 
        /// You can provide more than one of these fields by separating them with
        /// commas.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationJob> UpdateEvaluationJobAsync(EvaluationJob evaluationJob, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEvaluationJobAsync(new UpdateEvaluationJobRequest
            {
                EvaluationJob = gax::GaxPreconditions.CheckNotNull(evaluationJob, nameof(evaluationJob)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an evaluation job. You can only update certain fields of the job's
        /// [EvaluationJobConfig][google.cloud.datalabeling.v1beta1.EvaluationJobConfig]: `humanAnnotationConfig.instruction`,
        /// `exampleCount`, and `exampleSamplePercentage`.
        /// 
        /// If you want to change any other aspect of the evaluation job, you must
        /// delete the job and create a new one.
        /// </summary>
        /// <param name="evaluationJob">
        /// Required. Evaluation job that is going to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Mask for which fields to update. You can only provide the
        /// following fields:
        /// 
        /// * `evaluationJobConfig.humanAnnotationConfig.instruction`
        /// * `evaluationJobConfig.exampleCount`
        /// * `evaluationJobConfig.exampleSamplePercentage`
        /// 
        /// You can provide more than one of these fields by separating them with
        /// commas.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationJob> UpdateEvaluationJobAsync(EvaluationJob evaluationJob, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateEvaluationJobAsync(evaluationJob, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an evaluation job by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EvaluationJob GetEvaluationJob(GetEvaluationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an evaluation job by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationJob> GetEvaluationJobAsync(GetEvaluationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an evaluation job by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationJob> GetEvaluationJobAsync(GetEvaluationJobRequest request, st::CancellationToken cancellationToken) =>
            GetEvaluationJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an evaluation job by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the evaluation job. Format:
        /// 
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;/evaluationJobs/&amp;lt;var&amp;gt;{evaluation_job_id}&amp;lt;/var&amp;gt;"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EvaluationJob GetEvaluationJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvaluationJob(new GetEvaluationJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an evaluation job by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the evaluation job. Format:
        /// 
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;/evaluationJobs/&amp;lt;var&amp;gt;{evaluation_job_id}&amp;lt;/var&amp;gt;"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationJob> GetEvaluationJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvaluationJobAsync(new GetEvaluationJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an evaluation job by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the evaluation job. Format:
        /// 
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;/evaluationJobs/&amp;lt;var&amp;gt;{evaluation_job_id}&amp;lt;/var&amp;gt;"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationJob> GetEvaluationJobAsync(string name, st::CancellationToken cancellationToken) =>
            GetEvaluationJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an evaluation job by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the evaluation job. Format:
        /// 
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;/evaluationJobs/&amp;lt;var&amp;gt;{evaluation_job_id}&amp;lt;/var&amp;gt;"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EvaluationJob GetEvaluationJob(EvaluationJobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvaluationJob(new GetEvaluationJobRequest
            {
                EvaluationJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an evaluation job by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the evaluation job. Format:
        /// 
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;/evaluationJobs/&amp;lt;var&amp;gt;{evaluation_job_id}&amp;lt;/var&amp;gt;"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationJob> GetEvaluationJobAsync(EvaluationJobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvaluationJobAsync(new GetEvaluationJobRequest
            {
                EvaluationJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an evaluation job by resource name.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the evaluation job. Format:
        /// 
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;/evaluationJobs/&amp;lt;var&amp;gt;{evaluation_job_id}&amp;lt;/var&amp;gt;"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EvaluationJob> GetEvaluationJobAsync(EvaluationJobName name, st::CancellationToken cancellationToken) =>
            GetEvaluationJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Pauses an evaluation job. Pausing an evaluation job that is already in a
        /// `PAUSED` state is a no-op.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void PauseEvaluationJob(PauseEvaluationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Pauses an evaluation job. Pausing an evaluation job that is already in a
        /// `PAUSED` state is a no-op.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task PauseEvaluationJobAsync(PauseEvaluationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Pauses an evaluation job. Pausing an evaluation job that is already in a
        /// `PAUSED` state is a no-op.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task PauseEvaluationJobAsync(PauseEvaluationJobRequest request, st::CancellationToken cancellationToken) =>
            PauseEvaluationJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Pauses an evaluation job. Pausing an evaluation job that is already in a
        /// `PAUSED` state is a no-op.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the evaluation job that is going to be paused. Format:
        /// 
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;/evaluationJobs/&amp;lt;var&amp;gt;{evaluation_job_id}&amp;lt;/var&amp;gt;"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void PauseEvaluationJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            PauseEvaluationJob(new PauseEvaluationJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Pauses an evaluation job. Pausing an evaluation job that is already in a
        /// `PAUSED` state is a no-op.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the evaluation job that is going to be paused. Format:
        /// 
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;/evaluationJobs/&amp;lt;var&amp;gt;{evaluation_job_id}&amp;lt;/var&amp;gt;"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task PauseEvaluationJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            PauseEvaluationJobAsync(new PauseEvaluationJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Pauses an evaluation job. Pausing an evaluation job that is already in a
        /// `PAUSED` state is a no-op.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the evaluation job that is going to be paused. Format:
        /// 
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;/evaluationJobs/&amp;lt;var&amp;gt;{evaluation_job_id}&amp;lt;/var&amp;gt;"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task PauseEvaluationJobAsync(string name, st::CancellationToken cancellationToken) =>
            PauseEvaluationJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Pauses an evaluation job. Pausing an evaluation job that is already in a
        /// `PAUSED` state is a no-op.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the evaluation job that is going to be paused. Format:
        /// 
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;/evaluationJobs/&amp;lt;var&amp;gt;{evaluation_job_id}&amp;lt;/var&amp;gt;"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void PauseEvaluationJob(EvaluationJobName name, gaxgrpc::CallSettings callSettings = null) =>
            PauseEvaluationJob(new PauseEvaluationJobRequest
            {
                EvaluationJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Pauses an evaluation job. Pausing an evaluation job that is already in a
        /// `PAUSED` state is a no-op.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the evaluation job that is going to be paused. Format:
        /// 
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;/evaluationJobs/&amp;lt;var&amp;gt;{evaluation_job_id}&amp;lt;/var&amp;gt;"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task PauseEvaluationJobAsync(EvaluationJobName name, gaxgrpc::CallSettings callSettings = null) =>
            PauseEvaluationJobAsync(new PauseEvaluationJobRequest
            {
                EvaluationJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Pauses an evaluation job. Pausing an evaluation job that is already in a
        /// `PAUSED` state is a no-op.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the evaluation job that is going to be paused. Format:
        /// 
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;/evaluationJobs/&amp;lt;var&amp;gt;{evaluation_job_id}&amp;lt;/var&amp;gt;"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task PauseEvaluationJobAsync(EvaluationJobName name, st::CancellationToken cancellationToken) =>
            PauseEvaluationJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resumes a paused evaluation job. A deleted evaluation job can't be resumed.
        /// Resuming a running or scheduled evaluation job is a no-op.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void ResumeEvaluationJob(ResumeEvaluationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resumes a paused evaluation job. A deleted evaluation job can't be resumed.
        /// Resuming a running or scheduled evaluation job is a no-op.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ResumeEvaluationJobAsync(ResumeEvaluationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resumes a paused evaluation job. A deleted evaluation job can't be resumed.
        /// Resuming a running or scheduled evaluation job is a no-op.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ResumeEvaluationJobAsync(ResumeEvaluationJobRequest request, st::CancellationToken cancellationToken) =>
            ResumeEvaluationJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resumes a paused evaluation job. A deleted evaluation job can't be resumed.
        /// Resuming a running or scheduled evaluation job is a no-op.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the evaluation job that is going to be resumed. Format:
        /// 
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;/evaluationJobs/&amp;lt;var&amp;gt;{evaluation_job_id}&amp;lt;/var&amp;gt;"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void ResumeEvaluationJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            ResumeEvaluationJob(new ResumeEvaluationJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Resumes a paused evaluation job. A deleted evaluation job can't be resumed.
        /// Resuming a running or scheduled evaluation job is a no-op.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the evaluation job that is going to be resumed. Format:
        /// 
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;/evaluationJobs/&amp;lt;var&amp;gt;{evaluation_job_id}&amp;lt;/var&amp;gt;"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ResumeEvaluationJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ResumeEvaluationJobAsync(new ResumeEvaluationJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Resumes a paused evaluation job. A deleted evaluation job can't be resumed.
        /// Resuming a running or scheduled evaluation job is a no-op.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the evaluation job that is going to be resumed. Format:
        /// 
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;/evaluationJobs/&amp;lt;var&amp;gt;{evaluation_job_id}&amp;lt;/var&amp;gt;"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ResumeEvaluationJobAsync(string name, st::CancellationToken cancellationToken) =>
            ResumeEvaluationJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resumes a paused evaluation job. A deleted evaluation job can't be resumed.
        /// Resuming a running or scheduled evaluation job is a no-op.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the evaluation job that is going to be resumed. Format:
        /// 
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;/evaluationJobs/&amp;lt;var&amp;gt;{evaluation_job_id}&amp;lt;/var&amp;gt;"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void ResumeEvaluationJob(EvaluationJobName name, gaxgrpc::CallSettings callSettings = null) =>
            ResumeEvaluationJob(new ResumeEvaluationJobRequest
            {
                EvaluationJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Resumes a paused evaluation job. A deleted evaluation job can't be resumed.
        /// Resuming a running or scheduled evaluation job is a no-op.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the evaluation job that is going to be resumed. Format:
        /// 
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;/evaluationJobs/&amp;lt;var&amp;gt;{evaluation_job_id}&amp;lt;/var&amp;gt;"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ResumeEvaluationJobAsync(EvaluationJobName name, gaxgrpc::CallSettings callSettings = null) =>
            ResumeEvaluationJobAsync(new ResumeEvaluationJobRequest
            {
                EvaluationJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Resumes a paused evaluation job. A deleted evaluation job can't be resumed.
        /// Resuming a running or scheduled evaluation job is a no-op.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the evaluation job that is going to be resumed. Format:
        /// 
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;/evaluationJobs/&amp;lt;var&amp;gt;{evaluation_job_id}&amp;lt;/var&amp;gt;"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task ResumeEvaluationJobAsync(EvaluationJobName name, st::CancellationToken cancellationToken) =>
            ResumeEvaluationJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Stops and deletes an evaluation job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEvaluationJob(DeleteEvaluationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops and deletes an evaluation job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEvaluationJobAsync(DeleteEvaluationJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Stops and deletes an evaluation job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEvaluationJobAsync(DeleteEvaluationJobRequest request, st::CancellationToken cancellationToken) =>
            DeleteEvaluationJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Stops and deletes an evaluation job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the evaluation job that is going to be deleted. Format:
        /// 
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;/evaluationJobs/&amp;lt;var&amp;gt;{evaluation_job_id}&amp;lt;/var&amp;gt;"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEvaluationJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEvaluationJob(new DeleteEvaluationJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stops and deletes an evaluation job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the evaluation job that is going to be deleted. Format:
        /// 
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;/evaluationJobs/&amp;lt;var&amp;gt;{evaluation_job_id}&amp;lt;/var&amp;gt;"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEvaluationJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEvaluationJobAsync(new DeleteEvaluationJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stops and deletes an evaluation job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the evaluation job that is going to be deleted. Format:
        /// 
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;/evaluationJobs/&amp;lt;var&amp;gt;{evaluation_job_id}&amp;lt;/var&amp;gt;"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEvaluationJobAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteEvaluationJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Stops and deletes an evaluation job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the evaluation job that is going to be deleted. Format:
        /// 
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;/evaluationJobs/&amp;lt;var&amp;gt;{evaluation_job_id}&amp;lt;/var&amp;gt;"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEvaluationJob(EvaluationJobName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEvaluationJob(new DeleteEvaluationJobRequest
            {
                EvaluationJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stops and deletes an evaluation job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the evaluation job that is going to be deleted. Format:
        /// 
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;/evaluationJobs/&amp;lt;var&amp;gt;{evaluation_job_id}&amp;lt;/var&amp;gt;"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEvaluationJobAsync(EvaluationJobName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEvaluationJobAsync(new DeleteEvaluationJobRequest
            {
                EvaluationJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Stops and deletes an evaluation job.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the evaluation job that is going to be deleted. Format:
        /// 
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;/evaluationJobs/&amp;lt;var&amp;gt;{evaluation_job_id}&amp;lt;/var&amp;gt;"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEvaluationJobAsync(EvaluationJobName name, st::CancellationToken cancellationToken) =>
            DeleteEvaluationJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all evaluation jobs within a project with possible filters.
        /// Pagination is supported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EvaluationJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEvaluationJobsResponse, EvaluationJob> ListEvaluationJobs(ListEvaluationJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all evaluation jobs within a project with possible filters.
        /// Pagination is supported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EvaluationJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEvaluationJobsResponse, EvaluationJob> ListEvaluationJobsAsync(ListEvaluationJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all evaluation jobs within a project with possible filters.
        /// Pagination is supported.
        /// </summary>
        /// <param name="parent">
        /// Required. Evaluation job resource parent. Format:
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;"
        /// </param>
        /// <param name="filter">
        /// Optional. You can filter the jobs to list by model_id (also known as
        /// model_name, as described in
        /// [EvaluationJob.modelVersion][google.cloud.datalabeling.v1beta1.EvaluationJob.model_version]) or by
        /// evaluation job state (as described in [EvaluationJob.state][google.cloud.datalabeling.v1beta1.EvaluationJob.state]). To filter
        /// by both criteria, use the `AND` operator or the `OR` operator. For example,
        /// you can use the following string for your filter:
        /// "evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.model_id = &amp;lt;var&amp;gt;{model_name}&amp;lt;/var&amp;gt; AND
        /// evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.state = &amp;lt;var&amp;gt;{evaluation_job_state}&amp;lt;/var&amp;gt;"
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
        /// <returns>A pageable sequence of <see cref="EvaluationJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEvaluationJobsResponse, EvaluationJob> ListEvaluationJobs(string parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListEvaluationJobs(new ListEvaluationJobsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = filter ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all evaluation jobs within a project with possible filters.
        /// Pagination is supported.
        /// </summary>
        /// <param name="parent">
        /// Required. Evaluation job resource parent. Format:
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;"
        /// </param>
        /// <param name="filter">
        /// Optional. You can filter the jobs to list by model_id (also known as
        /// model_name, as described in
        /// [EvaluationJob.modelVersion][google.cloud.datalabeling.v1beta1.EvaluationJob.model_version]) or by
        /// evaluation job state (as described in [EvaluationJob.state][google.cloud.datalabeling.v1beta1.EvaluationJob.state]). To filter
        /// by both criteria, use the `AND` operator or the `OR` operator. For example,
        /// you can use the following string for your filter:
        /// "evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.model_id = &amp;lt;var&amp;gt;{model_name}&amp;lt;/var&amp;gt; AND
        /// evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.state = &amp;lt;var&amp;gt;{evaluation_job_state}&amp;lt;/var&amp;gt;"
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
        /// <returns>A pageable asynchronous sequence of <see cref="EvaluationJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEvaluationJobsResponse, EvaluationJob> ListEvaluationJobsAsync(string parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListEvaluationJobsAsync(new ListEvaluationJobsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Filter = filter ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all evaluation jobs within a project with possible filters.
        /// Pagination is supported.
        /// </summary>
        /// <param name="parent">
        /// Required. Evaluation job resource parent. Format:
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;"
        /// </param>
        /// <param name="filter">
        /// Optional. You can filter the jobs to list by model_id (also known as
        /// model_name, as described in
        /// [EvaluationJob.modelVersion][google.cloud.datalabeling.v1beta1.EvaluationJob.model_version]) or by
        /// evaluation job state (as described in [EvaluationJob.state][google.cloud.datalabeling.v1beta1.EvaluationJob.state]). To filter
        /// by both criteria, use the `AND` operator or the `OR` operator. For example,
        /// you can use the following string for your filter:
        /// "evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.model_id = &amp;lt;var&amp;gt;{model_name}&amp;lt;/var&amp;gt; AND
        /// evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.state = &amp;lt;var&amp;gt;{evaluation_job_state}&amp;lt;/var&amp;gt;"
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
        /// <returns>A pageable sequence of <see cref="EvaluationJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEvaluationJobsResponse, EvaluationJob> ListEvaluationJobs(gagr::ProjectName parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListEvaluationJobs(new ListEvaluationJobsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = filter ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists all evaluation jobs within a project with possible filters.
        /// Pagination is supported.
        /// </summary>
        /// <param name="parent">
        /// Required. Evaluation job resource parent. Format:
        /// "projects/&amp;lt;var&amp;gt;{project_id}&amp;lt;/var&amp;gt;"
        /// </param>
        /// <param name="filter">
        /// Optional. You can filter the jobs to list by model_id (also known as
        /// model_name, as described in
        /// [EvaluationJob.modelVersion][google.cloud.datalabeling.v1beta1.EvaluationJob.model_version]) or by
        /// evaluation job state (as described in [EvaluationJob.state][google.cloud.datalabeling.v1beta1.EvaluationJob.state]). To filter
        /// by both criteria, use the `AND` operator or the `OR` operator. For example,
        /// you can use the following string for your filter:
        /// "evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.model_id = &amp;lt;var&amp;gt;{model_name}&amp;lt;/var&amp;gt; AND
        /// evaluation&amp;lt;span&amp;gt;_&amp;lt;/span&amp;gt;job.state = &amp;lt;var&amp;gt;{evaluation_job_state}&amp;lt;/var&amp;gt;"
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
        /// <returns>A pageable asynchronous sequence of <see cref="EvaluationJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEvaluationJobsResponse, EvaluationJob> ListEvaluationJobsAsync(gagr::ProjectName parent, string filter, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListEvaluationJobsAsync(new ListEvaluationJobsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Filter = filter ?? "",
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);
    }

    /// <summary>DataLabelingService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service for the AI Platform Data Labeling API.
    /// </remarks>
    public sealed partial class DataLabelingServiceClientImpl : DataLabelingServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateDatasetRequest, Dataset> _callCreateDataset;

        private readonly gaxgrpc::ApiCall<GetDatasetRequest, Dataset> _callGetDataset;

        private readonly gaxgrpc::ApiCall<ListDatasetsRequest, ListDatasetsResponse> _callListDatasets;

        private readonly gaxgrpc::ApiCall<DeleteDatasetRequest, wkt::Empty> _callDeleteDataset;

        private readonly gaxgrpc::ApiCall<ImportDataRequest, lro::Operation> _callImportData;

        private readonly gaxgrpc::ApiCall<ExportDataRequest, lro::Operation> _callExportData;

        private readonly gaxgrpc::ApiCall<GetDataItemRequest, DataItem> _callGetDataItem;

        private readonly gaxgrpc::ApiCall<ListDataItemsRequest, ListDataItemsResponse> _callListDataItems;

        private readonly gaxgrpc::ApiCall<GetAnnotatedDatasetRequest, AnnotatedDataset> _callGetAnnotatedDataset;

        private readonly gaxgrpc::ApiCall<ListAnnotatedDatasetsRequest, ListAnnotatedDatasetsResponse> _callListAnnotatedDatasets;

        private readonly gaxgrpc::ApiCall<DeleteAnnotatedDatasetRequest, wkt::Empty> _callDeleteAnnotatedDataset;

        private readonly gaxgrpc::ApiCall<LabelImageRequest, lro::Operation> _callLabelImage;

        private readonly gaxgrpc::ApiCall<LabelVideoRequest, lro::Operation> _callLabelVideo;

        private readonly gaxgrpc::ApiCall<LabelTextRequest, lro::Operation> _callLabelText;

        private readonly gaxgrpc::ApiCall<GetExampleRequest, Example> _callGetExample;

        private readonly gaxgrpc::ApiCall<ListExamplesRequest, ListExamplesResponse> _callListExamples;

        private readonly gaxgrpc::ApiCall<CreateAnnotationSpecSetRequest, AnnotationSpecSet> _callCreateAnnotationSpecSet;

        private readonly gaxgrpc::ApiCall<GetAnnotationSpecSetRequest, AnnotationSpecSet> _callGetAnnotationSpecSet;

        private readonly gaxgrpc::ApiCall<ListAnnotationSpecSetsRequest, ListAnnotationSpecSetsResponse> _callListAnnotationSpecSets;

        private readonly gaxgrpc::ApiCall<DeleteAnnotationSpecSetRequest, wkt::Empty> _callDeleteAnnotationSpecSet;

        private readonly gaxgrpc::ApiCall<CreateInstructionRequest, lro::Operation> _callCreateInstruction;

        private readonly gaxgrpc::ApiCall<GetInstructionRequest, Instruction> _callGetInstruction;

        private readonly gaxgrpc::ApiCall<ListInstructionsRequest, ListInstructionsResponse> _callListInstructions;

        private readonly gaxgrpc::ApiCall<DeleteInstructionRequest, wkt::Empty> _callDeleteInstruction;

        private readonly gaxgrpc::ApiCall<GetEvaluationRequest, Evaluation> _callGetEvaluation;

        private readonly gaxgrpc::ApiCall<SearchEvaluationsRequest, SearchEvaluationsResponse> _callSearchEvaluations;

        private readonly gaxgrpc::ApiCall<SearchExampleComparisonsRequest, SearchExampleComparisonsResponse> _callSearchExampleComparisons;

        private readonly gaxgrpc::ApiCall<CreateEvaluationJobRequest, EvaluationJob> _callCreateEvaluationJob;

        private readonly gaxgrpc::ApiCall<UpdateEvaluationJobRequest, EvaluationJob> _callUpdateEvaluationJob;

        private readonly gaxgrpc::ApiCall<GetEvaluationJobRequest, EvaluationJob> _callGetEvaluationJob;

        private readonly gaxgrpc::ApiCall<PauseEvaluationJobRequest, wkt::Empty> _callPauseEvaluationJob;

        private readonly gaxgrpc::ApiCall<ResumeEvaluationJobRequest, wkt::Empty> _callResumeEvaluationJob;

        private readonly gaxgrpc::ApiCall<DeleteEvaluationJobRequest, wkt::Empty> _callDeleteEvaluationJob;

        private readonly gaxgrpc::ApiCall<ListEvaluationJobsRequest, ListEvaluationJobsResponse> _callListEvaluationJobs;

        /// <summary>
        /// Constructs a client wrapper for the DataLabelingService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DataLabelingServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DataLabelingServiceClientImpl(DataLabelingService.DataLabelingServiceClient grpcClient, DataLabelingServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DataLabelingServiceSettings effectiveSettings = settings ?? DataLabelingServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            ImportDataOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ImportDataOperationsSettings, logger);
            ExportDataOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportDataOperationsSettings, logger);
            LabelImageOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.LabelImageOperationsSettings, logger);
            LabelVideoOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.LabelVideoOperationsSettings, logger);
            LabelTextOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.LabelTextOperationsSettings, logger);
            CreateInstructionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateInstructionOperationsSettings, logger);
            _callCreateDataset = clientHelper.BuildApiCall<CreateDatasetRequest, Dataset>("CreateDataset", grpcClient.CreateDatasetAsync, grpcClient.CreateDataset, effectiveSettings.CreateDatasetSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDataset);
            Modify_CreateDatasetApiCall(ref _callCreateDataset);
            _callGetDataset = clientHelper.BuildApiCall<GetDatasetRequest, Dataset>("GetDataset", grpcClient.GetDatasetAsync, grpcClient.GetDataset, effectiveSettings.GetDatasetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDataset);
            Modify_GetDatasetApiCall(ref _callGetDataset);
            _callListDatasets = clientHelper.BuildApiCall<ListDatasetsRequest, ListDatasetsResponse>("ListDatasets", grpcClient.ListDatasetsAsync, grpcClient.ListDatasets, effectiveSettings.ListDatasetsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDatasets);
            Modify_ListDatasetsApiCall(ref _callListDatasets);
            _callDeleteDataset = clientHelper.BuildApiCall<DeleteDatasetRequest, wkt::Empty>("DeleteDataset", grpcClient.DeleteDatasetAsync, grpcClient.DeleteDataset, effectiveSettings.DeleteDatasetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDataset);
            Modify_DeleteDatasetApiCall(ref _callDeleteDataset);
            _callImportData = clientHelper.BuildApiCall<ImportDataRequest, lro::Operation>("ImportData", grpcClient.ImportDataAsync, grpcClient.ImportData, effectiveSettings.ImportDataSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callImportData);
            Modify_ImportDataApiCall(ref _callImportData);
            _callExportData = clientHelper.BuildApiCall<ExportDataRequest, lro::Operation>("ExportData", grpcClient.ExportDataAsync, grpcClient.ExportData, effectiveSettings.ExportDataSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callExportData);
            Modify_ExportDataApiCall(ref _callExportData);
            _callGetDataItem = clientHelper.BuildApiCall<GetDataItemRequest, DataItem>("GetDataItem", grpcClient.GetDataItemAsync, grpcClient.GetDataItem, effectiveSettings.GetDataItemSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDataItem);
            Modify_GetDataItemApiCall(ref _callGetDataItem);
            _callListDataItems = clientHelper.BuildApiCall<ListDataItemsRequest, ListDataItemsResponse>("ListDataItems", grpcClient.ListDataItemsAsync, grpcClient.ListDataItems, effectiveSettings.ListDataItemsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDataItems);
            Modify_ListDataItemsApiCall(ref _callListDataItems);
            _callGetAnnotatedDataset = clientHelper.BuildApiCall<GetAnnotatedDatasetRequest, AnnotatedDataset>("GetAnnotatedDataset", grpcClient.GetAnnotatedDatasetAsync, grpcClient.GetAnnotatedDataset, effectiveSettings.GetAnnotatedDatasetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAnnotatedDataset);
            Modify_GetAnnotatedDatasetApiCall(ref _callGetAnnotatedDataset);
            _callListAnnotatedDatasets = clientHelper.BuildApiCall<ListAnnotatedDatasetsRequest, ListAnnotatedDatasetsResponse>("ListAnnotatedDatasets", grpcClient.ListAnnotatedDatasetsAsync, grpcClient.ListAnnotatedDatasets, effectiveSettings.ListAnnotatedDatasetsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAnnotatedDatasets);
            Modify_ListAnnotatedDatasetsApiCall(ref _callListAnnotatedDatasets);
            _callDeleteAnnotatedDataset = clientHelper.BuildApiCall<DeleteAnnotatedDatasetRequest, wkt::Empty>("DeleteAnnotatedDataset", grpcClient.DeleteAnnotatedDatasetAsync, grpcClient.DeleteAnnotatedDataset, effectiveSettings.DeleteAnnotatedDatasetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAnnotatedDataset);
            Modify_DeleteAnnotatedDatasetApiCall(ref _callDeleteAnnotatedDataset);
            _callLabelImage = clientHelper.BuildApiCall<LabelImageRequest, lro::Operation>("LabelImage", grpcClient.LabelImageAsync, grpcClient.LabelImage, effectiveSettings.LabelImageSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callLabelImage);
            Modify_LabelImageApiCall(ref _callLabelImage);
            _callLabelVideo = clientHelper.BuildApiCall<LabelVideoRequest, lro::Operation>("LabelVideo", grpcClient.LabelVideoAsync, grpcClient.LabelVideo, effectiveSettings.LabelVideoSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callLabelVideo);
            Modify_LabelVideoApiCall(ref _callLabelVideo);
            _callLabelText = clientHelper.BuildApiCall<LabelTextRequest, lro::Operation>("LabelText", grpcClient.LabelTextAsync, grpcClient.LabelText, effectiveSettings.LabelTextSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callLabelText);
            Modify_LabelTextApiCall(ref _callLabelText);
            _callGetExample = clientHelper.BuildApiCall<GetExampleRequest, Example>("GetExample", grpcClient.GetExampleAsync, grpcClient.GetExample, effectiveSettings.GetExampleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetExample);
            Modify_GetExampleApiCall(ref _callGetExample);
            _callListExamples = clientHelper.BuildApiCall<ListExamplesRequest, ListExamplesResponse>("ListExamples", grpcClient.ListExamplesAsync, grpcClient.ListExamples, effectiveSettings.ListExamplesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListExamples);
            Modify_ListExamplesApiCall(ref _callListExamples);
            _callCreateAnnotationSpecSet = clientHelper.BuildApiCall<CreateAnnotationSpecSetRequest, AnnotationSpecSet>("CreateAnnotationSpecSet", grpcClient.CreateAnnotationSpecSetAsync, grpcClient.CreateAnnotationSpecSet, effectiveSettings.CreateAnnotationSpecSetSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAnnotationSpecSet);
            Modify_CreateAnnotationSpecSetApiCall(ref _callCreateAnnotationSpecSet);
            _callGetAnnotationSpecSet = clientHelper.BuildApiCall<GetAnnotationSpecSetRequest, AnnotationSpecSet>("GetAnnotationSpecSet", grpcClient.GetAnnotationSpecSetAsync, grpcClient.GetAnnotationSpecSet, effectiveSettings.GetAnnotationSpecSetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAnnotationSpecSet);
            Modify_GetAnnotationSpecSetApiCall(ref _callGetAnnotationSpecSet);
            _callListAnnotationSpecSets = clientHelper.BuildApiCall<ListAnnotationSpecSetsRequest, ListAnnotationSpecSetsResponse>("ListAnnotationSpecSets", grpcClient.ListAnnotationSpecSetsAsync, grpcClient.ListAnnotationSpecSets, effectiveSettings.ListAnnotationSpecSetsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAnnotationSpecSets);
            Modify_ListAnnotationSpecSetsApiCall(ref _callListAnnotationSpecSets);
            _callDeleteAnnotationSpecSet = clientHelper.BuildApiCall<DeleteAnnotationSpecSetRequest, wkt::Empty>("DeleteAnnotationSpecSet", grpcClient.DeleteAnnotationSpecSetAsync, grpcClient.DeleteAnnotationSpecSet, effectiveSettings.DeleteAnnotationSpecSetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAnnotationSpecSet);
            Modify_DeleteAnnotationSpecSetApiCall(ref _callDeleteAnnotationSpecSet);
            _callCreateInstruction = clientHelper.BuildApiCall<CreateInstructionRequest, lro::Operation>("CreateInstruction", grpcClient.CreateInstructionAsync, grpcClient.CreateInstruction, effectiveSettings.CreateInstructionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateInstruction);
            Modify_CreateInstructionApiCall(ref _callCreateInstruction);
            _callGetInstruction = clientHelper.BuildApiCall<GetInstructionRequest, Instruction>("GetInstruction", grpcClient.GetInstructionAsync, grpcClient.GetInstruction, effectiveSettings.GetInstructionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetInstruction);
            Modify_GetInstructionApiCall(ref _callGetInstruction);
            _callListInstructions = clientHelper.BuildApiCall<ListInstructionsRequest, ListInstructionsResponse>("ListInstructions", grpcClient.ListInstructionsAsync, grpcClient.ListInstructions, effectiveSettings.ListInstructionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListInstructions);
            Modify_ListInstructionsApiCall(ref _callListInstructions);
            _callDeleteInstruction = clientHelper.BuildApiCall<DeleteInstructionRequest, wkt::Empty>("DeleteInstruction", grpcClient.DeleteInstructionAsync, grpcClient.DeleteInstruction, effectiveSettings.DeleteInstructionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteInstruction);
            Modify_DeleteInstructionApiCall(ref _callDeleteInstruction);
            _callGetEvaluation = clientHelper.BuildApiCall<GetEvaluationRequest, Evaluation>("GetEvaluation", grpcClient.GetEvaluationAsync, grpcClient.GetEvaluation, effectiveSettings.GetEvaluationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEvaluation);
            Modify_GetEvaluationApiCall(ref _callGetEvaluation);
            _callSearchEvaluations = clientHelper.BuildApiCall<SearchEvaluationsRequest, SearchEvaluationsResponse>("SearchEvaluations", grpcClient.SearchEvaluationsAsync, grpcClient.SearchEvaluations, effectiveSettings.SearchEvaluationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSearchEvaluations);
            Modify_SearchEvaluationsApiCall(ref _callSearchEvaluations);
            _callSearchExampleComparisons = clientHelper.BuildApiCall<SearchExampleComparisonsRequest, SearchExampleComparisonsResponse>("SearchExampleComparisons", grpcClient.SearchExampleComparisonsAsync, grpcClient.SearchExampleComparisons, effectiveSettings.SearchExampleComparisonsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSearchExampleComparisons);
            Modify_SearchExampleComparisonsApiCall(ref _callSearchExampleComparisons);
            _callCreateEvaluationJob = clientHelper.BuildApiCall<CreateEvaluationJobRequest, EvaluationJob>("CreateEvaluationJob", grpcClient.CreateEvaluationJobAsync, grpcClient.CreateEvaluationJob, effectiveSettings.CreateEvaluationJobSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateEvaluationJob);
            Modify_CreateEvaluationJobApiCall(ref _callCreateEvaluationJob);
            _callUpdateEvaluationJob = clientHelper.BuildApiCall<UpdateEvaluationJobRequest, EvaluationJob>("UpdateEvaluationJob", grpcClient.UpdateEvaluationJobAsync, grpcClient.UpdateEvaluationJob, effectiveSettings.UpdateEvaluationJobSettings).WithGoogleRequestParam("evaluation_job.name", request => request.EvaluationJob?.Name);
            Modify_ApiCall(ref _callUpdateEvaluationJob);
            Modify_UpdateEvaluationJobApiCall(ref _callUpdateEvaluationJob);
            _callGetEvaluationJob = clientHelper.BuildApiCall<GetEvaluationJobRequest, EvaluationJob>("GetEvaluationJob", grpcClient.GetEvaluationJobAsync, grpcClient.GetEvaluationJob, effectiveSettings.GetEvaluationJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEvaluationJob);
            Modify_GetEvaluationJobApiCall(ref _callGetEvaluationJob);
            _callPauseEvaluationJob = clientHelper.BuildApiCall<PauseEvaluationJobRequest, wkt::Empty>("PauseEvaluationJob", grpcClient.PauseEvaluationJobAsync, grpcClient.PauseEvaluationJob, effectiveSettings.PauseEvaluationJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callPauseEvaluationJob);
            Modify_PauseEvaluationJobApiCall(ref _callPauseEvaluationJob);
            _callResumeEvaluationJob = clientHelper.BuildApiCall<ResumeEvaluationJobRequest, wkt::Empty>("ResumeEvaluationJob", grpcClient.ResumeEvaluationJobAsync, grpcClient.ResumeEvaluationJob, effectiveSettings.ResumeEvaluationJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callResumeEvaluationJob);
            Modify_ResumeEvaluationJobApiCall(ref _callResumeEvaluationJob);
            _callDeleteEvaluationJob = clientHelper.BuildApiCall<DeleteEvaluationJobRequest, wkt::Empty>("DeleteEvaluationJob", grpcClient.DeleteEvaluationJobAsync, grpcClient.DeleteEvaluationJob, effectiveSettings.DeleteEvaluationJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteEvaluationJob);
            Modify_DeleteEvaluationJobApiCall(ref _callDeleteEvaluationJob);
            _callListEvaluationJobs = clientHelper.BuildApiCall<ListEvaluationJobsRequest, ListEvaluationJobsResponse>("ListEvaluationJobs", grpcClient.ListEvaluationJobsAsync, grpcClient.ListEvaluationJobs, effectiveSettings.ListEvaluationJobsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEvaluationJobs);
            Modify_ListEvaluationJobsApiCall(ref _callListEvaluationJobs);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateDatasetApiCall(ref gaxgrpc::ApiCall<CreateDatasetRequest, Dataset> call);

        partial void Modify_GetDatasetApiCall(ref gaxgrpc::ApiCall<GetDatasetRequest, Dataset> call);

        partial void Modify_ListDatasetsApiCall(ref gaxgrpc::ApiCall<ListDatasetsRequest, ListDatasetsResponse> call);

        partial void Modify_DeleteDatasetApiCall(ref gaxgrpc::ApiCall<DeleteDatasetRequest, wkt::Empty> call);

        partial void Modify_ImportDataApiCall(ref gaxgrpc::ApiCall<ImportDataRequest, lro::Operation> call);

        partial void Modify_ExportDataApiCall(ref gaxgrpc::ApiCall<ExportDataRequest, lro::Operation> call);

        partial void Modify_GetDataItemApiCall(ref gaxgrpc::ApiCall<GetDataItemRequest, DataItem> call);

        partial void Modify_ListDataItemsApiCall(ref gaxgrpc::ApiCall<ListDataItemsRequest, ListDataItemsResponse> call);

        partial void Modify_GetAnnotatedDatasetApiCall(ref gaxgrpc::ApiCall<GetAnnotatedDatasetRequest, AnnotatedDataset> call);

        partial void Modify_ListAnnotatedDatasetsApiCall(ref gaxgrpc::ApiCall<ListAnnotatedDatasetsRequest, ListAnnotatedDatasetsResponse> call);

        partial void Modify_DeleteAnnotatedDatasetApiCall(ref gaxgrpc::ApiCall<DeleteAnnotatedDatasetRequest, wkt::Empty> call);

        partial void Modify_LabelImageApiCall(ref gaxgrpc::ApiCall<LabelImageRequest, lro::Operation> call);

        partial void Modify_LabelVideoApiCall(ref gaxgrpc::ApiCall<LabelVideoRequest, lro::Operation> call);

        partial void Modify_LabelTextApiCall(ref gaxgrpc::ApiCall<LabelTextRequest, lro::Operation> call);

        partial void Modify_GetExampleApiCall(ref gaxgrpc::ApiCall<GetExampleRequest, Example> call);

        partial void Modify_ListExamplesApiCall(ref gaxgrpc::ApiCall<ListExamplesRequest, ListExamplesResponse> call);

        partial void Modify_CreateAnnotationSpecSetApiCall(ref gaxgrpc::ApiCall<CreateAnnotationSpecSetRequest, AnnotationSpecSet> call);

        partial void Modify_GetAnnotationSpecSetApiCall(ref gaxgrpc::ApiCall<GetAnnotationSpecSetRequest, AnnotationSpecSet> call);

        partial void Modify_ListAnnotationSpecSetsApiCall(ref gaxgrpc::ApiCall<ListAnnotationSpecSetsRequest, ListAnnotationSpecSetsResponse> call);

        partial void Modify_DeleteAnnotationSpecSetApiCall(ref gaxgrpc::ApiCall<DeleteAnnotationSpecSetRequest, wkt::Empty> call);

        partial void Modify_CreateInstructionApiCall(ref gaxgrpc::ApiCall<CreateInstructionRequest, lro::Operation> call);

        partial void Modify_GetInstructionApiCall(ref gaxgrpc::ApiCall<GetInstructionRequest, Instruction> call);

        partial void Modify_ListInstructionsApiCall(ref gaxgrpc::ApiCall<ListInstructionsRequest, ListInstructionsResponse> call);

        partial void Modify_DeleteInstructionApiCall(ref gaxgrpc::ApiCall<DeleteInstructionRequest, wkt::Empty> call);

        partial void Modify_GetEvaluationApiCall(ref gaxgrpc::ApiCall<GetEvaluationRequest, Evaluation> call);

        partial void Modify_SearchEvaluationsApiCall(ref gaxgrpc::ApiCall<SearchEvaluationsRequest, SearchEvaluationsResponse> call);

        partial void Modify_SearchExampleComparisonsApiCall(ref gaxgrpc::ApiCall<SearchExampleComparisonsRequest, SearchExampleComparisonsResponse> call);

        partial void Modify_CreateEvaluationJobApiCall(ref gaxgrpc::ApiCall<CreateEvaluationJobRequest, EvaluationJob> call);

        partial void Modify_UpdateEvaluationJobApiCall(ref gaxgrpc::ApiCall<UpdateEvaluationJobRequest, EvaluationJob> call);

        partial void Modify_GetEvaluationJobApiCall(ref gaxgrpc::ApiCall<GetEvaluationJobRequest, EvaluationJob> call);

        partial void Modify_PauseEvaluationJobApiCall(ref gaxgrpc::ApiCall<PauseEvaluationJobRequest, wkt::Empty> call);

        partial void Modify_ResumeEvaluationJobApiCall(ref gaxgrpc::ApiCall<ResumeEvaluationJobRequest, wkt::Empty> call);

        partial void Modify_DeleteEvaluationJobApiCall(ref gaxgrpc::ApiCall<DeleteEvaluationJobRequest, wkt::Empty> call);

        partial void Modify_ListEvaluationJobsApiCall(ref gaxgrpc::ApiCall<ListEvaluationJobsRequest, ListEvaluationJobsResponse> call);

        partial void OnConstruction(DataLabelingService.DataLabelingServiceClient grpcClient, DataLabelingServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DataLabelingService client</summary>
        public override DataLabelingService.DataLabelingServiceClient GrpcClient { get; }

        partial void Modify_CreateDatasetRequest(ref CreateDatasetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDatasetRequest(ref GetDatasetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDatasetsRequest(ref ListDatasetsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDatasetRequest(ref DeleteDatasetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportDataRequest(ref ImportDataRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportDataRequest(ref ExportDataRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDataItemRequest(ref GetDataItemRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDataItemsRequest(ref ListDataItemsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAnnotatedDatasetRequest(ref GetAnnotatedDatasetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAnnotatedDatasetsRequest(ref ListAnnotatedDatasetsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAnnotatedDatasetRequest(ref DeleteAnnotatedDatasetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_LabelImageRequest(ref LabelImageRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_LabelVideoRequest(ref LabelVideoRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_LabelTextRequest(ref LabelTextRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetExampleRequest(ref GetExampleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListExamplesRequest(ref ListExamplesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAnnotationSpecSetRequest(ref CreateAnnotationSpecSetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAnnotationSpecSetRequest(ref GetAnnotationSpecSetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAnnotationSpecSetsRequest(ref ListAnnotationSpecSetsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAnnotationSpecSetRequest(ref DeleteAnnotationSpecSetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateInstructionRequest(ref CreateInstructionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetInstructionRequest(ref GetInstructionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListInstructionsRequest(ref ListInstructionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteInstructionRequest(ref DeleteInstructionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEvaluationRequest(ref GetEvaluationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchEvaluationsRequest(ref SearchEvaluationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchExampleComparisonsRequest(ref SearchExampleComparisonsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateEvaluationJobRequest(ref CreateEvaluationJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateEvaluationJobRequest(ref UpdateEvaluationJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEvaluationJobRequest(ref GetEvaluationJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PauseEvaluationJobRequest(ref PauseEvaluationJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResumeEvaluationJobRequest(ref ResumeEvaluationJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteEvaluationJobRequest(ref DeleteEvaluationJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEvaluationJobsRequest(ref ListEvaluationJobsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates dataset. If success return a Dataset resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Dataset CreateDataset(CreateDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDatasetRequest(ref request, ref callSettings);
            return _callCreateDataset.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates dataset. If success return a Dataset resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Dataset> CreateDatasetAsync(CreateDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDatasetRequest(ref request, ref callSettings);
            return _callCreateDataset.Async(request, callSettings);
        }

        /// <summary>
        /// Gets dataset by resource name.
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
        /// Gets dataset by resource name.
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
        /// Lists datasets under a project. Pagination is supported.
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
        /// Lists datasets under a project. Pagination is supported.
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
        /// Deletes a dataset by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteDataset(DeleteDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDatasetRequest(ref request, ref callSettings);
            _callDeleteDataset.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a dataset by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteDatasetAsync(DeleteDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDatasetRequest(ref request, ref callSettings);
            return _callDeleteDataset.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>ImportData</c>.</summary>
        public override lro::OperationsClient ImportDataOperationsClient { get; }

        /// <summary>
        /// Imports data into dataset based on source locations defined in request.
        /// It can be called multiple times for the same dataset. Each dataset can
        /// only have one long running operation running on it. For example, no
        /// labeling task (also long running operation) can be started while
        /// importing is still ongoing. Vice versa.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ImportDataOperationResponse, ImportDataOperationMetadata> ImportData(ImportDataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportDataRequest(ref request, ref callSettings);
            return new lro::Operation<ImportDataOperationResponse, ImportDataOperationMetadata>(_callImportData.Sync(request, callSettings), ImportDataOperationsClient);
        }

        /// <summary>
        /// Imports data into dataset based on source locations defined in request.
        /// It can be called multiple times for the same dataset. Each dataset can
        /// only have one long running operation running on it. For example, no
        /// labeling task (also long running operation) can be started while
        /// importing is still ongoing. Vice versa.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ImportDataOperationResponse, ImportDataOperationMetadata>> ImportDataAsync(ImportDataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportDataRequest(ref request, ref callSettings);
            return new lro::Operation<ImportDataOperationResponse, ImportDataOperationMetadata>(await _callImportData.Async(request, callSettings).ConfigureAwait(false), ImportDataOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ExportData</c>.</summary>
        public override lro::OperationsClient ExportDataOperationsClient { get; }

        /// <summary>
        /// Exports data and annotations from dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ExportDataOperationResponse, ExportDataOperationMetadata> ExportData(ExportDataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportDataRequest(ref request, ref callSettings);
            return new lro::Operation<ExportDataOperationResponse, ExportDataOperationMetadata>(_callExportData.Sync(request, callSettings), ExportDataOperationsClient);
        }

        /// <summary>
        /// Exports data and annotations from dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ExportDataOperationResponse, ExportDataOperationMetadata>> ExportDataAsync(ExportDataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportDataRequest(ref request, ref callSettings);
            return new lro::Operation<ExportDataOperationResponse, ExportDataOperationMetadata>(await _callExportData.Async(request, callSettings).ConfigureAwait(false), ExportDataOperationsClient);
        }

        /// <summary>
        /// Gets a data item in a dataset by resource name. This API can be
        /// called after data are imported into dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DataItem GetDataItem(GetDataItemRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataItemRequest(ref request, ref callSettings);
            return _callGetDataItem.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a data item in a dataset by resource name. This API can be
        /// called after data are imported into dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DataItem> GetDataItemAsync(GetDataItemRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDataItemRequest(ref request, ref callSettings);
            return _callGetDataItem.Async(request, callSettings);
        }

        /// <summary>
        /// Lists data items in a dataset. This API can be called after data
        /// are imported into dataset. Pagination is supported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DataItem"/> resources.</returns>
        public override gax::PagedEnumerable<ListDataItemsResponse, DataItem> ListDataItems(ListDataItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataItemsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDataItemsRequest, ListDataItemsResponse, DataItem>(_callListDataItems, request, callSettings);
        }

        /// <summary>
        /// Lists data items in a dataset. This API can be called after data
        /// are imported into dataset. Pagination is supported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DataItem"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDataItemsResponse, DataItem> ListDataItemsAsync(ListDataItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDataItemsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDataItemsRequest, ListDataItemsResponse, DataItem>(_callListDataItems, request, callSettings);
        }

        /// <summary>
        /// Gets an annotated dataset by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AnnotatedDataset GetAnnotatedDataset(GetAnnotatedDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAnnotatedDatasetRequest(ref request, ref callSettings);
            return _callGetAnnotatedDataset.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an annotated dataset by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AnnotatedDataset> GetAnnotatedDatasetAsync(GetAnnotatedDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAnnotatedDatasetRequest(ref request, ref callSettings);
            return _callGetAnnotatedDataset.Async(request, callSettings);
        }

        /// <summary>
        /// Lists annotated datasets for a dataset. Pagination is supported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AnnotatedDataset"/> resources.</returns>
        public override gax::PagedEnumerable<ListAnnotatedDatasetsResponse, AnnotatedDataset> ListAnnotatedDatasets(ListAnnotatedDatasetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAnnotatedDatasetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAnnotatedDatasetsRequest, ListAnnotatedDatasetsResponse, AnnotatedDataset>(_callListAnnotatedDatasets, request, callSettings);
        }

        /// <summary>
        /// Lists annotated datasets for a dataset. Pagination is supported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AnnotatedDataset"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAnnotatedDatasetsResponse, AnnotatedDataset> ListAnnotatedDatasetsAsync(ListAnnotatedDatasetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAnnotatedDatasetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAnnotatedDatasetsRequest, ListAnnotatedDatasetsResponse, AnnotatedDataset>(_callListAnnotatedDatasets, request, callSettings);
        }

        /// <summary>
        /// Deletes an annotated dataset by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteAnnotatedDataset(DeleteAnnotatedDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAnnotatedDatasetRequest(ref request, ref callSettings);
            _callDeleteAnnotatedDataset.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an annotated dataset by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteAnnotatedDatasetAsync(DeleteAnnotatedDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAnnotatedDatasetRequest(ref request, ref callSettings);
            return _callDeleteAnnotatedDataset.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>LabelImage</c>.</summary>
        public override lro::OperationsClient LabelImageOperationsClient { get; }

        /// <summary>
        /// Starts a labeling task for image. The type of image labeling task is
        /// configured by feature in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AnnotatedDataset, LabelOperationMetadata> LabelImage(LabelImageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LabelImageRequest(ref request, ref callSettings);
            return new lro::Operation<AnnotatedDataset, LabelOperationMetadata>(_callLabelImage.Sync(request, callSettings), LabelImageOperationsClient);
        }

        /// <summary>
        /// Starts a labeling task for image. The type of image labeling task is
        /// configured by feature in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AnnotatedDataset, LabelOperationMetadata>> LabelImageAsync(LabelImageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LabelImageRequest(ref request, ref callSettings);
            return new lro::Operation<AnnotatedDataset, LabelOperationMetadata>(await _callLabelImage.Async(request, callSettings).ConfigureAwait(false), LabelImageOperationsClient);
        }

        /// <summary>The long-running operations client for <c>LabelVideo</c>.</summary>
        public override lro::OperationsClient LabelVideoOperationsClient { get; }

        /// <summary>
        /// Starts a labeling task for video. The type of video labeling task is
        /// configured by feature in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AnnotatedDataset, LabelOperationMetadata> LabelVideo(LabelVideoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LabelVideoRequest(ref request, ref callSettings);
            return new lro::Operation<AnnotatedDataset, LabelOperationMetadata>(_callLabelVideo.Sync(request, callSettings), LabelVideoOperationsClient);
        }

        /// <summary>
        /// Starts a labeling task for video. The type of video labeling task is
        /// configured by feature in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AnnotatedDataset, LabelOperationMetadata>> LabelVideoAsync(LabelVideoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LabelVideoRequest(ref request, ref callSettings);
            return new lro::Operation<AnnotatedDataset, LabelOperationMetadata>(await _callLabelVideo.Async(request, callSettings).ConfigureAwait(false), LabelVideoOperationsClient);
        }

        /// <summary>The long-running operations client for <c>LabelText</c>.</summary>
        public override lro::OperationsClient LabelTextOperationsClient { get; }

        /// <summary>
        /// Starts a labeling task for text. The type of text labeling task is
        /// configured by feature in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AnnotatedDataset, LabelOperationMetadata> LabelText(LabelTextRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LabelTextRequest(ref request, ref callSettings);
            return new lro::Operation<AnnotatedDataset, LabelOperationMetadata>(_callLabelText.Sync(request, callSettings), LabelTextOperationsClient);
        }

        /// <summary>
        /// Starts a labeling task for text. The type of text labeling task is
        /// configured by feature in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AnnotatedDataset, LabelOperationMetadata>> LabelTextAsync(LabelTextRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LabelTextRequest(ref request, ref callSettings);
            return new lro::Operation<AnnotatedDataset, LabelOperationMetadata>(await _callLabelText.Async(request, callSettings).ConfigureAwait(false), LabelTextOperationsClient);
        }

        /// <summary>
        /// Gets an example by resource name, including both data and annotation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Example GetExample(GetExampleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetExampleRequest(ref request, ref callSettings);
            return _callGetExample.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an example by resource name, including both data and annotation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Example> GetExampleAsync(GetExampleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetExampleRequest(ref request, ref callSettings);
            return _callGetExample.Async(request, callSettings);
        }

        /// <summary>
        /// Lists examples in an annotated dataset. Pagination is supported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Example"/> resources.</returns>
        public override gax::PagedEnumerable<ListExamplesResponse, Example> ListExamples(ListExamplesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListExamplesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListExamplesRequest, ListExamplesResponse, Example>(_callListExamples, request, callSettings);
        }

        /// <summary>
        /// Lists examples in an annotated dataset. Pagination is supported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Example"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListExamplesResponse, Example> ListExamplesAsync(ListExamplesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListExamplesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListExamplesRequest, ListExamplesResponse, Example>(_callListExamples, request, callSettings);
        }

        /// <summary>
        /// Creates an annotation spec set by providing a set of labels.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AnnotationSpecSet CreateAnnotationSpecSet(CreateAnnotationSpecSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAnnotationSpecSetRequest(ref request, ref callSettings);
            return _callCreateAnnotationSpecSet.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an annotation spec set by providing a set of labels.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AnnotationSpecSet> CreateAnnotationSpecSetAsync(CreateAnnotationSpecSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAnnotationSpecSetRequest(ref request, ref callSettings);
            return _callCreateAnnotationSpecSet.Async(request, callSettings);
        }

        /// <summary>
        /// Gets an annotation spec set by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AnnotationSpecSet GetAnnotationSpecSet(GetAnnotationSpecSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAnnotationSpecSetRequest(ref request, ref callSettings);
            return _callGetAnnotationSpecSet.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an annotation spec set by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AnnotationSpecSet> GetAnnotationSpecSetAsync(GetAnnotationSpecSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAnnotationSpecSetRequest(ref request, ref callSettings);
            return _callGetAnnotationSpecSet.Async(request, callSettings);
        }

        /// <summary>
        /// Lists annotation spec sets for a project. Pagination is supported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AnnotationSpecSet"/> resources.</returns>
        public override gax::PagedEnumerable<ListAnnotationSpecSetsResponse, AnnotationSpecSet> ListAnnotationSpecSets(ListAnnotationSpecSetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAnnotationSpecSetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAnnotationSpecSetsRequest, ListAnnotationSpecSetsResponse, AnnotationSpecSet>(_callListAnnotationSpecSets, request, callSettings);
        }

        /// <summary>
        /// Lists annotation spec sets for a project. Pagination is supported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AnnotationSpecSet"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAnnotationSpecSetsResponse, AnnotationSpecSet> ListAnnotationSpecSetsAsync(ListAnnotationSpecSetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAnnotationSpecSetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAnnotationSpecSetsRequest, ListAnnotationSpecSetsResponse, AnnotationSpecSet>(_callListAnnotationSpecSets, request, callSettings);
        }

        /// <summary>
        /// Deletes an annotation spec set by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteAnnotationSpecSet(DeleteAnnotationSpecSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAnnotationSpecSetRequest(ref request, ref callSettings);
            _callDeleteAnnotationSpecSet.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an annotation spec set by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteAnnotationSpecSetAsync(DeleteAnnotationSpecSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAnnotationSpecSetRequest(ref request, ref callSettings);
            return _callDeleteAnnotationSpecSet.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateInstruction</c>.</summary>
        public override lro::OperationsClient CreateInstructionOperationsClient { get; }

        /// <summary>
        /// Creates an instruction for how data should be labeled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Instruction, CreateInstructionMetadata> CreateInstruction(CreateInstructionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInstructionRequest(ref request, ref callSettings);
            return new lro::Operation<Instruction, CreateInstructionMetadata>(_callCreateInstruction.Sync(request, callSettings), CreateInstructionOperationsClient);
        }

        /// <summary>
        /// Creates an instruction for how data should be labeled.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Instruction, CreateInstructionMetadata>> CreateInstructionAsync(CreateInstructionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInstructionRequest(ref request, ref callSettings);
            return new lro::Operation<Instruction, CreateInstructionMetadata>(await _callCreateInstruction.Async(request, callSettings).ConfigureAwait(false), CreateInstructionOperationsClient);
        }

        /// <summary>
        /// Gets an instruction by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Instruction GetInstruction(GetInstructionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstructionRequest(ref request, ref callSettings);
            return _callGetInstruction.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an instruction by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Instruction> GetInstructionAsync(GetInstructionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInstructionRequest(ref request, ref callSettings);
            return _callGetInstruction.Async(request, callSettings);
        }

        /// <summary>
        /// Lists instructions for a project. Pagination is supported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Instruction"/> resources.</returns>
        public override gax::PagedEnumerable<ListInstructionsResponse, Instruction> ListInstructions(ListInstructionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstructionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListInstructionsRequest, ListInstructionsResponse, Instruction>(_callListInstructions, request, callSettings);
        }

        /// <summary>
        /// Lists instructions for a project. Pagination is supported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Instruction"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListInstructionsResponse, Instruction> ListInstructionsAsync(ListInstructionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInstructionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListInstructionsRequest, ListInstructionsResponse, Instruction>(_callListInstructions, request, callSettings);
        }

        /// <summary>
        /// Deletes an instruction object by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteInstruction(DeleteInstructionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInstructionRequest(ref request, ref callSettings);
            _callDeleteInstruction.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an instruction object by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteInstructionAsync(DeleteInstructionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInstructionRequest(ref request, ref callSettings);
            return _callDeleteInstruction.Async(request, callSettings);
        }

        /// <summary>
        /// Gets an evaluation by resource name (to search, use
        /// [projects.evaluations.search][google.cloud.datalabeling.v1beta1.DataLabelingService.SearchEvaluations]).
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
        /// Gets an evaluation by resource name (to search, use
        /// [projects.evaluations.search][google.cloud.datalabeling.v1beta1.DataLabelingService.SearchEvaluations]).
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
        /// Searches [evaluations][google.cloud.datalabeling.v1beta1.Evaluation] within a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Evaluation"/> resources.</returns>
        public override gax::PagedEnumerable<SearchEvaluationsResponse, Evaluation> SearchEvaluations(SearchEvaluationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchEvaluationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchEvaluationsRequest, SearchEvaluationsResponse, Evaluation>(_callSearchEvaluations, request, callSettings);
        }

        /// <summary>
        /// Searches [evaluations][google.cloud.datalabeling.v1beta1.Evaluation] within a project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Evaluation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchEvaluationsResponse, Evaluation> SearchEvaluationsAsync(SearchEvaluationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchEvaluationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchEvaluationsRequest, SearchEvaluationsResponse, Evaluation>(_callSearchEvaluations, request, callSettings);
        }

        /// <summary>
        /// Searches example comparisons from an evaluation. The return format is a
        /// list of example comparisons that show ground truth and prediction(s) for
        /// a single input. Search by providing an evaluation ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable sequence of <see cref="SearchExampleComparisonsResponse.Types.ExampleComparison"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<SearchExampleComparisonsResponse, SearchExampleComparisonsResponse.Types.ExampleComparison> SearchExampleComparisons(SearchExampleComparisonsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchExampleComparisonsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchExampleComparisonsRequest, SearchExampleComparisonsResponse, SearchExampleComparisonsResponse.Types.ExampleComparison>(_callSearchExampleComparisons, request, callSettings);
        }

        /// <summary>
        /// Searches example comparisons from an evaluation. The return format is a
        /// list of example comparisons that show ground truth and prediction(s) for
        /// a single input. Search by providing an evaluation ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="SearchExampleComparisonsResponse.Types.ExampleComparison"/>
        /// resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<SearchExampleComparisonsResponse, SearchExampleComparisonsResponse.Types.ExampleComparison> SearchExampleComparisonsAsync(SearchExampleComparisonsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchExampleComparisonsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchExampleComparisonsRequest, SearchExampleComparisonsResponse, SearchExampleComparisonsResponse.Types.ExampleComparison>(_callSearchExampleComparisons, request, callSettings);
        }

        /// <summary>
        /// Creates an evaluation job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EvaluationJob CreateEvaluationJob(CreateEvaluationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEvaluationJobRequest(ref request, ref callSettings);
            return _callCreateEvaluationJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an evaluation job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EvaluationJob> CreateEvaluationJobAsync(CreateEvaluationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEvaluationJobRequest(ref request, ref callSettings);
            return _callCreateEvaluationJob.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an evaluation job. You can only update certain fields of the job's
        /// [EvaluationJobConfig][google.cloud.datalabeling.v1beta1.EvaluationJobConfig]: `humanAnnotationConfig.instruction`,
        /// `exampleCount`, and `exampleSamplePercentage`.
        /// 
        /// If you want to change any other aspect of the evaluation job, you must
        /// delete the job and create a new one.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EvaluationJob UpdateEvaluationJob(UpdateEvaluationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEvaluationJobRequest(ref request, ref callSettings);
            return _callUpdateEvaluationJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an evaluation job. You can only update certain fields of the job's
        /// [EvaluationJobConfig][google.cloud.datalabeling.v1beta1.EvaluationJobConfig]: `humanAnnotationConfig.instruction`,
        /// `exampleCount`, and `exampleSamplePercentage`.
        /// 
        /// If you want to change any other aspect of the evaluation job, you must
        /// delete the job and create a new one.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EvaluationJob> UpdateEvaluationJobAsync(UpdateEvaluationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEvaluationJobRequest(ref request, ref callSettings);
            return _callUpdateEvaluationJob.Async(request, callSettings);
        }

        /// <summary>
        /// Gets an evaluation job by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EvaluationJob GetEvaluationJob(GetEvaluationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEvaluationJobRequest(ref request, ref callSettings);
            return _callGetEvaluationJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an evaluation job by resource name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EvaluationJob> GetEvaluationJobAsync(GetEvaluationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEvaluationJobRequest(ref request, ref callSettings);
            return _callGetEvaluationJob.Async(request, callSettings);
        }

        /// <summary>
        /// Pauses an evaluation job. Pausing an evaluation job that is already in a
        /// `PAUSED` state is a no-op.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void PauseEvaluationJob(PauseEvaluationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PauseEvaluationJobRequest(ref request, ref callSettings);
            _callPauseEvaluationJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Pauses an evaluation job. Pausing an evaluation job that is already in a
        /// `PAUSED` state is a no-op.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task PauseEvaluationJobAsync(PauseEvaluationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PauseEvaluationJobRequest(ref request, ref callSettings);
            return _callPauseEvaluationJob.Async(request, callSettings);
        }

        /// <summary>
        /// Resumes a paused evaluation job. A deleted evaluation job can't be resumed.
        /// Resuming a running or scheduled evaluation job is a no-op.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void ResumeEvaluationJob(ResumeEvaluationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResumeEvaluationJobRequest(ref request, ref callSettings);
            _callResumeEvaluationJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Resumes a paused evaluation job. A deleted evaluation job can't be resumed.
        /// Resuming a running or scheduled evaluation job is a no-op.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task ResumeEvaluationJobAsync(ResumeEvaluationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResumeEvaluationJobRequest(ref request, ref callSettings);
            return _callResumeEvaluationJob.Async(request, callSettings);
        }

        /// <summary>
        /// Stops and deletes an evaluation job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteEvaluationJob(DeleteEvaluationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEvaluationJobRequest(ref request, ref callSettings);
            _callDeleteEvaluationJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Stops and deletes an evaluation job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteEvaluationJobAsync(DeleteEvaluationJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEvaluationJobRequest(ref request, ref callSettings);
            return _callDeleteEvaluationJob.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all evaluation jobs within a project with possible filters.
        /// Pagination is supported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EvaluationJob"/> resources.</returns>
        public override gax::PagedEnumerable<ListEvaluationJobsResponse, EvaluationJob> ListEvaluationJobs(ListEvaluationJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEvaluationJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEvaluationJobsRequest, ListEvaluationJobsResponse, EvaluationJob>(_callListEvaluationJobs, request, callSettings);
        }

        /// <summary>
        /// Lists all evaluation jobs within a project with possible filters.
        /// Pagination is supported.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EvaluationJob"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEvaluationJobsResponse, EvaluationJob> ListEvaluationJobsAsync(ListEvaluationJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEvaluationJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEvaluationJobsRequest, ListEvaluationJobsResponse, EvaluationJob>(_callListEvaluationJobs, request, callSettings);
        }
    }

    public partial class ListDatasetsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDataItemsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAnnotatedDatasetsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListExamplesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAnnotationSpecSetsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListInstructionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchEvaluationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchExampleComparisonsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEvaluationJobsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDatasetsResponse : gaxgrpc::IPageResponse<Dataset>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Dataset> GetEnumerator() => Datasets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDataItemsResponse : gaxgrpc::IPageResponse<DataItem>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DataItem> GetEnumerator() => DataItems.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAnnotatedDatasetsResponse : gaxgrpc::IPageResponse<AnnotatedDataset>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AnnotatedDataset> GetEnumerator() => AnnotatedDatasets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListExamplesResponse : gaxgrpc::IPageResponse<Example>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Example> GetEnumerator() => Examples.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAnnotationSpecSetsResponse : gaxgrpc::IPageResponse<AnnotationSpecSet>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AnnotationSpecSet> GetEnumerator() => AnnotationSpecSets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListInstructionsResponse : gaxgrpc::IPageResponse<Instruction>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Instruction> GetEnumerator() => Instructions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchEvaluationsResponse : gaxgrpc::IPageResponse<Evaluation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Evaluation> GetEnumerator() => Evaluations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchExampleComparisonsResponse : gaxgrpc::IPageResponse<SearchExampleComparisonsResponse.Types.ExampleComparison>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Types.ExampleComparison> GetEnumerator() => ExampleComparisons.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListEvaluationJobsResponse : gaxgrpc::IPageResponse<EvaluationJob>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<EvaluationJob> GetEnumerator() => EvaluationJobs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class DataLabelingService
    {
        public partial class DataLabelingServiceClient
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
