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

namespace Google.Cloud.DocumentAI.V1
{
    /// <summary>Settings for <see cref="DocumentProcessorServiceClient"/> instances.</summary>
    public sealed partial class DocumentProcessorServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DocumentProcessorServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DocumentProcessorServiceSettings"/>.</returns>
        public static DocumentProcessorServiceSettings GetDefault() => new DocumentProcessorServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="DocumentProcessorServiceSettings"/> object with default settings.
        /// </summary>
        public DocumentProcessorServiceSettings()
        {
        }

        private DocumentProcessorServiceSettings(DocumentProcessorServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ProcessDocumentSettings = existing.ProcessDocumentSettings;
            BatchProcessDocumentsSettings = existing.BatchProcessDocumentsSettings;
            BatchProcessDocumentsOperationsSettings = existing.BatchProcessDocumentsOperationsSettings.Clone();
            FetchProcessorTypesSettings = existing.FetchProcessorTypesSettings;
            ListProcessorTypesSettings = existing.ListProcessorTypesSettings;
            GetProcessorTypeSettings = existing.GetProcessorTypeSettings;
            ListProcessorsSettings = existing.ListProcessorsSettings;
            GetProcessorSettings = existing.GetProcessorSettings;
            TrainProcessorVersionSettings = existing.TrainProcessorVersionSettings;
            TrainProcessorVersionOperationsSettings = existing.TrainProcessorVersionOperationsSettings.Clone();
            GetProcessorVersionSettings = existing.GetProcessorVersionSettings;
            ListProcessorVersionsSettings = existing.ListProcessorVersionsSettings;
            DeleteProcessorVersionSettings = existing.DeleteProcessorVersionSettings;
            DeleteProcessorVersionOperationsSettings = existing.DeleteProcessorVersionOperationsSettings.Clone();
            DeployProcessorVersionSettings = existing.DeployProcessorVersionSettings;
            DeployProcessorVersionOperationsSettings = existing.DeployProcessorVersionOperationsSettings.Clone();
            UndeployProcessorVersionSettings = existing.UndeployProcessorVersionSettings;
            UndeployProcessorVersionOperationsSettings = existing.UndeployProcessorVersionOperationsSettings.Clone();
            CreateProcessorSettings = existing.CreateProcessorSettings;
            DeleteProcessorSettings = existing.DeleteProcessorSettings;
            DeleteProcessorOperationsSettings = existing.DeleteProcessorOperationsSettings.Clone();
            EnableProcessorSettings = existing.EnableProcessorSettings;
            EnableProcessorOperationsSettings = existing.EnableProcessorOperationsSettings.Clone();
            DisableProcessorSettings = existing.DisableProcessorSettings;
            DisableProcessorOperationsSettings = existing.DisableProcessorOperationsSettings.Clone();
            SetDefaultProcessorVersionSettings = existing.SetDefaultProcessorVersionSettings;
            SetDefaultProcessorVersionOperationsSettings = existing.SetDefaultProcessorVersionOperationsSettings.Clone();
            ReviewDocumentSettings = existing.ReviewDocumentSettings;
            ReviewDocumentOperationsSettings = existing.ReviewDocumentOperationsSettings.Clone();
            EvaluateProcessorVersionSettings = existing.EvaluateProcessorVersionSettings;
            EvaluateProcessorVersionOperationsSettings = existing.EvaluateProcessorVersionOperationsSettings.Clone();
            GetEvaluationSettings = existing.GetEvaluationSettings;
            ListEvaluationsSettings = existing.ListEvaluationsSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DocumentProcessorServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentProcessorServiceClient.ProcessDocument</c> and
        /// <c>DocumentProcessorServiceClient.ProcessDocumentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 9</description></item>
        /// <item><description>Retry maximum delay: 90000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.ResourceExhausted"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ProcessDocumentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(90000), backoffMultiplier: 9, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentProcessorServiceClient.BatchProcessDocuments</c> and
        /// <c>DocumentProcessorServiceClient.BatchProcessDocumentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.5</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings BatchProcessDocumentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.5, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DocumentProcessorServiceClient.BatchProcessDocuments</c> and
        /// <c>DocumentProcessorServiceClient.BatchProcessDocumentsAsync</c>.
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
        public lro::OperationsSettings BatchProcessDocumentsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentProcessorServiceClient.FetchProcessorTypes</c> and
        /// <c>DocumentProcessorServiceClient.FetchProcessorTypesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FetchProcessorTypesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentProcessorServiceClient.ListProcessorTypes</c> and
        /// <c>DocumentProcessorServiceClient.ListProcessorTypesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListProcessorTypesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentProcessorServiceClient.GetProcessorType</c> and
        /// <c>DocumentProcessorServiceClient.GetProcessorTypeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetProcessorTypeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentProcessorServiceClient.ListProcessors</c> and
        /// <c>DocumentProcessorServiceClient.ListProcessorsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListProcessorsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentProcessorServiceClient.GetProcessor</c> and <c>DocumentProcessorServiceClient.GetProcessorAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetProcessorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentProcessorServiceClient.TrainProcessorVersion</c> and
        /// <c>DocumentProcessorServiceClient.TrainProcessorVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TrainProcessorVersionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DocumentProcessorServiceClient.TrainProcessorVersion</c> and
        /// <c>DocumentProcessorServiceClient.TrainProcessorVersionAsync</c>.
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
        public lro::OperationsSettings TrainProcessorVersionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentProcessorServiceClient.GetProcessorVersion</c> and
        /// <c>DocumentProcessorServiceClient.GetProcessorVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetProcessorVersionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentProcessorServiceClient.ListProcessorVersions</c> and
        /// <c>DocumentProcessorServiceClient.ListProcessorVersionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListProcessorVersionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentProcessorServiceClient.DeleteProcessorVersion</c> and
        /// <c>DocumentProcessorServiceClient.DeleteProcessorVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteProcessorVersionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DocumentProcessorServiceClient.DeleteProcessorVersion</c>
        /// and <c>DocumentProcessorServiceClient.DeleteProcessorVersionAsync</c>.
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
        public lro::OperationsSettings DeleteProcessorVersionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentProcessorServiceClient.DeployProcessorVersion</c> and
        /// <c>DocumentProcessorServiceClient.DeployProcessorVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeployProcessorVersionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DocumentProcessorServiceClient.DeployProcessorVersion</c>
        /// and <c>DocumentProcessorServiceClient.DeployProcessorVersionAsync</c>.
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
        public lro::OperationsSettings DeployProcessorVersionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentProcessorServiceClient.UndeployProcessorVersion</c> and
        /// <c>DocumentProcessorServiceClient.UndeployProcessorVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UndeployProcessorVersionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DocumentProcessorServiceClient.UndeployProcessorVersion</c>
        /// and <c>DocumentProcessorServiceClient.UndeployProcessorVersionAsync</c>.
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
        public lro::OperationsSettings UndeployProcessorVersionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentProcessorServiceClient.CreateProcessor</c> and
        /// <c>DocumentProcessorServiceClient.CreateProcessorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateProcessorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentProcessorServiceClient.DeleteProcessor</c> and
        /// <c>DocumentProcessorServiceClient.DeleteProcessorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteProcessorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DocumentProcessorServiceClient.DeleteProcessor</c> and
        /// <c>DocumentProcessorServiceClient.DeleteProcessorAsync</c>.
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
        public lro::OperationsSettings DeleteProcessorOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentProcessorServiceClient.EnableProcessor</c> and
        /// <c>DocumentProcessorServiceClient.EnableProcessorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings EnableProcessorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DocumentProcessorServiceClient.EnableProcessor</c> and
        /// <c>DocumentProcessorServiceClient.EnableProcessorAsync</c>.
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
        public lro::OperationsSettings EnableProcessorOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentProcessorServiceClient.DisableProcessor</c> and
        /// <c>DocumentProcessorServiceClient.DisableProcessorAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DisableProcessorSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DocumentProcessorServiceClient.DisableProcessor</c> and
        /// <c>DocumentProcessorServiceClient.DisableProcessorAsync</c>.
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
        public lro::OperationsSettings DisableProcessorOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentProcessorServiceClient.SetDefaultProcessorVersion</c> and
        /// <c>DocumentProcessorServiceClient.SetDefaultProcessorVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SetDefaultProcessorVersionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DocumentProcessorServiceClient.SetDefaultProcessorVersion</c>
        ///  and <c>DocumentProcessorServiceClient.SetDefaultProcessorVersionAsync</c>.
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
        public lro::OperationsSettings SetDefaultProcessorVersionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentProcessorServiceClient.ReviewDocument</c> and
        /// <c>DocumentProcessorServiceClient.ReviewDocumentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.5</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.DeadlineExceeded"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReviewDocumentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.5, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DocumentProcessorServiceClient.ReviewDocument</c> and
        /// <c>DocumentProcessorServiceClient.ReviewDocumentAsync</c>.
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
        public lro::OperationsSettings ReviewDocumentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentProcessorServiceClient.EvaluateProcessorVersion</c> and
        /// <c>DocumentProcessorServiceClient.EvaluateProcessorVersionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings EvaluateProcessorVersionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DocumentProcessorServiceClient.EvaluateProcessorVersion</c>
        /// and <c>DocumentProcessorServiceClient.EvaluateProcessorVersionAsync</c>.
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
        public lro::OperationsSettings EvaluateProcessorVersionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentProcessorServiceClient.GetEvaluation</c> and <c>DocumentProcessorServiceClient.GetEvaluationAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEvaluationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DocumentProcessorServiceClient.ListEvaluations</c> and
        /// <c>DocumentProcessorServiceClient.ListEvaluationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEvaluationsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DocumentProcessorServiceSettings"/> object.</returns>
        public DocumentProcessorServiceSettings Clone() => new DocumentProcessorServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DocumentProcessorServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class DocumentProcessorServiceClientBuilder : gaxgrpc::ClientBuilderBase<DocumentProcessorServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DocumentProcessorServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DocumentProcessorServiceClientBuilder() : base(DocumentProcessorServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DocumentProcessorServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DocumentProcessorServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DocumentProcessorServiceClient Build()
        {
            DocumentProcessorServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DocumentProcessorServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DocumentProcessorServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DocumentProcessorServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DocumentProcessorServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DocumentProcessorServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DocumentProcessorServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DocumentProcessorServiceClient.ChannelPool;
    }

    /// <summary>DocumentProcessorService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to call Document AI to process documents according to the
    /// processor's definition. Processors are built using state-of-the-art Google
    /// AI such as natural language, computer vision, and translation to extract
    /// structured information from unstructured or semi-structured documents.
    /// </remarks>
    public abstract partial class DocumentProcessorServiceClient
    {
        /// <summary>
        /// The default endpoint for the DocumentProcessorService service, which is a host of
        /// "documentai.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "documentai.googleapis.com:443";

        /// <summary>The default DocumentProcessorService scopes.</summary>
        /// <remarks>
        /// The default DocumentProcessorService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DocumentProcessorService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DocumentProcessorServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="DocumentProcessorServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DocumentProcessorServiceClient"/>.</returns>
        public static stt::Task<DocumentProcessorServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DocumentProcessorServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DocumentProcessorServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="DocumentProcessorServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DocumentProcessorServiceClient"/>.</returns>
        public static DocumentProcessorServiceClient Create() => new DocumentProcessorServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DocumentProcessorServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DocumentProcessorServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DocumentProcessorServiceClient"/>.</returns>
        internal static DocumentProcessorServiceClient Create(grpccore::CallInvoker callInvoker, DocumentProcessorServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DocumentProcessorService.DocumentProcessorServiceClient grpcClient = new DocumentProcessorService.DocumentProcessorServiceClient(callInvoker);
            return new DocumentProcessorServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DocumentProcessorService client</summary>
        public virtual DocumentProcessorService.DocumentProcessorServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Processes a single document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProcessResponse ProcessDocument(ProcessRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Processes a single document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProcessResponse> ProcessDocumentAsync(ProcessRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Processes a single document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProcessResponse> ProcessDocumentAsync(ProcessRequest request, st::CancellationToken cancellationToken) =>
            ProcessDocumentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Processes a single document.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [Processor][google.cloud.documentai.v1.Processor] or
        /// [ProcessorVersion][google.cloud.documentai.v1.ProcessorVersion]
        /// to use for processing. If a
        /// [Processor][google.cloud.documentai.v1.Processor] is specified, the server
        /// will use its [default
        /// version][google.cloud.documentai.v1.Processor.default_processor_version].
        /// Format: `projects/{project}/locations/{location}/processors/{processor}`,
        /// or
        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProcessResponse ProcessDocument(string name, gaxgrpc::CallSettings callSettings = null) =>
            ProcessDocument(new ProcessRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Processes a single document.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [Processor][google.cloud.documentai.v1.Processor] or
        /// [ProcessorVersion][google.cloud.documentai.v1.ProcessorVersion]
        /// to use for processing. If a
        /// [Processor][google.cloud.documentai.v1.Processor] is specified, the server
        /// will use its [default
        /// version][google.cloud.documentai.v1.Processor.default_processor_version].
        /// Format: `projects/{project}/locations/{location}/processors/{processor}`,
        /// or
        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProcessResponse> ProcessDocumentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ProcessDocumentAsync(new ProcessRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Processes a single document.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [Processor][google.cloud.documentai.v1.Processor] or
        /// [ProcessorVersion][google.cloud.documentai.v1.ProcessorVersion]
        /// to use for processing. If a
        /// [Processor][google.cloud.documentai.v1.Processor] is specified, the server
        /// will use its [default
        /// version][google.cloud.documentai.v1.Processor.default_processor_version].
        /// Format: `projects/{project}/locations/{location}/processors/{processor}`,
        /// or
        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProcessResponse> ProcessDocumentAsync(string name, st::CancellationToken cancellationToken) =>
            ProcessDocumentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Processes a single document.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [Processor][google.cloud.documentai.v1.Processor] or
        /// [ProcessorVersion][google.cloud.documentai.v1.ProcessorVersion]
        /// to use for processing. If a
        /// [Processor][google.cloud.documentai.v1.Processor] is specified, the server
        /// will use its [default
        /// version][google.cloud.documentai.v1.Processor.default_processor_version].
        /// Format: `projects/{project}/locations/{location}/processors/{processor}`,
        /// or
        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProcessResponse ProcessDocument(gax::IResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            ProcessDocument(new ProcessRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Processes a single document.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [Processor][google.cloud.documentai.v1.Processor] or
        /// [ProcessorVersion][google.cloud.documentai.v1.ProcessorVersion]
        /// to use for processing. If a
        /// [Processor][google.cloud.documentai.v1.Processor] is specified, the server
        /// will use its [default
        /// version][google.cloud.documentai.v1.Processor.default_processor_version].
        /// Format: `projects/{project}/locations/{location}/processors/{processor}`,
        /// or
        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProcessResponse> ProcessDocumentAsync(gax::IResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            ProcessDocumentAsync(new ProcessRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Processes a single document.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [Processor][google.cloud.documentai.v1.Processor] or
        /// [ProcessorVersion][google.cloud.documentai.v1.ProcessorVersion]
        /// to use for processing. If a
        /// [Processor][google.cloud.documentai.v1.Processor] is specified, the server
        /// will use its [default
        /// version][google.cloud.documentai.v1.Processor.default_processor_version].
        /// Format: `projects/{project}/locations/{location}/processors/{processor}`,
        /// or
        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProcessResponse> ProcessDocumentAsync(gax::IResourceName name, st::CancellationToken cancellationToken) =>
            ProcessDocumentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// LRO endpoint to batch process many documents. The output is written
        /// to Cloud Storage as JSON in the [Document] format.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchProcessResponse, BatchProcessMetadata> BatchProcessDocuments(BatchProcessRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// LRO endpoint to batch process many documents. The output is written
        /// to Cloud Storage as JSON in the [Document] format.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchProcessResponse, BatchProcessMetadata>> BatchProcessDocumentsAsync(BatchProcessRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// LRO endpoint to batch process many documents. The output is written
        /// to Cloud Storage as JSON in the [Document] format.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchProcessResponse, BatchProcessMetadata>> BatchProcessDocumentsAsync(BatchProcessRequest request, st::CancellationToken cancellationToken) =>
            BatchProcessDocumentsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>BatchProcessDocuments</c>.</summary>
        public virtual lro::OperationsClient BatchProcessDocumentsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchProcessDocuments</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BatchProcessResponse, BatchProcessMetadata> PollOnceBatchProcessDocuments(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchProcessResponse, BatchProcessMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchProcessDocumentsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>BatchProcessDocuments</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BatchProcessResponse, BatchProcessMetadata>> PollOnceBatchProcessDocumentsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<BatchProcessResponse, BatchProcessMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), BatchProcessDocumentsOperationsClient, callSettings);

        /// <summary>
        /// LRO endpoint to batch process many documents. The output is written
        /// to Cloud Storage as JSON in the [Document] format.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of
        /// [Processor][google.cloud.documentai.v1.Processor] or
        /// [ProcessorVersion][google.cloud.documentai.v1.ProcessorVersion].
        /// Format: `projects/{project}/locations/{location}/processors/{processor}`,
        /// or
        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchProcessResponse, BatchProcessMetadata> BatchProcessDocuments(string name, gaxgrpc::CallSettings callSettings = null) =>
            BatchProcessDocuments(new BatchProcessRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// LRO endpoint to batch process many documents. The output is written
        /// to Cloud Storage as JSON in the [Document] format.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of
        /// [Processor][google.cloud.documentai.v1.Processor] or
        /// [ProcessorVersion][google.cloud.documentai.v1.ProcessorVersion].
        /// Format: `projects/{project}/locations/{location}/processors/{processor}`,
        /// or
        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchProcessResponse, BatchProcessMetadata>> BatchProcessDocumentsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            BatchProcessDocumentsAsync(new BatchProcessRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// LRO endpoint to batch process many documents. The output is written
        /// to Cloud Storage as JSON in the [Document] format.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of
        /// [Processor][google.cloud.documentai.v1.Processor] or
        /// [ProcessorVersion][google.cloud.documentai.v1.ProcessorVersion].
        /// Format: `projects/{project}/locations/{location}/processors/{processor}`,
        /// or
        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchProcessResponse, BatchProcessMetadata>> BatchProcessDocumentsAsync(string name, st::CancellationToken cancellationToken) =>
            BatchProcessDocumentsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// LRO endpoint to batch process many documents. The output is written
        /// to Cloud Storage as JSON in the [Document] format.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of
        /// [Processor][google.cloud.documentai.v1.Processor] or
        /// [ProcessorVersion][google.cloud.documentai.v1.ProcessorVersion].
        /// Format: `projects/{project}/locations/{location}/processors/{processor}`,
        /// or
        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<BatchProcessResponse, BatchProcessMetadata> BatchProcessDocuments(gax::IResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            BatchProcessDocuments(new BatchProcessRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// LRO endpoint to batch process many documents. The output is written
        /// to Cloud Storage as JSON in the [Document] format.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of
        /// [Processor][google.cloud.documentai.v1.Processor] or
        /// [ProcessorVersion][google.cloud.documentai.v1.ProcessorVersion].
        /// Format: `projects/{project}/locations/{location}/processors/{processor}`,
        /// or
        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchProcessResponse, BatchProcessMetadata>> BatchProcessDocumentsAsync(gax::IResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            BatchProcessDocumentsAsync(new BatchProcessRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// LRO endpoint to batch process many documents. The output is written
        /// to Cloud Storage as JSON in the [Document] format.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of
        /// [Processor][google.cloud.documentai.v1.Processor] or
        /// [ProcessorVersion][google.cloud.documentai.v1.ProcessorVersion].
        /// Format: `projects/{project}/locations/{location}/processors/{processor}`,
        /// or
        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<BatchProcessResponse, BatchProcessMetadata>> BatchProcessDocumentsAsync(gax::IResourceName name, st::CancellationToken cancellationToken) =>
            BatchProcessDocumentsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches processor types. Note that we don't use
        /// [ListProcessorTypes][google.cloud.documentai.v1.DocumentProcessorService.ListProcessorTypes]
        /// here, because it isn't paginated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchProcessorTypesResponse FetchProcessorTypes(FetchProcessorTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches processor types. Note that we don't use
        /// [ListProcessorTypes][google.cloud.documentai.v1.DocumentProcessorService.ListProcessorTypes]
        /// here, because it isn't paginated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchProcessorTypesResponse> FetchProcessorTypesAsync(FetchProcessorTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches processor types. Note that we don't use
        /// [ListProcessorTypes][google.cloud.documentai.v1.DocumentProcessorService.ListProcessorTypes]
        /// here, because it isn't paginated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchProcessorTypesResponse> FetchProcessorTypesAsync(FetchProcessorTypesRequest request, st::CancellationToken cancellationToken) =>
            FetchProcessorTypesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches processor types. Note that we don't use
        /// [ListProcessorTypes][google.cloud.documentai.v1.DocumentProcessorService.ListProcessorTypes]
        /// here, because it isn't paginated.
        /// </summary>
        /// <param name="parent">
        /// Required. The location of processor types to list.
        /// Format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchProcessorTypesResponse FetchProcessorTypes(string parent, gaxgrpc::CallSettings callSettings = null) =>
            FetchProcessorTypes(new FetchProcessorTypesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Fetches processor types. Note that we don't use
        /// [ListProcessorTypes][google.cloud.documentai.v1.DocumentProcessorService.ListProcessorTypes]
        /// here, because it isn't paginated.
        /// </summary>
        /// <param name="parent">
        /// Required. The location of processor types to list.
        /// Format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchProcessorTypesResponse> FetchProcessorTypesAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            FetchProcessorTypesAsync(new FetchProcessorTypesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Fetches processor types. Note that we don't use
        /// [ListProcessorTypes][google.cloud.documentai.v1.DocumentProcessorService.ListProcessorTypes]
        /// here, because it isn't paginated.
        /// </summary>
        /// <param name="parent">
        /// Required. The location of processor types to list.
        /// Format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchProcessorTypesResponse> FetchProcessorTypesAsync(string parent, st::CancellationToken cancellationToken) =>
            FetchProcessorTypesAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches processor types. Note that we don't use
        /// [ListProcessorTypes][google.cloud.documentai.v1.DocumentProcessorService.ListProcessorTypes]
        /// here, because it isn't paginated.
        /// </summary>
        /// <param name="parent">
        /// Required. The location of processor types to list.
        /// Format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchProcessorTypesResponse FetchProcessorTypes(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            FetchProcessorTypes(new FetchProcessorTypesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Fetches processor types. Note that we don't use
        /// [ListProcessorTypes][google.cloud.documentai.v1.DocumentProcessorService.ListProcessorTypes]
        /// here, because it isn't paginated.
        /// </summary>
        /// <param name="parent">
        /// Required. The location of processor types to list.
        /// Format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchProcessorTypesResponse> FetchProcessorTypesAsync(gagr::LocationName parent, gaxgrpc::CallSettings callSettings = null) =>
            FetchProcessorTypesAsync(new FetchProcessorTypesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            }, callSettings);

        /// <summary>
        /// Fetches processor types. Note that we don't use
        /// [ListProcessorTypes][google.cloud.documentai.v1.DocumentProcessorService.ListProcessorTypes]
        /// here, because it isn't paginated.
        /// </summary>
        /// <param name="parent">
        /// Required. The location of processor types to list.
        /// Format: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchProcessorTypesResponse> FetchProcessorTypesAsync(gagr::LocationName parent, st::CancellationToken cancellationToken) =>
            FetchProcessorTypesAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the processor types that exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ProcessorType"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProcessorTypesResponse, ProcessorType> ListProcessorTypes(ListProcessorTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the processor types that exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ProcessorType"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProcessorTypesResponse, ProcessorType> ListProcessorTypesAsync(ListProcessorTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the processor types that exist.
        /// </summary>
        /// <param name="parent">
        /// Required. The location of processor types to list.
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
        /// <returns>A pageable sequence of <see cref="ProcessorType"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProcessorTypesResponse, ProcessorType> ListProcessorTypes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProcessorTypesRequest request = new ListProcessorTypesRequest
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
            return ListProcessorTypes(request, callSettings);
        }

        /// <summary>
        /// Lists the processor types that exist.
        /// </summary>
        /// <param name="parent">
        /// Required. The location of processor types to list.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ProcessorType"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProcessorTypesResponse, ProcessorType> ListProcessorTypesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProcessorTypesRequest request = new ListProcessorTypesRequest
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
            return ListProcessorTypesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the processor types that exist.
        /// </summary>
        /// <param name="parent">
        /// Required. The location of processor types to list.
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
        /// <returns>A pageable sequence of <see cref="ProcessorType"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProcessorTypesResponse, ProcessorType> ListProcessorTypes(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProcessorTypesRequest request = new ListProcessorTypesRequest
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
            return ListProcessorTypes(request, callSettings);
        }

        /// <summary>
        /// Lists the processor types that exist.
        /// </summary>
        /// <param name="parent">
        /// Required. The location of processor types to list.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ProcessorType"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProcessorTypesResponse, ProcessorType> ListProcessorTypesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProcessorTypesRequest request = new ListProcessorTypesRequest
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
            return ListProcessorTypesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a processor type detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProcessorType GetProcessorType(GetProcessorTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a processor type detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProcessorType> GetProcessorTypeAsync(GetProcessorTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a processor type detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProcessorType> GetProcessorTypeAsync(GetProcessorTypeRequest request, st::CancellationToken cancellationToken) =>
            GetProcessorTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a processor type detail.
        /// </summary>
        /// <param name="name">
        /// Required. The processor type resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProcessorType GetProcessorType(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProcessorType(new GetProcessorTypeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a processor type detail.
        /// </summary>
        /// <param name="name">
        /// Required. The processor type resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProcessorType> GetProcessorTypeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProcessorTypeAsync(new GetProcessorTypeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a processor type detail.
        /// </summary>
        /// <param name="name">
        /// Required. The processor type resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProcessorType> GetProcessorTypeAsync(string name, st::CancellationToken cancellationToken) =>
            GetProcessorTypeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a processor type detail.
        /// </summary>
        /// <param name="name">
        /// Required. The processor type resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProcessorType GetProcessorType(ProcessorTypeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProcessorType(new GetProcessorTypeRequest
            {
                ProcessorTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a processor type detail.
        /// </summary>
        /// <param name="name">
        /// Required. The processor type resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProcessorType> GetProcessorTypeAsync(ProcessorTypeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProcessorTypeAsync(new GetProcessorTypeRequest
            {
                ProcessorTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a processor type detail.
        /// </summary>
        /// <param name="name">
        /// Required. The processor type resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProcessorType> GetProcessorTypeAsync(ProcessorTypeName name, st::CancellationToken cancellationToken) =>
            GetProcessorTypeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all processors which belong to this project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Processor"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProcessorsResponse, Processor> ListProcessors(ListProcessorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all processors which belong to this project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Processor"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProcessorsResponse, Processor> ListProcessorsAsync(ListProcessorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all processors which belong to this project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) which owns this collection of
        /// Processors. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="Processor"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProcessorsResponse, Processor> ListProcessors(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProcessorsRequest request = new ListProcessorsRequest
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
            return ListProcessors(request, callSettings);
        }

        /// <summary>
        /// Lists all processors which belong to this project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) which owns this collection of
        /// Processors. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Processor"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProcessorsResponse, Processor> ListProcessorsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProcessorsRequest request = new ListProcessorsRequest
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
            return ListProcessorsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all processors which belong to this project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) which owns this collection of
        /// Processors. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="Processor"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProcessorsResponse, Processor> ListProcessors(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProcessorsRequest request = new ListProcessorsRequest
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
            return ListProcessors(request, callSettings);
        }

        /// <summary>
        /// Lists all processors which belong to this project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) which owns this collection of
        /// Processors. Format: `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Processor"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProcessorsResponse, Processor> ListProcessorsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProcessorsRequest request = new ListProcessorsRequest
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
            return ListProcessorsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a processor detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Processor GetProcessor(GetProcessorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a processor detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Processor> GetProcessorAsync(GetProcessorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a processor detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Processor> GetProcessorAsync(GetProcessorRequest request, st::CancellationToken cancellationToken) =>
            GetProcessorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a processor detail.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Processor GetProcessor(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProcessor(new GetProcessorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a processor detail.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Processor> GetProcessorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProcessorAsync(new GetProcessorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a processor detail.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Processor> GetProcessorAsync(string name, st::CancellationToken cancellationToken) =>
            GetProcessorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a processor detail.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Processor GetProcessor(ProcessorName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProcessor(new GetProcessorRequest
            {
                ProcessorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a processor detail.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Processor> GetProcessorAsync(ProcessorName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProcessorAsync(new GetProcessorRequest
            {
                ProcessorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a processor detail.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Processor> GetProcessorAsync(ProcessorName name, st::CancellationToken cancellationToken) =>
            GetProcessorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Trains a new processor version.
        /// Operation metadata is returned as
        /// [TrainProcessorVersionMetadata][google.cloud.documentai.v1.TrainProcessorVersionMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TrainProcessorVersionResponse, TrainProcessorVersionMetadata> TrainProcessorVersion(TrainProcessorVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Trains a new processor version.
        /// Operation metadata is returned as
        /// [TrainProcessorVersionMetadata][google.cloud.documentai.v1.TrainProcessorVersionMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TrainProcessorVersionResponse, TrainProcessorVersionMetadata>> TrainProcessorVersionAsync(TrainProcessorVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Trains a new processor version.
        /// Operation metadata is returned as
        /// [TrainProcessorVersionMetadata][google.cloud.documentai.v1.TrainProcessorVersionMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TrainProcessorVersionResponse, TrainProcessorVersionMetadata>> TrainProcessorVersionAsync(TrainProcessorVersionRequest request, st::CancellationToken cancellationToken) =>
            TrainProcessorVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>TrainProcessorVersion</c>.</summary>
        public virtual lro::OperationsClient TrainProcessorVersionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>TrainProcessorVersion</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<TrainProcessorVersionResponse, TrainProcessorVersionMetadata> PollOnceTrainProcessorVersion(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TrainProcessorVersionResponse, TrainProcessorVersionMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), TrainProcessorVersionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>TrainProcessorVersion</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<TrainProcessorVersionResponse, TrainProcessorVersionMetadata>> PollOnceTrainProcessorVersionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TrainProcessorVersionResponse, TrainProcessorVersionMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), TrainProcessorVersionOperationsClient, callSettings);

        /// <summary>
        /// Trains a new processor version.
        /// Operation metadata is returned as
        /// [TrainProcessorVersionMetadata][google.cloud.documentai.v1.TrainProcessorVersionMetadata].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project, location and processor) to create the new
        /// version for. Format:
        /// `projects/{project}/locations/{location}/processors/{processor}`.
        /// </param>
        /// <param name="processorVersion">
        /// Required. The processor version to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TrainProcessorVersionResponse, TrainProcessorVersionMetadata> TrainProcessorVersion(string parent, ProcessorVersion processorVersion, gaxgrpc::CallSettings callSettings = null) =>
            TrainProcessorVersion(new TrainProcessorVersionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ProcessorVersion = gax::GaxPreconditions.CheckNotNull(processorVersion, nameof(processorVersion)),
            }, callSettings);

        /// <summary>
        /// Trains a new processor version.
        /// Operation metadata is returned as
        /// [TrainProcessorVersionMetadata][google.cloud.documentai.v1.TrainProcessorVersionMetadata].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project, location and processor) to create the new
        /// version for. Format:
        /// `projects/{project}/locations/{location}/processors/{processor}`.
        /// </param>
        /// <param name="processorVersion">
        /// Required. The processor version to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TrainProcessorVersionResponse, TrainProcessorVersionMetadata>> TrainProcessorVersionAsync(string parent, ProcessorVersion processorVersion, gaxgrpc::CallSettings callSettings = null) =>
            TrainProcessorVersionAsync(new TrainProcessorVersionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ProcessorVersion = gax::GaxPreconditions.CheckNotNull(processorVersion, nameof(processorVersion)),
            }, callSettings);

        /// <summary>
        /// Trains a new processor version.
        /// Operation metadata is returned as
        /// [TrainProcessorVersionMetadata][google.cloud.documentai.v1.TrainProcessorVersionMetadata].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project, location and processor) to create the new
        /// version for. Format:
        /// `projects/{project}/locations/{location}/processors/{processor}`.
        /// </param>
        /// <param name="processorVersion">
        /// Required. The processor version to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TrainProcessorVersionResponse, TrainProcessorVersionMetadata>> TrainProcessorVersionAsync(string parent, ProcessorVersion processorVersion, st::CancellationToken cancellationToken) =>
            TrainProcessorVersionAsync(parent, processorVersion, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Trains a new processor version.
        /// Operation metadata is returned as
        /// [TrainProcessorVersionMetadata][google.cloud.documentai.v1.TrainProcessorVersionMetadata].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project, location and processor) to create the new
        /// version for. Format:
        /// `projects/{project}/locations/{location}/processors/{processor}`.
        /// </param>
        /// <param name="processorVersion">
        /// Required. The processor version to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TrainProcessorVersionResponse, TrainProcessorVersionMetadata> TrainProcessorVersion(ProcessorName parent, ProcessorVersion processorVersion, gaxgrpc::CallSettings callSettings = null) =>
            TrainProcessorVersion(new TrainProcessorVersionRequest
            {
                ParentAsProcessorName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ProcessorVersion = gax::GaxPreconditions.CheckNotNull(processorVersion, nameof(processorVersion)),
            }, callSettings);

        /// <summary>
        /// Trains a new processor version.
        /// Operation metadata is returned as
        /// [TrainProcessorVersionMetadata][google.cloud.documentai.v1.TrainProcessorVersionMetadata].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project, location and processor) to create the new
        /// version for. Format:
        /// `projects/{project}/locations/{location}/processors/{processor}`.
        /// </param>
        /// <param name="processorVersion">
        /// Required. The processor version to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TrainProcessorVersionResponse, TrainProcessorVersionMetadata>> TrainProcessorVersionAsync(ProcessorName parent, ProcessorVersion processorVersion, gaxgrpc::CallSettings callSettings = null) =>
            TrainProcessorVersionAsync(new TrainProcessorVersionRequest
            {
                ParentAsProcessorName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ProcessorVersion = gax::GaxPreconditions.CheckNotNull(processorVersion, nameof(processorVersion)),
            }, callSettings);

        /// <summary>
        /// Trains a new processor version.
        /// Operation metadata is returned as
        /// [TrainProcessorVersionMetadata][google.cloud.documentai.v1.TrainProcessorVersionMetadata].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project, location and processor) to create the new
        /// version for. Format:
        /// `projects/{project}/locations/{location}/processors/{processor}`.
        /// </param>
        /// <param name="processorVersion">
        /// Required. The processor version to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TrainProcessorVersionResponse, TrainProcessorVersionMetadata>> TrainProcessorVersionAsync(ProcessorName parent, ProcessorVersion processorVersion, st::CancellationToken cancellationToken) =>
            TrainProcessorVersionAsync(parent, processorVersion, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a processor version detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProcessorVersion GetProcessorVersion(GetProcessorVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a processor version detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProcessorVersion> GetProcessorVersionAsync(GetProcessorVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a processor version detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProcessorVersion> GetProcessorVersionAsync(GetProcessorVersionRequest request, st::CancellationToken cancellationToken) =>
            GetProcessorVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a processor version detail.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProcessorVersion GetProcessorVersion(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProcessorVersion(new GetProcessorVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a processor version detail.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProcessorVersion> GetProcessorVersionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProcessorVersionAsync(new GetProcessorVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a processor version detail.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProcessorVersion> GetProcessorVersionAsync(string name, st::CancellationToken cancellationToken) =>
            GetProcessorVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a processor version detail.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProcessorVersion GetProcessorVersion(ProcessorVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProcessorVersion(new GetProcessorVersionRequest
            {
                ProcessorVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a processor version detail.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProcessorVersion> GetProcessorVersionAsync(ProcessorVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProcessorVersionAsync(new GetProcessorVersionRequest
            {
                ProcessorVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a processor version detail.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProcessorVersion> GetProcessorVersionAsync(ProcessorVersionName name, st::CancellationToken cancellationToken) =>
            GetProcessorVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all versions of a processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ProcessorVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProcessorVersionsResponse, ProcessorVersion> ListProcessorVersions(ListProcessorVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all versions of a processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ProcessorVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProcessorVersionsResponse, ProcessorVersion> ListProcessorVersionsAsync(ListProcessorVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all versions of a processor.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project, location and processor) to list all
        /// versions. Format:
        /// `projects/{project}/locations/{location}/processors/{processor}`
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
        /// <returns>A pageable sequence of <see cref="ProcessorVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProcessorVersionsResponse, ProcessorVersion> ListProcessorVersions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProcessorVersionsRequest request = new ListProcessorVersionsRequest
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
            return ListProcessorVersions(request, callSettings);
        }

        /// <summary>
        /// Lists all versions of a processor.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project, location and processor) to list all
        /// versions. Format:
        /// `projects/{project}/locations/{location}/processors/{processor}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ProcessorVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProcessorVersionsResponse, ProcessorVersion> ListProcessorVersionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProcessorVersionsRequest request = new ListProcessorVersionsRequest
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
            return ListProcessorVersionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all versions of a processor.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project, location and processor) to list all
        /// versions. Format:
        /// `projects/{project}/locations/{location}/processors/{processor}`
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
        /// <returns>A pageable sequence of <see cref="ProcessorVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProcessorVersionsResponse, ProcessorVersion> ListProcessorVersions(ProcessorName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProcessorVersionsRequest request = new ListProcessorVersionsRequest
            {
                ParentAsProcessorName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListProcessorVersions(request, callSettings);
        }

        /// <summary>
        /// Lists all versions of a processor.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project, location and processor) to list all
        /// versions. Format:
        /// `projects/{project}/locations/{location}/processors/{processor}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="ProcessorVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProcessorVersionsResponse, ProcessorVersion> ListProcessorVersionsAsync(ProcessorName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProcessorVersionsRequest request = new ListProcessorVersionsRequest
            {
                ParentAsProcessorName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListProcessorVersionsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes the processor version, all artifacts under the processor version
        /// will be deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteProcessorVersionMetadata> DeleteProcessorVersion(DeleteProcessorVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the processor version, all artifacts under the processor version
        /// will be deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteProcessorVersionMetadata>> DeleteProcessorVersionAsync(DeleteProcessorVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the processor version, all artifacts under the processor version
        /// will be deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteProcessorVersionMetadata>> DeleteProcessorVersionAsync(DeleteProcessorVersionRequest request, st::CancellationToken cancellationToken) =>
            DeleteProcessorVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteProcessorVersion</c>.</summary>
        public virtual lro::OperationsClient DeleteProcessorVersionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteProcessorVersion</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteProcessorVersionMetadata> PollOnceDeleteProcessorVersion(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteProcessorVersionMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteProcessorVersionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteProcessorVersion</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteProcessorVersionMetadata>> PollOnceDeleteProcessorVersionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteProcessorVersionMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteProcessorVersionOperationsClient, callSettings);

        /// <summary>
        /// Deletes the processor version, all artifacts under the processor version
        /// will be deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The processor version resource name to be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteProcessorVersionMetadata> DeleteProcessorVersion(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProcessorVersion(new DeleteProcessorVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the processor version, all artifacts under the processor version
        /// will be deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The processor version resource name to be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteProcessorVersionMetadata>> DeleteProcessorVersionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProcessorVersionAsync(new DeleteProcessorVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the processor version, all artifacts under the processor version
        /// will be deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The processor version resource name to be deleted.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteProcessorVersionMetadata>> DeleteProcessorVersionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteProcessorVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the processor version, all artifacts under the processor version
        /// will be deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The processor version resource name to be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteProcessorVersionMetadata> DeleteProcessorVersion(ProcessorVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProcessorVersion(new DeleteProcessorVersionRequest
            {
                ProcessorVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the processor version, all artifacts under the processor version
        /// will be deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The processor version resource name to be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteProcessorVersionMetadata>> DeleteProcessorVersionAsync(ProcessorVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProcessorVersionAsync(new DeleteProcessorVersionRequest
            {
                ProcessorVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the processor version, all artifacts under the processor version
        /// will be deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The processor version resource name to be deleted.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteProcessorVersionMetadata>> DeleteProcessorVersionAsync(ProcessorVersionName name, st::CancellationToken cancellationToken) =>
            DeleteProcessorVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deploys the processor version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeployProcessorVersionResponse, DeployProcessorVersionMetadata> DeployProcessorVersion(DeployProcessorVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deploys the processor version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployProcessorVersionResponse, DeployProcessorVersionMetadata>> DeployProcessorVersionAsync(DeployProcessorVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deploys the processor version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployProcessorVersionResponse, DeployProcessorVersionMetadata>> DeployProcessorVersionAsync(DeployProcessorVersionRequest request, st::CancellationToken cancellationToken) =>
            DeployProcessorVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeployProcessorVersion</c>.</summary>
        public virtual lro::OperationsClient DeployProcessorVersionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeployProcessorVersion</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DeployProcessorVersionResponse, DeployProcessorVersionMetadata> PollOnceDeployProcessorVersion(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DeployProcessorVersionResponse, DeployProcessorVersionMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeployProcessorVersionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeployProcessorVersion</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DeployProcessorVersionResponse, DeployProcessorVersionMetadata>> PollOnceDeployProcessorVersionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DeployProcessorVersionResponse, DeployProcessorVersionMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeployProcessorVersionOperationsClient, callSettings);

        /// <summary>
        /// Deploys the processor version.
        /// </summary>
        /// <param name="name">
        /// Required. The processor version resource name to be deployed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeployProcessorVersionResponse, DeployProcessorVersionMetadata> DeployProcessorVersion(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeployProcessorVersion(new DeployProcessorVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deploys the processor version.
        /// </summary>
        /// <param name="name">
        /// Required. The processor version resource name to be deployed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployProcessorVersionResponse, DeployProcessorVersionMetadata>> DeployProcessorVersionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeployProcessorVersionAsync(new DeployProcessorVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deploys the processor version.
        /// </summary>
        /// <param name="name">
        /// Required. The processor version resource name to be deployed.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployProcessorVersionResponse, DeployProcessorVersionMetadata>> DeployProcessorVersionAsync(string name, st::CancellationToken cancellationToken) =>
            DeployProcessorVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deploys the processor version.
        /// </summary>
        /// <param name="name">
        /// Required. The processor version resource name to be deployed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeployProcessorVersionResponse, DeployProcessorVersionMetadata> DeployProcessorVersion(ProcessorVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeployProcessorVersion(new DeployProcessorVersionRequest
            {
                ProcessorVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deploys the processor version.
        /// </summary>
        /// <param name="name">
        /// Required. The processor version resource name to be deployed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployProcessorVersionResponse, DeployProcessorVersionMetadata>> DeployProcessorVersionAsync(ProcessorVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeployProcessorVersionAsync(new DeployProcessorVersionRequest
            {
                ProcessorVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deploys the processor version.
        /// </summary>
        /// <param name="name">
        /// Required. The processor version resource name to be deployed.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployProcessorVersionResponse, DeployProcessorVersionMetadata>> DeployProcessorVersionAsync(ProcessorVersionName name, st::CancellationToken cancellationToken) =>
            DeployProcessorVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Undeploys the processor version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UndeployProcessorVersionResponse, UndeployProcessorVersionMetadata> UndeployProcessorVersion(UndeployProcessorVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Undeploys the processor version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeployProcessorVersionResponse, UndeployProcessorVersionMetadata>> UndeployProcessorVersionAsync(UndeployProcessorVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Undeploys the processor version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeployProcessorVersionResponse, UndeployProcessorVersionMetadata>> UndeployProcessorVersionAsync(UndeployProcessorVersionRequest request, st::CancellationToken cancellationToken) =>
            UndeployProcessorVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UndeployProcessorVersion</c>.</summary>
        public virtual lro::OperationsClient UndeployProcessorVersionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UndeployProcessorVersion</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<UndeployProcessorVersionResponse, UndeployProcessorVersionMetadata> PollOnceUndeployProcessorVersion(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<UndeployProcessorVersionResponse, UndeployProcessorVersionMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UndeployProcessorVersionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UndeployProcessorVersion</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<UndeployProcessorVersionResponse, UndeployProcessorVersionMetadata>> PollOnceUndeployProcessorVersionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<UndeployProcessorVersionResponse, UndeployProcessorVersionMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UndeployProcessorVersionOperationsClient, callSettings);

        /// <summary>
        /// Undeploys the processor version.
        /// </summary>
        /// <param name="name">
        /// Required. The processor version resource name to be undeployed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UndeployProcessorVersionResponse, UndeployProcessorVersionMetadata> UndeployProcessorVersion(string name, gaxgrpc::CallSettings callSettings = null) =>
            UndeployProcessorVersion(new UndeployProcessorVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undeploys the processor version.
        /// </summary>
        /// <param name="name">
        /// Required. The processor version resource name to be undeployed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeployProcessorVersionResponse, UndeployProcessorVersionMetadata>> UndeployProcessorVersionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            UndeployProcessorVersionAsync(new UndeployProcessorVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undeploys the processor version.
        /// </summary>
        /// <param name="name">
        /// Required. The processor version resource name to be undeployed.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeployProcessorVersionResponse, UndeployProcessorVersionMetadata>> UndeployProcessorVersionAsync(string name, st::CancellationToken cancellationToken) =>
            UndeployProcessorVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Undeploys the processor version.
        /// </summary>
        /// <param name="name">
        /// Required. The processor version resource name to be undeployed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<UndeployProcessorVersionResponse, UndeployProcessorVersionMetadata> UndeployProcessorVersion(ProcessorVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            UndeployProcessorVersion(new UndeployProcessorVersionRequest
            {
                ProcessorVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undeploys the processor version.
        /// </summary>
        /// <param name="name">
        /// Required. The processor version resource name to be undeployed.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeployProcessorVersionResponse, UndeployProcessorVersionMetadata>> UndeployProcessorVersionAsync(ProcessorVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            UndeployProcessorVersionAsync(new UndeployProcessorVersionRequest
            {
                ProcessorVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undeploys the processor version.
        /// </summary>
        /// <param name="name">
        /// Required. The processor version resource name to be undeployed.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<UndeployProcessorVersionResponse, UndeployProcessorVersionMetadata>> UndeployProcessorVersionAsync(ProcessorVersionName name, st::CancellationToken cancellationToken) =>
            UndeployProcessorVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a processor from the
        /// [ProcessorType][google.cloud.documentai.v1.ProcessorType] provided. The
        /// processor will be at `ENABLED` state by default after its creation. Note
        /// that this method requires the `documentai.processors.create` permission on
        /// the project, which is highly privileged. A user or service account with
        /// this permission can create new processors that can interact with any gcs
        /// bucket in your project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Processor CreateProcessor(CreateProcessorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a processor from the
        /// [ProcessorType][google.cloud.documentai.v1.ProcessorType] provided. The
        /// processor will be at `ENABLED` state by default after its creation. Note
        /// that this method requires the `documentai.processors.create` permission on
        /// the project, which is highly privileged. A user or service account with
        /// this permission can create new processors that can interact with any gcs
        /// bucket in your project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Processor> CreateProcessorAsync(CreateProcessorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a processor from the
        /// [ProcessorType][google.cloud.documentai.v1.ProcessorType] provided. The
        /// processor will be at `ENABLED` state by default after its creation. Note
        /// that this method requires the `documentai.processors.create` permission on
        /// the project, which is highly privileged. A user or service account with
        /// this permission can create new processors that can interact with any gcs
        /// bucket in your project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Processor> CreateProcessorAsync(CreateProcessorRequest request, st::CancellationToken cancellationToken) =>
            CreateProcessorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a processor from the
        /// [ProcessorType][google.cloud.documentai.v1.ProcessorType] provided. The
        /// processor will be at `ENABLED` state by default after its creation. Note
        /// that this method requires the `documentai.processors.create` permission on
        /// the project, which is highly privileged. A user or service account with
        /// this permission can create new processors that can interact with any gcs
        /// bucket in your project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) under which to create the
        /// processor. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="processor">
        /// Required. The processor to be created, requires
        /// [Processor.type][google.cloud.documentai.v1.Processor.type] and
        /// [Processor.display_name][google.cloud.documentai.v1.Processor.display_name]
        /// to be set. Also, the
        /// [Processor.kms_key_name][google.cloud.documentai.v1.Processor.kms_key_name]
        /// field must be set if the processor is under CMEK.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Processor CreateProcessor(string parent, Processor processor, gaxgrpc::CallSettings callSettings = null) =>
            CreateProcessor(new CreateProcessorRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Processor = gax::GaxPreconditions.CheckNotNull(processor, nameof(processor)),
            }, callSettings);

        /// <summary>
        /// Creates a processor from the
        /// [ProcessorType][google.cloud.documentai.v1.ProcessorType] provided. The
        /// processor will be at `ENABLED` state by default after its creation. Note
        /// that this method requires the `documentai.processors.create` permission on
        /// the project, which is highly privileged. A user or service account with
        /// this permission can create new processors that can interact with any gcs
        /// bucket in your project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) under which to create the
        /// processor. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="processor">
        /// Required. The processor to be created, requires
        /// [Processor.type][google.cloud.documentai.v1.Processor.type] and
        /// [Processor.display_name][google.cloud.documentai.v1.Processor.display_name]
        /// to be set. Also, the
        /// [Processor.kms_key_name][google.cloud.documentai.v1.Processor.kms_key_name]
        /// field must be set if the processor is under CMEK.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Processor> CreateProcessorAsync(string parent, Processor processor, gaxgrpc::CallSettings callSettings = null) =>
            CreateProcessorAsync(new CreateProcessorRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Processor = gax::GaxPreconditions.CheckNotNull(processor, nameof(processor)),
            }, callSettings);

        /// <summary>
        /// Creates a processor from the
        /// [ProcessorType][google.cloud.documentai.v1.ProcessorType] provided. The
        /// processor will be at `ENABLED` state by default after its creation. Note
        /// that this method requires the `documentai.processors.create` permission on
        /// the project, which is highly privileged. A user or service account with
        /// this permission can create new processors that can interact with any gcs
        /// bucket in your project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) under which to create the
        /// processor. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="processor">
        /// Required. The processor to be created, requires
        /// [Processor.type][google.cloud.documentai.v1.Processor.type] and
        /// [Processor.display_name][google.cloud.documentai.v1.Processor.display_name]
        /// to be set. Also, the
        /// [Processor.kms_key_name][google.cloud.documentai.v1.Processor.kms_key_name]
        /// field must be set if the processor is under CMEK.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Processor> CreateProcessorAsync(string parent, Processor processor, st::CancellationToken cancellationToken) =>
            CreateProcessorAsync(parent, processor, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a processor from the
        /// [ProcessorType][google.cloud.documentai.v1.ProcessorType] provided. The
        /// processor will be at `ENABLED` state by default after its creation. Note
        /// that this method requires the `documentai.processors.create` permission on
        /// the project, which is highly privileged. A user or service account with
        /// this permission can create new processors that can interact with any gcs
        /// bucket in your project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) under which to create the
        /// processor. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="processor">
        /// Required. The processor to be created, requires
        /// [Processor.type][google.cloud.documentai.v1.Processor.type] and
        /// [Processor.display_name][google.cloud.documentai.v1.Processor.display_name]
        /// to be set. Also, the
        /// [Processor.kms_key_name][google.cloud.documentai.v1.Processor.kms_key_name]
        /// field must be set if the processor is under CMEK.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Processor CreateProcessor(gagr::LocationName parent, Processor processor, gaxgrpc::CallSettings callSettings = null) =>
            CreateProcessor(new CreateProcessorRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Processor = gax::GaxPreconditions.CheckNotNull(processor, nameof(processor)),
            }, callSettings);

        /// <summary>
        /// Creates a processor from the
        /// [ProcessorType][google.cloud.documentai.v1.ProcessorType] provided. The
        /// processor will be at `ENABLED` state by default after its creation. Note
        /// that this method requires the `documentai.processors.create` permission on
        /// the project, which is highly privileged. A user or service account with
        /// this permission can create new processors that can interact with any gcs
        /// bucket in your project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) under which to create the
        /// processor. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="processor">
        /// Required. The processor to be created, requires
        /// [Processor.type][google.cloud.documentai.v1.Processor.type] and
        /// [Processor.display_name][google.cloud.documentai.v1.Processor.display_name]
        /// to be set. Also, the
        /// [Processor.kms_key_name][google.cloud.documentai.v1.Processor.kms_key_name]
        /// field must be set if the processor is under CMEK.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Processor> CreateProcessorAsync(gagr::LocationName parent, Processor processor, gaxgrpc::CallSettings callSettings = null) =>
            CreateProcessorAsync(new CreateProcessorRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Processor = gax::GaxPreconditions.CheckNotNull(processor, nameof(processor)),
            }, callSettings);

        /// <summary>
        /// Creates a processor from the
        /// [ProcessorType][google.cloud.documentai.v1.ProcessorType] provided. The
        /// processor will be at `ENABLED` state by default after its creation. Note
        /// that this method requires the `documentai.processors.create` permission on
        /// the project, which is highly privileged. A user or service account with
        /// this permission can create new processors that can interact with any gcs
        /// bucket in your project.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent (project and location) under which to create the
        /// processor. Format: `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="processor">
        /// Required. The processor to be created, requires
        /// [Processor.type][google.cloud.documentai.v1.Processor.type] and
        /// [Processor.display_name][google.cloud.documentai.v1.Processor.display_name]
        /// to be set. Also, the
        /// [Processor.kms_key_name][google.cloud.documentai.v1.Processor.kms_key_name]
        /// field must be set if the processor is under CMEK.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Processor> CreateProcessorAsync(gagr::LocationName parent, Processor processor, st::CancellationToken cancellationToken) =>
            CreateProcessorAsync(parent, processor, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the processor, unloads all deployed model artifacts if it was
        /// enabled and then deletes all artifacts associated with this processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteProcessorMetadata> DeleteProcessor(DeleteProcessorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the processor, unloads all deployed model artifacts if it was
        /// enabled and then deletes all artifacts associated with this processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteProcessorMetadata>> DeleteProcessorAsync(DeleteProcessorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the processor, unloads all deployed model artifacts if it was
        /// enabled and then deletes all artifacts associated with this processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteProcessorMetadata>> DeleteProcessorAsync(DeleteProcessorRequest request, st::CancellationToken cancellationToken) =>
            DeleteProcessorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteProcessor</c>.</summary>
        public virtual lro::OperationsClient DeleteProcessorOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteProcessor</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteProcessorMetadata> PollOnceDeleteProcessor(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteProcessorMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteProcessorOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteProcessor</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteProcessorMetadata>> PollOnceDeleteProcessorAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, DeleteProcessorMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteProcessorOperationsClient, callSettings);

        /// <summary>
        /// Deletes the processor, unloads all deployed model artifacts if it was
        /// enabled and then deletes all artifacts associated with this processor.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name to be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteProcessorMetadata> DeleteProcessor(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProcessor(new DeleteProcessorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the processor, unloads all deployed model artifacts if it was
        /// enabled and then deletes all artifacts associated with this processor.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name to be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteProcessorMetadata>> DeleteProcessorAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProcessorAsync(new DeleteProcessorRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the processor, unloads all deployed model artifacts if it was
        /// enabled and then deletes all artifacts associated with this processor.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name to be deleted.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteProcessorMetadata>> DeleteProcessorAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteProcessorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the processor, unloads all deployed model artifacts if it was
        /// enabled and then deletes all artifacts associated with this processor.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name to be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, DeleteProcessorMetadata> DeleteProcessor(ProcessorName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProcessor(new DeleteProcessorRequest
            {
                ProcessorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the processor, unloads all deployed model artifacts if it was
        /// enabled and then deletes all artifacts associated with this processor.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name to be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteProcessorMetadata>> DeleteProcessorAsync(ProcessorName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteProcessorAsync(new DeleteProcessorRequest
            {
                ProcessorName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the processor, unloads all deployed model artifacts if it was
        /// enabled and then deletes all artifacts associated with this processor.
        /// </summary>
        /// <param name="name">
        /// Required. The processor resource name to be deleted.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, DeleteProcessorMetadata>> DeleteProcessorAsync(ProcessorName name, st::CancellationToken cancellationToken) =>
            DeleteProcessorAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Enables a processor
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EnableProcessorResponse, EnableProcessorMetadata> EnableProcessor(EnableProcessorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enables a processor
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EnableProcessorResponse, EnableProcessorMetadata>> EnableProcessorAsync(EnableProcessorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enables a processor
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EnableProcessorResponse, EnableProcessorMetadata>> EnableProcessorAsync(EnableProcessorRequest request, st::CancellationToken cancellationToken) =>
            EnableProcessorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>EnableProcessor</c>.</summary>
        public virtual lro::OperationsClient EnableProcessorOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>EnableProcessor</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<EnableProcessorResponse, EnableProcessorMetadata> PollOnceEnableProcessor(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EnableProcessorResponse, EnableProcessorMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), EnableProcessorOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>EnableProcessor</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<EnableProcessorResponse, EnableProcessorMetadata>> PollOnceEnableProcessorAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EnableProcessorResponse, EnableProcessorMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), EnableProcessorOperationsClient, callSettings);

        /// <summary>
        /// Disables a processor
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DisableProcessorResponse, DisableProcessorMetadata> DisableProcessor(DisableProcessorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disables a processor
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DisableProcessorResponse, DisableProcessorMetadata>> DisableProcessorAsync(DisableProcessorRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disables a processor
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DisableProcessorResponse, DisableProcessorMetadata>> DisableProcessorAsync(DisableProcessorRequest request, st::CancellationToken cancellationToken) =>
            DisableProcessorAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DisableProcessor</c>.</summary>
        public virtual lro::OperationsClient DisableProcessorOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DisableProcessor</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DisableProcessorResponse, DisableProcessorMetadata> PollOnceDisableProcessor(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DisableProcessorResponse, DisableProcessorMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DisableProcessorOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DisableProcessor</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DisableProcessorResponse, DisableProcessorMetadata>> PollOnceDisableProcessorAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DisableProcessorResponse, DisableProcessorMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DisableProcessorOperationsClient, callSettings);

        /// <summary>
        /// Set the default (active) version of a
        /// [Processor][google.cloud.documentai.v1.Processor] that will be used in
        /// [ProcessDocument][google.cloud.documentai.v1.DocumentProcessorService.ProcessDocument]
        /// and
        /// [BatchProcessDocuments][google.cloud.documentai.v1.DocumentProcessorService.BatchProcessDocuments].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SetDefaultProcessorVersionResponse, SetDefaultProcessorVersionMetadata> SetDefaultProcessorVersion(SetDefaultProcessorVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Set the default (active) version of a
        /// [Processor][google.cloud.documentai.v1.Processor] that will be used in
        /// [ProcessDocument][google.cloud.documentai.v1.DocumentProcessorService.ProcessDocument]
        /// and
        /// [BatchProcessDocuments][google.cloud.documentai.v1.DocumentProcessorService.BatchProcessDocuments].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SetDefaultProcessorVersionResponse, SetDefaultProcessorVersionMetadata>> SetDefaultProcessorVersionAsync(SetDefaultProcessorVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Set the default (active) version of a
        /// [Processor][google.cloud.documentai.v1.Processor] that will be used in
        /// [ProcessDocument][google.cloud.documentai.v1.DocumentProcessorService.ProcessDocument]
        /// and
        /// [BatchProcessDocuments][google.cloud.documentai.v1.DocumentProcessorService.BatchProcessDocuments].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SetDefaultProcessorVersionResponse, SetDefaultProcessorVersionMetadata>> SetDefaultProcessorVersionAsync(SetDefaultProcessorVersionRequest request, st::CancellationToken cancellationToken) =>
            SetDefaultProcessorVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SetDefaultProcessorVersion</c>.</summary>
        public virtual lro::OperationsClient SetDefaultProcessorVersionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetDefaultProcessorVersion</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<SetDefaultProcessorVersionResponse, SetDefaultProcessorVersionMetadata> PollOnceSetDefaultProcessorVersion(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SetDefaultProcessorVersionResponse, SetDefaultProcessorVersionMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetDefaultProcessorVersionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SetDefaultProcessorVersion</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<SetDefaultProcessorVersionResponse, SetDefaultProcessorVersionMetadata>> PollOnceSetDefaultProcessorVersionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SetDefaultProcessorVersionResponse, SetDefaultProcessorVersionMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SetDefaultProcessorVersionOperationsClient, callSettings);

        /// <summary>
        /// Send a document for Human Review. The input document should be processed by
        /// the specified processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata> ReviewDocument(ReviewDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Send a document for Human Review. The input document should be processed by
        /// the specified processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata>> ReviewDocumentAsync(ReviewDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Send a document for Human Review. The input document should be processed by
        /// the specified processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata>> ReviewDocumentAsync(ReviewDocumentRequest request, st::CancellationToken cancellationToken) =>
            ReviewDocumentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ReviewDocument</c>.</summary>
        public virtual lro::OperationsClient ReviewDocumentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ReviewDocument</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata> PollOnceReviewDocument(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ReviewDocumentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ReviewDocument</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata>> PollOnceReviewDocumentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ReviewDocumentOperationsClient, callSettings);

        /// <summary>
        /// Send a document for Human Review. The input document should be processed by
        /// the specified processor.
        /// </summary>
        /// <param name="humanReviewConfig">
        /// Required. The resource name of the
        /// [HumanReviewConfig][google.cloud.documentai.v1.HumanReviewConfig] that the
        /// document will be reviewed with.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata> ReviewDocument(string humanReviewConfig, gaxgrpc::CallSettings callSettings = null) =>
            ReviewDocument(new ReviewDocumentRequest
            {
                HumanReviewConfig = gax::GaxPreconditions.CheckNotNullOrEmpty(humanReviewConfig, nameof(humanReviewConfig)),
            }, callSettings);

        /// <summary>
        /// Send a document for Human Review. The input document should be processed by
        /// the specified processor.
        /// </summary>
        /// <param name="humanReviewConfig">
        /// Required. The resource name of the
        /// [HumanReviewConfig][google.cloud.documentai.v1.HumanReviewConfig] that the
        /// document will be reviewed with.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata>> ReviewDocumentAsync(string humanReviewConfig, gaxgrpc::CallSettings callSettings = null) =>
            ReviewDocumentAsync(new ReviewDocumentRequest
            {
                HumanReviewConfig = gax::GaxPreconditions.CheckNotNullOrEmpty(humanReviewConfig, nameof(humanReviewConfig)),
            }, callSettings);

        /// <summary>
        /// Send a document for Human Review. The input document should be processed by
        /// the specified processor.
        /// </summary>
        /// <param name="humanReviewConfig">
        /// Required. The resource name of the
        /// [HumanReviewConfig][google.cloud.documentai.v1.HumanReviewConfig] that the
        /// document will be reviewed with.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata>> ReviewDocumentAsync(string humanReviewConfig, st::CancellationToken cancellationToken) =>
            ReviewDocumentAsync(humanReviewConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Send a document for Human Review. The input document should be processed by
        /// the specified processor.
        /// </summary>
        /// <param name="humanReviewConfig">
        /// Required. The resource name of the
        /// [HumanReviewConfig][google.cloud.documentai.v1.HumanReviewConfig] that the
        /// document will be reviewed with.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata> ReviewDocument(HumanReviewConfigName humanReviewConfig, gaxgrpc::CallSettings callSettings = null) =>
            ReviewDocument(new ReviewDocumentRequest
            {
                HumanReviewConfigAsHumanReviewConfigName = gax::GaxPreconditions.CheckNotNull(humanReviewConfig, nameof(humanReviewConfig)),
            }, callSettings);

        /// <summary>
        /// Send a document for Human Review. The input document should be processed by
        /// the specified processor.
        /// </summary>
        /// <param name="humanReviewConfig">
        /// Required. The resource name of the
        /// [HumanReviewConfig][google.cloud.documentai.v1.HumanReviewConfig] that the
        /// document will be reviewed with.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata>> ReviewDocumentAsync(HumanReviewConfigName humanReviewConfig, gaxgrpc::CallSettings callSettings = null) =>
            ReviewDocumentAsync(new ReviewDocumentRequest
            {
                HumanReviewConfigAsHumanReviewConfigName = gax::GaxPreconditions.CheckNotNull(humanReviewConfig, nameof(humanReviewConfig)),
            }, callSettings);

        /// <summary>
        /// Send a document for Human Review. The input document should be processed by
        /// the specified processor.
        /// </summary>
        /// <param name="humanReviewConfig">
        /// Required. The resource name of the
        /// [HumanReviewConfig][google.cloud.documentai.v1.HumanReviewConfig] that the
        /// document will be reviewed with.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata>> ReviewDocumentAsync(HumanReviewConfigName humanReviewConfig, st::CancellationToken cancellationToken) =>
            ReviewDocumentAsync(humanReviewConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Evaluates a ProcessorVersion against annotated documents, producing an
        /// Evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EvaluateProcessorVersionResponse, EvaluateProcessorVersionMetadata> EvaluateProcessorVersion(EvaluateProcessorVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Evaluates a ProcessorVersion against annotated documents, producing an
        /// Evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EvaluateProcessorVersionResponse, EvaluateProcessorVersionMetadata>> EvaluateProcessorVersionAsync(EvaluateProcessorVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Evaluates a ProcessorVersion against annotated documents, producing an
        /// Evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EvaluateProcessorVersionResponse, EvaluateProcessorVersionMetadata>> EvaluateProcessorVersionAsync(EvaluateProcessorVersionRequest request, st::CancellationToken cancellationToken) =>
            EvaluateProcessorVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>EvaluateProcessorVersion</c>.</summary>
        public virtual lro::OperationsClient EvaluateProcessorVersionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>EvaluateProcessorVersion</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<EvaluateProcessorVersionResponse, EvaluateProcessorVersionMetadata> PollOnceEvaluateProcessorVersion(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EvaluateProcessorVersionResponse, EvaluateProcessorVersionMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), EvaluateProcessorVersionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>EvaluateProcessorVersion</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<EvaluateProcessorVersionResponse, EvaluateProcessorVersionMetadata>> PollOnceEvaluateProcessorVersionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EvaluateProcessorVersionResponse, EvaluateProcessorVersionMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), EvaluateProcessorVersionOperationsClient, callSettings);

        /// <summary>
        /// Evaluates a ProcessorVersion against annotated documents, producing an
        /// Evaluation.
        /// </summary>
        /// <param name="processorVersion">
        /// Required. The resource name of the
        /// [ProcessorVersion][google.cloud.documentai.v1.ProcessorVersion] to
        /// evaluate.
        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EvaluateProcessorVersionResponse, EvaluateProcessorVersionMetadata> EvaluateProcessorVersion(string processorVersion, gaxgrpc::CallSettings callSettings = null) =>
            EvaluateProcessorVersion(new EvaluateProcessorVersionRequest
            {
                ProcessorVersion = gax::GaxPreconditions.CheckNotNullOrEmpty(processorVersion, nameof(processorVersion)),
            }, callSettings);

        /// <summary>
        /// Evaluates a ProcessorVersion against annotated documents, producing an
        /// Evaluation.
        /// </summary>
        /// <param name="processorVersion">
        /// Required. The resource name of the
        /// [ProcessorVersion][google.cloud.documentai.v1.ProcessorVersion] to
        /// evaluate.
        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EvaluateProcessorVersionResponse, EvaluateProcessorVersionMetadata>> EvaluateProcessorVersionAsync(string processorVersion, gaxgrpc::CallSettings callSettings = null) =>
            EvaluateProcessorVersionAsync(new EvaluateProcessorVersionRequest
            {
                ProcessorVersion = gax::GaxPreconditions.CheckNotNullOrEmpty(processorVersion, nameof(processorVersion)),
            }, callSettings);

        /// <summary>
        /// Evaluates a ProcessorVersion against annotated documents, producing an
        /// Evaluation.
        /// </summary>
        /// <param name="processorVersion">
        /// Required. The resource name of the
        /// [ProcessorVersion][google.cloud.documentai.v1.ProcessorVersion] to
        /// evaluate.
        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EvaluateProcessorVersionResponse, EvaluateProcessorVersionMetadata>> EvaluateProcessorVersionAsync(string processorVersion, st::CancellationToken cancellationToken) =>
            EvaluateProcessorVersionAsync(processorVersion, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Evaluates a ProcessorVersion against annotated documents, producing an
        /// Evaluation.
        /// </summary>
        /// <param name="processorVersion">
        /// Required. The resource name of the
        /// [ProcessorVersion][google.cloud.documentai.v1.ProcessorVersion] to
        /// evaluate.
        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EvaluateProcessorVersionResponse, EvaluateProcessorVersionMetadata> EvaluateProcessorVersion(ProcessorVersionName processorVersion, gaxgrpc::CallSettings callSettings = null) =>
            EvaluateProcessorVersion(new EvaluateProcessorVersionRequest
            {
                ProcessorVersionAsProcessorVersionName = gax::GaxPreconditions.CheckNotNull(processorVersion, nameof(processorVersion)),
            }, callSettings);

        /// <summary>
        /// Evaluates a ProcessorVersion against annotated documents, producing an
        /// Evaluation.
        /// </summary>
        /// <param name="processorVersion">
        /// Required. The resource name of the
        /// [ProcessorVersion][google.cloud.documentai.v1.ProcessorVersion] to
        /// evaluate.
        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EvaluateProcessorVersionResponse, EvaluateProcessorVersionMetadata>> EvaluateProcessorVersionAsync(ProcessorVersionName processorVersion, gaxgrpc::CallSettings callSettings = null) =>
            EvaluateProcessorVersionAsync(new EvaluateProcessorVersionRequest
            {
                ProcessorVersionAsProcessorVersionName = gax::GaxPreconditions.CheckNotNull(processorVersion, nameof(processorVersion)),
            }, callSettings);

        /// <summary>
        /// Evaluates a ProcessorVersion against annotated documents, producing an
        /// Evaluation.
        /// </summary>
        /// <param name="processorVersion">
        /// Required. The resource name of the
        /// [ProcessorVersion][google.cloud.documentai.v1.ProcessorVersion] to
        /// evaluate.
        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EvaluateProcessorVersionResponse, EvaluateProcessorVersionMetadata>> EvaluateProcessorVersionAsync(ProcessorVersionName processorVersion, st::CancellationToken cancellationToken) =>
            EvaluateProcessorVersionAsync(processorVersion, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a specific evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Evaluation GetEvaluation(GetEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a specific evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> GetEvaluationAsync(GetEvaluationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a specific evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> GetEvaluationAsync(GetEvaluationRequest request, st::CancellationToken cancellationToken) =>
            GetEvaluationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a specific evaluation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [Evaluation][google.cloud.documentai.v1.Evaluation] to get.
        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}/evaluations/{evaluation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Evaluation GetEvaluation(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvaluation(new GetEvaluationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a specific evaluation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [Evaluation][google.cloud.documentai.v1.Evaluation] to get.
        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}/evaluations/{evaluation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> GetEvaluationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvaluationAsync(new GetEvaluationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a specific evaluation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [Evaluation][google.cloud.documentai.v1.Evaluation] to get.
        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}/evaluations/{evaluation}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> GetEvaluationAsync(string name, st::CancellationToken cancellationToken) =>
            GetEvaluationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a specific evaluation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [Evaluation][google.cloud.documentai.v1.Evaluation] to get.
        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}/evaluations/{evaluation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Evaluation GetEvaluation(EvaluationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvaluation(new GetEvaluationRequest
            {
                EvaluationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a specific evaluation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [Evaluation][google.cloud.documentai.v1.Evaluation] to get.
        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}/evaluations/{evaluation}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> GetEvaluationAsync(EvaluationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEvaluationAsync(new GetEvaluationRequest
            {
                EvaluationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a specific evaluation.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the
        /// [Evaluation][google.cloud.documentai.v1.Evaluation] to get.
        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}/evaluations/{evaluation}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Evaluation> GetEvaluationAsync(EvaluationName name, st::CancellationToken cancellationToken) =>
            GetEvaluationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a set of evaluations for a given processor version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Evaluation"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEvaluationsResponse, Evaluation> ListEvaluations(ListEvaluationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a set of evaluations for a given processor version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Evaluation"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEvaluationsResponse, Evaluation> ListEvaluationsAsync(ListEvaluationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a set of evaluations for a given processor version.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the
        /// [ProcessorVersion][google.cloud.documentai.v1.ProcessorVersion] to list
        /// evaluations for.
        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`
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
        /// Retrieves a set of evaluations for a given processor version.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the
        /// [ProcessorVersion][google.cloud.documentai.v1.ProcessorVersion] to list
        /// evaluations for.
        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`
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
        /// Retrieves a set of evaluations for a given processor version.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the
        /// [ProcessorVersion][google.cloud.documentai.v1.ProcessorVersion] to list
        /// evaluations for.
        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`
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
        public virtual gax::PagedEnumerable<ListEvaluationsResponse, Evaluation> ListEvaluations(ProcessorVersionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEvaluationsRequest request = new ListEvaluationsRequest
            {
                ParentAsProcessorVersionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Retrieves a set of evaluations for a given processor version.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the
        /// [ProcessorVersion][google.cloud.documentai.v1.ProcessorVersion] to list
        /// evaluations for.
        /// `projects/{project}/locations/{location}/processors/{processor}/processorVersions/{processorVersion}`
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
        public virtual gax::PagedAsyncEnumerable<ListEvaluationsResponse, Evaluation> ListEvaluationsAsync(ProcessorVersionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEvaluationsRequest request = new ListEvaluationsRequest
            {
                ParentAsProcessorVersionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
    }

    /// <summary>DocumentProcessorService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to call Document AI to process documents according to the
    /// processor's definition. Processors are built using state-of-the-art Google
    /// AI such as natural language, computer vision, and translation to extract
    /// structured information from unstructured or semi-structured documents.
    /// </remarks>
    public sealed partial class DocumentProcessorServiceClientImpl : DocumentProcessorServiceClient
    {
        private readonly gaxgrpc::ApiCall<ProcessRequest, ProcessResponse> _callProcessDocument;

        private readonly gaxgrpc::ApiCall<BatchProcessRequest, lro::Operation> _callBatchProcessDocuments;

        private readonly gaxgrpc::ApiCall<FetchProcessorTypesRequest, FetchProcessorTypesResponse> _callFetchProcessorTypes;

        private readonly gaxgrpc::ApiCall<ListProcessorTypesRequest, ListProcessorTypesResponse> _callListProcessorTypes;

        private readonly gaxgrpc::ApiCall<GetProcessorTypeRequest, ProcessorType> _callGetProcessorType;

        private readonly gaxgrpc::ApiCall<ListProcessorsRequest, ListProcessorsResponse> _callListProcessors;

        private readonly gaxgrpc::ApiCall<GetProcessorRequest, Processor> _callGetProcessor;

        private readonly gaxgrpc::ApiCall<TrainProcessorVersionRequest, lro::Operation> _callTrainProcessorVersion;

        private readonly gaxgrpc::ApiCall<GetProcessorVersionRequest, ProcessorVersion> _callGetProcessorVersion;

        private readonly gaxgrpc::ApiCall<ListProcessorVersionsRequest, ListProcessorVersionsResponse> _callListProcessorVersions;

        private readonly gaxgrpc::ApiCall<DeleteProcessorVersionRequest, lro::Operation> _callDeleteProcessorVersion;

        private readonly gaxgrpc::ApiCall<DeployProcessorVersionRequest, lro::Operation> _callDeployProcessorVersion;

        private readonly gaxgrpc::ApiCall<UndeployProcessorVersionRequest, lro::Operation> _callUndeployProcessorVersion;

        private readonly gaxgrpc::ApiCall<CreateProcessorRequest, Processor> _callCreateProcessor;

        private readonly gaxgrpc::ApiCall<DeleteProcessorRequest, lro::Operation> _callDeleteProcessor;

        private readonly gaxgrpc::ApiCall<EnableProcessorRequest, lro::Operation> _callEnableProcessor;

        private readonly gaxgrpc::ApiCall<DisableProcessorRequest, lro::Operation> _callDisableProcessor;

        private readonly gaxgrpc::ApiCall<SetDefaultProcessorVersionRequest, lro::Operation> _callSetDefaultProcessorVersion;

        private readonly gaxgrpc::ApiCall<ReviewDocumentRequest, lro::Operation> _callReviewDocument;

        private readonly gaxgrpc::ApiCall<EvaluateProcessorVersionRequest, lro::Operation> _callEvaluateProcessorVersion;

        private readonly gaxgrpc::ApiCall<GetEvaluationRequest, Evaluation> _callGetEvaluation;

        private readonly gaxgrpc::ApiCall<ListEvaluationsRequest, ListEvaluationsResponse> _callListEvaluations;

        /// <summary>
        /// Constructs a client wrapper for the DocumentProcessorService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="DocumentProcessorServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DocumentProcessorServiceClientImpl(DocumentProcessorService.DocumentProcessorServiceClient grpcClient, DocumentProcessorServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DocumentProcessorServiceSettings effectiveSettings = settings ?? DocumentProcessorServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            BatchProcessDocumentsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.BatchProcessDocumentsOperationsSettings, logger);
            TrainProcessorVersionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.TrainProcessorVersionOperationsSettings, logger);
            DeleteProcessorVersionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteProcessorVersionOperationsSettings, logger);
            DeployProcessorVersionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeployProcessorVersionOperationsSettings, logger);
            UndeployProcessorVersionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UndeployProcessorVersionOperationsSettings, logger);
            DeleteProcessorOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteProcessorOperationsSettings, logger);
            EnableProcessorOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.EnableProcessorOperationsSettings, logger);
            DisableProcessorOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DisableProcessorOperationsSettings, logger);
            SetDefaultProcessorVersionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.SetDefaultProcessorVersionOperationsSettings, logger);
            ReviewDocumentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ReviewDocumentOperationsSettings, logger);
            EvaluateProcessorVersionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.EvaluateProcessorVersionOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callProcessDocument = clientHelper.BuildApiCall<ProcessRequest, ProcessResponse>("ProcessDocument", grpcClient.ProcessDocumentAsync, grpcClient.ProcessDocument, effectiveSettings.ProcessDocumentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callProcessDocument);
            Modify_ProcessDocumentApiCall(ref _callProcessDocument);
            _callBatchProcessDocuments = clientHelper.BuildApiCall<BatchProcessRequest, lro::Operation>("BatchProcessDocuments", grpcClient.BatchProcessDocumentsAsync, grpcClient.BatchProcessDocuments, effectiveSettings.BatchProcessDocumentsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callBatchProcessDocuments);
            Modify_BatchProcessDocumentsApiCall(ref _callBatchProcessDocuments);
            _callFetchProcessorTypes = clientHelper.BuildApiCall<FetchProcessorTypesRequest, FetchProcessorTypesResponse>("FetchProcessorTypes", grpcClient.FetchProcessorTypesAsync, grpcClient.FetchProcessorTypes, effectiveSettings.FetchProcessorTypesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callFetchProcessorTypes);
            Modify_FetchProcessorTypesApiCall(ref _callFetchProcessorTypes);
            _callListProcessorTypes = clientHelper.BuildApiCall<ListProcessorTypesRequest, ListProcessorTypesResponse>("ListProcessorTypes", grpcClient.ListProcessorTypesAsync, grpcClient.ListProcessorTypes, effectiveSettings.ListProcessorTypesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListProcessorTypes);
            Modify_ListProcessorTypesApiCall(ref _callListProcessorTypes);
            _callGetProcessorType = clientHelper.BuildApiCall<GetProcessorTypeRequest, ProcessorType>("GetProcessorType", grpcClient.GetProcessorTypeAsync, grpcClient.GetProcessorType, effectiveSettings.GetProcessorTypeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetProcessorType);
            Modify_GetProcessorTypeApiCall(ref _callGetProcessorType);
            _callListProcessors = clientHelper.BuildApiCall<ListProcessorsRequest, ListProcessorsResponse>("ListProcessors", grpcClient.ListProcessorsAsync, grpcClient.ListProcessors, effectiveSettings.ListProcessorsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListProcessors);
            Modify_ListProcessorsApiCall(ref _callListProcessors);
            _callGetProcessor = clientHelper.BuildApiCall<GetProcessorRequest, Processor>("GetProcessor", grpcClient.GetProcessorAsync, grpcClient.GetProcessor, effectiveSettings.GetProcessorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetProcessor);
            Modify_GetProcessorApiCall(ref _callGetProcessor);
            _callTrainProcessorVersion = clientHelper.BuildApiCall<TrainProcessorVersionRequest, lro::Operation>("TrainProcessorVersion", grpcClient.TrainProcessorVersionAsync, grpcClient.TrainProcessorVersion, effectiveSettings.TrainProcessorVersionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callTrainProcessorVersion);
            Modify_TrainProcessorVersionApiCall(ref _callTrainProcessorVersion);
            _callGetProcessorVersion = clientHelper.BuildApiCall<GetProcessorVersionRequest, ProcessorVersion>("GetProcessorVersion", grpcClient.GetProcessorVersionAsync, grpcClient.GetProcessorVersion, effectiveSettings.GetProcessorVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetProcessorVersion);
            Modify_GetProcessorVersionApiCall(ref _callGetProcessorVersion);
            _callListProcessorVersions = clientHelper.BuildApiCall<ListProcessorVersionsRequest, ListProcessorVersionsResponse>("ListProcessorVersions", grpcClient.ListProcessorVersionsAsync, grpcClient.ListProcessorVersions, effectiveSettings.ListProcessorVersionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListProcessorVersions);
            Modify_ListProcessorVersionsApiCall(ref _callListProcessorVersions);
            _callDeleteProcessorVersion = clientHelper.BuildApiCall<DeleteProcessorVersionRequest, lro::Operation>("DeleteProcessorVersion", grpcClient.DeleteProcessorVersionAsync, grpcClient.DeleteProcessorVersion, effectiveSettings.DeleteProcessorVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteProcessorVersion);
            Modify_DeleteProcessorVersionApiCall(ref _callDeleteProcessorVersion);
            _callDeployProcessorVersion = clientHelper.BuildApiCall<DeployProcessorVersionRequest, lro::Operation>("DeployProcessorVersion", grpcClient.DeployProcessorVersionAsync, grpcClient.DeployProcessorVersion, effectiveSettings.DeployProcessorVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeployProcessorVersion);
            Modify_DeployProcessorVersionApiCall(ref _callDeployProcessorVersion);
            _callUndeployProcessorVersion = clientHelper.BuildApiCall<UndeployProcessorVersionRequest, lro::Operation>("UndeployProcessorVersion", grpcClient.UndeployProcessorVersionAsync, grpcClient.UndeployProcessorVersion, effectiveSettings.UndeployProcessorVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUndeployProcessorVersion);
            Modify_UndeployProcessorVersionApiCall(ref _callUndeployProcessorVersion);
            _callCreateProcessor = clientHelper.BuildApiCall<CreateProcessorRequest, Processor>("CreateProcessor", grpcClient.CreateProcessorAsync, grpcClient.CreateProcessor, effectiveSettings.CreateProcessorSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateProcessor);
            Modify_CreateProcessorApiCall(ref _callCreateProcessor);
            _callDeleteProcessor = clientHelper.BuildApiCall<DeleteProcessorRequest, lro::Operation>("DeleteProcessor", grpcClient.DeleteProcessorAsync, grpcClient.DeleteProcessor, effectiveSettings.DeleteProcessorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteProcessor);
            Modify_DeleteProcessorApiCall(ref _callDeleteProcessor);
            _callEnableProcessor = clientHelper.BuildApiCall<EnableProcessorRequest, lro::Operation>("EnableProcessor", grpcClient.EnableProcessorAsync, grpcClient.EnableProcessor, effectiveSettings.EnableProcessorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callEnableProcessor);
            Modify_EnableProcessorApiCall(ref _callEnableProcessor);
            _callDisableProcessor = clientHelper.BuildApiCall<DisableProcessorRequest, lro::Operation>("DisableProcessor", grpcClient.DisableProcessorAsync, grpcClient.DisableProcessor, effectiveSettings.DisableProcessorSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDisableProcessor);
            Modify_DisableProcessorApiCall(ref _callDisableProcessor);
            _callSetDefaultProcessorVersion = clientHelper.BuildApiCall<SetDefaultProcessorVersionRequest, lro::Operation>("SetDefaultProcessorVersion", grpcClient.SetDefaultProcessorVersionAsync, grpcClient.SetDefaultProcessorVersion, effectiveSettings.SetDefaultProcessorVersionSettings).WithGoogleRequestParam("processor", request => request.Processor);
            Modify_ApiCall(ref _callSetDefaultProcessorVersion);
            Modify_SetDefaultProcessorVersionApiCall(ref _callSetDefaultProcessorVersion);
            _callReviewDocument = clientHelper.BuildApiCall<ReviewDocumentRequest, lro::Operation>("ReviewDocument", grpcClient.ReviewDocumentAsync, grpcClient.ReviewDocument, effectiveSettings.ReviewDocumentSettings).WithGoogleRequestParam("human_review_config", request => request.HumanReviewConfig);
            Modify_ApiCall(ref _callReviewDocument);
            Modify_ReviewDocumentApiCall(ref _callReviewDocument);
            _callEvaluateProcessorVersion = clientHelper.BuildApiCall<EvaluateProcessorVersionRequest, lro::Operation>("EvaluateProcessorVersion", grpcClient.EvaluateProcessorVersionAsync, grpcClient.EvaluateProcessorVersion, effectiveSettings.EvaluateProcessorVersionSettings).WithGoogleRequestParam("processor_version", request => request.ProcessorVersion);
            Modify_ApiCall(ref _callEvaluateProcessorVersion);
            Modify_EvaluateProcessorVersionApiCall(ref _callEvaluateProcessorVersion);
            _callGetEvaluation = clientHelper.BuildApiCall<GetEvaluationRequest, Evaluation>("GetEvaluation", grpcClient.GetEvaluationAsync, grpcClient.GetEvaluation, effectiveSettings.GetEvaluationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEvaluation);
            Modify_GetEvaluationApiCall(ref _callGetEvaluation);
            _callListEvaluations = clientHelper.BuildApiCall<ListEvaluationsRequest, ListEvaluationsResponse>("ListEvaluations", grpcClient.ListEvaluationsAsync, grpcClient.ListEvaluations, effectiveSettings.ListEvaluationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEvaluations);
            Modify_ListEvaluationsApiCall(ref _callListEvaluations);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ProcessDocumentApiCall(ref gaxgrpc::ApiCall<ProcessRequest, ProcessResponse> call);

        partial void Modify_BatchProcessDocumentsApiCall(ref gaxgrpc::ApiCall<BatchProcessRequest, lro::Operation> call);

        partial void Modify_FetchProcessorTypesApiCall(ref gaxgrpc::ApiCall<FetchProcessorTypesRequest, FetchProcessorTypesResponse> call);

        partial void Modify_ListProcessorTypesApiCall(ref gaxgrpc::ApiCall<ListProcessorTypesRequest, ListProcessorTypesResponse> call);

        partial void Modify_GetProcessorTypeApiCall(ref gaxgrpc::ApiCall<GetProcessorTypeRequest, ProcessorType> call);

        partial void Modify_ListProcessorsApiCall(ref gaxgrpc::ApiCall<ListProcessorsRequest, ListProcessorsResponse> call);

        partial void Modify_GetProcessorApiCall(ref gaxgrpc::ApiCall<GetProcessorRequest, Processor> call);

        partial void Modify_TrainProcessorVersionApiCall(ref gaxgrpc::ApiCall<TrainProcessorVersionRequest, lro::Operation> call);

        partial void Modify_GetProcessorVersionApiCall(ref gaxgrpc::ApiCall<GetProcessorVersionRequest, ProcessorVersion> call);

        partial void Modify_ListProcessorVersionsApiCall(ref gaxgrpc::ApiCall<ListProcessorVersionsRequest, ListProcessorVersionsResponse> call);

        partial void Modify_DeleteProcessorVersionApiCall(ref gaxgrpc::ApiCall<DeleteProcessorVersionRequest, lro::Operation> call);

        partial void Modify_DeployProcessorVersionApiCall(ref gaxgrpc::ApiCall<DeployProcessorVersionRequest, lro::Operation> call);

        partial void Modify_UndeployProcessorVersionApiCall(ref gaxgrpc::ApiCall<UndeployProcessorVersionRequest, lro::Operation> call);

        partial void Modify_CreateProcessorApiCall(ref gaxgrpc::ApiCall<CreateProcessorRequest, Processor> call);

        partial void Modify_DeleteProcessorApiCall(ref gaxgrpc::ApiCall<DeleteProcessorRequest, lro::Operation> call);

        partial void Modify_EnableProcessorApiCall(ref gaxgrpc::ApiCall<EnableProcessorRequest, lro::Operation> call);

        partial void Modify_DisableProcessorApiCall(ref gaxgrpc::ApiCall<DisableProcessorRequest, lro::Operation> call);

        partial void Modify_SetDefaultProcessorVersionApiCall(ref gaxgrpc::ApiCall<SetDefaultProcessorVersionRequest, lro::Operation> call);

        partial void Modify_ReviewDocumentApiCall(ref gaxgrpc::ApiCall<ReviewDocumentRequest, lro::Operation> call);

        partial void Modify_EvaluateProcessorVersionApiCall(ref gaxgrpc::ApiCall<EvaluateProcessorVersionRequest, lro::Operation> call);

        partial void Modify_GetEvaluationApiCall(ref gaxgrpc::ApiCall<GetEvaluationRequest, Evaluation> call);

        partial void Modify_ListEvaluationsApiCall(ref gaxgrpc::ApiCall<ListEvaluationsRequest, ListEvaluationsResponse> call);

        partial void OnConstruction(DocumentProcessorService.DocumentProcessorServiceClient grpcClient, DocumentProcessorServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DocumentProcessorService client</summary>
        public override DocumentProcessorService.DocumentProcessorServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ProcessRequest(ref ProcessRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_BatchProcessRequest(ref BatchProcessRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FetchProcessorTypesRequest(ref FetchProcessorTypesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListProcessorTypesRequest(ref ListProcessorTypesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetProcessorTypeRequest(ref GetProcessorTypeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListProcessorsRequest(ref ListProcessorsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetProcessorRequest(ref GetProcessorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TrainProcessorVersionRequest(ref TrainProcessorVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetProcessorVersionRequest(ref GetProcessorVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListProcessorVersionsRequest(ref ListProcessorVersionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteProcessorVersionRequest(ref DeleteProcessorVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeployProcessorVersionRequest(ref DeployProcessorVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UndeployProcessorVersionRequest(ref UndeployProcessorVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateProcessorRequest(ref CreateProcessorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteProcessorRequest(ref DeleteProcessorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_EnableProcessorRequest(ref EnableProcessorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DisableProcessorRequest(ref DisableProcessorRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SetDefaultProcessorVersionRequest(ref SetDefaultProcessorVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReviewDocumentRequest(ref ReviewDocumentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_EvaluateProcessorVersionRequest(ref EvaluateProcessorVersionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEvaluationRequest(ref GetEvaluationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEvaluationsRequest(ref ListEvaluationsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Processes a single document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ProcessResponse ProcessDocument(ProcessRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ProcessRequest(ref request, ref callSettings);
            return _callProcessDocument.Sync(request, callSettings);
        }

        /// <summary>
        /// Processes a single document.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ProcessResponse> ProcessDocumentAsync(ProcessRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ProcessRequest(ref request, ref callSettings);
            return _callProcessDocument.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>BatchProcessDocuments</c>.</summary>
        public override lro::OperationsClient BatchProcessDocumentsOperationsClient { get; }

        /// <summary>
        /// LRO endpoint to batch process many documents. The output is written
        /// to Cloud Storage as JSON in the [Document] format.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<BatchProcessResponse, BatchProcessMetadata> BatchProcessDocuments(BatchProcessRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchProcessRequest(ref request, ref callSettings);
            return new lro::Operation<BatchProcessResponse, BatchProcessMetadata>(_callBatchProcessDocuments.Sync(request, callSettings), BatchProcessDocumentsOperationsClient);
        }

        /// <summary>
        /// LRO endpoint to batch process many documents. The output is written
        /// to Cloud Storage as JSON in the [Document] format.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<BatchProcessResponse, BatchProcessMetadata>> BatchProcessDocumentsAsync(BatchProcessRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchProcessRequest(ref request, ref callSettings);
            return new lro::Operation<BatchProcessResponse, BatchProcessMetadata>(await _callBatchProcessDocuments.Async(request, callSettings).ConfigureAwait(false), BatchProcessDocumentsOperationsClient);
        }

        /// <summary>
        /// Fetches processor types. Note that we don't use
        /// [ListProcessorTypes][google.cloud.documentai.v1.DocumentProcessorService.ListProcessorTypes]
        /// here, because it isn't paginated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FetchProcessorTypesResponse FetchProcessorTypes(FetchProcessorTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchProcessorTypesRequest(ref request, ref callSettings);
            return _callFetchProcessorTypes.Sync(request, callSettings);
        }

        /// <summary>
        /// Fetches processor types. Note that we don't use
        /// [ListProcessorTypes][google.cloud.documentai.v1.DocumentProcessorService.ListProcessorTypes]
        /// here, because it isn't paginated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FetchProcessorTypesResponse> FetchProcessorTypesAsync(FetchProcessorTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchProcessorTypesRequest(ref request, ref callSettings);
            return _callFetchProcessorTypes.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the processor types that exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ProcessorType"/> resources.</returns>
        public override gax::PagedEnumerable<ListProcessorTypesResponse, ProcessorType> ListProcessorTypes(ListProcessorTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProcessorTypesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListProcessorTypesRequest, ListProcessorTypesResponse, ProcessorType>(_callListProcessorTypes, request, callSettings);
        }

        /// <summary>
        /// Lists the processor types that exist.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ProcessorType"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListProcessorTypesResponse, ProcessorType> ListProcessorTypesAsync(ListProcessorTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProcessorTypesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListProcessorTypesRequest, ListProcessorTypesResponse, ProcessorType>(_callListProcessorTypes, request, callSettings);
        }

        /// <summary>
        /// Gets a processor type detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ProcessorType GetProcessorType(GetProcessorTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProcessorTypeRequest(ref request, ref callSettings);
            return _callGetProcessorType.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a processor type detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ProcessorType> GetProcessorTypeAsync(GetProcessorTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProcessorTypeRequest(ref request, ref callSettings);
            return _callGetProcessorType.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all processors which belong to this project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Processor"/> resources.</returns>
        public override gax::PagedEnumerable<ListProcessorsResponse, Processor> ListProcessors(ListProcessorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProcessorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListProcessorsRequest, ListProcessorsResponse, Processor>(_callListProcessors, request, callSettings);
        }

        /// <summary>
        /// Lists all processors which belong to this project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Processor"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListProcessorsResponse, Processor> ListProcessorsAsync(ListProcessorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProcessorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListProcessorsRequest, ListProcessorsResponse, Processor>(_callListProcessors, request, callSettings);
        }

        /// <summary>
        /// Gets a processor detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Processor GetProcessor(GetProcessorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProcessorRequest(ref request, ref callSettings);
            return _callGetProcessor.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a processor detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Processor> GetProcessorAsync(GetProcessorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProcessorRequest(ref request, ref callSettings);
            return _callGetProcessor.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>TrainProcessorVersion</c>.</summary>
        public override lro::OperationsClient TrainProcessorVersionOperationsClient { get; }

        /// <summary>
        /// Trains a new processor version.
        /// Operation metadata is returned as
        /// [TrainProcessorVersionMetadata][google.cloud.documentai.v1.TrainProcessorVersionMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<TrainProcessorVersionResponse, TrainProcessorVersionMetadata> TrainProcessorVersion(TrainProcessorVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TrainProcessorVersionRequest(ref request, ref callSettings);
            return new lro::Operation<TrainProcessorVersionResponse, TrainProcessorVersionMetadata>(_callTrainProcessorVersion.Sync(request, callSettings), TrainProcessorVersionOperationsClient);
        }

        /// <summary>
        /// Trains a new processor version.
        /// Operation metadata is returned as
        /// [TrainProcessorVersionMetadata][google.cloud.documentai.v1.TrainProcessorVersionMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<TrainProcessorVersionResponse, TrainProcessorVersionMetadata>> TrainProcessorVersionAsync(TrainProcessorVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TrainProcessorVersionRequest(ref request, ref callSettings);
            return new lro::Operation<TrainProcessorVersionResponse, TrainProcessorVersionMetadata>(await _callTrainProcessorVersion.Async(request, callSettings).ConfigureAwait(false), TrainProcessorVersionOperationsClient);
        }

        /// <summary>
        /// Gets a processor version detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ProcessorVersion GetProcessorVersion(GetProcessorVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProcessorVersionRequest(ref request, ref callSettings);
            return _callGetProcessorVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a processor version detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ProcessorVersion> GetProcessorVersionAsync(GetProcessorVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProcessorVersionRequest(ref request, ref callSettings);
            return _callGetProcessorVersion.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all versions of a processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ProcessorVersion"/> resources.</returns>
        public override gax::PagedEnumerable<ListProcessorVersionsResponse, ProcessorVersion> ListProcessorVersions(ListProcessorVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProcessorVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListProcessorVersionsRequest, ListProcessorVersionsResponse, ProcessorVersion>(_callListProcessorVersions, request, callSettings);
        }

        /// <summary>
        /// Lists all versions of a processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ProcessorVersion"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListProcessorVersionsResponse, ProcessorVersion> ListProcessorVersionsAsync(ListProcessorVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProcessorVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListProcessorVersionsRequest, ListProcessorVersionsResponse, ProcessorVersion>(_callListProcessorVersions, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteProcessorVersion</c>.</summary>
        public override lro::OperationsClient DeleteProcessorVersionOperationsClient { get; }

        /// <summary>
        /// Deletes the processor version, all artifacts under the processor version
        /// will be deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteProcessorVersionMetadata> DeleteProcessorVersion(DeleteProcessorVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteProcessorVersionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteProcessorVersionMetadata>(_callDeleteProcessorVersion.Sync(request, callSettings), DeleteProcessorVersionOperationsClient);
        }

        /// <summary>
        /// Deletes the processor version, all artifacts under the processor version
        /// will be deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteProcessorVersionMetadata>> DeleteProcessorVersionAsync(DeleteProcessorVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteProcessorVersionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteProcessorVersionMetadata>(await _callDeleteProcessorVersion.Async(request, callSettings).ConfigureAwait(false), DeleteProcessorVersionOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeployProcessorVersion</c>.</summary>
        public override lro::OperationsClient DeployProcessorVersionOperationsClient { get; }

        /// <summary>
        /// Deploys the processor version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DeployProcessorVersionResponse, DeployProcessorVersionMetadata> DeployProcessorVersion(DeployProcessorVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeployProcessorVersionRequest(ref request, ref callSettings);
            return new lro::Operation<DeployProcessorVersionResponse, DeployProcessorVersionMetadata>(_callDeployProcessorVersion.Sync(request, callSettings), DeployProcessorVersionOperationsClient);
        }

        /// <summary>
        /// Deploys the processor version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DeployProcessorVersionResponse, DeployProcessorVersionMetadata>> DeployProcessorVersionAsync(DeployProcessorVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeployProcessorVersionRequest(ref request, ref callSettings);
            return new lro::Operation<DeployProcessorVersionResponse, DeployProcessorVersionMetadata>(await _callDeployProcessorVersion.Async(request, callSettings).ConfigureAwait(false), DeployProcessorVersionOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UndeployProcessorVersion</c>.</summary>
        public override lro::OperationsClient UndeployProcessorVersionOperationsClient { get; }

        /// <summary>
        /// Undeploys the processor version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<UndeployProcessorVersionResponse, UndeployProcessorVersionMetadata> UndeployProcessorVersion(UndeployProcessorVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeployProcessorVersionRequest(ref request, ref callSettings);
            return new lro::Operation<UndeployProcessorVersionResponse, UndeployProcessorVersionMetadata>(_callUndeployProcessorVersion.Sync(request, callSettings), UndeployProcessorVersionOperationsClient);
        }

        /// <summary>
        /// Undeploys the processor version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<UndeployProcessorVersionResponse, UndeployProcessorVersionMetadata>> UndeployProcessorVersionAsync(UndeployProcessorVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeployProcessorVersionRequest(ref request, ref callSettings);
            return new lro::Operation<UndeployProcessorVersionResponse, UndeployProcessorVersionMetadata>(await _callUndeployProcessorVersion.Async(request, callSettings).ConfigureAwait(false), UndeployProcessorVersionOperationsClient);
        }

        /// <summary>
        /// Creates a processor from the
        /// [ProcessorType][google.cloud.documentai.v1.ProcessorType] provided. The
        /// processor will be at `ENABLED` state by default after its creation. Note
        /// that this method requires the `documentai.processors.create` permission on
        /// the project, which is highly privileged. A user or service account with
        /// this permission can create new processors that can interact with any gcs
        /// bucket in your project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Processor CreateProcessor(CreateProcessorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateProcessorRequest(ref request, ref callSettings);
            return _callCreateProcessor.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a processor from the
        /// [ProcessorType][google.cloud.documentai.v1.ProcessorType] provided. The
        /// processor will be at `ENABLED` state by default after its creation. Note
        /// that this method requires the `documentai.processors.create` permission on
        /// the project, which is highly privileged. A user or service account with
        /// this permission can create new processors that can interact with any gcs
        /// bucket in your project.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Processor> CreateProcessorAsync(CreateProcessorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateProcessorRequest(ref request, ref callSettings);
            return _callCreateProcessor.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteProcessor</c>.</summary>
        public override lro::OperationsClient DeleteProcessorOperationsClient { get; }

        /// <summary>
        /// Deletes the processor, unloads all deployed model artifacts if it was
        /// enabled and then deletes all artifacts associated with this processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, DeleteProcessorMetadata> DeleteProcessor(DeleteProcessorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteProcessorRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteProcessorMetadata>(_callDeleteProcessor.Sync(request, callSettings), DeleteProcessorOperationsClient);
        }

        /// <summary>
        /// Deletes the processor, unloads all deployed model artifacts if it was
        /// enabled and then deletes all artifacts associated with this processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, DeleteProcessorMetadata>> DeleteProcessorAsync(DeleteProcessorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteProcessorRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, DeleteProcessorMetadata>(await _callDeleteProcessor.Async(request, callSettings).ConfigureAwait(false), DeleteProcessorOperationsClient);
        }

        /// <summary>The long-running operations client for <c>EnableProcessor</c>.</summary>
        public override lro::OperationsClient EnableProcessorOperationsClient { get; }

        /// <summary>
        /// Enables a processor
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<EnableProcessorResponse, EnableProcessorMetadata> EnableProcessor(EnableProcessorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnableProcessorRequest(ref request, ref callSettings);
            return new lro::Operation<EnableProcessorResponse, EnableProcessorMetadata>(_callEnableProcessor.Sync(request, callSettings), EnableProcessorOperationsClient);
        }

        /// <summary>
        /// Enables a processor
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<EnableProcessorResponse, EnableProcessorMetadata>> EnableProcessorAsync(EnableProcessorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnableProcessorRequest(ref request, ref callSettings);
            return new lro::Operation<EnableProcessorResponse, EnableProcessorMetadata>(await _callEnableProcessor.Async(request, callSettings).ConfigureAwait(false), EnableProcessorOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DisableProcessor</c>.</summary>
        public override lro::OperationsClient DisableProcessorOperationsClient { get; }

        /// <summary>
        /// Disables a processor
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DisableProcessorResponse, DisableProcessorMetadata> DisableProcessor(DisableProcessorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DisableProcessorRequest(ref request, ref callSettings);
            return new lro::Operation<DisableProcessorResponse, DisableProcessorMetadata>(_callDisableProcessor.Sync(request, callSettings), DisableProcessorOperationsClient);
        }

        /// <summary>
        /// Disables a processor
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DisableProcessorResponse, DisableProcessorMetadata>> DisableProcessorAsync(DisableProcessorRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DisableProcessorRequest(ref request, ref callSettings);
            return new lro::Operation<DisableProcessorResponse, DisableProcessorMetadata>(await _callDisableProcessor.Async(request, callSettings).ConfigureAwait(false), DisableProcessorOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SetDefaultProcessorVersion</c>.</summary>
        public override lro::OperationsClient SetDefaultProcessorVersionOperationsClient { get; }

        /// <summary>
        /// Set the default (active) version of a
        /// [Processor][google.cloud.documentai.v1.Processor] that will be used in
        /// [ProcessDocument][google.cloud.documentai.v1.DocumentProcessorService.ProcessDocument]
        /// and
        /// [BatchProcessDocuments][google.cloud.documentai.v1.DocumentProcessorService.BatchProcessDocuments].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<SetDefaultProcessorVersionResponse, SetDefaultProcessorVersionMetadata> SetDefaultProcessorVersion(SetDefaultProcessorVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetDefaultProcessorVersionRequest(ref request, ref callSettings);
            return new lro::Operation<SetDefaultProcessorVersionResponse, SetDefaultProcessorVersionMetadata>(_callSetDefaultProcessorVersion.Sync(request, callSettings), SetDefaultProcessorVersionOperationsClient);
        }

        /// <summary>
        /// Set the default (active) version of a
        /// [Processor][google.cloud.documentai.v1.Processor] that will be used in
        /// [ProcessDocument][google.cloud.documentai.v1.DocumentProcessorService.ProcessDocument]
        /// and
        /// [BatchProcessDocuments][google.cloud.documentai.v1.DocumentProcessorService.BatchProcessDocuments].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<SetDefaultProcessorVersionResponse, SetDefaultProcessorVersionMetadata>> SetDefaultProcessorVersionAsync(SetDefaultProcessorVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SetDefaultProcessorVersionRequest(ref request, ref callSettings);
            return new lro::Operation<SetDefaultProcessorVersionResponse, SetDefaultProcessorVersionMetadata>(await _callSetDefaultProcessorVersion.Async(request, callSettings).ConfigureAwait(false), SetDefaultProcessorVersionOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ReviewDocument</c>.</summary>
        public override lro::OperationsClient ReviewDocumentOperationsClient { get; }

        /// <summary>
        /// Send a document for Human Review. The input document should be processed by
        /// the specified processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata> ReviewDocument(ReviewDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReviewDocumentRequest(ref request, ref callSettings);
            return new lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata>(_callReviewDocument.Sync(request, callSettings), ReviewDocumentOperationsClient);
        }

        /// <summary>
        /// Send a document for Human Review. The input document should be processed by
        /// the specified processor.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata>> ReviewDocumentAsync(ReviewDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReviewDocumentRequest(ref request, ref callSettings);
            return new lro::Operation<ReviewDocumentResponse, ReviewDocumentOperationMetadata>(await _callReviewDocument.Async(request, callSettings).ConfigureAwait(false), ReviewDocumentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>EvaluateProcessorVersion</c>.</summary>
        public override lro::OperationsClient EvaluateProcessorVersionOperationsClient { get; }

        /// <summary>
        /// Evaluates a ProcessorVersion against annotated documents, producing an
        /// Evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<EvaluateProcessorVersionResponse, EvaluateProcessorVersionMetadata> EvaluateProcessorVersion(EvaluateProcessorVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EvaluateProcessorVersionRequest(ref request, ref callSettings);
            return new lro::Operation<EvaluateProcessorVersionResponse, EvaluateProcessorVersionMetadata>(_callEvaluateProcessorVersion.Sync(request, callSettings), EvaluateProcessorVersionOperationsClient);
        }

        /// <summary>
        /// Evaluates a ProcessorVersion against annotated documents, producing an
        /// Evaluation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<EvaluateProcessorVersionResponse, EvaluateProcessorVersionMetadata>> EvaluateProcessorVersionAsync(EvaluateProcessorVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EvaluateProcessorVersionRequest(ref request, ref callSettings);
            return new lro::Operation<EvaluateProcessorVersionResponse, EvaluateProcessorVersionMetadata>(await _callEvaluateProcessorVersion.Async(request, callSettings).ConfigureAwait(false), EvaluateProcessorVersionOperationsClient);
        }

        /// <summary>
        /// Retrieves a specific evaluation.
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
        /// Retrieves a specific evaluation.
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
        /// Retrieves a set of evaluations for a given processor version.
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
        /// Retrieves a set of evaluations for a given processor version.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Evaluation"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEvaluationsResponse, Evaluation> ListEvaluationsAsync(ListEvaluationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEvaluationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEvaluationsRequest, ListEvaluationsResponse, Evaluation>(_callListEvaluations, request, callSettings);
        }
    }

    public partial class ListProcessorTypesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListProcessorsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListProcessorVersionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEvaluationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListProcessorTypesResponse : gaxgrpc::IPageResponse<ProcessorType>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ProcessorType> GetEnumerator() => ProcessorTypes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListProcessorsResponse : gaxgrpc::IPageResponse<Processor>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Processor> GetEnumerator() => Processors.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListProcessorVersionsResponse : gaxgrpc::IPageResponse<ProcessorVersion>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ProcessorVersion> GetEnumerator() => ProcessorVersions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListEvaluationsResponse : gaxgrpc::IPageResponse<Evaluation>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Evaluation> GetEnumerator() => Evaluations.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class DocumentProcessorService
    {
        public partial class DocumentProcessorServiceClient
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

    public static partial class DocumentProcessorService
    {
        public partial class DocumentProcessorServiceClient
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
