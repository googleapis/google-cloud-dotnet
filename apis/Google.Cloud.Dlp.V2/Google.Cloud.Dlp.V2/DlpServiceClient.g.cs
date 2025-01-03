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
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.Dlp.V2
{
    /// <summary>Settings for <see cref="DlpServiceClient"/> instances.</summary>
    public sealed partial class DlpServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DlpServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DlpServiceSettings"/>.</returns>
        public static DlpServiceSettings GetDefault() => new DlpServiceSettings();

        /// <summary>Constructs a new <see cref="DlpServiceSettings"/> object with default settings.</summary>
        public DlpServiceSettings()
        {
        }

        private DlpServiceSettings(DlpServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            InspectContentSettings = existing.InspectContentSettings;
            RedactImageSettings = existing.RedactImageSettings;
            DeidentifyContentSettings = existing.DeidentifyContentSettings;
            ReidentifyContentSettings = existing.ReidentifyContentSettings;
            ListInfoTypesSettings = existing.ListInfoTypesSettings;
            CreateInspectTemplateSettings = existing.CreateInspectTemplateSettings;
            UpdateInspectTemplateSettings = existing.UpdateInspectTemplateSettings;
            GetInspectTemplateSettings = existing.GetInspectTemplateSettings;
            ListInspectTemplatesSettings = existing.ListInspectTemplatesSettings;
            DeleteInspectTemplateSettings = existing.DeleteInspectTemplateSettings;
            CreateDeidentifyTemplateSettings = existing.CreateDeidentifyTemplateSettings;
            UpdateDeidentifyTemplateSettings = existing.UpdateDeidentifyTemplateSettings;
            GetDeidentifyTemplateSettings = existing.GetDeidentifyTemplateSettings;
            ListDeidentifyTemplatesSettings = existing.ListDeidentifyTemplatesSettings;
            DeleteDeidentifyTemplateSettings = existing.DeleteDeidentifyTemplateSettings;
            CreateJobTriggerSettings = existing.CreateJobTriggerSettings;
            UpdateJobTriggerSettings = existing.UpdateJobTriggerSettings;
            HybridInspectJobTriggerSettings = existing.HybridInspectJobTriggerSettings;
            GetJobTriggerSettings = existing.GetJobTriggerSettings;
            ListJobTriggersSettings = existing.ListJobTriggersSettings;
            DeleteJobTriggerSettings = existing.DeleteJobTriggerSettings;
            ActivateJobTriggerSettings = existing.ActivateJobTriggerSettings;
            CreateDiscoveryConfigSettings = existing.CreateDiscoveryConfigSettings;
            UpdateDiscoveryConfigSettings = existing.UpdateDiscoveryConfigSettings;
            GetDiscoveryConfigSettings = existing.GetDiscoveryConfigSettings;
            ListDiscoveryConfigsSettings = existing.ListDiscoveryConfigsSettings;
            DeleteDiscoveryConfigSettings = existing.DeleteDiscoveryConfigSettings;
            CreateDlpJobSettings = existing.CreateDlpJobSettings;
            ListDlpJobsSettings = existing.ListDlpJobsSettings;
            GetDlpJobSettings = existing.GetDlpJobSettings;
            DeleteDlpJobSettings = existing.DeleteDlpJobSettings;
            CancelDlpJobSettings = existing.CancelDlpJobSettings;
            CreateStoredInfoTypeSettings = existing.CreateStoredInfoTypeSettings;
            UpdateStoredInfoTypeSettings = existing.UpdateStoredInfoTypeSettings;
            GetStoredInfoTypeSettings = existing.GetStoredInfoTypeSettings;
            ListStoredInfoTypesSettings = existing.ListStoredInfoTypesSettings;
            DeleteStoredInfoTypeSettings = existing.DeleteStoredInfoTypeSettings;
            ListProjectDataProfilesSettings = existing.ListProjectDataProfilesSettings;
            ListTableDataProfilesSettings = existing.ListTableDataProfilesSettings;
            ListColumnDataProfilesSettings = existing.ListColumnDataProfilesSettings;
            GetProjectDataProfileSettings = existing.GetProjectDataProfileSettings;
            ListFileStoreDataProfilesSettings = existing.ListFileStoreDataProfilesSettings;
            GetFileStoreDataProfileSettings = existing.GetFileStoreDataProfileSettings;
            DeleteFileStoreDataProfileSettings = existing.DeleteFileStoreDataProfileSettings;
            GetTableDataProfileSettings = existing.GetTableDataProfileSettings;
            GetColumnDataProfileSettings = existing.GetColumnDataProfileSettings;
            DeleteTableDataProfileSettings = existing.DeleteTableDataProfileSettings;
            HybridInspectDlpJobSettings = existing.HybridInspectDlpJobSettings;
            FinishDlpJobSettings = existing.FinishDlpJobSettings;
            CreateConnectionSettings = existing.CreateConnectionSettings;
            GetConnectionSettings = existing.GetConnectionSettings;
            ListConnectionsSettings = existing.ListConnectionsSettings;
            SearchConnectionsSettings = existing.SearchConnectionsSettings;
            DeleteConnectionSettings = existing.DeleteConnectionSettings;
            UpdateConnectionSettings = existing.UpdateConnectionSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DlpServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.InspectContent</c> and <c>DlpServiceClient.InspectContentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings InspectContentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.RedactImage</c> and <c>DlpServiceClient.RedactImageAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RedactImageSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.DeidentifyContent</c> and <c>DlpServiceClient.DeidentifyContentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeidentifyContentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.ReidentifyContent</c> and <c>DlpServiceClient.ReidentifyContentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ReidentifyContentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.ListInfoTypes</c> and <c>DlpServiceClient.ListInfoTypesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListInfoTypesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.CreateInspectTemplate</c> and <c>DlpServiceClient.CreateInspectTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateInspectTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.UpdateInspectTemplate</c> and <c>DlpServiceClient.UpdateInspectTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateInspectTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.GetInspectTemplate</c> and <c>DlpServiceClient.GetInspectTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetInspectTemplateSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.ListInspectTemplates</c> and <c>DlpServiceClient.ListInspectTemplatesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListInspectTemplatesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.DeleteInspectTemplate</c> and <c>DlpServiceClient.DeleteInspectTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteInspectTemplateSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.CreateDeidentifyTemplate</c> and <c>DlpServiceClient.CreateDeidentifyTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDeidentifyTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.UpdateDeidentifyTemplate</c> and <c>DlpServiceClient.UpdateDeidentifyTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDeidentifyTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.GetDeidentifyTemplate</c> and <c>DlpServiceClient.GetDeidentifyTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDeidentifyTemplateSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.ListDeidentifyTemplates</c> and <c>DlpServiceClient.ListDeidentifyTemplatesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDeidentifyTemplatesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.DeleteDeidentifyTemplate</c> and <c>DlpServiceClient.DeleteDeidentifyTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDeidentifyTemplateSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.CreateJobTrigger</c> and <c>DlpServiceClient.CreateJobTriggerAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateJobTriggerSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.UpdateJobTrigger</c> and <c>DlpServiceClient.UpdateJobTriggerAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateJobTriggerSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.HybridInspectJobTrigger</c> and <c>DlpServiceClient.HybridInspectJobTriggerAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings HybridInspectJobTriggerSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.GetJobTrigger</c> and <c>DlpServiceClient.GetJobTriggerAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetJobTriggerSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.ListJobTriggers</c> and <c>DlpServiceClient.ListJobTriggersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListJobTriggersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.DeleteJobTrigger</c> and <c>DlpServiceClient.DeleteJobTriggerAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteJobTriggerSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.ActivateJobTrigger</c> and <c>DlpServiceClient.ActivateJobTriggerAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ActivateJobTriggerSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.CreateDiscoveryConfig</c> and <c>DlpServiceClient.CreateDiscoveryConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDiscoveryConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.UpdateDiscoveryConfig</c> and <c>DlpServiceClient.UpdateDiscoveryConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDiscoveryConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.GetDiscoveryConfig</c> and <c>DlpServiceClient.GetDiscoveryConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDiscoveryConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.ListDiscoveryConfigs</c> and <c>DlpServiceClient.ListDiscoveryConfigsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDiscoveryConfigsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.DeleteDiscoveryConfig</c> and <c>DlpServiceClient.DeleteDiscoveryConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDiscoveryConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.CreateDlpJob</c> and <c>DlpServiceClient.CreateDlpJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDlpJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.ListDlpJobs</c> and <c>DlpServiceClient.ListDlpJobsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDlpJobsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DlpServiceClient.GetDlpJob</c>
        ///  and <c>DlpServiceClient.GetDlpJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDlpJobSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.DeleteDlpJob</c> and <c>DlpServiceClient.DeleteDlpJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDlpJobSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.CancelDlpJob</c> and <c>DlpServiceClient.CancelDlpJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CancelDlpJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.CreateStoredInfoType</c> and <c>DlpServiceClient.CreateStoredInfoTypeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateStoredInfoTypeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.UpdateStoredInfoType</c> and <c>DlpServiceClient.UpdateStoredInfoTypeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateStoredInfoTypeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.GetStoredInfoType</c> and <c>DlpServiceClient.GetStoredInfoTypeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetStoredInfoTypeSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.ListStoredInfoTypes</c> and <c>DlpServiceClient.ListStoredInfoTypesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListStoredInfoTypesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.DeleteStoredInfoType</c> and <c>DlpServiceClient.DeleteStoredInfoTypeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteStoredInfoTypeSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.ListProjectDataProfiles</c> and <c>DlpServiceClient.ListProjectDataProfilesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListProjectDataProfilesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.ListTableDataProfiles</c> and <c>DlpServiceClient.ListTableDataProfilesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListTableDataProfilesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.ListColumnDataProfiles</c> and <c>DlpServiceClient.ListColumnDataProfilesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListColumnDataProfilesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.GetProjectDataProfile</c> and <c>DlpServiceClient.GetProjectDataProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetProjectDataProfileSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.ListFileStoreDataProfiles</c> and <c>DlpServiceClient.ListFileStoreDataProfilesAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListFileStoreDataProfilesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.GetFileStoreDataProfile</c> and <c>DlpServiceClient.GetFileStoreDataProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetFileStoreDataProfileSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.DeleteFileStoreDataProfile</c> and <c>DlpServiceClient.DeleteFileStoreDataProfileAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteFileStoreDataProfileSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.GetTableDataProfile</c> and <c>DlpServiceClient.GetTableDataProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetTableDataProfileSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.GetColumnDataProfile</c> and <c>DlpServiceClient.GetColumnDataProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetColumnDataProfileSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.DeleteTableDataProfile</c> and <c>DlpServiceClient.DeleteTableDataProfileAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTableDataProfileSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.HybridInspectDlpJob</c> and <c>DlpServiceClient.HybridInspectDlpJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings HybridInspectDlpJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.FinishDlpJob</c> and <c>DlpServiceClient.FinishDlpJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 300 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FinishDlpJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.CreateConnection</c> and <c>DlpServiceClient.CreateConnectionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateConnectionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.GetConnection</c> and <c>DlpServiceClient.GetConnectionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetConnectionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.ListConnections</c> and <c>DlpServiceClient.ListConnectionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListConnectionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.SearchConnections</c> and <c>DlpServiceClient.SearchConnectionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchConnectionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.DeleteConnection</c> and <c>DlpServiceClient.DeleteConnectionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteConnectionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DlpServiceClient.UpdateConnection</c> and <c>DlpServiceClient.UpdateConnectionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateConnectionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DlpServiceSettings"/> object.</returns>
        public DlpServiceSettings Clone() => new DlpServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DlpServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class DlpServiceClientBuilder : gaxgrpc::ClientBuilderBase<DlpServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DlpServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DlpServiceClientBuilder() : base(DlpServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DlpServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DlpServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DlpServiceClient Build()
        {
            DlpServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DlpServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DlpServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DlpServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DlpServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DlpServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DlpServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DlpServiceClient.ChannelPool;
    }

    /// <summary>DlpService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Sensitive Data Protection provides access to a powerful sensitive data
    /// inspection, classification, and de-identification platform that works
    /// on text, images, and Google Cloud storage repositories.
    /// To learn more about concepts and find how-to guides see
    /// https://cloud.google.com/sensitive-data-protection/docs/.
    /// </remarks>
    public abstract partial class DlpServiceClient
    {
        /// <summary>
        /// The default endpoint for the DlpService service, which is a host of "dlp.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dlp.googleapis.com:443";

        /// <summary>The default DlpService scopes.</summary>
        /// <remarks>
        /// The default DlpService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DlpService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DlpServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DlpServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DlpServiceClient"/>.</returns>
        public static stt::Task<DlpServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DlpServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DlpServiceClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="DlpServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DlpServiceClient"/>.</returns>
        public static DlpServiceClient Create() => new DlpServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DlpServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DlpServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DlpServiceClient"/>.</returns>
        internal static DlpServiceClient Create(grpccore::CallInvoker callInvoker, DlpServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DlpService.DlpServiceClient grpcClient = new DlpService.DlpServiceClient(callInvoker);
            return new DlpServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DlpService client</summary>
        public virtual DlpService.DlpServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Finds potentially sensitive info in content.
        /// This method has limits on input size, processing time, and output size.
        /// 
        /// When no InfoTypes or CustomInfoTypes are specified in this request, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        /// 
        /// For how to guides, see
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-images
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-text,
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InspectContentResponse InspectContent(InspectContentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Finds potentially sensitive info in content.
        /// This method has limits on input size, processing time, and output size.
        /// 
        /// When no InfoTypes or CustomInfoTypes are specified in this request, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        /// 
        /// For how to guides, see
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-images
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-text,
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InspectContentResponse> InspectContentAsync(InspectContentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Finds potentially sensitive info in content.
        /// This method has limits on input size, processing time, and output size.
        /// 
        /// When no InfoTypes or CustomInfoTypes are specified in this request, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        /// 
        /// For how to guides, see
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-images
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-text,
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InspectContentResponse> InspectContentAsync(InspectContentRequest request, st::CancellationToken cancellationToken) =>
            InspectContentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Redacts potentially sensitive info from an image.
        /// This method has limits on input size, processing time, and output size.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/redacting-sensitive-data-images
        /// to learn more.
        /// 
        /// When no InfoTypes or CustomInfoTypes are specified in this request, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RedactImageResponse RedactImage(RedactImageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Redacts potentially sensitive info from an image.
        /// This method has limits on input size, processing time, and output size.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/redacting-sensitive-data-images
        /// to learn more.
        /// 
        /// When no InfoTypes or CustomInfoTypes are specified in this request, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RedactImageResponse> RedactImageAsync(RedactImageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Redacts potentially sensitive info from an image.
        /// This method has limits on input size, processing time, and output size.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/redacting-sensitive-data-images
        /// to learn more.
        /// 
        /// When no InfoTypes or CustomInfoTypes are specified in this request, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RedactImageResponse> RedactImageAsync(RedactImageRequest request, st::CancellationToken cancellationToken) =>
            RedactImageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// De-identifies potentially sensitive info from a ContentItem.
        /// This method has limits on input size and output size.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/deidentify-sensitive-data
        /// to learn more.
        /// 
        /// When no InfoTypes or CustomInfoTypes are specified in this request, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeidentifyContentResponse DeidentifyContent(DeidentifyContentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// De-identifies potentially sensitive info from a ContentItem.
        /// This method has limits on input size and output size.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/deidentify-sensitive-data
        /// to learn more.
        /// 
        /// When no InfoTypes or CustomInfoTypes are specified in this request, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeidentifyContentResponse> DeidentifyContentAsync(DeidentifyContentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// De-identifies potentially sensitive info from a ContentItem.
        /// This method has limits on input size and output size.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/deidentify-sensitive-data
        /// to learn more.
        /// 
        /// When no InfoTypes or CustomInfoTypes are specified in this request, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeidentifyContentResponse> DeidentifyContentAsync(DeidentifyContentRequest request, st::CancellationToken cancellationToken) =>
            DeidentifyContentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Re-identifies content that has been de-identified.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/pseudonymization#re-identification_in_free_text_code_example
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReidentifyContentResponse ReidentifyContent(ReidentifyContentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Re-identifies content that has been de-identified.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/pseudonymization#re-identification_in_free_text_code_example
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReidentifyContentResponse> ReidentifyContentAsync(ReidentifyContentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Re-identifies content that has been de-identified.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/pseudonymization#re-identification_in_free_text_code_example
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReidentifyContentResponse> ReidentifyContentAsync(ReidentifyContentRequest request, st::CancellationToken cancellationToken) =>
            ReidentifyContentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of the sensitive information types that DLP API
        /// supports. See
        /// https://cloud.google.com/sensitive-data-protection/docs/infotypes-reference
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListInfoTypesResponse ListInfoTypes(ListInfoTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of the sensitive information types that DLP API
        /// supports. See
        /// https://cloud.google.com/sensitive-data-protection/docs/infotypes-reference
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListInfoTypesResponse> ListInfoTypesAsync(ListInfoTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of the sensitive information types that DLP API
        /// supports. See
        /// https://cloud.google.com/sensitive-data-protection/docs/infotypes-reference
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListInfoTypesResponse> ListInfoTypesAsync(ListInfoTypesRequest request, st::CancellationToken cancellationToken) =>
            ListInfoTypesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of the sensitive information types that DLP API
        /// supports. See
        /// https://cloud.google.com/sensitive-data-protection/docs/infotypes-reference
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// The parent resource name.
        /// 
        /// The format of this value is as follows:
        /// 
        /// `locations/{location_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListInfoTypesResponse ListInfoTypes(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ListInfoTypes(new ListInfoTypesRequest { Parent = parent ?? "", }, callSettings);

        /// <summary>
        /// Returns a list of the sensitive information types that DLP API
        /// supports. See
        /// https://cloud.google.com/sensitive-data-protection/docs/infotypes-reference
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// The parent resource name.
        /// 
        /// The format of this value is as follows:
        /// 
        /// `locations/{location_id}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListInfoTypesResponse> ListInfoTypesAsync(string parent, gaxgrpc::CallSettings callSettings = null) =>
            ListInfoTypesAsync(new ListInfoTypesRequest { Parent = parent ?? "", }, callSettings);

        /// <summary>
        /// Returns a list of the sensitive information types that DLP API
        /// supports. See
        /// https://cloud.google.com/sensitive-data-protection/docs/infotypes-reference
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// The parent resource name.
        /// 
        /// The format of this value is as follows:
        /// 
        /// `locations/{location_id}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListInfoTypesResponse> ListInfoTypesAsync(string parent, st::CancellationToken cancellationToken) =>
            ListInfoTypesAsync(parent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an InspectTemplate for reusing frequently used configuration
        /// for inspecting content, images, and storage.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InspectTemplate CreateInspectTemplate(CreateInspectTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an InspectTemplate for reusing frequently used configuration
        /// for inspecting content, images, and storage.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InspectTemplate> CreateInspectTemplateAsync(CreateInspectTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an InspectTemplate for reusing frequently used configuration
        /// for inspecting content, images, and storage.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InspectTemplate> CreateInspectTemplateAsync(CreateInspectTemplateRequest request, st::CancellationToken cancellationToken) =>
            CreateInspectTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an InspectTemplate for reusing frequently used configuration
        /// for inspecting content, images, and storage.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="inspectTemplate">
        /// Required. The InspectTemplate to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InspectTemplate CreateInspectTemplate(string parent, InspectTemplate inspectTemplate, gaxgrpc::CallSettings callSettings = null) =>
            CreateInspectTemplate(new CreateInspectTemplateRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InspectTemplate = gax::GaxPreconditions.CheckNotNull(inspectTemplate, nameof(inspectTemplate)),
            }, callSettings);

        /// <summary>
        /// Creates an InspectTemplate for reusing frequently used configuration
        /// for inspecting content, images, and storage.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="inspectTemplate">
        /// Required. The InspectTemplate to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InspectTemplate> CreateInspectTemplateAsync(string parent, InspectTemplate inspectTemplate, gaxgrpc::CallSettings callSettings = null) =>
            CreateInspectTemplateAsync(new CreateInspectTemplateRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InspectTemplate = gax::GaxPreconditions.CheckNotNull(inspectTemplate, nameof(inspectTemplate)),
            }, callSettings);

        /// <summary>
        /// Creates an InspectTemplate for reusing frequently used configuration
        /// for inspecting content, images, and storage.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="inspectTemplate">
        /// Required. The InspectTemplate to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InspectTemplate> CreateInspectTemplateAsync(string parent, InspectTemplate inspectTemplate, st::CancellationToken cancellationToken) =>
            CreateInspectTemplateAsync(parent, inspectTemplate, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an InspectTemplate for reusing frequently used configuration
        /// for inspecting content, images, and storage.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="inspectTemplate">
        /// Required. The InspectTemplate to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InspectTemplate CreateInspectTemplate(gagr::OrganizationName parent, InspectTemplate inspectTemplate, gaxgrpc::CallSettings callSettings = null) =>
            CreateInspectTemplate(new CreateInspectTemplateRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InspectTemplate = gax::GaxPreconditions.CheckNotNull(inspectTemplate, nameof(inspectTemplate)),
            }, callSettings);

        /// <summary>
        /// Creates an InspectTemplate for reusing frequently used configuration
        /// for inspecting content, images, and storage.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="inspectTemplate">
        /// Required. The InspectTemplate to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InspectTemplate> CreateInspectTemplateAsync(gagr::OrganizationName parent, InspectTemplate inspectTemplate, gaxgrpc::CallSettings callSettings = null) =>
            CreateInspectTemplateAsync(new CreateInspectTemplateRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InspectTemplate = gax::GaxPreconditions.CheckNotNull(inspectTemplate, nameof(inspectTemplate)),
            }, callSettings);

        /// <summary>
        /// Creates an InspectTemplate for reusing frequently used configuration
        /// for inspecting content, images, and storage.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="inspectTemplate">
        /// Required. The InspectTemplate to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InspectTemplate> CreateInspectTemplateAsync(gagr::OrganizationName parent, InspectTemplate inspectTemplate, st::CancellationToken cancellationToken) =>
            CreateInspectTemplateAsync(parent, inspectTemplate, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an InspectTemplate for reusing frequently used configuration
        /// for inspecting content, images, and storage.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="inspectTemplate">
        /// Required. The InspectTemplate to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InspectTemplate CreateInspectTemplate(gagr::ProjectName parent, InspectTemplate inspectTemplate, gaxgrpc::CallSettings callSettings = null) =>
            CreateInspectTemplate(new CreateInspectTemplateRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InspectTemplate = gax::GaxPreconditions.CheckNotNull(inspectTemplate, nameof(inspectTemplate)),
            }, callSettings);

        /// <summary>
        /// Creates an InspectTemplate for reusing frequently used configuration
        /// for inspecting content, images, and storage.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="inspectTemplate">
        /// Required. The InspectTemplate to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InspectTemplate> CreateInspectTemplateAsync(gagr::ProjectName parent, InspectTemplate inspectTemplate, gaxgrpc::CallSettings callSettings = null) =>
            CreateInspectTemplateAsync(new CreateInspectTemplateRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InspectTemplate = gax::GaxPreconditions.CheckNotNull(inspectTemplate, nameof(inspectTemplate)),
            }, callSettings);

        /// <summary>
        /// Creates an InspectTemplate for reusing frequently used configuration
        /// for inspecting content, images, and storage.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="inspectTemplate">
        /// Required. The InspectTemplate to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InspectTemplate> CreateInspectTemplateAsync(gagr::ProjectName parent, InspectTemplate inspectTemplate, st::CancellationToken cancellationToken) =>
            CreateInspectTemplateAsync(parent, inspectTemplate, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an InspectTemplate for reusing frequently used configuration
        /// for inspecting content, images, and storage.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="inspectTemplate">
        /// Required. The InspectTemplate to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InspectTemplate CreateInspectTemplate(OrganizationLocationName parent, InspectTemplate inspectTemplate, gaxgrpc::CallSettings callSettings = null) =>
            CreateInspectTemplate(new CreateInspectTemplateRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InspectTemplate = gax::GaxPreconditions.CheckNotNull(inspectTemplate, nameof(inspectTemplate)),
            }, callSettings);

        /// <summary>
        /// Creates an InspectTemplate for reusing frequently used configuration
        /// for inspecting content, images, and storage.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="inspectTemplate">
        /// Required. The InspectTemplate to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InspectTemplate> CreateInspectTemplateAsync(OrganizationLocationName parent, InspectTemplate inspectTemplate, gaxgrpc::CallSettings callSettings = null) =>
            CreateInspectTemplateAsync(new CreateInspectTemplateRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InspectTemplate = gax::GaxPreconditions.CheckNotNull(inspectTemplate, nameof(inspectTemplate)),
            }, callSettings);

        /// <summary>
        /// Creates an InspectTemplate for reusing frequently used configuration
        /// for inspecting content, images, and storage.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="inspectTemplate">
        /// Required. The InspectTemplate to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InspectTemplate> CreateInspectTemplateAsync(OrganizationLocationName parent, InspectTemplate inspectTemplate, st::CancellationToken cancellationToken) =>
            CreateInspectTemplateAsync(parent, inspectTemplate, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an InspectTemplate for reusing frequently used configuration
        /// for inspecting content, images, and storage.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="inspectTemplate">
        /// Required. The InspectTemplate to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InspectTemplate CreateInspectTemplate(gagr::LocationName parent, InspectTemplate inspectTemplate, gaxgrpc::CallSettings callSettings = null) =>
            CreateInspectTemplate(new CreateInspectTemplateRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InspectTemplate = gax::GaxPreconditions.CheckNotNull(inspectTemplate, nameof(inspectTemplate)),
            }, callSettings);

        /// <summary>
        /// Creates an InspectTemplate for reusing frequently used configuration
        /// for inspecting content, images, and storage.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="inspectTemplate">
        /// Required. The InspectTemplate to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InspectTemplate> CreateInspectTemplateAsync(gagr::LocationName parent, InspectTemplate inspectTemplate, gaxgrpc::CallSettings callSettings = null) =>
            CreateInspectTemplateAsync(new CreateInspectTemplateRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InspectTemplate = gax::GaxPreconditions.CheckNotNull(inspectTemplate, nameof(inspectTemplate)),
            }, callSettings);

        /// <summary>
        /// Creates an InspectTemplate for reusing frequently used configuration
        /// for inspecting content, images, and storage.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="inspectTemplate">
        /// Required. The InspectTemplate to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InspectTemplate> CreateInspectTemplateAsync(gagr::LocationName parent, InspectTemplate inspectTemplate, st::CancellationToken cancellationToken) =>
            CreateInspectTemplateAsync(parent, inspectTemplate, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the InspectTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InspectTemplate UpdateInspectTemplate(UpdateInspectTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the InspectTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InspectTemplate> UpdateInspectTemplateAsync(UpdateInspectTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the InspectTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InspectTemplate> UpdateInspectTemplateAsync(UpdateInspectTemplateRequest request, st::CancellationToken cancellationToken) =>
            UpdateInspectTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the InspectTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of organization and inspectTemplate to be updated,
        /// for example `organizations/433245324/inspectTemplates/432452342` or
        /// projects/project-id/inspectTemplates/432452342.
        /// </param>
        /// <param name="inspectTemplate">
        /// New InspectTemplate value.
        /// </param>
        /// <param name="updateMask">
        /// Mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InspectTemplate UpdateInspectTemplate(string name, InspectTemplate inspectTemplate, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateInspectTemplate(new UpdateInspectTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                InspectTemplate = inspectTemplate,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the InspectTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of organization and inspectTemplate to be updated,
        /// for example `organizations/433245324/inspectTemplates/432452342` or
        /// projects/project-id/inspectTemplates/432452342.
        /// </param>
        /// <param name="inspectTemplate">
        /// New InspectTemplate value.
        /// </param>
        /// <param name="updateMask">
        /// Mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InspectTemplate> UpdateInspectTemplateAsync(string name, InspectTemplate inspectTemplate, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateInspectTemplateAsync(new UpdateInspectTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                InspectTemplate = inspectTemplate,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the InspectTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of organization and inspectTemplate to be updated,
        /// for example `organizations/433245324/inspectTemplates/432452342` or
        /// projects/project-id/inspectTemplates/432452342.
        /// </param>
        /// <param name="inspectTemplate">
        /// New InspectTemplate value.
        /// </param>
        /// <param name="updateMask">
        /// Mask to control which fields get updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InspectTemplate> UpdateInspectTemplateAsync(string name, InspectTemplate inspectTemplate, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateInspectTemplateAsync(name, inspectTemplate, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the InspectTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of organization and inspectTemplate to be updated,
        /// for example `organizations/433245324/inspectTemplates/432452342` or
        /// projects/project-id/inspectTemplates/432452342.
        /// </param>
        /// <param name="inspectTemplate">
        /// New InspectTemplate value.
        /// </param>
        /// <param name="updateMask">
        /// Mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InspectTemplate UpdateInspectTemplate(InspectTemplateName name, InspectTemplate inspectTemplate, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateInspectTemplate(new UpdateInspectTemplateRequest
            {
                InspectTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                InspectTemplate = inspectTemplate,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the InspectTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of organization and inspectTemplate to be updated,
        /// for example `organizations/433245324/inspectTemplates/432452342` or
        /// projects/project-id/inspectTemplates/432452342.
        /// </param>
        /// <param name="inspectTemplate">
        /// New InspectTemplate value.
        /// </param>
        /// <param name="updateMask">
        /// Mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InspectTemplate> UpdateInspectTemplateAsync(InspectTemplateName name, InspectTemplate inspectTemplate, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateInspectTemplateAsync(new UpdateInspectTemplateRequest
            {
                InspectTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                InspectTemplate = inspectTemplate,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the InspectTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of organization and inspectTemplate to be updated,
        /// for example `organizations/433245324/inspectTemplates/432452342` or
        /// projects/project-id/inspectTemplates/432452342.
        /// </param>
        /// <param name="inspectTemplate">
        /// New InspectTemplate value.
        /// </param>
        /// <param name="updateMask">
        /// Mask to control which fields get updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InspectTemplate> UpdateInspectTemplateAsync(InspectTemplateName name, InspectTemplate inspectTemplate, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateInspectTemplateAsync(name, inspectTemplate, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an InspectTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InspectTemplate GetInspectTemplate(GetInspectTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an InspectTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InspectTemplate> GetInspectTemplateAsync(GetInspectTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an InspectTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InspectTemplate> GetInspectTemplateAsync(GetInspectTemplateRequest request, st::CancellationToken cancellationToken) =>
            GetInspectTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an InspectTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the organization and inspectTemplate to be read,
        /// for example `organizations/433245324/inspectTemplates/432452342` or
        /// projects/project-id/inspectTemplates/432452342.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InspectTemplate GetInspectTemplate(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInspectTemplate(new GetInspectTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an InspectTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the organization and inspectTemplate to be read,
        /// for example `organizations/433245324/inspectTemplates/432452342` or
        /// projects/project-id/inspectTemplates/432452342.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InspectTemplate> GetInspectTemplateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetInspectTemplateAsync(new GetInspectTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an InspectTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the organization and inspectTemplate to be read,
        /// for example `organizations/433245324/inspectTemplates/432452342` or
        /// projects/project-id/inspectTemplates/432452342.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InspectTemplate> GetInspectTemplateAsync(string name, st::CancellationToken cancellationToken) =>
            GetInspectTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an InspectTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the organization and inspectTemplate to be read,
        /// for example `organizations/433245324/inspectTemplates/432452342` or
        /// projects/project-id/inspectTemplates/432452342.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual InspectTemplate GetInspectTemplate(InspectTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInspectTemplate(new GetInspectTemplateRequest
            {
                InspectTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an InspectTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the organization and inspectTemplate to be read,
        /// for example `organizations/433245324/inspectTemplates/432452342` or
        /// projects/project-id/inspectTemplates/432452342.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InspectTemplate> GetInspectTemplateAsync(InspectTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetInspectTemplateAsync(new GetInspectTemplateRequest
            {
                InspectTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an InspectTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the organization and inspectTemplate to be read,
        /// for example `organizations/433245324/inspectTemplates/432452342` or
        /// projects/project-id/inspectTemplates/432452342.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<InspectTemplate> GetInspectTemplateAsync(InspectTemplateName name, st::CancellationToken cancellationToken) =>
            GetInspectTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists InspectTemplates.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InspectTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInspectTemplatesResponse, InspectTemplate> ListInspectTemplates(ListInspectTemplatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists InspectTemplates.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="InspectTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInspectTemplatesResponse, InspectTemplate> ListInspectTemplatesAsync(ListInspectTemplatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists InspectTemplates.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable sequence of <see cref="InspectTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInspectTemplatesResponse, InspectTemplate> ListInspectTemplates(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInspectTemplatesRequest request = new ListInspectTemplatesRequest
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
            return ListInspectTemplates(request, callSettings);
        }

        /// <summary>
        /// Lists InspectTemplates.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable asynchronous sequence of <see cref="InspectTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInspectTemplatesResponse, InspectTemplate> ListInspectTemplatesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInspectTemplatesRequest request = new ListInspectTemplatesRequest
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
            return ListInspectTemplatesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists InspectTemplates.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable sequence of <see cref="InspectTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInspectTemplatesResponse, InspectTemplate> ListInspectTemplates(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInspectTemplatesRequest request = new ListInspectTemplatesRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListInspectTemplates(request, callSettings);
        }

        /// <summary>
        /// Lists InspectTemplates.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable asynchronous sequence of <see cref="InspectTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInspectTemplatesResponse, InspectTemplate> ListInspectTemplatesAsync(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInspectTemplatesRequest request = new ListInspectTemplatesRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListInspectTemplatesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists InspectTemplates.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable sequence of <see cref="InspectTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInspectTemplatesResponse, InspectTemplate> ListInspectTemplates(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInspectTemplatesRequest request = new ListInspectTemplatesRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListInspectTemplates(request, callSettings);
        }

        /// <summary>
        /// Lists InspectTemplates.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable asynchronous sequence of <see cref="InspectTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInspectTemplatesResponse, InspectTemplate> ListInspectTemplatesAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInspectTemplatesRequest request = new ListInspectTemplatesRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListInspectTemplatesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists InspectTemplates.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable sequence of <see cref="InspectTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInspectTemplatesResponse, InspectTemplate> ListInspectTemplates(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInspectTemplatesRequest request = new ListInspectTemplatesRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListInspectTemplates(request, callSettings);
        }

        /// <summary>
        /// Lists InspectTemplates.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable asynchronous sequence of <see cref="InspectTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInspectTemplatesResponse, InspectTemplate> ListInspectTemplatesAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInspectTemplatesRequest request = new ListInspectTemplatesRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListInspectTemplatesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists InspectTemplates.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable sequence of <see cref="InspectTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListInspectTemplatesResponse, InspectTemplate> ListInspectTemplates(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInspectTemplatesRequest request = new ListInspectTemplatesRequest
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
            return ListInspectTemplates(request, callSettings);
        }

        /// <summary>
        /// Lists InspectTemplates.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable asynchronous sequence of <see cref="InspectTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListInspectTemplatesResponse, InspectTemplate> ListInspectTemplatesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListInspectTemplatesRequest request = new ListInspectTemplatesRequest
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
            return ListInspectTemplatesAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes an InspectTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteInspectTemplate(DeleteInspectTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an InspectTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteInspectTemplateAsync(DeleteInspectTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an InspectTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteInspectTemplateAsync(DeleteInspectTemplateRequest request, st::CancellationToken cancellationToken) =>
            DeleteInspectTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an InspectTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the organization and inspectTemplate to be
        /// deleted, for example `organizations/433245324/inspectTemplates/432452342`
        /// or projects/project-id/inspectTemplates/432452342.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteInspectTemplate(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInspectTemplate(new DeleteInspectTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an InspectTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the organization and inspectTemplate to be
        /// deleted, for example `organizations/433245324/inspectTemplates/432452342`
        /// or projects/project-id/inspectTemplates/432452342.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteInspectTemplateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInspectTemplateAsync(new DeleteInspectTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an InspectTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the organization and inspectTemplate to be
        /// deleted, for example `organizations/433245324/inspectTemplates/432452342`
        /// or projects/project-id/inspectTemplates/432452342.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteInspectTemplateAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteInspectTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an InspectTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the organization and inspectTemplate to be
        /// deleted, for example `organizations/433245324/inspectTemplates/432452342`
        /// or projects/project-id/inspectTemplates/432452342.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteInspectTemplate(InspectTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInspectTemplate(new DeleteInspectTemplateRequest
            {
                InspectTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an InspectTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the organization and inspectTemplate to be
        /// deleted, for example `organizations/433245324/inspectTemplates/432452342`
        /// or projects/project-id/inspectTemplates/432452342.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteInspectTemplateAsync(InspectTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteInspectTemplateAsync(new DeleteInspectTemplateRequest
            {
                InspectTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an InspectTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the organization and inspectTemplate to be
        /// deleted, for example `organizations/433245324/inspectTemplates/432452342`
        /// or projects/project-id/inspectTemplates/432452342.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteInspectTemplateAsync(InspectTemplateName name, st::CancellationToken cancellationToken) =>
            DeleteInspectTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a DeidentifyTemplate for reusing frequently used configuration
        /// for de-identifying content, images, and storage.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeidentifyTemplate CreateDeidentifyTemplate(CreateDeidentifyTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a DeidentifyTemplate for reusing frequently used configuration
        /// for de-identifying content, images, and storage.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeidentifyTemplate> CreateDeidentifyTemplateAsync(CreateDeidentifyTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a DeidentifyTemplate for reusing frequently used configuration
        /// for de-identifying content, images, and storage.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeidentifyTemplate> CreateDeidentifyTemplateAsync(CreateDeidentifyTemplateRequest request, st::CancellationToken cancellationToken) =>
            CreateDeidentifyTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a DeidentifyTemplate for reusing frequently used configuration
        /// for de-identifying content, images, and storage.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="deidentifyTemplate">
        /// Required. The DeidentifyTemplate to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeidentifyTemplate CreateDeidentifyTemplate(string parent, DeidentifyTemplate deidentifyTemplate, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeidentifyTemplate(new CreateDeidentifyTemplateRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DeidentifyTemplate = gax::GaxPreconditions.CheckNotNull(deidentifyTemplate, nameof(deidentifyTemplate)),
            }, callSettings);

        /// <summary>
        /// Creates a DeidentifyTemplate for reusing frequently used configuration
        /// for de-identifying content, images, and storage.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="deidentifyTemplate">
        /// Required. The DeidentifyTemplate to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeidentifyTemplate> CreateDeidentifyTemplateAsync(string parent, DeidentifyTemplate deidentifyTemplate, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeidentifyTemplateAsync(new CreateDeidentifyTemplateRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DeidentifyTemplate = gax::GaxPreconditions.CheckNotNull(deidentifyTemplate, nameof(deidentifyTemplate)),
            }, callSettings);

        /// <summary>
        /// Creates a DeidentifyTemplate for reusing frequently used configuration
        /// for de-identifying content, images, and storage.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="deidentifyTemplate">
        /// Required. The DeidentifyTemplate to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeidentifyTemplate> CreateDeidentifyTemplateAsync(string parent, DeidentifyTemplate deidentifyTemplate, st::CancellationToken cancellationToken) =>
            CreateDeidentifyTemplateAsync(parent, deidentifyTemplate, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a DeidentifyTemplate for reusing frequently used configuration
        /// for de-identifying content, images, and storage.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="deidentifyTemplate">
        /// Required. The DeidentifyTemplate to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeidentifyTemplate CreateDeidentifyTemplate(gagr::OrganizationName parent, DeidentifyTemplate deidentifyTemplate, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeidentifyTemplate(new CreateDeidentifyTemplateRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DeidentifyTemplate = gax::GaxPreconditions.CheckNotNull(deidentifyTemplate, nameof(deidentifyTemplate)),
            }, callSettings);

        /// <summary>
        /// Creates a DeidentifyTemplate for reusing frequently used configuration
        /// for de-identifying content, images, and storage.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="deidentifyTemplate">
        /// Required. The DeidentifyTemplate to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeidentifyTemplate> CreateDeidentifyTemplateAsync(gagr::OrganizationName parent, DeidentifyTemplate deidentifyTemplate, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeidentifyTemplateAsync(new CreateDeidentifyTemplateRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DeidentifyTemplate = gax::GaxPreconditions.CheckNotNull(deidentifyTemplate, nameof(deidentifyTemplate)),
            }, callSettings);

        /// <summary>
        /// Creates a DeidentifyTemplate for reusing frequently used configuration
        /// for de-identifying content, images, and storage.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="deidentifyTemplate">
        /// Required. The DeidentifyTemplate to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeidentifyTemplate> CreateDeidentifyTemplateAsync(gagr::OrganizationName parent, DeidentifyTemplate deidentifyTemplate, st::CancellationToken cancellationToken) =>
            CreateDeidentifyTemplateAsync(parent, deidentifyTemplate, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a DeidentifyTemplate for reusing frequently used configuration
        /// for de-identifying content, images, and storage.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="deidentifyTemplate">
        /// Required. The DeidentifyTemplate to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeidentifyTemplate CreateDeidentifyTemplate(gagr::ProjectName parent, DeidentifyTemplate deidentifyTemplate, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeidentifyTemplate(new CreateDeidentifyTemplateRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DeidentifyTemplate = gax::GaxPreconditions.CheckNotNull(deidentifyTemplate, nameof(deidentifyTemplate)),
            }, callSettings);

        /// <summary>
        /// Creates a DeidentifyTemplate for reusing frequently used configuration
        /// for de-identifying content, images, and storage.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="deidentifyTemplate">
        /// Required. The DeidentifyTemplate to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeidentifyTemplate> CreateDeidentifyTemplateAsync(gagr::ProjectName parent, DeidentifyTemplate deidentifyTemplate, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeidentifyTemplateAsync(new CreateDeidentifyTemplateRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DeidentifyTemplate = gax::GaxPreconditions.CheckNotNull(deidentifyTemplate, nameof(deidentifyTemplate)),
            }, callSettings);

        /// <summary>
        /// Creates a DeidentifyTemplate for reusing frequently used configuration
        /// for de-identifying content, images, and storage.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="deidentifyTemplate">
        /// Required. The DeidentifyTemplate to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeidentifyTemplate> CreateDeidentifyTemplateAsync(gagr::ProjectName parent, DeidentifyTemplate deidentifyTemplate, st::CancellationToken cancellationToken) =>
            CreateDeidentifyTemplateAsync(parent, deidentifyTemplate, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a DeidentifyTemplate for reusing frequently used configuration
        /// for de-identifying content, images, and storage.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="deidentifyTemplate">
        /// Required. The DeidentifyTemplate to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeidentifyTemplate CreateDeidentifyTemplate(OrganizationLocationName parent, DeidentifyTemplate deidentifyTemplate, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeidentifyTemplate(new CreateDeidentifyTemplateRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DeidentifyTemplate = gax::GaxPreconditions.CheckNotNull(deidentifyTemplate, nameof(deidentifyTemplate)),
            }, callSettings);

        /// <summary>
        /// Creates a DeidentifyTemplate for reusing frequently used configuration
        /// for de-identifying content, images, and storage.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="deidentifyTemplate">
        /// Required. The DeidentifyTemplate to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeidentifyTemplate> CreateDeidentifyTemplateAsync(OrganizationLocationName parent, DeidentifyTemplate deidentifyTemplate, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeidentifyTemplateAsync(new CreateDeidentifyTemplateRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DeidentifyTemplate = gax::GaxPreconditions.CheckNotNull(deidentifyTemplate, nameof(deidentifyTemplate)),
            }, callSettings);

        /// <summary>
        /// Creates a DeidentifyTemplate for reusing frequently used configuration
        /// for de-identifying content, images, and storage.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="deidentifyTemplate">
        /// Required. The DeidentifyTemplate to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeidentifyTemplate> CreateDeidentifyTemplateAsync(OrganizationLocationName parent, DeidentifyTemplate deidentifyTemplate, st::CancellationToken cancellationToken) =>
            CreateDeidentifyTemplateAsync(parent, deidentifyTemplate, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a DeidentifyTemplate for reusing frequently used configuration
        /// for de-identifying content, images, and storage.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="deidentifyTemplate">
        /// Required. The DeidentifyTemplate to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeidentifyTemplate CreateDeidentifyTemplate(gagr::LocationName parent, DeidentifyTemplate deidentifyTemplate, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeidentifyTemplate(new CreateDeidentifyTemplateRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DeidentifyTemplate = gax::GaxPreconditions.CheckNotNull(deidentifyTemplate, nameof(deidentifyTemplate)),
            }, callSettings);

        /// <summary>
        /// Creates a DeidentifyTemplate for reusing frequently used configuration
        /// for de-identifying content, images, and storage.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="deidentifyTemplate">
        /// Required. The DeidentifyTemplate to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeidentifyTemplate> CreateDeidentifyTemplateAsync(gagr::LocationName parent, DeidentifyTemplate deidentifyTemplate, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeidentifyTemplateAsync(new CreateDeidentifyTemplateRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DeidentifyTemplate = gax::GaxPreconditions.CheckNotNull(deidentifyTemplate, nameof(deidentifyTemplate)),
            }, callSettings);

        /// <summary>
        /// Creates a DeidentifyTemplate for reusing frequently used configuration
        /// for de-identifying content, images, and storage.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="deidentifyTemplate">
        /// Required. The DeidentifyTemplate to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeidentifyTemplate> CreateDeidentifyTemplateAsync(gagr::LocationName parent, DeidentifyTemplate deidentifyTemplate, st::CancellationToken cancellationToken) =>
            CreateDeidentifyTemplateAsync(parent, deidentifyTemplate, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the DeidentifyTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeidentifyTemplate UpdateDeidentifyTemplate(UpdateDeidentifyTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the DeidentifyTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeidentifyTemplate> UpdateDeidentifyTemplateAsync(UpdateDeidentifyTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the DeidentifyTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeidentifyTemplate> UpdateDeidentifyTemplateAsync(UpdateDeidentifyTemplateRequest request, st::CancellationToken cancellationToken) =>
            UpdateDeidentifyTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the DeidentifyTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of organization and deidentify template to be
        /// updated, for example
        /// `organizations/433245324/deidentifyTemplates/432452342` or
        /// projects/project-id/deidentifyTemplates/432452342.
        /// </param>
        /// <param name="deidentifyTemplate">
        /// New DeidentifyTemplate value.
        /// </param>
        /// <param name="updateMask">
        /// Mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeidentifyTemplate UpdateDeidentifyTemplate(string name, DeidentifyTemplate deidentifyTemplate, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDeidentifyTemplate(new UpdateDeidentifyTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                DeidentifyTemplate = deidentifyTemplate,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the DeidentifyTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of organization and deidentify template to be
        /// updated, for example
        /// `organizations/433245324/deidentifyTemplates/432452342` or
        /// projects/project-id/deidentifyTemplates/432452342.
        /// </param>
        /// <param name="deidentifyTemplate">
        /// New DeidentifyTemplate value.
        /// </param>
        /// <param name="updateMask">
        /// Mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeidentifyTemplate> UpdateDeidentifyTemplateAsync(string name, DeidentifyTemplate deidentifyTemplate, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDeidentifyTemplateAsync(new UpdateDeidentifyTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                DeidentifyTemplate = deidentifyTemplate,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the DeidentifyTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of organization and deidentify template to be
        /// updated, for example
        /// `organizations/433245324/deidentifyTemplates/432452342` or
        /// projects/project-id/deidentifyTemplates/432452342.
        /// </param>
        /// <param name="deidentifyTemplate">
        /// New DeidentifyTemplate value.
        /// </param>
        /// <param name="updateMask">
        /// Mask to control which fields get updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeidentifyTemplate> UpdateDeidentifyTemplateAsync(string name, DeidentifyTemplate deidentifyTemplate, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDeidentifyTemplateAsync(name, deidentifyTemplate, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the DeidentifyTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of organization and deidentify template to be
        /// updated, for example
        /// `organizations/433245324/deidentifyTemplates/432452342` or
        /// projects/project-id/deidentifyTemplates/432452342.
        /// </param>
        /// <param name="deidentifyTemplate">
        /// New DeidentifyTemplate value.
        /// </param>
        /// <param name="updateMask">
        /// Mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeidentifyTemplate UpdateDeidentifyTemplate(DeidentifyTemplateName name, DeidentifyTemplate deidentifyTemplate, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDeidentifyTemplate(new UpdateDeidentifyTemplateRequest
            {
                DeidentifyTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                DeidentifyTemplate = deidentifyTemplate,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the DeidentifyTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of organization and deidentify template to be
        /// updated, for example
        /// `organizations/433245324/deidentifyTemplates/432452342` or
        /// projects/project-id/deidentifyTemplates/432452342.
        /// </param>
        /// <param name="deidentifyTemplate">
        /// New DeidentifyTemplate value.
        /// </param>
        /// <param name="updateMask">
        /// Mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeidentifyTemplate> UpdateDeidentifyTemplateAsync(DeidentifyTemplateName name, DeidentifyTemplate deidentifyTemplate, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDeidentifyTemplateAsync(new UpdateDeidentifyTemplateRequest
            {
                DeidentifyTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                DeidentifyTemplate = deidentifyTemplate,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the DeidentifyTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of organization and deidentify template to be
        /// updated, for example
        /// `organizations/433245324/deidentifyTemplates/432452342` or
        /// projects/project-id/deidentifyTemplates/432452342.
        /// </param>
        /// <param name="deidentifyTemplate">
        /// New DeidentifyTemplate value.
        /// </param>
        /// <param name="updateMask">
        /// Mask to control which fields get updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeidentifyTemplate> UpdateDeidentifyTemplateAsync(DeidentifyTemplateName name, DeidentifyTemplate deidentifyTemplate, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDeidentifyTemplateAsync(name, deidentifyTemplate, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a DeidentifyTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeidentifyTemplate GetDeidentifyTemplate(GetDeidentifyTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a DeidentifyTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeidentifyTemplate> GetDeidentifyTemplateAsync(GetDeidentifyTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a DeidentifyTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeidentifyTemplate> GetDeidentifyTemplateAsync(GetDeidentifyTemplateRequest request, st::CancellationToken cancellationToken) =>
            GetDeidentifyTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a DeidentifyTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the organization and deidentify template to be
        /// read, for example `organizations/433245324/deidentifyTemplates/432452342`
        /// or projects/project-id/deidentifyTemplates/432452342.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeidentifyTemplate GetDeidentifyTemplate(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeidentifyTemplate(new GetDeidentifyTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a DeidentifyTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the organization and deidentify template to be
        /// read, for example `organizations/433245324/deidentifyTemplates/432452342`
        /// or projects/project-id/deidentifyTemplates/432452342.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeidentifyTemplate> GetDeidentifyTemplateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeidentifyTemplateAsync(new GetDeidentifyTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a DeidentifyTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the organization and deidentify template to be
        /// read, for example `organizations/433245324/deidentifyTemplates/432452342`
        /// or projects/project-id/deidentifyTemplates/432452342.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeidentifyTemplate> GetDeidentifyTemplateAsync(string name, st::CancellationToken cancellationToken) =>
            GetDeidentifyTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a DeidentifyTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the organization and deidentify template to be
        /// read, for example `organizations/433245324/deidentifyTemplates/432452342`
        /// or projects/project-id/deidentifyTemplates/432452342.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DeidentifyTemplate GetDeidentifyTemplate(DeidentifyTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeidentifyTemplate(new GetDeidentifyTemplateRequest
            {
                DeidentifyTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a DeidentifyTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the organization and deidentify template to be
        /// read, for example `organizations/433245324/deidentifyTemplates/432452342`
        /// or projects/project-id/deidentifyTemplates/432452342.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeidentifyTemplate> GetDeidentifyTemplateAsync(DeidentifyTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeidentifyTemplateAsync(new GetDeidentifyTemplateRequest
            {
                DeidentifyTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a DeidentifyTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the organization and deidentify template to be
        /// read, for example `organizations/433245324/deidentifyTemplates/432452342`
        /// or projects/project-id/deidentifyTemplates/432452342.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DeidentifyTemplate> GetDeidentifyTemplateAsync(DeidentifyTemplateName name, st::CancellationToken cancellationToken) =>
            GetDeidentifyTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists DeidentifyTemplates.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DeidentifyTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeidentifyTemplatesResponse, DeidentifyTemplate> ListDeidentifyTemplates(ListDeidentifyTemplatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists DeidentifyTemplates.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DeidentifyTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeidentifyTemplatesResponse, DeidentifyTemplate> ListDeidentifyTemplatesAsync(ListDeidentifyTemplatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists DeidentifyTemplates.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable sequence of <see cref="DeidentifyTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeidentifyTemplatesResponse, DeidentifyTemplate> ListDeidentifyTemplates(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeidentifyTemplatesRequest request = new ListDeidentifyTemplatesRequest
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
            return ListDeidentifyTemplates(request, callSettings);
        }

        /// <summary>
        /// Lists DeidentifyTemplates.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable asynchronous sequence of <see cref="DeidentifyTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeidentifyTemplatesResponse, DeidentifyTemplate> ListDeidentifyTemplatesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeidentifyTemplatesRequest request = new ListDeidentifyTemplatesRequest
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
            return ListDeidentifyTemplatesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists DeidentifyTemplates.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable sequence of <see cref="DeidentifyTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeidentifyTemplatesResponse, DeidentifyTemplate> ListDeidentifyTemplates(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeidentifyTemplatesRequest request = new ListDeidentifyTemplatesRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDeidentifyTemplates(request, callSettings);
        }

        /// <summary>
        /// Lists DeidentifyTemplates.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable asynchronous sequence of <see cref="DeidentifyTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeidentifyTemplatesResponse, DeidentifyTemplate> ListDeidentifyTemplatesAsync(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeidentifyTemplatesRequest request = new ListDeidentifyTemplatesRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDeidentifyTemplatesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists DeidentifyTemplates.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable sequence of <see cref="DeidentifyTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeidentifyTemplatesResponse, DeidentifyTemplate> ListDeidentifyTemplates(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeidentifyTemplatesRequest request = new ListDeidentifyTemplatesRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDeidentifyTemplates(request, callSettings);
        }

        /// <summary>
        /// Lists DeidentifyTemplates.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable asynchronous sequence of <see cref="DeidentifyTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeidentifyTemplatesResponse, DeidentifyTemplate> ListDeidentifyTemplatesAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeidentifyTemplatesRequest request = new ListDeidentifyTemplatesRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDeidentifyTemplatesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists DeidentifyTemplates.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable sequence of <see cref="DeidentifyTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeidentifyTemplatesResponse, DeidentifyTemplate> ListDeidentifyTemplates(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeidentifyTemplatesRequest request = new ListDeidentifyTemplatesRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDeidentifyTemplates(request, callSettings);
        }

        /// <summary>
        /// Lists DeidentifyTemplates.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable asynchronous sequence of <see cref="DeidentifyTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeidentifyTemplatesResponse, DeidentifyTemplate> ListDeidentifyTemplatesAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeidentifyTemplatesRequest request = new ListDeidentifyTemplatesRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDeidentifyTemplatesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists DeidentifyTemplates.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable sequence of <see cref="DeidentifyTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeidentifyTemplatesResponse, DeidentifyTemplate> ListDeidentifyTemplates(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeidentifyTemplatesRequest request = new ListDeidentifyTemplatesRequest
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
            return ListDeidentifyTemplates(request, callSettings);
        }

        /// <summary>
        /// Lists DeidentifyTemplates.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable asynchronous sequence of <see cref="DeidentifyTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeidentifyTemplatesResponse, DeidentifyTemplate> ListDeidentifyTemplatesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeidentifyTemplatesRequest request = new ListDeidentifyTemplatesRequest
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
            return ListDeidentifyTemplatesAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a DeidentifyTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDeidentifyTemplate(DeleteDeidentifyTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a DeidentifyTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDeidentifyTemplateAsync(DeleteDeidentifyTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a DeidentifyTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDeidentifyTemplateAsync(DeleteDeidentifyTemplateRequest request, st::CancellationToken cancellationToken) =>
            DeleteDeidentifyTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a DeidentifyTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the organization and deidentify template to be
        /// deleted, for example
        /// `organizations/433245324/deidentifyTemplates/432452342` or
        /// projects/project-id/deidentifyTemplates/432452342.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDeidentifyTemplate(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDeidentifyTemplate(new DeleteDeidentifyTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a DeidentifyTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the organization and deidentify template to be
        /// deleted, for example
        /// `organizations/433245324/deidentifyTemplates/432452342` or
        /// projects/project-id/deidentifyTemplates/432452342.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDeidentifyTemplateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDeidentifyTemplateAsync(new DeleteDeidentifyTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a DeidentifyTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the organization and deidentify template to be
        /// deleted, for example
        /// `organizations/433245324/deidentifyTemplates/432452342` or
        /// projects/project-id/deidentifyTemplates/432452342.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDeidentifyTemplateAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDeidentifyTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a DeidentifyTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the organization and deidentify template to be
        /// deleted, for example
        /// `organizations/433245324/deidentifyTemplates/432452342` or
        /// projects/project-id/deidentifyTemplates/432452342.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDeidentifyTemplate(DeidentifyTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDeidentifyTemplate(new DeleteDeidentifyTemplateRequest
            {
                DeidentifyTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a DeidentifyTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the organization and deidentify template to be
        /// deleted, for example
        /// `organizations/433245324/deidentifyTemplates/432452342` or
        /// projects/project-id/deidentifyTemplates/432452342.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDeidentifyTemplateAsync(DeidentifyTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDeidentifyTemplateAsync(new DeleteDeidentifyTemplateRequest
            {
                DeidentifyTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a DeidentifyTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the organization and deidentify template to be
        /// deleted, for example
        /// `organizations/433245324/deidentifyTemplates/432452342` or
        /// projects/project-id/deidentifyTemplates/432452342.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDeidentifyTemplateAsync(DeidentifyTemplateName name, st::CancellationToken cancellationToken) =>
            DeleteDeidentifyTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a job trigger to run DLP actions such as scanning storage for
        /// sensitive information on a set schedule.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual JobTrigger CreateJobTrigger(CreateJobTriggerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a job trigger to run DLP actions such as scanning storage for
        /// sensitive information on a set schedule.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<JobTrigger> CreateJobTriggerAsync(CreateJobTriggerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a job trigger to run DLP actions such as scanning storage for
        /// sensitive information on a set schedule.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<JobTrigger> CreateJobTriggerAsync(CreateJobTriggerRequest request, st::CancellationToken cancellationToken) =>
            CreateJobTriggerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a job trigger to run DLP actions such as scanning storage for
        /// sensitive information on a set schedule.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on whether you have [specified a
        /// processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="jobTrigger">
        /// Required. The JobTrigger to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual JobTrigger CreateJobTrigger(string parent, JobTrigger jobTrigger, gaxgrpc::CallSettings callSettings = null) =>
            CreateJobTrigger(new CreateJobTriggerRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                JobTrigger = gax::GaxPreconditions.CheckNotNull(jobTrigger, nameof(jobTrigger)),
            }, callSettings);

        /// <summary>
        /// Creates a job trigger to run DLP actions such as scanning storage for
        /// sensitive information on a set schedule.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on whether you have [specified a
        /// processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="jobTrigger">
        /// Required. The JobTrigger to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<JobTrigger> CreateJobTriggerAsync(string parent, JobTrigger jobTrigger, gaxgrpc::CallSettings callSettings = null) =>
            CreateJobTriggerAsync(new CreateJobTriggerRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                JobTrigger = gax::GaxPreconditions.CheckNotNull(jobTrigger, nameof(jobTrigger)),
            }, callSettings);

        /// <summary>
        /// Creates a job trigger to run DLP actions such as scanning storage for
        /// sensitive information on a set schedule.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on whether you have [specified a
        /// processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="jobTrigger">
        /// Required. The JobTrigger to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<JobTrigger> CreateJobTriggerAsync(string parent, JobTrigger jobTrigger, st::CancellationToken cancellationToken) =>
            CreateJobTriggerAsync(parent, jobTrigger, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a job trigger to run DLP actions such as scanning storage for
        /// sensitive information on a set schedule.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on whether you have [specified a
        /// processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="jobTrigger">
        /// Required. The JobTrigger to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual JobTrigger CreateJobTrigger(gagr::ProjectName parent, JobTrigger jobTrigger, gaxgrpc::CallSettings callSettings = null) =>
            CreateJobTrigger(new CreateJobTriggerRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                JobTrigger = gax::GaxPreconditions.CheckNotNull(jobTrigger, nameof(jobTrigger)),
            }, callSettings);

        /// <summary>
        /// Creates a job trigger to run DLP actions such as scanning storage for
        /// sensitive information on a set schedule.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on whether you have [specified a
        /// processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="jobTrigger">
        /// Required. The JobTrigger to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<JobTrigger> CreateJobTriggerAsync(gagr::ProjectName parent, JobTrigger jobTrigger, gaxgrpc::CallSettings callSettings = null) =>
            CreateJobTriggerAsync(new CreateJobTriggerRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                JobTrigger = gax::GaxPreconditions.CheckNotNull(jobTrigger, nameof(jobTrigger)),
            }, callSettings);

        /// <summary>
        /// Creates a job trigger to run DLP actions such as scanning storage for
        /// sensitive information on a set schedule.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on whether you have [specified a
        /// processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="jobTrigger">
        /// Required. The JobTrigger to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<JobTrigger> CreateJobTriggerAsync(gagr::ProjectName parent, JobTrigger jobTrigger, st::CancellationToken cancellationToken) =>
            CreateJobTriggerAsync(parent, jobTrigger, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a job trigger to run DLP actions such as scanning storage for
        /// sensitive information on a set schedule.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on whether you have [specified a
        /// processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="jobTrigger">
        /// Required. The JobTrigger to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual JobTrigger CreateJobTrigger(gagr::LocationName parent, JobTrigger jobTrigger, gaxgrpc::CallSettings callSettings = null) =>
            CreateJobTrigger(new CreateJobTriggerRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                JobTrigger = gax::GaxPreconditions.CheckNotNull(jobTrigger, nameof(jobTrigger)),
            }, callSettings);

        /// <summary>
        /// Creates a job trigger to run DLP actions such as scanning storage for
        /// sensitive information on a set schedule.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on whether you have [specified a
        /// processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="jobTrigger">
        /// Required. The JobTrigger to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<JobTrigger> CreateJobTriggerAsync(gagr::LocationName parent, JobTrigger jobTrigger, gaxgrpc::CallSettings callSettings = null) =>
            CreateJobTriggerAsync(new CreateJobTriggerRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                JobTrigger = gax::GaxPreconditions.CheckNotNull(jobTrigger, nameof(jobTrigger)),
            }, callSettings);

        /// <summary>
        /// Creates a job trigger to run DLP actions such as scanning storage for
        /// sensitive information on a set schedule.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on whether you have [specified a
        /// processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="jobTrigger">
        /// Required. The JobTrigger to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<JobTrigger> CreateJobTriggerAsync(gagr::LocationName parent, JobTrigger jobTrigger, st::CancellationToken cancellationToken) =>
            CreateJobTriggerAsync(parent, jobTrigger, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a job trigger.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual JobTrigger UpdateJobTrigger(UpdateJobTriggerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a job trigger.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<JobTrigger> UpdateJobTriggerAsync(UpdateJobTriggerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a job trigger.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<JobTrigger> UpdateJobTriggerAsync(UpdateJobTriggerRequest request, st::CancellationToken cancellationToken) =>
            UpdateJobTriggerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a job trigger.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the project and the triggeredJob, for example
        /// `projects/dlp-test-project/jobTriggers/53234423`.
        /// </param>
        /// <param name="jobTrigger">
        /// New JobTrigger value.
        /// </param>
        /// <param name="updateMask">
        /// Mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual JobTrigger UpdateJobTrigger(string name, JobTrigger jobTrigger, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateJobTrigger(new UpdateJobTriggerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                JobTrigger = jobTrigger,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a job trigger.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the project and the triggeredJob, for example
        /// `projects/dlp-test-project/jobTriggers/53234423`.
        /// </param>
        /// <param name="jobTrigger">
        /// New JobTrigger value.
        /// </param>
        /// <param name="updateMask">
        /// Mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<JobTrigger> UpdateJobTriggerAsync(string name, JobTrigger jobTrigger, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateJobTriggerAsync(new UpdateJobTriggerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                JobTrigger = jobTrigger,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a job trigger.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the project and the triggeredJob, for example
        /// `projects/dlp-test-project/jobTriggers/53234423`.
        /// </param>
        /// <param name="jobTrigger">
        /// New JobTrigger value.
        /// </param>
        /// <param name="updateMask">
        /// Mask to control which fields get updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<JobTrigger> UpdateJobTriggerAsync(string name, JobTrigger jobTrigger, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateJobTriggerAsync(name, jobTrigger, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a job trigger.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the project and the triggeredJob, for example
        /// `projects/dlp-test-project/jobTriggers/53234423`.
        /// </param>
        /// <param name="jobTrigger">
        /// New JobTrigger value.
        /// </param>
        /// <param name="updateMask">
        /// Mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual JobTrigger UpdateJobTrigger(JobTriggerName name, JobTrigger jobTrigger, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateJobTrigger(new UpdateJobTriggerRequest
            {
                JobTriggerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                JobTrigger = jobTrigger,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a job trigger.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the project and the triggeredJob, for example
        /// `projects/dlp-test-project/jobTriggers/53234423`.
        /// </param>
        /// <param name="jobTrigger">
        /// New JobTrigger value.
        /// </param>
        /// <param name="updateMask">
        /// Mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<JobTrigger> UpdateJobTriggerAsync(JobTriggerName name, JobTrigger jobTrigger, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateJobTriggerAsync(new UpdateJobTriggerRequest
            {
                JobTriggerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                JobTrigger = jobTrigger,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a job trigger.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the project and the triggeredJob, for example
        /// `projects/dlp-test-project/jobTriggers/53234423`.
        /// </param>
        /// <param name="jobTrigger">
        /// New JobTrigger value.
        /// </param>
        /// <param name="updateMask">
        /// Mask to control which fields get updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<JobTrigger> UpdateJobTriggerAsync(JobTriggerName name, JobTrigger jobTrigger, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateJobTriggerAsync(name, jobTrigger, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Inspect hybrid content and store findings to a trigger. The inspection
        /// will be processed asynchronously. To review the findings monitor the
        /// jobs within the trigger.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual HybridInspectResponse HybridInspectJobTrigger(HybridInspectJobTriggerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Inspect hybrid content and store findings to a trigger. The inspection
        /// will be processed asynchronously. To review the findings monitor the
        /// jobs within the trigger.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HybridInspectResponse> HybridInspectJobTriggerAsync(HybridInspectJobTriggerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Inspect hybrid content and store findings to a trigger. The inspection
        /// will be processed asynchronously. To review the findings monitor the
        /// jobs within the trigger.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HybridInspectResponse> HybridInspectJobTriggerAsync(HybridInspectJobTriggerRequest request, st::CancellationToken cancellationToken) =>
            HybridInspectJobTriggerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Inspect hybrid content and store findings to a trigger. The inspection
        /// will be processed asynchronously. To review the findings monitor the
        /// jobs within the trigger.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the trigger to execute a hybrid inspect on, for
        /// example `projects/dlp-test-project/jobTriggers/53234423`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual HybridInspectResponse HybridInspectJobTrigger(string name, gaxgrpc::CallSettings callSettings = null) =>
            HybridInspectJobTrigger(new HybridInspectJobTriggerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Inspect hybrid content and store findings to a trigger. The inspection
        /// will be processed asynchronously. To review the findings monitor the
        /// jobs within the trigger.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the trigger to execute a hybrid inspect on, for
        /// example `projects/dlp-test-project/jobTriggers/53234423`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HybridInspectResponse> HybridInspectJobTriggerAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            HybridInspectJobTriggerAsync(new HybridInspectJobTriggerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Inspect hybrid content and store findings to a trigger. The inspection
        /// will be processed asynchronously. To review the findings monitor the
        /// jobs within the trigger.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the trigger to execute a hybrid inspect on, for
        /// example `projects/dlp-test-project/jobTriggers/53234423`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HybridInspectResponse> HybridInspectJobTriggerAsync(string name, st::CancellationToken cancellationToken) =>
            HybridInspectJobTriggerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Inspect hybrid content and store findings to a trigger. The inspection
        /// will be processed asynchronously. To review the findings monitor the
        /// jobs within the trigger.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the trigger to execute a hybrid inspect on, for
        /// example `projects/dlp-test-project/jobTriggers/53234423`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual HybridInspectResponse HybridInspectJobTrigger(JobTriggerName name, gaxgrpc::CallSettings callSettings = null) =>
            HybridInspectJobTrigger(new HybridInspectJobTriggerRequest
            {
                JobTriggerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Inspect hybrid content and store findings to a trigger. The inspection
        /// will be processed asynchronously. To review the findings monitor the
        /// jobs within the trigger.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the trigger to execute a hybrid inspect on, for
        /// example `projects/dlp-test-project/jobTriggers/53234423`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HybridInspectResponse> HybridInspectJobTriggerAsync(JobTriggerName name, gaxgrpc::CallSettings callSettings = null) =>
            HybridInspectJobTriggerAsync(new HybridInspectJobTriggerRequest
            {
                JobTriggerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Inspect hybrid content and store findings to a trigger. The inspection
        /// will be processed asynchronously. To review the findings monitor the
        /// jobs within the trigger.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the trigger to execute a hybrid inspect on, for
        /// example `projects/dlp-test-project/jobTriggers/53234423`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HybridInspectResponse> HybridInspectJobTriggerAsync(JobTriggerName name, st::CancellationToken cancellationToken) =>
            HybridInspectJobTriggerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a job trigger.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual JobTrigger GetJobTrigger(GetJobTriggerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a job trigger.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<JobTrigger> GetJobTriggerAsync(GetJobTriggerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a job trigger.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<JobTrigger> GetJobTriggerAsync(GetJobTriggerRequest request, st::CancellationToken cancellationToken) =>
            GetJobTriggerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a job trigger.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the project and the triggeredJob, for example
        /// `projects/dlp-test-project/jobTriggers/53234423`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual JobTrigger GetJobTrigger(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetJobTrigger(new GetJobTriggerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a job trigger.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the project and the triggeredJob, for example
        /// `projects/dlp-test-project/jobTriggers/53234423`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<JobTrigger> GetJobTriggerAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetJobTriggerAsync(new GetJobTriggerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a job trigger.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the project and the triggeredJob, for example
        /// `projects/dlp-test-project/jobTriggers/53234423`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<JobTrigger> GetJobTriggerAsync(string name, st::CancellationToken cancellationToken) =>
            GetJobTriggerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a job trigger.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the project and the triggeredJob, for example
        /// `projects/dlp-test-project/jobTriggers/53234423`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual JobTrigger GetJobTrigger(JobTriggerName name, gaxgrpc::CallSettings callSettings = null) =>
            GetJobTrigger(new GetJobTriggerRequest
            {
                JobTriggerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a job trigger.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the project and the triggeredJob, for example
        /// `projects/dlp-test-project/jobTriggers/53234423`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<JobTrigger> GetJobTriggerAsync(JobTriggerName name, gaxgrpc::CallSettings callSettings = null) =>
            GetJobTriggerAsync(new GetJobTriggerRequest
            {
                JobTriggerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a job trigger.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the project and the triggeredJob, for example
        /// `projects/dlp-test-project/jobTriggers/53234423`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<JobTrigger> GetJobTriggerAsync(JobTriggerName name, st::CancellationToken cancellationToken) =>
            GetJobTriggerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists job triggers.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="JobTrigger"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListJobTriggersResponse, JobTrigger> ListJobTriggers(ListJobTriggersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists job triggers.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="JobTrigger"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListJobTriggersResponse, JobTrigger> ListJobTriggersAsync(ListJobTriggersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists job triggers.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on whether you have [specified a
        /// processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable sequence of <see cref="JobTrigger"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListJobTriggersResponse, JobTrigger> ListJobTriggers(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListJobTriggersRequest request = new ListJobTriggersRequest
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
            return ListJobTriggers(request, callSettings);
        }

        /// <summary>
        /// Lists job triggers.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on whether you have [specified a
        /// processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable asynchronous sequence of <see cref="JobTrigger"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListJobTriggersResponse, JobTrigger> ListJobTriggersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListJobTriggersRequest request = new ListJobTriggersRequest
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
            return ListJobTriggersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists job triggers.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on whether you have [specified a
        /// processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable sequence of <see cref="JobTrigger"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListJobTriggersResponse, JobTrigger> ListJobTriggers(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListJobTriggersRequest request = new ListJobTriggersRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListJobTriggers(request, callSettings);
        }

        /// <summary>
        /// Lists job triggers.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on whether you have [specified a
        /// processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable asynchronous sequence of <see cref="JobTrigger"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListJobTriggersResponse, JobTrigger> ListJobTriggersAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListJobTriggersRequest request = new ListJobTriggersRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListJobTriggersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists job triggers.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on whether you have [specified a
        /// processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable sequence of <see cref="JobTrigger"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListJobTriggersResponse, JobTrigger> ListJobTriggers(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListJobTriggersRequest request = new ListJobTriggersRequest
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
            return ListJobTriggers(request, callSettings);
        }

        /// <summary>
        /// Lists job triggers.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on whether you have [specified a
        /// processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable asynchronous sequence of <see cref="JobTrigger"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListJobTriggersResponse, JobTrigger> ListJobTriggersAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListJobTriggersRequest request = new ListJobTriggersRequest
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
            return ListJobTriggersAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a job trigger.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteJobTrigger(DeleteJobTriggerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a job trigger.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteJobTriggerAsync(DeleteJobTriggerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a job trigger.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteJobTriggerAsync(DeleteJobTriggerRequest request, st::CancellationToken cancellationToken) =>
            DeleteJobTriggerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a job trigger.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the project and the triggeredJob, for example
        /// `projects/dlp-test-project/jobTriggers/53234423`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteJobTrigger(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteJobTrigger(new DeleteJobTriggerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a job trigger.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the project and the triggeredJob, for example
        /// `projects/dlp-test-project/jobTriggers/53234423`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteJobTriggerAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteJobTriggerAsync(new DeleteJobTriggerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a job trigger.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the project and the triggeredJob, for example
        /// `projects/dlp-test-project/jobTriggers/53234423`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteJobTriggerAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteJobTriggerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a job trigger.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the project and the triggeredJob, for example
        /// `projects/dlp-test-project/jobTriggers/53234423`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteJobTrigger(JobTriggerName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteJobTrigger(new DeleteJobTriggerRequest
            {
                JobTriggerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a job trigger.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the project and the triggeredJob, for example
        /// `projects/dlp-test-project/jobTriggers/53234423`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteJobTriggerAsync(JobTriggerName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteJobTriggerAsync(new DeleteJobTriggerRequest
            {
                JobTriggerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a job trigger.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the project and the triggeredJob, for example
        /// `projects/dlp-test-project/jobTriggers/53234423`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteJobTriggerAsync(JobTriggerName name, st::CancellationToken cancellationToken) =>
            DeleteJobTriggerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Activate a job trigger. Causes the immediate execute of a trigger
        /// instead of waiting on the trigger event to occur.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DlpJob ActivateJobTrigger(ActivateJobTriggerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Activate a job trigger. Causes the immediate execute of a trigger
        /// instead of waiting on the trigger event to occur.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DlpJob> ActivateJobTriggerAsync(ActivateJobTriggerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Activate a job trigger. Causes the immediate execute of a trigger
        /// instead of waiting on the trigger event to occur.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DlpJob> ActivateJobTriggerAsync(ActivateJobTriggerRequest request, st::CancellationToken cancellationToken) =>
            ActivateJobTriggerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a config for discovery to scan and profile storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DiscoveryConfig CreateDiscoveryConfig(CreateDiscoveryConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a config for discovery to scan and profile storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveryConfig> CreateDiscoveryConfigAsync(CreateDiscoveryConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a config for discovery to scan and profile storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveryConfig> CreateDiscoveryConfigAsync(CreateDiscoveryConfigRequest request, st::CancellationToken cancellationToken) =>
            CreateDiscoveryConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a config for discovery to scan and profile storage.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization):
        /// 
        /// + Projects scope:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Organizations scope:
        /// `organizations/{org_id}/locations/{location_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="discoveryConfig">
        /// Required. The DiscoveryConfig to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DiscoveryConfig CreateDiscoveryConfig(string parent, DiscoveryConfig discoveryConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateDiscoveryConfig(new CreateDiscoveryConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DiscoveryConfig = gax::GaxPreconditions.CheckNotNull(discoveryConfig, nameof(discoveryConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a config for discovery to scan and profile storage.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization):
        /// 
        /// + Projects scope:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Organizations scope:
        /// `organizations/{org_id}/locations/{location_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="discoveryConfig">
        /// Required. The DiscoveryConfig to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveryConfig> CreateDiscoveryConfigAsync(string parent, DiscoveryConfig discoveryConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateDiscoveryConfigAsync(new CreateDiscoveryConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DiscoveryConfig = gax::GaxPreconditions.CheckNotNull(discoveryConfig, nameof(discoveryConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a config for discovery to scan and profile storage.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization):
        /// 
        /// + Projects scope:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Organizations scope:
        /// `organizations/{org_id}/locations/{location_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="discoveryConfig">
        /// Required. The DiscoveryConfig to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveryConfig> CreateDiscoveryConfigAsync(string parent, DiscoveryConfig discoveryConfig, st::CancellationToken cancellationToken) =>
            CreateDiscoveryConfigAsync(parent, discoveryConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a config for discovery to scan and profile storage.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization):
        /// 
        /// + Projects scope:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Organizations scope:
        /// `organizations/{org_id}/locations/{location_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="discoveryConfig">
        /// Required. The DiscoveryConfig to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DiscoveryConfig CreateDiscoveryConfig(gagr::LocationName parent, DiscoveryConfig discoveryConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateDiscoveryConfig(new CreateDiscoveryConfigRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DiscoveryConfig = gax::GaxPreconditions.CheckNotNull(discoveryConfig, nameof(discoveryConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a config for discovery to scan and profile storage.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization):
        /// 
        /// + Projects scope:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Organizations scope:
        /// `organizations/{org_id}/locations/{location_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="discoveryConfig">
        /// Required. The DiscoveryConfig to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveryConfig> CreateDiscoveryConfigAsync(gagr::LocationName parent, DiscoveryConfig discoveryConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateDiscoveryConfigAsync(new CreateDiscoveryConfigRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DiscoveryConfig = gax::GaxPreconditions.CheckNotNull(discoveryConfig, nameof(discoveryConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a config for discovery to scan and profile storage.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization):
        /// 
        /// + Projects scope:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Organizations scope:
        /// `organizations/{org_id}/locations/{location_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="discoveryConfig">
        /// Required. The DiscoveryConfig to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveryConfig> CreateDiscoveryConfigAsync(gagr::LocationName parent, DiscoveryConfig discoveryConfig, st::CancellationToken cancellationToken) =>
            CreateDiscoveryConfigAsync(parent, discoveryConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a discovery configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DiscoveryConfig UpdateDiscoveryConfig(UpdateDiscoveryConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a discovery configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveryConfig> UpdateDiscoveryConfigAsync(UpdateDiscoveryConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a discovery configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveryConfig> UpdateDiscoveryConfigAsync(UpdateDiscoveryConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateDiscoveryConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a discovery configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the project and the configuration, for example
        /// `projects/dlp-test-project/discoveryConfigs/53234423`.
        /// </param>
        /// <param name="discoveryConfig">
        /// Required. New DiscoveryConfig value.
        /// </param>
        /// <param name="updateMask">
        /// Mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DiscoveryConfig UpdateDiscoveryConfig(string name, DiscoveryConfig discoveryConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDiscoveryConfig(new UpdateDiscoveryConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                DiscoveryConfig = gax::GaxPreconditions.CheckNotNull(discoveryConfig, nameof(discoveryConfig)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a discovery configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the project and the configuration, for example
        /// `projects/dlp-test-project/discoveryConfigs/53234423`.
        /// </param>
        /// <param name="discoveryConfig">
        /// Required. New DiscoveryConfig value.
        /// </param>
        /// <param name="updateMask">
        /// Mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveryConfig> UpdateDiscoveryConfigAsync(string name, DiscoveryConfig discoveryConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDiscoveryConfigAsync(new UpdateDiscoveryConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                DiscoveryConfig = gax::GaxPreconditions.CheckNotNull(discoveryConfig, nameof(discoveryConfig)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a discovery configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the project and the configuration, for example
        /// `projects/dlp-test-project/discoveryConfigs/53234423`.
        /// </param>
        /// <param name="discoveryConfig">
        /// Required. New DiscoveryConfig value.
        /// </param>
        /// <param name="updateMask">
        /// Mask to control which fields get updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveryConfig> UpdateDiscoveryConfigAsync(string name, DiscoveryConfig discoveryConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDiscoveryConfigAsync(name, discoveryConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a discovery configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the project and the configuration, for example
        /// `projects/dlp-test-project/discoveryConfigs/53234423`.
        /// </param>
        /// <param name="discoveryConfig">
        /// Required. New DiscoveryConfig value.
        /// </param>
        /// <param name="updateMask">
        /// Mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DiscoveryConfig UpdateDiscoveryConfig(DiscoveryConfigName name, DiscoveryConfig discoveryConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDiscoveryConfig(new UpdateDiscoveryConfigRequest
            {
                DiscoveryConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                DiscoveryConfig = gax::GaxPreconditions.CheckNotNull(discoveryConfig, nameof(discoveryConfig)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a discovery configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the project and the configuration, for example
        /// `projects/dlp-test-project/discoveryConfigs/53234423`.
        /// </param>
        /// <param name="discoveryConfig">
        /// Required. New DiscoveryConfig value.
        /// </param>
        /// <param name="updateMask">
        /// Mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveryConfig> UpdateDiscoveryConfigAsync(DiscoveryConfigName name, DiscoveryConfig discoveryConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDiscoveryConfigAsync(new UpdateDiscoveryConfigRequest
            {
                DiscoveryConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                DiscoveryConfig = gax::GaxPreconditions.CheckNotNull(discoveryConfig, nameof(discoveryConfig)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a discovery configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the project and the configuration, for example
        /// `projects/dlp-test-project/discoveryConfigs/53234423`.
        /// </param>
        /// <param name="discoveryConfig">
        /// Required. New DiscoveryConfig value.
        /// </param>
        /// <param name="updateMask">
        /// Mask to control which fields get updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveryConfig> UpdateDiscoveryConfigAsync(DiscoveryConfigName name, DiscoveryConfig discoveryConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDiscoveryConfigAsync(name, discoveryConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a discovery configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DiscoveryConfig GetDiscoveryConfig(GetDiscoveryConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a discovery configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveryConfig> GetDiscoveryConfigAsync(GetDiscoveryConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a discovery configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveryConfig> GetDiscoveryConfigAsync(GetDiscoveryConfigRequest request, st::CancellationToken cancellationToken) =>
            GetDiscoveryConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a discovery configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the project and the configuration, for example
        /// `projects/dlp-test-project/discoveryConfigs/53234423`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DiscoveryConfig GetDiscoveryConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDiscoveryConfig(new GetDiscoveryConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a discovery configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the project and the configuration, for example
        /// `projects/dlp-test-project/discoveryConfigs/53234423`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveryConfig> GetDiscoveryConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDiscoveryConfigAsync(new GetDiscoveryConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a discovery configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the project and the configuration, for example
        /// `projects/dlp-test-project/discoveryConfigs/53234423`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveryConfig> GetDiscoveryConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetDiscoveryConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a discovery configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the project and the configuration, for example
        /// `projects/dlp-test-project/discoveryConfigs/53234423`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DiscoveryConfig GetDiscoveryConfig(DiscoveryConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDiscoveryConfig(new GetDiscoveryConfigRequest
            {
                DiscoveryConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a discovery configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the project and the configuration, for example
        /// `projects/dlp-test-project/discoveryConfigs/53234423`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveryConfig> GetDiscoveryConfigAsync(DiscoveryConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDiscoveryConfigAsync(new GetDiscoveryConfigRequest
            {
                DiscoveryConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a discovery configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the project and the configuration, for example
        /// `projects/dlp-test-project/discoveryConfigs/53234423`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DiscoveryConfig> GetDiscoveryConfigAsync(DiscoveryConfigName name, st::CancellationToken cancellationToken) =>
            GetDiscoveryConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists discovery configurations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DiscoveryConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDiscoveryConfigsResponse, DiscoveryConfig> ListDiscoveryConfigs(ListDiscoveryConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists discovery configurations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DiscoveryConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDiscoveryConfigsResponse, DiscoveryConfig> ListDiscoveryConfigsAsync(ListDiscoveryConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists discovery configurations.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value is as follows:
        /// `projects/{project_id}/locations/{location_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable sequence of <see cref="DiscoveryConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDiscoveryConfigsResponse, DiscoveryConfig> ListDiscoveryConfigs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDiscoveryConfigsRequest request = new ListDiscoveryConfigsRequest
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
            return ListDiscoveryConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists discovery configurations.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value is as follows:
        /// `projects/{project_id}/locations/{location_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable asynchronous sequence of <see cref="DiscoveryConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDiscoveryConfigsResponse, DiscoveryConfig> ListDiscoveryConfigsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDiscoveryConfigsRequest request = new ListDiscoveryConfigsRequest
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
            return ListDiscoveryConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists discovery configurations.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value is as follows:
        /// `projects/{project_id}/locations/{location_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable sequence of <see cref="DiscoveryConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDiscoveryConfigsResponse, DiscoveryConfig> ListDiscoveryConfigs(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDiscoveryConfigsRequest request = new ListDiscoveryConfigsRequest
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
            return ListDiscoveryConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists discovery configurations.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value is as follows:
        /// `projects/{project_id}/locations/{location_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable asynchronous sequence of <see cref="DiscoveryConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDiscoveryConfigsResponse, DiscoveryConfig> ListDiscoveryConfigsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDiscoveryConfigsRequest request = new ListDiscoveryConfigsRequest
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
            return ListDiscoveryConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a discovery configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDiscoveryConfig(DeleteDiscoveryConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a discovery configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDiscoveryConfigAsync(DeleteDiscoveryConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a discovery configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDiscoveryConfigAsync(DeleteDiscoveryConfigRequest request, st::CancellationToken cancellationToken) =>
            DeleteDiscoveryConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a discovery configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the project and the config, for example
        /// `projects/dlp-test-project/discoveryConfigs/53234423`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDiscoveryConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDiscoveryConfig(new DeleteDiscoveryConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a discovery configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the project and the config, for example
        /// `projects/dlp-test-project/discoveryConfigs/53234423`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDiscoveryConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDiscoveryConfigAsync(new DeleteDiscoveryConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a discovery configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the project and the config, for example
        /// `projects/dlp-test-project/discoveryConfigs/53234423`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDiscoveryConfigAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDiscoveryConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a discovery configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the project and the config, for example
        /// `projects/dlp-test-project/discoveryConfigs/53234423`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDiscoveryConfig(DiscoveryConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDiscoveryConfig(new DeleteDiscoveryConfigRequest
            {
                DiscoveryConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a discovery configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the project and the config, for example
        /// `projects/dlp-test-project/discoveryConfigs/53234423`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDiscoveryConfigAsync(DiscoveryConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDiscoveryConfigAsync(new DeleteDiscoveryConfigRequest
            {
                DiscoveryConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a discovery configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the project and the config, for example
        /// `projects/dlp-test-project/discoveryConfigs/53234423`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDiscoveryConfigAsync(DiscoveryConfigName name, st::CancellationToken cancellationToken) =>
            DeleteDiscoveryConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new job to inspect storage or calculate risk metrics.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// 
        /// When no InfoTypes or CustomInfoTypes are specified in inspect jobs, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DlpJob CreateDlpJob(CreateDlpJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new job to inspect storage or calculate risk metrics.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// 
        /// When no InfoTypes or CustomInfoTypes are specified in inspect jobs, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DlpJob> CreateDlpJobAsync(CreateDlpJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new job to inspect storage or calculate risk metrics.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// 
        /// When no InfoTypes or CustomInfoTypes are specified in inspect jobs, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DlpJob> CreateDlpJobAsync(CreateDlpJobRequest request, st::CancellationToken cancellationToken) =>
            CreateDlpJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new job to inspect storage or calculate risk metrics.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// 
        /// When no InfoTypes or CustomInfoTypes are specified in inspect jobs, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on whether you have [specified a
        /// processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="inspectJob">
        /// An inspection job scans a storage repository for InfoTypes.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DlpJob CreateDlpJob(string parent, InspectJobConfig inspectJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateDlpJob(new CreateDlpJobRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InspectJob = inspectJob,
            }, callSettings);

        /// <summary>
        /// Creates a new job to inspect storage or calculate risk metrics.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// 
        /// When no InfoTypes or CustomInfoTypes are specified in inspect jobs, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on whether you have [specified a
        /// processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="inspectJob">
        /// An inspection job scans a storage repository for InfoTypes.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DlpJob> CreateDlpJobAsync(string parent, InspectJobConfig inspectJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateDlpJobAsync(new CreateDlpJobRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                InspectJob = inspectJob,
            }, callSettings);

        /// <summary>
        /// Creates a new job to inspect storage or calculate risk metrics.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// 
        /// When no InfoTypes or CustomInfoTypes are specified in inspect jobs, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on whether you have [specified a
        /// processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="inspectJob">
        /// An inspection job scans a storage repository for InfoTypes.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DlpJob> CreateDlpJobAsync(string parent, InspectJobConfig inspectJob, st::CancellationToken cancellationToken) =>
            CreateDlpJobAsync(parent, inspectJob, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new job to inspect storage or calculate risk metrics.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// 
        /// When no InfoTypes or CustomInfoTypes are specified in inspect jobs, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on whether you have [specified a
        /// processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="inspectJob">
        /// An inspection job scans a storage repository for InfoTypes.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DlpJob CreateDlpJob(gagr::ProjectName parent, InspectJobConfig inspectJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateDlpJob(new CreateDlpJobRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InspectJob = inspectJob,
            }, callSettings);

        /// <summary>
        /// Creates a new job to inspect storage or calculate risk metrics.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// 
        /// When no InfoTypes or CustomInfoTypes are specified in inspect jobs, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on whether you have [specified a
        /// processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="inspectJob">
        /// An inspection job scans a storage repository for InfoTypes.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DlpJob> CreateDlpJobAsync(gagr::ProjectName parent, InspectJobConfig inspectJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateDlpJobAsync(new CreateDlpJobRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InspectJob = inspectJob,
            }, callSettings);

        /// <summary>
        /// Creates a new job to inspect storage or calculate risk metrics.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// 
        /// When no InfoTypes or CustomInfoTypes are specified in inspect jobs, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on whether you have [specified a
        /// processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="inspectJob">
        /// An inspection job scans a storage repository for InfoTypes.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DlpJob> CreateDlpJobAsync(gagr::ProjectName parent, InspectJobConfig inspectJob, st::CancellationToken cancellationToken) =>
            CreateDlpJobAsync(parent, inspectJob, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new job to inspect storage or calculate risk metrics.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// 
        /// When no InfoTypes or CustomInfoTypes are specified in inspect jobs, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on whether you have [specified a
        /// processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="inspectJob">
        /// An inspection job scans a storage repository for InfoTypes.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DlpJob CreateDlpJob(gagr::LocationName parent, InspectJobConfig inspectJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateDlpJob(new CreateDlpJobRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InspectJob = inspectJob,
            }, callSettings);

        /// <summary>
        /// Creates a new job to inspect storage or calculate risk metrics.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// 
        /// When no InfoTypes or CustomInfoTypes are specified in inspect jobs, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on whether you have [specified a
        /// processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="inspectJob">
        /// An inspection job scans a storage repository for InfoTypes.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DlpJob> CreateDlpJobAsync(gagr::LocationName parent, InspectJobConfig inspectJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateDlpJobAsync(new CreateDlpJobRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                InspectJob = inspectJob,
            }, callSettings);

        /// <summary>
        /// Creates a new job to inspect storage or calculate risk metrics.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// 
        /// When no InfoTypes or CustomInfoTypes are specified in inspect jobs, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on whether you have [specified a
        /// processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="inspectJob">
        /// An inspection job scans a storage repository for InfoTypes.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DlpJob> CreateDlpJobAsync(gagr::LocationName parent, InspectJobConfig inspectJob, st::CancellationToken cancellationToken) =>
            CreateDlpJobAsync(parent, inspectJob, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new job to inspect storage or calculate risk metrics.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// 
        /// When no InfoTypes or CustomInfoTypes are specified in inspect jobs, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on whether you have [specified a
        /// processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="riskJob">
        /// A risk analysis job calculates re-identification risk metrics for a
        /// BigQuery table.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DlpJob CreateDlpJob(string parent, RiskAnalysisJobConfig riskJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateDlpJob(new CreateDlpJobRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RiskJob = riskJob,
            }, callSettings);

        /// <summary>
        /// Creates a new job to inspect storage or calculate risk metrics.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// 
        /// When no InfoTypes or CustomInfoTypes are specified in inspect jobs, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on whether you have [specified a
        /// processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="riskJob">
        /// A risk analysis job calculates re-identification risk metrics for a
        /// BigQuery table.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DlpJob> CreateDlpJobAsync(string parent, RiskAnalysisJobConfig riskJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateDlpJobAsync(new CreateDlpJobRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                RiskJob = riskJob,
            }, callSettings);

        /// <summary>
        /// Creates a new job to inspect storage or calculate risk metrics.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// 
        /// When no InfoTypes or CustomInfoTypes are specified in inspect jobs, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on whether you have [specified a
        /// processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="riskJob">
        /// A risk analysis job calculates re-identification risk metrics for a
        /// BigQuery table.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DlpJob> CreateDlpJobAsync(string parent, RiskAnalysisJobConfig riskJob, st::CancellationToken cancellationToken) =>
            CreateDlpJobAsync(parent, riskJob, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new job to inspect storage or calculate risk metrics.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// 
        /// When no InfoTypes or CustomInfoTypes are specified in inspect jobs, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on whether you have [specified a
        /// processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="riskJob">
        /// A risk analysis job calculates re-identification risk metrics for a
        /// BigQuery table.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DlpJob CreateDlpJob(gagr::ProjectName parent, RiskAnalysisJobConfig riskJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateDlpJob(new CreateDlpJobRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RiskJob = riskJob,
            }, callSettings);

        /// <summary>
        /// Creates a new job to inspect storage or calculate risk metrics.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// 
        /// When no InfoTypes or CustomInfoTypes are specified in inspect jobs, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on whether you have [specified a
        /// processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="riskJob">
        /// A risk analysis job calculates re-identification risk metrics for a
        /// BigQuery table.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DlpJob> CreateDlpJobAsync(gagr::ProjectName parent, RiskAnalysisJobConfig riskJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateDlpJobAsync(new CreateDlpJobRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RiskJob = riskJob,
            }, callSettings);

        /// <summary>
        /// Creates a new job to inspect storage or calculate risk metrics.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// 
        /// When no InfoTypes or CustomInfoTypes are specified in inspect jobs, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on whether you have [specified a
        /// processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="riskJob">
        /// A risk analysis job calculates re-identification risk metrics for a
        /// BigQuery table.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DlpJob> CreateDlpJobAsync(gagr::ProjectName parent, RiskAnalysisJobConfig riskJob, st::CancellationToken cancellationToken) =>
            CreateDlpJobAsync(parent, riskJob, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new job to inspect storage or calculate risk metrics.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// 
        /// When no InfoTypes or CustomInfoTypes are specified in inspect jobs, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on whether you have [specified a
        /// processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="riskJob">
        /// A risk analysis job calculates re-identification risk metrics for a
        /// BigQuery table.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DlpJob CreateDlpJob(gagr::LocationName parent, RiskAnalysisJobConfig riskJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateDlpJob(new CreateDlpJobRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RiskJob = riskJob,
            }, callSettings);

        /// <summary>
        /// Creates a new job to inspect storage or calculate risk metrics.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// 
        /// When no InfoTypes or CustomInfoTypes are specified in inspect jobs, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on whether you have [specified a
        /// processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="riskJob">
        /// A risk analysis job calculates re-identification risk metrics for a
        /// BigQuery table.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DlpJob> CreateDlpJobAsync(gagr::LocationName parent, RiskAnalysisJobConfig riskJob, gaxgrpc::CallSettings callSettings = null) =>
            CreateDlpJobAsync(new CreateDlpJobRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                RiskJob = riskJob,
            }, callSettings);

        /// <summary>
        /// Creates a new job to inspect storage or calculate risk metrics.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// 
        /// When no InfoTypes or CustomInfoTypes are specified in inspect jobs, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on whether you have [specified a
        /// processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="riskJob">
        /// A risk analysis job calculates re-identification risk metrics for a
        /// BigQuery table.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DlpJob> CreateDlpJobAsync(gagr::LocationName parent, RiskAnalysisJobConfig riskJob, st::CancellationToken cancellationToken) =>
            CreateDlpJobAsync(parent, riskJob, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists DlpJobs that match the specified filter in the request.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DlpJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDlpJobsResponse, DlpJob> ListDlpJobs(ListDlpJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists DlpJobs that match the specified filter in the request.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DlpJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDlpJobsResponse, DlpJob> ListDlpJobsAsync(ListDlpJobsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists DlpJobs that match the specified filter in the request.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on whether you have [specified a
        /// processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable sequence of <see cref="DlpJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDlpJobsResponse, DlpJob> ListDlpJobs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDlpJobsRequest request = new ListDlpJobsRequest
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
            return ListDlpJobs(request, callSettings);
        }

        /// <summary>
        /// Lists DlpJobs that match the specified filter in the request.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on whether you have [specified a
        /// processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable asynchronous sequence of <see cref="DlpJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDlpJobsResponse, DlpJob> ListDlpJobsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDlpJobsRequest request = new ListDlpJobsRequest
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
            return ListDlpJobsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists DlpJobs that match the specified filter in the request.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on whether you have [specified a
        /// processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable sequence of <see cref="DlpJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDlpJobsResponse, DlpJob> ListDlpJobs(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDlpJobsRequest request = new ListDlpJobsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDlpJobs(request, callSettings);
        }

        /// <summary>
        /// Lists DlpJobs that match the specified filter in the request.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on whether you have [specified a
        /// processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable asynchronous sequence of <see cref="DlpJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDlpJobsResponse, DlpJob> ListDlpJobsAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDlpJobsRequest request = new ListDlpJobsRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDlpJobsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists DlpJobs that match the specified filter in the request.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on whether you have [specified a
        /// processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable sequence of <see cref="DlpJob"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDlpJobsResponse, DlpJob> ListDlpJobs(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDlpJobsRequest request = new ListDlpJobsRequest
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
            return ListDlpJobs(request, callSettings);
        }

        /// <summary>
        /// Lists DlpJobs that match the specified filter in the request.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on whether you have [specified a
        /// processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable asynchronous sequence of <see cref="DlpJob"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDlpJobsResponse, DlpJob> ListDlpJobsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDlpJobsRequest request = new ListDlpJobsRequest
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
            return ListDlpJobsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the latest state of a long-running DlpJob.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DlpJob GetDlpJob(GetDlpJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the latest state of a long-running DlpJob.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DlpJob> GetDlpJobAsync(GetDlpJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the latest state of a long-running DlpJob.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DlpJob> GetDlpJobAsync(GetDlpJobRequest request, st::CancellationToken cancellationToken) =>
            GetDlpJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the latest state of a long-running DlpJob.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DlpJob resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DlpJob GetDlpJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDlpJob(new GetDlpJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the latest state of a long-running DlpJob.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DlpJob resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DlpJob> GetDlpJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDlpJobAsync(new GetDlpJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the latest state of a long-running DlpJob.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DlpJob resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DlpJob> GetDlpJobAsync(string name, st::CancellationToken cancellationToken) =>
            GetDlpJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the latest state of a long-running DlpJob.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DlpJob resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DlpJob GetDlpJob(DlpJobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDlpJob(new GetDlpJobRequest
            {
                DlpJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the latest state of a long-running DlpJob.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DlpJob resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DlpJob> GetDlpJobAsync(DlpJobName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDlpJobAsync(new GetDlpJobRequest
            {
                DlpJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the latest state of a long-running DlpJob.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DlpJob resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DlpJob> GetDlpJobAsync(DlpJobName name, st::CancellationToken cancellationToken) =>
            GetDlpJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a long-running DlpJob. This method indicates that the client is
        /// no longer interested in the DlpJob result. The job will be canceled if
        /// possible.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDlpJob(DeleteDlpJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a long-running DlpJob. This method indicates that the client is
        /// no longer interested in the DlpJob result. The job will be canceled if
        /// possible.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDlpJobAsync(DeleteDlpJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a long-running DlpJob. This method indicates that the client is
        /// no longer interested in the DlpJob result. The job will be canceled if
        /// possible.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDlpJobAsync(DeleteDlpJobRequest request, st::CancellationToken cancellationToken) =>
            DeleteDlpJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a long-running DlpJob. This method indicates that the client is
        /// no longer interested in the DlpJob result. The job will be canceled if
        /// possible.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DlpJob resource to be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDlpJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDlpJob(new DeleteDlpJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a long-running DlpJob. This method indicates that the client is
        /// no longer interested in the DlpJob result. The job will be canceled if
        /// possible.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DlpJob resource to be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDlpJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDlpJobAsync(new DeleteDlpJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a long-running DlpJob. This method indicates that the client is
        /// no longer interested in the DlpJob result. The job will be canceled if
        /// possible.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DlpJob resource to be deleted.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDlpJobAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDlpJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a long-running DlpJob. This method indicates that the client is
        /// no longer interested in the DlpJob result. The job will be canceled if
        /// possible.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DlpJob resource to be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteDlpJob(DlpJobName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDlpJob(new DeleteDlpJobRequest
            {
                DlpJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a long-running DlpJob. This method indicates that the client is
        /// no longer interested in the DlpJob result. The job will be canceled if
        /// possible.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DlpJob resource to be deleted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDlpJobAsync(DlpJobName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDlpJobAsync(new DeleteDlpJobRequest
            {
                DlpJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a long-running DlpJob. This method indicates that the client is
        /// no longer interested in the DlpJob result. The job will be canceled if
        /// possible.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the DlpJob resource to be deleted.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteDlpJobAsync(DlpJobName name, st::CancellationToken cancellationToken) =>
            DeleteDlpJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts asynchronous cancellation on a long-running DlpJob. The server
        /// makes a best effort to cancel the DlpJob, but success is not
        /// guaranteed.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void CancelDlpJob(CancelDlpJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts asynchronous cancellation on a long-running DlpJob. The server
        /// makes a best effort to cancel the DlpJob, but success is not
        /// guaranteed.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelDlpJobAsync(CancelDlpJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts asynchronous cancellation on a long-running DlpJob. The server
        /// makes a best effort to cancel the DlpJob, but success is not
        /// guaranteed.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task CancelDlpJobAsync(CancelDlpJobRequest request, st::CancellationToken cancellationToken) =>
            CancelDlpJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a pre-built stored infoType to be used for inspection.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StoredInfoType CreateStoredInfoType(CreateStoredInfoTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a pre-built stored infoType to be used for inspection.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StoredInfoType> CreateStoredInfoTypeAsync(CreateStoredInfoTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a pre-built stored infoType to be used for inspection.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StoredInfoType> CreateStoredInfoTypeAsync(CreateStoredInfoTypeRequest request, st::CancellationToken cancellationToken) =>
            CreateStoredInfoTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a pre-built stored infoType to be used for inspection.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="config">
        /// Required. Configuration of the storedInfoType to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StoredInfoType CreateStoredInfoType(string parent, StoredInfoTypeConfig config, gaxgrpc::CallSettings callSettings = null) =>
            CreateStoredInfoType(new CreateStoredInfoTypeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Config = gax::GaxPreconditions.CheckNotNull(config, nameof(config)),
            }, callSettings);

        /// <summary>
        /// Creates a pre-built stored infoType to be used for inspection.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="config">
        /// Required. Configuration of the storedInfoType to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StoredInfoType> CreateStoredInfoTypeAsync(string parent, StoredInfoTypeConfig config, gaxgrpc::CallSettings callSettings = null) =>
            CreateStoredInfoTypeAsync(new CreateStoredInfoTypeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Config = gax::GaxPreconditions.CheckNotNull(config, nameof(config)),
            }, callSettings);

        /// <summary>
        /// Creates a pre-built stored infoType to be used for inspection.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="config">
        /// Required. Configuration of the storedInfoType to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StoredInfoType> CreateStoredInfoTypeAsync(string parent, StoredInfoTypeConfig config, st::CancellationToken cancellationToken) =>
            CreateStoredInfoTypeAsync(parent, config, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a pre-built stored infoType to be used for inspection.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="config">
        /// Required. Configuration of the storedInfoType to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StoredInfoType CreateStoredInfoType(gagr::OrganizationName parent, StoredInfoTypeConfig config, gaxgrpc::CallSettings callSettings = null) =>
            CreateStoredInfoType(new CreateStoredInfoTypeRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Config = gax::GaxPreconditions.CheckNotNull(config, nameof(config)),
            }, callSettings);

        /// <summary>
        /// Creates a pre-built stored infoType to be used for inspection.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="config">
        /// Required. Configuration of the storedInfoType to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StoredInfoType> CreateStoredInfoTypeAsync(gagr::OrganizationName parent, StoredInfoTypeConfig config, gaxgrpc::CallSettings callSettings = null) =>
            CreateStoredInfoTypeAsync(new CreateStoredInfoTypeRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Config = gax::GaxPreconditions.CheckNotNull(config, nameof(config)),
            }, callSettings);

        /// <summary>
        /// Creates a pre-built stored infoType to be used for inspection.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="config">
        /// Required. Configuration of the storedInfoType to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StoredInfoType> CreateStoredInfoTypeAsync(gagr::OrganizationName parent, StoredInfoTypeConfig config, st::CancellationToken cancellationToken) =>
            CreateStoredInfoTypeAsync(parent, config, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a pre-built stored infoType to be used for inspection.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="config">
        /// Required. Configuration of the storedInfoType to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StoredInfoType CreateStoredInfoType(gagr::ProjectName parent, StoredInfoTypeConfig config, gaxgrpc::CallSettings callSettings = null) =>
            CreateStoredInfoType(new CreateStoredInfoTypeRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Config = gax::GaxPreconditions.CheckNotNull(config, nameof(config)),
            }, callSettings);

        /// <summary>
        /// Creates a pre-built stored infoType to be used for inspection.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="config">
        /// Required. Configuration of the storedInfoType to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StoredInfoType> CreateStoredInfoTypeAsync(gagr::ProjectName parent, StoredInfoTypeConfig config, gaxgrpc::CallSettings callSettings = null) =>
            CreateStoredInfoTypeAsync(new CreateStoredInfoTypeRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Config = gax::GaxPreconditions.CheckNotNull(config, nameof(config)),
            }, callSettings);

        /// <summary>
        /// Creates a pre-built stored infoType to be used for inspection.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="config">
        /// Required. Configuration of the storedInfoType to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StoredInfoType> CreateStoredInfoTypeAsync(gagr::ProjectName parent, StoredInfoTypeConfig config, st::CancellationToken cancellationToken) =>
            CreateStoredInfoTypeAsync(parent, config, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a pre-built stored infoType to be used for inspection.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="config">
        /// Required. Configuration of the storedInfoType to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StoredInfoType CreateStoredInfoType(OrganizationLocationName parent, StoredInfoTypeConfig config, gaxgrpc::CallSettings callSettings = null) =>
            CreateStoredInfoType(new CreateStoredInfoTypeRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Config = gax::GaxPreconditions.CheckNotNull(config, nameof(config)),
            }, callSettings);

        /// <summary>
        /// Creates a pre-built stored infoType to be used for inspection.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="config">
        /// Required. Configuration of the storedInfoType to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StoredInfoType> CreateStoredInfoTypeAsync(OrganizationLocationName parent, StoredInfoTypeConfig config, gaxgrpc::CallSettings callSettings = null) =>
            CreateStoredInfoTypeAsync(new CreateStoredInfoTypeRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Config = gax::GaxPreconditions.CheckNotNull(config, nameof(config)),
            }, callSettings);

        /// <summary>
        /// Creates a pre-built stored infoType to be used for inspection.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="config">
        /// Required. Configuration of the storedInfoType to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StoredInfoType> CreateStoredInfoTypeAsync(OrganizationLocationName parent, StoredInfoTypeConfig config, st::CancellationToken cancellationToken) =>
            CreateStoredInfoTypeAsync(parent, config, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a pre-built stored infoType to be used for inspection.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="config">
        /// Required. Configuration of the storedInfoType to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StoredInfoType CreateStoredInfoType(gagr::LocationName parent, StoredInfoTypeConfig config, gaxgrpc::CallSettings callSettings = null) =>
            CreateStoredInfoType(new CreateStoredInfoTypeRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Config = gax::GaxPreconditions.CheckNotNull(config, nameof(config)),
            }, callSettings);

        /// <summary>
        /// Creates a pre-built stored infoType to be used for inspection.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="config">
        /// Required. Configuration of the storedInfoType to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StoredInfoType> CreateStoredInfoTypeAsync(gagr::LocationName parent, StoredInfoTypeConfig config, gaxgrpc::CallSettings callSettings = null) =>
            CreateStoredInfoTypeAsync(new CreateStoredInfoTypeRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Config = gax::GaxPreconditions.CheckNotNull(config, nameof(config)),
            }, callSettings);

        /// <summary>
        /// Creates a pre-built stored infoType to be used for inspection.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// + Organizations scope, location specified:
        /// `organizations/{org_id}/locations/{location_id}`
        /// + Organizations scope, no location specified (defaults to global):
        /// `organizations/{org_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
        /// </param>
        /// <param name="config">
        /// Required. Configuration of the storedInfoType to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StoredInfoType> CreateStoredInfoTypeAsync(gagr::LocationName parent, StoredInfoTypeConfig config, st::CancellationToken cancellationToken) =>
            CreateStoredInfoTypeAsync(parent, config, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the stored infoType by creating a new version. The existing version
        /// will continue to be used until the new version is ready.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StoredInfoType UpdateStoredInfoType(UpdateStoredInfoTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the stored infoType by creating a new version. The existing version
        /// will continue to be used until the new version is ready.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StoredInfoType> UpdateStoredInfoTypeAsync(UpdateStoredInfoTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the stored infoType by creating a new version. The existing version
        /// will continue to be used until the new version is ready.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StoredInfoType> UpdateStoredInfoTypeAsync(UpdateStoredInfoTypeRequest request, st::CancellationToken cancellationToken) =>
            UpdateStoredInfoTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the stored infoType by creating a new version. The existing version
        /// will continue to be used until the new version is ready.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of organization and storedInfoType to be updated,
        /// for example `organizations/433245324/storedInfoTypes/432452342` or
        /// projects/project-id/storedInfoTypes/432452342.
        /// </param>
        /// <param name="config">
        /// Updated configuration for the storedInfoType. If not provided, a new
        /// version of the storedInfoType will be created with the existing
        /// configuration.
        /// </param>
        /// <param name="updateMask">
        /// Mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StoredInfoType UpdateStoredInfoType(string name, StoredInfoTypeConfig config, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateStoredInfoType(new UpdateStoredInfoTypeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Config = config,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the stored infoType by creating a new version. The existing version
        /// will continue to be used until the new version is ready.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of organization and storedInfoType to be updated,
        /// for example `organizations/433245324/storedInfoTypes/432452342` or
        /// projects/project-id/storedInfoTypes/432452342.
        /// </param>
        /// <param name="config">
        /// Updated configuration for the storedInfoType. If not provided, a new
        /// version of the storedInfoType will be created with the existing
        /// configuration.
        /// </param>
        /// <param name="updateMask">
        /// Mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StoredInfoType> UpdateStoredInfoTypeAsync(string name, StoredInfoTypeConfig config, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateStoredInfoTypeAsync(new UpdateStoredInfoTypeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Config = config,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the stored infoType by creating a new version. The existing version
        /// will continue to be used until the new version is ready.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of organization and storedInfoType to be updated,
        /// for example `organizations/433245324/storedInfoTypes/432452342` or
        /// projects/project-id/storedInfoTypes/432452342.
        /// </param>
        /// <param name="config">
        /// Updated configuration for the storedInfoType. If not provided, a new
        /// version of the storedInfoType will be created with the existing
        /// configuration.
        /// </param>
        /// <param name="updateMask">
        /// Mask to control which fields get updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StoredInfoType> UpdateStoredInfoTypeAsync(string name, StoredInfoTypeConfig config, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateStoredInfoTypeAsync(name, config, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the stored infoType by creating a new version. The existing version
        /// will continue to be used until the new version is ready.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of organization and storedInfoType to be updated,
        /// for example `organizations/433245324/storedInfoTypes/432452342` or
        /// projects/project-id/storedInfoTypes/432452342.
        /// </param>
        /// <param name="config">
        /// Updated configuration for the storedInfoType. If not provided, a new
        /// version of the storedInfoType will be created with the existing
        /// configuration.
        /// </param>
        /// <param name="updateMask">
        /// Mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StoredInfoType UpdateStoredInfoType(StoredInfoTypeName name, StoredInfoTypeConfig config, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateStoredInfoType(new UpdateStoredInfoTypeRequest
            {
                StoredInfoTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Config = config,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the stored infoType by creating a new version. The existing version
        /// will continue to be used until the new version is ready.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of organization and storedInfoType to be updated,
        /// for example `organizations/433245324/storedInfoTypes/432452342` or
        /// projects/project-id/storedInfoTypes/432452342.
        /// </param>
        /// <param name="config">
        /// Updated configuration for the storedInfoType. If not provided, a new
        /// version of the storedInfoType will be created with the existing
        /// configuration.
        /// </param>
        /// <param name="updateMask">
        /// Mask to control which fields get updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StoredInfoType> UpdateStoredInfoTypeAsync(StoredInfoTypeName name, StoredInfoTypeConfig config, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateStoredInfoTypeAsync(new UpdateStoredInfoTypeRequest
            {
                StoredInfoTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                Config = config,
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the stored infoType by creating a new version. The existing version
        /// will continue to be used until the new version is ready.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of organization and storedInfoType to be updated,
        /// for example `organizations/433245324/storedInfoTypes/432452342` or
        /// projects/project-id/storedInfoTypes/432452342.
        /// </param>
        /// <param name="config">
        /// Updated configuration for the storedInfoType. If not provided, a new
        /// version of the storedInfoType will be created with the existing
        /// configuration.
        /// </param>
        /// <param name="updateMask">
        /// Mask to control which fields get updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StoredInfoType> UpdateStoredInfoTypeAsync(StoredInfoTypeName name, StoredInfoTypeConfig config, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateStoredInfoTypeAsync(name, config, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a stored infoType.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StoredInfoType GetStoredInfoType(GetStoredInfoTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a stored infoType.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StoredInfoType> GetStoredInfoTypeAsync(GetStoredInfoTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a stored infoType.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StoredInfoType> GetStoredInfoTypeAsync(GetStoredInfoTypeRequest request, st::CancellationToken cancellationToken) =>
            GetStoredInfoTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a stored infoType.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the organization and storedInfoType to be read,
        /// for example `organizations/433245324/storedInfoTypes/432452342` or
        /// projects/project-id/storedInfoTypes/432452342.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StoredInfoType GetStoredInfoType(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetStoredInfoType(new GetStoredInfoTypeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a stored infoType.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the organization and storedInfoType to be read,
        /// for example `organizations/433245324/storedInfoTypes/432452342` or
        /// projects/project-id/storedInfoTypes/432452342.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StoredInfoType> GetStoredInfoTypeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetStoredInfoTypeAsync(new GetStoredInfoTypeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a stored infoType.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the organization and storedInfoType to be read,
        /// for example `organizations/433245324/storedInfoTypes/432452342` or
        /// projects/project-id/storedInfoTypes/432452342.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StoredInfoType> GetStoredInfoTypeAsync(string name, st::CancellationToken cancellationToken) =>
            GetStoredInfoTypeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a stored infoType.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the organization and storedInfoType to be read,
        /// for example `organizations/433245324/storedInfoTypes/432452342` or
        /// projects/project-id/storedInfoTypes/432452342.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StoredInfoType GetStoredInfoType(StoredInfoTypeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetStoredInfoType(new GetStoredInfoTypeRequest
            {
                StoredInfoTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a stored infoType.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the organization and storedInfoType to be read,
        /// for example `organizations/433245324/storedInfoTypes/432452342` or
        /// projects/project-id/storedInfoTypes/432452342.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StoredInfoType> GetStoredInfoTypeAsync(StoredInfoTypeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetStoredInfoTypeAsync(new GetStoredInfoTypeRequest
            {
                StoredInfoTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a stored infoType.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the organization and storedInfoType to be read,
        /// for example `organizations/433245324/storedInfoTypes/432452342` or
        /// projects/project-id/storedInfoTypes/432452342.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StoredInfoType> GetStoredInfoTypeAsync(StoredInfoTypeName name, st::CancellationToken cancellationToken) =>
            GetStoredInfoTypeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists stored infoTypes.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="StoredInfoType"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListStoredInfoTypesResponse, StoredInfoType> ListStoredInfoTypes(ListStoredInfoTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists stored infoTypes.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="StoredInfoType"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListStoredInfoTypesResponse, StoredInfoType> ListStoredInfoTypesAsync(ListStoredInfoTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists stored infoTypes.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable sequence of <see cref="StoredInfoType"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListStoredInfoTypesResponse, StoredInfoType> ListStoredInfoTypes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListStoredInfoTypesRequest request = new ListStoredInfoTypesRequest
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
            return ListStoredInfoTypes(request, callSettings);
        }

        /// <summary>
        /// Lists stored infoTypes.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable asynchronous sequence of <see cref="StoredInfoType"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListStoredInfoTypesResponse, StoredInfoType> ListStoredInfoTypesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListStoredInfoTypesRequest request = new ListStoredInfoTypesRequest
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
            return ListStoredInfoTypesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists stored infoTypes.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable sequence of <see cref="StoredInfoType"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListStoredInfoTypesResponse, StoredInfoType> ListStoredInfoTypes(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListStoredInfoTypesRequest request = new ListStoredInfoTypesRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListStoredInfoTypes(request, callSettings);
        }

        /// <summary>
        /// Lists stored infoTypes.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable asynchronous sequence of <see cref="StoredInfoType"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListStoredInfoTypesResponse, StoredInfoType> ListStoredInfoTypesAsync(gagr::OrganizationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListStoredInfoTypesRequest request = new ListStoredInfoTypesRequest
            {
                ParentAsOrganizationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListStoredInfoTypesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists stored infoTypes.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable sequence of <see cref="StoredInfoType"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListStoredInfoTypesResponse, StoredInfoType> ListStoredInfoTypes(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListStoredInfoTypesRequest request = new ListStoredInfoTypesRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListStoredInfoTypes(request, callSettings);
        }

        /// <summary>
        /// Lists stored infoTypes.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable asynchronous sequence of <see cref="StoredInfoType"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListStoredInfoTypesResponse, StoredInfoType> ListStoredInfoTypesAsync(gagr::ProjectName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListStoredInfoTypesRequest request = new ListStoredInfoTypesRequest
            {
                ParentAsProjectName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListStoredInfoTypesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists stored infoTypes.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable sequence of <see cref="StoredInfoType"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListStoredInfoTypesResponse, StoredInfoType> ListStoredInfoTypes(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListStoredInfoTypesRequest request = new ListStoredInfoTypesRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListStoredInfoTypes(request, callSettings);
        }

        /// <summary>
        /// Lists stored infoTypes.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable asynchronous sequence of <see cref="StoredInfoType"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListStoredInfoTypesResponse, StoredInfoType> ListStoredInfoTypesAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListStoredInfoTypesRequest request = new ListStoredInfoTypesRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListStoredInfoTypesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists stored infoTypes.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable sequence of <see cref="StoredInfoType"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListStoredInfoTypesResponse, StoredInfoType> ListStoredInfoTypes(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListStoredInfoTypesRequest request = new ListStoredInfoTypesRequest
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
            return ListStoredInfoTypes(request, callSettings);
        }

        /// <summary>
        /// Lists stored infoTypes.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization) and whether you have [specified a processing
        /// location](https://cloud.google.com/sensitive-data-protection/docs/specifying-location):
        /// 
        /// + Projects scope, location specified:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Projects scope, no location specified (defaults to global):
        /// `projects/{project_id}`
        /// 
        /// The following example `parent` string specifies a parent project with the
        /// identifier `example-project`, and specifies the `europe-west3` location
        /// for processing data:
        /// 
        /// parent=projects/example-project/locations/europe-west3
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
        /// <returns>A pageable asynchronous sequence of <see cref="StoredInfoType"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListStoredInfoTypesResponse, StoredInfoType> ListStoredInfoTypesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListStoredInfoTypesRequest request = new ListStoredInfoTypesRequest
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
            return ListStoredInfoTypesAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a stored infoType.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteStoredInfoType(DeleteStoredInfoTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a stored infoType.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteStoredInfoTypeAsync(DeleteStoredInfoTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a stored infoType.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteStoredInfoTypeAsync(DeleteStoredInfoTypeRequest request, st::CancellationToken cancellationToken) =>
            DeleteStoredInfoTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a stored infoType.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the organization and storedInfoType to be
        /// deleted, for example `organizations/433245324/storedInfoTypes/432452342` or
        /// projects/project-id/storedInfoTypes/432452342.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteStoredInfoType(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteStoredInfoType(new DeleteStoredInfoTypeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a stored infoType.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the organization and storedInfoType to be
        /// deleted, for example `organizations/433245324/storedInfoTypes/432452342` or
        /// projects/project-id/storedInfoTypes/432452342.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteStoredInfoTypeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteStoredInfoTypeAsync(new DeleteStoredInfoTypeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a stored infoType.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the organization and storedInfoType to be
        /// deleted, for example `organizations/433245324/storedInfoTypes/432452342` or
        /// projects/project-id/storedInfoTypes/432452342.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteStoredInfoTypeAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteStoredInfoTypeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a stored infoType.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the organization and storedInfoType to be
        /// deleted, for example `organizations/433245324/storedInfoTypes/432452342` or
        /// projects/project-id/storedInfoTypes/432452342.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteStoredInfoType(StoredInfoTypeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteStoredInfoType(new DeleteStoredInfoTypeRequest
            {
                StoredInfoTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a stored infoType.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the organization and storedInfoType to be
        /// deleted, for example `organizations/433245324/storedInfoTypes/432452342` or
        /// projects/project-id/storedInfoTypes/432452342.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteStoredInfoTypeAsync(StoredInfoTypeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteStoredInfoTypeAsync(new DeleteStoredInfoTypeRequest
            {
                StoredInfoTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a stored infoType.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the organization and storedInfoType to be
        /// deleted, for example `organizations/433245324/storedInfoTypes/432452342` or
        /// projects/project-id/storedInfoTypes/432452342.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteStoredInfoTypeAsync(StoredInfoTypeName name, st::CancellationToken cancellationToken) =>
            DeleteStoredInfoTypeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists project data profiles for an organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ProjectDataProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProjectDataProfilesResponse, ProjectDataProfile> ListProjectDataProfiles(ListProjectDataProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists project data profiles for an organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ProjectDataProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProjectDataProfilesResponse, ProjectDataProfile> ListProjectDataProfilesAsync(ListProjectDataProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists project data profiles for an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. organizations/{org_id}/locations/{loc_id}
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
        /// <returns>A pageable sequence of <see cref="ProjectDataProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProjectDataProfilesResponse, ProjectDataProfile> ListProjectDataProfiles(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProjectDataProfilesRequest request = new ListProjectDataProfilesRequest
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
            return ListProjectDataProfiles(request, callSettings);
        }

        /// <summary>
        /// Lists project data profiles for an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. organizations/{org_id}/locations/{loc_id}
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
        /// <returns>A pageable asynchronous sequence of <see cref="ProjectDataProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProjectDataProfilesResponse, ProjectDataProfile> ListProjectDataProfilesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProjectDataProfilesRequest request = new ListProjectDataProfilesRequest
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
            return ListProjectDataProfilesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists project data profiles for an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. organizations/{org_id}/locations/{loc_id}
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
        /// <returns>A pageable sequence of <see cref="ProjectDataProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProjectDataProfilesResponse, ProjectDataProfile> ListProjectDataProfiles(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProjectDataProfilesRequest request = new ListProjectDataProfilesRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListProjectDataProfiles(request, callSettings);
        }

        /// <summary>
        /// Lists project data profiles for an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. organizations/{org_id}/locations/{loc_id}
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
        /// <returns>A pageable asynchronous sequence of <see cref="ProjectDataProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProjectDataProfilesResponse, ProjectDataProfile> ListProjectDataProfilesAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProjectDataProfilesRequest request = new ListProjectDataProfilesRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListProjectDataProfilesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists project data profiles for an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. organizations/{org_id}/locations/{loc_id}
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
        /// <returns>A pageable sequence of <see cref="ProjectDataProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProjectDataProfilesResponse, ProjectDataProfile> ListProjectDataProfiles(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProjectDataProfilesRequest request = new ListProjectDataProfilesRequest
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
            return ListProjectDataProfiles(request, callSettings);
        }

        /// <summary>
        /// Lists project data profiles for an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. organizations/{org_id}/locations/{loc_id}
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
        /// <returns>A pageable asynchronous sequence of <see cref="ProjectDataProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProjectDataProfilesResponse, ProjectDataProfile> ListProjectDataProfilesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListProjectDataProfilesRequest request = new ListProjectDataProfilesRequest
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
            return ListProjectDataProfilesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists table data profiles for an organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TableDataProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTableDataProfilesResponse, TableDataProfile> ListTableDataProfiles(ListTableDataProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists table data profiles for an organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TableDataProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTableDataProfilesResponse, TableDataProfile> ListTableDataProfilesAsync(ListTableDataProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists table data profiles for an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the organization or project, for
        /// example `organizations/433245324/locations/europe` or
        /// `projects/project-id/locations/asia`.
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
        /// <returns>A pageable sequence of <see cref="TableDataProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTableDataProfilesResponse, TableDataProfile> ListTableDataProfiles(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTableDataProfilesRequest request = new ListTableDataProfilesRequest
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
            return ListTableDataProfiles(request, callSettings);
        }

        /// <summary>
        /// Lists table data profiles for an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the organization or project, for
        /// example `organizations/433245324/locations/europe` or
        /// `projects/project-id/locations/asia`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TableDataProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTableDataProfilesResponse, TableDataProfile> ListTableDataProfilesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTableDataProfilesRequest request = new ListTableDataProfilesRequest
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
            return ListTableDataProfilesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists table data profiles for an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the organization or project, for
        /// example `organizations/433245324/locations/europe` or
        /// `projects/project-id/locations/asia`.
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
        /// <returns>A pageable sequence of <see cref="TableDataProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTableDataProfilesResponse, TableDataProfile> ListTableDataProfiles(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTableDataProfilesRequest request = new ListTableDataProfilesRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTableDataProfiles(request, callSettings);
        }

        /// <summary>
        /// Lists table data profiles for an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the organization or project, for
        /// example `organizations/433245324/locations/europe` or
        /// `projects/project-id/locations/asia`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TableDataProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTableDataProfilesResponse, TableDataProfile> ListTableDataProfilesAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTableDataProfilesRequest request = new ListTableDataProfilesRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListTableDataProfilesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists table data profiles for an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the organization or project, for
        /// example `organizations/433245324/locations/europe` or
        /// `projects/project-id/locations/asia`.
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
        /// <returns>A pageable sequence of <see cref="TableDataProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTableDataProfilesResponse, TableDataProfile> ListTableDataProfiles(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTableDataProfilesRequest request = new ListTableDataProfilesRequest
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
            return ListTableDataProfiles(request, callSettings);
        }

        /// <summary>
        /// Lists table data profiles for an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the organization or project, for
        /// example `organizations/433245324/locations/europe` or
        /// `projects/project-id/locations/asia`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TableDataProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTableDataProfilesResponse, TableDataProfile> ListTableDataProfilesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTableDataProfilesRequest request = new ListTableDataProfilesRequest
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
            return ListTableDataProfilesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists column data profiles for an organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ColumnDataProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListColumnDataProfilesResponse, ColumnDataProfile> ListColumnDataProfiles(ListColumnDataProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists column data profiles for an organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ColumnDataProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListColumnDataProfilesResponse, ColumnDataProfile> ListColumnDataProfilesAsync(ListColumnDataProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists column data profiles for an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the organization or project, for
        /// example `organizations/433245324/locations/europe` or
        /// `projects/project-id/locations/asia`.
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
        /// <returns>A pageable sequence of <see cref="ColumnDataProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListColumnDataProfilesResponse, ColumnDataProfile> ListColumnDataProfiles(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListColumnDataProfilesRequest request = new ListColumnDataProfilesRequest
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
            return ListColumnDataProfiles(request, callSettings);
        }

        /// <summary>
        /// Lists column data profiles for an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the organization or project, for
        /// example `organizations/433245324/locations/europe` or
        /// `projects/project-id/locations/asia`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ColumnDataProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListColumnDataProfilesResponse, ColumnDataProfile> ListColumnDataProfilesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListColumnDataProfilesRequest request = new ListColumnDataProfilesRequest
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
            return ListColumnDataProfilesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists column data profiles for an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the organization or project, for
        /// example `organizations/433245324/locations/europe` or
        /// `projects/project-id/locations/asia`.
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
        /// <returns>A pageable sequence of <see cref="ColumnDataProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListColumnDataProfilesResponse, ColumnDataProfile> ListColumnDataProfiles(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListColumnDataProfilesRequest request = new ListColumnDataProfilesRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListColumnDataProfiles(request, callSettings);
        }

        /// <summary>
        /// Lists column data profiles for an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the organization or project, for
        /// example `organizations/433245324/locations/europe` or
        /// `projects/project-id/locations/asia`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ColumnDataProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListColumnDataProfilesResponse, ColumnDataProfile> ListColumnDataProfilesAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListColumnDataProfilesRequest request = new ListColumnDataProfilesRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListColumnDataProfilesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists column data profiles for an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the organization or project, for
        /// example `organizations/433245324/locations/europe` or
        /// `projects/project-id/locations/asia`.
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
        /// <returns>A pageable sequence of <see cref="ColumnDataProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListColumnDataProfilesResponse, ColumnDataProfile> ListColumnDataProfiles(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListColumnDataProfilesRequest request = new ListColumnDataProfilesRequest
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
            return ListColumnDataProfiles(request, callSettings);
        }

        /// <summary>
        /// Lists column data profiles for an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the organization or project, for
        /// example `organizations/433245324/locations/europe` or
        /// `projects/project-id/locations/asia`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ColumnDataProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListColumnDataProfilesResponse, ColumnDataProfile> ListColumnDataProfilesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListColumnDataProfilesRequest request = new ListColumnDataProfilesRequest
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
            return ListColumnDataProfilesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a project data profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProjectDataProfile GetProjectDataProfile(GetProjectDataProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a project data profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProjectDataProfile> GetProjectDataProfileAsync(GetProjectDataProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a project data profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProjectDataProfile> GetProjectDataProfileAsync(GetProjectDataProfileRequest request, st::CancellationToken cancellationToken) =>
            GetProjectDataProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a project data profile.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name, for example
        /// `organizations/12345/locations/us/projectDataProfiles/53234423`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProjectDataProfile GetProjectDataProfile(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProjectDataProfile(new GetProjectDataProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a project data profile.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name, for example
        /// `organizations/12345/locations/us/projectDataProfiles/53234423`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProjectDataProfile> GetProjectDataProfileAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetProjectDataProfileAsync(new GetProjectDataProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a project data profile.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name, for example
        /// `organizations/12345/locations/us/projectDataProfiles/53234423`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProjectDataProfile> GetProjectDataProfileAsync(string name, st::CancellationToken cancellationToken) =>
            GetProjectDataProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a project data profile.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name, for example
        /// `organizations/12345/locations/us/projectDataProfiles/53234423`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ProjectDataProfile GetProjectDataProfile(ProjectDataProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProjectDataProfile(new GetProjectDataProfileRequest
            {
                ProjectDataProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a project data profile.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name, for example
        /// `organizations/12345/locations/us/projectDataProfiles/53234423`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProjectDataProfile> GetProjectDataProfileAsync(ProjectDataProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            GetProjectDataProfileAsync(new GetProjectDataProfileRequest
            {
                ProjectDataProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a project data profile.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name, for example
        /// `organizations/12345/locations/us/projectDataProfiles/53234423`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ProjectDataProfile> GetProjectDataProfileAsync(ProjectDataProfileName name, st::CancellationToken cancellationToken) =>
            GetProjectDataProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists file store data profiles for an organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FileStoreDataProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFileStoreDataProfilesResponse, FileStoreDataProfile> ListFileStoreDataProfiles(ListFileStoreDataProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists file store data profiles for an organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FileStoreDataProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFileStoreDataProfilesResponse, FileStoreDataProfile> ListFileStoreDataProfilesAsync(ListFileStoreDataProfilesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists file store data profiles for an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the organization or project, for
        /// example `organizations/433245324/locations/europe` or
        /// `projects/project-id/locations/asia`.
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
        /// <returns>A pageable sequence of <see cref="FileStoreDataProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFileStoreDataProfilesResponse, FileStoreDataProfile> ListFileStoreDataProfiles(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFileStoreDataProfilesRequest request = new ListFileStoreDataProfilesRequest
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
            return ListFileStoreDataProfiles(request, callSettings);
        }

        /// <summary>
        /// Lists file store data profiles for an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the organization or project, for
        /// example `organizations/433245324/locations/europe` or
        /// `projects/project-id/locations/asia`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="FileStoreDataProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFileStoreDataProfilesResponse, FileStoreDataProfile> ListFileStoreDataProfilesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFileStoreDataProfilesRequest request = new ListFileStoreDataProfilesRequest
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
            return ListFileStoreDataProfilesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists file store data profiles for an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the organization or project, for
        /// example `organizations/433245324/locations/europe` or
        /// `projects/project-id/locations/asia`.
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
        /// <returns>A pageable sequence of <see cref="FileStoreDataProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFileStoreDataProfilesResponse, FileStoreDataProfile> ListFileStoreDataProfiles(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFileStoreDataProfilesRequest request = new ListFileStoreDataProfilesRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFileStoreDataProfiles(request, callSettings);
        }

        /// <summary>
        /// Lists file store data profiles for an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the organization or project, for
        /// example `organizations/433245324/locations/europe` or
        /// `projects/project-id/locations/asia`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="FileStoreDataProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFileStoreDataProfilesResponse, FileStoreDataProfile> ListFileStoreDataProfilesAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFileStoreDataProfilesRequest request = new ListFileStoreDataProfilesRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListFileStoreDataProfilesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists file store data profiles for an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the organization or project, for
        /// example `organizations/433245324/locations/europe` or
        /// `projects/project-id/locations/asia`.
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
        /// <returns>A pageable sequence of <see cref="FileStoreDataProfile"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFileStoreDataProfilesResponse, FileStoreDataProfile> ListFileStoreDataProfiles(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFileStoreDataProfilesRequest request = new ListFileStoreDataProfilesRequest
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
            return ListFileStoreDataProfiles(request, callSettings);
        }

        /// <summary>
        /// Lists file store data profiles for an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the organization or project, for
        /// example `organizations/433245324/locations/europe` or
        /// `projects/project-id/locations/asia`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="FileStoreDataProfile"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFileStoreDataProfilesResponse, FileStoreDataProfile> ListFileStoreDataProfilesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFileStoreDataProfilesRequest request = new ListFileStoreDataProfilesRequest
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
            return ListFileStoreDataProfilesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a file store data profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FileStoreDataProfile GetFileStoreDataProfile(GetFileStoreDataProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a file store data profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FileStoreDataProfile> GetFileStoreDataProfileAsync(GetFileStoreDataProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a file store data profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FileStoreDataProfile> GetFileStoreDataProfileAsync(GetFileStoreDataProfileRequest request, st::CancellationToken cancellationToken) =>
            GetFileStoreDataProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a file store data profile.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name, for example
        /// `organizations/12345/locations/us/fileStoreDataProfiles/53234423`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FileStoreDataProfile GetFileStoreDataProfile(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFileStoreDataProfile(new GetFileStoreDataProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a file store data profile.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name, for example
        /// `organizations/12345/locations/us/fileStoreDataProfiles/53234423`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FileStoreDataProfile> GetFileStoreDataProfileAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFileStoreDataProfileAsync(new GetFileStoreDataProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a file store data profile.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name, for example
        /// `organizations/12345/locations/us/fileStoreDataProfiles/53234423`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FileStoreDataProfile> GetFileStoreDataProfileAsync(string name, st::CancellationToken cancellationToken) =>
            GetFileStoreDataProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a file store data profile.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name, for example
        /// `organizations/12345/locations/us/fileStoreDataProfiles/53234423`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FileStoreDataProfile GetFileStoreDataProfile(ProjectDataProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFileStoreDataProfile(new GetFileStoreDataProfileRequest
            {
                ProjectDataProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a file store data profile.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name, for example
        /// `organizations/12345/locations/us/fileStoreDataProfiles/53234423`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FileStoreDataProfile> GetFileStoreDataProfileAsync(ProjectDataProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFileStoreDataProfileAsync(new GetFileStoreDataProfileRequest
            {
                ProjectDataProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a file store data profile.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name, for example
        /// `organizations/12345/locations/us/fileStoreDataProfiles/53234423`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FileStoreDataProfile> GetFileStoreDataProfileAsync(ProjectDataProfileName name, st::CancellationToken cancellationToken) =>
            GetFileStoreDataProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a FileStoreDataProfile. Will not prevent the profile from being
        /// regenerated if the resource is still included in a discovery configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteFileStoreDataProfile(DeleteFileStoreDataProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a FileStoreDataProfile. Will not prevent the profile from being
        /// regenerated if the resource is still included in a discovery configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFileStoreDataProfileAsync(DeleteFileStoreDataProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a FileStoreDataProfile. Will not prevent the profile from being
        /// regenerated if the resource is still included in a discovery configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFileStoreDataProfileAsync(DeleteFileStoreDataProfileRequest request, st::CancellationToken cancellationToken) =>
            DeleteFileStoreDataProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a FileStoreDataProfile. Will not prevent the profile from being
        /// regenerated if the resource is still included in a discovery configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the file store data profile.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteFileStoreDataProfile(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFileStoreDataProfile(new DeleteFileStoreDataProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a FileStoreDataProfile. Will not prevent the profile from being
        /// regenerated if the resource is still included in a discovery configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the file store data profile.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFileStoreDataProfileAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFileStoreDataProfileAsync(new DeleteFileStoreDataProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a FileStoreDataProfile. Will not prevent the profile from being
        /// regenerated if the resource is still included in a discovery configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the file store data profile.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFileStoreDataProfileAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteFileStoreDataProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a FileStoreDataProfile. Will not prevent the profile from being
        /// regenerated if the resource is still included in a discovery configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the file store data profile.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteFileStoreDataProfile(FileStoreDataProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFileStoreDataProfile(new DeleteFileStoreDataProfileRequest
            {
                FileStoreDataProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a FileStoreDataProfile. Will not prevent the profile from being
        /// regenerated if the resource is still included in a discovery configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the file store data profile.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFileStoreDataProfileAsync(FileStoreDataProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFileStoreDataProfileAsync(new DeleteFileStoreDataProfileRequest
            {
                FileStoreDataProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a FileStoreDataProfile. Will not prevent the profile from being
        /// regenerated if the resource is still included in a discovery configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the file store data profile.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteFileStoreDataProfileAsync(FileStoreDataProfileName name, st::CancellationToken cancellationToken) =>
            DeleteFileStoreDataProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a table data profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TableDataProfile GetTableDataProfile(GetTableDataProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a table data profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TableDataProfile> GetTableDataProfileAsync(GetTableDataProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a table data profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TableDataProfile> GetTableDataProfileAsync(GetTableDataProfileRequest request, st::CancellationToken cancellationToken) =>
            GetTableDataProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a table data profile.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name, for example
        /// `organizations/12345/locations/us/tableDataProfiles/53234423`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TableDataProfile GetTableDataProfile(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTableDataProfile(new GetTableDataProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a table data profile.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name, for example
        /// `organizations/12345/locations/us/tableDataProfiles/53234423`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TableDataProfile> GetTableDataProfileAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTableDataProfileAsync(new GetTableDataProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a table data profile.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name, for example
        /// `organizations/12345/locations/us/tableDataProfiles/53234423`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TableDataProfile> GetTableDataProfileAsync(string name, st::CancellationToken cancellationToken) =>
            GetTableDataProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a table data profile.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name, for example
        /// `organizations/12345/locations/us/tableDataProfiles/53234423`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TableDataProfile GetTableDataProfile(TableDataProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTableDataProfile(new GetTableDataProfileRequest
            {
                TableDataProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a table data profile.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name, for example
        /// `organizations/12345/locations/us/tableDataProfiles/53234423`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TableDataProfile> GetTableDataProfileAsync(TableDataProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTableDataProfileAsync(new GetTableDataProfileRequest
            {
                TableDataProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a table data profile.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name, for example
        /// `organizations/12345/locations/us/tableDataProfiles/53234423`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TableDataProfile> GetTableDataProfileAsync(TableDataProfileName name, st::CancellationToken cancellationToken) =>
            GetTableDataProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a column data profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ColumnDataProfile GetColumnDataProfile(GetColumnDataProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a column data profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ColumnDataProfile> GetColumnDataProfileAsync(GetColumnDataProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a column data profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ColumnDataProfile> GetColumnDataProfileAsync(GetColumnDataProfileRequest request, st::CancellationToken cancellationToken) =>
            GetColumnDataProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a column data profile.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name, for example
        /// `organizations/12345/locations/us/columnDataProfiles/53234423`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ColumnDataProfile GetColumnDataProfile(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetColumnDataProfile(new GetColumnDataProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a column data profile.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name, for example
        /// `organizations/12345/locations/us/columnDataProfiles/53234423`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ColumnDataProfile> GetColumnDataProfileAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetColumnDataProfileAsync(new GetColumnDataProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a column data profile.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name, for example
        /// `organizations/12345/locations/us/columnDataProfiles/53234423`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ColumnDataProfile> GetColumnDataProfileAsync(string name, st::CancellationToken cancellationToken) =>
            GetColumnDataProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a column data profile.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name, for example
        /// `organizations/12345/locations/us/columnDataProfiles/53234423`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ColumnDataProfile GetColumnDataProfile(ColumnDataProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            GetColumnDataProfile(new GetColumnDataProfileRequest
            {
                ColumnDataProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a column data profile.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name, for example
        /// `organizations/12345/locations/us/columnDataProfiles/53234423`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ColumnDataProfile> GetColumnDataProfileAsync(ColumnDataProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            GetColumnDataProfileAsync(new GetColumnDataProfileRequest
            {
                ColumnDataProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a column data profile.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name, for example
        /// `organizations/12345/locations/us/columnDataProfiles/53234423`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ColumnDataProfile> GetColumnDataProfileAsync(ColumnDataProfileName name, st::CancellationToken cancellationToken) =>
            GetColumnDataProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a TableDataProfile. Will not prevent the profile from being
        /// regenerated if the table is still included in a discovery configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTableDataProfile(DeleteTableDataProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a TableDataProfile. Will not prevent the profile from being
        /// regenerated if the table is still included in a discovery configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTableDataProfileAsync(DeleteTableDataProfileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a TableDataProfile. Will not prevent the profile from being
        /// regenerated if the table is still included in a discovery configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTableDataProfileAsync(DeleteTableDataProfileRequest request, st::CancellationToken cancellationToken) =>
            DeleteTableDataProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a TableDataProfile. Will not prevent the profile from being
        /// regenerated if the table is still included in a discovery configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the table data profile.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTableDataProfile(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTableDataProfile(new DeleteTableDataProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a TableDataProfile. Will not prevent the profile from being
        /// regenerated if the table is still included in a discovery configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the table data profile.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTableDataProfileAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTableDataProfileAsync(new DeleteTableDataProfileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a TableDataProfile. Will not prevent the profile from being
        /// regenerated if the table is still included in a discovery configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the table data profile.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTableDataProfileAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteTableDataProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a TableDataProfile. Will not prevent the profile from being
        /// regenerated if the table is still included in a discovery configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the table data profile.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTableDataProfile(TableDataProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTableDataProfile(new DeleteTableDataProfileRequest
            {
                TableDataProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a TableDataProfile. Will not prevent the profile from being
        /// regenerated if the table is still included in a discovery configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the table data profile.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTableDataProfileAsync(TableDataProfileName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTableDataProfileAsync(new DeleteTableDataProfileRequest
            {
                TableDataProfileName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a TableDataProfile. Will not prevent the profile from being
        /// regenerated if the table is still included in a discovery configuration.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the table data profile.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTableDataProfileAsync(TableDataProfileName name, st::CancellationToken cancellationToken) =>
            DeleteTableDataProfileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Inspect hybrid content and store findings to a job.
        /// To review the findings, inspect the job. Inspection will occur
        /// asynchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual HybridInspectResponse HybridInspectDlpJob(HybridInspectDlpJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Inspect hybrid content and store findings to a job.
        /// To review the findings, inspect the job. Inspection will occur
        /// asynchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HybridInspectResponse> HybridInspectDlpJobAsync(HybridInspectDlpJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Inspect hybrid content and store findings to a job.
        /// To review the findings, inspect the job. Inspection will occur
        /// asynchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HybridInspectResponse> HybridInspectDlpJobAsync(HybridInspectDlpJobRequest request, st::CancellationToken cancellationToken) =>
            HybridInspectDlpJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Inspect hybrid content and store findings to a job.
        /// To review the findings, inspect the job. Inspection will occur
        /// asynchronously.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the job to execute a hybrid inspect on, for
        /// example `projects/dlp-test-project/dlpJob/53234423`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual HybridInspectResponse HybridInspectDlpJob(string name, gaxgrpc::CallSettings callSettings = null) =>
            HybridInspectDlpJob(new HybridInspectDlpJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Inspect hybrid content and store findings to a job.
        /// To review the findings, inspect the job. Inspection will occur
        /// asynchronously.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the job to execute a hybrid inspect on, for
        /// example `projects/dlp-test-project/dlpJob/53234423`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HybridInspectResponse> HybridInspectDlpJobAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            HybridInspectDlpJobAsync(new HybridInspectDlpJobRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Inspect hybrid content and store findings to a job.
        /// To review the findings, inspect the job. Inspection will occur
        /// asynchronously.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the job to execute a hybrid inspect on, for
        /// example `projects/dlp-test-project/dlpJob/53234423`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HybridInspectResponse> HybridInspectDlpJobAsync(string name, st::CancellationToken cancellationToken) =>
            HybridInspectDlpJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Inspect hybrid content and store findings to a job.
        /// To review the findings, inspect the job. Inspection will occur
        /// asynchronously.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the job to execute a hybrid inspect on, for
        /// example `projects/dlp-test-project/dlpJob/53234423`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual HybridInspectResponse HybridInspectDlpJob(DlpJobName name, gaxgrpc::CallSettings callSettings = null) =>
            HybridInspectDlpJob(new HybridInspectDlpJobRequest
            {
                DlpJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Inspect hybrid content and store findings to a job.
        /// To review the findings, inspect the job. Inspection will occur
        /// asynchronously.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the job to execute a hybrid inspect on, for
        /// example `projects/dlp-test-project/dlpJob/53234423`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HybridInspectResponse> HybridInspectDlpJobAsync(DlpJobName name, gaxgrpc::CallSettings callSettings = null) =>
            HybridInspectDlpJobAsync(new HybridInspectDlpJobRequest
            {
                DlpJobName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Inspect hybrid content and store findings to a job.
        /// To review the findings, inspect the job. Inspection will occur
        /// asynchronously.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the job to execute a hybrid inspect on, for
        /// example `projects/dlp-test-project/dlpJob/53234423`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<HybridInspectResponse> HybridInspectDlpJobAsync(DlpJobName name, st::CancellationToken cancellationToken) =>
            HybridInspectDlpJobAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Finish a running hybrid DlpJob. Triggers the finalization steps and running
        /// of any enabled actions that have not yet run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void FinishDlpJob(FinishDlpJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Finish a running hybrid DlpJob. Triggers the finalization steps and running
        /// of any enabled actions that have not yet run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task FinishDlpJobAsync(FinishDlpJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Finish a running hybrid DlpJob. Triggers the finalization steps and running
        /// of any enabled actions that have not yet run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task FinishDlpJobAsync(FinishDlpJobRequest request, st::CancellationToken cancellationToken) =>
            FinishDlpJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a Connection to an external data source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Connection CreateConnection(CreateConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a Connection to an external data source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> CreateConnectionAsync(CreateConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a Connection to an external data source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> CreateConnectionAsync(CreateConnectionRequest request, st::CancellationToken cancellationToken) =>
            CreateConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a Connection to an external data source.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization):
        /// 
        /// + Projects scope:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Organizations scope:
        /// `organizations/{org_id}/locations/{location_id}`
        /// </param>
        /// <param name="connection">
        /// Required. The connection resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Connection CreateConnection(string parent, Connection connection, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnection(new CreateConnectionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Connection = gax::GaxPreconditions.CheckNotNull(connection, nameof(connection)),
            }, callSettings);

        /// <summary>
        /// Create a Connection to an external data source.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization):
        /// 
        /// + Projects scope:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Organizations scope:
        /// `organizations/{org_id}/locations/{location_id}`
        /// </param>
        /// <param name="connection">
        /// Required. The connection resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> CreateConnectionAsync(string parent, Connection connection, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnectionAsync(new CreateConnectionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Connection = gax::GaxPreconditions.CheckNotNull(connection, nameof(connection)),
            }, callSettings);

        /// <summary>
        /// Create a Connection to an external data source.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization):
        /// 
        /// + Projects scope:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Organizations scope:
        /// `organizations/{org_id}/locations/{location_id}`
        /// </param>
        /// <param name="connection">
        /// Required. The connection resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> CreateConnectionAsync(string parent, Connection connection, st::CancellationToken cancellationToken) =>
            CreateConnectionAsync(parent, connection, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a Connection to an external data source.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization):
        /// 
        /// + Projects scope:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Organizations scope:
        /// `organizations/{org_id}/locations/{location_id}`
        /// </param>
        /// <param name="connection">
        /// Required. The connection resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Connection CreateConnection(gagr::LocationName parent, Connection connection, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnection(new CreateConnectionRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Connection = gax::GaxPreconditions.CheckNotNull(connection, nameof(connection)),
            }, callSettings);

        /// <summary>
        /// Create a Connection to an external data source.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization):
        /// 
        /// + Projects scope:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Organizations scope:
        /// `organizations/{org_id}/locations/{location_id}`
        /// </param>
        /// <param name="connection">
        /// Required. The connection resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> CreateConnectionAsync(gagr::LocationName parent, Connection connection, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnectionAsync(new CreateConnectionRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Connection = gax::GaxPreconditions.CheckNotNull(connection, nameof(connection)),
            }, callSettings);

        /// <summary>
        /// Create a Connection to an external data source.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization):
        /// 
        /// + Projects scope:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Organizations scope:
        /// `organizations/{org_id}/locations/{location_id}`
        /// </param>
        /// <param name="connection">
        /// Required. The connection resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> CreateConnectionAsync(gagr::LocationName parent, Connection connection, st::CancellationToken cancellationToken) =>
            CreateConnectionAsync(parent, connection, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a Connection to an external data source.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization):
        /// 
        /// + Projects scope:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Organizations scope:
        /// `organizations/{org_id}/locations/{location_id}`
        /// </param>
        /// <param name="connection">
        /// Required. The connection resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Connection CreateConnection(OrganizationLocationName parent, Connection connection, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnection(new CreateConnectionRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Connection = gax::GaxPreconditions.CheckNotNull(connection, nameof(connection)),
            }, callSettings);

        /// <summary>
        /// Create a Connection to an external data source.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization):
        /// 
        /// + Projects scope:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Organizations scope:
        /// `organizations/{org_id}/locations/{location_id}`
        /// </param>
        /// <param name="connection">
        /// Required. The connection resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> CreateConnectionAsync(OrganizationLocationName parent, Connection connection, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnectionAsync(new CreateConnectionRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Connection = gax::GaxPreconditions.CheckNotNull(connection, nameof(connection)),
            }, callSettings);

        /// <summary>
        /// Create a Connection to an external data source.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent resource name.
        /// 
        /// The format of this value varies depending on the scope of the request
        /// (project or organization):
        /// 
        /// + Projects scope:
        /// `projects/{project_id}/locations/{location_id}`
        /// + Organizations scope:
        /// `organizations/{org_id}/locations/{location_id}`
        /// </param>
        /// <param name="connection">
        /// Required. The connection resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> CreateConnectionAsync(OrganizationLocationName parent, Connection connection, st::CancellationToken cancellationToken) =>
            CreateConnectionAsync(parent, connection, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a Connection by name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Connection GetConnection(GetConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a Connection by name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> GetConnectionAsync(GetConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a Connection by name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> GetConnectionAsync(GetConnectionRequest request, st::CancellationToken cancellationToken) =>
            GetConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a Connection by name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name in the format:
        /// `projects/{project}/locations/{location}/connections/{connection}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Connection GetConnection(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnection(new GetConnectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a Connection by name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name in the format:
        /// `projects/{project}/locations/{location}/connections/{connection}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> GetConnectionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectionAsync(new GetConnectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a Connection by name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name in the format:
        /// `projects/{project}/locations/{location}/connections/{connection}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> GetConnectionAsync(string name, st::CancellationToken cancellationToken) =>
            GetConnectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a Connection by name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name in the format:
        /// `projects/{project}/locations/{location}/connections/{connection}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Connection GetConnection(ConnectionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnection(new GetConnectionRequest
            {
                ConnectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a Connection by name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name in the format:
        /// `projects/{project}/locations/{location}/connections/{connection}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> GetConnectionAsync(ConnectionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectionAsync(new GetConnectionRequest
            {
                ConnectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a Connection by name.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name in the format:
        /// `projects/{project}/locations/{location}/connections/{connection}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> GetConnectionAsync(ConnectionName name, st::CancellationToken cancellationToken) =>
            GetConnectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Connections in a parent. Use SearchConnections to see all connections
        /// within an organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Connection"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConnectionsResponse, Connection> ListConnections(ListConnectionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Connections in a parent. Use SearchConnections to see all connections
        /// within an organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Connection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConnectionsResponse, Connection> ListConnectionsAsync(ListConnectionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Connections in a parent. Use SearchConnections to see all connections
        /// within an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the organization or project, for
        /// example, `organizations/433245324/locations/europe` or
        /// `projects/project-id/locations/asia`.
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
        /// <returns>A pageable sequence of <see cref="Connection"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConnectionsResponse, Connection> ListConnections(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectionsRequest request = new ListConnectionsRequest
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
            return ListConnections(request, callSettings);
        }

        /// <summary>
        /// Lists Connections in a parent. Use SearchConnections to see all connections
        /// within an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the organization or project, for
        /// example, `organizations/433245324/locations/europe` or
        /// `projects/project-id/locations/asia`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Connection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConnectionsResponse, Connection> ListConnectionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectionsRequest request = new ListConnectionsRequest
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
            return ListConnectionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Connections in a parent. Use SearchConnections to see all connections
        /// within an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the organization or project, for
        /// example, `organizations/433245324/locations/europe` or
        /// `projects/project-id/locations/asia`.
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
        /// <returns>A pageable sequence of <see cref="Connection"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConnectionsResponse, Connection> ListConnections(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectionsRequest request = new ListConnectionsRequest
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
            return ListConnections(request, callSettings);
        }

        /// <summary>
        /// Lists Connections in a parent. Use SearchConnections to see all connections
        /// within an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the organization or project, for
        /// example, `organizations/433245324/locations/europe` or
        /// `projects/project-id/locations/asia`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Connection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConnectionsResponse, Connection> ListConnectionsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectionsRequest request = new ListConnectionsRequest
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
            return ListConnectionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Connections in a parent. Use SearchConnections to see all connections
        /// within an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the organization or project, for
        /// example, `organizations/433245324/locations/europe` or
        /// `projects/project-id/locations/asia`.
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
        /// <returns>A pageable sequence of <see cref="Connection"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConnectionsResponse, Connection> ListConnections(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectionsRequest request = new ListConnectionsRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListConnections(request, callSettings);
        }

        /// <summary>
        /// Lists Connections in a parent. Use SearchConnections to see all connections
        /// within an organization.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the organization or project, for
        /// example, `organizations/433245324/locations/europe` or
        /// `projects/project-id/locations/asia`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Connection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConnectionsResponse, Connection> ListConnectionsAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectionsRequest request = new ListConnectionsRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListConnectionsAsync(request, callSettings);
        }

        /// <summary>
        /// Searches for Connections in a parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Connection"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchConnectionsResponse, Connection> SearchConnections(SearchConnectionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches for Connections in a parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Connection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchConnectionsResponse, Connection> SearchConnectionsAsync(SearchConnectionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches for Connections in a parent.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the organization or project with a wildcard
        /// location, for example, `organizations/433245324/locations/-` or
        /// `projects/project-id/locations/-`.
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
        /// <returns>A pageable sequence of <see cref="Connection"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchConnectionsResponse, Connection> SearchConnections(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchConnectionsRequest request = new SearchConnectionsRequest
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
            return SearchConnections(request, callSettings);
        }

        /// <summary>
        /// Searches for Connections in a parent.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the organization or project with a wildcard
        /// location, for example, `organizations/433245324/locations/-` or
        /// `projects/project-id/locations/-`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Connection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchConnectionsResponse, Connection> SearchConnectionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchConnectionsRequest request = new SearchConnectionsRequest
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
            return SearchConnectionsAsync(request, callSettings);
        }

        /// <summary>
        /// Searches for Connections in a parent.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the organization or project with a wildcard
        /// location, for example, `organizations/433245324/locations/-` or
        /// `projects/project-id/locations/-`.
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
        /// <returns>A pageable sequence of <see cref="Connection"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchConnectionsResponse, Connection> SearchConnections(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchConnectionsRequest request = new SearchConnectionsRequest
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
            return SearchConnections(request, callSettings);
        }

        /// <summary>
        /// Searches for Connections in a parent.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the organization or project with a wildcard
        /// location, for example, `organizations/433245324/locations/-` or
        /// `projects/project-id/locations/-`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Connection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchConnectionsResponse, Connection> SearchConnectionsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchConnectionsRequest request = new SearchConnectionsRequest
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
            return SearchConnectionsAsync(request, callSettings);
        }

        /// <summary>
        /// Searches for Connections in a parent.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the organization or project with a wildcard
        /// location, for example, `organizations/433245324/locations/-` or
        /// `projects/project-id/locations/-`.
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
        /// <returns>A pageable sequence of <see cref="Connection"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchConnectionsResponse, Connection> SearchConnections(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchConnectionsRequest request = new SearchConnectionsRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchConnections(request, callSettings);
        }

        /// <summary>
        /// Searches for Connections in a parent.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the organization or project with a wildcard
        /// location, for example, `organizations/433245324/locations/-` or
        /// `projects/project-id/locations/-`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Connection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchConnectionsResponse, Connection> SearchConnectionsAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchConnectionsRequest request = new SearchConnectionsRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchConnectionsAsync(request, callSettings);
        }

        /// <summary>
        /// Delete a Connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteConnection(DeleteConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a Connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConnectionAsync(DeleteConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a Connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConnectionAsync(DeleteConnectionRequest request, st::CancellationToken cancellationToken) =>
            DeleteConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a Connection.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the Connection to be deleted, in the format:
        /// `projects/{project}/locations/{location}/connections/{connection}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteConnection(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnection(new DeleteConnectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a Connection.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the Connection to be deleted, in the format:
        /// `projects/{project}/locations/{location}/connections/{connection}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConnectionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnectionAsync(new DeleteConnectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a Connection.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the Connection to be deleted, in the format:
        /// `projects/{project}/locations/{location}/connections/{connection}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConnectionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteConnectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a Connection.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the Connection to be deleted, in the format:
        /// `projects/{project}/locations/{location}/connections/{connection}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteConnection(ConnectionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnection(new DeleteConnectionRequest
            {
                ConnectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a Connection.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the Connection to be deleted, in the format:
        /// `projects/{project}/locations/{location}/connections/{connection}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConnectionAsync(ConnectionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnectionAsync(new DeleteConnectionRequest
            {
                ConnectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a Connection.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name of the Connection to be deleted, in the format:
        /// `projects/{project}/locations/{location}/connections/{connection}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConnectionAsync(ConnectionName name, st::CancellationToken cancellationToken) =>
            DeleteConnectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a Connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Connection UpdateConnection(UpdateConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a Connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> UpdateConnectionAsync(UpdateConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a Connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> UpdateConnectionAsync(UpdateConnectionRequest request, st::CancellationToken cancellationToken) =>
            UpdateConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a Connection.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name in the format:
        /// `projects/{project}/locations/{location}/connections/{connection}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Connection UpdateConnection(string name, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConnection(new UpdateConnectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Update a Connection.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name in the format:
        /// `projects/{project}/locations/{location}/connections/{connection}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> UpdateConnectionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConnectionAsync(new UpdateConnectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Update a Connection.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name in the format:
        /// `projects/{project}/locations/{location}/connections/{connection}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> UpdateConnectionAsync(string name, st::CancellationToken cancellationToken) =>
            UpdateConnectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a Connection.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name in the format:
        /// `projects/{project}/locations/{location}/connections/{connection}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Connection UpdateConnection(ConnectionName name, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConnection(new UpdateConnectionRequest
            {
                ConnectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Update a Connection.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name in the format:
        /// `projects/{project}/locations/{location}/connections/{connection}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> UpdateConnectionAsync(ConnectionName name, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConnectionAsync(new UpdateConnectionRequest
            {
                ConnectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Update a Connection.
        /// </summary>
        /// <param name="name">
        /// Required. Resource name in the format:
        /// `projects/{project}/locations/{location}/connections/{connection}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> UpdateConnectionAsync(ConnectionName name, st::CancellationToken cancellationToken) =>
            UpdateConnectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DlpService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Sensitive Data Protection provides access to a powerful sensitive data
    /// inspection, classification, and de-identification platform that works
    /// on text, images, and Google Cloud storage repositories.
    /// To learn more about concepts and find how-to guides see
    /// https://cloud.google.com/sensitive-data-protection/docs/.
    /// </remarks>
    public sealed partial class DlpServiceClientImpl : DlpServiceClient
    {
        private readonly gaxgrpc::ApiCall<InspectContentRequest, InspectContentResponse> _callInspectContent;

        private readonly gaxgrpc::ApiCall<RedactImageRequest, RedactImageResponse> _callRedactImage;

        private readonly gaxgrpc::ApiCall<DeidentifyContentRequest, DeidentifyContentResponse> _callDeidentifyContent;

        private readonly gaxgrpc::ApiCall<ReidentifyContentRequest, ReidentifyContentResponse> _callReidentifyContent;

        private readonly gaxgrpc::ApiCall<ListInfoTypesRequest, ListInfoTypesResponse> _callListInfoTypes;

        private readonly gaxgrpc::ApiCall<CreateInspectTemplateRequest, InspectTemplate> _callCreateInspectTemplate;

        private readonly gaxgrpc::ApiCall<UpdateInspectTemplateRequest, InspectTemplate> _callUpdateInspectTemplate;

        private readonly gaxgrpc::ApiCall<GetInspectTemplateRequest, InspectTemplate> _callGetInspectTemplate;

        private readonly gaxgrpc::ApiCall<ListInspectTemplatesRequest, ListInspectTemplatesResponse> _callListInspectTemplates;

        private readonly gaxgrpc::ApiCall<DeleteInspectTemplateRequest, wkt::Empty> _callDeleteInspectTemplate;

        private readonly gaxgrpc::ApiCall<CreateDeidentifyTemplateRequest, DeidentifyTemplate> _callCreateDeidentifyTemplate;

        private readonly gaxgrpc::ApiCall<UpdateDeidentifyTemplateRequest, DeidentifyTemplate> _callUpdateDeidentifyTemplate;

        private readonly gaxgrpc::ApiCall<GetDeidentifyTemplateRequest, DeidentifyTemplate> _callGetDeidentifyTemplate;

        private readonly gaxgrpc::ApiCall<ListDeidentifyTemplatesRequest, ListDeidentifyTemplatesResponse> _callListDeidentifyTemplates;

        private readonly gaxgrpc::ApiCall<DeleteDeidentifyTemplateRequest, wkt::Empty> _callDeleteDeidentifyTemplate;

        private readonly gaxgrpc::ApiCall<CreateJobTriggerRequest, JobTrigger> _callCreateJobTrigger;

        private readonly gaxgrpc::ApiCall<UpdateJobTriggerRequest, JobTrigger> _callUpdateJobTrigger;

        private readonly gaxgrpc::ApiCall<HybridInspectJobTriggerRequest, HybridInspectResponse> _callHybridInspectJobTrigger;

        private readonly gaxgrpc::ApiCall<GetJobTriggerRequest, JobTrigger> _callGetJobTrigger;

        private readonly gaxgrpc::ApiCall<ListJobTriggersRequest, ListJobTriggersResponse> _callListJobTriggers;

        private readonly gaxgrpc::ApiCall<DeleteJobTriggerRequest, wkt::Empty> _callDeleteJobTrigger;

        private readonly gaxgrpc::ApiCall<ActivateJobTriggerRequest, DlpJob> _callActivateJobTrigger;

        private readonly gaxgrpc::ApiCall<CreateDiscoveryConfigRequest, DiscoveryConfig> _callCreateDiscoveryConfig;

        private readonly gaxgrpc::ApiCall<UpdateDiscoveryConfigRequest, DiscoveryConfig> _callUpdateDiscoveryConfig;

        private readonly gaxgrpc::ApiCall<GetDiscoveryConfigRequest, DiscoveryConfig> _callGetDiscoveryConfig;

        private readonly gaxgrpc::ApiCall<ListDiscoveryConfigsRequest, ListDiscoveryConfigsResponse> _callListDiscoveryConfigs;

        private readonly gaxgrpc::ApiCall<DeleteDiscoveryConfigRequest, wkt::Empty> _callDeleteDiscoveryConfig;

        private readonly gaxgrpc::ApiCall<CreateDlpJobRequest, DlpJob> _callCreateDlpJob;

        private readonly gaxgrpc::ApiCall<ListDlpJobsRequest, ListDlpJobsResponse> _callListDlpJobs;

        private readonly gaxgrpc::ApiCall<GetDlpJobRequest, DlpJob> _callGetDlpJob;

        private readonly gaxgrpc::ApiCall<DeleteDlpJobRequest, wkt::Empty> _callDeleteDlpJob;

        private readonly gaxgrpc::ApiCall<CancelDlpJobRequest, wkt::Empty> _callCancelDlpJob;

        private readonly gaxgrpc::ApiCall<CreateStoredInfoTypeRequest, StoredInfoType> _callCreateStoredInfoType;

        private readonly gaxgrpc::ApiCall<UpdateStoredInfoTypeRequest, StoredInfoType> _callUpdateStoredInfoType;

        private readonly gaxgrpc::ApiCall<GetStoredInfoTypeRequest, StoredInfoType> _callGetStoredInfoType;

        private readonly gaxgrpc::ApiCall<ListStoredInfoTypesRequest, ListStoredInfoTypesResponse> _callListStoredInfoTypes;

        private readonly gaxgrpc::ApiCall<DeleteStoredInfoTypeRequest, wkt::Empty> _callDeleteStoredInfoType;

        private readonly gaxgrpc::ApiCall<ListProjectDataProfilesRequest, ListProjectDataProfilesResponse> _callListProjectDataProfiles;

        private readonly gaxgrpc::ApiCall<ListTableDataProfilesRequest, ListTableDataProfilesResponse> _callListTableDataProfiles;

        private readonly gaxgrpc::ApiCall<ListColumnDataProfilesRequest, ListColumnDataProfilesResponse> _callListColumnDataProfiles;

        private readonly gaxgrpc::ApiCall<GetProjectDataProfileRequest, ProjectDataProfile> _callGetProjectDataProfile;

        private readonly gaxgrpc::ApiCall<ListFileStoreDataProfilesRequest, ListFileStoreDataProfilesResponse> _callListFileStoreDataProfiles;

        private readonly gaxgrpc::ApiCall<GetFileStoreDataProfileRequest, FileStoreDataProfile> _callGetFileStoreDataProfile;

        private readonly gaxgrpc::ApiCall<DeleteFileStoreDataProfileRequest, wkt::Empty> _callDeleteFileStoreDataProfile;

        private readonly gaxgrpc::ApiCall<GetTableDataProfileRequest, TableDataProfile> _callGetTableDataProfile;

        private readonly gaxgrpc::ApiCall<GetColumnDataProfileRequest, ColumnDataProfile> _callGetColumnDataProfile;

        private readonly gaxgrpc::ApiCall<DeleteTableDataProfileRequest, wkt::Empty> _callDeleteTableDataProfile;

        private readonly gaxgrpc::ApiCall<HybridInspectDlpJobRequest, HybridInspectResponse> _callHybridInspectDlpJob;

        private readonly gaxgrpc::ApiCall<FinishDlpJobRequest, wkt::Empty> _callFinishDlpJob;

        private readonly gaxgrpc::ApiCall<CreateConnectionRequest, Connection> _callCreateConnection;

        private readonly gaxgrpc::ApiCall<GetConnectionRequest, Connection> _callGetConnection;

        private readonly gaxgrpc::ApiCall<ListConnectionsRequest, ListConnectionsResponse> _callListConnections;

        private readonly gaxgrpc::ApiCall<SearchConnectionsRequest, SearchConnectionsResponse> _callSearchConnections;

        private readonly gaxgrpc::ApiCall<DeleteConnectionRequest, wkt::Empty> _callDeleteConnection;

        private readonly gaxgrpc::ApiCall<UpdateConnectionRequest, Connection> _callUpdateConnection;

        /// <summary>
        /// Constructs a client wrapper for the DlpService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DlpServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DlpServiceClientImpl(DlpService.DlpServiceClient grpcClient, DlpServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DlpServiceSettings effectiveSettings = settings ?? DlpServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callInspectContent = clientHelper.BuildApiCall<InspectContentRequest, InspectContentResponse>("InspectContent", grpcClient.InspectContentAsync, grpcClient.InspectContent, effectiveSettings.InspectContentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callInspectContent);
            Modify_InspectContentApiCall(ref _callInspectContent);
            _callRedactImage = clientHelper.BuildApiCall<RedactImageRequest, RedactImageResponse>("RedactImage", grpcClient.RedactImageAsync, grpcClient.RedactImage, effectiveSettings.RedactImageSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callRedactImage);
            Modify_RedactImageApiCall(ref _callRedactImage);
            _callDeidentifyContent = clientHelper.BuildApiCall<DeidentifyContentRequest, DeidentifyContentResponse>("DeidentifyContent", grpcClient.DeidentifyContentAsync, grpcClient.DeidentifyContent, effectiveSettings.DeidentifyContentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callDeidentifyContent);
            Modify_DeidentifyContentApiCall(ref _callDeidentifyContent);
            _callReidentifyContent = clientHelper.BuildApiCall<ReidentifyContentRequest, ReidentifyContentResponse>("ReidentifyContent", grpcClient.ReidentifyContentAsync, grpcClient.ReidentifyContent, effectiveSettings.ReidentifyContentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callReidentifyContent);
            Modify_ReidentifyContentApiCall(ref _callReidentifyContent);
            _callListInfoTypes = clientHelper.BuildApiCall<ListInfoTypesRequest, ListInfoTypesResponse>("ListInfoTypes", grpcClient.ListInfoTypesAsync, grpcClient.ListInfoTypes, effectiveSettings.ListInfoTypesSettings);
            Modify_ApiCall(ref _callListInfoTypes);
            Modify_ListInfoTypesApiCall(ref _callListInfoTypes);
            _callCreateInspectTemplate = clientHelper.BuildApiCall<CreateInspectTemplateRequest, InspectTemplate>("CreateInspectTemplate", grpcClient.CreateInspectTemplateAsync, grpcClient.CreateInspectTemplate, effectiveSettings.CreateInspectTemplateSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateInspectTemplate);
            Modify_CreateInspectTemplateApiCall(ref _callCreateInspectTemplate);
            _callUpdateInspectTemplate = clientHelper.BuildApiCall<UpdateInspectTemplateRequest, InspectTemplate>("UpdateInspectTemplate", grpcClient.UpdateInspectTemplateAsync, grpcClient.UpdateInspectTemplate, effectiveSettings.UpdateInspectTemplateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateInspectTemplate);
            Modify_UpdateInspectTemplateApiCall(ref _callUpdateInspectTemplate);
            _callGetInspectTemplate = clientHelper.BuildApiCall<GetInspectTemplateRequest, InspectTemplate>("GetInspectTemplate", grpcClient.GetInspectTemplateAsync, grpcClient.GetInspectTemplate, effectiveSettings.GetInspectTemplateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetInspectTemplate);
            Modify_GetInspectTemplateApiCall(ref _callGetInspectTemplate);
            _callListInspectTemplates = clientHelper.BuildApiCall<ListInspectTemplatesRequest, ListInspectTemplatesResponse>("ListInspectTemplates", grpcClient.ListInspectTemplatesAsync, grpcClient.ListInspectTemplates, effectiveSettings.ListInspectTemplatesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListInspectTemplates);
            Modify_ListInspectTemplatesApiCall(ref _callListInspectTemplates);
            _callDeleteInspectTemplate = clientHelper.BuildApiCall<DeleteInspectTemplateRequest, wkt::Empty>("DeleteInspectTemplate", grpcClient.DeleteInspectTemplateAsync, grpcClient.DeleteInspectTemplate, effectiveSettings.DeleteInspectTemplateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteInspectTemplate);
            Modify_DeleteInspectTemplateApiCall(ref _callDeleteInspectTemplate);
            _callCreateDeidentifyTemplate = clientHelper.BuildApiCall<CreateDeidentifyTemplateRequest, DeidentifyTemplate>("CreateDeidentifyTemplate", grpcClient.CreateDeidentifyTemplateAsync, grpcClient.CreateDeidentifyTemplate, effectiveSettings.CreateDeidentifyTemplateSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDeidentifyTemplate);
            Modify_CreateDeidentifyTemplateApiCall(ref _callCreateDeidentifyTemplate);
            _callUpdateDeidentifyTemplate = clientHelper.BuildApiCall<UpdateDeidentifyTemplateRequest, DeidentifyTemplate>("UpdateDeidentifyTemplate", grpcClient.UpdateDeidentifyTemplateAsync, grpcClient.UpdateDeidentifyTemplate, effectiveSettings.UpdateDeidentifyTemplateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateDeidentifyTemplate);
            Modify_UpdateDeidentifyTemplateApiCall(ref _callUpdateDeidentifyTemplate);
            _callGetDeidentifyTemplate = clientHelper.BuildApiCall<GetDeidentifyTemplateRequest, DeidentifyTemplate>("GetDeidentifyTemplate", grpcClient.GetDeidentifyTemplateAsync, grpcClient.GetDeidentifyTemplate, effectiveSettings.GetDeidentifyTemplateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDeidentifyTemplate);
            Modify_GetDeidentifyTemplateApiCall(ref _callGetDeidentifyTemplate);
            _callListDeidentifyTemplates = clientHelper.BuildApiCall<ListDeidentifyTemplatesRequest, ListDeidentifyTemplatesResponse>("ListDeidentifyTemplates", grpcClient.ListDeidentifyTemplatesAsync, grpcClient.ListDeidentifyTemplates, effectiveSettings.ListDeidentifyTemplatesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDeidentifyTemplates);
            Modify_ListDeidentifyTemplatesApiCall(ref _callListDeidentifyTemplates);
            _callDeleteDeidentifyTemplate = clientHelper.BuildApiCall<DeleteDeidentifyTemplateRequest, wkt::Empty>("DeleteDeidentifyTemplate", grpcClient.DeleteDeidentifyTemplateAsync, grpcClient.DeleteDeidentifyTemplate, effectiveSettings.DeleteDeidentifyTemplateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDeidentifyTemplate);
            Modify_DeleteDeidentifyTemplateApiCall(ref _callDeleteDeidentifyTemplate);
            _callCreateJobTrigger = clientHelper.BuildApiCall<CreateJobTriggerRequest, JobTrigger>("CreateJobTrigger", grpcClient.CreateJobTriggerAsync, grpcClient.CreateJobTrigger, effectiveSettings.CreateJobTriggerSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateJobTrigger);
            Modify_CreateJobTriggerApiCall(ref _callCreateJobTrigger);
            _callUpdateJobTrigger = clientHelper.BuildApiCall<UpdateJobTriggerRequest, JobTrigger>("UpdateJobTrigger", grpcClient.UpdateJobTriggerAsync, grpcClient.UpdateJobTrigger, effectiveSettings.UpdateJobTriggerSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateJobTrigger);
            Modify_UpdateJobTriggerApiCall(ref _callUpdateJobTrigger);
            _callHybridInspectJobTrigger = clientHelper.BuildApiCall<HybridInspectJobTriggerRequest, HybridInspectResponse>("HybridInspectJobTrigger", grpcClient.HybridInspectJobTriggerAsync, grpcClient.HybridInspectJobTrigger, effectiveSettings.HybridInspectJobTriggerSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callHybridInspectJobTrigger);
            Modify_HybridInspectJobTriggerApiCall(ref _callHybridInspectJobTrigger);
            _callGetJobTrigger = clientHelper.BuildApiCall<GetJobTriggerRequest, JobTrigger>("GetJobTrigger", grpcClient.GetJobTriggerAsync, grpcClient.GetJobTrigger, effectiveSettings.GetJobTriggerSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetJobTrigger);
            Modify_GetJobTriggerApiCall(ref _callGetJobTrigger);
            _callListJobTriggers = clientHelper.BuildApiCall<ListJobTriggersRequest, ListJobTriggersResponse>("ListJobTriggers", grpcClient.ListJobTriggersAsync, grpcClient.ListJobTriggers, effectiveSettings.ListJobTriggersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListJobTriggers);
            Modify_ListJobTriggersApiCall(ref _callListJobTriggers);
            _callDeleteJobTrigger = clientHelper.BuildApiCall<DeleteJobTriggerRequest, wkt::Empty>("DeleteJobTrigger", grpcClient.DeleteJobTriggerAsync, grpcClient.DeleteJobTrigger, effectiveSettings.DeleteJobTriggerSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteJobTrigger);
            Modify_DeleteJobTriggerApiCall(ref _callDeleteJobTrigger);
            _callActivateJobTrigger = clientHelper.BuildApiCall<ActivateJobTriggerRequest, DlpJob>("ActivateJobTrigger", grpcClient.ActivateJobTriggerAsync, grpcClient.ActivateJobTrigger, effectiveSettings.ActivateJobTriggerSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callActivateJobTrigger);
            Modify_ActivateJobTriggerApiCall(ref _callActivateJobTrigger);
            _callCreateDiscoveryConfig = clientHelper.BuildApiCall<CreateDiscoveryConfigRequest, DiscoveryConfig>("CreateDiscoveryConfig", grpcClient.CreateDiscoveryConfigAsync, grpcClient.CreateDiscoveryConfig, effectiveSettings.CreateDiscoveryConfigSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDiscoveryConfig);
            Modify_CreateDiscoveryConfigApiCall(ref _callCreateDiscoveryConfig);
            _callUpdateDiscoveryConfig = clientHelper.BuildApiCall<UpdateDiscoveryConfigRequest, DiscoveryConfig>("UpdateDiscoveryConfig", grpcClient.UpdateDiscoveryConfigAsync, grpcClient.UpdateDiscoveryConfig, effectiveSettings.UpdateDiscoveryConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateDiscoveryConfig);
            Modify_UpdateDiscoveryConfigApiCall(ref _callUpdateDiscoveryConfig);
            _callGetDiscoveryConfig = clientHelper.BuildApiCall<GetDiscoveryConfigRequest, DiscoveryConfig>("GetDiscoveryConfig", grpcClient.GetDiscoveryConfigAsync, grpcClient.GetDiscoveryConfig, effectiveSettings.GetDiscoveryConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDiscoveryConfig);
            Modify_GetDiscoveryConfigApiCall(ref _callGetDiscoveryConfig);
            _callListDiscoveryConfigs = clientHelper.BuildApiCall<ListDiscoveryConfigsRequest, ListDiscoveryConfigsResponse>("ListDiscoveryConfigs", grpcClient.ListDiscoveryConfigsAsync, grpcClient.ListDiscoveryConfigs, effectiveSettings.ListDiscoveryConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDiscoveryConfigs);
            Modify_ListDiscoveryConfigsApiCall(ref _callListDiscoveryConfigs);
            _callDeleteDiscoveryConfig = clientHelper.BuildApiCall<DeleteDiscoveryConfigRequest, wkt::Empty>("DeleteDiscoveryConfig", grpcClient.DeleteDiscoveryConfigAsync, grpcClient.DeleteDiscoveryConfig, effectiveSettings.DeleteDiscoveryConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDiscoveryConfig);
            Modify_DeleteDiscoveryConfigApiCall(ref _callDeleteDiscoveryConfig);
            _callCreateDlpJob = clientHelper.BuildApiCall<CreateDlpJobRequest, DlpJob>("CreateDlpJob", grpcClient.CreateDlpJobAsync, grpcClient.CreateDlpJob, effectiveSettings.CreateDlpJobSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDlpJob);
            Modify_CreateDlpJobApiCall(ref _callCreateDlpJob);
            _callListDlpJobs = clientHelper.BuildApiCall<ListDlpJobsRequest, ListDlpJobsResponse>("ListDlpJobs", grpcClient.ListDlpJobsAsync, grpcClient.ListDlpJobs, effectiveSettings.ListDlpJobsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDlpJobs);
            Modify_ListDlpJobsApiCall(ref _callListDlpJobs);
            _callGetDlpJob = clientHelper.BuildApiCall<GetDlpJobRequest, DlpJob>("GetDlpJob", grpcClient.GetDlpJobAsync, grpcClient.GetDlpJob, effectiveSettings.GetDlpJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDlpJob);
            Modify_GetDlpJobApiCall(ref _callGetDlpJob);
            _callDeleteDlpJob = clientHelper.BuildApiCall<DeleteDlpJobRequest, wkt::Empty>("DeleteDlpJob", grpcClient.DeleteDlpJobAsync, grpcClient.DeleteDlpJob, effectiveSettings.DeleteDlpJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDlpJob);
            Modify_DeleteDlpJobApiCall(ref _callDeleteDlpJob);
            _callCancelDlpJob = clientHelper.BuildApiCall<CancelDlpJobRequest, wkt::Empty>("CancelDlpJob", grpcClient.CancelDlpJobAsync, grpcClient.CancelDlpJob, effectiveSettings.CancelDlpJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCancelDlpJob);
            Modify_CancelDlpJobApiCall(ref _callCancelDlpJob);
            _callCreateStoredInfoType = clientHelper.BuildApiCall<CreateStoredInfoTypeRequest, StoredInfoType>("CreateStoredInfoType", grpcClient.CreateStoredInfoTypeAsync, grpcClient.CreateStoredInfoType, effectiveSettings.CreateStoredInfoTypeSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateStoredInfoType);
            Modify_CreateStoredInfoTypeApiCall(ref _callCreateStoredInfoType);
            _callUpdateStoredInfoType = clientHelper.BuildApiCall<UpdateStoredInfoTypeRequest, StoredInfoType>("UpdateStoredInfoType", grpcClient.UpdateStoredInfoTypeAsync, grpcClient.UpdateStoredInfoType, effectiveSettings.UpdateStoredInfoTypeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateStoredInfoType);
            Modify_UpdateStoredInfoTypeApiCall(ref _callUpdateStoredInfoType);
            _callGetStoredInfoType = clientHelper.BuildApiCall<GetStoredInfoTypeRequest, StoredInfoType>("GetStoredInfoType", grpcClient.GetStoredInfoTypeAsync, grpcClient.GetStoredInfoType, effectiveSettings.GetStoredInfoTypeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetStoredInfoType);
            Modify_GetStoredInfoTypeApiCall(ref _callGetStoredInfoType);
            _callListStoredInfoTypes = clientHelper.BuildApiCall<ListStoredInfoTypesRequest, ListStoredInfoTypesResponse>("ListStoredInfoTypes", grpcClient.ListStoredInfoTypesAsync, grpcClient.ListStoredInfoTypes, effectiveSettings.ListStoredInfoTypesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListStoredInfoTypes);
            Modify_ListStoredInfoTypesApiCall(ref _callListStoredInfoTypes);
            _callDeleteStoredInfoType = clientHelper.BuildApiCall<DeleteStoredInfoTypeRequest, wkt::Empty>("DeleteStoredInfoType", grpcClient.DeleteStoredInfoTypeAsync, grpcClient.DeleteStoredInfoType, effectiveSettings.DeleteStoredInfoTypeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteStoredInfoType);
            Modify_DeleteStoredInfoTypeApiCall(ref _callDeleteStoredInfoType);
            _callListProjectDataProfiles = clientHelper.BuildApiCall<ListProjectDataProfilesRequest, ListProjectDataProfilesResponse>("ListProjectDataProfiles", grpcClient.ListProjectDataProfilesAsync, grpcClient.ListProjectDataProfiles, effectiveSettings.ListProjectDataProfilesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListProjectDataProfiles);
            Modify_ListProjectDataProfilesApiCall(ref _callListProjectDataProfiles);
            _callListTableDataProfiles = clientHelper.BuildApiCall<ListTableDataProfilesRequest, ListTableDataProfilesResponse>("ListTableDataProfiles", grpcClient.ListTableDataProfilesAsync, grpcClient.ListTableDataProfiles, effectiveSettings.ListTableDataProfilesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTableDataProfiles);
            Modify_ListTableDataProfilesApiCall(ref _callListTableDataProfiles);
            _callListColumnDataProfiles = clientHelper.BuildApiCall<ListColumnDataProfilesRequest, ListColumnDataProfilesResponse>("ListColumnDataProfiles", grpcClient.ListColumnDataProfilesAsync, grpcClient.ListColumnDataProfiles, effectiveSettings.ListColumnDataProfilesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListColumnDataProfiles);
            Modify_ListColumnDataProfilesApiCall(ref _callListColumnDataProfiles);
            _callGetProjectDataProfile = clientHelper.BuildApiCall<GetProjectDataProfileRequest, ProjectDataProfile>("GetProjectDataProfile", grpcClient.GetProjectDataProfileAsync, grpcClient.GetProjectDataProfile, effectiveSettings.GetProjectDataProfileSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetProjectDataProfile);
            Modify_GetProjectDataProfileApiCall(ref _callGetProjectDataProfile);
            _callListFileStoreDataProfiles = clientHelper.BuildApiCall<ListFileStoreDataProfilesRequest, ListFileStoreDataProfilesResponse>("ListFileStoreDataProfiles", grpcClient.ListFileStoreDataProfilesAsync, grpcClient.ListFileStoreDataProfiles, effectiveSettings.ListFileStoreDataProfilesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListFileStoreDataProfiles);
            Modify_ListFileStoreDataProfilesApiCall(ref _callListFileStoreDataProfiles);
            _callGetFileStoreDataProfile = clientHelper.BuildApiCall<GetFileStoreDataProfileRequest, FileStoreDataProfile>("GetFileStoreDataProfile", grpcClient.GetFileStoreDataProfileAsync, grpcClient.GetFileStoreDataProfile, effectiveSettings.GetFileStoreDataProfileSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetFileStoreDataProfile);
            Modify_GetFileStoreDataProfileApiCall(ref _callGetFileStoreDataProfile);
            _callDeleteFileStoreDataProfile = clientHelper.BuildApiCall<DeleteFileStoreDataProfileRequest, wkt::Empty>("DeleteFileStoreDataProfile", grpcClient.DeleteFileStoreDataProfileAsync, grpcClient.DeleteFileStoreDataProfile, effectiveSettings.DeleteFileStoreDataProfileSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteFileStoreDataProfile);
            Modify_DeleteFileStoreDataProfileApiCall(ref _callDeleteFileStoreDataProfile);
            _callGetTableDataProfile = clientHelper.BuildApiCall<GetTableDataProfileRequest, TableDataProfile>("GetTableDataProfile", grpcClient.GetTableDataProfileAsync, grpcClient.GetTableDataProfile, effectiveSettings.GetTableDataProfileSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTableDataProfile);
            Modify_GetTableDataProfileApiCall(ref _callGetTableDataProfile);
            _callGetColumnDataProfile = clientHelper.BuildApiCall<GetColumnDataProfileRequest, ColumnDataProfile>("GetColumnDataProfile", grpcClient.GetColumnDataProfileAsync, grpcClient.GetColumnDataProfile, effectiveSettings.GetColumnDataProfileSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetColumnDataProfile);
            Modify_GetColumnDataProfileApiCall(ref _callGetColumnDataProfile);
            _callDeleteTableDataProfile = clientHelper.BuildApiCall<DeleteTableDataProfileRequest, wkt::Empty>("DeleteTableDataProfile", grpcClient.DeleteTableDataProfileAsync, grpcClient.DeleteTableDataProfile, effectiveSettings.DeleteTableDataProfileSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTableDataProfile);
            Modify_DeleteTableDataProfileApiCall(ref _callDeleteTableDataProfile);
            _callHybridInspectDlpJob = clientHelper.BuildApiCall<HybridInspectDlpJobRequest, HybridInspectResponse>("HybridInspectDlpJob", grpcClient.HybridInspectDlpJobAsync, grpcClient.HybridInspectDlpJob, effectiveSettings.HybridInspectDlpJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callHybridInspectDlpJob);
            Modify_HybridInspectDlpJobApiCall(ref _callHybridInspectDlpJob);
            _callFinishDlpJob = clientHelper.BuildApiCall<FinishDlpJobRequest, wkt::Empty>("FinishDlpJob", grpcClient.FinishDlpJobAsync, grpcClient.FinishDlpJob, effectiveSettings.FinishDlpJobSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callFinishDlpJob);
            Modify_FinishDlpJobApiCall(ref _callFinishDlpJob);
            _callCreateConnection = clientHelper.BuildApiCall<CreateConnectionRequest, Connection>("CreateConnection", grpcClient.CreateConnectionAsync, grpcClient.CreateConnection, effectiveSettings.CreateConnectionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateConnection);
            Modify_CreateConnectionApiCall(ref _callCreateConnection);
            _callGetConnection = clientHelper.BuildApiCall<GetConnectionRequest, Connection>("GetConnection", grpcClient.GetConnectionAsync, grpcClient.GetConnection, effectiveSettings.GetConnectionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetConnection);
            Modify_GetConnectionApiCall(ref _callGetConnection);
            _callListConnections = clientHelper.BuildApiCall<ListConnectionsRequest, ListConnectionsResponse>("ListConnections", grpcClient.ListConnectionsAsync, grpcClient.ListConnections, effectiveSettings.ListConnectionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListConnections);
            Modify_ListConnectionsApiCall(ref _callListConnections);
            _callSearchConnections = clientHelper.BuildApiCall<SearchConnectionsRequest, SearchConnectionsResponse>("SearchConnections", grpcClient.SearchConnectionsAsync, grpcClient.SearchConnections, effectiveSettings.SearchConnectionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSearchConnections);
            Modify_SearchConnectionsApiCall(ref _callSearchConnections);
            _callDeleteConnection = clientHelper.BuildApiCall<DeleteConnectionRequest, wkt::Empty>("DeleteConnection", grpcClient.DeleteConnectionAsync, grpcClient.DeleteConnection, effectiveSettings.DeleteConnectionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteConnection);
            Modify_DeleteConnectionApiCall(ref _callDeleteConnection);
            _callUpdateConnection = clientHelper.BuildApiCall<UpdateConnectionRequest, Connection>("UpdateConnection", grpcClient.UpdateConnectionAsync, grpcClient.UpdateConnection, effectiveSettings.UpdateConnectionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateConnection);
            Modify_UpdateConnectionApiCall(ref _callUpdateConnection);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_InspectContentApiCall(ref gaxgrpc::ApiCall<InspectContentRequest, InspectContentResponse> call);

        partial void Modify_RedactImageApiCall(ref gaxgrpc::ApiCall<RedactImageRequest, RedactImageResponse> call);

        partial void Modify_DeidentifyContentApiCall(ref gaxgrpc::ApiCall<DeidentifyContentRequest, DeidentifyContentResponse> call);

        partial void Modify_ReidentifyContentApiCall(ref gaxgrpc::ApiCall<ReidentifyContentRequest, ReidentifyContentResponse> call);

        partial void Modify_ListInfoTypesApiCall(ref gaxgrpc::ApiCall<ListInfoTypesRequest, ListInfoTypesResponse> call);

        partial void Modify_CreateInspectTemplateApiCall(ref gaxgrpc::ApiCall<CreateInspectTemplateRequest, InspectTemplate> call);

        partial void Modify_UpdateInspectTemplateApiCall(ref gaxgrpc::ApiCall<UpdateInspectTemplateRequest, InspectTemplate> call);

        partial void Modify_GetInspectTemplateApiCall(ref gaxgrpc::ApiCall<GetInspectTemplateRequest, InspectTemplate> call);

        partial void Modify_ListInspectTemplatesApiCall(ref gaxgrpc::ApiCall<ListInspectTemplatesRequest, ListInspectTemplatesResponse> call);

        partial void Modify_DeleteInspectTemplateApiCall(ref gaxgrpc::ApiCall<DeleteInspectTemplateRequest, wkt::Empty> call);

        partial void Modify_CreateDeidentifyTemplateApiCall(ref gaxgrpc::ApiCall<CreateDeidentifyTemplateRequest, DeidentifyTemplate> call);

        partial void Modify_UpdateDeidentifyTemplateApiCall(ref gaxgrpc::ApiCall<UpdateDeidentifyTemplateRequest, DeidentifyTemplate> call);

        partial void Modify_GetDeidentifyTemplateApiCall(ref gaxgrpc::ApiCall<GetDeidentifyTemplateRequest, DeidentifyTemplate> call);

        partial void Modify_ListDeidentifyTemplatesApiCall(ref gaxgrpc::ApiCall<ListDeidentifyTemplatesRequest, ListDeidentifyTemplatesResponse> call);

        partial void Modify_DeleteDeidentifyTemplateApiCall(ref gaxgrpc::ApiCall<DeleteDeidentifyTemplateRequest, wkt::Empty> call);

        partial void Modify_CreateJobTriggerApiCall(ref gaxgrpc::ApiCall<CreateJobTriggerRequest, JobTrigger> call);

        partial void Modify_UpdateJobTriggerApiCall(ref gaxgrpc::ApiCall<UpdateJobTriggerRequest, JobTrigger> call);

        partial void Modify_HybridInspectJobTriggerApiCall(ref gaxgrpc::ApiCall<HybridInspectJobTriggerRequest, HybridInspectResponse> call);

        partial void Modify_GetJobTriggerApiCall(ref gaxgrpc::ApiCall<GetJobTriggerRequest, JobTrigger> call);

        partial void Modify_ListJobTriggersApiCall(ref gaxgrpc::ApiCall<ListJobTriggersRequest, ListJobTriggersResponse> call);

        partial void Modify_DeleteJobTriggerApiCall(ref gaxgrpc::ApiCall<DeleteJobTriggerRequest, wkt::Empty> call);

        partial void Modify_ActivateJobTriggerApiCall(ref gaxgrpc::ApiCall<ActivateJobTriggerRequest, DlpJob> call);

        partial void Modify_CreateDiscoveryConfigApiCall(ref gaxgrpc::ApiCall<CreateDiscoveryConfigRequest, DiscoveryConfig> call);

        partial void Modify_UpdateDiscoveryConfigApiCall(ref gaxgrpc::ApiCall<UpdateDiscoveryConfigRequest, DiscoveryConfig> call);

        partial void Modify_GetDiscoveryConfigApiCall(ref gaxgrpc::ApiCall<GetDiscoveryConfigRequest, DiscoveryConfig> call);

        partial void Modify_ListDiscoveryConfigsApiCall(ref gaxgrpc::ApiCall<ListDiscoveryConfigsRequest, ListDiscoveryConfigsResponse> call);

        partial void Modify_DeleteDiscoveryConfigApiCall(ref gaxgrpc::ApiCall<DeleteDiscoveryConfigRequest, wkt::Empty> call);

        partial void Modify_CreateDlpJobApiCall(ref gaxgrpc::ApiCall<CreateDlpJobRequest, DlpJob> call);

        partial void Modify_ListDlpJobsApiCall(ref gaxgrpc::ApiCall<ListDlpJobsRequest, ListDlpJobsResponse> call);

        partial void Modify_GetDlpJobApiCall(ref gaxgrpc::ApiCall<GetDlpJobRequest, DlpJob> call);

        partial void Modify_DeleteDlpJobApiCall(ref gaxgrpc::ApiCall<DeleteDlpJobRequest, wkt::Empty> call);

        partial void Modify_CancelDlpJobApiCall(ref gaxgrpc::ApiCall<CancelDlpJobRequest, wkt::Empty> call);

        partial void Modify_CreateStoredInfoTypeApiCall(ref gaxgrpc::ApiCall<CreateStoredInfoTypeRequest, StoredInfoType> call);

        partial void Modify_UpdateStoredInfoTypeApiCall(ref gaxgrpc::ApiCall<UpdateStoredInfoTypeRequest, StoredInfoType> call);

        partial void Modify_GetStoredInfoTypeApiCall(ref gaxgrpc::ApiCall<GetStoredInfoTypeRequest, StoredInfoType> call);

        partial void Modify_ListStoredInfoTypesApiCall(ref gaxgrpc::ApiCall<ListStoredInfoTypesRequest, ListStoredInfoTypesResponse> call);

        partial void Modify_DeleteStoredInfoTypeApiCall(ref gaxgrpc::ApiCall<DeleteStoredInfoTypeRequest, wkt::Empty> call);

        partial void Modify_ListProjectDataProfilesApiCall(ref gaxgrpc::ApiCall<ListProjectDataProfilesRequest, ListProjectDataProfilesResponse> call);

        partial void Modify_ListTableDataProfilesApiCall(ref gaxgrpc::ApiCall<ListTableDataProfilesRequest, ListTableDataProfilesResponse> call);

        partial void Modify_ListColumnDataProfilesApiCall(ref gaxgrpc::ApiCall<ListColumnDataProfilesRequest, ListColumnDataProfilesResponse> call);

        partial void Modify_GetProjectDataProfileApiCall(ref gaxgrpc::ApiCall<GetProjectDataProfileRequest, ProjectDataProfile> call);

        partial void Modify_ListFileStoreDataProfilesApiCall(ref gaxgrpc::ApiCall<ListFileStoreDataProfilesRequest, ListFileStoreDataProfilesResponse> call);

        partial void Modify_GetFileStoreDataProfileApiCall(ref gaxgrpc::ApiCall<GetFileStoreDataProfileRequest, FileStoreDataProfile> call);

        partial void Modify_DeleteFileStoreDataProfileApiCall(ref gaxgrpc::ApiCall<DeleteFileStoreDataProfileRequest, wkt::Empty> call);

        partial void Modify_GetTableDataProfileApiCall(ref gaxgrpc::ApiCall<GetTableDataProfileRequest, TableDataProfile> call);

        partial void Modify_GetColumnDataProfileApiCall(ref gaxgrpc::ApiCall<GetColumnDataProfileRequest, ColumnDataProfile> call);

        partial void Modify_DeleteTableDataProfileApiCall(ref gaxgrpc::ApiCall<DeleteTableDataProfileRequest, wkt::Empty> call);

        partial void Modify_HybridInspectDlpJobApiCall(ref gaxgrpc::ApiCall<HybridInspectDlpJobRequest, HybridInspectResponse> call);

        partial void Modify_FinishDlpJobApiCall(ref gaxgrpc::ApiCall<FinishDlpJobRequest, wkt::Empty> call);

        partial void Modify_CreateConnectionApiCall(ref gaxgrpc::ApiCall<CreateConnectionRequest, Connection> call);

        partial void Modify_GetConnectionApiCall(ref gaxgrpc::ApiCall<GetConnectionRequest, Connection> call);

        partial void Modify_ListConnectionsApiCall(ref gaxgrpc::ApiCall<ListConnectionsRequest, ListConnectionsResponse> call);

        partial void Modify_SearchConnectionsApiCall(ref gaxgrpc::ApiCall<SearchConnectionsRequest, SearchConnectionsResponse> call);

        partial void Modify_DeleteConnectionApiCall(ref gaxgrpc::ApiCall<DeleteConnectionRequest, wkt::Empty> call);

        partial void Modify_UpdateConnectionApiCall(ref gaxgrpc::ApiCall<UpdateConnectionRequest, Connection> call);

        partial void OnConstruction(DlpService.DlpServiceClient grpcClient, DlpServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DlpService client</summary>
        public override DlpService.DlpServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_InspectContentRequest(ref InspectContentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RedactImageRequest(ref RedactImageRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeidentifyContentRequest(ref DeidentifyContentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ReidentifyContentRequest(ref ReidentifyContentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListInfoTypesRequest(ref ListInfoTypesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateInspectTemplateRequest(ref CreateInspectTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateInspectTemplateRequest(ref UpdateInspectTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetInspectTemplateRequest(ref GetInspectTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListInspectTemplatesRequest(ref ListInspectTemplatesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteInspectTemplateRequest(ref DeleteInspectTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateDeidentifyTemplateRequest(ref CreateDeidentifyTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDeidentifyTemplateRequest(ref UpdateDeidentifyTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDeidentifyTemplateRequest(ref GetDeidentifyTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDeidentifyTemplatesRequest(ref ListDeidentifyTemplatesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDeidentifyTemplateRequest(ref DeleteDeidentifyTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateJobTriggerRequest(ref CreateJobTriggerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateJobTriggerRequest(ref UpdateJobTriggerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_HybridInspectJobTriggerRequest(ref HybridInspectJobTriggerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetJobTriggerRequest(ref GetJobTriggerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListJobTriggersRequest(ref ListJobTriggersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteJobTriggerRequest(ref DeleteJobTriggerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ActivateJobTriggerRequest(ref ActivateJobTriggerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateDiscoveryConfigRequest(ref CreateDiscoveryConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDiscoveryConfigRequest(ref UpdateDiscoveryConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDiscoveryConfigRequest(ref GetDiscoveryConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDiscoveryConfigsRequest(ref ListDiscoveryConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDiscoveryConfigRequest(ref DeleteDiscoveryConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateDlpJobRequest(ref CreateDlpJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDlpJobsRequest(ref ListDlpJobsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDlpJobRequest(ref GetDlpJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDlpJobRequest(ref DeleteDlpJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CancelDlpJobRequest(ref CancelDlpJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateStoredInfoTypeRequest(ref CreateStoredInfoTypeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateStoredInfoTypeRequest(ref UpdateStoredInfoTypeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetStoredInfoTypeRequest(ref GetStoredInfoTypeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListStoredInfoTypesRequest(ref ListStoredInfoTypesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteStoredInfoTypeRequest(ref DeleteStoredInfoTypeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListProjectDataProfilesRequest(ref ListProjectDataProfilesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTableDataProfilesRequest(ref ListTableDataProfilesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListColumnDataProfilesRequest(ref ListColumnDataProfilesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetProjectDataProfileRequest(ref GetProjectDataProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListFileStoreDataProfilesRequest(ref ListFileStoreDataProfilesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetFileStoreDataProfileRequest(ref GetFileStoreDataProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteFileStoreDataProfileRequest(ref DeleteFileStoreDataProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTableDataProfileRequest(ref GetTableDataProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetColumnDataProfileRequest(ref GetColumnDataProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTableDataProfileRequest(ref DeleteTableDataProfileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_HybridInspectDlpJobRequest(ref HybridInspectDlpJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FinishDlpJobRequest(ref FinishDlpJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateConnectionRequest(ref CreateConnectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetConnectionRequest(ref GetConnectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListConnectionsRequest(ref ListConnectionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchConnectionsRequest(ref SearchConnectionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteConnectionRequest(ref DeleteConnectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateConnectionRequest(ref UpdateConnectionRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Finds potentially sensitive info in content.
        /// This method has limits on input size, processing time, and output size.
        /// 
        /// When no InfoTypes or CustomInfoTypes are specified in this request, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        /// 
        /// For how to guides, see
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-images
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-text,
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override InspectContentResponse InspectContent(InspectContentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InspectContentRequest(ref request, ref callSettings);
            return _callInspectContent.Sync(request, callSettings);
        }

        /// <summary>
        /// Finds potentially sensitive info in content.
        /// This method has limits on input size, processing time, and output size.
        /// 
        /// When no InfoTypes or CustomInfoTypes are specified in this request, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        /// 
        /// For how to guides, see
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-images
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-text,
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<InspectContentResponse> InspectContentAsync(InspectContentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_InspectContentRequest(ref request, ref callSettings);
            return _callInspectContent.Async(request, callSettings);
        }

        /// <summary>
        /// Redacts potentially sensitive info from an image.
        /// This method has limits on input size, processing time, and output size.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/redacting-sensitive-data-images
        /// to learn more.
        /// 
        /// When no InfoTypes or CustomInfoTypes are specified in this request, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RedactImageResponse RedactImage(RedactImageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RedactImageRequest(ref request, ref callSettings);
            return _callRedactImage.Sync(request, callSettings);
        }

        /// <summary>
        /// Redacts potentially sensitive info from an image.
        /// This method has limits on input size, processing time, and output size.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/redacting-sensitive-data-images
        /// to learn more.
        /// 
        /// When no InfoTypes or CustomInfoTypes are specified in this request, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RedactImageResponse> RedactImageAsync(RedactImageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RedactImageRequest(ref request, ref callSettings);
            return _callRedactImage.Async(request, callSettings);
        }

        /// <summary>
        /// De-identifies potentially sensitive info from a ContentItem.
        /// This method has limits on input size and output size.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/deidentify-sensitive-data
        /// to learn more.
        /// 
        /// When no InfoTypes or CustomInfoTypes are specified in this request, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DeidentifyContentResponse DeidentifyContent(DeidentifyContentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeidentifyContentRequest(ref request, ref callSettings);
            return _callDeidentifyContent.Sync(request, callSettings);
        }

        /// <summary>
        /// De-identifies potentially sensitive info from a ContentItem.
        /// This method has limits on input size and output size.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/deidentify-sensitive-data
        /// to learn more.
        /// 
        /// When no InfoTypes or CustomInfoTypes are specified in this request, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DeidentifyContentResponse> DeidentifyContentAsync(DeidentifyContentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeidentifyContentRequest(ref request, ref callSettings);
            return _callDeidentifyContent.Async(request, callSettings);
        }

        /// <summary>
        /// Re-identifies content that has been de-identified.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/pseudonymization#re-identification_in_free_text_code_example
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReidentifyContentResponse ReidentifyContent(ReidentifyContentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReidentifyContentRequest(ref request, ref callSettings);
            return _callReidentifyContent.Sync(request, callSettings);
        }

        /// <summary>
        /// Re-identifies content that has been de-identified.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/pseudonymization#re-identification_in_free_text_code_example
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReidentifyContentResponse> ReidentifyContentAsync(ReidentifyContentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ReidentifyContentRequest(ref request, ref callSettings);
            return _callReidentifyContent.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a list of the sensitive information types that DLP API
        /// supports. See
        /// https://cloud.google.com/sensitive-data-protection/docs/infotypes-reference
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListInfoTypesResponse ListInfoTypes(ListInfoTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInfoTypesRequest(ref request, ref callSettings);
            return _callListInfoTypes.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of the sensitive information types that DLP API
        /// supports. See
        /// https://cloud.google.com/sensitive-data-protection/docs/infotypes-reference
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListInfoTypesResponse> ListInfoTypesAsync(ListInfoTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInfoTypesRequest(ref request, ref callSettings);
            return _callListInfoTypes.Async(request, callSettings);
        }

        /// <summary>
        /// Creates an InspectTemplate for reusing frequently used configuration
        /// for inspecting content, images, and storage.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override InspectTemplate CreateInspectTemplate(CreateInspectTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInspectTemplateRequest(ref request, ref callSettings);
            return _callCreateInspectTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an InspectTemplate for reusing frequently used configuration
        /// for inspecting content, images, and storage.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<InspectTemplate> CreateInspectTemplateAsync(CreateInspectTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateInspectTemplateRequest(ref request, ref callSettings);
            return _callCreateInspectTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the InspectTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override InspectTemplate UpdateInspectTemplate(UpdateInspectTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInspectTemplateRequest(ref request, ref callSettings);
            return _callUpdateInspectTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the InspectTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<InspectTemplate> UpdateInspectTemplateAsync(UpdateInspectTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateInspectTemplateRequest(ref request, ref callSettings);
            return _callUpdateInspectTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Gets an InspectTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override InspectTemplate GetInspectTemplate(GetInspectTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInspectTemplateRequest(ref request, ref callSettings);
            return _callGetInspectTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an InspectTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<InspectTemplate> GetInspectTemplateAsync(GetInspectTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetInspectTemplateRequest(ref request, ref callSettings);
            return _callGetInspectTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Lists InspectTemplates.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="InspectTemplate"/> resources.</returns>
        public override gax::PagedEnumerable<ListInspectTemplatesResponse, InspectTemplate> ListInspectTemplates(ListInspectTemplatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInspectTemplatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListInspectTemplatesRequest, ListInspectTemplatesResponse, InspectTemplate>(_callListInspectTemplates, request, callSettings);
        }

        /// <summary>
        /// Lists InspectTemplates.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="InspectTemplate"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListInspectTemplatesResponse, InspectTemplate> ListInspectTemplatesAsync(ListInspectTemplatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListInspectTemplatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListInspectTemplatesRequest, ListInspectTemplatesResponse, InspectTemplate>(_callListInspectTemplates, request, callSettings);
        }

        /// <summary>
        /// Deletes an InspectTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteInspectTemplate(DeleteInspectTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInspectTemplateRequest(ref request, ref callSettings);
            _callDeleteInspectTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an InspectTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteInspectTemplateAsync(DeleteInspectTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteInspectTemplateRequest(ref request, ref callSettings);
            return _callDeleteInspectTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a DeidentifyTemplate for reusing frequently used configuration
        /// for de-identifying content, images, and storage.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DeidentifyTemplate CreateDeidentifyTemplate(CreateDeidentifyTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDeidentifyTemplateRequest(ref request, ref callSettings);
            return _callCreateDeidentifyTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a DeidentifyTemplate for reusing frequently used configuration
        /// for de-identifying content, images, and storage.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DeidentifyTemplate> CreateDeidentifyTemplateAsync(CreateDeidentifyTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDeidentifyTemplateRequest(ref request, ref callSettings);
            return _callCreateDeidentifyTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the DeidentifyTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DeidentifyTemplate UpdateDeidentifyTemplate(UpdateDeidentifyTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDeidentifyTemplateRequest(ref request, ref callSettings);
            return _callUpdateDeidentifyTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the DeidentifyTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DeidentifyTemplate> UpdateDeidentifyTemplateAsync(UpdateDeidentifyTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDeidentifyTemplateRequest(ref request, ref callSettings);
            return _callUpdateDeidentifyTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a DeidentifyTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DeidentifyTemplate GetDeidentifyTemplate(GetDeidentifyTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDeidentifyTemplateRequest(ref request, ref callSettings);
            return _callGetDeidentifyTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a DeidentifyTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DeidentifyTemplate> GetDeidentifyTemplateAsync(GetDeidentifyTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDeidentifyTemplateRequest(ref request, ref callSettings);
            return _callGetDeidentifyTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Lists DeidentifyTemplates.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DeidentifyTemplate"/> resources.</returns>
        public override gax::PagedEnumerable<ListDeidentifyTemplatesResponse, DeidentifyTemplate> ListDeidentifyTemplates(ListDeidentifyTemplatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDeidentifyTemplatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDeidentifyTemplatesRequest, ListDeidentifyTemplatesResponse, DeidentifyTemplate>(_callListDeidentifyTemplates, request, callSettings);
        }

        /// <summary>
        /// Lists DeidentifyTemplates.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DeidentifyTemplate"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDeidentifyTemplatesResponse, DeidentifyTemplate> ListDeidentifyTemplatesAsync(ListDeidentifyTemplatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDeidentifyTemplatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDeidentifyTemplatesRequest, ListDeidentifyTemplatesResponse, DeidentifyTemplate>(_callListDeidentifyTemplates, request, callSettings);
        }

        /// <summary>
        /// Deletes a DeidentifyTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteDeidentifyTemplate(DeleteDeidentifyTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDeidentifyTemplateRequest(ref request, ref callSettings);
            _callDeleteDeidentifyTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a DeidentifyTemplate.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-templates-deid
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteDeidentifyTemplateAsync(DeleteDeidentifyTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDeidentifyTemplateRequest(ref request, ref callSettings);
            return _callDeleteDeidentifyTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a job trigger to run DLP actions such as scanning storage for
        /// sensitive information on a set schedule.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override JobTrigger CreateJobTrigger(CreateJobTriggerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateJobTriggerRequest(ref request, ref callSettings);
            return _callCreateJobTrigger.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a job trigger to run DLP actions such as scanning storage for
        /// sensitive information on a set schedule.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<JobTrigger> CreateJobTriggerAsync(CreateJobTriggerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateJobTriggerRequest(ref request, ref callSettings);
            return _callCreateJobTrigger.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a job trigger.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override JobTrigger UpdateJobTrigger(UpdateJobTriggerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateJobTriggerRequest(ref request, ref callSettings);
            return _callUpdateJobTrigger.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a job trigger.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<JobTrigger> UpdateJobTriggerAsync(UpdateJobTriggerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateJobTriggerRequest(ref request, ref callSettings);
            return _callUpdateJobTrigger.Async(request, callSettings);
        }

        /// <summary>
        /// Inspect hybrid content and store findings to a trigger. The inspection
        /// will be processed asynchronously. To review the findings monitor the
        /// jobs within the trigger.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override HybridInspectResponse HybridInspectJobTrigger(HybridInspectJobTriggerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_HybridInspectJobTriggerRequest(ref request, ref callSettings);
            return _callHybridInspectJobTrigger.Sync(request, callSettings);
        }

        /// <summary>
        /// Inspect hybrid content and store findings to a trigger. The inspection
        /// will be processed asynchronously. To review the findings monitor the
        /// jobs within the trigger.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<HybridInspectResponse> HybridInspectJobTriggerAsync(HybridInspectJobTriggerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_HybridInspectJobTriggerRequest(ref request, ref callSettings);
            return _callHybridInspectJobTrigger.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a job trigger.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override JobTrigger GetJobTrigger(GetJobTriggerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetJobTriggerRequest(ref request, ref callSettings);
            return _callGetJobTrigger.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a job trigger.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<JobTrigger> GetJobTriggerAsync(GetJobTriggerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetJobTriggerRequest(ref request, ref callSettings);
            return _callGetJobTrigger.Async(request, callSettings);
        }

        /// <summary>
        /// Lists job triggers.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="JobTrigger"/> resources.</returns>
        public override gax::PagedEnumerable<ListJobTriggersResponse, JobTrigger> ListJobTriggers(ListJobTriggersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListJobTriggersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListJobTriggersRequest, ListJobTriggersResponse, JobTrigger>(_callListJobTriggers, request, callSettings);
        }

        /// <summary>
        /// Lists job triggers.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="JobTrigger"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListJobTriggersResponse, JobTrigger> ListJobTriggersAsync(ListJobTriggersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListJobTriggersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListJobTriggersRequest, ListJobTriggersResponse, JobTrigger>(_callListJobTriggers, request, callSettings);
        }

        /// <summary>
        /// Deletes a job trigger.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteJobTrigger(DeleteJobTriggerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteJobTriggerRequest(ref request, ref callSettings);
            _callDeleteJobTrigger.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a job trigger.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-job-triggers
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteJobTriggerAsync(DeleteJobTriggerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteJobTriggerRequest(ref request, ref callSettings);
            return _callDeleteJobTrigger.Async(request, callSettings);
        }

        /// <summary>
        /// Activate a job trigger. Causes the immediate execute of a trigger
        /// instead of waiting on the trigger event to occur.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DlpJob ActivateJobTrigger(ActivateJobTriggerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ActivateJobTriggerRequest(ref request, ref callSettings);
            return _callActivateJobTrigger.Sync(request, callSettings);
        }

        /// <summary>
        /// Activate a job trigger. Causes the immediate execute of a trigger
        /// instead of waiting on the trigger event to occur.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DlpJob> ActivateJobTriggerAsync(ActivateJobTriggerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ActivateJobTriggerRequest(ref request, ref callSettings);
            return _callActivateJobTrigger.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a config for discovery to scan and profile storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DiscoveryConfig CreateDiscoveryConfig(CreateDiscoveryConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDiscoveryConfigRequest(ref request, ref callSettings);
            return _callCreateDiscoveryConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a config for discovery to scan and profile storage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DiscoveryConfig> CreateDiscoveryConfigAsync(CreateDiscoveryConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDiscoveryConfigRequest(ref request, ref callSettings);
            return _callCreateDiscoveryConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a discovery configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DiscoveryConfig UpdateDiscoveryConfig(UpdateDiscoveryConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDiscoveryConfigRequest(ref request, ref callSettings);
            return _callUpdateDiscoveryConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a discovery configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DiscoveryConfig> UpdateDiscoveryConfigAsync(UpdateDiscoveryConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDiscoveryConfigRequest(ref request, ref callSettings);
            return _callUpdateDiscoveryConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a discovery configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DiscoveryConfig GetDiscoveryConfig(GetDiscoveryConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDiscoveryConfigRequest(ref request, ref callSettings);
            return _callGetDiscoveryConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a discovery configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DiscoveryConfig> GetDiscoveryConfigAsync(GetDiscoveryConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDiscoveryConfigRequest(ref request, ref callSettings);
            return _callGetDiscoveryConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Lists discovery configurations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DiscoveryConfig"/> resources.</returns>
        public override gax::PagedEnumerable<ListDiscoveryConfigsResponse, DiscoveryConfig> ListDiscoveryConfigs(ListDiscoveryConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDiscoveryConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDiscoveryConfigsRequest, ListDiscoveryConfigsResponse, DiscoveryConfig>(_callListDiscoveryConfigs, request, callSettings);
        }

        /// <summary>
        /// Lists discovery configurations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DiscoveryConfig"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDiscoveryConfigsResponse, DiscoveryConfig> ListDiscoveryConfigsAsync(ListDiscoveryConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDiscoveryConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDiscoveryConfigsRequest, ListDiscoveryConfigsResponse, DiscoveryConfig>(_callListDiscoveryConfigs, request, callSettings);
        }

        /// <summary>
        /// Deletes a discovery configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteDiscoveryConfig(DeleteDiscoveryConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDiscoveryConfigRequest(ref request, ref callSettings);
            _callDeleteDiscoveryConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a discovery configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteDiscoveryConfigAsync(DeleteDiscoveryConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDiscoveryConfigRequest(ref request, ref callSettings);
            return _callDeleteDiscoveryConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new job to inspect storage or calculate risk metrics.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// 
        /// When no InfoTypes or CustomInfoTypes are specified in inspect jobs, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DlpJob CreateDlpJob(CreateDlpJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDlpJobRequest(ref request, ref callSettings);
            return _callCreateDlpJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new job to inspect storage or calculate risk metrics.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// 
        /// When no InfoTypes or CustomInfoTypes are specified in inspect jobs, the
        /// system will automatically choose what detectors to run. By default this may
        /// be all types, but may change over time as detectors are updated.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DlpJob> CreateDlpJobAsync(CreateDlpJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDlpJobRequest(ref request, ref callSettings);
            return _callCreateDlpJob.Async(request, callSettings);
        }

        /// <summary>
        /// Lists DlpJobs that match the specified filter in the request.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DlpJob"/> resources.</returns>
        public override gax::PagedEnumerable<ListDlpJobsResponse, DlpJob> ListDlpJobs(ListDlpJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDlpJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDlpJobsRequest, ListDlpJobsResponse, DlpJob>(_callListDlpJobs, request, callSettings);
        }

        /// <summary>
        /// Lists DlpJobs that match the specified filter in the request.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DlpJob"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDlpJobsResponse, DlpJob> ListDlpJobsAsync(ListDlpJobsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDlpJobsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDlpJobsRequest, ListDlpJobsResponse, DlpJob>(_callListDlpJobs, request, callSettings);
        }

        /// <summary>
        /// Gets the latest state of a long-running DlpJob.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DlpJob GetDlpJob(GetDlpJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDlpJobRequest(ref request, ref callSettings);
            return _callGetDlpJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the latest state of a long-running DlpJob.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DlpJob> GetDlpJobAsync(GetDlpJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDlpJobRequest(ref request, ref callSettings);
            return _callGetDlpJob.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a long-running DlpJob. This method indicates that the client is
        /// no longer interested in the DlpJob result. The job will be canceled if
        /// possible.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteDlpJob(DeleteDlpJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDlpJobRequest(ref request, ref callSettings);
            _callDeleteDlpJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a long-running DlpJob. This method indicates that the client is
        /// no longer interested in the DlpJob result. The job will be canceled if
        /// possible.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteDlpJobAsync(DeleteDlpJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDlpJobRequest(ref request, ref callSettings);
            return _callDeleteDlpJob.Async(request, callSettings);
        }

        /// <summary>
        /// Starts asynchronous cancellation on a long-running DlpJob. The server
        /// makes a best effort to cancel the DlpJob, but success is not
        /// guaranteed.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void CancelDlpJob(CancelDlpJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelDlpJobRequest(ref request, ref callSettings);
            _callCancelDlpJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Starts asynchronous cancellation on a long-running DlpJob. The server
        /// makes a best effort to cancel the DlpJob, but success is not
        /// guaranteed.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/inspecting-storage
        /// and
        /// https://cloud.google.com/sensitive-data-protection/docs/compute-risk-analysis
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task CancelDlpJobAsync(CancelDlpJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelDlpJobRequest(ref request, ref callSettings);
            return _callCancelDlpJob.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a pre-built stored infoType to be used for inspection.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override StoredInfoType CreateStoredInfoType(CreateStoredInfoTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateStoredInfoTypeRequest(ref request, ref callSettings);
            return _callCreateStoredInfoType.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a pre-built stored infoType to be used for inspection.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<StoredInfoType> CreateStoredInfoTypeAsync(CreateStoredInfoTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateStoredInfoTypeRequest(ref request, ref callSettings);
            return _callCreateStoredInfoType.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the stored infoType by creating a new version. The existing version
        /// will continue to be used until the new version is ready.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override StoredInfoType UpdateStoredInfoType(UpdateStoredInfoTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateStoredInfoTypeRequest(ref request, ref callSettings);
            return _callUpdateStoredInfoType.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the stored infoType by creating a new version. The existing version
        /// will continue to be used until the new version is ready.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<StoredInfoType> UpdateStoredInfoTypeAsync(UpdateStoredInfoTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateStoredInfoTypeRequest(ref request, ref callSettings);
            return _callUpdateStoredInfoType.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a stored infoType.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override StoredInfoType GetStoredInfoType(GetStoredInfoTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetStoredInfoTypeRequest(ref request, ref callSettings);
            return _callGetStoredInfoType.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a stored infoType.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<StoredInfoType> GetStoredInfoTypeAsync(GetStoredInfoTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetStoredInfoTypeRequest(ref request, ref callSettings);
            return _callGetStoredInfoType.Async(request, callSettings);
        }

        /// <summary>
        /// Lists stored infoTypes.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="StoredInfoType"/> resources.</returns>
        public override gax::PagedEnumerable<ListStoredInfoTypesResponse, StoredInfoType> ListStoredInfoTypes(ListStoredInfoTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListStoredInfoTypesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListStoredInfoTypesRequest, ListStoredInfoTypesResponse, StoredInfoType>(_callListStoredInfoTypes, request, callSettings);
        }

        /// <summary>
        /// Lists stored infoTypes.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="StoredInfoType"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListStoredInfoTypesResponse, StoredInfoType> ListStoredInfoTypesAsync(ListStoredInfoTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListStoredInfoTypesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListStoredInfoTypesRequest, ListStoredInfoTypesResponse, StoredInfoType>(_callListStoredInfoTypes, request, callSettings);
        }

        /// <summary>
        /// Deletes a stored infoType.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteStoredInfoType(DeleteStoredInfoTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteStoredInfoTypeRequest(ref request, ref callSettings);
            _callDeleteStoredInfoType.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a stored infoType.
        /// See
        /// https://cloud.google.com/sensitive-data-protection/docs/creating-stored-infotypes
        /// to learn more.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteStoredInfoTypeAsync(DeleteStoredInfoTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteStoredInfoTypeRequest(ref request, ref callSettings);
            return _callDeleteStoredInfoType.Async(request, callSettings);
        }

        /// <summary>
        /// Lists project data profiles for an organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ProjectDataProfile"/> resources.</returns>
        public override gax::PagedEnumerable<ListProjectDataProfilesResponse, ProjectDataProfile> ListProjectDataProfiles(ListProjectDataProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProjectDataProfilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListProjectDataProfilesRequest, ListProjectDataProfilesResponse, ProjectDataProfile>(_callListProjectDataProfiles, request, callSettings);
        }

        /// <summary>
        /// Lists project data profiles for an organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ProjectDataProfile"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListProjectDataProfilesResponse, ProjectDataProfile> ListProjectDataProfilesAsync(ListProjectDataProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProjectDataProfilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListProjectDataProfilesRequest, ListProjectDataProfilesResponse, ProjectDataProfile>(_callListProjectDataProfiles, request, callSettings);
        }

        /// <summary>
        /// Lists table data profiles for an organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TableDataProfile"/> resources.</returns>
        public override gax::PagedEnumerable<ListTableDataProfilesResponse, TableDataProfile> ListTableDataProfiles(ListTableDataProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTableDataProfilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTableDataProfilesRequest, ListTableDataProfilesResponse, TableDataProfile>(_callListTableDataProfiles, request, callSettings);
        }

        /// <summary>
        /// Lists table data profiles for an organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TableDataProfile"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTableDataProfilesResponse, TableDataProfile> ListTableDataProfilesAsync(ListTableDataProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTableDataProfilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTableDataProfilesRequest, ListTableDataProfilesResponse, TableDataProfile>(_callListTableDataProfiles, request, callSettings);
        }

        /// <summary>
        /// Lists column data profiles for an organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ColumnDataProfile"/> resources.</returns>
        public override gax::PagedEnumerable<ListColumnDataProfilesResponse, ColumnDataProfile> ListColumnDataProfiles(ListColumnDataProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListColumnDataProfilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListColumnDataProfilesRequest, ListColumnDataProfilesResponse, ColumnDataProfile>(_callListColumnDataProfiles, request, callSettings);
        }

        /// <summary>
        /// Lists column data profiles for an organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ColumnDataProfile"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListColumnDataProfilesResponse, ColumnDataProfile> ListColumnDataProfilesAsync(ListColumnDataProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListColumnDataProfilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListColumnDataProfilesRequest, ListColumnDataProfilesResponse, ColumnDataProfile>(_callListColumnDataProfiles, request, callSettings);
        }

        /// <summary>
        /// Gets a project data profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ProjectDataProfile GetProjectDataProfile(GetProjectDataProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProjectDataProfileRequest(ref request, ref callSettings);
            return _callGetProjectDataProfile.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a project data profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ProjectDataProfile> GetProjectDataProfileAsync(GetProjectDataProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProjectDataProfileRequest(ref request, ref callSettings);
            return _callGetProjectDataProfile.Async(request, callSettings);
        }

        /// <summary>
        /// Lists file store data profiles for an organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FileStoreDataProfile"/> resources.</returns>
        public override gax::PagedEnumerable<ListFileStoreDataProfilesResponse, FileStoreDataProfile> ListFileStoreDataProfiles(ListFileStoreDataProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFileStoreDataProfilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListFileStoreDataProfilesRequest, ListFileStoreDataProfilesResponse, FileStoreDataProfile>(_callListFileStoreDataProfiles, request, callSettings);
        }

        /// <summary>
        /// Lists file store data profiles for an organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FileStoreDataProfile"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListFileStoreDataProfilesResponse, FileStoreDataProfile> ListFileStoreDataProfilesAsync(ListFileStoreDataProfilesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFileStoreDataProfilesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListFileStoreDataProfilesRequest, ListFileStoreDataProfilesResponse, FileStoreDataProfile>(_callListFileStoreDataProfiles, request, callSettings);
        }

        /// <summary>
        /// Gets a file store data profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FileStoreDataProfile GetFileStoreDataProfile(GetFileStoreDataProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFileStoreDataProfileRequest(ref request, ref callSettings);
            return _callGetFileStoreDataProfile.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a file store data profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FileStoreDataProfile> GetFileStoreDataProfileAsync(GetFileStoreDataProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFileStoreDataProfileRequest(ref request, ref callSettings);
            return _callGetFileStoreDataProfile.Async(request, callSettings);
        }

        /// <summary>
        /// Delete a FileStoreDataProfile. Will not prevent the profile from being
        /// regenerated if the resource is still included in a discovery configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteFileStoreDataProfile(DeleteFileStoreDataProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFileStoreDataProfileRequest(ref request, ref callSettings);
            _callDeleteFileStoreDataProfile.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete a FileStoreDataProfile. Will not prevent the profile from being
        /// regenerated if the resource is still included in a discovery configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteFileStoreDataProfileAsync(DeleteFileStoreDataProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFileStoreDataProfileRequest(ref request, ref callSettings);
            return _callDeleteFileStoreDataProfile.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a table data profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TableDataProfile GetTableDataProfile(GetTableDataProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTableDataProfileRequest(ref request, ref callSettings);
            return _callGetTableDataProfile.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a table data profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TableDataProfile> GetTableDataProfileAsync(GetTableDataProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTableDataProfileRequest(ref request, ref callSettings);
            return _callGetTableDataProfile.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a column data profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ColumnDataProfile GetColumnDataProfile(GetColumnDataProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetColumnDataProfileRequest(ref request, ref callSettings);
            return _callGetColumnDataProfile.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a column data profile.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ColumnDataProfile> GetColumnDataProfileAsync(GetColumnDataProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetColumnDataProfileRequest(ref request, ref callSettings);
            return _callGetColumnDataProfile.Async(request, callSettings);
        }

        /// <summary>
        /// Delete a TableDataProfile. Will not prevent the profile from being
        /// regenerated if the table is still included in a discovery configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteTableDataProfile(DeleteTableDataProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTableDataProfileRequest(ref request, ref callSettings);
            _callDeleteTableDataProfile.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete a TableDataProfile. Will not prevent the profile from being
        /// regenerated if the table is still included in a discovery configuration.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteTableDataProfileAsync(DeleteTableDataProfileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTableDataProfileRequest(ref request, ref callSettings);
            return _callDeleteTableDataProfile.Async(request, callSettings);
        }

        /// <summary>
        /// Inspect hybrid content and store findings to a job.
        /// To review the findings, inspect the job. Inspection will occur
        /// asynchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override HybridInspectResponse HybridInspectDlpJob(HybridInspectDlpJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_HybridInspectDlpJobRequest(ref request, ref callSettings);
            return _callHybridInspectDlpJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Inspect hybrid content and store findings to a job.
        /// To review the findings, inspect the job. Inspection will occur
        /// asynchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<HybridInspectResponse> HybridInspectDlpJobAsync(HybridInspectDlpJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_HybridInspectDlpJobRequest(ref request, ref callSettings);
            return _callHybridInspectDlpJob.Async(request, callSettings);
        }

        /// <summary>
        /// Finish a running hybrid DlpJob. Triggers the finalization steps and running
        /// of any enabled actions that have not yet run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void FinishDlpJob(FinishDlpJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FinishDlpJobRequest(ref request, ref callSettings);
            _callFinishDlpJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Finish a running hybrid DlpJob. Triggers the finalization steps and running
        /// of any enabled actions that have not yet run.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task FinishDlpJobAsync(FinishDlpJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FinishDlpJobRequest(ref request, ref callSettings);
            return _callFinishDlpJob.Async(request, callSettings);
        }

        /// <summary>
        /// Create a Connection to an external data source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Connection CreateConnection(CreateConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConnectionRequest(ref request, ref callSettings);
            return _callCreateConnection.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a Connection to an external data source.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Connection> CreateConnectionAsync(CreateConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateConnectionRequest(ref request, ref callSettings);
            return _callCreateConnection.Async(request, callSettings);
        }

        /// <summary>
        /// Get a Connection by name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Connection GetConnection(GetConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConnectionRequest(ref request, ref callSettings);
            return _callGetConnection.Sync(request, callSettings);
        }

        /// <summary>
        /// Get a Connection by name.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Connection> GetConnectionAsync(GetConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConnectionRequest(ref request, ref callSettings);
            return _callGetConnection.Async(request, callSettings);
        }

        /// <summary>
        /// Lists Connections in a parent. Use SearchConnections to see all connections
        /// within an organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Connection"/> resources.</returns>
        public override gax::PagedEnumerable<ListConnectionsResponse, Connection> ListConnections(ListConnectionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConnectionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListConnectionsRequest, ListConnectionsResponse, Connection>(_callListConnections, request, callSettings);
        }

        /// <summary>
        /// Lists Connections in a parent. Use SearchConnections to see all connections
        /// within an organization.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Connection"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListConnectionsResponse, Connection> ListConnectionsAsync(ListConnectionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListConnectionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListConnectionsRequest, ListConnectionsResponse, Connection>(_callListConnections, request, callSettings);
        }

        /// <summary>
        /// Searches for Connections in a parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Connection"/> resources.</returns>
        public override gax::PagedEnumerable<SearchConnectionsResponse, Connection> SearchConnections(SearchConnectionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchConnectionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchConnectionsRequest, SearchConnectionsResponse, Connection>(_callSearchConnections, request, callSettings);
        }

        /// <summary>
        /// Searches for Connections in a parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Connection"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchConnectionsResponse, Connection> SearchConnectionsAsync(SearchConnectionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchConnectionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchConnectionsRequest, SearchConnectionsResponse, Connection>(_callSearchConnections, request, callSettings);
        }

        /// <summary>
        /// Delete a Connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteConnection(DeleteConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConnectionRequest(ref request, ref callSettings);
            _callDeleteConnection.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete a Connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteConnectionAsync(DeleteConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteConnectionRequest(ref request, ref callSettings);
            return _callDeleteConnection.Async(request, callSettings);
        }

        /// <summary>
        /// Update a Connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Connection UpdateConnection(UpdateConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConnectionRequest(ref request, ref callSettings);
            return _callUpdateConnection.Sync(request, callSettings);
        }

        /// <summary>
        /// Update a Connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Connection> UpdateConnectionAsync(UpdateConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConnectionRequest(ref request, ref callSettings);
            return _callUpdateConnection.Async(request, callSettings);
        }
    }

    public partial class ListInspectTemplatesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDeidentifyTemplatesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListJobTriggersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDiscoveryConfigsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDlpJobsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListStoredInfoTypesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListProjectDataProfilesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTableDataProfilesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListColumnDataProfilesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListFileStoreDataProfilesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListConnectionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchConnectionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListInspectTemplatesResponse : gaxgrpc::IPageResponse<InspectTemplate>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<InspectTemplate> GetEnumerator() => InspectTemplates.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDeidentifyTemplatesResponse : gaxgrpc::IPageResponse<DeidentifyTemplate>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DeidentifyTemplate> GetEnumerator() => DeidentifyTemplates.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListJobTriggersResponse : gaxgrpc::IPageResponse<JobTrigger>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<JobTrigger> GetEnumerator() => JobTriggers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDiscoveryConfigsResponse : gaxgrpc::IPageResponse<DiscoveryConfig>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DiscoveryConfig> GetEnumerator() => DiscoveryConfigs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDlpJobsResponse : gaxgrpc::IPageResponse<DlpJob>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DlpJob> GetEnumerator() => Jobs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListStoredInfoTypesResponse : gaxgrpc::IPageResponse<StoredInfoType>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<StoredInfoType> GetEnumerator() => StoredInfoTypes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListProjectDataProfilesResponse : gaxgrpc::IPageResponse<ProjectDataProfile>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ProjectDataProfile> GetEnumerator() => ProjectDataProfiles.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTableDataProfilesResponse : gaxgrpc::IPageResponse<TableDataProfile>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TableDataProfile> GetEnumerator() => TableDataProfiles.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListColumnDataProfilesResponse : gaxgrpc::IPageResponse<ColumnDataProfile>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ColumnDataProfile> GetEnumerator() => ColumnDataProfiles.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListFileStoreDataProfilesResponse : gaxgrpc::IPageResponse<FileStoreDataProfile>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<FileStoreDataProfile> GetEnumerator() => FileStoreDataProfiles.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListConnectionsResponse : gaxgrpc::IPageResponse<Connection>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Connection> GetEnumerator() => Connections.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchConnectionsResponse : gaxgrpc::IPageResponse<Connection>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Connection> GetEnumerator() => Connections.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class DlpService
    {
        public partial class DlpServiceClient
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
