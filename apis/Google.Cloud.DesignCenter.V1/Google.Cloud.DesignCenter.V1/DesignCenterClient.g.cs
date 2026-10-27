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

namespace Google.Cloud.DesignCenter.V1
{
    /// <summary>Settings for <see cref="DesignCenterClient"/> instances.</summary>
    public sealed partial class DesignCenterSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DesignCenterSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DesignCenterSettings"/>.</returns>
        public static DesignCenterSettings GetDefault() => new DesignCenterSettings();

        /// <summary>Constructs a new <see cref="DesignCenterSettings"/> object with default settings.</summary>
        public DesignCenterSettings()
        {
        }

        private DesignCenterSettings(DesignCenterSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetSpaceSettings = existing.GetSpaceSettings;
            ListSpacesSettings = existing.ListSpacesSettings;
            CreateSpaceSettings = existing.CreateSpaceSettings;
            UpdateSpaceSettings = existing.UpdateSpaceSettings;
            DeleteSpaceSettings = existing.DeleteSpaceSettings;
            GetApplicationTemplateSettings = existing.GetApplicationTemplateSettings;
            ListApplicationTemplatesSettings = existing.ListApplicationTemplatesSettings;
            CreateApplicationTemplateSettings = existing.CreateApplicationTemplateSettings;
            UpdateApplicationTemplateSettings = existing.UpdateApplicationTemplateSettings;
            ImportApplicationTemplateSettings = existing.ImportApplicationTemplateSettings;
            DeleteApplicationTemplateSettings = existing.DeleteApplicationTemplateSettings;
            CommitApplicationTemplateSettings = existing.CommitApplicationTemplateSettings;
            SnapshotApplicationTemplateSettings = existing.SnapshotApplicationTemplateSettings;
            SnapshotApplicationTemplateOperationsSettings = existing.SnapshotApplicationTemplateOperationsSettings.Clone();
            GenerateApplicationTemplateIaCSettings = existing.GenerateApplicationTemplateIaCSettings;
            ExportApplicationTemplateIaCSettings = existing.ExportApplicationTemplateIaCSettings;
            ExportApplicationTemplateIaCOperationsSettings = existing.ExportApplicationTemplateIaCOperationsSettings.Clone();
            GenerateApplicationTemplateRevisionIaCSettings = existing.GenerateApplicationTemplateRevisionIaCSettings;
            ExportApplicationTemplateRevisionIaCSettings = existing.ExportApplicationTemplateRevisionIaCSettings;
            ExportApplicationTemplateRevisionIaCOperationsSettings = existing.ExportApplicationTemplateRevisionIaCOperationsSettings.Clone();
            GetComponentSettings = existing.GetComponentSettings;
            ListComponentsSettings = existing.ListComponentsSettings;
            CreateComponentSettings = existing.CreateComponentSettings;
            UpdateComponentSettings = existing.UpdateComponentSettings;
            DeleteComponentSettings = existing.DeleteComponentSettings;
            GetConnectionSettings = existing.GetConnectionSettings;
            ListConnectionsSettings = existing.ListConnectionsSettings;
            CreateConnectionSettings = existing.CreateConnectionSettings;
            UpdateConnectionSettings = existing.UpdateConnectionSettings;
            DeleteConnectionSettings = existing.DeleteConnectionSettings;
            GetApplicationTemplateRevisionSettings = existing.GetApplicationTemplateRevisionSettings;
            ListApplicationTemplateRevisionsSettings = existing.ListApplicationTemplateRevisionsSettings;
            DeleteApplicationTemplateRevisionSettings = existing.DeleteApplicationTemplateRevisionSettings;
            GetCatalogSettings = existing.GetCatalogSettings;
            ListCatalogsSettings = existing.ListCatalogsSettings;
            CreateCatalogSettings = existing.CreateCatalogSettings;
            UpdateCatalogSettings = existing.UpdateCatalogSettings;
            DeleteCatalogSettings = existing.DeleteCatalogSettings;
            DeleteCatalogOperationsSettings = existing.DeleteCatalogOperationsSettings.Clone();
            CreateCatalogTemplateSettings = existing.CreateCatalogTemplateSettings;
            GetCatalogTemplateSettings = existing.GetCatalogTemplateSettings;
            ListCatalogTemplatesSettings = existing.ListCatalogTemplatesSettings;
            UpdateCatalogTemplateSettings = existing.UpdateCatalogTemplateSettings;
            DeleteCatalogTemplateSettings = existing.DeleteCatalogTemplateSettings;
            DeleteCatalogTemplateOperationsSettings = existing.DeleteCatalogTemplateOperationsSettings.Clone();
            CreateShareSettings = existing.CreateShareSettings;
            CreateShareOperationsSettings = existing.CreateShareOperationsSettings.Clone();
            ListSharesSettings = existing.ListSharesSettings;
            GetShareSettings = existing.GetShareSettings;
            DeleteShareSettings = existing.DeleteShareSettings;
            DeleteShareOperationsSettings = existing.DeleteShareOperationsSettings.Clone();
            SyncShareSettings = existing.SyncShareSettings;
            SyncShareOperationsSettings = existing.SyncShareOperationsSettings.Clone();
            GetSharedTemplateSettings = existing.GetSharedTemplateSettings;
            ListSharedTemplatesSettings = existing.ListSharedTemplatesSettings;
            GetSharedTemplateRevisionSettings = existing.GetSharedTemplateRevisionSettings;
            ListSharedTemplateRevisionsSettings = existing.ListSharedTemplateRevisionsSettings;
            CreateCatalogTemplateRevisionSettings = existing.CreateCatalogTemplateRevisionSettings;
            CreateCatalogTemplateRevisionOperationsSettings = existing.CreateCatalogTemplateRevisionOperationsSettings.Clone();
            GetCatalogTemplateRevisionSettings = existing.GetCatalogTemplateRevisionSettings;
            ListCatalogTemplateRevisionsSettings = existing.ListCatalogTemplateRevisionsSettings;
            DeleteCatalogTemplateRevisionSettings = existing.DeleteCatalogTemplateRevisionSettings;
            DeleteCatalogTemplateRevisionOperationsSettings = existing.DeleteCatalogTemplateRevisionOperationsSettings.Clone();
            CreateApplicationSettings = existing.CreateApplicationSettings;
            GetApplicationSettings = existing.GetApplicationSettings;
            ListApplicationsSettings = existing.ListApplicationsSettings;
            UpdateApplicationSettings = existing.UpdateApplicationSettings;
            DeleteApplicationSettings = existing.DeleteApplicationSettings;
            DeleteApplicationOperationsSettings = existing.DeleteApplicationOperationsSettings.Clone();
            DeployApplicationSettings = existing.DeployApplicationSettings;
            DeployApplicationOperationsSettings = existing.DeployApplicationOperationsSettings.Clone();
            PreviewApplicationSettings = existing.PreviewApplicationSettings;
            PreviewApplicationOperationsSettings = existing.PreviewApplicationOperationsSettings.Clone();
            FetchApplicationAssessmentReportSettings = existing.FetchApplicationAssessmentReportSettings;
            GenerateApplicationAssessmentReportSettings = existing.GenerateApplicationAssessmentReportSettings;
            GenerateApplicationAssessmentReportOperationsSettings = existing.GenerateApplicationAssessmentReportOperationsSettings.Clone();
            GenerateApplicationTemplateAssessmentReportSettings = existing.GenerateApplicationTemplateAssessmentReportSettings;
            GenerateApplicationTemplateAssessmentReportOperationsSettings = existing.GenerateApplicationTemplateAssessmentReportOperationsSettings.Clone();
            GenerateAssessmentReportSettings = existing.GenerateAssessmentReportSettings;
            GenerateAssessmentReportOperationsSettings = existing.GenerateAssessmentReportOperationsSettings.Clone();
            GenerateTerraformPlanAssessmentReportSettings = existing.GenerateTerraformPlanAssessmentReportSettings;
            GenerateTerraformPlanAssessmentReportOperationsSettings = existing.GenerateTerraformPlanAssessmentReportOperationsSettings.Clone();
            GetPolicySettings = existing.GetPolicySettings;
            ListPoliciesSettings = existing.ListPoliciesSettings;
            CreatePolicySettings = existing.CreatePolicySettings;
            UpdatePolicySettings = existing.UpdatePolicySettings;
            DeletePolicySettings = existing.DeletePolicySettings;
            FetchFrameworksSettings = existing.FetchFrameworksSettings;
            GenerateApplicationIaCSettings = existing.GenerateApplicationIaCSettings;
            ExportApplicationIaCSettings = existing.ExportApplicationIaCSettings;
            ExportApplicationIaCOperationsSettings = existing.ExportApplicationIaCOperationsSettings.Clone();
            ImportApplicationTemplateIaCSettings = existing.ImportApplicationTemplateIaCSettings;
            IngestApplicationTemplateIaCSettings = existing.IngestApplicationTemplateIaCSettings;
            IngestApplicationTemplateIaCOperationsSettings = existing.IngestApplicationTemplateIaCOperationsSettings.Clone();
            ImportApplicationIaCSettings = existing.ImportApplicationIaCSettings;
            RegisterAppHubApplicationResourcesSettings = existing.RegisterAppHubApplicationResourcesSettings;
            RegisterAppHubApplicationResourcesOperationsSettings = existing.RegisterAppHubApplicationResourcesOperationsSettings.Clone();
            ListApplicationTemplateSystemRevisionsSettings = existing.ListApplicationTemplateSystemRevisionsSettings;
            GetApplicationTemplateSystemRevisionSettings = existing.GetApplicationTemplateSystemRevisionSettings;
            RecommendIAMRolesSettings = existing.RecommendIAMRolesSettings;
            RecommendIAMRolesOperationsSettings = existing.RecommendIAMRolesOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(DesignCenterSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DesignCenterClient.GetSpace</c>
        ///  and <c>DesignCenterClient.GetSpaceAsync</c>.
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
        public gaxgrpc::CallSettings GetSpaceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.ListSpaces</c> and <c>DesignCenterClient.ListSpacesAsync</c>.
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
        public gaxgrpc::CallSettings ListSpacesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.CreateSpace</c> and <c>DesignCenterClient.CreateSpaceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 120 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSpaceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(120000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.UpdateSpace</c> and <c>DesignCenterClient.UpdateSpaceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSpaceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.DeleteSpace</c> and <c>DesignCenterClient.DeleteSpaceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSpaceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.GetApplicationTemplate</c> and <c>DesignCenterClient.GetApplicationTemplateAsync</c>.
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
        public gaxgrpc::CallSettings GetApplicationTemplateSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.ListApplicationTemplates</c> and <c>DesignCenterClient.ListApplicationTemplatesAsync</c>
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
        public gaxgrpc::CallSettings ListApplicationTemplatesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.CreateApplicationTemplate</c> and <c>DesignCenterClient.CreateApplicationTemplateAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateApplicationTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.UpdateApplicationTemplate</c> and <c>DesignCenterClient.UpdateApplicationTemplateAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateApplicationTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.ImportApplicationTemplate</c> and <c>DesignCenterClient.ImportApplicationTemplateAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ImportApplicationTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.DeleteApplicationTemplate</c> and <c>DesignCenterClient.DeleteApplicationTemplateAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteApplicationTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.CommitApplicationTemplate</c> and <c>DesignCenterClient.CommitApplicationTemplateAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CommitApplicationTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.SnapshotApplicationTemplate</c> and
        /// <c>DesignCenterClient.SnapshotApplicationTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SnapshotApplicationTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DesignCenterClient.SnapshotApplicationTemplate</c> and
        /// <c>DesignCenterClient.SnapshotApplicationTemplateAsync</c>.
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
        public lro::OperationsSettings SnapshotApplicationTemplateOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.GenerateApplicationTemplateIaC</c> and
        /// <c>DesignCenterClient.GenerateApplicationTemplateIaCAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateApplicationTemplateIaCSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.ExportApplicationTemplateIaC</c> and
        /// <c>DesignCenterClient.ExportApplicationTemplateIaCAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExportApplicationTemplateIaCSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DesignCenterClient.ExportApplicationTemplateIaC</c> and
        /// <c>DesignCenterClient.ExportApplicationTemplateIaCAsync</c>.
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
        public lro::OperationsSettings ExportApplicationTemplateIaCOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.GenerateApplicationTemplateRevisionIaC</c> and
        /// <c>DesignCenterClient.GenerateApplicationTemplateRevisionIaCAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateApplicationTemplateRevisionIaCSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.ExportApplicationTemplateRevisionIaC</c> and
        /// <c>DesignCenterClient.ExportApplicationTemplateRevisionIaCAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExportApplicationTemplateRevisionIaCSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DesignCenterClient.ExportApplicationTemplateRevisionIaC</c>
        /// and <c>DesignCenterClient.ExportApplicationTemplateRevisionIaCAsync</c>.
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
        public lro::OperationsSettings ExportApplicationTemplateRevisionIaCOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.GetComponent</c> and <c>DesignCenterClient.GetComponentAsync</c>.
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
        public gaxgrpc::CallSettings GetComponentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.ListComponents</c> and <c>DesignCenterClient.ListComponentsAsync</c>.
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
        public gaxgrpc::CallSettings ListComponentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.CreateComponent</c> and <c>DesignCenterClient.CreateComponentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateComponentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.UpdateComponent</c> and <c>DesignCenterClient.UpdateComponentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateComponentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.DeleteComponent</c> and <c>DesignCenterClient.DeleteComponentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteComponentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.GetConnection</c> and <c>DesignCenterClient.GetConnectionAsync</c>.
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
        public gaxgrpc::CallSettings GetConnectionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.ListConnections</c> and <c>DesignCenterClient.ListConnectionsAsync</c>.
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
        public gaxgrpc::CallSettings ListConnectionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.CreateConnection</c> and <c>DesignCenterClient.CreateConnectionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateConnectionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.UpdateConnection</c> and <c>DesignCenterClient.UpdateConnectionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateConnectionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.DeleteConnection</c> and <c>DesignCenterClient.DeleteConnectionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteConnectionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.GetApplicationTemplateRevision</c> and
        /// <c>DesignCenterClient.GetApplicationTemplateRevisionAsync</c>.
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
        public gaxgrpc::CallSettings GetApplicationTemplateRevisionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.ListApplicationTemplateRevisions</c> and
        /// <c>DesignCenterClient.ListApplicationTemplateRevisionsAsync</c>.
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
        public gaxgrpc::CallSettings ListApplicationTemplateRevisionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.DeleteApplicationTemplateRevision</c> and
        /// <c>DesignCenterClient.DeleteApplicationTemplateRevisionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteApplicationTemplateRevisionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.GetCatalog</c> and <c>DesignCenterClient.GetCatalogAsync</c>.
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
        public gaxgrpc::CallSettings GetCatalogSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.ListCatalogs</c> and <c>DesignCenterClient.ListCatalogsAsync</c>.
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
        public gaxgrpc::CallSettings ListCatalogsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.CreateCatalog</c> and <c>DesignCenterClient.CreateCatalogAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateCatalogSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.UpdateCatalog</c> and <c>DesignCenterClient.UpdateCatalogAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateCatalogSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.DeleteCatalog</c> and <c>DesignCenterClient.DeleteCatalogAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteCatalogSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DesignCenterClient.DeleteCatalog</c> and
        /// <c>DesignCenterClient.DeleteCatalogAsync</c>.
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
        public lro::OperationsSettings DeleteCatalogOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.CreateCatalogTemplate</c> and <c>DesignCenterClient.CreateCatalogTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateCatalogTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.GetCatalogTemplate</c> and <c>DesignCenterClient.GetCatalogTemplateAsync</c>.
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
        public gaxgrpc::CallSettings GetCatalogTemplateSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.ListCatalogTemplates</c> and <c>DesignCenterClient.ListCatalogTemplatesAsync</c>.
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
        public gaxgrpc::CallSettings ListCatalogTemplatesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.UpdateCatalogTemplate</c> and <c>DesignCenterClient.UpdateCatalogTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateCatalogTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.DeleteCatalogTemplate</c> and <c>DesignCenterClient.DeleteCatalogTemplateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteCatalogTemplateSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DesignCenterClient.DeleteCatalogTemplate</c> and
        /// <c>DesignCenterClient.DeleteCatalogTemplateAsync</c>.
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
        public lro::OperationsSettings DeleteCatalogTemplateOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.CreateShare</c> and <c>DesignCenterClient.CreateShareAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateShareSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DesignCenterClient.CreateShare</c> and
        /// <c>DesignCenterClient.CreateShareAsync</c>.
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
        public lro::OperationsSettings CreateShareOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.ListShares</c> and <c>DesignCenterClient.ListSharesAsync</c>.
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
        public gaxgrpc::CallSettings ListSharesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>DesignCenterClient.GetShare</c>
        ///  and <c>DesignCenterClient.GetShareAsync</c>.
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
        public gaxgrpc::CallSettings GetShareSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.DeleteShare</c> and <c>DesignCenterClient.DeleteShareAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteShareSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DesignCenterClient.DeleteShare</c> and
        /// <c>DesignCenterClient.DeleteShareAsync</c>.
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
        public lro::OperationsSettings DeleteShareOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.SyncShare</c> and <c>DesignCenterClient.SyncShareAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SyncShareSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DesignCenterClient.SyncShare</c> and
        /// <c>DesignCenterClient.SyncShareAsync</c>.
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
        public lro::OperationsSettings SyncShareOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.GetSharedTemplate</c> and <c>DesignCenterClient.GetSharedTemplateAsync</c>.
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
        public gaxgrpc::CallSettings GetSharedTemplateSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.ListSharedTemplates</c> and <c>DesignCenterClient.ListSharedTemplatesAsync</c>.
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
        public gaxgrpc::CallSettings ListSharedTemplatesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.GetSharedTemplateRevision</c> and <c>DesignCenterClient.GetSharedTemplateRevisionAsync</c>
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
        public gaxgrpc::CallSettings GetSharedTemplateRevisionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.ListSharedTemplateRevisions</c> and
        /// <c>DesignCenterClient.ListSharedTemplateRevisionsAsync</c>.
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
        public gaxgrpc::CallSettings ListSharedTemplateRevisionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.CreateCatalogTemplateRevision</c> and
        /// <c>DesignCenterClient.CreateCatalogTemplateRevisionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateCatalogTemplateRevisionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DesignCenterClient.CreateCatalogTemplateRevision</c> and
        /// <c>DesignCenterClient.CreateCatalogTemplateRevisionAsync</c>.
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
        public lro::OperationsSettings CreateCatalogTemplateRevisionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.GetCatalogTemplateRevision</c> and
        /// <c>DesignCenterClient.GetCatalogTemplateRevisionAsync</c>.
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
        public gaxgrpc::CallSettings GetCatalogTemplateRevisionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.ListCatalogTemplateRevisions</c> and
        /// <c>DesignCenterClient.ListCatalogTemplateRevisionsAsync</c>.
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
        public gaxgrpc::CallSettings ListCatalogTemplateRevisionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.DeleteCatalogTemplateRevision</c> and
        /// <c>DesignCenterClient.DeleteCatalogTemplateRevisionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteCatalogTemplateRevisionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DesignCenterClient.DeleteCatalogTemplateRevision</c> and
        /// <c>DesignCenterClient.DeleteCatalogTemplateRevisionAsync</c>.
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
        public lro::OperationsSettings DeleteCatalogTemplateRevisionOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.CreateApplication</c> and <c>DesignCenterClient.CreateApplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateApplicationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.GetApplication</c> and <c>DesignCenterClient.GetApplicationAsync</c>.
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
        public gaxgrpc::CallSettings GetApplicationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.ListApplications</c> and <c>DesignCenterClient.ListApplicationsAsync</c>.
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
        public gaxgrpc::CallSettings ListApplicationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.UpdateApplication</c> and <c>DesignCenterClient.UpdateApplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateApplicationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.DeleteApplication</c> and <c>DesignCenterClient.DeleteApplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteApplicationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DesignCenterClient.DeleteApplication</c> and
        /// <c>DesignCenterClient.DeleteApplicationAsync</c>.
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
        public lro::OperationsSettings DeleteApplicationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.DeployApplication</c> and <c>DesignCenterClient.DeployApplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeployApplicationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DesignCenterClient.DeployApplication</c> and
        /// <c>DesignCenterClient.DeployApplicationAsync</c>.
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
        public lro::OperationsSettings DeployApplicationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.PreviewApplication</c> and <c>DesignCenterClient.PreviewApplicationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PreviewApplicationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DesignCenterClient.PreviewApplication</c> and
        /// <c>DesignCenterClient.PreviewApplicationAsync</c>.
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
        public lro::OperationsSettings PreviewApplicationOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.FetchApplicationAssessmentReport</c> and
        /// <c>DesignCenterClient.FetchApplicationAssessmentReportAsync</c>.
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
        public gaxgrpc::CallSettings FetchApplicationAssessmentReportSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.GenerateApplicationAssessmentReport</c> and
        /// <c>DesignCenterClient.GenerateApplicationAssessmentReportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateApplicationAssessmentReportSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DesignCenterClient.GenerateApplicationAssessmentReport</c>
        /// and <c>DesignCenterClient.GenerateApplicationAssessmentReportAsync</c>.
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
        public lro::OperationsSettings GenerateApplicationAssessmentReportOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.GenerateApplicationTemplateAssessmentReport</c> and
        /// <c>DesignCenterClient.GenerateApplicationTemplateAssessmentReportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateApplicationTemplateAssessmentReportSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>DesignCenterClient.GenerateApplicationTemplateAssessmentReport</c> and
        /// <c>DesignCenterClient.GenerateApplicationTemplateAssessmentReportAsync</c>.
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
        public lro::OperationsSettings GenerateApplicationTemplateAssessmentReportOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.GenerateAssessmentReport</c> and <c>DesignCenterClient.GenerateAssessmentReportAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateAssessmentReportSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DesignCenterClient.GenerateAssessmentReport</c> and
        /// <c>DesignCenterClient.GenerateAssessmentReportAsync</c>.
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
        public lro::OperationsSettings GenerateAssessmentReportOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.GenerateTerraformPlanAssessmentReport</c> and
        /// <c>DesignCenterClient.GenerateTerraformPlanAssessmentReportAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateTerraformPlanAssessmentReportSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DesignCenterClient.GenerateTerraformPlanAssessmentReport</c>
        /// and <c>DesignCenterClient.GenerateTerraformPlanAssessmentReportAsync</c>.
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
        public lro::OperationsSettings GenerateTerraformPlanAssessmentReportOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.GetPolicy</c> and <c>DesignCenterClient.GetPolicyAsync</c>.
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
        public gaxgrpc::CallSettings GetPolicySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.ListPolicies</c> and <c>DesignCenterClient.ListPoliciesAsync</c>.
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
        public gaxgrpc::CallSettings ListPoliciesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.CreatePolicy</c> and <c>DesignCenterClient.CreatePolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreatePolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.UpdatePolicy</c> and <c>DesignCenterClient.UpdatePolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdatePolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.DeletePolicy</c> and <c>DesignCenterClient.DeletePolicyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeletePolicySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.FetchFrameworks</c> and <c>DesignCenterClient.FetchFrameworksAsync</c>.
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
        public gaxgrpc::CallSettings FetchFrameworksSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.GenerateApplicationIaC</c> and <c>DesignCenterClient.GenerateApplicationIaCAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GenerateApplicationIaCSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.ExportApplicationIaC</c> and <c>DesignCenterClient.ExportApplicationIaCAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ExportApplicationIaCSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DesignCenterClient.ExportApplicationIaC</c> and
        /// <c>DesignCenterClient.ExportApplicationIaCAsync</c>.
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
        public lro::OperationsSettings ExportApplicationIaCOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.ImportApplicationTemplateIaC</c> and
        /// <c>DesignCenterClient.ImportApplicationTemplateIaCAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ImportApplicationTemplateIaCSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.IngestApplicationTemplateIaC</c> and
        /// <c>DesignCenterClient.IngestApplicationTemplateIaCAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings IngestApplicationTemplateIaCSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>DesignCenterClient.IngestApplicationTemplateIaC</c> and
        /// <c>DesignCenterClient.IngestApplicationTemplateIaCAsync</c>.
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
        public lro::OperationsSettings IngestApplicationTemplateIaCOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.ImportApplicationIaC</c> and <c>DesignCenterClient.ImportApplicationIaCAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ImportApplicationIaCSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.RegisterAppHubApplicationResources</c> and
        /// <c>DesignCenterClient.RegisterAppHubApplicationResourcesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RegisterAppHubApplicationResourcesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DesignCenterClient.RegisterAppHubApplicationResources</c>
        /// and <c>DesignCenterClient.RegisterAppHubApplicationResourcesAsync</c>.
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
        public lro::OperationsSettings RegisterAppHubApplicationResourcesOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.ListApplicationTemplateSystemRevisions</c> and
        /// <c>DesignCenterClient.ListApplicationTemplateSystemRevisionsAsync</c>.
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
        public gaxgrpc::CallSettings ListApplicationTemplateSystemRevisionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.GetApplicationTemplateSystemRevision</c> and
        /// <c>DesignCenterClient.GetApplicationTemplateSystemRevisionAsync</c>.
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
        public gaxgrpc::CallSettings GetApplicationTemplateSystemRevisionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DesignCenterClient.RecommendIAMRoles</c> and <c>DesignCenterClient.RecommendIAMRolesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RecommendIAMRolesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>DesignCenterClient.RecommendIAMRoles</c> and
        /// <c>DesignCenterClient.RecommendIAMRolesAsync</c>.
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
        public lro::OperationsSettings RecommendIAMRolesOperationsSettings { get; set; } = new lro::OperationsSettings
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
        /// <returns>A deep clone of this <see cref="DesignCenterSettings"/> object.</returns>
        public DesignCenterSettings Clone() => new DesignCenterSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DesignCenterClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class DesignCenterClientBuilder : gaxgrpc::ClientBuilderBase<DesignCenterClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DesignCenterSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public DesignCenterClientBuilder() : base(DesignCenterClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref DesignCenterClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DesignCenterClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DesignCenterClient Build()
        {
            DesignCenterClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DesignCenterClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DesignCenterClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DesignCenterClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DesignCenterClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<DesignCenterClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DesignCenterClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DesignCenterClient.ChannelPool;
    }

    /// <summary>DesignCenter client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public abstract partial class DesignCenterClient
    {
        /// <summary>
        /// The default endpoint for the DesignCenter service, which is a host of "designcenter.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "designcenter.googleapis.com:443";

        /// <summary>The default DesignCenter scopes.</summary>
        /// <remarks>
        /// The default DesignCenter scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(DesignCenter.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="DesignCenterClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DesignCenterClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DesignCenterClient"/>.</returns>
        public static stt::Task<DesignCenterClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DesignCenterClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DesignCenterClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="DesignCenterClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DesignCenterClient"/>.</returns>
        public static DesignCenterClient Create() => new DesignCenterClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DesignCenterClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DesignCenterSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="DesignCenterClient"/>.</returns>
        internal static DesignCenterClient Create(grpccore::CallInvoker callInvoker, DesignCenterSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DesignCenter.DesignCenterClient grpcClient = new DesignCenter.DesignCenterClient(callInvoker);
            return new DesignCenterClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC DesignCenter client</summary>
        public virtual DesignCenter.DesignCenterClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about a space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Space GetSpace(GetSpaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about a space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> GetSpaceAsync(GetSpaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about a space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> GetSpaceAsync(GetSpaceRequest request, st::CancellationToken cancellationToken) =>
            GetSpaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a space.
        /// </summary>
        /// <param name="name">
        /// Required. The space name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Space GetSpace(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpace(new GetSpaceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a space.
        /// </summary>
        /// <param name="name">
        /// Required. The space name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> GetSpaceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpaceAsync(new GetSpaceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a space.
        /// </summary>
        /// <param name="name">
        /// Required. The space name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> GetSpaceAsync(string name, st::CancellationToken cancellationToken) =>
            GetSpaceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a space.
        /// </summary>
        /// <param name="name">
        /// Required. The space name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Space GetSpace(SpaceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpace(new GetSpaceRequest
            {
                SpaceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a space.
        /// </summary>
        /// <param name="name">
        /// Required. The space name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> GetSpaceAsync(SpaceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSpaceAsync(new GetSpaceRequest
            {
                SpaceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a space.
        /// </summary>
        /// <param name="name">
        /// Required. The space name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> GetSpaceAsync(SpaceName name, st::CancellationToken cancellationToken) =>
            GetSpaceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists spaces in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Space"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSpacesResponse, Space> ListSpaces(ListSpacesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists spaces in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Space"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSpacesResponse, Space> ListSpacesAsync(ListSpacesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists spaces in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource, for which spaces are listed.
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
        /// <returns>A pageable sequence of <see cref="Space"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSpacesResponse, Space> ListSpaces(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSpacesRequest request = new ListSpacesRequest
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
            return ListSpaces(request, callSettings);
        }

        /// <summary>
        /// Lists spaces in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource, for which spaces are listed.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Space"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSpacesResponse, Space> ListSpacesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSpacesRequest request = new ListSpacesRequest
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
            return ListSpacesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists spaces in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource, for which spaces are listed.
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
        /// <returns>A pageable sequence of <see cref="Space"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSpacesResponse, Space> ListSpaces(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSpacesRequest request = new ListSpacesRequest
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
            return ListSpaces(request, callSettings);
        }

        /// <summary>
        /// Lists spaces in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent resource, for which spaces are listed.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Space"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSpacesResponse, Space> ListSpacesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSpacesRequest request = new ListSpacesRequest
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
            return ListSpacesAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Space CreateSpace(CreateSpaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> CreateSpaceAsync(CreateSpaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> CreateSpaceAsync(CreateSpaceRequest request, st::CancellationToken cancellationToken) =>
            CreateSpaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in which to create a space.
        /// </param>
        /// <param name="space">
        /// Required. The space to create.
        /// </param>
        /// <param name="spaceId">
        /// Required. The ID of the space to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Space CreateSpace(string parent, Space space, string spaceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSpace(new CreateSpaceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SpaceId = gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)),
                Space = gax::GaxPreconditions.CheckNotNull(space, nameof(space)),
            }, callSettings);

        /// <summary>
        /// Creates a space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in which to create a space.
        /// </param>
        /// <param name="space">
        /// Required. The space to create.
        /// </param>
        /// <param name="spaceId">
        /// Required. The ID of the space to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> CreateSpaceAsync(string parent, Space space, string spaceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSpaceAsync(new CreateSpaceRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SpaceId = gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)),
                Space = gax::GaxPreconditions.CheckNotNull(space, nameof(space)),
            }, callSettings);

        /// <summary>
        /// Creates a space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in which to create a space.
        /// </param>
        /// <param name="space">
        /// Required. The space to create.
        /// </param>
        /// <param name="spaceId">
        /// Required. The ID of the space to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> CreateSpaceAsync(string parent, Space space, string spaceId, st::CancellationToken cancellationToken) =>
            CreateSpaceAsync(parent, space, spaceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in which to create a space.
        /// </param>
        /// <param name="space">
        /// Required. The space to create.
        /// </param>
        /// <param name="spaceId">
        /// Required. The ID of the space to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Space CreateSpace(gagr::LocationName parent, Space space, string spaceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSpace(new CreateSpaceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SpaceId = gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)),
                Space = gax::GaxPreconditions.CheckNotNull(space, nameof(space)),
            }, callSettings);

        /// <summary>
        /// Creates a space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in which to create a space.
        /// </param>
        /// <param name="space">
        /// Required. The space to create.
        /// </param>
        /// <param name="spaceId">
        /// Required. The ID of the space to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> CreateSpaceAsync(gagr::LocationName parent, Space space, string spaceId, gaxgrpc::CallSettings callSettings = null) =>
            CreateSpaceAsync(new CreateSpaceRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SpaceId = gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)),
                Space = gax::GaxPreconditions.CheckNotNull(space, nameof(space)),
            }, callSettings);

        /// <summary>
        /// Creates a space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in which to create a space.
        /// </param>
        /// <param name="space">
        /// Required. The space to create.
        /// </param>
        /// <param name="spaceId">
        /// Required. The ID of the space to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> CreateSpaceAsync(gagr::LocationName parent, Space space, string spaceId, st::CancellationToken cancellationToken) =>
            CreateSpaceAsync(parent, space, spaceId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Space UpdateSpace(UpdateSpaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> UpdateSpaceAsync(UpdateSpaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> UpdateSpaceAsync(UpdateSpaceRequest request, st::CancellationToken cancellationToken) =>
            UpdateSpaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a space.
        /// </summary>
        /// <param name="space">
        /// Required. The space to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The fields to overwrite in the space update. If you don't provide
        /// a mask, all fields are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Space UpdateSpace(Space space, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSpace(new UpdateSpaceRequest
            {
                UpdateMask = updateMask,
                Space = gax::GaxPreconditions.CheckNotNull(space, nameof(space)),
            }, callSettings);

        /// <summary>
        /// Updates a space.
        /// </summary>
        /// <param name="space">
        /// Required. The space to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The fields to overwrite in the space update. If you don't provide
        /// a mask, all fields are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> UpdateSpaceAsync(Space space, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSpaceAsync(new UpdateSpaceRequest
            {
                UpdateMask = updateMask,
                Space = gax::GaxPreconditions.CheckNotNull(space, nameof(space)),
            }, callSettings);

        /// <summary>
        /// Updates a space.
        /// </summary>
        /// <param name="space">
        /// Required. The space to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The fields to overwrite in the space update. If you don't provide
        /// a mask, all fields are overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Space> UpdateSpaceAsync(Space space, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSpaceAsync(space, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSpace(DeleteSpaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSpaceAsync(DeleteSpaceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSpaceAsync(DeleteSpaceRequest request, st::CancellationToken cancellationToken) =>
            DeleteSpaceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a space.
        /// </summary>
        /// <param name="name">
        /// Required. The space name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSpace(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSpace(new DeleteSpaceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a space.
        /// </summary>
        /// <param name="name">
        /// Required. The space name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSpaceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSpaceAsync(new DeleteSpaceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a space.
        /// </summary>
        /// <param name="name">
        /// Required. The space name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSpaceAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSpaceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a space.
        /// </summary>
        /// <param name="name">
        /// Required. The space name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSpace(SpaceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSpace(new DeleteSpaceRequest
            {
                SpaceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a space.
        /// </summary>
        /// <param name="name">
        /// Required. The space name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSpaceAsync(SpaceName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSpaceAsync(new DeleteSpaceRequest
            {
                SpaceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a space.
        /// </summary>
        /// <param name="name">
        /// Required. The space name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSpaceAsync(SpaceName name, st::CancellationToken cancellationToken) =>
            DeleteSpaceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApplicationTemplate GetApplicationTemplate(GetApplicationTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplicationTemplate> GetApplicationTemplateAsync(GetApplicationTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplicationTemplate> GetApplicationTemplateAsync(GetApplicationTemplateRequest request, st::CancellationToken cancellationToken) =>
            GetApplicationTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about an application template.
        /// </summary>
        /// <param name="name">
        /// Required. The application template name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApplicationTemplate GetApplicationTemplate(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetApplicationTemplate(new GetApplicationTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about an application template.
        /// </summary>
        /// <param name="name">
        /// Required. The application template name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplicationTemplate> GetApplicationTemplateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetApplicationTemplateAsync(new GetApplicationTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about an application template.
        /// </summary>
        /// <param name="name">
        /// Required. The application template name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplicationTemplate> GetApplicationTemplateAsync(string name, st::CancellationToken cancellationToken) =>
            GetApplicationTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about an application template.
        /// </summary>
        /// <param name="name">
        /// Required. The application template name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApplicationTemplate GetApplicationTemplate(ApplicationTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetApplicationTemplate(new GetApplicationTemplateRequest
            {
                ApplicationTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about an application template.
        /// </summary>
        /// <param name="name">
        /// Required. The application template name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplicationTemplate> GetApplicationTemplateAsync(ApplicationTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetApplicationTemplateAsync(new GetApplicationTemplateRequest
            {
                ApplicationTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about an application template.
        /// </summary>
        /// <param name="name">
        /// Required. The application template name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplicationTemplate> GetApplicationTemplateAsync(ApplicationTemplateName name, st::CancellationToken cancellationToken) =>
            GetApplicationTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists application templates in a given space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ApplicationTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApplicationTemplatesResponse, ApplicationTemplate> ListApplicationTemplates(ListApplicationTemplatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists application templates in a given space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ApplicationTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApplicationTemplatesResponse, ApplicationTemplate> ListApplicationTemplatesAsync(ListApplicationTemplatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists application templates in a given space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource from which to list application templates.
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
        /// <returns>A pageable sequence of <see cref="ApplicationTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApplicationTemplatesResponse, ApplicationTemplate> ListApplicationTemplates(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApplicationTemplatesRequest request = new ListApplicationTemplatesRequest
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
            return ListApplicationTemplates(request, callSettings);
        }

        /// <summary>
        /// Lists application templates in a given space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource from which to list application templates.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ApplicationTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApplicationTemplatesResponse, ApplicationTemplate> ListApplicationTemplatesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApplicationTemplatesRequest request = new ListApplicationTemplatesRequest
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
            return ListApplicationTemplatesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists application templates in a given space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource from which to list application templates.
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
        /// <returns>A pageable sequence of <see cref="ApplicationTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApplicationTemplatesResponse, ApplicationTemplate> ListApplicationTemplates(SpaceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApplicationTemplatesRequest request = new ListApplicationTemplatesRequest
            {
                ParentAsSpaceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListApplicationTemplates(request, callSettings);
        }

        /// <summary>
        /// Lists application templates in a given space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource from which to list application templates.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ApplicationTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApplicationTemplatesResponse, ApplicationTemplate> ListApplicationTemplatesAsync(SpaceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApplicationTemplatesRequest request = new ListApplicationTemplatesRequest
            {
                ParentAsSpaceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListApplicationTemplatesAsync(request, callSettings);
        }

        /// <summary>
        /// Creates an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApplicationTemplate CreateApplicationTemplate(CreateApplicationTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplicationTemplate> CreateApplicationTemplateAsync(CreateApplicationTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplicationTemplate> CreateApplicationTemplateAsync(CreateApplicationTemplateRequest request, st::CancellationToken cancellationToken) =>
            CreateApplicationTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an application template.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the application template.
        /// </param>
        /// <param name="applicationTemplate">
        /// Required. The application template to create.
        /// </param>
        /// <param name="applicationTemplateId">
        /// Required. The ID of the application template to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApplicationTemplate CreateApplicationTemplate(string parent, ApplicationTemplate applicationTemplate, string applicationTemplateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApplicationTemplate(new CreateApplicationTemplateRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ApplicationTemplateId = gax::GaxPreconditions.CheckNotNullOrEmpty(applicationTemplateId, nameof(applicationTemplateId)),
                ApplicationTemplate = gax::GaxPreconditions.CheckNotNull(applicationTemplate, nameof(applicationTemplate)),
            }, callSettings);

        /// <summary>
        /// Creates an application template.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the application template.
        /// </param>
        /// <param name="applicationTemplate">
        /// Required. The application template to create.
        /// </param>
        /// <param name="applicationTemplateId">
        /// Required. The ID of the application template to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplicationTemplate> CreateApplicationTemplateAsync(string parent, ApplicationTemplate applicationTemplate, string applicationTemplateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApplicationTemplateAsync(new CreateApplicationTemplateRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ApplicationTemplateId = gax::GaxPreconditions.CheckNotNullOrEmpty(applicationTemplateId, nameof(applicationTemplateId)),
                ApplicationTemplate = gax::GaxPreconditions.CheckNotNull(applicationTemplate, nameof(applicationTemplate)),
            }, callSettings);

        /// <summary>
        /// Creates an application template.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the application template.
        /// </param>
        /// <param name="applicationTemplate">
        /// Required. The application template to create.
        /// </param>
        /// <param name="applicationTemplateId">
        /// Required. The ID of the application template to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplicationTemplate> CreateApplicationTemplateAsync(string parent, ApplicationTemplate applicationTemplate, string applicationTemplateId, st::CancellationToken cancellationToken) =>
            CreateApplicationTemplateAsync(parent, applicationTemplate, applicationTemplateId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an application template.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the application template.
        /// </param>
        /// <param name="applicationTemplate">
        /// Required. The application template to create.
        /// </param>
        /// <param name="applicationTemplateId">
        /// Required. The ID of the application template to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApplicationTemplate CreateApplicationTemplate(SpaceName parent, ApplicationTemplate applicationTemplate, string applicationTemplateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApplicationTemplate(new CreateApplicationTemplateRequest
            {
                ParentAsSpaceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ApplicationTemplateId = gax::GaxPreconditions.CheckNotNullOrEmpty(applicationTemplateId, nameof(applicationTemplateId)),
                ApplicationTemplate = gax::GaxPreconditions.CheckNotNull(applicationTemplate, nameof(applicationTemplate)),
            }, callSettings);

        /// <summary>
        /// Creates an application template.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the application template.
        /// </param>
        /// <param name="applicationTemplate">
        /// Required. The application template to create.
        /// </param>
        /// <param name="applicationTemplateId">
        /// Required. The ID of the application template to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplicationTemplate> CreateApplicationTemplateAsync(SpaceName parent, ApplicationTemplate applicationTemplate, string applicationTemplateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApplicationTemplateAsync(new CreateApplicationTemplateRequest
            {
                ParentAsSpaceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ApplicationTemplateId = gax::GaxPreconditions.CheckNotNullOrEmpty(applicationTemplateId, nameof(applicationTemplateId)),
                ApplicationTemplate = gax::GaxPreconditions.CheckNotNull(applicationTemplate, nameof(applicationTemplate)),
            }, callSettings);

        /// <summary>
        /// Creates an application template.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the application template.
        /// </param>
        /// <param name="applicationTemplate">
        /// Required. The application template to create.
        /// </param>
        /// <param name="applicationTemplateId">
        /// Required. The ID of the application template to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplicationTemplate> CreateApplicationTemplateAsync(SpaceName parent, ApplicationTemplate applicationTemplate, string applicationTemplateId, st::CancellationToken cancellationToken) =>
            CreateApplicationTemplateAsync(parent, applicationTemplate, applicationTemplateId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApplicationTemplate UpdateApplicationTemplate(UpdateApplicationTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplicationTemplate> UpdateApplicationTemplateAsync(UpdateApplicationTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplicationTemplate> UpdateApplicationTemplateAsync(UpdateApplicationTemplateRequest request, st::CancellationToken cancellationToken) =>
            UpdateApplicationTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an application template.
        /// </summary>
        /// <param name="applicationTemplate">
        /// Required. The application template to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The fields to overwrite in the application template update. The
        /// fields specified in the update_mask are relative to the resource, not the
        /// full request. A field will be overwritten if it is in the mask. If you
        /// don't provide a mask, all fields are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApplicationTemplate UpdateApplicationTemplate(ApplicationTemplate applicationTemplate, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateApplicationTemplate(new UpdateApplicationTemplateRequest
            {
                UpdateMask = updateMask,
                ApplicationTemplate = gax::GaxPreconditions.CheckNotNull(applicationTemplate, nameof(applicationTemplate)),
            }, callSettings);

        /// <summary>
        /// Updates an application template.
        /// </summary>
        /// <param name="applicationTemplate">
        /// Required. The application template to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The fields to overwrite in the application template update. The
        /// fields specified in the update_mask are relative to the resource, not the
        /// full request. A field will be overwritten if it is in the mask. If you
        /// don't provide a mask, all fields are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplicationTemplate> UpdateApplicationTemplateAsync(ApplicationTemplate applicationTemplate, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateApplicationTemplateAsync(new UpdateApplicationTemplateRequest
            {
                UpdateMask = updateMask,
                ApplicationTemplate = gax::GaxPreconditions.CheckNotNull(applicationTemplate, nameof(applicationTemplate)),
            }, callSettings);

        /// <summary>
        /// Updates an application template.
        /// </summary>
        /// <param name="applicationTemplate">
        /// Required. The application template to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The fields to overwrite in the application template update. The
        /// fields specified in the update_mask are relative to the resource, not the
        /// full request. A field will be overwritten if it is in the mask. If you
        /// don't provide a mask, all fields are overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplicationTemplate> UpdateApplicationTemplateAsync(ApplicationTemplate applicationTemplate, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateApplicationTemplateAsync(applicationTemplate, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports to an existing application template from a given shared template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApplicationTemplate ImportApplicationTemplate(ImportApplicationTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports to an existing application template from a given shared template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplicationTemplate> ImportApplicationTemplateAsync(ImportApplicationTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports to an existing application template from a given shared template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplicationTemplate> ImportApplicationTemplateAsync(ImportApplicationTemplateRequest request, st::CancellationToken cancellationToken) =>
            ImportApplicationTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports to an existing application template from a given shared template.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="applicationTemplateRevisionUri">
        /// Optional. The source URI for application template revision.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApplicationTemplate ImportApplicationTemplate(string name, string applicationTemplateRevisionUri, gaxgrpc::CallSettings callSettings = null) =>
            ImportApplicationTemplate(new ImportApplicationTemplateRequest
            {
                ApplicationTemplateRevisionUri = applicationTemplateRevisionUri ?? "",
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Imports to an existing application template from a given shared template.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="applicationTemplateRevisionUri">
        /// Optional. The source URI for application template revision.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplicationTemplate> ImportApplicationTemplateAsync(string name, string applicationTemplateRevisionUri, gaxgrpc::CallSettings callSettings = null) =>
            ImportApplicationTemplateAsync(new ImportApplicationTemplateRequest
            {
                ApplicationTemplateRevisionUri = applicationTemplateRevisionUri ?? "",
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Imports to an existing application template from a given shared template.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="applicationTemplateRevisionUri">
        /// Optional. The source URI for application template revision.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplicationTemplate> ImportApplicationTemplateAsync(string name, string applicationTemplateRevisionUri, st::CancellationToken cancellationToken) =>
            ImportApplicationTemplateAsync(name, applicationTemplateRevisionUri, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports to an existing application template from a given shared template.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="applicationTemplateRevisionUri">
        /// Optional. The source URI for application template revision.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApplicationTemplate ImportApplicationTemplate(ApplicationTemplateName name, ApplicationTemplateRevisionName applicationTemplateRevisionUri, gaxgrpc::CallSettings callSettings = null) =>
            ImportApplicationTemplate(new ImportApplicationTemplateRequest
            {
                ApplicationTemplateRevisionUriAsApplicationTemplateRevisionName = applicationTemplateRevisionUri,
                ApplicationTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Imports to an existing application template from a given shared template.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="applicationTemplateRevisionUri">
        /// Optional. The source URI for application template revision.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplicationTemplate> ImportApplicationTemplateAsync(ApplicationTemplateName name, ApplicationTemplateRevisionName applicationTemplateRevisionUri, gaxgrpc::CallSettings callSettings = null) =>
            ImportApplicationTemplateAsync(new ImportApplicationTemplateRequest
            {
                ApplicationTemplateRevisionUriAsApplicationTemplateRevisionName = applicationTemplateRevisionUri,
                ApplicationTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Imports to an existing application template from a given shared template.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="applicationTemplateRevisionUri">
        /// Optional. The source URI for application template revision.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplicationTemplate> ImportApplicationTemplateAsync(ApplicationTemplateName name, ApplicationTemplateRevisionName applicationTemplateRevisionUri, st::CancellationToken cancellationToken) =>
            ImportApplicationTemplateAsync(name, applicationTemplateRevisionUri, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteApplicationTemplate(DeleteApplicationTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApplicationTemplateAsync(DeleteApplicationTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApplicationTemplateAsync(DeleteApplicationTemplateRequest request, st::CancellationToken cancellationToken) =>
            DeleteApplicationTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an application template.
        /// </summary>
        /// <param name="name">
        /// Required. The application template name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteApplicationTemplate(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApplicationTemplate(new DeleteApplicationTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an application template.
        /// </summary>
        /// <param name="name">
        /// Required. The application template name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApplicationTemplateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApplicationTemplateAsync(new DeleteApplicationTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an application template.
        /// </summary>
        /// <param name="name">
        /// Required. The application template name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApplicationTemplateAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteApplicationTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an application template.
        /// </summary>
        /// <param name="name">
        /// Required. The application template name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteApplicationTemplate(ApplicationTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApplicationTemplate(new DeleteApplicationTemplateRequest
            {
                ApplicationTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an application template.
        /// </summary>
        /// <param name="name">
        /// Required. The application template name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApplicationTemplateAsync(ApplicationTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApplicationTemplateAsync(new DeleteApplicationTemplateRequest
            {
                ApplicationTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an application template.
        /// </summary>
        /// <param name="name">
        /// Required. The application template name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApplicationTemplateAsync(ApplicationTemplateName name, st::CancellationToken cancellationToken) =>
            DeleteApplicationTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Commits an application template to create a new revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApplicationTemplateRevision CommitApplicationTemplate(CommitApplicationTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Commits an application template to create a new revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplicationTemplateRevision> CommitApplicationTemplateAsync(CommitApplicationTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Commits an application template to create a new revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplicationTemplateRevision> CommitApplicationTemplateAsync(CommitApplicationTemplateRequest request, st::CancellationToken cancellationToken) =>
            CommitApplicationTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Commits an application template to create a new revision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApplicationTemplateRevision CommitApplicationTemplate(string name, gaxgrpc::CallSettings callSettings = null) =>
            CommitApplicationTemplate(new CommitApplicationTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Commits an application template to create a new revision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplicationTemplateRevision> CommitApplicationTemplateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            CommitApplicationTemplateAsync(new CommitApplicationTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Commits an application template to create a new revision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplicationTemplateRevision> CommitApplicationTemplateAsync(string name, st::CancellationToken cancellationToken) =>
            CommitApplicationTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Commits an application template to create a new revision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApplicationTemplateRevision CommitApplicationTemplate(ApplicationTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            CommitApplicationTemplate(new CommitApplicationTemplateRequest
            {
                ApplicationTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Commits an application template to create a new revision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplicationTemplateRevision> CommitApplicationTemplateAsync(ApplicationTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            CommitApplicationTemplateAsync(new CommitApplicationTemplateRequest
            {
                ApplicationTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Commits an application template to create a new revision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplicationTemplateRevision> CommitApplicationTemplateAsync(ApplicationTemplateName name, st::CancellationToken cancellationToken) =>
            CommitApplicationTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Snapshots an application template to create a new revision asynchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SnapshotApplicationTemplateResponse, OperationMetadata> SnapshotApplicationTemplate(SnapshotApplicationTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Snapshots an application template to create a new revision asynchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SnapshotApplicationTemplateResponse, OperationMetadata>> SnapshotApplicationTemplateAsync(SnapshotApplicationTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Snapshots an application template to create a new revision asynchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SnapshotApplicationTemplateResponse, OperationMetadata>> SnapshotApplicationTemplateAsync(SnapshotApplicationTemplateRequest request, st::CancellationToken cancellationToken) =>
            SnapshotApplicationTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SnapshotApplicationTemplate</c>.</summary>
        public virtual lro::OperationsClient SnapshotApplicationTemplateOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SnapshotApplicationTemplate</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<SnapshotApplicationTemplateResponse, OperationMetadata> PollOnceSnapshotApplicationTemplate(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SnapshotApplicationTemplateResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SnapshotApplicationTemplateOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SnapshotApplicationTemplate</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<SnapshotApplicationTemplateResponse, OperationMetadata>> PollOnceSnapshotApplicationTemplateAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<SnapshotApplicationTemplateResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SnapshotApplicationTemplateOperationsClient, callSettings);

        /// <summary>
        /// Snapshots an application template to create a new revision asynchronously.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SnapshotApplicationTemplateResponse, OperationMetadata> SnapshotApplicationTemplate(string name, gaxgrpc::CallSettings callSettings = null) =>
            SnapshotApplicationTemplate(new SnapshotApplicationTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Snapshots an application template to create a new revision asynchronously.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SnapshotApplicationTemplateResponse, OperationMetadata>> SnapshotApplicationTemplateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            SnapshotApplicationTemplateAsync(new SnapshotApplicationTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Snapshots an application template to create a new revision asynchronously.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SnapshotApplicationTemplateResponse, OperationMetadata>> SnapshotApplicationTemplateAsync(string name, st::CancellationToken cancellationToken) =>
            SnapshotApplicationTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Snapshots an application template to create a new revision asynchronously.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<SnapshotApplicationTemplateResponse, OperationMetadata> SnapshotApplicationTemplate(ApplicationTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            SnapshotApplicationTemplate(new SnapshotApplicationTemplateRequest
            {
                ApplicationTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Snapshots an application template to create a new revision asynchronously.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SnapshotApplicationTemplateResponse, OperationMetadata>> SnapshotApplicationTemplateAsync(ApplicationTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            SnapshotApplicationTemplateAsync(new SnapshotApplicationTemplateRequest
            {
                ApplicationTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Snapshots an application template to create a new revision asynchronously.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<SnapshotApplicationTemplateResponse, OperationMetadata>> SnapshotApplicationTemplateAsync(ApplicationTemplateName name, st::CancellationToken cancellationToken) =>
            SnapshotApplicationTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates Terraform files for an application template.
        /// This is a SYNCHRONOUS operation and returns the generated IaC
        /// directly in the response. It
        /// does NOT download external module sources; it only uses remote sources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateApplicationTemplateIaCResponse GenerateApplicationTemplateIaC(GenerateApplicationTemplateIaCRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates Terraform files for an application template.
        /// This is a SYNCHRONOUS operation and returns the generated IaC
        /// directly in the response. It
        /// does NOT download external module sources; it only uses remote sources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateApplicationTemplateIaCResponse> GenerateApplicationTemplateIaCAsync(GenerateApplicationTemplateIaCRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates Terraform files for an application template.
        /// This is a SYNCHRONOUS operation and returns the generated IaC
        /// directly in the response. It
        /// does NOT download external module sources; it only uses remote sources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateApplicationTemplateIaCResponse> GenerateApplicationTemplateIaCAsync(GenerateApplicationTemplateIaCRequest request, st::CancellationToken cancellationToken) =>
            GenerateApplicationTemplateIaCAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates Terraform files for an application template.
        /// This is a SYNCHRONOUS operation and returns the generated IaC
        /// directly in the response. It
        /// does NOT download external module sources; it only uses remote sources.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateApplicationTemplateIaCResponse GenerateApplicationTemplateIaC(string name, gaxgrpc::CallSettings callSettings = null) =>
            GenerateApplicationTemplateIaC(new GenerateApplicationTemplateIaCRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Generates Terraform files for an application template.
        /// This is a SYNCHRONOUS operation and returns the generated IaC
        /// directly in the response. It
        /// does NOT download external module sources; it only uses remote sources.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateApplicationTemplateIaCResponse> GenerateApplicationTemplateIaCAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GenerateApplicationTemplateIaCAsync(new GenerateApplicationTemplateIaCRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Generates Terraform files for an application template.
        /// This is a SYNCHRONOUS operation and returns the generated IaC
        /// directly in the response. It
        /// does NOT download external module sources; it only uses remote sources.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateApplicationTemplateIaCResponse> GenerateApplicationTemplateIaCAsync(string name, st::CancellationToken cancellationToken) =>
            GenerateApplicationTemplateIaCAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates Terraform files for an application template.
        /// This is a SYNCHRONOUS operation and returns the generated IaC
        /// directly in the response. It
        /// does NOT download external module sources; it only uses remote sources.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateApplicationTemplateIaCResponse GenerateApplicationTemplateIaC(ApplicationTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            GenerateApplicationTemplateIaC(new GenerateApplicationTemplateIaCRequest
            {
                ApplicationTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Generates Terraform files for an application template.
        /// This is a SYNCHRONOUS operation and returns the generated IaC
        /// directly in the response. It
        /// does NOT download external module sources; it only uses remote sources.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateApplicationTemplateIaCResponse> GenerateApplicationTemplateIaCAsync(ApplicationTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            GenerateApplicationTemplateIaCAsync(new GenerateApplicationTemplateIaCRequest
            {
                ApplicationTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Generates Terraform files for an application template.
        /// This is a SYNCHRONOUS operation and returns the generated IaC
        /// directly in the response. It
        /// does NOT download external module sources; it only uses remote sources.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateApplicationTemplateIaCResponse> GenerateApplicationTemplateIaCAsync(ApplicationTemplateName name, st::CancellationToken cancellationToken) =>
            GenerateApplicationTemplateIaCAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports Terraform files for an application template. The generated
        /// modules can have remote sources or local sources downloaded from remote.
        /// This is an ASYNCHRONOUS operation that returns a Long Running Operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportApplicationTemplateIaCResponse, OperationMetadata> ExportApplicationTemplateIaC(ExportApplicationTemplateIaCRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports Terraform files for an application template. The generated
        /// modules can have remote sources or local sources downloaded from remote.
        /// This is an ASYNCHRONOUS operation that returns a Long Running Operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportApplicationTemplateIaCResponse, OperationMetadata>> ExportApplicationTemplateIaCAsync(ExportApplicationTemplateIaCRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports Terraform files for an application template. The generated
        /// modules can have remote sources or local sources downloaded from remote.
        /// This is an ASYNCHRONOUS operation that returns a Long Running Operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportApplicationTemplateIaCResponse, OperationMetadata>> ExportApplicationTemplateIaCAsync(ExportApplicationTemplateIaCRequest request, st::CancellationToken cancellationToken) =>
            ExportApplicationTemplateIaCAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExportApplicationTemplateIaC</c>.</summary>
        public virtual lro::OperationsClient ExportApplicationTemplateIaCOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportApplicationTemplateIaC</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ExportApplicationTemplateIaCResponse, OperationMetadata> PollOnceExportApplicationTemplateIaC(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportApplicationTemplateIaCResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportApplicationTemplateIaCOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportApplicationTemplateIaC</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ExportApplicationTemplateIaCResponse, OperationMetadata>> PollOnceExportApplicationTemplateIaCAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportApplicationTemplateIaCResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportApplicationTemplateIaCOperationsClient, callSettings);

        /// <summary>
        /// Exports Terraform files for an application template. The generated
        /// modules can have remote sources or local sources downloaded from remote.
        /// This is an ASYNCHRONOUS operation that returns a Long Running Operation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportApplicationTemplateIaCResponse, OperationMetadata> ExportApplicationTemplateIaC(string name, gaxgrpc::CallSettings callSettings = null) =>
            ExportApplicationTemplateIaC(new ExportApplicationTemplateIaCRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Exports Terraform files for an application template. The generated
        /// modules can have remote sources or local sources downloaded from remote.
        /// This is an ASYNCHRONOUS operation that returns a Long Running Operation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportApplicationTemplateIaCResponse, OperationMetadata>> ExportApplicationTemplateIaCAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ExportApplicationTemplateIaCAsync(new ExportApplicationTemplateIaCRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Exports Terraform files for an application template. The generated
        /// modules can have remote sources or local sources downloaded from remote.
        /// This is an ASYNCHRONOUS operation that returns a Long Running Operation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportApplicationTemplateIaCResponse, OperationMetadata>> ExportApplicationTemplateIaCAsync(string name, st::CancellationToken cancellationToken) =>
            ExportApplicationTemplateIaCAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports Terraform files for an application template. The generated
        /// modules can have remote sources or local sources downloaded from remote.
        /// This is an ASYNCHRONOUS operation that returns a Long Running Operation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportApplicationTemplateIaCResponse, OperationMetadata> ExportApplicationTemplateIaC(ApplicationTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            ExportApplicationTemplateIaC(new ExportApplicationTemplateIaCRequest
            {
                ApplicationTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Exports Terraform files for an application template. The generated
        /// modules can have remote sources or local sources downloaded from remote.
        /// This is an ASYNCHRONOUS operation that returns a Long Running Operation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportApplicationTemplateIaCResponse, OperationMetadata>> ExportApplicationTemplateIaCAsync(ApplicationTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            ExportApplicationTemplateIaCAsync(new ExportApplicationTemplateIaCRequest
            {
                ApplicationTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Exports Terraform files for an application template. The generated
        /// modules can have remote sources or local sources downloaded from remote.
        /// This is an ASYNCHRONOUS operation that returns a Long Running Operation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportApplicationTemplateIaCResponse, OperationMetadata>> ExportApplicationTemplateIaCAsync(ApplicationTemplateName name, st::CancellationToken cancellationToken) =>
            ExportApplicationTemplateIaCAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates Terraform files for an application template revision.
        /// This is a SYNCHRONOUS operation and returns the generated IaC
        /// directly in the response. It
        /// does NOT download external module sources; it only uses remote sources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateApplicationTemplateRevisionIaCResponse GenerateApplicationTemplateRevisionIaC(GenerateApplicationTemplateRevisionIaCRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates Terraform files for an application template revision.
        /// This is a SYNCHRONOUS operation and returns the generated IaC
        /// directly in the response. It
        /// does NOT download external module sources; it only uses remote sources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateApplicationTemplateRevisionIaCResponse> GenerateApplicationTemplateRevisionIaCAsync(GenerateApplicationTemplateRevisionIaCRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates Terraform files for an application template revision.
        /// This is a SYNCHRONOUS operation and returns the generated IaC
        /// directly in the response. It
        /// does NOT download external module sources; it only uses remote sources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateApplicationTemplateRevisionIaCResponse> GenerateApplicationTemplateRevisionIaCAsync(GenerateApplicationTemplateRevisionIaCRequest request, st::CancellationToken cancellationToken) =>
            GenerateApplicationTemplateRevisionIaCAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates Terraform files for an application template revision.
        /// This is a SYNCHRONOUS operation and returns the generated IaC
        /// directly in the response. It
        /// does NOT download external module sources; it only uses remote sources.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template revision.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateApplicationTemplateRevisionIaCResponse GenerateApplicationTemplateRevisionIaC(string name, gaxgrpc::CallSettings callSettings = null) =>
            GenerateApplicationTemplateRevisionIaC(new GenerateApplicationTemplateRevisionIaCRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Generates Terraform files for an application template revision.
        /// This is a SYNCHRONOUS operation and returns the generated IaC
        /// directly in the response. It
        /// does NOT download external module sources; it only uses remote sources.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template revision.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateApplicationTemplateRevisionIaCResponse> GenerateApplicationTemplateRevisionIaCAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GenerateApplicationTemplateRevisionIaCAsync(new GenerateApplicationTemplateRevisionIaCRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Generates Terraform files for an application template revision.
        /// This is a SYNCHRONOUS operation and returns the generated IaC
        /// directly in the response. It
        /// does NOT download external module sources; it only uses remote sources.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template revision.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateApplicationTemplateRevisionIaCResponse> GenerateApplicationTemplateRevisionIaCAsync(string name, st::CancellationToken cancellationToken) =>
            GenerateApplicationTemplateRevisionIaCAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates Terraform files for an application template revision.
        /// This is a SYNCHRONOUS operation and returns the generated IaC
        /// directly in the response. It
        /// does NOT download external module sources; it only uses remote sources.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template revision.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateApplicationTemplateRevisionIaCResponse GenerateApplicationTemplateRevisionIaC(ApplicationTemplateRevisionName name, gaxgrpc::CallSettings callSettings = null) =>
            GenerateApplicationTemplateRevisionIaC(new GenerateApplicationTemplateRevisionIaCRequest
            {
                ApplicationTemplateRevisionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Generates Terraform files for an application template revision.
        /// This is a SYNCHRONOUS operation and returns the generated IaC
        /// directly in the response. It
        /// does NOT download external module sources; it only uses remote sources.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template revision.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateApplicationTemplateRevisionIaCResponse> GenerateApplicationTemplateRevisionIaCAsync(ApplicationTemplateRevisionName name, gaxgrpc::CallSettings callSettings = null) =>
            GenerateApplicationTemplateRevisionIaCAsync(new GenerateApplicationTemplateRevisionIaCRequest
            {
                ApplicationTemplateRevisionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Generates Terraform files for an application template revision.
        /// This is a SYNCHRONOUS operation and returns the generated IaC
        /// directly in the response. It
        /// does NOT download external module sources; it only uses remote sources.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template revision.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateApplicationTemplateRevisionIaCResponse> GenerateApplicationTemplateRevisionIaCAsync(ApplicationTemplateRevisionName name, st::CancellationToken cancellationToken) =>
            GenerateApplicationTemplateRevisionIaCAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports Terraform files for an application template revision. The generated
        /// modules can have remote sources or local sources downloaded from remote.
        /// This is an ASYNCHRONOUS operation that returns a Long Running Operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportApplicationTemplateRevisionIaCResponse, OperationMetadata> ExportApplicationTemplateRevisionIaC(ExportApplicationTemplateRevisionIaCRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports Terraform files for an application template revision. The generated
        /// modules can have remote sources or local sources downloaded from remote.
        /// This is an ASYNCHRONOUS operation that returns a Long Running Operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportApplicationTemplateRevisionIaCResponse, OperationMetadata>> ExportApplicationTemplateRevisionIaCAsync(ExportApplicationTemplateRevisionIaCRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports Terraform files for an application template revision. The generated
        /// modules can have remote sources or local sources downloaded from remote.
        /// This is an ASYNCHRONOUS operation that returns a Long Running Operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportApplicationTemplateRevisionIaCResponse, OperationMetadata>> ExportApplicationTemplateRevisionIaCAsync(ExportApplicationTemplateRevisionIaCRequest request, st::CancellationToken cancellationToken) =>
            ExportApplicationTemplateRevisionIaCAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExportApplicationTemplateRevisionIaC</c>.</summary>
        public virtual lro::OperationsClient ExportApplicationTemplateRevisionIaCOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportApplicationTemplateRevisionIaC</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ExportApplicationTemplateRevisionIaCResponse, OperationMetadata> PollOnceExportApplicationTemplateRevisionIaC(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportApplicationTemplateRevisionIaCResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportApplicationTemplateRevisionIaCOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportApplicationTemplateRevisionIaC</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ExportApplicationTemplateRevisionIaCResponse, OperationMetadata>> PollOnceExportApplicationTemplateRevisionIaCAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportApplicationTemplateRevisionIaCResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportApplicationTemplateRevisionIaCOperationsClient, callSettings);

        /// <summary>
        /// Exports Terraform files for an application template revision. The generated
        /// modules can have remote sources or local sources downloaded from remote.
        /// This is an ASYNCHRONOUS operation that returns a Long Running Operation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template revision.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportApplicationTemplateRevisionIaCResponse, OperationMetadata> ExportApplicationTemplateRevisionIaC(string name, gaxgrpc::CallSettings callSettings = null) =>
            ExportApplicationTemplateRevisionIaC(new ExportApplicationTemplateRevisionIaCRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Exports Terraform files for an application template revision. The generated
        /// modules can have remote sources or local sources downloaded from remote.
        /// This is an ASYNCHRONOUS operation that returns a Long Running Operation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template revision.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportApplicationTemplateRevisionIaCResponse, OperationMetadata>> ExportApplicationTemplateRevisionIaCAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ExportApplicationTemplateRevisionIaCAsync(new ExportApplicationTemplateRevisionIaCRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Exports Terraform files for an application template revision. The generated
        /// modules can have remote sources or local sources downloaded from remote.
        /// This is an ASYNCHRONOUS operation that returns a Long Running Operation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template revision.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportApplicationTemplateRevisionIaCResponse, OperationMetadata>> ExportApplicationTemplateRevisionIaCAsync(string name, st::CancellationToken cancellationToken) =>
            ExportApplicationTemplateRevisionIaCAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports Terraform files for an application template revision. The generated
        /// modules can have remote sources or local sources downloaded from remote.
        /// This is an ASYNCHRONOUS operation that returns a Long Running Operation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template revision.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportApplicationTemplateRevisionIaCResponse, OperationMetadata> ExportApplicationTemplateRevisionIaC(ApplicationTemplateRevisionName name, gaxgrpc::CallSettings callSettings = null) =>
            ExportApplicationTemplateRevisionIaC(new ExportApplicationTemplateRevisionIaCRequest
            {
                ApplicationTemplateRevisionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Exports Terraform files for an application template revision. The generated
        /// modules can have remote sources or local sources downloaded from remote.
        /// This is an ASYNCHRONOUS operation that returns a Long Running Operation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template revision.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportApplicationTemplateRevisionIaCResponse, OperationMetadata>> ExportApplicationTemplateRevisionIaCAsync(ApplicationTemplateRevisionName name, gaxgrpc::CallSettings callSettings = null) =>
            ExportApplicationTemplateRevisionIaCAsync(new ExportApplicationTemplateRevisionIaCRequest
            {
                ApplicationTemplateRevisionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Exports Terraform files for an application template revision. The generated
        /// modules can have remote sources or local sources downloaded from remote.
        /// This is an ASYNCHRONOUS operation that returns a Long Running Operation.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template revision.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportApplicationTemplateRevisionIaCResponse, OperationMetadata>> ExportApplicationTemplateRevisionIaCAsync(ApplicationTemplateRevisionName name, st::CancellationToken cancellationToken) =>
            ExportApplicationTemplateRevisionIaCAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a Component.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Component GetComponent(GetComponentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about a Component.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Component> GetComponentAsync(GetComponentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about a Component.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Component> GetComponentAsync(GetComponentRequest request, st::CancellationToken cancellationToken) =>
            GetComponentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a Component.
        /// </summary>
        /// <param name="name">
        /// Required. The component name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Component GetComponent(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetComponent(new GetComponentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a Component.
        /// </summary>
        /// <param name="name">
        /// Required. The component name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Component> GetComponentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetComponentAsync(new GetComponentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a Component.
        /// </summary>
        /// <param name="name">
        /// Required. The component name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Component> GetComponentAsync(string name, st::CancellationToken cancellationToken) =>
            GetComponentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a Component.
        /// </summary>
        /// <param name="name">
        /// Required. The component name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Component GetComponent(ComponentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetComponent(new GetComponentRequest
            {
                ComponentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a Component.
        /// </summary>
        /// <param name="name">
        /// Required. The component name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Component> GetComponentAsync(ComponentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetComponentAsync(new GetComponentRequest
            {
                ComponentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a Component.
        /// </summary>
        /// <param name="name">
        /// Required. The component name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Component> GetComponentAsync(ComponentName name, st::CancellationToken cancellationToken) =>
            GetComponentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists components in an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Component"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListComponentsResponse, Component> ListComponents(ListComponentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists components in an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Component"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListComponentsResponse, Component> ListComponentsAsync(ListComponentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists components in an application template.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource from which the list of components is
        /// requested.
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
        /// <returns>A pageable sequence of <see cref="Component"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListComponentsResponse, Component> ListComponents(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListComponentsRequest request = new ListComponentsRequest
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
            return ListComponents(request, callSettings);
        }

        /// <summary>
        /// Lists components in an application template.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource from which the list of components is
        /// requested.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Component"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListComponentsResponse, Component> ListComponentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListComponentsRequest request = new ListComponentsRequest
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
            return ListComponentsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists components in an application template.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource from which the list of components is
        /// requested.
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
        /// <returns>A pageable sequence of <see cref="Component"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListComponentsResponse, Component> ListComponents(ApplicationTemplateName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListComponentsRequest request = new ListComponentsRequest
            {
                ParentAsApplicationTemplateName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListComponents(request, callSettings);
        }

        /// <summary>
        /// Lists components in an application template.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource from which the list of components is
        /// requested.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Component"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListComponentsResponse, Component> ListComponentsAsync(ApplicationTemplateName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListComponentsRequest request = new ListComponentsRequest
            {
                ParentAsApplicationTemplateName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListComponentsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a component.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Component CreateComponent(CreateComponentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a component.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Component> CreateComponentAsync(CreateComponentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a component.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Component> CreateComponentAsync(CreateComponentRequest request, st::CancellationToken cancellationToken) =>
            CreateComponentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a component.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the component.
        /// </param>
        /// <param name="component">
        /// Required. The component to create.
        /// </param>
        /// <param name="componentId">
        /// Required. The ID of the component to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Component CreateComponent(string parent, Component component, string componentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateComponent(new CreateComponentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ComponentId = gax::GaxPreconditions.CheckNotNullOrEmpty(componentId, nameof(componentId)),
                Component = gax::GaxPreconditions.CheckNotNull(component, nameof(component)),
            }, callSettings);

        /// <summary>
        /// Creates a component.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the component.
        /// </param>
        /// <param name="component">
        /// Required. The component to create.
        /// </param>
        /// <param name="componentId">
        /// Required. The ID of the component to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Component> CreateComponentAsync(string parent, Component component, string componentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateComponentAsync(new CreateComponentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ComponentId = gax::GaxPreconditions.CheckNotNullOrEmpty(componentId, nameof(componentId)),
                Component = gax::GaxPreconditions.CheckNotNull(component, nameof(component)),
            }, callSettings);

        /// <summary>
        /// Creates a component.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the component.
        /// </param>
        /// <param name="component">
        /// Required. The component to create.
        /// </param>
        /// <param name="componentId">
        /// Required. The ID of the component to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Component> CreateComponentAsync(string parent, Component component, string componentId, st::CancellationToken cancellationToken) =>
            CreateComponentAsync(parent, component, componentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a component.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the component.
        /// </param>
        /// <param name="component">
        /// Required. The component to create.
        /// </param>
        /// <param name="componentId">
        /// Required. The ID of the component to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Component CreateComponent(ApplicationTemplateName parent, Component component, string componentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateComponent(new CreateComponentRequest
            {
                ParentAsApplicationTemplateName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ComponentId = gax::GaxPreconditions.CheckNotNullOrEmpty(componentId, nameof(componentId)),
                Component = gax::GaxPreconditions.CheckNotNull(component, nameof(component)),
            }, callSettings);

        /// <summary>
        /// Creates a component.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the component.
        /// </param>
        /// <param name="component">
        /// Required. The component to create.
        /// </param>
        /// <param name="componentId">
        /// Required. The ID of the component to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Component> CreateComponentAsync(ApplicationTemplateName parent, Component component, string componentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateComponentAsync(new CreateComponentRequest
            {
                ParentAsApplicationTemplateName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ComponentId = gax::GaxPreconditions.CheckNotNullOrEmpty(componentId, nameof(componentId)),
                Component = gax::GaxPreconditions.CheckNotNull(component, nameof(component)),
            }, callSettings);

        /// <summary>
        /// Creates a component.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the component.
        /// </param>
        /// <param name="component">
        /// Required. The component to create.
        /// </param>
        /// <param name="componentId">
        /// Required. The ID of the component to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Component> CreateComponentAsync(ApplicationTemplateName parent, Component component, string componentId, st::CancellationToken cancellationToken) =>
            CreateComponentAsync(parent, component, componentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a component.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Component UpdateComponent(UpdateComponentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a component.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Component> UpdateComponentAsync(UpdateComponentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a component.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Component> UpdateComponentAsync(UpdateComponentRequest request, st::CancellationToken cancellationToken) =>
            UpdateComponentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a component.
        /// </summary>
        /// <param name="component">
        /// Required. The component to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The fields to overwrite in the component update. If you don't
        /// provide a mask, all fields are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Component UpdateComponent(Component component, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateComponent(new UpdateComponentRequest
            {
                UpdateMask = updateMask,
                Component = gax::GaxPreconditions.CheckNotNull(component, nameof(component)),
            }, callSettings);

        /// <summary>
        /// Updates a component.
        /// </summary>
        /// <param name="component">
        /// Required. The component to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The fields to overwrite in the component update. If you don't
        /// provide a mask, all fields are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Component> UpdateComponentAsync(Component component, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateComponentAsync(new UpdateComponentRequest
            {
                UpdateMask = updateMask,
                Component = gax::GaxPreconditions.CheckNotNull(component, nameof(component)),
            }, callSettings);

        /// <summary>
        /// Updates a component.
        /// </summary>
        /// <param name="component">
        /// Required. The component to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The fields to overwrite in the component update. If you don't
        /// provide a mask, all fields are overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Component> UpdateComponentAsync(Component component, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateComponentAsync(component, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a component.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteComponent(DeleteComponentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a component.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteComponentAsync(DeleteComponentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a component.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteComponentAsync(DeleteComponentRequest request, st::CancellationToken cancellationToken) =>
            DeleteComponentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a component.
        /// </summary>
        /// <param name="name">
        /// Required. The component name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteComponent(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteComponent(new DeleteComponentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a component.
        /// </summary>
        /// <param name="name">
        /// Required. The component name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteComponentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteComponentAsync(new DeleteComponentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a component.
        /// </summary>
        /// <param name="name">
        /// Required. The component name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteComponentAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteComponentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a component.
        /// </summary>
        /// <param name="name">
        /// Required. The component name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteComponent(ComponentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteComponent(new DeleteComponentRequest
            {
                ComponentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a component.
        /// </summary>
        /// <param name="name">
        /// Required. The component name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteComponentAsync(ComponentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteComponentAsync(new DeleteComponentRequest
            {
                ComponentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a component.
        /// </summary>
        /// <param name="name">
        /// Required. The component name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteComponentAsync(ComponentName name, st::CancellationToken cancellationToken) =>
            DeleteComponentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Connection GetConnection(GetConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about a connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> GetConnectionAsync(GetConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about a connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> GetConnectionAsync(GetConnectionRequest request, st::CancellationToken cancellationToken) =>
            GetConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a connection.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Connection GetConnection(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnection(new GetConnectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a connection.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> GetConnectionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectionAsync(new GetConnectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a connection.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> GetConnectionAsync(string name, st::CancellationToken cancellationToken) =>
            GetConnectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a connection.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Connection GetConnection(ConnectionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnection(new GetConnectionRequest
            {
                ConnectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a connection.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> GetConnectionAsync(ConnectionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetConnectionAsync(new GetConnectionRequest
            {
                ConnectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a connection.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> GetConnectionAsync(ConnectionName name, st::CancellationToken cancellationToken) =>
            GetConnectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists connections in an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Connection"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListConnectionsResponse, Connection> ListConnections(ListConnectionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists connections in an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Connection"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListConnectionsResponse, Connection> ListConnectionsAsync(ListConnectionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists connections in an application template.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource from which to request a list of connections.
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
        /// Lists connections in an application template.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource from which to request a list of connections.
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
        /// Lists connections in an application template.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource from which to request a list of connections.
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
        public virtual gax::PagedEnumerable<ListConnectionsResponse, Connection> ListConnections(ComponentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectionsRequest request = new ListConnectionsRequest
            {
                ParentAsComponentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Lists connections in an application template.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource from which to request a list of connections.
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
        public virtual gax::PagedAsyncEnumerable<ListConnectionsResponse, Connection> ListConnectionsAsync(ComponentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListConnectionsRequest request = new ListConnectionsRequest
            {
                ParentAsComponentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Creates a connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Connection CreateConnection(CreateConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> CreateConnectionAsync(CreateConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> CreateConnectionAsync(CreateConnectionRequest request, st::CancellationToken cancellationToken) =>
            CreateConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a connection.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create a connection.
        /// </param>
        /// <param name="connection">
        /// Required. The connection to create.
        /// </param>
        /// <param name="connectionId">
        /// Required. The ID of the connection to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Connection CreateConnection(string parent, Connection connection, string connectionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnection(new CreateConnectionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ConnectionId = gax::GaxPreconditions.CheckNotNullOrEmpty(connectionId, nameof(connectionId)),
                Connection = gax::GaxPreconditions.CheckNotNull(connection, nameof(connection)),
            }, callSettings);

        /// <summary>
        /// Creates a connection.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create a connection.
        /// </param>
        /// <param name="connection">
        /// Required. The connection to create.
        /// </param>
        /// <param name="connectionId">
        /// Required. The ID of the connection to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> CreateConnectionAsync(string parent, Connection connection, string connectionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnectionAsync(new CreateConnectionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ConnectionId = gax::GaxPreconditions.CheckNotNullOrEmpty(connectionId, nameof(connectionId)),
                Connection = gax::GaxPreconditions.CheckNotNull(connection, nameof(connection)),
            }, callSettings);

        /// <summary>
        /// Creates a connection.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create a connection.
        /// </param>
        /// <param name="connection">
        /// Required. The connection to create.
        /// </param>
        /// <param name="connectionId">
        /// Required. The ID of the connection to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> CreateConnectionAsync(string parent, Connection connection, string connectionId, st::CancellationToken cancellationToken) =>
            CreateConnectionAsync(parent, connection, connectionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a connection.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create a connection.
        /// </param>
        /// <param name="connection">
        /// Required. The connection to create.
        /// </param>
        /// <param name="connectionId">
        /// Required. The ID of the connection to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Connection CreateConnection(ComponentName parent, Connection connection, string connectionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnection(new CreateConnectionRequest
            {
                ParentAsComponentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ConnectionId = gax::GaxPreconditions.CheckNotNullOrEmpty(connectionId, nameof(connectionId)),
                Connection = gax::GaxPreconditions.CheckNotNull(connection, nameof(connection)),
            }, callSettings);

        /// <summary>
        /// Creates a connection.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create a connection.
        /// </param>
        /// <param name="connection">
        /// Required. The connection to create.
        /// </param>
        /// <param name="connectionId">
        /// Required. The ID of the connection to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> CreateConnectionAsync(ComponentName parent, Connection connection, string connectionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateConnectionAsync(new CreateConnectionRequest
            {
                ParentAsComponentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ConnectionId = gax::GaxPreconditions.CheckNotNullOrEmpty(connectionId, nameof(connectionId)),
                Connection = gax::GaxPreconditions.CheckNotNull(connection, nameof(connection)),
            }, callSettings);

        /// <summary>
        /// Creates a connection.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create a connection.
        /// </param>
        /// <param name="connection">
        /// Required. The connection to create.
        /// </param>
        /// <param name="connectionId">
        /// Required. The ID of the connection to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> CreateConnectionAsync(ComponentName parent, Connection connection, string connectionId, st::CancellationToken cancellationToken) =>
            CreateConnectionAsync(parent, connection, connectionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Connection UpdateConnection(UpdateConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> UpdateConnectionAsync(UpdateConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> UpdateConnectionAsync(UpdateConnectionRequest request, st::CancellationToken cancellationToken) =>
            UpdateConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a connection.
        /// </summary>
        /// <param name="connection">
        /// Required. The connection to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Fields to overwrite in the connection update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If you
        /// don't provide a mask, all fields are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Connection UpdateConnection(Connection connection, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConnection(new UpdateConnectionRequest
            {
                UpdateMask = updateMask,
                Connection = gax::GaxPreconditions.CheckNotNull(connection, nameof(connection)),
            }, callSettings);

        /// <summary>
        /// Updates a connection.
        /// </summary>
        /// <param name="connection">
        /// Required. The connection to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Fields to overwrite in the connection update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If you
        /// don't provide a mask, all fields are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> UpdateConnectionAsync(Connection connection, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateConnectionAsync(new UpdateConnectionRequest
            {
                UpdateMask = updateMask,
                Connection = gax::GaxPreconditions.CheckNotNull(connection, nameof(connection)),
            }, callSettings);

        /// <summary>
        /// Updates a connection.
        /// </summary>
        /// <param name="connection">
        /// Required. The connection to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Fields to overwrite in the connection update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If you
        /// don't provide a mask, all fields are overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Connection> UpdateConnectionAsync(Connection connection, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateConnectionAsync(connection, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteConnection(DeleteConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConnectionAsync(DeleteConnectionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConnectionAsync(DeleteConnectionRequest request, st::CancellationToken cancellationToken) =>
            DeleteConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a connection.
        /// </summary>
        /// <param name="name">
        /// Required. The connection name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteConnection(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnection(new DeleteConnectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a connection.
        /// </summary>
        /// <param name="name">
        /// Required. The connection name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConnectionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnectionAsync(new DeleteConnectionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a connection.
        /// </summary>
        /// <param name="name">
        /// Required. The connection name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConnectionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteConnectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a connection.
        /// </summary>
        /// <param name="name">
        /// Required. The connection name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteConnection(ConnectionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnection(new DeleteConnectionRequest
            {
                ConnectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a connection.
        /// </summary>
        /// <param name="name">
        /// Required. The connection name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConnectionAsync(ConnectionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteConnectionAsync(new DeleteConnectionRequest
            {
                ConnectionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a connection.
        /// </summary>
        /// <param name="name">
        /// Required. The connection name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteConnectionAsync(ConnectionName name, st::CancellationToken cancellationToken) =>
            DeleteConnectionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about an application template revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApplicationTemplateRevision GetApplicationTemplateRevision(GetApplicationTemplateRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about an application template revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplicationTemplateRevision> GetApplicationTemplateRevisionAsync(GetApplicationTemplateRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about an application template revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplicationTemplateRevision> GetApplicationTemplateRevisionAsync(GetApplicationTemplateRevisionRequest request, st::CancellationToken cancellationToken) =>
            GetApplicationTemplateRevisionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about an application template revision.
        /// </summary>
        /// <param name="name">
        /// Required. The application template revision name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApplicationTemplateRevision GetApplicationTemplateRevision(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetApplicationTemplateRevision(new GetApplicationTemplateRevisionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about an application template revision.
        /// </summary>
        /// <param name="name">
        /// Required. The application template revision name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplicationTemplateRevision> GetApplicationTemplateRevisionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetApplicationTemplateRevisionAsync(new GetApplicationTemplateRevisionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about an application template revision.
        /// </summary>
        /// <param name="name">
        /// Required. The application template revision name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplicationTemplateRevision> GetApplicationTemplateRevisionAsync(string name, st::CancellationToken cancellationToken) =>
            GetApplicationTemplateRevisionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about an application template revision.
        /// </summary>
        /// <param name="name">
        /// Required. The application template revision name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApplicationTemplateRevision GetApplicationTemplateRevision(ApplicationTemplateRevisionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetApplicationTemplateRevision(new GetApplicationTemplateRevisionRequest
            {
                ApplicationTemplateRevisionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about an application template revision.
        /// </summary>
        /// <param name="name">
        /// Required. The application template revision name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplicationTemplateRevision> GetApplicationTemplateRevisionAsync(ApplicationTemplateRevisionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetApplicationTemplateRevisionAsync(new GetApplicationTemplateRevisionRequest
            {
                ApplicationTemplateRevisionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about an application template revision.
        /// </summary>
        /// <param name="name">
        /// Required. The application template revision name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplicationTemplateRevision> GetApplicationTemplateRevisionAsync(ApplicationTemplateRevisionName name, st::CancellationToken cancellationToken) =>
            GetApplicationTemplateRevisionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists application template revisions in a given application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ApplicationTemplateRevision"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApplicationTemplateRevisionsResponse, ApplicationTemplateRevision> ListApplicationTemplateRevisions(ListApplicationTemplateRevisionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists application template revisions in a given application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ApplicationTemplateRevision"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApplicationTemplateRevisionsResponse, ApplicationTemplateRevision> ListApplicationTemplateRevisionsAsync(ListApplicationTemplateRevisionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists application template revisions in a given application template.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent from which to list application template revisions.
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
        /// <returns>A pageable sequence of <see cref="ApplicationTemplateRevision"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApplicationTemplateRevisionsResponse, ApplicationTemplateRevision> ListApplicationTemplateRevisions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApplicationTemplateRevisionsRequest request = new ListApplicationTemplateRevisionsRequest
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
            return ListApplicationTemplateRevisions(request, callSettings);
        }

        /// <summary>
        /// Lists application template revisions in a given application template.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent from which to list application template revisions.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ApplicationTemplateRevision"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApplicationTemplateRevisionsResponse, ApplicationTemplateRevision> ListApplicationTemplateRevisionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApplicationTemplateRevisionsRequest request = new ListApplicationTemplateRevisionsRequest
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
            return ListApplicationTemplateRevisionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists application template revisions in a given application template.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent from which to list application template revisions.
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
        /// <returns>A pageable sequence of <see cref="ApplicationTemplateRevision"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApplicationTemplateRevisionsResponse, ApplicationTemplateRevision> ListApplicationTemplateRevisions(ApplicationTemplateName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApplicationTemplateRevisionsRequest request = new ListApplicationTemplateRevisionsRequest
            {
                ParentAsApplicationTemplateName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListApplicationTemplateRevisions(request, callSettings);
        }

        /// <summary>
        /// Lists application template revisions in a given application template.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent from which to list application template revisions.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ApplicationTemplateRevision"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApplicationTemplateRevisionsResponse, ApplicationTemplateRevision> ListApplicationTemplateRevisionsAsync(ApplicationTemplateName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApplicationTemplateRevisionsRequest request = new ListApplicationTemplateRevisionsRequest
            {
                ParentAsApplicationTemplateName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListApplicationTemplateRevisionsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes an application template revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteApplicationTemplateRevision(DeleteApplicationTemplateRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an application template revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApplicationTemplateRevisionAsync(DeleteApplicationTemplateRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an application template revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApplicationTemplateRevisionAsync(DeleteApplicationTemplateRevisionRequest request, st::CancellationToken cancellationToken) =>
            DeleteApplicationTemplateRevisionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an application template revision.
        /// </summary>
        /// <param name="name">
        /// Required. The application template revision name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteApplicationTemplateRevision(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApplicationTemplateRevision(new DeleteApplicationTemplateRevisionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an application template revision.
        /// </summary>
        /// <param name="name">
        /// Required. The application template revision name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApplicationTemplateRevisionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApplicationTemplateRevisionAsync(new DeleteApplicationTemplateRevisionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an application template revision.
        /// </summary>
        /// <param name="name">
        /// Required. The application template revision name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApplicationTemplateRevisionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteApplicationTemplateRevisionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an application template revision.
        /// </summary>
        /// <param name="name">
        /// Required. The application template revision name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteApplicationTemplateRevision(ApplicationTemplateRevisionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApplicationTemplateRevision(new DeleteApplicationTemplateRevisionRequest
            {
                ApplicationTemplateRevisionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an application template revision.
        /// </summary>
        /// <param name="name">
        /// Required. The application template revision name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApplicationTemplateRevisionAsync(ApplicationTemplateRevisionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApplicationTemplateRevisionAsync(new DeleteApplicationTemplateRevisionRequest
            {
                ApplicationTemplateRevisionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an application template revision.
        /// </summary>
        /// <param name="name">
        /// Required. The application template revision name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteApplicationTemplateRevisionAsync(ApplicationTemplateRevisionName name, st::CancellationToken cancellationToken) =>
            DeleteApplicationTemplateRevisionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Catalog GetCatalog(GetCatalogRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about a catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Catalog> GetCatalogAsync(GetCatalogRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about a catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Catalog> GetCatalogAsync(GetCatalogRequest request, st::CancellationToken cancellationToken) =>
            GetCatalogAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a catalog.
        /// </summary>
        /// <param name="name">
        /// Required. The catalog name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Catalog GetCatalog(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCatalog(new GetCatalogRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a catalog.
        /// </summary>
        /// <param name="name">
        /// Required. The catalog name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Catalog> GetCatalogAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCatalogAsync(new GetCatalogRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a catalog.
        /// </summary>
        /// <param name="name">
        /// Required. The catalog name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Catalog> GetCatalogAsync(string name, st::CancellationToken cancellationToken) =>
            GetCatalogAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a catalog.
        /// </summary>
        /// <param name="name">
        /// Required. The catalog name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Catalog GetCatalog(CatalogName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCatalog(new GetCatalogRequest
            {
                CatalogName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a catalog.
        /// </summary>
        /// <param name="name">
        /// Required. The catalog name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Catalog> GetCatalogAsync(CatalogName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCatalogAsync(new GetCatalogRequest
            {
                CatalogName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a catalog.
        /// </summary>
        /// <param name="name">
        /// Required. The catalog name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Catalog> GetCatalogAsync(CatalogName name, st::CancellationToken cancellationToken) =>
            GetCatalogAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists catalogs in a given space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Catalog"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCatalogsResponse, Catalog> ListCatalogs(ListCatalogsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists catalogs in a given space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Catalog"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCatalogsResponse, Catalog> ListCatalogsAsync(ListCatalogsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists catalogs in a given space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent space from which catalogs are listed.
        /// Format: `projects/$project/locations/$location/spaces/$space`
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
        /// <returns>A pageable sequence of <see cref="Catalog"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCatalogsResponse, Catalog> ListCatalogs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCatalogsRequest request = new ListCatalogsRequest
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
            return ListCatalogs(request, callSettings);
        }

        /// <summary>
        /// Lists catalogs in a given space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent space from which catalogs are listed.
        /// Format: `projects/$project/locations/$location/spaces/$space`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Catalog"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCatalogsResponse, Catalog> ListCatalogsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCatalogsRequest request = new ListCatalogsRequest
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
            return ListCatalogsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists catalogs in a given space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent space from which catalogs are listed.
        /// Format: `projects/$project/locations/$location/spaces/$space`
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
        /// <returns>A pageable sequence of <see cref="Catalog"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCatalogsResponse, Catalog> ListCatalogs(SpaceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCatalogsRequest request = new ListCatalogsRequest
            {
                ParentAsSpaceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCatalogs(request, callSettings);
        }

        /// <summary>
        /// Lists catalogs in a given space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent space from which catalogs are listed.
        /// Format: `projects/$project/locations/$location/spaces/$space`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Catalog"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCatalogsResponse, Catalog> ListCatalogsAsync(SpaceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCatalogsRequest request = new ListCatalogsRequest
            {
                ParentAsSpaceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCatalogsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Catalog CreateCatalog(CreateCatalogRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Catalog> CreateCatalogAsync(CreateCatalogRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Catalog> CreateCatalogAsync(CreateCatalogRequest request, st::CancellationToken cancellationToken) =>
            CreateCatalogAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a catalog.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent space in which a catalog is created in the following
        /// format: `projects/$project/locations/$location/spaces/$space`
        /// </param>
        /// <param name="catalog">
        /// Required. The catalog to create.
        /// </param>
        /// <param name="catalogId">
        /// Required. The ID of the catalog to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Catalog CreateCatalog(string parent, Catalog catalog, string catalogId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCatalog(new CreateCatalogRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CatalogId = gax::GaxPreconditions.CheckNotNullOrEmpty(catalogId, nameof(catalogId)),
                Catalog = gax::GaxPreconditions.CheckNotNull(catalog, nameof(catalog)),
            }, callSettings);

        /// <summary>
        /// Creates a catalog.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent space in which a catalog is created in the following
        /// format: `projects/$project/locations/$location/spaces/$space`
        /// </param>
        /// <param name="catalog">
        /// Required. The catalog to create.
        /// </param>
        /// <param name="catalogId">
        /// Required. The ID of the catalog to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Catalog> CreateCatalogAsync(string parent, Catalog catalog, string catalogId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCatalogAsync(new CreateCatalogRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CatalogId = gax::GaxPreconditions.CheckNotNullOrEmpty(catalogId, nameof(catalogId)),
                Catalog = gax::GaxPreconditions.CheckNotNull(catalog, nameof(catalog)),
            }, callSettings);

        /// <summary>
        /// Creates a catalog.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent space in which a catalog is created in the following
        /// format: `projects/$project/locations/$location/spaces/$space`
        /// </param>
        /// <param name="catalog">
        /// Required. The catalog to create.
        /// </param>
        /// <param name="catalogId">
        /// Required. The ID of the catalog to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Catalog> CreateCatalogAsync(string parent, Catalog catalog, string catalogId, st::CancellationToken cancellationToken) =>
            CreateCatalogAsync(parent, catalog, catalogId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a catalog.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent space in which a catalog is created in the following
        /// format: `projects/$project/locations/$location/spaces/$space`
        /// </param>
        /// <param name="catalog">
        /// Required. The catalog to create.
        /// </param>
        /// <param name="catalogId">
        /// Required. The ID of the catalog to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Catalog CreateCatalog(SpaceName parent, Catalog catalog, string catalogId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCatalog(new CreateCatalogRequest
            {
                ParentAsSpaceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CatalogId = gax::GaxPreconditions.CheckNotNullOrEmpty(catalogId, nameof(catalogId)),
                Catalog = gax::GaxPreconditions.CheckNotNull(catalog, nameof(catalog)),
            }, callSettings);

        /// <summary>
        /// Creates a catalog.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent space in which a catalog is created in the following
        /// format: `projects/$project/locations/$location/spaces/$space`
        /// </param>
        /// <param name="catalog">
        /// Required. The catalog to create.
        /// </param>
        /// <param name="catalogId">
        /// Required. The ID of the catalog to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Catalog> CreateCatalogAsync(SpaceName parent, Catalog catalog, string catalogId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCatalogAsync(new CreateCatalogRequest
            {
                ParentAsSpaceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CatalogId = gax::GaxPreconditions.CheckNotNullOrEmpty(catalogId, nameof(catalogId)),
                Catalog = gax::GaxPreconditions.CheckNotNull(catalog, nameof(catalog)),
            }, callSettings);

        /// <summary>
        /// Creates a catalog.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent space in which a catalog is created in the following
        /// format: `projects/$project/locations/$location/spaces/$space`
        /// </param>
        /// <param name="catalog">
        /// Required. The catalog to create.
        /// </param>
        /// <param name="catalogId">
        /// Required. The ID of the catalog to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Catalog> CreateCatalogAsync(SpaceName parent, Catalog catalog, string catalogId, st::CancellationToken cancellationToken) =>
            CreateCatalogAsync(parent, catalog, catalogId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Catalog UpdateCatalog(UpdateCatalogRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Catalog> UpdateCatalogAsync(UpdateCatalogRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Catalog> UpdateCatalogAsync(UpdateCatalogRequest request, st::CancellationToken cancellationToken) =>
            UpdateCatalogAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a catalog.
        /// </summary>
        /// <param name="catalog">
        /// Required. The catalog to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The fields to overwrite in the catalog update. If you don't
        /// provide a mask, all fields are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Catalog UpdateCatalog(Catalog catalog, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCatalog(new UpdateCatalogRequest
            {
                UpdateMask = updateMask,
                Catalog = gax::GaxPreconditions.CheckNotNull(catalog, nameof(catalog)),
            }, callSettings);

        /// <summary>
        /// Updates a catalog.
        /// </summary>
        /// <param name="catalog">
        /// Required. The catalog to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The fields to overwrite in the catalog update. If you don't
        /// provide a mask, all fields are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Catalog> UpdateCatalogAsync(Catalog catalog, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCatalogAsync(new UpdateCatalogRequest
            {
                UpdateMask = updateMask,
                Catalog = gax::GaxPreconditions.CheckNotNull(catalog, nameof(catalog)),
            }, callSettings);

        /// <summary>
        /// Updates a catalog.
        /// </summary>
        /// <param name="catalog">
        /// Required. The catalog to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The fields to overwrite in the catalog update. If you don't
        /// provide a mask, all fields are overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Catalog> UpdateCatalogAsync(Catalog catalog, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateCatalogAsync(catalog, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCatalog(DeleteCatalogRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCatalogAsync(DeleteCatalogRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCatalogAsync(DeleteCatalogRequest request, st::CancellationToken cancellationToken) =>
            DeleteCatalogAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteCatalog</c>.</summary>
        public virtual lro::OperationsClient DeleteCatalogOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteCatalog</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteCatalog(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteCatalogOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteCatalog</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteCatalogAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteCatalogOperationsClient, callSettings);

        /// <summary>
        /// Deletes a catalog.
        /// </summary>
        /// <param name="name">
        /// Required. The catalog name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCatalog(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCatalog(new DeleteCatalogRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a catalog.
        /// </summary>
        /// <param name="name">
        /// Required. The catalog name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCatalogAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCatalogAsync(new DeleteCatalogRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a catalog.
        /// </summary>
        /// <param name="name">
        /// Required. The catalog name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCatalogAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteCatalogAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a catalog.
        /// </summary>
        /// <param name="name">
        /// Required. The catalog name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCatalog(CatalogName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCatalog(new DeleteCatalogRequest
            {
                CatalogName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a catalog.
        /// </summary>
        /// <param name="name">
        /// Required. The catalog name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCatalogAsync(CatalogName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCatalogAsync(new DeleteCatalogRequest
            {
                CatalogName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a catalog.
        /// </summary>
        /// <param name="name">
        /// Required. The catalog name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCatalogAsync(CatalogName name, st::CancellationToken cancellationToken) =>
            DeleteCatalogAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a template to a catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CatalogTemplate CreateCatalogTemplate(CreateCatalogTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a template to a catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CatalogTemplate> CreateCatalogTemplateAsync(CreateCatalogTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds a template to a catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CatalogTemplate> CreateCatalogTemplateAsync(CreateCatalogTemplateRequest request, st::CancellationToken cancellationToken) =>
            CreateCatalogTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a template to a catalog.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which the catalog template is created.
        /// </param>
        /// <param name="catalogTemplate">
        /// Required. The catalog template to create.
        /// </param>
        /// <param name="catalogTemplateId">
        /// Required. The ID of the catalog template to create. The ID is appended to
        /// the catalog template's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CatalogTemplate CreateCatalogTemplate(string parent, CatalogTemplate catalogTemplate, string catalogTemplateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCatalogTemplate(new CreateCatalogTemplateRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CatalogTemplateId = gax::GaxPreconditions.CheckNotNullOrEmpty(catalogTemplateId, nameof(catalogTemplateId)),
                CatalogTemplate = gax::GaxPreconditions.CheckNotNull(catalogTemplate, nameof(catalogTemplate)),
            }, callSettings);

        /// <summary>
        /// Adds a template to a catalog.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which the catalog template is created.
        /// </param>
        /// <param name="catalogTemplate">
        /// Required. The catalog template to create.
        /// </param>
        /// <param name="catalogTemplateId">
        /// Required. The ID of the catalog template to create. The ID is appended to
        /// the catalog template's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CatalogTemplate> CreateCatalogTemplateAsync(string parent, CatalogTemplate catalogTemplate, string catalogTemplateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCatalogTemplateAsync(new CreateCatalogTemplateRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CatalogTemplateId = gax::GaxPreconditions.CheckNotNullOrEmpty(catalogTemplateId, nameof(catalogTemplateId)),
                CatalogTemplate = gax::GaxPreconditions.CheckNotNull(catalogTemplate, nameof(catalogTemplate)),
            }, callSettings);

        /// <summary>
        /// Adds a template to a catalog.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which the catalog template is created.
        /// </param>
        /// <param name="catalogTemplate">
        /// Required. The catalog template to create.
        /// </param>
        /// <param name="catalogTemplateId">
        /// Required. The ID of the catalog template to create. The ID is appended to
        /// the catalog template's name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CatalogTemplate> CreateCatalogTemplateAsync(string parent, CatalogTemplate catalogTemplate, string catalogTemplateId, st::CancellationToken cancellationToken) =>
            CreateCatalogTemplateAsync(parent, catalogTemplate, catalogTemplateId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds a template to a catalog.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which the catalog template is created.
        /// </param>
        /// <param name="catalogTemplate">
        /// Required. The catalog template to create.
        /// </param>
        /// <param name="catalogTemplateId">
        /// Required. The ID of the catalog template to create. The ID is appended to
        /// the catalog template's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CatalogTemplate CreateCatalogTemplate(CatalogName parent, CatalogTemplate catalogTemplate, string catalogTemplateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCatalogTemplate(new CreateCatalogTemplateRequest
            {
                ParentAsCatalogName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CatalogTemplateId = gax::GaxPreconditions.CheckNotNullOrEmpty(catalogTemplateId, nameof(catalogTemplateId)),
                CatalogTemplate = gax::GaxPreconditions.CheckNotNull(catalogTemplate, nameof(catalogTemplate)),
            }, callSettings);

        /// <summary>
        /// Adds a template to a catalog.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which the catalog template is created.
        /// </param>
        /// <param name="catalogTemplate">
        /// Required. The catalog template to create.
        /// </param>
        /// <param name="catalogTemplateId">
        /// Required. The ID of the catalog template to create. The ID is appended to
        /// the catalog template's name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CatalogTemplate> CreateCatalogTemplateAsync(CatalogName parent, CatalogTemplate catalogTemplate, string catalogTemplateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCatalogTemplateAsync(new CreateCatalogTemplateRequest
            {
                ParentAsCatalogName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CatalogTemplateId = gax::GaxPreconditions.CheckNotNullOrEmpty(catalogTemplateId, nameof(catalogTemplateId)),
                CatalogTemplate = gax::GaxPreconditions.CheckNotNull(catalogTemplate, nameof(catalogTemplate)),
            }, callSettings);

        /// <summary>
        /// Adds a template to a catalog.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which the catalog template is created.
        /// </param>
        /// <param name="catalogTemplate">
        /// Required. The catalog template to create.
        /// </param>
        /// <param name="catalogTemplateId">
        /// Required. The ID of the catalog template to create. The ID is appended to
        /// the catalog template's name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CatalogTemplate> CreateCatalogTemplateAsync(CatalogName parent, CatalogTemplate catalogTemplate, string catalogTemplateId, st::CancellationToken cancellationToken) =>
            CreateCatalogTemplateAsync(parent, catalogTemplate, catalogTemplateId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a catalog template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CatalogTemplate GetCatalogTemplate(GetCatalogTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a catalog template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CatalogTemplate> GetCatalogTemplateAsync(GetCatalogTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a catalog template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CatalogTemplate> GetCatalogTemplateAsync(GetCatalogTemplateRequest request, st::CancellationToken cancellationToken) =>
            GetCatalogTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a catalog template.
        /// </summary>
        /// <param name="name">
        /// Required. The catalog template name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog/templates/$template`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CatalogTemplate GetCatalogTemplate(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCatalogTemplate(new GetCatalogTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a catalog template.
        /// </summary>
        /// <param name="name">
        /// Required. The catalog template name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog/templates/$template`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CatalogTemplate> GetCatalogTemplateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCatalogTemplateAsync(new GetCatalogTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a catalog template.
        /// </summary>
        /// <param name="name">
        /// Required. The catalog template name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog/templates/$template`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CatalogTemplate> GetCatalogTemplateAsync(string name, st::CancellationToken cancellationToken) =>
            GetCatalogTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a catalog template.
        /// </summary>
        /// <param name="name">
        /// Required. The catalog template name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog/templates/$template`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CatalogTemplate GetCatalogTemplate(CatalogTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCatalogTemplate(new GetCatalogTemplateRequest
            {
                CatalogTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a catalog template.
        /// </summary>
        /// <param name="name">
        /// Required. The catalog template name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog/templates/$template`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CatalogTemplate> GetCatalogTemplateAsync(CatalogTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCatalogTemplateAsync(new GetCatalogTemplateRequest
            {
                CatalogTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a catalog template.
        /// </summary>
        /// <param name="name">
        /// Required. The catalog template name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog/templates/$template`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CatalogTemplate> GetCatalogTemplateAsync(CatalogTemplateName name, st::CancellationToken cancellationToken) =>
            GetCatalogTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists catalog templates.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CatalogTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCatalogTemplatesResponse, CatalogTemplate> ListCatalogTemplates(ListCatalogTemplatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists catalog templates.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CatalogTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCatalogTemplatesResponse, CatalogTemplate> ListCatalogTemplatesAsync(ListCatalogTemplatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists catalog templates.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent from which the catalog templates are listed in the
        /// following format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog`
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
        /// <returns>A pageable sequence of <see cref="CatalogTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCatalogTemplatesResponse, CatalogTemplate> ListCatalogTemplates(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCatalogTemplatesRequest request = new ListCatalogTemplatesRequest
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
            return ListCatalogTemplates(request, callSettings);
        }

        /// <summary>
        /// Lists catalog templates.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent from which the catalog templates are listed in the
        /// following format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog`
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
        /// <returns>A pageable asynchronous sequence of <see cref="CatalogTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCatalogTemplatesResponse, CatalogTemplate> ListCatalogTemplatesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCatalogTemplatesRequest request = new ListCatalogTemplatesRequest
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
            return ListCatalogTemplatesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists catalog templates.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent from which the catalog templates are listed in the
        /// following format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog`
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
        /// <returns>A pageable sequence of <see cref="CatalogTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCatalogTemplatesResponse, CatalogTemplate> ListCatalogTemplates(CatalogName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCatalogTemplatesRequest request = new ListCatalogTemplatesRequest
            {
                ParentAsCatalogName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCatalogTemplates(request, callSettings);
        }

        /// <summary>
        /// Lists catalog templates.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent from which the catalog templates are listed in the
        /// following format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog`
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
        /// <returns>A pageable asynchronous sequence of <see cref="CatalogTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCatalogTemplatesResponse, CatalogTemplate> ListCatalogTemplatesAsync(CatalogName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCatalogTemplatesRequest request = new ListCatalogTemplatesRequest
            {
                ParentAsCatalogName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCatalogTemplatesAsync(request, callSettings);
        }

        /// <summary>
        /// Updates a catalog template resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CatalogTemplate UpdateCatalogTemplate(UpdateCatalogTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a catalog template resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CatalogTemplate> UpdateCatalogTemplateAsync(UpdateCatalogTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a catalog template resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CatalogTemplate> UpdateCatalogTemplateAsync(UpdateCatalogTemplateRequest request, st::CancellationToken cancellationToken) =>
            UpdateCatalogTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a catalog template resource.
        /// </summary>
        /// <param name="catalogTemplate">
        /// Required. The catalog template to update.
        /// Format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog/templates/$template`
        /// </param>
        /// <param name="updateMask">
        /// Optional. The fields to overwrite in the catalog template update. The
        /// fields specified in the update_mask are relative to the resource, not the
        /// full request. A field will be overwritten if it is in the mask. If you
        /// don't provide a mask, all fields are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CatalogTemplate UpdateCatalogTemplate(CatalogTemplate catalogTemplate, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCatalogTemplate(new UpdateCatalogTemplateRequest
            {
                CatalogTemplate = gax::GaxPreconditions.CheckNotNull(catalogTemplate, nameof(catalogTemplate)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a catalog template resource.
        /// </summary>
        /// <param name="catalogTemplate">
        /// Required. The catalog template to update.
        /// Format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog/templates/$template`
        /// </param>
        /// <param name="updateMask">
        /// Optional. The fields to overwrite in the catalog template update. The
        /// fields specified in the update_mask are relative to the resource, not the
        /// full request. A field will be overwritten if it is in the mask. If you
        /// don't provide a mask, all fields are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CatalogTemplate> UpdateCatalogTemplateAsync(CatalogTemplate catalogTemplate, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCatalogTemplateAsync(new UpdateCatalogTemplateRequest
            {
                CatalogTemplate = gax::GaxPreconditions.CheckNotNull(catalogTemplate, nameof(catalogTemplate)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates a catalog template resource.
        /// </summary>
        /// <param name="catalogTemplate">
        /// Required. The catalog template to update.
        /// Format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog/templates/$template`
        /// </param>
        /// <param name="updateMask">
        /// Optional. The fields to overwrite in the catalog template update. The
        /// fields specified in the update_mask are relative to the resource, not the
        /// full request. A field will be overwritten if it is in the mask. If you
        /// don't provide a mask, all fields are overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CatalogTemplate> UpdateCatalogTemplateAsync(CatalogTemplate catalogTemplate, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateCatalogTemplateAsync(catalogTemplate, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a catalog template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCatalogTemplate(DeleteCatalogTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a catalog template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCatalogTemplateAsync(DeleteCatalogTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a catalog template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCatalogTemplateAsync(DeleteCatalogTemplateRequest request, st::CancellationToken cancellationToken) =>
            DeleteCatalogTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteCatalogTemplate</c>.</summary>
        public virtual lro::OperationsClient DeleteCatalogTemplateOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteCatalogTemplate</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteCatalogTemplate(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteCatalogTemplateOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteCatalogTemplate</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteCatalogTemplateAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteCatalogTemplateOperationsClient, callSettings);

        /// <summary>
        /// Deletes a catalog template.
        /// </summary>
        /// <param name="name">
        /// Required. The catalog template name.
        /// Format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog/templates/$template`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCatalogTemplate(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCatalogTemplate(new DeleteCatalogTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a catalog template.
        /// </summary>
        /// <param name="name">
        /// Required. The catalog template name.
        /// Format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog/templates/$template`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCatalogTemplateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCatalogTemplateAsync(new DeleteCatalogTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a catalog template.
        /// </summary>
        /// <param name="name">
        /// Required. The catalog template name.
        /// Format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog/templates/$template`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCatalogTemplateAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteCatalogTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a catalog template.
        /// </summary>
        /// <param name="name">
        /// Required. The catalog template name.
        /// Format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog/templates/$template`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCatalogTemplate(CatalogTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCatalogTemplate(new DeleteCatalogTemplateRequest
            {
                CatalogTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a catalog template.
        /// </summary>
        /// <param name="name">
        /// Required. The catalog template name.
        /// Format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog/templates/$template`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCatalogTemplateAsync(CatalogTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCatalogTemplateAsync(new DeleteCatalogTemplateRequest
            {
                CatalogTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a catalog template.
        /// </summary>
        /// <param name="name">
        /// Required. The catalog template name.
        /// Format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog/templates/$template`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCatalogTemplateAsync(CatalogTemplateName name, st::CancellationToken cancellationToken) =>
            DeleteCatalogTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Shares a catalog from one space to another space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Share, OperationMetadata> CreateShare(CreateShareRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Shares a catalog from one space to another space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Share, OperationMetadata>> CreateShareAsync(CreateShareRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Shares a catalog from one space to another space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Share, OperationMetadata>> CreateShareAsync(CreateShareRequest request, st::CancellationToken cancellationToken) =>
            CreateShareAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateShare</c>.</summary>
        public virtual lro::OperationsClient CreateShareOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateShare</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Share, OperationMetadata> PollOnceCreateShare(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Share, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateShareOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateShare</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Share, OperationMetadata>> PollOnceCreateShareAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Share, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateShareOperationsClient, callSettings);

        /// <summary>
        /// Shares a catalog from one space to another space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which shares are created.
        /// </param>
        /// <param name="share">
        /// Required. The share to create.
        /// </param>
        /// <param name="shareId">
        /// Required. The ID of the share to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Share, OperationMetadata> CreateShare(string parent, Share share, string shareId, gaxgrpc::CallSettings callSettings = null) =>
            CreateShare(new CreateShareRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ShareId = gax::GaxPreconditions.CheckNotNullOrEmpty(shareId, nameof(shareId)),
                Share = gax::GaxPreconditions.CheckNotNull(share, nameof(share)),
            }, callSettings);

        /// <summary>
        /// Shares a catalog from one space to another space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which shares are created.
        /// </param>
        /// <param name="share">
        /// Required. The share to create.
        /// </param>
        /// <param name="shareId">
        /// Required. The ID of the share to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Share, OperationMetadata>> CreateShareAsync(string parent, Share share, string shareId, gaxgrpc::CallSettings callSettings = null) =>
            CreateShareAsync(new CreateShareRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ShareId = gax::GaxPreconditions.CheckNotNullOrEmpty(shareId, nameof(shareId)),
                Share = gax::GaxPreconditions.CheckNotNull(share, nameof(share)),
            }, callSettings);

        /// <summary>
        /// Shares a catalog from one space to another space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which shares are created.
        /// </param>
        /// <param name="share">
        /// Required. The share to create.
        /// </param>
        /// <param name="shareId">
        /// Required. The ID of the share to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Share, OperationMetadata>> CreateShareAsync(string parent, Share share, string shareId, st::CancellationToken cancellationToken) =>
            CreateShareAsync(parent, share, shareId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Shares a catalog from one space to another space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which shares are created.
        /// </param>
        /// <param name="share">
        /// Required. The share to create.
        /// </param>
        /// <param name="shareId">
        /// Required. The ID of the share to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Share, OperationMetadata> CreateShare(CatalogName parent, Share share, string shareId, gaxgrpc::CallSettings callSettings = null) =>
            CreateShare(new CreateShareRequest
            {
                ParentAsCatalogName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ShareId = gax::GaxPreconditions.CheckNotNullOrEmpty(shareId, nameof(shareId)),
                Share = gax::GaxPreconditions.CheckNotNull(share, nameof(share)),
            }, callSettings);

        /// <summary>
        /// Shares a catalog from one space to another space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which shares are created.
        /// </param>
        /// <param name="share">
        /// Required. The share to create.
        /// </param>
        /// <param name="shareId">
        /// Required. The ID of the share to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Share, OperationMetadata>> CreateShareAsync(CatalogName parent, Share share, string shareId, gaxgrpc::CallSettings callSettings = null) =>
            CreateShareAsync(new CreateShareRequest
            {
                ParentAsCatalogName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ShareId = gax::GaxPreconditions.CheckNotNullOrEmpty(shareId, nameof(shareId)),
                Share = gax::GaxPreconditions.CheckNotNull(share, nameof(share)),
            }, callSettings);

        /// <summary>
        /// Shares a catalog from one space to another space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which shares are created.
        /// </param>
        /// <param name="share">
        /// Required. The share to create.
        /// </param>
        /// <param name="shareId">
        /// Required. The ID of the share to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Share, OperationMetadata>> CreateShareAsync(CatalogName parent, Share share, string shareId, st::CancellationToken cancellationToken) =>
            CreateShareAsync(parent, share, shareId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists catalog share objects for the space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Share"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSharesResponse, Share> ListShares(ListSharesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists catalog share objects for the space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Share"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSharesResponse, Share> ListSharesAsync(ListSharesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists catalog share objects for the space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource from which a list of shares is requested.
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
        /// <returns>A pageable sequence of <see cref="Share"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSharesResponse, Share> ListShares(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSharesRequest request = new ListSharesRequest
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
            return ListShares(request, callSettings);
        }

        /// <summary>
        /// Lists catalog share objects for the space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource from which a list of shares is requested.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Share"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSharesResponse, Share> ListSharesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSharesRequest request = new ListSharesRequest
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
            return ListSharesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists catalog share objects for the space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource from which a list of shares is requested.
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
        /// <returns>A pageable sequence of <see cref="Share"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSharesResponse, Share> ListShares(CatalogName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSharesRequest request = new ListSharesRequest
            {
                ParentAsCatalogName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListShares(request, callSettings);
        }

        /// <summary>
        /// Lists catalog share objects for the space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource from which a list of shares is requested.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Share"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSharesResponse, Share> ListSharesAsync(CatalogName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSharesRequest request = new ListSharesRequest
            {
                ParentAsCatalogName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSharesAsync(request, callSettings);
        }

        /// <summary>
        /// Get catalog share object for the space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Share GetShare(GetShareRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get catalog share object for the space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Share> GetShareAsync(GetShareRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get catalog share object for the space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Share> GetShareAsync(GetShareRequest request, st::CancellationToken cancellationToken) =>
            GetShareAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get catalog share object for the space.
        /// </summary>
        /// <param name="name">
        /// Required. The share name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog/shares/$share`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Share GetShare(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetShare(new GetShareRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get catalog share object for the space.
        /// </summary>
        /// <param name="name">
        /// Required. The share name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog/shares/$share`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Share> GetShareAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetShareAsync(new GetShareRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get catalog share object for the space.
        /// </summary>
        /// <param name="name">
        /// Required. The share name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog/shares/$share`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Share> GetShareAsync(string name, st::CancellationToken cancellationToken) =>
            GetShareAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get catalog share object for the space.
        /// </summary>
        /// <param name="name">
        /// Required. The share name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog/shares/$share`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Share GetShare(ShareName name, gaxgrpc::CallSettings callSettings = null) =>
            GetShare(new GetShareRequest
            {
                ShareName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get catalog share object for the space.
        /// </summary>
        /// <param name="name">
        /// Required. The share name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog/shares/$share`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Share> GetShareAsync(ShareName name, gaxgrpc::CallSettings callSettings = null) =>
            GetShareAsync(new GetShareRequest
            {
                ShareName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get catalog share object for the space.
        /// </summary>
        /// <param name="name">
        /// Required. The share name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog/shares/$share`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Share> GetShareAsync(ShareName name, st::CancellationToken cancellationToken) =>
            GetShareAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a catalog share.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteShare(DeleteShareRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a catalog share.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteShareAsync(DeleteShareRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a catalog share.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteShareAsync(DeleteShareRequest request, st::CancellationToken cancellationToken) =>
            DeleteShareAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteShare</c>.</summary>
        public virtual lro::OperationsClient DeleteShareOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteShare</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteShare(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteShareOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteShare</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteShareAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteShareOperationsClient, callSettings);

        /// <summary>
        /// Deletes a catalog share.
        /// </summary>
        /// <param name="name">
        /// Required. The share name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog/shares/$share`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteShare(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteShare(new DeleteShareRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a catalog share.
        /// </summary>
        /// <param name="name">
        /// Required. The share name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog/shares/$share`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteShareAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteShareAsync(new DeleteShareRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a catalog share.
        /// </summary>
        /// <param name="name">
        /// Required. The share name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog/shares/$share`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteShareAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteShareAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a catalog share.
        /// </summary>
        /// <param name="name">
        /// Required. The share name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog/shares/$share`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteShare(ShareName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteShare(new DeleteShareRequest
            {
                ShareName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a catalog share.
        /// </summary>
        /// <param name="name">
        /// Required. The share name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog/shares/$share`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteShareAsync(ShareName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteShareAsync(new DeleteShareRequest
            {
                ShareName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a catalog share.
        /// </summary>
        /// <param name="name">
        /// Required. The share name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog/shares/$share`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteShareAsync(ShareName name, st::CancellationToken cancellationToken) =>
            DeleteShareAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Synchronizes a share and updates the destination workspace to reflect.
        /// reflect the most recent changes to the catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Share, OperationMetadata> SyncShare(SyncShareRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Synchronizes a share and updates the destination workspace to reflect.
        /// reflect the most recent changes to the catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Share, OperationMetadata>> SyncShareAsync(SyncShareRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Synchronizes a share and updates the destination workspace to reflect.
        /// reflect the most recent changes to the catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Share, OperationMetadata>> SyncShareAsync(SyncShareRequest request, st::CancellationToken cancellationToken) =>
            SyncShareAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SyncShare</c>.</summary>
        public virtual lro::OperationsClient SyncShareOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SyncShare</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Share, OperationMetadata> PollOnceSyncShare(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Share, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SyncShareOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SyncShare</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Share, OperationMetadata>> PollOnceSyncShareAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Share, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SyncShareOperationsClient, callSettings);

        /// <summary>
        /// Synchronizes a share and updates the destination workspace to reflect.
        /// reflect the most recent changes to the catalog.
        /// </summary>
        /// <param name="name">
        /// Required. The share name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog/shares/$share`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Share, OperationMetadata> SyncShare(string name, gaxgrpc::CallSettings callSettings = null) =>
            SyncShare(new SyncShareRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Synchronizes a share and updates the destination workspace to reflect.
        /// reflect the most recent changes to the catalog.
        /// </summary>
        /// <param name="name">
        /// Required. The share name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog/shares/$share`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Share, OperationMetadata>> SyncShareAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            SyncShareAsync(new SyncShareRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Synchronizes a share and updates the destination workspace to reflect.
        /// reflect the most recent changes to the catalog.
        /// </summary>
        /// <param name="name">
        /// Required. The share name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog/shares/$share`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Share, OperationMetadata>> SyncShareAsync(string name, st::CancellationToken cancellationToken) =>
            SyncShareAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Synchronizes a share and updates the destination workspace to reflect.
        /// reflect the most recent changes to the catalog.
        /// </summary>
        /// <param name="name">
        /// Required. The share name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog/shares/$share`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Share, OperationMetadata> SyncShare(ShareName name, gaxgrpc::CallSettings callSettings = null) =>
            SyncShare(new SyncShareRequest
            {
                ShareName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Synchronizes a share and updates the destination workspace to reflect.
        /// reflect the most recent changes to the catalog.
        /// </summary>
        /// <param name="name">
        /// Required. The share name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog/shares/$share`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Share, OperationMetadata>> SyncShareAsync(ShareName name, gaxgrpc::CallSettings callSettings = null) =>
            SyncShareAsync(new SyncShareRequest
            {
                ShareName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Synchronizes a share and updates the destination workspace to reflect.
        /// reflect the most recent changes to the catalog.
        /// </summary>
        /// <param name="name">
        /// Required. The share name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/catalogs/$catalog/shares/$share`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Share, OperationMetadata>> SyncShareAsync(ShareName name, st::CancellationToken cancellationToken) =>
            SyncShareAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a shared template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SharedTemplate GetSharedTemplate(GetSharedTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about a shared template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SharedTemplate> GetSharedTemplateAsync(GetSharedTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about a shared template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SharedTemplate> GetSharedTemplateAsync(GetSharedTemplateRequest request, st::CancellationToken cancellationToken) =>
            GetSharedTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a shared template.
        /// </summary>
        /// <param name="name">
        /// Required. The shared template name.
        /// Format:
        /// `projects/$project/locations/$location/spaces/$space/sharedTemplates/$sharedTemplate`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SharedTemplate GetSharedTemplate(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSharedTemplate(new GetSharedTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a shared template.
        /// </summary>
        /// <param name="name">
        /// Required. The shared template name.
        /// Format:
        /// `projects/$project/locations/$location/spaces/$space/sharedTemplates/$sharedTemplate`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SharedTemplate> GetSharedTemplateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSharedTemplateAsync(new GetSharedTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a shared template.
        /// </summary>
        /// <param name="name">
        /// Required. The shared template name.
        /// Format:
        /// `projects/$project/locations/$location/spaces/$space/sharedTemplates/$sharedTemplate`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SharedTemplate> GetSharedTemplateAsync(string name, st::CancellationToken cancellationToken) =>
            GetSharedTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a shared template.
        /// </summary>
        /// <param name="name">
        /// Required. The shared template name.
        /// Format:
        /// `projects/$project/locations/$location/spaces/$space/sharedTemplates/$sharedTemplate`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SharedTemplate GetSharedTemplate(SharedTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSharedTemplate(new GetSharedTemplateRequest
            {
                SharedTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a shared template.
        /// </summary>
        /// <param name="name">
        /// Required. The shared template name.
        /// Format:
        /// `projects/$project/locations/$location/spaces/$space/sharedTemplates/$sharedTemplate`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SharedTemplate> GetSharedTemplateAsync(SharedTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSharedTemplateAsync(new GetSharedTemplateRequest
            {
                SharedTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a shared template.
        /// </summary>
        /// <param name="name">
        /// Required. The shared template name.
        /// Format:
        /// `projects/$project/locations/$location/spaces/$space/sharedTemplates/$sharedTemplate`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SharedTemplate> GetSharedTemplateAsync(SharedTemplateName name, st::CancellationToken cancellationToken) =>
            GetSharedTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists shared templates in a given space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SharedTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSharedTemplatesResponse, SharedTemplate> ListSharedTemplates(ListSharedTemplatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists shared templates in a given space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SharedTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSharedTemplatesResponse, SharedTemplate> ListSharedTemplatesAsync(ListSharedTemplatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists shared templates in a given space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent space for which shared templates are listed in the
        /// following format: `projects/$project/locations/$location/spaces/$space`
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
        /// <returns>A pageable sequence of <see cref="SharedTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSharedTemplatesResponse, SharedTemplate> ListSharedTemplates(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSharedTemplatesRequest request = new ListSharedTemplatesRequest
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
            return ListSharedTemplates(request, callSettings);
        }

        /// <summary>
        /// Lists shared templates in a given space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent space for which shared templates are listed in the
        /// following format: `projects/$project/locations/$location/spaces/$space`
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
        /// <returns>A pageable asynchronous sequence of <see cref="SharedTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSharedTemplatesResponse, SharedTemplate> ListSharedTemplatesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSharedTemplatesRequest request = new ListSharedTemplatesRequest
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
            return ListSharedTemplatesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists shared templates in a given space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent space for which shared templates are listed in the
        /// following format: `projects/$project/locations/$location/spaces/$space`
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
        /// <returns>A pageable sequence of <see cref="SharedTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSharedTemplatesResponse, SharedTemplate> ListSharedTemplates(SpaceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSharedTemplatesRequest request = new ListSharedTemplatesRequest
            {
                ParentAsSpaceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSharedTemplates(request, callSettings);
        }

        /// <summary>
        /// Lists shared templates in a given space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent space for which shared templates are listed in the
        /// following format: `projects/$project/locations/$location/spaces/$space`
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
        /// <returns>A pageable asynchronous sequence of <see cref="SharedTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSharedTemplatesResponse, SharedTemplate> ListSharedTemplatesAsync(SpaceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSharedTemplatesRequest request = new ListSharedTemplatesRequest
            {
                ParentAsSpaceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSharedTemplatesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details about a shared template revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SharedTemplateRevision GetSharedTemplateRevision(GetSharedTemplateRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about a shared template revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SharedTemplateRevision> GetSharedTemplateRevisionAsync(GetSharedTemplateRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about a shared template revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SharedTemplateRevision> GetSharedTemplateRevisionAsync(GetSharedTemplateRevisionRequest request, st::CancellationToken cancellationToken) =>
            GetSharedTemplateRevisionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a shared template revision.
        /// </summary>
        /// <param name="name">
        /// Required. The shared template revision name, in the following format:
        /// `projects/$project/locations/$location/spaces/$space/sharedTemplates/$sharedTemplate/revisions/$revision`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SharedTemplateRevision GetSharedTemplateRevision(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSharedTemplateRevision(new GetSharedTemplateRevisionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a shared template revision.
        /// </summary>
        /// <param name="name">
        /// Required. The shared template revision name, in the following format:
        /// `projects/$project/locations/$location/spaces/$space/sharedTemplates/$sharedTemplate/revisions/$revision`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SharedTemplateRevision> GetSharedTemplateRevisionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSharedTemplateRevisionAsync(new GetSharedTemplateRevisionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a shared template revision.
        /// </summary>
        /// <param name="name">
        /// Required. The shared template revision name, in the following format:
        /// `projects/$project/locations/$location/spaces/$space/sharedTemplates/$sharedTemplate/revisions/$revision`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SharedTemplateRevision> GetSharedTemplateRevisionAsync(string name, st::CancellationToken cancellationToken) =>
            GetSharedTemplateRevisionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a shared template revision.
        /// </summary>
        /// <param name="name">
        /// Required. The shared template revision name, in the following format:
        /// `projects/$project/locations/$location/spaces/$space/sharedTemplates/$sharedTemplate/revisions/$revision`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SharedTemplateRevision GetSharedTemplateRevision(SharedTemplateRevisionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSharedTemplateRevision(new GetSharedTemplateRevisionRequest
            {
                SharedTemplateRevisionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a shared template revision.
        /// </summary>
        /// <param name="name">
        /// Required. The shared template revision name, in the following format:
        /// `projects/$project/locations/$location/spaces/$space/sharedTemplates/$sharedTemplate/revisions/$revision`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SharedTemplateRevision> GetSharedTemplateRevisionAsync(SharedTemplateRevisionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSharedTemplateRevisionAsync(new GetSharedTemplateRevisionRequest
            {
                SharedTemplateRevisionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a shared template revision.
        /// </summary>
        /// <param name="name">
        /// Required. The shared template revision name, in the following format:
        /// `projects/$project/locations/$location/spaces/$space/sharedTemplates/$sharedTemplate/revisions/$revision`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SharedTemplateRevision> GetSharedTemplateRevisionAsync(SharedTemplateRevisionName name, st::CancellationToken cancellationToken) =>
            GetSharedTemplateRevisionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists shared template revisions in a given space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SharedTemplateRevision"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSharedTemplateRevisionsResponse, SharedTemplateRevision> ListSharedTemplateRevisions(ListSharedTemplateRevisionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists shared template revisions in a given space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SharedTemplateRevision"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSharedTemplateRevisionsResponse, SharedTemplateRevision> ListSharedTemplateRevisionsAsync(ListSharedTemplateRevisionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists shared template revisions in a given space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource from which to list shared template revisions,
        /// in the following format:
        /// `projects/$project/locations/$location/spaces/$space/sharedTemplates/$sharedTemplate`
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
        /// <returns>A pageable sequence of <see cref="SharedTemplateRevision"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSharedTemplateRevisionsResponse, SharedTemplateRevision> ListSharedTemplateRevisions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSharedTemplateRevisionsRequest request = new ListSharedTemplateRevisionsRequest
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
            return ListSharedTemplateRevisions(request, callSettings);
        }

        /// <summary>
        /// Lists shared template revisions in a given space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource from which to list shared template revisions,
        /// in the following format:
        /// `projects/$project/locations/$location/spaces/$space/sharedTemplates/$sharedTemplate`
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
        /// <returns>A pageable asynchronous sequence of <see cref="SharedTemplateRevision"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSharedTemplateRevisionsResponse, SharedTemplateRevision> ListSharedTemplateRevisionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSharedTemplateRevisionsRequest request = new ListSharedTemplateRevisionsRequest
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
            return ListSharedTemplateRevisionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists shared template revisions in a given space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource from which to list shared template revisions,
        /// in the following format:
        /// `projects/$project/locations/$location/spaces/$space/sharedTemplates/$sharedTemplate`
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
        /// <returns>A pageable sequence of <see cref="SharedTemplateRevision"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSharedTemplateRevisionsResponse, SharedTemplateRevision> ListSharedTemplateRevisions(SharedTemplateName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSharedTemplateRevisionsRequest request = new ListSharedTemplateRevisionsRequest
            {
                ParentAsSharedTemplateName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSharedTemplateRevisions(request, callSettings);
        }

        /// <summary>
        /// Lists shared template revisions in a given space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource from which to list shared template revisions,
        /// in the following format:
        /// `projects/$project/locations/$location/spaces/$space/sharedTemplates/$sharedTemplate`
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
        /// <returns>A pageable asynchronous sequence of <see cref="SharedTemplateRevision"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSharedTemplateRevisionsResponse, SharedTemplateRevision> ListSharedTemplateRevisionsAsync(SharedTemplateName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSharedTemplateRevisionsRequest request = new ListSharedTemplateRevisionsRequest
            {
                ParentAsSharedTemplateName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSharedTemplateRevisionsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a template revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CatalogTemplateRevision, OperationMetadata> CreateCatalogTemplateRevision(CreateCatalogTemplateRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a template revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CatalogTemplateRevision, OperationMetadata>> CreateCatalogTemplateRevisionAsync(CreateCatalogTemplateRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a template revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CatalogTemplateRevision, OperationMetadata>> CreateCatalogTemplateRevisionAsync(CreateCatalogTemplateRevisionRequest request, st::CancellationToken cancellationToken) =>
            CreateCatalogTemplateRevisionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateCatalogTemplateRevision</c>.</summary>
        public virtual lro::OperationsClient CreateCatalogTemplateRevisionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateCatalogTemplateRevision</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CatalogTemplateRevision, OperationMetadata> PollOnceCreateCatalogTemplateRevision(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CatalogTemplateRevision, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateCatalogTemplateRevisionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateCatalogTemplateRevision</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CatalogTemplateRevision, OperationMetadata>> PollOnceCreateCatalogTemplateRevisionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CatalogTemplateRevision, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateCatalogTemplateRevisionOperationsClient, callSettings);

        /// <summary>
        /// Creates a template revision.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in which the catalog template revisions request is
        /// created in following format:
        /// `projects/$project/locations/$location/spaces/$space/templates/$template`
        /// </param>
        /// <param name="catalogTemplateRevision">
        /// Required. The template revision to create.
        /// </param>
        /// <param name="catalogTemplateRevisionId">
        /// Required. The ID of the template revision to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CatalogTemplateRevision, OperationMetadata> CreateCatalogTemplateRevision(string parent, CatalogTemplateRevision catalogTemplateRevision, string catalogTemplateRevisionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCatalogTemplateRevision(new CreateCatalogTemplateRevisionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CatalogTemplateRevisionId = gax::GaxPreconditions.CheckNotNullOrEmpty(catalogTemplateRevisionId, nameof(catalogTemplateRevisionId)),
                CatalogTemplateRevision = gax::GaxPreconditions.CheckNotNull(catalogTemplateRevision, nameof(catalogTemplateRevision)),
            }, callSettings);

        /// <summary>
        /// Creates a template revision.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in which the catalog template revisions request is
        /// created in following format:
        /// `projects/$project/locations/$location/spaces/$space/templates/$template`
        /// </param>
        /// <param name="catalogTemplateRevision">
        /// Required. The template revision to create.
        /// </param>
        /// <param name="catalogTemplateRevisionId">
        /// Required. The ID of the template revision to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CatalogTemplateRevision, OperationMetadata>> CreateCatalogTemplateRevisionAsync(string parent, CatalogTemplateRevision catalogTemplateRevision, string catalogTemplateRevisionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCatalogTemplateRevisionAsync(new CreateCatalogTemplateRevisionRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CatalogTemplateRevisionId = gax::GaxPreconditions.CheckNotNullOrEmpty(catalogTemplateRevisionId, nameof(catalogTemplateRevisionId)),
                CatalogTemplateRevision = gax::GaxPreconditions.CheckNotNull(catalogTemplateRevision, nameof(catalogTemplateRevision)),
            }, callSettings);

        /// <summary>
        /// Creates a template revision.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in which the catalog template revisions request is
        /// created in following format:
        /// `projects/$project/locations/$location/spaces/$space/templates/$template`
        /// </param>
        /// <param name="catalogTemplateRevision">
        /// Required. The template revision to create.
        /// </param>
        /// <param name="catalogTemplateRevisionId">
        /// Required. The ID of the template revision to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CatalogTemplateRevision, OperationMetadata>> CreateCatalogTemplateRevisionAsync(string parent, CatalogTemplateRevision catalogTemplateRevision, string catalogTemplateRevisionId, st::CancellationToken cancellationToken) =>
            CreateCatalogTemplateRevisionAsync(parent, catalogTemplateRevision, catalogTemplateRevisionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a template revision.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in which the catalog template revisions request is
        /// created in following format:
        /// `projects/$project/locations/$location/spaces/$space/templates/$template`
        /// </param>
        /// <param name="catalogTemplateRevision">
        /// Required. The template revision to create.
        /// </param>
        /// <param name="catalogTemplateRevisionId">
        /// Required. The ID of the template revision to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CatalogTemplateRevision, OperationMetadata> CreateCatalogTemplateRevision(CatalogTemplateName parent, CatalogTemplateRevision catalogTemplateRevision, string catalogTemplateRevisionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCatalogTemplateRevision(new CreateCatalogTemplateRevisionRequest
            {
                ParentAsCatalogTemplateName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CatalogTemplateRevisionId = gax::GaxPreconditions.CheckNotNullOrEmpty(catalogTemplateRevisionId, nameof(catalogTemplateRevisionId)),
                CatalogTemplateRevision = gax::GaxPreconditions.CheckNotNull(catalogTemplateRevision, nameof(catalogTemplateRevision)),
            }, callSettings);

        /// <summary>
        /// Creates a template revision.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in which the catalog template revisions request is
        /// created in following format:
        /// `projects/$project/locations/$location/spaces/$space/templates/$template`
        /// </param>
        /// <param name="catalogTemplateRevision">
        /// Required. The template revision to create.
        /// </param>
        /// <param name="catalogTemplateRevisionId">
        /// Required. The ID of the template revision to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CatalogTemplateRevision, OperationMetadata>> CreateCatalogTemplateRevisionAsync(CatalogTemplateName parent, CatalogTemplateRevision catalogTemplateRevision, string catalogTemplateRevisionId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCatalogTemplateRevisionAsync(new CreateCatalogTemplateRevisionRequest
            {
                ParentAsCatalogTemplateName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CatalogTemplateRevisionId = gax::GaxPreconditions.CheckNotNullOrEmpty(catalogTemplateRevisionId, nameof(catalogTemplateRevisionId)),
                CatalogTemplateRevision = gax::GaxPreconditions.CheckNotNull(catalogTemplateRevision, nameof(catalogTemplateRevision)),
            }, callSettings);

        /// <summary>
        /// Creates a template revision.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in which the catalog template revisions request is
        /// created in following format:
        /// `projects/$project/locations/$location/spaces/$space/templates/$template`
        /// </param>
        /// <param name="catalogTemplateRevision">
        /// Required. The template revision to create.
        /// </param>
        /// <param name="catalogTemplateRevisionId">
        /// Required. The ID of the template revision to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CatalogTemplateRevision, OperationMetadata>> CreateCatalogTemplateRevisionAsync(CatalogTemplateName parent, CatalogTemplateRevision catalogTemplateRevision, string catalogTemplateRevisionId, st::CancellationToken cancellationToken) =>
            CreateCatalogTemplateRevisionAsync(parent, catalogTemplateRevision, catalogTemplateRevisionId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a template revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CatalogTemplateRevision GetCatalogTemplateRevision(GetCatalogTemplateRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about a template revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CatalogTemplateRevision> GetCatalogTemplateRevisionAsync(GetCatalogTemplateRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about a template revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CatalogTemplateRevision> GetCatalogTemplateRevisionAsync(GetCatalogTemplateRevisionRequest request, st::CancellationToken cancellationToken) =>
            GetCatalogTemplateRevisionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a template revision.
        /// </summary>
        /// <param name="name">
        /// Required. The catalog template revisions name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CatalogTemplateRevision GetCatalogTemplateRevision(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCatalogTemplateRevision(new GetCatalogTemplateRevisionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a template revision.
        /// </summary>
        /// <param name="name">
        /// Required. The catalog template revisions name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CatalogTemplateRevision> GetCatalogTemplateRevisionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCatalogTemplateRevisionAsync(new GetCatalogTemplateRevisionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a template revision.
        /// </summary>
        /// <param name="name">
        /// Required. The catalog template revisions name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CatalogTemplateRevision> GetCatalogTemplateRevisionAsync(string name, st::CancellationToken cancellationToken) =>
            GetCatalogTemplateRevisionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a template revision.
        /// </summary>
        /// <param name="name">
        /// Required. The catalog template revisions name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CatalogTemplateRevision GetCatalogTemplateRevision(CatalogTemplateRevisionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCatalogTemplateRevision(new GetCatalogTemplateRevisionRequest
            {
                CatalogTemplateRevisionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a template revision.
        /// </summary>
        /// <param name="name">
        /// Required. The catalog template revisions name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CatalogTemplateRevision> GetCatalogTemplateRevisionAsync(CatalogTemplateRevisionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCatalogTemplateRevisionAsync(new GetCatalogTemplateRevisionRequest
            {
                CatalogTemplateRevisionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a template revision.
        /// </summary>
        /// <param name="name">
        /// Required. The catalog template revisions name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CatalogTemplateRevision> GetCatalogTemplateRevisionAsync(CatalogTemplateRevisionName name, st::CancellationToken cancellationToken) =>
            GetCatalogTemplateRevisionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists template revisions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CatalogTemplateRevision"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCatalogTemplateRevisionsResponse, CatalogTemplateRevision> ListCatalogTemplateRevisions(ListCatalogTemplateRevisionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists template revisions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CatalogTemplateRevision"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCatalogTemplateRevisionsResponse, CatalogTemplateRevision> ListCatalogTemplateRevisionsAsync(ListCatalogTemplateRevisionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists template revisions.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource from which a list of catalog template
        /// revisions is requested.
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
        /// <returns>A pageable sequence of <see cref="CatalogTemplateRevision"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCatalogTemplateRevisionsResponse, CatalogTemplateRevision> ListCatalogTemplateRevisions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCatalogTemplateRevisionsRequest request = new ListCatalogTemplateRevisionsRequest
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
            return ListCatalogTemplateRevisions(request, callSettings);
        }

        /// <summary>
        /// Lists template revisions.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource from which a list of catalog template
        /// revisions is requested.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CatalogTemplateRevision"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCatalogTemplateRevisionsResponse, CatalogTemplateRevision> ListCatalogTemplateRevisionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCatalogTemplateRevisionsRequest request = new ListCatalogTemplateRevisionsRequest
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
            return ListCatalogTemplateRevisionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists template revisions.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource from which a list of catalog template
        /// revisions is requested.
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
        /// <returns>A pageable sequence of <see cref="CatalogTemplateRevision"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCatalogTemplateRevisionsResponse, CatalogTemplateRevision> ListCatalogTemplateRevisions(CatalogTemplateName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCatalogTemplateRevisionsRequest request = new ListCatalogTemplateRevisionsRequest
            {
                ParentAsCatalogTemplateName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCatalogTemplateRevisions(request, callSettings);
        }

        /// <summary>
        /// Lists template revisions.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource from which a list of catalog template
        /// revisions is requested.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CatalogTemplateRevision"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCatalogTemplateRevisionsResponse, CatalogTemplateRevision> ListCatalogTemplateRevisionsAsync(CatalogTemplateName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCatalogTemplateRevisionsRequest request = new ListCatalogTemplateRevisionsRequest
            {
                ParentAsCatalogTemplateName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCatalogTemplateRevisionsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a template revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCatalogTemplateRevision(DeleteCatalogTemplateRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a template revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCatalogTemplateRevisionAsync(DeleteCatalogTemplateRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a template revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCatalogTemplateRevisionAsync(DeleteCatalogTemplateRevisionRequest request, st::CancellationToken cancellationToken) =>
            DeleteCatalogTemplateRevisionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteCatalogTemplateRevision</c>.</summary>
        public virtual lro::OperationsClient DeleteCatalogTemplateRevisionOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteCatalogTemplateRevision</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteCatalogTemplateRevision(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteCatalogTemplateRevisionOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteCatalogTemplateRevision</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteCatalogTemplateRevisionAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteCatalogTemplateRevisionOperationsClient, callSettings);

        /// <summary>
        /// Deletes a template revision.
        /// </summary>
        /// <param name="name">
        /// Required. The template revision name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCatalogTemplateRevision(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCatalogTemplateRevision(new DeleteCatalogTemplateRevisionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a template revision.
        /// </summary>
        /// <param name="name">
        /// Required. The template revision name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCatalogTemplateRevisionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCatalogTemplateRevisionAsync(new DeleteCatalogTemplateRevisionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a template revision.
        /// </summary>
        /// <param name="name">
        /// Required. The template revision name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCatalogTemplateRevisionAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteCatalogTemplateRevisionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a template revision.
        /// </summary>
        /// <param name="name">
        /// Required. The template revision name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCatalogTemplateRevision(CatalogTemplateRevisionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCatalogTemplateRevision(new DeleteCatalogTemplateRevisionRequest
            {
                CatalogTemplateRevisionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a template revision.
        /// </summary>
        /// <param name="name">
        /// Required. The template revision name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCatalogTemplateRevisionAsync(CatalogTemplateRevisionName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCatalogTemplateRevisionAsync(new DeleteCatalogTemplateRevisionRequest
            {
                CatalogTemplateRevisionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a template revision.
        /// </summary>
        /// <param name="name">
        /// Required. The template revision name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCatalogTemplateRevisionAsync(CatalogTemplateRevisionName name, st::CancellationToken cancellationToken) =>
            DeleteCatalogTemplateRevisionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Application CreateApplication(CreateApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> CreateApplicationAsync(CreateApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> CreateApplicationAsync(CreateApplicationRequest request, st::CancellationToken cancellationToken) =>
            CreateApplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an application.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the application.
        /// Format: `projects/$project/locations/$location/spaces/$space`
        /// </param>
        /// <param name="application">
        /// Required. The application to create.
        /// </param>
        /// <param name="applicationId">
        /// Required. The ID of the application to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Application CreateApplication(string parent, Application application, string applicationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApplication(new CreateApplicationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ApplicationId = gax::GaxPreconditions.CheckNotNullOrEmpty(applicationId, nameof(applicationId)),
                Application = gax::GaxPreconditions.CheckNotNull(application, nameof(application)),
            }, callSettings);

        /// <summary>
        /// Creates an application.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the application.
        /// Format: `projects/$project/locations/$location/spaces/$space`
        /// </param>
        /// <param name="application">
        /// Required. The application to create.
        /// </param>
        /// <param name="applicationId">
        /// Required. The ID of the application to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> CreateApplicationAsync(string parent, Application application, string applicationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApplicationAsync(new CreateApplicationRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ApplicationId = gax::GaxPreconditions.CheckNotNullOrEmpty(applicationId, nameof(applicationId)),
                Application = gax::GaxPreconditions.CheckNotNull(application, nameof(application)),
            }, callSettings);

        /// <summary>
        /// Creates an application.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the application.
        /// Format: `projects/$project/locations/$location/spaces/$space`
        /// </param>
        /// <param name="application">
        /// Required. The application to create.
        /// </param>
        /// <param name="applicationId">
        /// Required. The ID of the application to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> CreateApplicationAsync(string parent, Application application, string applicationId, st::CancellationToken cancellationToken) =>
            CreateApplicationAsync(parent, application, applicationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an application.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the application.
        /// Format: `projects/$project/locations/$location/spaces/$space`
        /// </param>
        /// <param name="application">
        /// Required. The application to create.
        /// </param>
        /// <param name="applicationId">
        /// Required. The ID of the application to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Application CreateApplication(SpaceName parent, Application application, string applicationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApplication(new CreateApplicationRequest
            {
                ParentAsSpaceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ApplicationId = gax::GaxPreconditions.CheckNotNullOrEmpty(applicationId, nameof(applicationId)),
                Application = gax::GaxPreconditions.CheckNotNull(application, nameof(application)),
            }, callSettings);

        /// <summary>
        /// Creates an application.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the application.
        /// Format: `projects/$project/locations/$location/spaces/$space`
        /// </param>
        /// <param name="application">
        /// Required. The application to create.
        /// </param>
        /// <param name="applicationId">
        /// Required. The ID of the application to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> CreateApplicationAsync(SpaceName parent, Application application, string applicationId, gaxgrpc::CallSettings callSettings = null) =>
            CreateApplicationAsync(new CreateApplicationRequest
            {
                ParentAsSpaceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ApplicationId = gax::GaxPreconditions.CheckNotNullOrEmpty(applicationId, nameof(applicationId)),
                Application = gax::GaxPreconditions.CheckNotNull(application, nameof(application)),
            }, callSettings);

        /// <summary>
        /// Creates an application.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the application.
        /// Format: `projects/$project/locations/$location/spaces/$space`
        /// </param>
        /// <param name="application">
        /// Required. The application to create.
        /// </param>
        /// <param name="applicationId">
        /// Required. The ID of the application to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> CreateApplicationAsync(SpaceName parent, Application application, string applicationId, st::CancellationToken cancellationToken) =>
            CreateApplicationAsync(parent, application, applicationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Application GetApplication(GetApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> GetApplicationAsync(GetApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> GetApplicationAsync(GetApplicationRequest request, st::CancellationToken cancellationToken) =>
            GetApplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about an application.
        /// </summary>
        /// <param name="name">
        /// Required. The application name.
        /// Format:
        /// `projects/$project/locations/$location/spaces/$space/applications/$application`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Application GetApplication(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetApplication(new GetApplicationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about an application.
        /// </summary>
        /// <param name="name">
        /// Required. The application name.
        /// Format:
        /// `projects/$project/locations/$location/spaces/$space/applications/$application`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> GetApplicationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetApplicationAsync(new GetApplicationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about an application.
        /// </summary>
        /// <param name="name">
        /// Required. The application name.
        /// Format:
        /// `projects/$project/locations/$location/spaces/$space/applications/$application`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> GetApplicationAsync(string name, st::CancellationToken cancellationToken) =>
            GetApplicationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about an application.
        /// </summary>
        /// <param name="name">
        /// Required. The application name.
        /// Format:
        /// `projects/$project/locations/$location/spaces/$space/applications/$application`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Application GetApplication(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetApplication(new GetApplicationRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about an application.
        /// </summary>
        /// <param name="name">
        /// Required. The application name.
        /// Format:
        /// `projects/$project/locations/$location/spaces/$space/applications/$application`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> GetApplicationAsync(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            GetApplicationAsync(new GetApplicationRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about an application.
        /// </summary>
        /// <param name="name">
        /// Required. The application name.
        /// Format:
        /// `projects/$project/locations/$location/spaces/$space/applications/$application`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> GetApplicationAsync(ApplicationName name, st::CancellationToken cancellationToken) =>
            GetApplicationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists applications in a given space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Application"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApplicationsResponse, Application> ListApplications(ListApplicationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists applications in a given space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Application"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApplicationsResponse, Application> ListApplicationsAsync(ListApplicationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists applications in a given space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource from which to request a list of applications.
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
        /// <returns>A pageable sequence of <see cref="Application"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApplicationsResponse, Application> ListApplications(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApplicationsRequest request = new ListApplicationsRequest
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
            return ListApplications(request, callSettings);
        }

        /// <summary>
        /// Lists applications in a given space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource from which to request a list of applications.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Application"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApplicationsResponse, Application> ListApplicationsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApplicationsRequest request = new ListApplicationsRequest
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
            return ListApplicationsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists applications in a given space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource from which to request a list of applications.
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
        /// <returns>A pageable sequence of <see cref="Application"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApplicationsResponse, Application> ListApplications(SpaceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApplicationsRequest request = new ListApplicationsRequest
            {
                ParentAsSpaceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListApplications(request, callSettings);
        }

        /// <summary>
        /// Lists applications in a given space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource from which to request a list of applications.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Application"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListApplicationsResponse, Application> ListApplicationsAsync(SpaceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApplicationsRequest request = new ListApplicationsRequest
            {
                ParentAsSpaceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListApplicationsAsync(request, callSettings);
        }

        /// <summary>
        /// Updates an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Application UpdateApplication(UpdateApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> UpdateApplicationAsync(UpdateApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> UpdateApplicationAsync(UpdateApplicationRequest request, st::CancellationToken cancellationToken) =>
            UpdateApplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an application.
        /// </summary>
        /// <param name="application">
        /// Required. The application to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The fields to overwrite in the application update. If you don't
        /// provide a mask, all fields are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Application UpdateApplication(Application application, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateApplication(new UpdateApplicationRequest
            {
                UpdateMask = updateMask,
                Application = gax::GaxPreconditions.CheckNotNull(application, nameof(application)),
            }, callSettings);

        /// <summary>
        /// Updates an application.
        /// </summary>
        /// <param name="application">
        /// Required. The application to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The fields to overwrite in the application update. If you don't
        /// provide a mask, all fields are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> UpdateApplicationAsync(Application application, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateApplicationAsync(new UpdateApplicationRequest
            {
                UpdateMask = updateMask,
                Application = gax::GaxPreconditions.CheckNotNull(application, nameof(application)),
            }, callSettings);

        /// <summary>
        /// Updates an application.
        /// </summary>
        /// <param name="application">
        /// Required. The application to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The fields to overwrite in the application update. If you don't
        /// provide a mask, all fields are overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Application> UpdateApplicationAsync(Application application, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateApplicationAsync(application, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteApplication(DeleteApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteApplicationAsync(DeleteApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteApplicationAsync(DeleteApplicationRequest request, st::CancellationToken cancellationToken) =>
            DeleteApplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteApplication</c>.</summary>
        public virtual lro::OperationsClient DeleteApplicationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteApplication</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteApplication(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteApplicationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteApplication</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteApplicationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteApplicationOperationsClient, callSettings);

        /// <summary>
        /// Deletes an application.
        /// </summary>
        /// <param name="name">
        /// Required. The application name.
        /// Format:
        /// `projects/$project/locations/$location/spaces/$space/applications/$application`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteApplication(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApplication(new DeleteApplicationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an application.
        /// </summary>
        /// <param name="name">
        /// Required. The application name.
        /// Format:
        /// `projects/$project/locations/$location/spaces/$space/applications/$application`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteApplicationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApplicationAsync(new DeleteApplicationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an application.
        /// </summary>
        /// <param name="name">
        /// Required. The application name.
        /// Format:
        /// `projects/$project/locations/$location/spaces/$space/applications/$application`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteApplicationAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteApplicationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an application.
        /// </summary>
        /// <param name="name">
        /// Required. The application name.
        /// Format:
        /// `projects/$project/locations/$location/spaces/$space/applications/$application`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteApplication(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApplication(new DeleteApplicationRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an application.
        /// </summary>
        /// <param name="name">
        /// Required. The application name.
        /// Format:
        /// `projects/$project/locations/$location/spaces/$space/applications/$application`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteApplicationAsync(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteApplicationAsync(new DeleteApplicationRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an application.
        /// </summary>
        /// <param name="name">
        /// Required. The application name.
        /// Format:
        /// `projects/$project/locations/$location/spaces/$space/applications/$application`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteApplicationAsync(ApplicationName name, st::CancellationToken cancellationToken) =>
            DeleteApplicationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deploys an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeployApplicationResponse, OperationMetadata> DeployApplication(DeployApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deploys an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployApplicationResponse, OperationMetadata>> DeployApplicationAsync(DeployApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deploys an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployApplicationResponse, OperationMetadata>> DeployApplicationAsync(DeployApplicationRequest request, st::CancellationToken cancellationToken) =>
            DeployApplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeployApplication</c>.</summary>
        public virtual lro::OperationsClient DeployApplicationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeployApplication</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DeployApplicationResponse, OperationMetadata> PollOnceDeployApplication(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DeployApplicationResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeployApplicationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeployApplication</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DeployApplicationResponse, OperationMetadata>> PollOnceDeployApplicationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DeployApplicationResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeployApplicationOperationsClient, callSettings);

        /// <summary>
        /// Deploys an application.
        /// </summary>
        /// <param name="name">
        /// Required. The application name.
        /// Format:
        /// `projects/$project/locations/$location/spaces/$space/applications/$application`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeployApplicationResponse, OperationMetadata> DeployApplication(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeployApplication(new DeployApplicationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deploys an application.
        /// </summary>
        /// <param name="name">
        /// Required. The application name.
        /// Format:
        /// `projects/$project/locations/$location/spaces/$space/applications/$application`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployApplicationResponse, OperationMetadata>> DeployApplicationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeployApplicationAsync(new DeployApplicationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deploys an application.
        /// </summary>
        /// <param name="name">
        /// Required. The application name.
        /// Format:
        /// `projects/$project/locations/$location/spaces/$space/applications/$application`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployApplicationResponse, OperationMetadata>> DeployApplicationAsync(string name, st::CancellationToken cancellationToken) =>
            DeployApplicationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deploys an application.
        /// </summary>
        /// <param name="name">
        /// Required. The application name.
        /// Format:
        /// `projects/$project/locations/$location/spaces/$space/applications/$application`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DeployApplicationResponse, OperationMetadata> DeployApplication(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeployApplication(new DeployApplicationRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deploys an application.
        /// </summary>
        /// <param name="name">
        /// Required. The application name.
        /// Format:
        /// `projects/$project/locations/$location/spaces/$space/applications/$application`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployApplicationResponse, OperationMetadata>> DeployApplicationAsync(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            DeployApplicationAsync(new DeployApplicationRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deploys an application.
        /// </summary>
        /// <param name="name">
        /// Required. The application name.
        /// Format:
        /// `projects/$project/locations/$location/spaces/$space/applications/$application`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DeployApplicationResponse, OperationMetadata>> DeployApplicationAsync(ApplicationName name, st::CancellationToken cancellationToken) =>
            DeployApplicationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Previews deployment of an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PreviewApplicationResponse, OperationMetadata> PreviewApplication(PreviewApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Previews deployment of an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PreviewApplicationResponse, OperationMetadata>> PreviewApplicationAsync(PreviewApplicationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Previews deployment of an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PreviewApplicationResponse, OperationMetadata>> PreviewApplicationAsync(PreviewApplicationRequest request, st::CancellationToken cancellationToken) =>
            PreviewApplicationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>PreviewApplication</c>.</summary>
        public virtual lro::OperationsClient PreviewApplicationOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>PreviewApplication</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<PreviewApplicationResponse, OperationMetadata> PollOncePreviewApplication(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PreviewApplicationResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PreviewApplicationOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>PreviewApplication</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<PreviewApplicationResponse, OperationMetadata>> PollOncePreviewApplicationAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<PreviewApplicationResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PreviewApplicationOperationsClient, callSettings);

        /// <summary>
        /// Previews deployment of an application.
        /// </summary>
        /// <param name="name">
        /// Required. The application name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/applications/$application`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PreviewApplicationResponse, OperationMetadata> PreviewApplication(string name, gaxgrpc::CallSettings callSettings = null) =>
            PreviewApplication(new PreviewApplicationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Previews deployment of an application.
        /// </summary>
        /// <param name="name">
        /// Required. The application name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/applications/$application`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PreviewApplicationResponse, OperationMetadata>> PreviewApplicationAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            PreviewApplicationAsync(new PreviewApplicationRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Previews deployment of an application.
        /// </summary>
        /// <param name="name">
        /// Required. The application name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/applications/$application`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PreviewApplicationResponse, OperationMetadata>> PreviewApplicationAsync(string name, st::CancellationToken cancellationToken) =>
            PreviewApplicationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Previews deployment of an application.
        /// </summary>
        /// <param name="name">
        /// Required. The application name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/applications/$application`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<PreviewApplicationResponse, OperationMetadata> PreviewApplication(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            PreviewApplication(new PreviewApplicationRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Previews deployment of an application.
        /// </summary>
        /// <param name="name">
        /// Required. The application name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/applications/$application`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PreviewApplicationResponse, OperationMetadata>> PreviewApplicationAsync(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            PreviewApplicationAsync(new PreviewApplicationRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Previews deployment of an application.
        /// </summary>
        /// <param name="name">
        /// Required. The application name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/applications/$application`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<PreviewApplicationResponse, OperationMetadata>> PreviewApplicationAsync(ApplicationName name, st::CancellationToken cancellationToken) =>
            PreviewApplicationAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches the assessment report of a deployed application if present.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchApplicationAssessmentReportResponse FetchApplicationAssessmentReport(FetchApplicationAssessmentReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches the assessment report of a deployed application if present.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchApplicationAssessmentReportResponse> FetchApplicationAssessmentReportAsync(FetchApplicationAssessmentReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches the assessment report of a deployed application if present.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchApplicationAssessmentReportResponse> FetchApplicationAssessmentReportAsync(FetchApplicationAssessmentReportRequest request, st::CancellationToken cancellationToken) =>
            FetchApplicationAssessmentReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches the assessment report of a deployed application if present.
        /// </summary>
        /// <param name="name">
        /// Required. The application name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/applications/$application`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchApplicationAssessmentReportResponse FetchApplicationAssessmentReport(string name, gaxgrpc::CallSettings callSettings = null) =>
            FetchApplicationAssessmentReport(new FetchApplicationAssessmentReportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches the assessment report of a deployed application if present.
        /// </summary>
        /// <param name="name">
        /// Required. The application name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/applications/$application`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchApplicationAssessmentReportResponse> FetchApplicationAssessmentReportAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            FetchApplicationAssessmentReportAsync(new FetchApplicationAssessmentReportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches the assessment report of a deployed application if present.
        /// </summary>
        /// <param name="name">
        /// Required. The application name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/applications/$application`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchApplicationAssessmentReportResponse> FetchApplicationAssessmentReportAsync(string name, st::CancellationToken cancellationToken) =>
            FetchApplicationAssessmentReportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches the assessment report of a deployed application if present.
        /// </summary>
        /// <param name="name">
        /// Required. The application name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/applications/$application`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchApplicationAssessmentReportResponse FetchApplicationAssessmentReport(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            FetchApplicationAssessmentReport(new FetchApplicationAssessmentReportRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches the assessment report of a deployed application if present.
        /// </summary>
        /// <param name="name">
        /// Required. The application name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/applications/$application`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchApplicationAssessmentReportResponse> FetchApplicationAssessmentReportAsync(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            FetchApplicationAssessmentReportAsync(new FetchApplicationAssessmentReportRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetches the assessment report of a deployed application if present.
        /// </summary>
        /// <param name="name">
        /// Required. The application name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/applications/$application`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchApplicationAssessmentReportResponse> FetchApplicationAssessmentReportAsync(ApplicationName name, st::CancellationToken cancellationToken) =>
            FetchApplicationAssessmentReportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generate Assessment Reports of an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GenerateApplicationAssessmentReportResponse, OperationMetadata> GenerateApplicationAssessmentReport(GenerateApplicationAssessmentReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generate Assessment Reports of an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GenerateApplicationAssessmentReportResponse, OperationMetadata>> GenerateApplicationAssessmentReportAsync(GenerateApplicationAssessmentReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generate Assessment Reports of an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GenerateApplicationAssessmentReportResponse, OperationMetadata>> GenerateApplicationAssessmentReportAsync(GenerateApplicationAssessmentReportRequest request, st::CancellationToken cancellationToken) =>
            GenerateApplicationAssessmentReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>GenerateApplicationAssessmentReport</c>.</summary>
        public virtual lro::OperationsClient GenerateApplicationAssessmentReportOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>GenerateApplicationAssessmentReport</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<GenerateApplicationAssessmentReportResponse, OperationMetadata> PollOnceGenerateApplicationAssessmentReport(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GenerateApplicationAssessmentReportResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), GenerateApplicationAssessmentReportOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>GenerateApplicationAssessmentReport</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<GenerateApplicationAssessmentReportResponse, OperationMetadata>> PollOnceGenerateApplicationAssessmentReportAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GenerateApplicationAssessmentReportResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), GenerateApplicationAssessmentReportOperationsClient, callSettings);

        /// <summary>
        /// Generate Assessment Reports of an application.
        /// </summary>
        /// <param name="name">
        /// Required. The application name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/applications/$application`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GenerateApplicationAssessmentReportResponse, OperationMetadata> GenerateApplicationAssessmentReport(string name, gaxgrpc::CallSettings callSettings = null) =>
            GenerateApplicationAssessmentReport(new GenerateApplicationAssessmentReportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Generate Assessment Reports of an application.
        /// </summary>
        /// <param name="name">
        /// Required. The application name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/applications/$application`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GenerateApplicationAssessmentReportResponse, OperationMetadata>> GenerateApplicationAssessmentReportAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GenerateApplicationAssessmentReportAsync(new GenerateApplicationAssessmentReportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Generate Assessment Reports of an application.
        /// </summary>
        /// <param name="name">
        /// Required. The application name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/applications/$application`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GenerateApplicationAssessmentReportResponse, OperationMetadata>> GenerateApplicationAssessmentReportAsync(string name, st::CancellationToken cancellationToken) =>
            GenerateApplicationAssessmentReportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generate Assessment Reports of an application.
        /// </summary>
        /// <param name="name">
        /// Required. The application name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/applications/$application`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GenerateApplicationAssessmentReportResponse, OperationMetadata> GenerateApplicationAssessmentReport(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            GenerateApplicationAssessmentReport(new GenerateApplicationAssessmentReportRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Generate Assessment Reports of an application.
        /// </summary>
        /// <param name="name">
        /// Required. The application name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/applications/$application`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GenerateApplicationAssessmentReportResponse, OperationMetadata>> GenerateApplicationAssessmentReportAsync(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            GenerateApplicationAssessmentReportAsync(new GenerateApplicationAssessmentReportRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Generate Assessment Reports of an application.
        /// </summary>
        /// <param name="name">
        /// Required. The application name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/applications/$application`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GenerateApplicationAssessmentReportResponse, OperationMetadata>> GenerateApplicationAssessmentReportAsync(ApplicationName name, st::CancellationToken cancellationToken) =>
            GenerateApplicationAssessmentReportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generate Assessment Reports of an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GenerateApplicationTemplateAssessmentReportResponse, OperationMetadata> GenerateApplicationTemplateAssessmentReport(GenerateApplicationTemplateAssessmentReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generate Assessment Reports of an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GenerateApplicationTemplateAssessmentReportResponse, OperationMetadata>> GenerateApplicationTemplateAssessmentReportAsync(GenerateApplicationTemplateAssessmentReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generate Assessment Reports of an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GenerateApplicationTemplateAssessmentReportResponse, OperationMetadata>> GenerateApplicationTemplateAssessmentReportAsync(GenerateApplicationTemplateAssessmentReportRequest request, st::CancellationToken cancellationToken) =>
            GenerateApplicationTemplateAssessmentReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// The long-running operations client for <c>GenerateApplicationTemplateAssessmentReport</c>.
        /// </summary>
        public virtual lro::OperationsClient GenerateApplicationTemplateAssessmentReportOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>GenerateApplicationTemplateAssessmentReport</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<GenerateApplicationTemplateAssessmentReportResponse, OperationMetadata> PollOnceGenerateApplicationTemplateAssessmentReport(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GenerateApplicationTemplateAssessmentReportResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), GenerateApplicationTemplateAssessmentReportOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>GenerateApplicationTemplateAssessmentReport</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<GenerateApplicationTemplateAssessmentReportResponse, OperationMetadata>> PollOnceGenerateApplicationTemplateAssessmentReportAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GenerateApplicationTemplateAssessmentReportResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), GenerateApplicationTemplateAssessmentReportOperationsClient, callSettings);

        /// <summary>
        /// Generate Assessment Reports of an application template.
        /// </summary>
        /// <param name="name">
        /// Required. The application template name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/applicationTemplates/$applicationTemplate`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GenerateApplicationTemplateAssessmentReportResponse, OperationMetadata> GenerateApplicationTemplateAssessmentReport(string name, gaxgrpc::CallSettings callSettings = null) =>
            GenerateApplicationTemplateAssessmentReport(new GenerateApplicationTemplateAssessmentReportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Generate Assessment Reports of an application template.
        /// </summary>
        /// <param name="name">
        /// Required. The application template name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/applicationTemplates/$applicationTemplate`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GenerateApplicationTemplateAssessmentReportResponse, OperationMetadata>> GenerateApplicationTemplateAssessmentReportAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GenerateApplicationTemplateAssessmentReportAsync(new GenerateApplicationTemplateAssessmentReportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Generate Assessment Reports of an application template.
        /// </summary>
        /// <param name="name">
        /// Required. The application template name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/applicationTemplates/$applicationTemplate`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GenerateApplicationTemplateAssessmentReportResponse, OperationMetadata>> GenerateApplicationTemplateAssessmentReportAsync(string name, st::CancellationToken cancellationToken) =>
            GenerateApplicationTemplateAssessmentReportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generate Assessment Reports of an application template.
        /// </summary>
        /// <param name="name">
        /// Required. The application template name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/applicationTemplates/$applicationTemplate`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GenerateApplicationTemplateAssessmentReportResponse, OperationMetadata> GenerateApplicationTemplateAssessmentReport(ApplicationTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            GenerateApplicationTemplateAssessmentReport(new GenerateApplicationTemplateAssessmentReportRequest
            {
                ApplicationTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Generate Assessment Reports of an application template.
        /// </summary>
        /// <param name="name">
        /// Required. The application template name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/applicationTemplates/$applicationTemplate`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GenerateApplicationTemplateAssessmentReportResponse, OperationMetadata>> GenerateApplicationTemplateAssessmentReportAsync(ApplicationTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            GenerateApplicationTemplateAssessmentReportAsync(new GenerateApplicationTemplateAssessmentReportRequest
            {
                ApplicationTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Generate Assessment Reports of an application template.
        /// </summary>
        /// <param name="name">
        /// Required. The application template name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/applicationTemplates/$applicationTemplate`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GenerateApplicationTemplateAssessmentReportResponse, OperationMetadata>> GenerateApplicationTemplateAssessmentReportAsync(ApplicationTemplateName name, st::CancellationToken cancellationToken) =>
            GenerateApplicationTemplateAssessmentReportAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deprecated: Use GenerateTerraformPlanAssessmentReport instead.
        /// 
        /// Generate a best practice report for a given Terraform plan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual lro::Operation<GenerateAssessmentReportResponse, OperationMetadata> GenerateAssessmentReport(GenerateAssessmentReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
#pragma warning restore CS0612
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deprecated: Use GenerateTerraformPlanAssessmentReport instead.
        /// 
        /// Generate a best practice report for a given Terraform plan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual stt::Task<lro::Operation<GenerateAssessmentReportResponse, OperationMetadata>> GenerateAssessmentReportAsync(GenerateAssessmentReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
#pragma warning restore CS0612
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deprecated: Use GenerateTerraformPlanAssessmentReport instead.
        /// 
        /// Generate a best practice report for a given Terraform plan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual stt::Task<lro::Operation<GenerateAssessmentReportResponse, OperationMetadata>> GenerateAssessmentReportAsync(GenerateAssessmentReportRequest request, st::CancellationToken cancellationToken) =>
#pragma warning restore CS0612
            GenerateAssessmentReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>GenerateAssessmentReport</c>.</summary>
        public virtual lro::OperationsClient GenerateAssessmentReportOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>GenerateAssessmentReport</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual lro::Operation<GenerateAssessmentReportResponse, OperationMetadata> PollOnceGenerateAssessmentReport(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GenerateAssessmentReportResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), GenerateAssessmentReportOperationsClient, callSettings);
#pragma warning restore CS0612

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>GenerateAssessmentReport</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual stt::Task<lro::Operation<GenerateAssessmentReportResponse, OperationMetadata>> PollOnceGenerateAssessmentReportAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GenerateAssessmentReportResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), GenerateAssessmentReportOperationsClient, callSettings);
#pragma warning restore CS0612

        /// <summary>
        /// Deprecated: Use GenerateTerraformPlanAssessmentReport instead.
        /// 
        /// Generate a best practice report for a given Terraform plan.
        /// </summary>
        /// <param name="spaceName">
        /// Required. The name of the space at which Generate Assessment Report is
        /// called. Format: `projects/$project/locations/$location/spaces/$space`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual lro::Operation<GenerateAssessmentReportResponse, OperationMetadata> GenerateAssessmentReport(string spaceName, gaxgrpc::CallSettings callSettings = null) =>
            GenerateAssessmentReport(new GenerateAssessmentReportRequest
#pragma warning restore CS0612
            {
                SpaceName = gax::GaxPreconditions.CheckNotNullOrEmpty(spaceName, nameof(spaceName)),
            }, callSettings);

        /// <summary>
        /// Deprecated: Use GenerateTerraformPlanAssessmentReport instead.
        /// 
        /// Generate a best practice report for a given Terraform plan.
        /// </summary>
        /// <param name="spaceName">
        /// Required. The name of the space at which Generate Assessment Report is
        /// called. Format: `projects/$project/locations/$location/spaces/$space`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual stt::Task<lro::Operation<GenerateAssessmentReportResponse, OperationMetadata>> GenerateAssessmentReportAsync(string spaceName, gaxgrpc::CallSettings callSettings = null) =>
            GenerateAssessmentReportAsync(new GenerateAssessmentReportRequest
#pragma warning restore CS0612
            {
                SpaceName = gax::GaxPreconditions.CheckNotNullOrEmpty(spaceName, nameof(spaceName)),
            }, callSettings);

        /// <summary>
        /// Deprecated: Use GenerateTerraformPlanAssessmentReport instead.
        /// 
        /// Generate a best practice report for a given Terraform plan.
        /// </summary>
        /// <param name="spaceName">
        /// Required. The name of the space at which Generate Assessment Report is
        /// called. Format: `projects/$project/locations/$location/spaces/$space`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual stt::Task<lro::Operation<GenerateAssessmentReportResponse, OperationMetadata>> GenerateAssessmentReportAsync(string spaceName, st::CancellationToken cancellationToken) =>
#pragma warning restore CS0612
            GenerateAssessmentReportAsync(spaceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deprecated: Use GenerateTerraformPlanAssessmentReport instead.
        /// 
        /// Generate a best practice report for a given Terraform plan.
        /// </summary>
        /// <param name="spaceName">
        /// Required. The name of the space at which Generate Assessment Report is
        /// called. Format: `projects/$project/locations/$location/spaces/$space`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual lro::Operation<GenerateAssessmentReportResponse, OperationMetadata> GenerateAssessmentReport(SpaceName spaceName, gaxgrpc::CallSettings callSettings = null) =>
            GenerateAssessmentReport(new GenerateAssessmentReportRequest
#pragma warning restore CS0612
            {
                SpaceNameAsSpaceName = gax::GaxPreconditions.CheckNotNull(spaceName, nameof(spaceName)),
            }, callSettings);

        /// <summary>
        /// Deprecated: Use GenerateTerraformPlanAssessmentReport instead.
        /// 
        /// Generate a best practice report for a given Terraform plan.
        /// </summary>
        /// <param name="spaceName">
        /// Required. The name of the space at which Generate Assessment Report is
        /// called. Format: `projects/$project/locations/$location/spaces/$space`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual stt::Task<lro::Operation<GenerateAssessmentReportResponse, OperationMetadata>> GenerateAssessmentReportAsync(SpaceName spaceName, gaxgrpc::CallSettings callSettings = null) =>
            GenerateAssessmentReportAsync(new GenerateAssessmentReportRequest
#pragma warning restore CS0612
            {
                SpaceNameAsSpaceName = gax::GaxPreconditions.CheckNotNull(spaceName, nameof(spaceName)),
            }, callSettings);

        /// <summary>
        /// Deprecated: Use GenerateTerraformPlanAssessmentReport instead.
        /// 
        /// Generate a best practice report for a given Terraform plan.
        /// </summary>
        /// <param name="spaceName">
        /// Required. The name of the space at which Generate Assessment Report is
        /// called. Format: `projects/$project/locations/$location/spaces/$space`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public virtual stt::Task<lro::Operation<GenerateAssessmentReportResponse, OperationMetadata>> GenerateAssessmentReportAsync(SpaceName spaceName, st::CancellationToken cancellationToken) =>
#pragma warning restore CS0612
            GenerateAssessmentReportAsync(spaceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generate a Terraform plan assessment report for a given Terraform plan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GenerateTerraformPlanAssessmentReportResponse, OperationMetadata> GenerateTerraformPlanAssessmentReport(GenerateTerraformPlanAssessmentReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generate a Terraform plan assessment report for a given Terraform plan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GenerateTerraformPlanAssessmentReportResponse, OperationMetadata>> GenerateTerraformPlanAssessmentReportAsync(GenerateTerraformPlanAssessmentReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generate a Terraform plan assessment report for a given Terraform plan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GenerateTerraformPlanAssessmentReportResponse, OperationMetadata>> GenerateTerraformPlanAssessmentReportAsync(GenerateTerraformPlanAssessmentReportRequest request, st::CancellationToken cancellationToken) =>
            GenerateTerraformPlanAssessmentReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>GenerateTerraformPlanAssessmentReport</c>.</summary>
        public virtual lro::OperationsClient GenerateTerraformPlanAssessmentReportOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>GenerateTerraformPlanAssessmentReport</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<GenerateTerraformPlanAssessmentReportResponse, OperationMetadata> PollOnceGenerateTerraformPlanAssessmentReport(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GenerateTerraformPlanAssessmentReportResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), GenerateTerraformPlanAssessmentReportOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>GenerateTerraformPlanAssessmentReport</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<GenerateTerraformPlanAssessmentReportResponse, OperationMetadata>> PollOnceGenerateTerraformPlanAssessmentReportAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<GenerateTerraformPlanAssessmentReportResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), GenerateTerraformPlanAssessmentReportOperationsClient, callSettings);

        /// <summary>
        /// Generate a Terraform plan assessment report for a given Terraform plan.
        /// </summary>
        /// <param name="name">
        /// Required. The parent resource in which to generate the assessment report.
        /// Format: projects/$project/locations/$location/spaces/$space
        /// </param>
        /// <param name="terraformPlan">
        /// Required. The raw JSON representation of the generated Terraform plan,
        /// provided as bytes.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GenerateTerraformPlanAssessmentReportResponse, OperationMetadata> GenerateTerraformPlanAssessmentReport(string name, proto::ByteString terraformPlan, gaxgrpc::CallSettings callSettings = null) =>
            GenerateTerraformPlanAssessmentReport(new GenerateTerraformPlanAssessmentReportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                TerraformPlan = gax::GaxPreconditions.CheckNotNull(terraformPlan, nameof(terraformPlan)),
            }, callSettings);

        /// <summary>
        /// Generate a Terraform plan assessment report for a given Terraform plan.
        /// </summary>
        /// <param name="name">
        /// Required. The parent resource in which to generate the assessment report.
        /// Format: projects/$project/locations/$location/spaces/$space
        /// </param>
        /// <param name="terraformPlan">
        /// Required. The raw JSON representation of the generated Terraform plan,
        /// provided as bytes.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GenerateTerraformPlanAssessmentReportResponse, OperationMetadata>> GenerateTerraformPlanAssessmentReportAsync(string name, proto::ByteString terraformPlan, gaxgrpc::CallSettings callSettings = null) =>
            GenerateTerraformPlanAssessmentReportAsync(new GenerateTerraformPlanAssessmentReportRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                TerraformPlan = gax::GaxPreconditions.CheckNotNull(terraformPlan, nameof(terraformPlan)),
            }, callSettings);

        /// <summary>
        /// Generate a Terraform plan assessment report for a given Terraform plan.
        /// </summary>
        /// <param name="name">
        /// Required. The parent resource in which to generate the assessment report.
        /// Format: projects/$project/locations/$location/spaces/$space
        /// </param>
        /// <param name="terraformPlan">
        /// Required. The raw JSON representation of the generated Terraform plan,
        /// provided as bytes.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GenerateTerraformPlanAssessmentReportResponse, OperationMetadata>> GenerateTerraformPlanAssessmentReportAsync(string name, proto::ByteString terraformPlan, st::CancellationToken cancellationToken) =>
            GenerateTerraformPlanAssessmentReportAsync(name, terraformPlan, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generate a Terraform plan assessment report for a given Terraform plan.
        /// </summary>
        /// <param name="name">
        /// Required. The parent resource in which to generate the assessment report.
        /// Format: projects/$project/locations/$location/spaces/$space
        /// </param>
        /// <param name="terraformPlan">
        /// Required. The raw JSON representation of the generated Terraform plan,
        /// provided as bytes.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<GenerateTerraformPlanAssessmentReportResponse, OperationMetadata> GenerateTerraformPlanAssessmentReport(SpaceName name, proto::ByteString terraformPlan, gaxgrpc::CallSettings callSettings = null) =>
            GenerateTerraformPlanAssessmentReport(new GenerateTerraformPlanAssessmentReportRequest
            {
                SpaceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                TerraformPlan = gax::GaxPreconditions.CheckNotNull(terraformPlan, nameof(terraformPlan)),
            }, callSettings);

        /// <summary>
        /// Generate a Terraform plan assessment report for a given Terraform plan.
        /// </summary>
        /// <param name="name">
        /// Required. The parent resource in which to generate the assessment report.
        /// Format: projects/$project/locations/$location/spaces/$space
        /// </param>
        /// <param name="terraformPlan">
        /// Required. The raw JSON representation of the generated Terraform plan,
        /// provided as bytes.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GenerateTerraformPlanAssessmentReportResponse, OperationMetadata>> GenerateTerraformPlanAssessmentReportAsync(SpaceName name, proto::ByteString terraformPlan, gaxgrpc::CallSettings callSettings = null) =>
            GenerateTerraformPlanAssessmentReportAsync(new GenerateTerraformPlanAssessmentReportRequest
            {
                SpaceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                TerraformPlan = gax::GaxPreconditions.CheckNotNull(terraformPlan, nameof(terraformPlan)),
            }, callSettings);

        /// <summary>
        /// Generate a Terraform plan assessment report for a given Terraform plan.
        /// </summary>
        /// <param name="name">
        /// Required. The parent resource in which to generate the assessment report.
        /// Format: projects/$project/locations/$location/spaces/$space
        /// </param>
        /// <param name="terraformPlan">
        /// Required. The raw JSON representation of the generated Terraform plan,
        /// provided as bytes.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<GenerateTerraformPlanAssessmentReportResponse, OperationMetadata>> GenerateTerraformPlanAssessmentReportAsync(SpaceName name, proto::ByteString terraformPlan, st::CancellationToken cancellationToken) =>
            GenerateTerraformPlanAssessmentReportAsync(name, terraformPlan, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Policy related APIs.
        /// Get a policy for an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy GetPolicy(GetPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Policy related APIs.
        /// Get a policy for an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetPolicyAsync(GetPolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Policy related APIs.
        /// Get a policy for an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetPolicyAsync(GetPolicyRequest request, st::CancellationToken cancellationToken) =>
            GetPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Policy related APIs.
        /// Get a policy for an application template.
        /// </summary>
        /// <param name="name">
        /// Required. The policy name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/applicationTemplates/$applicationTemplate/policies/$policy`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy GetPolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPolicy(new GetPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Policy related APIs.
        /// Get a policy for an application template.
        /// </summary>
        /// <param name="name">
        /// Required. The policy name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/applicationTemplates/$applicationTemplate/policies/$policy`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetPolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPolicyAsync(new GetPolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Policy related APIs.
        /// Get a policy for an application template.
        /// </summary>
        /// <param name="name">
        /// Required. The policy name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/applicationTemplates/$applicationTemplate/policies/$policy`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetPolicyAsync(string name, st::CancellationToken cancellationToken) =>
            GetPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Policy related APIs.
        /// Get a policy for an application template.
        /// </summary>
        /// <param name="name">
        /// Required. The policy name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/applicationTemplates/$applicationTemplate/policies/$policy`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy GetPolicy(PolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPolicy(new GetPolicyRequest
            {
                PolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Policy related APIs.
        /// Get a policy for an application template.
        /// </summary>
        /// <param name="name">
        /// Required. The policy name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/applicationTemplates/$applicationTemplate/policies/$policy`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetPolicyAsync(PolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPolicyAsync(new GetPolicyRequest
            {
                PolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Policy related APIs.
        /// Get a policy for an application template.
        /// </summary>
        /// <param name="name">
        /// Required. The policy name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/applicationTemplates/$applicationTemplate/policies/$policy`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> GetPolicyAsync(PolicyName name, st::CancellationToken cancellationToken) =>
            GetPolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists policies for an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Policy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPoliciesResponse, Policy> ListPolicies(ListPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists policies for an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Policy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPoliciesResponse, Policy> ListPoliciesAsync(ListPoliciesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists policies for an application template.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent application template from which policies are listed in
        /// the following format:
        /// `projects/$project/locations/$location/spaces/$space/applicationTemplates/$applicationTemplate`
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
        /// <returns>A pageable sequence of <see cref="Policy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPoliciesResponse, Policy> ListPolicies(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPoliciesRequest request = new ListPoliciesRequest
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
            return ListPolicies(request, callSettings);
        }

        /// <summary>
        /// Lists policies for an application template.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent application template from which policies are listed in
        /// the following format:
        /// `projects/$project/locations/$location/spaces/$space/applicationTemplates/$applicationTemplate`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Policy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPoliciesResponse, Policy> ListPoliciesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPoliciesRequest request = new ListPoliciesRequest
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
            return ListPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists policies for an application template.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent application template from which policies are listed in
        /// the following format:
        /// `projects/$project/locations/$location/spaces/$space/applicationTemplates/$applicationTemplate`
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
        /// <returns>A pageable sequence of <see cref="Policy"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPoliciesResponse, Policy> ListPolicies(ApplicationTemplateName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPoliciesRequest request = new ListPoliciesRequest
            {
                ParentAsApplicationTemplateName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPolicies(request, callSettings);
        }

        /// <summary>
        /// Lists policies for an application template.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent application template from which policies are listed in
        /// the following format:
        /// `projects/$project/locations/$location/spaces/$space/applicationTemplates/$applicationTemplate`
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
        /// <returns>A pageable asynchronous sequence of <see cref="Policy"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPoliciesResponse, Policy> ListPoliciesAsync(ApplicationTemplateName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPoliciesRequest request = new ListPoliciesRequest
            {
                ParentAsApplicationTemplateName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPoliciesAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a policy for an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy CreatePolicy(CreatePolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a policy for an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> CreatePolicyAsync(CreatePolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a policy for an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> CreatePolicyAsync(CreatePolicyRequest request, st::CancellationToken cancellationToken) =>
            CreatePolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a policy for an application template.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the policy in the
        /// following format:
        /// `projects/$project/locations/$location/spaces/$space/applicationTemplates/$applicationTemplate`
        /// </param>
        /// <param name="policy">
        /// Required. The policy to create.
        /// </param>
        /// <param name="policyId">
        /// Required. The ID of the policy to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy CreatePolicy(string parent, Policy policy, string policyId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePolicy(new CreatePolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(policyId, nameof(policyId)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Creates a policy for an application template.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the policy in the
        /// following format:
        /// `projects/$project/locations/$location/spaces/$space/applicationTemplates/$applicationTemplate`
        /// </param>
        /// <param name="policy">
        /// Required. The policy to create.
        /// </param>
        /// <param name="policyId">
        /// Required. The ID of the policy to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> CreatePolicyAsync(string parent, Policy policy, string policyId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePolicyAsync(new CreatePolicyRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(policyId, nameof(policyId)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Creates a policy for an application template.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the policy in the
        /// following format:
        /// `projects/$project/locations/$location/spaces/$space/applicationTemplates/$applicationTemplate`
        /// </param>
        /// <param name="policy">
        /// Required. The policy to create.
        /// </param>
        /// <param name="policyId">
        /// Required. The ID of the policy to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> CreatePolicyAsync(string parent, Policy policy, string policyId, st::CancellationToken cancellationToken) =>
            CreatePolicyAsync(parent, policy, policyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a policy for an application template.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the policy in the
        /// following format:
        /// `projects/$project/locations/$location/spaces/$space/applicationTemplates/$applicationTemplate`
        /// </param>
        /// <param name="policy">
        /// Required. The policy to create.
        /// </param>
        /// <param name="policyId">
        /// Required. The ID of the policy to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy CreatePolicy(ApplicationTemplateName parent, Policy policy, string policyId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePolicy(new CreatePolicyRequest
            {
                ParentAsApplicationTemplateName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(policyId, nameof(policyId)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Creates a policy for an application template.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the policy in the
        /// following format:
        /// `projects/$project/locations/$location/spaces/$space/applicationTemplates/$applicationTemplate`
        /// </param>
        /// <param name="policy">
        /// Required. The policy to create.
        /// </param>
        /// <param name="policyId">
        /// Required. The ID of the policy to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> CreatePolicyAsync(ApplicationTemplateName parent, Policy policy, string policyId, gaxgrpc::CallSettings callSettings = null) =>
            CreatePolicyAsync(new CreatePolicyRequest
            {
                ParentAsApplicationTemplateName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PolicyId = gax::GaxPreconditions.CheckNotNullOrEmpty(policyId, nameof(policyId)),
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Creates a policy for an application template.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource in which to create the policy in the
        /// following format:
        /// `projects/$project/locations/$location/spaces/$space/applicationTemplates/$applicationTemplate`
        /// </param>
        /// <param name="policy">
        /// Required. The policy to create.
        /// </param>
        /// <param name="policyId">
        /// Required. The ID of the policy to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> CreatePolicyAsync(ApplicationTemplateName parent, Policy policy, string policyId, st::CancellationToken cancellationToken) =>
            CreatePolicyAsync(parent, policy, policyId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy UpdatePolicy(UpdatePolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> UpdatePolicyAsync(UpdatePolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> UpdatePolicyAsync(UpdatePolicyRequest request, st::CancellationToken cancellationToken) =>
            UpdatePolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a policy.
        /// </summary>
        /// <param name="policy">
        /// Required. The policy to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The fields to overwrite in the policy update. The fields
        /// specified in the update_mask are relative to the resource, not the full
        /// request. A field will be overwritten if it is in the mask. If you don't
        /// provide a mask, all fields are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Policy UpdatePolicy(Policy policy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePolicy(new UpdatePolicyRequest
            {
                UpdateMask = updateMask,
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Updates a policy.
        /// </summary>
        /// <param name="policy">
        /// Required. The policy to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The fields to overwrite in the policy update. The fields
        /// specified in the update_mask are relative to the resource, not the full
        /// request. A field will be overwritten if it is in the mask. If you don't
        /// provide a mask, all fields are overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> UpdatePolicyAsync(Policy policy, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePolicyAsync(new UpdatePolicyRequest
            {
                UpdateMask = updateMask,
                Policy = gax::GaxPreconditions.CheckNotNull(policy, nameof(policy)),
            }, callSettings);

        /// <summary>
        /// Updates a policy.
        /// </summary>
        /// <param name="policy">
        /// Required. The policy to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The fields to overwrite in the policy update. The fields
        /// specified in the update_mask are relative to the resource, not the full
        /// request. A field will be overwritten if it is in the mask. If you don't
        /// provide a mask, all fields are overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Policy> UpdatePolicyAsync(Policy policy, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdatePolicyAsync(policy, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePolicy(DeletePolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePolicyAsync(DeletePolicyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePolicyAsync(DeletePolicyRequest request, st::CancellationToken cancellationToken) =>
            DeletePolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a policy.
        /// </summary>
        /// <param name="name">
        /// Required. The policy name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/applicationTemplates/$applicationTemplate/policies/$policy`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePolicy(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePolicy(new DeletePolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a policy.
        /// </summary>
        /// <param name="name">
        /// Required. The policy name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/applicationTemplates/$applicationTemplate/policies/$policy`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePolicyAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePolicyAsync(new DeletePolicyRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a policy.
        /// </summary>
        /// <param name="name">
        /// Required. The policy name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/applicationTemplates/$applicationTemplate/policies/$policy`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePolicyAsync(string name, st::CancellationToken cancellationToken) =>
            DeletePolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a policy.
        /// </summary>
        /// <param name="name">
        /// Required. The policy name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/applicationTemplates/$applicationTemplate/policies/$policy`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePolicy(PolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePolicy(new DeletePolicyRequest
            {
                PolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a policy.
        /// </summary>
        /// <param name="name">
        /// Required. The policy name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/applicationTemplates/$applicationTemplate/policies/$policy`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePolicyAsync(PolicyName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePolicyAsync(new DeletePolicyRequest
            {
                PolicyName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a policy.
        /// </summary>
        /// <param name="name">
        /// Required. The policy name in the following format:
        /// `projects/$project/locations/$location/spaces/$space/applicationTemplates/$applicationTemplate/policies/$policy`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePolicyAsync(PolicyName name, st::CancellationToken cancellationToken) =>
            DeletePolicyAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetches all frameworks for assessment report.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Framework"/> resources.</returns>
        public virtual gax::PagedEnumerable<FetchFrameworksResponse, Framework> FetchFrameworks(FetchFrameworksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches all frameworks for assessment report.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Framework"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<FetchFrameworksResponse, Framework> FetchFrameworksAsync(FetchFrameworksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetches all frameworks for assessment report.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
        /// Format: projects/{project}/locations/{location}
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
        /// <returns>A pageable sequence of <see cref="Framework"/> resources.</returns>
        public virtual gax::PagedEnumerable<FetchFrameworksResponse, Framework> FetchFrameworks(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            FetchFrameworksRequest request = new FetchFrameworksRequest
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
            return FetchFrameworks(request, callSettings);
        }

        /// <summary>
        /// Fetches all frameworks for assessment report.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent resource name.
        /// Format: projects/{project}/locations/{location}
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
        /// <returns>A pageable asynchronous sequence of <see cref="Framework"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<FetchFrameworksResponse, Framework> FetchFrameworksAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            FetchFrameworksRequest request = new FetchFrameworksRequest
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
            return FetchFrameworksAsync(request, callSettings);
        }

        /// <summary>
        /// Generates Terraform files for an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateApplicationIaCResponse GenerateApplicationIaC(GenerateApplicationIaCRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates Terraform files for an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateApplicationIaCResponse> GenerateApplicationIaCAsync(GenerateApplicationIaCRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates Terraform files for an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateApplicationIaCResponse> GenerateApplicationIaCAsync(GenerateApplicationIaCRequest request, st::CancellationToken cancellationToken) =>
            GenerateApplicationIaCAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates Terraform files for an application.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateApplicationIaCResponse GenerateApplicationIaC(string name, gaxgrpc::CallSettings callSettings = null) =>
            GenerateApplicationIaC(new GenerateApplicationIaCRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Generates Terraform files for an application.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateApplicationIaCResponse> GenerateApplicationIaCAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GenerateApplicationIaCAsync(new GenerateApplicationIaCRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Generates Terraform files for an application.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateApplicationIaCResponse> GenerateApplicationIaCAsync(string name, st::CancellationToken cancellationToken) =>
            GenerateApplicationIaCAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates Terraform files for an application.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateApplicationIaCResponse GenerateApplicationIaC(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            GenerateApplicationIaC(new GenerateApplicationIaCRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Generates Terraform files for an application.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateApplicationIaCResponse> GenerateApplicationIaCAsync(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            GenerateApplicationIaCAsync(new GenerateApplicationIaCRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Generates Terraform files for an application.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateApplicationIaCResponse> GenerateApplicationIaCAsync(ApplicationName name, st::CancellationToken cancellationToken) =>
            GenerateApplicationIaCAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports Terraform files for an application asynchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportApplicationIaCResponse, OperationMetadata> ExportApplicationIaC(ExportApplicationIaCRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports Terraform files for an application asynchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportApplicationIaCResponse, OperationMetadata>> ExportApplicationIaCAsync(ExportApplicationIaCRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports Terraform files for an application asynchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportApplicationIaCResponse, OperationMetadata>> ExportApplicationIaCAsync(ExportApplicationIaCRequest request, st::CancellationToken cancellationToken) =>
            ExportApplicationIaCAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ExportApplicationIaC</c>.</summary>
        public virtual lro::OperationsClient ExportApplicationIaCOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ExportApplicationIaC</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ExportApplicationIaCResponse, OperationMetadata> PollOnceExportApplicationIaC(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportApplicationIaCResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportApplicationIaCOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ExportApplicationIaC</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ExportApplicationIaCResponse, OperationMetadata>> PollOnceExportApplicationIaCAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ExportApplicationIaCResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ExportApplicationIaCOperationsClient, callSettings);

        /// <summary>
        /// Exports Terraform files for an application asynchronously.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportApplicationIaCResponse, OperationMetadata> ExportApplicationIaC(string name, gaxgrpc::CallSettings callSettings = null) =>
            ExportApplicationIaC(new ExportApplicationIaCRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Exports Terraform files for an application asynchronously.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportApplicationIaCResponse, OperationMetadata>> ExportApplicationIaCAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ExportApplicationIaCAsync(new ExportApplicationIaCRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Exports Terraform files for an application asynchronously.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportApplicationIaCResponse, OperationMetadata>> ExportApplicationIaCAsync(string name, st::CancellationToken cancellationToken) =>
            ExportApplicationIaCAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports Terraform files for an application asynchronously.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ExportApplicationIaCResponse, OperationMetadata> ExportApplicationIaC(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            ExportApplicationIaC(new ExportApplicationIaCRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Exports Terraform files for an application asynchronously.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportApplicationIaCResponse, OperationMetadata>> ExportApplicationIaCAsync(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            ExportApplicationIaCAsync(new ExportApplicationIaCRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Exports Terraform files for an application asynchronously.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ExportApplicationIaCResponse, OperationMetadata>> ExportApplicationIaCAsync(ApplicationName name, st::CancellationToken cancellationToken) =>
            ExportApplicationIaCAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports IaC for an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ImportApplicationTemplateIaCResponse ImportApplicationTemplateIaC(ImportApplicationTemplateIaCRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports IaC for an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportApplicationTemplateIaCResponse> ImportApplicationTemplateIaCAsync(ImportApplicationTemplateIaCRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports IaC for an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportApplicationTemplateIaCResponse> ImportApplicationTemplateIaCAsync(ImportApplicationTemplateIaCRequest request, st::CancellationToken cancellationToken) =>
            ImportApplicationTemplateIaCAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports IaC for an application template.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ImportApplicationTemplateIaCResponse ImportApplicationTemplateIaC(string name, gaxgrpc::CallSettings callSettings = null) =>
            ImportApplicationTemplateIaC(new ImportApplicationTemplateIaCRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Imports IaC for an application template.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportApplicationTemplateIaCResponse> ImportApplicationTemplateIaCAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ImportApplicationTemplateIaCAsync(new ImportApplicationTemplateIaCRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Imports IaC for an application template.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportApplicationTemplateIaCResponse> ImportApplicationTemplateIaCAsync(string name, st::CancellationToken cancellationToken) =>
            ImportApplicationTemplateIaCAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports IaC for an application template.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ImportApplicationTemplateIaCResponse ImportApplicationTemplateIaC(ApplicationTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            ImportApplicationTemplateIaC(new ImportApplicationTemplateIaCRequest
            {
                ApplicationTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Imports IaC for an application template.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportApplicationTemplateIaCResponse> ImportApplicationTemplateIaCAsync(ApplicationTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            ImportApplicationTemplateIaCAsync(new ImportApplicationTemplateIaCRequest
            {
                ApplicationTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Imports IaC for an application template.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportApplicationTemplateIaCResponse> ImportApplicationTemplateIaCAsync(ApplicationTemplateName name, st::CancellationToken cancellationToken) =>
            ImportApplicationTemplateIaCAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Ingests IaC for an application template asynchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<IngestApplicationTemplateIaCResponse, OperationMetadata> IngestApplicationTemplateIaC(IngestApplicationTemplateIaCRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Ingests IaC for an application template asynchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IngestApplicationTemplateIaCResponse, OperationMetadata>> IngestApplicationTemplateIaCAsync(IngestApplicationTemplateIaCRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Ingests IaC for an application template asynchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IngestApplicationTemplateIaCResponse, OperationMetadata>> IngestApplicationTemplateIaCAsync(IngestApplicationTemplateIaCRequest request, st::CancellationToken cancellationToken) =>
            IngestApplicationTemplateIaCAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>IngestApplicationTemplateIaC</c>.</summary>
        public virtual lro::OperationsClient IngestApplicationTemplateIaCOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>IngestApplicationTemplateIaC</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<IngestApplicationTemplateIaCResponse, OperationMetadata> PollOnceIngestApplicationTemplateIaC(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<IngestApplicationTemplateIaCResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), IngestApplicationTemplateIaCOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>IngestApplicationTemplateIaC</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<IngestApplicationTemplateIaCResponse, OperationMetadata>> PollOnceIngestApplicationTemplateIaCAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<IngestApplicationTemplateIaCResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), IngestApplicationTemplateIaCOperationsClient, callSettings);

        /// <summary>
        /// Ingests IaC for an application template asynchronously.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<IngestApplicationTemplateIaCResponse, OperationMetadata> IngestApplicationTemplateIaC(string name, gaxgrpc::CallSettings callSettings = null) =>
            IngestApplicationTemplateIaC(new IngestApplicationTemplateIaCRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Ingests IaC for an application template asynchronously.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IngestApplicationTemplateIaCResponse, OperationMetadata>> IngestApplicationTemplateIaCAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            IngestApplicationTemplateIaCAsync(new IngestApplicationTemplateIaCRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Ingests IaC for an application template asynchronously.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IngestApplicationTemplateIaCResponse, OperationMetadata>> IngestApplicationTemplateIaCAsync(string name, st::CancellationToken cancellationToken) =>
            IngestApplicationTemplateIaCAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Ingests IaC for an application template asynchronously.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<IngestApplicationTemplateIaCResponse, OperationMetadata> IngestApplicationTemplateIaC(ApplicationTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            IngestApplicationTemplateIaC(new IngestApplicationTemplateIaCRequest
            {
                ApplicationTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Ingests IaC for an application template asynchronously.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IngestApplicationTemplateIaCResponse, OperationMetadata>> IngestApplicationTemplateIaCAsync(ApplicationTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            IngestApplicationTemplateIaCAsync(new IngestApplicationTemplateIaCRequest
            {
                ApplicationTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Ingests IaC for an application template asynchronously.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application template.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<IngestApplicationTemplateIaCResponse, OperationMetadata>> IngestApplicationTemplateIaCAsync(ApplicationTemplateName name, st::CancellationToken cancellationToken) =>
            IngestApplicationTemplateIaCAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports IaC for an application resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ImportApplicationIaCResponse ImportApplicationIaC(ImportApplicationIaCRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports IaC for an application resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportApplicationIaCResponse> ImportApplicationIaCAsync(ImportApplicationIaCRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports IaC for an application resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportApplicationIaCResponse> ImportApplicationIaCAsync(ImportApplicationIaCRequest request, st::CancellationToken cancellationToken) =>
            ImportApplicationIaCAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports IaC for an application resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ImportApplicationIaCResponse ImportApplicationIaC(string name, gaxgrpc::CallSettings callSettings = null) =>
            ImportApplicationIaC(new ImportApplicationIaCRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Imports IaC for an application resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportApplicationIaCResponse> ImportApplicationIaCAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ImportApplicationIaCAsync(new ImportApplicationIaCRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Imports IaC for an application resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportApplicationIaCResponse> ImportApplicationIaCAsync(string name, st::CancellationToken cancellationToken) =>
            ImportApplicationIaCAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports IaC for an application resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ImportApplicationIaCResponse ImportApplicationIaC(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            ImportApplicationIaC(new ImportApplicationIaCRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Imports IaC for an application resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportApplicationIaCResponse> ImportApplicationIaCAsync(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            ImportApplicationIaCAsync(new ImportApplicationIaCRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Imports IaC for an application resource.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ImportApplicationIaCResponse> ImportApplicationIaCAsync(ApplicationName name, st::CancellationToken cancellationToken) =>
            ImportApplicationIaCAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Register deployed resources from terraform state file with App Hub
        /// without needing a space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RegisterAppHubApplicationResourcesResponse, OperationMetadata> RegisterAppHubApplicationResources(RegisterAppHubApplicationResourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Register deployed resources from terraform state file with App Hub
        /// without needing a space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RegisterAppHubApplicationResourcesResponse, OperationMetadata>> RegisterAppHubApplicationResourcesAsync(RegisterAppHubApplicationResourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Register deployed resources from terraform state file with App Hub
        /// without needing a space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RegisterAppHubApplicationResourcesResponse, OperationMetadata>> RegisterAppHubApplicationResourcesAsync(RegisterAppHubApplicationResourcesRequest request, st::CancellationToken cancellationToken) =>
            RegisterAppHubApplicationResourcesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RegisterAppHubApplicationResources</c>.</summary>
        public virtual lro::OperationsClient RegisterAppHubApplicationResourcesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RegisterAppHubApplicationResources</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<RegisterAppHubApplicationResourcesResponse, OperationMetadata> PollOnceRegisterAppHubApplicationResources(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RegisterAppHubApplicationResourcesResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RegisterAppHubApplicationResourcesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RegisterAppHubApplicationResources</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<RegisterAppHubApplicationResourcesResponse, OperationMetadata>> PollOnceRegisterAppHubApplicationResourcesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RegisterAppHubApplicationResourcesResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RegisterAppHubApplicationResourcesOperationsClient, callSettings);

        /// <summary>
        /// Register deployed resources from terraform state file with App Hub
        /// without needing a space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="apphubApplication">
        /// Required. The name of the AppHub Application.
        /// Format:
        /// projects/{project}/locations/{location}/applications/{application}
        /// </param>
        /// <param name="tfstateContent">
        /// Optional. The Terraform state (tfstate) content as a raw string.
        /// For large state files exceeding 10MB, use the 'tfstate_signed_gcs_uri'
        /// field instead.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RegisterAppHubApplicationResourcesResponse, OperationMetadata> RegisterAppHubApplicationResources(string parent, string apphubApplication, string tfstateContent, gaxgrpc::CallSettings callSettings = null) =>
            RegisterAppHubApplicationResources(new RegisterAppHubApplicationResourcesRequest
            {
                TfstateContent = tfstateContent ?? "",
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ApphubApplication = gax::GaxPreconditions.CheckNotNullOrEmpty(apphubApplication, nameof(apphubApplication)),
            }, callSettings);

        /// <summary>
        /// Register deployed resources from terraform state file with App Hub
        /// without needing a space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="apphubApplication">
        /// Required. The name of the AppHub Application.
        /// Format:
        /// projects/{project}/locations/{location}/applications/{application}
        /// </param>
        /// <param name="tfstateContent">
        /// Optional. The Terraform state (tfstate) content as a raw string.
        /// For large state files exceeding 10MB, use the 'tfstate_signed_gcs_uri'
        /// field instead.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RegisterAppHubApplicationResourcesResponse, OperationMetadata>> RegisterAppHubApplicationResourcesAsync(string parent, string apphubApplication, string tfstateContent, gaxgrpc::CallSettings callSettings = null) =>
            RegisterAppHubApplicationResourcesAsync(new RegisterAppHubApplicationResourcesRequest
            {
                TfstateContent = tfstateContent ?? "",
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ApphubApplication = gax::GaxPreconditions.CheckNotNullOrEmpty(apphubApplication, nameof(apphubApplication)),
            }, callSettings);

        /// <summary>
        /// Register deployed resources from terraform state file with App Hub
        /// without needing a space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="apphubApplication">
        /// Required. The name of the AppHub Application.
        /// Format:
        /// projects/{project}/locations/{location}/applications/{application}
        /// </param>
        /// <param name="tfstateContent">
        /// Optional. The Terraform state (tfstate) content as a raw string.
        /// For large state files exceeding 10MB, use the 'tfstate_signed_gcs_uri'
        /// field instead.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RegisterAppHubApplicationResourcesResponse, OperationMetadata>> RegisterAppHubApplicationResourcesAsync(string parent, string apphubApplication, string tfstateContent, st::CancellationToken cancellationToken) =>
            RegisterAppHubApplicationResourcesAsync(parent, apphubApplication, tfstateContent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Register deployed resources from terraform state file with App Hub
        /// without needing a space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="apphubApplication">
        /// Required. The name of the AppHub Application.
        /// Format:
        /// projects/{project}/locations/{location}/applications/{application}
        /// </param>
        /// <param name="tfstateContent">
        /// Optional. The Terraform state (tfstate) content as a raw string.
        /// For large state files exceeding 10MB, use the 'tfstate_signed_gcs_uri'
        /// field instead.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RegisterAppHubApplicationResourcesResponse, OperationMetadata> RegisterAppHubApplicationResources(gagr::LocationName parent, string apphubApplication, string tfstateContent, gaxgrpc::CallSettings callSettings = null) =>
            RegisterAppHubApplicationResources(new RegisterAppHubApplicationResourcesRequest
            {
                TfstateContent = tfstateContent ?? "",
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ApphubApplication = gax::GaxPreconditions.CheckNotNullOrEmpty(apphubApplication, nameof(apphubApplication)),
            }, callSettings);

        /// <summary>
        /// Register deployed resources from terraform state file with App Hub
        /// without needing a space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="apphubApplication">
        /// Required. The name of the AppHub Application.
        /// Format:
        /// projects/{project}/locations/{location}/applications/{application}
        /// </param>
        /// <param name="tfstateContent">
        /// Optional. The Terraform state (tfstate) content as a raw string.
        /// For large state files exceeding 10MB, use the 'tfstate_signed_gcs_uri'
        /// field instead.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RegisterAppHubApplicationResourcesResponse, OperationMetadata>> RegisterAppHubApplicationResourcesAsync(gagr::LocationName parent, string apphubApplication, string tfstateContent, gaxgrpc::CallSettings callSettings = null) =>
            RegisterAppHubApplicationResourcesAsync(new RegisterAppHubApplicationResourcesRequest
            {
                TfstateContent = tfstateContent ?? "",
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ApphubApplication = gax::GaxPreconditions.CheckNotNullOrEmpty(apphubApplication, nameof(apphubApplication)),
            }, callSettings);

        /// <summary>
        /// Register deployed resources from terraform state file with App Hub
        /// without needing a space.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent location.
        /// Format: projects/{project}/locations/{location}
        /// </param>
        /// <param name="apphubApplication">
        /// Required. The name of the AppHub Application.
        /// Format:
        /// projects/{project}/locations/{location}/applications/{application}
        /// </param>
        /// <param name="tfstateContent">
        /// Optional. The Terraform state (tfstate) content as a raw string.
        /// For large state files exceeding 10MB, use the 'tfstate_signed_gcs_uri'
        /// field instead.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RegisterAppHubApplicationResourcesResponse, OperationMetadata>> RegisterAppHubApplicationResourcesAsync(gagr::LocationName parent, string apphubApplication, string tfstateContent, st::CancellationToken cancellationToken) =>
            RegisterAppHubApplicationResourcesAsync(parent, apphubApplication, tfstateContent, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists application template system revisions in a given application
        /// template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ApplicationTemplateSystemRevision"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApplicationTemplateSystemRevisionsResponse, ApplicationTemplateSystemRevision> ListApplicationTemplateSystemRevisions(ListApplicationTemplateSystemRevisionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists application template system revisions in a given application
        /// template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ApplicationTemplateSystemRevision"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListApplicationTemplateSystemRevisionsResponse, ApplicationTemplateSystemRevision> ListApplicationTemplateSystemRevisionsAsync(ListApplicationTemplateSystemRevisionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists application template system revisions in a given application
        /// template.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent Application Template from which to list the system
        /// revisions. Format:
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}
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
        /// <returns>A pageable sequence of <see cref="ApplicationTemplateSystemRevision"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApplicationTemplateSystemRevisionsResponse, ApplicationTemplateSystemRevision> ListApplicationTemplateSystemRevisions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApplicationTemplateSystemRevisionsRequest request = new ListApplicationTemplateSystemRevisionsRequest
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
            return ListApplicationTemplateSystemRevisions(request, callSettings);
        }

        /// <summary>
        /// Lists application template system revisions in a given application
        /// template.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent Application Template from which to list the system
        /// revisions. Format:
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}
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
        /// A pageable asynchronous sequence of <see cref="ApplicationTemplateSystemRevision"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListApplicationTemplateSystemRevisionsResponse, ApplicationTemplateSystemRevision> ListApplicationTemplateSystemRevisionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApplicationTemplateSystemRevisionsRequest request = new ListApplicationTemplateSystemRevisionsRequest
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
            return ListApplicationTemplateSystemRevisionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists application template system revisions in a given application
        /// template.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent Application Template from which to list the system
        /// revisions. Format:
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}
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
        /// <returns>A pageable sequence of <see cref="ApplicationTemplateSystemRevision"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListApplicationTemplateSystemRevisionsResponse, ApplicationTemplateSystemRevision> ListApplicationTemplateSystemRevisions(ApplicationTemplateName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApplicationTemplateSystemRevisionsRequest request = new ListApplicationTemplateSystemRevisionsRequest
            {
                ParentAsApplicationTemplateName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListApplicationTemplateSystemRevisions(request, callSettings);
        }

        /// <summary>
        /// Lists application template system revisions in a given application
        /// template.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent Application Template from which to list the system
        /// revisions. Format:
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}
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
        /// A pageable asynchronous sequence of <see cref="ApplicationTemplateSystemRevision"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListApplicationTemplateSystemRevisionsResponse, ApplicationTemplateSystemRevision> ListApplicationTemplateSystemRevisionsAsync(ApplicationTemplateName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListApplicationTemplateSystemRevisionsRequest request = new ListApplicationTemplateSystemRevisionsRequest
            {
                ParentAsApplicationTemplateName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListApplicationTemplateSystemRevisionsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the given application template system revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApplicationTemplateSystemRevision GetApplicationTemplateSystemRevision(GetApplicationTemplateSystemRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the given application template system revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplicationTemplateSystemRevision> GetApplicationTemplateSystemRevisionAsync(GetApplicationTemplateSystemRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the given application template system revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplicationTemplateSystemRevision> GetApplicationTemplateSystemRevisionAsync(GetApplicationTemplateSystemRevisionRequest request, st::CancellationToken cancellationToken) =>
            GetApplicationTemplateSystemRevisionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the given application template system revision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ApplicationTemplateSystemRevision to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/systemRevisions/{system_revision}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApplicationTemplateSystemRevision GetApplicationTemplateSystemRevision(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetApplicationTemplateSystemRevision(new GetApplicationTemplateSystemRevisionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the given application template system revision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ApplicationTemplateSystemRevision to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/systemRevisions/{system_revision}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplicationTemplateSystemRevision> GetApplicationTemplateSystemRevisionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetApplicationTemplateSystemRevisionAsync(new GetApplicationTemplateSystemRevisionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the given application template system revision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ApplicationTemplateSystemRevision to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/systemRevisions/{system_revision}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplicationTemplateSystemRevision> GetApplicationTemplateSystemRevisionAsync(string name, st::CancellationToken cancellationToken) =>
            GetApplicationTemplateSystemRevisionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the given application template system revision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ApplicationTemplateSystemRevision to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/systemRevisions/{system_revision}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ApplicationTemplateSystemRevision GetApplicationTemplateSystemRevision(ApplicationTemplateSystemRevisionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetApplicationTemplateSystemRevision(new GetApplicationTemplateSystemRevisionRequest
            {
                ApplicationTemplateSystemRevisionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the given application template system revision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ApplicationTemplateSystemRevision to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/systemRevisions/{system_revision}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplicationTemplateSystemRevision> GetApplicationTemplateSystemRevisionAsync(ApplicationTemplateSystemRevisionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetApplicationTemplateSystemRevisionAsync(new GetApplicationTemplateSystemRevisionRequest
            {
                ApplicationTemplateSystemRevisionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the given application template system revision.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the ApplicationTemplateSystemRevision to retrieve.
        /// Format:
        /// projects/{project}/locations/{location}/spaces/{space}/applicationTemplates/{application_template}/systemRevisions/{system_revision}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ApplicationTemplateSystemRevision> GetApplicationTemplateSystemRevisionAsync(ApplicationTemplateSystemRevisionName name, st::CancellationToken cancellationToken) =>
            GetApplicationTemplateSystemRevisionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets recommended IAM roles for an application.
        /// 
        /// Evaluates the infrastructure resources defined by an application (including
        /// its template configuration and parameters) to determine the set of IAM
        /// roles and Google Cloud APIs that you must configure before you deploy
        /// across target projects.
        /// 
        /// The operation is asynchronous and returns a `google.longrunning.Operation`.
        /// Upon completion, the operation result contains a
        /// `RecommendIAMRolesResponse` with project-level IAM role and API
        /// recommendations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RecommendIAMRolesResponse, OperationMetadata> RecommendIAMRoles(RecommendIAMRolesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets recommended IAM roles for an application.
        /// 
        /// Evaluates the infrastructure resources defined by an application (including
        /// its template configuration and parameters) to determine the set of IAM
        /// roles and Google Cloud APIs that you must configure before you deploy
        /// across target projects.
        /// 
        /// The operation is asynchronous and returns a `google.longrunning.Operation`.
        /// Upon completion, the operation result contains a
        /// `RecommendIAMRolesResponse` with project-level IAM role and API
        /// recommendations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RecommendIAMRolesResponse, OperationMetadata>> RecommendIAMRolesAsync(RecommendIAMRolesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets recommended IAM roles for an application.
        /// 
        /// Evaluates the infrastructure resources defined by an application (including
        /// its template configuration and parameters) to determine the set of IAM
        /// roles and Google Cloud APIs that you must configure before you deploy
        /// across target projects.
        /// 
        /// The operation is asynchronous and returns a `google.longrunning.Operation`.
        /// Upon completion, the operation result contains a
        /// `RecommendIAMRolesResponse` with project-level IAM role and API
        /// recommendations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RecommendIAMRolesResponse, OperationMetadata>> RecommendIAMRolesAsync(RecommendIAMRolesRequest request, st::CancellationToken cancellationToken) =>
            RecommendIAMRolesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RecommendIAMRoles</c>.</summary>
        public virtual lro::OperationsClient RecommendIAMRolesOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RecommendIAMRoles</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<RecommendIAMRolesResponse, OperationMetadata> PollOnceRecommendIAMRoles(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RecommendIAMRolesResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RecommendIAMRolesOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RecommendIAMRoles</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<RecommendIAMRolesResponse, OperationMetadata>> PollOnceRecommendIAMRolesAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<RecommendIAMRolesResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RecommendIAMRolesOperationsClient, callSettings);

        /// <summary>
        /// Gets recommended IAM roles for an application.
        /// 
        /// Evaluates the infrastructure resources defined by an application (including
        /// its template configuration and parameters) to determine the set of IAM
        /// roles and Google Cloud APIs that you must configure before you deploy
        /// across target projects.
        /// 
        /// The operation is asynchronous and returns a `google.longrunning.Operation`.
        /// Upon completion, the operation result contains a
        /// `RecommendIAMRolesResponse` with project-level IAM role and API
        /// recommendations.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application resource for which to recommend IAM
        /// roles. Format:
        /// projects/$project/locations/$location/spaces/$space/applications/$application
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RecommendIAMRolesResponse, OperationMetadata> RecommendIAMRoles(string name, gaxgrpc::CallSettings callSettings = null) =>
            RecommendIAMRoles(new RecommendIAMRolesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets recommended IAM roles for an application.
        /// 
        /// Evaluates the infrastructure resources defined by an application (including
        /// its template configuration and parameters) to determine the set of IAM
        /// roles and Google Cloud APIs that you must configure before you deploy
        /// across target projects.
        /// 
        /// The operation is asynchronous and returns a `google.longrunning.Operation`.
        /// Upon completion, the operation result contains a
        /// `RecommendIAMRolesResponse` with project-level IAM role and API
        /// recommendations.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application resource for which to recommend IAM
        /// roles. Format:
        /// projects/$project/locations/$location/spaces/$space/applications/$application
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RecommendIAMRolesResponse, OperationMetadata>> RecommendIAMRolesAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            RecommendIAMRolesAsync(new RecommendIAMRolesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets recommended IAM roles for an application.
        /// 
        /// Evaluates the infrastructure resources defined by an application (including
        /// its template configuration and parameters) to determine the set of IAM
        /// roles and Google Cloud APIs that you must configure before you deploy
        /// across target projects.
        /// 
        /// The operation is asynchronous and returns a `google.longrunning.Operation`.
        /// Upon completion, the operation result contains a
        /// `RecommendIAMRolesResponse` with project-level IAM role and API
        /// recommendations.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application resource for which to recommend IAM
        /// roles. Format:
        /// projects/$project/locations/$location/spaces/$space/applications/$application
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RecommendIAMRolesResponse, OperationMetadata>> RecommendIAMRolesAsync(string name, st::CancellationToken cancellationToken) =>
            RecommendIAMRolesAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets recommended IAM roles for an application.
        /// 
        /// Evaluates the infrastructure resources defined by an application (including
        /// its template configuration and parameters) to determine the set of IAM
        /// roles and Google Cloud APIs that you must configure before you deploy
        /// across target projects.
        /// 
        /// The operation is asynchronous and returns a `google.longrunning.Operation`.
        /// Upon completion, the operation result contains a
        /// `RecommendIAMRolesResponse` with project-level IAM role and API
        /// recommendations.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application resource for which to recommend IAM
        /// roles. Format:
        /// projects/$project/locations/$location/spaces/$space/applications/$application
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<RecommendIAMRolesResponse, OperationMetadata> RecommendIAMRoles(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            RecommendIAMRoles(new RecommendIAMRolesRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets recommended IAM roles for an application.
        /// 
        /// Evaluates the infrastructure resources defined by an application (including
        /// its template configuration and parameters) to determine the set of IAM
        /// roles and Google Cloud APIs that you must configure before you deploy
        /// across target projects.
        /// 
        /// The operation is asynchronous and returns a `google.longrunning.Operation`.
        /// Upon completion, the operation result contains a
        /// `RecommendIAMRolesResponse` with project-level IAM role and API
        /// recommendations.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application resource for which to recommend IAM
        /// roles. Format:
        /// projects/$project/locations/$location/spaces/$space/applications/$application
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RecommendIAMRolesResponse, OperationMetadata>> RecommendIAMRolesAsync(ApplicationName name, gaxgrpc::CallSettings callSettings = null) =>
            RecommendIAMRolesAsync(new RecommendIAMRolesRequest
            {
                ApplicationName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets recommended IAM roles for an application.
        /// 
        /// Evaluates the infrastructure resources defined by an application (including
        /// its template configuration and parameters) to determine the set of IAM
        /// roles and Google Cloud APIs that you must configure before you deploy
        /// across target projects.
        /// 
        /// The operation is asynchronous and returns a `google.longrunning.Operation`.
        /// Upon completion, the operation result contains a
        /// `RecommendIAMRolesResponse` with project-level IAM role and API
        /// recommendations.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the application resource for which to recommend IAM
        /// roles. Format:
        /// projects/$project/locations/$location/spaces/$space/applications/$application
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<RecommendIAMRolesResponse, OperationMetadata>> RecommendIAMRolesAsync(ApplicationName name, st::CancellationToken cancellationToken) =>
            RecommendIAMRolesAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DesignCenter client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public sealed partial class DesignCenterClientImpl : DesignCenterClient
    {
        private readonly gaxgrpc::ApiCall<GetSpaceRequest, Space> _callGetSpace;

        private readonly gaxgrpc::ApiCall<ListSpacesRequest, ListSpacesResponse> _callListSpaces;

        private readonly gaxgrpc::ApiCall<CreateSpaceRequest, Space> _callCreateSpace;

        private readonly gaxgrpc::ApiCall<UpdateSpaceRequest, Space> _callUpdateSpace;

        private readonly gaxgrpc::ApiCall<DeleteSpaceRequest, wkt::Empty> _callDeleteSpace;

        private readonly gaxgrpc::ApiCall<GetApplicationTemplateRequest, ApplicationTemplate> _callGetApplicationTemplate;

        private readonly gaxgrpc::ApiCall<ListApplicationTemplatesRequest, ListApplicationTemplatesResponse> _callListApplicationTemplates;

        private readonly gaxgrpc::ApiCall<CreateApplicationTemplateRequest, ApplicationTemplate> _callCreateApplicationTemplate;

        private readonly gaxgrpc::ApiCall<UpdateApplicationTemplateRequest, ApplicationTemplate> _callUpdateApplicationTemplate;

        private readonly gaxgrpc::ApiCall<ImportApplicationTemplateRequest, ApplicationTemplate> _callImportApplicationTemplate;

        private readonly gaxgrpc::ApiCall<DeleteApplicationTemplateRequest, wkt::Empty> _callDeleteApplicationTemplate;

        private readonly gaxgrpc::ApiCall<CommitApplicationTemplateRequest, ApplicationTemplateRevision> _callCommitApplicationTemplate;

        private readonly gaxgrpc::ApiCall<SnapshotApplicationTemplateRequest, lro::Operation> _callSnapshotApplicationTemplate;

        private readonly gaxgrpc::ApiCall<GenerateApplicationTemplateIaCRequest, GenerateApplicationTemplateIaCResponse> _callGenerateApplicationTemplateIaC;

        private readonly gaxgrpc::ApiCall<ExportApplicationTemplateIaCRequest, lro::Operation> _callExportApplicationTemplateIaC;

        private readonly gaxgrpc::ApiCall<GenerateApplicationTemplateRevisionIaCRequest, GenerateApplicationTemplateRevisionIaCResponse> _callGenerateApplicationTemplateRevisionIaC;

        private readonly gaxgrpc::ApiCall<ExportApplicationTemplateRevisionIaCRequest, lro::Operation> _callExportApplicationTemplateRevisionIaC;

        private readonly gaxgrpc::ApiCall<GetComponentRequest, Component> _callGetComponent;

        private readonly gaxgrpc::ApiCall<ListComponentsRequest, ListComponentsResponse> _callListComponents;

        private readonly gaxgrpc::ApiCall<CreateComponentRequest, Component> _callCreateComponent;

        private readonly gaxgrpc::ApiCall<UpdateComponentRequest, Component> _callUpdateComponent;

        private readonly gaxgrpc::ApiCall<DeleteComponentRequest, wkt::Empty> _callDeleteComponent;

        private readonly gaxgrpc::ApiCall<GetConnectionRequest, Connection> _callGetConnection;

        private readonly gaxgrpc::ApiCall<ListConnectionsRequest, ListConnectionsResponse> _callListConnections;

        private readonly gaxgrpc::ApiCall<CreateConnectionRequest, Connection> _callCreateConnection;

        private readonly gaxgrpc::ApiCall<UpdateConnectionRequest, Connection> _callUpdateConnection;

        private readonly gaxgrpc::ApiCall<DeleteConnectionRequest, wkt::Empty> _callDeleteConnection;

        private readonly gaxgrpc::ApiCall<GetApplicationTemplateRevisionRequest, ApplicationTemplateRevision> _callGetApplicationTemplateRevision;

        private readonly gaxgrpc::ApiCall<ListApplicationTemplateRevisionsRequest, ListApplicationTemplateRevisionsResponse> _callListApplicationTemplateRevisions;

        private readonly gaxgrpc::ApiCall<DeleteApplicationTemplateRevisionRequest, wkt::Empty> _callDeleteApplicationTemplateRevision;

        private readonly gaxgrpc::ApiCall<GetCatalogRequest, Catalog> _callGetCatalog;

        private readonly gaxgrpc::ApiCall<ListCatalogsRequest, ListCatalogsResponse> _callListCatalogs;

        private readonly gaxgrpc::ApiCall<CreateCatalogRequest, Catalog> _callCreateCatalog;

        private readonly gaxgrpc::ApiCall<UpdateCatalogRequest, Catalog> _callUpdateCatalog;

        private readonly gaxgrpc::ApiCall<DeleteCatalogRequest, lro::Operation> _callDeleteCatalog;

        private readonly gaxgrpc::ApiCall<CreateCatalogTemplateRequest, CatalogTemplate> _callCreateCatalogTemplate;

        private readonly gaxgrpc::ApiCall<GetCatalogTemplateRequest, CatalogTemplate> _callGetCatalogTemplate;

        private readonly gaxgrpc::ApiCall<ListCatalogTemplatesRequest, ListCatalogTemplatesResponse> _callListCatalogTemplates;

        private readonly gaxgrpc::ApiCall<UpdateCatalogTemplateRequest, CatalogTemplate> _callUpdateCatalogTemplate;

        private readonly gaxgrpc::ApiCall<DeleteCatalogTemplateRequest, lro::Operation> _callDeleteCatalogTemplate;

        private readonly gaxgrpc::ApiCall<CreateShareRequest, lro::Operation> _callCreateShare;

        private readonly gaxgrpc::ApiCall<ListSharesRequest, ListSharesResponse> _callListShares;

        private readonly gaxgrpc::ApiCall<GetShareRequest, Share> _callGetShare;

        private readonly gaxgrpc::ApiCall<DeleteShareRequest, lro::Operation> _callDeleteShare;

        private readonly gaxgrpc::ApiCall<SyncShareRequest, lro::Operation> _callSyncShare;

        private readonly gaxgrpc::ApiCall<GetSharedTemplateRequest, SharedTemplate> _callGetSharedTemplate;

        private readonly gaxgrpc::ApiCall<ListSharedTemplatesRequest, ListSharedTemplatesResponse> _callListSharedTemplates;

        private readonly gaxgrpc::ApiCall<GetSharedTemplateRevisionRequest, SharedTemplateRevision> _callGetSharedTemplateRevision;

        private readonly gaxgrpc::ApiCall<ListSharedTemplateRevisionsRequest, ListSharedTemplateRevisionsResponse> _callListSharedTemplateRevisions;

        private readonly gaxgrpc::ApiCall<CreateCatalogTemplateRevisionRequest, lro::Operation> _callCreateCatalogTemplateRevision;

        private readonly gaxgrpc::ApiCall<GetCatalogTemplateRevisionRequest, CatalogTemplateRevision> _callGetCatalogTemplateRevision;

        private readonly gaxgrpc::ApiCall<ListCatalogTemplateRevisionsRequest, ListCatalogTemplateRevisionsResponse> _callListCatalogTemplateRevisions;

        private readonly gaxgrpc::ApiCall<DeleteCatalogTemplateRevisionRequest, lro::Operation> _callDeleteCatalogTemplateRevision;

        private readonly gaxgrpc::ApiCall<CreateApplicationRequest, Application> _callCreateApplication;

        private readonly gaxgrpc::ApiCall<GetApplicationRequest, Application> _callGetApplication;

        private readonly gaxgrpc::ApiCall<ListApplicationsRequest, ListApplicationsResponse> _callListApplications;

        private readonly gaxgrpc::ApiCall<UpdateApplicationRequest, Application> _callUpdateApplication;

        private readonly gaxgrpc::ApiCall<DeleteApplicationRequest, lro::Operation> _callDeleteApplication;

        private readonly gaxgrpc::ApiCall<DeployApplicationRequest, lro::Operation> _callDeployApplication;

        private readonly gaxgrpc::ApiCall<PreviewApplicationRequest, lro::Operation> _callPreviewApplication;

        private readonly gaxgrpc::ApiCall<FetchApplicationAssessmentReportRequest, FetchApplicationAssessmentReportResponse> _callFetchApplicationAssessmentReport;

        private readonly gaxgrpc::ApiCall<GenerateApplicationAssessmentReportRequest, lro::Operation> _callGenerateApplicationAssessmentReport;

        private readonly gaxgrpc::ApiCall<GenerateApplicationTemplateAssessmentReportRequest, lro::Operation> _callGenerateApplicationTemplateAssessmentReport;

#pragma warning disable CS0612
        private readonly gaxgrpc::ApiCall<GenerateAssessmentReportRequest, lro::Operation> _callGenerateAssessmentReport;
#pragma warning restore CS0612

        private readonly gaxgrpc::ApiCall<GenerateTerraformPlanAssessmentReportRequest, lro::Operation> _callGenerateTerraformPlanAssessmentReport;

        private readonly gaxgrpc::ApiCall<GetPolicyRequest, Policy> _callGetPolicy;

        private readonly gaxgrpc::ApiCall<ListPoliciesRequest, ListPoliciesResponse> _callListPolicies;

        private readonly gaxgrpc::ApiCall<CreatePolicyRequest, Policy> _callCreatePolicy;

        private readonly gaxgrpc::ApiCall<UpdatePolicyRequest, Policy> _callUpdatePolicy;

        private readonly gaxgrpc::ApiCall<DeletePolicyRequest, wkt::Empty> _callDeletePolicy;

        private readonly gaxgrpc::ApiCall<FetchFrameworksRequest, FetchFrameworksResponse> _callFetchFrameworks;

        private readonly gaxgrpc::ApiCall<GenerateApplicationIaCRequest, GenerateApplicationIaCResponse> _callGenerateApplicationIaC;

        private readonly gaxgrpc::ApiCall<ExportApplicationIaCRequest, lro::Operation> _callExportApplicationIaC;

        private readonly gaxgrpc::ApiCall<ImportApplicationTemplateIaCRequest, ImportApplicationTemplateIaCResponse> _callImportApplicationTemplateIaC;

        private readonly gaxgrpc::ApiCall<IngestApplicationTemplateIaCRequest, lro::Operation> _callIngestApplicationTemplateIaC;

        private readonly gaxgrpc::ApiCall<ImportApplicationIaCRequest, ImportApplicationIaCResponse> _callImportApplicationIaC;

        private readonly gaxgrpc::ApiCall<RegisterAppHubApplicationResourcesRequest, lro::Operation> _callRegisterAppHubApplicationResources;

        private readonly gaxgrpc::ApiCall<ListApplicationTemplateSystemRevisionsRequest, ListApplicationTemplateSystemRevisionsResponse> _callListApplicationTemplateSystemRevisions;

        private readonly gaxgrpc::ApiCall<GetApplicationTemplateSystemRevisionRequest, ApplicationTemplateSystemRevision> _callGetApplicationTemplateSystemRevision;

        private readonly gaxgrpc::ApiCall<RecommendIAMRolesRequest, lro::Operation> _callRecommendIAMRoles;

        /// <summary>
        /// Constructs a client wrapper for the DesignCenter service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DesignCenterSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public DesignCenterClientImpl(DesignCenter.DesignCenterClient grpcClient, DesignCenterSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            DesignCenterSettings effectiveSettings = settings ?? DesignCenterSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            SnapshotApplicationTemplateOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.SnapshotApplicationTemplateOperationsSettings, logger);
            ExportApplicationTemplateIaCOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportApplicationTemplateIaCOperationsSettings, logger);
            ExportApplicationTemplateRevisionIaCOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportApplicationTemplateRevisionIaCOperationsSettings, logger);
            DeleteCatalogOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteCatalogOperationsSettings, logger);
            DeleteCatalogTemplateOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteCatalogTemplateOperationsSettings, logger);
            CreateShareOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateShareOperationsSettings, logger);
            DeleteShareOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteShareOperationsSettings, logger);
            SyncShareOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.SyncShareOperationsSettings, logger);
            CreateCatalogTemplateRevisionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateCatalogTemplateRevisionOperationsSettings, logger);
            DeleteCatalogTemplateRevisionOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteCatalogTemplateRevisionOperationsSettings, logger);
            DeleteApplicationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteApplicationOperationsSettings, logger);
            DeployApplicationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeployApplicationOperationsSettings, logger);
            PreviewApplicationOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.PreviewApplicationOperationsSettings, logger);
            GenerateApplicationAssessmentReportOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.GenerateApplicationAssessmentReportOperationsSettings, logger);
            GenerateApplicationTemplateAssessmentReportOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.GenerateApplicationTemplateAssessmentReportOperationsSettings, logger);
            GenerateAssessmentReportOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.GenerateAssessmentReportOperationsSettings, logger);
            GenerateTerraformPlanAssessmentReportOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.GenerateTerraformPlanAssessmentReportOperationsSettings, logger);
            ExportApplicationIaCOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ExportApplicationIaCOperationsSettings, logger);
            IngestApplicationTemplateIaCOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.IngestApplicationTemplateIaCOperationsSettings, logger);
            RegisterAppHubApplicationResourcesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RegisterAppHubApplicationResourcesOperationsSettings, logger);
            RecommendIAMRolesOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RecommendIAMRolesOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callGetSpace = clientHelper.BuildApiCall<GetSpaceRequest, Space>("GetSpace", grpcClient.GetSpaceAsync, grpcClient.GetSpace, effectiveSettings.GetSpaceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSpace);
            Modify_GetSpaceApiCall(ref _callGetSpace);
            _callListSpaces = clientHelper.BuildApiCall<ListSpacesRequest, ListSpacesResponse>("ListSpaces", grpcClient.ListSpacesAsync, grpcClient.ListSpaces, effectiveSettings.ListSpacesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSpaces);
            Modify_ListSpacesApiCall(ref _callListSpaces);
            _callCreateSpace = clientHelper.BuildApiCall<CreateSpaceRequest, Space>("CreateSpace", grpcClient.CreateSpaceAsync, grpcClient.CreateSpace, effectiveSettings.CreateSpaceSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSpace);
            Modify_CreateSpaceApiCall(ref _callCreateSpace);
            _callUpdateSpace = clientHelper.BuildApiCall<UpdateSpaceRequest, Space>("UpdateSpace", grpcClient.UpdateSpaceAsync, grpcClient.UpdateSpace, effectiveSettings.UpdateSpaceSettings).WithGoogleRequestParam("space.name", request => request.Space?.Name);
            Modify_ApiCall(ref _callUpdateSpace);
            Modify_UpdateSpaceApiCall(ref _callUpdateSpace);
            _callDeleteSpace = clientHelper.BuildApiCall<DeleteSpaceRequest, wkt::Empty>("DeleteSpace", grpcClient.DeleteSpaceAsync, grpcClient.DeleteSpace, effectiveSettings.DeleteSpaceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSpace);
            Modify_DeleteSpaceApiCall(ref _callDeleteSpace);
            _callGetApplicationTemplate = clientHelper.BuildApiCall<GetApplicationTemplateRequest, ApplicationTemplate>("GetApplicationTemplate", grpcClient.GetApplicationTemplateAsync, grpcClient.GetApplicationTemplate, effectiveSettings.GetApplicationTemplateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetApplicationTemplate);
            Modify_GetApplicationTemplateApiCall(ref _callGetApplicationTemplate);
            _callListApplicationTemplates = clientHelper.BuildApiCall<ListApplicationTemplatesRequest, ListApplicationTemplatesResponse>("ListApplicationTemplates", grpcClient.ListApplicationTemplatesAsync, grpcClient.ListApplicationTemplates, effectiveSettings.ListApplicationTemplatesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListApplicationTemplates);
            Modify_ListApplicationTemplatesApiCall(ref _callListApplicationTemplates);
            _callCreateApplicationTemplate = clientHelper.BuildApiCall<CreateApplicationTemplateRequest, ApplicationTemplate>("CreateApplicationTemplate", grpcClient.CreateApplicationTemplateAsync, grpcClient.CreateApplicationTemplate, effectiveSettings.CreateApplicationTemplateSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateApplicationTemplate);
            Modify_CreateApplicationTemplateApiCall(ref _callCreateApplicationTemplate);
            _callUpdateApplicationTemplate = clientHelper.BuildApiCall<UpdateApplicationTemplateRequest, ApplicationTemplate>("UpdateApplicationTemplate", grpcClient.UpdateApplicationTemplateAsync, grpcClient.UpdateApplicationTemplate, effectiveSettings.UpdateApplicationTemplateSettings).WithGoogleRequestParam("application_template.name", request => request.ApplicationTemplate?.Name);
            Modify_ApiCall(ref _callUpdateApplicationTemplate);
            Modify_UpdateApplicationTemplateApiCall(ref _callUpdateApplicationTemplate);
            _callImportApplicationTemplate = clientHelper.BuildApiCall<ImportApplicationTemplateRequest, ApplicationTemplate>("ImportApplicationTemplate", grpcClient.ImportApplicationTemplateAsync, grpcClient.ImportApplicationTemplate, effectiveSettings.ImportApplicationTemplateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callImportApplicationTemplate);
            Modify_ImportApplicationTemplateApiCall(ref _callImportApplicationTemplate);
            _callDeleteApplicationTemplate = clientHelper.BuildApiCall<DeleteApplicationTemplateRequest, wkt::Empty>("DeleteApplicationTemplate", grpcClient.DeleteApplicationTemplateAsync, grpcClient.DeleteApplicationTemplate, effectiveSettings.DeleteApplicationTemplateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteApplicationTemplate);
            Modify_DeleteApplicationTemplateApiCall(ref _callDeleteApplicationTemplate);
            _callCommitApplicationTemplate = clientHelper.BuildApiCall<CommitApplicationTemplateRequest, ApplicationTemplateRevision>("CommitApplicationTemplate", grpcClient.CommitApplicationTemplateAsync, grpcClient.CommitApplicationTemplate, effectiveSettings.CommitApplicationTemplateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCommitApplicationTemplate);
            Modify_CommitApplicationTemplateApiCall(ref _callCommitApplicationTemplate);
            _callSnapshotApplicationTemplate = clientHelper.BuildApiCall<SnapshotApplicationTemplateRequest, lro::Operation>("SnapshotApplicationTemplate", grpcClient.SnapshotApplicationTemplateAsync, grpcClient.SnapshotApplicationTemplate, effectiveSettings.SnapshotApplicationTemplateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callSnapshotApplicationTemplate);
            Modify_SnapshotApplicationTemplateApiCall(ref _callSnapshotApplicationTemplate);
            _callGenerateApplicationTemplateIaC = clientHelper.BuildApiCall<GenerateApplicationTemplateIaCRequest, GenerateApplicationTemplateIaCResponse>("GenerateApplicationTemplateIaC", grpcClient.GenerateApplicationTemplateIaCAsync, grpcClient.GenerateApplicationTemplateIaC, effectiveSettings.GenerateApplicationTemplateIaCSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGenerateApplicationTemplateIaC);
            Modify_GenerateApplicationTemplateIaCApiCall(ref _callGenerateApplicationTemplateIaC);
            _callExportApplicationTemplateIaC = clientHelper.BuildApiCall<ExportApplicationTemplateIaCRequest, lro::Operation>("ExportApplicationTemplateIaC", grpcClient.ExportApplicationTemplateIaCAsync, grpcClient.ExportApplicationTemplateIaC, effectiveSettings.ExportApplicationTemplateIaCSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callExportApplicationTemplateIaC);
            Modify_ExportApplicationTemplateIaCApiCall(ref _callExportApplicationTemplateIaC);
            _callGenerateApplicationTemplateRevisionIaC = clientHelper.BuildApiCall<GenerateApplicationTemplateRevisionIaCRequest, GenerateApplicationTemplateRevisionIaCResponse>("GenerateApplicationTemplateRevisionIaC", grpcClient.GenerateApplicationTemplateRevisionIaCAsync, grpcClient.GenerateApplicationTemplateRevisionIaC, effectiveSettings.GenerateApplicationTemplateRevisionIaCSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGenerateApplicationTemplateRevisionIaC);
            Modify_GenerateApplicationTemplateRevisionIaCApiCall(ref _callGenerateApplicationTemplateRevisionIaC);
            _callExportApplicationTemplateRevisionIaC = clientHelper.BuildApiCall<ExportApplicationTemplateRevisionIaCRequest, lro::Operation>("ExportApplicationTemplateRevisionIaC", grpcClient.ExportApplicationTemplateRevisionIaCAsync, grpcClient.ExportApplicationTemplateRevisionIaC, effectiveSettings.ExportApplicationTemplateRevisionIaCSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callExportApplicationTemplateRevisionIaC);
            Modify_ExportApplicationTemplateRevisionIaCApiCall(ref _callExportApplicationTemplateRevisionIaC);
            _callGetComponent = clientHelper.BuildApiCall<GetComponentRequest, Component>("GetComponent", grpcClient.GetComponentAsync, grpcClient.GetComponent, effectiveSettings.GetComponentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetComponent);
            Modify_GetComponentApiCall(ref _callGetComponent);
            _callListComponents = clientHelper.BuildApiCall<ListComponentsRequest, ListComponentsResponse>("ListComponents", grpcClient.ListComponentsAsync, grpcClient.ListComponents, effectiveSettings.ListComponentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListComponents);
            Modify_ListComponentsApiCall(ref _callListComponents);
            _callCreateComponent = clientHelper.BuildApiCall<CreateComponentRequest, Component>("CreateComponent", grpcClient.CreateComponentAsync, grpcClient.CreateComponent, effectiveSettings.CreateComponentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateComponent);
            Modify_CreateComponentApiCall(ref _callCreateComponent);
            _callUpdateComponent = clientHelper.BuildApiCall<UpdateComponentRequest, Component>("UpdateComponent", grpcClient.UpdateComponentAsync, grpcClient.UpdateComponent, effectiveSettings.UpdateComponentSettings).WithGoogleRequestParam("component.name", request => request.Component?.Name);
            Modify_ApiCall(ref _callUpdateComponent);
            Modify_UpdateComponentApiCall(ref _callUpdateComponent);
            _callDeleteComponent = clientHelper.BuildApiCall<DeleteComponentRequest, wkt::Empty>("DeleteComponent", grpcClient.DeleteComponentAsync, grpcClient.DeleteComponent, effectiveSettings.DeleteComponentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteComponent);
            Modify_DeleteComponentApiCall(ref _callDeleteComponent);
            _callGetConnection = clientHelper.BuildApiCall<GetConnectionRequest, Connection>("GetConnection", grpcClient.GetConnectionAsync, grpcClient.GetConnection, effectiveSettings.GetConnectionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetConnection);
            Modify_GetConnectionApiCall(ref _callGetConnection);
            _callListConnections = clientHelper.BuildApiCall<ListConnectionsRequest, ListConnectionsResponse>("ListConnections", grpcClient.ListConnectionsAsync, grpcClient.ListConnections, effectiveSettings.ListConnectionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListConnections);
            Modify_ListConnectionsApiCall(ref _callListConnections);
            _callCreateConnection = clientHelper.BuildApiCall<CreateConnectionRequest, Connection>("CreateConnection", grpcClient.CreateConnectionAsync, grpcClient.CreateConnection, effectiveSettings.CreateConnectionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateConnection);
            Modify_CreateConnectionApiCall(ref _callCreateConnection);
            _callUpdateConnection = clientHelper.BuildApiCall<UpdateConnectionRequest, Connection>("UpdateConnection", grpcClient.UpdateConnectionAsync, grpcClient.UpdateConnection, effectiveSettings.UpdateConnectionSettings).WithGoogleRequestParam("connection.name", request => request.Connection?.Name);
            Modify_ApiCall(ref _callUpdateConnection);
            Modify_UpdateConnectionApiCall(ref _callUpdateConnection);
            _callDeleteConnection = clientHelper.BuildApiCall<DeleteConnectionRequest, wkt::Empty>("DeleteConnection", grpcClient.DeleteConnectionAsync, grpcClient.DeleteConnection, effectiveSettings.DeleteConnectionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteConnection);
            Modify_DeleteConnectionApiCall(ref _callDeleteConnection);
            _callGetApplicationTemplateRevision = clientHelper.BuildApiCall<GetApplicationTemplateRevisionRequest, ApplicationTemplateRevision>("GetApplicationTemplateRevision", grpcClient.GetApplicationTemplateRevisionAsync, grpcClient.GetApplicationTemplateRevision, effectiveSettings.GetApplicationTemplateRevisionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetApplicationTemplateRevision);
            Modify_GetApplicationTemplateRevisionApiCall(ref _callGetApplicationTemplateRevision);
            _callListApplicationTemplateRevisions = clientHelper.BuildApiCall<ListApplicationTemplateRevisionsRequest, ListApplicationTemplateRevisionsResponse>("ListApplicationTemplateRevisions", grpcClient.ListApplicationTemplateRevisionsAsync, grpcClient.ListApplicationTemplateRevisions, effectiveSettings.ListApplicationTemplateRevisionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListApplicationTemplateRevisions);
            Modify_ListApplicationTemplateRevisionsApiCall(ref _callListApplicationTemplateRevisions);
            _callDeleteApplicationTemplateRevision = clientHelper.BuildApiCall<DeleteApplicationTemplateRevisionRequest, wkt::Empty>("DeleteApplicationTemplateRevision", grpcClient.DeleteApplicationTemplateRevisionAsync, grpcClient.DeleteApplicationTemplateRevision, effectiveSettings.DeleteApplicationTemplateRevisionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteApplicationTemplateRevision);
            Modify_DeleteApplicationTemplateRevisionApiCall(ref _callDeleteApplicationTemplateRevision);
            _callGetCatalog = clientHelper.BuildApiCall<GetCatalogRequest, Catalog>("GetCatalog", grpcClient.GetCatalogAsync, grpcClient.GetCatalog, effectiveSettings.GetCatalogSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCatalog);
            Modify_GetCatalogApiCall(ref _callGetCatalog);
            _callListCatalogs = clientHelper.BuildApiCall<ListCatalogsRequest, ListCatalogsResponse>("ListCatalogs", grpcClient.ListCatalogsAsync, grpcClient.ListCatalogs, effectiveSettings.ListCatalogsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCatalogs);
            Modify_ListCatalogsApiCall(ref _callListCatalogs);
            _callCreateCatalog = clientHelper.BuildApiCall<CreateCatalogRequest, Catalog>("CreateCatalog", grpcClient.CreateCatalogAsync, grpcClient.CreateCatalog, effectiveSettings.CreateCatalogSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCatalog);
            Modify_CreateCatalogApiCall(ref _callCreateCatalog);
            _callUpdateCatalog = clientHelper.BuildApiCall<UpdateCatalogRequest, Catalog>("UpdateCatalog", grpcClient.UpdateCatalogAsync, grpcClient.UpdateCatalog, effectiveSettings.UpdateCatalogSettings).WithGoogleRequestParam("catalog.name", request => request.Catalog?.Name);
            Modify_ApiCall(ref _callUpdateCatalog);
            Modify_UpdateCatalogApiCall(ref _callUpdateCatalog);
            _callDeleteCatalog = clientHelper.BuildApiCall<DeleteCatalogRequest, lro::Operation>("DeleteCatalog", grpcClient.DeleteCatalogAsync, grpcClient.DeleteCatalog, effectiveSettings.DeleteCatalogSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteCatalog);
            Modify_DeleteCatalogApiCall(ref _callDeleteCatalog);
            _callCreateCatalogTemplate = clientHelper.BuildApiCall<CreateCatalogTemplateRequest, CatalogTemplate>("CreateCatalogTemplate", grpcClient.CreateCatalogTemplateAsync, grpcClient.CreateCatalogTemplate, effectiveSettings.CreateCatalogTemplateSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCatalogTemplate);
            Modify_CreateCatalogTemplateApiCall(ref _callCreateCatalogTemplate);
            _callGetCatalogTemplate = clientHelper.BuildApiCall<GetCatalogTemplateRequest, CatalogTemplate>("GetCatalogTemplate", grpcClient.GetCatalogTemplateAsync, grpcClient.GetCatalogTemplate, effectiveSettings.GetCatalogTemplateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCatalogTemplate);
            Modify_GetCatalogTemplateApiCall(ref _callGetCatalogTemplate);
            _callListCatalogTemplates = clientHelper.BuildApiCall<ListCatalogTemplatesRequest, ListCatalogTemplatesResponse>("ListCatalogTemplates", grpcClient.ListCatalogTemplatesAsync, grpcClient.ListCatalogTemplates, effectiveSettings.ListCatalogTemplatesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCatalogTemplates);
            Modify_ListCatalogTemplatesApiCall(ref _callListCatalogTemplates);
            _callUpdateCatalogTemplate = clientHelper.BuildApiCall<UpdateCatalogTemplateRequest, CatalogTemplate>("UpdateCatalogTemplate", grpcClient.UpdateCatalogTemplateAsync, grpcClient.UpdateCatalogTemplate, effectiveSettings.UpdateCatalogTemplateSettings).WithGoogleRequestParam("catalog_template.name", request => request.CatalogTemplate?.Name);
            Modify_ApiCall(ref _callUpdateCatalogTemplate);
            Modify_UpdateCatalogTemplateApiCall(ref _callUpdateCatalogTemplate);
            _callDeleteCatalogTemplate = clientHelper.BuildApiCall<DeleteCatalogTemplateRequest, lro::Operation>("DeleteCatalogTemplate", grpcClient.DeleteCatalogTemplateAsync, grpcClient.DeleteCatalogTemplate, effectiveSettings.DeleteCatalogTemplateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteCatalogTemplate);
            Modify_DeleteCatalogTemplateApiCall(ref _callDeleteCatalogTemplate);
            _callCreateShare = clientHelper.BuildApiCall<CreateShareRequest, lro::Operation>("CreateShare", grpcClient.CreateShareAsync, grpcClient.CreateShare, effectiveSettings.CreateShareSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateShare);
            Modify_CreateShareApiCall(ref _callCreateShare);
            _callListShares = clientHelper.BuildApiCall<ListSharesRequest, ListSharesResponse>("ListShares", grpcClient.ListSharesAsync, grpcClient.ListShares, effectiveSettings.ListSharesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListShares);
            Modify_ListSharesApiCall(ref _callListShares);
            _callGetShare = clientHelper.BuildApiCall<GetShareRequest, Share>("GetShare", grpcClient.GetShareAsync, grpcClient.GetShare, effectiveSettings.GetShareSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetShare);
            Modify_GetShareApiCall(ref _callGetShare);
            _callDeleteShare = clientHelper.BuildApiCall<DeleteShareRequest, lro::Operation>("DeleteShare", grpcClient.DeleteShareAsync, grpcClient.DeleteShare, effectiveSettings.DeleteShareSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteShare);
            Modify_DeleteShareApiCall(ref _callDeleteShare);
            _callSyncShare = clientHelper.BuildApiCall<SyncShareRequest, lro::Operation>("SyncShare", grpcClient.SyncShareAsync, grpcClient.SyncShare, effectiveSettings.SyncShareSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callSyncShare);
            Modify_SyncShareApiCall(ref _callSyncShare);
            _callGetSharedTemplate = clientHelper.BuildApiCall<GetSharedTemplateRequest, SharedTemplate>("GetSharedTemplate", grpcClient.GetSharedTemplateAsync, grpcClient.GetSharedTemplate, effectiveSettings.GetSharedTemplateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSharedTemplate);
            Modify_GetSharedTemplateApiCall(ref _callGetSharedTemplate);
            _callListSharedTemplates = clientHelper.BuildApiCall<ListSharedTemplatesRequest, ListSharedTemplatesResponse>("ListSharedTemplates", grpcClient.ListSharedTemplatesAsync, grpcClient.ListSharedTemplates, effectiveSettings.ListSharedTemplatesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSharedTemplates);
            Modify_ListSharedTemplatesApiCall(ref _callListSharedTemplates);
            _callGetSharedTemplateRevision = clientHelper.BuildApiCall<GetSharedTemplateRevisionRequest, SharedTemplateRevision>("GetSharedTemplateRevision", grpcClient.GetSharedTemplateRevisionAsync, grpcClient.GetSharedTemplateRevision, effectiveSettings.GetSharedTemplateRevisionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSharedTemplateRevision);
            Modify_GetSharedTemplateRevisionApiCall(ref _callGetSharedTemplateRevision);
            _callListSharedTemplateRevisions = clientHelper.BuildApiCall<ListSharedTemplateRevisionsRequest, ListSharedTemplateRevisionsResponse>("ListSharedTemplateRevisions", grpcClient.ListSharedTemplateRevisionsAsync, grpcClient.ListSharedTemplateRevisions, effectiveSettings.ListSharedTemplateRevisionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSharedTemplateRevisions);
            Modify_ListSharedTemplateRevisionsApiCall(ref _callListSharedTemplateRevisions);
            _callCreateCatalogTemplateRevision = clientHelper.BuildApiCall<CreateCatalogTemplateRevisionRequest, lro::Operation>("CreateCatalogTemplateRevision", grpcClient.CreateCatalogTemplateRevisionAsync, grpcClient.CreateCatalogTemplateRevision, effectiveSettings.CreateCatalogTemplateRevisionSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCatalogTemplateRevision);
            Modify_CreateCatalogTemplateRevisionApiCall(ref _callCreateCatalogTemplateRevision);
            _callGetCatalogTemplateRevision = clientHelper.BuildApiCall<GetCatalogTemplateRevisionRequest, CatalogTemplateRevision>("GetCatalogTemplateRevision", grpcClient.GetCatalogTemplateRevisionAsync, grpcClient.GetCatalogTemplateRevision, effectiveSettings.GetCatalogTemplateRevisionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCatalogTemplateRevision);
            Modify_GetCatalogTemplateRevisionApiCall(ref _callGetCatalogTemplateRevision);
            _callListCatalogTemplateRevisions = clientHelper.BuildApiCall<ListCatalogTemplateRevisionsRequest, ListCatalogTemplateRevisionsResponse>("ListCatalogTemplateRevisions", grpcClient.ListCatalogTemplateRevisionsAsync, grpcClient.ListCatalogTemplateRevisions, effectiveSettings.ListCatalogTemplateRevisionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCatalogTemplateRevisions);
            Modify_ListCatalogTemplateRevisionsApiCall(ref _callListCatalogTemplateRevisions);
            _callDeleteCatalogTemplateRevision = clientHelper.BuildApiCall<DeleteCatalogTemplateRevisionRequest, lro::Operation>("DeleteCatalogTemplateRevision", grpcClient.DeleteCatalogTemplateRevisionAsync, grpcClient.DeleteCatalogTemplateRevision, effectiveSettings.DeleteCatalogTemplateRevisionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteCatalogTemplateRevision);
            Modify_DeleteCatalogTemplateRevisionApiCall(ref _callDeleteCatalogTemplateRevision);
            _callCreateApplication = clientHelper.BuildApiCall<CreateApplicationRequest, Application>("CreateApplication", grpcClient.CreateApplicationAsync, grpcClient.CreateApplication, effectiveSettings.CreateApplicationSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateApplication);
            Modify_CreateApplicationApiCall(ref _callCreateApplication);
            _callGetApplication = clientHelper.BuildApiCall<GetApplicationRequest, Application>("GetApplication", grpcClient.GetApplicationAsync, grpcClient.GetApplication, effectiveSettings.GetApplicationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetApplication);
            Modify_GetApplicationApiCall(ref _callGetApplication);
            _callListApplications = clientHelper.BuildApiCall<ListApplicationsRequest, ListApplicationsResponse>("ListApplications", grpcClient.ListApplicationsAsync, grpcClient.ListApplications, effectiveSettings.ListApplicationsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListApplications);
            Modify_ListApplicationsApiCall(ref _callListApplications);
            _callUpdateApplication = clientHelper.BuildApiCall<UpdateApplicationRequest, Application>("UpdateApplication", grpcClient.UpdateApplicationAsync, grpcClient.UpdateApplication, effectiveSettings.UpdateApplicationSettings).WithGoogleRequestParam("application.name", request => request.Application?.Name);
            Modify_ApiCall(ref _callUpdateApplication);
            Modify_UpdateApplicationApiCall(ref _callUpdateApplication);
            _callDeleteApplication = clientHelper.BuildApiCall<DeleteApplicationRequest, lro::Operation>("DeleteApplication", grpcClient.DeleteApplicationAsync, grpcClient.DeleteApplication, effectiveSettings.DeleteApplicationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteApplication);
            Modify_DeleteApplicationApiCall(ref _callDeleteApplication);
            _callDeployApplication = clientHelper.BuildApiCall<DeployApplicationRequest, lro::Operation>("DeployApplication", grpcClient.DeployApplicationAsync, grpcClient.DeployApplication, effectiveSettings.DeployApplicationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeployApplication);
            Modify_DeployApplicationApiCall(ref _callDeployApplication);
            _callPreviewApplication = clientHelper.BuildApiCall<PreviewApplicationRequest, lro::Operation>("PreviewApplication", grpcClient.PreviewApplicationAsync, grpcClient.PreviewApplication, effectiveSettings.PreviewApplicationSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callPreviewApplication);
            Modify_PreviewApplicationApiCall(ref _callPreviewApplication);
            _callFetchApplicationAssessmentReport = clientHelper.BuildApiCall<FetchApplicationAssessmentReportRequest, FetchApplicationAssessmentReportResponse>("FetchApplicationAssessmentReport", grpcClient.FetchApplicationAssessmentReportAsync, grpcClient.FetchApplicationAssessmentReport, effectiveSettings.FetchApplicationAssessmentReportSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callFetchApplicationAssessmentReport);
            Modify_FetchApplicationAssessmentReportApiCall(ref _callFetchApplicationAssessmentReport);
            _callGenerateApplicationAssessmentReport = clientHelper.BuildApiCall<GenerateApplicationAssessmentReportRequest, lro::Operation>("GenerateApplicationAssessmentReport", grpcClient.GenerateApplicationAssessmentReportAsync, grpcClient.GenerateApplicationAssessmentReport, effectiveSettings.GenerateApplicationAssessmentReportSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGenerateApplicationAssessmentReport);
            Modify_GenerateApplicationAssessmentReportApiCall(ref _callGenerateApplicationAssessmentReport);
            _callGenerateApplicationTemplateAssessmentReport = clientHelper.BuildApiCall<GenerateApplicationTemplateAssessmentReportRequest, lro::Operation>("GenerateApplicationTemplateAssessmentReport", grpcClient.GenerateApplicationTemplateAssessmentReportAsync, grpcClient.GenerateApplicationTemplateAssessmentReport, effectiveSettings.GenerateApplicationTemplateAssessmentReportSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGenerateApplicationTemplateAssessmentReport);
            Modify_GenerateApplicationTemplateAssessmentReportApiCall(ref _callGenerateApplicationTemplateAssessmentReport);
#pragma warning disable CS0612
            _callGenerateAssessmentReport = clientHelper.BuildApiCall<GenerateAssessmentReportRequest, lro::Operation>("GenerateAssessmentReport", grpcClient.GenerateAssessmentReportAsync, grpcClient.GenerateAssessmentReport, effectiveSettings.GenerateAssessmentReportSettings).WithGoogleRequestParam("space_name", request => request.SpaceName);
#pragma warning restore CS0612
            Modify_ApiCall(ref _callGenerateAssessmentReport);
            Modify_GenerateAssessmentReportApiCall(ref _callGenerateAssessmentReport);
            _callGenerateTerraformPlanAssessmentReport = clientHelper.BuildApiCall<GenerateTerraformPlanAssessmentReportRequest, lro::Operation>("GenerateTerraformPlanAssessmentReport", grpcClient.GenerateTerraformPlanAssessmentReportAsync, grpcClient.GenerateTerraformPlanAssessmentReport, effectiveSettings.GenerateTerraformPlanAssessmentReportSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGenerateTerraformPlanAssessmentReport);
            Modify_GenerateTerraformPlanAssessmentReportApiCall(ref _callGenerateTerraformPlanAssessmentReport);
            _callGetPolicy = clientHelper.BuildApiCall<GetPolicyRequest, Policy>("GetPolicy", grpcClient.GetPolicyAsync, grpcClient.GetPolicy, effectiveSettings.GetPolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPolicy);
            Modify_GetPolicyApiCall(ref _callGetPolicy);
            _callListPolicies = clientHelper.BuildApiCall<ListPoliciesRequest, ListPoliciesResponse>("ListPolicies", grpcClient.ListPoliciesAsync, grpcClient.ListPolicies, effectiveSettings.ListPoliciesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPolicies);
            Modify_ListPoliciesApiCall(ref _callListPolicies);
            _callCreatePolicy = clientHelper.BuildApiCall<CreatePolicyRequest, Policy>("CreatePolicy", grpcClient.CreatePolicyAsync, grpcClient.CreatePolicy, effectiveSettings.CreatePolicySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreatePolicy);
            Modify_CreatePolicyApiCall(ref _callCreatePolicy);
            _callUpdatePolicy = clientHelper.BuildApiCall<UpdatePolicyRequest, Policy>("UpdatePolicy", grpcClient.UpdatePolicyAsync, grpcClient.UpdatePolicy, effectiveSettings.UpdatePolicySettings).WithGoogleRequestParam("policy.name", request => request.Policy?.Name);
            Modify_ApiCall(ref _callUpdatePolicy);
            Modify_UpdatePolicyApiCall(ref _callUpdatePolicy);
            _callDeletePolicy = clientHelper.BuildApiCall<DeletePolicyRequest, wkt::Empty>("DeletePolicy", grpcClient.DeletePolicyAsync, grpcClient.DeletePolicy, effectiveSettings.DeletePolicySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeletePolicy);
            Modify_DeletePolicyApiCall(ref _callDeletePolicy);
            _callFetchFrameworks = clientHelper.BuildApiCall<FetchFrameworksRequest, FetchFrameworksResponse>("FetchFrameworks", grpcClient.FetchFrameworksAsync, grpcClient.FetchFrameworks, effectiveSettings.FetchFrameworksSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callFetchFrameworks);
            Modify_FetchFrameworksApiCall(ref _callFetchFrameworks);
            _callGenerateApplicationIaC = clientHelper.BuildApiCall<GenerateApplicationIaCRequest, GenerateApplicationIaCResponse>("GenerateApplicationIaC", grpcClient.GenerateApplicationIaCAsync, grpcClient.GenerateApplicationIaC, effectiveSettings.GenerateApplicationIaCSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGenerateApplicationIaC);
            Modify_GenerateApplicationIaCApiCall(ref _callGenerateApplicationIaC);
            _callExportApplicationIaC = clientHelper.BuildApiCall<ExportApplicationIaCRequest, lro::Operation>("ExportApplicationIaC", grpcClient.ExportApplicationIaCAsync, grpcClient.ExportApplicationIaC, effectiveSettings.ExportApplicationIaCSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callExportApplicationIaC);
            Modify_ExportApplicationIaCApiCall(ref _callExportApplicationIaC);
            _callImportApplicationTemplateIaC = clientHelper.BuildApiCall<ImportApplicationTemplateIaCRequest, ImportApplicationTemplateIaCResponse>("ImportApplicationTemplateIaC", grpcClient.ImportApplicationTemplateIaCAsync, grpcClient.ImportApplicationTemplateIaC, effectiveSettings.ImportApplicationTemplateIaCSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callImportApplicationTemplateIaC);
            Modify_ImportApplicationTemplateIaCApiCall(ref _callImportApplicationTemplateIaC);
            _callIngestApplicationTemplateIaC = clientHelper.BuildApiCall<IngestApplicationTemplateIaCRequest, lro::Operation>("IngestApplicationTemplateIaC", grpcClient.IngestApplicationTemplateIaCAsync, grpcClient.IngestApplicationTemplateIaC, effectiveSettings.IngestApplicationTemplateIaCSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callIngestApplicationTemplateIaC);
            Modify_IngestApplicationTemplateIaCApiCall(ref _callIngestApplicationTemplateIaC);
            _callImportApplicationIaC = clientHelper.BuildApiCall<ImportApplicationIaCRequest, ImportApplicationIaCResponse>("ImportApplicationIaC", grpcClient.ImportApplicationIaCAsync, grpcClient.ImportApplicationIaC, effectiveSettings.ImportApplicationIaCSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callImportApplicationIaC);
            Modify_ImportApplicationIaCApiCall(ref _callImportApplicationIaC);
            _callRegisterAppHubApplicationResources = clientHelper.BuildApiCall<RegisterAppHubApplicationResourcesRequest, lro::Operation>("RegisterAppHubApplicationResources", grpcClient.RegisterAppHubApplicationResourcesAsync, grpcClient.RegisterAppHubApplicationResources, effectiveSettings.RegisterAppHubApplicationResourcesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callRegisterAppHubApplicationResources);
            Modify_RegisterAppHubApplicationResourcesApiCall(ref _callRegisterAppHubApplicationResources);
            _callListApplicationTemplateSystemRevisions = clientHelper.BuildApiCall<ListApplicationTemplateSystemRevisionsRequest, ListApplicationTemplateSystemRevisionsResponse>("ListApplicationTemplateSystemRevisions", grpcClient.ListApplicationTemplateSystemRevisionsAsync, grpcClient.ListApplicationTemplateSystemRevisions, effectiveSettings.ListApplicationTemplateSystemRevisionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListApplicationTemplateSystemRevisions);
            Modify_ListApplicationTemplateSystemRevisionsApiCall(ref _callListApplicationTemplateSystemRevisions);
            _callGetApplicationTemplateSystemRevision = clientHelper.BuildApiCall<GetApplicationTemplateSystemRevisionRequest, ApplicationTemplateSystemRevision>("GetApplicationTemplateSystemRevision", grpcClient.GetApplicationTemplateSystemRevisionAsync, grpcClient.GetApplicationTemplateSystemRevision, effectiveSettings.GetApplicationTemplateSystemRevisionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetApplicationTemplateSystemRevision);
            Modify_GetApplicationTemplateSystemRevisionApiCall(ref _callGetApplicationTemplateSystemRevision);
            _callRecommendIAMRoles = clientHelper.BuildApiCall<RecommendIAMRolesRequest, lro::Operation>("RecommendIAMRoles", grpcClient.RecommendIAMRolesAsync, grpcClient.RecommendIAMRoles, effectiveSettings.RecommendIAMRolesSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRecommendIAMRoles);
            Modify_RecommendIAMRolesApiCall(ref _callRecommendIAMRoles);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetSpaceApiCall(ref gaxgrpc::ApiCall<GetSpaceRequest, Space> call);

        partial void Modify_ListSpacesApiCall(ref gaxgrpc::ApiCall<ListSpacesRequest, ListSpacesResponse> call);

        partial void Modify_CreateSpaceApiCall(ref gaxgrpc::ApiCall<CreateSpaceRequest, Space> call);

        partial void Modify_UpdateSpaceApiCall(ref gaxgrpc::ApiCall<UpdateSpaceRequest, Space> call);

        partial void Modify_DeleteSpaceApiCall(ref gaxgrpc::ApiCall<DeleteSpaceRequest, wkt::Empty> call);

        partial void Modify_GetApplicationTemplateApiCall(ref gaxgrpc::ApiCall<GetApplicationTemplateRequest, ApplicationTemplate> call);

        partial void Modify_ListApplicationTemplatesApiCall(ref gaxgrpc::ApiCall<ListApplicationTemplatesRequest, ListApplicationTemplatesResponse> call);

        partial void Modify_CreateApplicationTemplateApiCall(ref gaxgrpc::ApiCall<CreateApplicationTemplateRequest, ApplicationTemplate> call);

        partial void Modify_UpdateApplicationTemplateApiCall(ref gaxgrpc::ApiCall<UpdateApplicationTemplateRequest, ApplicationTemplate> call);

        partial void Modify_ImportApplicationTemplateApiCall(ref gaxgrpc::ApiCall<ImportApplicationTemplateRequest, ApplicationTemplate> call);

        partial void Modify_DeleteApplicationTemplateApiCall(ref gaxgrpc::ApiCall<DeleteApplicationTemplateRequest, wkt::Empty> call);

        partial void Modify_CommitApplicationTemplateApiCall(ref gaxgrpc::ApiCall<CommitApplicationTemplateRequest, ApplicationTemplateRevision> call);

        partial void Modify_SnapshotApplicationTemplateApiCall(ref gaxgrpc::ApiCall<SnapshotApplicationTemplateRequest, lro::Operation> call);

        partial void Modify_GenerateApplicationTemplateIaCApiCall(ref gaxgrpc::ApiCall<GenerateApplicationTemplateIaCRequest, GenerateApplicationTemplateIaCResponse> call);

        partial void Modify_ExportApplicationTemplateIaCApiCall(ref gaxgrpc::ApiCall<ExportApplicationTemplateIaCRequest, lro::Operation> call);

        partial void Modify_GenerateApplicationTemplateRevisionIaCApiCall(ref gaxgrpc::ApiCall<GenerateApplicationTemplateRevisionIaCRequest, GenerateApplicationTemplateRevisionIaCResponse> call);

        partial void Modify_ExportApplicationTemplateRevisionIaCApiCall(ref gaxgrpc::ApiCall<ExportApplicationTemplateRevisionIaCRequest, lro::Operation> call);

        partial void Modify_GetComponentApiCall(ref gaxgrpc::ApiCall<GetComponentRequest, Component> call);

        partial void Modify_ListComponentsApiCall(ref gaxgrpc::ApiCall<ListComponentsRequest, ListComponentsResponse> call);

        partial void Modify_CreateComponentApiCall(ref gaxgrpc::ApiCall<CreateComponentRequest, Component> call);

        partial void Modify_UpdateComponentApiCall(ref gaxgrpc::ApiCall<UpdateComponentRequest, Component> call);

        partial void Modify_DeleteComponentApiCall(ref gaxgrpc::ApiCall<DeleteComponentRequest, wkt::Empty> call);

        partial void Modify_GetConnectionApiCall(ref gaxgrpc::ApiCall<GetConnectionRequest, Connection> call);

        partial void Modify_ListConnectionsApiCall(ref gaxgrpc::ApiCall<ListConnectionsRequest, ListConnectionsResponse> call);

        partial void Modify_CreateConnectionApiCall(ref gaxgrpc::ApiCall<CreateConnectionRequest, Connection> call);

        partial void Modify_UpdateConnectionApiCall(ref gaxgrpc::ApiCall<UpdateConnectionRequest, Connection> call);

        partial void Modify_DeleteConnectionApiCall(ref gaxgrpc::ApiCall<DeleteConnectionRequest, wkt::Empty> call);

        partial void Modify_GetApplicationTemplateRevisionApiCall(ref gaxgrpc::ApiCall<GetApplicationTemplateRevisionRequest, ApplicationTemplateRevision> call);

        partial void Modify_ListApplicationTemplateRevisionsApiCall(ref gaxgrpc::ApiCall<ListApplicationTemplateRevisionsRequest, ListApplicationTemplateRevisionsResponse> call);

        partial void Modify_DeleteApplicationTemplateRevisionApiCall(ref gaxgrpc::ApiCall<DeleteApplicationTemplateRevisionRequest, wkt::Empty> call);

        partial void Modify_GetCatalogApiCall(ref gaxgrpc::ApiCall<GetCatalogRequest, Catalog> call);

        partial void Modify_ListCatalogsApiCall(ref gaxgrpc::ApiCall<ListCatalogsRequest, ListCatalogsResponse> call);

        partial void Modify_CreateCatalogApiCall(ref gaxgrpc::ApiCall<CreateCatalogRequest, Catalog> call);

        partial void Modify_UpdateCatalogApiCall(ref gaxgrpc::ApiCall<UpdateCatalogRequest, Catalog> call);

        partial void Modify_DeleteCatalogApiCall(ref gaxgrpc::ApiCall<DeleteCatalogRequest, lro::Operation> call);

        partial void Modify_CreateCatalogTemplateApiCall(ref gaxgrpc::ApiCall<CreateCatalogTemplateRequest, CatalogTemplate> call);

        partial void Modify_GetCatalogTemplateApiCall(ref gaxgrpc::ApiCall<GetCatalogTemplateRequest, CatalogTemplate> call);

        partial void Modify_ListCatalogTemplatesApiCall(ref gaxgrpc::ApiCall<ListCatalogTemplatesRequest, ListCatalogTemplatesResponse> call);

        partial void Modify_UpdateCatalogTemplateApiCall(ref gaxgrpc::ApiCall<UpdateCatalogTemplateRequest, CatalogTemplate> call);

        partial void Modify_DeleteCatalogTemplateApiCall(ref gaxgrpc::ApiCall<DeleteCatalogTemplateRequest, lro::Operation> call);

        partial void Modify_CreateShareApiCall(ref gaxgrpc::ApiCall<CreateShareRequest, lro::Operation> call);

        partial void Modify_ListSharesApiCall(ref gaxgrpc::ApiCall<ListSharesRequest, ListSharesResponse> call);

        partial void Modify_GetShareApiCall(ref gaxgrpc::ApiCall<GetShareRequest, Share> call);

        partial void Modify_DeleteShareApiCall(ref gaxgrpc::ApiCall<DeleteShareRequest, lro::Operation> call);

        partial void Modify_SyncShareApiCall(ref gaxgrpc::ApiCall<SyncShareRequest, lro::Operation> call);

        partial void Modify_GetSharedTemplateApiCall(ref gaxgrpc::ApiCall<GetSharedTemplateRequest, SharedTemplate> call);

        partial void Modify_ListSharedTemplatesApiCall(ref gaxgrpc::ApiCall<ListSharedTemplatesRequest, ListSharedTemplatesResponse> call);

        partial void Modify_GetSharedTemplateRevisionApiCall(ref gaxgrpc::ApiCall<GetSharedTemplateRevisionRequest, SharedTemplateRevision> call);

        partial void Modify_ListSharedTemplateRevisionsApiCall(ref gaxgrpc::ApiCall<ListSharedTemplateRevisionsRequest, ListSharedTemplateRevisionsResponse> call);

        partial void Modify_CreateCatalogTemplateRevisionApiCall(ref gaxgrpc::ApiCall<CreateCatalogTemplateRevisionRequest, lro::Operation> call);

        partial void Modify_GetCatalogTemplateRevisionApiCall(ref gaxgrpc::ApiCall<GetCatalogTemplateRevisionRequest, CatalogTemplateRevision> call);

        partial void Modify_ListCatalogTemplateRevisionsApiCall(ref gaxgrpc::ApiCall<ListCatalogTemplateRevisionsRequest, ListCatalogTemplateRevisionsResponse> call);

        partial void Modify_DeleteCatalogTemplateRevisionApiCall(ref gaxgrpc::ApiCall<DeleteCatalogTemplateRevisionRequest, lro::Operation> call);

        partial void Modify_CreateApplicationApiCall(ref gaxgrpc::ApiCall<CreateApplicationRequest, Application> call);

        partial void Modify_GetApplicationApiCall(ref gaxgrpc::ApiCall<GetApplicationRequest, Application> call);

        partial void Modify_ListApplicationsApiCall(ref gaxgrpc::ApiCall<ListApplicationsRequest, ListApplicationsResponse> call);

        partial void Modify_UpdateApplicationApiCall(ref gaxgrpc::ApiCall<UpdateApplicationRequest, Application> call);

        partial void Modify_DeleteApplicationApiCall(ref gaxgrpc::ApiCall<DeleteApplicationRequest, lro::Operation> call);

        partial void Modify_DeployApplicationApiCall(ref gaxgrpc::ApiCall<DeployApplicationRequest, lro::Operation> call);

        partial void Modify_PreviewApplicationApiCall(ref gaxgrpc::ApiCall<PreviewApplicationRequest, lro::Operation> call);

        partial void Modify_FetchApplicationAssessmentReportApiCall(ref gaxgrpc::ApiCall<FetchApplicationAssessmentReportRequest, FetchApplicationAssessmentReportResponse> call);

        partial void Modify_GenerateApplicationAssessmentReportApiCall(ref gaxgrpc::ApiCall<GenerateApplicationAssessmentReportRequest, lro::Operation> call);

        partial void Modify_GenerateApplicationTemplateAssessmentReportApiCall(ref gaxgrpc::ApiCall<GenerateApplicationTemplateAssessmentReportRequest, lro::Operation> call);

#pragma warning disable CS0612
        partial void Modify_GenerateAssessmentReportApiCall(ref gaxgrpc::ApiCall<GenerateAssessmentReportRequest, lro::Operation> call);
#pragma warning restore CS0612

        partial void Modify_GenerateTerraformPlanAssessmentReportApiCall(ref gaxgrpc::ApiCall<GenerateTerraformPlanAssessmentReportRequest, lro::Operation> call);

        partial void Modify_GetPolicyApiCall(ref gaxgrpc::ApiCall<GetPolicyRequest, Policy> call);

        partial void Modify_ListPoliciesApiCall(ref gaxgrpc::ApiCall<ListPoliciesRequest, ListPoliciesResponse> call);

        partial void Modify_CreatePolicyApiCall(ref gaxgrpc::ApiCall<CreatePolicyRequest, Policy> call);

        partial void Modify_UpdatePolicyApiCall(ref gaxgrpc::ApiCall<UpdatePolicyRequest, Policy> call);

        partial void Modify_DeletePolicyApiCall(ref gaxgrpc::ApiCall<DeletePolicyRequest, wkt::Empty> call);

        partial void Modify_FetchFrameworksApiCall(ref gaxgrpc::ApiCall<FetchFrameworksRequest, FetchFrameworksResponse> call);

        partial void Modify_GenerateApplicationIaCApiCall(ref gaxgrpc::ApiCall<GenerateApplicationIaCRequest, GenerateApplicationIaCResponse> call);

        partial void Modify_ExportApplicationIaCApiCall(ref gaxgrpc::ApiCall<ExportApplicationIaCRequest, lro::Operation> call);

        partial void Modify_ImportApplicationTemplateIaCApiCall(ref gaxgrpc::ApiCall<ImportApplicationTemplateIaCRequest, ImportApplicationTemplateIaCResponse> call);

        partial void Modify_IngestApplicationTemplateIaCApiCall(ref gaxgrpc::ApiCall<IngestApplicationTemplateIaCRequest, lro::Operation> call);

        partial void Modify_ImportApplicationIaCApiCall(ref gaxgrpc::ApiCall<ImportApplicationIaCRequest, ImportApplicationIaCResponse> call);

        partial void Modify_RegisterAppHubApplicationResourcesApiCall(ref gaxgrpc::ApiCall<RegisterAppHubApplicationResourcesRequest, lro::Operation> call);

        partial void Modify_ListApplicationTemplateSystemRevisionsApiCall(ref gaxgrpc::ApiCall<ListApplicationTemplateSystemRevisionsRequest, ListApplicationTemplateSystemRevisionsResponse> call);

        partial void Modify_GetApplicationTemplateSystemRevisionApiCall(ref gaxgrpc::ApiCall<GetApplicationTemplateSystemRevisionRequest, ApplicationTemplateSystemRevision> call);

        partial void Modify_RecommendIAMRolesApiCall(ref gaxgrpc::ApiCall<RecommendIAMRolesRequest, lro::Operation> call);

        partial void OnConstruction(DesignCenter.DesignCenterClient grpcClient, DesignCenterSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DesignCenter client</summary>
        public override DesignCenter.DesignCenterClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_GetSpaceRequest(ref GetSpaceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSpacesRequest(ref ListSpacesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSpaceRequest(ref CreateSpaceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSpaceRequest(ref UpdateSpaceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSpaceRequest(ref DeleteSpaceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetApplicationTemplateRequest(ref GetApplicationTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListApplicationTemplatesRequest(ref ListApplicationTemplatesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateApplicationTemplateRequest(ref CreateApplicationTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateApplicationTemplateRequest(ref UpdateApplicationTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportApplicationTemplateRequest(ref ImportApplicationTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteApplicationTemplateRequest(ref DeleteApplicationTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CommitApplicationTemplateRequest(ref CommitApplicationTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SnapshotApplicationTemplateRequest(ref SnapshotApplicationTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateApplicationTemplateIaCRequest(ref GenerateApplicationTemplateIaCRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportApplicationTemplateIaCRequest(ref ExportApplicationTemplateIaCRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateApplicationTemplateRevisionIaCRequest(ref GenerateApplicationTemplateRevisionIaCRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportApplicationTemplateRevisionIaCRequest(ref ExportApplicationTemplateRevisionIaCRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetComponentRequest(ref GetComponentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListComponentsRequest(ref ListComponentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateComponentRequest(ref CreateComponentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateComponentRequest(ref UpdateComponentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteComponentRequest(ref DeleteComponentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetConnectionRequest(ref GetConnectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListConnectionsRequest(ref ListConnectionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateConnectionRequest(ref CreateConnectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateConnectionRequest(ref UpdateConnectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteConnectionRequest(ref DeleteConnectionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetApplicationTemplateRevisionRequest(ref GetApplicationTemplateRevisionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListApplicationTemplateRevisionsRequest(ref ListApplicationTemplateRevisionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteApplicationTemplateRevisionRequest(ref DeleteApplicationTemplateRevisionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCatalogRequest(ref GetCatalogRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCatalogsRequest(ref ListCatalogsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateCatalogRequest(ref CreateCatalogRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCatalogRequest(ref UpdateCatalogRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteCatalogRequest(ref DeleteCatalogRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateCatalogTemplateRequest(ref CreateCatalogTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCatalogTemplateRequest(ref GetCatalogTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCatalogTemplatesRequest(ref ListCatalogTemplatesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCatalogTemplateRequest(ref UpdateCatalogTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteCatalogTemplateRequest(ref DeleteCatalogTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateShareRequest(ref CreateShareRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSharesRequest(ref ListSharesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetShareRequest(ref GetShareRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteShareRequest(ref DeleteShareRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SyncShareRequest(ref SyncShareRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSharedTemplateRequest(ref GetSharedTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSharedTemplatesRequest(ref ListSharedTemplatesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSharedTemplateRevisionRequest(ref GetSharedTemplateRevisionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSharedTemplateRevisionsRequest(ref ListSharedTemplateRevisionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateCatalogTemplateRevisionRequest(ref CreateCatalogTemplateRevisionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCatalogTemplateRevisionRequest(ref GetCatalogTemplateRevisionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCatalogTemplateRevisionsRequest(ref ListCatalogTemplateRevisionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteCatalogTemplateRevisionRequest(ref DeleteCatalogTemplateRevisionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateApplicationRequest(ref CreateApplicationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetApplicationRequest(ref GetApplicationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListApplicationsRequest(ref ListApplicationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateApplicationRequest(ref UpdateApplicationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteApplicationRequest(ref DeleteApplicationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeployApplicationRequest(ref DeployApplicationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PreviewApplicationRequest(ref PreviewApplicationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FetchApplicationAssessmentReportRequest(ref FetchApplicationAssessmentReportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateApplicationAssessmentReportRequest(ref GenerateApplicationAssessmentReportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateApplicationTemplateAssessmentReportRequest(ref GenerateApplicationTemplateAssessmentReportRequest request, ref gaxgrpc::CallSettings settings);

#pragma warning disable CS0612
        partial void Modify_GenerateAssessmentReportRequest(ref GenerateAssessmentReportRequest request, ref gaxgrpc::CallSettings settings);
#pragma warning restore CS0612

        partial void Modify_GenerateTerraformPlanAssessmentReportRequest(ref GenerateTerraformPlanAssessmentReportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPolicyRequest(ref GetPolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPoliciesRequest(ref ListPoliciesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreatePolicyRequest(ref CreatePolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdatePolicyRequest(ref UpdatePolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePolicyRequest(ref DeletePolicyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FetchFrameworksRequest(ref FetchFrameworksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateApplicationIaCRequest(ref GenerateApplicationIaCRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportApplicationIaCRequest(ref ExportApplicationIaCRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportApplicationTemplateIaCRequest(ref ImportApplicationTemplateIaCRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_IngestApplicationTemplateIaCRequest(ref IngestApplicationTemplateIaCRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportApplicationIaCRequest(ref ImportApplicationIaCRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RegisterAppHubApplicationResourcesRequest(ref RegisterAppHubApplicationResourcesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListApplicationTemplateSystemRevisionsRequest(ref ListApplicationTemplateSystemRevisionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetApplicationTemplateSystemRevisionRequest(ref GetApplicationTemplateSystemRevisionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RecommendIAMRolesRequest(ref RecommendIAMRolesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets details about a space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Space GetSpace(GetSpaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSpaceRequest(ref request, ref callSettings);
            return _callGetSpace.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details about a space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Space> GetSpaceAsync(GetSpaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSpaceRequest(ref request, ref callSettings);
            return _callGetSpace.Async(request, callSettings);
        }

        /// <summary>
        /// Lists spaces in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Space"/> resources.</returns>
        public override gax::PagedEnumerable<ListSpacesResponse, Space> ListSpaces(ListSpacesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSpacesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSpacesRequest, ListSpacesResponse, Space>(_callListSpaces, request, callSettings);
        }

        /// <summary>
        /// Lists spaces in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Space"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSpacesResponse, Space> ListSpacesAsync(ListSpacesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSpacesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSpacesRequest, ListSpacesResponse, Space>(_callListSpaces, request, callSettings);
        }

        /// <summary>
        /// Creates a space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Space CreateSpace(CreateSpaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSpaceRequest(ref request, ref callSettings);
            return _callCreateSpace.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Space> CreateSpaceAsync(CreateSpaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSpaceRequest(ref request, ref callSettings);
            return _callCreateSpace.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Space UpdateSpace(UpdateSpaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSpaceRequest(ref request, ref callSettings);
            return _callUpdateSpace.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Space> UpdateSpaceAsync(UpdateSpaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSpaceRequest(ref request, ref callSettings);
            return _callUpdateSpace.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteSpace(DeleteSpaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSpaceRequest(ref request, ref callSettings);
            _callDeleteSpace.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteSpaceAsync(DeleteSpaceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSpaceRequest(ref request, ref callSettings);
            return _callDeleteSpace.Async(request, callSettings);
        }

        /// <summary>
        /// Gets details about an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ApplicationTemplate GetApplicationTemplate(GetApplicationTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetApplicationTemplateRequest(ref request, ref callSettings);
            return _callGetApplicationTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details about an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ApplicationTemplate> GetApplicationTemplateAsync(GetApplicationTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetApplicationTemplateRequest(ref request, ref callSettings);
            return _callGetApplicationTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Lists application templates in a given space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ApplicationTemplate"/> resources.</returns>
        public override gax::PagedEnumerable<ListApplicationTemplatesResponse, ApplicationTemplate> ListApplicationTemplates(ListApplicationTemplatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListApplicationTemplatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListApplicationTemplatesRequest, ListApplicationTemplatesResponse, ApplicationTemplate>(_callListApplicationTemplates, request, callSettings);
        }

        /// <summary>
        /// Lists application templates in a given space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ApplicationTemplate"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListApplicationTemplatesResponse, ApplicationTemplate> ListApplicationTemplatesAsync(ListApplicationTemplatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListApplicationTemplatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListApplicationTemplatesRequest, ListApplicationTemplatesResponse, ApplicationTemplate>(_callListApplicationTemplates, request, callSettings);
        }

        /// <summary>
        /// Creates an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ApplicationTemplate CreateApplicationTemplate(CreateApplicationTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateApplicationTemplateRequest(ref request, ref callSettings);
            return _callCreateApplicationTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ApplicationTemplate> CreateApplicationTemplateAsync(CreateApplicationTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateApplicationTemplateRequest(ref request, ref callSettings);
            return _callCreateApplicationTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ApplicationTemplate UpdateApplicationTemplate(UpdateApplicationTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateApplicationTemplateRequest(ref request, ref callSettings);
            return _callUpdateApplicationTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ApplicationTemplate> UpdateApplicationTemplateAsync(UpdateApplicationTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateApplicationTemplateRequest(ref request, ref callSettings);
            return _callUpdateApplicationTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Imports to an existing application template from a given shared template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ApplicationTemplate ImportApplicationTemplate(ImportApplicationTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportApplicationTemplateRequest(ref request, ref callSettings);
            return _callImportApplicationTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Imports to an existing application template from a given shared template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ApplicationTemplate> ImportApplicationTemplateAsync(ImportApplicationTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportApplicationTemplateRequest(ref request, ref callSettings);
            return _callImportApplicationTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteApplicationTemplate(DeleteApplicationTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteApplicationTemplateRequest(ref request, ref callSettings);
            _callDeleteApplicationTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteApplicationTemplateAsync(DeleteApplicationTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteApplicationTemplateRequest(ref request, ref callSettings);
            return _callDeleteApplicationTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Commits an application template to create a new revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ApplicationTemplateRevision CommitApplicationTemplate(CommitApplicationTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CommitApplicationTemplateRequest(ref request, ref callSettings);
            return _callCommitApplicationTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Commits an application template to create a new revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ApplicationTemplateRevision> CommitApplicationTemplateAsync(CommitApplicationTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CommitApplicationTemplateRequest(ref request, ref callSettings);
            return _callCommitApplicationTemplate.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>SnapshotApplicationTemplate</c>.</summary>
        public override lro::OperationsClient SnapshotApplicationTemplateOperationsClient { get; }

        /// <summary>
        /// Snapshots an application template to create a new revision asynchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<SnapshotApplicationTemplateResponse, OperationMetadata> SnapshotApplicationTemplate(SnapshotApplicationTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SnapshotApplicationTemplateRequest(ref request, ref callSettings);
            return new lro::Operation<SnapshotApplicationTemplateResponse, OperationMetadata>(_callSnapshotApplicationTemplate.Sync(request, callSettings), SnapshotApplicationTemplateOperationsClient);
        }

        /// <summary>
        /// Snapshots an application template to create a new revision asynchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<SnapshotApplicationTemplateResponse, OperationMetadata>> SnapshotApplicationTemplateAsync(SnapshotApplicationTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SnapshotApplicationTemplateRequest(ref request, ref callSettings);
            return new lro::Operation<SnapshotApplicationTemplateResponse, OperationMetadata>(await _callSnapshotApplicationTemplate.Async(request, callSettings).ConfigureAwait(false), SnapshotApplicationTemplateOperationsClient);
        }

        /// <summary>
        /// Generates Terraform files for an application template.
        /// This is a SYNCHRONOUS operation and returns the generated IaC
        /// directly in the response. It
        /// does NOT download external module sources; it only uses remote sources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateApplicationTemplateIaCResponse GenerateApplicationTemplateIaC(GenerateApplicationTemplateIaCRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateApplicationTemplateIaCRequest(ref request, ref callSettings);
            return _callGenerateApplicationTemplateIaC.Sync(request, callSettings);
        }

        /// <summary>
        /// Generates Terraform files for an application template.
        /// This is a SYNCHRONOUS operation and returns the generated IaC
        /// directly in the response. It
        /// does NOT download external module sources; it only uses remote sources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateApplicationTemplateIaCResponse> GenerateApplicationTemplateIaCAsync(GenerateApplicationTemplateIaCRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateApplicationTemplateIaCRequest(ref request, ref callSettings);
            return _callGenerateApplicationTemplateIaC.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>ExportApplicationTemplateIaC</c>.</summary>
        public override lro::OperationsClient ExportApplicationTemplateIaCOperationsClient { get; }

        /// <summary>
        /// Exports Terraform files for an application template. The generated
        /// modules can have remote sources or local sources downloaded from remote.
        /// This is an ASYNCHRONOUS operation that returns a Long Running Operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ExportApplicationTemplateIaCResponse, OperationMetadata> ExportApplicationTemplateIaC(ExportApplicationTemplateIaCRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportApplicationTemplateIaCRequest(ref request, ref callSettings);
            return new lro::Operation<ExportApplicationTemplateIaCResponse, OperationMetadata>(_callExportApplicationTemplateIaC.Sync(request, callSettings), ExportApplicationTemplateIaCOperationsClient);
        }

        /// <summary>
        /// Exports Terraform files for an application template. The generated
        /// modules can have remote sources or local sources downloaded from remote.
        /// This is an ASYNCHRONOUS operation that returns a Long Running Operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ExportApplicationTemplateIaCResponse, OperationMetadata>> ExportApplicationTemplateIaCAsync(ExportApplicationTemplateIaCRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportApplicationTemplateIaCRequest(ref request, ref callSettings);
            return new lro::Operation<ExportApplicationTemplateIaCResponse, OperationMetadata>(await _callExportApplicationTemplateIaC.Async(request, callSettings).ConfigureAwait(false), ExportApplicationTemplateIaCOperationsClient);
        }

        /// <summary>
        /// Generates Terraform files for an application template revision.
        /// This is a SYNCHRONOUS operation and returns the generated IaC
        /// directly in the response. It
        /// does NOT download external module sources; it only uses remote sources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateApplicationTemplateRevisionIaCResponse GenerateApplicationTemplateRevisionIaC(GenerateApplicationTemplateRevisionIaCRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateApplicationTemplateRevisionIaCRequest(ref request, ref callSettings);
            return _callGenerateApplicationTemplateRevisionIaC.Sync(request, callSettings);
        }

        /// <summary>
        /// Generates Terraform files for an application template revision.
        /// This is a SYNCHRONOUS operation and returns the generated IaC
        /// directly in the response. It
        /// does NOT download external module sources; it only uses remote sources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateApplicationTemplateRevisionIaCResponse> GenerateApplicationTemplateRevisionIaCAsync(GenerateApplicationTemplateRevisionIaCRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateApplicationTemplateRevisionIaCRequest(ref request, ref callSettings);
            return _callGenerateApplicationTemplateRevisionIaC.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>ExportApplicationTemplateRevisionIaC</c>.</summary>
        public override lro::OperationsClient ExportApplicationTemplateRevisionIaCOperationsClient { get; }

        /// <summary>
        /// Exports Terraform files for an application template revision. The generated
        /// modules can have remote sources or local sources downloaded from remote.
        /// This is an ASYNCHRONOUS operation that returns a Long Running Operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ExportApplicationTemplateRevisionIaCResponse, OperationMetadata> ExportApplicationTemplateRevisionIaC(ExportApplicationTemplateRevisionIaCRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportApplicationTemplateRevisionIaCRequest(ref request, ref callSettings);
            return new lro::Operation<ExportApplicationTemplateRevisionIaCResponse, OperationMetadata>(_callExportApplicationTemplateRevisionIaC.Sync(request, callSettings), ExportApplicationTemplateRevisionIaCOperationsClient);
        }

        /// <summary>
        /// Exports Terraform files for an application template revision. The generated
        /// modules can have remote sources or local sources downloaded from remote.
        /// This is an ASYNCHRONOUS operation that returns a Long Running Operation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ExportApplicationTemplateRevisionIaCResponse, OperationMetadata>> ExportApplicationTemplateRevisionIaCAsync(ExportApplicationTemplateRevisionIaCRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportApplicationTemplateRevisionIaCRequest(ref request, ref callSettings);
            return new lro::Operation<ExportApplicationTemplateRevisionIaCResponse, OperationMetadata>(await _callExportApplicationTemplateRevisionIaC.Async(request, callSettings).ConfigureAwait(false), ExportApplicationTemplateRevisionIaCOperationsClient);
        }

        /// <summary>
        /// Gets details about a Component.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Component GetComponent(GetComponentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetComponentRequest(ref request, ref callSettings);
            return _callGetComponent.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details about a Component.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Component> GetComponentAsync(GetComponentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetComponentRequest(ref request, ref callSettings);
            return _callGetComponent.Async(request, callSettings);
        }

        /// <summary>
        /// Lists components in an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Component"/> resources.</returns>
        public override gax::PagedEnumerable<ListComponentsResponse, Component> ListComponents(ListComponentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListComponentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListComponentsRequest, ListComponentsResponse, Component>(_callListComponents, request, callSettings);
        }

        /// <summary>
        /// Lists components in an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Component"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListComponentsResponse, Component> ListComponentsAsync(ListComponentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListComponentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListComponentsRequest, ListComponentsResponse, Component>(_callListComponents, request, callSettings);
        }

        /// <summary>
        /// Creates a component.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Component CreateComponent(CreateComponentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateComponentRequest(ref request, ref callSettings);
            return _callCreateComponent.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a component.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Component> CreateComponentAsync(CreateComponentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateComponentRequest(ref request, ref callSettings);
            return _callCreateComponent.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a component.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Component UpdateComponent(UpdateComponentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateComponentRequest(ref request, ref callSettings);
            return _callUpdateComponent.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a component.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Component> UpdateComponentAsync(UpdateComponentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateComponentRequest(ref request, ref callSettings);
            return _callUpdateComponent.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a component.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteComponent(DeleteComponentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteComponentRequest(ref request, ref callSettings);
            _callDeleteComponent.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a component.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteComponentAsync(DeleteComponentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteComponentRequest(ref request, ref callSettings);
            return _callDeleteComponent.Async(request, callSettings);
        }

        /// <summary>
        /// Gets details about a connection.
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
        /// Gets details about a connection.
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
        /// Lists connections in an application template.
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
        /// Lists connections in an application template.
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
        /// Creates a connection.
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
        /// Creates a connection.
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
        /// Updates a connection.
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
        /// Updates a connection.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Connection> UpdateConnectionAsync(UpdateConnectionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateConnectionRequest(ref request, ref callSettings);
            return _callUpdateConnection.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a connection.
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
        /// Deletes a connection.
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
        /// Gets details about an application template revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ApplicationTemplateRevision GetApplicationTemplateRevision(GetApplicationTemplateRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetApplicationTemplateRevisionRequest(ref request, ref callSettings);
            return _callGetApplicationTemplateRevision.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details about an application template revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ApplicationTemplateRevision> GetApplicationTemplateRevisionAsync(GetApplicationTemplateRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetApplicationTemplateRevisionRequest(ref request, ref callSettings);
            return _callGetApplicationTemplateRevision.Async(request, callSettings);
        }

        /// <summary>
        /// Lists application template revisions in a given application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ApplicationTemplateRevision"/> resources.</returns>
        public override gax::PagedEnumerable<ListApplicationTemplateRevisionsResponse, ApplicationTemplateRevision> ListApplicationTemplateRevisions(ListApplicationTemplateRevisionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListApplicationTemplateRevisionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListApplicationTemplateRevisionsRequest, ListApplicationTemplateRevisionsResponse, ApplicationTemplateRevision>(_callListApplicationTemplateRevisions, request, callSettings);
        }

        /// <summary>
        /// Lists application template revisions in a given application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ApplicationTemplateRevision"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListApplicationTemplateRevisionsResponse, ApplicationTemplateRevision> ListApplicationTemplateRevisionsAsync(ListApplicationTemplateRevisionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListApplicationTemplateRevisionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListApplicationTemplateRevisionsRequest, ListApplicationTemplateRevisionsResponse, ApplicationTemplateRevision>(_callListApplicationTemplateRevisions, request, callSettings);
        }

        /// <summary>
        /// Deletes an application template revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteApplicationTemplateRevision(DeleteApplicationTemplateRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteApplicationTemplateRevisionRequest(ref request, ref callSettings);
            _callDeleteApplicationTemplateRevision.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an application template revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteApplicationTemplateRevisionAsync(DeleteApplicationTemplateRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteApplicationTemplateRevisionRequest(ref request, ref callSettings);
            return _callDeleteApplicationTemplateRevision.Async(request, callSettings);
        }

        /// <summary>
        /// Gets details about a catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Catalog GetCatalog(GetCatalogRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCatalogRequest(ref request, ref callSettings);
            return _callGetCatalog.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details about a catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Catalog> GetCatalogAsync(GetCatalogRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCatalogRequest(ref request, ref callSettings);
            return _callGetCatalog.Async(request, callSettings);
        }

        /// <summary>
        /// Lists catalogs in a given space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Catalog"/> resources.</returns>
        public override gax::PagedEnumerable<ListCatalogsResponse, Catalog> ListCatalogs(ListCatalogsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCatalogsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCatalogsRequest, ListCatalogsResponse, Catalog>(_callListCatalogs, request, callSettings);
        }

        /// <summary>
        /// Lists catalogs in a given space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Catalog"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCatalogsResponse, Catalog> ListCatalogsAsync(ListCatalogsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCatalogsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCatalogsRequest, ListCatalogsResponse, Catalog>(_callListCatalogs, request, callSettings);
        }

        /// <summary>
        /// Creates a catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Catalog CreateCatalog(CreateCatalogRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCatalogRequest(ref request, ref callSettings);
            return _callCreateCatalog.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Catalog> CreateCatalogAsync(CreateCatalogRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCatalogRequest(ref request, ref callSettings);
            return _callCreateCatalog.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Catalog UpdateCatalog(UpdateCatalogRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCatalogRequest(ref request, ref callSettings);
            return _callUpdateCatalog.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Catalog> UpdateCatalogAsync(UpdateCatalogRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCatalogRequest(ref request, ref callSettings);
            return _callUpdateCatalog.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteCatalog</c>.</summary>
        public override lro::OperationsClient DeleteCatalogOperationsClient { get; }

        /// <summary>
        /// Deletes a catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteCatalog(DeleteCatalogRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCatalogRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteCatalog.Sync(request, callSettings), DeleteCatalogOperationsClient);
        }

        /// <summary>
        /// Deletes a catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCatalogAsync(DeleteCatalogRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCatalogRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteCatalog.Async(request, callSettings).ConfigureAwait(false), DeleteCatalogOperationsClient);
        }

        /// <summary>
        /// Adds a template to a catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CatalogTemplate CreateCatalogTemplate(CreateCatalogTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCatalogTemplateRequest(ref request, ref callSettings);
            return _callCreateCatalogTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Adds a template to a catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CatalogTemplate> CreateCatalogTemplateAsync(CreateCatalogTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCatalogTemplateRequest(ref request, ref callSettings);
            return _callCreateCatalogTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a catalog template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CatalogTemplate GetCatalogTemplate(GetCatalogTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCatalogTemplateRequest(ref request, ref callSettings);
            return _callGetCatalogTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a catalog template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CatalogTemplate> GetCatalogTemplateAsync(GetCatalogTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCatalogTemplateRequest(ref request, ref callSettings);
            return _callGetCatalogTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Lists catalog templates.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CatalogTemplate"/> resources.</returns>
        public override gax::PagedEnumerable<ListCatalogTemplatesResponse, CatalogTemplate> ListCatalogTemplates(ListCatalogTemplatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCatalogTemplatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCatalogTemplatesRequest, ListCatalogTemplatesResponse, CatalogTemplate>(_callListCatalogTemplates, request, callSettings);
        }

        /// <summary>
        /// Lists catalog templates.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CatalogTemplate"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCatalogTemplatesResponse, CatalogTemplate> ListCatalogTemplatesAsync(ListCatalogTemplatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCatalogTemplatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCatalogTemplatesRequest, ListCatalogTemplatesResponse, CatalogTemplate>(_callListCatalogTemplates, request, callSettings);
        }

        /// <summary>
        /// Updates a catalog template resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CatalogTemplate UpdateCatalogTemplate(UpdateCatalogTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCatalogTemplateRequest(ref request, ref callSettings);
            return _callUpdateCatalogTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a catalog template resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CatalogTemplate> UpdateCatalogTemplateAsync(UpdateCatalogTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCatalogTemplateRequest(ref request, ref callSettings);
            return _callUpdateCatalogTemplate.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteCatalogTemplate</c>.</summary>
        public override lro::OperationsClient DeleteCatalogTemplateOperationsClient { get; }

        /// <summary>
        /// Deletes a catalog template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteCatalogTemplate(DeleteCatalogTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCatalogTemplateRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteCatalogTemplate.Sync(request, callSettings), DeleteCatalogTemplateOperationsClient);
        }

        /// <summary>
        /// Deletes a catalog template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCatalogTemplateAsync(DeleteCatalogTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCatalogTemplateRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteCatalogTemplate.Async(request, callSettings).ConfigureAwait(false), DeleteCatalogTemplateOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateShare</c>.</summary>
        public override lro::OperationsClient CreateShareOperationsClient { get; }

        /// <summary>
        /// Shares a catalog from one space to another space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Share, OperationMetadata> CreateShare(CreateShareRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateShareRequest(ref request, ref callSettings);
            return new lro::Operation<Share, OperationMetadata>(_callCreateShare.Sync(request, callSettings), CreateShareOperationsClient);
        }

        /// <summary>
        /// Shares a catalog from one space to another space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Share, OperationMetadata>> CreateShareAsync(CreateShareRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateShareRequest(ref request, ref callSettings);
            return new lro::Operation<Share, OperationMetadata>(await _callCreateShare.Async(request, callSettings).ConfigureAwait(false), CreateShareOperationsClient);
        }

        /// <summary>
        /// Lists catalog share objects for the space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Share"/> resources.</returns>
        public override gax::PagedEnumerable<ListSharesResponse, Share> ListShares(ListSharesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSharesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSharesRequest, ListSharesResponse, Share>(_callListShares, request, callSettings);
        }

        /// <summary>
        /// Lists catalog share objects for the space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Share"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSharesResponse, Share> ListSharesAsync(ListSharesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSharesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSharesRequest, ListSharesResponse, Share>(_callListShares, request, callSettings);
        }

        /// <summary>
        /// Get catalog share object for the space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Share GetShare(GetShareRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetShareRequest(ref request, ref callSettings);
            return _callGetShare.Sync(request, callSettings);
        }

        /// <summary>
        /// Get catalog share object for the space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Share> GetShareAsync(GetShareRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetShareRequest(ref request, ref callSettings);
            return _callGetShare.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteShare</c>.</summary>
        public override lro::OperationsClient DeleteShareOperationsClient { get; }

        /// <summary>
        /// Deletes a catalog share.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteShare(DeleteShareRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteShareRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteShare.Sync(request, callSettings), DeleteShareOperationsClient);
        }

        /// <summary>
        /// Deletes a catalog share.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteShareAsync(DeleteShareRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteShareRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteShare.Async(request, callSettings).ConfigureAwait(false), DeleteShareOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SyncShare</c>.</summary>
        public override lro::OperationsClient SyncShareOperationsClient { get; }

        /// <summary>
        /// Synchronizes a share and updates the destination workspace to reflect.
        /// reflect the most recent changes to the catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Share, OperationMetadata> SyncShare(SyncShareRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SyncShareRequest(ref request, ref callSettings);
            return new lro::Operation<Share, OperationMetadata>(_callSyncShare.Sync(request, callSettings), SyncShareOperationsClient);
        }

        /// <summary>
        /// Synchronizes a share and updates the destination workspace to reflect.
        /// reflect the most recent changes to the catalog.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Share, OperationMetadata>> SyncShareAsync(SyncShareRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SyncShareRequest(ref request, ref callSettings);
            return new lro::Operation<Share, OperationMetadata>(await _callSyncShare.Async(request, callSettings).ConfigureAwait(false), SyncShareOperationsClient);
        }

        /// <summary>
        /// Gets details about a shared template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SharedTemplate GetSharedTemplate(GetSharedTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSharedTemplateRequest(ref request, ref callSettings);
            return _callGetSharedTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details about a shared template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SharedTemplate> GetSharedTemplateAsync(GetSharedTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSharedTemplateRequest(ref request, ref callSettings);
            return _callGetSharedTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Lists shared templates in a given space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SharedTemplate"/> resources.</returns>
        public override gax::PagedEnumerable<ListSharedTemplatesResponse, SharedTemplate> ListSharedTemplates(ListSharedTemplatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSharedTemplatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSharedTemplatesRequest, ListSharedTemplatesResponse, SharedTemplate>(_callListSharedTemplates, request, callSettings);
        }

        /// <summary>
        /// Lists shared templates in a given space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SharedTemplate"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSharedTemplatesResponse, SharedTemplate> ListSharedTemplatesAsync(ListSharedTemplatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSharedTemplatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSharedTemplatesRequest, ListSharedTemplatesResponse, SharedTemplate>(_callListSharedTemplates, request, callSettings);
        }

        /// <summary>
        /// Gets details about a shared template revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SharedTemplateRevision GetSharedTemplateRevision(GetSharedTemplateRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSharedTemplateRevisionRequest(ref request, ref callSettings);
            return _callGetSharedTemplateRevision.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details about a shared template revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SharedTemplateRevision> GetSharedTemplateRevisionAsync(GetSharedTemplateRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSharedTemplateRevisionRequest(ref request, ref callSettings);
            return _callGetSharedTemplateRevision.Async(request, callSettings);
        }

        /// <summary>
        /// Lists shared template revisions in a given space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SharedTemplateRevision"/> resources.</returns>
        public override gax::PagedEnumerable<ListSharedTemplateRevisionsResponse, SharedTemplateRevision> ListSharedTemplateRevisions(ListSharedTemplateRevisionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSharedTemplateRevisionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSharedTemplateRevisionsRequest, ListSharedTemplateRevisionsResponse, SharedTemplateRevision>(_callListSharedTemplateRevisions, request, callSettings);
        }

        /// <summary>
        /// Lists shared template revisions in a given space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SharedTemplateRevision"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSharedTemplateRevisionsResponse, SharedTemplateRevision> ListSharedTemplateRevisionsAsync(ListSharedTemplateRevisionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSharedTemplateRevisionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSharedTemplateRevisionsRequest, ListSharedTemplateRevisionsResponse, SharedTemplateRevision>(_callListSharedTemplateRevisions, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateCatalogTemplateRevision</c>.</summary>
        public override lro::OperationsClient CreateCatalogTemplateRevisionOperationsClient { get; }

        /// <summary>
        /// Creates a template revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CatalogTemplateRevision, OperationMetadata> CreateCatalogTemplateRevision(CreateCatalogTemplateRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCatalogTemplateRevisionRequest(ref request, ref callSettings);
            return new lro::Operation<CatalogTemplateRevision, OperationMetadata>(_callCreateCatalogTemplateRevision.Sync(request, callSettings), CreateCatalogTemplateRevisionOperationsClient);
        }

        /// <summary>
        /// Creates a template revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CatalogTemplateRevision, OperationMetadata>> CreateCatalogTemplateRevisionAsync(CreateCatalogTemplateRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCatalogTemplateRevisionRequest(ref request, ref callSettings);
            return new lro::Operation<CatalogTemplateRevision, OperationMetadata>(await _callCreateCatalogTemplateRevision.Async(request, callSettings).ConfigureAwait(false), CreateCatalogTemplateRevisionOperationsClient);
        }

        /// <summary>
        /// Gets details about a template revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CatalogTemplateRevision GetCatalogTemplateRevision(GetCatalogTemplateRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCatalogTemplateRevisionRequest(ref request, ref callSettings);
            return _callGetCatalogTemplateRevision.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details about a template revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CatalogTemplateRevision> GetCatalogTemplateRevisionAsync(GetCatalogTemplateRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCatalogTemplateRevisionRequest(ref request, ref callSettings);
            return _callGetCatalogTemplateRevision.Async(request, callSettings);
        }

        /// <summary>
        /// Lists template revisions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CatalogTemplateRevision"/> resources.</returns>
        public override gax::PagedEnumerable<ListCatalogTemplateRevisionsResponse, CatalogTemplateRevision> ListCatalogTemplateRevisions(ListCatalogTemplateRevisionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCatalogTemplateRevisionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCatalogTemplateRevisionsRequest, ListCatalogTemplateRevisionsResponse, CatalogTemplateRevision>(_callListCatalogTemplateRevisions, request, callSettings);
        }

        /// <summary>
        /// Lists template revisions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CatalogTemplateRevision"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCatalogTemplateRevisionsResponse, CatalogTemplateRevision> ListCatalogTemplateRevisionsAsync(ListCatalogTemplateRevisionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCatalogTemplateRevisionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCatalogTemplateRevisionsRequest, ListCatalogTemplateRevisionsResponse, CatalogTemplateRevision>(_callListCatalogTemplateRevisions, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteCatalogTemplateRevision</c>.</summary>
        public override lro::OperationsClient DeleteCatalogTemplateRevisionOperationsClient { get; }

        /// <summary>
        /// Deletes a template revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteCatalogTemplateRevision(DeleteCatalogTemplateRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCatalogTemplateRevisionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteCatalogTemplateRevision.Sync(request, callSettings), DeleteCatalogTemplateRevisionOperationsClient);
        }

        /// <summary>
        /// Deletes a template revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCatalogTemplateRevisionAsync(DeleteCatalogTemplateRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCatalogTemplateRevisionRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteCatalogTemplateRevision.Async(request, callSettings).ConfigureAwait(false), DeleteCatalogTemplateRevisionOperationsClient);
        }

        /// <summary>
        /// Creates an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Application CreateApplication(CreateApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateApplicationRequest(ref request, ref callSettings);
            return _callCreateApplication.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Application> CreateApplicationAsync(CreateApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateApplicationRequest(ref request, ref callSettings);
            return _callCreateApplication.Async(request, callSettings);
        }

        /// <summary>
        /// Gets details about an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Application GetApplication(GetApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetApplicationRequest(ref request, ref callSettings);
            return _callGetApplication.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details about an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Application> GetApplicationAsync(GetApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetApplicationRequest(ref request, ref callSettings);
            return _callGetApplication.Async(request, callSettings);
        }

        /// <summary>
        /// Lists applications in a given space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Application"/> resources.</returns>
        public override gax::PagedEnumerable<ListApplicationsResponse, Application> ListApplications(ListApplicationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListApplicationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListApplicationsRequest, ListApplicationsResponse, Application>(_callListApplications, request, callSettings);
        }

        /// <summary>
        /// Lists applications in a given space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Application"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListApplicationsResponse, Application> ListApplicationsAsync(ListApplicationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListApplicationsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListApplicationsRequest, ListApplicationsResponse, Application>(_callListApplications, request, callSettings);
        }

        /// <summary>
        /// Updates an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Application UpdateApplication(UpdateApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateApplicationRequest(ref request, ref callSettings);
            return _callUpdateApplication.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Application> UpdateApplicationAsync(UpdateApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateApplicationRequest(ref request, ref callSettings);
            return _callUpdateApplication.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteApplication</c>.</summary>
        public override lro::OperationsClient DeleteApplicationOperationsClient { get; }

        /// <summary>
        /// Deletes an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteApplication(DeleteApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteApplicationRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteApplication.Sync(request, callSettings), DeleteApplicationOperationsClient);
        }

        /// <summary>
        /// Deletes an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteApplicationAsync(DeleteApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteApplicationRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteApplication.Async(request, callSettings).ConfigureAwait(false), DeleteApplicationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeployApplication</c>.</summary>
        public override lro::OperationsClient DeployApplicationOperationsClient { get; }

        /// <summary>
        /// Deploys an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DeployApplicationResponse, OperationMetadata> DeployApplication(DeployApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeployApplicationRequest(ref request, ref callSettings);
            return new lro::Operation<DeployApplicationResponse, OperationMetadata>(_callDeployApplication.Sync(request, callSettings), DeployApplicationOperationsClient);
        }

        /// <summary>
        /// Deploys an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DeployApplicationResponse, OperationMetadata>> DeployApplicationAsync(DeployApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeployApplicationRequest(ref request, ref callSettings);
            return new lro::Operation<DeployApplicationResponse, OperationMetadata>(await _callDeployApplication.Async(request, callSettings).ConfigureAwait(false), DeployApplicationOperationsClient);
        }

        /// <summary>The long-running operations client for <c>PreviewApplication</c>.</summary>
        public override lro::OperationsClient PreviewApplicationOperationsClient { get; }

        /// <summary>
        /// Previews deployment of an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<PreviewApplicationResponse, OperationMetadata> PreviewApplication(PreviewApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PreviewApplicationRequest(ref request, ref callSettings);
            return new lro::Operation<PreviewApplicationResponse, OperationMetadata>(_callPreviewApplication.Sync(request, callSettings), PreviewApplicationOperationsClient);
        }

        /// <summary>
        /// Previews deployment of an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<PreviewApplicationResponse, OperationMetadata>> PreviewApplicationAsync(PreviewApplicationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PreviewApplicationRequest(ref request, ref callSettings);
            return new lro::Operation<PreviewApplicationResponse, OperationMetadata>(await _callPreviewApplication.Async(request, callSettings).ConfigureAwait(false), PreviewApplicationOperationsClient);
        }

        /// <summary>
        /// Fetches the assessment report of a deployed application if present.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FetchApplicationAssessmentReportResponse FetchApplicationAssessmentReport(FetchApplicationAssessmentReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchApplicationAssessmentReportRequest(ref request, ref callSettings);
            return _callFetchApplicationAssessmentReport.Sync(request, callSettings);
        }

        /// <summary>
        /// Fetches the assessment report of a deployed application if present.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FetchApplicationAssessmentReportResponse> FetchApplicationAssessmentReportAsync(FetchApplicationAssessmentReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchApplicationAssessmentReportRequest(ref request, ref callSettings);
            return _callFetchApplicationAssessmentReport.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>GenerateApplicationAssessmentReport</c>.</summary>
        public override lro::OperationsClient GenerateApplicationAssessmentReportOperationsClient { get; }

        /// <summary>
        /// Generate Assessment Reports of an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<GenerateApplicationAssessmentReportResponse, OperationMetadata> GenerateApplicationAssessmentReport(GenerateApplicationAssessmentReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateApplicationAssessmentReportRequest(ref request, ref callSettings);
            return new lro::Operation<GenerateApplicationAssessmentReportResponse, OperationMetadata>(_callGenerateApplicationAssessmentReport.Sync(request, callSettings), GenerateApplicationAssessmentReportOperationsClient);
        }

        /// <summary>
        /// Generate Assessment Reports of an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<GenerateApplicationAssessmentReportResponse, OperationMetadata>> GenerateApplicationAssessmentReportAsync(GenerateApplicationAssessmentReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateApplicationAssessmentReportRequest(ref request, ref callSettings);
            return new lro::Operation<GenerateApplicationAssessmentReportResponse, OperationMetadata>(await _callGenerateApplicationAssessmentReport.Async(request, callSettings).ConfigureAwait(false), GenerateApplicationAssessmentReportOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>GenerateApplicationTemplateAssessmentReport</c>.
        /// </summary>
        public override lro::OperationsClient GenerateApplicationTemplateAssessmentReportOperationsClient { get; }

        /// <summary>
        /// Generate Assessment Reports of an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<GenerateApplicationTemplateAssessmentReportResponse, OperationMetadata> GenerateApplicationTemplateAssessmentReport(GenerateApplicationTemplateAssessmentReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateApplicationTemplateAssessmentReportRequest(ref request, ref callSettings);
            return new lro::Operation<GenerateApplicationTemplateAssessmentReportResponse, OperationMetadata>(_callGenerateApplicationTemplateAssessmentReport.Sync(request, callSettings), GenerateApplicationTemplateAssessmentReportOperationsClient);
        }

        /// <summary>
        /// Generate Assessment Reports of an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<GenerateApplicationTemplateAssessmentReportResponse, OperationMetadata>> GenerateApplicationTemplateAssessmentReportAsync(GenerateApplicationTemplateAssessmentReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateApplicationTemplateAssessmentReportRequest(ref request, ref callSettings);
            return new lro::Operation<GenerateApplicationTemplateAssessmentReportResponse, OperationMetadata>(await _callGenerateApplicationTemplateAssessmentReport.Async(request, callSettings).ConfigureAwait(false), GenerateApplicationTemplateAssessmentReportOperationsClient);
        }

        /// <summary>The long-running operations client for <c>GenerateAssessmentReport</c>.</summary>
        public override lro::OperationsClient GenerateAssessmentReportOperationsClient { get; }

        /// <summary>
        /// Deprecated: Use GenerateTerraformPlanAssessmentReport instead.
        /// 
        /// Generate a best practice report for a given Terraform plan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public override lro::Operation<GenerateAssessmentReportResponse, OperationMetadata> GenerateAssessmentReport(GenerateAssessmentReportRequest request, gaxgrpc::CallSettings callSettings = null)
#pragma warning restore CS0612
        {
            Modify_GenerateAssessmentReportRequest(ref request, ref callSettings);
#pragma warning disable CS0612
            return new lro::Operation<GenerateAssessmentReportResponse, OperationMetadata>(_callGenerateAssessmentReport.Sync(request, callSettings), GenerateAssessmentReportOperationsClient);
#pragma warning restore CS0612
        }

        /// <summary>
        /// Deprecated: Use GenerateTerraformPlanAssessmentReport instead.
        /// 
        /// Generate a best practice report for a given Terraform plan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        [sys::ObsoleteAttribute]
#pragma warning disable CS0612
        public override async stt::Task<lro::Operation<GenerateAssessmentReportResponse, OperationMetadata>> GenerateAssessmentReportAsync(GenerateAssessmentReportRequest request, gaxgrpc::CallSettings callSettings = null)
#pragma warning restore CS0612
        {
            Modify_GenerateAssessmentReportRequest(ref request, ref callSettings);
#pragma warning disable CS0612
            return new lro::Operation<GenerateAssessmentReportResponse, OperationMetadata>(await _callGenerateAssessmentReport.Async(request, callSettings).ConfigureAwait(false), GenerateAssessmentReportOperationsClient);
#pragma warning restore CS0612
        }

        /// <summary>The long-running operations client for <c>GenerateTerraformPlanAssessmentReport</c>.</summary>
        public override lro::OperationsClient GenerateTerraformPlanAssessmentReportOperationsClient { get; }

        /// <summary>
        /// Generate a Terraform plan assessment report for a given Terraform plan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<GenerateTerraformPlanAssessmentReportResponse, OperationMetadata> GenerateTerraformPlanAssessmentReport(GenerateTerraformPlanAssessmentReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateTerraformPlanAssessmentReportRequest(ref request, ref callSettings);
            return new lro::Operation<GenerateTerraformPlanAssessmentReportResponse, OperationMetadata>(_callGenerateTerraformPlanAssessmentReport.Sync(request, callSettings), GenerateTerraformPlanAssessmentReportOperationsClient);
        }

        /// <summary>
        /// Generate a Terraform plan assessment report for a given Terraform plan.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<GenerateTerraformPlanAssessmentReportResponse, OperationMetadata>> GenerateTerraformPlanAssessmentReportAsync(GenerateTerraformPlanAssessmentReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateTerraformPlanAssessmentReportRequest(ref request, ref callSettings);
            return new lro::Operation<GenerateTerraformPlanAssessmentReportResponse, OperationMetadata>(await _callGenerateTerraformPlanAssessmentReport.Async(request, callSettings).ConfigureAwait(false), GenerateTerraformPlanAssessmentReportOperationsClient);
        }

        /// <summary>
        /// Policy related APIs.
        /// Get a policy for an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Policy GetPolicy(GetPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPolicyRequest(ref request, ref callSettings);
            return _callGetPolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Policy related APIs.
        /// Get a policy for an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Policy> GetPolicyAsync(GetPolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPolicyRequest(ref request, ref callSettings);
            return _callGetPolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Lists policies for an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Policy"/> resources.</returns>
        public override gax::PagedEnumerable<ListPoliciesResponse, Policy> ListPolicies(ListPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPoliciesRequest, ListPoliciesResponse, Policy>(_callListPolicies, request, callSettings);
        }

        /// <summary>
        /// Lists policies for an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Policy"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPoliciesResponse, Policy> ListPoliciesAsync(ListPoliciesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPoliciesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPoliciesRequest, ListPoliciesResponse, Policy>(_callListPolicies, request, callSettings);
        }

        /// <summary>
        /// Creates a policy for an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Policy CreatePolicy(CreatePolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePolicyRequest(ref request, ref callSettings);
            return _callCreatePolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a policy for an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Policy> CreatePolicyAsync(CreatePolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePolicyRequest(ref request, ref callSettings);
            return _callCreatePolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Policy UpdatePolicy(UpdatePolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePolicyRequest(ref request, ref callSettings);
            return _callUpdatePolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Policy> UpdatePolicyAsync(UpdatePolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePolicyRequest(ref request, ref callSettings);
            return _callUpdatePolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeletePolicy(DeletePolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePolicyRequest(ref request, ref callSettings);
            _callDeletePolicy.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a policy.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeletePolicyAsync(DeletePolicyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePolicyRequest(ref request, ref callSettings);
            return _callDeletePolicy.Async(request, callSettings);
        }

        /// <summary>
        /// Fetches all frameworks for assessment report.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Framework"/> resources.</returns>
        public override gax::PagedEnumerable<FetchFrameworksResponse, Framework> FetchFrameworks(FetchFrameworksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchFrameworksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<FetchFrameworksRequest, FetchFrameworksResponse, Framework>(_callFetchFrameworks, request, callSettings);
        }

        /// <summary>
        /// Fetches all frameworks for assessment report.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Framework"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<FetchFrameworksResponse, Framework> FetchFrameworksAsync(FetchFrameworksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchFrameworksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<FetchFrameworksRequest, FetchFrameworksResponse, Framework>(_callFetchFrameworks, request, callSettings);
        }

        /// <summary>
        /// Generates Terraform files for an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateApplicationIaCResponse GenerateApplicationIaC(GenerateApplicationIaCRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateApplicationIaCRequest(ref request, ref callSettings);
            return _callGenerateApplicationIaC.Sync(request, callSettings);
        }

        /// <summary>
        /// Generates Terraform files for an application.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateApplicationIaCResponse> GenerateApplicationIaCAsync(GenerateApplicationIaCRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateApplicationIaCRequest(ref request, ref callSettings);
            return _callGenerateApplicationIaC.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>ExportApplicationIaC</c>.</summary>
        public override lro::OperationsClient ExportApplicationIaCOperationsClient { get; }

        /// <summary>
        /// Exports Terraform files for an application asynchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ExportApplicationIaCResponse, OperationMetadata> ExportApplicationIaC(ExportApplicationIaCRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportApplicationIaCRequest(ref request, ref callSettings);
            return new lro::Operation<ExportApplicationIaCResponse, OperationMetadata>(_callExportApplicationIaC.Sync(request, callSettings), ExportApplicationIaCOperationsClient);
        }

        /// <summary>
        /// Exports Terraform files for an application asynchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ExportApplicationIaCResponse, OperationMetadata>> ExportApplicationIaCAsync(ExportApplicationIaCRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportApplicationIaCRequest(ref request, ref callSettings);
            return new lro::Operation<ExportApplicationIaCResponse, OperationMetadata>(await _callExportApplicationIaC.Async(request, callSettings).ConfigureAwait(false), ExportApplicationIaCOperationsClient);
        }

        /// <summary>
        /// Imports IaC for an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ImportApplicationTemplateIaCResponse ImportApplicationTemplateIaC(ImportApplicationTemplateIaCRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportApplicationTemplateIaCRequest(ref request, ref callSettings);
            return _callImportApplicationTemplateIaC.Sync(request, callSettings);
        }

        /// <summary>
        /// Imports IaC for an application template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ImportApplicationTemplateIaCResponse> ImportApplicationTemplateIaCAsync(ImportApplicationTemplateIaCRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportApplicationTemplateIaCRequest(ref request, ref callSettings);
            return _callImportApplicationTemplateIaC.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>IngestApplicationTemplateIaC</c>.</summary>
        public override lro::OperationsClient IngestApplicationTemplateIaCOperationsClient { get; }

        /// <summary>
        /// Ingests IaC for an application template asynchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<IngestApplicationTemplateIaCResponse, OperationMetadata> IngestApplicationTemplateIaC(IngestApplicationTemplateIaCRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_IngestApplicationTemplateIaCRequest(ref request, ref callSettings);
            return new lro::Operation<IngestApplicationTemplateIaCResponse, OperationMetadata>(_callIngestApplicationTemplateIaC.Sync(request, callSettings), IngestApplicationTemplateIaCOperationsClient);
        }

        /// <summary>
        /// Ingests IaC for an application template asynchronously.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<IngestApplicationTemplateIaCResponse, OperationMetadata>> IngestApplicationTemplateIaCAsync(IngestApplicationTemplateIaCRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_IngestApplicationTemplateIaCRequest(ref request, ref callSettings);
            return new lro::Operation<IngestApplicationTemplateIaCResponse, OperationMetadata>(await _callIngestApplicationTemplateIaC.Async(request, callSettings).ConfigureAwait(false), IngestApplicationTemplateIaCOperationsClient);
        }

        /// <summary>
        /// Imports IaC for an application resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ImportApplicationIaCResponse ImportApplicationIaC(ImportApplicationIaCRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportApplicationIaCRequest(ref request, ref callSettings);
            return _callImportApplicationIaC.Sync(request, callSettings);
        }

        /// <summary>
        /// Imports IaC for an application resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ImportApplicationIaCResponse> ImportApplicationIaCAsync(ImportApplicationIaCRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportApplicationIaCRequest(ref request, ref callSettings);
            return _callImportApplicationIaC.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>RegisterAppHubApplicationResources</c>.</summary>
        public override lro::OperationsClient RegisterAppHubApplicationResourcesOperationsClient { get; }

        /// <summary>
        /// Register deployed resources from terraform state file with App Hub
        /// without needing a space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<RegisterAppHubApplicationResourcesResponse, OperationMetadata> RegisterAppHubApplicationResources(RegisterAppHubApplicationResourcesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RegisterAppHubApplicationResourcesRequest(ref request, ref callSettings);
            return new lro::Operation<RegisterAppHubApplicationResourcesResponse, OperationMetadata>(_callRegisterAppHubApplicationResources.Sync(request, callSettings), RegisterAppHubApplicationResourcesOperationsClient);
        }

        /// <summary>
        /// Register deployed resources from terraform state file with App Hub
        /// without needing a space.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<RegisterAppHubApplicationResourcesResponse, OperationMetadata>> RegisterAppHubApplicationResourcesAsync(RegisterAppHubApplicationResourcesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RegisterAppHubApplicationResourcesRequest(ref request, ref callSettings);
            return new lro::Operation<RegisterAppHubApplicationResourcesResponse, OperationMetadata>(await _callRegisterAppHubApplicationResources.Async(request, callSettings).ConfigureAwait(false), RegisterAppHubApplicationResourcesOperationsClient);
        }

        /// <summary>
        /// Lists application template system revisions in a given application
        /// template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ApplicationTemplateSystemRevision"/> resources.</returns>
        public override gax::PagedEnumerable<ListApplicationTemplateSystemRevisionsResponse, ApplicationTemplateSystemRevision> ListApplicationTemplateSystemRevisions(ListApplicationTemplateSystemRevisionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListApplicationTemplateSystemRevisionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListApplicationTemplateSystemRevisionsRequest, ListApplicationTemplateSystemRevisionsResponse, ApplicationTemplateSystemRevision>(_callListApplicationTemplateSystemRevisions, request, callSettings);
        }

        /// <summary>
        /// Lists application template system revisions in a given application
        /// template.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ApplicationTemplateSystemRevision"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListApplicationTemplateSystemRevisionsResponse, ApplicationTemplateSystemRevision> ListApplicationTemplateSystemRevisionsAsync(ListApplicationTemplateSystemRevisionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListApplicationTemplateSystemRevisionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListApplicationTemplateSystemRevisionsRequest, ListApplicationTemplateSystemRevisionsResponse, ApplicationTemplateSystemRevision>(_callListApplicationTemplateSystemRevisions, request, callSettings);
        }

        /// <summary>
        /// Gets the given application template system revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ApplicationTemplateSystemRevision GetApplicationTemplateSystemRevision(GetApplicationTemplateSystemRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetApplicationTemplateSystemRevisionRequest(ref request, ref callSettings);
            return _callGetApplicationTemplateSystemRevision.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the given application template system revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ApplicationTemplateSystemRevision> GetApplicationTemplateSystemRevisionAsync(GetApplicationTemplateSystemRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetApplicationTemplateSystemRevisionRequest(ref request, ref callSettings);
            return _callGetApplicationTemplateSystemRevision.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>RecommendIAMRoles</c>.</summary>
        public override lro::OperationsClient RecommendIAMRolesOperationsClient { get; }

        /// <summary>
        /// Gets recommended IAM roles for an application.
        /// 
        /// Evaluates the infrastructure resources defined by an application (including
        /// its template configuration and parameters) to determine the set of IAM
        /// roles and Google Cloud APIs that you must configure before you deploy
        /// across target projects.
        /// 
        /// The operation is asynchronous and returns a `google.longrunning.Operation`.
        /// Upon completion, the operation result contains a
        /// `RecommendIAMRolesResponse` with project-level IAM role and API
        /// recommendations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<RecommendIAMRolesResponse, OperationMetadata> RecommendIAMRoles(RecommendIAMRolesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RecommendIAMRolesRequest(ref request, ref callSettings);
            return new lro::Operation<RecommendIAMRolesResponse, OperationMetadata>(_callRecommendIAMRoles.Sync(request, callSettings), RecommendIAMRolesOperationsClient);
        }

        /// <summary>
        /// Gets recommended IAM roles for an application.
        /// 
        /// Evaluates the infrastructure resources defined by an application (including
        /// its template configuration and parameters) to determine the set of IAM
        /// roles and Google Cloud APIs that you must configure before you deploy
        /// across target projects.
        /// 
        /// The operation is asynchronous and returns a `google.longrunning.Operation`.
        /// Upon completion, the operation result contains a
        /// `RecommendIAMRolesResponse` with project-level IAM role and API
        /// recommendations.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<RecommendIAMRolesResponse, OperationMetadata>> RecommendIAMRolesAsync(RecommendIAMRolesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RecommendIAMRolesRequest(ref request, ref callSettings);
            return new lro::Operation<RecommendIAMRolesResponse, OperationMetadata>(await _callRecommendIAMRoles.Async(request, callSettings).ConfigureAwait(false), RecommendIAMRolesOperationsClient);
        }
    }

    public partial class ListSpacesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListApplicationTemplatesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListComponentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListConnectionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListApplicationTemplateRevisionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCatalogsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCatalogTemplatesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSharesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSharedTemplatesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSharedTemplateRevisionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCatalogTemplateRevisionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListApplicationsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPoliciesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class FetchFrameworksRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListApplicationTemplateSystemRevisionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSpacesResponse : gaxgrpc::IPageResponse<Space>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Space> GetEnumerator() => Spaces.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListApplicationTemplatesResponse : gaxgrpc::IPageResponse<ApplicationTemplate>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ApplicationTemplate> GetEnumerator() => ApplicationTemplates.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListComponentsResponse : gaxgrpc::IPageResponse<Component>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Component> GetEnumerator() => Components.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListConnectionsResponse : gaxgrpc::IPageResponse<Connection>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Connection> GetEnumerator() => Connections.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListApplicationTemplateRevisionsResponse : gaxgrpc::IPageResponse<ApplicationTemplateRevision>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ApplicationTemplateRevision> GetEnumerator() =>
            ApplicationTemplateRevisions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListCatalogsResponse : gaxgrpc::IPageResponse<Catalog>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Catalog> GetEnumerator() => Catalogs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListCatalogTemplatesResponse : gaxgrpc::IPageResponse<CatalogTemplate>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CatalogTemplate> GetEnumerator() => CatalogTemplates.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSharesResponse : gaxgrpc::IPageResponse<Share>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Share> GetEnumerator() => Shares.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSharedTemplatesResponse : gaxgrpc::IPageResponse<SharedTemplate>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<SharedTemplate> GetEnumerator() => SharedTemplates.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSharedTemplateRevisionsResponse : gaxgrpc::IPageResponse<SharedTemplateRevision>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<SharedTemplateRevision> GetEnumerator() => SharedTemplateRevisions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListCatalogTemplateRevisionsResponse : gaxgrpc::IPageResponse<CatalogTemplateRevision>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CatalogTemplateRevision> GetEnumerator() => CatalogTemplateRevisions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListApplicationsResponse : gaxgrpc::IPageResponse<Application>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Application> GetEnumerator() => Applications.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListPoliciesResponse : gaxgrpc::IPageResponse<Policy>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Policy> GetEnumerator() => Policies.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class FetchFrameworksResponse : gaxgrpc::IPageResponse<Framework>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Framework> GetEnumerator() => Frameworks.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListApplicationTemplateSystemRevisionsResponse : gaxgrpc::IPageResponse<ApplicationTemplateSystemRevision>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ApplicationTemplateSystemRevision> GetEnumerator() =>
            ApplicationTemplateSystemRevisions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class DesignCenter
    {
        public partial class DesignCenterClient
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

    public static partial class DesignCenter
    {
        public partial class DesignCenterClient
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
